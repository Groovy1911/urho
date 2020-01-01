@echo off
call :ReportFolderState "..\Bin"
call :ReportFolderState "..\Bin\Android"

@echo on
copy /Y Android.cmake ..\Urho3D\Source\CMake\Toolchains
copy /Y CMakeLists.txt ..\Urho3D\Source\Source\Urho3D
copy /Y Mono.cpp ..\Urho3D\Source\Source\Urho3D
copy /Y Mono.h ..\Urho3D\Source\Source\Urho3D
pause
exit


:GetDirParentN
    for %%I in ("%~2\%~3") do set "%~1=%%~fI"
    exit /b 0

:GetFileBaseDirWithoutEndSlash
    set "dirWithBackSlash=%~dp2"
    REM substring from the start to the end minus 1 char from the end
    set "%~1=%dirWithBackSlash:~0,-1%"
    exit /b 0

:ReportFolderState
@call :GetDirParentN dirFileParent "%~1"
call :GetFileBaseDirWithoutEndSlash dirFileBaseWithBackSlash "%dirFileParent%"
@call :CheckFolder "%dirFileBaseWithBackSlash%"
@set RESULT=%ERRORLEVEL%
@if %RESULT% equ 999 (
	@echo not exists!
	mkdir "%~1"
	)
@if %RESULT% equ 1 ( 
	@echo not empty!
    for /F "delims=" %%i in ("%dirFileBaseWithBackSlash%\*.*") do (rmdir "%%i" /s/q || del "%%i" /s/q)
	)
@if %RESULT% equ 0   @echo Empty!
@exit /b 
 
:CheckFolder
@if not exist "%~1" @exit /b 999
@for /F "delims=" %%I in ('dir /b "%~1\*.*"') do @exit /b 1
@exit /b 0

