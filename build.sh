#!/bin/sh
cd ./Windows/C#/HsvScreensaver/
msbuild64="/c/Windows/Microsoft.NET/Framework64/v4.0.30319/MSBuild.exe"
msbuild86="/c/Windows/Microsoft.NET/Framework/v4.0.30319/MSBuild.exe"
$msbuild64  /property:Configuration=Release  /property:Platform=x64  HsvScreensaver.csproj
$msbuild86  /property:Configuration=Release  /property:Platform=x86  HsvScreensaver.csproj
