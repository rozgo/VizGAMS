using System;
using System.IO;
using UnrealBuildTool;

public class UnrealGAMSLibrary : ModuleRules
{
	public UnrealGAMSLibrary(ReadOnlyTargetRules Target) : base(Target)
	{
		Type = ModuleType.External;

		string envAceRoot = Environment.GetEnvironmentVariable("ACE_ROOT", EnvironmentVariableTarget.Process);
		string envMadaraRoot = Environment.GetEnvironmentVariable("MADARA_ROOT", EnvironmentVariableTarget.Process);
		string envGAMSRoot = Environment.GetEnvironmentVariable("GAMS_ROOT", EnvironmentVariableTarget.Process);

		if (Target.Platform == UnrealTargetPlatform.Linux)
		{
			PublicLibraryPaths.Add(Path.Combine(envAceRoot, "lib"));
			PublicLibraryPaths.Add(Path.Combine(envMadaraRoot, "lib"));
			PublicLibraryPaths.Add(envGAMSRoot);

			PublicAdditionalLibraries.Add("ACE");
			PublicAdditionalLibraries.Add("MADARA");
			PublicAdditionalLibraries.Add("GAMS");
		}

	}
}
