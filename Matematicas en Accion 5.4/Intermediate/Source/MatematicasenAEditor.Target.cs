using UnrealBuildTool;

public class MatematicasenAEditorTarget : TargetRules
{
	public MatematicasenAEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MatematicasenA");
	}
}
