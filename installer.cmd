tar -xf keys.zip
powershell -noexit %AppData%\yuzu\fwki\installer.ps1

cd ..\nand\system\Contents\registered\
tar -xf ..\..\..\..\fwki\firmware.zip