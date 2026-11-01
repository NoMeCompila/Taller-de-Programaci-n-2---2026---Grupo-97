# Resumen Rápido: Flujo del Instalador en 4 Capas (Para Desarrolladores Jr)

1. **Capa 1 — Portabilidad en C# (`MainForm.cs` y `DatabaseInitializer.cs`)**:
   - Usar `AppDomain.CurrentDomain.BaseDirectory` en lugar de rutas absolutas de desarrollo.
   - `Program.cs` invoca `BackupService.EnsureDatabaseReady()` -> `DatabaseInitializer.EnsureDatabaseReady()` antes de iniciar `LoginForm`.
2. **Capa 2 — Auto-Aprovisionamiento de Base de Datos (`MobileSolutions_Initial.bak` + `init_db.ps1`)**:
   - Si `MobileSolutionsDB` no existe en `(localdb)\MSSQLLocalDB`, se restaura `MobileSolutions_Initial.bak` moviendo `.mdf` y `.ldf` a `%LocalAppData%\MobileSolutions\Data\`.
3. **Capa 3 — Publicación Self-Contained (`dotnet publish`)**:
   - `dotnet publish MobileSolutions.UILayer\MobileSolutions.UILayer.csproj -c Release -r win-x64 --self-contained true -o .\publish` incluye el runtime de `.NET 10`.
4. **Capa 4 — Compilación con Inno Setup (`MobileSolutions.iss`)**:
   - Empaqueta `publish\*`, `MobileSolutions_Initial.bak` y `init_db.ps1` en `InstallerOutput\MobileSolutions_Setup.exe`.

Para el detalle completo, ver `../../../Installer/GUIA_INSTALADOR_JR.md`.
