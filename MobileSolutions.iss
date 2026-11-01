#define MyAppName "Mobile Solutions"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "Grupo 97 - Taller de Programación 2"
#define MyAppExeName "MobileSolutions.UILayer.exe"

[Setup]
AppId={{8B981A42-01C4-415F-8581-43754B38A240}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
PrivilegesRequired=admin
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible
OutputDir=.\InstallerOutput
OutputBaseFilename=MobileSolutions_Setup
Compression=lzma2/max
SolidCompression=yes
WizardStyle=modern
DisableProgramGroupPage=yes

[Languages]
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
; 1. Todos los archivos publicados de la aplicación (.NET 10 autocontenido)
Source: "publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

; 2. Backup semilla (.bak), scripts SQL de respaldo y script de aprovisionamiento automático
Source: "Installer\Database\MobileSolutions_Initial.bak"; DestDir: "{app}\Database"; Flags: ignoreversion
Source: "MobileSolutions.DataLayer\ScriptsSQL\*.sql"; DestDir: "{app}\ScriptsSQL"; Flags: ignoreversion
Source: "Installer\init_db.ps1"; DestDir: "{app}"; Flags: ignoreversion

; 3. Instalador opcional de SQL Server Express LocalDB (si se incluye en Installer\Prerequisites\SqlLocalDB.msi)
Source: "Installer\Prerequisites\SqlLocalDB.msi"; DestDir: "{tmp}"; Flags: deleteafterinstall skipifsourcedoesntexist

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
; Paso A: Instalar SQL Server LocalDB silenciosamente si no está instalado y el archivo SqlLocalDB.msi fue empaquetado
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\SqlLocalDB.msi"" IACCEPTSQLLOCALDBLICENSETERMS=YES /qn /norestart"; \
    StatusMsg: "Instalando motor de base de datos local (SQL Server LocalDB)..."; \
    Check: ShouldInstallSqlLocalDB; Flags: waituntilterminated

; Paso B: Crear e inicializar la base de datos MobileSolutionsDB automáticamente
Filename: "powershell.exe"; Parameters: "-NoProfile -ExecutionPolicy Bypass -File ""{app}\init_db.ps1"""; \
    StatusMsg: "Configurando base de datos MobileSolutionsDB (tablas, reportes y datos iniciales)..."; \
    Flags: runhidden waituntilterminated

; Paso C: Opción para abrir Mobile Solutions al finalizar el instalador
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; \
    Flags: nowait postinstall skipifsilent

[Code]
// Verifica si SQL Server LocalDB ya está instalado y si SqlLocalDB.msi está disponible en {tmp}
function ShouldInstallSqlLocalDB(): Boolean;
var
  ResultCode: Integer;
begin
  if not FileExists(ExpandConstant('{tmp}\SqlLocalDB.msi')) then
  begin
    Result := False;
    Exit;
  end;

  if Exec('cmd.exe', '/c sqllocaldb info > nul 2>&1', '', SW_HIDE, ewWaitUntilTerminated, ResultCode) then
  begin
    Result := (ResultCode <> 0);
  end
  else
  begin
    Result := True;
  end;
end;
