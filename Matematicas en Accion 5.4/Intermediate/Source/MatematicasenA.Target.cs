using UnrealBuildTool;

public class MatematicasenATarget : TargetRules
{
	public MatematicasenATarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MatematicasenA");
	}
}
