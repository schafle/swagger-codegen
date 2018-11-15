:: Generated by: https://github.com/swagger-api/swagger-codegen.git
::

@echo off

SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v3.5

if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://dist.nuget.org/win-x86-commandline/latest/nuget.exe', '.\nuget.exe')"
.\nuget.exe install srcIO.Swagger\packages.config -o packages

if not exist ".\bin" mkdir bin

copy packages\Newtonsoft.Json.10.0.3\libnet35\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\JsonSubTypes.1.2.0\libnet35\JsonSubTypes.dll bin\JsonSubTypes.dll
copy packages\RestSharp.105.1.0\libnet35\RestSharp.dll bin\RestSharp.dll
%CSCPATH%\csc  /reference:bin\Newtonsoft.Json.dll;bin\JsonSubTypes.dll;bin\RestSharp.dll;System.ComponentModel.DataAnnotations.dll  /target:library /out:binIO.Swagger.dll /recurse:srcIO.Swagger\*.cs /doc:binIO.Swagger.xml

