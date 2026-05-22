using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering.PostProcessing;

namespace Il2Cpp
{
	// Token: 0x020000E8 RID: 232
	public class Global : MonoBehaviour
	{
		// Token: 0x06001A90 RID: 6800 RVA: 0x0007FC58 File Offset: 0x0007DE58
		// Note: this type is marked as 'beforefieldinit'.
		static Global()
		{
			Il2CppClassPointerStore<Global>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Global");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Global>.NativeClassPtr);
			Global.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "me");
			Global.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "player");
			Global.NativeFieldInfoPtr_playerTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "playerTrans");
			Global.NativeFieldInfoPtr_playerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "playerState");
			Global.NativeFieldInfoPtr_manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "manager");
			Global.NativeFieldInfoPtr_rumbler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "rumbler");
			Global.NativeFieldInfoPtr_camControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "camControl");
			Global.NativeFieldInfoPtr_searchGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "searchGrid");
			Global.NativeFieldInfoPtr_pathFinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "pathFinding");
			Global.NativeFieldInfoPtr_shadowLayerer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "shadowLayerer");
			Global.NativeFieldInfoPtr_mac = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "mac");
			Global.NativeFieldInfoPtr_guardIdleSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "guardIdleSpd");
			Global.NativeFieldInfoPtr_guardSearchSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "guardSearchSpd");
			Global.NativeFieldInfoPtr_guardChaseSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "guardChaseSpd");
			Global.NativeFieldInfoPtr_guardStalkSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "guardStalkSpd");
			Global.NativeFieldInfoPtr_guardAttackSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "guardAttackSpd");
			Global.NativeFieldInfoPtr_fatIdleSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "fatIdleSpd");
			Global.NativeFieldInfoPtr_fatSearchSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "fatSearchSpd");
			Global.NativeFieldInfoPtr_fatChaseSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "fatChaseSpd");
			Global.NativeFieldInfoPtr_fatStalkSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "fatStalkSpd");
			Global.NativeFieldInfoPtr_fatAttackSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "fatAttackSpd");
			Global.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "level");
			Global.NativeFieldInfoPtr_uncaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "uncaged");
			Global.NativeFieldInfoPtr_tileBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "tileBuilding");
			Global.NativeFieldInfoPtr_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "free");
			Global.NativeFieldInfoPtr_apeLit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "apeLit");
			Global.NativeFieldInfoPtr_apeLitTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "apeLitTimer");
			Global.NativeFieldInfoPtr_stealthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "stealthLevel");
			Global.NativeFieldInfoPtr_leaderboards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "leaderboards");
			Global.NativeFieldInfoPtr_healthMaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "healthMaster");
			Global.NativeFieldInfoPtr_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "menu");
			Global.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "mode");
			Global.NativeFieldInfoPtr_glassBreakTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "glassBreakTime");
			Global.NativeFieldInfoPtr_parTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "parTime");
			Global.NativeFieldInfoPtr_guardsKilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "guardsKilled");
			Global.NativeFieldInfoPtr_elevatorGuards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "elevatorGuards");
			Global.NativeFieldInfoPtr_noElevators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "noElevators");
			Global.NativeFieldInfoPtr_killerAssigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "killerAssigned");
			Global.NativeFieldInfoPtr_intro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "intro");
			Global.NativeFieldInfoPtr_newGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "newGame");
			Global.NativeFieldInfoPtr_trailer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "trailer");
			Global.NativeFieldInfoPtr_titles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "titles");
			Global.NativeFieldInfoPtr_shownTitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "shownTitles");
			Global.NativeFieldInfoPtr_endOfAct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "endOfAct");
			Global.NativeFieldInfoPtr_camMaxX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "camMaxX");
			Global.NativeFieldInfoPtr_guardMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "guardMats");
			Global.NativeFieldInfoPtr_bloodyGuardMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "bloodyGuardMats");
			Global.NativeFieldInfoPtr_killerGuardMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "killerGuardMats");
			Global.NativeFieldInfoPtr_trailerGarbageBin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "trailerGarbageBin");
			Global.NativeFieldInfoPtr_trailerGuardsKilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "trailerGuardsKilled");
			Global.NativeFieldInfoPtr_titleSnapShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "titleSnapShot");
			Global.NativeFieldInfoPtr_normalSnapShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "normalSnapShot");
			Global.NativeFieldInfoPtr_trailerVignettes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "trailerVignettes");
			Global.NativeFieldInfoPtr_playerStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "playerStartPos");
			Global.NativeFieldInfoPtr_timeSinceLastKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "timeSinceLastKill");
			Global.NativeFieldInfoPtr_guardsOnScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "guardsOnScreen");
			Global.NativeFieldInfoPtr_titling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "titling");
			Global.NativeFieldInfoPtr_introing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "introing");
			Global.NativeFieldInfoPtr_roomState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "roomState");
			Global.NativeFieldInfoPtr_trailerPlayerDied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "trailerPlayerDied");
			Global.NativeFieldInfoPtr_curVignette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "curVignette");
			Global.NativeFieldInfoPtr_doingTrailerThang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "doingTrailerThang");
			Global.NativeFieldInfoPtr_rumble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "rumble");
			Global.NativeFieldInfoPtr_framNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "framNum");
			Global.NativeFieldInfoPtr_playerMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "playerMovement");
			Global.NativeFieldInfoPtr_audioMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "audioMixer");
			Global.NativeFieldInfoPtr_gonnaEarnCheevo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "gonnaEarnCheevo");
			Global.NativeFieldInfoPtr_shadowOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "shadowOrigin");
			Global.NativeFieldInfoPtr_shadowOriginV3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "shadowOriginV3");
			Global.NativeFieldInfoPtr_mapGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "mapGenerator");
			Global.NativeFieldInfoPtr_curLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "curLevel");
			Global.NativeFieldInfoPtr_diedOnLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "diedOnLevel");
			Global.NativeFieldInfoPtr_stairList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "stairList");
			Global.NativeFieldInfoPtr_curFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "curFloor");
			Global.NativeFieldInfoPtr_sniperList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "sniperList");
			Global.NativeFieldInfoPtr_shadowOriginOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "shadowOriginOverride");
			Global.NativeFieldInfoPtr_treeMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "treeMeshes");
			Global.NativeFieldInfoPtr_officePlantMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "officePlantMeshes");
			Global.NativeFieldInfoPtr_tropical1Meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "tropical1Meshes");
			Global.NativeFieldInfoPtr_tropical2Meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "tropical2Meshes");
			Global.NativeFieldInfoPtr_guardAnimControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "guardAnimControllers");
			Global.NativeFieldInfoPtr_paraCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "paraCurve");
			Global.NativeFieldInfoPtr_containerMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "containerMats");
			Global.NativeFieldInfoPtr_indoorContainerMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "indoorContainerMats");
			Global.NativeFieldInfoPtr_outdoorContainerMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "outdoorContainerMats");
			Global.NativeFieldInfoPtr_deathContainerMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "deathContainerMat");
			Global.NativeFieldInfoPtr_justPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "justPaused");
			Global.NativeFieldInfoPtr_transitionTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "transitionTile");
			Global.NativeFieldInfoPtr_startTileTelepoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "startTileTelepoint");
			Global.NativeFieldInfoPtr_lastCymbal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "lastCymbal");
			Global.NativeFieldInfoPtr_PlayerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "PlayerTag");
			Global.NativeFieldInfoPtr_EnemyTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "EnemyTag");
			Global.NativeFieldInfoPtr_PebbleMagnetTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "PebbleMagnetTag");
			Global.NativeFieldInfoPtr_delayForFixedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "delayForFixedUpdate");
			Global.NativeFieldInfoPtr_delay1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "delay1");
			Global.NativeFieldInfoPtr_delaypt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "delaypt1");
			Global.NativeFieldInfoPtr_arcadeModeTransitionTitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "arcadeModeTransitionTitles");
			Global.NativeFieldInfoPtr_swappedMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "swappedMusic");
			Global.NativeFieldInfoPtr_isPacifist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "isPacifist");
			Global.NativeFieldInfoPtr_isPerfect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "isPerfect");
			Global.NativeFieldInfoPtr_weBlind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "weBlind");
			Global.NativeFieldInfoPtr_containerRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "containerRoom");
			Global.NativeFieldInfoPtr_containerReverb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "containerReverb");
			Global.NativeFieldInfoPtr_containerAmbiance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "containerAmbiance");
			Global.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "intensity");
			Global.NativeFieldInfoPtr_maxIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "maxIntensity");
			Global.NativeFieldInfoPtr_normalizedIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "normalizedIntensity");
			Global.NativeFieldInfoPtr_debugIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "debugIntensity");
			Global.NativeFieldInfoPtr_intensityDebugTxt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "intensityDebugTxt");
			Global.NativeFieldInfoPtr_bonusDecay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "bonusDecay");
			Global.NativeFieldInfoPtr_baselineSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "baselineSmooth");
			Global.NativeFieldInfoPtr_bonusWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "bonusWeight");
			Global.NativeFieldInfoPtr_baselineWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "baselineWeight");
			Global.NativeFieldInfoPtr_maxIntensityFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "maxIntensityFloor");
			Global.NativeFieldInfoPtr_floorAdjustmentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "floorAdjustmentSpeed");
			Global.NativeFieldInfoPtr_maxDecay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "maxDecay");
			Global.NativeFieldInfoPtr_disableDynamicIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "disableDynamicIntensity");
			Global.NativeFieldInfoPtr_FixedDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "FixedDeltaTime");
			Global.NativeFieldInfoPtr_postVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "postVolume");
			Global.NativeFieldInfoPtr_normalProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "normalProfile");
			Global.NativeFieldInfoPtr_splodeProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "splodeProfile");
			Global.NativeFieldInfoPtr_blurProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "blurProfile");
			Global.NativeFieldInfoPtr_normalProfileSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "normalProfileSwitch");
			Global.NativeFieldInfoPtr_splodeProfileSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "splodeProfileSwitch");
			Global.NativeFieldInfoPtr_blurProfileSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "blurProfileSwitch");
			Global.NativeFieldInfoPtr_bwProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "bwProfile");
			Global.NativeFieldInfoPtr_fixedNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "fixedNum");
			Global.NativeFieldInfoPtr_timeDebt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "timeDebt");
			Global.NativeFieldInfoPtr_fixedUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "fixedUpdates");
			Global.NativeFieldInfoPtr_ambInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "ambInd");
			Global.NativeFieldInfoPtr_floorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "floorMaterial");
			Global.NativeFieldInfoPtr_dontPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "dontPause");
			Global.NativeFieldInfoPtr_readyToStartMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "readyToStartMusic");
			Global.NativeFieldInfoPtr_prevKills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "prevKills");
			Global.NativeFieldInfoPtr_exitObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "exitObj");
			Global.NativeFieldInfoPtr_mapWidths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "mapWidths");
			Global.NativeFieldInfoPtr_mapHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "mapHeights");
			Global.NativeFieldInfoPtr_thisIsZoo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "thisIsZoo");
			Global.NativeFieldInfoPtr_inSideBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "inSideBreak");
			Global.NativeFieldInfoPtr_baselineIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "baselineIntensity");
			Global.NativeFieldInfoPtr_smoothBaselineIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "smoothBaselineIntensity");
			Global.NativeFieldInfoPtr_bonusIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global>.NativeClassPtr, "bonusIntensity");
			Global.NativeMethodInfoPtr_Get_Public_Static_Global_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665505);
			Global.NativeMethodInfoPtr_GetParalaxForFloor_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665506);
			Global.NativeMethodInfoPtr_SetPostProfile_Public_Void_PostProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665507);
			Global.NativeMethodInfoPtr_StartMusic_Public_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665508);
			Global.NativeMethodInfoPtr_StartAltMusic_Public_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665509);
			Global.NativeMethodInfoPtr_SwapInAltMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665510);
			Global.NativeMethodInfoPtr_SwapOutAltMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665511);
			Global.NativeMethodInfoPtr_FadeUpAfterIntro_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665512);
			Global.NativeMethodInfoPtr_FadeOutBeforeIntro_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665513);
			Global.NativeMethodInfoPtr_GetSamplerPatchForLevel_Public_LevelSamplerPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665514);
			Global.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665515);
			Global.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665516);
			Global.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665517);
			Global.NativeMethodInfoPtr_ClearRun_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665518);
			Global.NativeMethodInfoPtr_ReloadLevel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665519);
			Global.NativeMethodInfoPtr_LoadNextLevel_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665520);
			Global.NativeMethodInfoPtr_NoPacifist_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665521);
			Global.NativeMethodInfoPtr_TookDamage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665522);
			Global.NativeMethodInfoPtr_LoadNextLevelCo_Private_IEnumerator_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665523);
			Global.NativeMethodInfoPtr_IntensityEvent_Public_Void_IntensityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665524);
			Global.NativeMethodInfoPtr_IntroIntensity_Public_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665525);
			Global.NativeMethodInfoPtr_IntensityDeal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665526);
			Global.NativeMethodInfoPtr_RunFixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665527);
			Global.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665528);
			Global.NativeMethodInfoPtr_PlayEndTrailerSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665529);
			Global.NativeMethodInfoPtr_KickBackToMenu_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665530);
			Global.NativeMethodInfoPtr_DoTrailerThang_Private_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665531);
			Global.NativeMethodInfoPtr_SwitchVignette_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665532);
			Global.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665533);
			Global.NativeMethodInfoPtr_ShowTitle_Public_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665534);
			Global.NativeMethodInfoPtr_EmptyThatFuckingGarbageBin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665535);
			Global.NativeMethodInfoPtr_IsZoo_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665536);
			Global.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global>.NativeClassPtr, 100665537);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00080A34 File Offset: 0x0007EC34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 61688, RefRangeEnd = 61692, XrefRangeStart = 61663, XrefRangeEnd = 61688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Global Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_Get_Public_Static_Global_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Global>(intPtr3) : null;
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00080A68 File Offset: 0x0007EC68
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 61695, RefRangeEnd = 61701, XrefRangeStart = 61692, XrefRangeEnd = 61695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetParalaxForFloor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_GetParalaxForFloor_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00080AA4 File Offset: 0x0007ECA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61704, RefRangeEnd = 61705, XrefRangeStart = 61701, XrefRangeEnd = 61704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPostProfile(Global.PostProfile i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_SetPostProfile_Public_Void_PostProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00080AE4 File Offset: 0x0007ECE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 61710, RefRangeEnd = 61714, XrefRangeStart = 61705, XrefRangeEnd = 61710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartMusic(bool halfSpeed = false, bool forceMin = false, bool wasKilled = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref halfSpeed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wasKilled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_StartMusic_Public_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00080B40 File Offset: 0x0007ED40
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 61719, RefRangeEnd = 61726, XrefRangeStart = 61714, XrefRangeEnd = 61719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAltMusic(bool halfSpeed = false, bool forceMin = false, bool wasKilled = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref halfSpeed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wasKilled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_StartAltMusic_Public_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00080B9C File Offset: 0x0007ED9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61730, RefRangeEnd = 61731, XrefRangeStart = 61726, XrefRangeEnd = 61730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwapInAltMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_SwapInAltMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00080BD0 File Offset: 0x0007EDD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 61735, RefRangeEnd = 61737, XrefRangeStart = 61731, XrefRangeEnd = 61735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwapOutAltMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_SwapOutAltMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00080C04 File Offset: 0x0007EE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61737, XrefRangeEnd = 61747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeUpAfterIntro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_FadeUpAfterIntro_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00080C38 File Offset: 0x0007EE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61747, XrefRangeEnd = 61752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeOutBeforeIntro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_FadeOutBeforeIntro_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00080C6C File Offset: 0x0007EE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61752, XrefRangeEnd = 61754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicSystem.LevelSamplerPatch GetSamplerPatchForLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_GetSamplerPatchForLevel_Public_LevelSamplerPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00080CA8 File Offset: 0x0007EEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61754, XrefRangeEnd = 62022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00080CDC File Offset: 0x0007EEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62022, XrefRangeEnd = 62037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00080D10 File Offset: 0x0007EF10
		[CallerCount(0)]
		public unsafe void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00080D44 File Offset: 0x0007EF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62037, XrefRangeEnd = 62062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRun()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_ClearRun_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00080D78 File Offset: 0x0007EF78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 62150, RefRangeEnd = 62152, XrefRangeStart = 62062, XrefRangeEnd = 62150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_ReloadLevel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x00080DAC File Offset: 0x0007EFAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 62237, RefRangeEnd = 62239, XrefRangeStart = 62152, XrefRangeEnd = 62237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadNextLevel(GameObject _exitObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_exitObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_LoadNextLevel_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00080DF0 File Offset: 0x0007EFF0
		[CallerCount(0)]
		public unsafe void NoPacifist()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_NoPacifist_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00080E24 File Offset: 0x0007F024
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 62257, RefRangeEnd = 62259, XrefRangeStart = 62239, XrefRangeEnd = 62257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TookDamage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_TookDamage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00080E58 File Offset: 0x0007F058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62259, XrefRangeEnd = 62262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadNextLevelCo(GameObject _exitObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_exitObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_LoadNextLevelCo_Private_IEnumerator_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00080EA8 File Offset: 0x0007F0A8
		[CallerCount(0)]
		public unsafe void IntensityEvent(Global.IntensityType eventType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_IntensityEvent_Public_Void_IntensityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00080EE8 File Offset: 0x0007F0E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 62265, RefRangeEnd = 62270, XrefRangeStart = 62262, XrefRangeEnd = 62265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator IntroIntensity(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_IntroIntensity_Public_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00080F34 File Offset: 0x0007F134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62341, RefRangeEnd = 62342, XrefRangeStart = 62270, XrefRangeEnd = 62341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntensityDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_IntensityDeal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00080F68 File Offset: 0x0007F168
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 62347, RefRangeEnd = 62350, XrefRangeStart = 62342, XrefRangeEnd = 62347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_RunFixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00080F9C File Offset: 0x0007F19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62350, XrefRangeEnd = 62430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00080FD0 File Offset: 0x0007F1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62430, XrefRangeEnd = 62440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayEndTrailerSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_PlayEndTrailerSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00081004 File Offset: 0x0007F204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62440, XrefRangeEnd = 62443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator KickBackToMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_KickBackToMenu_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00081044 File Offset: 0x0007F244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62443, XrefRangeEnd = 62446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoTrailerThang(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_DoTrailerThang_Private_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00081090 File Offset: 0x0007F290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62446, XrefRangeEnd = 62499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchVignette(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_SwitchVignette_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x000810D0 File Offset: 0x0007F2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62499, XrefRangeEnd = 62503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00081104 File Offset: 0x0007F304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62506, RefRangeEnd = 62507, XrefRangeStart = 62503, XrefRangeEnd = 62506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowTitle(int titNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref titNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_ShowTitle_Public_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x00081150 File Offset: 0x0007F350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62527, RefRangeEnd = 62528, XrefRangeStart = 62507, XrefRangeEnd = 62527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmptyThatFuckingGarbageBin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_EmptyThatFuckingGarbageBin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x00081184 File Offset: 0x0007F384
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 62530, RefRangeEnd = 62532, XrefRangeStart = 62528, XrefRangeEnd = 62530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsZoo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr_IsZoo_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x000811C0 File Offset: 0x0007F3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62532, XrefRangeEnd = 62549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Global()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Global>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x00012A09 File Offset: 0x00010C09
		public Global(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x000811FC File Offset: 0x0007F3FC
		// (set) Token: 0x06001AB4 RID: 6836 RVA: 0x00012A12 File Offset: 0x00010C12
		public unsafe static Global me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Global.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Global>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Global.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x00081224 File Offset: 0x0007F424
		// (set) Token: 0x06001AB6 RID: 6838 RVA: 0x00012A24 File Offset: 0x00010C24
		public unsafe GameObject player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x00081254 File Offset: 0x0007F454
		// (set) Token: 0x06001AB8 RID: 6840 RVA: 0x00012A43 File Offset: 0x00010C43
		public unsafe Transform playerTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_playerTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_playerTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x00081284 File Offset: 0x0007F484
		// (set) Token: 0x06001ABA RID: 6842 RVA: 0x00012A62 File Offset: 0x00010C62
		public unsafe PlayerState playerState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_playerState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_playerState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001ABB RID: 6843 RVA: 0x000812B4 File Offset: 0x0007F4B4
		// (set) Token: 0x06001ABC RID: 6844 RVA: 0x00012A81 File Offset: 0x00010C81
		public unsafe GameObject manager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_manager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_manager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x000812E4 File Offset: 0x0007F4E4
		// (set) Token: 0x06001ABE RID: 6846 RVA: 0x00012AA0 File Offset: 0x00010CA0
		public unsafe RumbleShake rumbler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_rumbler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RumbleShake>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_rumbler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x00081314 File Offset: 0x0007F514
		// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x00012ABF File Offset: 0x00010CBF
		public unsafe CamControl camControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_camControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CamControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_camControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x00081344 File Offset: 0x0007F544
		// (set) Token: 0x06001AC2 RID: 6850 RVA: 0x00012ADE File Offset: 0x00010CDE
		public unsafe SearchGrid searchGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_searchGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchGrid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_searchGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x00081374 File Offset: 0x0007F574
		// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x00012AFD File Offset: 0x00010CFD
		public unsafe PathFinding pathFinding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_pathFinding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathFinding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_pathFinding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x000813A4 File Offset: 0x0007F5A4
		// (set) Token: 0x06001AC6 RID: 6854 RVA: 0x00012B1C File Offset: 0x00010D1C
		public unsafe ShadowLayerer shadowLayerer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_shadowLayerer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShadowLayerer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_shadowLayerer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x000813D4 File Offset: 0x0007F5D4
		// (set) Token: 0x06001AC8 RID: 6856 RVA: 0x00012B3B File Offset: 0x00010D3B
		public unsafe bool mac
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_mac);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_mac)) = value;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x000813FC File Offset: 0x0007F5FC
		// (set) Token: 0x06001ACA RID: 6858 RVA: 0x00012B56 File Offset: 0x00010D56
		public unsafe float guardIdleSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardIdleSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardIdleSpd)) = value;
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x00081424 File Offset: 0x0007F624
		// (set) Token: 0x06001ACC RID: 6860 RVA: 0x00012B71 File Offset: 0x00010D71
		public unsafe float guardSearchSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardSearchSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardSearchSpd)) = value;
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x0008144C File Offset: 0x0007F64C
		// (set) Token: 0x06001ACE RID: 6862 RVA: 0x00012B8C File Offset: 0x00010D8C
		public unsafe float guardChaseSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardChaseSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardChaseSpd)) = value;
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x00081474 File Offset: 0x0007F674
		// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x00012BA7 File Offset: 0x00010DA7
		public unsafe float guardStalkSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardStalkSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardStalkSpd)) = value;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x0008149C File Offset: 0x0007F69C
		// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x00012BC2 File Offset: 0x00010DC2
		public unsafe float guardAttackSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardAttackSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardAttackSpd)) = value;
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x000814C4 File Offset: 0x0007F6C4
		// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x00012BDD File Offset: 0x00010DDD
		public unsafe float fatIdleSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_fatIdleSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_fatIdleSpd)) = value;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x000814EC File Offset: 0x0007F6EC
		// (set) Token: 0x06001AD6 RID: 6870 RVA: 0x00012BF8 File Offset: 0x00010DF8
		public unsafe float fatSearchSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_fatSearchSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_fatSearchSpd)) = value;
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x00081514 File Offset: 0x0007F714
		// (set) Token: 0x06001AD8 RID: 6872 RVA: 0x00012C13 File Offset: 0x00010E13
		public unsafe float fatChaseSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_fatChaseSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_fatChaseSpd)) = value;
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x0008153C File Offset: 0x0007F73C
		// (set) Token: 0x06001ADA RID: 6874 RVA: 0x00012C2E File Offset: 0x00010E2E
		public unsafe float fatStalkSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_fatStalkSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_fatStalkSpd)) = value;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x00081564 File Offset: 0x0007F764
		// (set) Token: 0x06001ADC RID: 6876 RVA: 0x00012C49 File Offset: 0x00010E49
		public unsafe float fatAttackSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_fatAttackSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_fatAttackSpd)) = value;
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x0008158C File Offset: 0x0007F78C
		// (set) Token: 0x06001ADE RID: 6878 RVA: 0x00012C64 File Offset: 0x00010E64
		public unsafe int level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x000815B4 File Offset: 0x0007F7B4
		// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x00012C7F File Offset: 0x00010E7F
		public unsafe bool uncaged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_uncaged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_uncaged)) = value;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x000815DC File Offset: 0x0007F7DC
		// (set) Token: 0x06001AE2 RID: 6882 RVA: 0x00012C9A File Offset: 0x00010E9A
		public unsafe bool tileBuilding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_tileBuilding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_tileBuilding)) = value;
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x00081604 File Offset: 0x0007F804
		// (set) Token: 0x06001AE4 RID: 6884 RVA: 0x00012CB5 File Offset: 0x00010EB5
		public unsafe bool free
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_free);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_free)) = value;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x0008162C File Offset: 0x0007F82C
		// (set) Token: 0x06001AE6 RID: 6886 RVA: 0x00012CD0 File Offset: 0x00010ED0
		public unsafe bool apeLit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_apeLit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_apeLit)) = value;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x00081654 File Offset: 0x0007F854
		// (set) Token: 0x06001AE8 RID: 6888 RVA: 0x00012CEB File Offset: 0x00010EEB
		public unsafe int apeLitTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_apeLitTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_apeLitTimer)) = value;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x0008167C File Offset: 0x0007F87C
		// (set) Token: 0x06001AEA RID: 6890 RVA: 0x00012D06 File Offset: 0x00010F06
		public unsafe bool stealthLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_stealthLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_stealthLevel)) = value;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x000816A4 File Offset: 0x0007F8A4
		// (set) Token: 0x06001AEC RID: 6892 RVA: 0x00012D21 File Offset: 0x00010F21
		public unsafe GameObject leaderboards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_leaderboards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_leaderboards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x000816D4 File Offset: 0x0007F8D4
		// (set) Token: 0x06001AEE RID: 6894 RVA: 0x00012D40 File Offset: 0x00010F40
		public unsafe HealthMaster healthMaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_healthMaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HealthMaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_healthMaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001AEF RID: 6895 RVA: 0x00081704 File Offset: 0x0007F904
		// (set) Token: 0x06001AF0 RID: 6896 RVA: 0x00012D5F File Offset: 0x00010F5F
		public unsafe Menu menu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_menu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Menu>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_menu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x00081734 File Offset: 0x0007F934
		// (set) Token: 0x06001AF2 RID: 6898 RVA: 0x00012D7E File Offset: 0x00010F7E
		public unsafe int mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x0008175C File Offset: 0x0007F95C
		// (set) Token: 0x06001AF4 RID: 6900 RVA: 0x00012D99 File Offset: 0x00010F99
		public unsafe float glassBreakTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_glassBreakTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_glassBreakTime)) = value;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x00081784 File Offset: 0x0007F984
		// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x00012DB4 File Offset: 0x00010FB4
		public unsafe int parTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_parTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_parTime)) = value;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x000817AC File Offset: 0x0007F9AC
		// (set) Token: 0x06001AF8 RID: 6904 RVA: 0x00012DCF File Offset: 0x00010FCF
		public unsafe int guardsKilled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardsKilled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardsKilled)) = value;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x000817D4 File Offset: 0x0007F9D4
		// (set) Token: 0x06001AFA RID: 6906 RVA: 0x00012DEA File Offset: 0x00010FEA
		public unsafe List<MapGenerator.GuardType> elevatorGuards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_elevatorGuards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MapGenerator.GuardType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_elevatorGuards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x00081804 File Offset: 0x0007FA04
		// (set) Token: 0x06001AFC RID: 6908 RVA: 0x00012E09 File Offset: 0x00011009
		public unsafe bool noElevators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_noElevators);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_noElevators)) = value;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x0008182C File Offset: 0x0007FA2C
		// (set) Token: 0x06001AFE RID: 6910 RVA: 0x00012E24 File Offset: 0x00011024
		public unsafe bool killerAssigned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_killerAssigned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_killerAssigned)) = value;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x00081854 File Offset: 0x0007FA54
		// (set) Token: 0x06001B00 RID: 6912 RVA: 0x00012E3F File Offset: 0x0001103F
		public unsafe bool intro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_intro);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_intro)) = value;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x0008187C File Offset: 0x0007FA7C
		// (set) Token: 0x06001B02 RID: 6914 RVA: 0x00012E5A File Offset: 0x0001105A
		public unsafe bool newGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_newGame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_newGame)) = value;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x000818A4 File Offset: 0x0007FAA4
		// (set) Token: 0x06001B04 RID: 6916 RVA: 0x00012E75 File Offset: 0x00011075
		public unsafe bool trailer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_trailer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_trailer)) = value;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x000818CC File Offset: 0x0007FACC
		// (set) Token: 0x06001B06 RID: 6918 RVA: 0x00012E90 File Offset: 0x00011090
		public unsafe Il2CppReferenceArray<GameObject> titles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_titles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_titles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x000818FC File Offset: 0x0007FAFC
		// (set) Token: 0x06001B08 RID: 6920 RVA: 0x00012EAF File Offset: 0x000110AF
		public unsafe int shownTitles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_shownTitles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_shownTitles)) = value;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x00081924 File Offset: 0x0007FB24
		// (set) Token: 0x06001B0A RID: 6922 RVA: 0x00012ECA File Offset: 0x000110CA
		public unsafe bool endOfAct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_endOfAct);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_endOfAct)) = value;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x0008194C File Offset: 0x0007FB4C
		// (set) Token: 0x06001B0C RID: 6924 RVA: 0x00012EE5 File Offset: 0x000110E5
		public unsafe float camMaxX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_camMaxX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_camMaxX)) = value;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x00081974 File Offset: 0x0007FB74
		// (set) Token: 0x06001B0E RID: 6926 RVA: 0x00012F00 File Offset: 0x00011100
		public unsafe Il2CppReferenceArray<Material> guardMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x000819A4 File Offset: 0x0007FBA4
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x00012F1F File Offset: 0x0001111F
		public unsafe Il2CppReferenceArray<Material> bloodyGuardMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_bloodyGuardMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_bloodyGuardMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001B11 RID: 6929 RVA: 0x000819D4 File Offset: 0x0007FBD4
		// (set) Token: 0x06001B12 RID: 6930 RVA: 0x00012F3E File Offset: 0x0001113E
		public unsafe Il2CppReferenceArray<Material> killerGuardMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_killerGuardMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_killerGuardMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001B13 RID: 6931 RVA: 0x00081A04 File Offset: 0x0007FC04
		// (set) Token: 0x06001B14 RID: 6932 RVA: 0x00012F5D File Offset: 0x0001115D
		public unsafe List<GameObject> trailerGarbageBin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_trailerGarbageBin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_trailerGarbageBin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x00081A34 File Offset: 0x0007FC34
		// (set) Token: 0x06001B16 RID: 6934 RVA: 0x00012F7C File Offset: 0x0001117C
		public unsafe int trailerGuardsKilled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_trailerGuardsKilled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_trailerGuardsKilled)) = value;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x00081A5C File Offset: 0x0007FC5C
		// (set) Token: 0x06001B18 RID: 6936 RVA: 0x00012F97 File Offset: 0x00011197
		public unsafe AudioMixerSnapshot titleSnapShot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_titleSnapShot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_titleSnapShot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x00081A8C File Offset: 0x0007FC8C
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x00012FB6 File Offset: 0x000111B6
		public unsafe AudioMixerSnapshot normalSnapShot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_normalSnapShot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_normalSnapShot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x00081ABC File Offset: 0x0007FCBC
		// (set) Token: 0x06001B1C RID: 6940 RVA: 0x00012FD5 File Offset: 0x000111D5
		public unsafe Il2CppReferenceArray<GameObject> trailerVignettes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_trailerVignettes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_trailerVignettes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x00081AEC File Offset: 0x0007FCEC
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x00012FF4 File Offset: 0x000111F4
		public unsafe Vector2 playerStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_playerStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_playerStartPos)) = value;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x00081B14 File Offset: 0x0007FD14
		// (set) Token: 0x06001B20 RID: 6944 RVA: 0x0001300F File Offset: 0x0001120F
		public unsafe float timeSinceLastKill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_timeSinceLastKill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_timeSinceLastKill)) = value;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x00081B3C File Offset: 0x0007FD3C
		// (set) Token: 0x06001B22 RID: 6946 RVA: 0x0001302A File Offset: 0x0001122A
		public unsafe int guardsOnScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardsOnScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardsOnScreen)) = value;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x00081B64 File Offset: 0x0007FD64
		// (set) Token: 0x06001B24 RID: 6948 RVA: 0x00013045 File Offset: 0x00011245
		public unsafe bool titling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_titling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_titling)) = value;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x00081B8C File Offset: 0x0007FD8C
		// (set) Token: 0x06001B26 RID: 6950 RVA: 0x00013060 File Offset: 0x00011260
		public unsafe bool introing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_introing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_introing)) = value;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x00081BB4 File Offset: 0x0007FDB4
		// (set) Token: 0x06001B28 RID: 6952 RVA: 0x0001307B File Offset: 0x0001127B
		public unsafe RoomState roomState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_roomState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoomState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_roomState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x00081BE4 File Offset: 0x0007FDE4
		// (set) Token: 0x06001B2A RID: 6954 RVA: 0x0001309A File Offset: 0x0001129A
		public unsafe bool trailerPlayerDied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_trailerPlayerDied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_trailerPlayerDied)) = value;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x00081C0C File Offset: 0x0007FE0C
		// (set) Token: 0x06001B2C RID: 6956 RVA: 0x000130B5 File Offset: 0x000112B5
		public unsafe int curVignette
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_curVignette);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_curVignette)) = value;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x00081C34 File Offset: 0x0007FE34
		// (set) Token: 0x06001B2E RID: 6958 RVA: 0x000130D0 File Offset: 0x000112D0
		public unsafe bool doingTrailerThang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_doingTrailerThang);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_doingTrailerThang)) = value;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x00081C5C File Offset: 0x0007FE5C
		// (set) Token: 0x06001B30 RID: 6960 RVA: 0x000130EB File Offset: 0x000112EB
		public unsafe bool rumble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_rumble);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_rumble)) = value;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x00081C84 File Offset: 0x0007FE84
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x00013106 File Offset: 0x00011306
		public unsafe int framNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_framNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_framNum)) = value;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x00081CAC File Offset: 0x0007FEAC
		// (set) Token: 0x06001B34 RID: 6964 RVA: 0x00013121 File Offset: 0x00011321
		public unsafe PlayerMovement playerMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_playerMovement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerMovement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_playerMovement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x00081CDC File Offset: 0x0007FEDC
		// (set) Token: 0x06001B36 RID: 6966 RVA: 0x00013140 File Offset: 0x00011340
		public unsafe AudioMixer audioMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_audioMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_audioMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x00081D0C File Offset: 0x0007FF0C
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x0001315F File Offset: 0x0001135F
		public unsafe bool gonnaEarnCheevo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_gonnaEarnCheevo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_gonnaEarnCheevo)) = value;
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x00081D34 File Offset: 0x0007FF34
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x0001317A File Offset: 0x0001137A
		public unsafe Vector2 shadowOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_shadowOrigin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_shadowOrigin)) = value;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x00081D5C File Offset: 0x0007FF5C
		// (set) Token: 0x06001B3C RID: 6972 RVA: 0x00013195 File Offset: 0x00011395
		public unsafe Vector3 shadowOriginV3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_shadowOriginV3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_shadowOriginV3)) = value;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001B3D RID: 6973 RVA: 0x00081D84 File Offset: 0x0007FF84
		// (set) Token: 0x06001B3E RID: 6974 RVA: 0x000131B0 File Offset: 0x000113B0
		public unsafe MapGenerator mapGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_mapGenerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MapGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_mapGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x00081DB4 File Offset: 0x0007FFB4
		// (set) Token: 0x06001B40 RID: 6976 RVA: 0x000131CF File Offset: 0x000113CF
		public unsafe Level curLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_curLevel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Level>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_curLevel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x00081DE4 File Offset: 0x0007FFE4
		// (set) Token: 0x06001B42 RID: 6978 RVA: 0x000131EE File Offset: 0x000113EE
		public unsafe Level diedOnLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_diedOnLevel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Level>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_diedOnLevel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001B43 RID: 6979 RVA: 0x00081E14 File Offset: 0x00080014
		// (set) Token: 0x06001B44 RID: 6980 RVA: 0x0001320D File Offset: 0x0001140D
		public unsafe List<Stairs> stairList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_stairList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Stairs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_stairList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x00081E44 File Offset: 0x00080044
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x0001322C File Offset: 0x0001142C
		public unsafe int curFloor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_curFloor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_curFloor)) = value;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x00081E6C File Offset: 0x0008006C
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x00013247 File Offset: 0x00011447
		public unsafe List<Transform> sniperList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_sniperList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_sniperList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x00081E9C File Offset: 0x0008009C
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x00013266 File Offset: 0x00011466
		public unsafe bool shadowOriginOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_shadowOriginOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_shadowOriginOverride)) = value;
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x00081EC4 File Offset: 0x000800C4
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x00013281 File Offset: 0x00011481
		public unsafe Il2CppReferenceArray<Mesh> treeMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_treeMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Mesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_treeMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x00081EF4 File Offset: 0x000800F4
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x000132A0 File Offset: 0x000114A0
		public unsafe Il2CppReferenceArray<Mesh> officePlantMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_officePlantMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Mesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_officePlantMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x00081F24 File Offset: 0x00080124
		// (set) Token: 0x06001B50 RID: 6992 RVA: 0x000132BF File Offset: 0x000114BF
		public unsafe Il2CppReferenceArray<Mesh> tropical1Meshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_tropical1Meshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Mesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_tropical1Meshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x00081F54 File Offset: 0x00080154
		// (set) Token: 0x06001B52 RID: 6994 RVA: 0x000132DE File Offset: 0x000114DE
		public unsafe Il2CppReferenceArray<Mesh> tropical2Meshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_tropical2Meshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Mesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_tropical2Meshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x00081F84 File Offset: 0x00080184
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x000132FD File Offset: 0x000114FD
		public unsafe Il2CppReferenceArray<RuntimeAnimatorController> guardAnimControllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardAnimControllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeAnimatorController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_guardAnimControllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x00081FB4 File Offset: 0x000801B4
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x0001331C File Offset: 0x0001151C
		public unsafe AnimationCurve paraCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_paraCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_paraCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x00081FE4 File Offset: 0x000801E4
		// (set) Token: 0x06001B58 RID: 7000 RVA: 0x0001333B File Offset: 0x0001153B
		public unsafe Il2CppReferenceArray<Material> containerMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_containerMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_containerMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x00082014 File Offset: 0x00080214
		// (set) Token: 0x06001B5A RID: 7002 RVA: 0x0001335A File Offset: 0x0001155A
		public unsafe Il2CppReferenceArray<Material> indoorContainerMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_indoorContainerMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_indoorContainerMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00082044 File Offset: 0x00080244
		// (set) Token: 0x06001B5C RID: 7004 RVA: 0x00013379 File Offset: 0x00011579
		public unsafe Il2CppReferenceArray<Material> outdoorContainerMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_outdoorContainerMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_outdoorContainerMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x00082074 File Offset: 0x00080274
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x00013398 File Offset: 0x00011598
		public unsafe Material deathContainerMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_deathContainerMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_deathContainerMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x000820A4 File Offset: 0x000802A4
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x000133B7 File Offset: 0x000115B7
		public unsafe bool justPaused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_justPaused);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_justPaused)) = value;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x000820CC File Offset: 0x000802CC
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x000133D2 File Offset: 0x000115D2
		public unsafe Transform transitionTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_transitionTile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_transitionTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x000820FC File Offset: 0x000802FC
		// (set) Token: 0x06001B64 RID: 7012 RVA: 0x000133F1 File Offset: 0x000115F1
		public unsafe Transform startTileTelepoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_startTileTelepoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_startTileTelepoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x0008212C File Offset: 0x0008032C
		// (set) Token: 0x06001B66 RID: 7014 RVA: 0x00013410 File Offset: 0x00011610
		public unsafe int lastCymbal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_lastCymbal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_lastCymbal)) = value;
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x00082154 File Offset: 0x00080354
		// (set) Token: 0x06001B68 RID: 7016 RVA: 0x0001342B File Offset: 0x0001162B
		public unsafe string PlayerTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_PlayerTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_PlayerTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x0008217C File Offset: 0x0008037C
		// (set) Token: 0x06001B6A RID: 7018 RVA: 0x0001344A File Offset: 0x0001164A
		public unsafe string EnemyTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_EnemyTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_EnemyTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x000821A4 File Offset: 0x000803A4
		// (set) Token: 0x06001B6C RID: 7020 RVA: 0x00013469 File Offset: 0x00011669
		public unsafe string PebbleMagnetTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_PebbleMagnetTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_PebbleMagnetTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x000821CC File Offset: 0x000803CC
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x00013488 File Offset: 0x00011688
		public unsafe WaitForFixedUpdate delayForFixedUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_delayForFixedUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForFixedUpdate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_delayForFixedUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x000821FC File Offset: 0x000803FC
		// (set) Token: 0x06001B70 RID: 7024 RVA: 0x000134A7 File Offset: 0x000116A7
		public unsafe WaitForSeconds delay1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_delay1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_delay1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x0008222C File Offset: 0x0008042C
		// (set) Token: 0x06001B72 RID: 7026 RVA: 0x000134C6 File Offset: 0x000116C6
		public unsafe WaitForSeconds delaypt1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_delaypt1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_delaypt1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x0008225C File Offset: 0x0008045C
		// (set) Token: 0x06001B74 RID: 7028 RVA: 0x000134E5 File Offset: 0x000116E5
		public unsafe Il2CppReferenceArray<TextMesh> arcadeModeTransitionTitles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_arcadeModeTransitionTitles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_arcadeModeTransitionTitles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x0008228C File Offset: 0x0008048C
		// (set) Token: 0x06001B76 RID: 7030 RVA: 0x00013504 File Offset: 0x00011704
		public unsafe bool swappedMusic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_swappedMusic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_swappedMusic)) = value;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x000822B4 File Offset: 0x000804B4
		// (set) Token: 0x06001B78 RID: 7032 RVA: 0x0001351F File Offset: 0x0001171F
		public unsafe bool isPacifist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_isPacifist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_isPacifist)) = value;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x000822DC File Offset: 0x000804DC
		// (set) Token: 0x06001B7A RID: 7034 RVA: 0x0001353A File Offset: 0x0001173A
		public unsafe bool isPerfect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_isPerfect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_isPerfect)) = value;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x00082304 File Offset: 0x00080504
		// (set) Token: 0x06001B7C RID: 7036 RVA: 0x00013555 File Offset: 0x00011755
		public unsafe bool weBlind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_weBlind);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_weBlind)) = value;
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x0008232C File Offset: 0x0008052C
		// (set) Token: 0x06001B7E RID: 7038 RVA: 0x00013570 File Offset: 0x00011770
		public unsafe ResonanceRoomPatch containerRoom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_containerRoom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResonanceRoomPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_containerRoom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x0008235C File Offset: 0x0008055C
		// (set) Token: 0x06001B80 RID: 7040 RVA: 0x0001358F File Offset: 0x0001178F
		public unsafe ReverbPatch containerReverb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_containerReverb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReverbPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_containerReverb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x0008238C File Offset: 0x0008058C
		// (set) Token: 0x06001B82 RID: 7042 RVA: 0x000135AE File Offset: 0x000117AE
		public unsafe SECTR_AudioAmbience containerAmbiance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_containerAmbiance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioAmbience>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_containerAmbiance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x000823BC File Offset: 0x000805BC
		// (set) Token: 0x06001B84 RID: 7044 RVA: 0x000135CD File Offset: 0x000117CD
		public unsafe float intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_intensity)) = value;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001B85 RID: 7045 RVA: 0x000823E4 File Offset: 0x000805E4
		// (set) Token: 0x06001B86 RID: 7046 RVA: 0x000135E8 File Offset: 0x000117E8
		public unsafe float maxIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_maxIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_maxIntensity)) = value;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x0008240C File Offset: 0x0008060C
		// (set) Token: 0x06001B88 RID: 7048 RVA: 0x00013603 File Offset: 0x00011803
		public unsafe float normalizedIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_normalizedIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_normalizedIntensity)) = value;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x00082434 File Offset: 0x00080634
		// (set) Token: 0x06001B8A RID: 7050 RVA: 0x0001361E File Offset: 0x0001181E
		public unsafe bool debugIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_debugIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_debugIntensity)) = value;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x0008245C File Offset: 0x0008065C
		// (set) Token: 0x06001B8C RID: 7052 RVA: 0x00013639 File Offset: 0x00011839
		public unsafe TextMesh intensityDebugTxt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_intensityDebugTxt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_intensityDebugTxt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001B8D RID: 7053 RVA: 0x0008248C File Offset: 0x0008068C
		// (set) Token: 0x06001B8E RID: 7054 RVA: 0x00013658 File Offset: 0x00011858
		public unsafe float bonusDecay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_bonusDecay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_bonusDecay)) = value;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x000824B4 File Offset: 0x000806B4
		// (set) Token: 0x06001B90 RID: 7056 RVA: 0x00013673 File Offset: 0x00011873
		public unsafe float baselineSmooth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_baselineSmooth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_baselineSmooth)) = value;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x000824DC File Offset: 0x000806DC
		// (set) Token: 0x06001B92 RID: 7058 RVA: 0x0001368E File Offset: 0x0001188E
		public unsafe float bonusWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_bonusWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_bonusWeight)) = value;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x00082504 File Offset: 0x00080704
		// (set) Token: 0x06001B94 RID: 7060 RVA: 0x000136A9 File Offset: 0x000118A9
		public unsafe float baselineWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_baselineWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_baselineWeight)) = value;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001B95 RID: 7061 RVA: 0x0008252C File Offset: 0x0008072C
		// (set) Token: 0x06001B96 RID: 7062 RVA: 0x000136C4 File Offset: 0x000118C4
		public unsafe float maxIntensityFloor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_maxIntensityFloor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_maxIntensityFloor)) = value;
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x00082554 File Offset: 0x00080754
		// (set) Token: 0x06001B98 RID: 7064 RVA: 0x000136DF File Offset: 0x000118DF
		public unsafe float floorAdjustmentSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_floorAdjustmentSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_floorAdjustmentSpeed)) = value;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x0008257C File Offset: 0x0008077C
		// (set) Token: 0x06001B9A RID: 7066 RVA: 0x000136FA File Offset: 0x000118FA
		public unsafe float maxDecay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_maxDecay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_maxDecay)) = value;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x000825A4 File Offset: 0x000807A4
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x00013715 File Offset: 0x00011915
		public unsafe bool disableDynamicIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_disableDynamicIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_disableDynamicIntensity)) = value;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x000825CC File Offset: 0x000807CC
		// (set) Token: 0x06001B9E RID: 7070 RVA: 0x00013730 File Offset: 0x00011930
		public unsafe static float FixedDeltaTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Global.NativeFieldInfoPtr_FixedDeltaTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Global.NativeFieldInfoPtr_FixedDeltaTime, (void*)(&value));
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x000825E8 File Offset: 0x000807E8
		// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x0001373E File Offset: 0x0001193E
		public unsafe PostProcessVolume postVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_postVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_postVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x00082618 File Offset: 0x00080818
		// (set) Token: 0x06001BA2 RID: 7074 RVA: 0x0001375D File Offset: 0x0001195D
		public unsafe PostProcessProfile normalProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_normalProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_normalProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x00082648 File Offset: 0x00080848
		// (set) Token: 0x06001BA4 RID: 7076 RVA: 0x0001377C File Offset: 0x0001197C
		public unsafe PostProcessProfile splodeProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_splodeProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_splodeProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x00082678 File Offset: 0x00080878
		// (set) Token: 0x06001BA6 RID: 7078 RVA: 0x0001379B File Offset: 0x0001199B
		public unsafe PostProcessProfile blurProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_blurProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_blurProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x000826A8 File Offset: 0x000808A8
		// (set) Token: 0x06001BA8 RID: 7080 RVA: 0x000137BA File Offset: 0x000119BA
		public unsafe PostProcessProfile normalProfileSwitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_normalProfileSwitch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_normalProfileSwitch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x000826D8 File Offset: 0x000808D8
		// (set) Token: 0x06001BAA RID: 7082 RVA: 0x000137D9 File Offset: 0x000119D9
		public unsafe PostProcessProfile splodeProfileSwitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_splodeProfileSwitch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_splodeProfileSwitch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001BAB RID: 7083 RVA: 0x00082708 File Offset: 0x00080908
		// (set) Token: 0x06001BAC RID: 7084 RVA: 0x000137F8 File Offset: 0x000119F8
		public unsafe PostProcessProfile blurProfileSwitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_blurProfileSwitch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_blurProfileSwitch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001BAD RID: 7085 RVA: 0x00082738 File Offset: 0x00080938
		// (set) Token: 0x06001BAE RID: 7086 RVA: 0x00013817 File Offset: 0x00011A17
		public unsafe PostProcessProfile bwProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_bwProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_bwProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x00082768 File Offset: 0x00080968
		// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x00013836 File Offset: 0x00011A36
		public unsafe int fixedNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_fixedNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_fixedNum)) = value;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x00082790 File Offset: 0x00080990
		// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x00013851 File Offset: 0x00011A51
		public unsafe float timeDebt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_timeDebt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_timeDebt)) = value;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x000827B8 File Offset: 0x000809B8
		// (set) Token: 0x06001BB4 RID: 7092 RVA: 0x0001386C File Offset: 0x00011A6C
		public unsafe Il2CppReferenceArray<List<Action>> fixedUpdates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_fixedUpdates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<Action>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_fixedUpdates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x000827E8 File Offset: 0x000809E8
		// (set) Token: 0x06001BB6 RID: 7094 RVA: 0x0001388B File Offset: 0x00011A8B
		public unsafe int ambInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_ambInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_ambInd)) = value;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x00082810 File Offset: 0x00080A10
		// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x000138A6 File Offset: 0x00011AA6
		public unsafe Level.FloorMaterial floorMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_floorMaterial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_floorMaterial)) = value;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x00082838 File Offset: 0x00080A38
		// (set) Token: 0x06001BBA RID: 7098 RVA: 0x000138C1 File Offset: 0x00011AC1
		public unsafe bool dontPause
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_dontPause);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_dontPause)) = value;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x00082860 File Offset: 0x00080A60
		// (set) Token: 0x06001BBC RID: 7100 RVA: 0x000138DC File Offset: 0x00011ADC
		public unsafe bool readyToStartMusic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_readyToStartMusic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_readyToStartMusic)) = value;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x00082888 File Offset: 0x00080A88
		// (set) Token: 0x06001BBE RID: 7102 RVA: 0x000138F7 File Offset: 0x00011AF7
		public unsafe int prevKills
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_prevKills);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_prevKills)) = value;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x000828B0 File Offset: 0x00080AB0
		// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x00013912 File Offset: 0x00011B12
		public unsafe GameObject exitObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_exitObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_exitObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x000828E0 File Offset: 0x00080AE0
		// (set) Token: 0x06001BC2 RID: 7106 RVA: 0x00013931 File Offset: 0x00011B31
		public unsafe Il2CppStructArray<int> mapWidths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_mapWidths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_mapWidths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x00082910 File Offset: 0x00080B10
		// (set) Token: 0x06001BC4 RID: 7108 RVA: 0x00013950 File Offset: 0x00011B50
		public unsafe Il2CppStructArray<int> mapHeights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_mapHeights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_mapHeights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x00082940 File Offset: 0x00080B40
		// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x0001396F File Offset: 0x00011B6F
		public unsafe bool thisIsZoo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_thisIsZoo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_thisIsZoo)) = value;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x00082968 File Offset: 0x00080B68
		// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x0001398A File Offset: 0x00011B8A
		public unsafe bool inSideBreak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_inSideBreak);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_inSideBreak)) = value;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x00082990 File Offset: 0x00080B90
		// (set) Token: 0x06001BCA RID: 7114 RVA: 0x000139A5 File Offset: 0x00011BA5
		public unsafe float baselineIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_baselineIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_baselineIntensity)) = value;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x000829B8 File Offset: 0x00080BB8
		// (set) Token: 0x06001BCC RID: 7116 RVA: 0x000139C0 File Offset: 0x00011BC0
		public unsafe float smoothBaselineIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_smoothBaselineIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_smoothBaselineIntensity)) = value;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x000829E0 File Offset: 0x00080BE0
		// (set) Token: 0x06001BCE RID: 7118 RVA: 0x000139DB File Offset: 0x00011BDB
		public unsafe float bonusIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_bonusIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global.NativeFieldInfoPtr_bonusIntensity)) = value;
			}
		}

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeFieldInfoPtr_playerTrans;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeFieldInfoPtr_playerState;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeFieldInfoPtr_manager;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeFieldInfoPtr_rumbler;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeFieldInfoPtr_camControl;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeFieldInfoPtr_searchGrid;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeFieldInfoPtr_pathFinding;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeFieldInfoPtr_shadowLayerer;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeFieldInfoPtr_mac;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeFieldInfoPtr_guardIdleSpd;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeFieldInfoPtr_guardSearchSpd;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeFieldInfoPtr_guardChaseSpd;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeFieldInfoPtr_guardStalkSpd;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeFieldInfoPtr_guardAttackSpd;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeFieldInfoPtr_fatIdleSpd;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeFieldInfoPtr_fatSearchSpd;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeFieldInfoPtr_fatChaseSpd;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeFieldInfoPtr_fatStalkSpd;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeFieldInfoPtr_fatAttackSpd;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeFieldInfoPtr_uncaged;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeFieldInfoPtr_tileBuilding;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeFieldInfoPtr_free;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeFieldInfoPtr_apeLit;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeFieldInfoPtr_apeLitTimer;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeFieldInfoPtr_stealthLevel;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeFieldInfoPtr_leaderboards;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeFieldInfoPtr_healthMaster;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeFieldInfoPtr_menu;

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeFieldInfoPtr_glassBreakTime;

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeFieldInfoPtr_parTime;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeFieldInfoPtr_guardsKilled;

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeFieldInfoPtr_elevatorGuards;

		// Token: 0x04001005 RID: 4101
		private static readonly IntPtr NativeFieldInfoPtr_noElevators;

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeFieldInfoPtr_killerAssigned;

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeFieldInfoPtr_intro;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeFieldInfoPtr_newGame;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeFieldInfoPtr_trailer;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeFieldInfoPtr_titles;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeFieldInfoPtr_shownTitles;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeFieldInfoPtr_endOfAct;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeFieldInfoPtr_camMaxX;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeFieldInfoPtr_guardMats;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeFieldInfoPtr_bloodyGuardMats;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeFieldInfoPtr_killerGuardMats;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeFieldInfoPtr_trailerGarbageBin;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeFieldInfoPtr_trailerGuardsKilled;

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeFieldInfoPtr_titleSnapShot;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeFieldInfoPtr_normalSnapShot;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeFieldInfoPtr_trailerVignettes;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeFieldInfoPtr_playerStartPos;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastKill;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeFieldInfoPtr_guardsOnScreen;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeFieldInfoPtr_titling;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeFieldInfoPtr_introing;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeFieldInfoPtr_roomState;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeFieldInfoPtr_trailerPlayerDied;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeFieldInfoPtr_curVignette;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeFieldInfoPtr_doingTrailerThang;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeFieldInfoPtr_rumble;

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeFieldInfoPtr_framNum;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeFieldInfoPtr_playerMovement;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeFieldInfoPtr_audioMixer;

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeFieldInfoPtr_gonnaEarnCheevo;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeFieldInfoPtr_shadowOrigin;

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeFieldInfoPtr_shadowOriginV3;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeFieldInfoPtr_mapGenerator;

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeFieldInfoPtr_curLevel;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeFieldInfoPtr_diedOnLevel;

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeFieldInfoPtr_stairList;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeFieldInfoPtr_curFloor;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeFieldInfoPtr_sniperList;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeFieldInfoPtr_shadowOriginOverride;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeFieldInfoPtr_treeMeshes;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeFieldInfoPtr_officePlantMeshes;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeFieldInfoPtr_tropical1Meshes;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeFieldInfoPtr_tropical2Meshes;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeFieldInfoPtr_guardAnimControllers;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeFieldInfoPtr_paraCurve;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeFieldInfoPtr_containerMats;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeFieldInfoPtr_indoorContainerMats;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeFieldInfoPtr_outdoorContainerMats;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeFieldInfoPtr_deathContainerMat;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeFieldInfoPtr_justPaused;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeFieldInfoPtr_transitionTile;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeFieldInfoPtr_startTileTelepoint;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeFieldInfoPtr_lastCymbal;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeFieldInfoPtr_PlayerTag;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeFieldInfoPtr_EnemyTag;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeFieldInfoPtr_PebbleMagnetTag;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeFieldInfoPtr_delayForFixedUpdate;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeFieldInfoPtr_delay1;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeFieldInfoPtr_delaypt1;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeFieldInfoPtr_arcadeModeTransitionTitles;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeFieldInfoPtr_swappedMusic;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeFieldInfoPtr_isPacifist;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeFieldInfoPtr_isPerfect;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeFieldInfoPtr_weBlind;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeFieldInfoPtr_containerRoom;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeFieldInfoPtr_containerReverb;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeFieldInfoPtr_containerAmbiance;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeFieldInfoPtr_maxIntensity;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeFieldInfoPtr_normalizedIntensity;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeFieldInfoPtr_debugIntensity;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeFieldInfoPtr_intensityDebugTxt;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeFieldInfoPtr_bonusDecay;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeFieldInfoPtr_baselineSmooth;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeFieldInfoPtr_bonusWeight;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeFieldInfoPtr_baselineWeight;

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeFieldInfoPtr_maxIntensityFloor;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeFieldInfoPtr_floorAdjustmentSpeed;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeFieldInfoPtr_maxDecay;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeFieldInfoPtr_disableDynamicIntensity;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeFieldInfoPtr_FixedDeltaTime;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeFieldInfoPtr_postVolume;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeFieldInfoPtr_normalProfile;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeFieldInfoPtr_splodeProfile;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeFieldInfoPtr_blurProfile;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeFieldInfoPtr_normalProfileSwitch;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeFieldInfoPtr_splodeProfileSwitch;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeFieldInfoPtr_blurProfileSwitch;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeFieldInfoPtr_bwProfile;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeFieldInfoPtr_fixedNum;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeFieldInfoPtr_timeDebt;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeFieldInfoPtr_fixedUpdates;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeFieldInfoPtr_ambInd;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeFieldInfoPtr_floorMaterial;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeFieldInfoPtr_dontPause;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeFieldInfoPtr_readyToStartMusic;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeFieldInfoPtr_prevKills;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeFieldInfoPtr_exitObj;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeFieldInfoPtr_mapWidths;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeFieldInfoPtr_mapHeights;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeFieldInfoPtr_thisIsZoo;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeFieldInfoPtr_inSideBreak;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeFieldInfoPtr_baselineIntensity;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeFieldInfoPtr_smoothBaselineIntensity;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeFieldInfoPtr_bonusIntensity;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Global_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr_GetParalaxForFloor_Public_Single_0;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_SetPostProfile_Public_Void_PostProfile_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_StartMusic_Public_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr_StartAltMusic_Public_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_SwapInAltMusic_Public_Void_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr_SwapOutAltMusic_Public_Void_0;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr_FadeUpAfterIntro_Public_Void_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_FadeOutBeforeIntro_Public_Void_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_GetSamplerPatchForLevel_Public_LevelSamplerPatch_0;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeMethodInfoPtr_ClearRun_Public_Void_0;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeMethodInfoPtr_ReloadLevel_Public_Void_0;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeMethodInfoPtr_LoadNextLevel_Public_Void_GameObject_0;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeMethodInfoPtr_NoPacifist_Public_Void_0;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeMethodInfoPtr_TookDamage_Public_Void_0;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeMethodInfoPtr_LoadNextLevelCo_Private_IEnumerator_GameObject_0;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr_IntensityEvent_Public_Void_IntensityType_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr_IntroIntensity_Public_IEnumerator_Single_0;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeMethodInfoPtr_IntensityDeal_Private_Void_0;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr_RunFixedUpdate_Public_Void_0;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeMethodInfoPtr_PlayEndTrailerSound_Public_Void_0;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeMethodInfoPtr_KickBackToMenu_Public_IEnumerator_0;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeMethodInfoPtr_DoTrailerThang_Private_IEnumerator_Int32_0;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeMethodInfoPtr_SwitchVignette_Public_Void_Int32_0;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeMethodInfoPtr_ShowTitle_Public_IEnumerator_Int32_0;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeMethodInfoPtr_EmptyThatFuckingGarbageBin_Public_Void_0;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeMethodInfoPtr_IsZoo_Public_Boolean_0;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002FE RID: 766
		[OriginalName("Assembly-CSharp.dll", "", "FixedUpdateType")]
		public enum FixedUpdateType
		{
			// Token: 0x040033EA RID: 13290
			global,
			// Token: 0x040033EB RID: 13291
			bearState,
			// Token: 0x040033EC RID: 13292
			def,
			// Token: 0x040033ED RID: 13293
			guardState,
			// Token: 0x040033EE RID: 13294
			guardGun,
			// Token: 0x040033EF RID: 13295
			guardCollision,
			// Token: 0x040033F0 RID: 13296
			playerState,
			// Token: 0x040033F1 RID: 13297
			playerMovement,
			// Token: 0x040033F2 RID: 13298
			playerHands,
			// Token: 0x040033F3 RID: 13299
			pathFollower,
			// Token: 0x040033F4 RID: 13300
			bunkerIntro,
			// Token: 0x040033F5 RID: 13301
			mover,
			// Token: 0x040033F6 RID: 13302
			grimeManager,
			// Token: 0x040033F7 RID: 13303
			count
		}

		// Token: 0x020002FF RID: 767
		[OriginalName("Assembly-CSharp.dll", "", "PostProfile")]
		public enum PostProfile
		{
			// Token: 0x040033F9 RID: 13305
			normal,
			// Token: 0x040033FA RID: 13306
			blurBloom,
			// Token: 0x040033FB RID: 13307
			blur,
			// Token: 0x040033FC RID: 13308
			bw
		}

		// Token: 0x02000300 RID: 768
		[OriginalName("Assembly-CSharp.dll", "", "IntensityType")]
		public enum IntensityType
		{
			// Token: 0x040033FE RID: 13310
			gunShot,
			// Token: 0x040033FF RID: 13311
			explosion,
			// Token: 0x04003400 RID: 13312
			guardAttacking,
			// Token: 0x04003401 RID: 13313
			guardGrabbed,
			// Token: 0x04003402 RID: 13314
			guardVisible,
			// Token: 0x04003403 RID: 13315
			playerMovement,
			// Token: 0x04003404 RID: 13316
			guardDeath,
			// Token: 0x04003405 RID: 13317
			fireVisible
		}

		// Token: 0x02000301 RID: 769
		[ObfuscatedName("Global+<LoadNextLevelCo>d__159")]
		public sealed class _LoadNextLevelCo_d__159 : global::Il2CppSystem.Object
		{
			// Token: 0x06004F2C RID: 20268 RVA: 0x00121CE0 File Offset: 0x0011FEE0
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadNextLevelCo_d__159()
			{
				Il2CppClassPointerStore<Global._LoadNextLevelCo_d__159>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Global>.NativeClassPtr, "<LoadNextLevelCo>d__159");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Global._LoadNextLevelCo_d__159>.NativeClassPtr);
				Global._LoadNextLevelCo_d__159.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._LoadNextLevelCo_d__159>.NativeClassPtr, "<>1__state");
				Global._LoadNextLevelCo_d__159.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._LoadNextLevelCo_d__159>.NativeClassPtr, "<>2__current");
				Global._LoadNextLevelCo_d__159.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._LoadNextLevelCo_d__159>.NativeClassPtr, "<>4__this");
				Global._LoadNextLevelCo_d__159.NativeFieldInfoPtr__newPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._LoadNextLevelCo_d__159>.NativeClassPtr, "<newPos>5__2");
				Global._LoadNextLevelCo_d__159.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._LoadNextLevelCo_d__159>.NativeClassPtr, 100665538);
				Global._LoadNextLevelCo_d__159.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._LoadNextLevelCo_d__159>.NativeClassPtr, 100665539);
				Global._LoadNextLevelCo_d__159.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._LoadNextLevelCo_d__159>.NativeClassPtr, 100665540);
				Global._LoadNextLevelCo_d__159.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._LoadNextLevelCo_d__159>.NativeClassPtr, 100665541);
				Global._LoadNextLevelCo_d__159.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._LoadNextLevelCo_d__159>.NativeClassPtr, 100665542);
				Global._LoadNextLevelCo_d__159.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._LoadNextLevelCo_d__159>.NativeClassPtr, 100665543);
			}

			// Token: 0x06004F2D RID: 20269 RVA: 0x00121DD4 File Offset: 0x0011FFD4
			[CallerCount(0)]
			public unsafe _LoadNextLevelCo_d__159(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Global._LoadNextLevelCo_d__159>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._LoadNextLevelCo_d__159.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F2E RID: 20270 RVA: 0x00121E1C File Offset: 0x0012001C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._LoadNextLevelCo_d__159.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F2F RID: 20271 RVA: 0x00121E50 File Offset: 0x00120050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61340, XrefRangeEnd = 61578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._LoadNextLevelCo_d__159.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CDE RID: 7390
			// (get) Token: 0x06004F30 RID: 20272 RVA: 0x00121E8C File Offset: 0x0012008C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._LoadNextLevelCo_d__159.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F31 RID: 20273 RVA: 0x00121ECC File Offset: 0x001200CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61578, XrefRangeEnd = 61583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._LoadNextLevelCo_d__159.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CDF RID: 7391
			// (get) Token: 0x06004F32 RID: 20274 RVA: 0x00121F00 File Offset: 0x00120100
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._LoadNextLevelCo_d__159.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F33 RID: 20275 RVA: 0x0002E577 File Offset: 0x0002C777
			public _LoadNextLevelCo_d__159(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CDA RID: 7386
			// (get) Token: 0x06004F34 RID: 20276 RVA: 0x00121F40 File Offset: 0x00120140
			// (set) Token: 0x06004F35 RID: 20277 RVA: 0x0002E580 File Offset: 0x0002C780
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._LoadNextLevelCo_d__159.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._LoadNextLevelCo_d__159.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CDB RID: 7387
			// (get) Token: 0x06004F36 RID: 20278 RVA: 0x00121F68 File Offset: 0x00120168
			// (set) Token: 0x06004F37 RID: 20279 RVA: 0x0002E59B File Offset: 0x0002C79B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._LoadNextLevelCo_d__159.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._LoadNextLevelCo_d__159.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CDC RID: 7388
			// (get) Token: 0x06004F38 RID: 20280 RVA: 0x00121F98 File Offset: 0x00120198
			// (set) Token: 0x06004F39 RID: 20281 RVA: 0x0002E5BA File Offset: 0x0002C7BA
			public unsafe Global __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._LoadNextLevelCo_d__159.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Global>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._LoadNextLevelCo_d__159.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CDD RID: 7389
			// (get) Token: 0x06004F3A RID: 20282 RVA: 0x00121FC8 File Offset: 0x001201C8
			// (set) Token: 0x06004F3B RID: 20283 RVA: 0x0002E5D9 File Offset: 0x0002C7D9
			public unsafe Vector3 _newPos_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._LoadNextLevelCo_d__159.NativeFieldInfoPtr__newPos_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._LoadNextLevelCo_d__159.NativeFieldInfoPtr__newPos_5__2)) = value;
				}
			}

			// Token: 0x04003406 RID: 13318
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003407 RID: 13319
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003408 RID: 13320
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003409 RID: 13321
			private static readonly IntPtr NativeFieldInfoPtr__newPos_5__2;

			// Token: 0x0400340A RID: 13322
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400340B RID: 13323
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400340C RID: 13324
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400340D RID: 13325
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400340E RID: 13326
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400340F RID: 13327
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000302 RID: 770
		[ObfuscatedName("Global+<IntroIntensity>d__165")]
		public sealed class _IntroIntensity_d__165 : global::Il2CppSystem.Object
		{
			// Token: 0x06004F3C RID: 20284 RVA: 0x00121FF0 File Offset: 0x001201F0
			// Note: this type is marked as 'beforefieldinit'.
			static _IntroIntensity_d__165()
			{
				Il2CppClassPointerStore<Global._IntroIntensity_d__165>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Global>.NativeClassPtr, "<IntroIntensity>d__165");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Global._IntroIntensity_d__165>.NativeClassPtr);
				Global._IntroIntensity_d__165.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._IntroIntensity_d__165>.NativeClassPtr, "<>1__state");
				Global._IntroIntensity_d__165.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._IntroIntensity_d__165>.NativeClassPtr, "<>2__current");
				Global._IntroIntensity_d__165.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._IntroIntensity_d__165>.NativeClassPtr, "<>4__this");
				Global._IntroIntensity_d__165.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._IntroIntensity_d__165>.NativeClassPtr, "time");
				Global._IntroIntensity_d__165.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._IntroIntensity_d__165>.NativeClassPtr, "<timer>5__2");
				Global._IntroIntensity_d__165.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._IntroIntensity_d__165>.NativeClassPtr, 100665544);
				Global._IntroIntensity_d__165.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._IntroIntensity_d__165>.NativeClassPtr, 100665545);
				Global._IntroIntensity_d__165.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._IntroIntensity_d__165>.NativeClassPtr, 100665546);
				Global._IntroIntensity_d__165.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._IntroIntensity_d__165>.NativeClassPtr, 100665547);
				Global._IntroIntensity_d__165.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._IntroIntensity_d__165>.NativeClassPtr, 100665548);
				Global._IntroIntensity_d__165.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._IntroIntensity_d__165>.NativeClassPtr, 100665549);
			}

			// Token: 0x06004F3D RID: 20285 RVA: 0x001220F8 File Offset: 0x001202F8
			[CallerCount(0)]
			public unsafe _IntroIntensity_d__165(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Global._IntroIntensity_d__165>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._IntroIntensity_d__165.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F3E RID: 20286 RVA: 0x00122140 File Offset: 0x00120340
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._IntroIntensity_d__165.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F3F RID: 20287 RVA: 0x00122174 File Offset: 0x00120374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61583, XrefRangeEnd = 61588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._IntroIntensity_d__165.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CE5 RID: 7397
			// (get) Token: 0x06004F40 RID: 20288 RVA: 0x001221B0 File Offset: 0x001203B0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._IntroIntensity_d__165.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F41 RID: 20289 RVA: 0x001221F0 File Offset: 0x001203F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61588, XrefRangeEnd = 61593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._IntroIntensity_d__165.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CE6 RID: 7398
			// (get) Token: 0x06004F42 RID: 20290 RVA: 0x00122224 File Offset: 0x00120424
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._IntroIntensity_d__165.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F43 RID: 20291 RVA: 0x0002E5F4 File Offset: 0x0002C7F4
			public _IntroIntensity_d__165(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CE0 RID: 7392
			// (get) Token: 0x06004F44 RID: 20292 RVA: 0x00122264 File Offset: 0x00120464
			// (set) Token: 0x06004F45 RID: 20293 RVA: 0x0002E5FD File Offset: 0x0002C7FD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._IntroIntensity_d__165.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._IntroIntensity_d__165.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CE1 RID: 7393
			// (get) Token: 0x06004F46 RID: 20294 RVA: 0x0012228C File Offset: 0x0012048C
			// (set) Token: 0x06004F47 RID: 20295 RVA: 0x0002E618 File Offset: 0x0002C818
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._IntroIntensity_d__165.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._IntroIntensity_d__165.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CE2 RID: 7394
			// (get) Token: 0x06004F48 RID: 20296 RVA: 0x001222BC File Offset: 0x001204BC
			// (set) Token: 0x06004F49 RID: 20297 RVA: 0x0002E637 File Offset: 0x0002C837
			public unsafe Global __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._IntroIntensity_d__165.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Global>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._IntroIntensity_d__165.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CE3 RID: 7395
			// (get) Token: 0x06004F4A RID: 20298 RVA: 0x001222EC File Offset: 0x001204EC
			// (set) Token: 0x06004F4B RID: 20299 RVA: 0x0002E656 File Offset: 0x0002C856
			public unsafe float time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._IntroIntensity_d__165.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._IntroIntensity_d__165.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x17001CE4 RID: 7396
			// (get) Token: 0x06004F4C RID: 20300 RVA: 0x00122314 File Offset: 0x00120514
			// (set) Token: 0x06004F4D RID: 20301 RVA: 0x0002E671 File Offset: 0x0002C871
			public unsafe float _timer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._IntroIntensity_d__165.NativeFieldInfoPtr__timer_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._IntroIntensity_d__165.NativeFieldInfoPtr__timer_5__2)) = value;
				}
			}

			// Token: 0x04003410 RID: 13328
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003411 RID: 13329
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003412 RID: 13330
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003413 RID: 13331
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04003414 RID: 13332
			private static readonly IntPtr NativeFieldInfoPtr__timer_5__2;

			// Token: 0x04003415 RID: 13333
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003416 RID: 13334
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003417 RID: 13335
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003418 RID: 13336
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003419 RID: 13337
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400341A RID: 13338
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000303 RID: 771
		[ObfuscatedName("Global+<KickBackToMenu>d__170")]
		public sealed class _KickBackToMenu_d__170 : global::Il2CppSystem.Object
		{
			// Token: 0x06004F4E RID: 20302 RVA: 0x0012233C File Offset: 0x0012053C
			// Note: this type is marked as 'beforefieldinit'.
			static _KickBackToMenu_d__170()
			{
				Il2CppClassPointerStore<Global._KickBackToMenu_d__170>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Global>.NativeClassPtr, "<KickBackToMenu>d__170");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Global._KickBackToMenu_d__170>.NativeClassPtr);
				Global._KickBackToMenu_d__170.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._KickBackToMenu_d__170>.NativeClassPtr, "<>1__state");
				Global._KickBackToMenu_d__170.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._KickBackToMenu_d__170>.NativeClassPtr, "<>2__current");
				Global._KickBackToMenu_d__170.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._KickBackToMenu_d__170>.NativeClassPtr, "<>4__this");
				Global._KickBackToMenu_d__170.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._KickBackToMenu_d__170>.NativeClassPtr, 100665550);
				Global._KickBackToMenu_d__170.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._KickBackToMenu_d__170>.NativeClassPtr, 100665551);
				Global._KickBackToMenu_d__170.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._KickBackToMenu_d__170>.NativeClassPtr, 100665552);
				Global._KickBackToMenu_d__170.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._KickBackToMenu_d__170>.NativeClassPtr, 100665553);
				Global._KickBackToMenu_d__170.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._KickBackToMenu_d__170>.NativeClassPtr, 100665554);
				Global._KickBackToMenu_d__170.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._KickBackToMenu_d__170>.NativeClassPtr, 100665555);
			}

			// Token: 0x06004F4F RID: 20303 RVA: 0x0012241C File Offset: 0x0012061C
			[CallerCount(0)]
			public unsafe _KickBackToMenu_d__170(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Global._KickBackToMenu_d__170>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._KickBackToMenu_d__170.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F50 RID: 20304 RVA: 0x00122464 File Offset: 0x00120664
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._KickBackToMenu_d__170.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F51 RID: 20305 RVA: 0x00122498 File Offset: 0x00120698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61593, XrefRangeEnd = 61617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._KickBackToMenu_d__170.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CEA RID: 7402
			// (get) Token: 0x06004F52 RID: 20306 RVA: 0x001224D4 File Offset: 0x001206D4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._KickBackToMenu_d__170.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F53 RID: 20307 RVA: 0x00122514 File Offset: 0x00120714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61617, XrefRangeEnd = 61622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._KickBackToMenu_d__170.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CEB RID: 7403
			// (get) Token: 0x06004F54 RID: 20308 RVA: 0x00122548 File Offset: 0x00120748
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._KickBackToMenu_d__170.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F55 RID: 20309 RVA: 0x0002E68C File Offset: 0x0002C88C
			public _KickBackToMenu_d__170(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CE7 RID: 7399
			// (get) Token: 0x06004F56 RID: 20310 RVA: 0x00122588 File Offset: 0x00120788
			// (set) Token: 0x06004F57 RID: 20311 RVA: 0x0002E695 File Offset: 0x0002C895
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._KickBackToMenu_d__170.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._KickBackToMenu_d__170.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CE8 RID: 7400
			// (get) Token: 0x06004F58 RID: 20312 RVA: 0x001225B0 File Offset: 0x001207B0
			// (set) Token: 0x06004F59 RID: 20313 RVA: 0x0002E6B0 File Offset: 0x0002C8B0
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._KickBackToMenu_d__170.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._KickBackToMenu_d__170.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CE9 RID: 7401
			// (get) Token: 0x06004F5A RID: 20314 RVA: 0x001225E0 File Offset: 0x001207E0
			// (set) Token: 0x06004F5B RID: 20315 RVA: 0x0002E6CF File Offset: 0x0002C8CF
			public unsafe Global __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._KickBackToMenu_d__170.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Global>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._KickBackToMenu_d__170.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400341B RID: 13339
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400341C RID: 13340
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400341D RID: 13341
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400341E RID: 13342
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400341F RID: 13343
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003420 RID: 13344
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003421 RID: 13345
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003422 RID: 13346
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003423 RID: 13347
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000304 RID: 772
		[ObfuscatedName("Global+<DoTrailerThang>d__171")]
		public sealed class _DoTrailerThang_d__171 : global::Il2CppSystem.Object
		{
			// Token: 0x06004F5C RID: 20316 RVA: 0x00122610 File Offset: 0x00120810
			// Note: this type is marked as 'beforefieldinit'.
			static _DoTrailerThang_d__171()
			{
				Il2CppClassPointerStore<Global._DoTrailerThang_d__171>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Global>.NativeClassPtr, "<DoTrailerThang>d__171");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Global._DoTrailerThang_d__171>.NativeClassPtr);
				Global._DoTrailerThang_d__171.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._DoTrailerThang_d__171>.NativeClassPtr, "<>1__state");
				Global._DoTrailerThang_d__171.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._DoTrailerThang_d__171>.NativeClassPtr, "<>2__current");
				Global._DoTrailerThang_d__171.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._DoTrailerThang_d__171>.NativeClassPtr, "<>4__this");
				Global._DoTrailerThang_d__171.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._DoTrailerThang_d__171>.NativeClassPtr, "i");
				Global._DoTrailerThang_d__171.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._DoTrailerThang_d__171>.NativeClassPtr, 100665556);
				Global._DoTrailerThang_d__171.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._DoTrailerThang_d__171>.NativeClassPtr, 100665557);
				Global._DoTrailerThang_d__171.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._DoTrailerThang_d__171>.NativeClassPtr, 100665558);
				Global._DoTrailerThang_d__171.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._DoTrailerThang_d__171>.NativeClassPtr, 100665559);
				Global._DoTrailerThang_d__171.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._DoTrailerThang_d__171>.NativeClassPtr, 100665560);
				Global._DoTrailerThang_d__171.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._DoTrailerThang_d__171>.NativeClassPtr, 100665561);
			}

			// Token: 0x06004F5D RID: 20317 RVA: 0x00122704 File Offset: 0x00120904
			[CallerCount(0)]
			public unsafe _DoTrailerThang_d__171(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Global._DoTrailerThang_d__171>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._DoTrailerThang_d__171.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F5E RID: 20318 RVA: 0x0012274C File Offset: 0x0012094C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._DoTrailerThang_d__171.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F5F RID: 20319 RVA: 0x00122780 File Offset: 0x00120980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61622, XrefRangeEnd = 61630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._DoTrailerThang_d__171.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CF0 RID: 7408
			// (get) Token: 0x06004F60 RID: 20320 RVA: 0x001227BC File Offset: 0x001209BC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._DoTrailerThang_d__171.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F61 RID: 20321 RVA: 0x001227FC File Offset: 0x001209FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61630, XrefRangeEnd = 61635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._DoTrailerThang_d__171.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CF1 RID: 7409
			// (get) Token: 0x06004F62 RID: 20322 RVA: 0x00122830 File Offset: 0x00120A30
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._DoTrailerThang_d__171.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F63 RID: 20323 RVA: 0x0002E6EE File Offset: 0x0002C8EE
			public _DoTrailerThang_d__171(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CEC RID: 7404
			// (get) Token: 0x06004F64 RID: 20324 RVA: 0x00122870 File Offset: 0x00120A70
			// (set) Token: 0x06004F65 RID: 20325 RVA: 0x0002E6F7 File Offset: 0x0002C8F7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._DoTrailerThang_d__171.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._DoTrailerThang_d__171.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CED RID: 7405
			// (get) Token: 0x06004F66 RID: 20326 RVA: 0x00122898 File Offset: 0x00120A98
			// (set) Token: 0x06004F67 RID: 20327 RVA: 0x0002E712 File Offset: 0x0002C912
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._DoTrailerThang_d__171.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._DoTrailerThang_d__171.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CEE RID: 7406
			// (get) Token: 0x06004F68 RID: 20328 RVA: 0x001228C8 File Offset: 0x00120AC8
			// (set) Token: 0x06004F69 RID: 20329 RVA: 0x0002E731 File Offset: 0x0002C931
			public unsafe Global __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._DoTrailerThang_d__171.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Global>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._DoTrailerThang_d__171.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CEF RID: 7407
			// (get) Token: 0x06004F6A RID: 20330 RVA: 0x001228F8 File Offset: 0x00120AF8
			// (set) Token: 0x06004F6B RID: 20331 RVA: 0x0002E750 File Offset: 0x0002C950
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._DoTrailerThang_d__171.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._DoTrailerThang_d__171.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x04003424 RID: 13348
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003425 RID: 13349
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003426 RID: 13350
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003427 RID: 13351
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04003428 RID: 13352
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003429 RID: 13353
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400342A RID: 13354
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400342B RID: 13355
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400342C RID: 13356
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400342D RID: 13357
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000305 RID: 773
		[ObfuscatedName("Global+<ShowTitle>d__174")]
		public sealed class _ShowTitle_d__174 : global::Il2CppSystem.Object
		{
			// Token: 0x06004F6C RID: 20332 RVA: 0x00122920 File Offset: 0x00120B20
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowTitle_d__174()
			{
				Il2CppClassPointerStore<Global._ShowTitle_d__174>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Global>.NativeClassPtr, "<ShowTitle>d__174");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Global._ShowTitle_d__174>.NativeClassPtr);
				Global._ShowTitle_d__174.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._ShowTitle_d__174>.NativeClassPtr, "<>1__state");
				Global._ShowTitle_d__174.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._ShowTitle_d__174>.NativeClassPtr, "<>2__current");
				Global._ShowTitle_d__174.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._ShowTitle_d__174>.NativeClassPtr, "<>4__this");
				Global._ShowTitle_d__174.NativeFieldInfoPtr_titNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Global._ShowTitle_d__174>.NativeClassPtr, "titNum");
				Global._ShowTitle_d__174.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._ShowTitle_d__174>.NativeClassPtr, 100665562);
				Global._ShowTitle_d__174.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._ShowTitle_d__174>.NativeClassPtr, 100665563);
				Global._ShowTitle_d__174.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._ShowTitle_d__174>.NativeClassPtr, 100665564);
				Global._ShowTitle_d__174.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._ShowTitle_d__174>.NativeClassPtr, 100665565);
				Global._ShowTitle_d__174.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._ShowTitle_d__174>.NativeClassPtr, 100665566);
				Global._ShowTitle_d__174.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Global._ShowTitle_d__174>.NativeClassPtr, 100665567);
			}

			// Token: 0x06004F6D RID: 20333 RVA: 0x00122A14 File Offset: 0x00120C14
			[CallerCount(0)]
			public unsafe _ShowTitle_d__174(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Global._ShowTitle_d__174>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._ShowTitle_d__174.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F6E RID: 20334 RVA: 0x00122A5C File Offset: 0x00120C5C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._ShowTitle_d__174.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F6F RID: 20335 RVA: 0x00122A90 File Offset: 0x00120C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61635, XrefRangeEnd = 61658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._ShowTitle_d__174.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CF6 RID: 7414
			// (get) Token: 0x06004F70 RID: 20336 RVA: 0x00122ACC File Offset: 0x00120CCC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._ShowTitle_d__174.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F71 RID: 20337 RVA: 0x00122B0C File Offset: 0x00120D0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61658, XrefRangeEnd = 61663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._ShowTitle_d__174.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CF7 RID: 7415
			// (get) Token: 0x06004F72 RID: 20338 RVA: 0x00122B40 File Offset: 0x00120D40
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Global._ShowTitle_d__174.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F73 RID: 20339 RVA: 0x0002E76B File Offset: 0x0002C96B
			public _ShowTitle_d__174(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CF2 RID: 7410
			// (get) Token: 0x06004F74 RID: 20340 RVA: 0x00122B80 File Offset: 0x00120D80
			// (set) Token: 0x06004F75 RID: 20341 RVA: 0x0002E774 File Offset: 0x0002C974
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._ShowTitle_d__174.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._ShowTitle_d__174.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CF3 RID: 7411
			// (get) Token: 0x06004F76 RID: 20342 RVA: 0x00122BA8 File Offset: 0x00120DA8
			// (set) Token: 0x06004F77 RID: 20343 RVA: 0x0002E78F File Offset: 0x0002C98F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._ShowTitle_d__174.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._ShowTitle_d__174.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CF4 RID: 7412
			// (get) Token: 0x06004F78 RID: 20344 RVA: 0x00122BD8 File Offset: 0x00120DD8
			// (set) Token: 0x06004F79 RID: 20345 RVA: 0x0002E7AE File Offset: 0x0002C9AE
			public unsafe Global __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._ShowTitle_d__174.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Global>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._ShowTitle_d__174.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CF5 RID: 7413
			// (get) Token: 0x06004F7A RID: 20346 RVA: 0x00122C08 File Offset: 0x00120E08
			// (set) Token: 0x06004F7B RID: 20347 RVA: 0x0002E7CD File Offset: 0x0002C9CD
			public unsafe int titNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._ShowTitle_d__174.NativeFieldInfoPtr_titNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Global._ShowTitle_d__174.NativeFieldInfoPtr_titNum)) = value;
				}
			}

			// Token: 0x0400342E RID: 13358
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400342F RID: 13359
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003430 RID: 13360
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003431 RID: 13361
			private static readonly IntPtr NativeFieldInfoPtr_titNum;

			// Token: 0x04003432 RID: 13362
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003433 RID: 13363
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003434 RID: 13364
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003435 RID: 13365
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003436 RID: 13366
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003437 RID: 13367
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
