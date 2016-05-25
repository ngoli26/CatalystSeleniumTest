echo off
set folder="C:\CatalystSeleniumTest\TestResults"
cd /d %folder%
for /F "delims=" %%i in ('dir /b') do (rmdir "%%i" /s/q || del "%%i" /s/q)

call "%C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\Tools\VsDevCmd.bat"

call mstest /testcontainer:C:\CatalystSeleniumTest\CatalystSeleniumTest.dll /resultsfile:C:\CatalystSeleniumTest\TestResults\SeleniumTestResults.trx >C:\CatalystSeleniumTest\TestResults\SeleniumTestResults.txt

::call C:\CatalystSeleniumTest\converter\trx2html.exe "C:\CatalystSeleniumTest\TestResults\SeleniumTestResults.trx"

PowerShell.exe -NoProfile -ExecutionPolicy Unrestricted -Command "& 'C:\CatalystSeleniumTest\Scripts\sendemail.ps1'"