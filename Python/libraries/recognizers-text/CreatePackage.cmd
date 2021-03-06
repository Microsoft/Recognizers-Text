@echo off
echo *** Building Microsoft.Recognizers.Text
setlocal
setlocal enabledelayedexpansion
setlocal enableextensions

if not exist ..\dist mkdir ..\dist
if exist ..\dist\Microsoft.Recognizers.Text*.whl erase /s ..\dist\Microsoft.Recognizers.Text*.whl
python setup.py bdist_wheel -d ..\dist\

set error=%errorlevel%
set packageName=Microsoft.Recognizers.Text
if %error% NEQ 0 (
	echo *** Failed to build %packageName%
	exit /b %error%
) else (
	echo *** Succeeded to build %packageName%
)