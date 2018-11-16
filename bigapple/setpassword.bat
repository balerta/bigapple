@ECHO OFF
cd /D "%~dp0"
PowerShell.exe -Command "& '%~dpn0.ps1'"
PAUSE