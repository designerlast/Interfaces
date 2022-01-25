@echo off
rem 把本批处理复制到每个项目，在工程设置的Build Event设置Post-Build为：
rem   PostBuild.cmd $(ProjectDir) $(OutDir) $(TargetName) $(ProjectName) $(ConfigurationName)
rem 该批处理会混淆dll并打包生成nuget package，调用obj\NugetPush.cmd完成发布。

echo Enter post build and wait for obfuscating... 
mutex IntellVega

echo Starting obfuscating... (ProjectDir = %1, OutDir = %2, TargetName = %3, ProjectName = %4, ConfigurationName = %5)
set backupName=%3_backup

set txtfile=%2\%3_PostBuildInfo.txt
set cmdfile=%1obj\NugetPush.cmd
echo ren %2%3.dll %backupName%.dll
if exist %cmdfile%                del %cmdfile%
if exist %2%backupName%.dll       del %2%backupName%.dll
if exist %2%backupName%.pdb       del %2%backupName%.pdb
if exist %2%backupName%.deps.json del %2%backupName%.deps.json
ren %2%3.dll %backupName%.dll
ren %2%3.pdb %backupName%.pdb
ren %2%3.deps.json %backupName%.deps.json


"C:\Program Files\Red Gate\SmartAssembly 8\SmartAssembly.com" ^
    /build "%1Obfuscator.saproj" ^
    /input="%2%backupName%.dll" ^
    /output="%2%3.dll" ^
    /keyfilename=false ^
    /tamperprotection=false ^
    /sealclasses=true ^
    /preventildasm=true ^
    /fieldobfuscation=2 ^
    /typemethodobfuscation=3 ^
    /methodparentobfuscation=true ^
    /cgsobfuscation=true ^
    /stringsencoding=true;improved:true,compressencrypt:true,cache:true ^
    /makepdb=portable ^
    /obfuscatepdburls=false ^
    /assembly=%3;prune:true,merge:false,nameobfuscate:true,dynamicproxy:true,compressencryptresources:true,controlflowobfuscate:1 > %txtfile% 2>&1
echo Obfuscating finished.
mutex /release IntellVega

if %errorlevel% EQU 9009 echo Failed to find SmartAssembly.com "C:\Program Files\Red Gate\SmartAssembly 8\". Please make sure SmartAssembly is installed. & goto Error
if %errorlevel% NEQ 0 goto Error

copy %txtfile% %txtfile%.bak

echo dotnet pack %4.csproj --no-build -c %5
dotnet pack %4.csproj --no-build  -c %5 > %txtfile% 2>&1
echo Packing finished.

if %errorlevel% NEQ 0 (dotnet pack %4.csproj --no-build -c %5 & if %errorlevel% NEQ 0 goto Error)

SETLOCAL EnableDelayedExpansion
for /f "Tokens=* Delims=" %%x in (%txtfile%) do set packPath=%%x
set proDir=%1
set diskSymbol=%proDir:~0,1%

rem set packPath=%packPath% hello
set from=:
set to=nupkg
For /F "Delims=" %%A In ('Echo %%packPath:*%from%^=%%'
) Do Set "subStringA=%%A"

if "%subStringA%"=="%packPath%" (echo Failed to find '%from%' & set errorlevel=1 & goto Error)

For /F "Delims=" %%A In ('Echo %%subStringA:%to%^=^&:%%'
) Do Set "subString=%%A"
if "%subString%"=="%subStringA%" (echo Failed to find '%to%' & set errorlevel=1 & goto Error)
rem echo a = %subStringA%, b = %subString%

set finalPath=%diskSymbol%%from%%subString%%to%

rem echo from = %from%, to = %to%, subString = %subString%, packPath = %packPath%
echo Extract package path: %finalPath%

echo nuget push %finalPath% -source http://69.230.220.250:8081/repository/nuget-hosted/ > %cmdfile%
echo @@@ %cmdfile%
echo nuget push %finalPath% -source http://69.230.220.250:8081/repository/nuget-hosted/

rem nuget setapikey 08197060-2848-3706-9e40-93d8d63bdXXX -source http://69.230.220.250:8081/repository/nuget-hosted/

rem nuget push %outputstring1%IntellVega.WorkBench.PropertyEditor.1.0.0-preview202108031425.nupkg -source http://69.230.220.250:8081/repository/nuget-hosted/
goto OK

:Error
set prevError=%errorlevel%
echo *** Error occured. Error code = %prevError% ***
type %txtfile%
echo *** End of error infomation ***
exit %prevError%

:OK
if exist %textfile% echo del %textfile%
