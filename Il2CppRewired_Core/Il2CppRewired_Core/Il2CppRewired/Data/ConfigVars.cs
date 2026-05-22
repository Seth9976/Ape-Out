using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Config;
using Il2CppRewired.Platforms;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppRewired.Data
{
	// Token: 0x0200009D RID: 157
	[Serializable]
	public sealed class ConfigVars : Object
	{
		// Token: 0x06001296 RID: 4758 RVA: 0x000724E4 File Offset: 0x000706E4
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigVars()
		{
			Il2CppClassPointerStore<ConfigVars>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data", "ConfigVars");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr);
			ConfigVars.NativeFieldInfoPtr_updateLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "updateLoop");
			ConfigVars.NativeFieldInfoPtr_alwaysUseUnityInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "alwaysUseUnityInput");
			ConfigVars.NativeFieldInfoPtr_windowsStandalonePrimaryInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "windowsStandalonePrimaryInputSource");
			ConfigVars.NativeFieldInfoPtr_osx_primaryInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "osx_primaryInputSource");
			ConfigVars.NativeFieldInfoPtr_linux_primaryInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "linux_primaryInputSource");
			ConfigVars.NativeFieldInfoPtr_windowsUWP_primaryInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "windowsUWP_primaryInputSource");
			ConfigVars.NativeFieldInfoPtr_xboxOne_primaryInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "xboxOne_primaryInputSource");
			ConfigVars.NativeFieldInfoPtr_gameCoreXboxOne_primaryInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "gameCoreXboxOne_primaryInputSource");
			ConfigVars.NativeFieldInfoPtr_gameCoreScarlett_primaryInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "gameCoreScarlett_primaryInputSource");
			ConfigVars.NativeFieldInfoPtr_ps4_primaryInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "ps4_primaryInputSource");
			ConfigVars.NativeFieldInfoPtr_ps5_primaryInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "ps5_primaryInputSource");
			ConfigVars.NativeFieldInfoPtr_webGL_primaryInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "webGL_primaryInputSource");
			ConfigVars.NativeFieldInfoPtr_stadia_primaryInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "stadia_primaryInputSource");
			ConfigVars.NativeFieldInfoPtr_useXInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "useXInput");
			ConfigVars.NativeFieldInfoPtr_useNativeMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "useNativeMouse");
			ConfigVars.NativeFieldInfoPtr_useEnhancedDeviceSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "useEnhancedDeviceSupport");
			ConfigVars.NativeFieldInfoPtr_windowsStandalone_useSteamRawInputControllerWorkaround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "windowsStandalone_useSteamRawInputControllerWorkaround");
			ConfigVars.NativeFieldInfoPtr_osxStandalone_useEnhancedDeviceSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "osxStandalone_useEnhancedDeviceSupport");
			ConfigVars.NativeFieldInfoPtr_android_supportUnknownGamepads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "android_supportUnknownGamepads");
			ConfigVars.NativeFieldInfoPtr_ps4_assignJoysticksByPS4JoyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "ps4_assignJoysticksByPS4JoyId");
			ConfigVars.NativeFieldInfoPtr_useSteamControllerSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "useSteamControllerSupport");
			ConfigVars.NativeFieldInfoPtr_logToScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "logToScreen");
			ConfigVars.NativeFieldInfoPtr_runInEditMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "runInEditMode");
			ConfigVars.NativeFieldInfoPtr_allowInputInEditorSceneView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "allowInputInEditorSceneView");
			ConfigVars.NativeFieldInfoPtr_platformVars_windowsStandalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_windowsStandalone");
			ConfigVars.NativeFieldInfoPtr_platformVars_linuxStandalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_linuxStandalone");
			ConfigVars.NativeFieldInfoPtr_platformVars_osxStandalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_osxStandalone");
			ConfigVars.NativeFieldInfoPtr_platformVars_windows8Store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_windows8Store");
			ConfigVars.NativeFieldInfoPtr_platformVars_windowsUWP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_windowsUWP");
			ConfigVars.NativeFieldInfoPtr_platformVars_iOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_iOS");
			ConfigVars.NativeFieldInfoPtr_platformVars_tvOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_tvOS");
			ConfigVars.NativeFieldInfoPtr_platformVars_android = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_android");
			ConfigVars.NativeFieldInfoPtr_platformVars_ps3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_ps3");
			ConfigVars.NativeFieldInfoPtr_platformVars_ps4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_ps4");
			ConfigVars.NativeFieldInfoPtr_platformVars_ps5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_ps5");
			ConfigVars.NativeFieldInfoPtr_platformVars_psVita = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_psVita");
			ConfigVars.NativeFieldInfoPtr_platformVars_xbox360 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_xbox360");
			ConfigVars.NativeFieldInfoPtr_platformVars_xboxOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_xboxOne");
			ConfigVars.NativeFieldInfoPtr_platformVars_gameCoreXboxOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_gameCoreXboxOne");
			ConfigVars.NativeFieldInfoPtr_platformVars_gameCoreScarlett = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_gameCoreScarlett");
			ConfigVars.NativeFieldInfoPtr_platformVars_wii = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_wii");
			ConfigVars.NativeFieldInfoPtr_platformVars_wiiu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_wiiu");
			ConfigVars.NativeFieldInfoPtr_platformVars_switch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_switch");
			ConfigVars.NativeFieldInfoPtr_platformVars_webGL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_webGL");
			ConfigVars.NativeFieldInfoPtr_platformVars_stadia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_stadia");
			ConfigVars.NativeFieldInfoPtr_platformVars_unknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "platformVars_unknown");
			ConfigVars.NativeFieldInfoPtr_maxJoysticksPerPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "maxJoysticksPerPlayer");
			ConfigVars.NativeFieldInfoPtr_autoAssignJoysticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "autoAssignJoysticks");
			ConfigVars.NativeFieldInfoPtr_assignJoysticksToPlayingPlayersOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "assignJoysticksToPlayingPlayersOnly");
			ConfigVars.NativeFieldInfoPtr_distributeJoysticksEvenly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "distributeJoysticksEvenly");
			ConfigVars.NativeFieldInfoPtr_reassignJoystickToPreviousOwnerOnReconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "reassignJoystickToPreviousOwnerOnReconnect");
			ConfigVars.NativeFieldInfoPtr_defaultJoystickAxis2DDeadZoneType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "defaultJoystickAxis2DDeadZoneType");
			ConfigVars.NativeFieldInfoPtr_defaultJoystickAxis2DSensitivityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "defaultJoystickAxis2DSensitivityType");
			ConfigVars.NativeFieldInfoPtr_defaultAxisSensitivityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "defaultAxisSensitivityType");
			ConfigVars.NativeFieldInfoPtr_force4WayHats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "force4WayHats");
			ConfigVars.NativeFieldInfoPtr_throttleCalibrationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "throttleCalibrationMode");
			ConfigVars.NativeFieldInfoPtr_activateActionButtonsOnNegativeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "activateActionButtonsOnNegativeValue");
			ConfigVars.NativeFieldInfoPtr_deferControllerConnectedEventsOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "deferControllerConnectedEventsOnStart");
			ConfigVars.NativeFieldInfoPtr_logLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "logLevel");
			ConfigVars.NativeFieldInfoPtr_editorSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "editorSettings");
			ConfigVars.NativeFieldInfoPtr___platformVarsDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "__platformVarsDict");
			ConfigVars.NativeFieldInfoPtr___getSetPlatformVariableDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "__getSetPlatformVariableDict");
			ConfigVars.NativeFieldInfoPtr___configVarsValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "__configVarsValues");
			ConfigVars.NativeFieldInfoPtr___valueDelegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "__valueDelegates");
			ConfigVars.NativeMethodInfoPtr_get_platformVarsDict_Private_get_Dictionary_2_Int32_OrbKWFwOjGZrOMASFSOZfbpzlJv_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666419);
			ConfigVars.NativeMethodInfoPtr_get_getSetPlatformVariableDict_Private_get_Dictionary_2_Int32_BeskwhpONorGAgNsHIAihRdquCY_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666420);
			ConfigVars.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666421);
			ConfigVars.NativeMethodInfoPtr_DoesPlatformUseFallback_Internal_Boolean_Platform_WebplayerPlatform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666422);
			ConfigVars.NativeMethodInfoPtr_DoesPlatformUseSDL2_Internal_Boolean_Platform_WebplayerPlatform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666423);
			ConfigVars.NativeMethodInfoPtr_GetDebugConfigSettings_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666424);
			ConfigVars.NativeMethodInfoPtr_GetPlatformVarsRelPath_Internal_String_Platform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666425);
			ConfigVars.NativeMethodInfoPtr_GetPlatformVars_Internal_PlatformVars_Platform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666426);
			ConfigVars.NativeMethodInfoPtr_Editor_GetAllSerializedPlatformVar_Internal_T_AllPlatformVar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666427);
			ConfigVars.NativeMethodInfoPtr_Editor_SetAllSerializedPlatformVar_Internal_Void_AllPlatformVar_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666428);
			ConfigVars.NativeMethodInfoPtr_GetPlatformVar_disableKeyboard_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666429);
			ConfigVars.NativeMethodInfoPtr_SetPlatformVar_disableKeyboard_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666430);
			ConfigVars.NativeMethodInfoPtr_GetPlatformVar_ignoreInputWhenAppNotInFocus_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666431);
			ConfigVars.NativeMethodInfoPtr_GetPlatformVar_useEnhancedDeviceSupport_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666432);
			ConfigVars.NativeMethodInfoPtr_GetPlatformVar_useNativeMouse_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666433);
			ConfigVars.NativeMethodInfoPtr_GetPlatformVar_useNativeKeyboard_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666434);
			ConfigVars.NativeMethodInfoPtr_GetPlatformVar_joystickRefreshRate_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666435);
			ConfigVars.NativeMethodInfoPtr_GetPlatformVar_assignJoysticksBySystemId_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666436);
			ConfigVars.NativeMethodInfoPtr_SetPlatformVar_ignoreInputWhenAppNotInFocus_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666437);
			ConfigVars.NativeMethodInfoPtr_SetPlatformVar_useEnhancedDeviceSupport_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666438);
			ConfigVars.NativeMethodInfoPtr_SetPlatformVar_useNativeMouse_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666439);
			ConfigVars.NativeMethodInfoPtr_SetPlatformVar_useNativeKeyboard_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666440);
			ConfigVars.NativeMethodInfoPtr_SetPlatformVar_joystickRefreshRate_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666441);
			ConfigVars.NativeMethodInfoPtr_SetPlatformVar_assignJoysticksBySystemId_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666442);
			ConfigVars.NativeMethodInfoPtr_GetPlatformVars_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666443);
			ConfigVars.NativeMethodInfoPtr_GetOrCreatePlatformVars_Private_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666444);
			ConfigVars.NativeMethodInfoPtr_GetAllSerializedPlatformVar_multiBool_Private_MultiBoolValue_AllPlatformVar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666445);
			ConfigVars.NativeMethodInfoPtr_IsEditModeInputSupported_Internal_Boolean_ControllerType_EditorPlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666446);
			ConfigVars.NativeMethodInfoPtr_Rewired_Data_IConfigVars_Internal_get_values_Private_Virtual_Final_New_get_KeyedGetSetValueStore_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666447);
			ConfigVars.NativeMethodInfoPtr_get_valueDelegates_Private_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666448);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__1_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666449);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__2_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666450);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__3_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666451);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__4_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666452);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__5_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666453);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__6_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666454);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__7_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666455);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__8_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666456);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__9_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666457);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__a_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666458);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__b_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666459);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__c_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666460);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__d_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666461);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__e_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666462);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__f_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666463);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__10_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666464);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__11_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666465);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__12_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666466);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__13_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666467);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__14_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666468);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__15_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666469);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__16_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666470);
			ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__17_Private_PlatformVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666471);
			ConfigVars.NativeMethodInfoPtr__get_getSetPlatformVariableDict_b__19_Private_Object_Platform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666472);
			ConfigVars.NativeMethodInfoPtr__get_getSetPlatformVariableDict_b__1a_Private_Void_Platform_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666473);
			ConfigVars.NativeMethodInfoPtr__get_getSetPlatformVariableDict_b__1b_Private_Object_Platform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666474);
			ConfigVars.NativeMethodInfoPtr__get_getSetPlatformVariableDict_b__1c_Private_Void_Platform_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666475);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__1e_Private_UpdateLoopSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666476);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__1f_Private_Void_UpdateLoopSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666477);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__20_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666478);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__21_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666479);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__22_Private_WindowsStandalonePrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666480);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__23_Private_Void_WindowsStandalonePrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666481);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__24_Private_OSXStandalonePrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666482);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__25_Private_Void_OSXStandalonePrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666483);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__26_Private_LinuxStandalonePrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666484);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__27_Private_Void_LinuxStandalonePrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666485);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__28_Private_WindowsUWPPrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666486);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__29_Private_Void_WindowsUWPPrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666487);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__2a_Private_XboxOnePrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666488);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__2b_Private_Void_XboxOnePrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666489);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__2c_Private_GameCoreXboxOnePrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666490);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__2d_Private_Void_GameCoreXboxOnePrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666491);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__2e_Private_GameCoreScarlettPrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666492);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__2f_Private_Void_GameCoreScarlettPrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666493);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__30_Private_PS4PrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666494);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__31_Private_Void_PS4PrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666495);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__32_Private_PS5PrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666496);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__33_Private_Void_PS5PrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666497);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__34_Private_WebGLPrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666498);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__35_Private_Void_WebGLPrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666499);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__36_Private_StadiaPrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666500);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__37_Private_Void_StadiaPrimaryInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666501);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__38_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666502);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__39_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666503);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__3a_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666504);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__3b_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666505);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__3c_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666506);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__3d_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666507);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__3e_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666508);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__3f_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666509);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__40_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666510);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__41_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666511);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__42_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666512);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__43_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666513);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__44_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666514);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__45_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666515);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__46_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666516);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__47_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666517);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__48_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666518);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__49_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666519);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__4a_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666520);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__4b_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666521);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__4c_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666522);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__4d_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666523);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__4e_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666524);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__4f_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666525);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__50_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666526);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__51_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666527);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__52_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666528);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__53_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666529);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__54_Private_DeadZone2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666530);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__55_Private_Void_DeadZone2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666531);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__56_Private_AxisSensitivity2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666532);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__57_Private_Void_AxisSensitivity2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666533);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__58_Private_AxisSensitivityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666534);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__59_Private_Void_AxisSensitivityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666535);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__5a_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666536);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__5b_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666537);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__5c_Private_ThrottleCalibrationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666538);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__5d_Private_Void_ThrottleCalibrationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666539);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__5e_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666540);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__5f_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666541);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__60_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666542);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__61_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666543);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__62_Private_LogLevelFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666544);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__63_Private_Void_LogLevelFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666545);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__64_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666546);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__65_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666547);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__66_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666548);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__67_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666549);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__68_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666550);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__69_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666551);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__6a_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666552);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__6b_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666553);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__6c_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666554);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__6d_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666555);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__6e_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666556);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__6f_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666557);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__70_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666558);
			ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__71_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, 100666559);
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x00073518 File Offset: 0x00071718
		public unsafe Dictionary<int, ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv> platformVarsDict
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 262400, RefRangeEnd = 262406, XrefRangeStart = 262160, XrefRangeEnd = 262400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_get_platformVarsDict_Private_get_Dictionary_2_Int32_OrbKWFwOjGZrOMASFSOZfbpzlJv_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv>>(intPtr3) : null;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x00073558 File Offset: 0x00071758
		public unsafe Dictionary<int, ConfigVars.BeskwhpONorGAgNsHIAihRdquCY> getSetPlatformVariableDict
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 262441, RefRangeEnd = 262445, XrefRangeStart = 262406, XrefRangeEnd = 262441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_get_getSetPlatformVariableDict_Private_get_Dictionary_2_Int32_BeskwhpONorGAgNsHIAihRdquCY_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ConfigVars.BeskwhpONorGAgNsHIAihRdquCY>>(intPtr3) : null;
			}
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00073598 File Offset: 0x00071798
		[CallerCount(0)]
		public unsafe ConfigVars()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x000735D4 File Offset: 0x000717D4
		[CallerCount(0)]
		public unsafe bool DoesPlatformUseFallback(Il2CppRewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref webplayerPlatform;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEditor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_DoesPlatformUseFallback_Internal_Boolean_Platform_WebplayerPlatform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0007363C File Offset: 0x0007183C
		[CallerCount(0)]
		public unsafe bool DoesPlatformUseSDL2(Il2CppRewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref webplayerPlatform;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEditor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_DoesPlatformUseSDL2_Internal_Boolean_Platform_WebplayerPlatform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x000736A4 File Offset: 0x000718A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262712, RefRangeEnd = 262713, XrefRangeStart = 262445, XrefRangeEnd = 262712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDebugConfigSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_GetDebugConfigSettings_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x000736DC File Offset: 0x000718DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262713, XrefRangeEnd = 262720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPlatformVarsRelPath(Il2CppRewired.Platforms.Platform platform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_GetPlatformVarsRelPath_Internal_String_Platform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00073720 File Offset: 0x00071920
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 262737, RefRangeEnd = 262753, XrefRangeStart = 262720, XrefRangeEnd = 262737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars GetPlatformVars(Il2CppRewired.Platforms.Platform platform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_GetPlatformVars_Internal_PlatformVars_Platform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
			}
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0007376C File Offset: 0x0007196C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262753, XrefRangeEnd = 262765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Editor_GetAllSerializedPlatformVar<T>(ConfigVars.AllPlatformVar var)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref var;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.MethodInfoStoreGeneric_Editor_GetAllSerializedPlatformVar_Internal_T_AllPlatformVar_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x000737B4 File Offset: 0x000719B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262765, XrefRangeEnd = 262785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Editor_SetAllSerializedPlatformVar(ConfigVars.AllPlatformVar var, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref var;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_Editor_SetAllSerializedPlatformVar_Internal_Void_AllPlatformVar_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00073804 File Offset: 0x00071A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262785, XrefRangeEnd = 262786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetPlatformVar_disableKeyboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_GetPlatformVar_disableKeyboard_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00073840 File Offset: 0x00071A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262786, XrefRangeEnd = 262787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetPlatformVar_disableKeyboard(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_SetPlatformVar_disableKeyboard_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0007388C File Offset: 0x00071A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262787, XrefRangeEnd = 262788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetPlatformVar_ignoreInputWhenAppNotInFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_GetPlatformVar_ignoreInputWhenAppNotInFocus_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x000738C8 File Offset: 0x00071AC8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 262792, RefRangeEnd = 262798, XrefRangeStart = 262788, XrefRangeEnd = 262792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetPlatformVar_useEnhancedDeviceSupport()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_GetPlatformVar_useEnhancedDeviceSupport_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00073904 File Offset: 0x00071B04
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 262804, RefRangeEnd = 262811, XrefRangeStart = 262798, XrefRangeEnd = 262804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetPlatformVar_useNativeMouse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_GetPlatformVar_useNativeMouse_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x00073940 File Offset: 0x00071B40
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 262819, RefRangeEnd = 262824, XrefRangeStart = 262811, XrefRangeEnd = 262819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetPlatformVar_useNativeKeyboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_GetPlatformVar_useNativeKeyboard_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x0007397C File Offset: 0x00071B7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 262831, RefRangeEnd = 262835, XrefRangeStart = 262824, XrefRangeEnd = 262831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlatformVar_joystickRefreshRate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_GetPlatformVar_joystickRefreshRate_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x000739B8 File Offset: 0x00071BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262835, XrefRangeEnd = 262842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetPlatformVar_assignJoysticksBySystemId()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_GetPlatformVar_assignJoysticksBySystemId_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x000739F4 File Offset: 0x00071BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262842, XrefRangeEnd = 262844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetPlatformVar_ignoreInputWhenAppNotInFocus(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_SetPlatformVar_ignoreInputWhenAppNotInFocus_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00073A40 File Offset: 0x00071C40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262848, RefRangeEnd = 262850, XrefRangeStart = 262844, XrefRangeEnd = 262848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetPlatformVar_useEnhancedDeviceSupport(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_SetPlatformVar_useEnhancedDeviceSupport_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00073A8C File Offset: 0x00071C8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262854, RefRangeEnd = 262856, XrefRangeStart = 262850, XrefRangeEnd = 262854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetPlatformVar_useNativeMouse(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_SetPlatformVar_useNativeMouse_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00073AD8 File Offset: 0x00071CD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262866, RefRangeEnd = 262868, XrefRangeStart = 262856, XrefRangeEnd = 262866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetPlatformVar_useNativeKeyboard(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_SetPlatformVar_useNativeKeyboard_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00073B24 File Offset: 0x00071D24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262875, RefRangeEnd = 262877, XrefRangeStart = 262868, XrefRangeEnd = 262875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetPlatformVar_joystickRefreshRate(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_SetPlatformVar_joystickRefreshRate_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00073B70 File Offset: 0x00071D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262877, XrefRangeEnd = 262884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetPlatformVar_assignJoysticksBySystemId(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_SetPlatformVar_assignJoysticksBySystemId_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00073BBC File Offset: 0x00071DBC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 262893, RefRangeEnd = 262909, XrefRangeStart = 262884, XrefRangeEnd = 262893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars GetPlatformVars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_GetPlatformVars_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00073BFC File Offset: 0x00071DFC
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 262909, RefRangeEnd = 262933, XrefRangeStart = 262909, XrefRangeEnd = 262909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetOrCreatePlatformVars<T>(ref T var) where T : ConfigVars.PlatformVars, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(var);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConfigVars.MethodInfoStoreGeneric_GetOrCreatePlatformVars_Private_T_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				var = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00073C60 File Offset: 0x00071E60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262970, RefRangeEnd = 262971, XrefRangeStart = 262933, XrefRangeEnd = 262970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiBoolValue GetAllSerializedPlatformVar_multiBool(ConfigVars.AllPlatformVar var)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref var;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_GetAllSerializedPlatformVar_multiBool_Private_MultiBoolValue_AllPlatformVar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00073CAC File Offset: 0x00071EAC
		[CallerCount(0)]
		public unsafe bool IsEditModeInputSupported(ControllerType controllerType, EditorPlatform editorPlatform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref editorPlatform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_IsEditModeInputSupported_Internal_Boolean_ControllerType_EditorPlatform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x00073D04 File Offset: 0x00071F04
		public unsafe KeyedGetSetValueStore<string> Rewired.Data.IConfigVars_Internal.values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262971, XrefRangeEnd = 262976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_Rewired_Data_IConfigVars_Internal_get_values_Private_Virtual_Final_New_get_KeyedGetSetValueStore_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<KeyedGetSetValueStore<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x00073D44 File Offset: 0x00071F44
		public unsafe Dictionary<string, Object> valueDelegates
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 263808, RefRangeEnd = 263809, XrefRangeStart = 262976, XrefRangeEnd = 263808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr_get_valueDelegates_Private_get_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00073D84 File Offset: 0x00071F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263809, XrefRangeEnd = 263812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__1_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00073DC4 File Offset: 0x00071FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263812, XrefRangeEnd = 263815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__2_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00073E04 File Offset: 0x00072004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263815, XrefRangeEnd = 263818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__3_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00073E44 File Offset: 0x00072044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263818, XrefRangeEnd = 263821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__4_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00073E84 File Offset: 0x00072084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263821, XrefRangeEnd = 263824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__5_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x00073EC4 File Offset: 0x000720C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263824, XrefRangeEnd = 263827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__6_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x00073F04 File Offset: 0x00072104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263827, XrefRangeEnd = 263830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__7_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00073F44 File Offset: 0x00072144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263830, XrefRangeEnd = 263833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__8_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00073F84 File Offset: 0x00072184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263833, XrefRangeEnd = 263836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__9()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__9_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00073FC4 File Offset: 0x000721C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263836, XrefRangeEnd = 263839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__a()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__a_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00074004 File Offset: 0x00072204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263839, XrefRangeEnd = 263842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__b()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__b_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00074044 File Offset: 0x00072244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263842, XrefRangeEnd = 263845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__c()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__c_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00074084 File Offset: 0x00072284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263845, XrefRangeEnd = 263848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__d()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__d_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x000740C4 File Offset: 0x000722C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263848, XrefRangeEnd = 263851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__e()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__e_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00074104 File Offset: 0x00072304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263851, XrefRangeEnd = 263854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__f()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__f_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00074144 File Offset: 0x00072344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263854, XrefRangeEnd = 263857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__10()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__10_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00074184 File Offset: 0x00072384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263857, XrefRangeEnd = 263860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__11()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__11_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x000741C4 File Offset: 0x000723C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263860, XrefRangeEnd = 263863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__12()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__12_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x00074204 File Offset: 0x00072404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263863, XrefRangeEnd = 263866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__13()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__13_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x00074244 File Offset: 0x00072444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263866, XrefRangeEnd = 263869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__14()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__14_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x00074284 File Offset: 0x00072484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263869, XrefRangeEnd = 263872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__15()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__15_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x000742C4 File Offset: 0x000724C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263872, XrefRangeEnd = 263875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__16()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__16_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x00074304 File Offset: 0x00072504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263875, XrefRangeEnd = 263878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigVars.PlatformVars _get_platformVarsDict_b__17()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_platformVarsDict_b__17_Private_PlatformVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr3) : null;
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x00074344 File Offset: 0x00072544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263878, XrefRangeEnd = 263882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _get_getSetPlatformVariableDict_b__19(Il2CppRewired.Platforms.Platform p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_getSetPlatformVariableDict_b__19_Private_Object_Platform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00074390 File Offset: 0x00072590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263882, XrefRangeEnd = 263885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _get_getSetPlatformVariableDict_b__1a(Il2CppRewired.Platforms.Platform platform, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_getSetPlatformVariableDict_b__1a_Private_Void_Platform_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x000743E0 File Offset: 0x000725E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263885, XrefRangeEnd = 263889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _get_getSetPlatformVariableDict_b__1b(Il2CppRewired.Platforms.Platform platform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_getSetPlatformVariableDict_b__1b_Private_Object_Platform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0007442C File Offset: 0x0007262C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263889, XrefRangeEnd = 263892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _get_getSetPlatformVariableDict_b__1c(Il2CppRewired.Platforms.Platform platform, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_getSetPlatformVariableDict_b__1c_Private_Void_Platform_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0007447C File Offset: 0x0007267C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateLoopSetting _get_valueDelegates_b__1e()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__1e_Private_UpdateLoopSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x000744B8 File Offset: 0x000726B8
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__1f(UpdateLoopSetting x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__1f_Private_Void_UpdateLoopSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x000744F8 File Offset: 0x000726F8
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__20()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__20_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00074534 File Offset: 0x00072734
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__21(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__21_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00074574 File Offset: 0x00072774
		[CallerCount(0)]
		public unsafe WindowsStandalonePrimaryInputSource _get_valueDelegates_b__22()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__22_Private_WindowsStandalonePrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x000745B0 File Offset: 0x000727B0
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__23(WindowsStandalonePrimaryInputSource x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__23_Private_Void_WindowsStandalonePrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x000745F0 File Offset: 0x000727F0
		[CallerCount(0)]
		public unsafe OSXStandalonePrimaryInputSource _get_valueDelegates_b__24()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__24_Private_OSXStandalonePrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0007462C File Offset: 0x0007282C
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__25(OSXStandalonePrimaryInputSource x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__25_Private_Void_OSXStandalonePrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x0007466C File Offset: 0x0007286C
		[CallerCount(0)]
		public unsafe LinuxStandalonePrimaryInputSource _get_valueDelegates_b__26()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__26_Private_LinuxStandalonePrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x000746A8 File Offset: 0x000728A8
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__27(LinuxStandalonePrimaryInputSource x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__27_Private_Void_LinuxStandalonePrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x000746E8 File Offset: 0x000728E8
		[CallerCount(0)]
		public unsafe WindowsUWPPrimaryInputSource _get_valueDelegates_b__28()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__28_Private_WindowsUWPPrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x00074724 File Offset: 0x00072924
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__29(WindowsUWPPrimaryInputSource x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__29_Private_Void_WindowsUWPPrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00074764 File Offset: 0x00072964
		[CallerCount(0)]
		public unsafe XboxOnePrimaryInputSource _get_valueDelegates_b__2a()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__2a_Private_XboxOnePrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x000747A0 File Offset: 0x000729A0
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__2b(XboxOnePrimaryInputSource x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__2b_Private_Void_XboxOnePrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x000747E0 File Offset: 0x000729E0
		[CallerCount(0)]
		public unsafe GameCoreXboxOnePrimaryInputSource _get_valueDelegates_b__2c()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__2c_Private_GameCoreXboxOnePrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0007481C File Offset: 0x00072A1C
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__2d(GameCoreXboxOnePrimaryInputSource x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__2d_Private_Void_GameCoreXboxOnePrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0007485C File Offset: 0x00072A5C
		[CallerCount(0)]
		public unsafe GameCoreScarlettPrimaryInputSource _get_valueDelegates_b__2e()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__2e_Private_GameCoreScarlettPrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00074898 File Offset: 0x00072A98
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__2f(GameCoreScarlettPrimaryInputSource x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__2f_Private_Void_GameCoreScarlettPrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x000748D8 File Offset: 0x00072AD8
		[CallerCount(0)]
		public unsafe PS4PrimaryInputSource _get_valueDelegates_b__30()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__30_Private_PS4PrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00074914 File Offset: 0x00072B14
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__31(PS4PrimaryInputSource x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__31_Private_Void_PS4PrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00074954 File Offset: 0x00072B54
		[CallerCount(0)]
		public unsafe PS5PrimaryInputSource _get_valueDelegates_b__32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__32_Private_PS5PrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00074990 File Offset: 0x00072B90
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__33(PS5PrimaryInputSource x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__33_Private_Void_PS5PrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x000749D0 File Offset: 0x00072BD0
		[CallerCount(0)]
		public unsafe WebGLPrimaryInputSource _get_valueDelegates_b__34()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__34_Private_WebGLPrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00074A0C File Offset: 0x00072C0C
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__35(WebGLPrimaryInputSource x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__35_Private_Void_WebGLPrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00074A4C File Offset: 0x00072C4C
		[CallerCount(0)]
		public unsafe StadiaPrimaryInputSource _get_valueDelegates_b__36()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__36_Private_StadiaPrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00074A88 File Offset: 0x00072C88
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__37(StadiaPrimaryInputSource x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__37_Private_Void_StadiaPrimaryInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00074AC8 File Offset: 0x00072CC8
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__38()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__38_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00074B04 File Offset: 0x00072D04
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__39(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__39_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00074B44 File Offset: 0x00072D44
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__3a()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__3a_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00074B80 File Offset: 0x00072D80
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__3b(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__3b_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00074BC0 File Offset: 0x00072DC0
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__3c()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__3c_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00074BFC File Offset: 0x00072DFC
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__3d(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__3d_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00074C3C File Offset: 0x00072E3C
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__3e()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__3e_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00074C78 File Offset: 0x00072E78
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__3f(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__3f_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00074CB8 File Offset: 0x00072EB8
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__40()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__40_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00074CF4 File Offset: 0x00072EF4
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__41(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__41_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00074D34 File Offset: 0x00072F34
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__42()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__42_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00074D70 File Offset: 0x00072F70
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__43(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__43_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00074DB0 File Offset: 0x00072FB0
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__44()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__44_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00074DEC File Offset: 0x00072FEC
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__45(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__45_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00074E2C File Offset: 0x0007302C
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__46()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__46_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00074E68 File Offset: 0x00073068
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__47(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__47_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00074EA8 File Offset: 0x000730A8
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__48()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__48_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00074EE4 File Offset: 0x000730E4
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__49(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__49_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00074F24 File Offset: 0x00073124
		[CallerCount(0)]
		public unsafe int _get_valueDelegates_b__4a()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__4a_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00074F60 File Offset: 0x00073160
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__4b(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__4b_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00074FA0 File Offset: 0x000731A0
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__4c()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__4c_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00074FDC File Offset: 0x000731DC
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__4d(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__4d_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x0007501C File Offset: 0x0007321C
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__4e()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__4e_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00075058 File Offset: 0x00073258
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__4f(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__4f_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00075098 File Offset: 0x00073298
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__50()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__50_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x000750D4 File Offset: 0x000732D4
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__51(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__51_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00075114 File Offset: 0x00073314
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__52()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__52_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00075150 File Offset: 0x00073350
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__53(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__53_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00075190 File Offset: 0x00073390
		[CallerCount(0)]
		public unsafe DeadZone2DType _get_valueDelegates_b__54()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__54_Private_DeadZone2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x000751CC File Offset: 0x000733CC
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__55(DeadZone2DType x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__55_Private_Void_DeadZone2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0007520C File Offset: 0x0007340C
		[CallerCount(0)]
		public unsafe AxisSensitivity2DType _get_valueDelegates_b__56()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__56_Private_AxisSensitivity2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00075248 File Offset: 0x00073448
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__57(AxisSensitivity2DType x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__57_Private_Void_AxisSensitivity2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00075288 File Offset: 0x00073488
		[CallerCount(0)]
		public unsafe AxisSensitivityType _get_valueDelegates_b__58()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__58_Private_AxisSensitivityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x000752C4 File Offset: 0x000734C4
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__59(AxisSensitivityType x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__59_Private_Void_AxisSensitivityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00075304 File Offset: 0x00073504
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__5a()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__5a_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00075340 File Offset: 0x00073540
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__5b(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__5b_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00075380 File Offset: 0x00073580
		[CallerCount(0)]
		public unsafe ThrottleCalibrationMode _get_valueDelegates_b__5c()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__5c_Private_ThrottleCalibrationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x000753BC File Offset: 0x000735BC
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__5d(ThrottleCalibrationMode x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__5d_Private_Void_ThrottleCalibrationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x000753FC File Offset: 0x000735FC
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__5e()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__5e_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00075438 File Offset: 0x00073638
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__5f(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__5f_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00075478 File Offset: 0x00073678
		[CallerCount(0)]
		public unsafe bool _get_valueDelegates_b__60()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__60_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x000754B4 File Offset: 0x000736B4
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__61(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__61_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x000754F4 File Offset: 0x000736F4
		[CallerCount(0)]
		public unsafe LogLevelFlags _get_valueDelegates_b__62()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__62_Private_LogLevelFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00075530 File Offset: 0x00073730
		[CallerCount(0)]
		public unsafe void _get_valueDelegates_b__63(LogLevelFlags x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__63_Private_Void_LogLevelFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00075570 File Offset: 0x00073770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_valueDelegates_b__64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__64_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x000755AC File Offset: 0x000737AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263892, XrefRangeEnd = 263893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _get_valueDelegates_b__65(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__65_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x000755EC File Offset: 0x000737EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_valueDelegates_b__66()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__66_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00075628 File Offset: 0x00073828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263893, XrefRangeEnd = 263895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _get_valueDelegates_b__67(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__67_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00075668 File Offset: 0x00073868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263895, XrefRangeEnd = 263896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_valueDelegates_b__68()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__68_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x000756A4 File Offset: 0x000738A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263896, XrefRangeEnd = 263897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _get_valueDelegates_b__69(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__69_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x000756E4 File Offset: 0x000738E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263897, XrefRangeEnd = 263898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_valueDelegates_b__6a()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__6a_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00075720 File Offset: 0x00073920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263898, XrefRangeEnd = 263899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _get_valueDelegates_b__6b(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__6b_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00075760 File Offset: 0x00073960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263899, XrefRangeEnd = 263900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_valueDelegates_b__6c()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__6c_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0007579C File Offset: 0x0007399C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263900, XrefRangeEnd = 263901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _get_valueDelegates_b__6d(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__6d_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x000757DC File Offset: 0x000739DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263901, XrefRangeEnd = 263902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _get_valueDelegates_b__6e()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__6e_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00075818 File Offset: 0x00073A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263902, XrefRangeEnd = 263903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _get_valueDelegates_b__6f(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__6f_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00075858 File Offset: 0x00073A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263903, XrefRangeEnd = 263910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_valueDelegates_b__70()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__70_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00075894 File Offset: 0x00073A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263910, XrefRangeEnd = 263917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _get_valueDelegates_b__71(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.NativeMethodInfoPtr__get_valueDelegates_b__71_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0000832E File Offset: 0x0000652E
		public ConfigVars(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x000758D4 File Offset: 0x00073AD4
		// (set) Token: 0x06001326 RID: 4902 RVA: 0x00008337 File Offset: 0x00006537
		public unsafe UpdateLoopSetting updateLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_updateLoop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_updateLoop)) = value;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001327 RID: 4903 RVA: 0x000758FC File Offset: 0x00073AFC
		// (set) Token: 0x06001328 RID: 4904 RVA: 0x00008352 File Offset: 0x00006552
		public unsafe bool alwaysUseUnityInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_alwaysUseUnityInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_alwaysUseUnityInput)) = value;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x00075924 File Offset: 0x00073B24
		// (set) Token: 0x0600132A RID: 4906 RVA: 0x0000836D File Offset: 0x0000656D
		public unsafe WindowsStandalonePrimaryInputSource windowsStandalonePrimaryInputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_windowsStandalonePrimaryInputSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_windowsStandalonePrimaryInputSource)) = value;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x0007594C File Offset: 0x00073B4C
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x00008388 File Offset: 0x00006588
		public unsafe OSXStandalonePrimaryInputSource osx_primaryInputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_osx_primaryInputSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_osx_primaryInputSource)) = value;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x00075974 File Offset: 0x00073B74
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x000083A3 File Offset: 0x000065A3
		public unsafe LinuxStandalonePrimaryInputSource linux_primaryInputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_linux_primaryInputSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_linux_primaryInputSource)) = value;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x0007599C File Offset: 0x00073B9C
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x000083BE File Offset: 0x000065BE
		public unsafe WindowsUWPPrimaryInputSource windowsUWP_primaryInputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_windowsUWP_primaryInputSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_windowsUWP_primaryInputSource)) = value;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x000759C4 File Offset: 0x00073BC4
		// (set) Token: 0x06001332 RID: 4914 RVA: 0x000083D9 File Offset: 0x000065D9
		public unsafe XboxOnePrimaryInputSource xboxOne_primaryInputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_xboxOne_primaryInputSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_xboxOne_primaryInputSource)) = value;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x000759EC File Offset: 0x00073BEC
		// (set) Token: 0x06001334 RID: 4916 RVA: 0x000083F4 File Offset: 0x000065F4
		public unsafe GameCoreXboxOnePrimaryInputSource gameCoreXboxOne_primaryInputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_gameCoreXboxOne_primaryInputSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_gameCoreXboxOne_primaryInputSource)) = value;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x00075A14 File Offset: 0x00073C14
		// (set) Token: 0x06001336 RID: 4918 RVA: 0x0000840F File Offset: 0x0000660F
		public unsafe GameCoreScarlettPrimaryInputSource gameCoreScarlett_primaryInputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_gameCoreScarlett_primaryInputSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_gameCoreScarlett_primaryInputSource)) = value;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x00075A3C File Offset: 0x00073C3C
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x0000842A File Offset: 0x0000662A
		public unsafe PS4PrimaryInputSource ps4_primaryInputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_ps4_primaryInputSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_ps4_primaryInputSource)) = value;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x00075A64 File Offset: 0x00073C64
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x00008445 File Offset: 0x00006645
		public unsafe PS5PrimaryInputSource ps5_primaryInputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_ps5_primaryInputSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_ps5_primaryInputSource)) = value;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x00075A8C File Offset: 0x00073C8C
		// (set) Token: 0x0600133C RID: 4924 RVA: 0x00008460 File Offset: 0x00006660
		public unsafe WebGLPrimaryInputSource webGL_primaryInputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_webGL_primaryInputSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_webGL_primaryInputSource)) = value;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x00075AB4 File Offset: 0x00073CB4
		// (set) Token: 0x0600133E RID: 4926 RVA: 0x0000847B File Offset: 0x0000667B
		public unsafe StadiaPrimaryInputSource stadia_primaryInputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_stadia_primaryInputSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_stadia_primaryInputSource)) = value;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x00075ADC File Offset: 0x00073CDC
		// (set) Token: 0x06001340 RID: 4928 RVA: 0x00008496 File Offset: 0x00006696
		public unsafe bool useXInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_useXInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_useXInput)) = value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x00075B04 File Offset: 0x00073D04
		// (set) Token: 0x06001342 RID: 4930 RVA: 0x000084B1 File Offset: 0x000066B1
		public unsafe bool useNativeMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_useNativeMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_useNativeMouse)) = value;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x00075B2C File Offset: 0x00073D2C
		// (set) Token: 0x06001344 RID: 4932 RVA: 0x000084CC File Offset: 0x000066CC
		public unsafe bool useEnhancedDeviceSupport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_useEnhancedDeviceSupport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_useEnhancedDeviceSupport)) = value;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001345 RID: 4933 RVA: 0x00075B54 File Offset: 0x00073D54
		// (set) Token: 0x06001346 RID: 4934 RVA: 0x000084E7 File Offset: 0x000066E7
		public unsafe bool windowsStandalone_useSteamRawInputControllerWorkaround
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_windowsStandalone_useSteamRawInputControllerWorkaround);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_windowsStandalone_useSteamRawInputControllerWorkaround)) = value;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x00075B7C File Offset: 0x00073D7C
		// (set) Token: 0x06001348 RID: 4936 RVA: 0x00008502 File Offset: 0x00006702
		public unsafe bool osxStandalone_useEnhancedDeviceSupport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_osxStandalone_useEnhancedDeviceSupport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_osxStandalone_useEnhancedDeviceSupport)) = value;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x00075BA4 File Offset: 0x00073DA4
		// (set) Token: 0x0600134A RID: 4938 RVA: 0x0000851D File Offset: 0x0000671D
		public unsafe bool android_supportUnknownGamepads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_android_supportUnknownGamepads);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_android_supportUnknownGamepads)) = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x00075BCC File Offset: 0x00073DCC
		// (set) Token: 0x0600134C RID: 4940 RVA: 0x00008538 File Offset: 0x00006738
		public unsafe bool ps4_assignJoysticksByPS4JoyId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_ps4_assignJoysticksByPS4JoyId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_ps4_assignJoysticksByPS4JoyId)) = value;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x00075BF4 File Offset: 0x00073DF4
		// (set) Token: 0x0600134E RID: 4942 RVA: 0x00008553 File Offset: 0x00006753
		public unsafe bool useSteamControllerSupport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_useSteamControllerSupport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_useSteamControllerSupport)) = value;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x00075C1C File Offset: 0x00073E1C
		// (set) Token: 0x06001350 RID: 4944 RVA: 0x0000856E File Offset: 0x0000676E
		public unsafe bool logToScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_logToScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_logToScreen)) = value;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x00075C44 File Offset: 0x00073E44
		// (set) Token: 0x06001352 RID: 4946 RVA: 0x00008589 File Offset: 0x00006789
		public unsafe bool runInEditMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_runInEditMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_runInEditMode)) = value;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x00075C6C File Offset: 0x00073E6C
		// (set) Token: 0x06001354 RID: 4948 RVA: 0x000085A4 File Offset: 0x000067A4
		public unsafe bool allowInputInEditorSceneView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_allowInputInEditorSceneView);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_allowInputInEditorSceneView)) = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x00075C94 File Offset: 0x00073E94
		// (set) Token: 0x06001356 RID: 4950 RVA: 0x000085BF File Offset: 0x000067BF
		public unsafe ConfigVars.PlatformVars_WindowsStandalone platformVars_windowsStandalone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_windowsStandalone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars_WindowsStandalone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_windowsStandalone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00075CC4 File Offset: 0x00073EC4
		// (set) Token: 0x06001358 RID: 4952 RVA: 0x000085DE File Offset: 0x000067DE
		public unsafe ConfigVars.PlatformVars platformVars_linuxStandalone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_linuxStandalone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_linuxStandalone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x00075CF4 File Offset: 0x00073EF4
		// (set) Token: 0x0600135A RID: 4954 RVA: 0x000085FD File Offset: 0x000067FD
		public unsafe ConfigVars.PlatformVars_OSXStandalone platformVars_osxStandalone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_osxStandalone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars_OSXStandalone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_osxStandalone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x00075D24 File Offset: 0x00073F24
		// (set) Token: 0x0600135C RID: 4956 RVA: 0x0000861C File Offset: 0x0000681C
		public unsafe ConfigVars.PlatformVars platformVars_windows8Store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_windows8Store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_windows8Store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x00075D54 File Offset: 0x00073F54
		// (set) Token: 0x0600135E RID: 4958 RVA: 0x0000863B File Offset: 0x0000683B
		public unsafe ConfigVars.PlatformVars_WindowsUWP platformVars_windowsUWP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_windowsUWP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars_WindowsUWP>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_windowsUWP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x00075D84 File Offset: 0x00073F84
		// (set) Token: 0x06001360 RID: 4960 RVA: 0x0000865A File Offset: 0x0000685A
		public unsafe ConfigVars.PlatformVars platformVars_iOS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_iOS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_iOS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x00075DB4 File Offset: 0x00073FB4
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x00008679 File Offset: 0x00006879
		public unsafe ConfigVars.PlatformVars platformVars_tvOS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_tvOS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_tvOS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x00075DE4 File Offset: 0x00073FE4
		// (set) Token: 0x06001364 RID: 4964 RVA: 0x00008698 File Offset: 0x00006898
		public unsafe ConfigVars.PlatformVars platformVars_android
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_android);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_android), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x00075E14 File Offset: 0x00074014
		// (set) Token: 0x06001366 RID: 4966 RVA: 0x000086B7 File Offset: 0x000068B7
		public unsafe ConfigVars.PlatformVars platformVars_ps3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_ps3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_ps3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x00075E44 File Offset: 0x00074044
		// (set) Token: 0x06001368 RID: 4968 RVA: 0x000086D6 File Offset: 0x000068D6
		public unsafe ConfigVars.PlatformVars platformVars_ps4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_ps4);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_ps4), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x00075E74 File Offset: 0x00074074
		// (set) Token: 0x0600136A RID: 4970 RVA: 0x000086F5 File Offset: 0x000068F5
		public unsafe ConfigVars.PlatformVars platformVars_ps5
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_ps5);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_ps5), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x00075EA4 File Offset: 0x000740A4
		// (set) Token: 0x0600136C RID: 4972 RVA: 0x00008714 File Offset: 0x00006914
		public unsafe ConfigVars.PlatformVars platformVars_psVita
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_psVita);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_psVita), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x00075ED4 File Offset: 0x000740D4
		// (set) Token: 0x0600136E RID: 4974 RVA: 0x00008733 File Offset: 0x00006933
		public unsafe ConfigVars.PlatformVars platformVars_xbox360
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_xbox360);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_xbox360), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x00075F04 File Offset: 0x00074104
		// (set) Token: 0x06001370 RID: 4976 RVA: 0x00008752 File Offset: 0x00006952
		public unsafe ConfigVars.PlatformVars platformVars_xboxOne
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_xboxOne);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_xboxOne), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x00075F34 File Offset: 0x00074134
		// (set) Token: 0x06001372 RID: 4978 RVA: 0x00008771 File Offset: 0x00006971
		public unsafe ConfigVars.PlatformVars_GameCoreXboxOne platformVars_gameCoreXboxOne
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_gameCoreXboxOne);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars_GameCoreXboxOne>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_gameCoreXboxOne), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x00075F64 File Offset: 0x00074164
		// (set) Token: 0x06001374 RID: 4980 RVA: 0x00008790 File Offset: 0x00006990
		public unsafe ConfigVars.PlatformVars_GameCoreScarlett platformVars_gameCoreScarlett
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_gameCoreScarlett);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars_GameCoreScarlett>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_gameCoreScarlett), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x00075F94 File Offset: 0x00074194
		// (set) Token: 0x06001376 RID: 4982 RVA: 0x000087AF File Offset: 0x000069AF
		public unsafe ConfigVars.PlatformVars platformVars_wii
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_wii);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_wii), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001377 RID: 4983 RVA: 0x00075FC4 File Offset: 0x000741C4
		// (set) Token: 0x06001378 RID: 4984 RVA: 0x000087CE File Offset: 0x000069CE
		public unsafe ConfigVars.PlatformVars platformVars_wiiu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_wiiu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_wiiu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x00075FF4 File Offset: 0x000741F4
		// (set) Token: 0x0600137A RID: 4986 RVA: 0x000087ED File Offset: 0x000069ED
		public unsafe ConfigVars.PlatformVars platformVars_switch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_switch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_switch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x00076024 File Offset: 0x00074224
		// (set) Token: 0x0600137C RID: 4988 RVA: 0x0000880C File Offset: 0x00006A0C
		public unsafe ConfigVars.PlatformVars platformVars_webGL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_webGL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_webGL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x00076054 File Offset: 0x00074254
		// (set) Token: 0x0600137E RID: 4990 RVA: 0x0000882B File Offset: 0x00006A2B
		public unsafe ConfigVars.PlatformVars_Stadia platformVars_stadia
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_stadia);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars_Stadia>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_stadia), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x00076084 File Offset: 0x00074284
		// (set) Token: 0x06001380 RID: 4992 RVA: 0x0000884A File Offset: 0x00006A4A
		public unsafe ConfigVars.PlatformVars platformVars_unknown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_unknown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.PlatformVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_platformVars_unknown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x000760B4 File Offset: 0x000742B4
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x00008869 File Offset: 0x00006A69
		public unsafe int maxJoysticksPerPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_maxJoysticksPerPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_maxJoysticksPerPlayer)) = value;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x000760DC File Offset: 0x000742DC
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x00008884 File Offset: 0x00006A84
		public unsafe bool autoAssignJoysticks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_autoAssignJoysticks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_autoAssignJoysticks)) = value;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x00076104 File Offset: 0x00074304
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x0000889F File Offset: 0x00006A9F
		public unsafe bool assignJoysticksToPlayingPlayersOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_assignJoysticksToPlayingPlayersOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_assignJoysticksToPlayingPlayersOnly)) = value;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x0007612C File Offset: 0x0007432C
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x000088BA File Offset: 0x00006ABA
		public unsafe bool distributeJoysticksEvenly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_distributeJoysticksEvenly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_distributeJoysticksEvenly)) = value;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x00076154 File Offset: 0x00074354
		// (set) Token: 0x0600138A RID: 5002 RVA: 0x000088D5 File Offset: 0x00006AD5
		public unsafe bool reassignJoystickToPreviousOwnerOnReconnect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_reassignJoystickToPreviousOwnerOnReconnect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_reassignJoystickToPreviousOwnerOnReconnect)) = value;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x0007617C File Offset: 0x0007437C
		// (set) Token: 0x0600138C RID: 5004 RVA: 0x000088F0 File Offset: 0x00006AF0
		public unsafe DeadZone2DType defaultJoystickAxis2DDeadZoneType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_defaultJoystickAxis2DDeadZoneType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_defaultJoystickAxis2DDeadZoneType)) = value;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x000761A4 File Offset: 0x000743A4
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x0000890B File Offset: 0x00006B0B
		public unsafe AxisSensitivity2DType defaultJoystickAxis2DSensitivityType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_defaultJoystickAxis2DSensitivityType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_defaultJoystickAxis2DSensitivityType)) = value;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x000761CC File Offset: 0x000743CC
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x00008926 File Offset: 0x00006B26
		public unsafe AxisSensitivityType defaultAxisSensitivityType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_defaultAxisSensitivityType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_defaultAxisSensitivityType)) = value;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x000761F4 File Offset: 0x000743F4
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x00008941 File Offset: 0x00006B41
		public unsafe bool force4WayHats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_force4WayHats);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_force4WayHats)) = value;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x0007621C File Offset: 0x0007441C
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x0000895C File Offset: 0x00006B5C
		public unsafe ThrottleCalibrationMode throttleCalibrationMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_throttleCalibrationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_throttleCalibrationMode)) = value;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x00076244 File Offset: 0x00074444
		// (set) Token: 0x06001396 RID: 5014 RVA: 0x00008977 File Offset: 0x00006B77
		public unsafe bool activateActionButtonsOnNegativeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_activateActionButtonsOnNegativeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_activateActionButtonsOnNegativeValue)) = value;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x0007626C File Offset: 0x0007446C
		// (set) Token: 0x06001398 RID: 5016 RVA: 0x00008992 File Offset: 0x00006B92
		public unsafe bool deferControllerConnectedEventsOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_deferControllerConnectedEventsOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_deferControllerConnectedEventsOnStart)) = value;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x00076294 File Offset: 0x00074494
		// (set) Token: 0x0600139A RID: 5018 RVA: 0x000089AD File Offset: 0x00006BAD
		public unsafe LogLevelFlags logLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_logLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_logLevel)) = value;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x000762BC File Offset: 0x000744BC
		// (set) Token: 0x0600139C RID: 5020 RVA: 0x000089C8 File Offset: 0x00006BC8
		public unsafe ConfigVars.EditorVars editorSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_editorSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars.EditorVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr_editorSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x000762EC File Offset: 0x000744EC
		// (set) Token: 0x0600139E RID: 5022 RVA: 0x000089E7 File Offset: 0x00006BE7
		public unsafe Dictionary<int, ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv> __platformVarsDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr___platformVarsDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr___platformVarsDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x0007631C File Offset: 0x0007451C
		// (set) Token: 0x060013A0 RID: 5024 RVA: 0x00008A06 File Offset: 0x00006C06
		public unsafe Dictionary<int, ConfigVars.BeskwhpONorGAgNsHIAihRdquCY> __getSetPlatformVariableDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr___getSetPlatformVariableDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ConfigVars.BeskwhpONorGAgNsHIAihRdquCY>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr___getSetPlatformVariableDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x0007634C File Offset: 0x0007454C
		// (set) Token: 0x060013A2 RID: 5026 RVA: 0x00008A25 File Offset: 0x00006C25
		public unsafe KeyedGetSetValueStore<string> __configVarsValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr___configVarsValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyedGetSetValueStore<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr___configVarsValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x0007637C File Offset: 0x0007457C
		// (set) Token: 0x060013A4 RID: 5028 RVA: 0x00008A44 File Offset: 0x00006C44
		public unsafe Dictionary<string, Object> __valueDelegates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr___valueDelegates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.NativeFieldInfoPtr___valueDelegates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeFieldInfoPtr_updateLoop;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeFieldInfoPtr_alwaysUseUnityInput;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeFieldInfoPtr_windowsStandalonePrimaryInputSource;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeFieldInfoPtr_osx_primaryInputSource;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeFieldInfoPtr_linux_primaryInputSource;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWP_primaryInputSource;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeFieldInfoPtr_xboxOne_primaryInputSource;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeFieldInfoPtr_gameCoreXboxOne_primaryInputSource;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeFieldInfoPtr_gameCoreScarlett_primaryInputSource;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeFieldInfoPtr_ps4_primaryInputSource;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeFieldInfoPtr_ps5_primaryInputSource;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeFieldInfoPtr_webGL_primaryInputSource;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeFieldInfoPtr_stadia_primaryInputSource;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeFieldInfoPtr_useXInput;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeFieldInfoPtr_useNativeMouse;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeFieldInfoPtr_useEnhancedDeviceSupport;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeFieldInfoPtr_windowsStandalone_useSteamRawInputControllerWorkaround;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeFieldInfoPtr_osxStandalone_useEnhancedDeviceSupport;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeFieldInfoPtr_android_supportUnknownGamepads;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeFieldInfoPtr_ps4_assignJoysticksByPS4JoyId;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeFieldInfoPtr_useSteamControllerSupport;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeFieldInfoPtr_logToScreen;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeFieldInfoPtr_runInEditMode;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeFieldInfoPtr_allowInputInEditorSceneView;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_windowsStandalone;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_linuxStandalone;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_osxStandalone;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_windows8Store;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_windowsUWP;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_iOS;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_tvOS;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_android;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_ps3;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_ps4;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_ps5;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_psVita;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_xbox360;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_xboxOne;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_gameCoreXboxOne;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_gameCoreScarlett;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_wii;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_wiiu;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_switch;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_webGL;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_stadia;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeFieldInfoPtr_platformVars_unknown;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeFieldInfoPtr_maxJoysticksPerPlayer;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeFieldInfoPtr_autoAssignJoysticks;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeFieldInfoPtr_assignJoysticksToPlayingPlayersOnly;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeFieldInfoPtr_distributeJoysticksEvenly;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeFieldInfoPtr_reassignJoystickToPreviousOwnerOnReconnect;

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeFieldInfoPtr_defaultJoystickAxis2DDeadZoneType;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeFieldInfoPtr_defaultJoystickAxis2DSensitivityType;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeFieldInfoPtr_defaultAxisSensitivityType;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeFieldInfoPtr_force4WayHats;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeFieldInfoPtr_throttleCalibrationMode;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeFieldInfoPtr_activateActionButtonsOnNegativeValue;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeFieldInfoPtr_deferControllerConnectedEventsOnStart;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeFieldInfoPtr_logLevel;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeFieldInfoPtr_editorSettings;

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeFieldInfoPtr___platformVarsDict;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeFieldInfoPtr___getSetPlatformVariableDict;

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeFieldInfoPtr___configVarsValues;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeFieldInfoPtr___valueDelegates;

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeMethodInfoPtr_get_platformVarsDict_Private_get_Dictionary_2_Int32_OrbKWFwOjGZrOMASFSOZfbpzlJv_0;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeMethodInfoPtr_get_getSetPlatformVariableDict_Private_get_Dictionary_2_Int32_BeskwhpONorGAgNsHIAihRdquCY_0;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeMethodInfoPtr_DoesPlatformUseFallback_Internal_Boolean_Platform_WebplayerPlatform_Boolean_0;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeMethodInfoPtr_DoesPlatformUseSDL2_Internal_Boolean_Platform_WebplayerPlatform_Boolean_0;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeMethodInfoPtr_GetDebugConfigSettings_Internal_String_0;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformVarsRelPath_Internal_String_Platform_0;

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformVars_Internal_PlatformVars_Platform_0;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeMethodInfoPtr_Editor_GetAllSerializedPlatformVar_Internal_T_AllPlatformVar_0;

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeMethodInfoPtr_Editor_SetAllSerializedPlatformVar_Internal_Void_AllPlatformVar_Object_0;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformVar_disableKeyboard_Internal_Boolean_0;

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeMethodInfoPtr_SetPlatformVar_disableKeyboard_Internal_Boolean_Boolean_0;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformVar_ignoreInputWhenAppNotInFocus_Internal_Boolean_0;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformVar_useEnhancedDeviceSupport_Internal_Boolean_0;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformVar_useNativeMouse_Internal_Boolean_0;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformVar_useNativeKeyboard_Internal_Boolean_0;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformVar_joystickRefreshRate_Internal_Int32_0;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformVar_assignJoysticksBySystemId_Internal_Boolean_0;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeMethodInfoPtr_SetPlatformVar_ignoreInputWhenAppNotInFocus_Internal_Boolean_Boolean_0;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeMethodInfoPtr_SetPlatformVar_useEnhancedDeviceSupport_Internal_Boolean_Boolean_0;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr_SetPlatformVar_useNativeMouse_Internal_Boolean_Boolean_0;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeMethodInfoPtr_SetPlatformVar_useNativeKeyboard_Internal_Boolean_Boolean_0;

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeMethodInfoPtr_SetPlatformVar_joystickRefreshRate_Internal_Boolean_Int32_0;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeMethodInfoPtr_SetPlatformVar_assignJoysticksBySystemId_Internal_Boolean_Boolean_0;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformVars_Private_PlatformVars_0;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreatePlatformVars_Private_T_byref_T_0;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeMethodInfoPtr_GetAllSerializedPlatformVar_multiBool_Private_MultiBoolValue_AllPlatformVar_0;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeMethodInfoPtr_IsEditModeInputSupported_Internal_Boolean_ControllerType_EditorPlatform_0;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Data_IConfigVars_Internal_get_values_Private_Virtual_Final_New_get_KeyedGetSetValueStore_1_String_0;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr_get_valueDelegates_Private_get_Dictionary_2_String_Object_0;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__1_Private_PlatformVars_0;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__2_Private_PlatformVars_0;

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__3_Private_PlatformVars_0;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__4_Private_PlatformVars_0;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__5_Private_PlatformVars_0;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__6_Private_PlatformVars_0;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__7_Private_PlatformVars_0;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__8_Private_PlatformVars_0;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__9_Private_PlatformVars_0;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__a_Private_PlatformVars_0;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__b_Private_PlatformVars_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__c_Private_PlatformVars_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__d_Private_PlatformVars_0;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__e_Private_PlatformVars_0;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__f_Private_PlatformVars_0;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__10_Private_PlatformVars_0;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__11_Private_PlatformVars_0;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__12_Private_PlatformVars_0;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__13_Private_PlatformVars_0;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__14_Private_PlatformVars_0;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__15_Private_PlatformVars_0;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__16_Private_PlatformVars_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr__get_platformVarsDict_b__17_Private_PlatformVars_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr__get_getSetPlatformVariableDict_b__19_Private_Object_Platform_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr__get_getSetPlatformVariableDict_b__1a_Private_Void_Platform_Object_0;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeMethodInfoPtr__get_getSetPlatformVariableDict_b__1b_Private_Object_Platform_0;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeMethodInfoPtr__get_getSetPlatformVariableDict_b__1c_Private_Void_Platform_Object_0;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__1e_Private_UpdateLoopSetting_0;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__1f_Private_Void_UpdateLoopSetting_0;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__20_Private_Boolean_0;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__21_Private_Void_Boolean_0;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__22_Private_WindowsStandalonePrimaryInputSource_0;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__23_Private_Void_WindowsStandalonePrimaryInputSource_0;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__24_Private_OSXStandalonePrimaryInputSource_0;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__25_Private_Void_OSXStandalonePrimaryInputSource_0;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__26_Private_LinuxStandalonePrimaryInputSource_0;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__27_Private_Void_LinuxStandalonePrimaryInputSource_0;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__28_Private_WindowsUWPPrimaryInputSource_0;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__29_Private_Void_WindowsUWPPrimaryInputSource_0;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__2a_Private_XboxOnePrimaryInputSource_0;

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__2b_Private_Void_XboxOnePrimaryInputSource_0;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__2c_Private_GameCoreXboxOnePrimaryInputSource_0;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__2d_Private_Void_GameCoreXboxOnePrimaryInputSource_0;

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__2e_Private_GameCoreScarlettPrimaryInputSource_0;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__2f_Private_Void_GameCoreScarlettPrimaryInputSource_0;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__30_Private_PS4PrimaryInputSource_0;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__31_Private_Void_PS4PrimaryInputSource_0;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__32_Private_PS5PrimaryInputSource_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__33_Private_Void_PS5PrimaryInputSource_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__34_Private_WebGLPrimaryInputSource_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__35_Private_Void_WebGLPrimaryInputSource_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__36_Private_StadiaPrimaryInputSource_0;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__37_Private_Void_StadiaPrimaryInputSource_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__38_Private_Boolean_0;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__39_Private_Void_Boolean_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__3a_Private_Boolean_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__3b_Private_Void_Boolean_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__3c_Private_Boolean_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__3d_Private_Void_Boolean_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__3e_Private_Boolean_0;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__3f_Private_Void_Boolean_0;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__40_Private_Boolean_0;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__41_Private_Void_Boolean_0;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__42_Private_Boolean_0;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__43_Private_Void_Boolean_0;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__44_Private_Boolean_0;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__45_Private_Void_Boolean_0;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__46_Private_Boolean_0;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__47_Private_Void_Boolean_0;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__48_Private_Boolean_0;

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__49_Private_Void_Boolean_0;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__4a_Private_Int32_0;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__4b_Private_Void_Int32_0;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__4c_Private_Boolean_0;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__4d_Private_Void_Boolean_0;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__4e_Private_Boolean_0;

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__4f_Private_Void_Boolean_0;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__50_Private_Boolean_0;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__51_Private_Void_Boolean_0;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__52_Private_Boolean_0;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__53_Private_Void_Boolean_0;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__54_Private_DeadZone2DType_0;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__55_Private_Void_DeadZone2DType_0;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__56_Private_AxisSensitivity2DType_0;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__57_Private_Void_AxisSensitivity2DType_0;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__58_Private_AxisSensitivityType_0;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__59_Private_Void_AxisSensitivityType_0;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__5a_Private_Boolean_0;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__5b_Private_Void_Boolean_0;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__5c_Private_ThrottleCalibrationMode_0;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__5d_Private_Void_ThrottleCalibrationMode_0;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__5e_Private_Boolean_0;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__5f_Private_Void_Boolean_0;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__60_Private_Boolean_0;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__61_Private_Void_Boolean_0;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__62_Private_LogLevelFlags_0;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__63_Private_Void_LogLevelFlags_0;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__64_Private_Boolean_0;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__65_Private_Void_Boolean_0;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__66_Private_Boolean_0;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__67_Private_Void_Boolean_0;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__68_Private_Boolean_0;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__69_Private_Void_Boolean_0;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__6a_Private_Boolean_0;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__6b_Private_Void_Boolean_0;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__6c_Private_Boolean_0;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__6d_Private_Void_Boolean_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__6e_Private_Int32_0;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__6f_Private_Void_Int32_0;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__70_Private_Boolean_0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeMethodInfoPtr__get_valueDelegates_b__71_Private_Void_Boolean_0;

		// Token: 0x020002B6 RID: 694
		public static class SaudciSZwqGMjMYSNuCWKsqNgTN : Object
		{
			// Token: 0x06003D33 RID: 15667 RVA: 0x001246F0 File Offset: 0x001228F0
			// Note: this type is marked as 'beforefieldinit'.
			static SaudciSZwqGMjMYSNuCWKsqNgTN()
			{
				Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "SaudciSZwqGMjMYSNuCWKsqNgTN");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr);
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_HmLJOEaFHWwVymwfHWYgZGnwyFG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "HmLJOEaFHWwVymwfHWYgZGnwyFG");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_WSaBuCgdiJCjFyQQmlSCWqsDcEr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "WSaBuCgdiJCjFyQQmlSCWqsDcEr");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_fCpYbVXdcgsoEiYuNQRFEHeImhF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "fCpYbVXdcgsoEiYuNQRFEHeImhF");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_yTrJMhJVpeKkAEJJPHIkhWKbcsgL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "yTrJMhJVpeKkAEJJPHIkhWKbcsgL");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_tugxpXohhWnkVWxyIPMZlUmkDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "tugxpXohhWnkVWxyIPMZlUmkDEX");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_CAnNMjjsRWlGeytfzKAnaftszXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "CAnNMjjsRWlGeytfzKAnaftszXY");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_VAmNNHfalxRMHdsHIRXORXyQaGl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "VAmNNHfalxRMHdsHIRXORXyQaGl");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_aYADgVAYasAbGCKhJNiGBwqaIpjX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "aYADgVAYasAbGCKhJNiGBwqaIpjX");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_UhjdUFFHnPAQWhYQoQOBVMknxiE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "UhjdUFFHnPAQWhYQoQOBVMknxiE");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_xGNrQZWyljLEpCBehNpAHzSMVnN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "xGNrQZWyljLEpCBehNpAHzSMVnN");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_bmBuKFScVsTziEUezgLcOPRwgqoE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "bmBuKFScVsTziEUezgLcOPRwgqoE");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_eowoFljdHvhrkdNwdrBDRrEsCRHu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "eowoFljdHvhrkdNwdrBDRrEsCRHu");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_wJogExdOlKicuAMEjdxIGPxIdOX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "wJogExdOlKicuAMEjdxIGPxIdOX");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_UjIRNxTHxWgRzBXVGwWqKyKyzEe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "UjIRNxTHxWgRzBXVGwWqKyKyzEe");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_ncwiyjdacyskzmyGNYlDpPTeXRXn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "ncwiyjdacyskzmyGNYlDpPTeXRXn");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_WSymewtjHZNmwXVoWoobEyDkayE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "WSymewtjHZNmwXVoWoobEyDkayE");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_aRtPSbarEKGvVGzYCzvvtCsYHlLP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "aRtPSbarEKGvVGzYCzvvtCsYHlLP");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_YyDPIrSkjTcIRaYouQruLDzBEhgN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "YyDPIrSkjTcIRaYouQruLDzBEhgN");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_kInOIVKQBvIpJftzSuhTJtzOdkN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "kInOIVKQBvIpJftzSuhTJtzOdkN");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_GcSOalocJvyuXxvHtjuPyJBLROG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "GcSOalocJvyuXxvHtjuPyJBLROG");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_ftrZNJjdFqSrhNnEyafexOOabzA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "ftrZNJjdFqSrhNnEyafexOOabzA");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_oAvzUJZWmSVAfdUfXcOiuqgjHBe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "oAvzUJZWmSVAfdUfXcOiuqgjHBe");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_XMnZlNysGYmYMNZpWadGLGhryeR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "XMnZlNysGYmYMNZpWadGLGhryeR");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_XEgffHNAbWJtbxnVzHSJAseHKvM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "XEgffHNAbWJtbxnVzHSJAseHKvM");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_FdlkTGZLuLZnafbuAXMxxmBfhfV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "FdlkTGZLuLZnafbuAXMxxmBfhfV");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_mfRFubCnrzlWvkPoEHHLXSjVWLB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "mfRFubCnrzlWvkPoEHHLXSjVWLB");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_pJfAEmKEXXYIZgmoEedyiBJaktWk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "pJfAEmKEXXYIZgmoEedyiBJaktWk");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_FHSsEZgPdUGxiSmLNHihdCWJnXu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "FHSsEZgPdUGxiSmLNHihdCWJnXu");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_IhMbguGWRYewmYEvzYbpMUncZaG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "IhMbguGWRYewmYEvzYbpMUncZaG");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_wyNMYzYNclcMIlQtTDnYJkvqjAF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "wyNMYzYNclcMIlQtTDnYJkvqjAF");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_LHWtnlunubZOWZspUdRNOImaGfp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "LHWtnlunubZOWZspUdRNOImaGfp");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_VfxRKrDUUUPofBKPxIdGfcBYLIee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "VfxRKrDUUUPofBKPxIdGfcBYLIee");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_ZDEEJXDdcsrNKAvmifeFWkbTungN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "ZDEEJXDdcsrNKAvmifeFWkbTungN");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_PCBFYYofNaNqwmVnMNKQSxDJywk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "PCBFYYofNaNqwmVnMNKQSxDJywk");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_loYPbwWbDEnqJrRNtKaCrGDBFg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "loYPbwWbDEnqJrRNtKaCrGDBFg");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_ojHJYQwkxGgbwCOlnDBQldvaoJF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "ojHJYQwkxGgbwCOlnDBQldvaoJF");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_gLwVQmvRcrNVkorRmQEdvQXcejDc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "gLwVQmvRcrNVkorRmQEdvQXcejDc");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_zJZkUSscztNfHKcixzTDIaPSbaP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "zJZkUSscztNfHKcixzTDIaPSbaP");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_rOOFOFvtXCzsKNFLBAWUhimPFEr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "rOOFOFvtXCzsKNFLBAWUhimPFEr");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_QRayyLHSzPnSHraHYnnAJdAEAGQG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "QRayyLHSzPnSHraHYnnAJdAEAGQG");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_MtOydQsGaLmrSKLXlXbSaZaYkXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "MtOydQsGaLmrSKLXlXbSaZaYkXZ");
				ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_uDqExakYxpTgRUJfCJYpPSzuAmq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN>.NativeClassPtr, "uDqExakYxpTgRUJfCJYpPSzuAmq");
			}

			// Token: 0x06003D34 RID: 15668 RVA: 0x00015BE3 File Offset: 0x00013DE3
			public SaudciSZwqGMjMYSNuCWKsqNgTN(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012BA RID: 4794
			// (get) Token: 0x06003D35 RID: 15669 RVA: 0x00124A64 File Offset: 0x00122C64
			// (set) Token: 0x06003D36 RID: 15670 RVA: 0x00015BEC File Offset: 0x00013DEC
			public unsafe static string HmLJOEaFHWwVymwfHWYgZGnwyFG
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_HmLJOEaFHWwVymwfHWYgZGnwyFG, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_HmLJOEaFHWwVymwfHWYgZGnwyFG, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012BB RID: 4795
			// (get) Token: 0x06003D37 RID: 15671 RVA: 0x00124A84 File Offset: 0x00122C84
			// (set) Token: 0x06003D38 RID: 15672 RVA: 0x00015BFE File Offset: 0x00013DFE
			public unsafe static string WSaBuCgdiJCjFyQQmlSCWqsDcEr
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_WSaBuCgdiJCjFyQQmlSCWqsDcEr, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_WSaBuCgdiJCjFyQQmlSCWqsDcEr, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012BC RID: 4796
			// (get) Token: 0x06003D39 RID: 15673 RVA: 0x00124AA4 File Offset: 0x00122CA4
			// (set) Token: 0x06003D3A RID: 15674 RVA: 0x00015C10 File Offset: 0x00013E10
			public unsafe static string fCpYbVXdcgsoEiYuNQRFEHeImhF
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_fCpYbVXdcgsoEiYuNQRFEHeImhF, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_fCpYbVXdcgsoEiYuNQRFEHeImhF, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012BD RID: 4797
			// (get) Token: 0x06003D3B RID: 15675 RVA: 0x00124AC4 File Offset: 0x00122CC4
			// (set) Token: 0x06003D3C RID: 15676 RVA: 0x00015C22 File Offset: 0x00013E22
			public unsafe static string yTrJMhJVpeKkAEJJPHIkhWKbcsgL
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_yTrJMhJVpeKkAEJJPHIkhWKbcsgL, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_yTrJMhJVpeKkAEJJPHIkhWKbcsgL, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012BE RID: 4798
			// (get) Token: 0x06003D3D RID: 15677 RVA: 0x00124AE4 File Offset: 0x00122CE4
			// (set) Token: 0x06003D3E RID: 15678 RVA: 0x00015C34 File Offset: 0x00013E34
			public unsafe static string tugxpXohhWnkVWxyIPMZlUmkDEX
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_tugxpXohhWnkVWxyIPMZlUmkDEX, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_tugxpXohhWnkVWxyIPMZlUmkDEX, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012BF RID: 4799
			// (get) Token: 0x06003D3F RID: 15679 RVA: 0x00124B04 File Offset: 0x00122D04
			// (set) Token: 0x06003D40 RID: 15680 RVA: 0x00015C46 File Offset: 0x00013E46
			public unsafe static string CAnNMjjsRWlGeytfzKAnaftszXY
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_CAnNMjjsRWlGeytfzKAnaftszXY, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_CAnNMjjsRWlGeytfzKAnaftszXY, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012C0 RID: 4800
			// (get) Token: 0x06003D41 RID: 15681 RVA: 0x00124B24 File Offset: 0x00122D24
			// (set) Token: 0x06003D42 RID: 15682 RVA: 0x00015C58 File Offset: 0x00013E58
			public unsafe static string VAmNNHfalxRMHdsHIRXORXyQaGl
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_VAmNNHfalxRMHdsHIRXORXyQaGl, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_VAmNNHfalxRMHdsHIRXORXyQaGl, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012C1 RID: 4801
			// (get) Token: 0x06003D43 RID: 15683 RVA: 0x00124B44 File Offset: 0x00122D44
			// (set) Token: 0x06003D44 RID: 15684 RVA: 0x00015C6A File Offset: 0x00013E6A
			public unsafe static string aYADgVAYasAbGCKhJNiGBwqaIpjX
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_aYADgVAYasAbGCKhJNiGBwqaIpjX, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_aYADgVAYasAbGCKhJNiGBwqaIpjX, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012C2 RID: 4802
			// (get) Token: 0x06003D45 RID: 15685 RVA: 0x00124B64 File Offset: 0x00122D64
			// (set) Token: 0x06003D46 RID: 15686 RVA: 0x00015C7C File Offset: 0x00013E7C
			public unsafe static string UhjdUFFHnPAQWhYQoQOBVMknxiE
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_UhjdUFFHnPAQWhYQoQOBVMknxiE, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_UhjdUFFHnPAQWhYQoQOBVMknxiE, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012C3 RID: 4803
			// (get) Token: 0x06003D47 RID: 15687 RVA: 0x00124B84 File Offset: 0x00122D84
			// (set) Token: 0x06003D48 RID: 15688 RVA: 0x00015C8E File Offset: 0x00013E8E
			public unsafe static string xGNrQZWyljLEpCBehNpAHzSMVnN
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_xGNrQZWyljLEpCBehNpAHzSMVnN, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_xGNrQZWyljLEpCBehNpAHzSMVnN, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012C4 RID: 4804
			// (get) Token: 0x06003D49 RID: 15689 RVA: 0x00124BA4 File Offset: 0x00122DA4
			// (set) Token: 0x06003D4A RID: 15690 RVA: 0x00015CA0 File Offset: 0x00013EA0
			public unsafe static string bmBuKFScVsTziEUezgLcOPRwgqoE
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_bmBuKFScVsTziEUezgLcOPRwgqoE, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_bmBuKFScVsTziEUezgLcOPRwgqoE, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012C5 RID: 4805
			// (get) Token: 0x06003D4B RID: 15691 RVA: 0x00124BC4 File Offset: 0x00122DC4
			// (set) Token: 0x06003D4C RID: 15692 RVA: 0x00015CB2 File Offset: 0x00013EB2
			public unsafe static string eowoFljdHvhrkdNwdrBDRrEsCRHu
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_eowoFljdHvhrkdNwdrBDRrEsCRHu, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_eowoFljdHvhrkdNwdrBDRrEsCRHu, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012C6 RID: 4806
			// (get) Token: 0x06003D4D RID: 15693 RVA: 0x00124BE4 File Offset: 0x00122DE4
			// (set) Token: 0x06003D4E RID: 15694 RVA: 0x00015CC4 File Offset: 0x00013EC4
			public unsafe static string wJogExdOlKicuAMEjdxIGPxIdOX
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_wJogExdOlKicuAMEjdxIGPxIdOX, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_wJogExdOlKicuAMEjdxIGPxIdOX, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012C7 RID: 4807
			// (get) Token: 0x06003D4F RID: 15695 RVA: 0x00124C04 File Offset: 0x00122E04
			// (set) Token: 0x06003D50 RID: 15696 RVA: 0x00015CD6 File Offset: 0x00013ED6
			public unsafe static string UjIRNxTHxWgRzBXVGwWqKyKyzEe
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_UjIRNxTHxWgRzBXVGwWqKyKyzEe, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_UjIRNxTHxWgRzBXVGwWqKyKyzEe, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012C8 RID: 4808
			// (get) Token: 0x06003D51 RID: 15697 RVA: 0x00124C24 File Offset: 0x00122E24
			// (set) Token: 0x06003D52 RID: 15698 RVA: 0x00015CE8 File Offset: 0x00013EE8
			public unsafe static string ncwiyjdacyskzmyGNYlDpPTeXRXn
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_ncwiyjdacyskzmyGNYlDpPTeXRXn, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_ncwiyjdacyskzmyGNYlDpPTeXRXn, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012C9 RID: 4809
			// (get) Token: 0x06003D53 RID: 15699 RVA: 0x00124C44 File Offset: 0x00122E44
			// (set) Token: 0x06003D54 RID: 15700 RVA: 0x00015CFA File Offset: 0x00013EFA
			public unsafe static string WSymewtjHZNmwXVoWoobEyDkayE
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_WSymewtjHZNmwXVoWoobEyDkayE, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_WSymewtjHZNmwXVoWoobEyDkayE, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012CA RID: 4810
			// (get) Token: 0x06003D55 RID: 15701 RVA: 0x00124C64 File Offset: 0x00122E64
			// (set) Token: 0x06003D56 RID: 15702 RVA: 0x00015D0C File Offset: 0x00013F0C
			public unsafe static string aRtPSbarEKGvVGzYCzvvtCsYHlLP
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_aRtPSbarEKGvVGzYCzvvtCsYHlLP, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_aRtPSbarEKGvVGzYCzvvtCsYHlLP, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012CB RID: 4811
			// (get) Token: 0x06003D57 RID: 15703 RVA: 0x00124C84 File Offset: 0x00122E84
			// (set) Token: 0x06003D58 RID: 15704 RVA: 0x00015D1E File Offset: 0x00013F1E
			public unsafe static string YyDPIrSkjTcIRaYouQruLDzBEhgN
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_YyDPIrSkjTcIRaYouQruLDzBEhgN, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_YyDPIrSkjTcIRaYouQruLDzBEhgN, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012CC RID: 4812
			// (get) Token: 0x06003D59 RID: 15705 RVA: 0x00124CA4 File Offset: 0x00122EA4
			// (set) Token: 0x06003D5A RID: 15706 RVA: 0x00015D30 File Offset: 0x00013F30
			public unsafe static string kInOIVKQBvIpJftzSuhTJtzOdkN
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_kInOIVKQBvIpJftzSuhTJtzOdkN, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_kInOIVKQBvIpJftzSuhTJtzOdkN, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012CD RID: 4813
			// (get) Token: 0x06003D5B RID: 15707 RVA: 0x00124CC4 File Offset: 0x00122EC4
			// (set) Token: 0x06003D5C RID: 15708 RVA: 0x00015D42 File Offset: 0x00013F42
			public unsafe static string GcSOalocJvyuXxvHtjuPyJBLROG
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_GcSOalocJvyuXxvHtjuPyJBLROG, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_GcSOalocJvyuXxvHtjuPyJBLROG, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012CE RID: 4814
			// (get) Token: 0x06003D5D RID: 15709 RVA: 0x00124CE4 File Offset: 0x00122EE4
			// (set) Token: 0x06003D5E RID: 15710 RVA: 0x00015D54 File Offset: 0x00013F54
			public unsafe static string ftrZNJjdFqSrhNnEyafexOOabzA
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_ftrZNJjdFqSrhNnEyafexOOabzA, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_ftrZNJjdFqSrhNnEyafexOOabzA, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012CF RID: 4815
			// (get) Token: 0x06003D5F RID: 15711 RVA: 0x00124D04 File Offset: 0x00122F04
			// (set) Token: 0x06003D60 RID: 15712 RVA: 0x00015D66 File Offset: 0x00013F66
			public unsafe static string oAvzUJZWmSVAfdUfXcOiuqgjHBe
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_oAvzUJZWmSVAfdUfXcOiuqgjHBe, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_oAvzUJZWmSVAfdUfXcOiuqgjHBe, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012D0 RID: 4816
			// (get) Token: 0x06003D61 RID: 15713 RVA: 0x00124D24 File Offset: 0x00122F24
			// (set) Token: 0x06003D62 RID: 15714 RVA: 0x00015D78 File Offset: 0x00013F78
			public unsafe static string XMnZlNysGYmYMNZpWadGLGhryeR
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_XMnZlNysGYmYMNZpWadGLGhryeR, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_XMnZlNysGYmYMNZpWadGLGhryeR, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012D1 RID: 4817
			// (get) Token: 0x06003D63 RID: 15715 RVA: 0x00124D44 File Offset: 0x00122F44
			// (set) Token: 0x06003D64 RID: 15716 RVA: 0x00015D8A File Offset: 0x00013F8A
			public unsafe static string XEgffHNAbWJtbxnVzHSJAseHKvM
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_XEgffHNAbWJtbxnVzHSJAseHKvM, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_XEgffHNAbWJtbxnVzHSJAseHKvM, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012D2 RID: 4818
			// (get) Token: 0x06003D65 RID: 15717 RVA: 0x00124D64 File Offset: 0x00122F64
			// (set) Token: 0x06003D66 RID: 15718 RVA: 0x00015D9C File Offset: 0x00013F9C
			public unsafe static string FdlkTGZLuLZnafbuAXMxxmBfhfV
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_FdlkTGZLuLZnafbuAXMxxmBfhfV, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_FdlkTGZLuLZnafbuAXMxxmBfhfV, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012D3 RID: 4819
			// (get) Token: 0x06003D67 RID: 15719 RVA: 0x00124D84 File Offset: 0x00122F84
			// (set) Token: 0x06003D68 RID: 15720 RVA: 0x00015DAE File Offset: 0x00013FAE
			public unsafe static string mfRFubCnrzlWvkPoEHHLXSjVWLB
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_mfRFubCnrzlWvkPoEHHLXSjVWLB, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_mfRFubCnrzlWvkPoEHHLXSjVWLB, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012D4 RID: 4820
			// (get) Token: 0x06003D69 RID: 15721 RVA: 0x00124DA4 File Offset: 0x00122FA4
			// (set) Token: 0x06003D6A RID: 15722 RVA: 0x00015DC0 File Offset: 0x00013FC0
			public unsafe static string pJfAEmKEXXYIZgmoEedyiBJaktWk
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_pJfAEmKEXXYIZgmoEedyiBJaktWk, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_pJfAEmKEXXYIZgmoEedyiBJaktWk, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012D5 RID: 4821
			// (get) Token: 0x06003D6B RID: 15723 RVA: 0x00124DC4 File Offset: 0x00122FC4
			// (set) Token: 0x06003D6C RID: 15724 RVA: 0x00015DD2 File Offset: 0x00013FD2
			public unsafe static string FHSsEZgPdUGxiSmLNHihdCWJnXu
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_FHSsEZgPdUGxiSmLNHihdCWJnXu, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_FHSsEZgPdUGxiSmLNHihdCWJnXu, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012D6 RID: 4822
			// (get) Token: 0x06003D6D RID: 15725 RVA: 0x00124DE4 File Offset: 0x00122FE4
			// (set) Token: 0x06003D6E RID: 15726 RVA: 0x00015DE4 File Offset: 0x00013FE4
			public unsafe static string IhMbguGWRYewmYEvzYbpMUncZaG
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_IhMbguGWRYewmYEvzYbpMUncZaG, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_IhMbguGWRYewmYEvzYbpMUncZaG, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012D7 RID: 4823
			// (get) Token: 0x06003D6F RID: 15727 RVA: 0x00124E04 File Offset: 0x00123004
			// (set) Token: 0x06003D70 RID: 15728 RVA: 0x00015DF6 File Offset: 0x00013FF6
			public unsafe static string wyNMYzYNclcMIlQtTDnYJkvqjAF
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_wyNMYzYNclcMIlQtTDnYJkvqjAF, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_wyNMYzYNclcMIlQtTDnYJkvqjAF, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012D8 RID: 4824
			// (get) Token: 0x06003D71 RID: 15729 RVA: 0x00124E24 File Offset: 0x00123024
			// (set) Token: 0x06003D72 RID: 15730 RVA: 0x00015E08 File Offset: 0x00014008
			public unsafe static string LHWtnlunubZOWZspUdRNOImaGfp
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_LHWtnlunubZOWZspUdRNOImaGfp, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_LHWtnlunubZOWZspUdRNOImaGfp, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012D9 RID: 4825
			// (get) Token: 0x06003D73 RID: 15731 RVA: 0x00124E44 File Offset: 0x00123044
			// (set) Token: 0x06003D74 RID: 15732 RVA: 0x00015E1A File Offset: 0x0001401A
			public unsafe static string VfxRKrDUUUPofBKPxIdGfcBYLIee
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_VfxRKrDUUUPofBKPxIdGfcBYLIee, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_VfxRKrDUUUPofBKPxIdGfcBYLIee, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012DA RID: 4826
			// (get) Token: 0x06003D75 RID: 15733 RVA: 0x00124E64 File Offset: 0x00123064
			// (set) Token: 0x06003D76 RID: 15734 RVA: 0x00015E2C File Offset: 0x0001402C
			public unsafe static string ZDEEJXDdcsrNKAvmifeFWkbTungN
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_ZDEEJXDdcsrNKAvmifeFWkbTungN, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_ZDEEJXDdcsrNKAvmifeFWkbTungN, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012DB RID: 4827
			// (get) Token: 0x06003D77 RID: 15735 RVA: 0x00124E84 File Offset: 0x00123084
			// (set) Token: 0x06003D78 RID: 15736 RVA: 0x00015E3E File Offset: 0x0001403E
			public unsafe static string PCBFYYofNaNqwmVnMNKQSxDJywk
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_PCBFYYofNaNqwmVnMNKQSxDJywk, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_PCBFYYofNaNqwmVnMNKQSxDJywk, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012DC RID: 4828
			// (get) Token: 0x06003D79 RID: 15737 RVA: 0x00124EA4 File Offset: 0x001230A4
			// (set) Token: 0x06003D7A RID: 15738 RVA: 0x00015E50 File Offset: 0x00014050
			public unsafe static string loYPbwWbDEnqJrRNtKaCrGDBFg
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_loYPbwWbDEnqJrRNtKaCrGDBFg, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_loYPbwWbDEnqJrRNtKaCrGDBFg, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012DD RID: 4829
			// (get) Token: 0x06003D7B RID: 15739 RVA: 0x00124EC4 File Offset: 0x001230C4
			// (set) Token: 0x06003D7C RID: 15740 RVA: 0x00015E62 File Offset: 0x00014062
			public unsafe static string ojHJYQwkxGgbwCOlnDBQldvaoJF
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_ojHJYQwkxGgbwCOlnDBQldvaoJF, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_ojHJYQwkxGgbwCOlnDBQldvaoJF, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012DE RID: 4830
			// (get) Token: 0x06003D7D RID: 15741 RVA: 0x00124EE4 File Offset: 0x001230E4
			// (set) Token: 0x06003D7E RID: 15742 RVA: 0x00015E74 File Offset: 0x00014074
			public unsafe static string gLwVQmvRcrNVkorRmQEdvQXcejDc
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_gLwVQmvRcrNVkorRmQEdvQXcejDc, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_gLwVQmvRcrNVkorRmQEdvQXcejDc, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012DF RID: 4831
			// (get) Token: 0x06003D7F RID: 15743 RVA: 0x00124F04 File Offset: 0x00123104
			// (set) Token: 0x06003D80 RID: 15744 RVA: 0x00015E86 File Offset: 0x00014086
			public unsafe static string zJZkUSscztNfHKcixzTDIaPSbaP
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_zJZkUSscztNfHKcixzTDIaPSbaP, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_zJZkUSscztNfHKcixzTDIaPSbaP, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012E0 RID: 4832
			// (get) Token: 0x06003D81 RID: 15745 RVA: 0x00124F24 File Offset: 0x00123124
			// (set) Token: 0x06003D82 RID: 15746 RVA: 0x00015E98 File Offset: 0x00014098
			public unsafe static string rOOFOFvtXCzsKNFLBAWUhimPFEr
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_rOOFOFvtXCzsKNFLBAWUhimPFEr, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_rOOFOFvtXCzsKNFLBAWUhimPFEr, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012E1 RID: 4833
			// (get) Token: 0x06003D83 RID: 15747 RVA: 0x00124F44 File Offset: 0x00123144
			// (set) Token: 0x06003D84 RID: 15748 RVA: 0x00015EAA File Offset: 0x000140AA
			public unsafe static string QRayyLHSzPnSHraHYnnAJdAEAGQG
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_QRayyLHSzPnSHraHYnnAJdAEAGQG, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_QRayyLHSzPnSHraHYnnAJdAEAGQG, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012E2 RID: 4834
			// (get) Token: 0x06003D85 RID: 15749 RVA: 0x00124F64 File Offset: 0x00123164
			// (set) Token: 0x06003D86 RID: 15750 RVA: 0x00015EBC File Offset: 0x000140BC
			public unsafe static string MtOydQsGaLmrSKLXlXbSaZaYkXZ
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_MtOydQsGaLmrSKLXlXbSaZaYkXZ, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_MtOydQsGaLmrSKLXlXbSaZaYkXZ, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012E3 RID: 4835
			// (get) Token: 0x06003D87 RID: 15751 RVA: 0x00124F84 File Offset: 0x00123184
			// (set) Token: 0x06003D88 RID: 15752 RVA: 0x00015ECE File Offset: 0x000140CE
			public unsafe static string uDqExakYxpTgRUJfCJYpPSzuAmq
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_uDqExakYxpTgRUJfCJYpPSzuAmq, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigVars.SaudciSZwqGMjMYSNuCWKsqNgTN.NativeFieldInfoPtr_uDqExakYxpTgRUJfCJYpPSzuAmq, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040032EF RID: 13039
			private static readonly IntPtr NativeFieldInfoPtr_HmLJOEaFHWwVymwfHWYgZGnwyFG;

			// Token: 0x040032F0 RID: 13040
			private static readonly IntPtr NativeFieldInfoPtr_WSaBuCgdiJCjFyQQmlSCWqsDcEr;

			// Token: 0x040032F1 RID: 13041
			private static readonly IntPtr NativeFieldInfoPtr_fCpYbVXdcgsoEiYuNQRFEHeImhF;

			// Token: 0x040032F2 RID: 13042
			private static readonly IntPtr NativeFieldInfoPtr_yTrJMhJVpeKkAEJJPHIkhWKbcsgL;

			// Token: 0x040032F3 RID: 13043
			private static readonly IntPtr NativeFieldInfoPtr_tugxpXohhWnkVWxyIPMZlUmkDEX;

			// Token: 0x040032F4 RID: 13044
			private static readonly IntPtr NativeFieldInfoPtr_CAnNMjjsRWlGeytfzKAnaftszXY;

			// Token: 0x040032F5 RID: 13045
			private static readonly IntPtr NativeFieldInfoPtr_VAmNNHfalxRMHdsHIRXORXyQaGl;

			// Token: 0x040032F6 RID: 13046
			private static readonly IntPtr NativeFieldInfoPtr_aYADgVAYasAbGCKhJNiGBwqaIpjX;

			// Token: 0x040032F7 RID: 13047
			private static readonly IntPtr NativeFieldInfoPtr_UhjdUFFHnPAQWhYQoQOBVMknxiE;

			// Token: 0x040032F8 RID: 13048
			private static readonly IntPtr NativeFieldInfoPtr_xGNrQZWyljLEpCBehNpAHzSMVnN;

			// Token: 0x040032F9 RID: 13049
			private static readonly IntPtr NativeFieldInfoPtr_bmBuKFScVsTziEUezgLcOPRwgqoE;

			// Token: 0x040032FA RID: 13050
			private static readonly IntPtr NativeFieldInfoPtr_eowoFljdHvhrkdNwdrBDRrEsCRHu;

			// Token: 0x040032FB RID: 13051
			private static readonly IntPtr NativeFieldInfoPtr_wJogExdOlKicuAMEjdxIGPxIdOX;

			// Token: 0x040032FC RID: 13052
			private static readonly IntPtr NativeFieldInfoPtr_UjIRNxTHxWgRzBXVGwWqKyKyzEe;

			// Token: 0x040032FD RID: 13053
			private static readonly IntPtr NativeFieldInfoPtr_ncwiyjdacyskzmyGNYlDpPTeXRXn;

			// Token: 0x040032FE RID: 13054
			private static readonly IntPtr NativeFieldInfoPtr_WSymewtjHZNmwXVoWoobEyDkayE;

			// Token: 0x040032FF RID: 13055
			private static readonly IntPtr NativeFieldInfoPtr_aRtPSbarEKGvVGzYCzvvtCsYHlLP;

			// Token: 0x04003300 RID: 13056
			private static readonly IntPtr NativeFieldInfoPtr_YyDPIrSkjTcIRaYouQruLDzBEhgN;

			// Token: 0x04003301 RID: 13057
			private static readonly IntPtr NativeFieldInfoPtr_kInOIVKQBvIpJftzSuhTJtzOdkN;

			// Token: 0x04003302 RID: 13058
			private static readonly IntPtr NativeFieldInfoPtr_GcSOalocJvyuXxvHtjuPyJBLROG;

			// Token: 0x04003303 RID: 13059
			private static readonly IntPtr NativeFieldInfoPtr_ftrZNJjdFqSrhNnEyafexOOabzA;

			// Token: 0x04003304 RID: 13060
			private static readonly IntPtr NativeFieldInfoPtr_oAvzUJZWmSVAfdUfXcOiuqgjHBe;

			// Token: 0x04003305 RID: 13061
			private static readonly IntPtr NativeFieldInfoPtr_XMnZlNysGYmYMNZpWadGLGhryeR;

			// Token: 0x04003306 RID: 13062
			private static readonly IntPtr NativeFieldInfoPtr_XEgffHNAbWJtbxnVzHSJAseHKvM;

			// Token: 0x04003307 RID: 13063
			private static readonly IntPtr NativeFieldInfoPtr_FdlkTGZLuLZnafbuAXMxxmBfhfV;

			// Token: 0x04003308 RID: 13064
			private static readonly IntPtr NativeFieldInfoPtr_mfRFubCnrzlWvkPoEHHLXSjVWLB;

			// Token: 0x04003309 RID: 13065
			private static readonly IntPtr NativeFieldInfoPtr_pJfAEmKEXXYIZgmoEedyiBJaktWk;

			// Token: 0x0400330A RID: 13066
			private static readonly IntPtr NativeFieldInfoPtr_FHSsEZgPdUGxiSmLNHihdCWJnXu;

			// Token: 0x0400330B RID: 13067
			private static readonly IntPtr NativeFieldInfoPtr_IhMbguGWRYewmYEvzYbpMUncZaG;

			// Token: 0x0400330C RID: 13068
			private static readonly IntPtr NativeFieldInfoPtr_wyNMYzYNclcMIlQtTDnYJkvqjAF;

			// Token: 0x0400330D RID: 13069
			private static readonly IntPtr NativeFieldInfoPtr_LHWtnlunubZOWZspUdRNOImaGfp;

			// Token: 0x0400330E RID: 13070
			private static readonly IntPtr NativeFieldInfoPtr_VfxRKrDUUUPofBKPxIdGfcBYLIee;

			// Token: 0x0400330F RID: 13071
			private static readonly IntPtr NativeFieldInfoPtr_ZDEEJXDdcsrNKAvmifeFWkbTungN;

			// Token: 0x04003310 RID: 13072
			private static readonly IntPtr NativeFieldInfoPtr_PCBFYYofNaNqwmVnMNKQSxDJywk;

			// Token: 0x04003311 RID: 13073
			private static readonly IntPtr NativeFieldInfoPtr_loYPbwWbDEnqJrRNtKaCrGDBFg;

			// Token: 0x04003312 RID: 13074
			private static readonly IntPtr NativeFieldInfoPtr_ojHJYQwkxGgbwCOlnDBQldvaoJF;

			// Token: 0x04003313 RID: 13075
			private static readonly IntPtr NativeFieldInfoPtr_gLwVQmvRcrNVkorRmQEdvQXcejDc;

			// Token: 0x04003314 RID: 13076
			private static readonly IntPtr NativeFieldInfoPtr_zJZkUSscztNfHKcixzTDIaPSbaP;

			// Token: 0x04003315 RID: 13077
			private static readonly IntPtr NativeFieldInfoPtr_rOOFOFvtXCzsKNFLBAWUhimPFEr;

			// Token: 0x04003316 RID: 13078
			private static readonly IntPtr NativeFieldInfoPtr_QRayyLHSzPnSHraHYnnAJdAEAGQG;

			// Token: 0x04003317 RID: 13079
			private static readonly IntPtr NativeFieldInfoPtr_MtOydQsGaLmrSKLXlXbSaZaYkXZ;

			// Token: 0x04003318 RID: 13080
			private static readonly IntPtr NativeFieldInfoPtr_uDqExakYxpTgRUJfCJYpPSzuAmq;
		}

		// Token: 0x020002B7 RID: 695
		[Serializable]
		public class PlatformVars : Object
		{
			// Token: 0x06003D89 RID: 15753 RVA: 0x00124FA4 File Offset: 0x001231A4
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformVars()
			{
				Il2CppClassPointerStore<ConfigVars.PlatformVars>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "PlatformVars");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigVars.PlatformVars>.NativeClassPtr);
				ConfigVars.PlatformVars.NativeFieldInfoPtr_disableKeyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.PlatformVars>.NativeClassPtr, "disableKeyboard");
				ConfigVars.PlatformVars.NativeFieldInfoPtr_ignoreInputWhenAppNotInFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.PlatformVars>.NativeClassPtr, "ignoreInputWhenAppNotInFocus");
				ConfigVars.PlatformVars.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars.PlatformVars>.NativeClassPtr, 100666560);
			}

			// Token: 0x06003D8A RID: 15754 RVA: 0x0012500C File Offset: 0x0012320C
			[CallerCount(0)]
			public unsafe PlatformVars()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigVars.PlatformVars>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.PlatformVars.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003D8B RID: 15755 RVA: 0x00015EE0 File Offset: 0x000140E0
			public PlatformVars(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012E4 RID: 4836
			// (get) Token: 0x06003D8C RID: 15756 RVA: 0x00125048 File Offset: 0x00123248
			// (set) Token: 0x06003D8D RID: 15757 RVA: 0x00015EE9 File Offset: 0x000140E9
			public unsafe bool disableKeyboard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars.NativeFieldInfoPtr_disableKeyboard);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars.NativeFieldInfoPtr_disableKeyboard)) = value;
				}
			}

			// Token: 0x170012E5 RID: 4837
			// (get) Token: 0x06003D8E RID: 15758 RVA: 0x00125070 File Offset: 0x00123270
			// (set) Token: 0x06003D8F RID: 15759 RVA: 0x00015F04 File Offset: 0x00014104
			public unsafe bool ignoreInputWhenAppNotInFocus
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars.NativeFieldInfoPtr_ignoreInputWhenAppNotInFocus);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars.NativeFieldInfoPtr_ignoreInputWhenAppNotInFocus)) = value;
				}
			}

			// Token: 0x04003319 RID: 13081
			private static readonly IntPtr NativeFieldInfoPtr_disableKeyboard;

			// Token: 0x0400331A RID: 13082
			private static readonly IntPtr NativeFieldInfoPtr_ignoreInputWhenAppNotInFocus;

			// Token: 0x0400331B RID: 13083
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002B8 RID: 696
		[Serializable]
		public class PlatformVars_WindowsStandalone : ConfigVars.PlatformVars
		{
			// Token: 0x06003D90 RID: 15760 RVA: 0x00125098 File Offset: 0x00123298
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformVars_WindowsStandalone()
			{
				Il2CppClassPointerStore<ConfigVars.PlatformVars_WindowsStandalone>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "PlatformVars_WindowsStandalone");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigVars.PlatformVars_WindowsStandalone>.NativeClassPtr);
				ConfigVars.PlatformVars_WindowsStandalone.NativeFieldInfoPtr_useNativeKeyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.PlatformVars_WindowsStandalone>.NativeClassPtr, "useNativeKeyboard");
				ConfigVars.PlatformVars_WindowsStandalone.NativeFieldInfoPtr_joystickRefreshRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.PlatformVars_WindowsStandalone>.NativeClassPtr, "joystickRefreshRate");
				ConfigVars.PlatformVars_WindowsStandalone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars.PlatformVars_WindowsStandalone>.NativeClassPtr, 100666561);
			}

			// Token: 0x06003D91 RID: 15761 RVA: 0x00125100 File Offset: 0x00123300
			[CallerCount(0)]
			public unsafe PlatformVars_WindowsStandalone()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigVars.PlatformVars_WindowsStandalone>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.PlatformVars_WindowsStandalone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003D92 RID: 15762 RVA: 0x00015F1F File Offset: 0x0001411F
			public PlatformVars_WindowsStandalone(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012E6 RID: 4838
			// (get) Token: 0x06003D93 RID: 15763 RVA: 0x0012513C File Offset: 0x0012333C
			// (set) Token: 0x06003D94 RID: 15764 RVA: 0x00015F28 File Offset: 0x00014128
			public unsafe bool useNativeKeyboard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars_WindowsStandalone.NativeFieldInfoPtr_useNativeKeyboard);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars_WindowsStandalone.NativeFieldInfoPtr_useNativeKeyboard)) = value;
				}
			}

			// Token: 0x170012E7 RID: 4839
			// (get) Token: 0x06003D95 RID: 15765 RVA: 0x00125164 File Offset: 0x00123364
			// (set) Token: 0x06003D96 RID: 15766 RVA: 0x00015F43 File Offset: 0x00014143
			public unsafe int joystickRefreshRate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars_WindowsStandalone.NativeFieldInfoPtr_joystickRefreshRate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars_WindowsStandalone.NativeFieldInfoPtr_joystickRefreshRate)) = value;
				}
			}

			// Token: 0x0400331C RID: 13084
			private static readonly IntPtr NativeFieldInfoPtr_useNativeKeyboard;

			// Token: 0x0400331D RID: 13085
			private static readonly IntPtr NativeFieldInfoPtr_joystickRefreshRate;

			// Token: 0x0400331E RID: 13086
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002B9 RID: 697
		[Serializable]
		public class PlatformVars_OSXStandalone : ConfigVars.PlatformVars
		{
			// Token: 0x06003D97 RID: 15767 RVA: 0x00015F5E File Offset: 0x0001415E
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformVars_OSXStandalone()
			{
				Il2CppClassPointerStore<ConfigVars.PlatformVars_OSXStandalone>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "PlatformVars_OSXStandalone");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigVars.PlatformVars_OSXStandalone>.NativeClassPtr);
				ConfigVars.PlatformVars_OSXStandalone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars.PlatformVars_OSXStandalone>.NativeClassPtr, 100666562);
			}

			// Token: 0x06003D98 RID: 15768 RVA: 0x0012518C File Offset: 0x0012338C
			[CallerCount(0)]
			public unsafe PlatformVars_OSXStandalone()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigVars.PlatformVars_OSXStandalone>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.PlatformVars_OSXStandalone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003D99 RID: 15769 RVA: 0x00015F92 File Offset: 0x00014192
			public PlatformVars_OSXStandalone(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400331F RID: 13087
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002BA RID: 698
		[Serializable]
		public class PlatformVars_WindowsUWP : ConfigVars.PlatformVars
		{
			// Token: 0x06003D9A RID: 15770 RVA: 0x001251C8 File Offset: 0x001233C8
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformVars_WindowsUWP()
			{
				Il2CppClassPointerStore<ConfigVars.PlatformVars_WindowsUWP>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "PlatformVars_WindowsUWP");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigVars.PlatformVars_WindowsUWP>.NativeClassPtr);
				ConfigVars.PlatformVars_WindowsUWP.NativeFieldInfoPtr_useGamepadAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.PlatformVars_WindowsUWP>.NativeClassPtr, "useGamepadAPI");
				ConfigVars.PlatformVars_WindowsUWP.NativeFieldInfoPtr_useHIDAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.PlatformVars_WindowsUWP>.NativeClassPtr, "useHIDAPI");
				ConfigVars.PlatformVars_WindowsUWP.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars.PlatformVars_WindowsUWP>.NativeClassPtr, 100666563);
			}

			// Token: 0x06003D9B RID: 15771 RVA: 0x00125230 File Offset: 0x00123430
			[CallerCount(0)]
			public unsafe PlatformVars_WindowsUWP()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigVars.PlatformVars_WindowsUWP>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.PlatformVars_WindowsUWP.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003D9C RID: 15772 RVA: 0x00015F9B File Offset: 0x0001419B
			public PlatformVars_WindowsUWP(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012E8 RID: 4840
			// (get) Token: 0x06003D9D RID: 15773 RVA: 0x0012526C File Offset: 0x0012346C
			// (set) Token: 0x06003D9E RID: 15774 RVA: 0x00015FA4 File Offset: 0x000141A4
			public unsafe bool useGamepadAPI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars_WindowsUWP.NativeFieldInfoPtr_useGamepadAPI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars_WindowsUWP.NativeFieldInfoPtr_useGamepadAPI)) = value;
				}
			}

			// Token: 0x170012E9 RID: 4841
			// (get) Token: 0x06003D9F RID: 15775 RVA: 0x00125294 File Offset: 0x00123494
			// (set) Token: 0x06003DA0 RID: 15776 RVA: 0x00015FBF File Offset: 0x000141BF
			public unsafe bool useHIDAPI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars_WindowsUWP.NativeFieldInfoPtr_useHIDAPI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars_WindowsUWP.NativeFieldInfoPtr_useHIDAPI)) = value;
				}
			}

			// Token: 0x04003320 RID: 13088
			private static readonly IntPtr NativeFieldInfoPtr_useGamepadAPI;

			// Token: 0x04003321 RID: 13089
			private static readonly IntPtr NativeFieldInfoPtr_useHIDAPI;

			// Token: 0x04003322 RID: 13090
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002BB RID: 699
		[Serializable]
		public class PlatformVars_Stadia : ConfigVars.PlatformVars
		{
			// Token: 0x06003DA1 RID: 15777 RVA: 0x001252BC File Offset: 0x001234BC
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformVars_Stadia()
			{
				Il2CppClassPointerStore<ConfigVars.PlatformVars_Stadia>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "PlatformVars_Stadia");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigVars.PlatformVars_Stadia>.NativeClassPtr);
				ConfigVars.PlatformVars_Stadia.NativeFieldInfoPtr_useNativeKeyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.PlatformVars_Stadia>.NativeClassPtr, "useNativeKeyboard");
				ConfigVars.PlatformVars_Stadia.NativeFieldInfoPtr_useNativeMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.PlatformVars_Stadia>.NativeClassPtr, "useNativeMouse");
				ConfigVars.PlatformVars_Stadia.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars.PlatformVars_Stadia>.NativeClassPtr, 100666564);
			}

			// Token: 0x06003DA2 RID: 15778 RVA: 0x00125324 File Offset: 0x00123524
			[CallerCount(0)]
			public unsafe PlatformVars_Stadia()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigVars.PlatformVars_Stadia>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.PlatformVars_Stadia.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003DA3 RID: 15779 RVA: 0x00015FDA File Offset: 0x000141DA
			public PlatformVars_Stadia(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012EA RID: 4842
			// (get) Token: 0x06003DA4 RID: 15780 RVA: 0x00125360 File Offset: 0x00123560
			// (set) Token: 0x06003DA5 RID: 15781 RVA: 0x00015FE3 File Offset: 0x000141E3
			public unsafe bool useNativeKeyboard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars_Stadia.NativeFieldInfoPtr_useNativeKeyboard);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars_Stadia.NativeFieldInfoPtr_useNativeKeyboard)) = value;
				}
			}

			// Token: 0x170012EB RID: 4843
			// (get) Token: 0x06003DA6 RID: 15782 RVA: 0x00125388 File Offset: 0x00123588
			// (set) Token: 0x06003DA7 RID: 15783 RVA: 0x00015FFE File Offset: 0x000141FE
			public unsafe bool useNativeMouse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars_Stadia.NativeFieldInfoPtr_useNativeMouse);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars_Stadia.NativeFieldInfoPtr_useNativeMouse)) = value;
				}
			}

			// Token: 0x04003323 RID: 13091
			private static readonly IntPtr NativeFieldInfoPtr_useNativeKeyboard;

			// Token: 0x04003324 RID: 13092
			private static readonly IntPtr NativeFieldInfoPtr_useNativeMouse;

			// Token: 0x04003325 RID: 13093
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002BC RID: 700
		[Serializable]
		public class PlatformVars_GameCoreXboxOne : ConfigVars.PlatformVars
		{
			// Token: 0x06003DA8 RID: 15784 RVA: 0x001253B0 File Offset: 0x001235B0
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformVars_GameCoreXboxOne()
			{
				Il2CppClassPointerStore<ConfigVars.PlatformVars_GameCoreXboxOne>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "PlatformVars_GameCoreXboxOne");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigVars.PlatformVars_GameCoreXboxOne>.NativeClassPtr);
				ConfigVars.PlatformVars_GameCoreXboxOne.NativeFieldInfoPtr_assignJoysticksByUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.PlatformVars_GameCoreXboxOne>.NativeClassPtr, "assignJoysticksByUserId");
				ConfigVars.PlatformVars_GameCoreXboxOne.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars.PlatformVars_GameCoreXboxOne>.NativeClassPtr, 100666565);
			}

			// Token: 0x06003DA9 RID: 15785 RVA: 0x00125404 File Offset: 0x00123604
			[CallerCount(0)]
			public unsafe PlatformVars_GameCoreXboxOne()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigVars.PlatformVars_GameCoreXboxOne>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.PlatformVars_GameCoreXboxOne.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003DAA RID: 15786 RVA: 0x00016019 File Offset: 0x00014219
			public PlatformVars_GameCoreXboxOne(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012EC RID: 4844
			// (get) Token: 0x06003DAB RID: 15787 RVA: 0x00125440 File Offset: 0x00123640
			// (set) Token: 0x06003DAC RID: 15788 RVA: 0x00016022 File Offset: 0x00014222
			public unsafe bool assignJoysticksByUserId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars_GameCoreXboxOne.NativeFieldInfoPtr_assignJoysticksByUserId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars_GameCoreXboxOne.NativeFieldInfoPtr_assignJoysticksByUserId)) = value;
				}
			}

			// Token: 0x04003326 RID: 13094
			private static readonly IntPtr NativeFieldInfoPtr_assignJoysticksByUserId;

			// Token: 0x04003327 RID: 13095
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002BD RID: 701
		[Serializable]
		public class PlatformVars_GameCoreScarlett : ConfigVars.PlatformVars
		{
			// Token: 0x06003DAD RID: 15789 RVA: 0x00125468 File Offset: 0x00123668
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformVars_GameCoreScarlett()
			{
				Il2CppClassPointerStore<ConfigVars.PlatformVars_GameCoreScarlett>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "PlatformVars_GameCoreScarlett");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigVars.PlatformVars_GameCoreScarlett>.NativeClassPtr);
				ConfigVars.PlatformVars_GameCoreScarlett.NativeFieldInfoPtr_assignJoysticksByUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.PlatformVars_GameCoreScarlett>.NativeClassPtr, "assignJoysticksByUserId");
				ConfigVars.PlatformVars_GameCoreScarlett.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars.PlatformVars_GameCoreScarlett>.NativeClassPtr, 100666566);
			}

			// Token: 0x06003DAE RID: 15790 RVA: 0x001254BC File Offset: 0x001236BC
			[CallerCount(0)]
			public unsafe PlatformVars_GameCoreScarlett()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigVars.PlatformVars_GameCoreScarlett>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.PlatformVars_GameCoreScarlett.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003DAF RID: 15791 RVA: 0x0001603D File Offset: 0x0001423D
			public PlatformVars_GameCoreScarlett(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012ED RID: 4845
			// (get) Token: 0x06003DB0 RID: 15792 RVA: 0x001254F8 File Offset: 0x001236F8
			// (set) Token: 0x06003DB1 RID: 15793 RVA: 0x00016046 File Offset: 0x00014246
			public unsafe bool assignJoysticksByUserId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars_GameCoreScarlett.NativeFieldInfoPtr_assignJoysticksByUserId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.PlatformVars_GameCoreScarlett.NativeFieldInfoPtr_assignJoysticksByUserId)) = value;
				}
			}

			// Token: 0x04003328 RID: 13096
			private static readonly IntPtr NativeFieldInfoPtr_assignJoysticksByUserId;

			// Token: 0x04003329 RID: 13097
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002BE RID: 702
		[Serializable]
		public sealed class EditorVars : Object
		{
			// Token: 0x06003DB2 RID: 15794 RVA: 0x00125520 File Offset: 0x00123720
			// Note: this type is marked as 'beforefieldinit'.
			static EditorVars()
			{
				Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "EditorVars");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr);
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_useParentClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_useParentClass");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_parentClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_parentClassName");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_useNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_useNamespace");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_namespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_namespace");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_actions");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_actionsClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_actionsClassName");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_actionsIncludeActionCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_actionsIncludeActionCategory");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_actionsCreateClassesForActionCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_actionsCreateClassesForActionCategories");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_mapCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_mapCategories");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_mapCategoriesClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_mapCategoriesClassName");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_layouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_layouts");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_layoutsClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_layoutsClassName");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_players");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_playersClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_playersClassName");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_inputBehaviors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_inputBehaviors");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_inputBehaviorsClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_inputBehaviorsClassName");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_customControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_customControllers");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_customControllersClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_customControllersClassName");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_customControllersAxesClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_customControllersAxesClassName");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_customControllersButtonsClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_customControllersButtonsClassName");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_layoutManagerRuleSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_layoutManagerRuleSets");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_layoutManagerRuleSetsClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_layoutManagerRuleSetsClassName");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_mapEnablerRuleSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_mapEnablerRuleSets");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_mapEnablerRuleSetsClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_mapEnablerRuleSetsClassName");
				ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_allCapsConstantNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, "exportConsts_allCapsConstantNames");
				ConfigVars.EditorVars.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr, 100666567);
			}

			// Token: 0x06003DB3 RID: 15795 RVA: 0x00125754 File Offset: 0x00123954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262137, XrefRangeEnd = 262160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EditorVars()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigVars.EditorVars>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.EditorVars.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003DB4 RID: 15796 RVA: 0x00016061 File Offset: 0x00014261
			public EditorVars(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012EE RID: 4846
			// (get) Token: 0x06003DB5 RID: 15797 RVA: 0x00125790 File Offset: 0x00123990
			// (set) Token: 0x06003DB6 RID: 15798 RVA: 0x0001606A File Offset: 0x0001426A
			public unsafe bool exportConsts_useParentClass
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_useParentClass);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_useParentClass)) = value;
				}
			}

			// Token: 0x170012EF RID: 4847
			// (get) Token: 0x06003DB7 RID: 15799 RVA: 0x001257B8 File Offset: 0x001239B8
			// (set) Token: 0x06003DB8 RID: 15800 RVA: 0x00016085 File Offset: 0x00014285
			public unsafe string exportConsts_parentClassName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_parentClassName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_parentClassName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012F0 RID: 4848
			// (get) Token: 0x06003DB9 RID: 15801 RVA: 0x001257E0 File Offset: 0x001239E0
			// (set) Token: 0x06003DBA RID: 15802 RVA: 0x000160A4 File Offset: 0x000142A4
			public unsafe bool exportConsts_useNamespace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_useNamespace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_useNamespace)) = value;
				}
			}

			// Token: 0x170012F1 RID: 4849
			// (get) Token: 0x06003DBB RID: 15803 RVA: 0x00125808 File Offset: 0x00123A08
			// (set) Token: 0x06003DBC RID: 15804 RVA: 0x000160BF File Offset: 0x000142BF
			public unsafe string exportConsts_namespace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_namespace);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_namespace), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012F2 RID: 4850
			// (get) Token: 0x06003DBD RID: 15805 RVA: 0x00125830 File Offset: 0x00123A30
			// (set) Token: 0x06003DBE RID: 15806 RVA: 0x000160DE File Offset: 0x000142DE
			public unsafe bool exportConsts_actions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_actions);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_actions)) = value;
				}
			}

			// Token: 0x170012F3 RID: 4851
			// (get) Token: 0x06003DBF RID: 15807 RVA: 0x00125858 File Offset: 0x00123A58
			// (set) Token: 0x06003DC0 RID: 15808 RVA: 0x000160F9 File Offset: 0x000142F9
			public unsafe string exportConsts_actionsClassName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_actionsClassName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_actionsClassName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012F4 RID: 4852
			// (get) Token: 0x06003DC1 RID: 15809 RVA: 0x00125880 File Offset: 0x00123A80
			// (set) Token: 0x06003DC2 RID: 15810 RVA: 0x00016118 File Offset: 0x00014318
			public unsafe bool exportConsts_actionsIncludeActionCategory
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_actionsIncludeActionCategory);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_actionsIncludeActionCategory)) = value;
				}
			}

			// Token: 0x170012F5 RID: 4853
			// (get) Token: 0x06003DC3 RID: 15811 RVA: 0x001258A8 File Offset: 0x00123AA8
			// (set) Token: 0x06003DC4 RID: 15812 RVA: 0x00016133 File Offset: 0x00014333
			public unsafe bool exportConsts_actionsCreateClassesForActionCategories
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_actionsCreateClassesForActionCategories);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_actionsCreateClassesForActionCategories)) = value;
				}
			}

			// Token: 0x170012F6 RID: 4854
			// (get) Token: 0x06003DC5 RID: 15813 RVA: 0x001258D0 File Offset: 0x00123AD0
			// (set) Token: 0x06003DC6 RID: 15814 RVA: 0x0001614E File Offset: 0x0001434E
			public unsafe bool exportConsts_mapCategories
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_mapCategories);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_mapCategories)) = value;
				}
			}

			// Token: 0x170012F7 RID: 4855
			// (get) Token: 0x06003DC7 RID: 15815 RVA: 0x001258F8 File Offset: 0x00123AF8
			// (set) Token: 0x06003DC8 RID: 15816 RVA: 0x00016169 File Offset: 0x00014369
			public unsafe string exportConsts_mapCategoriesClassName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_mapCategoriesClassName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_mapCategoriesClassName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012F8 RID: 4856
			// (get) Token: 0x06003DC9 RID: 15817 RVA: 0x00125920 File Offset: 0x00123B20
			// (set) Token: 0x06003DCA RID: 15818 RVA: 0x00016188 File Offset: 0x00014388
			public unsafe bool exportConsts_layouts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_layouts);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_layouts)) = value;
				}
			}

			// Token: 0x170012F9 RID: 4857
			// (get) Token: 0x06003DCB RID: 15819 RVA: 0x00125948 File Offset: 0x00123B48
			// (set) Token: 0x06003DCC RID: 15820 RVA: 0x000161A3 File Offset: 0x000143A3
			public unsafe string exportConsts_layoutsClassName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_layoutsClassName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_layoutsClassName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012FA RID: 4858
			// (get) Token: 0x06003DCD RID: 15821 RVA: 0x00125970 File Offset: 0x00123B70
			// (set) Token: 0x06003DCE RID: 15822 RVA: 0x000161C2 File Offset: 0x000143C2
			public unsafe bool exportConsts_players
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_players);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_players)) = value;
				}
			}

			// Token: 0x170012FB RID: 4859
			// (get) Token: 0x06003DCF RID: 15823 RVA: 0x00125998 File Offset: 0x00123B98
			// (set) Token: 0x06003DD0 RID: 15824 RVA: 0x000161DD File Offset: 0x000143DD
			public unsafe string exportConsts_playersClassName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_playersClassName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_playersClassName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012FC RID: 4860
			// (get) Token: 0x06003DD1 RID: 15825 RVA: 0x001259C0 File Offset: 0x00123BC0
			// (set) Token: 0x06003DD2 RID: 15826 RVA: 0x000161FC File Offset: 0x000143FC
			public unsafe bool exportConsts_inputBehaviors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_inputBehaviors);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_inputBehaviors)) = value;
				}
			}

			// Token: 0x170012FD RID: 4861
			// (get) Token: 0x06003DD3 RID: 15827 RVA: 0x001259E8 File Offset: 0x00123BE8
			// (set) Token: 0x06003DD4 RID: 15828 RVA: 0x00016217 File Offset: 0x00014417
			public unsafe string exportConsts_inputBehaviorsClassName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_inputBehaviorsClassName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_inputBehaviorsClassName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012FE RID: 4862
			// (get) Token: 0x06003DD5 RID: 15829 RVA: 0x00125A10 File Offset: 0x00123C10
			// (set) Token: 0x06003DD6 RID: 15830 RVA: 0x00016236 File Offset: 0x00014436
			public unsafe bool exportConsts_customControllers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_customControllers);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_customControllers)) = value;
				}
			}

			// Token: 0x170012FF RID: 4863
			// (get) Token: 0x06003DD7 RID: 15831 RVA: 0x00125A38 File Offset: 0x00123C38
			// (set) Token: 0x06003DD8 RID: 15832 RVA: 0x00016251 File Offset: 0x00014451
			public unsafe string exportConsts_customControllersClassName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_customControllersClassName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_customControllersClassName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001300 RID: 4864
			// (get) Token: 0x06003DD9 RID: 15833 RVA: 0x00125A60 File Offset: 0x00123C60
			// (set) Token: 0x06003DDA RID: 15834 RVA: 0x00016270 File Offset: 0x00014470
			public unsafe string exportConsts_customControllersAxesClassName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_customControllersAxesClassName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_customControllersAxesClassName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001301 RID: 4865
			// (get) Token: 0x06003DDB RID: 15835 RVA: 0x00125A88 File Offset: 0x00123C88
			// (set) Token: 0x06003DDC RID: 15836 RVA: 0x0001628F File Offset: 0x0001448F
			public unsafe string exportConsts_customControllersButtonsClassName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_customControllersButtonsClassName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_customControllersButtonsClassName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001302 RID: 4866
			// (get) Token: 0x06003DDD RID: 15837 RVA: 0x00125AB0 File Offset: 0x00123CB0
			// (set) Token: 0x06003DDE RID: 15838 RVA: 0x000162AE File Offset: 0x000144AE
			public unsafe bool exportConsts_layoutManagerRuleSets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_layoutManagerRuleSets);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_layoutManagerRuleSets)) = value;
				}
			}

			// Token: 0x17001303 RID: 4867
			// (get) Token: 0x06003DDF RID: 15839 RVA: 0x00125AD8 File Offset: 0x00123CD8
			// (set) Token: 0x06003DE0 RID: 15840 RVA: 0x000162C9 File Offset: 0x000144C9
			public unsafe string exportConsts_layoutManagerRuleSetsClassName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_layoutManagerRuleSetsClassName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_layoutManagerRuleSetsClassName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001304 RID: 4868
			// (get) Token: 0x06003DE1 RID: 15841 RVA: 0x00125B00 File Offset: 0x00123D00
			// (set) Token: 0x06003DE2 RID: 15842 RVA: 0x000162E8 File Offset: 0x000144E8
			public unsafe bool exportConsts_mapEnablerRuleSets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_mapEnablerRuleSets);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_mapEnablerRuleSets)) = value;
				}
			}

			// Token: 0x17001305 RID: 4869
			// (get) Token: 0x06003DE3 RID: 15843 RVA: 0x00125B28 File Offset: 0x00123D28
			// (set) Token: 0x06003DE4 RID: 15844 RVA: 0x00016303 File Offset: 0x00014503
			public unsafe string exportConsts_mapEnablerRuleSetsClassName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_mapEnablerRuleSetsClassName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_mapEnablerRuleSetsClassName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001306 RID: 4870
			// (get) Token: 0x06003DE5 RID: 15845 RVA: 0x00125B50 File Offset: 0x00123D50
			// (set) Token: 0x06003DE6 RID: 15846 RVA: 0x00016322 File Offset: 0x00014522
			public unsafe bool exportConsts_allCapsConstantNames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_allCapsConstantNames);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.EditorVars.NativeFieldInfoPtr_exportConsts_allCapsConstantNames)) = value;
				}
			}

			// Token: 0x0400332A RID: 13098
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_useParentClass;

			// Token: 0x0400332B RID: 13099
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_parentClassName;

			// Token: 0x0400332C RID: 13100
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_useNamespace;

			// Token: 0x0400332D RID: 13101
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_namespace;

			// Token: 0x0400332E RID: 13102
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_actions;

			// Token: 0x0400332F RID: 13103
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_actionsClassName;

			// Token: 0x04003330 RID: 13104
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_actionsIncludeActionCategory;

			// Token: 0x04003331 RID: 13105
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_actionsCreateClassesForActionCategories;

			// Token: 0x04003332 RID: 13106
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_mapCategories;

			// Token: 0x04003333 RID: 13107
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_mapCategoriesClassName;

			// Token: 0x04003334 RID: 13108
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_layouts;

			// Token: 0x04003335 RID: 13109
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_layoutsClassName;

			// Token: 0x04003336 RID: 13110
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_players;

			// Token: 0x04003337 RID: 13111
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_playersClassName;

			// Token: 0x04003338 RID: 13112
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_inputBehaviors;

			// Token: 0x04003339 RID: 13113
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_inputBehaviorsClassName;

			// Token: 0x0400333A RID: 13114
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_customControllers;

			// Token: 0x0400333B RID: 13115
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_customControllersClassName;

			// Token: 0x0400333C RID: 13116
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_customControllersAxesClassName;

			// Token: 0x0400333D RID: 13117
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_customControllersButtonsClassName;

			// Token: 0x0400333E RID: 13118
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_layoutManagerRuleSets;

			// Token: 0x0400333F RID: 13119
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_layoutManagerRuleSetsClassName;

			// Token: 0x04003340 RID: 13120
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_mapEnablerRuleSets;

			// Token: 0x04003341 RID: 13121
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_mapEnablerRuleSetsClassName;

			// Token: 0x04003342 RID: 13122
			private static readonly IntPtr NativeFieldInfoPtr_exportConsts_allCapsConstantNames;

			// Token: 0x04003343 RID: 13123
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002BF RID: 703
		public class OrbKWFwOjGZrOMASFSOZfbpzlJv : Object
		{
			// Token: 0x06003DE7 RID: 15847 RVA: 0x00125B78 File Offset: 0x00123D78
			// Note: this type is marked as 'beforefieldinit'.
			static OrbKWFwOjGZrOMASFSOZfbpzlJv()
			{
				Il2CppClassPointerStore<ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "OrbKWFwOjGZrOMASFSOZfbpzlJv");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv>.NativeClassPtr);
				ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv.NativeFieldInfoPtr_ISRUHQszopeuPTJsHwXvFnnSymK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv>.NativeClassPtr, "ISRUHQszopeuPTJsHwXvFnnSymK");
				ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv.NativeFieldInfoPtr_eDLKhUsveJtGPvQzyBpKMHTrgsT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv>.NativeClassPtr, "eDLKhUsveJtGPvQzyBpKMHTrgsT");
				ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv.NativeMethodInfoPtr__ctor_Public_Void_Func_1_PlatformVars_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv>.NativeClassPtr, 100666568);
			}

			// Token: 0x06003DE8 RID: 15848 RVA: 0x00125BE0 File Offset: 0x00123DE0
			[CallerCount(76)]
			[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OrbKWFwOjGZrOMASFSOZfbpzlJv(Func<ConfigVars.PlatformVars> getDelegate, string dataPath)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(getDelegate);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dataPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv.NativeMethodInfoPtr__ctor_Public_Void_Func_1_PlatformVars_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003DE9 RID: 15849 RVA: 0x0001633D File Offset: 0x0001453D
			public OrbKWFwOjGZrOMASFSOZfbpzlJv(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001307 RID: 4871
			// (get) Token: 0x06003DEA RID: 15850 RVA: 0x00125C40 File Offset: 0x00123E40
			// (set) Token: 0x06003DEB RID: 15851 RVA: 0x00016346 File Offset: 0x00014546
			public unsafe Func<ConfigVars.PlatformVars> ISRUHQszopeuPTJsHwXvFnnSymK
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv.NativeFieldInfoPtr_ISRUHQszopeuPTJsHwXvFnnSymK);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ConfigVars.PlatformVars>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv.NativeFieldInfoPtr_ISRUHQszopeuPTJsHwXvFnnSymK), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001308 RID: 4872
			// (get) Token: 0x06003DEC RID: 15852 RVA: 0x00125C70 File Offset: 0x00123E70
			// (set) Token: 0x06003DED RID: 15853 RVA: 0x00016365 File Offset: 0x00014565
			public unsafe string eDLKhUsveJtGPvQzyBpKMHTrgsT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv.NativeFieldInfoPtr_eDLKhUsveJtGPvQzyBpKMHTrgsT);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.OrbKWFwOjGZrOMASFSOZfbpzlJv.NativeFieldInfoPtr_eDLKhUsveJtGPvQzyBpKMHTrgsT), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003344 RID: 13124
			private static readonly IntPtr NativeFieldInfoPtr_ISRUHQszopeuPTJsHwXvFnnSymK;

			// Token: 0x04003345 RID: 13125
			private static readonly IntPtr NativeFieldInfoPtr_eDLKhUsveJtGPvQzyBpKMHTrgsT;

			// Token: 0x04003346 RID: 13126
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_PlatformVars_String_0;
		}

		// Token: 0x020002C0 RID: 704
		public class BeskwhpONorGAgNsHIAihRdquCY : Object
		{
			// Token: 0x06003DEE RID: 15854 RVA: 0x00125C98 File Offset: 0x00123E98
			// Note: this type is marked as 'beforefieldinit'.
			static BeskwhpONorGAgNsHIAihRdquCY()
			{
				Il2CppClassPointerStore<ConfigVars.BeskwhpONorGAgNsHIAihRdquCY>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigVars>.NativeClassPtr, "BeskwhpONorGAgNsHIAihRdquCY");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigVars.BeskwhpONorGAgNsHIAihRdquCY>.NativeClassPtr);
				ConfigVars.BeskwhpONorGAgNsHIAihRdquCY.NativeFieldInfoPtr_ISRUHQszopeuPTJsHwXvFnnSymK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.BeskwhpONorGAgNsHIAihRdquCY>.NativeClassPtr, "ISRUHQszopeuPTJsHwXvFnnSymK");
				ConfigVars.BeskwhpONorGAgNsHIAihRdquCY.NativeFieldInfoPtr_EyjlGIIqFnQcMbXkOosfKZaSYgI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigVars.BeskwhpONorGAgNsHIAihRdquCY>.NativeClassPtr, "EyjlGIIqFnQcMbXkOosfKZaSYgI");
				ConfigVars.BeskwhpONorGAgNsHIAihRdquCY.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Platform_Object_Action_2_Platform_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigVars.BeskwhpONorGAgNsHIAihRdquCY>.NativeClassPtr, 100666569);
			}

			// Token: 0x06003DEF RID: 15855 RVA: 0x00125D00 File Offset: 0x00123F00
			[CallerCount(76)]
			[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BeskwhpONorGAgNsHIAihRdquCY(Func<Il2CppRewired.Platforms.Platform, Object> getDelegate, Action<Il2CppRewired.Platforms.Platform, Object> setDelegate)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigVars.BeskwhpONorGAgNsHIAihRdquCY>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(getDelegate);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setDelegate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigVars.BeskwhpONorGAgNsHIAihRdquCY.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Platform_Object_Action_2_Platform_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003DF0 RID: 15856 RVA: 0x00016384 File Offset: 0x00014584
			public BeskwhpONorGAgNsHIAihRdquCY(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001309 RID: 4873
			// (get) Token: 0x06003DF1 RID: 15857 RVA: 0x00125D60 File Offset: 0x00123F60
			// (set) Token: 0x06003DF2 RID: 15858 RVA: 0x0001638D File Offset: 0x0001458D
			public unsafe Func<Il2CppRewired.Platforms.Platform, Object> ISRUHQszopeuPTJsHwXvFnnSymK
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.BeskwhpONorGAgNsHIAihRdquCY.NativeFieldInfoPtr_ISRUHQszopeuPTJsHwXvFnnSymK);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppRewired.Platforms.Platform, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.BeskwhpONorGAgNsHIAihRdquCY.NativeFieldInfoPtr_ISRUHQszopeuPTJsHwXvFnnSymK), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700130A RID: 4874
			// (get) Token: 0x06003DF3 RID: 15859 RVA: 0x00125D90 File Offset: 0x00123F90
			// (set) Token: 0x06003DF4 RID: 15860 RVA: 0x000163AC File Offset: 0x000145AC
			public unsafe Action<Il2CppRewired.Platforms.Platform, Object> EyjlGIIqFnQcMbXkOosfKZaSYgI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.BeskwhpONorGAgNsHIAihRdquCY.NativeFieldInfoPtr_EyjlGIIqFnQcMbXkOosfKZaSYgI);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppRewired.Platforms.Platform, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigVars.BeskwhpONorGAgNsHIAihRdquCY.NativeFieldInfoPtr_EyjlGIIqFnQcMbXkOosfKZaSYgI), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003347 RID: 13127
			private static readonly IntPtr NativeFieldInfoPtr_ISRUHQszopeuPTJsHwXvFnnSymK;

			// Token: 0x04003348 RID: 13128
			private static readonly IntPtr NativeFieldInfoPtr_EyjlGIIqFnQcMbXkOosfKZaSYgI;

			// Token: 0x04003349 RID: 13129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_Platform_Object_Action_2_Platform_Object_0;
		}

		// Token: 0x020002C1 RID: 705
		[OriginalName("Rewired_Core.dll", "", "AllPlatformVar")]
		public enum AllPlatformVar
		{
			// Token: 0x0400334B RID: 13131
			DisableKeyboard,
			// Token: 0x0400334C RID: 13132
			IgnoreInputWhenAppNotInFocus
		}

		// Token: 0x020002C2 RID: 706
		private sealed class MethodInfoStoreGeneric_Editor_GetAllSerializedPlatformVar_Internal_T_AllPlatformVar_0<T>
		{
			// Token: 0x0400334D RID: 13133
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConfigVars.NativeMethodInfoPtr_Editor_GetAllSerializedPlatformVar_Internal_T_AllPlatformVar_0, Il2CppClassPointerStore<ConfigVars>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002C3 RID: 707
		private sealed class MethodInfoStoreGeneric_GetOrCreatePlatformVars_Private_T_byref_T_0<T>
		{
			// Token: 0x0400334E RID: 13134
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConfigVars.NativeMethodInfoPtr_GetOrCreatePlatformVars_Private_T_byref_T_0, Il2CppClassPointerStore<ConfigVars>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
