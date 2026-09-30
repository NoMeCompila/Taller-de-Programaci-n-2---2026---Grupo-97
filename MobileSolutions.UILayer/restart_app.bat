@echo off
cd /d "%~dp0"
if exist "bin\Debug\net10.0-windows\MobileSolutions.UILayer.exe" (
    start "" "bin\Debug\net10.0-windows\MobileSolutions.UILayer.exe"
) else if exist "MobileSolutions.UILayer.exe" (
    start "" "MobileSolutions.UILayer.exe"
)
exit

