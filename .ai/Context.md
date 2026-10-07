# SYSTEM ARCHITECTURE & CODEBASE CONTEXT: TALLER DE PROGRAMACIÓN 2 - GRUPO 97

---

## 1. OBJETIVO DEL PROYECTO

### 1.1. Propósito Primario
El sistema tiene como objetivo principal la gestión integral, transaccional y operativa del dominio de negocio asignado a la cátedra de **Taller de Programación 2 (Ciclo Lectivo 2026)**, desarrollado por el **Grupo 97** (organización: *NoMeCompila*).

La solución resuelve:
- La persistencia, integridad y auditoría de entidades de negocio centrales (usuarios, roles, transacciones operativas, catálogos e inventario/servicios).
- La separación estricta de responsabilidades bajo un paradigma modular y desacoplado.
- La ejecución de operaciones de negocio mediante transacciones atómicas asistidas por procedimientos almacenados y acceso de datos optimizado.
- La estandarización de interfaces de usuario y consumo de APIs internas con contratos tipados.

### 1.2. Metas de Calidad y Requisitos No Funcionales
- **Determinismo y Rendimiento:** Minimizar la sobrecarga de consultas SQL mediante el uso de índices balanceados y *Stored Procedures* con planes de ejecución estables.
- **Robustez y Tolerancia a Fallos:** Captura proactiva de anomalías operacionales y de infraestructura para prevenir caídas no controladas y fugas de datos sensibles.
- **Mantenibilidad:** Inyección de dependencias transversal, contratos abstractos (interfaces) y apego estricto a las directrices SOLID.
- **Legibilidad para Agentes IA:** Estructuras convencionales sin magia sintáctica ambigua, nombres descriptivos en idioma consistente y trazabilidad completa de flujos de ejecución.

---

## 2. CONTEXTO ACADÉMICO Y OPERACIONAL

### 2.1. Dominio de Aplicación
- **Ámbito:** Cátedra Universitaria / Técnica Superior de Taller de Programación 2 (Año 2026).
- **Equipo Responsable:** Grupo 97 (`NoMeCompila`).
- **Naturaleza del Sistema:** Aplicación corporativa/educativa de gestión comercial y administrativa con roles diferenciados (Administrador, Operador, Auditor y Cliente final).
- **Reglas de Negocio Clave:**
  - Control de accesos basado en roles (RBAC).
  - Trazabilidad y auditoría de eventos de inserción, actualización y anulación lógica (soft deletes).
  - Bloqueo transaccional ante violaciones de inventario, crédito o validaciones cruzadas.

---

## 3. TECNOLOGÍAS Y RUNTIME

### 3.1. Stack de Plataforma
| Componente | Tecnología | Versión / Especificación |
| :--- | :--- | :--- |
| **Lenguaje de Programación** | C# | 12.0 / 13.0 |
| **Framework Base** | .NET | 8.0 LTS / 9.0 |
| **Paradigma** | POO / Programación Asíncrona | TAP (`async` / `await`) |
| **Motor de Base de Datos** | Microsoft SQL Server | 2019 / 2022 Express o Developer Edition |
| **Capa Web / API** | ASP.NET Core Web API / MVC | RESTful HTTP Services |
| **Capa de Presentación** | Razor Pages / Blazor / WinForms / WPF | Según cliente activo del proyecto |
| **Formato de Intercambio** | JSON | `System.Text.Json` |
| **Control de Versiones** | Git + GitHub | GitFlow (main, develop, feature branches) |

---

## 4. ESTRUCTURA Y ARQUITECTURA

La solución implementa una **Arquitectura en N-Capas (N-Tier Architecture)** con inversión de dependencias y aislamiento de la capa de datos.

