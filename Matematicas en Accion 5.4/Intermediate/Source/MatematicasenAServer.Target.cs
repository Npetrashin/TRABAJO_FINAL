using UnrealBuildTool;

public class MatematicasenAServerTarget : TargetRules
{
	public MatematicasenAServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MatematicasenA");
	}
}
