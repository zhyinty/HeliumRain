// Helium Rain Project - http://helium-rain.com

using UnrealBuildTool;

public class HeliumRain : ModuleRules
{
	public HeliumRain(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(
            new string[] {
				"Core",
				"CoreUObject",
				"Engine",
				"OnlineSubsystem",
				"OnlineSubsystemUtils",
                "RHI",
                "RenderCore",
                "Http",
                "Json",
                "JsonUtilities",
                "Projects"
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[] {
				"InputCore",
				"Slate",
				"SlateCore",
				"HeliumRainLoadingScreen",
                "AppFramework"
            }
        );

        PublicIncludePaths.AddRange(
            new string[]
            {
                "HeliumRainLoadingScreen"
            }
        );
        
        PrivateDependencyModuleNames.Add("OnlineSubsystem");
        DynamicallyLoadedModuleNames.Add("OnlineSubsystemSteam");
    }
}
