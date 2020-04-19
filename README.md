# BannerlordPlayground
Here's a rundown of the repository:

- The `BannerlordPlayground.csproj` is the entrypoint of the building process and holds all the details of your project.
- The `env.xml` file holds any build configuration particular to your environment, like where the game's installed. It doesn't exist by default though, you have to create it from `env.example.xml`.
- The module's files go into the `Module` directory. Everything there will be copied as-is to the final distributable folder, with just one exception...
- The `SubModule.xml` will have macros, like `$(Name)` and `$(Version)` replaced with their actual value by the `PostBuild.ps1` script.
- The `BannerlordPlaygroundSubModule.cs` is the entrypoint of your source code. The resulting DLL will also be copied into the final distributable folder by `PostBuild.ps1` script.
- You build the project using the [MSBuild CLI](https://docs.microsoft.com/en-us/visualstudio/msbuild/msbuild-command-line-reference?view=vs-2019). See the [Development section](#Development) below.


# Installation

Download the latest release from [Releases](releases) and extract into the `Modules` directory inside your game installation folder. e.g. `C:\Steam\steamapps\common\Mount & Blade II Bannerlord`.

Open the game launcher, enable the module and click Play.

# Usage

_Write instructions for the player..._

# Development

Copy `env.example.xml` to `env.xml` and edit the settings according to your environment. Watch out for the ampersand in XML files.

The `PostBuild.ps1` script will auto execute on successful builds, and assemble the final distributable folder of the module inside the `.\dist` directory.

## Debug

```ps1
PS C:\> dotnet build -c Debug
```

When you build in `Debug` configuration the `PostBuild.ps1` script will also copy the module folder in place and launch the game loading a bare minimum set of modules for a quick test run.

## Release

```ps1
PS C:\> dotnet build -c Release
```

When you build in `Release` configuration the `PostBuild.ps1` script will also produce an archive in the `.\dist` directory, specific to the version being built. That's what you upload to the internet.

Remember to bump the version inside the `csproj` file, tag the commit--like this `v1.0.0`--and rebuild.

# Legal

MIT © 2020 Konstantin Fedorov

This modification is not created by, affiliated with or sponsored by TaleWorlds Entertainment or its affiliates. The Mount & Blade II Bannerlord API and related logos are intelectual property of TaleWorlds Entertainment. All rights reserved.