@echo off

SETLOCAL enabledelayedexpansion

SET MSBUILD_PATH="C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe"
SET PROJECT_PATH="C:\Users\Anon\Desktop\ConfigurationManagement\FileSaver\FileSaver.csproj"

%MSBUILD_PATH% %PROJECT_PATH%
pause