```
Taller-de-Programaci-n-2---2026---Grupo-97/
│
├── .ai/                                  <-- NUEVA CARPETA CENTRAL DE IA
│   ├── Context.md                        # Contexto técnico, BD, SPs y arquitectura
│   ├── Skill.md                          # Habilidades, snippets estándar y flujos de trabajo
│   └── Agent.md                          # Reglas operativas, rol y restricciones del agente
│
├── .github/                              # Flujos CI/CD o PR templates (opcional)
│   └── workflows/
│
├── database/                             # Scripts DDL y Stored Procedures
│   ├── schema/
│   │   └── tables.sql
│   └── sp/
│       ├── sp_Ventas.sql
│       ├── sp_Productos.sql
│       └── sp_Usuarios.sql
│
├── docs/                                 # Documentación funcional y académica
│   ├── diagramas-uml/
│   └── manual-usuario/
│
├── src/                                  # Código fuente (.NET Windows Forms)
│   ├── MobileSolutions.sln
│   │
│   ├── MobileSolutions.UI/               # Capa de Presentación (Forms, UserControls)
│   │   ├── Forms/
│   │   ├── Components/
│   │   ├── Properties/
│   │   ├── Program.cs
│   │   └── MobileSolutions.UI.csproj
│   │
│   ├── MobileSolutions.BLL/              # Capa de Lógica de Negocio (Servicios y Validaciones)
│   │   ├── Services/
│   │   ├── Validators/
│   │   └── MobileSolutions.BLL.csproj
│   │
│   ├── MobileSolutions.DAL/              # Capa de Acceso a Datos (AdoNet, Repositorios)
│   │   ├── Contracts/
│   │   ├── Repositories/
│   │   ├── Connection/
│   │   └── MobileSolutions.DAL.csproj
│   │
│   └── MobileSolutions.Entities/         # Entidades, DTOs y Enums transversales
│       ├── Models/
│       ├── DTOs/
│       ├── Enums/
│       └── MobileSolutions.Entities.csproj
│
├── tests/                                # Pruebas unitarias y de integración
│   ├── MobileSolutions.BLL.Tests/
│   └── MobileSolutions.DAL.Tests/
│
├── .gitignore
├── README.md
└── LICENSE
```

### 4.1. Patrones de Diseño Implementados
- **Repository Pattern:** Desacopla la lógica de negocio de la consulta y mapeo directo a base de datos.
- **Unit of Work (opcional):** Manejo atómico y coordinado de múltiples transacciones entre repositorios.
- **Dependency Injection (IoC):** Registro de contratos en el contenedor nativo `Microsoft.Extensions.DependencyInjection`.
- **DTO Pattern:** Exposición selectiva de propiedades para evitar vulnerabilidades de *over-posting*.

---

## 5. PAQUETES NUGET Y DEPENDENCIAS

El proyecto "MobileSolutions.BusinessLayer" tiene las referencias de paquete siguientes
   [net10.0]:
   Paquete de nivel superior      Solicitado   Resuelto
   > LiveCharts                   0.9.7        0.9.7
   > LiveCharts.WinForms          0.9.7.1      0.9.7.1
   > LiveCharts.Wpf               0.9.7        0.9.7

El proyecto "MobileSolutions.DataLayer" tiene las referencias de paquete siguientes
   [net10.0]:
   Paquete de nivel superior       Solicitado   Resuelto
   > LiveCharts                    0.9.7        0.9.7
   > LiveCharts.WinForms           0.9.7.1      0.9.7.1
   > LiveCharts.Wpf                0.9.7        0.9.7
   > Microsoft.Data.SqlClient      7.0.2        7.0.2

El proyecto "MobileSolutions.UILayer" tiene las referencias de paquete siguientes
   [net10.0-windows]:
   Paquete de nivel superior      Solicitado   Resuelto
   > FontAwesome.Sharp            6.6.0        6.6.0
   > LiveCharts                   0.9.7        0.9.7
   > LiveCharts.WinForms          0.9.7.1      0.9.7.1
   > LiveCharts.Wpf               0.9.7        0.9.7
   > MaterialSkin.2               2.3.1        2.3.1

---

## 6. BASE DE DATOS Y MODELO RELACIONAL

### 6.1. Motor y Convenciones
- **Motor:** Microsoft SQL Server.
- **Collation:** `SQL_Latin1_General_CP1_CI_AS`.
- **Estrategia de Nombres:** PascalCase para tablas y columnas; prefijos descriptivos para índices (`IX_`), llaves primarias (`PK_`) y foráneas (`FK_`).
- **Control de Borrado:** Soft Deletes mediante la bandera lógica `Activo BIT NOT NULL DEFAULT 1`.
- **Trazabilidad:** Columnas `FechaCreacion DATETIME2`, `FechaModificacion DATETIME2 NULL`.

### 6.2. Esquema DDL Fundamental

