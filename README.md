# seztion-parser

[![seztion-parser-logo](https://raw.githubusercontent.com/DevD4v3/seztion-parser/main/docs/images/seztionparser-logo.png)](https://github.com/DevD4v3/seztion-parser)

[![seztion-parser](https://img.shields.io/nuget/vpre/seztion-parser?label=Seztion.Parser%20-%20nuget&color=red)](https://www.nuget.org/packages/seztion-parser)
[![downloads](https://img.shields.io/nuget/dt/seztion-parser?color=yellow)](https://www.nuget.org/packages/seztion-parser)
[![license](https://img.shields.io/badge/License-MIT-green)](https://raw.githubusercontent.com/DevD4v3/seztion-parser/master/LICENSE)

**Seztion Parser** is a lightweight .NET library for reading section-based configuration files, such as `.ini` files. It provides a simple API for accessing the contents of each section while remaining independent of the file extension.

## Why this library exists

Seztion Parser was originally developed for the [Capture the Flag](https://github.com/DevD4v3/Capture-The-Flag) game mode for [SA-MP](https://www.sa-mp.mp) (San Andreas Multiplayer), a multiplayer mod for GTA San Andreas.

Each map configuration file contained information such as:

- Alpha team spawn locations
- Beta team spawn locations
- Red and blue flag locations
- Interior ID
- Weather
- World time

Instead of using a database, each map's configuration was stored in an INI file organized into sections.

```ini
#
# Aim_Headshot Map
#

# Format: X,Y,Z,Angle
[AlphaTeamLocations]
-669.9301,2567.7261,233.1899,4.0968
-662.3662,2568.0757,233.1899,4.4101

[BetaTeamLocations]
-656.4174,2739.6848,219.2168,177.9750
-650.9906,2739.0764,219.2168,177.9750

# Format: X,Y,Z
[RedFlagLocation]
-729.1639,2635.3447,223.3559

[BlueFlagLocation]
-576.2537,2731.9312,233.3905

[Interior]
10

[Weather]
1

[WorldTime]
12
```

Seztion Parser provides a straightforward API for loading this configuration and accessing each section.

## Features

- Read section-based configuration files.
- Access sections by name.
- Enumerate all values within a section.
- Read typed values from the first line of a section.
- Supports any file extension (not limited to `.ini`).
- Lightweight with no external dependencies.

## Installation

Install the package using the .NET CLI:

```bash
dotnet add package seztion-parser
```

Or using the NuGet Package Manager:

```powershell
Install-Package seztion-parser
```

## Usage

The following example loads the map configuration and reads the data from each section.

```csharp
using SeztionParser;

ISectionsData sections = SectionsFile.Load("Aim_Headshot.ini");

Console.WriteLine("[AlphaTeamLocations]");
ISectionData alphaTeamLocations = sections["AlphaTeamLocations"];
foreach (string data in alphaTeamLocations)
    Console.WriteLine(data);

Console.WriteLine();

Console.WriteLine("[BetaTeamLocations]");
ISectionData betaTeamLocations = sections["BetaTeamLocations"];
foreach (string data in betaTeamLocations)
    Console.WriteLine(data);

Console.WriteLine();

Console.WriteLine("[RedFlagLocation]");
ISectionData redFlagLocation = sections["RedFlagLocation"];
foreach (string data in redFlagLocation)
    Console.WriteLine(data);

Console.WriteLine();

Console.WriteLine("[BlueFlagLocation]");
ISectionData blueFlagLocation = sections["BlueFlagLocation"];
foreach (string data in blueFlagLocation)
    Console.WriteLine(data);

int interior = sections.GetFirstLineInt("Interior");
Console.WriteLine();
Console.WriteLine("[Interior]");
Console.WriteLine(interior);

int weather = sections.GetFirstLineInt("Weather");
Console.WriteLine();
Console.WriteLine("[Weather]");
Console.WriteLine(weather);

int worldTime = sections.GetFirstLineInt("WorldTime");
Console.WriteLine();
Console.WriteLine("[WorldTime]");
Console.WriteLine(worldTime);
```

## Documentation

Documentation is available on the project website.

- [Website](https://DevD4v3.github.io/seztion-parser)
- [Getting Started](https://DevD4v3.github.io/seztion-parser/articles/getting_started.html)
- [API Reference](https://DevD4v3.github.io/seztion-parser/api/SeztionParser.html)

## Contribution

Contributions of all kinds are welcome! You can help by improving the code, documentation, or tests.

To contribute:

- Fork the repository.
- Create a feature branch (`git checkout -b my-new-change`).
- Commit your changes (`git commit -am "Add some change"`).
- Push to your branch (`git push origin my-new-change`).
- Open a Pull Request.

## License

This project is licensed under the MIT License. See the [LICENSE](https://github.com/DevD4v3/seztion-parser/blob/main/LICENSE) file for details.