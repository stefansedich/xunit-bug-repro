#!/bin/bash

# Nuget Restore

mono ./.nuget/NuGet.exe restore BugRepro.sln

# Build

xbuild ./BugRepro.Tests/BugRepro.Tests.csproj
xbuild ./BugRepro.Console/BugRepro.Console.csproj

# Execute

mono ./BugRepro.Console/bin/Debug/BugRepro.Console.exe
mono ./packages/xunit.runner.console.2.1.0/tools/xunit.console.exe ./BugRepro.Tests/bin/Debug/BugRepro.Tests.dll