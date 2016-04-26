#!/usr/bin/env bash
frameworkVersion=net45
netfx=${frameworkVersion#net}

wget -nc https://nuget.org/nuget.exe;
mozroots --import --sync
mono nuget.exe install ./packages.config -o vendor;
mkdir -p bin;

mkdir bin/${frameworkVersion}

# Rename RestSharp net4 to net40
if [ ! -d "vendor/RestSharp.105.2.3/lib/${frameworkVersion}" ]; then
  mv "vendor/RestSharp.105.2.3/lib/net4" "vendor/RestSharp.105.2.3/lib/${frameworkVersion}"
fi

cp vendor/Newtonsoft.Json.8.0.3/lib/${frameworkVersion}/Newtonsoft.Json.dll bin/${frameworkVersion}/Newtonsoft.Json.dll;
cp vendor/RestSharp.105.2.3/lib/${frameworkVersion}/RestSharp.dll bin/${frameworkVersion}/RestSharp.dll;

mcs -sdk:${netfx} -r:bin/${frameworkVersion}/Newtonsoft.Json.dll,\
bin/${frameworkVersion}/RestSharp.dll,\
System.Runtime.Serialization.dll \
-target:library \
-out:bin/${frameworkVersion}/Aylien.NewsApi.dll \
-recurse:'src/*.cs' \
-doc:bin/${frameworkVersion}/Aylien.NewsApi.xml \
-platform:anycpu
