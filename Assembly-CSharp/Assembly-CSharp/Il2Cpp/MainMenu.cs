using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

namespace Il2Cpp
{
	// Token: 0x02000128 RID: 296
	public class MainMenu : MonoBehaviour
	{
		// Token: 0x0600231A RID: 8986 RVA: 0x00095B64 File Offset: 0x00093D64
		// Note: this type is marked as 'beforefieldinit'.
		static MainMenu()
		{
			Il2CppClassPointerStore<MainMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MainMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenu>.NativeClassPtr);
			MainMenu.NativeFieldInfoPtr_playing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "playing");
			MainMenu.NativeFieldInfoPtr_playTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "playTimer");
			MainMenu.NativeFieldInfoPtr_coverer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "coverer");
			MainMenu.NativeFieldInfoPtr_aud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "aud");
			MainMenu.NativeFieldInfoPtr_deadSnds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "deadSnds");
			MainMenu.NativeFieldInfoPtr_menuText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "menuText");
			MainMenu.NativeFieldInfoPtr_startText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "startText");
			MainMenu.NativeFieldInfoPtr_levelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "levelText");
			MainMenu.NativeFieldInfoPtr_worldText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "worldText");
			MainMenu.NativeFieldInfoPtr_optionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "optionText");
			MainMenu.NativeFieldInfoPtr_rebindText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "rebindText");
			MainMenu.NativeFieldInfoPtr_menued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "menued");
			MainMenu.NativeFieldInfoPtr_select = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "select");
			MainMenu.NativeFieldInfoPtr_prevStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "prevStick");
			MainMenu.NativeFieldInfoPtr_levelSelecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "levelSelecting");
			MainMenu.NativeFieldInfoPtr_worldSelecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "worldSelecting");
			MainMenu.NativeFieldInfoPtr_optioning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "optioning");
			MainMenu.NativeFieldInfoPtr_singling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "singling");
			MainMenu.NativeFieldInfoPtr_textArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "textArr");
			MainMenu.NativeFieldInfoPtr_textArrIndexToDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "textArrIndexToDisable");
			MainMenu.NativeFieldInfoPtr_levelTextArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "levelTextArr");
			MainMenu.NativeFieldInfoPtr_modeTextArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "modeTextArr");
			MainMenu.NativeFieldInfoPtr_optionTextArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "optionTextArr");
			MainMenu.NativeFieldInfoPtr_optionSettingTextArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "optionSettingTextArr");
			MainMenu.NativeFieldInfoPtr_optionIndexToDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "optionIndexToDisable");
			MainMenu.NativeFieldInfoPtr_rebindTextArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "rebindTextArr");
			MainMenu.NativeFieldInfoPtr_rebindSettingTextArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "rebindSettingTextArr");
			MainMenu.NativeFieldInfoPtr_menuInds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "menuInds");
			MainMenu.NativeFieldInfoPtr_levelInds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "levelInds");
			MainMenu.NativeFieldInfoPtr_modeInds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "modeInds");
			MainMenu.NativeFieldInfoPtr_optionInds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "optionInds");
			MainMenu.NativeFieldInfoPtr_rebindInds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "rebindInds");
			MainMenu.NativeFieldInfoPtr_singleInds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "singleInds");
			MainMenu.NativeFieldInfoPtr_albums = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "albums");
			MainMenu.NativeFieldInfoPtr_albumInds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "albumInds");
			MainMenu.NativeFieldInfoPtr_albumTxt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "albumTxt");
			MainMenu.NativeFieldInfoPtr_singles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "singles");
			MainMenu.NativeFieldInfoPtr_leveler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "leveler");
			MainMenu.NativeFieldInfoPtr_unlockedLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "unlockedLevels");
			MainMenu.NativeFieldInfoPtr_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "world");
			MainMenu.NativeFieldInfoPtr_levelBackPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "levelBackPos");
			MainMenu.NativeFieldInfoPtr_levelBackRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "levelBackRot");
			MainMenu.NativeFieldInfoPtr_niceResolutions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "niceResolutions");
			MainMenu.NativeFieldInfoPtr_curResIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "curResIndex");
			MainMenu.NativeFieldInfoPtr_defResIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "defResIndex");
			MainMenu.NativeFieldInfoPtr_asyncLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "asyncLoader");
			MainMenu.NativeFieldInfoPtr_acceptInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "acceptInput");
			MainMenu.NativeFieldInfoPtr_controllerTitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "controllerTitles");
			MainMenu.NativeFieldInfoPtr_music = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "music");
			MainMenu.NativeFieldInfoPtr_mouseMovedDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "mouseMovedDist");
			MainMenu.NativeFieldInfoPtr_prevMousePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "prevMousePos");
			MainMenu.NativeFieldInfoPtr_cursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "cursor");
			MainMenu.NativeFieldInfoPtr_keyboardText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "keyboardText");
			MainMenu.NativeFieldInfoPtr_controllerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "controllerText");
			MainMenu.NativeFieldInfoPtr_menuPalTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "menuPalTex");
			MainMenu.NativeFieldInfoPtr_mainRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "mainRenderer");
			MainMenu.NativeFieldInfoPtr_albumMenus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "albumMenus");
			MainMenu.NativeFieldInfoPtr_openAlbum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "openAlbum");
			MainMenu.NativeFieldInfoPtr_stick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "stick");
			MainMenu.NativeFieldInfoPtr_wiggleMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "wiggleMat");
			MainMenu.NativeFieldInfoPtr_nonWiggleMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "nonWiggleMat");
			MainMenu.NativeFieldInfoPtr_apeShit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "apeShit");
			MainMenu.NativeFieldInfoPtr_normalAlbs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "normalAlbs");
			MainMenu.NativeFieldInfoPtr_shitAlbs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "shitAlbs");
			MainMenu.NativeFieldInfoPtr_hardTxt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "hardTxt");
			MainMenu.NativeFieldInfoPtr_panning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "panning");
			MainMenu.NativeFieldInfoPtr_panTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "panTimer");
			MainMenu.NativeFieldInfoPtr_panTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "panTime");
			MainMenu.NativeFieldInfoPtr_panCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "panCurve");
			MainMenu.NativeFieldInfoPtr_blackScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "blackScreen");
			MainMenu.NativeFieldInfoPtr_grimeBlackScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "grimeBlackScreen");
			MainMenu.NativeFieldInfoPtr_albBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "albBG");
			MainMenu.NativeFieldInfoPtr_startFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "startFlag");
			MainMenu.NativeFieldInfoPtr_clearScreens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "clearScreens");
			MainMenu.NativeFieldInfoPtr_deathTxts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "deathTxts");
			MainMenu.NativeFieldInfoPtr_timeTxts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "timeTxts");
			MainMenu.NativeFieldInfoPtr_onClearScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "onClearScreen");
			MainMenu.NativeFieldInfoPtr_albumFlipper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "albumFlipper");
			MainMenu.NativeFieldInfoPtr_clearInputLockout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "clearInputLockout");
			MainMenu.NativeFieldInfoPtr_tweenTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "tweenTimer");
			MainMenu.NativeFieldInfoPtr_clearIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "clearIndex");
			MainMenu.NativeFieldInfoPtr_prevApeShit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "prevApeShit");
			MainMenu.NativeFieldInfoPtr_langList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "langList");
			MainMenu.NativeFieldInfoPtr_keyboarding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "keyboarding");
			MainMenu.NativeFieldInfoPtr_lastNoteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "lastNoteTime");
			MainMenu.NativeFieldInfoPtr_palRendTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "palRendTex");
			MainMenu.NativeFieldInfoPtr_dots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "dots");
			MainMenu.NativeFieldInfoPtr_dotTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "dotTimer");
			MainMenu.NativeFieldInfoPtr_dotRotTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "dotRotTimer");
			MainMenu.NativeFieldInfoPtr_showDots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "showDots");
			MainMenu.NativeFieldInfoPtr_postVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "postVolume");
			MainMenu.NativeFieldInfoPtr_normalProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "normalProfile");
			MainMenu.NativeFieldInfoPtr_normalProfileSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "normalProfileSwitch");
			MainMenu.NativeFieldInfoPtr_LastOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "LastOptions");
			MainMenu.NativeFieldInfoPtr_delaypt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "delaypt1");
			MainMenu.NativeFieldInfoPtr_delaypt13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "delaypt13");
			MainMenu.NativeFieldInfoPtr_delaypt2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "delaypt2");
			MainMenu.NativeFieldInfoPtr_delaypt3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "delaypt3");
			MainMenu.NativeFieldInfoPtr_delaypt25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "delaypt25");
			MainMenu.NativeFieldInfoPtr_delaypt4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "delaypt4");
			MainMenu.NativeFieldInfoPtr_delay1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "delay1");
			MainMenu.NativeFieldInfoPtr_delay1pt25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "delay1pt25");
			MainMenu.NativeFieldInfoPtr_singleBanana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "singleBanana");
			MainMenu.NativeFieldInfoPtr_singleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "singleTime");
			MainMenu.NativeFieldInfoPtr_mainTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "mainTitle");
			MainMenu.NativeFieldInfoPtr_controlSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "controlSetting");
			MainMenu.NativeFieldInfoPtr_rebinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "rebinding");
			MainMenu.NativeFieldInfoPtr_rebindingKeyRightNow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "rebindingKeyRightNow");
			MainMenu.NativeFieldInfoPtr_keyArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "keyArr");
			MainMenu.NativeFieldInfoPtr_rebindingInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "rebindingInd");
			MainMenu.NativeFieldInfoPtr_fScreenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "fScreenMode");
			MainMenu.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "controller");
			MainMenu.NativeFieldInfoPtr_clearBlackScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "clearBlackScreen");
			MainMenu.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "me");
			MainMenu.NativeFieldInfoPtr_lightsUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "lightsUp");
			MainMenu.NativeFieldInfoPtr_stickSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "stickSources");
			MainMenu.NativeFieldInfoPtr_lastStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "lastStick");
			MainMenu.NativeFieldInfoPtr_audioMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "audioMixer");
			MainMenu.NativeFieldInfoPtr_indicatorsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "indicatorsDisabled");
			MainMenu.NativeMethodInfoPtr_LoadLevel_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666024);
			MainMenu.NativeMethodInfoPtr_Done_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666025);
			MainMenu.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666026);
			MainMenu.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666027);
			MainMenu.NativeMethodInfoPtr_StartMusicDelayed_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666028);
			MainMenu.NativeMethodInfoPtr_ShowControllerThing_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666029);
			MainMenu.NativeMethodInfoPtr_Quit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666030);
			MainMenu.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666031);
			MainMenu.NativeMethodInfoPtr_CycleLockState_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666032);
			MainMenu.NativeMethodInfoPtr_SetFullScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666033);
			MainMenu.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666034);
			MainMenu.NativeMethodInfoPtr_LocalizeOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666035);
			MainMenu.NativeMethodInfoPtr_RecordInitialOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666036);
			MainMenu.NativeMethodInfoPtr_ResetOptionsToInitial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666037);
			MainMenu.NativeMethodInfoPtr_RemapVolume_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666038);
			MainMenu.NativeMethodInfoPtr_SetSFXVol_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666039);
			MainMenu.NativeMethodInfoPtr_SetMusicVol_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666040);
			MainMenu.NativeMethodInfoPtr_ScaleStuff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666041);
			MainMenu.NativeMethodInfoPtr_GoBackForLevelSelect_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666042);
			MainMenu.NativeMethodInfoPtr_GoBack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666043);
			MainMenu.NativeMethodInfoPtr_TurnOffClearBlack_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666044);
			MainMenu.NativeMethodInfoPtr_ClearScreenInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666045);
			MainMenu.NativeMethodInfoPtr_MenuSelect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666046);
			MainMenu.NativeMethodInfoPtr_Options_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666047);
			MainMenu.NativeMethodInfoPtr_Rebind_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666048);
			MainMenu.NativeMethodInfoPtr_GiveInputBack_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666049);
			MainMenu.NativeMethodInfoPtr_TurnOffAlbumTextInASec_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666050);
			MainMenu.NativeMethodInfoPtr_TurnOffAlbumText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666051);
			MainMenu.NativeMethodInfoPtr_FlipThisAlbumUpInASec_Private_IEnumerator_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666052);
			MainMenu.NativeMethodInfoPtr_ClearAlbum_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666053);
			MainMenu.NativeMethodInfoPtr_StickHit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666054);
			MainMenu.NativeMethodInfoPtr_FlipThisAlbumUp_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666055);
			MainMenu.NativeMethodInfoPtr_TurnOnAlbumText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666056);
			MainMenu.NativeMethodInfoPtr_OpenAlbum_Public_Void_AlbumMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666057);
			MainMenu.NativeMethodInfoPtr_PanDownForAlbumIntro_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666058);
			MainMenu.NativeMethodInfoPtr_Pan_Public_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666059);
			MainMenu.NativeMethodInfoPtr_SwitchHard_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666060);
			MainMenu.NativeMethodInfoPtr_LevelSelect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666061);
			MainMenu.NativeMethodInfoPtr_Single_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666062);
			MainMenu.NativeMethodInfoPtr_WorldSelect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666063);
			MainMenu.NativeMethodInfoPtr_Playco_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666064);
			MainMenu.NativeMethodInfoPtr_SetKeyArr_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666065);
			MainMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, 100666066);
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x0009683C File Offset: 0x00094A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70089, RefRangeEnd = 70090, XrefRangeStart = 70086, XrefRangeEnd = 70089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_LoadLevel_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x0009687C File Offset: 0x00094A7C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Done()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_Done_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x000968B0 File Offset: 0x00094AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70090, XrefRangeEnd = 70092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x000968E4 File Offset: 0x00094AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70092, XrefRangeEnd = 70377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x00096918 File Offset: 0x00094B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70377, XrefRangeEnd = 70380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StartMusicDelayed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_StartMusicDelayed_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00096958 File Offset: 0x00094B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70380, XrefRangeEnd = 70383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowControllerThing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_ShowControllerThing_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00096998 File Offset: 0x00094B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70383, XrefRangeEnd = 70387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Quit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_Quit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x000969CC File Offset: 0x00094BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70387, XrefRangeEnd = 70389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00096A00 File Offset: 0x00094C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70389, XrefRangeEnd = 70392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CycleLockState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_CycleLockState_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x00096A40 File Offset: 0x00094C40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70477, RefRangeEnd = 70478, XrefRangeStart = 70392, XrefRangeEnd = 70477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFullScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_SetFullScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x00096A74 File Offset: 0x00094C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70478, XrefRangeEnd = 70552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00096AA8 File Offset: 0x00094CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70552, XrefRangeEnd = 70618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalizeOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_LocalizeOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00096ADC File Offset: 0x00094CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70618, XrefRangeEnd = 70653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordInitialOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_RecordInitialOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x00096B10 File Offset: 0x00094D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70653, XrefRangeEnd = 70694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetOptionsToInitial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_ResetOptionsToInitial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x00096B44 File Offset: 0x00094D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70694, XrefRangeEnd = 70695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float RemapVolume(float vol)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_RemapVolume_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x00096B84 File Offset: 0x00094D84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70706, RefRangeEnd = 70708, XrefRangeStart = 70695, XrefRangeEnd = 70706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSFXVol(float vol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_SetSFXVol_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x00096BC4 File Offset: 0x00094DC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70713, RefRangeEnd = 70715, XrefRangeStart = 70708, XrefRangeEnd = 70713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMusicVol(float vol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_SetMusicVol_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x00096C04 File Offset: 0x00094E04
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScaleStuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_ScaleStuff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x00096C38 File Offset: 0x00094E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70715, XrefRangeEnd = 70718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GoBackForLevelSelect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_GoBackForLevelSelect_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x00096C78 File Offset: 0x00094E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70718, XrefRangeEnd = 70757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_GoBack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x00096CAC File Offset: 0x00094EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70757, XrefRangeEnd = 70760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TurnOffClearBlack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_TurnOffClearBlack_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x00096CEC File Offset: 0x00094EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70760, XrefRangeEnd = 70775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearScreenInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_ClearScreenInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x00096D20 File Offset: 0x00094F20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70782, RefRangeEnd = 70783, XrefRangeStart = 70775, XrefRangeEnd = 70782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MenuSelect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_MenuSelect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x00096D54 File Offset: 0x00094F54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70793, RefRangeEnd = 70794, XrefRangeStart = 70783, XrefRangeEnd = 70793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Options()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_Options_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x00096D88 File Offset: 0x00094F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70794, XrefRangeEnd = 70804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rebind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_Rebind_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x00096DBC File Offset: 0x00094FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70804, XrefRangeEnd = 70807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GiveInputBack(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_GiveInputBack_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x00096E08 File Offset: 0x00095008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70807, XrefRangeEnd = 70810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TurnOffAlbumTextInASec()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_TurnOffAlbumTextInASec_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x00096E48 File Offset: 0x00095048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70813, RefRangeEnd = 70814, XrefRangeStart = 70810, XrefRangeEnd = 70813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TurnOffAlbumText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_TurnOffAlbumText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x00096E7C File Offset: 0x0009507C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70817, RefRangeEnd = 70819, XrefRangeStart = 70814, XrefRangeEnd = 70817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FlipThisAlbumUpInASec(GameObject album, bool clearing = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(album);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_FlipThisAlbumUpInASec_Private_IEnumerator_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00096EDC File Offset: 0x000950DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70819, XrefRangeEnd = 70822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ClearAlbum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_ClearAlbum_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00096F1C File Offset: 0x0009511C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 70837, RefRangeEnd = 70840, XrefRangeStart = 70822, XrefRangeEnd = 70837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StickHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_StickHit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x00096F50 File Offset: 0x00095150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70840, XrefRangeEnd = 70913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlipThisAlbumUp(GameObject album)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(album);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_FlipThisAlbumUp_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00096F94 File Offset: 0x00095194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70923, RefRangeEnd = 70924, XrefRangeStart = 70913, XrefRangeEnd = 70923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TurnOnAlbumText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_TurnOnAlbumText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x00096FC8 File Offset: 0x000951C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70924, XrefRangeEnd = 70942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenAlbum(AlbumMenu bum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bum);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_OpenAlbum_Public_Void_AlbumMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x0009700C File Offset: 0x0009520C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70942, XrefRangeEnd = 70945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PanDownForAlbumIntro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_PanDownForAlbumIntro_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x0009704C File Offset: 0x0009524C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70948, RefRangeEnd = 70949, XrefRangeStart = 70945, XrefRangeEnd = 70948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Pan(bool up)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref up;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_Pan_Public_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00097098 File Offset: 0x00095298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70952, RefRangeEnd = 70953, XrefRangeStart = 70949, XrefRangeEnd = 70952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SwitchHard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_SwitchHard_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x000970D8 File Offset: 0x000952D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70953, XrefRangeEnd = 70969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LevelSelect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_LevelSelect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x0009710C File Offset: 0x0009530C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70969, XrefRangeEnd = 70981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Single()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_Single_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x00097140 File Offset: 0x00095340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 71017, RefRangeEnd = 71019, XrefRangeStart = 70981, XrefRangeEnd = 71017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WorldSelect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_WorldSelect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x00097174 File Offset: 0x00095374
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71022, RefRangeEnd = 71023, XrefRangeStart = 71019, XrefRangeEnd = 71022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Playco()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_Playco_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x000971B4 File Offset: 0x000953B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71238, RefRangeEnd = 71239, XrefRangeStart = 71023, XrefRangeEnd = 71238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKeyArr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr_SetKeyArr_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x000971E8 File Offset: 0x000953E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71239, XrefRangeEnd = 71307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MainMenu()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x00018983 File Offset: 0x00016B83
		public MainMenu(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x00097224 File Offset: 0x00095424
		// (set) Token: 0x06002348 RID: 9032 RVA: 0x0001898C File Offset: 0x00016B8C
		public unsafe bool playing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_playing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_playing)) = value;
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x0009724C File Offset: 0x0009544C
		// (set) Token: 0x0600234A RID: 9034 RVA: 0x000189A7 File Offset: 0x00016BA7
		public unsafe int playTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_playTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_playTimer)) = value;
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x00097274 File Offset: 0x00095474
		// (set) Token: 0x0600234C RID: 9036 RVA: 0x000189C2 File Offset: 0x00016BC2
		public unsafe GameObject coverer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_coverer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_coverer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x000972A4 File Offset: 0x000954A4
		// (set) Token: 0x0600234E RID: 9038 RVA: 0x000189E1 File Offset: 0x00016BE1
		public unsafe AudioSource aud
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_aud);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_aud), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x000972D4 File Offset: 0x000954D4
		// (set) Token: 0x06002350 RID: 9040 RVA: 0x00018A00 File Offset: 0x00016C00
		public unsafe Il2CppReferenceArray<AudioSource> deadSnds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_deadSnds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_deadSnds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06002351 RID: 9041 RVA: 0x00097304 File Offset: 0x00095504
		// (set) Token: 0x06002352 RID: 9042 RVA: 0x00018A1F File Offset: 0x00016C1F
		public unsafe GameObject menuText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_menuText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_menuText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x00097334 File Offset: 0x00095534
		// (set) Token: 0x06002354 RID: 9044 RVA: 0x00018A3E File Offset: 0x00016C3E
		public unsafe GameObject startText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_startText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_startText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x00097364 File Offset: 0x00095564
		// (set) Token: 0x06002356 RID: 9046 RVA: 0x00018A5D File Offset: 0x00016C5D
		public unsafe GameObject levelText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_levelText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_levelText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x00097394 File Offset: 0x00095594
		// (set) Token: 0x06002358 RID: 9048 RVA: 0x00018A7C File Offset: 0x00016C7C
		public unsafe GameObject worldText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_worldText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_worldText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06002359 RID: 9049 RVA: 0x000973C4 File Offset: 0x000955C4
		// (set) Token: 0x0600235A RID: 9050 RVA: 0x00018A9B File Offset: 0x00016C9B
		public unsafe GameObject optionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_optionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_optionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x0600235B RID: 9051 RVA: 0x000973F4 File Offset: 0x000955F4
		// (set) Token: 0x0600235C RID: 9052 RVA: 0x00018ABA File Offset: 0x00016CBA
		public unsafe GameObject rebindText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_rebindText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_rebindText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x0600235D RID: 9053 RVA: 0x00097424 File Offset: 0x00095624
		// (set) Token: 0x0600235E RID: 9054 RVA: 0x00018AD9 File Offset: 0x00016CD9
		public unsafe bool menued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_menued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_menued)) = value;
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x0600235F RID: 9055 RVA: 0x0009744C File Offset: 0x0009564C
		// (set) Token: 0x06002360 RID: 9056 RVA: 0x00018AF4 File Offset: 0x00016CF4
		public unsafe int select
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_select);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_select)) = value;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002361 RID: 9057 RVA: 0x00097474 File Offset: 0x00095674
		// (set) Token: 0x06002362 RID: 9058 RVA: 0x00018B0F File Offset: 0x00016D0F
		public unsafe Vector2 prevStick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_prevStick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_prevStick)) = value;
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06002363 RID: 9059 RVA: 0x0009749C File Offset: 0x0009569C
		// (set) Token: 0x06002364 RID: 9060 RVA: 0x00018B2A File Offset: 0x00016D2A
		public unsafe bool levelSelecting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_levelSelecting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_levelSelecting)) = value;
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06002365 RID: 9061 RVA: 0x000974C4 File Offset: 0x000956C4
		// (set) Token: 0x06002366 RID: 9062 RVA: 0x00018B45 File Offset: 0x00016D45
		public unsafe bool worldSelecting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_worldSelecting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_worldSelecting)) = value;
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x000974EC File Offset: 0x000956EC
		// (set) Token: 0x06002368 RID: 9064 RVA: 0x00018B60 File Offset: 0x00016D60
		public unsafe bool optioning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_optioning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_optioning)) = value;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x00097514 File Offset: 0x00095714
		// (set) Token: 0x0600236A RID: 9066 RVA: 0x00018B7B File Offset: 0x00016D7B
		public unsafe bool singling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_singling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_singling)) = value;
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x0009753C File Offset: 0x0009573C
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x00018B96 File Offset: 0x00016D96
		public unsafe Il2CppReferenceArray<Text> textArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_textArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_textArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x0009756C File Offset: 0x0009576C
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x00018BB5 File Offset: 0x00016DB5
		public unsafe Il2CppStructArray<bool> textArrIndexToDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_textArrIndexToDisable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_textArrIndexToDisable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x0009759C File Offset: 0x0009579C
		// (set) Token: 0x06002370 RID: 9072 RVA: 0x00018BD4 File Offset: 0x00016DD4
		public unsafe Il2CppReferenceArray<Text> levelTextArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_levelTextArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_levelTextArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x000975CC File Offset: 0x000957CC
		// (set) Token: 0x06002372 RID: 9074 RVA: 0x00018BF3 File Offset: 0x00016DF3
		public unsafe Il2CppReferenceArray<Text> modeTextArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_modeTextArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_modeTextArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x000975FC File Offset: 0x000957FC
		// (set) Token: 0x06002374 RID: 9076 RVA: 0x00018C12 File Offset: 0x00016E12
		public unsafe Il2CppReferenceArray<Text> optionTextArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_optionTextArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_optionTextArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x0009762C File Offset: 0x0009582C
		// (set) Token: 0x06002376 RID: 9078 RVA: 0x00018C31 File Offset: 0x00016E31
		public unsafe Il2CppReferenceArray<Text> optionSettingTextArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_optionSettingTextArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_optionSettingTextArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x0009765C File Offset: 0x0009585C
		// (set) Token: 0x06002378 RID: 9080 RVA: 0x00018C50 File Offset: 0x00016E50
		public unsafe Il2CppStructArray<bool> optionIndexToDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_optionIndexToDisable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_optionIndexToDisable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x0009768C File Offset: 0x0009588C
		// (set) Token: 0x0600237A RID: 9082 RVA: 0x00018C6F File Offset: 0x00016E6F
		public unsafe Il2CppReferenceArray<Text> rebindTextArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_rebindTextArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_rebindTextArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x000976BC File Offset: 0x000958BC
		// (set) Token: 0x0600237C RID: 9084 RVA: 0x00018C8E File Offset: 0x00016E8E
		public unsafe Il2CppReferenceArray<Text> rebindSettingTextArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_rebindSettingTextArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_rebindSettingTextArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x000976EC File Offset: 0x000958EC
		// (set) Token: 0x0600237E RID: 9086 RVA: 0x00018CAD File Offset: 0x00016EAD
		public unsafe Il2CppReferenceArray<GameObject> menuInds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_menuInds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_menuInds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x0009771C File Offset: 0x0009591C
		// (set) Token: 0x06002380 RID: 9088 RVA: 0x00018CCC File Offset: 0x00016ECC
		public unsafe Il2CppReferenceArray<GameObject> levelInds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_levelInds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_levelInds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002381 RID: 9089 RVA: 0x0009774C File Offset: 0x0009594C
		// (set) Token: 0x06002382 RID: 9090 RVA: 0x00018CEB File Offset: 0x00016EEB
		public unsafe Il2CppReferenceArray<GameObject> modeInds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_modeInds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_modeInds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06002383 RID: 9091 RVA: 0x0009777C File Offset: 0x0009597C
		// (set) Token: 0x06002384 RID: 9092 RVA: 0x00018D0A File Offset: 0x00016F0A
		public unsafe Il2CppReferenceArray<GameObject> optionInds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_optionInds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_optionInds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06002385 RID: 9093 RVA: 0x000977AC File Offset: 0x000959AC
		// (set) Token: 0x06002386 RID: 9094 RVA: 0x00018D29 File Offset: 0x00016F29
		public unsafe Il2CppReferenceArray<GameObject> rebindInds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_rebindInds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_rebindInds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x000977DC File Offset: 0x000959DC
		// (set) Token: 0x06002388 RID: 9096 RVA: 0x00018D48 File Offset: 0x00016F48
		public unsafe Il2CppReferenceArray<GameObject> singleInds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_singleInds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_singleInds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x0009780C File Offset: 0x00095A0C
		// (set) Token: 0x0600238A RID: 9098 RVA: 0x00018D67 File Offset: 0x00016F67
		public unsafe Il2CppReferenceArray<GameObject> albums
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_albums);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_albums), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x0009783C File Offset: 0x00095A3C
		// (set) Token: 0x0600238C RID: 9100 RVA: 0x00018D86 File Offset: 0x00016F86
		public unsafe Il2CppReferenceArray<GameObject> albumInds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_albumInds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_albumInds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x0009786C File Offset: 0x00095A6C
		// (set) Token: 0x0600238E RID: 9102 RVA: 0x00018DA5 File Offset: 0x00016FA5
		public unsafe Il2CppReferenceArray<GameObject> albumTxt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_albumTxt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_albumTxt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x0009789C File Offset: 0x00095A9C
		// (set) Token: 0x06002390 RID: 9104 RVA: 0x00018DC4 File Offset: 0x00016FC4
		public unsafe Il2CppReferenceArray<GameObject> singles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_singles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_singles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x000978CC File Offset: 0x00095ACC
		// (set) Token: 0x06002392 RID: 9106 RVA: 0x00018DE3 File Offset: 0x00016FE3
		public unsafe HealthMaster leveler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_leveler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HealthMaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_leveler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x000978FC File Offset: 0x00095AFC
		// (set) Token: 0x06002394 RID: 9108 RVA: 0x00018E02 File Offset: 0x00017002
		public unsafe int unlockedLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_unlockedLevels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_unlockedLevels)) = value;
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06002395 RID: 9109 RVA: 0x00097924 File Offset: 0x00095B24
		// (set) Token: 0x06002396 RID: 9110 RVA: 0x00018E1D File Offset: 0x0001701D
		public unsafe int world
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_world);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_world)) = value;
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06002397 RID: 9111 RVA: 0x0009794C File Offset: 0x00095B4C
		// (set) Token: 0x06002398 RID: 9112 RVA: 0x00018E38 File Offset: 0x00017038
		public unsafe Vector2 levelBackPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_levelBackPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_levelBackPos)) = value;
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06002399 RID: 9113 RVA: 0x00097974 File Offset: 0x00095B74
		// (set) Token: 0x0600239A RID: 9114 RVA: 0x00018E53 File Offset: 0x00017053
		public unsafe Quaternion levelBackRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_levelBackRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_levelBackRot)) = value;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x0600239B RID: 9115 RVA: 0x0009799C File Offset: 0x00095B9C
		// (set) Token: 0x0600239C RID: 9116 RVA: 0x00018E6E File Offset: 0x0001706E
		public unsafe List<Resolution> niceResolutions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_niceResolutions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Resolution>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_niceResolutions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x0600239D RID: 9117 RVA: 0x000979CC File Offset: 0x00095BCC
		// (set) Token: 0x0600239E RID: 9118 RVA: 0x00018E8D File Offset: 0x0001708D
		public unsafe int curResIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_curResIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_curResIndex)) = value;
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x0600239F RID: 9119 RVA: 0x000979F4 File Offset: 0x00095BF4
		// (set) Token: 0x060023A0 RID: 9120 RVA: 0x00018EA8 File Offset: 0x000170A8
		public unsafe int defResIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_defResIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_defResIndex)) = value;
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060023A1 RID: 9121 RVA: 0x00097A1C File Offset: 0x00095C1C
		// (set) Token: 0x060023A2 RID: 9122 RVA: 0x00018EC3 File Offset: 0x000170C3
		public unsafe AsyncOperation asyncLoader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_asyncLoader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_asyncLoader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060023A3 RID: 9123 RVA: 0x00097A4C File Offset: 0x00095C4C
		// (set) Token: 0x060023A4 RID: 9124 RVA: 0x00018EE2 File Offset: 0x000170E2
		public unsafe bool acceptInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_acceptInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_acceptInput)) = value;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060023A5 RID: 9125 RVA: 0x00097A74 File Offset: 0x00095C74
		// (set) Token: 0x060023A6 RID: 9126 RVA: 0x00018EFD File Offset: 0x000170FD
		public unsafe Il2CppReferenceArray<GameObject> controllerTitles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_controllerTitles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_controllerTitles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060023A7 RID: 9127 RVA: 0x00097AA4 File Offset: 0x00095CA4
		// (set) Token: 0x060023A8 RID: 9128 RVA: 0x00018F1C File Offset: 0x0001711C
		public unsafe AudioSource music
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_music);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_music), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060023A9 RID: 9129 RVA: 0x00097AD4 File Offset: 0x00095CD4
		// (set) Token: 0x060023AA RID: 9130 RVA: 0x00018F3B File Offset: 0x0001713B
		public unsafe float mouseMovedDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_mouseMovedDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_mouseMovedDist)) = value;
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060023AB RID: 9131 RVA: 0x00097AFC File Offset: 0x00095CFC
		// (set) Token: 0x060023AC RID: 9132 RVA: 0x00018F56 File Offset: 0x00017156
		public unsafe Vector2 prevMousePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_prevMousePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_prevMousePos)) = value;
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060023AD RID: 9133 RVA: 0x00097B24 File Offset: 0x00095D24
		// (set) Token: 0x060023AE RID: 9134 RVA: 0x00018F71 File Offset: 0x00017171
		public unsafe GameObject cursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_cursor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_cursor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x00097B54 File Offset: 0x00095D54
		// (set) Token: 0x060023B0 RID: 9136 RVA: 0x00018F90 File Offset: 0x00017190
		public unsafe GameObject keyboardText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_keyboardText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_keyboardText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x060023B1 RID: 9137 RVA: 0x00097B84 File Offset: 0x00095D84
		// (set) Token: 0x060023B2 RID: 9138 RVA: 0x00018FAF File Offset: 0x000171AF
		public unsafe GameObject controllerText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_controllerText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_controllerText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x060023B3 RID: 9139 RVA: 0x00097BB4 File Offset: 0x00095DB4
		// (set) Token: 0x060023B4 RID: 9140 RVA: 0x00018FCE File Offset: 0x000171CE
		public unsafe Texture menuPalTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_menuPalTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_menuPalTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x060023B5 RID: 9141 RVA: 0x00097BE4 File Offset: 0x00095DE4
		// (set) Token: 0x060023B6 RID: 9142 RVA: 0x00018FED File Offset: 0x000171ED
		public unsafe Renderer mainRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_mainRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_mainRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x060023B7 RID: 9143 RVA: 0x00097C14 File Offset: 0x00095E14
		// (set) Token: 0x060023B8 RID: 9144 RVA: 0x0001900C File Offset: 0x0001720C
		public unsafe Il2CppReferenceArray<AlbumMenu> albumMenus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_albumMenus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AlbumMenu>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_albumMenus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x060023B9 RID: 9145 RVA: 0x00097C44 File Offset: 0x00095E44
		// (set) Token: 0x060023BA RID: 9146 RVA: 0x0001902B File Offset: 0x0001722B
		public unsafe AlbumMenu openAlbum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_openAlbum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AlbumMenu>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_openAlbum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x060023BB RID: 9147 RVA: 0x00097C74 File Offset: 0x00095E74
		// (set) Token: 0x060023BC RID: 9148 RVA: 0x0001904A File Offset: 0x0001724A
		public unsafe Vector2 stick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_stick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_stick)) = value;
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x00097C9C File Offset: 0x00095E9C
		// (set) Token: 0x060023BE RID: 9150 RVA: 0x00019065 File Offset: 0x00017265
		public unsafe Material wiggleMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_wiggleMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_wiggleMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x060023BF RID: 9151 RVA: 0x00097CCC File Offset: 0x00095ECC
		// (set) Token: 0x060023C0 RID: 9152 RVA: 0x00019084 File Offset: 0x00017284
		public unsafe Material nonWiggleMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_nonWiggleMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_nonWiggleMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x060023C1 RID: 9153 RVA: 0x00097CFC File Offset: 0x00095EFC
		// (set) Token: 0x060023C2 RID: 9154 RVA: 0x000190A3 File Offset: 0x000172A3
		public unsafe bool apeShit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_apeShit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_apeShit)) = value;
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x060023C3 RID: 9155 RVA: 0x00097D24 File Offset: 0x00095F24
		// (set) Token: 0x060023C4 RID: 9156 RVA: 0x000190BE File Offset: 0x000172BE
		public unsafe Il2CppReferenceArray<AlbumMenu> normalAlbs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_normalAlbs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AlbumMenu>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_normalAlbs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x060023C5 RID: 9157 RVA: 0x00097D54 File Offset: 0x00095F54
		// (set) Token: 0x060023C6 RID: 9158 RVA: 0x000190DD File Offset: 0x000172DD
		public unsafe Il2CppReferenceArray<AlbumMenu> shitAlbs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_shitAlbs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AlbumMenu>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_shitAlbs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x060023C7 RID: 9159 RVA: 0x00097D84 File Offset: 0x00095F84
		// (set) Token: 0x060023C8 RID: 9160 RVA: 0x000190FC File Offset: 0x000172FC
		public unsafe TextMesh hardTxt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_hardTxt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_hardTxt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x060023C9 RID: 9161 RVA: 0x00097DB4 File Offset: 0x00095FB4
		// (set) Token: 0x060023CA RID: 9162 RVA: 0x0001911B File Offset: 0x0001731B
		public unsafe bool panning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_panning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_panning)) = value;
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x00097DDC File Offset: 0x00095FDC
		// (set) Token: 0x060023CC RID: 9164 RVA: 0x00019136 File Offset: 0x00017336
		public unsafe float panTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_panTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_panTimer)) = value;
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x00097E04 File Offset: 0x00096004
		// (set) Token: 0x060023CE RID: 9166 RVA: 0x00019151 File Offset: 0x00017351
		public unsafe float panTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_panTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_panTime)) = value;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x060023CF RID: 9167 RVA: 0x00097E2C File Offset: 0x0009602C
		// (set) Token: 0x060023D0 RID: 9168 RVA: 0x0001916C File Offset: 0x0001736C
		public unsafe AnimationCurve panCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_panCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_panCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x060023D1 RID: 9169 RVA: 0x00097E5C File Offset: 0x0009605C
		// (set) Token: 0x060023D2 RID: 9170 RVA: 0x0001918B File Offset: 0x0001738B
		public unsafe GameObject blackScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_blackScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_blackScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x060023D3 RID: 9171 RVA: 0x00097E8C File Offset: 0x0009608C
		// (set) Token: 0x060023D4 RID: 9172 RVA: 0x000191AA File Offset: 0x000173AA
		public unsafe GameObject grimeBlackScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_grimeBlackScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_grimeBlackScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x060023D5 RID: 9173 RVA: 0x00097EBC File Offset: 0x000960BC
		// (set) Token: 0x060023D6 RID: 9174 RVA: 0x000191C9 File Offset: 0x000173C9
		public unsafe GameObject albBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_albBG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_albBG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060023D7 RID: 9175 RVA: 0x00097EEC File Offset: 0x000960EC
		// (set) Token: 0x060023D8 RID: 9176 RVA: 0x000191E8 File Offset: 0x000173E8
		public unsafe bool startFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_startFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_startFlag)) = value;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060023D9 RID: 9177 RVA: 0x00097F14 File Offset: 0x00096114
		// (set) Token: 0x060023DA RID: 9178 RVA: 0x00019203 File Offset: 0x00017403
		public unsafe Il2CppReferenceArray<GameObject> clearScreens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_clearScreens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_clearScreens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x060023DB RID: 9179 RVA: 0x00097F44 File Offset: 0x00096144
		// (set) Token: 0x060023DC RID: 9180 RVA: 0x00019222 File Offset: 0x00017422
		public unsafe Il2CppReferenceArray<TextMesh> deathTxts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_deathTxts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_deathTxts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060023DD RID: 9181 RVA: 0x00097F74 File Offset: 0x00096174
		// (set) Token: 0x060023DE RID: 9182 RVA: 0x00019241 File Offset: 0x00017441
		public unsafe Il2CppReferenceArray<TextMesh> timeTxts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_timeTxts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_timeTxts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x060023DF RID: 9183 RVA: 0x00097FA4 File Offset: 0x000961A4
		// (set) Token: 0x060023E0 RID: 9184 RVA: 0x00019260 File Offset: 0x00017460
		public unsafe bool onClearScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_onClearScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_onClearScreen)) = value;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060023E1 RID: 9185 RVA: 0x00097FCC File Offset: 0x000961CC
		// (set) Token: 0x060023E2 RID: 9186 RVA: 0x0001927B File Offset: 0x0001747B
		public unsafe GameObject albumFlipper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_albumFlipper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_albumFlipper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x060023E3 RID: 9187 RVA: 0x00097FFC File Offset: 0x000961FC
		// (set) Token: 0x060023E4 RID: 9188 RVA: 0x0001929A File Offset: 0x0001749A
		public unsafe float clearInputLockout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_clearInputLockout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_clearInputLockout)) = value;
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x060023E5 RID: 9189 RVA: 0x00098024 File Offset: 0x00096224
		// (set) Token: 0x060023E6 RID: 9190 RVA: 0x000192B5 File Offset: 0x000174B5
		public unsafe float tweenTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_tweenTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_tweenTimer)) = value;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060023E7 RID: 9191 RVA: 0x0009804C File Offset: 0x0009624C
		// (set) Token: 0x060023E8 RID: 9192 RVA: 0x000192D0 File Offset: 0x000174D0
		public unsafe int clearIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_clearIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_clearIndex)) = value;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060023E9 RID: 9193 RVA: 0x00098074 File Offset: 0x00096274
		// (set) Token: 0x060023EA RID: 9194 RVA: 0x000192EB File Offset: 0x000174EB
		public unsafe bool prevApeShit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_prevApeShit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_prevApeShit)) = value;
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x0009809C File Offset: 0x0009629C
		// (set) Token: 0x060023EC RID: 9196 RVA: 0x00019306 File Offset: 0x00017506
		public unsafe Il2CppStringArray langList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_langList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_langList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x060023ED RID: 9197 RVA: 0x000980CC File Offset: 0x000962CC
		// (set) Token: 0x060023EE RID: 9198 RVA: 0x00019325 File Offset: 0x00017525
		public unsafe bool keyboarding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_keyboarding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_keyboarding)) = value;
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x000980F4 File Offset: 0x000962F4
		// (set) Token: 0x060023F0 RID: 9200 RVA: 0x00019340 File Offset: 0x00017540
		public unsafe float lastNoteTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_lastNoteTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_lastNoteTime)) = value;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x0009811C File Offset: 0x0009631C
		// (set) Token: 0x060023F2 RID: 9202 RVA: 0x0001935B File Offset: 0x0001755B
		public unsafe RenderTexture palRendTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_palRendTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_palRendTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x0009814C File Offset: 0x0009634C
		// (set) Token: 0x060023F4 RID: 9204 RVA: 0x0001937A File Offset: 0x0001757A
		public unsafe Il2CppReferenceArray<GameObject> dots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_dots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_dots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x0009817C File Offset: 0x0009637C
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x00019399 File Offset: 0x00017599
		public unsafe float dotTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_dotTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_dotTimer)) = value;
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x000981A4 File Offset: 0x000963A4
		// (set) Token: 0x060023F8 RID: 9208 RVA: 0x000193B4 File Offset: 0x000175B4
		public unsafe float dotRotTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_dotRotTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_dotRotTimer)) = value;
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x000981CC File Offset: 0x000963CC
		// (set) Token: 0x060023FA RID: 9210 RVA: 0x000193CF File Offset: 0x000175CF
		public unsafe bool showDots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_showDots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_showDots)) = value;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x000981F4 File Offset: 0x000963F4
		// (set) Token: 0x060023FC RID: 9212 RVA: 0x000193EA File Offset: 0x000175EA
		public unsafe PostProcessVolume postVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_postVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_postVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x060023FD RID: 9213 RVA: 0x00098224 File Offset: 0x00096424
		// (set) Token: 0x060023FE RID: 9214 RVA: 0x00019409 File Offset: 0x00017609
		public unsafe PostProcessProfile normalProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_normalProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_normalProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x00098254 File Offset: 0x00096454
		// (set) Token: 0x06002400 RID: 9216 RVA: 0x00019428 File Offset: 0x00017628
		public unsafe PostProcessProfile normalProfileSwitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_normalProfileSwitch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_normalProfileSwitch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x00098284 File Offset: 0x00096484
		// (set) Token: 0x06002402 RID: 9218 RVA: 0x00019447 File Offset: 0x00017647
		public unsafe static MainMenu.OptionsInformation LastOptions
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MainMenu.OptionsInformation>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(MainMenu.NativeFieldInfoPtr_LastOptions, intPtr);
				return new MainMenu.OptionsInformation(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MainMenu.OptionsInformation>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MainMenu.NativeFieldInfoPtr_LastOptions, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x000982C0 File Offset: 0x000964C0
		// (set) Token: 0x06002404 RID: 9220 RVA: 0x0001945E File Offset: 0x0001765E
		public unsafe WaitForSeconds delaypt1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_delaypt1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_delaypt1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x000982F0 File Offset: 0x000964F0
		// (set) Token: 0x06002406 RID: 9222 RVA: 0x0001947D File Offset: 0x0001767D
		public unsafe WaitForSeconds delaypt13
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_delaypt13);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_delaypt13), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06002407 RID: 9223 RVA: 0x00098320 File Offset: 0x00096520
		// (set) Token: 0x06002408 RID: 9224 RVA: 0x0001949C File Offset: 0x0001769C
		public unsafe WaitForSeconds delaypt2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_delaypt2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_delaypt2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x00098350 File Offset: 0x00096550
		// (set) Token: 0x0600240A RID: 9226 RVA: 0x000194BB File Offset: 0x000176BB
		public unsafe WaitForSeconds delaypt3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_delaypt3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_delaypt3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x00098380 File Offset: 0x00096580
		// (set) Token: 0x0600240C RID: 9228 RVA: 0x000194DA File Offset: 0x000176DA
		public unsafe WaitForSeconds delaypt25
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_delaypt25);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_delaypt25), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x0600240D RID: 9229 RVA: 0x000983B0 File Offset: 0x000965B0
		// (set) Token: 0x0600240E RID: 9230 RVA: 0x000194F9 File Offset: 0x000176F9
		public unsafe WaitForSeconds delaypt4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_delaypt4);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_delaypt4), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x000983E0 File Offset: 0x000965E0
		// (set) Token: 0x06002410 RID: 9232 RVA: 0x00019518 File Offset: 0x00017718
		public unsafe WaitForSeconds delay1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_delay1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_delay1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x00098410 File Offset: 0x00096610
		// (set) Token: 0x06002412 RID: 9234 RVA: 0x00019537 File Offset: 0x00017737
		public unsafe WaitForSeconds delay1pt25
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_delay1pt25);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_delay1pt25), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x00098440 File Offset: 0x00096640
		// (set) Token: 0x06002414 RID: 9236 RVA: 0x00019556 File Offset: 0x00017756
		public unsafe GameObject singleBanana
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_singleBanana);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_singleBanana), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x00098470 File Offset: 0x00096670
		// (set) Token: 0x06002416 RID: 9238 RVA: 0x00019575 File Offset: 0x00017775
		public unsafe TextMesh singleTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_singleTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_singleTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x000984A0 File Offset: 0x000966A0
		// (set) Token: 0x06002418 RID: 9240 RVA: 0x00019594 File Offset: 0x00017794
		public unsafe Transform mainTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_mainTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_mainTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x000984D0 File Offset: 0x000966D0
		// (set) Token: 0x0600241A RID: 9242 RVA: 0x000195B3 File Offset: 0x000177B3
		public unsafe bool controlSetting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_controlSetting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_controlSetting)) = value;
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x0600241B RID: 9243 RVA: 0x000984F8 File Offset: 0x000966F8
		// (set) Token: 0x0600241C RID: 9244 RVA: 0x000195CE File Offset: 0x000177CE
		public unsafe bool rebinding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_rebinding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_rebinding)) = value;
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x00098520 File Offset: 0x00096720
		// (set) Token: 0x0600241E RID: 9246 RVA: 0x000195E9 File Offset: 0x000177E9
		public unsafe bool rebindingKeyRightNow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_rebindingKeyRightNow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_rebindingKeyRightNow)) = value;
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x00098548 File Offset: 0x00096748
		// (set) Token: 0x06002420 RID: 9248 RVA: 0x00019604 File Offset: 0x00017804
		public unsafe Il2CppReferenceArray<KeyPair> keyArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_keyArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_keyArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06002421 RID: 9249 RVA: 0x00098578 File Offset: 0x00096778
		// (set) Token: 0x06002422 RID: 9250 RVA: 0x00019623 File Offset: 0x00017823
		public unsafe int rebindingInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_rebindingInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_rebindingInd)) = value;
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x000985A0 File Offset: 0x000967A0
		// (set) Token: 0x06002424 RID: 9252 RVA: 0x0001963E File Offset: 0x0001783E
		public unsafe int fScreenMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_fScreenMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_fScreenMode)) = value;
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x000985C8 File Offset: 0x000967C8
		// (set) Token: 0x06002426 RID: 9254 RVA: 0x00019659 File Offset: 0x00017859
		public unsafe Player controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x000985F8 File Offset: 0x000967F8
		// (set) Token: 0x06002428 RID: 9256 RVA: 0x00019678 File Offset: 0x00017878
		public unsafe GameObject clearBlackScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_clearBlackScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_clearBlackScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x00098628 File Offset: 0x00096828
		// (set) Token: 0x0600242A RID: 9258 RVA: 0x00019697 File Offset: 0x00017897
		public unsafe static MainMenu me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MainMenu.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenu>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MainMenu.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x00098650 File Offset: 0x00096850
		// (set) Token: 0x0600242C RID: 9260 RVA: 0x000196A9 File Offset: 0x000178A9
		public unsafe AudioSource lightsUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_lightsUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_lightsUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x00098680 File Offset: 0x00096880
		// (set) Token: 0x0600242E RID: 9262 RVA: 0x000196C8 File Offset: 0x000178C8
		public unsafe Il2CppReferenceArray<AudioSource> stickSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_stickSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_stickSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x000986B0 File Offset: 0x000968B0
		// (set) Token: 0x06002430 RID: 9264 RVA: 0x000196E7 File Offset: 0x000178E7
		public unsafe int lastStick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_lastStick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_lastStick)) = value;
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06002431 RID: 9265 RVA: 0x000986D8 File Offset: 0x000968D8
		// (set) Token: 0x06002432 RID: 9266 RVA: 0x00019702 File Offset: 0x00017902
		public unsafe AudioMixer audioMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_audioMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_audioMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x00098708 File Offset: 0x00096908
		// (set) Token: 0x06002434 RID: 9268 RVA: 0x00019721 File Offset: 0x00017921
		public unsafe Il2CppStructArray<bool> indicatorsDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_indicatorsDisabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.NativeFieldInfoPtr_indicatorsDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeFieldInfoPtr_playing;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeFieldInfoPtr_playTimer;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeFieldInfoPtr_coverer;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeFieldInfoPtr_aud;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeFieldInfoPtr_deadSnds;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeFieldInfoPtr_menuText;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeFieldInfoPtr_startText;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeFieldInfoPtr_levelText;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeFieldInfoPtr_worldText;

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeFieldInfoPtr_optionText;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeFieldInfoPtr_rebindText;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeFieldInfoPtr_menued;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeFieldInfoPtr_select;

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeFieldInfoPtr_prevStick;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeFieldInfoPtr_levelSelecting;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeFieldInfoPtr_worldSelecting;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeFieldInfoPtr_optioning;

		// Token: 0x040014C1 RID: 5313
		private static readonly IntPtr NativeFieldInfoPtr_singling;

		// Token: 0x040014C2 RID: 5314
		private static readonly IntPtr NativeFieldInfoPtr_textArr;

		// Token: 0x040014C3 RID: 5315
		private static readonly IntPtr NativeFieldInfoPtr_textArrIndexToDisable;

		// Token: 0x040014C4 RID: 5316
		private static readonly IntPtr NativeFieldInfoPtr_levelTextArr;

		// Token: 0x040014C5 RID: 5317
		private static readonly IntPtr NativeFieldInfoPtr_modeTextArr;

		// Token: 0x040014C6 RID: 5318
		private static readonly IntPtr NativeFieldInfoPtr_optionTextArr;

		// Token: 0x040014C7 RID: 5319
		private static readonly IntPtr NativeFieldInfoPtr_optionSettingTextArr;

		// Token: 0x040014C8 RID: 5320
		private static readonly IntPtr NativeFieldInfoPtr_optionIndexToDisable;

		// Token: 0x040014C9 RID: 5321
		private static readonly IntPtr NativeFieldInfoPtr_rebindTextArr;

		// Token: 0x040014CA RID: 5322
		private static readonly IntPtr NativeFieldInfoPtr_rebindSettingTextArr;

		// Token: 0x040014CB RID: 5323
		private static readonly IntPtr NativeFieldInfoPtr_menuInds;

		// Token: 0x040014CC RID: 5324
		private static readonly IntPtr NativeFieldInfoPtr_levelInds;

		// Token: 0x040014CD RID: 5325
		private static readonly IntPtr NativeFieldInfoPtr_modeInds;

		// Token: 0x040014CE RID: 5326
		private static readonly IntPtr NativeFieldInfoPtr_optionInds;

		// Token: 0x040014CF RID: 5327
		private static readonly IntPtr NativeFieldInfoPtr_rebindInds;

		// Token: 0x040014D0 RID: 5328
		private static readonly IntPtr NativeFieldInfoPtr_singleInds;

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeFieldInfoPtr_albums;

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeFieldInfoPtr_albumInds;

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeFieldInfoPtr_albumTxt;

		// Token: 0x040014D4 RID: 5332
		private static readonly IntPtr NativeFieldInfoPtr_singles;

		// Token: 0x040014D5 RID: 5333
		private static readonly IntPtr NativeFieldInfoPtr_leveler;

		// Token: 0x040014D6 RID: 5334
		private static readonly IntPtr NativeFieldInfoPtr_unlockedLevels;

		// Token: 0x040014D7 RID: 5335
		private static readonly IntPtr NativeFieldInfoPtr_world;

		// Token: 0x040014D8 RID: 5336
		private static readonly IntPtr NativeFieldInfoPtr_levelBackPos;

		// Token: 0x040014D9 RID: 5337
		private static readonly IntPtr NativeFieldInfoPtr_levelBackRot;

		// Token: 0x040014DA RID: 5338
		private static readonly IntPtr NativeFieldInfoPtr_niceResolutions;

		// Token: 0x040014DB RID: 5339
		private static readonly IntPtr NativeFieldInfoPtr_curResIndex;

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeFieldInfoPtr_defResIndex;

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeFieldInfoPtr_asyncLoader;

		// Token: 0x040014DE RID: 5342
		private static readonly IntPtr NativeFieldInfoPtr_acceptInput;

		// Token: 0x040014DF RID: 5343
		private static readonly IntPtr NativeFieldInfoPtr_controllerTitles;

		// Token: 0x040014E0 RID: 5344
		private static readonly IntPtr NativeFieldInfoPtr_music;

		// Token: 0x040014E1 RID: 5345
		private static readonly IntPtr NativeFieldInfoPtr_mouseMovedDist;

		// Token: 0x040014E2 RID: 5346
		private static readonly IntPtr NativeFieldInfoPtr_prevMousePos;

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeFieldInfoPtr_cursor;

		// Token: 0x040014E4 RID: 5348
		private static readonly IntPtr NativeFieldInfoPtr_keyboardText;

		// Token: 0x040014E5 RID: 5349
		private static readonly IntPtr NativeFieldInfoPtr_controllerText;

		// Token: 0x040014E6 RID: 5350
		private static readonly IntPtr NativeFieldInfoPtr_menuPalTex;

		// Token: 0x040014E7 RID: 5351
		private static readonly IntPtr NativeFieldInfoPtr_mainRenderer;

		// Token: 0x040014E8 RID: 5352
		private static readonly IntPtr NativeFieldInfoPtr_albumMenus;

		// Token: 0x040014E9 RID: 5353
		private static readonly IntPtr NativeFieldInfoPtr_openAlbum;

		// Token: 0x040014EA RID: 5354
		private static readonly IntPtr NativeFieldInfoPtr_stick;

		// Token: 0x040014EB RID: 5355
		private static readonly IntPtr NativeFieldInfoPtr_wiggleMat;

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeFieldInfoPtr_nonWiggleMat;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeFieldInfoPtr_apeShit;

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeFieldInfoPtr_normalAlbs;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeFieldInfoPtr_shitAlbs;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeFieldInfoPtr_hardTxt;

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeFieldInfoPtr_panning;

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeFieldInfoPtr_panTimer;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeFieldInfoPtr_panTime;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeFieldInfoPtr_panCurve;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeFieldInfoPtr_blackScreen;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeFieldInfoPtr_grimeBlackScreen;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeFieldInfoPtr_albBG;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeFieldInfoPtr_startFlag;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeFieldInfoPtr_clearScreens;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeFieldInfoPtr_deathTxts;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeFieldInfoPtr_timeTxts;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeFieldInfoPtr_onClearScreen;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeFieldInfoPtr_albumFlipper;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeFieldInfoPtr_clearInputLockout;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeFieldInfoPtr_tweenTimer;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeFieldInfoPtr_clearIndex;

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeFieldInfoPtr_prevApeShit;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeFieldInfoPtr_langList;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeFieldInfoPtr_keyboarding;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeFieldInfoPtr_lastNoteTime;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeFieldInfoPtr_palRendTex;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeFieldInfoPtr_dots;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeFieldInfoPtr_dotTimer;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeFieldInfoPtr_dotRotTimer;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeFieldInfoPtr_showDots;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeFieldInfoPtr_postVolume;

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeFieldInfoPtr_normalProfile;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeFieldInfoPtr_normalProfileSwitch;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeFieldInfoPtr_LastOptions;

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeFieldInfoPtr_delaypt1;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeFieldInfoPtr_delaypt13;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeFieldInfoPtr_delaypt2;

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeFieldInfoPtr_delaypt3;

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeFieldInfoPtr_delaypt25;

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeFieldInfoPtr_delaypt4;

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeFieldInfoPtr_delay1;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeFieldInfoPtr_delay1pt25;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeFieldInfoPtr_singleBanana;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeFieldInfoPtr_singleTime;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeFieldInfoPtr_mainTitle;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeFieldInfoPtr_controlSetting;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeFieldInfoPtr_rebinding;

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeFieldInfoPtr_rebindingKeyRightNow;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeFieldInfoPtr_keyArr;

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeFieldInfoPtr_rebindingInd;

		// Token: 0x0400151E RID: 5406
		private static readonly IntPtr NativeFieldInfoPtr_fScreenMode;

		// Token: 0x0400151F RID: 5407
		private static readonly IntPtr NativeFieldInfoPtr_controller;

		// Token: 0x04001520 RID: 5408
		private static readonly IntPtr NativeFieldInfoPtr_clearBlackScreen;

		// Token: 0x04001521 RID: 5409
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeFieldInfoPtr_lightsUp;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeFieldInfoPtr_stickSources;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeFieldInfoPtr_lastStick;

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeFieldInfoPtr_audioMixer;

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeFieldInfoPtr_indicatorsDisabled;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeMethodInfoPtr_LoadLevel_Private_IEnumerator_0;

		// Token: 0x04001528 RID: 5416
		private static readonly IntPtr NativeMethodInfoPtr_Done_Private_Void_0;

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeMethodInfoPtr_StartMusicDelayed_Private_IEnumerator_0;

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeMethodInfoPtr_ShowControllerThing_Private_IEnumerator_0;

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeMethodInfoPtr_Quit_Public_Void_0;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeMethodInfoPtr_CycleLockState_Private_IEnumerator_0;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeMethodInfoPtr_SetFullScreen_Private_Void_0;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeMethodInfoPtr_LocalizeOptions_Private_Void_0;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeMethodInfoPtr_RecordInitialOptions_Private_Void_0;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeMethodInfoPtr_ResetOptionsToInitial_Private_Void_0;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr_RemapVolume_Public_Static_Single_Single_0;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr_SetSFXVol_Private_Void_Single_0;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeMethodInfoPtr_SetMusicVol_Private_Void_Single_0;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeMethodInfoPtr_ScaleStuff_Public_Void_0;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeMethodInfoPtr_GoBackForLevelSelect_Private_IEnumerator_0;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr_GoBack_Public_Void_0;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr_TurnOffClearBlack_Private_IEnumerator_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr_ClearScreenInput_Private_Void_0;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr_MenuSelect_Public_Void_0;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeMethodInfoPtr_Options_Public_Void_0;

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeMethodInfoPtr_Rebind_Public_Void_0;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeMethodInfoPtr_GiveInputBack_Private_IEnumerator_Single_0;

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeMethodInfoPtr_TurnOffAlbumTextInASec_Private_IEnumerator_0;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeMethodInfoPtr_TurnOffAlbumText_Private_Void_0;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeMethodInfoPtr_FlipThisAlbumUpInASec_Private_IEnumerator_GameObject_Boolean_0;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeMethodInfoPtr_ClearAlbum_Private_IEnumerator_0;

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeMethodInfoPtr_StickHit_Private_Void_0;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeMethodInfoPtr_FlipThisAlbumUp_Private_Void_GameObject_0;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeMethodInfoPtr_TurnOnAlbumText_Private_Void_0;

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeMethodInfoPtr_OpenAlbum_Public_Void_AlbumMenu_0;

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeMethodInfoPtr_PanDownForAlbumIntro_Private_IEnumerator_0;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeMethodInfoPtr_Pan_Public_IEnumerator_Boolean_0;

		// Token: 0x0400154B RID: 5451
		private static readonly IntPtr NativeMethodInfoPtr_SwitchHard_Public_IEnumerator_0;

		// Token: 0x0400154C RID: 5452
		private static readonly IntPtr NativeMethodInfoPtr_LevelSelect_Public_Void_0;

		// Token: 0x0400154D RID: 5453
		private static readonly IntPtr NativeMethodInfoPtr_Single_Public_Void_0;

		// Token: 0x0400154E RID: 5454
		private static readonly IntPtr NativeMethodInfoPtr_WorldSelect_Public_Void_0;

		// Token: 0x0400154F RID: 5455
		private static readonly IntPtr NativeMethodInfoPtr_Playco_Private_IEnumerator_0;

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeMethodInfoPtr_SetKeyArr_Private_Void_0;

		// Token: 0x04001551 RID: 5457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200031B RID: 795
		public sealed class OptionsInformation : ValueType
		{
			// Token: 0x0600504E RID: 20558 RVA: 0x0012555C File Offset: 0x0012375C
			// Note: this type is marked as 'beforefieldinit'.
			static OptionsInformation()
			{
				Il2CppClassPointerStore<MainMenu.OptionsInformation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "OptionsInformation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenu.OptionsInformation>.NativeClassPtr);
				MainMenu.OptionsInformation.NativeFieldInfoPtr_language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu.OptionsInformation>.NativeClassPtr, "language");
				MainMenu.OptionsInformation.NativeFieldInfoPtr_volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu.OptionsInformation>.NativeClassPtr, "volume");
				MainMenu.OptionsInformation.NativeFieldInfoPtr_musicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu.OptionsInformation>.NativeClassPtr, "musicVolume");
				MainMenu.OptionsInformation.NativeFieldInfoPtr_fullscreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu.OptionsInformation>.NativeClassPtr, "fullscreen");
				MainMenu.OptionsInformation.NativeFieldInfoPtr_rumble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu.OptionsInformation>.NativeClassPtr, "rumble");
				MainMenu.OptionsInformation.NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu.OptionsInformation>.NativeClassPtr, "resolution");
				MainMenu.OptionsInformation.NativeFieldInfoPtr_resIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu.OptionsInformation>.NativeClassPtr, "resIndex");
			}

			// Token: 0x0600504F RID: 20559 RVA: 0x0002EDF9 File Offset: 0x0002CFF9
			public OptionsInformation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005050 RID: 20560 RVA: 0x0002EE02 File Offset: 0x0002D002
			public OptionsInformation()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenu.OptionsInformation>.NativeClassPtr))
			{
			}

			// Token: 0x17001D45 RID: 7493
			// (get) Token: 0x06005051 RID: 20561 RVA: 0x00125614 File Offset: 0x00123814
			// (set) Token: 0x06005052 RID: 20562 RVA: 0x0002EE14 File Offset: 0x0002D014
			public unsafe string language
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.OptionsInformation.NativeFieldInfoPtr_language);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.OptionsInformation.NativeFieldInfoPtr_language), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001D46 RID: 7494
			// (get) Token: 0x06005053 RID: 20563 RVA: 0x0012563C File Offset: 0x0012383C
			// (set) Token: 0x06005054 RID: 20564 RVA: 0x0002EE33 File Offset: 0x0002D033
			public unsafe float volume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.OptionsInformation.NativeFieldInfoPtr_volume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.OptionsInformation.NativeFieldInfoPtr_volume)) = value;
				}
			}

			// Token: 0x17001D47 RID: 7495
			// (get) Token: 0x06005055 RID: 20565 RVA: 0x00125664 File Offset: 0x00123864
			// (set) Token: 0x06005056 RID: 20566 RVA: 0x0002EE4E File Offset: 0x0002D04E
			public unsafe float musicVolume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.OptionsInformation.NativeFieldInfoPtr_musicVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.OptionsInformation.NativeFieldInfoPtr_musicVolume)) = value;
				}
			}

			// Token: 0x17001D48 RID: 7496
			// (get) Token: 0x06005057 RID: 20567 RVA: 0x0012568C File Offset: 0x0012388C
			// (set) Token: 0x06005058 RID: 20568 RVA: 0x0002EE69 File Offset: 0x0002D069
			public unsafe int fullscreen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.OptionsInformation.NativeFieldInfoPtr_fullscreen);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.OptionsInformation.NativeFieldInfoPtr_fullscreen)) = value;
				}
			}

			// Token: 0x17001D49 RID: 7497
			// (get) Token: 0x06005059 RID: 20569 RVA: 0x001256B4 File Offset: 0x001238B4
			// (set) Token: 0x0600505A RID: 20570 RVA: 0x0002EE84 File Offset: 0x0002D084
			public unsafe int rumble
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.OptionsInformation.NativeFieldInfoPtr_rumble);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.OptionsInformation.NativeFieldInfoPtr_rumble)) = value;
				}
			}

			// Token: 0x17001D4A RID: 7498
			// (get) Token: 0x0600505B RID: 20571 RVA: 0x001256DC File Offset: 0x001238DC
			// (set) Token: 0x0600505C RID: 20572 RVA: 0x0002EE9F File Offset: 0x0002D09F
			public unsafe Resolution resolution
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.OptionsInformation.NativeFieldInfoPtr_resolution);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.OptionsInformation.NativeFieldInfoPtr_resolution)) = value;
				}
			}

			// Token: 0x17001D4B RID: 7499
			// (get) Token: 0x0600505D RID: 20573 RVA: 0x00125704 File Offset: 0x00123904
			// (set) Token: 0x0600505E RID: 20574 RVA: 0x0002EEBA File Offset: 0x0002D0BA
			public unsafe int resIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.OptionsInformation.NativeFieldInfoPtr_resIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu.OptionsInformation.NativeFieldInfoPtr_resIndex)) = value;
				}
			}

			// Token: 0x0400351E RID: 13598
			private static readonly IntPtr NativeFieldInfoPtr_language;

			// Token: 0x0400351F RID: 13599
			private static readonly IntPtr NativeFieldInfoPtr_volume;

			// Token: 0x04003520 RID: 13600
			private static readonly IntPtr NativeFieldInfoPtr_musicVolume;

			// Token: 0x04003521 RID: 13601
			private static readonly IntPtr NativeFieldInfoPtr_fullscreen;

			// Token: 0x04003522 RID: 13602
			private static readonly IntPtr NativeFieldInfoPtr_rumble;

			// Token: 0x04003523 RID: 13603
			private static readonly IntPtr NativeFieldInfoPtr_resolution;

			// Token: 0x04003524 RID: 13604
			private static readonly IntPtr NativeFieldInfoPtr_resIndex;
		}

		// Token: 0x0200031C RID: 796
		[ObfuscatedName("MainMenu+<LoadLevel>d__119")]
		public sealed class _LoadLevel_d__119 : global::Il2CppSystem.Object
		{
			// Token: 0x0600505F RID: 20575 RVA: 0x0012572C File Offset: 0x0012392C
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadLevel_d__119()
			{
				Il2CppClassPointerStore<MainMenu._LoadLevel_d__119>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "<LoadLevel>d__119");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenu._LoadLevel_d__119>.NativeClassPtr);
				MainMenu._LoadLevel_d__119.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._LoadLevel_d__119>.NativeClassPtr, "<>1__state");
				MainMenu._LoadLevel_d__119.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._LoadLevel_d__119>.NativeClassPtr, "<>2__current");
				MainMenu._LoadLevel_d__119.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._LoadLevel_d__119>.NativeClassPtr, "<>4__this");
				MainMenu._LoadLevel_d__119.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._LoadLevel_d__119>.NativeClassPtr, 100666067);
				MainMenu._LoadLevel_d__119.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._LoadLevel_d__119>.NativeClassPtr, 100666068);
				MainMenu._LoadLevel_d__119.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._LoadLevel_d__119>.NativeClassPtr, 100666069);
				MainMenu._LoadLevel_d__119.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._LoadLevel_d__119>.NativeClassPtr, 100666070);
				MainMenu._LoadLevel_d__119.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._LoadLevel_d__119>.NativeClassPtr, 100666071);
				MainMenu._LoadLevel_d__119.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._LoadLevel_d__119>.NativeClassPtr, 100666072);
			}

			// Token: 0x06005060 RID: 20576 RVA: 0x0012580C File Offset: 0x00123A0C
			[CallerCount(0)]
			public unsafe _LoadLevel_d__119(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenu._LoadLevel_d__119>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._LoadLevel_d__119.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005061 RID: 20577 RVA: 0x00125854 File Offset: 0x00123A54
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._LoadLevel_d__119.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005062 RID: 20578 RVA: 0x00125888 File Offset: 0x00123A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69844, XrefRangeEnd = 69858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._LoadLevel_d__119.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D4F RID: 7503
			// (get) Token: 0x06005063 RID: 20579 RVA: 0x001258C4 File Offset: 0x00123AC4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._LoadLevel_d__119.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005064 RID: 20580 RVA: 0x00125904 File Offset: 0x00123B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69858, XrefRangeEnd = 69863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._LoadLevel_d__119.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D50 RID: 7504
			// (get) Token: 0x06005065 RID: 20581 RVA: 0x00125938 File Offset: 0x00123B38
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._LoadLevel_d__119.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005066 RID: 20582 RVA: 0x0002EED5 File Offset: 0x0002D0D5
			public _LoadLevel_d__119(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D4C RID: 7500
			// (get) Token: 0x06005067 RID: 20583 RVA: 0x00125978 File Offset: 0x00123B78
			// (set) Token: 0x06005068 RID: 20584 RVA: 0x0002EEDE File Offset: 0x0002D0DE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._LoadLevel_d__119.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._LoadLevel_d__119.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D4D RID: 7501
			// (get) Token: 0x06005069 RID: 20585 RVA: 0x001259A0 File Offset: 0x00123BA0
			// (set) Token: 0x0600506A RID: 20586 RVA: 0x0002EEF9 File Offset: 0x0002D0F9
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._LoadLevel_d__119.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._LoadLevel_d__119.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D4E RID: 7502
			// (get) Token: 0x0600506B RID: 20587 RVA: 0x001259D0 File Offset: 0x00123BD0
			// (set) Token: 0x0600506C RID: 20588 RVA: 0x0002EF18 File Offset: 0x0002D118
			public unsafe MainMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._LoadLevel_d__119.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._LoadLevel_d__119.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003525 RID: 13605
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003526 RID: 13606
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003527 RID: 13607
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003528 RID: 13608
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003529 RID: 13609
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400352A RID: 13610
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400352B RID: 13611
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400352C RID: 13612
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400352D RID: 13613
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200031D RID: 797
		[ObfuscatedName("MainMenu+<StartMusicDelayed>d__124")]
		public sealed class _StartMusicDelayed_d__124 : global::Il2CppSystem.Object
		{
			// Token: 0x0600506D RID: 20589 RVA: 0x00125A00 File Offset: 0x00123C00
			// Note: this type is marked as 'beforefieldinit'.
			static _StartMusicDelayed_d__124()
			{
				Il2CppClassPointerStore<MainMenu._StartMusicDelayed_d__124>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "<StartMusicDelayed>d__124");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenu._StartMusicDelayed_d__124>.NativeClassPtr);
				MainMenu._StartMusicDelayed_d__124.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._StartMusicDelayed_d__124>.NativeClassPtr, "<>1__state");
				MainMenu._StartMusicDelayed_d__124.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._StartMusicDelayed_d__124>.NativeClassPtr, "<>2__current");
				MainMenu._StartMusicDelayed_d__124.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._StartMusicDelayed_d__124>.NativeClassPtr, "<>4__this");
				MainMenu._StartMusicDelayed_d__124.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._StartMusicDelayed_d__124>.NativeClassPtr, 100666073);
				MainMenu._StartMusicDelayed_d__124.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._StartMusicDelayed_d__124>.NativeClassPtr, 100666074);
				MainMenu._StartMusicDelayed_d__124.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._StartMusicDelayed_d__124>.NativeClassPtr, 100666075);
				MainMenu._StartMusicDelayed_d__124.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._StartMusicDelayed_d__124>.NativeClassPtr, 100666076);
				MainMenu._StartMusicDelayed_d__124.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._StartMusicDelayed_d__124>.NativeClassPtr, 100666077);
				MainMenu._StartMusicDelayed_d__124.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._StartMusicDelayed_d__124>.NativeClassPtr, 100666078);
			}

			// Token: 0x0600506E RID: 20590 RVA: 0x00125AE0 File Offset: 0x00123CE0
			[CallerCount(0)]
			public unsafe _StartMusicDelayed_d__124(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenu._StartMusicDelayed_d__124>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._StartMusicDelayed_d__124.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600506F RID: 20591 RVA: 0x00125B28 File Offset: 0x00123D28
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._StartMusicDelayed_d__124.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005070 RID: 20592 RVA: 0x00125B5C File Offset: 0x00123D5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69863, XrefRangeEnd = 69868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._StartMusicDelayed_d__124.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D54 RID: 7508
			// (get) Token: 0x06005071 RID: 20593 RVA: 0x00125B98 File Offset: 0x00123D98
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._StartMusicDelayed_d__124.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005072 RID: 20594 RVA: 0x00125BD8 File Offset: 0x00123DD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69868, XrefRangeEnd = 69873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._StartMusicDelayed_d__124.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D55 RID: 7509
			// (get) Token: 0x06005073 RID: 20595 RVA: 0x00125C0C File Offset: 0x00123E0C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._StartMusicDelayed_d__124.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005074 RID: 20596 RVA: 0x0002EF37 File Offset: 0x0002D137
			public _StartMusicDelayed_d__124(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D51 RID: 7505
			// (get) Token: 0x06005075 RID: 20597 RVA: 0x00125C4C File Offset: 0x00123E4C
			// (set) Token: 0x06005076 RID: 20598 RVA: 0x0002EF40 File Offset: 0x0002D140
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._StartMusicDelayed_d__124.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._StartMusicDelayed_d__124.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D52 RID: 7506
			// (get) Token: 0x06005077 RID: 20599 RVA: 0x00125C74 File Offset: 0x00123E74
			// (set) Token: 0x06005078 RID: 20600 RVA: 0x0002EF5B File Offset: 0x0002D15B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._StartMusicDelayed_d__124.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._StartMusicDelayed_d__124.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D53 RID: 7507
			// (get) Token: 0x06005079 RID: 20601 RVA: 0x00125CA4 File Offset: 0x00123EA4
			// (set) Token: 0x0600507A RID: 20602 RVA: 0x0002EF7A File Offset: 0x0002D17A
			public unsafe MainMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._StartMusicDelayed_d__124.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._StartMusicDelayed_d__124.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400352E RID: 13614
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400352F RID: 13615
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003530 RID: 13616
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003531 RID: 13617
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003532 RID: 13618
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003533 RID: 13619
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003534 RID: 13620
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003535 RID: 13621
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003536 RID: 13622
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200031E RID: 798
		[ObfuscatedName("MainMenu+<ShowControllerThing>d__125")]
		public sealed class _ShowControllerThing_d__125 : global::Il2CppSystem.Object
		{
			// Token: 0x0600507B RID: 20603 RVA: 0x00125CD4 File Offset: 0x00123ED4
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowControllerThing_d__125()
			{
				Il2CppClassPointerStore<MainMenu._ShowControllerThing_d__125>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "<ShowControllerThing>d__125");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenu._ShowControllerThing_d__125>.NativeClassPtr);
				MainMenu._ShowControllerThing_d__125.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._ShowControllerThing_d__125>.NativeClassPtr, "<>1__state");
				MainMenu._ShowControllerThing_d__125.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._ShowControllerThing_d__125>.NativeClassPtr, "<>2__current");
				MainMenu._ShowControllerThing_d__125.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._ShowControllerThing_d__125>.NativeClassPtr, "<>4__this");
				MainMenu._ShowControllerThing_d__125.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._ShowControllerThing_d__125>.NativeClassPtr, 100666079);
				MainMenu._ShowControllerThing_d__125.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._ShowControllerThing_d__125>.NativeClassPtr, 100666080);
				MainMenu._ShowControllerThing_d__125.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._ShowControllerThing_d__125>.NativeClassPtr, 100666081);
				MainMenu._ShowControllerThing_d__125.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._ShowControllerThing_d__125>.NativeClassPtr, 100666082);
				MainMenu._ShowControllerThing_d__125.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._ShowControllerThing_d__125>.NativeClassPtr, 100666083);
				MainMenu._ShowControllerThing_d__125.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._ShowControllerThing_d__125>.NativeClassPtr, 100666084);
			}

			// Token: 0x0600507C RID: 20604 RVA: 0x00125DB4 File Offset: 0x00123FB4
			[CallerCount(0)]
			public unsafe _ShowControllerThing_d__125(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenu._ShowControllerThing_d__125>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._ShowControllerThing_d__125.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600507D RID: 20605 RVA: 0x00125DFC File Offset: 0x00123FFC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._ShowControllerThing_d__125.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600507E RID: 20606 RVA: 0x00125E30 File Offset: 0x00124030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69873, XrefRangeEnd = 69877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._ShowControllerThing_d__125.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D59 RID: 7513
			// (get) Token: 0x0600507F RID: 20607 RVA: 0x00125E6C File Offset: 0x0012406C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._ShowControllerThing_d__125.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005080 RID: 20608 RVA: 0x00125EAC File Offset: 0x001240AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69877, XrefRangeEnd = 69882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._ShowControllerThing_d__125.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D5A RID: 7514
			// (get) Token: 0x06005081 RID: 20609 RVA: 0x00125EE0 File Offset: 0x001240E0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._ShowControllerThing_d__125.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005082 RID: 20610 RVA: 0x0002EF99 File Offset: 0x0002D199
			public _ShowControllerThing_d__125(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D56 RID: 7510
			// (get) Token: 0x06005083 RID: 20611 RVA: 0x00125F20 File Offset: 0x00124120
			// (set) Token: 0x06005084 RID: 20612 RVA: 0x0002EFA2 File Offset: 0x0002D1A2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._ShowControllerThing_d__125.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._ShowControllerThing_d__125.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D57 RID: 7511
			// (get) Token: 0x06005085 RID: 20613 RVA: 0x00125F48 File Offset: 0x00124148
			// (set) Token: 0x06005086 RID: 20614 RVA: 0x0002EFBD File Offset: 0x0002D1BD
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._ShowControllerThing_d__125.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._ShowControllerThing_d__125.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D58 RID: 7512
			// (get) Token: 0x06005087 RID: 20615 RVA: 0x00125F78 File Offset: 0x00124178
			// (set) Token: 0x06005088 RID: 20616 RVA: 0x0002EFDC File Offset: 0x0002D1DC
			public unsafe MainMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._ShowControllerThing_d__125.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._ShowControllerThing_d__125.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003537 RID: 13623
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003538 RID: 13624
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003539 RID: 13625
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400353A RID: 13626
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400353B RID: 13627
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400353C RID: 13628
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400353D RID: 13629
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400353E RID: 13630
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400353F RID: 13631
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200031F RID: 799
		[ObfuscatedName("MainMenu+<CycleLockState>d__128")]
		public sealed class _CycleLockState_d__128 : global::Il2CppSystem.Object
		{
			// Token: 0x06005089 RID: 20617 RVA: 0x00125FA8 File Offset: 0x001241A8
			// Note: this type is marked as 'beforefieldinit'.
			static _CycleLockState_d__128()
			{
				Il2CppClassPointerStore<MainMenu._CycleLockState_d__128>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "<CycleLockState>d__128");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenu._CycleLockState_d__128>.NativeClassPtr);
				MainMenu._CycleLockState_d__128.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._CycleLockState_d__128>.NativeClassPtr, "<>1__state");
				MainMenu._CycleLockState_d__128.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._CycleLockState_d__128>.NativeClassPtr, "<>2__current");
				MainMenu._CycleLockState_d__128.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._CycleLockState_d__128>.NativeClassPtr, 100666085);
				MainMenu._CycleLockState_d__128.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._CycleLockState_d__128>.NativeClassPtr, 100666086);
				MainMenu._CycleLockState_d__128.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._CycleLockState_d__128>.NativeClassPtr, 100666087);
				MainMenu._CycleLockState_d__128.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._CycleLockState_d__128>.NativeClassPtr, 100666088);
				MainMenu._CycleLockState_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._CycleLockState_d__128>.NativeClassPtr, 100666089);
				MainMenu._CycleLockState_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._CycleLockState_d__128>.NativeClassPtr, 100666090);
			}

			// Token: 0x0600508A RID: 20618 RVA: 0x00126074 File Offset: 0x00124274
			[CallerCount(0)]
			public unsafe _CycleLockState_d__128(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenu._CycleLockState_d__128>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._CycleLockState_d__128.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600508B RID: 20619 RVA: 0x001260BC File Offset: 0x001242BC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._CycleLockState_d__128.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600508C RID: 20620 RVA: 0x001260F0 File Offset: 0x001242F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69882, XrefRangeEnd = 69887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._CycleLockState_d__128.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D5D RID: 7517
			// (get) Token: 0x0600508D RID: 20621 RVA: 0x0012612C File Offset: 0x0012432C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._CycleLockState_d__128.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600508E RID: 20622 RVA: 0x0012616C File Offset: 0x0012436C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69887, XrefRangeEnd = 69892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._CycleLockState_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D5E RID: 7518
			// (get) Token: 0x0600508F RID: 20623 RVA: 0x001261A0 File Offset: 0x001243A0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._CycleLockState_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005090 RID: 20624 RVA: 0x0002EFFB File Offset: 0x0002D1FB
			public _CycleLockState_d__128(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D5B RID: 7515
			// (get) Token: 0x06005091 RID: 20625 RVA: 0x001261E0 File Offset: 0x001243E0
			// (set) Token: 0x06005092 RID: 20626 RVA: 0x0002F004 File Offset: 0x0002D204
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._CycleLockState_d__128.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._CycleLockState_d__128.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D5C RID: 7516
			// (get) Token: 0x06005093 RID: 20627 RVA: 0x00126208 File Offset: 0x00124408
			// (set) Token: 0x06005094 RID: 20628 RVA: 0x0002F01F File Offset: 0x0002D21F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._CycleLockState_d__128.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._CycleLockState_d__128.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003540 RID: 13632
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003541 RID: 13633
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003542 RID: 13634
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003543 RID: 13635
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003544 RID: 13636
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003545 RID: 13637
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003546 RID: 13638
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003547 RID: 13639
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000320 RID: 800
		[ObfuscatedName("MainMenu+<GoBackForLevelSelect>d__138")]
		public sealed class _GoBackForLevelSelect_d__138 : global::Il2CppSystem.Object
		{
			// Token: 0x06005095 RID: 20629 RVA: 0x00126238 File Offset: 0x00124438
			// Note: this type is marked as 'beforefieldinit'.
			static _GoBackForLevelSelect_d__138()
			{
				Il2CppClassPointerStore<MainMenu._GoBackForLevelSelect_d__138>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "<GoBackForLevelSelect>d__138");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenu._GoBackForLevelSelect_d__138>.NativeClassPtr);
				MainMenu._GoBackForLevelSelect_d__138.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._GoBackForLevelSelect_d__138>.NativeClassPtr, "<>1__state");
				MainMenu._GoBackForLevelSelect_d__138.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._GoBackForLevelSelect_d__138>.NativeClassPtr, "<>2__current");
				MainMenu._GoBackForLevelSelect_d__138.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._GoBackForLevelSelect_d__138>.NativeClassPtr, "<>4__this");
				MainMenu._GoBackForLevelSelect_d__138.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._GoBackForLevelSelect_d__138>.NativeClassPtr, 100666091);
				MainMenu._GoBackForLevelSelect_d__138.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._GoBackForLevelSelect_d__138>.NativeClassPtr, 100666092);
				MainMenu._GoBackForLevelSelect_d__138.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._GoBackForLevelSelect_d__138>.NativeClassPtr, 100666093);
				MainMenu._GoBackForLevelSelect_d__138.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._GoBackForLevelSelect_d__138>.NativeClassPtr, 100666094);
				MainMenu._GoBackForLevelSelect_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._GoBackForLevelSelect_d__138>.NativeClassPtr, 100666095);
				MainMenu._GoBackForLevelSelect_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._GoBackForLevelSelect_d__138>.NativeClassPtr, 100666096);
			}

			// Token: 0x06005096 RID: 20630 RVA: 0x00126318 File Offset: 0x00124518
			[CallerCount(0)]
			public unsafe _GoBackForLevelSelect_d__138(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenu._GoBackForLevelSelect_d__138>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._GoBackForLevelSelect_d__138.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005097 RID: 20631 RVA: 0x00126360 File Offset: 0x00124560
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._GoBackForLevelSelect_d__138.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005098 RID: 20632 RVA: 0x00126394 File Offset: 0x00124594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69892, XrefRangeEnd = 69895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._GoBackForLevelSelect_d__138.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D62 RID: 7522
			// (get) Token: 0x06005099 RID: 20633 RVA: 0x001263D0 File Offset: 0x001245D0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._GoBackForLevelSelect_d__138.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600509A RID: 20634 RVA: 0x00126410 File Offset: 0x00124610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69895, XrefRangeEnd = 69900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._GoBackForLevelSelect_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D63 RID: 7523
			// (get) Token: 0x0600509B RID: 20635 RVA: 0x00126444 File Offset: 0x00124644
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._GoBackForLevelSelect_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600509C RID: 20636 RVA: 0x0002F03E File Offset: 0x0002D23E
			public _GoBackForLevelSelect_d__138(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D5F RID: 7519
			// (get) Token: 0x0600509D RID: 20637 RVA: 0x00126484 File Offset: 0x00124684
			// (set) Token: 0x0600509E RID: 20638 RVA: 0x0002F047 File Offset: 0x0002D247
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._GoBackForLevelSelect_d__138.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._GoBackForLevelSelect_d__138.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D60 RID: 7520
			// (get) Token: 0x0600509F RID: 20639 RVA: 0x001264AC File Offset: 0x001246AC
			// (set) Token: 0x060050A0 RID: 20640 RVA: 0x0002F062 File Offset: 0x0002D262
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._GoBackForLevelSelect_d__138.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._GoBackForLevelSelect_d__138.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D61 RID: 7521
			// (get) Token: 0x060050A1 RID: 20641 RVA: 0x001264DC File Offset: 0x001246DC
			// (set) Token: 0x060050A2 RID: 20642 RVA: 0x0002F081 File Offset: 0x0002D281
			public unsafe MainMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._GoBackForLevelSelect_d__138.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._GoBackForLevelSelect_d__138.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003548 RID: 13640
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003549 RID: 13641
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400354A RID: 13642
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400354B RID: 13643
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400354C RID: 13644
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400354D RID: 13645
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400354E RID: 13646
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400354F RID: 13647
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003550 RID: 13648
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000321 RID: 801
		[ObfuscatedName("MainMenu+<TurnOffClearBlack>d__140")]
		public sealed class _TurnOffClearBlack_d__140 : global::Il2CppSystem.Object
		{
			// Token: 0x060050A3 RID: 20643 RVA: 0x0012650C File Offset: 0x0012470C
			// Note: this type is marked as 'beforefieldinit'.
			static _TurnOffClearBlack_d__140()
			{
				Il2CppClassPointerStore<MainMenu._TurnOffClearBlack_d__140>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "<TurnOffClearBlack>d__140");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenu._TurnOffClearBlack_d__140>.NativeClassPtr);
				MainMenu._TurnOffClearBlack_d__140.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._TurnOffClearBlack_d__140>.NativeClassPtr, "<>1__state");
				MainMenu._TurnOffClearBlack_d__140.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._TurnOffClearBlack_d__140>.NativeClassPtr, "<>2__current");
				MainMenu._TurnOffClearBlack_d__140.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._TurnOffClearBlack_d__140>.NativeClassPtr, "<>4__this");
				MainMenu._TurnOffClearBlack_d__140.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._TurnOffClearBlack_d__140>.NativeClassPtr, 100666097);
				MainMenu._TurnOffClearBlack_d__140.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._TurnOffClearBlack_d__140>.NativeClassPtr, 100666098);
				MainMenu._TurnOffClearBlack_d__140.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._TurnOffClearBlack_d__140>.NativeClassPtr, 100666099);
				MainMenu._TurnOffClearBlack_d__140.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._TurnOffClearBlack_d__140>.NativeClassPtr, 100666100);
				MainMenu._TurnOffClearBlack_d__140.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._TurnOffClearBlack_d__140>.NativeClassPtr, 100666101);
				MainMenu._TurnOffClearBlack_d__140.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._TurnOffClearBlack_d__140>.NativeClassPtr, 100666102);
			}

			// Token: 0x060050A4 RID: 20644 RVA: 0x001265EC File Offset: 0x001247EC
			[CallerCount(0)]
			public unsafe _TurnOffClearBlack_d__140(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenu._TurnOffClearBlack_d__140>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._TurnOffClearBlack_d__140.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050A5 RID: 20645 RVA: 0x00126634 File Offset: 0x00124834
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._TurnOffClearBlack_d__140.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050A6 RID: 20646 RVA: 0x00126668 File Offset: 0x00124868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69900, XrefRangeEnd = 69946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._TurnOffClearBlack_d__140.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D67 RID: 7527
			// (get) Token: 0x060050A7 RID: 20647 RVA: 0x001266A4 File Offset: 0x001248A4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._TurnOffClearBlack_d__140.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060050A8 RID: 20648 RVA: 0x001266E4 File Offset: 0x001248E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69946, XrefRangeEnd = 69951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._TurnOffClearBlack_d__140.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D68 RID: 7528
			// (get) Token: 0x060050A9 RID: 20649 RVA: 0x00126718 File Offset: 0x00124918
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._TurnOffClearBlack_d__140.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060050AA RID: 20650 RVA: 0x0002F0A0 File Offset: 0x0002D2A0
			public _TurnOffClearBlack_d__140(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D64 RID: 7524
			// (get) Token: 0x060050AB RID: 20651 RVA: 0x00126758 File Offset: 0x00124958
			// (set) Token: 0x060050AC RID: 20652 RVA: 0x0002F0A9 File Offset: 0x0002D2A9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._TurnOffClearBlack_d__140.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._TurnOffClearBlack_d__140.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D65 RID: 7525
			// (get) Token: 0x060050AD RID: 20653 RVA: 0x00126780 File Offset: 0x00124980
			// (set) Token: 0x060050AE RID: 20654 RVA: 0x0002F0C4 File Offset: 0x0002D2C4
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._TurnOffClearBlack_d__140.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._TurnOffClearBlack_d__140.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D66 RID: 7526
			// (get) Token: 0x060050AF RID: 20655 RVA: 0x001267B0 File Offset: 0x001249B0
			// (set) Token: 0x060050B0 RID: 20656 RVA: 0x0002F0E3 File Offset: 0x0002D2E3
			public unsafe MainMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._TurnOffClearBlack_d__140.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._TurnOffClearBlack_d__140.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003551 RID: 13649
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003552 RID: 13650
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003553 RID: 13651
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003554 RID: 13652
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003555 RID: 13653
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003556 RID: 13654
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003557 RID: 13655
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003558 RID: 13656
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003559 RID: 13657
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000322 RID: 802
		[ObfuscatedName("MainMenu+<GiveInputBack>d__145")]
		public sealed class _GiveInputBack_d__145 : global::Il2CppSystem.Object
		{
			// Token: 0x060050B1 RID: 20657 RVA: 0x001267E0 File Offset: 0x001249E0
			// Note: this type is marked as 'beforefieldinit'.
			static _GiveInputBack_d__145()
			{
				Il2CppClassPointerStore<MainMenu._GiveInputBack_d__145>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "<GiveInputBack>d__145");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenu._GiveInputBack_d__145>.NativeClassPtr);
				MainMenu._GiveInputBack_d__145.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._GiveInputBack_d__145>.NativeClassPtr, "<>1__state");
				MainMenu._GiveInputBack_d__145.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._GiveInputBack_d__145>.NativeClassPtr, "<>2__current");
				MainMenu._GiveInputBack_d__145.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._GiveInputBack_d__145>.NativeClassPtr, "time");
				MainMenu._GiveInputBack_d__145.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._GiveInputBack_d__145>.NativeClassPtr, "<>4__this");
				MainMenu._GiveInputBack_d__145.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._GiveInputBack_d__145>.NativeClassPtr, 100666103);
				MainMenu._GiveInputBack_d__145.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._GiveInputBack_d__145>.NativeClassPtr, 100666104);
				MainMenu._GiveInputBack_d__145.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._GiveInputBack_d__145>.NativeClassPtr, 100666105);
				MainMenu._GiveInputBack_d__145.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._GiveInputBack_d__145>.NativeClassPtr, 100666106);
				MainMenu._GiveInputBack_d__145.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._GiveInputBack_d__145>.NativeClassPtr, 100666107);
				MainMenu._GiveInputBack_d__145.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._GiveInputBack_d__145>.NativeClassPtr, 100666108);
			}

			// Token: 0x060050B2 RID: 20658 RVA: 0x001268D4 File Offset: 0x00124AD4
			[CallerCount(0)]
			public unsafe _GiveInputBack_d__145(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenu._GiveInputBack_d__145>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._GiveInputBack_d__145.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050B3 RID: 20659 RVA: 0x0012691C File Offset: 0x00124B1C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._GiveInputBack_d__145.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050B4 RID: 20660 RVA: 0x00126950 File Offset: 0x00124B50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69951, XrefRangeEnd = 69954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._GiveInputBack_d__145.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D6D RID: 7533
			// (get) Token: 0x060050B5 RID: 20661 RVA: 0x0012698C File Offset: 0x00124B8C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._GiveInputBack_d__145.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060050B6 RID: 20662 RVA: 0x001269CC File Offset: 0x00124BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69954, XrefRangeEnd = 69959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._GiveInputBack_d__145.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D6E RID: 7534
			// (get) Token: 0x060050B7 RID: 20663 RVA: 0x00126A00 File Offset: 0x00124C00
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._GiveInputBack_d__145.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060050B8 RID: 20664 RVA: 0x0002F102 File Offset: 0x0002D302
			public _GiveInputBack_d__145(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D69 RID: 7529
			// (get) Token: 0x060050B9 RID: 20665 RVA: 0x00126A40 File Offset: 0x00124C40
			// (set) Token: 0x060050BA RID: 20666 RVA: 0x0002F10B File Offset: 0x0002D30B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._GiveInputBack_d__145.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._GiveInputBack_d__145.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D6A RID: 7530
			// (get) Token: 0x060050BB RID: 20667 RVA: 0x00126A68 File Offset: 0x00124C68
			// (set) Token: 0x060050BC RID: 20668 RVA: 0x0002F126 File Offset: 0x0002D326
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._GiveInputBack_d__145.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._GiveInputBack_d__145.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D6B RID: 7531
			// (get) Token: 0x060050BD RID: 20669 RVA: 0x00126A98 File Offset: 0x00124C98
			// (set) Token: 0x060050BE RID: 20670 RVA: 0x0002F145 File Offset: 0x0002D345
			public unsafe float time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._GiveInputBack_d__145.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._GiveInputBack_d__145.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x17001D6C RID: 7532
			// (get) Token: 0x060050BF RID: 20671 RVA: 0x00126AC0 File Offset: 0x00124CC0
			// (set) Token: 0x060050C0 RID: 20672 RVA: 0x0002F160 File Offset: 0x0002D360
			public unsafe MainMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._GiveInputBack_d__145.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._GiveInputBack_d__145.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400355A RID: 13658
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400355B RID: 13659
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400355C RID: 13660
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x0400355D RID: 13661
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400355E RID: 13662
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400355F RID: 13663
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003560 RID: 13664
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003561 RID: 13665
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003562 RID: 13666
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003563 RID: 13667
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000323 RID: 803
		[ObfuscatedName("MainMenu+<TurnOffAlbumTextInASec>d__146")]
		public sealed class _TurnOffAlbumTextInASec_d__146 : global::Il2CppSystem.Object
		{
			// Token: 0x060050C1 RID: 20673 RVA: 0x00126AF0 File Offset: 0x00124CF0
			// Note: this type is marked as 'beforefieldinit'.
			static _TurnOffAlbumTextInASec_d__146()
			{
				Il2CppClassPointerStore<MainMenu._TurnOffAlbumTextInASec_d__146>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "<TurnOffAlbumTextInASec>d__146");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenu._TurnOffAlbumTextInASec_d__146>.NativeClassPtr);
				MainMenu._TurnOffAlbumTextInASec_d__146.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._TurnOffAlbumTextInASec_d__146>.NativeClassPtr, "<>1__state");
				MainMenu._TurnOffAlbumTextInASec_d__146.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._TurnOffAlbumTextInASec_d__146>.NativeClassPtr, "<>2__current");
				MainMenu._TurnOffAlbumTextInASec_d__146.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._TurnOffAlbumTextInASec_d__146>.NativeClassPtr, "<>4__this");
				MainMenu._TurnOffAlbumTextInASec_d__146.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._TurnOffAlbumTextInASec_d__146>.NativeClassPtr, 100666109);
				MainMenu._TurnOffAlbumTextInASec_d__146.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._TurnOffAlbumTextInASec_d__146>.NativeClassPtr, 100666110);
				MainMenu._TurnOffAlbumTextInASec_d__146.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._TurnOffAlbumTextInASec_d__146>.NativeClassPtr, 100666111);
				MainMenu._TurnOffAlbumTextInASec_d__146.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._TurnOffAlbumTextInASec_d__146>.NativeClassPtr, 100666112);
				MainMenu._TurnOffAlbumTextInASec_d__146.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._TurnOffAlbumTextInASec_d__146>.NativeClassPtr, 100666113);
				MainMenu._TurnOffAlbumTextInASec_d__146.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._TurnOffAlbumTextInASec_d__146>.NativeClassPtr, 100666114);
			}

			// Token: 0x060050C2 RID: 20674 RVA: 0x00126BD0 File Offset: 0x00124DD0
			[CallerCount(0)]
			public unsafe _TurnOffAlbumTextInASec_d__146(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenu._TurnOffAlbumTextInASec_d__146>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._TurnOffAlbumTextInASec_d__146.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050C3 RID: 20675 RVA: 0x00126C18 File Offset: 0x00124E18
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._TurnOffAlbumTextInASec_d__146.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050C4 RID: 20676 RVA: 0x00126C4C File Offset: 0x00124E4C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._TurnOffAlbumTextInASec_d__146.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D72 RID: 7538
			// (get) Token: 0x060050C5 RID: 20677 RVA: 0x00126C88 File Offset: 0x00124E88
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._TurnOffAlbumTextInASec_d__146.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060050C6 RID: 20678 RVA: 0x00126CC8 File Offset: 0x00124EC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69959, XrefRangeEnd = 69964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._TurnOffAlbumTextInASec_d__146.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D73 RID: 7539
			// (get) Token: 0x060050C7 RID: 20679 RVA: 0x00126CFC File Offset: 0x00124EFC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._TurnOffAlbumTextInASec_d__146.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060050C8 RID: 20680 RVA: 0x0002F17F File Offset: 0x0002D37F
			public _TurnOffAlbumTextInASec_d__146(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D6F RID: 7535
			// (get) Token: 0x060050C9 RID: 20681 RVA: 0x00126D3C File Offset: 0x00124F3C
			// (set) Token: 0x060050CA RID: 20682 RVA: 0x0002F188 File Offset: 0x0002D388
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._TurnOffAlbumTextInASec_d__146.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._TurnOffAlbumTextInASec_d__146.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D70 RID: 7536
			// (get) Token: 0x060050CB RID: 20683 RVA: 0x00126D64 File Offset: 0x00124F64
			// (set) Token: 0x060050CC RID: 20684 RVA: 0x0002F1A3 File Offset: 0x0002D3A3
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._TurnOffAlbumTextInASec_d__146.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._TurnOffAlbumTextInASec_d__146.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D71 RID: 7537
			// (get) Token: 0x060050CD RID: 20685 RVA: 0x00126D94 File Offset: 0x00124F94
			// (set) Token: 0x060050CE RID: 20686 RVA: 0x0002F1C2 File Offset: 0x0002D3C2
			public unsafe MainMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._TurnOffAlbumTextInASec_d__146.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._TurnOffAlbumTextInASec_d__146.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003564 RID: 13668
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003565 RID: 13669
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003566 RID: 13670
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003567 RID: 13671
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003568 RID: 13672
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003569 RID: 13673
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400356A RID: 13674
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400356B RID: 13675
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400356C RID: 13676
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000324 RID: 804
		[ObfuscatedName("MainMenu+<FlipThisAlbumUpInASec>d__148")]
		public sealed class _FlipThisAlbumUpInASec_d__148 : global::Il2CppSystem.Object
		{
			// Token: 0x060050CF RID: 20687 RVA: 0x00126DC4 File Offset: 0x00124FC4
			// Note: this type is marked as 'beforefieldinit'.
			static _FlipThisAlbumUpInASec_d__148()
			{
				Il2CppClassPointerStore<MainMenu._FlipThisAlbumUpInASec_d__148>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "<FlipThisAlbumUpInASec>d__148");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenu._FlipThisAlbumUpInASec_d__148>.NativeClassPtr);
				MainMenu._FlipThisAlbumUpInASec_d__148.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._FlipThisAlbumUpInASec_d__148>.NativeClassPtr, "<>1__state");
				MainMenu._FlipThisAlbumUpInASec_d__148.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._FlipThisAlbumUpInASec_d__148>.NativeClassPtr, "<>2__current");
				MainMenu._FlipThisAlbumUpInASec_d__148.NativeFieldInfoPtr_album = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._FlipThisAlbumUpInASec_d__148>.NativeClassPtr, "album");
				MainMenu._FlipThisAlbumUpInASec_d__148.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._FlipThisAlbumUpInASec_d__148>.NativeClassPtr, "<>4__this");
				MainMenu._FlipThisAlbumUpInASec_d__148.NativeFieldInfoPtr_clearing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._FlipThisAlbumUpInASec_d__148>.NativeClassPtr, "clearing");
				MainMenu._FlipThisAlbumUpInASec_d__148.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._FlipThisAlbumUpInASec_d__148>.NativeClassPtr, 100666115);
				MainMenu._FlipThisAlbumUpInASec_d__148.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._FlipThisAlbumUpInASec_d__148>.NativeClassPtr, 100666116);
				MainMenu._FlipThisAlbumUpInASec_d__148.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._FlipThisAlbumUpInASec_d__148>.NativeClassPtr, 100666117);
				MainMenu._FlipThisAlbumUpInASec_d__148.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._FlipThisAlbumUpInASec_d__148>.NativeClassPtr, 100666118);
				MainMenu._FlipThisAlbumUpInASec_d__148.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._FlipThisAlbumUpInASec_d__148>.NativeClassPtr, 100666119);
				MainMenu._FlipThisAlbumUpInASec_d__148.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._FlipThisAlbumUpInASec_d__148>.NativeClassPtr, 100666120);
			}

			// Token: 0x060050D0 RID: 20688 RVA: 0x00126ECC File Offset: 0x001250CC
			[CallerCount(0)]
			public unsafe _FlipThisAlbumUpInASec_d__148(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenu._FlipThisAlbumUpInASec_d__148>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._FlipThisAlbumUpInASec_d__148.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050D1 RID: 20689 RVA: 0x00126F14 File Offset: 0x00125114
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._FlipThisAlbumUpInASec_d__148.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050D2 RID: 20690 RVA: 0x00126F48 File Offset: 0x00125148
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69964, XrefRangeEnd = 69974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._FlipThisAlbumUpInASec_d__148.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D79 RID: 7545
			// (get) Token: 0x060050D3 RID: 20691 RVA: 0x00126F84 File Offset: 0x00125184
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._FlipThisAlbumUpInASec_d__148.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060050D4 RID: 20692 RVA: 0x00126FC4 File Offset: 0x001251C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69974, XrefRangeEnd = 69979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._FlipThisAlbumUpInASec_d__148.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D7A RID: 7546
			// (get) Token: 0x060050D5 RID: 20693 RVA: 0x00126FF8 File Offset: 0x001251F8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._FlipThisAlbumUpInASec_d__148.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060050D6 RID: 20694 RVA: 0x0002F1E1 File Offset: 0x0002D3E1
			public _FlipThisAlbumUpInASec_d__148(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D74 RID: 7540
			// (get) Token: 0x060050D7 RID: 20695 RVA: 0x00127038 File Offset: 0x00125238
			// (set) Token: 0x060050D8 RID: 20696 RVA: 0x0002F1EA File Offset: 0x0002D3EA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._FlipThisAlbumUpInASec_d__148.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._FlipThisAlbumUpInASec_d__148.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D75 RID: 7541
			// (get) Token: 0x060050D9 RID: 20697 RVA: 0x00127060 File Offset: 0x00125260
			// (set) Token: 0x060050DA RID: 20698 RVA: 0x0002F205 File Offset: 0x0002D405
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._FlipThisAlbumUpInASec_d__148.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._FlipThisAlbumUpInASec_d__148.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D76 RID: 7542
			// (get) Token: 0x060050DB RID: 20699 RVA: 0x00127090 File Offset: 0x00125290
			// (set) Token: 0x060050DC RID: 20700 RVA: 0x0002F224 File Offset: 0x0002D424
			public unsafe GameObject album
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._FlipThisAlbumUpInASec_d__148.NativeFieldInfoPtr_album);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._FlipThisAlbumUpInASec_d__148.NativeFieldInfoPtr_album), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D77 RID: 7543
			// (get) Token: 0x060050DD RID: 20701 RVA: 0x001270C0 File Offset: 0x001252C0
			// (set) Token: 0x060050DE RID: 20702 RVA: 0x0002F243 File Offset: 0x0002D443
			public unsafe MainMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._FlipThisAlbumUpInASec_d__148.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._FlipThisAlbumUpInASec_d__148.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D78 RID: 7544
			// (get) Token: 0x060050DF RID: 20703 RVA: 0x001270F0 File Offset: 0x001252F0
			// (set) Token: 0x060050E0 RID: 20704 RVA: 0x0002F262 File Offset: 0x0002D462
			public unsafe bool clearing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._FlipThisAlbumUpInASec_d__148.NativeFieldInfoPtr_clearing);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._FlipThisAlbumUpInASec_d__148.NativeFieldInfoPtr_clearing)) = value;
				}
			}

			// Token: 0x0400356D RID: 13677
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400356E RID: 13678
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400356F RID: 13679
			private static readonly IntPtr NativeFieldInfoPtr_album;

			// Token: 0x04003570 RID: 13680
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003571 RID: 13681
			private static readonly IntPtr NativeFieldInfoPtr_clearing;

			// Token: 0x04003572 RID: 13682
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003573 RID: 13683
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003574 RID: 13684
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003575 RID: 13685
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003576 RID: 13686
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003577 RID: 13687
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000325 RID: 805
		[ObfuscatedName("MainMenu+<ClearAlbum>d__149")]
		public sealed class _ClearAlbum_d__149 : global::Il2CppSystem.Object
		{
			// Token: 0x060050E1 RID: 20705 RVA: 0x00127118 File Offset: 0x00125318
			// Note: this type is marked as 'beforefieldinit'.
			static _ClearAlbum_d__149()
			{
				Il2CppClassPointerStore<MainMenu._ClearAlbum_d__149>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "<ClearAlbum>d__149");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenu._ClearAlbum_d__149>.NativeClassPtr);
				MainMenu._ClearAlbum_d__149.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._ClearAlbum_d__149>.NativeClassPtr, "<>1__state");
				MainMenu._ClearAlbum_d__149.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._ClearAlbum_d__149>.NativeClassPtr, "<>2__current");
				MainMenu._ClearAlbum_d__149.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._ClearAlbum_d__149>.NativeClassPtr, "<>4__this");
				MainMenu._ClearAlbum_d__149.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._ClearAlbum_d__149>.NativeClassPtr, 100666121);
				MainMenu._ClearAlbum_d__149.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._ClearAlbum_d__149>.NativeClassPtr, 100666122);
				MainMenu._ClearAlbum_d__149.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._ClearAlbum_d__149>.NativeClassPtr, 100666123);
				MainMenu._ClearAlbum_d__149.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._ClearAlbum_d__149>.NativeClassPtr, 100666124);
				MainMenu._ClearAlbum_d__149.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._ClearAlbum_d__149>.NativeClassPtr, 100666125);
				MainMenu._ClearAlbum_d__149.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._ClearAlbum_d__149>.NativeClassPtr, 100666126);
			}

			// Token: 0x060050E2 RID: 20706 RVA: 0x001271F8 File Offset: 0x001253F8
			[CallerCount(0)]
			public unsafe _ClearAlbum_d__149(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenu._ClearAlbum_d__149>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._ClearAlbum_d__149.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050E3 RID: 20707 RVA: 0x00127240 File Offset: 0x00125440
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._ClearAlbum_d__149.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050E4 RID: 20708 RVA: 0x00127274 File Offset: 0x00125474
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69979, XrefRangeEnd = 70019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._ClearAlbum_d__149.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D7E RID: 7550
			// (get) Token: 0x060050E5 RID: 20709 RVA: 0x001272B0 File Offset: 0x001254B0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._ClearAlbum_d__149.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060050E6 RID: 20710 RVA: 0x001272F0 File Offset: 0x001254F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70019, XrefRangeEnd = 70024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._ClearAlbum_d__149.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D7F RID: 7551
			// (get) Token: 0x060050E7 RID: 20711 RVA: 0x00127324 File Offset: 0x00125524
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._ClearAlbum_d__149.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060050E8 RID: 20712 RVA: 0x0002F27D File Offset: 0x0002D47D
			public _ClearAlbum_d__149(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D7B RID: 7547
			// (get) Token: 0x060050E9 RID: 20713 RVA: 0x00127364 File Offset: 0x00125564
			// (set) Token: 0x060050EA RID: 20714 RVA: 0x0002F286 File Offset: 0x0002D486
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._ClearAlbum_d__149.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._ClearAlbum_d__149.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D7C RID: 7548
			// (get) Token: 0x060050EB RID: 20715 RVA: 0x0012738C File Offset: 0x0012558C
			// (set) Token: 0x060050EC RID: 20716 RVA: 0x0002F2A1 File Offset: 0x0002D4A1
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._ClearAlbum_d__149.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._ClearAlbum_d__149.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D7D RID: 7549
			// (get) Token: 0x060050ED RID: 20717 RVA: 0x001273BC File Offset: 0x001255BC
			// (set) Token: 0x060050EE RID: 20718 RVA: 0x0002F2C0 File Offset: 0x0002D4C0
			public unsafe MainMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._ClearAlbum_d__149.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._ClearAlbum_d__149.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003578 RID: 13688
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003579 RID: 13689
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400357A RID: 13690
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400357B RID: 13691
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400357C RID: 13692
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400357D RID: 13693
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400357E RID: 13694
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400357F RID: 13695
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003580 RID: 13696
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000326 RID: 806
		[ObfuscatedName("MainMenu+<PanDownForAlbumIntro>d__154")]
		public sealed class _PanDownForAlbumIntro_d__154 : global::Il2CppSystem.Object
		{
			// Token: 0x060050EF RID: 20719 RVA: 0x001273EC File Offset: 0x001255EC
			// Note: this type is marked as 'beforefieldinit'.
			static _PanDownForAlbumIntro_d__154()
			{
				Il2CppClassPointerStore<MainMenu._PanDownForAlbumIntro_d__154>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "<PanDownForAlbumIntro>d__154");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenu._PanDownForAlbumIntro_d__154>.NativeClassPtr);
				MainMenu._PanDownForAlbumIntro_d__154.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._PanDownForAlbumIntro_d__154>.NativeClassPtr, "<>1__state");
				MainMenu._PanDownForAlbumIntro_d__154.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._PanDownForAlbumIntro_d__154>.NativeClassPtr, "<>2__current");
				MainMenu._PanDownForAlbumIntro_d__154.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._PanDownForAlbumIntro_d__154>.NativeClassPtr, "<>4__this");
				MainMenu._PanDownForAlbumIntro_d__154.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._PanDownForAlbumIntro_d__154>.NativeClassPtr, 100666127);
				MainMenu._PanDownForAlbumIntro_d__154.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._PanDownForAlbumIntro_d__154>.NativeClassPtr, 100666128);
				MainMenu._PanDownForAlbumIntro_d__154.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._PanDownForAlbumIntro_d__154>.NativeClassPtr, 100666129);
				MainMenu._PanDownForAlbumIntro_d__154.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._PanDownForAlbumIntro_d__154>.NativeClassPtr, 100666130);
				MainMenu._PanDownForAlbumIntro_d__154.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._PanDownForAlbumIntro_d__154>.NativeClassPtr, 100666131);
				MainMenu._PanDownForAlbumIntro_d__154.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._PanDownForAlbumIntro_d__154>.NativeClassPtr, 100666132);
			}

			// Token: 0x060050F0 RID: 20720 RVA: 0x001274CC File Offset: 0x001256CC
			[CallerCount(0)]
			public unsafe _PanDownForAlbumIntro_d__154(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenu._PanDownForAlbumIntro_d__154>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._PanDownForAlbumIntro_d__154.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050F1 RID: 20721 RVA: 0x00127514 File Offset: 0x00125714
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._PanDownForAlbumIntro_d__154.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050F2 RID: 20722 RVA: 0x00127548 File Offset: 0x00125748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70024, XrefRangeEnd = 70034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._PanDownForAlbumIntro_d__154.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D83 RID: 7555
			// (get) Token: 0x060050F3 RID: 20723 RVA: 0x00127584 File Offset: 0x00125784
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._PanDownForAlbumIntro_d__154.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060050F4 RID: 20724 RVA: 0x001275C4 File Offset: 0x001257C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70034, XrefRangeEnd = 70039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._PanDownForAlbumIntro_d__154.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D84 RID: 7556
			// (get) Token: 0x060050F5 RID: 20725 RVA: 0x001275F8 File Offset: 0x001257F8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._PanDownForAlbumIntro_d__154.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060050F6 RID: 20726 RVA: 0x0002F2DF File Offset: 0x0002D4DF
			public _PanDownForAlbumIntro_d__154(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D80 RID: 7552
			// (get) Token: 0x060050F7 RID: 20727 RVA: 0x00127638 File Offset: 0x00125838
			// (set) Token: 0x060050F8 RID: 20728 RVA: 0x0002F2E8 File Offset: 0x0002D4E8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._PanDownForAlbumIntro_d__154.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._PanDownForAlbumIntro_d__154.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D81 RID: 7553
			// (get) Token: 0x060050F9 RID: 20729 RVA: 0x00127660 File Offset: 0x00125860
			// (set) Token: 0x060050FA RID: 20730 RVA: 0x0002F303 File Offset: 0x0002D503
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._PanDownForAlbumIntro_d__154.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._PanDownForAlbumIntro_d__154.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D82 RID: 7554
			// (get) Token: 0x060050FB RID: 20731 RVA: 0x00127690 File Offset: 0x00125890
			// (set) Token: 0x060050FC RID: 20732 RVA: 0x0002F322 File Offset: 0x0002D522
			public unsafe MainMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._PanDownForAlbumIntro_d__154.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._PanDownForAlbumIntro_d__154.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003581 RID: 13697
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003582 RID: 13698
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003583 RID: 13699
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003584 RID: 13700
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003585 RID: 13701
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003586 RID: 13702
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003587 RID: 13703
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003588 RID: 13704
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003589 RID: 13705
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000327 RID: 807
		[ObfuscatedName("MainMenu+<Pan>d__155")]
		public sealed class _Pan_d__155 : global::Il2CppSystem.Object
		{
			// Token: 0x060050FD RID: 20733 RVA: 0x001276C0 File Offset: 0x001258C0
			// Note: this type is marked as 'beforefieldinit'.
			static _Pan_d__155()
			{
				Il2CppClassPointerStore<MainMenu._Pan_d__155>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "<Pan>d__155");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenu._Pan_d__155>.NativeClassPtr);
				MainMenu._Pan_d__155.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._Pan_d__155>.NativeClassPtr, "<>1__state");
				MainMenu._Pan_d__155.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._Pan_d__155>.NativeClassPtr, "<>2__current");
				MainMenu._Pan_d__155.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._Pan_d__155>.NativeClassPtr, "<>4__this");
				MainMenu._Pan_d__155.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._Pan_d__155>.NativeClassPtr, "up");
				MainMenu._Pan_d__155.NativeFieldInfoPtr__startPt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._Pan_d__155>.NativeClassPtr, "<startPt>5__2");
				MainMenu._Pan_d__155.NativeFieldInfoPtr__targetPt_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._Pan_d__155>.NativeClassPtr, "<targetPt>5__3");
				MainMenu._Pan_d__155.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._Pan_d__155>.NativeClassPtr, 100666133);
				MainMenu._Pan_d__155.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._Pan_d__155>.NativeClassPtr, 100666134);
				MainMenu._Pan_d__155.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._Pan_d__155>.NativeClassPtr, 100666135);
				MainMenu._Pan_d__155.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._Pan_d__155>.NativeClassPtr, 100666136);
				MainMenu._Pan_d__155.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._Pan_d__155>.NativeClassPtr, 100666137);
				MainMenu._Pan_d__155.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._Pan_d__155>.NativeClassPtr, 100666138);
			}

			// Token: 0x060050FE RID: 20734 RVA: 0x001277DC File Offset: 0x001259DC
			[CallerCount(0)]
			public unsafe _Pan_d__155(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenu._Pan_d__155>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._Pan_d__155.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050FF RID: 20735 RVA: 0x00127824 File Offset: 0x00125A24
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._Pan_d__155.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005100 RID: 20736 RVA: 0x00127858 File Offset: 0x00125A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70039, XrefRangeEnd = 70057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._Pan_d__155.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D8B RID: 7563
			// (get) Token: 0x06005101 RID: 20737 RVA: 0x00127894 File Offset: 0x00125A94
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._Pan_d__155.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005102 RID: 20738 RVA: 0x001278D4 File Offset: 0x00125AD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70057, XrefRangeEnd = 70062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._Pan_d__155.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D8C RID: 7564
			// (get) Token: 0x06005103 RID: 20739 RVA: 0x00127908 File Offset: 0x00125B08
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._Pan_d__155.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005104 RID: 20740 RVA: 0x0002F341 File Offset: 0x0002D541
			public _Pan_d__155(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D85 RID: 7557
			// (get) Token: 0x06005105 RID: 20741 RVA: 0x00127948 File Offset: 0x00125B48
			// (set) Token: 0x06005106 RID: 20742 RVA: 0x0002F34A File Offset: 0x0002D54A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Pan_d__155.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Pan_d__155.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D86 RID: 7558
			// (get) Token: 0x06005107 RID: 20743 RVA: 0x00127970 File Offset: 0x00125B70
			// (set) Token: 0x06005108 RID: 20744 RVA: 0x0002F365 File Offset: 0x0002D565
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Pan_d__155.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Pan_d__155.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D87 RID: 7559
			// (get) Token: 0x06005109 RID: 20745 RVA: 0x001279A0 File Offset: 0x00125BA0
			// (set) Token: 0x0600510A RID: 20746 RVA: 0x0002F384 File Offset: 0x0002D584
			public unsafe MainMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Pan_d__155.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Pan_d__155.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D88 RID: 7560
			// (get) Token: 0x0600510B RID: 20747 RVA: 0x001279D0 File Offset: 0x00125BD0
			// (set) Token: 0x0600510C RID: 20748 RVA: 0x0002F3A3 File Offset: 0x0002D5A3
			public unsafe bool up
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Pan_d__155.NativeFieldInfoPtr_up);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Pan_d__155.NativeFieldInfoPtr_up)) = value;
				}
			}

			// Token: 0x17001D89 RID: 7561
			// (get) Token: 0x0600510D RID: 20749 RVA: 0x001279F8 File Offset: 0x00125BF8
			// (set) Token: 0x0600510E RID: 20750 RVA: 0x0002F3BE File Offset: 0x0002D5BE
			public unsafe float _startPt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Pan_d__155.NativeFieldInfoPtr__startPt_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Pan_d__155.NativeFieldInfoPtr__startPt_5__2)) = value;
				}
			}

			// Token: 0x17001D8A RID: 7562
			// (get) Token: 0x0600510F RID: 20751 RVA: 0x00127A20 File Offset: 0x00125C20
			// (set) Token: 0x06005110 RID: 20752 RVA: 0x0002F3D9 File Offset: 0x0002D5D9
			public unsafe float _targetPt_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Pan_d__155.NativeFieldInfoPtr__targetPt_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Pan_d__155.NativeFieldInfoPtr__targetPt_5__3)) = value;
				}
			}

			// Token: 0x0400358A RID: 13706
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400358B RID: 13707
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400358C RID: 13708
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400358D RID: 13709
			private static readonly IntPtr NativeFieldInfoPtr_up;

			// Token: 0x0400358E RID: 13710
			private static readonly IntPtr NativeFieldInfoPtr__startPt_5__2;

			// Token: 0x0400358F RID: 13711
			private static readonly IntPtr NativeFieldInfoPtr__targetPt_5__3;

			// Token: 0x04003590 RID: 13712
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003591 RID: 13713
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003592 RID: 13714
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003593 RID: 13715
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003594 RID: 13716
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003595 RID: 13717
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000328 RID: 808
		[ObfuscatedName("MainMenu+<SwitchHard>d__156")]
		public sealed class _SwitchHard_d__156 : global::Il2CppSystem.Object
		{
			// Token: 0x06005111 RID: 20753 RVA: 0x00127A48 File Offset: 0x00125C48
			// Note: this type is marked as 'beforefieldinit'.
			static _SwitchHard_d__156()
			{
				Il2CppClassPointerStore<MainMenu._SwitchHard_d__156>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "<SwitchHard>d__156");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenu._SwitchHard_d__156>.NativeClassPtr);
				MainMenu._SwitchHard_d__156.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._SwitchHard_d__156>.NativeClassPtr, "<>1__state");
				MainMenu._SwitchHard_d__156.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._SwitchHard_d__156>.NativeClassPtr, "<>2__current");
				MainMenu._SwitchHard_d__156.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._SwitchHard_d__156>.NativeClassPtr, "<>4__this");
				MainMenu._SwitchHard_d__156.NativeFieldInfoPtr__boop_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._SwitchHard_d__156>.NativeClassPtr, "<boop>5__2");
				MainMenu._SwitchHard_d__156.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._SwitchHard_d__156>.NativeClassPtr, 100666139);
				MainMenu._SwitchHard_d__156.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._SwitchHard_d__156>.NativeClassPtr, 100666140);
				MainMenu._SwitchHard_d__156.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._SwitchHard_d__156>.NativeClassPtr, 100666141);
				MainMenu._SwitchHard_d__156.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._SwitchHard_d__156>.NativeClassPtr, 100666142);
				MainMenu._SwitchHard_d__156.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._SwitchHard_d__156>.NativeClassPtr, 100666143);
				MainMenu._SwitchHard_d__156.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._SwitchHard_d__156>.NativeClassPtr, 100666144);
			}

			// Token: 0x06005112 RID: 20754 RVA: 0x00127B3C File Offset: 0x00125D3C
			[CallerCount(0)]
			public unsafe _SwitchHard_d__156(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenu._SwitchHard_d__156>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._SwitchHard_d__156.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005113 RID: 20755 RVA: 0x00127B84 File Offset: 0x00125D84
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._SwitchHard_d__156.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005114 RID: 20756 RVA: 0x00127BB8 File Offset: 0x00125DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70062, XrefRangeEnd = 70064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._SwitchHard_d__156.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D91 RID: 7569
			// (get) Token: 0x06005115 RID: 20757 RVA: 0x00127BF4 File Offset: 0x00125DF4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._SwitchHard_d__156.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005116 RID: 20758 RVA: 0x00127C34 File Offset: 0x00125E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70064, XrefRangeEnd = 70069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._SwitchHard_d__156.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D92 RID: 7570
			// (get) Token: 0x06005117 RID: 20759 RVA: 0x00127C68 File Offset: 0x00125E68
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._SwitchHard_d__156.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005118 RID: 20760 RVA: 0x0002F3F4 File Offset: 0x0002D5F4
			public _SwitchHard_d__156(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D8D RID: 7565
			// (get) Token: 0x06005119 RID: 20761 RVA: 0x00127CA8 File Offset: 0x00125EA8
			// (set) Token: 0x0600511A RID: 20762 RVA: 0x0002F3FD File Offset: 0x0002D5FD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._SwitchHard_d__156.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._SwitchHard_d__156.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D8E RID: 7566
			// (get) Token: 0x0600511B RID: 20763 RVA: 0x00127CD0 File Offset: 0x00125ED0
			// (set) Token: 0x0600511C RID: 20764 RVA: 0x0002F418 File Offset: 0x0002D618
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._SwitchHard_d__156.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._SwitchHard_d__156.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D8F RID: 7567
			// (get) Token: 0x0600511D RID: 20765 RVA: 0x00127D00 File Offset: 0x00125F00
			// (set) Token: 0x0600511E RID: 20766 RVA: 0x0002F437 File Offset: 0x0002D637
			public unsafe MainMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._SwitchHard_d__156.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._SwitchHard_d__156.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D90 RID: 7568
			// (get) Token: 0x0600511F RID: 20767 RVA: 0x00127D30 File Offset: 0x00125F30
			// (set) Token: 0x06005120 RID: 20768 RVA: 0x0002F456 File Offset: 0x0002D656
			public unsafe bool _boop_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._SwitchHard_d__156.NativeFieldInfoPtr__boop_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._SwitchHard_d__156.NativeFieldInfoPtr__boop_5__2)) = value;
				}
			}

			// Token: 0x04003596 RID: 13718
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003597 RID: 13719
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003598 RID: 13720
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003599 RID: 13721
			private static readonly IntPtr NativeFieldInfoPtr__boop_5__2;

			// Token: 0x0400359A RID: 13722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400359B RID: 13723
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400359C RID: 13724
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400359D RID: 13725
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400359E RID: 13726
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400359F RID: 13727
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000329 RID: 809
		[ObfuscatedName("MainMenu+<Playco>d__160")]
		public sealed class _Playco_d__160 : global::Il2CppSystem.Object
		{
			// Token: 0x06005121 RID: 20769 RVA: 0x00127D58 File Offset: 0x00125F58
			// Note: this type is marked as 'beforefieldinit'.
			static _Playco_d__160()
			{
				Il2CppClassPointerStore<MainMenu._Playco_d__160>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenu>.NativeClassPtr, "<Playco>d__160");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenu._Playco_d__160>.NativeClassPtr);
				MainMenu._Playco_d__160.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._Playco_d__160>.NativeClassPtr, "<>1__state");
				MainMenu._Playco_d__160.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._Playco_d__160>.NativeClassPtr, "<>2__current");
				MainMenu._Playco_d__160.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenu._Playco_d__160>.NativeClassPtr, "<>4__this");
				MainMenu._Playco_d__160.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._Playco_d__160>.NativeClassPtr, 100666145);
				MainMenu._Playco_d__160.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._Playco_d__160>.NativeClassPtr, 100666146);
				MainMenu._Playco_d__160.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._Playco_d__160>.NativeClassPtr, 100666147);
				MainMenu._Playco_d__160.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._Playco_d__160>.NativeClassPtr, 100666148);
				MainMenu._Playco_d__160.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._Playco_d__160>.NativeClassPtr, 100666149);
				MainMenu._Playco_d__160.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenu._Playco_d__160>.NativeClassPtr, 100666150);
			}

			// Token: 0x06005122 RID: 20770 RVA: 0x00127E38 File Offset: 0x00126038
			[CallerCount(0)]
			public unsafe _Playco_d__160(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenu._Playco_d__160>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._Playco_d__160.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005123 RID: 20771 RVA: 0x00127E80 File Offset: 0x00126080
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._Playco_d__160.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005124 RID: 20772 RVA: 0x00127EB4 File Offset: 0x001260B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70069, XrefRangeEnd = 70081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._Playco_d__160.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D96 RID: 7574
			// (get) Token: 0x06005125 RID: 20773 RVA: 0x00127EF0 File Offset: 0x001260F0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._Playco_d__160.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005126 RID: 20774 RVA: 0x00127F30 File Offset: 0x00126130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70081, XrefRangeEnd = 70086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._Playco_d__160.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D97 RID: 7575
			// (get) Token: 0x06005127 RID: 20775 RVA: 0x00127F64 File Offset: 0x00126164
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenu._Playco_d__160.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005128 RID: 20776 RVA: 0x0002F471 File Offset: 0x0002D671
			public _Playco_d__160(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D93 RID: 7571
			// (get) Token: 0x06005129 RID: 20777 RVA: 0x00127FA4 File Offset: 0x001261A4
			// (set) Token: 0x0600512A RID: 20778 RVA: 0x0002F47A File Offset: 0x0002D67A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Playco_d__160.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Playco_d__160.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D94 RID: 7572
			// (get) Token: 0x0600512B RID: 20779 RVA: 0x00127FCC File Offset: 0x001261CC
			// (set) Token: 0x0600512C RID: 20780 RVA: 0x0002F495 File Offset: 0x0002D695
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Playco_d__160.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Playco_d__160.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D95 RID: 7573
			// (get) Token: 0x0600512D RID: 20781 RVA: 0x00127FFC File Offset: 0x001261FC
			// (set) Token: 0x0600512E RID: 20782 RVA: 0x0002F4B4 File Offset: 0x0002D6B4
			public unsafe MainMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Playco_d__160.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenu._Playco_d__160.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040035A0 RID: 13728
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040035A1 RID: 13729
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040035A2 RID: 13730
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040035A3 RID: 13731
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040035A4 RID: 13732
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035A5 RID: 13733
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040035A6 RID: 13734
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040035A7 RID: 13735
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035A8 RID: 13736
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
