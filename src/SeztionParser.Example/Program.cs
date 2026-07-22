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
