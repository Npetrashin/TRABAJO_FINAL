using UnrealBuildTool;

public class MatematicasenAClientTarget : TargetRules
{
	public MatematicasenAClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MatematicasenA");
	}
}
