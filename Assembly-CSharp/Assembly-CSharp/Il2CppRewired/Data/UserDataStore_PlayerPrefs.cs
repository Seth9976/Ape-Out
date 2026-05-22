using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Data
{
	// Token: 0x020001E6 RID: 486
	public class UserDataStore_PlayerPrefs : UserDataStore
	{
		// Token: 0x0600388D RID: 14477 RVA: 0x000D2824 File Offset: 0x000D0A24
		// Note: this type is marked as 'beforefieldinit'.
		static UserDataStore_PlayerPrefs()
		{
			Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Data", "UserDataStore_PlayerPrefs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr);
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_thisScriptName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "thisScriptName");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_logPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "logPrefix");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_editorLoadedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "editorLoadedMessage");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_playerPrefsKeySuffix_controllerAssignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "playerPrefsKeySuffix_controllerAssignments");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_original = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "controllerMapPPKeyVersion_original");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_includeDuplicateJoystickIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "controllerMapPPKeyVersion_includeDuplicateJoystickIndex");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_supportDisconnectedControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "controllerMapPPKeyVersion_supportDisconnectedControllers");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_includeFormatVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "controllerMapPPKeyVersion_includeFormatVersion");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "controllerMapPPKeyVersion");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_isEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "isEnabled");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadDataOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "loadDataOnStart");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadJoystickAssignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "loadJoystickAssignments");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadKeyboardAssignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "loadKeyboardAssignments");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadMouseAssignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "loadMouseAssignments");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_playerPrefsKeyPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "playerPrefsKeyPrefix");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_allowImpreciseJoystickAssignmentMatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "allowImpreciseJoystickAssignmentMatching");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_deferredJoystickAssignmentLoadPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "deferredJoystickAssignmentLoadPending");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr_wasJoystickEverDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "wasJoystickEverDetected");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr___allActionIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "__allActionIds");
			UserDataStore_PlayerPrefs.NativeFieldInfoPtr___allActionIdsString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "__allActionIdsString");
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667942);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_IsEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667943);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_LoadDataOnStart_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667944);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_LoadDataOnStart_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667945);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_LoadJoystickAssignments_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667946);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_LoadJoystickAssignments_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667947);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_LoadKeyboardAssignments_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667948);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_LoadKeyboardAssignments_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667949);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_LoadMouseAssignments_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667950);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_LoadMouseAssignments_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667951);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_PlayerPrefsKeyPrefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667952);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_PlayerPrefsKeyPrefix_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667953);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_playerPrefsKey_controllerAssignments_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667954);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_loadControllerAssignments_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667955);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_allActionIds_Private_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667956);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_allActionIdsString_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667957);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_Save_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667958);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667959);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667960);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SavePlayerData_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667961);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveInputBehavior_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667962);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_Load_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667963);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667964);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667965);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadPlayerData_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667966);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadInputBehavior_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667967);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667968);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_OnControllerConnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667969);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_OnControllerPreDisconnect_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667970);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_OnControllerDisconnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667971);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerMap_Public_Virtual_Void_Int32_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667972);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerMap_Public_Virtual_ControllerMap_Int32_ControllerIdentifier_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667973);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadAll_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667974);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667975);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667976);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadAllJoystickCalibrationData_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667977);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667978);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667979);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickData_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667980);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667981);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667982);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerMaps_Private_Int32_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667983);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerMap_Private_ControllerMap_Player_ControllerIdentifier_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667984);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadInputBehaviors_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667985);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667986);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Player_InputBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667987);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerAssignmentsNow_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667988);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadKeyboardAndMouseAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667989);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667990);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerAssignmentData_Private_ControllerAssignmentSaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667991);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickAssignmentsDeferred_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667992);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667993);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667994);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667995);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveAllJoystickCalibrationData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667996);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667997);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667998);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveJoystickData_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100667999);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668000);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668001);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Player_PlayerSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668002);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668003);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerMap_Private_Void_Player_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668004);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveInputBehaviors_Private_Void_Player_PlayerSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668005);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668006);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Player_InputBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668007);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerAssignments_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668008);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_ControllerAssignmentSaveDataExists_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668009);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetBasePlayerPrefsKey_Private_String_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668010);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668011);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapKnownActionIdsPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668012);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapPlayerPrefsKeyCommonSuffix_Private_Static_String_Player_ControllerIdentifier_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668013);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetJoystickCalibrationMapPlayerPrefsKey_Private_String_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668014);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetInputBehaviorPlayerPrefsKey_Private_String_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668015);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapXml_Private_String_Player_ControllerIdentifier_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668016);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapKnownActionIds_Private_List_1_Int32_Player_ControllerIdentifier_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668017);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetJoystickCalibrationMapXml_Private_String_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668018);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetInputBehaviorXml_Private_String_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668019);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_AddDefaultMappingsForNewActions_Private_Void_ControllerIdentifier_ControllerMap_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668020);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_FindJoystickPrecise_Private_Joystick_JoystickInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668021);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_TryFindJoysticksImprecise_Private_Boolean_JoystickInfo_byref_List_1_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668022);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetDuplicateIndex_Private_Static_Int32_Player_ControllerIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668023);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_RefreshLayoutManager_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668024);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapType_Private_Static_Type_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668025);
			UserDataStore_PlayerPrefs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100668026);
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x0600388E RID: 14478 RVA: 0x000D3088 File Offset: 0x000D1288
		// (set) Token: 0x0600388F RID: 14479 RVA: 0x000D30C4 File Offset: 0x000D12C4
		public unsafe bool IsEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_IsEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06003890 RID: 14480 RVA: 0x000D3104 File Offset: 0x000D1304
		// (set) Token: 0x06003891 RID: 14481 RVA: 0x000D3140 File Offset: 0x000D1340
		public unsafe bool LoadDataOnStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_LoadDataOnStart_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_LoadDataOnStart_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06003892 RID: 14482 RVA: 0x000D3180 File Offset: 0x000D1380
		// (set) Token: 0x06003893 RID: 14483 RVA: 0x000D31BC File Offset: 0x000D13BC
		public unsafe bool LoadJoystickAssignments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_LoadJoystickAssignments_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_LoadJoystickAssignments_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x06003894 RID: 14484 RVA: 0x000D31FC File Offset: 0x000D13FC
		// (set) Token: 0x06003895 RID: 14485 RVA: 0x000D3238 File Offset: 0x000D1438
		public unsafe bool LoadKeyboardAssignments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_LoadKeyboardAssignments_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_LoadKeyboardAssignments_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x06003896 RID: 14486 RVA: 0x000D3278 File Offset: 0x000D1478
		// (set) Token: 0x06003897 RID: 14487 RVA: 0x000D32B4 File Offset: 0x000D14B4
		public unsafe bool LoadMouseAssignments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_LoadMouseAssignments_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_LoadMouseAssignments_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x06003898 RID: 14488 RVA: 0x000D32F4 File Offset: 0x000D14F4
		// (set) Token: 0x06003899 RID: 14489 RVA: 0x000D332C File Offset: 0x000D152C
		public unsafe string PlayerPrefsKeyPrefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_PlayerPrefsKeyPrefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_PlayerPrefsKeyPrefix_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x0600389A RID: 14490 RVA: 0x000D3370 File Offset: 0x000D1570
		public unsafe string playerPrefsKey_controllerAssignments
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87489, XrefRangeEnd = 87494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_playerPrefsKey_controllerAssignments_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x0600389B RID: 14491 RVA: 0x000D33A8 File Offset: 0x000D15A8
		public unsafe bool loadControllerAssignments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_loadControllerAssignments_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x0600389C RID: 14492 RVA: 0x000D33E4 File Offset: 0x000D15E4
		public unsafe List<int> allActionIds
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 87516, RefRangeEnd = 87518, XrefRangeStart = 87494, XrefRangeEnd = 87516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_allActionIds_Private_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x0600389D RID: 14493 RVA: 0x000D3424 File Offset: 0x000D1624
		public unsafe string allActionIdsString
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 87533, RefRangeEnd = 87534, XrefRangeStart = 87518, XrefRangeEnd = 87533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_allActionIdsString_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x000D345C File Offset: 0x000D165C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87534, XrefRangeEnd = 87541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_Save_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x000D3498 File Offset: 0x000D1698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87541, XrefRangeEnd = 87554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x000D3500 File Offset: 0x000D1700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87554, XrefRangeEnd = 87565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SaveControllerData(ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x000D3558 File Offset: 0x000D1758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87565, XrefRangeEnd = 87582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SavePlayerData(int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SavePlayerData_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x000D35A4 File Offset: 0x000D17A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87582, XrefRangeEnd = 87598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SaveInputBehavior(int playerId, int behaviorId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviorId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveInputBehavior_Public_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x000D35FC File Offset: 0x000D17FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87598, XrefRangeEnd = 87605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_Load_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x000D3638 File Offset: 0x000D1838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87605, XrefRangeEnd = 87615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x000D36A0 File Offset: 0x000D18A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87615, XrefRangeEnd = 87622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LoadControllerData(ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x000D36F8 File Offset: 0x000D18F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87622, XrefRangeEnd = 87635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LoadPlayerData(int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadPlayerData_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x000D3744 File Offset: 0x000D1944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87635, XrefRangeEnd = 87647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LoadInputBehavior(int playerId, int behaviorId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviorId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadInputBehavior_Public_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x000D379C File Offset: 0x000D199C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87647, XrefRangeEnd = 87653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x000D37D8 File Offset: 0x000D19D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87653, XrefRangeEnd = 87659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_OnControllerConnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x000D3828 File Offset: 0x000D1A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87659, XrefRangeEnd = 87660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_OnControllerPreDisconnect_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x000D3878 File Offset: 0x000D1A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87660, XrefRangeEnd = 87661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_OnControllerDisconnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x000D38C8 File Offset: 0x000D1AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87661, XrefRangeEnd = 87667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SaveControllerMap(int playerId, ControllerMap controllerMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controllerMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerMap_Public_Virtual_Void_Int32_ControllerMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x000D3924 File Offset: 0x000D1B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87667, XrefRangeEnd = 87673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(controllerIdentifier));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layoutId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerMap_Public_Virtual_ControllerMap_Int32_ControllerIdentifier_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr3) : null;
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x000D39B0 File Offset: 0x000D1BB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87690, RefRangeEnd = 87691, XrefRangeStart = 87673, XrefRangeEnd = 87690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LoadAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadAll_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x000D39EC File Offset: 0x000D1BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87691, XrefRangeEnd = 87698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LoadPlayerDataNow(int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x000D3A38 File Offset: 0x000D1C38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 87725, RefRangeEnd = 87728, XrefRangeStart = 87698, XrefRangeEnd = 87725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LoadPlayerDataNow(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x000D3A88 File Offset: 0x000D1C88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87743, RefRangeEnd = 87744, XrefRangeStart = 87728, XrefRangeEnd = 87743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LoadAllJoystickCalibrationData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadAllJoystickCalibrationData_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x000D3AC4 File Offset: 0x000D1CC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 87752, RefRangeEnd = 87755, XrefRangeStart = 87744, XrefRangeEnd = 87752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LoadJoystickCalibrationData(Joystick joystick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(joystick);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x000D3B14 File Offset: 0x000D1D14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 87762, RefRangeEnd = 87766, XrefRangeStart = 87755, XrefRangeEnd = 87762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LoadJoystickCalibrationData(int joystickId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref joystickId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x000D3B60 File Offset: 0x000D1D60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87801, RefRangeEnd = 87802, XrefRangeStart = 87766, XrefRangeEnd = 87801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LoadJoystickData(int joystickId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref joystickId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickData_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x000D3BAC File Offset: 0x000D1DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87802, XrefRangeEnd = 87806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_Int32_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x000D3C14 File Offset: 0x000D1E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87806, XrefRangeEnd = 87807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LoadControllerDataNow(ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x000D3C6C File Offset: 0x000D1E6C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 87849, RefRangeEnd = 87855, XrefRangeStart = 87807, XrefRangeEnd = 87849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerMaps_Private_Int32_Int32_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x000D3CD4 File Offset: 0x000D1ED4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87859, RefRangeEnd = 87861, XrefRangeStart = 87855, XrefRangeEnd = 87859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(controllerIdentifier));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layoutId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerMap_Private_ControllerMap_Player_ControllerIdentifier_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr3) : null;
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x000D3D58 File Offset: 0x000D1F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87881, RefRangeEnd = 87882, XrefRangeStart = 87861, XrefRangeEnd = 87881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LoadInputBehaviors(int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadInputBehaviors_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x000D3DA4 File Offset: 0x000D1FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87882, XrefRangeEnd = 87892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LoadInputBehaviorNow(int playerId, int behaviorId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviorId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x000D3DFC File Offset: 0x000D1FFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 87902, RefRangeEnd = 87905, XrefRangeStart = 87892, XrefRangeEnd = 87902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputBehavior);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Player_InputBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x000D3E5C File Offset: 0x000D205C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87909, RefRangeEnd = 87910, XrefRangeStart = 87905, XrefRangeEnd = 87909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LoadControllerAssignmentsNow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerAssignmentsNow_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x000D3E98 File Offset: 0x000D2098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87916, RefRangeEnd = 87917, XrefRangeStart = 87910, XrefRangeEnd = 87916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LoadKeyboardAndMouseAssignmentsNow(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadKeyboardAndMouseAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x000D3EE8 File Offset: 0x000D20E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88053, RefRangeEnd = 88054, XrefRangeStart = 87917, XrefRangeEnd = 88053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LoadJoystickAssignmentsNow(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x000D3F38 File Offset: 0x000D2138
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88080, RefRangeEnd = 88083, XrefRangeStart = 88054, XrefRangeEnd = 88080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo LoadControllerAssignmentData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerAssignmentData_Private_ControllerAssignmentSaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>(intPtr3) : null;
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x000D3F78 File Offset: 0x000D2178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88083, XrefRangeEnd = 88086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadJoystickAssignmentsDeferred()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickAssignmentsDeferred_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x000D3FB8 File Offset: 0x000D21B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88108, RefRangeEnd = 88109, XrefRangeStart = 88086, XrefRangeEnd = 88108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x000D3FEC File Offset: 0x000D21EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88109, XrefRangeEnd = 88120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SavePlayerDataNow(int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x000D402C File Offset: 0x000D222C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88126, RefRangeEnd = 88129, XrefRangeStart = 88120, XrefRangeEnd = 88126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SavePlayerDataNow(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x000D4070 File Offset: 0x000D2270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88144, RefRangeEnd = 88145, XrefRangeStart = 88129, XrefRangeEnd = 88144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveAllJoystickCalibrationData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveAllJoystickCalibrationData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x000D40A4 File Offset: 0x000D22A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 88152, RefRangeEnd = 88156, XrefRangeStart = 88145, XrefRangeEnd = 88152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveJoystickCalibrationData(int joystickId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref joystickId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x000D40E4 File Offset: 0x000D22E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88168, RefRangeEnd = 88171, XrefRangeStart = 88156, XrefRangeEnd = 88168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveJoystickCalibrationData(Joystick joystick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(joystick);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x000D4128 File Offset: 0x000D2328
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88205, RefRangeEnd = 88206, XrefRangeStart = 88171, XrefRangeEnd = 88205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveJoystickData(int joystickId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref joystickId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveJoystickData_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x000D4168 File Offset: 0x000D2368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88206, XrefRangeEnd = 88216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_Int32_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x000D41C4 File Offset: 0x000D23C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88216, XrefRangeEnd = 88221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveControllerDataNow(ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038CA RID: 14538 RVA: 0x000D4210 File Offset: 0x000D2410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88239, RefRangeEnd = 88240, XrefRangeStart = 88221, XrefRangeEnd = 88239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(playerSaveData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Player_PlayerSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038CB RID: 14539 RVA: 0x000D426C File Offset: 0x000D246C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88260, RefRangeEnd = 88263, XrefRangeStart = 88240, XrefRangeEnd = 88260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Int32_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038CC RID: 14540 RVA: 0x000D42C8 File Offset: 0x000D24C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88276, RefRangeEnd = 88279, XrefRangeStart = 88263, XrefRangeEnd = 88276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveControllerMap(Player player, ControllerMap controllerMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controllerMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerMap_Private_Void_Player_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x000D431C File Offset: 0x000D251C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88279, XrefRangeEnd = 88283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(playerSaveData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveInputBehaviors_Private_Void_Player_PlayerSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x000D4378 File Offset: 0x000D2578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88283, XrefRangeEnd = 88297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveInputBehaviorNow(int playerId, int behaviorId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviorId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x000D43C4 File Offset: 0x000D25C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88297, XrefRangeEnd = 88300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputBehavior);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Player_InputBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x000D4418 File Offset: 0x000D2618
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 88352, RefRangeEnd = 88356, XrefRangeStart = 88300, XrefRangeEnd = 88352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SaveControllerAssignments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerAssignments_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x000D4454 File Offset: 0x000D2654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88356, XrefRangeEnd = 88369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ControllerAssignmentSaveDataExists()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_ControllerAssignmentSaveDataExists_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x000D4490 File Offset: 0x000D2690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88369, XrefRangeEnd = 88374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetBasePlayerPrefsKey(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetBasePlayerPrefsKey_Private_String_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x000D44D8 File Offset: 0x000D26D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88384, RefRangeEnd = 88387, XrefRangeStart = 88374, XrefRangeEnd = 88384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(controllerIdentifier));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layoutId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ppKeyVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x000D4564 File Offset: 0x000D2764
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88397, RefRangeEnd = 88399, XrefRangeStart = 88387, XrefRangeEnd = 88397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(controllerIdentifier));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layoutId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ppKeyVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapKnownActionIdsPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x000D45F0 File Offset: 0x000D27F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88462, RefRangeEnd = 88464, XrefRangeStart = 88399, XrefRangeEnd = 88462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(controllerIdentifier));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layoutId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ppKeyVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapPlayerPrefsKeyCommonSuffix_Private_Static_String_Player_ControllerIdentifier_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x000D4670 File Offset: 0x000D2870
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88485, RefRangeEnd = 88488, XrefRangeStart = 88464, XrefRangeEnd = 88485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(joystick);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetJoystickCalibrationMapPlayerPrefsKey_Private_String_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x000D46B8 File Offset: 0x000D28B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 88501, RefRangeEnd = 88508, XrefRangeStart = 88488, XrefRangeEnd = 88501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputBehaviorId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetInputBehaviorPlayerPrefsKey_Private_String_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x000D4710 File Offset: 0x000D2910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88508, XrefRangeEnd = 88513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(controllerIdentifier));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layoutId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapXml_Private_String_Player_ControllerIdentifier_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x000D478C File Offset: 0x000D298C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88513, XrefRangeEnd = 88524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(controllerIdentifier));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layoutId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapKnownActionIds_Private_List_1_Int32_Player_ControllerIdentifier_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x000D4810 File Offset: 0x000D2A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88524, XrefRangeEnd = 88530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetJoystickCalibrationMapXml(Joystick joystick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(joystick);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetJoystickCalibrationMapXml_Private_String_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x000D4858 File Offset: 0x000D2A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88530, XrefRangeEnd = 88536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetInputBehaviorXml(Player player, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetInputBehaviorXml_Private_String_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x000D48B0 File Offset: 0x000D2AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88536, XrefRangeEnd = 88583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(controllerIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controllerMap);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(knownActionIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_AddDefaultMappingsForNewActions_Private_Void_ControllerIdentifier_ControllerMap_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x000D491C File Offset: 0x000D2B1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88604, RefRangeEnd = 88605, XrefRangeStart = 88583, XrefRangeEnd = 88604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Joystick FindJoystickPrecise(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(joystickInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_FindJoystickPrecise_Private_Joystick_JoystickInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Joystick>(intPtr3) : null;
			}
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x000D496C File Offset: 0x000D2B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88635, RefRangeEnd = 88636, XrefRangeStart = 88605, XrefRangeEnd = 88635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryFindJoysticksImprecise(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(joystickInfo);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_TryFindJoysticksImprecise_Private_Boolean_JoystickInfo_byref_List_1_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			matches = ((intPtr4 == 0) ? null : new List<Joystick>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x000D49DC File Offset: 0x000D2BDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88690, RefRangeEnd = 88691, XrefRangeStart = 88636, XrefRangeEnd = 88690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(controllerIdentifier));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetDuplicateIndex_Private_Static_Int32_Player_ControllerIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x000D4A34 File Offset: 0x000D2C34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 88697, RefRangeEnd = 88701, XrefRangeStart = 88691, XrefRangeEnd = 88697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshLayoutManager(int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_RefreshLayoutManager_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x000D4A74 File Offset: 0x000D2C74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88716, RefRangeEnd = 88717, XrefRangeStart = 88701, XrefRangeEnd = 88716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetControllerMapType(ControllerType controllerType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapType_Private_Static_Type_ControllerType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x000D4AB4 File Offset: 0x000D2CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88717, XrefRangeEnd = 88722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserDataStore_PlayerPrefs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x0002440A File Offset: 0x0002260A
		public UserDataStore_PlayerPrefs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x060038E4 RID: 14564 RVA: 0x000D4AF0 File Offset: 0x000D2CF0
		// (set) Token: 0x060038E5 RID: 14565 RVA: 0x00024413 File Offset: 0x00022613
		public unsafe static string thisScriptName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_thisScriptName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_thisScriptName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x060038E6 RID: 14566 RVA: 0x000D4B10 File Offset: 0x000D2D10
		// (set) Token: 0x060038E7 RID: 14567 RVA: 0x00024425 File Offset: 0x00022625
		public unsafe static string logPrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_logPrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_logPrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x060038E8 RID: 14568 RVA: 0x000D4B30 File Offset: 0x000D2D30
		// (set) Token: 0x060038E9 RID: 14569 RVA: 0x00024437 File Offset: 0x00022637
		public unsafe static string editorLoadedMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_editorLoadedMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_editorLoadedMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x060038EA RID: 14570 RVA: 0x000D4B50 File Offset: 0x000D2D50
		// (set) Token: 0x060038EB RID: 14571 RVA: 0x00024449 File Offset: 0x00022649
		public unsafe static string playerPrefsKeySuffix_controllerAssignments
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_playerPrefsKeySuffix_controllerAssignments, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_playerPrefsKeySuffix_controllerAssignments, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x060038EC RID: 14572 RVA: 0x000D4B70 File Offset: 0x000D2D70
		// (set) Token: 0x060038ED RID: 14573 RVA: 0x0002445B File Offset: 0x0002265B
		public unsafe static int controllerMapPPKeyVersion_original
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_original, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_original, (void*)(&value));
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x060038EE RID: 14574 RVA: 0x000D4B8C File Offset: 0x000D2D8C
		// (set) Token: 0x060038EF RID: 14575 RVA: 0x00024469 File Offset: 0x00022669
		public unsafe static int controllerMapPPKeyVersion_includeDuplicateJoystickIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_includeDuplicateJoystickIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_includeDuplicateJoystickIndex, (void*)(&value));
			}
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x060038F0 RID: 14576 RVA: 0x000D4BA8 File Offset: 0x000D2DA8
		// (set) Token: 0x060038F1 RID: 14577 RVA: 0x00024477 File Offset: 0x00022677
		public unsafe static int controllerMapPPKeyVersion_supportDisconnectedControllers
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_supportDisconnectedControllers, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_supportDisconnectedControllers, (void*)(&value));
			}
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x060038F2 RID: 14578 RVA: 0x000D4BC4 File Offset: 0x000D2DC4
		// (set) Token: 0x060038F3 RID: 14579 RVA: 0x00024485 File Offset: 0x00022685
		public unsafe static int controllerMapPPKeyVersion_includeFormatVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_includeFormatVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_includeFormatVersion, (void*)(&value));
			}
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x060038F4 RID: 14580 RVA: 0x000D4BE0 File Offset: 0x000D2DE0
		// (set) Token: 0x060038F5 RID: 14581 RVA: 0x00024493 File Offset: 0x00022693
		public unsafe static int controllerMapPPKeyVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion, (void*)(&value));
			}
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x060038F6 RID: 14582 RVA: 0x000D4BFC File Offset: 0x000D2DFC
		// (set) Token: 0x060038F7 RID: 14583 RVA: 0x000244A1 File Offset: 0x000226A1
		public unsafe bool isEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_isEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_isEnabled)) = value;
			}
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x060038F8 RID: 14584 RVA: 0x000D4C24 File Offset: 0x000D2E24
		// (set) Token: 0x060038F9 RID: 14585 RVA: 0x000244BC File Offset: 0x000226BC
		public unsafe bool loadDataOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadDataOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadDataOnStart)) = value;
			}
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x060038FA RID: 14586 RVA: 0x000D4C4C File Offset: 0x000D2E4C
		// (set) Token: 0x060038FB RID: 14587 RVA: 0x000244D7 File Offset: 0x000226D7
		public unsafe bool loadJoystickAssignments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadJoystickAssignments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadJoystickAssignments)) = value;
			}
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x060038FC RID: 14588 RVA: 0x000D4C74 File Offset: 0x000D2E74
		// (set) Token: 0x060038FD RID: 14589 RVA: 0x000244F2 File Offset: 0x000226F2
		public unsafe bool loadKeyboardAssignments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadKeyboardAssignments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadKeyboardAssignments)) = value;
			}
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x060038FE RID: 14590 RVA: 0x000D4C9C File Offset: 0x000D2E9C
		// (set) Token: 0x060038FF RID: 14591 RVA: 0x0002450D File Offset: 0x0002270D
		public unsafe bool loadMouseAssignments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadMouseAssignments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadMouseAssignments)) = value;
			}
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06003900 RID: 14592 RVA: 0x000D4CC4 File Offset: 0x000D2EC4
		// (set) Token: 0x06003901 RID: 14593 RVA: 0x00024528 File Offset: 0x00022728
		public unsafe string playerPrefsKeyPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_playerPrefsKeyPrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_playerPrefsKeyPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06003902 RID: 14594 RVA: 0x000D4CEC File Offset: 0x000D2EEC
		// (set) Token: 0x06003903 RID: 14595 RVA: 0x00024547 File Offset: 0x00022747
		public unsafe bool allowImpreciseJoystickAssignmentMatching
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_allowImpreciseJoystickAssignmentMatching);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_allowImpreciseJoystickAssignmentMatching)) = value;
			}
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06003904 RID: 14596 RVA: 0x000D4D14 File Offset: 0x000D2F14
		// (set) Token: 0x06003905 RID: 14597 RVA: 0x00024562 File Offset: 0x00022762
		public unsafe bool deferredJoystickAssignmentLoadPending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_deferredJoystickAssignmentLoadPending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_deferredJoystickAssignmentLoadPending)) = value;
			}
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06003906 RID: 14598 RVA: 0x000D4D3C File Offset: 0x000D2F3C
		// (set) Token: 0x06003907 RID: 14599 RVA: 0x0002457D File Offset: 0x0002277D
		public unsafe bool wasJoystickEverDetected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_wasJoystickEverDetected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_wasJoystickEverDetected)) = value;
			}
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06003908 RID: 14600 RVA: 0x000D4D64 File Offset: 0x000D2F64
		// (set) Token: 0x06003909 RID: 14601 RVA: 0x00024598 File Offset: 0x00022798
		public unsafe List<int> __allActionIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr___allActionIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr___allActionIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x0600390A RID: 14602 RVA: 0x000D4D94 File Offset: 0x000D2F94
		// (set) Token: 0x0600390B RID: 14603 RVA: 0x000245B7 File Offset: 0x000227B7
		public unsafe string __allActionIdsString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr___allActionIdsString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr___allActionIdsString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040021BA RID: 8634
		private static readonly IntPtr NativeFieldInfoPtr_thisScriptName;

		// Token: 0x040021BB RID: 8635
		private static readonly IntPtr NativeFieldInfoPtr_logPrefix;

		// Token: 0x040021BC RID: 8636
		private static readonly IntPtr NativeFieldInfoPtr_editorLoadedMessage;

		// Token: 0x040021BD RID: 8637
		private static readonly IntPtr NativeFieldInfoPtr_playerPrefsKeySuffix_controllerAssignments;

		// Token: 0x040021BE RID: 8638
		private static readonly IntPtr NativeFieldInfoPtr_controllerMapPPKeyVersion_original;

		// Token: 0x040021BF RID: 8639
		private static readonly IntPtr NativeFieldInfoPtr_controllerMapPPKeyVersion_includeDuplicateJoystickIndex;

		// Token: 0x040021C0 RID: 8640
		private static readonly IntPtr NativeFieldInfoPtr_controllerMapPPKeyVersion_supportDisconnectedControllers;

		// Token: 0x040021C1 RID: 8641
		private static readonly IntPtr NativeFieldInfoPtr_controllerMapPPKeyVersion_includeFormatVersion;

		// Token: 0x040021C2 RID: 8642
		private static readonly IntPtr NativeFieldInfoPtr_controllerMapPPKeyVersion;

		// Token: 0x040021C3 RID: 8643
		private static readonly IntPtr NativeFieldInfoPtr_isEnabled;

		// Token: 0x040021C4 RID: 8644
		private static readonly IntPtr NativeFieldInfoPtr_loadDataOnStart;

		// Token: 0x040021C5 RID: 8645
		private static readonly IntPtr NativeFieldInfoPtr_loadJoystickAssignments;

		// Token: 0x040021C6 RID: 8646
		private static readonly IntPtr NativeFieldInfoPtr_loadKeyboardAssignments;

		// Token: 0x040021C7 RID: 8647
		private static readonly IntPtr NativeFieldInfoPtr_loadMouseAssignments;

		// Token: 0x040021C8 RID: 8648
		private static readonly IntPtr NativeFieldInfoPtr_playerPrefsKeyPrefix;

		// Token: 0x040021C9 RID: 8649
		private static readonly IntPtr NativeFieldInfoPtr_allowImpreciseJoystickAssignmentMatching;

		// Token: 0x040021CA RID: 8650
		private static readonly IntPtr NativeFieldInfoPtr_deferredJoystickAssignmentLoadPending;

		// Token: 0x040021CB RID: 8651
		private static readonly IntPtr NativeFieldInfoPtr_wasJoystickEverDetected;

		// Token: 0x040021CC RID: 8652
		private static readonly IntPtr NativeFieldInfoPtr___allActionIds;

		// Token: 0x040021CD RID: 8653
		private static readonly IntPtr NativeFieldInfoPtr___allActionIdsString;

		// Token: 0x040021CE RID: 8654
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;

		// Token: 0x040021CF RID: 8655
		private static readonly IntPtr NativeMethodInfoPtr_set_IsEnabled_Public_set_Void_Boolean_0;

		// Token: 0x040021D0 RID: 8656
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadDataOnStart_Public_get_Boolean_0;

		// Token: 0x040021D1 RID: 8657
		private static readonly IntPtr NativeMethodInfoPtr_set_LoadDataOnStart_Public_set_Void_Boolean_0;

		// Token: 0x040021D2 RID: 8658
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadJoystickAssignments_Public_get_Boolean_0;

		// Token: 0x040021D3 RID: 8659
		private static readonly IntPtr NativeMethodInfoPtr_set_LoadJoystickAssignments_Public_set_Void_Boolean_0;

		// Token: 0x040021D4 RID: 8660
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadKeyboardAssignments_Public_get_Boolean_0;

		// Token: 0x040021D5 RID: 8661
		private static readonly IntPtr NativeMethodInfoPtr_set_LoadKeyboardAssignments_Public_set_Void_Boolean_0;

		// Token: 0x040021D6 RID: 8662
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadMouseAssignments_Public_get_Boolean_0;

		// Token: 0x040021D7 RID: 8663
		private static readonly IntPtr NativeMethodInfoPtr_set_LoadMouseAssignments_Public_set_Void_Boolean_0;

		// Token: 0x040021D8 RID: 8664
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerPrefsKeyPrefix_Public_get_String_0;

		// Token: 0x040021D9 RID: 8665
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerPrefsKeyPrefix_Public_set_Void_String_0;

		// Token: 0x040021DA RID: 8666
		private static readonly IntPtr NativeMethodInfoPtr_get_playerPrefsKey_controllerAssignments_Private_get_String_0;

		// Token: 0x040021DB RID: 8667
		private static readonly IntPtr NativeMethodInfoPtr_get_loadControllerAssignments_Private_get_Boolean_0;

		// Token: 0x040021DC RID: 8668
		private static readonly IntPtr NativeMethodInfoPtr_get_allActionIds_Private_get_List_1_Int32_0;

		// Token: 0x040021DD RID: 8669
		private static readonly IntPtr NativeMethodInfoPtr_get_allActionIdsString_Private_get_String_0;

		// Token: 0x040021DE RID: 8670
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Void_0;

		// Token: 0x040021DF RID: 8671
		private static readonly IntPtr NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0;

		// Token: 0x040021E0 RID: 8672
		private static readonly IntPtr NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_ControllerType_Int32_0;

		// Token: 0x040021E1 RID: 8673
		private static readonly IntPtr NativeMethodInfoPtr_SavePlayerData_Public_Virtual_Void_Int32_0;

		// Token: 0x040021E2 RID: 8674
		private static readonly IntPtr NativeMethodInfoPtr_SaveInputBehavior_Public_Virtual_Void_Int32_Int32_0;

		// Token: 0x040021E3 RID: 8675
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_0;

		// Token: 0x040021E4 RID: 8676
		private static readonly IntPtr NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0;

		// Token: 0x040021E5 RID: 8677
		private static readonly IntPtr NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_ControllerType_Int32_0;

		// Token: 0x040021E6 RID: 8678
		private static readonly IntPtr NativeMethodInfoPtr_LoadPlayerData_Public_Virtual_Void_Int32_0;

		// Token: 0x040021E7 RID: 8679
		private static readonly IntPtr NativeMethodInfoPtr_LoadInputBehavior_Public_Virtual_Void_Int32_Int32_0;

		// Token: 0x040021E8 RID: 8680
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

		// Token: 0x040021E9 RID: 8681
		private static readonly IntPtr NativeMethodInfoPtr_OnControllerConnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0;

		// Token: 0x040021EA RID: 8682
		private static readonly IntPtr NativeMethodInfoPtr_OnControllerPreDisconnect_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0;

		// Token: 0x040021EB RID: 8683
		private static readonly IntPtr NativeMethodInfoPtr_OnControllerDisconnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0;

		// Token: 0x040021EC RID: 8684
		private static readonly IntPtr NativeMethodInfoPtr_SaveControllerMap_Public_Virtual_Void_Int32_ControllerMap_0;

		// Token: 0x040021ED RID: 8685
		private static readonly IntPtr NativeMethodInfoPtr_LoadControllerMap_Public_Virtual_ControllerMap_Int32_ControllerIdentifier_Int32_Int32_0;

		// Token: 0x040021EE RID: 8686
		private static readonly IntPtr NativeMethodInfoPtr_LoadAll_Private_Int32_0;

		// Token: 0x040021EF RID: 8687
		private static readonly IntPtr NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Int32_0;

		// Token: 0x040021F0 RID: 8688
		private static readonly IntPtr NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Player_0;

		// Token: 0x040021F1 RID: 8689
		private static readonly IntPtr NativeMethodInfoPtr_LoadAllJoystickCalibrationData_Private_Int32_0;

		// Token: 0x040021F2 RID: 8690
		private static readonly IntPtr NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Joystick_0;

		// Token: 0x040021F3 RID: 8691
		private static readonly IntPtr NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Int32_0;

		// Token: 0x040021F4 RID: 8692
		private static readonly IntPtr NativeMethodInfoPtr_LoadJoystickData_Private_Int32_Int32_0;

		// Token: 0x040021F5 RID: 8693
		private static readonly IntPtr NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_Int32_ControllerType_Int32_0;

		// Token: 0x040021F6 RID: 8694
		private static readonly IntPtr NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_ControllerType_Int32_0;

		// Token: 0x040021F7 RID: 8695
		private static readonly IntPtr NativeMethodInfoPtr_LoadControllerMaps_Private_Int32_Int32_ControllerType_Int32_0;

		// Token: 0x040021F8 RID: 8696
		private static readonly IntPtr NativeMethodInfoPtr_LoadControllerMap_Private_ControllerMap_Player_ControllerIdentifier_Int32_Int32_0;

		// Token: 0x040021F9 RID: 8697
		private static readonly IntPtr NativeMethodInfoPtr_LoadInputBehaviors_Private_Int32_Int32_0;

		// Token: 0x040021FA RID: 8698
		private static readonly IntPtr NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Int32_Int32_0;

		// Token: 0x040021FB RID: 8699
		private static readonly IntPtr NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Player_InputBehavior_0;

		// Token: 0x040021FC RID: 8700
		private static readonly IntPtr NativeMethodInfoPtr_LoadControllerAssignmentsNow_Private_Boolean_0;

		// Token: 0x040021FD RID: 8701
		private static readonly IntPtr NativeMethodInfoPtr_LoadKeyboardAndMouseAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0;

		// Token: 0x040021FE RID: 8702
		private static readonly IntPtr NativeMethodInfoPtr_LoadJoystickAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0;

		// Token: 0x040021FF RID: 8703
		private static readonly IntPtr NativeMethodInfoPtr_LoadControllerAssignmentData_Private_ControllerAssignmentSaveInfo_0;

		// Token: 0x04002200 RID: 8704
		private static readonly IntPtr NativeMethodInfoPtr_LoadJoystickAssignmentsDeferred_Private_IEnumerator_0;

		// Token: 0x04002201 RID: 8705
		private static readonly IntPtr NativeMethodInfoPtr_SaveAll_Private_Void_0;

		// Token: 0x04002202 RID: 8706
		private static readonly IntPtr NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Int32_0;

		// Token: 0x04002203 RID: 8707
		private static readonly IntPtr NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Player_0;

		// Token: 0x04002204 RID: 8708
		private static readonly IntPtr NativeMethodInfoPtr_SaveAllJoystickCalibrationData_Private_Void_0;

		// Token: 0x04002205 RID: 8709
		private static readonly IntPtr NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Int32_0;

		// Token: 0x04002206 RID: 8710
		private static readonly IntPtr NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Joystick_0;

		// Token: 0x04002207 RID: 8711
		private static readonly IntPtr NativeMethodInfoPtr_SaveJoystickData_Private_Void_Int32_0;

		// Token: 0x04002208 RID: 8712
		private static readonly IntPtr NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_Int32_ControllerType_Int32_0;

		// Token: 0x04002209 RID: 8713
		private static readonly IntPtr NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_ControllerType_Int32_0;

		// Token: 0x0400220A RID: 8714
		private static readonly IntPtr NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Player_PlayerSaveData_0;

		// Token: 0x0400220B RID: 8715
		private static readonly IntPtr NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Int32_ControllerType_Int32_0;

		// Token: 0x0400220C RID: 8716
		private static readonly IntPtr NativeMethodInfoPtr_SaveControllerMap_Private_Void_Player_ControllerMap_0;

		// Token: 0x0400220D RID: 8717
		private static readonly IntPtr NativeMethodInfoPtr_SaveInputBehaviors_Private_Void_Player_PlayerSaveData_0;

		// Token: 0x0400220E RID: 8718
		private static readonly IntPtr NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Int32_Int32_0;

		// Token: 0x0400220F RID: 8719
		private static readonly IntPtr NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Player_InputBehavior_0;

		// Token: 0x04002210 RID: 8720
		private static readonly IntPtr NativeMethodInfoPtr_SaveControllerAssignments_Private_Boolean_0;

		// Token: 0x04002211 RID: 8721
		private static readonly IntPtr NativeMethodInfoPtr_ControllerAssignmentSaveDataExists_Private_Boolean_0;

		// Token: 0x04002212 RID: 8722
		private static readonly IntPtr NativeMethodInfoPtr_GetBasePlayerPrefsKey_Private_String_Player_0;

		// Token: 0x04002213 RID: 8723
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerMapPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0;

		// Token: 0x04002214 RID: 8724
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerMapKnownActionIdsPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0;

		// Token: 0x04002215 RID: 8725
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerMapPlayerPrefsKeyCommonSuffix_Private_Static_String_Player_ControllerIdentifier_Int32_Int32_Int32_0;

		// Token: 0x04002216 RID: 8726
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickCalibrationMapPlayerPrefsKey_Private_String_Joystick_0;

		// Token: 0x04002217 RID: 8727
		private static readonly IntPtr NativeMethodInfoPtr_GetInputBehaviorPlayerPrefsKey_Private_String_Player_Int32_0;

		// Token: 0x04002218 RID: 8728
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerMapXml_Private_String_Player_ControllerIdentifier_Int32_Int32_0;

		// Token: 0x04002219 RID: 8729
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerMapKnownActionIds_Private_List_1_Int32_Player_ControllerIdentifier_Int32_Int32_0;

		// Token: 0x0400221A RID: 8730
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickCalibrationMapXml_Private_String_Joystick_0;

		// Token: 0x0400221B RID: 8731
		private static readonly IntPtr NativeMethodInfoPtr_GetInputBehaviorXml_Private_String_Player_Int32_0;

		// Token: 0x0400221C RID: 8732
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultMappingsForNewActions_Private_Void_ControllerIdentifier_ControllerMap_List_1_Int32_0;

		// Token: 0x0400221D RID: 8733
		private static readonly IntPtr NativeMethodInfoPtr_FindJoystickPrecise_Private_Joystick_JoystickInfo_0;

		// Token: 0x0400221E RID: 8734
		private static readonly IntPtr NativeMethodInfoPtr_TryFindJoysticksImprecise_Private_Boolean_JoystickInfo_byref_List_1_Joystick_0;

		// Token: 0x0400221F RID: 8735
		private static readonly IntPtr NativeMethodInfoPtr_GetDuplicateIndex_Private_Static_Int32_Player_ControllerIdentifier_0;

		// Token: 0x04002220 RID: 8736
		private static readonly IntPtr NativeMethodInfoPtr_RefreshLayoutManager_Private_Void_Int32_0;

		// Token: 0x04002221 RID: 8737
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerMapType_Private_Static_Type_ControllerType_0;

		// Token: 0x04002222 RID: 8738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200035A RID: 858
		public class ControllerAssignmentSaveInfo : Object
		{
			// Token: 0x06005446 RID: 21574 RVA: 0x00131BA8 File Offset: 0x0012FDA8
			// Note: this type is marked as 'beforefieldinit'.
			static ControllerAssignmentSaveInfo()
			{
				Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "ControllerAssignmentSaveInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr);
				UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr, "players");
				UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr_get_playerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr, 100668027);
				UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr, 100668028);
				UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr, 100668029);
				UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr_IndexOfPlayer_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr, 100668030);
				UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr_ContainsPlayer_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr, 100668031);
			}

			// Token: 0x17001EBB RID: 7867
			// (get) Token: 0x06005447 RID: 21575 RVA: 0x00131C4C File Offset: 0x0012FE4C
			public unsafe int playerCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr_get_playerCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005448 RID: 21576 RVA: 0x00131C88 File Offset: 0x0012FE88
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControllerAssignmentSaveInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005449 RID: 21577 RVA: 0x00131CC4 File Offset: 0x0012FEC4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 87471, RefRangeEnd = 87472, XrefRangeStart = 87463, XrefRangeEnd = 87471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControllerAssignmentSaveInfo(int playerCount)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref playerCount;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600544A RID: 21578 RVA: 0x00131D0C File Offset: 0x0012FF0C
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 87474, RefRangeEnd = 87479, XrefRangeStart = 87472, XrefRangeEnd = 87474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int IndexOfPlayer(int playerId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref playerId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr_IndexOfPlayer_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600544B RID: 21579 RVA: 0x00131D58 File Offset: 0x0012FF58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87479, XrefRangeEnd = 87480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ContainsPlayer(int playerId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref playerId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr_ContainsPlayer_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600544C RID: 21580 RVA: 0x00030E3A File Offset: 0x0002F03A
			public ControllerAssignmentSaveInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EBA RID: 7866
			// (get) Token: 0x0600544D RID: 21581 RVA: 0x00131DA4 File Offset: 0x0012FFA4
			// (set) Token: 0x0600544E RID: 21582 RVA: 0x00030E43 File Offset: 0x0002F043
			public unsafe Il2CppReferenceArray<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo> players
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeFieldInfoPtr_players);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeFieldInfoPtr_players), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040037BB RID: 14267
			private static readonly IntPtr NativeFieldInfoPtr_players;

			// Token: 0x040037BC RID: 14268
			private static readonly IntPtr NativeMethodInfoPtr_get_playerCount_Public_get_Int32_0;

			// Token: 0x040037BD RID: 14269
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040037BE RID: 14270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040037BF RID: 14271
			private static readonly IntPtr NativeMethodInfoPtr_IndexOfPlayer_Public_Int32_Int32_0;

			// Token: 0x040037C0 RID: 14272
			private static readonly IntPtr NativeMethodInfoPtr_ContainsPlayer_Public_Boolean_Int32_0;

			// Token: 0x02000402 RID: 1026
			public class PlayerInfo : Object
			{
				// Token: 0x06005B88 RID: 23432 RVA: 0x00149F98 File Offset: 0x00148198
				// Note: this type is marked as 'beforefieldinit'.
				static PlayerInfo()
				{
					Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr, "PlayerInfo");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr);
					UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr, "id");
					UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_hasKeyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr, "hasKeyboard");
					UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_hasMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr, "hasMouse");
					UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_joysticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr, "joysticks");
					UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeMethodInfoPtr_get_joystickCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr, 100668032);
					UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeMethodInfoPtr_IndexOfJoystick_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr, 100668033);
					UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeMethodInfoPtr_ContainsJoystick_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr, 100668034);
					UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr, 100668035);
				}

				// Token: 0x1700213A RID: 8506
				// (get) Token: 0x06005B89 RID: 23433 RVA: 0x0014A064 File Offset: 0x00148264
				public unsafe int joystickCount
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeMethodInfoPtr_get_joystickCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06005B8A RID: 23434 RVA: 0x0014A0A0 File Offset: 0x001482A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87459, XrefRangeEnd = 87461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int IndexOfJoystick(int joystickId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref joystickId;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeMethodInfoPtr_IndexOfJoystick_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06005B8B RID: 23435 RVA: 0x0014A0EC File Offset: 0x001482EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87461, XrefRangeEnd = 87463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool ContainsJoystick(int joystickId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref joystickId;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeMethodInfoPtr_ContainsJoystick_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06005B8C RID: 23436 RVA: 0x0014A138 File Offset: 0x00148338
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe PlayerInfo()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005B8D RID: 23437 RVA: 0x00034392 File Offset: 0x00032592
				public PlayerInfo(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17002136 RID: 8502
				// (get) Token: 0x06005B8E RID: 23438 RVA: 0x0014A174 File Offset: 0x00148374
				// (set) Token: 0x06005B8F RID: 23439 RVA: 0x0003439B File Offset: 0x0003259B
				public unsafe int id
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_id);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_id)) = value;
					}
				}

				// Token: 0x17002137 RID: 8503
				// (get) Token: 0x06005B90 RID: 23440 RVA: 0x0014A19C File Offset: 0x0014839C
				// (set) Token: 0x06005B91 RID: 23441 RVA: 0x000343B6 File Offset: 0x000325B6
				public unsafe bool hasKeyboard
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_hasKeyboard);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_hasKeyboard)) = value;
					}
				}

				// Token: 0x17002138 RID: 8504
				// (get) Token: 0x06005B92 RID: 23442 RVA: 0x0014A1C4 File Offset: 0x001483C4
				// (set) Token: 0x06005B93 RID: 23443 RVA: 0x000343D1 File Offset: 0x000325D1
				public unsafe bool hasMouse
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_hasMouse);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_hasMouse)) = value;
					}
				}

				// Token: 0x17002139 RID: 8505
				// (get) Token: 0x06005B94 RID: 23444 RVA: 0x0014A1EC File Offset: 0x001483EC
				// (set) Token: 0x06005B95 RID: 23445 RVA: 0x000343EC File Offset: 0x000325EC
				public unsafe Il2CppReferenceArray<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo> joysticks
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_joysticks);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_joysticks), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04003CD8 RID: 15576
				private static readonly IntPtr NativeFieldInfoPtr_id;

				// Token: 0x04003CD9 RID: 15577
				private static readonly IntPtr NativeFieldInfoPtr_hasKeyboard;

				// Token: 0x04003CDA RID: 15578
				private static readonly IntPtr NativeFieldInfoPtr_hasMouse;

				// Token: 0x04003CDB RID: 15579
				private static readonly IntPtr NativeFieldInfoPtr_joysticks;

				// Token: 0x04003CDC RID: 15580
				private static readonly IntPtr NativeMethodInfoPtr_get_joystickCount_Public_get_Int32_0;

				// Token: 0x04003CDD RID: 15581
				private static readonly IntPtr NativeMethodInfoPtr_IndexOfJoystick_Public_Int32_Int32_0;

				// Token: 0x04003CDE RID: 15582
				private static readonly IntPtr NativeMethodInfoPtr_ContainsJoystick_Public_Boolean_Int32_0;

				// Token: 0x04003CDF RID: 15583
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}

			// Token: 0x02000403 RID: 1027
			public class JoystickInfo : Object
			{
				// Token: 0x06005B96 RID: 23446 RVA: 0x0014A21C File Offset: 0x0014841C
				// Note: this type is marked as 'beforefieldinit'.
				static JoystickInfo()
				{
					Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr, "JoystickInfo");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>.NativeClassPtr);
					UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_instanceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>.NativeClassPtr, "instanceGuid");
					UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_hardwareIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>.NativeClassPtr, "hardwareIdentifier");
					UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>.NativeClassPtr, "id");
					UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>.NativeClassPtr, 100668036);
				}

				// Token: 0x06005B97 RID: 23447 RVA: 0x0014A298 File Offset: 0x00148498
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe JoystickInfo()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005B98 RID: 23448 RVA: 0x0003440B File Offset: 0x0003260B
				public JoystickInfo(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700213B RID: 8507
				// (get) Token: 0x06005B99 RID: 23449 RVA: 0x0014A2D4 File Offset: 0x001484D4
				// (set) Token: 0x06005B9A RID: 23450 RVA: 0x00034414 File Offset: 0x00032614
				public unsafe Guid instanceGuid
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_instanceGuid);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_instanceGuid)) = value;
					}
				}

				// Token: 0x1700213C RID: 8508
				// (get) Token: 0x06005B9B RID: 23451 RVA: 0x0014A2FC File Offset: 0x001484FC
				// (set) Token: 0x06005B9C RID: 23452 RVA: 0x0003442F File Offset: 0x0003262F
				public unsafe string hardwareIdentifier
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_hardwareIdentifier);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_hardwareIdentifier), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x1700213D RID: 8509
				// (get) Token: 0x06005B9D RID: 23453 RVA: 0x0014A324 File Offset: 0x00148524
				// (set) Token: 0x06005B9E RID: 23454 RVA: 0x0003444E File Offset: 0x0003264E
				public unsafe int id
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_id);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_id)) = value;
					}
				}

				// Token: 0x04003CE0 RID: 15584
				private static readonly IntPtr NativeFieldInfoPtr_instanceGuid;

				// Token: 0x04003CE1 RID: 15585
				private static readonly IntPtr NativeFieldInfoPtr_hardwareIdentifier;

				// Token: 0x04003CE2 RID: 15586
				private static readonly IntPtr NativeFieldInfoPtr_id;

				// Token: 0x04003CE3 RID: 15587
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}
		}

		// Token: 0x0200035B RID: 859
		public class JoystickAssignmentHistoryInfo : Object
		{
			// Token: 0x0600544F RID: 21583 RVA: 0x00131DD4 File Offset: 0x0012FFD4
			// Note: this type is marked as 'beforefieldinit'.
			static JoystickAssignmentHistoryInfo()
			{
				Il2CppClassPointerStore<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "JoystickAssignmentHistoryInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>.NativeClassPtr);
				UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo.NativeFieldInfoPtr_joystick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>.NativeClassPtr, "joystick");
				UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo.NativeFieldInfoPtr_oldJoystickId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>.NativeClassPtr, "oldJoystickId");
				UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo.NativeMethodInfoPtr__ctor_Public_Void_Joystick_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>.NativeClassPtr, 100668037);
			}

			// Token: 0x06005450 RID: 21584 RVA: 0x00131E3C File Offset: 0x0013003C
			[CallerCount(0)]
			public unsafe JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(joystick);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldJoystickId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo.NativeMethodInfoPtr__ctor_Public_Void_Joystick_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005451 RID: 21585 RVA: 0x00030E62 File Offset: 0x0002F062
			public JoystickAssignmentHistoryInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EBC RID: 7868
			// (get) Token: 0x06005452 RID: 21586 RVA: 0x00131E98 File Offset: 0x00130098
			// (set) Token: 0x06005453 RID: 21587 RVA: 0x00030E6B File Offset: 0x0002F06B
			public unsafe Joystick joystick
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo.NativeFieldInfoPtr_joystick);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Joystick>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo.NativeFieldInfoPtr_joystick), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EBD RID: 7869
			// (get) Token: 0x06005454 RID: 21588 RVA: 0x00131EC8 File Offset: 0x001300C8
			// (set) Token: 0x06005455 RID: 21589 RVA: 0x00030E8A File Offset: 0x0002F08A
			public unsafe int oldJoystickId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo.NativeFieldInfoPtr_oldJoystickId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo.NativeFieldInfoPtr_oldJoystickId)) = value;
				}
			}

			// Token: 0x040037C1 RID: 14273
			private static readonly IntPtr NativeFieldInfoPtr_joystick;

			// Token: 0x040037C2 RID: 14274
			private static readonly IntPtr NativeFieldInfoPtr_oldJoystickId;

			// Token: 0x040037C3 RID: 14275
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Joystick_Int32_0;
		}

		// Token: 0x0200035C RID: 860
		[ObfuscatedName("Rewired.Data.UserDataStore_PlayerPrefs+<>c__DisplayClass78_0")]
		public sealed class __c__DisplayClass78_0 : Object
		{
			// Token: 0x06005456 RID: 21590 RVA: 0x00131EF0 File Offset: 0x001300F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_0()
			{
				Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "<>c__DisplayClass78_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_0>.NativeClassPtr);
				UserDataStore_PlayerPrefs.__c__DisplayClass78_0.NativeFieldInfoPtr_joystick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_0>.NativeClassPtr, "joystick");
				UserDataStore_PlayerPrefs.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_0>.NativeClassPtr, 100668038);
				UserDataStore_PlayerPrefs.__c__DisplayClass78_0.NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__0_Internal_Boolean_JoystickAssignmentHistoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_0>.NativeClassPtr, 100668039);
			}

			// Token: 0x06005457 RID: 21591 RVA: 0x00131F58 File Offset: 0x00130158
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass78_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005458 RID: 21592 RVA: 0x00131F94 File Offset: 0x00130194
			[CallerCount(0)]
			public unsafe bool _LoadJoystickAssignmentsNow_b__0(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.__c__DisplayClass78_0.NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__0_Internal_Boolean_JoystickAssignmentHistoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005459 RID: 21593 RVA: 0x00030EA5 File Offset: 0x0002F0A5
			public __c__DisplayClass78_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EBE RID: 7870
			// (get) Token: 0x0600545A RID: 21594 RVA: 0x00131FE4 File Offset: 0x001301E4
			// (set) Token: 0x0600545B RID: 21595 RVA: 0x00030EAE File Offset: 0x0002F0AE
			public unsafe Joystick joystick
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.__c__DisplayClass78_0.NativeFieldInfoPtr_joystick);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Joystick>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.__c__DisplayClass78_0.NativeFieldInfoPtr_joystick), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040037C4 RID: 14276
			private static readonly IntPtr NativeFieldInfoPtr_joystick;

			// Token: 0x040037C5 RID: 14277
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040037C6 RID: 14278
			private static readonly IntPtr NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__0_Internal_Boolean_JoystickAssignmentHistoryInfo_0;
		}

		// Token: 0x0200035D RID: 861
		[ObfuscatedName("Rewired.Data.UserDataStore_PlayerPrefs+<>c__DisplayClass78_1")]
		public sealed class __c__DisplayClass78_1 : Object
		{
			// Token: 0x0600545C RID: 21596 RVA: 0x00132014 File Offset: 0x00130214
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_1()
			{
				Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "<>c__DisplayClass78_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_1>.NativeClassPtr);
				UserDataStore_PlayerPrefs.__c__DisplayClass78_1.NativeFieldInfoPtr_joystickInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_1>.NativeClassPtr, "joystickInfo");
				UserDataStore_PlayerPrefs.__c__DisplayClass78_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_1>.NativeClassPtr, 100668040);
				UserDataStore_PlayerPrefs.__c__DisplayClass78_1.NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__1_Internal_Boolean_JoystickAssignmentHistoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_1>.NativeClassPtr, 100668041);
			}

			// Token: 0x0600545D RID: 21597 RVA: 0x0013207C File Offset: 0x0013027C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass78_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.__c__DisplayClass78_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600545E RID: 21598 RVA: 0x001320B8 File Offset: 0x001302B8
			[CallerCount(0)]
			public unsafe bool _LoadJoystickAssignmentsNow_b__1(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.__c__DisplayClass78_1.NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__1_Internal_Boolean_JoystickAssignmentHistoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600545F RID: 21599 RVA: 0x00030ECD File Offset: 0x0002F0CD
			public __c__DisplayClass78_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EBF RID: 7871
			// (get) Token: 0x06005460 RID: 21600 RVA: 0x00132108 File Offset: 0x00130308
			// (set) Token: 0x06005461 RID: 21601 RVA: 0x00030ED6 File Offset: 0x0002F0D6
			public unsafe UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.__c__DisplayClass78_1.NativeFieldInfoPtr_joystickInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.__c__DisplayClass78_1.NativeFieldInfoPtr_joystickInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040037C7 RID: 14279
			private static readonly IntPtr NativeFieldInfoPtr_joystickInfo;

			// Token: 0x040037C8 RID: 14280
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040037C9 RID: 14281
			private static readonly IntPtr NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__1_Internal_Boolean_JoystickAssignmentHistoryInfo_0;
		}

		// Token: 0x0200035E RID: 862
		[ObfuscatedName("Rewired.Data.UserDataStore_PlayerPrefs+<>c__DisplayClass78_2")]
		public sealed class __c__DisplayClass78_2 : Object
		{
			// Token: 0x06005462 RID: 21602 RVA: 0x00132138 File Offset: 0x00130338
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_2()
			{
				Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "<>c__DisplayClass78_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_2>.NativeClassPtr);
				UserDataStore_PlayerPrefs.__c__DisplayClass78_2.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_2>.NativeClassPtr, "match");
				UserDataStore_PlayerPrefs.__c__DisplayClass78_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_2>.NativeClassPtr, 100668042);
				UserDataStore_PlayerPrefs.__c__DisplayClass78_2.NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__2_Internal_Boolean_JoystickAssignmentHistoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_2>.NativeClassPtr, 100668043);
			}

			// Token: 0x06005463 RID: 21603 RVA: 0x001321A0 File Offset: 0x001303A0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass78_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.__c__DisplayClass78_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005464 RID: 21604 RVA: 0x001321DC File Offset: 0x001303DC
			[CallerCount(0)]
			public unsafe bool _LoadJoystickAssignmentsNow_b__2(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.__c__DisplayClass78_2.NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__2_Internal_Boolean_JoystickAssignmentHistoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005465 RID: 21605 RVA: 0x00030EF5 File Offset: 0x0002F0F5
			public __c__DisplayClass78_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EC0 RID: 7872
			// (get) Token: 0x06005466 RID: 21606 RVA: 0x0013222C File Offset: 0x0013042C
			// (set) Token: 0x06005467 RID: 21607 RVA: 0x00030EFE File Offset: 0x0002F0FE
			public unsafe Joystick match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.__c__DisplayClass78_2.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Joystick>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.__c__DisplayClass78_2.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040037CA RID: 14282
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040037CB RID: 14283
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040037CC RID: 14284
			private static readonly IntPtr NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__2_Internal_Boolean_JoystickAssignmentHistoryInfo_0;
		}

		// Token: 0x0200035F RID: 863
		[ObfuscatedName("Rewired.Data.UserDataStore_PlayerPrefs+<LoadJoystickAssignmentsDeferred>d__80")]
		public sealed class _LoadJoystickAssignmentsDeferred_d__80 : Object
		{
			// Token: 0x06005468 RID: 21608 RVA: 0x0013225C File Offset: 0x0013045C
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadJoystickAssignmentsDeferred_d__80()
			{
				Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "<LoadJoystickAssignmentsDeferred>d__80");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr);
				UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, "<>1__state");
				UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, "<>2__current");
				UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, "<>4__this");
				UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100668044);
				UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100668045);
				UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100668046);
				UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100668047);
				UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100668048);
				UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100668049);
			}

			// Token: 0x06005469 RID: 21609 RVA: 0x0013233C File Offset: 0x0013053C
			[CallerCount(0)]
			public unsafe _LoadJoystickAssignmentsDeferred_d__80(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600546A RID: 21610 RVA: 0x00132384 File Offset: 0x00130584
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600546B RID: 21611 RVA: 0x001323B8 File Offset: 0x001305B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87480, XrefRangeEnd = 87484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001EC4 RID: 7876
			// (get) Token: 0x0600546C RID: 21612 RVA: 0x001323F4 File Offset: 0x001305F4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600546D RID: 21613 RVA: 0x00132434 File Offset: 0x00130634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87484, XrefRangeEnd = 87489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001EC5 RID: 7877
			// (get) Token: 0x0600546E RID: 21614 RVA: 0x00132468 File Offset: 0x00130668
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600546F RID: 21615 RVA: 0x00030F1D File Offset: 0x0002F11D
			public _LoadJoystickAssignmentsDeferred_d__80(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EC1 RID: 7873
			// (get) Token: 0x06005470 RID: 21616 RVA: 0x001324A8 File Offset: 0x001306A8
			// (set) Token: 0x06005471 RID: 21617 RVA: 0x00030F26 File Offset: 0x0002F126
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001EC2 RID: 7874
			// (get) Token: 0x06005472 RID: 21618 RVA: 0x001324D0 File Offset: 0x001306D0
			// (set) Token: 0x06005473 RID: 21619 RVA: 0x00030F41 File Offset: 0x0002F141
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EC3 RID: 7875
			// (get) Token: 0x06005474 RID: 21620 RVA: 0x00132500 File Offset: 0x00130700
			// (set) Token: 0x06005475 RID: 21621 RVA: 0x00030F60 File Offset: 0x0002F160
			public unsafe UserDataStore_PlayerPrefs __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserDataStore_PlayerPrefs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040037CD RID: 14285
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040037CE RID: 14286
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040037CF RID: 14287
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040037D0 RID: 14288
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040037D1 RID: 14289
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040037D2 RID: 14290
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040037D3 RID: 14291
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040037D4 RID: 14292
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040037D5 RID: 14293
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
