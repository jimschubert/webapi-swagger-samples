#!/usr/bin/env bash
wget -nc https://nuget.org/nuget.exe;
mozroots --import --sync
mono nuget.exe install src/Petstore/packages.config -o src/Packages;
mkdir -p src/Petstore/bin;

## Build
mcs -sdk:45 -r:src/packages/Microsoft.AspNet.WebApi.Core.5.2.3/lib/net45/System.Web.Http.dll,\
src/packages/Microsoft.CodeDom.Providers.DotNetCompilerPlatform.1.0.0/lib/net45/Microsoft.CodeDom.Providers.DotNetCompilerPlatform.dll,\
src/packages/Newtonsoft.Json.8.0.2/lib/net45/Newtonsoft.Json.dll,\
src/packages/WebActivatorEx.2.0/lib/net40/WebActivatorEx.dll,\
src/packages/Microsoft.AspNet.WebApi.WebHost.5.2.3/lib/net45/System.Web.Http.WebHost.dll,\
src/packages/Microsoft.AspNet.WebApi.Cors.5.2.3/lib/net45/System.Web.Http.Cors.dll,\
src/packages/Microsoft.AspNet.Cors.5.2.3/lib/net45/System.Web.Cors.dll,\
src/packages/Microsoft.AspNet.WebApi.Client.5.2.3/lib/net45/System.Net.Http.Formatting.dll,\
src/packages/Microsoft.Web.Infrastructure.1.0.0.0/lib/net40/Microsoft.Web.Infrastructure.dll,\
src/packages/Swashbuckle.Core.5.2.2/lib/net40/Swashbuckle.Core.dll \
-pkg:dotnet \
-target:library \
-out:src/Petstore/bin/Petstore.dll \
-recurse:'src/*.cs' \
-doc:src/Petstore/bin/Petstore.xml \
-platform:anycpu
