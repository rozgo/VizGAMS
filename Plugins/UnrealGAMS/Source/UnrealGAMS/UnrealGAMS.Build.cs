// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System;
using System.IO;

public class UnrealGAMS : ModuleRules
{
	public UnrealGAMS(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		string envAceRoot = Environment.GetEnvironmentVariable("ACE_ROOT", EnvironmentVariableTarget.Process);
		string envMadaraRoot = Environment.GetEnvironmentVariable("MADARA_ROOT", EnvironmentVariableTarget.Process);
		string envGAMSRoot = Environment.GetEnvironmentVariable("GAMS_ROOT", EnvironmentVariableTarget.Process);
		
		PublicIncludePaths.AddRange(
			new string[] {
				"UnrealGAMS/Public",
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"UnrealGAMS/Private",
				envAceRoot,
				Path.Combine(envMadaraRoot, "include"),
				Path.Combine(envGAMSRoot, "src"),
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"UnrealGAMSLibrary",
				"Projects"
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
     			"Engine",
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
