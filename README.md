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
## 📚 Documentación

En esta sección se encuentran los documentos del proyecto:

* 📑 [Especificación de Requerimientos de Software (ERS)] (./Documentacion/Grupo 97 - Especificación de Requerimientos de Software (ERS).pdf)
---

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
