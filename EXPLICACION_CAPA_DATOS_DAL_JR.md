# Guía Conceptual y Técnica: ¿Para qué sirven los archivos `*Dal.cs` en `MobileSolutions.DataLayer`?
*(Explicación nivel Desarrollador Jr para exposición en clase — Caso práctico: `CustomerDal.cs`)*

---

## 1. ¿Qué significa `DAL` y cuál es su rol en la Arquitectura en 3 Capas?

**DAL** significa **Data Access Layer** (*Capa de Acceso a Datos*). En nuestro proyecto `MobileSolutions`, todos los archivos que terminan en `*Dal.cs` (`CustomerDal.cs`, `ProductDal.cs`, `SaleDal.cs`, `UserDal.cs`, etc.) tienen **una única misión**:

> **Ser el "Traductor y Mensajero" exclusivo entre el código C# (Objetos) y el motor SQL Server (Tablas y Stored Procedures).**

### La Analogía del Restaurante (Ideal para explicar en clase)
Imagina que nuestro sistema es un restaurante dividido en 3 sectores:
1. **`MobileSolutions.UILayer` (El Mozo / Formularios Windows Forms)**:
   - Muestra los botones, grillas (`DataGridView`) y cajas de texto al usuario. **No sabe cocinar ni sabe hablar SQL**.
2. **`MobileSolutions.BusinessLayer` (El Chef / `*Service.cs` como `CustomerService.cs`)**:
   - Conoce las **reglas del negocio** (por ejemplo: *"el DNI debe tener entre 7 y 8 dígitos"*, *"el email debe tener `@`"*). Si algo está mal antes de ir a la base de datos, lo frena ahí mismo.
3. **`MobileSolutions.DataLayer` (El Encargado de Despensa / `*Dal.cs` como `CustomerDal.cs`)**:
   - Es el **único** que tiene la llave de la base de datos (`DatabaseConnection.cs`).
   - Recibe un objeto `Customer` de C#, abre la conexión a SQL Server, ejecuta el Procedimiento Almacenado (`Stored Procedure`), y cuando SQL Server devuelve filas, las transforma ("mapea") en una lista `List<Customer>` para devolvérsela al Chef (`CustomerService`).

```
[ UILayer (Vista WinForms) ]
          │  Pide o envía un objeto Customer
          ▼
[ BusinessLayer (CustomerService.cs) ]  <-- Valida formato (DNI 7-8 dígitos, Email, Nulos)
          │  Llama a _customerDal
          ▼
[ DataLayer (CustomerDal.cs) ]          <-- Traduce C# a SQLParameters, abre conexión y mapea
          │  Ejecuta Stored Procedure (ADO.NET)
          ▼
[ SQL Server (CustomerSP.sql + Tabla Customer) ] <-- Valida CHECKs, UNIQUEs e Índices
```

---

## 2. Anatomía Técnica de `CustomerDal.cs` (Explicado bloque por bloque)

Si abrimos `MobileSolutions.DataLayer\CustomerDal.cs`, veremos que utiliza **ADO.NET** (`Microsoft.Data.SqlClient`), que es la tecnología nativa y más rápida de .NET para comunicarse con SQL Server. Se divide en 3 partes clave:

### A. El Conector (`_dbConnection`)
```csharp
private readonly DatabaseConnection _dbConnection;

public CustomerDal()
{
    _dbConnection = new DatabaseConnection();
}
```
- `CustomerDal` no tiene escrita la cadena de conexión (`Server=(localdb)\MSSQLLocalDB...`). Se la pide a `DatabaseConnection.cs`. Si mañana cambiamos de servidor SQL, solo tocamos `DatabaseConnection.cs` y todos los `*Dal.cs` siguen funcionando.

