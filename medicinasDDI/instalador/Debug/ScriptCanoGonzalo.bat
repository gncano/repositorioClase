@echo off
echo Iniciando instalacion de la aplicacion...
start /wait "" "setup.exe"

echo Instalacion finalizada.
echo Creando base de datos...

sqlcmd -S BENDER\GONZALOCANO_2025 -E -i scriptBBDD.sql

echo Base de datos creada correctamente.
echo Proceso completado.
pause