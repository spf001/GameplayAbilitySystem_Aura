// Copyright spf

using UnrealBuildTool;
using System.Collections.Generic;

public class GASRPGEditorTarget : TargetRules
{
	public GASRPGEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "GASRPG" } );
	}
}