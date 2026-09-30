// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GASgame : ModuleRules
{
	public GASgame(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"GASgame",
			"GASgame/Variant_Platforming",
			"GASgame/Variant_Platforming/Animation",
			"GASgame/Variant_Combat",
			"GASgame/Variant_Combat/AI",
			"GASgame/Variant_Combat/Animation",
			"GASgame/Variant_Combat/Gameplay",
			"GASgame/Variant_Combat/Interfaces",
			"GASgame/Variant_Combat/UI",
			"GASgame/Variant_SideScrolling",
			"GASgame/Variant_SideScrolling/AI",
			"GASgame/Variant_SideScrolling/Gameplay",
			"GASgame/Variant_SideScrolling/Interfaces",
			"GASgame/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