### B. Los Métodos de Lectura (`SELECT` con `SqlDataReader`)
Métodos como `GetActiveCustomers()` o `SearchActiveCustomers(string? searchTerm)`:
1. Usan bloques **`using (...)`** para asegurar que, pase lo que pase (incluso si ocurre un error), la conexión a SQL Server **se cierre y libere la memoria automáticamente**.
2. Configuran `command.CommandType = CommandType.StoredProcedure;` para indicar que no enviamos un `SELECT *` suelto, sino que invocamos un procedimiento precompilado en SQL Server (`sp_GetActiveCustomers`).
3. Ejecutan `command.ExecuteReader()`, que abre un **cursor de lectura rápida hacia adelante** (`SqlDataReader`) fila por fila.

### C. Los Métodos de Escritura (`INSERT`, `UPDATE`, `SoftDelete`, `Reactivate`)
Aquí aparece una diferencia técnica fundamental que suelen preguntar en los exámenes: **¿Cuándo se usa `ExecuteScalar()` y cuándo `ExecuteNonQuery()`?**

| Método en `CustomerDal.cs` | Método de ADO.NET que usa | ¿Por qué usa ese método? |
| :--- | :--- | :--- |
| **`CreateCustomer`** (`INSERT`) | **`command.ExecuteScalar()`** | Porque el Stored Procedure `sp_CreateCustomer` termina con `SELECT SCOPE_IDENTITY() AS NewCustomerId;`. `ExecuteScalar()` recupera **ese único valor** (primera fila, primera columna): el ID autogenerado del nuevo cliente. |
| **`UpdateCustomer`**, **`SoftDeleteCustomer`**, **`ReactivateCustomer`** (`UPDATE`) | **`command.ExecuteNonQuery()`** | Porque un `UPDATE` no devuelve una tabla de datos, sino el **número entero de filas afectadas** (`int rowsAffected`). Si `rowsAffected > 0`, sabemos que el cambio se guardó con éxito. |

---

## 3. ¿Qué Validaciones tiene `CustomerDal.cs` y Cómo se Aplican? (Defensa en Profundidad)

