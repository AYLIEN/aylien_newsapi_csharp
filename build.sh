#!/usr/bin/env bash
#
# Copyright 2017 Aylien, Inc. All Rights Reserved.

# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at

#     http://www.apache.org/licenses/LICENSE-2.0

# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

frameworkVersion=net45
netfx=${frameworkVersion#net}

wget -nc https://nuget.org/nuget.exe;
cert-sync --import --sync
mono nuget.exe install ./src/main/csharp/Aylien.NewsApi/packages.config -o vendor;
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
System.ComponentModel.DataAnnotations.dll,\
System.Runtime.Serialization.dll \
-target:library \
-out:bin/${frameworkVersion}/Aylien.NewsApi.dll \
-recurse:'src/*.cs' \
-doc:bin/${frameworkVersion}/Aylien.NewsApi.xml \
-platform:anycpu