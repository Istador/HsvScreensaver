#!/bin/sh
cd ./Windows/C#/HsvScreensaver/
msbuild="/c/Windows/Microsoft.NET/Framework64/v4.0.30319/MSBuild.exe"
$msbuild  /property:Configuration=Release  /property:Platform=x64  HsvScreensaver.csproj
$msbuild  /property:Configuration=Release  /property:Platform=x86  HsvScreensaver.csproj
