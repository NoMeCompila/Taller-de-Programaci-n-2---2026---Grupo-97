# Guía Didáctica Paso a Paso: Cómo Construimos el Instalador `.exe` de MobileSolutions (Explicación para un Desarrollador Jr)

Esta guía documenta **qué implementamos en la solución**, **por qué se diseñó así** y **cómo explicárselo paso a paso a un desarrollador Junior** para que entienda cómo pasar de un proyecto en Visual Studio a un instalador profesional **`MobileSolutions_Setup.exe`** que funciona en otra PC con Windows 10 o Windows 11.

---

## 1. El Problema: ¿Por qué no alcanza con pasarle a otra PC el `.exe` de `bin\Debug`?

Cuando empezamos a programar en Windows Forms, es común pensar: *"Copio el archivo `.exe` que está en `bin\Debug` a un pendrive, lo llevo a otra PC y listo"*.
Si un Jr intenta eso, la aplicación **fallará por 3 motivos**:

1. **Falta el Runtime de .NET 10**: La otra PC puede no tener instalado `.NET 10 Desktop Runtime`.
2. **Rutas quemadas ("Hardcoded") de nuestra PC**: Si en el código quedó escrita una ruta como `C:\Users\FeR\Desktop\...`, en la PC del cliente esa carpeta no existe.
3. **La Base de Datos no existe en la otra PC**: Aunque el programa abra, cuando intente hacer Login buscará `MobileSolutionsDB` en `(localdb)\MSSQLLocalDB` y dará error porque nadie creó las tablas, los Stored Procedures ni el usuario `admin`.

---

## 2. La Solución en 4 Capas (Mapa Mental para el Jr)

1. **Capa 1 — Código Portable en C#**:
   - `MainForm.cs` usa rutas relativas (`AppDomain.CurrentDomain.BaseDirectory`).
   - `DatabaseInitializer.cs` verifica y crea la base automáticamente antes de abrir el `LoginForm`.
2. **Capa 2 — Semilla de Base de Datos**:
   - `Installer\Database\MobileSolutions_Initial.bak` contiene el esquema completo, SPs, Triggers y usuarios iniciales.
   - `Installer\init_db.ps1` aprovisiona la base durante la instalación sin pisar datos previos si ya existía.
3. **Capa 3 — Publicación Autocontenida (`.NET 10`)**:
   - `dotnet publish -c Release -r win-x64 --self-contained true` empaqueta todas las DLLs de `.NET 10` junto a la app.
4. **Capa 4 — Instalador de Windows (Inno Setup 6)**:
   - `MobileSolutions.iss` comprime todo en un único `InstallerOutput\MobileSolutions_Setup.exe`.

---

## 3. Paso a Paso de lo que Implementamos en el Proyecto

### Paso 1: Hicimos el código 100% portable en `MobileSolutions.UILayer\MainForm.cs`
- **¿Qué pasaba antes?** En el método `ExecuteApplicationRestart()` (cuando el usuario cierra sesión), el código buscaba primero una ruta fija de tu escritorio (`C:\Users\FeR\Desktop\...`).
- **¿Qué hicimos?** Lo reemplazamos por `AppDomain.CurrentDomain.BaseDirectory`, que le pregunta dinámicamente a Windows: *"¿En qué carpeta estoy instalado ahora mismo?"*. Así funciona igual en tu escritorio o en `C:\Program Files\Mobile Solutions\`.

### Paso 2: Creamos el Auto-Inicializador de Base de Datos (`MobileSolutions.DataLayer\DatabaseInitializer.cs`)
- **¿Por qué lo necesitamos?** Para que el cliente no tenga que abrir SQL Server Management Studio ni correr scripts a mano.
- **¿Cómo funciona por dentro?**
  1. Antes de abrir el formulario de Login en `Program.cs`, llamamos a `BackupService.EnsureDatabaseReady()`, que invoca a `DatabaseInitializer.EnsureDatabaseReady()`.
  2. Enciende automáticamente el motor local con `sqllocaldb start MSSQLLocalDB`.
  3. Se conecta a la base `master` y pregunta:
     ```sql
     SELECT COUNT(*) FROM sys.databases WHERE name = 'MobileSolutionsDB';
     ```
  4. **Si ya existe (`> 0`)**: No hace nada y abre el Login inmediatamente (así nunca borra las ventas ni clientes que ya tenga cargados el usuario).
  5. **Si no existe (`0`)**: Toma el backup semilla limpio (`Database\MobileSolutions_Initial.bak`) y lo restaura automáticamente en la carpeta del usuario (`%LocalAppData%\MobileSolutions\Data\`) usando `RESTORE DATABASE ... WITH MOVE`.
- **¿Por qué usamos `%LocalAppData%` y no `C:\Program Files` para los archivos `.mdf` y `.ldf`?**
  - *Tip clave para explicarle al Jr*: Windows 10 y 11 bloquean por seguridad la escritura en `C:\Program Files` para usuarios normales. En cambio, `%LocalAppData%` (`C:\Users\<NombreCliente>\AppData\Local\MobileSolutions\Data`) pertenece al usuario y SQL Server LocalDB tiene permiso total de lectura y escritura sin pedir permisos de Administrador cada vez que abre la app.

### Paso 3: Generamos la Semilla de Base de Datos y el Script del Instalador (`Installer\init_db.ps1`)
- Exportamos la base de datos curada con UTF-8, Stored Procedures, Triggers y usuarios al archivo `Installer\Database\MobileSolutions_Initial.bak`.
- Creamos `Installer\init_db.ps1` para que el propio instalador deje la base lista incluso antes de que el usuario abra la aplicación por primera vez.

### Paso 4: Empaquetamos todo en un único instalador con Inno Setup (`MobileSolutions.iss` y `build_installer.ps1`)
- Creamos `MobileSolutions.iss`, que es la receta de **Inno Setup 6**:
  - Toma todos los binarios de `publish\` (compilados con `--self-contained true`, por lo que ya incluyen `.NET 10`).
  - Incluye el backup semilla `MobileSolutions_Initial.bak` y los scripts SQL.
  - Crea el acceso directo en el Menú Inicio y en el Escritorio.
  - Si colocas el archivo `SqlLocalDB.msi` dentro de `Installer\Prerequisites\SqlLocalDB.msi`, el instalador detecta automáticamente si la PC del cliente no tiene SQL Server LocalDB y lo instala de forma silenciosa (`/qn`).
- Creamos el script maestro `build_installer.ps1` que automatiza los **3 pasos con un solo comando**:
  1. Actualiza `MobileSolutions_Initial.bak` desde tu LocalDB.
  2. Ejecuta `dotnet publish` en modo `Release` + `win-x64` + `--self-contained true`.
  3. Compila `MobileSolutions.iss` con Inno Setup y genera **`InstallerOutput\MobileSolutions_Setup.exe`**.

---

## 4. ¿Cómo volver a generar el instalador en el futuro cuando hagan cambios?

Cada vez que tú o tu compañero Jr agreguen una funcionalidad nueva y quieran actualizar el instalador `MobileSolutions_Setup.exe`, solo tienen que abrir PowerShell en la raíz del proyecto y ejecutar:

```powershell
.\build_installer.ps1
```

El instalador compilado queda listo para compartir en:
- **`InstallerOutput\MobileSolutions_Setup.exe`**