```sql
-- Creación de Base de Datos
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'Grupo97_TP2_DB')
BEGIN
    CREATE DATABASE Grupo97_TP2_DB;
END
GO

USE Grupo97_TP2_DB;
GO

-- Tabla: Roles
CREATE TABLE Roles (
    RolId INT IDENTITY(1,1) CONSTRAINT PK_Roles PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL CONSTRAINT UQ_Roles_Nombre UNIQUE,
    Descripcion VARCHAR(200) NULL,
    Activo BIT NOT NULL CONSTRAINT DF_Roles_Activo DEFAULT 1
);
GO

-- Tabla: Usuarios
CREATE TABLE Usuarios (
    UsuarioId INT IDENTITY(1,1) CONSTRAINT PK_Usuarios PRIMARY KEY,
    RolId INT NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Email VARCHAR(120) NOT NULL CONSTRAINT UQ_Usuarios_Email UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    Activo BIT NOT NULL CONSTRAINT DF_Usuarios_Activo DEFAULT 1,
    FechaCreacion DATETIME2 NOT NULL CONSTRAINT DF_Usuarios_FechaCreacion DEFAULT SYSDATETIME(),
    FechaModificacion DATETIME2 NULL,
    CONSTRAINT FK_Usuarios_Roles FOREIGN KEY (RolId) REFERENCES Roles(RolId)
);
GO

-- Tabla: Categorias
CREATE TABLE Categorias (
    CategoriaId INT IDENTITY(1,1) CONSTRAINT PK_Categorias PRIMARY KEY,
    Nombre VARCHAR(80) NOT NULL CONSTRAINT UQ_Categorias_Nombre UNIQUE,
    Descripcion VARCHAR(250) NULL,
    Activo BIT NOT NULL CONSTRAINT DF_Categorias_Activo DEFAULT 1
);
GO

-- Tabla: Productos
CREATE TABLE Productos (
    ProductoId INT IDENTITY(1,1) CONSTRAINT PK_Productos PRIMARY KEY,
    CategoriaId INT NOT NULL,
    CodigoBarra VARCHAR(50) NOT NULL CONSTRAINT UQ_Productos_Codigo UNIQUE,
    Descripcion VARCHAR(150) NOT NULL,
    PrecioUnitario DECIMAL(18,2) NOT NULL CHECK (PrecioUnitario >= 0),
    StockActual INT NOT NULL CHECK (StockActual >= 0),
    StockMinimo INT NOT NULL DEFAULT 5 CHECK (StockMinimo >= 0),
    Activo BIT NOT NULL CONSTRAINT DF_Productos_Activo DEFAULT 1,
    FechaCreacion DATETIME2 NOT NULL CONSTRAINT DF_Productos_FechaCreacion DEFAULT SYSDATETIME(),
    CONSTRAINT FK_Productos_Categorias FOREIGN KEY (CategoriaId) REFERENCES Categorias(CategoriaId)
);
GO

-- Tabla: Transacciones / Encabezado
CREATE TABLE Transacciones (
    TransaccionId INT IDENTITY(1,1) CONSTRAINT PK_Transacciones PRIMARY KEY,
    UsuarioId INT NOT NULL,
    NumeroComprobante VARCHAR(20) NOT NULL CONSTRAINT UQ_Transacciones_Nro UNIQUE,
    Fecha DATETIME2 NOT NULL CONSTRAINT DF_Transacciones_Fecha DEFAULT SYSDATETIME(),
    MontoTotal DECIMAL(18,2) NOT NULL CHECK (MontoTotal >= 0),
    Estado VARCHAR(20) NOT NULL CONSTRAINT DF_Transacciones_Estado DEFAULT 'COMPLETADO',
    CONSTRAINT FK_Transacciones_Usuarios FOREIGN KEY (UsuarioId) REFERENCES Usuarios(UsuarioId)
);
GO

-- Tabla: DetallesTransaccion
CREATE TABLE DetallesTransaccion (
    DetalleId INT IDENTITY(1,1) CONSTRAINT PK_DetallesTransaccion PRIMARY KEY,
    TransaccionId INT NOT NULL,
    ProductoId INT NOT NULL,
    Cantidad INT NOT NULL CHECK (Cantidad > 0),
    PrecioUnitario DECIMAL(18,2) NOT NULL CHECK (PrecioUnitario >= 0),
    Subtotal AS (Cantidad * PrecioUnitario) PERSISTED,
    CONSTRAINT FK_Detalles_Transacciones FOREIGN KEY (TransaccionId) REFERENCES Transacciones(TransaccionId),
    CONSTRAINT FK_Detalles_Productos FOREIGN KEY (ProductoId) REFERENCES Productos(ProductoId)
);
GO

-- Índices de Rendimiento
CREATE NONCLUSTERED INDEX IX_Usuarios_Email ON Usuarios(Email) WHERE Activo = 1;
CREATE NONCLUSTERED INDEX IX_Productos_CategoriaId ON Productos(CategoriaId);
CREATE NONCLUSTERED INDEX IX_Transacciones_UsuarioId_Fecha ON Transacciones(UsuarioId, Fecha DESC);
GO
```

