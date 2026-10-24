# 📱 Mobile Solutions - Sistema de Punto de Venta (POS)

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8%2B-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms%20%7C%20MaterialSkin.2-0078D6?logo=windows&logoColor=white)](https://github.com/IgnaceMaes/MaterialSkin)
[![SQL Server](https://img.shields.io/badge/Database-Microsoft%20SQL%20Server-CC292B?logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/sql-server)
[![Standards](https://img.shields.io/badge/Standard-IEEE%20830--1998-orange)](https://standards.ieee.org/)
---
# Universidad Nacional del Nordeste

## Facultad de Ciencias Exactas y Naturales y Agrimensura

## Taller de Programación II

Integrantes:
- Fernando Caballero
- Pannunzio Mario Nicolas

Cátedra: Taller de Programación II
Carrera: Licenciatura en Sistemas de Información
Año Lectivo: 2026

---

---
## 📄 Documentación

| Documento | Descripción | Enlace |
|-----------|-------------|--------|
| 📋 ERS | Especificación de Requisitos de Software (IEEE 830) | [Ver PDF](Documentacion/Especificación_de_Requerimientos_de_Software_%28ERS%29.pdf) |
| 📖 Manual de Usuario | Guía completa de uso para clientes y administradores | [Proximamente...]|
| ⚙️ Guía de Instalación | Instrucciones para configurar el entorno local | [Proximamente...] |

---

## 🧭 NAVEGACIÓN Y ESTRUCTURA DEL REPOSITORIO

Acceso directo a la arquitectura en capas, componentes, modelos y scripts de la solución:

### 📁 [`Documentacion/`](Documentacion/) — Documentación y Especificaciones
* 📄 [`Documentacion/Especificación_de_Requerimientos_de_Software_(ERS).pdf`](Documentacion/Especificación_de_Requerimientos_de_Software_%28ERS%29.pdf): Documento formal de Especificación de Requisitos de Software bajo estándar IEEE 830-1998.

### 📁 [`MobileSolutions.UILayer/`](MobileSolutions.UILayer/) — Capa de Presentación (UI)
Interfaz de usuario de escritorio construida en Windows Forms con MaterialSkin.2.
* 📂 [`MobileSolutions.UILayer/ControlViews/`](MobileSolutions.UILayer/ControlViews/): **Vistas Modulares y Controles de Usuario**
  * 🖥️ [`HomeView.cs`](MobileSolutions.UILayer/ControlViews/HomeView.cs): Tablero principal del sistema.
  * 🛒 [`SaleView.cs`](MobileSolutions.UILayer/ControlViews/SaleView.cs) | [`SalesHistoryView.cs`](MobileSolutions.UILayer/ControlViews/SalesHistoryView.cs): Módulo de facturación, emisión de tickets e historial comercial.
  * 📦 [`ProductView.cs`](MobileSolutions.UILayer/ControlViews/ProductView.cs): Gestión y catálogo de productos celulares y accesorios.
  * 👥 [`CustomerView.cs`](MobileSolutions.UILayer/ControlViews/CustomerView.cs): Administración y legajo de clientes.
  * 🛡️ [`UserView.cs`](MobileSolutions.UILayer/ControlViews/UserView.cs): Gestión de usuarios, credenciales y perfiles de acceso.
  * 📊 [`ReportsView.cs`](MobileSolutions.UILayer/ControlViews/ReportsView.cs) | [`ManagerReportControl.cs`](MobileSolutions.UILayer/ControlViews/ManagerReportControl.cs) | [`SellerReportControl.cs`](MobileSolutions.UILayer/ControlViews/SellerReportControl.cs) | [`AdminReportControl.cs`](MobileSolutions.UILayer/ControlViews/AdminReportControl.cs): Reportes estadísticos y gráficos analíticos.
  * 💾 [`BackupView.cs`](MobileSolutions.UILayer/ControlViews/BackupView.cs): Copias de seguridad y restauración del sistema.
* 📂 [`MobileSolutions.UILayer/Contracts/`](MobileSolutions.UILayer/Contracts/): **Contratos e Interfaces**
  * 🔌 [`ILogoutSupport.cs`](MobileSolutions.UILayer/Contracts/ILogoutSupport.cs): Contrato de soporte para cierre de sesión y reinicio de contexto.
* 📄 [`MobileSolutions.UILayer/LoginForm.cs`](MobileSolutions.UILayer/LoginForm.cs): Formulario de autenticación y validación de credenciales.
* 📄 [`MobileSolutions.UILayer/MainForm.cs`](MobileSolutions.UILayer/MainForm.cs): Ventana contenedora principal con barra de navegación y control de roles.
* 📄 [`MobileSolutions.UILayer/Program.cs`](MobileSolutions.UILayer/Program.cs): Punto de entrada y ciclo de vida de la aplicación.
* ⚙️ [`MobileSolutions.UILayer/MobileSolutions.UILayer.csproj`](MobileSolutions.UILayer/MobileSolutions.UILayer.csproj): Archivo de configuración del proyecto de UI.

### 📁 [`MobileSolutions.BusinessLayer/`](MobileSolutions.BusinessLayer/) — Capa de Lógica de Negocio (BLL)
Reglas de validación, lógica de dominio, hashing de contraseñas y procesamiento comercial.
* 📂 [`MobileSolutions.BusinessLayer/Models/`](MobileSolutions.BusinessLayer/Models/): **Modelos de Dominio y DTOs**
  * 📊 [`ManagerReport.cs`](MobileSolutions.BusinessLayer/Models/ManagerReport.cs): Modelo de consolidación analítica gerencial.
* ⚙️ **Servicios de Negocio:**
  * 🔐 [`UserService.cs`](MobileSolutions.BusinessLayer/UserService.cs) | [`PasswordResetService.cs`](MobileSolutions.BusinessLayer/PasswordResetService.cs): Control de usuarios, restablecimiento y hashing SHA-256.
  * 🛒 [`SaleService.cs`](MobileSolutions.BusinessLayer/SaleService.cs) | [`TicketReportService.cs`](MobileSolutions.BusinessLayer/TicketReportService.cs): Procesamiento transaccional de ventas y emisión de tickets.
  * 📦 [`ProductService.cs`](MobileSolutions.BusinessLayer/ProductService.cs): Validaciones de stock, precios y reglas de catálogo.
  * 👥 [`CustomerService.cs`](MobileSolutions.BusinessLayer/CustomerService.cs): Validaciones de clientes y verificación de DNI.
  * 📈 [`ManagerReportService.cs`](MobileSolutions.BusinessLayer/ManagerReportService.cs) | [`SellerReportService.cs`](MobileSolutions.BusinessLayer/SellerReportService.cs): Lógica de cálculo de reportes y métricas operativas.
  * 🛡️ [`AuditService.cs`](MobileSolutions.BusinessLayer/AuditService.cs): Auditoría de eventos y trazabilidad del sistema.
  * 👤 [`CurrentSession.cs`](MobileSolutions.BusinessLayer/CurrentSession.cs): Gestión de sesión del usuario en memoria.
* ⚙️ [`MobileSolutions.BusinessLayer/MobileSolutions.BusinessLayer.csproj`](MobileSolutions.BusinessLayer/MobileSolutions.BusinessLayer.csproj): Archivo de configuración del proyecto de lógica de negocio.

### 📁 [`MobileSolutions.DataLayer/`](MobileSolutions.DataLayer/) — Capa de Acceso a Datos (DAL) y Persistencia
Conexión a base de datos, procedimientos almacenados y mapeo objeto-relacional mediante ADO.NET.
* 📂 [`MobileSolutions.DataLayer/ScriptsSQL/`](MobileSolutions.DataLayer/ScriptsSQL/): **Scripts SQL Server (DDL, DML y Procedimientos Almacenados)**
  * 🛠️ [`CreateDB.sql`](MobileSolutions.DataLayer/ScriptsSQL/CreateDB.sql): Script DDL de creación de base de datos, tablas relacionales e índices.
  * ⚙️ **Procedimientos Almacenados (SP):**
    * 🔐 [`UserSP.sql`](MobileSolutions.DataLayer/ScriptsSQL/UserSP.sql) | [`AuditAndGovernanceSP.sql`](MobileSolutions.DataLayer/ScriptsSQL/AuditAndGovernanceSP.sql) | [`MigratePasswordsToSha256.sql`](MobileSolutions.DataLayer/ScriptsSQL/MigratePasswordsToSha256.sql): SPs de usuarios, auditoría y seguridad.
    * 👥 [`CustomerSP.sql`](MobileSolutions.DataLayer/ScriptsSQL/CustomerSP.sql): SPs de gestión de clientes.
    * 📦 [`ProductSP.sql`](MobileSolutions.DataLayer/ScriptsSQL/ProductSP.sql): SPs de productos, marcas y stock.
    * 🛒 [`SaleSP.sql`](MobileSolutions.DataLayer/ScriptsSQL/SaleSP.sql): SPs de registro transaccional de ventas.
    * 📊 [`ManagerReportSP.sql`](MobileSolutions.DataLayer/ScriptsSQL/ManagerReportSP.sql) | [`SellerReportSP.sql`](MobileSolutions.DataLayer/ScriptsSQL/SellerReportSP.sql): SPs de reportes analíticos y estadísticos.
  * 📥 **Carga de Datos Iniciales y de Prueba (DML):**
    * 👥 [`usersData.sql`](MobileSolutions.DataLayer/ScriptsSQL/usersData.sql) | [`customersData.sql`](MobileSolutions.DataLayer/ScriptsSQL/customersData.sql) | [`productData.sql`](MobileSolutions.DataLayer/ScriptsSQL/productData.sql) | [`SalesData.sql`](MobileSolutions.DataLayer/ScriptsSQL/SalesData.sql)
* 📂 [`MobileSolutions.DataLayer/Models/`](MobileSolutions.DataLayer/Models/): **Entidades y Modelos de Persistencia**
  * 👤 [`User.cs`](MobileSolutions.DataLayer/Models/User.cs) | 👥 [`Customer.cs`](MobileSolutions.DataLayer/Models/Customer.cs) | 📦 [`Product.cs`](MobileSolutions.DataLayer/Models/Product.cs) | 🏷️ [`Brand.cs`](MobileSolutions.DataLayer/Models/Brand.cs)
  * 💳 [`PaymentType.cs`](MobileSolutions.DataLayer/Models/PaymentType.cs) | 🧾 [`SaleHeader.cs`](MobileSolutions.DataLayer/Models/SaleHeader.cs) | 📋 [`SaleDetail.cs`](MobileSolutions.DataLayer/Models/SaleDetail.cs)
  * 🛡️ [`AuditEvent.cs`](MobileSolutions.DataLayer/Models/AuditEvent.cs) | 📈 [`ManagerReport.cs`](MobileSolutions.DataLayer/Models/ManagerReport.cs) | 📊 [`SellerReport.cs`](MobileSolutions.DataLayer/Models/SellerReport.cs) | 📊 [`AdminDashboardMetrics.cs`](MobileSolutions.DataLayer/Models/AdminDashboardMetrics.cs)
* 🔌 [`DatabaseConnection.cs`](MobileSolutions.DataLayer/DatabaseConnection.cs): Conexión centralizada ADO.NET a Microsoft SQL Server.
* 🗄️ **Componentes DAL:**
  * [`UserDal.cs`](MobileSolutions.DataLayer/UserDal.cs), [`CustomerDal.cs`](MobileSolutions.DataLayer/CustomerDal.cs), [`ProductDal.cs`](MobileSolutions.DataLayer/ProductDal.cs), [`SaleDal.cs`](MobileSolutions.DataLayer/SaleDal.cs), [`ManagerReportDal.cs`](MobileSolutions.DataLayer/ManagerReportDal.cs), [`SellerReportDal.cs`](MobileSolutions.DataLayer/SellerReportDal.cs), [`AuditDal.cs`](MobileSolutions.DataLayer/AuditDal.cs).
* ⚙️ [`MobileSolutions.DataLayer/MobileSolutions.DataLayer.csproj`](MobileSolutions.DataLayer/MobileSolutions.DataLayer.csproj): Archivo de configuración del proyecto de datos.

### ⚙️ Archivos de Solución y Configuración Raíz
* 📄 [`MobileSolutions.slnx`](MobileSolutions.slnx): Archivo de solución XML (.slnx) de Visual Studio.
* 📄 [`.gitignore`](.gitignore): Configuración de exclusiones de Git para artefactos de compilación (`bin/`, `obj/`, `.vs/`).
* 📄 [`ticketSample.html`](ticketSample.html): Plantilla base de ticket de venta.

---

## 📌 Descripción del Sistema

**Mobile Solutions POS** es una aplicación de escritorio diseñada para entornos Microsoft Windows (Windows 10/11), orientada a la gestión comercial integral, facturación y control de inventario de equipos de telefonía celular y accesorios tecnológicos para la firma comercial *Mobile Solutions*.

El sistema está desarrollado bajo el estándar de especificación **IEEE 830-1998** y estructurado mediante una **arquitectura en capas** (Presentación, Lógica de Negocio y Acceso a Datos), garantizando modularidad, mantenibilidad y robustez transaccional.

---

## 🚀 Funcionalidades Principales

### 🔐 1. Autenticación y Control de Acceso Multirol
* Validación segura de credenciales mediante login.
* Control de acceso basado en perfiles y permisos granulares (**Admin User**, **Gerente**, **Vendedor / Cajero**).

### 🛒 2. Ventas y Facturación
* Registro de operaciones comerciales y selección ágil de productos por código o descripción.
* Validación de stock en tiempo real antes de confirmar la transacción.
* Cálculo automático de subtotales, totales e impuestos.
* Registro de tipo de pago y emisión/generación de tickets de compra.

### 📦 3. Gestión de Inventario y Catálogo (ABM)
* Altas, Bajas y Modificaciones de equipos celulares y accesorios.
* Control y actualización de existencias en tiempo real.
* Gestión de Marcas comerciales asociadas a los productos.
* Integración con API REST externa para la consulta y renderizado de imágenes de los productos.

### 👥 4. Gestión de Clientes
* Registro, edición y búsqueda de clientes mediante DNI o datos personales.
* Historial de compras asociadas al cliente.

### 📊 5. Reportes Estadísticos y Analítica
* Panel de seguimiento operativo y financiero.
* Gráficos estadísticos:
  * 📊 **Gráfico de barras:** Vendedores con mayor volumen de ventas y productos más vendidos.
  * 🥧 **Gráfico de torta:** Marcas con mayor demanda comercial.
* Métricas clave: Ganancias totales acumuladas, volumen de ventas por período y contador de clientes.

### ⚙️ 6. Administración del Sistema y Usuarios
* Mantenimiento de cuentas de usuario y asignación de perfiles.
* Gestión de perfiles y permisos del sistema.

---

## 👥 Perfiles de Usuario y Matriz de Roles

| Rol | Descripción y Responsabilidades |
| :--- | :--- |
| **🛡️ Admin User** | Encargado de la configuración, mantenimiento y seguridad. Administra la Base de Datos, gestiona altas/bajas/modificaciones de usuarios y perfiles, asigna permisos y supervisa la operatividad del sistema. |
| **💼 Gerente** | Supervisa el flujo comercial y financiero. Acceso completo a reportes analíticos, métricas de ganancias, estadísticas de ventas, gestión de marcas y procesamiento de ventas. |
| **🏷️ Vendedor / Cajero** | Operador diario del punto de venta. Atención y registro de clientes, consulta de catálogo y stock, carga/modificación de productos y marcas, y emisión de ventas y tickets. |

---

## 🛠️ Stack Tecnológico y Requisitos

* **Lenguaje de Programación:** C#
* **Plataforma / Framework:** .NET Framework
* **Interfaz de Usuario (UI):** Windows Forms + MaterialSkin.2 (UI personalizada y moderna)
* **Base de Datos:** Microsoft SQL Server (Procedimientos Almacenados y Persistencia Relacional)
* **IDE Recomendado:** Microsoft Visual Studio
* **Control de Versiones:** Git / GitHub
* **Metodología de Trabajo:** Scrum (Gestión ágil de iteraciones y Sprints)
* **Entorno de Ejecución:** Microsoft Windows 10 / Windows 11
* **Dependencias:** Conexión a Internet activa (para consumo de API REST de imágenes multimedia).

---

## 🏛️ Arquitectura del Sistema

El software implementa un patrón en **3 Capas**:
