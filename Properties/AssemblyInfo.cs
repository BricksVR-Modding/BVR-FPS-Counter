using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(FPSmod.BuildInfo.Description)]
[assembly: AssemblyDescription(FPSmod.BuildInfo.Description)]
[assembly: AssemblyCompany(FPSmod.BuildInfo.Company)]
[assembly: AssemblyProduct(FPSmod.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + FPSmod.BuildInfo.Author)]
[assembly: AssemblyTrademark(FPSmod.BuildInfo.Company)]
[assembly: AssemblyVersion(FPSmod.BuildInfo.Version)]
[assembly: AssemblyFileVersion(FPSmod.BuildInfo.Version)]
[assembly: MelonInfo(typeof(FPSmod.FPSmod), FPSmod.BuildInfo.Name, FPSmod.BuildInfo.Version, FPSmod.BuildInfo.Author, FPSmod.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("BricksVR", "BricksVR")]