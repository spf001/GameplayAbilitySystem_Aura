// Copyright spf

using UnrealBuildTool;
using System.Collections.Generic;

public class GASRPGTarget : TargetRules
{
	public GASRPGTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "GASRPG" } );
	}
}
