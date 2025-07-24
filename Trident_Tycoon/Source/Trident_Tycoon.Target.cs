// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Trident_TycoonTarget : TargetRules
{
	public Trident_TycoonTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;
        

        ExtraModuleNames.AddRange( new string[] { "Trident_Tycoon" } );
	}
}