En nuestro proyecto las validaciones están organizadas en **3 anillos de seguridad** (desde C# hasta el motor SQL Server). En `CustomerDal.cs` específicamente se aplican **6 validaciones y protecciones técnicas**:

### Validación 1: Prevención de Inyección SQL mediante Parámetros Tipados (`SqlParameter`)
En `SearchActiveCustomers` y `CreateCustomer`, **jamás concatenamos strings** (nunca hacemos `"EXEC sp_Search '" + searchTerm + "'"`). En su lugar hacemos:
```csharp
command.Parameters.Add(new SqlParameter("@SearchTerm", SqlDbType.NVarChar, 100)
{
    Value = dbValue
});
```
- **¿Qué valida y protege?** Define el tipo exacto (`VarChar` / `NVarChar` / `Int` / `Date`) y el largo máximo (`8` para DNI, `100` para nombre). Si alguien escribe código malicioso como `' OR 1=1; DROP TABLE Customer--` en el buscador, SQL Server lo trata como texto literal inofensivo y no como un comando ejecutable.

### Validación 2: Normalización de Nulos de C# a `DBNull.Value` de SQL
En C# existe `null`, pero SQL Server no entiende el `null` de C#; exige un objeto especial llamado **`DBNull.Value`**.
- **En búsquedas (`SearchActiveCustomers`, líneas 176-178)**:
  ```csharp
  object dbValue = string.IsNullOrWhiteSpace(searchTerm) ? DBNull.Value : searchTerm.Trim();
  ```
  Si el usuario dejó la barra de búsqueda vacía o con puros espacios, envía `NULL` al Stored Procedure y les quita los espacios sobrantes (`.Trim()`).
- **En campos opcionales (`CreateCustomer`, líneas 299-300)**:
  ```csharp
  command.Parameters.Add("@phone", SqlDbType.VarChar, 15).Value = (object?)customer.Phone ?? DBNull.Value;
  ```
  Usa el operador de coalescencia nula (`??`): si `Phone` o `Address` vienen vacíos (`null`), los convierte en `DBNull.Value` para que SQL Server guarde `NULL` sin lanzar excepción.

### Validación 3: Guard Clause contra Objetos Nulos (`ArgumentNullException`)
En `CreateCustomer` y `UpdateCustomer` (líneas 285 y 313):
```csharp
if (customer == null)
    throw new ArgumentNullException(nameof(customer));
```
- Evita que el método intente abrir una conexión a la base de datos si por error desde otra capa le enviaron un objeto `Customer` nulo (`NullReferenceException`).

### Validación 4: Mapeo Seguro de Columnas (`GetOrdinalSafe` y `IsDBNull`)
Cuando SQL Server devuelve resultados en `SqlDataReader`, `CustomerDal.cs` aplica dos validaciones defensivas en `GetOrdinalSafe` y `MapCustomerFromReader` (líneas 20-66):
1. **`GetOrdinalSafe(reader, "Nombre", "name")`**: Busca la posición (índice numérico) de la columna probando tanto el alias en español (`"Nombre"`) como el nombre físico en inglés (`"name"`). Además, lo calcula **antes de entrar al `while (reader.Read())`**, lo cual es mucho más rápido que buscar el nombre de la columna por cada fila.
2. **`!reader.IsDBNull(ordPhone)`**: Antes de leer un string o fecha con `reader.GetString(...)`, verifica que la celda en SQL no sea `NULL`. Si es `NULL`, asigna `null` o `string.Empty` sin que la aplicación explote con `SqlNullValueException`.

### Validación 5: Control de Tiempo Límite (`CommandTimeout = 30`)
En todos los métodos verás:
```csharp
command.CommandTimeout = 30;
```
- **¿Para qué sirve?** Si la base de datos estuviera bloqueada o saturada, evita que la pantalla de Windows Forms quede "congelada" para siempre; a los 30 segundos corta y devuelve un error controlado.

### Validación 6: Cómo se complementa con `CustomerService.cs` y con SQL Server (`CustomerSP.sql` + `CreateDB.sql`)
Para explicarlo completo en clase, muestra cómo viaja un dato por las 3 capas:
1. **`CustomerService.cs` (Capa de Negocio)**: Valida rápido en memoria que Nombre/Apellido no estén vacíos, que el DNI tenga 7 u 8 caracteres y que el Email tenga `@`. Además, en su `catch (SqlException ex)` captura los errores **`2627` y `2601`** (violación de `UNIQUE`) para traducirlos a un mensaje amigable: *"Ya existe un Cliente con ese número de DNI"*.
2. **`CustomerDal.cs` (Capa de Datos)**: Valida `ArgumentNullException`, limpia nulos con `DBNull.Value`, parametriza tipos y largos (`SqlDbType.VarChar, 8`), y verifica si `rowsAffected > 0`.
3. **`CustomerSP.sql` y Tabla `Customer` (Motor SQL)**:
   - El Stored Procedure valida que el cliente sea **mayor de 18 años** (`IF @birth > DATEADD(YEAR, -18, GETDATE()) RAISERROR(...)`).
   - La tabla `Customer` tiene restricciones físicas inquebrantables (`CONSTRAINT`):
     - `PK_Customer`: Clave primaria (`customer_id`).
     - `UQ_Customer_DNI` y `UQ_Customer_Email`: No permite dos clientes con el mismo DNI o Email.
     - `CHK_Customer_Sex`: Solo permite `'Masculino'`, `'Femenino'` u `'Otro'`.
     - `CHK_Customer_Email`: Valida patrón `LIKE '%_@_%.%'`.

---

## 4. ¿Son Indexadas las Consultas de `CustomerDal.cs`? (Análisis Real de Índices en SQL Server)

Esta es una **excelente pregunta técnica para lucirse en clase**. La respuesta exacta es: **Algunas consultas usan búsqueda directa por índice (*Index Seek*, rapidísimo) y otras hacen recorrido del índice (*Index Scan*), dependiendo de qué columna use el `WHERE`**.

### 4.1. ¿Qué índices existen hoy en nuestra tabla `Customer`?
En SQL Server (`CreateDB.sql`, líneas 50-52), al declarar una `PRIMARY KEY` y restricciones `UNIQUE`, **SQL Server crea automáticamente 3 índices físicos (árboles B-Tree)** en la tabla `Customer`:

| Nombre del Índice en SQL Server | Tipo de Índice | Columna Indexada | ¿Cómo se creó? |
| :--- | :--- | :--- | :--- |
| **`PK_Customer`** | **`CLUSTERED` (Agrupado)** | `customer_id` | Automáticamente por `PRIMARY KEY (customer_id)`. Ordena físicamente las filas de la tabla por ID. |
| **`UQ_Customer_DNI`** | **`NONCLUSTERED` (No agrupado, Único)** | `dni` | Automáticamente por `CONSTRAINT UQ_Customer_DNI UNIQUE (dni)`. |
| **`UQ_Customer_Email`** | **`NONCLUSTERED` (No agrupado, Único)** | `email` | Automáticamente por `CONSTRAINT UQ_Customer_Email UNIQUE (email)`. |

---

### 4.2. Consulta por Consulta: ¿Cuáles aprovechan los índices y cómo?

#### Caso 1: `UpdateCustomer`, `SoftDeleteCustomer` y `ReactivateCustomer` $\rightarrow$ **¡SÍ! 100% Indexadas (`Clustered Index Seek`)**
- **Consulta en SQL**:
  ```sql
  UPDATE Customer SET status = 0 WHERE customer_id = @customer_id;
  ```
- **¿Cómo actúa el índice?** Como busca por `WHERE customer_id = @customer_id` y `customer_id` tiene el índice **`PK_Customer (CLUSTERED)`**, SQL Server hace un **Clustered Index Seek**: va directo al registro en milisegundos sin leer el resto de la tabla (complejidad $O(\log N)$).

#### Caso 2: `CreateCustomer` (`INSERT`) $\rightarrow$ **Usa los índices `UNIQUE` para validar duplicados al instante**
- Cuando insertas un cliente nuevo, SQL Server tiene que verificar que el `@dni` y el `@email` no estén repetidos.
- Gracias a los índices **`UQ_Customer_DNI`** y **`UQ_Customer_Email`**, SQL Server comprueba si ya existen haciendo un **Index Seek** instantáneo sobre ambos árboles B-Tree. Si ya existen, lanza el error `2627` que atrapa `CustomerService.cs`.

#### Caso 3: `GetActiveCustomers` y `GetInactiveCustomers` $\rightarrow$ **Hacen `Clustered Index Scan` + `Sort`**
- **Consulta en SQL**:
  ```sql
  SELECT ... FROM Customer WHERE status = 1 ORDER BY lastname ASC, name ASC;
  ```
- **¿Por qué hace Scan y no Seek?** Porque no hay un índice creado sobre la columna `(status, lastname, name)`. Además, `status` es un campo `BIT` (solo vale `1` o `0`, baja selectividad: casi todos los clientes están activos). Por lo tanto, SQL Server recorre la tabla (`Clustered Index Scan`), filtra los que tienen `status = 1` y los ordena en memoria por apellido y nombre.

#### Caso 4: `SearchActiveCustomers` y `SearchInactiveCustomers` $\rightarrow$ **Hacen `Clustered Index Scan` por el comodín inicial `'%'`**
- **Consulta en SQL**:
  ```sql
  WHERE c.status = 1
    AND (c.name LIKE '%' + @SearchTerm + '%'
         OR c.dni LIKE '%' + @SearchTerm + '%'
         OR c.email LIKE '%' + @SearchTerm + '%' ...)
  ```
- **Explicación clave para el profesor**:
  Aunque `dni` y `email` **sí tienen índice** (`UQ_Customer_DNI` y `UQ_Customer_Email`), cuando en SQL escribimos **`LIKE '%texto%'`** con el signo `%` **adelante** (comodín a la izquierda), el árbol B-Tree del índice no puede usarse para saltar directo (igual que en un diccionario de papel no puedes buscar rápido todas las palabras que *terminen* o *contengan* `"ez"` en el medio; tienes que leer todas las páginas).
  - En inglés técnico esto se llama consulta **Non-SARGable** (*Non-Search Argument Able*).
  - **¿Es un problema en nuestro proyecto?** Para miles de clientes en una tienda local, un `Scan` en memoria tarda menos de 2 milisegundos y ofrece la gran ventaja de encontrar coincidencias parciales en cualquier parte del nombre, DNI, teléfono o localidad.
  - **¿Cómo se haría 100% indexada si tuviéramos 10 millones de clientes?**
    1. Usando prefijos sin `%` al inicio (`c.dni LIKE @SearchTerm + '%'`), lo que sí habilita un `Index Seek` en `UQ_Customer_DNI`.
    2. Creando un índice compuesto no agrupado para el listado activo:
       ```sql
       CREATE NONCLUSTERED INDEX IX_Customer_Status_Lastname_Name
       ON Customer (status, lastname ASC, name ASC);
       ```

---

## 5. Resumen Ejecutivo de 1 Minuto (Chuleta para decir en Clase)

1. **¿Qué son los `*Dal.cs`?** Son las clases de la **Capa de Acceso a Datos (DAL)**. Usan **ADO.NET (`Microsoft.Data.SqlClient`)** para ejecutar **Stored Procedures** en SQL Server y transformar las filas devueltas (`SqlDataReader`) en objetos de C# (`Customer`).
2. **¿Qué validaciones aplican?**
   - En **`CustomerDal.cs`**: validan que el objeto no sea nulo (`ArgumentNullException`), convierten strings vacíos o `null` a `DBNull.Value`, usan parámetros tipados (`SqlParameter`) para bloquear **Inyección SQL**, leen columnas de forma segura (`GetOrdinalSafe` + `IsDBNull`) y verifican filas afectadas.
   - Trabajan en equipo con **`CustomerService.cs`** (que valida reglas de formato y atrapa errores SQL `2627`/`2601` de duplicados) y con **SQL Server** (que valida mayoría de edad `+18` en el SP y restricciones `PRIMARY KEY`, `UNIQUE` y `CHECK` en la tabla).
3. **¿Son indexadas las consultas?**
   - **Sí** en modificaciones, bajas lógicas, reactivaciones y validación de duplicados: aprovechan el índice agrupado **`PK_Customer` (`customer_id`)** y los índices únicos no agrupados **`UQ_Customer_DNI`** y **`UQ_Customer_Email`** mediante *Index Seek*.
   - En las búsquedas generales con `LIKE '%termino%'`, SQL Server realiza un *Clustered Index Scan* porque el comodín `%` al inicio busca subcadenas en cualquier posición de 7 columnas distintas.


---

## 6. Ejemplo Práctico Detallado: Cómo funciona `MapProductFromReader` en `ProductDal.cs`

En `MobileSolutions.DataLayer\ProductDal.cs` (líneas 33-57) encontramos este método:

```csharp
private static Product MapProductFromReader(
    SqlDataReader reader,
    int ordProductId,
    int ordBrandId,
    int ordBrandName,
    int ordProductCode,
    int ordName,
    int ordStock,
    int ordPurchasePrice,
    int ordSalePrice,
    int ordImage)
{
    return new Product
    {
        ProductId = ordProductId >= 0 && !reader.IsDBNull(ordProductId) ? reader.GetInt32(ordProductId) : 0,
        BrandId = ordBrandId >= 0 && !reader.IsDBNull(ordBrandId) ? reader.GetInt32(ordBrandId) : 0,
        BrandName = ordBrandName >= 0 && !reader.IsDBNull(ordBrandName) ? reader.GetString(ordBrandName) : string.Empty,
        ProductCode = ordProductCode >= 0 && !reader.IsDBNull(ordProductCode) ? reader.GetString(ordProductCode) : string.Empty,
        Name = ordName >= 0 && !reader.IsDBNull(ordName) ? reader.GetString(ordName) : string.Empty,
        Stock = ordStock >= 0 && !reader.IsDBNull(ordStock) ? reader.GetInt32(ordStock) : 0,
        PurchasePrice = ordPurchasePrice >= 0 && !reader.IsDBNull(ordPurchasePrice) ? reader.GetDecimal(ordPurchasePrice) : 0m,
        SalePrice = ordSalePrice >= 0 && !reader.IsDBNull(ordSalePrice) ? reader.GetDecimal(ordSalePrice) : 0m,
        Image = ordImage >= 0 && !reader.IsDBNull(ordImage) ? reader.GetString(ordImage) : null
    };
}
```

### 6.1. ¿Qué hace este método en palabras simples?
Cuando SQL Server ejecuta `sp_GetActiveProducts`, devuelve una **tabla cruda**. Pero Windows Forms y nuestra capa de negocio (`ProductService`) no trabajan con filas sueltas de SQL, sino con objetos de la clase **`Product`**.
- **"Mapear" (`MapProductFromReader`)** significa: **tomar la fila actual donde está parado el `SqlDataReader` y convertirla en un objeto `new Product { ... }` de C#**.

### 6.2. ¿Qué son los parámetros `int ord...` (Ordinales)?
Cuando SQL Server devuelve las columnas del `SELECT` (en `ProductSP.sql`):
- Columna `0`: `product_id`
- Columna `1`: `brand_id`
- Columna `2`: `Marca` (`BrandName`)
- Columna `3`: `Codigo` (`ProductCode`)
- ...
- Columna `8`: `Imagen` (`Image`)

Ese número de posición (`0, 1, 2, ..., 8`) se llama **Ordinal**.
Antes de empezar a recorrer las filas con `while (reader.Read())`, el método `GetOrdinalSafe` averigua qué número de columna le tocó a cada dato (y si alguna columna no vino en el `SELECT`, devuelve **`-1`**).

### 6.3. Desglose de una línea paso a paso (El Operador Ternario `? :`)
Miremos cómo se arma cada propiedad, por ejemplo `PurchasePrice` o `Image`:

```csharp
PurchasePrice = ordPurchasePrice >= 0 && !reader.IsDBNull(ordPurchasePrice)
    ? reader.GetDecimal(ordPurchasePrice)
    : 0m,
```

Esta línea usa un **operador condicional ternario (`condición ? valor_si_es_true : valor_si_es_false`)** con **dos escudos de seguridad** antes de leer el dato:

1. **Primer escudo (`ordPurchasePrice >= 0`)**:
   - Verifica que la columna realmente exista en el resultado del `SELECT`.
   - Si alguien modificó el Stored Procedure y olvidó incluir la columna, `ordPurchasePrice` valdrá `-1`. Gracias a `>= 0`, el código **no explota** con `IndexOutOfRangeException`.
2. **Segundo escudo (`&& !reader.IsDBNull(ordPurchasePrice)`)**:
   - Verifica que el valor guardado en esa celda de SQL Server **no sea `NULL`**.
   - Por ejemplo, en la tabla `Product`, la columna `image VARCHAR(255) NULL` permite valores nulos (productos sin foto). Si intentáramos hacer `reader.GetString(ordImage)` directamente sobre un `NULL` de SQL, C# lanzaría un error fatal (`SqlNullValueException`).
3. **Lectura tipada (`? reader.GetDecimal(...)` / `reader.GetInt32(...)` / `reader.GetString(...)`)**:
   - Si pasó ambos escudos, lee el dato con su tipo nativo exacto:
     - `GetInt32` $\rightarrow$ para `int` (`ProductId`, `BrandId`, `Stock`).
     - `GetString` $\rightarrow$ para `string` (`BrandName`, `ProductCode`, `Name`, `Image`).
     - `GetDecimal` $\rightarrow$ para dinero/precios con decimales exactos (`PurchasePrice`, `SalePrice`).
4. **Valor por defecto seguro (`: 0`, `: string.Empty`, `: 0m`, `: null`)**:
   - Si la columna no existía o venía `NULL` en la base de datos, asigna un valor por defecto limpio:
     - `0` para enteros (`int`).
     - `0m` para decimales financieros (`decimal`, la `m` en C# significa *monetary/decimal*).
     - `string.Empty` (`""`) para textos obligatorios.
     - `null` para `Image`, indicando explícitamente que ese producto no tiene ruta de imagen cargada.
