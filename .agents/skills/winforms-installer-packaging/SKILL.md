---
name: winforms-installer-packaging
description: "Trigger: instalador, .exe, Setup.exe, Inno Setup, LocalDB, build_installer, empaquetar. Package .NET WinForms + SQL Server LocalDB into a standalone Windows installer."
license: Apache-2.0
metadata:
  author: "Grupo-97"
  version: "1.0"
---

## Activation Contract

Activate this skill when:
- Building, updating, or debugging the standalone `.exe` installer (`MobileSolutions_Setup.exe`).
- Modifying database auto-provisioning (`DatabaseInitializer.cs`, `Installer/init_db.ps1`, or `MobileSolutions_Initial.bak`).
- Explaining the WinForms + LocalDB packaging workflow to a team member or Junior developer.

Do not activate for regular UI or CRUD changes unrelated to deployment or database initialization.

## Hard Rules

- Never hardcode developer machine paths (`C:\Users\<Dev>\...`) in executable or asset lookups; always use `AppDomain.CurrentDomain.BaseDirectory` or `Application.ExecutablePath`.
- Never overwrite an existing `MobileSolutionsDB` on the client PC; always guard creation/restoration with `SELECT COUNT(*) FROM sys.databases WHERE name = 'MobileSolutionsDB'`.
- Always restore `.mdf` and `.ldf` files into `%LocalAppData%\MobileSolutions\Data\` using `RESTORE DATABASE ... WITH MOVE` so standard Windows 10/11 users do not hit `C:\Program Files` write-permission errors.
- Always save `.cs`, `.sql`, `.ps1`, and `.iss` files encoded as `UTF-8 with BOM`.

## Decision Gates

| Scenario | Action |
|----------|--------|
| Schema, SPs, or seed data changed in `(localdb)\MSSQLLocalDB` | Run `.\build_installer.ps1` to refresh `Installer\Database\MobileSolutions_Initial.bak` and recompile `MobileSolutions_Setup.exe` |
| Client PC has no internet and needs SQL Server LocalDB | Place `SqlLocalDB.msi` in `Installer\Prerequisites\SqlLocalDB.msi` before running `.\build_installer.ps1` |
| Explaining the installer to a Junior developer | Use the 4-layer mental model in `references/guia-instalador-jr.md` |

## Execution Steps

1. Verify portability: ensure no hardcoded local paths exist in `MobileSolutions.UILayer` or `MobileSolutions.DataLayer`.
2. Ensure `(localdb)\MSSQLLocalDB` is running and `MobileSolutionsDB` has the latest schema, SPs, and seed data.
3. Execute `powershell -NoProfile -ExecutionPolicy Bypass -File .\build_installer.ps1` from the repository root:
   - Step 1 exports `Installer\Database\MobileSolutions_Initial.bak`.
   - Step 2 runs `dotnet publish` (`Release`, `win-x64`, `--self-contained true`) into `.\publish`.
   - Step 3 compiles `MobileSolutions.iss` with Inno Setup (`ISCC.exe`) into `InstallerOutput\MobileSolutions_Setup.exe`.
4. Verify that `InstallerOutput\MobileSolutions_Setup.exe` exists and is non-empty.

## Output Contract

Return:
- Path and size (in MB) of `InstallerOutput\MobileSolutions_Setup.exe`.
- Any changes made to `DatabaseInitializer.cs`, `Installer\init_db.ps1`, `MobileSolutions.iss`, or `build_installer.ps1`.
- Confirmation that `Installer\Database\MobileSolutions_Initial.bak` was refreshed.

## References

- `references/guia-instalador-jr.md` — Didactic step-by-step guide for Junior developers.
- `../../../Installer/GUIA_INSTALADOR_JR.md` — Project-level copy of the installer guide.
- `../../../MobileSolutions.iss` — Inno Setup configuration script.
- `../../../build_installer.ps1` — Automated build and packaging script.
