# ==============================================================================
# Script Automatizado de Construcción del Instalador (MobileSolutions_Setup.exe)
# Uso: .\build_installer.ps1
# ==============================================================================
$ErrorActionPreference = "Stop"

$repoRoot = $PSScriptRoot
Set-Location $repoRoot

Write-Host "============================================================" -ForegroundColor Cyan
Write-Host " 1/3 - Generando Backup Semilla (MobileSolutions_Initial.bak)" -ForegroundColor Cyan
Write-Host "============================================================" -ForegroundColor Cyan

$dbFolder = Join-Path $repoRoot "Installer\Database"
New-Item -ItemType Directory -Force -Path $dbFolder | Out-Null
$bakPath = Join-Path $dbFolder "MobileSolutions_Initial.bak"

try {
    sqllocaldb start MSSQLLocalDB | Out-Null
    $conn = New-Object System.Data.SqlClient.SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=master;Trusted_Connection=True;TrustServerCertificate=True;")
    $conn.Open()
    $cmd = $conn.CreateCommand()
    $cmd.CommandTimeout = 300
    $cmd.CommandText = "BACKUP DATABASE [MobileSolutionsDB] TO DISK = N'$bakPath' WITH FORMAT, INIT, NAME = N'MobileSolutionsDB-InitialSeed';"
    [void]$cmd.ExecuteNonQuery()
    $conn.Close()
    Write-Host "[OK] Backup semilla actualizado en: $bakPath" -ForegroundColor Green
} catch {
    if (Test-Path $bakPath) {
        Write-Host "[WARN] No se pudo regenerar el backup en vivo, se utilizará el existente en: $bakPath" -ForegroundColor Yellow
    } else {
        throw "No se pudo generar ni encontrar el backup semilla en $bakPath. Error: $_"
    }
}

Write-Host "`n============================================================" -ForegroundColor Cyan
Write-Host " 2/3 - Publicando Aplicación .NET 10 (Self-Contained win-x64)" -ForegroundColor Cyan
Write-Host "============================================================" -ForegroundColor Cyan

$publishDir = Join-Path $repoRoot "publish"
if (Test-Path $publishDir) {
    Remove-Item -Path $publishDir -Recurse -Force
}

dotnet publish "MobileSolutions.UILayer\MobileSolutions.UILayer.csproj" `
    -c Release `
    -r win-x64 `
    --self-contained true `
    -p:PublishSingleFile=false `
    -o $publishDir

if ($LASTEXITCODE -ne 0) {
    throw "Falló el comando 'dotnet publish'."
}

# Copiar también la carpeta Database dentro de publish para que funcione incluso en modo portable
$publishDbDir = Join-Path $publishDir "Database"
New-Item -ItemType Directory -Force -Path $publishDbDir | Out-Null
Copy-Item -Path $bakPath -Destination (Join-Path $publishDbDir "MobileSolutions_Initial.bak") -Force

Write-Host "[OK] Publicación Self-Contained completada en: $publishDir" -ForegroundColor Green

Write-Host "`n============================================================" -ForegroundColor Cyan
Write-Host " 3/3 - Compilando Instalador con Inno Setup (ISCC.exe)" -ForegroundColor Cyan
Write-Host "============================================================" -ForegroundColor Cyan

$isccCandidates = @(
    "${env:ProgramFiles(x86)}\Inno Setup 6\ISCC.exe",
    "$env:ProgramFiles\Inno Setup 6\ISCC.exe",
    "$env:LOCALAPPDATA\Programs\Inno Setup 6\ISCC.exe"
)

$isccPath = $isccCandidates | Where-Object { Test-Path $_ } | Select-Object -First 1

if ($null -eq $isccPath) {
    Write-Host "[INFO] Inno Setup 6 no detectado. Intentando instalar vía winget..." -ForegroundColor Yellow
    winget install --id JRSoftware.InnoSetup -e --silent --accept-package-agreements --accept-source-agreements
    $isccPath = $isccCandidates | Where-Object { Test-Path $_ } | Select-Object -First 1
}

if ($null -ne $isccPath) {
    & $isccPath (Join-Path $repoRoot "MobileSolutions.iss")
    if ($LASTEXITCODE -ne 0) {
        throw "Falló la compilación de Inno Setup."
    }
    $setupExe = Join-Path $repoRoot "InstallerOutput\MobileSolutions_Setup.exe"
    Write-Host "`n[ÉXITO] Instalador generado correctamente en:" -ForegroundColor Green
    Write-Host " -> $setupExe" -ForegroundColor White
} else {
    Write-Host "[WARN] No se encontró ISCC.exe (Inno Setup 6). Abre 'MobileSolutions.iss' con Inno Setup y presiona Ctrl+F9." -ForegroundColor Yellow
}
