using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Il2Cpp
{
	// Token: 0x02000030 RID: 48
	public class SoundSystem : MonoBehaviour
	{
		// Token: 0x060005D2 RID: 1490 RVA: 0x00045BAC File Offset: 0x00043DAC
		// Note: this type is marked as 'beforefieldinit'.
		static SoundSystem()
		{
			Il2CppClassPointerStore<SoundSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SoundSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr);
			SoundSystem.NativeFieldInfoPtr_AmbianceAudSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "AmbianceAudSource");
			SoundSystem.NativeFieldInfoPtr_SECTRMixerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "SECTRMixerGroup");
			SoundSystem.NativeFieldInfoPtr_AmbianceMixerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "AmbianceMixerGroup");
			SoundSystem.NativeFieldInfoPtr_MetaMixerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MetaMixerGroup");
			SoundSystem.NativeFieldInfoPtr_ApplianceMatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApplianceMatCue");
			SoundSystem.NativeFieldInfoPtr_BarsMatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BarsMatCue");
			SoundSystem.NativeFieldInfoPtr_ConcreteMatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ConcreteMatCue");
			SoundSystem.NativeFieldInfoPtr_DryWallMatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "DryWallMatCue");
			SoundSystem.NativeFieldInfoPtr_FenceMatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FenceMatCue");
			SoundSystem.NativeFieldInfoPtr_FleshMatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FleshMatCue");
			SoundSystem.NativeFieldInfoPtr_RockMatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "RockMatCue");
			SoundSystem.NativeFieldInfoPtr_ThickMetalMatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ThickMetalMatCue");
			SoundSystem.NativeFieldInfoPtr_ThinMetalMatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ThinMetalMatCue");
			SoundSystem.NativeFieldInfoPtr_TreeMatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "TreeMatCue");
			SoundSystem.NativeFieldInfoPtr_WoodMatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "WoodMatCue");
			SoundSystem.NativeFieldInfoPtr_ApplianceSplatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApplianceSplatCue");
			SoundSystem.NativeFieldInfoPtr_BarsSplatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BarsSplatCue");
			SoundSystem.NativeFieldInfoPtr_ConcreteSplatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ConcreteSplatCue");
			SoundSystem.NativeFieldInfoPtr_DryWallSplatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "DryWallSplatCue");
			SoundSystem.NativeFieldInfoPtr_FenceSplatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FenceSplatCue");
			SoundSystem.NativeFieldInfoPtr_FleshSplatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FleshSplatCue");
			SoundSystem.NativeFieldInfoPtr_RockSplatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "RockSplatCue");
			SoundSystem.NativeFieldInfoPtr_ThickMetalSplatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ThickMetalSplatCue");
			SoundSystem.NativeFieldInfoPtr_ThinMetalSplatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ThinMetalSplatCue");
			SoundSystem.NativeFieldInfoPtr_TreeSplatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "TreeSplatCue");
			SoundSystem.NativeFieldInfoPtr_WoodSplatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "WoodSplatCue");
			SoundSystem.NativeFieldInfoPtr_BulletHitFleshCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BulletHitFleshCue");
			SoundSystem.NativeFieldInfoPtr_BulletHitVestCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BulletHitVestCue");
			SoundSystem.NativeFieldInfoPtr_BulletHitConcreteCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BulletHitConcreteCue");
			SoundSystem.NativeFieldInfoPtr_BulletHitWoodCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BulletHitWoodCue");
			SoundSystem.NativeFieldInfoPtr_BulletHitGlassCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BulletHitGlassCue");
			SoundSystem.NativeFieldInfoPtr_BulletHitMetalCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BulletHitMetalCue");
			SoundSystem.NativeFieldInfoPtr_BulletHitMetalDoorCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BulletHitMetalDoorCue");
			SoundSystem.NativeFieldInfoPtr_BulletCasingOnCarpet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BulletCasingOnCarpet");
			SoundSystem.NativeFieldInfoPtr_BulletCasingOnCement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BulletCasingOnCement");
			SoundSystem.NativeFieldInfoPtr_BulletCasingOnDirt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BulletCasingOnDirt");
			SoundSystem.NativeFieldInfoPtr_BulletCasingOnGrass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BulletCasingOnGrass");
			SoundSystem.NativeFieldInfoPtr_BulletCasingOnTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BulletCasingOnTile");
			SoundSystem.NativeFieldInfoPtr_BulletCasingOnLinoleum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BulletCasingOnLinoleum");
			SoundSystem.NativeFieldInfoPtr_BulletCasingOnWood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BulletCasingOnWood");
			SoundSystem.NativeFieldInfoPtr_MachineGunShotCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MachineGunShotCue");
			SoundSystem.NativeFieldInfoPtr_RifleShotCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "RifleShotCue");
			SoundSystem.NativeFieldInfoPtr_RocketLaunchCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "RocketLaunchCue");
			SoundSystem.NativeFieldInfoPtr_ShotgunShotCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ShotgunShotCue");
			SoundSystem.NativeFieldInfoPtr_SniperRifleShotCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "SniperRifleShotCue");
			SoundSystem.NativeFieldInfoPtr_TranquilizerShotCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "TranquilizerShotCue");
			SoundSystem.NativeFieldInfoPtr_MachineGunCockCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MachineGunCockCue");
			SoundSystem.NativeFieldInfoPtr_RifleCockCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "RifleCockCue");
			SoundSystem.NativeFieldInfoPtr_RocketLauncherCockCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "RocketLauncherCockCue");
			SoundSystem.NativeFieldInfoPtr_ShotgunCockCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ShotgunCockCue");
			SoundSystem.NativeFieldInfoPtr_SniperRifleCockCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "SniperRifleCockCue");
			SoundSystem.NativeFieldInfoPtr_TranquilizerCockCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "TranquilizerCockCue");
			SoundSystem.NativeFieldInfoPtr_HeavyGuardAsphaltRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "HeavyGuardAsphaltRunCue");
			SoundSystem.NativeFieldInfoPtr_HeavyGuardAsphaltWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "HeavyGuardAsphaltWalkCue");
			SoundSystem.NativeFieldInfoPtr_HeavyGuardCarpetRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "HeavyGuardCarpetRunCue");
			SoundSystem.NativeFieldInfoPtr_HeavyGuardCarpetWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "HeavyGuardCarpetWalkCue");
			SoundSystem.NativeFieldInfoPtr_HeavyGuardConcreteRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "HeavyGuardConcreteRunCue");
			SoundSystem.NativeFieldInfoPtr_HeavyGuardConcreteWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "HeavyGuardConcreteWalkCue");
			SoundSystem.NativeFieldInfoPtr_HeavyGuardGrassRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "HeavyGuardGrassRunCue");
			SoundSystem.NativeFieldInfoPtr_HeavyGuardGrassWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "HeavyGuardGrassWalkCue");
			SoundSystem.NativeFieldInfoPtr_HeavyGuardLinoleumRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "HeavyGuardLinoleumRunCue");
			SoundSystem.NativeFieldInfoPtr_HeavyGuardLinoleumWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "HeavyGuardLinoleumWalkCue");
			SoundSystem.NativeFieldInfoPtr_HeavyGuardMetalRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "HeavyGuardMetalRunCue");
			SoundSystem.NativeFieldInfoPtr_HeavyGuardMetalWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "HeavyGuardMetalWalkCue");
			SoundSystem.NativeFieldInfoPtr_HeavyGuardTimberRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "HeavyGuardTimberRunCue");
			SoundSystem.NativeFieldInfoPtr_HeavyGuardTimberWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "HeavyGuardTimberWalkCue");
			SoundSystem.NativeFieldInfoPtr_HeavyGuardWoodRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "HeavyGuardWoodRunCue");
			SoundSystem.NativeFieldInfoPtr_HeavyGuardWoodWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "HeavyGuardWoodWalkCue");
			SoundSystem.NativeFieldInfoPtr_LightGuardAsphaltRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightGuardAsphaltRunCue");
			SoundSystem.NativeFieldInfoPtr_LightGuardAsphaltWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightGuardAsphaltWalkCue");
			SoundSystem.NativeFieldInfoPtr_LightGuardCarpetRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightGuardCarpetRunCue");
			SoundSystem.NativeFieldInfoPtr_LightGuardCarpetWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightGuardCarpetWalkCue");
			SoundSystem.NativeFieldInfoPtr_LightGuardConcreteRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightGuardConcreteRunCue");
			SoundSystem.NativeFieldInfoPtr_LightGuardConcreteWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightGuardConcreteWalkCue");
			SoundSystem.NativeFieldInfoPtr_LightGuardGrassRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightGuardGrassRunCue");
			SoundSystem.NativeFieldInfoPtr_LightGuardGrassWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightGuardGrassWalkCue");
			SoundSystem.NativeFieldInfoPtr_LightGuardLinoleumRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightGuardLinoleumRunCue");
			SoundSystem.NativeFieldInfoPtr_LightGuardLinoleumWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightGuardLinoleumWalkCue");
			SoundSystem.NativeFieldInfoPtr_LightGuardMetalRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightGuardMetalRunCue");
			SoundSystem.NativeFieldInfoPtr_LightGuardMetalWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightGuardMetalWalkCue");
			SoundSystem.NativeFieldInfoPtr_LightGuardTimberRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightGuardTimberRunCue");
			SoundSystem.NativeFieldInfoPtr_LightGuardTimberWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightGuardTimberWalkCue");
			SoundSystem.NativeFieldInfoPtr_LightGuardWoodRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightGuardWoodRunCue");
			SoundSystem.NativeFieldInfoPtr_LightGuardWoodWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightGuardWoodWalkCue");
			SoundSystem.NativeFieldInfoPtr_FlameGuardAsphaltRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameGuardAsphaltRunCue");
			SoundSystem.NativeFieldInfoPtr_FlameGuardAsphaltWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameGuardAsphaltWalkCue");
			SoundSystem.NativeFieldInfoPtr_FlameGuardCarpetRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameGuardCarpetRunCue");
			SoundSystem.NativeFieldInfoPtr_FlameGuardCarpetWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameGuardCarpetWalkCue");
			SoundSystem.NativeFieldInfoPtr_FlameGuardConcreteRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameGuardConcreteRunCue");
			SoundSystem.NativeFieldInfoPtr_FlameGuardConcreteWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameGuardConcreteWalkCue");
			SoundSystem.NativeFieldInfoPtr_FlameGuardGrassRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameGuardGrassRunCue");
			SoundSystem.NativeFieldInfoPtr_FlameGuardGrassWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameGuardGrassWalkCue");
			SoundSystem.NativeFieldInfoPtr_FlameGuardLinoleumRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameGuardLinoleumRunCue");
			SoundSystem.NativeFieldInfoPtr_FlameGuardLinoleumWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameGuardLinoleumWalkCue");
			SoundSystem.NativeFieldInfoPtr_FlameGuardMetalRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameGuardMetalRunCue");
			SoundSystem.NativeFieldInfoPtr_FlameGuardMetalWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameGuardMetalWalkCue");
			SoundSystem.NativeFieldInfoPtr_FlameGuardTimberRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameGuardTimberRunCue");
			SoundSystem.NativeFieldInfoPtr_FlameGuardTimberWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameGuardTimberWalkCue");
			SoundSystem.NativeFieldInfoPtr_FlameGuardWoodRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameGuardWoodRunCue");
			SoundSystem.NativeFieldInfoPtr_FlameGuardWoodWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameGuardWoodWalkCue");
			SoundSystem.NativeFieldInfoPtr_MediumGuardAsphaltRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MediumGuardAsphaltRunCue");
			SoundSystem.NativeFieldInfoPtr_MediumGuardAsphaltWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MediumGuardAsphaltWalkCue");
			SoundSystem.NativeFieldInfoPtr_MediumGuardCarpetRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MediumGuardCarpetRunCue");
			SoundSystem.NativeFieldInfoPtr_MediumGuardCarpetWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MediumGuardCarpetWalkCue");
			SoundSystem.NativeFieldInfoPtr_MediumGuardConcreteRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MediumGuardConcreteRunCue");
			SoundSystem.NativeFieldInfoPtr_MediumGuardConcreteWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MediumGuardConcreteWalkCue");
			SoundSystem.NativeFieldInfoPtr_MediumGuardGrassRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MediumGuardGrassRunCue");
			SoundSystem.NativeFieldInfoPtr_MediumGuardGrassWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MediumGuardGrassWalkCue");
			SoundSystem.NativeFieldInfoPtr_MediumGuardLinoleumRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MediumGuardLinoleumRunCue");
			SoundSystem.NativeFieldInfoPtr_MediumGuardLinoleumWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MediumGuardLinoleumWalkCue");
			SoundSystem.NativeFieldInfoPtr_MediumGuardMetalRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MediumGuardMetalRunCue");
			SoundSystem.NativeFieldInfoPtr_MediumGuardMetalWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MediumGuardMetalWalkCue");
			SoundSystem.NativeFieldInfoPtr_MediumGuardTimberRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MediumGuardTimberRunCue");
			SoundSystem.NativeFieldInfoPtr_MediumGuardTimberWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MediumGuardTimberWalkCue");
			SoundSystem.NativeFieldInfoPtr_MediumGuardWoodRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MediumGuardWoodRunCue");
			SoundSystem.NativeFieldInfoPtr_MediumGuardWoodWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MediumGuardWoodWalkCue");
			SoundSystem.NativeFieldInfoPtr_MelvinGuardAsphaltRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MelvinGuardAsphaltRunCue");
			SoundSystem.NativeFieldInfoPtr_MelvinGuardAsphaltWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MelvinGuardAsphaltWalkCue");
			SoundSystem.NativeFieldInfoPtr_MelvinGuardCarpetRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MelvinGuardCarpetRunCue");
			SoundSystem.NativeFieldInfoPtr_MelvinGuardCarpetWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MelvinGuardCarpetWalkCue");
			SoundSystem.NativeFieldInfoPtr_MelvinGuardConcreteRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MelvinGuardConcreteRunCue");
			SoundSystem.NativeFieldInfoPtr_MelvinGuardConcreteWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MelvinGuardConcreteWalkCue");
			SoundSystem.NativeFieldInfoPtr_MelvinGuardGrassRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MelvinGuardGrassRunCue");
			SoundSystem.NativeFieldInfoPtr_MelvinGuardGrassWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MelvinGuardGrassWalkCue");
			SoundSystem.NativeFieldInfoPtr_MelvinGuardLinoleumRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MelvinGuardLinoleumRunCue");
			SoundSystem.NativeFieldInfoPtr_MelvinGuardLinoleumWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MelvinGuardLinoleumWalkCue");
			SoundSystem.NativeFieldInfoPtr_MelvinGuardMetalRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MelvinGuardMetalRunCue");
			SoundSystem.NativeFieldInfoPtr_MelvinGuardMetalWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MelvinGuardMetalWalkCue");
			SoundSystem.NativeFieldInfoPtr_MelvinGuardTimberRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MelvinGuardTimberRunCue");
			SoundSystem.NativeFieldInfoPtr_MelvinGuardTimberWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MelvinGuardTimberWalkCue");
			SoundSystem.NativeFieldInfoPtr_MelvinGuardWoodRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MelvinGuardWoodRunCue");
			SoundSystem.NativeFieldInfoPtr_MelvinGuardWoodWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MelvinGuardWoodWalkCue");
			SoundSystem.NativeFieldInfoPtr_GearlessGuardAsphaltRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GearlessGuardAsphaltRunCue");
			SoundSystem.NativeFieldInfoPtr_GearlessGuardAsphaltWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GearlessGuardAsphaltWalkCue");
			SoundSystem.NativeFieldInfoPtr_GearlessGuardCarpetRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GearlessGuardCarpetRunCue");
			SoundSystem.NativeFieldInfoPtr_GearlessGuardCarpetWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GearlessGuardCarpetWalkCue");
			SoundSystem.NativeFieldInfoPtr_GearlessGuardConcreteRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GearlessGuardConcreteRunCue");
			SoundSystem.NativeFieldInfoPtr_GearlessGuardConcreteWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GearlessGuardConcreteWalkCue");
			SoundSystem.NativeFieldInfoPtr_GearlessGuardGrassRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GearlessGuardGrassRunCue");
			SoundSystem.NativeFieldInfoPtr_GearlessGuardGrassWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GearlessGuardGrassWalkCue");
			SoundSystem.NativeFieldInfoPtr_GearlessGuardLinoleumRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GearlessGuardLinoleumRunCue");
			SoundSystem.NativeFieldInfoPtr_GearlessGuardLinoleumWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GearlessGuardLinoleumWalkCue");
			SoundSystem.NativeFieldInfoPtr_GearlessGuardMetalRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GearlessGuardMetalRunCue");
			SoundSystem.NativeFieldInfoPtr_GearlessGuardMetalWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GearlessGuardMetalWalkCue");
			SoundSystem.NativeFieldInfoPtr_GearlessGuardTimberRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GearlessGuardTimberRunCue");
			SoundSystem.NativeFieldInfoPtr_GearlessGuardTimberWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GearlessGuardTimberWalkCue");
			SoundSystem.NativeFieldInfoPtr_GearlessGuardWoodRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GearlessGuardWoodRunCue");
			SoundSystem.NativeFieldInfoPtr_GearlessGuardWoodWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GearlessGuardWoodWalkCue");
			SoundSystem.NativeFieldInfoPtr_GuardAsphaltRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardAsphaltRunCue");
			SoundSystem.NativeFieldInfoPtr_GuardAsphaltWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardAsphaltWalkCue");
			SoundSystem.NativeFieldInfoPtr_GuardCarpetRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardCarpetRunCue");
			SoundSystem.NativeFieldInfoPtr_GuardCarpetWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardCarpetWalkCue");
			SoundSystem.NativeFieldInfoPtr_GuardConcreteRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardConcreteRunCue");
			SoundSystem.NativeFieldInfoPtr_GuardConcreteWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardConcreteWalkCue");
			SoundSystem.NativeFieldInfoPtr_GuardFuelCanisterShakeCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardFuelCanisterShakeCue");
			SoundSystem.NativeFieldInfoPtr_GuardGrassRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardGrassRunCue");
			SoundSystem.NativeFieldInfoPtr_GuardGrassWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardGrassWalkCue");
			SoundSystem.NativeFieldInfoPtr_GuardHeavyGearShakeRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardHeavyGearShakeRunCue");
			SoundSystem.NativeFieldInfoPtr_GuardLightGearShakeRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardLightGearShakeRunCue");
			SoundSystem.NativeFieldInfoPtr_GuardLightGearShakeWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardLightGearShakeWalkCue");
			SoundSystem.NativeFieldInfoPtr_GuardLinoleumRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardLinoleumRunCue");
			SoundSystem.NativeFieldInfoPtr_GuardLinoleumWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardLinoleumWalkCue");
			SoundSystem.NativeFieldInfoPtr_GuardMedGearShakeRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardMedGearShakeRunCue");
			SoundSystem.NativeFieldInfoPtr_GuardMedGearShakeWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardMedGearShakeWalkCue");
			SoundSystem.NativeFieldInfoPtr_GuardMetalClipCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardMetalClipCue");
			SoundSystem.NativeFieldInfoPtr_GuardWetCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardWetCue");
			SoundSystem.NativeFieldInfoPtr_GuardMetalRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardMetalRunCue");
			SoundSystem.NativeFieldInfoPtr_GuardMetalWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardMetalWalkCue");
			SoundSystem.NativeFieldInfoPtr_GuardTimberRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardTimberRunCue");
			SoundSystem.NativeFieldInfoPtr_GuardTimberWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardTimberWalkCue");
			SoundSystem.NativeFieldInfoPtr_GuardWoodRunCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardWoodRunCue");
			SoundSystem.NativeFieldInfoPtr_GuardWoodWalkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardWoodWalkCue");
			SoundSystem.NativeFieldInfoPtr_GuardCorpseSplatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardCorpseSplatCue");
			SoundSystem.NativeFieldInfoPtr_GuardFallYellCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardFallYellCue");
			SoundSystem.NativeFieldInfoPtr_GuardFlashlightOnCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardFlashlightOnCue");
			SoundSystem.NativeFieldInfoPtr_GuardOceanSpatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardOceanSpatCue");
			SoundSystem.NativeFieldInfoPtr_GuardShovedGruntCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardShovedGruntCue");
			SoundSystem.NativeFieldInfoPtr_GuardSpatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardSpatCue");
			SoundSystem.NativeFieldInfoPtr_GuardStreetSplatCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardStreetSplatCue");
			SoundSystem.NativeFieldInfoPtr_GuardSwingInCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardSwingInCue");
			SoundSystem.NativeFieldInfoPtr_GuardYelpCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardYelpCue");
			SoundSystem.NativeFieldInfoPtr_GuardPushedWooshCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardPushedWooshCue");
			SoundSystem.NativeFieldInfoPtr_GuardAhhhCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardAhhhCue");
			SoundSystem.NativeFieldInfoPtr_GuardGaspCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardGaspCue");
			SoundSystem.NativeFieldInfoPtr_GuardGrabbedGaspCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardGrabbedGaspCue");
			SoundSystem.NativeFieldInfoPtr_GuardCowerCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardCowerCue");
			SoundSystem.NativeFieldInfoPtr_GuardYawnCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardYawnCue");
			SoundSystem.NativeFieldInfoPtr_GuardScratchCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GuardScratchCue");
			SoundSystem.NativeFieldInfoPtr_CrateBreakCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "CrateBreakCue");
			SoundSystem.NativeFieldInfoPtr_GlassBreakCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GlassBreakCue");
			SoundSystem.NativeFieldInfoPtr_BombDropCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BombDropCue");
			SoundSystem.NativeFieldInfoPtr_BunkerCeilingHitCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BunkerCeilingHitCue");
			SoundSystem.NativeFieldInfoPtr_ExplosionCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ExplosionCue");
			SoundSystem.NativeFieldInfoPtr_MassiveGlassCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MassiveGlassCue");
			SoundSystem.NativeFieldInfoPtr_LongBompDropCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LongBompDropCue");
			SoundSystem.NativeFieldInfoPtr_MultiBombDropCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "MultiBombDropCue");
			SoundSystem.NativeFieldInfoPtr_FireInWorldCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FireInWorldCue");
			SoundSystem.NativeFieldInfoPtr_FlameThrowerCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FlameThrowerCue");
			SoundSystem.NativeFieldInfoPtr_ApeOnFireCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApeOnFireCue");
			SoundSystem.NativeFieldInfoPtr_BodyBurnUpCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BodyBurnUpCue");
			SoundSystem.NativeFieldInfoPtr_FireBallCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "FireBallCue");
			SoundSystem.NativeFieldInfoPtr_LightsUpCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "LightsUpCue");
			SoundSystem.NativeFieldInfoPtr_CableSnapCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "CableSnapCue");
			SoundSystem.NativeFieldInfoPtr_GeneratorPowerDownCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "GeneratorPowerDownCue");
			SoundSystem.NativeFieldInfoPtr_BedSqueakCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BedSqueakCue");
			SoundSystem.NativeFieldInfoPtr_DingCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "DingCue");
			SoundSystem.NativeFieldInfoPtr_TickingCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "TickingCue");
			SoundSystem.NativeFieldInfoPtr_SparkCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "SparkCue");
			SoundSystem.NativeFieldInfoPtr_PlaneLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "PlaneLoop");
			SoundSystem.NativeFieldInfoPtr_EnvironmentalFireCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "EnvironmentalFireCue");
			SoundSystem.NativeFieldInfoPtr_DoorBendCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "DoorBendCue");
			SoundSystem.NativeFieldInfoPtr_DoorDragCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "DoorDragCue");
			SoundSystem.NativeFieldInfoPtr_DoorOpenCloseCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "DoorOpenCloseCue");
			SoundSystem.NativeFieldInfoPtr_DoorFallCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "DoorFallCue");
			SoundSystem.NativeFieldInfoPtr_DoorRipOffCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "DoorRipOffCue");
			SoundSystem.NativeFieldInfoPtr_SwingyDoorCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "SwingyDoorCue");
			SoundSystem.NativeFieldInfoPtr_BarDoorCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BarDoorCue");
			SoundSystem.NativeFieldInfoPtr_BigDoorCreakOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BigDoorCreakOne");
			SoundSystem.NativeFieldInfoPtr_BigDoorCreakTwo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BigDoorCreakTwo");
			SoundSystem.NativeFieldInfoPtr_BigDoorCreakThree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BigDoorCreakThree");
			SoundSystem.NativeFieldInfoPtr_ApeWalkStepCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApeWalkStepCue");
			SoundSystem.NativeFieldInfoPtr_ApeRunStepCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApeRunStepCue");
			SoundSystem.NativeFieldInfoPtr_ApeCarpetStepCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApeCarpetStepCue");
			SoundSystem.NativeFieldInfoPtr_ApeParquetStepCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApeParquetStepCue");
			SoundSystem.NativeFieldInfoPtr_ApeLinoleumStepCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApeLinoleumStepCue");
			SoundSystem.NativeFieldInfoPtr_ApeMetalStepCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApeMetalStepCue");
			SoundSystem.NativeFieldInfoPtr_ApeConcreteStepCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApeConcreteStepCue");
			SoundSystem.NativeFieldInfoPtr_ApeTimberStepCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApeTimberStepCue");
			SoundSystem.NativeFieldInfoPtr_ApeGrassStepCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApeGrassStepCue");
			SoundSystem.NativeFieldInfoPtr_ApeWoodStepCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApeWoodStepCue");
			SoundSystem.NativeFieldInfoPtr_ApeWetStepCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApeWetStepCue");
			SoundSystem.NativeFieldInfoPtr_ApeAsphaltStepCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApeAsphaltStepCue");
			SoundSystem.NativeFieldInfoPtr_ApeGrabsCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApeGrabsCue");
			SoundSystem.NativeFieldInfoPtr_ApeGrabsBodyPartCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApeGrabsBodyPartCue");
			SoundSystem.NativeFieldInfoPtr_ApeGrabWhiffCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "ApeGrabWhiffCue");
			SoundSystem.NativeFieldInfoPtr_RetrySwitchCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "RetrySwitchCue");
			SoundSystem.NativeFieldInfoPtr_StickHitCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "StickHitCue");
			SoundSystem.NativeFieldInfoPtr_BoatSetPieceCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "BoatSetPieceCue");
			SoundSystem.NativeFieldInfoPtr_CarCrashCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "CarCrashCue");
			SoundSystem.NativeFieldInfoPtr_OfficeIntroCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "OfficeIntroCue");
			SoundSystem.NativeFieldInfoPtr_OfficeOutroCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "OfficeOutroCue");
			SoundSystem.NativeFieldInfoPtr_AlarmCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "AlarmCue");
			SoundSystem.NativeFieldInfoPtr_DebuggingResAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "DebuggingResAudio");
			SoundSystem.NativeFieldInfoPtr_OverriddenFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "OverriddenFloor");
			SoundSystem.NativeFieldInfoPtr_OverrideFloorMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "OverrideFloorMat");
			SoundSystem.NativeFieldInfoPtr_melvinStepNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "melvinStepNum");
			SoundSystem.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "me");
			SoundSystem.NativeFieldInfoPtr_destroyingAmb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "destroyingAmb");
			SoundSystem.NativeFieldInfoPtr_yelling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "yelling");
			SoundSystem.NativeFieldInfoPtr_alarmInst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "alarmInst");
			SoundSystem.NativeFieldInfoPtr_bloodiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "bloodiness");
			SoundSystem.NativeFieldInfoPtr_bloodyApe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "bloodyApe");
			SoundSystem.NativeFieldInfoPtr_doorRipOffSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "doorRipOffSource");
			SoundSystem.NativeFieldInfoPtr_fireSourceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "fireSourceIndex");
			SoundSystem.NativeFieldInfoPtr_tickingInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, "tickingInstance");
			SoundSystem.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663797);
			SoundSystem.NativeMethodInfoPtr_SetYelling_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663798);
			SoundSystem.NativeMethodInfoPtr_AlarmDoorStart_Public_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663799);
			SoundSystem.NativeMethodInfoPtr_AcceptAmbiance_Public_Void_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663800);
			SoundSystem.NativeMethodInfoPtr_DestroyAmbiance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663801);
			SoundSystem.NativeMethodInfoPtr_ReallyDestroyAmb_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663802);
			SoundSystem.NativeMethodInfoPtr_AlarmDoorStop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663803);
			SoundSystem.NativeMethodInfoPtr_Grab_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663804);
			SoundSystem.NativeMethodInfoPtr_GrabBodyPart_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663805);
			SoundSystem.NativeMethodInfoPtr_GrabWhiff_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663806);
			SoundSystem.NativeMethodInfoPtr_SetBloodiness_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663807);
			SoundSystem.NativeMethodInfoPtr_ApeStep_Public_Void_Single_Transform_FloorMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663808);
			SoundSystem.NativeMethodInfoPtr_GuardStep_Public_Void_Single_Transform_GuardBodyType_WeaponType_FloorMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663809);
			SoundSystem.NativeMethodInfoPtr_GuardShovedGrunt_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663810);
			SoundSystem.NativeMethodInfoPtr_GuardFallYell_Public_SECTR_AudioCueInstance_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663811);
			SoundSystem.NativeMethodInfoPtr_GuardFallYell_Public_SECTR_AudioCueInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663812);
			SoundSystem.NativeMethodInfoPtr_GuardAhh_Public_SECTR_AudioCueInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663813);
			SoundSystem.NativeMethodInfoPtr_GuardGasp_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663814);
			SoundSystem.NativeMethodInfoPtr_GuardGrabbedGasp_Public_Void_Transform_GuardBodyType_WeaponType_FloorMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663815);
			SoundSystem.NativeMethodInfoPtr_GuardGrabbedGaspLoud_Public_Void_Transform_GuardBodyType_WeaponType_FloorMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663816);
			SoundSystem.NativeMethodInfoPtr_GuardCower_Public_SECTR_AudioCueInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663817);
			SoundSystem.NativeMethodInfoPtr_GuardYawn_Public_SECTR_AudioCueInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663818);
			SoundSystem.NativeMethodInfoPtr_GuardScratch_Public_SECTR_AudioCueInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663819);
			SoundSystem.NativeMethodInfoPtr_GuardSwingIn_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663820);
			SoundSystem.NativeMethodInfoPtr_GuardPushedWoosh_Public_SECTR_AudioCueInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663821);
			SoundSystem.NativeMethodInfoPtr_RifleShot_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663822);
			SoundSystem.NativeMethodInfoPtr_ShotgunShot_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663823);
			SoundSystem.NativeMethodInfoPtr_MachineGunShot_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663824);
			SoundSystem.NativeMethodInfoPtr_SniperRifleShot_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663825);
			SoundSystem.NativeMethodInfoPtr_TranqShot_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663826);
			SoundSystem.NativeMethodInfoPtr_LaunchRocket_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663827);
			SoundSystem.NativeMethodInfoPtr_GuardYelp_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663828);
			SoundSystem.NativeMethodInfoPtr_AllGunsCockAtOnce_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663829);
			SoundSystem.NativeMethodInfoPtr_RifleCock_Public_SECTR_AudioCueInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663830);
			SoundSystem.NativeMethodInfoPtr_ShotgunCock_Public_SECTR_AudioCueInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663831);
			SoundSystem.NativeMethodInfoPtr_MachineGunCock_Public_SECTR_AudioCueInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663832);
			SoundSystem.NativeMethodInfoPtr_SniperRifleCock_Public_SECTR_AudioCueInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663833);
			SoundSystem.NativeMethodInfoPtr_RocketLauncherCock_Public_SECTR_AudioCueInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663834);
			SoundSystem.NativeMethodInfoPtr_BulletHitWall_Public_Void_Vector3_SurfaceMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663835);
			SoundSystem.NativeMethodInfoPtr_BulletHitWall_Public_Void_Transform_SurfaceMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663836);
			SoundSystem.NativeMethodInfoPtr_BulletHitFlesh_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663837);
			SoundSystem.NativeMethodInfoPtr_BulletHitVest_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663838);
			SoundSystem.NativeMethodInfoPtr_BulletHitConcrete_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663839);
			SoundSystem.NativeMethodInfoPtr_BulletHitWood_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663840);
			SoundSystem.NativeMethodInfoPtr_BulletHitMetal_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663841);
			SoundSystem.NativeMethodInfoPtr_BulletHitMetalDoor_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663842);
			SoundSystem.NativeMethodInfoPtr_BulletHitGlass_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663843);
			SoundSystem.NativeMethodInfoPtr_BulletCasingFell_Public_Void_Transform_FloorMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663844);
			SoundSystem.NativeMethodInfoPtr_BreakCrate_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663845);
			SoundSystem.NativeMethodInfoPtr_GlassBreak_Public_Void_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663846);
			SoundSystem.NativeMethodInfoPtr_MetalDoorBend_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663847);
			SoundSystem.NativeMethodInfoPtr_BigDoorCreak_Public_SECTR_AudioCueInstance_Int32_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663848);
			SoundSystem.NativeMethodInfoPtr_DoorRipOff_Public_Single_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663849);
			SoundSystem.NativeMethodInfoPtr_MetalDoorDragStart_Public_SECTRLoopThrough_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663850);
			SoundSystem.NativeMethodInfoPtr_DoorFall_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663851);
			SoundSystem.NativeMethodInfoPtr_DoorOpenClose_Public_Void_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663852);
			SoundSystem.NativeMethodInfoPtr_SwingyDoor_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663853);
			SoundSystem.NativeMethodInfoPtr_MassiveGlass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663854);
			SoundSystem.NativeMethodInfoPtr_Explosion_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663855);
			SoundSystem.NativeMethodInfoPtr_InWorldFireStart_Public_SECTR_AudioCueInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663856);
			SoundSystem.NativeMethodInfoPtr_FireBall_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663857);
			SoundSystem.NativeMethodInfoPtr_FireStart_Public_SECTR_AudioCueInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663858);
			SoundSystem.NativeMethodInfoPtr_FlameThrowerStart_Public_SECTRLoopThrough_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663859);
			SoundSystem.NativeMethodInfoPtr_GuardSurfaceHit_Public_Void_Transform_Quaternion_SoundMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663860);
			SoundSystem.NativeMethodInfoPtr_GuardSplat_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663861);
			SoundSystem.NativeMethodInfoPtr_GuardStreetSplat_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663862);
			SoundSystem.NativeMethodInfoPtr_GuardStreetSplat_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663863);
			SoundSystem.NativeMethodInfoPtr_GuardOceanSplat_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663864);
			SoundSystem.NativeMethodInfoPtr_GuardFlashLightOn_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663865);
			SoundSystem.NativeMethodInfoPtr_CorpseSplat_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663866);
			SoundSystem.NativeMethodInfoPtr_ApeLit_Public_SECTR_AudioCueInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663867);
			SoundSystem.NativeMethodInfoPtr_LightsUp_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663868);
			SoundSystem.NativeMethodInfoPtr_BunkerCeilingHit_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663869);
			SoundSystem.NativeMethodInfoPtr_CableSnap_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663870);
			SoundSystem.NativeMethodInfoPtr_BodyBurnUp_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663871);
			SoundSystem.NativeMethodInfoPtr_SurfaceSplat_Public_Void_Transform_Quaternion_SoundMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663872);
			SoundSystem.NativeMethodInfoPtr_SurfaceSplat_Public_Void_Vector3_Quaternion_SoundMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663873);
			SoundSystem.NativeMethodInfoPtr_SurfaceHit_Public_Void_Transform_Quaternion_SoundMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663874);
			SoundSystem.NativeMethodInfoPtr_SurfaceHit_Public_Void_Vector3_Quaternion_SoundMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663875);
			SoundSystem.NativeMethodInfoPtr_RetrySwitch_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663876);
			SoundSystem.NativeMethodInfoPtr_BedSqueak_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663877);
			SoundSystem.NativeMethodInfoPtr_Ding_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663878);
			SoundSystem.NativeMethodInfoPtr_StickHit_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663879);
			SoundSystem.NativeMethodInfoPtr_BarDoorClose_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663880);
			SoundSystem.NativeMethodInfoPtr_DropBomb_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663881);
			SoundSystem.NativeMethodInfoPtr_DropIntroBomb_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663882);
			SoundSystem.NativeMethodInfoPtr_MultiBombDrop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663883);
			SoundSystem.NativeMethodInfoPtr_StartTicking_Public_SECTR_AudioCueInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663884);
			SoundSystem.NativeMethodInfoPtr_StopTicking_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663885);
			SoundSystem.NativeMethodInfoPtr_PlayBoatSetPiece_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663886);
			SoundSystem.NativeMethodInfoPtr_PlayCarCrash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663887);
			SoundSystem.NativeMethodInfoPtr_Spark_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663888);
			SoundSystem.NativeMethodInfoPtr_GeneratorPowerDown_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663889);
			SoundSystem.NativeMethodInfoPtr_PlayOfficeIntro_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663890);
			SoundSystem.NativeMethodInfoPtr_PlayOfficeOutro_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663891);
			SoundSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr, 100663892);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00047748 File Offset: 0x00045948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35659, XrefRangeEnd = 35687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0004777C File Offset: 0x0004597C
		[CallerCount(0)]
		public unsafe void SetYelling(bool _yelling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _yelling;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_SetYelling_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x000477BC File Offset: 0x000459BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 35700, RefRangeEnd = 35703, XrefRangeStart = 35687, XrefRangeEnd = 35700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlarmDoorStart(List<Vector3> positions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(positions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_AlarmDoorStart_Public_Void_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00047800 File Offset: 0x00045A00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35719, RefRangeEnd = 35721, XrefRangeStart = 35703, XrefRangeEnd = 35719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcceptAmbiance(AudioSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_AcceptAmbiance_Public_Void_AudioSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00047844 File Offset: 0x00045A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35721, XrefRangeEnd = 35747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyAmbiance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_DestroyAmbiance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00047878 File Offset: 0x00045A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35747, XrefRangeEnd = 35777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReallyDestroyAmb()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_ReallyDestroyAmb_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000478AC File Offset: 0x00045AAC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 35803, RefRangeEnd = 35808, XrefRangeStart = 35777, XrefRangeEnd = 35803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlarmDoorStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_AlarmDoorStop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x000478E0 File Offset: 0x00045AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35808, XrefRangeEnd = 35818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Grab(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_Grab_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00047924 File Offset: 0x00045B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35818, XrefRangeEnd = 35828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrabBodyPart(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GrabBodyPart_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00047968 File Offset: 0x00045B68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35838, RefRangeEnd = 35839, XrefRangeStart = 35828, XrefRangeEnd = 35838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrabWhiff(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GrabWhiff_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x000479AC File Offset: 0x00045BAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35845, RefRangeEnd = 35847, XrefRangeStart = 35839, XrefRangeEnd = 35845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBloodiness(float bloody)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bloody;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_SetBloodiness_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x000479EC File Offset: 0x00045BEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35902, RefRangeEnd = 35903, XrefRangeStart = 35847, XrefRangeEnd = 35902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApeStep(float spd, Transform pos, Level.FloorMaterial floorMat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref spd;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floorMat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_ApeStep_Public_Void_Single_Transform_FloorMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00047A4C File Offset: 0x00045C4C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 35943, RefRangeEnd = 35949, XrefRangeStart = 35903, XrefRangeEnd = 35943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardStep(float spd, Transform pos, GuardState.GuardBodyType guardType, GuardState.WeaponType weaponType, Level.FloorMaterial floorMat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref spd;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guardType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weaponType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floorMat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardStep_Public_Void_Single_Transform_GuardBodyType_WeaponType_FloorMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00047AC8 File Offset: 0x00045CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35949, XrefRangeEnd = 35959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardShovedGrunt(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardShovedGrunt_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00047B0C File Offset: 0x00045D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35959, XrefRangeEnd = 35967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance GuardFallYell(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardFallYell_Public_SECTR_AudioCueInstance_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SECTR_AudioCueInstance(intPtr);
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00047B50 File Offset: 0x00045D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35967, XrefRangeEnd = 35977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance GuardFallYell(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardFallYell_Public_SECTR_AudioCueInstance_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SECTR_AudioCueInstance(intPtr);
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00047B98 File Offset: 0x00045D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35977, XrefRangeEnd = 35983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance GuardAhh(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardAhh_Public_SECTR_AudioCueInstance_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SECTR_AudioCueInstance(intPtr);
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00047BE0 File Offset: 0x00045DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35983, XrefRangeEnd = 35989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardGasp(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardGasp_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00047C24 File Offset: 0x00045E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35989, XrefRangeEnd = 35997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardGrabbedGasp(Transform pos, GuardState.GuardBodyType guardType, GuardState.WeaponType weaponType, Level.FloorMaterial floorMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guardType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weaponType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floorMaterial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardGrabbedGasp_Public_Void_Transform_GuardBodyType_WeaponType_FloorMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00047C90 File Offset: 0x00045E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35997, XrefRangeEnd = 36005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardGrabbedGaspLoud(Transform pos, GuardState.GuardBodyType guardType, GuardState.WeaponType weaponType, Level.FloorMaterial floorMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guardType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weaponType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floorMaterial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardGrabbedGaspLoud_Public_Void_Transform_GuardBodyType_WeaponType_FloorMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00047CFC File Offset: 0x00045EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36005, XrefRangeEnd = 36011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance GuardCower(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardCower_Public_SECTR_AudioCueInstance_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SECTR_AudioCueInstance(intPtr);
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00047D44 File Offset: 0x00045F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36011, XrefRangeEnd = 36017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance GuardYawn(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardYawn_Public_SECTR_AudioCueInstance_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SECTR_AudioCueInstance(intPtr);
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00047D8C File Offset: 0x00045F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36017, XrefRangeEnd = 36023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance GuardScratch(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardScratch_Public_SECTR_AudioCueInstance_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SECTR_AudioCueInstance(intPtr);
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00047DD4 File Offset: 0x00045FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36023, XrefRangeEnd = 36029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardSwingIn(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardSwingIn_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00047E18 File Offset: 0x00046018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36029, XrefRangeEnd = 36042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance GuardPushedWoosh(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardPushedWoosh_Public_SECTR_AudioCueInstance_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SECTR_AudioCueInstance(intPtr);
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00047E60 File Offset: 0x00046060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36042, XrefRangeEnd = 36050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RifleShot(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_RifleShot_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00047EAC File Offset: 0x000460AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36050, XrefRangeEnd = 36058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShotgunShot(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_ShotgunShot_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00047EF8 File Offset: 0x000460F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36058, XrefRangeEnd = 36066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MachineGunShot(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_MachineGunShot_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00047F44 File Offset: 0x00046144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36066, XrefRangeEnd = 36074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SniperRifleShot(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_SniperRifleShot_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00047F90 File Offset: 0x00046190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36074, XrefRangeEnd = 36082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TranqShot(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_TranqShot_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00047FDC File Offset: 0x000461DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36082, XrefRangeEnd = 36092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LaunchRocket(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_LaunchRocket_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00048020 File Offset: 0x00046220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36092, XrefRangeEnd = 36102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardYelp(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardYelp_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00048064 File Offset: 0x00046264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36102, XrefRangeEnd = 36108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllGunsCockAtOnce(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_AllGunsCockAtOnce_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000480A8 File Offset: 0x000462A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 36118, RefRangeEnd = 36123, XrefRangeStart = 36108, XrefRangeEnd = 36118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance RifleCock(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_RifleCock_Public_SECTR_AudioCueInstance_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SECTR_AudioCueInstance(intPtr);
			}
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x000480F0 File Offset: 0x000462F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 36133, RefRangeEnd = 36138, XrefRangeStart = 36123, XrefRangeEnd = 36133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance ShotgunCock(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_ShotgunCock_Public_SECTR_AudioCueInstance_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SECTR_AudioCueInstance(intPtr);
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00048138 File Offset: 0x00046338
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 36148, RefRangeEnd = 36151, XrefRangeStart = 36138, XrefRangeEnd = 36148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance MachineGunCock(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_MachineGunCock_Public_SECTR_AudioCueInstance_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SECTR_AudioCueInstance(intPtr);
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00048180 File Offset: 0x00046380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36151, XrefRangeEnd = 36161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance SniperRifleCock(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_SniperRifleCock_Public_SECTR_AudioCueInstance_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SECTR_AudioCueInstance(intPtr);
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000481C8 File Offset: 0x000463C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 36171, RefRangeEnd = 36174, XrefRangeStart = 36161, XrefRangeEnd = 36171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance RocketLauncherCock(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_RocketLauncherCock_Public_SECTR_AudioCueInstance_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SECTR_AudioCueInstance(intPtr);
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00048210 File Offset: 0x00046410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36175, RefRangeEnd = 36176, XrefRangeStart = 36174, XrefRangeEnd = 36175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BulletHitWall(Vector3 pos, ResonanceAudioRoomManager.SurfaceMaterial mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_BulletHitWall_Public_Void_Vector3_SurfaceMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0004825C File Offset: 0x0004645C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36176, XrefRangeEnd = 36179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BulletHitWall(Transform pos, ResonanceAudioRoomManager.SurfaceMaterial mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_BulletHitWall_Public_Void_Transform_SurfaceMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x000482AC File Offset: 0x000464AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36179, XrefRangeEnd = 36187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BulletHitFlesh(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_BulletHitFlesh_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x000482EC File Offset: 0x000464EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36187, XrefRangeEnd = 36195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BulletHitVest(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_BulletHitVest_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0004832C File Offset: 0x0004652C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36195, XrefRangeEnd = 36203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BulletHitConcrete(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_BulletHitConcrete_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0004836C File Offset: 0x0004656C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36211, RefRangeEnd = 36212, XrefRangeStart = 36203, XrefRangeEnd = 36211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BulletHitWood(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_BulletHitWood_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x000483AC File Offset: 0x000465AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 36220, RefRangeEnd = 36223, XrefRangeStart = 36212, XrefRangeEnd = 36220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BulletHitMetal(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_BulletHitMetal_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x000483EC File Offset: 0x000465EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36223, XrefRangeEnd = 36231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BulletHitMetalDoor(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_BulletHitMetalDoor_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0004842C File Offset: 0x0004662C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36231, XrefRangeEnd = 36239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BulletHitGlass(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_BulletHitGlass_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0004846C File Offset: 0x0004666C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36249, RefRangeEnd = 36250, XrefRangeStart = 36239, XrefRangeEnd = 36249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BulletCasingFell(Transform pos, Level.FloorMaterial floorMat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floorMat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_BulletCasingFell_Public_Void_Transform_FloorMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x000484BC File Offset: 0x000466BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36260, RefRangeEnd = 36262, XrefRangeStart = 36250, XrefRangeEnd = 36260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BreakCrate(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_BreakCrate_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00048500 File Offset: 0x00046700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36262, XrefRangeEnd = 36270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GlassBreak(Vector3 pos, Transform trans)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trans);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GlassBreak_Public_Void_Vector3_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00048550 File Offset: 0x00046750
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36280, RefRangeEnd = 36282, XrefRangeStart = 36270, XrefRangeEnd = 36280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MetalDoorBend(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_MetalDoorBend_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00048594 File Offset: 0x00046794
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36290, RefRangeEnd = 36292, XrefRangeStart = 36282, XrefRangeEnd = 36290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance BigDoorCreak(int number, Transform position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(position);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_BigDoorCreak_Public_SECTR_AudioCueInstance_Int32_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SECTR_AudioCueInstance(intPtr);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000485EC File Offset: 0x000467EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36325, RefRangeEnd = 36326, XrefRangeStart = 36292, XrefRangeEnd = 36325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float DoorRipOff(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_DoorRipOff_Public_Single_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0004863C File Offset: 0x0004683C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36326, XrefRangeEnd = 36330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTRLoopThrough MetalDoorDragStart(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_MetalDoorDragStart_Public_SECTRLoopThrough_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTRLoopThrough>(intPtr3) : null;
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0004868C File Offset: 0x0004688C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 36346, RefRangeEnd = 36351, XrefRangeStart = 36330, XrefRangeEnd = 36346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoorFall(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_DoorFall_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000486D0 File Offset: 0x000468D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36359, RefRangeEnd = 36361, XrefRangeStart = 36351, XrefRangeEnd = 36359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoorOpenClose(Vector3 pos, Transform trans)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trans);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_DoorOpenClose_Public_Void_Vector3_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00048720 File Offset: 0x00046920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36361, XrefRangeEnd = 36371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwingyDoor(Transform trans)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_SwingyDoor_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00048764 File Offset: 0x00046964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36371, XrefRangeEnd = 36383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MassiveGlass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_MassiveGlass_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00048798 File Offset: 0x00046998
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 36399, RefRangeEnd = 36402, XrefRangeStart = 36383, XrefRangeEnd = 36399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Explosion(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_Explosion_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000487DC File Offset: 0x000469DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36402, XrefRangeEnd = 36408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance InWorldFireStart(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_InWorldFireStart_Public_SECTR_AudioCueInstance_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SECTR_AudioCueInstance(intPtr);
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00048824 File Offset: 0x00046A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36408, XrefRangeEnd = 36418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FireBall(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_FireBall_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00048868 File Offset: 0x00046A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36418, XrefRangeEnd = 36428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance FireStart(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_FireStart_Public_SECTR_AudioCueInstance_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SECTR_AudioCueInstance(intPtr);
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000488B0 File Offset: 0x00046AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36428, XrefRangeEnd = 36432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTRLoopThrough FlameThrowerStart(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_FlameThrowerStart_Public_SECTRLoopThrough_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTRLoopThrough>(intPtr3) : null;
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00048900 File Offset: 0x00046B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36432, XrefRangeEnd = 36436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardSurfaceHit(Transform pos, Quaternion rot, Tags.SoundMaterial mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardSurfaceHit_Public_Void_Transform_Quaternion_SoundMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00048960 File Offset: 0x00046B60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36446, RefRangeEnd = 36447, XrefRangeStart = 36436, XrefRangeEnd = 36446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardSplat(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardSplat_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x000489A4 File Offset: 0x00046BA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 36455, RefRangeEnd = 36458, XrefRangeStart = 36447, XrefRangeEnd = 36455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardStreetSplat(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardStreetSplat_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x000489E4 File Offset: 0x00046BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36458, XrefRangeEnd = 36461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardStreetSplat(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardStreetSplat_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00048A28 File Offset: 0x00046C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36461, XrefRangeEnd = 36471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardOceanSplat(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardOceanSplat_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00048A6C File Offset: 0x00046C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36471, XrefRangeEnd = 36481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardFlashLightOn(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GuardFlashLightOn_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00048AB0 File Offset: 0x00046CB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36489, RefRangeEnd = 36491, XrefRangeStart = 36481, XrefRangeEnd = 36489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CorpseSplat(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_CorpseSplat_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00048AF0 File Offset: 0x00046CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36491, XrefRangeEnd = 36497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance ApeLit(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_ApeLit_Public_SECTR_AudioCueInstance_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SECTR_AudioCueInstance(intPtr);
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00048B38 File Offset: 0x00046D38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 36507, RefRangeEnd = 36511, XrefRangeStart = 36497, XrefRangeEnd = 36507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LightsUp(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_LightsUp_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00048B7C File Offset: 0x00046D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36511, XrefRangeEnd = 36521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BunkerCeilingHit(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_BunkerCeilingHit_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00048BC0 File Offset: 0x00046DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36521, XrefRangeEnd = 36531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CableSnap(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_CableSnap_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00048C04 File Offset: 0x00046E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36531, XrefRangeEnd = 36541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyBurnUp(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_BodyBurnUp_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00048C48 File Offset: 0x00046E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36541, XrefRangeEnd = 36544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SurfaceSplat(Transform pos, Quaternion rot, Tags.SoundMaterial mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_SurfaceSplat_Public_Void_Transform_Quaternion_SoundMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00048CA8 File Offset: 0x00046EA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36552, RefRangeEnd = 36554, XrefRangeStart = 36544, XrefRangeEnd = 36552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SurfaceSplat(Vector3 pos, Quaternion rot, Tags.SoundMaterial mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_SurfaceSplat_Public_Void_Vector3_Quaternion_SoundMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00048D04 File Offset: 0x00046F04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36557, RefRangeEnd = 36558, XrefRangeStart = 36554, XrefRangeEnd = 36557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SurfaceHit(Transform pos, Quaternion rot, Tags.SoundMaterial mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_SurfaceHit_Public_Void_Transform_Quaternion_SoundMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00048D64 File Offset: 0x00046F64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36566, RefRangeEnd = 36568, XrefRangeStart = 36558, XrefRangeEnd = 36566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SurfaceHit(Vector3 pos, Quaternion rot, Tags.SoundMaterial mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_SurfaceHit_Public_Void_Vector3_Quaternion_SoundMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00048DC0 File Offset: 0x00046FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36568, XrefRangeEnd = 36578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RetrySwitch(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_RetrySwitch_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00048E04 File Offset: 0x00047004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36578, XrefRangeEnd = 36586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BedSqueak(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_BedSqueak_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00048E44 File Offset: 0x00047044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36586, XrefRangeEnd = 36594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ding(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_Ding_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00048E84 File Offset: 0x00047084
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 36604, RefRangeEnd = 36607, XrefRangeStart = 36594, XrefRangeEnd = 36604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StickHit(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_StickHit_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00048EC8 File Offset: 0x000470C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36607, XrefRangeEnd = 36619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BarDoorClose(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_BarDoorClose_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00048F0C File Offset: 0x0004710C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36619, XrefRangeEnd = 36627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropBomb()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_DropBomb_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00048F40 File Offset: 0x00047140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36635, RefRangeEnd = 36636, XrefRangeStart = 36627, XrefRangeEnd = 36635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropIntroBomb()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_DropIntroBomb_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00048F74 File Offset: 0x00047174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36636, XrefRangeEnd = 36644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MultiBombDrop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_MultiBombDrop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00048FA8 File Offset: 0x000471A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36644, XrefRangeEnd = 36652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance StartTicking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_StartTicking_Public_SECTR_AudioCueInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SECTR_AudioCueInstance(intPtr);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00048FE0 File Offset: 0x000471E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36652, XrefRangeEnd = 36658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTicking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_StopTicking_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00049014 File Offset: 0x00047214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36658, XrefRangeEnd = 36670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayBoatSetPiece()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_PlayBoatSetPiece_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00049048 File Offset: 0x00047248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36670, XrefRangeEnd = 36682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayCarCrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_PlayCarCrash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0004907C File Offset: 0x0004727C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36682, XrefRangeEnd = 36692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Spark(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_Spark_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x000490C0 File Offset: 0x000472C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36692, XrefRangeEnd = 36702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GeneratorPowerDown(Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_GeneratorPowerDown_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00049104 File Offset: 0x00047304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36702, XrefRangeEnd = 36714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayOfficeIntro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_PlayOfficeIntro_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00049138 File Offset: 0x00047338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36714, XrefRangeEnd = 36726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayOfficeOutro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr_PlayOfficeOutro_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0004916C File Offset: 0x0004736C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36726, XrefRangeEnd = 36737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoundSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoundSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00005829 File Offset: 0x00003A29
		public SoundSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x000491A8 File Offset: 0x000473A8
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x00005832 File Offset: 0x00003A32
		public unsafe AudioSource AmbianceAudSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_AmbianceAudSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_AmbianceAudSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x000491D8 File Offset: 0x000473D8
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x00005851 File Offset: 0x00003A51
		public unsafe AudioMixerGroup SECTRMixerGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_SECTRMixerGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_SECTRMixerGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00049208 File Offset: 0x00047408
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x00005870 File Offset: 0x00003A70
		public unsafe AudioMixerGroup AmbianceMixerGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_AmbianceMixerGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_AmbianceMixerGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00049238 File Offset: 0x00047438
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x0000588F File Offset: 0x00003A8F
		public unsafe AudioMixerGroup MetaMixerGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MetaMixerGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MetaMixerGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00049268 File Offset: 0x00047468
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x000058AE File Offset: 0x00003AAE
		public unsafe SECTR_AudioCue ApplianceMatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApplianceMatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApplianceMatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x00049298 File Offset: 0x00047498
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x000058CD File Offset: 0x00003ACD
		public unsafe SECTR_AudioCue BarsMatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BarsMatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BarsMatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x000492C8 File Offset: 0x000474C8
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x000058EC File Offset: 0x00003AEC
		public unsafe SECTR_AudioCue ConcreteMatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ConcreteMatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ConcreteMatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x000492F8 File Offset: 0x000474F8
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x0000590B File Offset: 0x00003B0B
		public unsafe SECTR_AudioCue DryWallMatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DryWallMatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DryWallMatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00049328 File Offset: 0x00047528
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x0000592A File Offset: 0x00003B2A
		public unsafe SECTR_AudioCue FenceMatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FenceMatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FenceMatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00049358 File Offset: 0x00047558
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x00005949 File Offset: 0x00003B49
		public unsafe SECTR_AudioCue FleshMatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FleshMatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FleshMatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00049388 File Offset: 0x00047588
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x00005968 File Offset: 0x00003B68
		public unsafe SECTR_AudioCue RockMatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_RockMatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_RockMatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x000493B8 File Offset: 0x000475B8
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00005987 File Offset: 0x00003B87
		public unsafe SECTR_AudioCue ThickMetalMatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ThickMetalMatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ThickMetalMatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x000493E8 File Offset: 0x000475E8
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x000059A6 File Offset: 0x00003BA6
		public unsafe SECTR_AudioCue ThinMetalMatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ThinMetalMatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ThinMetalMatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00049418 File Offset: 0x00047618
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x000059C5 File Offset: 0x00003BC5
		public unsafe SECTR_AudioCue TreeMatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_TreeMatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_TreeMatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00049448 File Offset: 0x00047648
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x000059E4 File Offset: 0x00003BE4
		public unsafe SECTR_AudioCue WoodMatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_WoodMatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_WoodMatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x00049478 File Offset: 0x00047678
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x00005A03 File Offset: 0x00003C03
		public unsafe SECTR_AudioCue ApplianceSplatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApplianceSplatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApplianceSplatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x000494A8 File Offset: 0x000476A8
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x00005A22 File Offset: 0x00003C22
		public unsafe SECTR_AudioCue BarsSplatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BarsSplatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BarsSplatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x000494D8 File Offset: 0x000476D8
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00005A41 File Offset: 0x00003C41
		public unsafe SECTR_AudioCue ConcreteSplatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ConcreteSplatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ConcreteSplatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00049508 File Offset: 0x00047708
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00005A60 File Offset: 0x00003C60
		public unsafe SECTR_AudioCue DryWallSplatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DryWallSplatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DryWallSplatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00049538 File Offset: 0x00047738
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x00005A7F File Offset: 0x00003C7F
		public unsafe SECTR_AudioCue FenceSplatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FenceSplatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FenceSplatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x00049568 File Offset: 0x00047768
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x00005A9E File Offset: 0x00003C9E
		public unsafe SECTR_AudioCue FleshSplatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FleshSplatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FleshSplatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x00049598 File Offset: 0x00047798
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x00005ABD File Offset: 0x00003CBD
		public unsafe SECTR_AudioCue RockSplatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_RockSplatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_RockSplatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x000495C8 File Offset: 0x000477C8
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x00005ADC File Offset: 0x00003CDC
		public unsafe SECTR_AudioCue ThickMetalSplatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ThickMetalSplatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ThickMetalSplatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x000495F8 File Offset: 0x000477F8
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x00005AFB File Offset: 0x00003CFB
		public unsafe SECTR_AudioCue ThinMetalSplatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ThinMetalSplatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ThinMetalSplatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00049628 File Offset: 0x00047828
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00005B1A File Offset: 0x00003D1A
		public unsafe SECTR_AudioCue TreeSplatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_TreeSplatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_TreeSplatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00049658 File Offset: 0x00047858
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00005B39 File Offset: 0x00003D39
		public unsafe SECTR_AudioCue WoodSplatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_WoodSplatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_WoodSplatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00049688 File Offset: 0x00047888
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00005B58 File Offset: 0x00003D58
		public unsafe SECTR_AudioCue BulletHitFleshCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletHitFleshCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletHitFleshCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x000496B8 File Offset: 0x000478B8
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00005B77 File Offset: 0x00003D77
		public unsafe SECTR_AudioCue BulletHitVestCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletHitVestCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletHitVestCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x000496E8 File Offset: 0x000478E8
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00005B96 File Offset: 0x00003D96
		public unsafe SECTR_AudioCue BulletHitConcreteCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletHitConcreteCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletHitConcreteCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00049718 File Offset: 0x00047918
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00005BB5 File Offset: 0x00003DB5
		public unsafe SECTR_AudioCue BulletHitWoodCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletHitWoodCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletHitWoodCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00049748 File Offset: 0x00047948
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00005BD4 File Offset: 0x00003DD4
		public unsafe SECTR_AudioCue BulletHitGlassCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletHitGlassCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletHitGlassCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00049778 File Offset: 0x00047978
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00005BF3 File Offset: 0x00003DF3
		public unsafe SECTR_AudioCue BulletHitMetalCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletHitMetalCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletHitMetalCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x000497A8 File Offset: 0x000479A8
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x00005C12 File Offset: 0x00003E12
		public unsafe SECTR_AudioCue BulletHitMetalDoorCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletHitMetalDoorCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletHitMetalDoorCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x000497D8 File Offset: 0x000479D8
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x00005C31 File Offset: 0x00003E31
		public unsafe SECTR_AudioCue BulletCasingOnCarpet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletCasingOnCarpet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletCasingOnCarpet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00049808 File Offset: 0x00047A08
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x00005C50 File Offset: 0x00003E50
		public unsafe SECTR_AudioCue BulletCasingOnCement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletCasingOnCement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletCasingOnCement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00049838 File Offset: 0x00047A38
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x00005C6F File Offset: 0x00003E6F
		public unsafe SECTR_AudioCue BulletCasingOnDirt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletCasingOnDirt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletCasingOnDirt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00049868 File Offset: 0x00047A68
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00005C8E File Offset: 0x00003E8E
		public unsafe SECTR_AudioCue BulletCasingOnGrass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletCasingOnGrass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletCasingOnGrass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x00049898 File Offset: 0x00047A98
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00005CAD File Offset: 0x00003EAD
		public unsafe SECTR_AudioCue BulletCasingOnTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletCasingOnTile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletCasingOnTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x000498C8 File Offset: 0x00047AC8
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x00005CCC File Offset: 0x00003ECC
		public unsafe SECTR_AudioCue BulletCasingOnLinoleum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletCasingOnLinoleum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletCasingOnLinoleum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x000498F8 File Offset: 0x00047AF8
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x00005CEB File Offset: 0x00003EEB
		public unsafe SECTR_AudioCue BulletCasingOnWood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletCasingOnWood);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BulletCasingOnWood), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x00049928 File Offset: 0x00047B28
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x00005D0A File Offset: 0x00003F0A
		public unsafe SECTR_AudioCue MachineGunShotCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MachineGunShotCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MachineGunShotCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00049958 File Offset: 0x00047B58
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x00005D29 File Offset: 0x00003F29
		public unsafe SECTR_AudioCue RifleShotCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_RifleShotCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_RifleShotCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x00049988 File Offset: 0x00047B88
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x00005D48 File Offset: 0x00003F48
		public unsafe SECTR_AudioCue RocketLaunchCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_RocketLaunchCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_RocketLaunchCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x000499B8 File Offset: 0x00047BB8
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x00005D67 File Offset: 0x00003F67
		public unsafe SECTR_AudioCue ShotgunShotCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ShotgunShotCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ShotgunShotCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x000499E8 File Offset: 0x00047BE8
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x00005D86 File Offset: 0x00003F86
		public unsafe SECTR_AudioCue SniperRifleShotCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_SniperRifleShotCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_SniperRifleShotCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00049A18 File Offset: 0x00047C18
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00005DA5 File Offset: 0x00003FA5
		public unsafe SECTR_AudioCue TranquilizerShotCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_TranquilizerShotCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_TranquilizerShotCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x00049A48 File Offset: 0x00047C48
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x00005DC4 File Offset: 0x00003FC4
		public unsafe SECTR_AudioCue MachineGunCockCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MachineGunCockCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MachineGunCockCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00049A78 File Offset: 0x00047C78
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x00005DE3 File Offset: 0x00003FE3
		public unsafe SECTR_AudioCue RifleCockCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_RifleCockCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_RifleCockCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00049AA8 File Offset: 0x00047CA8
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x00005E02 File Offset: 0x00004002
		public unsafe SECTR_AudioCue RocketLauncherCockCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_RocketLauncherCockCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_RocketLauncherCockCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00049AD8 File Offset: 0x00047CD8
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x00005E21 File Offset: 0x00004021
		public unsafe SECTR_AudioCue ShotgunCockCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ShotgunCockCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ShotgunCockCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x00049B08 File Offset: 0x00047D08
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x00005E40 File Offset: 0x00004040
		public unsafe SECTR_AudioCue SniperRifleCockCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_SniperRifleCockCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_SniperRifleCockCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x00049B38 File Offset: 0x00047D38
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x00005E5F File Offset: 0x0000405F
		public unsafe SECTR_AudioCue TranquilizerCockCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_TranquilizerCockCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_TranquilizerCockCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00049B68 File Offset: 0x00047D68
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x00005E7E File Offset: 0x0000407E
		public unsafe SECTR_AudioCue HeavyGuardAsphaltRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardAsphaltRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardAsphaltRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00049B98 File Offset: 0x00047D98
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x00005E9D File Offset: 0x0000409D
		public unsafe SECTR_AudioCue HeavyGuardAsphaltWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardAsphaltWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardAsphaltWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00049BC8 File Offset: 0x00047DC8
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x00005EBC File Offset: 0x000040BC
		public unsafe SECTR_AudioCue HeavyGuardCarpetRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardCarpetRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardCarpetRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00049BF8 File Offset: 0x00047DF8
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x00005EDB File Offset: 0x000040DB
		public unsafe SECTR_AudioCue HeavyGuardCarpetWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardCarpetWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardCarpetWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00049C28 File Offset: 0x00047E28
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x00005EFA File Offset: 0x000040FA
		public unsafe SECTR_AudioCue HeavyGuardConcreteRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardConcreteRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardConcreteRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00049C58 File Offset: 0x00047E58
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x00005F19 File Offset: 0x00004119
		public unsafe SECTR_AudioCue HeavyGuardConcreteWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardConcreteWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardConcreteWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00049C88 File Offset: 0x00047E88
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x00005F38 File Offset: 0x00004138
		public unsafe SECTR_AudioCue HeavyGuardGrassRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardGrassRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardGrassRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00049CB8 File Offset: 0x00047EB8
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x00005F57 File Offset: 0x00004157
		public unsafe SECTR_AudioCue HeavyGuardGrassWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardGrassWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardGrassWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00049CE8 File Offset: 0x00047EE8
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x00005F76 File Offset: 0x00004176
		public unsafe SECTR_AudioCue HeavyGuardLinoleumRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardLinoleumRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardLinoleumRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00049D18 File Offset: 0x00047F18
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x00005F95 File Offset: 0x00004195
		public unsafe SECTR_AudioCue HeavyGuardLinoleumWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardLinoleumWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardLinoleumWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00049D48 File Offset: 0x00047F48
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x00005FB4 File Offset: 0x000041B4
		public unsafe SECTR_AudioCue HeavyGuardMetalRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardMetalRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardMetalRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00049D78 File Offset: 0x00047F78
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x00005FD3 File Offset: 0x000041D3
		public unsafe SECTR_AudioCue HeavyGuardMetalWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardMetalWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardMetalWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00049DA8 File Offset: 0x00047FA8
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x00005FF2 File Offset: 0x000041F2
		public unsafe SECTR_AudioCue HeavyGuardTimberRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardTimberRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardTimberRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x00049DD8 File Offset: 0x00047FD8
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x00006011 File Offset: 0x00004211
		public unsafe SECTR_AudioCue HeavyGuardTimberWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardTimberWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardTimberWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00049E08 File Offset: 0x00048008
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x00006030 File Offset: 0x00004230
		public unsafe SECTR_AudioCue HeavyGuardWoodRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardWoodRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardWoodRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00049E38 File Offset: 0x00048038
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x0000604F File Offset: 0x0000424F
		public unsafe SECTR_AudioCue HeavyGuardWoodWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardWoodWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_HeavyGuardWoodWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x00049E68 File Offset: 0x00048068
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x0000606E File Offset: 0x0000426E
		public unsafe SECTR_AudioCue LightGuardAsphaltRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardAsphaltRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardAsphaltRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00049E98 File Offset: 0x00048098
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x0000608D File Offset: 0x0000428D
		public unsafe SECTR_AudioCue LightGuardAsphaltWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardAsphaltWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardAsphaltWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00049EC8 File Offset: 0x000480C8
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x000060AC File Offset: 0x000042AC
		public unsafe SECTR_AudioCue LightGuardCarpetRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardCarpetRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardCarpetRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00049EF8 File Offset: 0x000480F8
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x000060CB File Offset: 0x000042CB
		public unsafe SECTR_AudioCue LightGuardCarpetWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardCarpetWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardCarpetWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00049F28 File Offset: 0x00048128
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x000060EA File Offset: 0x000042EA
		public unsafe SECTR_AudioCue LightGuardConcreteRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardConcreteRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardConcreteRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00049F58 File Offset: 0x00048158
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x00006109 File Offset: 0x00004309
		public unsafe SECTR_AudioCue LightGuardConcreteWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardConcreteWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardConcreteWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00049F88 File Offset: 0x00048188
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x00006128 File Offset: 0x00004328
		public unsafe SECTR_AudioCue LightGuardGrassRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardGrassRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardGrassRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x00049FB8 File Offset: 0x000481B8
		// (set) Token: 0x060006CB RID: 1739 RVA: 0x00006147 File Offset: 0x00004347
		public unsafe SECTR_AudioCue LightGuardGrassWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardGrassWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardGrassWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x00049FE8 File Offset: 0x000481E8
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x00006166 File Offset: 0x00004366
		public unsafe SECTR_AudioCue LightGuardLinoleumRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardLinoleumRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardLinoleumRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x0004A018 File Offset: 0x00048218
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x00006185 File Offset: 0x00004385
		public unsafe SECTR_AudioCue LightGuardLinoleumWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardLinoleumWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardLinoleumWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0004A048 File Offset: 0x00048248
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x000061A4 File Offset: 0x000043A4
		public unsafe SECTR_AudioCue LightGuardMetalRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardMetalRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardMetalRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x0004A078 File Offset: 0x00048278
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x000061C3 File Offset: 0x000043C3
		public unsafe SECTR_AudioCue LightGuardMetalWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardMetalWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardMetalWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0004A0A8 File Offset: 0x000482A8
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x000061E2 File Offset: 0x000043E2
		public unsafe SECTR_AudioCue LightGuardTimberRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardTimberRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardTimberRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0004A0D8 File Offset: 0x000482D8
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00006201 File Offset: 0x00004401
		public unsafe SECTR_AudioCue LightGuardTimberWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardTimberWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardTimberWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0004A108 File Offset: 0x00048308
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00006220 File Offset: 0x00004420
		public unsafe SECTR_AudioCue LightGuardWoodRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardWoodRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardWoodRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x0004A138 File Offset: 0x00048338
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x0000623F File Offset: 0x0000443F
		public unsafe SECTR_AudioCue LightGuardWoodWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardWoodWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightGuardWoodWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x0004A168 File Offset: 0x00048368
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x0000625E File Offset: 0x0000445E
		public unsafe SECTR_AudioCue FlameGuardAsphaltRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardAsphaltRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardAsphaltRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0004A198 File Offset: 0x00048398
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x0000627D File Offset: 0x0000447D
		public unsafe SECTR_AudioCue FlameGuardAsphaltWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardAsphaltWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardAsphaltWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x0004A1C8 File Offset: 0x000483C8
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x0000629C File Offset: 0x0000449C
		public unsafe SECTR_AudioCue FlameGuardCarpetRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardCarpetRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardCarpetRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0004A1F8 File Offset: 0x000483F8
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x000062BB File Offset: 0x000044BB
		public unsafe SECTR_AudioCue FlameGuardCarpetWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardCarpetWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardCarpetWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0004A228 File Offset: 0x00048428
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x000062DA File Offset: 0x000044DA
		public unsafe SECTR_AudioCue FlameGuardConcreteRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardConcreteRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardConcreteRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x0004A258 File Offset: 0x00048458
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x000062F9 File Offset: 0x000044F9
		public unsafe SECTR_AudioCue FlameGuardConcreteWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardConcreteWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardConcreteWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0004A288 File Offset: 0x00048488
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00006318 File Offset: 0x00004518
		public unsafe SECTR_AudioCue FlameGuardGrassRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardGrassRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardGrassRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x0004A2B8 File Offset: 0x000484B8
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x00006337 File Offset: 0x00004537
		public unsafe SECTR_AudioCue FlameGuardGrassWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardGrassWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardGrassWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x0004A2E8 File Offset: 0x000484E8
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00006356 File Offset: 0x00004556
		public unsafe SECTR_AudioCue FlameGuardLinoleumRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardLinoleumRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardLinoleumRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x0004A318 File Offset: 0x00048518
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00006375 File Offset: 0x00004575
		public unsafe SECTR_AudioCue FlameGuardLinoleumWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardLinoleumWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardLinoleumWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0004A348 File Offset: 0x00048548
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00006394 File Offset: 0x00004594
		public unsafe SECTR_AudioCue FlameGuardMetalRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardMetalRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardMetalRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0004A378 File Offset: 0x00048578
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x000063B3 File Offset: 0x000045B3
		public unsafe SECTR_AudioCue FlameGuardMetalWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardMetalWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardMetalWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x0004A3A8 File Offset: 0x000485A8
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x000063D2 File Offset: 0x000045D2
		public unsafe SECTR_AudioCue FlameGuardTimberRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardTimberRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardTimberRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x0004A3D8 File Offset: 0x000485D8
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x000063F1 File Offset: 0x000045F1
		public unsafe SECTR_AudioCue FlameGuardTimberWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardTimberWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardTimberWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x0004A408 File Offset: 0x00048608
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x00006410 File Offset: 0x00004610
		public unsafe SECTR_AudioCue FlameGuardWoodRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardWoodRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardWoodRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x0004A438 File Offset: 0x00048638
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x0000642F File Offset: 0x0000462F
		public unsafe SECTR_AudioCue FlameGuardWoodWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardWoodWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameGuardWoodWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x0004A468 File Offset: 0x00048668
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x0000644E File Offset: 0x0000464E
		public unsafe SECTR_AudioCue MediumGuardAsphaltRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardAsphaltRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardAsphaltRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x0004A498 File Offset: 0x00048698
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x0000646D File Offset: 0x0000466D
		public unsafe SECTR_AudioCue MediumGuardAsphaltWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardAsphaltWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardAsphaltWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0004A4C8 File Offset: 0x000486C8
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x0000648C File Offset: 0x0000468C
		public unsafe SECTR_AudioCue MediumGuardCarpetRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardCarpetRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardCarpetRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x0004A4F8 File Offset: 0x000486F8
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x000064AB File Offset: 0x000046AB
		public unsafe SECTR_AudioCue MediumGuardCarpetWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardCarpetWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardCarpetWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x0004A528 File Offset: 0x00048728
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x000064CA File Offset: 0x000046CA
		public unsafe SECTR_AudioCue MediumGuardConcreteRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardConcreteRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardConcreteRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x0004A558 File Offset: 0x00048758
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x000064E9 File Offset: 0x000046E9
		public unsafe SECTR_AudioCue MediumGuardConcreteWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardConcreteWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardConcreteWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x0004A588 File Offset: 0x00048788
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x00006508 File Offset: 0x00004708
		public unsafe SECTR_AudioCue MediumGuardGrassRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardGrassRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardGrassRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x0004A5B8 File Offset: 0x000487B8
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x00006527 File Offset: 0x00004727
		public unsafe SECTR_AudioCue MediumGuardGrassWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardGrassWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardGrassWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x0004A5E8 File Offset: 0x000487E8
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00006546 File Offset: 0x00004746
		public unsafe SECTR_AudioCue MediumGuardLinoleumRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardLinoleumRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardLinoleumRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x0004A618 File Offset: 0x00048818
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00006565 File Offset: 0x00004765
		public unsafe SECTR_AudioCue MediumGuardLinoleumWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardLinoleumWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardLinoleumWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0004A648 File Offset: 0x00048848
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00006584 File Offset: 0x00004784
		public unsafe SECTR_AudioCue MediumGuardMetalRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardMetalRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardMetalRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0004A678 File Offset: 0x00048878
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x000065A3 File Offset: 0x000047A3
		public unsafe SECTR_AudioCue MediumGuardMetalWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardMetalWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardMetalWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0004A6A8 File Offset: 0x000488A8
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x000065C2 File Offset: 0x000047C2
		public unsafe SECTR_AudioCue MediumGuardTimberRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardTimberRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardTimberRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0004A6D8 File Offset: 0x000488D8
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x000065E1 File Offset: 0x000047E1
		public unsafe SECTR_AudioCue MediumGuardTimberWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardTimberWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardTimberWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0004A708 File Offset: 0x00048908
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00006600 File Offset: 0x00004800
		public unsafe SECTR_AudioCue MediumGuardWoodRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardWoodRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardWoodRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0004A738 File Offset: 0x00048938
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x0000661F File Offset: 0x0000481F
		public unsafe SECTR_AudioCue MediumGuardWoodWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardWoodWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MediumGuardWoodWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x0004A768 File Offset: 0x00048968
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x0000663E File Offset: 0x0000483E
		public unsafe SECTR_AudioCue MelvinGuardAsphaltRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardAsphaltRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardAsphaltRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x0004A798 File Offset: 0x00048998
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x0000665D File Offset: 0x0000485D
		public unsafe SECTR_AudioCue MelvinGuardAsphaltWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardAsphaltWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardAsphaltWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x0004A7C8 File Offset: 0x000489C8
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x0000667C File Offset: 0x0000487C
		public unsafe SECTR_AudioCue MelvinGuardCarpetRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardCarpetRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardCarpetRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x0004A7F8 File Offset: 0x000489F8
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x0000669B File Offset: 0x0000489B
		public unsafe SECTR_AudioCue MelvinGuardCarpetWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardCarpetWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardCarpetWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x0004A828 File Offset: 0x00048A28
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x000066BA File Offset: 0x000048BA
		public unsafe SECTR_AudioCue MelvinGuardConcreteRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardConcreteRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardConcreteRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x0004A858 File Offset: 0x00048A58
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x000066D9 File Offset: 0x000048D9
		public unsafe SECTR_AudioCue MelvinGuardConcreteWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardConcreteWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardConcreteWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x0004A888 File Offset: 0x00048A88
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x000066F8 File Offset: 0x000048F8
		public unsafe SECTR_AudioCue MelvinGuardGrassRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardGrassRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardGrassRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x0004A8B8 File Offset: 0x00048AB8
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x00006717 File Offset: 0x00004917
		public unsafe SECTR_AudioCue MelvinGuardGrassWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardGrassWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardGrassWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x0004A8E8 File Offset: 0x00048AE8
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x00006736 File Offset: 0x00004936
		public unsafe SECTR_AudioCue MelvinGuardLinoleumRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardLinoleumRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardLinoleumRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x0004A918 File Offset: 0x00048B18
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00006755 File Offset: 0x00004955
		public unsafe SECTR_AudioCue MelvinGuardLinoleumWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardLinoleumWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardLinoleumWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x0004A948 File Offset: 0x00048B48
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x00006774 File Offset: 0x00004974
		public unsafe SECTR_AudioCue MelvinGuardMetalRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardMetalRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardMetalRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x0004A978 File Offset: 0x00048B78
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00006793 File Offset: 0x00004993
		public unsafe SECTR_AudioCue MelvinGuardMetalWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardMetalWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardMetalWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x0004A9A8 File Offset: 0x00048BA8
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x000067B2 File Offset: 0x000049B2
		public unsafe SECTR_AudioCue MelvinGuardTimberRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardTimberRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardTimberRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x0004A9D8 File Offset: 0x00048BD8
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x000067D1 File Offset: 0x000049D1
		public unsafe SECTR_AudioCue MelvinGuardTimberWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardTimberWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardTimberWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x0004AA08 File Offset: 0x00048C08
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x000067F0 File Offset: 0x000049F0
		public unsafe SECTR_AudioCue MelvinGuardWoodRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardWoodRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardWoodRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x0004AA38 File Offset: 0x00048C38
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x0000680F File Offset: 0x00004A0F
		public unsafe SECTR_AudioCue MelvinGuardWoodWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardWoodWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MelvinGuardWoodWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x0004AA68 File Offset: 0x00048C68
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x0000682E File Offset: 0x00004A2E
		public unsafe SECTR_AudioCue GearlessGuardAsphaltRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardAsphaltRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardAsphaltRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0004AA98 File Offset: 0x00048C98
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x0000684D File Offset: 0x00004A4D
		public unsafe SECTR_AudioCue GearlessGuardAsphaltWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardAsphaltWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardAsphaltWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x0004AAC8 File Offset: 0x00048CC8
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x0000686C File Offset: 0x00004A6C
		public unsafe SECTR_AudioCue GearlessGuardCarpetRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardCarpetRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardCarpetRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0004AAF8 File Offset: 0x00048CF8
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x0000688B File Offset: 0x00004A8B
		public unsafe SECTR_AudioCue GearlessGuardCarpetWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardCarpetWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardCarpetWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x0004AB28 File Offset: 0x00048D28
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x000068AA File Offset: 0x00004AAA
		public unsafe SECTR_AudioCue GearlessGuardConcreteRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardConcreteRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardConcreteRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x0004AB58 File Offset: 0x00048D58
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x000068C9 File Offset: 0x00004AC9
		public unsafe SECTR_AudioCue GearlessGuardConcreteWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardConcreteWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardConcreteWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x0004AB88 File Offset: 0x00048D88
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x000068E8 File Offset: 0x00004AE8
		public unsafe SECTR_AudioCue GearlessGuardGrassRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardGrassRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardGrassRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x0004ABB8 File Offset: 0x00048DB8
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00006907 File Offset: 0x00004B07
		public unsafe SECTR_AudioCue GearlessGuardGrassWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardGrassWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardGrassWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x0004ABE8 File Offset: 0x00048DE8
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00006926 File Offset: 0x00004B26
		public unsafe SECTR_AudioCue GearlessGuardLinoleumRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardLinoleumRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardLinoleumRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x0004AC18 File Offset: 0x00048E18
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x00006945 File Offset: 0x00004B45
		public unsafe SECTR_AudioCue GearlessGuardLinoleumWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardLinoleumWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardLinoleumWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x0004AC48 File Offset: 0x00048E48
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00006964 File Offset: 0x00004B64
		public unsafe SECTR_AudioCue GearlessGuardMetalRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardMetalRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardMetalRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x0004AC78 File Offset: 0x00048E78
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00006983 File Offset: 0x00004B83
		public unsafe SECTR_AudioCue GearlessGuardMetalWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardMetalWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardMetalWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x0004ACA8 File Offset: 0x00048EA8
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x000069A2 File Offset: 0x00004BA2
		public unsafe SECTR_AudioCue GearlessGuardTimberRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardTimberRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardTimberRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x0004ACD8 File Offset: 0x00048ED8
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x000069C1 File Offset: 0x00004BC1
		public unsafe SECTR_AudioCue GearlessGuardTimberWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardTimberWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardTimberWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x0004AD08 File Offset: 0x00048F08
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x000069E0 File Offset: 0x00004BE0
		public unsafe SECTR_AudioCue GearlessGuardWoodRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardWoodRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardWoodRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x0004AD38 File Offset: 0x00048F38
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x000069FF File Offset: 0x00004BFF
		public unsafe SECTR_AudioCue GearlessGuardWoodWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardWoodWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GearlessGuardWoodWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x0004AD68 File Offset: 0x00048F68
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x00006A1E File Offset: 0x00004C1E
		public unsafe SECTR_AudioCue GuardAsphaltRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardAsphaltRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardAsphaltRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x0004AD98 File Offset: 0x00048F98
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x00006A3D File Offset: 0x00004C3D
		public unsafe SECTR_AudioCue GuardAsphaltWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardAsphaltWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardAsphaltWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x0004ADC8 File Offset: 0x00048FC8
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x00006A5C File Offset: 0x00004C5C
		public unsafe SECTR_AudioCue GuardCarpetRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardCarpetRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardCarpetRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x0004ADF8 File Offset: 0x00048FF8
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x00006A7B File Offset: 0x00004C7B
		public unsafe SECTR_AudioCue GuardCarpetWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardCarpetWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardCarpetWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x0004AE28 File Offset: 0x00049028
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x00006A9A File Offset: 0x00004C9A
		public unsafe SECTR_AudioCue GuardConcreteRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardConcreteRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardConcreteRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x0004AE58 File Offset: 0x00049058
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x00006AB9 File Offset: 0x00004CB9
		public unsafe SECTR_AudioCue GuardConcreteWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardConcreteWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardConcreteWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x0004AE88 File Offset: 0x00049088
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00006AD8 File Offset: 0x00004CD8
		public unsafe SECTR_AudioCue GuardFuelCanisterShakeCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardFuelCanisterShakeCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardFuelCanisterShakeCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x0004AEB8 File Offset: 0x000490B8
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00006AF7 File Offset: 0x00004CF7
		public unsafe SECTR_AudioCue GuardGrassRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardGrassRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardGrassRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x0004AEE8 File Offset: 0x000490E8
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x00006B16 File Offset: 0x00004D16
		public unsafe SECTR_AudioCue GuardGrassWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardGrassWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardGrassWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x0004AF18 File Offset: 0x00049118
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x00006B35 File Offset: 0x00004D35
		public unsafe SECTR_AudioCue GuardHeavyGearShakeRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardHeavyGearShakeRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardHeavyGearShakeRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x0004AF48 File Offset: 0x00049148
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x00006B54 File Offset: 0x00004D54
		public unsafe SECTR_AudioCue GuardLightGearShakeRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardLightGearShakeRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardLightGearShakeRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x0004AF78 File Offset: 0x00049178
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x00006B73 File Offset: 0x00004D73
		public unsafe SECTR_AudioCue GuardLightGearShakeWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardLightGearShakeWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardLightGearShakeWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x0004AFA8 File Offset: 0x000491A8
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x00006B92 File Offset: 0x00004D92
		public unsafe SECTR_AudioCue GuardLinoleumRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardLinoleumRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardLinoleumRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x0004AFD8 File Offset: 0x000491D8
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x00006BB1 File Offset: 0x00004DB1
		public unsafe SECTR_AudioCue GuardLinoleumWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardLinoleumWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardLinoleumWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0004B008 File Offset: 0x00049208
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00006BD0 File Offset: 0x00004DD0
		public unsafe SECTR_AudioCue GuardMedGearShakeRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardMedGearShakeRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardMedGearShakeRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0004B038 File Offset: 0x00049238
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x00006BEF File Offset: 0x00004DEF
		public unsafe SECTR_AudioCue GuardMedGearShakeWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardMedGearShakeWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardMedGearShakeWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0004B068 File Offset: 0x00049268
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x00006C0E File Offset: 0x00004E0E
		public unsafe SECTR_AudioCue GuardMetalClipCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardMetalClipCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardMetalClipCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x0004B098 File Offset: 0x00049298
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x00006C2D File Offset: 0x00004E2D
		public unsafe SECTR_AudioCue GuardWetCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardWetCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardWetCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0004B0C8 File Offset: 0x000492C8
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00006C4C File Offset: 0x00004E4C
		public unsafe SECTR_AudioCue GuardMetalRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardMetalRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardMetalRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x0004B0F8 File Offset: 0x000492F8
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00006C6B File Offset: 0x00004E6B
		public unsafe SECTR_AudioCue GuardMetalWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardMetalWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardMetalWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x0004B128 File Offset: 0x00049328
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00006C8A File Offset: 0x00004E8A
		public unsafe SECTR_AudioCue GuardTimberRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardTimberRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardTimberRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x0004B158 File Offset: 0x00049358
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00006CA9 File Offset: 0x00004EA9
		public unsafe SECTR_AudioCue GuardTimberWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardTimberWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardTimberWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0004B188 File Offset: 0x00049388
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00006CC8 File Offset: 0x00004EC8
		public unsafe SECTR_AudioCue GuardWoodRunCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardWoodRunCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardWoodRunCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x0004B1B8 File Offset: 0x000493B8
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x00006CE7 File Offset: 0x00004EE7
		public unsafe SECTR_AudioCue GuardWoodWalkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardWoodWalkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardWoodWalkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x0004B1E8 File Offset: 0x000493E8
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x00006D06 File Offset: 0x00004F06
		public unsafe SECTR_AudioCue GuardCorpseSplatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardCorpseSplatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardCorpseSplatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x0004B218 File Offset: 0x00049418
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00006D25 File Offset: 0x00004F25
		public unsafe SECTR_AudioCue GuardFallYellCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardFallYellCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardFallYellCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x0004B248 File Offset: 0x00049448
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x00006D44 File Offset: 0x00004F44
		public unsafe SECTR_AudioCue GuardFlashlightOnCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardFlashlightOnCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardFlashlightOnCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x0004B278 File Offset: 0x00049478
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x00006D63 File Offset: 0x00004F63
		public unsafe SECTR_AudioCue GuardOceanSpatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardOceanSpatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardOceanSpatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x0004B2A8 File Offset: 0x000494A8
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x00006D82 File Offset: 0x00004F82
		public unsafe SECTR_AudioCue GuardShovedGruntCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardShovedGruntCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardShovedGruntCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x0004B2D8 File Offset: 0x000494D8
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x00006DA1 File Offset: 0x00004FA1
		public unsafe SECTR_AudioCue GuardSpatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardSpatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardSpatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x0004B308 File Offset: 0x00049508
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x00006DC0 File Offset: 0x00004FC0
		public unsafe SECTR_AudioCue GuardStreetSplatCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardStreetSplatCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardStreetSplatCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x0004B338 File Offset: 0x00049538
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x00006DDF File Offset: 0x00004FDF
		public unsafe SECTR_AudioCue GuardSwingInCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardSwingInCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardSwingInCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x0004B368 File Offset: 0x00049568
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x00006DFE File Offset: 0x00004FFE
		public unsafe SECTR_AudioCue GuardYelpCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardYelpCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardYelpCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x0004B398 File Offset: 0x00049598
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00006E1D File Offset: 0x0000501D
		public unsafe SECTR_AudioCue GuardPushedWooshCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardPushedWooshCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardPushedWooshCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0004B3C8 File Offset: 0x000495C8
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x00006E3C File Offset: 0x0000503C
		public unsafe SECTR_AudioCue GuardAhhhCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardAhhhCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardAhhhCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x0004B3F8 File Offset: 0x000495F8
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x00006E5B File Offset: 0x0000505B
		public unsafe SECTR_AudioCue GuardGaspCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardGaspCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardGaspCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x0004B428 File Offset: 0x00049628
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x00006E7A File Offset: 0x0000507A
		public unsafe SECTR_AudioCue GuardGrabbedGaspCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardGrabbedGaspCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardGrabbedGaspCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x0004B458 File Offset: 0x00049658
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x00006E99 File Offset: 0x00005099
		public unsafe SECTR_AudioCue GuardCowerCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardCowerCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardCowerCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x0004B488 File Offset: 0x00049688
		// (set) Token: 0x060007A9 RID: 1961 RVA: 0x00006EB8 File Offset: 0x000050B8
		public unsafe SECTR_AudioCue GuardYawnCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardYawnCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardYawnCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x0004B4B8 File Offset: 0x000496B8
		// (set) Token: 0x060007AB RID: 1963 RVA: 0x00006ED7 File Offset: 0x000050D7
		public unsafe SECTR_AudioCue GuardScratchCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardScratchCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GuardScratchCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x0004B4E8 File Offset: 0x000496E8
		// (set) Token: 0x060007AD RID: 1965 RVA: 0x00006EF6 File Offset: 0x000050F6
		public unsafe SECTR_AudioCue CrateBreakCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_CrateBreakCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_CrateBreakCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x0004B518 File Offset: 0x00049718
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x00006F15 File Offset: 0x00005115
		public unsafe SECTR_AudioCue GlassBreakCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GlassBreakCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GlassBreakCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x0004B548 File Offset: 0x00049748
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x00006F34 File Offset: 0x00005134
		public unsafe SECTR_AudioCue BombDropCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BombDropCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BombDropCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x0004B578 File Offset: 0x00049778
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x00006F53 File Offset: 0x00005153
		public unsafe SECTR_AudioCue BunkerCeilingHitCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BunkerCeilingHitCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BunkerCeilingHitCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0004B5A8 File Offset: 0x000497A8
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x00006F72 File Offset: 0x00005172
		public unsafe SECTR_AudioCue ExplosionCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ExplosionCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ExplosionCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x0004B5D8 File Offset: 0x000497D8
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x00006F91 File Offset: 0x00005191
		public unsafe SECTR_AudioCue MassiveGlassCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MassiveGlassCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MassiveGlassCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x0004B608 File Offset: 0x00049808
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x00006FB0 File Offset: 0x000051B0
		public unsafe SECTR_AudioCue LongBompDropCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LongBompDropCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LongBompDropCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x0004B638 File Offset: 0x00049838
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x00006FCF File Offset: 0x000051CF
		public unsafe SECTR_AudioCue MultiBombDropCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MultiBombDropCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_MultiBombDropCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x0004B668 File Offset: 0x00049868
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x00006FEE File Offset: 0x000051EE
		public unsafe SECTR_AudioCue FireInWorldCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FireInWorldCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FireInWorldCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x0004B698 File Offset: 0x00049898
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x0000700D File Offset: 0x0000520D
		public unsafe SECTR_AudioCue FlameThrowerCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameThrowerCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FlameThrowerCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0004B6C8 File Offset: 0x000498C8
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x0000702C File Offset: 0x0000522C
		public unsafe SECTR_AudioCue ApeOnFireCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeOnFireCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeOnFireCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x0004B6F8 File Offset: 0x000498F8
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x0000704B File Offset: 0x0000524B
		public unsafe SECTR_AudioCue BodyBurnUpCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BodyBurnUpCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BodyBurnUpCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0004B728 File Offset: 0x00049928
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x0000706A File Offset: 0x0000526A
		public unsafe SECTR_AudioCue FireBallCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FireBallCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_FireBallCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0004B758 File Offset: 0x00049958
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00007089 File Offset: 0x00005289
		public unsafe SECTR_AudioCue LightsUpCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightsUpCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_LightsUpCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0004B788 File Offset: 0x00049988
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x000070A8 File Offset: 0x000052A8
		public unsafe SECTR_AudioCue CableSnapCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_CableSnapCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_CableSnapCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x0004B7B8 File Offset: 0x000499B8
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x000070C7 File Offset: 0x000052C7
		public unsafe SECTR_AudioCue GeneratorPowerDownCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GeneratorPowerDownCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_GeneratorPowerDownCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x0004B7E8 File Offset: 0x000499E8
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x000070E6 File Offset: 0x000052E6
		public unsafe SECTR_AudioCue BedSqueakCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BedSqueakCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BedSqueakCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x0004B818 File Offset: 0x00049A18
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x00007105 File Offset: 0x00005305
		public unsafe SECTR_AudioCue DingCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DingCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DingCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0004B848 File Offset: 0x00049A48
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x00007124 File Offset: 0x00005324
		public unsafe SECTR_AudioCue TickingCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_TickingCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_TickingCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x0004B878 File Offset: 0x00049A78
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x00007143 File Offset: 0x00005343
		public unsafe SECTR_AudioCue SparkCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_SparkCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_SparkCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x0004B8A8 File Offset: 0x00049AA8
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x00007162 File Offset: 0x00005362
		public unsafe SECTR_AudioCue PlaneLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_PlaneLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_PlaneLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0004B8D8 File Offset: 0x00049AD8
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x00007181 File Offset: 0x00005381
		public unsafe SECTR_AudioCue EnvironmentalFireCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_EnvironmentalFireCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_EnvironmentalFireCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x0004B908 File Offset: 0x00049B08
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x000071A0 File Offset: 0x000053A0
		public unsafe SECTR_AudioCue DoorBendCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DoorBendCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DoorBendCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x0004B938 File Offset: 0x00049B38
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x000071BF File Offset: 0x000053BF
		public unsafe SECTR_AudioCue DoorDragCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DoorDragCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DoorDragCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x0004B968 File Offset: 0x00049B68
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x000071DE File Offset: 0x000053DE
		public unsafe SECTR_AudioCue DoorOpenCloseCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DoorOpenCloseCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DoorOpenCloseCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x0004B998 File Offset: 0x00049B98
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x000071FD File Offset: 0x000053FD
		public unsafe SECTR_AudioCue DoorFallCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DoorFallCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DoorFallCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x0004B9C8 File Offset: 0x00049BC8
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x0000721C File Offset: 0x0000541C
		public unsafe SECTR_AudioCue DoorRipOffCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DoorRipOffCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DoorRipOffCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x0004B9F8 File Offset: 0x00049BF8
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x0000723B File Offset: 0x0000543B
		public unsafe SECTR_AudioCue SwingyDoorCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_SwingyDoorCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_SwingyDoorCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0004BA28 File Offset: 0x00049C28
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x0000725A File Offset: 0x0000545A
		public unsafe SECTR_AudioCue BarDoorCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BarDoorCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BarDoorCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x0004BA58 File Offset: 0x00049C58
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00007279 File Offset: 0x00005479
		public unsafe SECTR_AudioCue BigDoorCreakOne
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BigDoorCreakOne);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BigDoorCreakOne), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x0004BA88 File Offset: 0x00049C88
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00007298 File Offset: 0x00005498
		public unsafe SECTR_AudioCue BigDoorCreakTwo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BigDoorCreakTwo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BigDoorCreakTwo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x0004BAB8 File Offset: 0x00049CB8
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x000072B7 File Offset: 0x000054B7
		public unsafe SECTR_AudioCue BigDoorCreakThree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BigDoorCreakThree);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BigDoorCreakThree), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0004BAE8 File Offset: 0x00049CE8
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x000072D6 File Offset: 0x000054D6
		public unsafe SECTR_AudioCue ApeWalkStepCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeWalkStepCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeWalkStepCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x0004BB18 File Offset: 0x00049D18
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x000072F5 File Offset: 0x000054F5
		public unsafe SECTR_AudioCue ApeRunStepCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeRunStepCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeRunStepCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x0004BB48 File Offset: 0x00049D48
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00007314 File Offset: 0x00005514
		public unsafe SECTR_AudioCue ApeCarpetStepCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeCarpetStepCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeCarpetStepCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x0004BB78 File Offset: 0x00049D78
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00007333 File Offset: 0x00005533
		public unsafe SECTR_AudioCue ApeParquetStepCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeParquetStepCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeParquetStepCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x0004BBA8 File Offset: 0x00049DA8
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x00007352 File Offset: 0x00005552
		public unsafe SECTR_AudioCue ApeLinoleumStepCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeLinoleumStepCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeLinoleumStepCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0004BBD8 File Offset: 0x00049DD8
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00007371 File Offset: 0x00005571
		public unsafe SECTR_AudioCue ApeMetalStepCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeMetalStepCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeMetalStepCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0004BC08 File Offset: 0x00049E08
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00007390 File Offset: 0x00005590
		public unsafe SECTR_AudioCue ApeConcreteStepCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeConcreteStepCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeConcreteStepCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x0004BC38 File Offset: 0x00049E38
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x000073AF File Offset: 0x000055AF
		public unsafe SECTR_AudioCue ApeTimberStepCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeTimberStepCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeTimberStepCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0004BC68 File Offset: 0x00049E68
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x000073CE File Offset: 0x000055CE
		public unsafe SECTR_AudioCue ApeGrassStepCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeGrassStepCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeGrassStepCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x0004BC98 File Offset: 0x00049E98
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x000073ED File Offset: 0x000055ED
		public unsafe SECTR_AudioCue ApeWoodStepCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeWoodStepCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeWoodStepCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x0004BCC8 File Offset: 0x00049EC8
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x0000740C File Offset: 0x0000560C
		public unsafe SECTR_AudioCue ApeWetStepCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeWetStepCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeWetStepCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x0004BCF8 File Offset: 0x00049EF8
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x0000742B File Offset: 0x0000562B
		public unsafe SECTR_AudioCue ApeAsphaltStepCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeAsphaltStepCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeAsphaltStepCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x0004BD28 File Offset: 0x00049F28
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x0000744A File Offset: 0x0000564A
		public unsafe SECTR_AudioCue ApeGrabsCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeGrabsCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeGrabsCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x0004BD58 File Offset: 0x00049F58
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00007469 File Offset: 0x00005669
		public unsafe SECTR_AudioCue ApeGrabsBodyPartCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeGrabsBodyPartCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeGrabsBodyPartCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x0004BD88 File Offset: 0x00049F88
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00007488 File Offset: 0x00005688
		public unsafe SECTR_AudioCue ApeGrabWhiffCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeGrabWhiffCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_ApeGrabWhiffCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x0004BDB8 File Offset: 0x00049FB8
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x000074A7 File Offset: 0x000056A7
		public unsafe SECTR_AudioCue RetrySwitchCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_RetrySwitchCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_RetrySwitchCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x0004BDE8 File Offset: 0x00049FE8
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x000074C6 File Offset: 0x000056C6
		public unsafe SECTR_AudioCue StickHitCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_StickHitCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_StickHitCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x0004BE18 File Offset: 0x0004A018
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x000074E5 File Offset: 0x000056E5
		public unsafe SECTR_AudioCue BoatSetPieceCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BoatSetPieceCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_BoatSetPieceCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x0004BE48 File Offset: 0x0004A048
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x00007504 File Offset: 0x00005704
		public unsafe SECTR_AudioCue CarCrashCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_CarCrashCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_CarCrashCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x0004BE78 File Offset: 0x0004A078
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x00007523 File Offset: 0x00005723
		public unsafe SECTR_AudioCue OfficeIntroCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_OfficeIntroCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_OfficeIntroCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x0004BEA8 File Offset: 0x0004A0A8
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x00007542 File Offset: 0x00005742
		public unsafe SECTR_AudioCue OfficeOutroCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_OfficeOutroCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_OfficeOutroCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x0004BED8 File Offset: 0x0004A0D8
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x00007561 File Offset: 0x00005761
		public unsafe SECTR_AudioCue AlarmCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_AlarmCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_AlarmCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x0004BF08 File Offset: 0x0004A108
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00007580 File Offset: 0x00005780
		public unsafe bool DebuggingResAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DebuggingResAudio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_DebuggingResAudio)) = value;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x0004BF30 File Offset: 0x0004A130
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x0000759B File Offset: 0x0000579B
		public unsafe bool OverriddenFloor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_OverriddenFloor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_OverriddenFloor)) = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x0004BF58 File Offset: 0x0004A158
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x000075B6 File Offset: 0x000057B6
		public unsafe Level.FloorMaterial OverrideFloorMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_OverrideFloorMat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_OverrideFloorMat)) = value;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x0004BF80 File Offset: 0x0004A180
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x000075D1 File Offset: 0x000057D1
		public unsafe int melvinStepNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_melvinStepNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_melvinStepNum)) = value;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x0004BFA8 File Offset: 0x0004A1A8
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x000075EC File Offset: 0x000057EC
		public unsafe static SoundSystem me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SoundSystem.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoundSystem>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SoundSystem.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x0004BFD0 File Offset: 0x0004A1D0
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x000075FE File Offset: 0x000057FE
		public unsafe bool destroyingAmb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_destroyingAmb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_destroyingAmb)) = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x0004BFF8 File Offset: 0x0004A1F8
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x00007619 File Offset: 0x00005819
		public unsafe bool yelling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_yelling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_yelling)) = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x0004C020 File Offset: 0x0004A220
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x00007634 File Offset: 0x00005834
		public unsafe List<SECTR_AudioCueInstance> alarmInst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_alarmInst);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_AudioCueInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_alarmInst), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x0004C050 File Offset: 0x0004A250
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x00007653 File Offset: 0x00005853
		public unsafe float bloodiness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_bloodiness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_bloodiness)) = value;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x0004C078 File Offset: 0x0004A278
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x0000766E File Offset: 0x0000586E
		public unsafe bool bloodyApe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_bloodyApe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_bloodyApe)) = value;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x0004C0A0 File Offset: 0x0004A2A0
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x00007689 File Offset: 0x00005889
		public unsafe AudioSource doorRipOffSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_doorRipOffSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_doorRipOffSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x0004C0D0 File Offset: 0x0004A2D0
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x000076A8 File Offset: 0x000058A8
		public unsafe int fireSourceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_fireSourceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_fireSourceIndex)) = value;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x0004C0F8 File Offset: 0x0004A2F8
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x000076C3 File Offset: 0x000058C3
		public SECTR_AudioCueInstance tickingInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_tickingInstance);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundSystem.NativeFieldInfoPtr_tickingInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeFieldInfoPtr_AmbianceAudSource;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeFieldInfoPtr_SECTRMixerGroup;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeFieldInfoPtr_AmbianceMixerGroup;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeFieldInfoPtr_MetaMixerGroup;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeFieldInfoPtr_ApplianceMatCue;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeFieldInfoPtr_BarsMatCue;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeFieldInfoPtr_ConcreteMatCue;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeFieldInfoPtr_DryWallMatCue;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeFieldInfoPtr_FenceMatCue;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeFieldInfoPtr_FleshMatCue;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeFieldInfoPtr_RockMatCue;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeFieldInfoPtr_ThickMetalMatCue;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeFieldInfoPtr_ThinMetalMatCue;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeFieldInfoPtr_TreeMatCue;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeFieldInfoPtr_WoodMatCue;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeFieldInfoPtr_ApplianceSplatCue;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeFieldInfoPtr_BarsSplatCue;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeFieldInfoPtr_ConcreteSplatCue;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeFieldInfoPtr_DryWallSplatCue;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeFieldInfoPtr_FenceSplatCue;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeFieldInfoPtr_FleshSplatCue;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeFieldInfoPtr_RockSplatCue;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeFieldInfoPtr_ThickMetalSplatCue;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeFieldInfoPtr_ThinMetalSplatCue;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeFieldInfoPtr_TreeSplatCue;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeFieldInfoPtr_WoodSplatCue;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeFieldInfoPtr_BulletHitFleshCue;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeFieldInfoPtr_BulletHitVestCue;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeFieldInfoPtr_BulletHitConcreteCue;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeFieldInfoPtr_BulletHitWoodCue;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeFieldInfoPtr_BulletHitGlassCue;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeFieldInfoPtr_BulletHitMetalCue;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeFieldInfoPtr_BulletHitMetalDoorCue;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeFieldInfoPtr_BulletCasingOnCarpet;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeFieldInfoPtr_BulletCasingOnCement;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeFieldInfoPtr_BulletCasingOnDirt;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeFieldInfoPtr_BulletCasingOnGrass;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr_BulletCasingOnTile;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeFieldInfoPtr_BulletCasingOnLinoleum;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeFieldInfoPtr_BulletCasingOnWood;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeFieldInfoPtr_MachineGunShotCue;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeFieldInfoPtr_RifleShotCue;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeFieldInfoPtr_RocketLaunchCue;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeFieldInfoPtr_ShotgunShotCue;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeFieldInfoPtr_SniperRifleShotCue;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeFieldInfoPtr_TranquilizerShotCue;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeFieldInfoPtr_MachineGunCockCue;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeFieldInfoPtr_RifleCockCue;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeFieldInfoPtr_RocketLauncherCockCue;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeFieldInfoPtr_ShotgunCockCue;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeFieldInfoPtr_SniperRifleCockCue;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeFieldInfoPtr_TranquilizerCockCue;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeFieldInfoPtr_HeavyGuardAsphaltRunCue;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeFieldInfoPtr_HeavyGuardAsphaltWalkCue;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeFieldInfoPtr_HeavyGuardCarpetRunCue;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeFieldInfoPtr_HeavyGuardCarpetWalkCue;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr_HeavyGuardConcreteRunCue;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr_HeavyGuardConcreteWalkCue;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeFieldInfoPtr_HeavyGuardGrassRunCue;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeFieldInfoPtr_HeavyGuardGrassWalkCue;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeFieldInfoPtr_HeavyGuardLinoleumRunCue;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeFieldInfoPtr_HeavyGuardLinoleumWalkCue;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeFieldInfoPtr_HeavyGuardMetalRunCue;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeFieldInfoPtr_HeavyGuardMetalWalkCue;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeFieldInfoPtr_HeavyGuardTimberRunCue;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeFieldInfoPtr_HeavyGuardTimberWalkCue;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeFieldInfoPtr_HeavyGuardWoodRunCue;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeFieldInfoPtr_HeavyGuardWoodWalkCue;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeFieldInfoPtr_LightGuardAsphaltRunCue;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeFieldInfoPtr_LightGuardAsphaltWalkCue;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr_LightGuardCarpetRunCue;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_LightGuardCarpetWalkCue;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_LightGuardConcreteRunCue;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeFieldInfoPtr_LightGuardConcreteWalkCue;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeFieldInfoPtr_LightGuardGrassRunCue;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr_LightGuardGrassWalkCue;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr_LightGuardLinoleumRunCue;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr_LightGuardLinoleumWalkCue;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_LightGuardMetalRunCue;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr_LightGuardMetalWalkCue;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr_LightGuardTimberRunCue;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeFieldInfoPtr_LightGuardTimberWalkCue;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr_LightGuardWoodRunCue;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr_LightGuardWoodWalkCue;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeFieldInfoPtr_FlameGuardAsphaltRunCue;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeFieldInfoPtr_FlameGuardAsphaltWalkCue;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeFieldInfoPtr_FlameGuardCarpetRunCue;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeFieldInfoPtr_FlameGuardCarpetWalkCue;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeFieldInfoPtr_FlameGuardConcreteRunCue;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeFieldInfoPtr_FlameGuardConcreteWalkCue;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeFieldInfoPtr_FlameGuardGrassRunCue;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeFieldInfoPtr_FlameGuardGrassWalkCue;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeFieldInfoPtr_FlameGuardLinoleumRunCue;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeFieldInfoPtr_FlameGuardLinoleumWalkCue;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeFieldInfoPtr_FlameGuardMetalRunCue;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeFieldInfoPtr_FlameGuardMetalWalkCue;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeFieldInfoPtr_FlameGuardTimberRunCue;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeFieldInfoPtr_FlameGuardTimberWalkCue;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeFieldInfoPtr_FlameGuardWoodRunCue;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeFieldInfoPtr_FlameGuardWoodWalkCue;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeFieldInfoPtr_MediumGuardAsphaltRunCue;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeFieldInfoPtr_MediumGuardAsphaltWalkCue;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeFieldInfoPtr_MediumGuardCarpetRunCue;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeFieldInfoPtr_MediumGuardCarpetWalkCue;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeFieldInfoPtr_MediumGuardConcreteRunCue;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeFieldInfoPtr_MediumGuardConcreteWalkCue;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeFieldInfoPtr_MediumGuardGrassRunCue;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeFieldInfoPtr_MediumGuardGrassWalkCue;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeFieldInfoPtr_MediumGuardLinoleumRunCue;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeFieldInfoPtr_MediumGuardLinoleumWalkCue;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeFieldInfoPtr_MediumGuardMetalRunCue;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeFieldInfoPtr_MediumGuardMetalWalkCue;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeFieldInfoPtr_MediumGuardTimberRunCue;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeFieldInfoPtr_MediumGuardTimberWalkCue;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeFieldInfoPtr_MediumGuardWoodRunCue;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeFieldInfoPtr_MediumGuardWoodWalkCue;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeFieldInfoPtr_MelvinGuardAsphaltRunCue;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeFieldInfoPtr_MelvinGuardAsphaltWalkCue;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeFieldInfoPtr_MelvinGuardCarpetRunCue;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr_MelvinGuardCarpetWalkCue;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr_MelvinGuardConcreteRunCue;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeFieldInfoPtr_MelvinGuardConcreteWalkCue;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr_MelvinGuardGrassRunCue;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr_MelvinGuardGrassWalkCue;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeFieldInfoPtr_MelvinGuardLinoleumRunCue;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr_MelvinGuardLinoleumWalkCue;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeFieldInfoPtr_MelvinGuardMetalRunCue;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr_MelvinGuardMetalWalkCue;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_MelvinGuardTimberRunCue;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_MelvinGuardTimberWalkCue;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_MelvinGuardWoodRunCue;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_MelvinGuardWoodWalkCue;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_GearlessGuardAsphaltRunCue;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_GearlessGuardAsphaltWalkCue;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_GearlessGuardCarpetRunCue;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_GearlessGuardCarpetWalkCue;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_GearlessGuardConcreteRunCue;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeFieldInfoPtr_GearlessGuardConcreteWalkCue;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeFieldInfoPtr_GearlessGuardGrassRunCue;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeFieldInfoPtr_GearlessGuardGrassWalkCue;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeFieldInfoPtr_GearlessGuardLinoleumRunCue;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeFieldInfoPtr_GearlessGuardLinoleumWalkCue;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeFieldInfoPtr_GearlessGuardMetalRunCue;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeFieldInfoPtr_GearlessGuardMetalWalkCue;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeFieldInfoPtr_GearlessGuardTimberRunCue;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeFieldInfoPtr_GearlessGuardTimberWalkCue;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeFieldInfoPtr_GearlessGuardWoodRunCue;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeFieldInfoPtr_GearlessGuardWoodWalkCue;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeFieldInfoPtr_GuardAsphaltRunCue;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeFieldInfoPtr_GuardAsphaltWalkCue;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeFieldInfoPtr_GuardCarpetRunCue;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeFieldInfoPtr_GuardCarpetWalkCue;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeFieldInfoPtr_GuardConcreteRunCue;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeFieldInfoPtr_GuardConcreteWalkCue;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeFieldInfoPtr_GuardFuelCanisterShakeCue;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeFieldInfoPtr_GuardGrassRunCue;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeFieldInfoPtr_GuardGrassWalkCue;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeFieldInfoPtr_GuardHeavyGearShakeRunCue;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeFieldInfoPtr_GuardLightGearShakeRunCue;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeFieldInfoPtr_GuardLightGearShakeWalkCue;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeFieldInfoPtr_GuardLinoleumRunCue;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeFieldInfoPtr_GuardLinoleumWalkCue;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeFieldInfoPtr_GuardMedGearShakeRunCue;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeFieldInfoPtr_GuardMedGearShakeWalkCue;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeFieldInfoPtr_GuardMetalClipCue;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeFieldInfoPtr_GuardWetCue;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeFieldInfoPtr_GuardMetalRunCue;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeFieldInfoPtr_GuardMetalWalkCue;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeFieldInfoPtr_GuardTimberRunCue;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeFieldInfoPtr_GuardTimberWalkCue;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeFieldInfoPtr_GuardWoodRunCue;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeFieldInfoPtr_GuardWoodWalkCue;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeFieldInfoPtr_GuardCorpseSplatCue;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeFieldInfoPtr_GuardFallYellCue;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeFieldInfoPtr_GuardFlashlightOnCue;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr_GuardOceanSpatCue;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr_GuardShovedGruntCue;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr_GuardSpatCue;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeFieldInfoPtr_GuardStreetSplatCue;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeFieldInfoPtr_GuardSwingInCue;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeFieldInfoPtr_GuardYelpCue;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeFieldInfoPtr_GuardPushedWooshCue;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeFieldInfoPtr_GuardAhhhCue;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeFieldInfoPtr_GuardGaspCue;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeFieldInfoPtr_GuardGrabbedGaspCue;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeFieldInfoPtr_GuardCowerCue;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeFieldInfoPtr_GuardYawnCue;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr_GuardScratchCue;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr_CrateBreakCue;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeFieldInfoPtr_GlassBreakCue;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeFieldInfoPtr_BombDropCue;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeFieldInfoPtr_BunkerCeilingHitCue;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionCue;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeFieldInfoPtr_MassiveGlassCue;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeFieldInfoPtr_LongBompDropCue;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeFieldInfoPtr_MultiBombDropCue;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr_FireInWorldCue;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr_FlameThrowerCue;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr_ApeOnFireCue;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeFieldInfoPtr_BodyBurnUpCue;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeFieldInfoPtr_FireBallCue;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeFieldInfoPtr_LightsUpCue;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeFieldInfoPtr_CableSnapCue;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeFieldInfoPtr_GeneratorPowerDownCue;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeFieldInfoPtr_BedSqueakCue;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeFieldInfoPtr_DingCue;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeFieldInfoPtr_TickingCue;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeFieldInfoPtr_SparkCue;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeFieldInfoPtr_PlaneLoop;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeFieldInfoPtr_EnvironmentalFireCue;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeFieldInfoPtr_DoorBendCue;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeFieldInfoPtr_DoorDragCue;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeFieldInfoPtr_DoorOpenCloseCue;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeFieldInfoPtr_DoorFallCue;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeFieldInfoPtr_DoorRipOffCue;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeFieldInfoPtr_SwingyDoorCue;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeFieldInfoPtr_BarDoorCue;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeFieldInfoPtr_BigDoorCreakOne;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeFieldInfoPtr_BigDoorCreakTwo;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeFieldInfoPtr_BigDoorCreakThree;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeFieldInfoPtr_ApeWalkStepCue;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeFieldInfoPtr_ApeRunStepCue;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeFieldInfoPtr_ApeCarpetStepCue;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeFieldInfoPtr_ApeParquetStepCue;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeFieldInfoPtr_ApeLinoleumStepCue;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeFieldInfoPtr_ApeMetalStepCue;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeFieldInfoPtr_ApeConcreteStepCue;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeFieldInfoPtr_ApeTimberStepCue;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeFieldInfoPtr_ApeGrassStepCue;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeFieldInfoPtr_ApeWoodStepCue;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeFieldInfoPtr_ApeWetStepCue;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeFieldInfoPtr_ApeAsphaltStepCue;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeFieldInfoPtr_ApeGrabsCue;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeFieldInfoPtr_ApeGrabsBodyPartCue;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeFieldInfoPtr_ApeGrabWhiffCue;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeFieldInfoPtr_RetrySwitchCue;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeFieldInfoPtr_StickHitCue;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr_BoatSetPieceCue;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeFieldInfoPtr_CarCrashCue;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeFieldInfoPtr_OfficeIntroCue;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeFieldInfoPtr_OfficeOutroCue;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeFieldInfoPtr_AlarmCue;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeFieldInfoPtr_DebuggingResAudio;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeFieldInfoPtr_OverriddenFloor;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeFieldInfoPtr_OverrideFloorMat;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeFieldInfoPtr_melvinStepNum;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeFieldInfoPtr_destroyingAmb;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeFieldInfoPtr_yelling;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeFieldInfoPtr_alarmInst;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeFieldInfoPtr_bloodiness;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeFieldInfoPtr_bloodyApe;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeFieldInfoPtr_doorRipOffSource;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeFieldInfoPtr_fireSourceIndex;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeFieldInfoPtr_tickingInstance;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_SetYelling_Public_Void_Boolean_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_AlarmDoorStart_Public_Void_List_1_Vector3_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_AcceptAmbiance_Public_Void_AudioSource_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_DestroyAmbiance_Public_Void_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_ReallyDestroyAmb_Private_Void_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_AlarmDoorStop_Public_Void_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_Grab_Public_Void_Transform_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_GrabBodyPart_Public_Void_Transform_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_GrabWhiff_Public_Void_Transform_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_SetBloodiness_Public_Void_Single_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_ApeStep_Public_Void_Single_Transform_FloorMaterial_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_GuardStep_Public_Void_Single_Transform_GuardBodyType_WeaponType_FloorMaterial_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_GuardShovedGrunt_Public_Void_Transform_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_GuardFallYell_Public_SECTR_AudioCueInstance_Vector3_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_GuardFallYell_Public_SECTR_AudioCueInstance_Transform_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_GuardAhh_Public_SECTR_AudioCueInstance_Transform_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_GuardGasp_Public_Void_Transform_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_GuardGrabbedGasp_Public_Void_Transform_GuardBodyType_WeaponType_FloorMaterial_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_GuardGrabbedGaspLoud_Public_Void_Transform_GuardBodyType_WeaponType_FloorMaterial_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_GuardCower_Public_SECTR_AudioCueInstance_Transform_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_GuardYawn_Public_SECTR_AudioCueInstance_Transform_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_GuardScratch_Public_SECTR_AudioCueInstance_Transform_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_GuardSwingIn_Public_Void_Transform_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_GuardPushedWoosh_Public_SECTR_AudioCueInstance_Transform_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_RifleShot_Public_Void_Vector3_Quaternion_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr_ShotgunShot_Public_Void_Vector3_Quaternion_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_MachineGunShot_Public_Void_Vector3_Quaternion_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_SniperRifleShot_Public_Void_Vector3_Quaternion_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_TranqShot_Public_Void_Vector3_Quaternion_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_LaunchRocket_Public_Void_Transform_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_GuardYelp_Public_Void_Transform_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_AllGunsCockAtOnce_Public_Void_Transform_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_RifleCock_Public_SECTR_AudioCueInstance_Transform_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_ShotgunCock_Public_SECTR_AudioCueInstance_Transform_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_MachineGunCock_Public_SECTR_AudioCueInstance_Transform_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_SniperRifleCock_Public_SECTR_AudioCueInstance_Transform_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_RocketLauncherCock_Public_SECTR_AudioCueInstance_Transform_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_BulletHitWall_Public_Void_Vector3_SurfaceMaterial_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_BulletHitWall_Public_Void_Transform_SurfaceMaterial_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_BulletHitFlesh_Public_Void_Vector3_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_BulletHitVest_Public_Void_Vector3_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_BulletHitConcrete_Public_Void_Vector3_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_BulletHitWood_Public_Void_Vector3_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_BulletHitMetal_Public_Void_Vector3_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_BulletHitMetalDoor_Public_Void_Vector3_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_BulletHitGlass_Public_Void_Vector3_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_BulletCasingFell_Public_Void_Transform_FloorMaterial_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_BreakCrate_Public_Void_Transform_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_GlassBreak_Public_Void_Vector3_Transform_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_MetalDoorBend_Public_Void_Transform_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_BigDoorCreak_Public_SECTR_AudioCueInstance_Int32_Transform_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_DoorRipOff_Public_Single_Transform_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_MetalDoorDragStart_Public_SECTRLoopThrough_Transform_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_DoorFall_Public_Void_Transform_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_DoorOpenClose_Public_Void_Vector3_Transform_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_SwingyDoor_Public_Void_Transform_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_MassiveGlass_Public_Void_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_Explosion_Public_Void_Transform_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_InWorldFireStart_Public_SECTR_AudioCueInstance_Transform_0;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_FireBall_Public_Void_Transform_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_FireStart_Public_SECTR_AudioCueInstance_Transform_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr_FlameThrowerStart_Public_SECTRLoopThrough_Transform_0;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr_GuardSurfaceHit_Public_Void_Transform_Quaternion_SoundMaterial_0;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr_GuardSplat_Public_Void_Transform_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr_GuardStreetSplat_Public_Void_Vector3_0;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_GuardStreetSplat_Public_Void_Transform_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_GuardOceanSplat_Public_Void_Transform_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_GuardFlashLightOn_Public_Void_Transform_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_CorpseSplat_Public_Void_Vector3_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_ApeLit_Public_SECTR_AudioCueInstance_Transform_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_LightsUp_Public_Void_Transform_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_BunkerCeilingHit_Public_Void_Transform_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_CableSnap_Public_Void_Transform_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_BodyBurnUp_Public_Void_Transform_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_SurfaceSplat_Public_Void_Transform_Quaternion_SoundMaterial_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_SurfaceSplat_Public_Void_Vector3_Quaternion_SoundMaterial_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_SurfaceHit_Public_Void_Transform_Quaternion_SoundMaterial_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_SurfaceHit_Public_Void_Vector3_Quaternion_SoundMaterial_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_RetrySwitch_Public_Void_Transform_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_BedSqueak_Public_Void_Vector3_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_Ding_Public_Void_Vector3_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_StickHit_Public_Void_Transform_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_BarDoorClose_Public_Void_Transform_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_DropBomb_Public_Void_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_DropIntroBomb_Public_Void_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_MultiBombDrop_Public_Void_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_StartTicking_Public_SECTR_AudioCueInstance_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_StopTicking_Public_Void_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_PlayBoatSetPiece_Public_Void_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_PlayCarCrash_Public_Void_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_Spark_Public_Void_Transform_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_GeneratorPowerDown_Public_Void_Transform_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_PlayOfficeIntro_Public_Void_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_PlayOfficeOutro_Public_Void_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
