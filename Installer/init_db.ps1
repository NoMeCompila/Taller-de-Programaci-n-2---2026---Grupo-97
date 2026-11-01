# ==============================================================================
# Script de Inicialización Automática de Base de Datos (MobileSolutionsDB)
# Se ejecuta durante la instalación de Inno Setup o manualmente para aprovisionar
# la base de datos en SQL Server Express LocalDB ((localdb)\MSSQLLocalDB).
# ==============================================================================
$ErrorActionPreference = "Stop"

# 1. Asegurar que la instancia MSSQLLocalDB exista y esté iniciada
try {
    sqllocaldb create MSSQLLocalDB -s | Out-Null
} catch {
    sqllocaldb start MSSQLLocalDB | Out-Null
}

$server = "(localdb)\MSSQLLocalDB"
$dbName = "MobileSolutionsDB"

# 2. Verificar si MobileSolutionsDB ya existe en la PC del cliente
$masterConn = New-Object System.Data.SqlClient.SqlConnection("Server=$server;Database=master;Trusted_Connection=True;TrustServerCertificate=True;")
$masterConn.Open()

try {
    $checkCmd = $masterConn.CreateCommand()
    $checkCmd.CommandText = "SELECT COUNT(*) FROM sys.databases WHERE name = '$dbName'"
    $exists = [int]$checkCmd.ExecuteScalar()

    if ($exists -gt 0) {
        Write-Host "La base de datos '$dbName' ya existe. Se preservan los datos actuales del usuario."
        return
    }

    # 3. Buscar el backup semilla MobileSolutions_Initial.bak
    $bakCandidates = @(
        (Join-Path $PSScriptRoot "Database\MobileSolutions_Initial.bak"),
        (Join-Path $PSScriptRoot "MobileSolutions_Initial.bak")
    )

    $bakPath = $bakCandidates | Where-Object { Test-Path $_ } | Select-Object -First 1

    if ($null -ne $bakPath) {
        $dataFolder = Join-Path $env:LOCALAPPDATA "MobileSolutions\Data"
        New-Item -ItemType Directory -Force -Path $dataFolder | Out-Null

        $mdfPath = Join-Path $dataFolder "MobileSolutionsDB.mdf"
        $ldfPath = Join-Path $dataFolder "MobileSolutionsDB_log.ldf"

        $restoreCmd = $masterConn.CreateCommand()
        $restoreCmd.CommandTimeout = 300
        $restoreCmd.CommandText = @"
            RESTORE DATABASE [MobileSolutionsDB]
            FROM DISK = N'$bakPath'
            WITH MOVE N'MobileSolutionsDB' TO N'$mdfPath',
                 MOVE N'MobileSolutionsDB_log' TO N'$ldfPath',
                 REPLACE,
                 RECOVERY;
"@
        [void]$restoreCmd.ExecuteNonQuery()
        Write-Host "Base de datos '$dbName' restaurada exitosamente en: $dataFolder"
    }
} finally {
    $masterConn.Close()
}
