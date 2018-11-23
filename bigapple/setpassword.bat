@ECHO OFF
cd /D "%~dp0"
PowerShell.exe -noprofile -executionpolicy bypass -file .\setpassword.ps1
PAUSE