using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001E5 RID: 485
	public class ExternalTools : global::Il2CppSystem.Object
	{
		// Token: 0x0600382D RID: 14381 RVA: 0x000D051C File Offset: 0x000CE71C
		// Note: this type is marked as 'beforefieldinit'.
		static ExternalTools()
		{
			Il2CppClassPointerStore<ExternalTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Utils", "ExternalTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr);
			ExternalTools.NativeFieldInfoPtr__getPlatformInitializerDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, "_getPlatformInitializerDelegate");
			ExternalTools.NativeFieldInfoPtr__isEditorPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, "_isEditorPaused");
			ExternalTools.NativeFieldInfoPtr__EditorPausedStateChangedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, "_EditorPausedStateChangedEvent");
			ExternalTools.NativeFieldInfoPtr_XboxOneInput_OnGamepadStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, "XboxOneInput_OnGamepadStateChange");
			ExternalTools.NativeMethodInfoPtr_get_getPlatformInitializerDelegate_Public_Static_get_Func_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667856);
			ExternalTools.NativeMethodInfoPtr_set_getPlatformInitializerDelegate_Public_Static_set_Void_Func_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667857);
			ExternalTools.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667858);
			ExternalTools.NativeMethodInfoPtr_Destroy_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667859);
			ExternalTools.NativeMethodInfoPtr_get_isEditorPaused_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667860);
			ExternalTools.NativeMethodInfoPtr_add_EditorPausedStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667861);
			ExternalTools.NativeMethodInfoPtr_remove_EditorPausedStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667862);
			ExternalTools.NativeMethodInfoPtr_GetPlatformInitializer_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667863);
			ExternalTools.NativeMethodInfoPtr_GetFocusedEditorWindowTitle_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667864);
			ExternalTools.NativeMethodInfoPtr_IsEditorSceneViewFocused_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667865);
			ExternalTools.NativeMethodInfoPtr_LinuxInput_IsJoystickPreconfigured_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667866);
			ExternalTools.NativeMethodInfoPtr_add_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_add_Void_Action_2_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667867);
			ExternalTools.NativeMethodInfoPtr_remove_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_rem_Void_Action_2_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667868);
			ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetUserIdForGamepad_Public_Virtual_Final_New_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667869);
			ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetControllerId_Public_Virtual_Final_New_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667870);
			ExternalTools.NativeMethodInfoPtr_XboxOneInput_IsGamepadActive_Public_Virtual_Final_New_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667871);
			ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetControllerType_Public_Virtual_Final_New_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667872);
			ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetJoystickId_Public_Virtual_Final_New_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667873);
			ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_UpdatePlugin_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667874);
			ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_SetGamepadVibration_Public_Virtual_Final_New_Boolean_UInt64_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667875);
			ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_PulseVibrateMotor_Public_Virtual_Final_New_Void_UInt64_Int32_Single_Single_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667876);
			ExternalTools.NativeMethodInfoPtr_PS4Input_GetLastAcceleration_Public_Virtual_Final_New_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667877);
			ExternalTools.NativeMethodInfoPtr_PS4Input_GetLastGyro_Public_Virtual_Final_New_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667878);
			ExternalTools.NativeMethodInfoPtr_PS4Input_GetLastOrientation_Public_Virtual_Final_New_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667879);
			ExternalTools.NativeMethodInfoPtr_PS4Input_GetLastTouchData_Public_Virtual_Final_New_Void_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667880);
			ExternalTools.NativeMethodInfoPtr_PS4Input_GetPadControllerInformation_Public_Virtual_Final_New_Void_Int32_byref_Single_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667881);
			ExternalTools.NativeMethodInfoPtr_PS4Input_PadSetMotionSensorState_Public_Virtual_Final_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667882);
			ExternalTools.NativeMethodInfoPtr_PS4Input_PadSetTiltCorrectionState_Public_Virtual_Final_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667883);
			ExternalTools.NativeMethodInfoPtr_PS4Input_PadSetAngularVelocityDeadbandState_Public_Virtual_Final_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667884);
			ExternalTools.NativeMethodInfoPtr_PS4Input_PadSetLightBar_Public_Virtual_Final_New_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667885);
			ExternalTools.NativeMethodInfoPtr_PS4Input_PadResetLightBar_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667886);
			ExternalTools.NativeMethodInfoPtr_PS4Input_PadSetVibration_Public_Virtual_Final_New_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667887);
			ExternalTools.NativeMethodInfoPtr_PS4Input_PadResetOrientation_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667888);
			ExternalTools.NativeMethodInfoPtr_PS4Input_PadIsConnected_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667889);
			ExternalTools.NativeMethodInfoPtr_PS4Input_GetUsersDetails_Public_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667890);
			ExternalTools.NativeMethodInfoPtr_PS4Input_GetDeviceClassForHandle_Public_Virtual_Final_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667891);
			ExternalTools.NativeMethodInfoPtr_PS4Input_GetDeviceClassString_Public_Virtual_Final_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667892);
			ExternalTools.NativeMethodInfoPtr_PS4Input_PadGetUsersHandles2_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667893);
			ExternalTools.NativeMethodInfoPtr_PS4Input_GetSpecialControllerInformation_Public_Virtual_Final_New_Void_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667894);
			ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetLastAcceleration_Public_Virtual_Final_New_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667895);
			ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetLastGyro_Public_Virtual_Final_New_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667896);
			ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetLastOrientation_Public_Virtual_Final_New_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667897);
			ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetUsersHandles_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667898);
			ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetUsersHandles2_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667899);
			ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialIsConnected_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667900);
			ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialResetLightSphere_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667901);
			ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialResetOrientation_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667902);
			ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetAngularVelocityDeadbandState_Public_Virtual_Final_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667903);
			ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetLightSphere_Public_Virtual_Final_New_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667904);
			ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetMotionSensorState_Public_Virtual_Final_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667905);
			ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetTiltCorrectionState_Public_Virtual_Final_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667906);
			ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetVibration_Public_Virtual_Final_New_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667907);
			ExternalTools.NativeMethodInfoPtr_PS4Input_AimGetLastAcceleration_Public_Virtual_Final_New_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667908);
			ExternalTools.NativeMethodInfoPtr_PS4Input_AimGetLastGyro_Public_Virtual_Final_New_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667909);
			ExternalTools.NativeMethodInfoPtr_PS4Input_AimGetLastOrientation_Public_Virtual_Final_New_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667910);
			ExternalTools.NativeMethodInfoPtr_PS4Input_AimGetUsersHandles_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667911);
			ExternalTools.NativeMethodInfoPtr_PS4Input_AimGetUsersHandles2_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667912);
			ExternalTools.NativeMethodInfoPtr_PS4Input_AimIsConnected_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667913);
			ExternalTools.NativeMethodInfoPtr_PS4Input_AimResetLightSphere_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667914);
			ExternalTools.NativeMethodInfoPtr_PS4Input_AimResetOrientation_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667915);
			ExternalTools.NativeMethodInfoPtr_PS4Input_AimSetAngularVelocityDeadbandState_Public_Virtual_Final_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667916);
			ExternalTools.NativeMethodInfoPtr_PS4Input_AimSetLightSphere_Public_Virtual_Final_New_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667917);
			ExternalTools.NativeMethodInfoPtr_PS4Input_AimSetMotionSensorState_Public_Virtual_Final_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667918);
			ExternalTools.NativeMethodInfoPtr_PS4Input_AimSetTiltCorrectionState_Public_Virtual_Final_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667919);
			ExternalTools.NativeMethodInfoPtr_PS4Input_AimSetVibration_Public_Virtual_Final_New_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667920);
			ExternalTools.NativeMethodInfoPtr_PS4Input_GetLastMoveAcceleration_Public_Virtual_Final_New_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667921);
			ExternalTools.NativeMethodInfoPtr_PS4Input_GetLastMoveGyro_Public_Virtual_Final_New_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667922);
			ExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetButtons_Public_Virtual_Final_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667923);
			ExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetAnalogButton_Public_Virtual_Final_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667924);
			ExternalTools.NativeMethodInfoPtr_PS4Input_MoveIsConnected_Public_Virtual_Final_New_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667925);
			ExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667926);
			ExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667927);
			ExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Virtual_Final_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667928);
			ExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetControllerInputForTracking_Public_Virtual_Final_New_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667929);
			ExternalTools.NativeMethodInfoPtr_PS4Input_MoveSetLightSphere_Public_Virtual_Final_New_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667930);
			ExternalTools.NativeMethodInfoPtr_PS4Input_MoveSetVibration_Public_Virtual_Final_New_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667931);
			ExternalTools.NativeMethodInfoPtr_GetDeviceVIDPIDs_Public_Virtual_Final_New_Void_byref_List_1_Int32_byref_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667932);
			ExternalTools.NativeMethodInfoPtr_GetAndroidAPILevel_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667933);
			ExternalTools.NativeMethodInfoPtr_UnityUI_Graphic_GetRaycastTarget_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667934);
			ExternalTools.NativeMethodInfoPtr_UnityUI_Graphic_SetRaycastTarget_Public_Virtual_Final_New_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667935);
			ExternalTools.NativeMethodInfoPtr_get_UnityInput_IsTouchPressureSupported_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667936);
			ExternalTools.NativeMethodInfoPtr_UnityInput_GetTouchPressure_Public_Virtual_Final_New_Single_byref_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667937);
			ExternalTools.NativeMethodInfoPtr_UnityInput_GetTouchMaximumPossiblePressure_Public_Virtual_Final_New_Single_byref_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667938);
			ExternalTools.NativeMethodInfoPtr_CreateControllerTemplate_Public_Virtual_Final_New_IControllerTemplate_Guid_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667939);
			ExternalTools.NativeMethodInfoPtr_GetControllerTemplateTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667940);
			ExternalTools.NativeMethodInfoPtr_GetControllerTemplateInterfaceTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100667941);
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x0600382E RID: 14382 RVA: 0x000D0C54 File Offset: 0x000CEE54
		// (set) Token: 0x0600382F RID: 14383 RVA: 0x000D0C88 File Offset: 0x000CEE88
		public unsafe static Func<global::Il2CppSystem.Object> getPlatformInitializerDelegate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87361, XrefRangeEnd = 87363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_get_getPlatformInitializerDelegate_Public_Static_get_Func_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<global::Il2CppSystem.Object>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87363, XrefRangeEnd = 87365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_set_getPlatformInitializerDelegate_Public_Static_set_Void_Func_1_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x000D0CC0 File Offset: 0x000CEEC0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExternalTools()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x000D0CFC File Offset: 0x000CEEFC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_Destroy_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x06003832 RID: 14386 RVA: 0x000D0D30 File Offset: 0x000CEF30
		public unsafe virtual bool isEditorPaused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_get_isEditorPaused_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003833 RID: 14387 RVA: 0x000D0D6C File Offset: 0x000CEF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87365, XrefRangeEnd = 87368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_EditorPausedStateChangedEvent(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_add_EditorPausedStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x000D0DB0 File Offset: 0x000CEFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87368, XrefRangeEnd = 87371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_EditorPausedStateChangedEvent(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_remove_EditorPausedStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003835 RID: 14389 RVA: 0x000D0DF4 File Offset: 0x000CEFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87371, XrefRangeEnd = 87376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual global::Il2CppSystem.Object GetPlatformInitializer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetPlatformInitializer_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x000D0E34 File Offset: 0x000CF034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87376, XrefRangeEnd = 87378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetFocusedEditorWindowTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetFocusedEditorWindowTitle_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x000D0E6C File Offset: 0x000CF06C
		[CallerCount(0)]
		public unsafe virtual bool IsEditorSceneViewFocused()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_IsEditorSceneViewFocused_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x000D0EA8 File Offset: 0x000CF0A8
		[CallerCount(0)]
		public unsafe virtual bool LinuxInput_IsJoystickPreconfigured(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_LinuxInput_IsJoystickPreconfigured_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x000D0EF8 File Offset: 0x000CF0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87378, XrefRangeEnd = 87381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_XboxOneInput_OnGamepadStateChange(Action<uint, bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_add_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_add_Void_Action_2_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x000D0F3C File Offset: 0x000CF13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87381, XrefRangeEnd = 87384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_XboxOneInput_OnGamepadStateChange(Action<uint, bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_remove_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_rem_Void_Action_2_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x000D0F80 File Offset: 0x000CF180
		[CallerCount(0)]
		public unsafe virtual int XboxOneInput_GetUserIdForGamepad(uint id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetUserIdForGamepad_Public_Virtual_Final_New_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x000D0FCC File Offset: 0x000CF1CC
		[CallerCount(0)]
		public unsafe virtual ulong XboxOneInput_GetControllerId(uint unityJoystickId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unityJoystickId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetControllerId_Public_Virtual_Final_New_UInt64_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x000D1018 File Offset: 0x000CF218
		[CallerCount(0)]
		public unsafe virtual bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unityJoystickId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOneInput_IsGamepadActive_Public_Virtual_Final_New_Boolean_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x000D1064 File Offset: 0x000CF264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87384, XrefRangeEnd = 87386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string XboxOneInput_GetControllerType(ulong xboxControllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xboxControllerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetControllerType_Public_Virtual_Final_New_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x000D10A8 File Offset: 0x000CF2A8
		[CallerCount(0)]
		public unsafe virtual uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xboxControllerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetJoystickId_Public_Virtual_Final_New_UInt32_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x000D10F4 File Offset: 0x000CF2F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void XboxOne_Gamepad_UpdatePlugin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_UpdatePlugin_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x000D1128 File Offset: 0x000CF328
		[CallerCount(0)]
		public unsafe virtual bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xboxOneJoystickId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftMotor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightMotor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftTriggerLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightTriggerLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_SetGamepadVibration_Public_Virtual_Final_New_Boolean_UInt64_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x000D11AC File Offset: 0x000CF3AC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xboxOneJoystickId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorInt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_PulseVibrateMotor_Public_Virtual_Final_New_Void_UInt64_Int32_Single_Single_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x000D1224 File Offset: 0x000CF424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87386, XrefRangeEnd = 87388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 PS4Input_GetLastAcceleration(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_GetLastAcceleration_Public_Virtual_Final_New_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x000D1270 File Offset: 0x000CF470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 PS4Input_GetLastGyro(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_GetLastGyro_Public_Virtual_Final_New_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x000D12BC File Offset: 0x000CF4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87388, XrefRangeEnd = 87390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector4 PS4Input_GetLastOrientation(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_GetLastOrientation_Public_Virtual_Final_New_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x000D1308 File Offset: 0x000CF508
		[CallerCount(0)]
		public unsafe virtual void PS4Input_GetLastTouchData(int id, out int touchNum, out int touch0x, out int touch0y, out int touch0id, out int touch1x, out int touch1y, out int touch1id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &touchNum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &touch0x;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &touch0y;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &touch0id;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &touch1x;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &touch1y;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &touch1id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_GetLastTouchData_Public_Virtual_Final_New_Void_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x000D13B0 File Offset: 0x000CF5B0
		[CallerCount(0)]
		public unsafe virtual void PS4Input_GetPadControllerInformation(int id, out float touchpixelDensity, out int touchResolutionX, out int touchResolutionY, out int analogDeadZoneLeft, out int analogDeadZoneright, out int connectionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &touchpixelDensity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &touchResolutionX;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &touchResolutionY;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &analogDeadZoneLeft;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &analogDeadZoneright;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &connectionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_GetPadControllerInformation_Public_Virtual_Final_New_Void_Int32_byref_Single_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x000D1448 File Offset: 0x000CF648
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_PadSetMotionSensorState(int id, bool bEnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_PadSetMotionSensorState_Public_Virtual_Final_New_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x000D1494 File Offset: 0x000CF694
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_PadSetTiltCorrectionState(int id, bool bEnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_PadSetTiltCorrectionState_Public_Virtual_Final_New_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x000D14E0 File Offset: 0x000CF6E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_PadSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_PadSetAngularVelocityDeadbandState_Public_Virtual_Final_New_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x000D152C File Offset: 0x000CF72C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_PadSetLightBar(int id, int red, int green, int blue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref red;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref green;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_PadSetLightBar_Public_Virtual_Final_New_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x000D1594 File Offset: 0x000CF794
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_PadResetLightBar(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_PadResetLightBar_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x000D15D4 File Offset: 0x000CF7D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_PadSetVibration(int id, int largeMotor, int smallMotor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref largeMotor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smallMotor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_PadSetVibration_Public_Virtual_Final_New_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x000D1630 File Offset: 0x000CF830
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_PadResetOrientation(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_PadResetOrientation_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x000D1670 File Offset: 0x000CF870
		[CallerCount(0)]
		public unsafe virtual bool PS4Input_PadIsConnected(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_PadIsConnected_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x000D16BC File Offset: 0x000CF8BC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_GetUsersDetails(int slot, global::Il2CppSystem.Object loggedInUser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref slot;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loggedInUser);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_GetUsersDetails_Public_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x000D170C File Offset: 0x000CF90C
		[CallerCount(0)]
		public unsafe virtual int PS4Input_GetDeviceClassForHandle(int handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_GetDeviceClassForHandle_Public_Virtual_Final_New_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x000D1758 File Offset: 0x000CF958
		[CallerCount(0)]
		public unsafe virtual string PS4Input_GetDeviceClassString(int intValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_GetDeviceClassString_Public_Virtual_Final_New_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x000D179C File Offset: 0x000CF99C
		[CallerCount(0)]
		public unsafe virtual int PS4Input_PadGetUsersHandles2(int maxControllers, Il2CppStructArray<int> handles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxControllers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_PadGetUsersHandles2_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x000D17F8 File Offset: 0x000CF9F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_GetSpecialControllerInformation(int id, int padIndex, global::Il2CppSystem.Object controllerInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controllerInformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_GetSpecialControllerInformation_Public_Virtual_Final_New_Void_Int32_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x000D1858 File Offset: 0x000CFA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 PS4Input_SpecialGetLastAcceleration(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetLastAcceleration_Public_Virtual_Final_New_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x000D18A4 File Offset: 0x000CFAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 PS4Input_SpecialGetLastGyro(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetLastGyro_Public_Virtual_Final_New_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x000D18F0 File Offset: 0x000CFAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector4 PS4Input_SpecialGetLastOrientation(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetLastOrientation_Public_Virtual_Final_New_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x000D193C File Offset: 0x000CFB3C
		[CallerCount(0)]
		public unsafe virtual int PS4Input_SpecialGetUsersHandles(int maxNumberControllers, Il2CppStructArray<int> handles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxNumberControllers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetUsersHandles_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003859 RID: 14425 RVA: 0x000D1998 File Offset: 0x000CFB98
		[CallerCount(0)]
		public unsafe virtual int PS4Input_SpecialGetUsersHandles2(int maxNumberControllers, Il2CppStructArray<int> handles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxNumberControllers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetUsersHandles2_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600385A RID: 14426 RVA: 0x000D19F4 File Offset: 0x000CFBF4
		[CallerCount(0)]
		public unsafe virtual bool PS4Input_SpecialIsConnected(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialIsConnected_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x000D1A40 File Offset: 0x000CFC40
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_SpecialResetLightSphere(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialResetLightSphere_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x000D1A80 File Offset: 0x000CFC80
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_SpecialResetOrientation(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialResetOrientation_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x000D1AC0 File Offset: 0x000CFCC0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_SpecialSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetAngularVelocityDeadbandState_Public_Virtual_Final_New_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x000D1B0C File Offset: 0x000CFD0C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_SpecialSetLightSphere(int id, int red, int green, int blue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref red;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref green;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetLightSphere_Public_Virtual_Final_New_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x000D1B74 File Offset: 0x000CFD74
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_SpecialSetMotionSensorState(int id, bool bEnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetMotionSensorState_Public_Virtual_Final_New_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x000D1BC0 File Offset: 0x000CFDC0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_SpecialSetTiltCorrectionState(int id, bool bEnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetTiltCorrectionState_Public_Virtual_Final_New_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x000D1C0C File Offset: 0x000CFE0C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_SpecialSetVibration(int id, int largeMotor, int smallMotor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref largeMotor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smallMotor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetVibration_Public_Virtual_Final_New_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x000D1C68 File Offset: 0x000CFE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 PS4Input_AimGetLastAcceleration(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_AimGetLastAcceleration_Public_Virtual_Final_New_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x000D1CB4 File Offset: 0x000CFEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 PS4Input_AimGetLastGyro(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_AimGetLastGyro_Public_Virtual_Final_New_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x000D1D00 File Offset: 0x000CFF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector4 PS4Input_AimGetLastOrientation(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_AimGetLastOrientation_Public_Virtual_Final_New_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003865 RID: 14437 RVA: 0x000D1D4C File Offset: 0x000CFF4C
		[CallerCount(0)]
		public unsafe virtual int PS4Input_AimGetUsersHandles(int maxNumberControllers, Il2CppStructArray<int> handles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxNumberControllers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_AimGetUsersHandles_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003866 RID: 14438 RVA: 0x000D1DA8 File Offset: 0x000CFFA8
		[CallerCount(0)]
		public unsafe virtual int PS4Input_AimGetUsersHandles2(int maxNumberControllers, Il2CppStructArray<int> handles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxNumberControllers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_AimGetUsersHandles2_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003867 RID: 14439 RVA: 0x000D1E04 File Offset: 0x000D0004
		[CallerCount(0)]
		public unsafe virtual bool PS4Input_AimIsConnected(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_AimIsConnected_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003868 RID: 14440 RVA: 0x000D1E50 File Offset: 0x000D0050
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_AimResetLightSphere(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_AimResetLightSphere_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003869 RID: 14441 RVA: 0x000D1E90 File Offset: 0x000D0090
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_AimResetOrientation(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_AimResetOrientation_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600386A RID: 14442 RVA: 0x000D1ED0 File Offset: 0x000D00D0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_AimSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_AimSetAngularVelocityDeadbandState_Public_Virtual_Final_New_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600386B RID: 14443 RVA: 0x000D1F1C File Offset: 0x000D011C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_AimSetLightSphere(int id, int red, int green, int blue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref red;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref green;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_AimSetLightSphere_Public_Virtual_Final_New_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600386C RID: 14444 RVA: 0x000D1F84 File Offset: 0x000D0184
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_AimSetMotionSensorState(int id, bool bEnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_AimSetMotionSensorState_Public_Virtual_Final_New_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600386D RID: 14445 RVA: 0x000D1FD0 File Offset: 0x000D01D0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_AimSetTiltCorrectionState(int id, bool bEnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_AimSetTiltCorrectionState_Public_Virtual_Final_New_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x000D201C File Offset: 0x000D021C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PS4Input_AimSetVibration(int id, int largeMotor, int smallMotor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref largeMotor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smallMotor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_AimSetVibration_Public_Virtual_Final_New_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x000D2078 File Offset: 0x000D0278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 PS4Input_GetLastMoveAcceleration(int id, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_GetLastMoveAcceleration_Public_Virtual_Final_New_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x000D20D0 File Offset: 0x000D02D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 PS4Input_GetLastMoveGyro(int id, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_GetLastMoveGyro_Public_Virtual_Final_New_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003871 RID: 14449 RVA: 0x000D2128 File Offset: 0x000D0328
		[CallerCount(0)]
		public unsafe virtual int PS4Input_MoveGetButtons(int id, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetButtons_Public_Virtual_Final_New_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003872 RID: 14450 RVA: 0x000D2180 File Offset: 0x000D0380
		[CallerCount(0)]
		public unsafe virtual int PS4Input_MoveGetAnalogButton(int id, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetAnalogButton_Public_Virtual_Final_New_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x000D21D8 File Offset: 0x000D03D8
		[CallerCount(0)]
		public unsafe virtual bool PS4Input_MoveIsConnected(int id, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_MoveIsConnected_Public_Virtual_Final_New_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003874 RID: 14452 RVA: 0x000D2230 File Offset: 0x000D0430
		[CallerCount(0)]
		public unsafe virtual int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, Il2CppStructArray<int> primaryHandles, Il2CppStructArray<int> secondaryHandles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxNumberControllers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(primaryHandles);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondaryHandles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x000D22A0 File Offset: 0x000D04A0
		[CallerCount(0)]
		public unsafe virtual int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, Il2CppStructArray<int> primaryHandles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxNumberControllers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(primaryHandles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x000D22FC File Offset: 0x000D04FC
		[CallerCount(0)]
		public unsafe virtual int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxNumberControllers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Virtual_Final_New_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x000D2348 File Offset: 0x000D0548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87390, XrefRangeEnd = 87391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IntPtr PS4Input_MoveGetControllerInputForTracking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetControllerInputForTracking_Public_Virtual_Final_New_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003878 RID: 14456 RVA: 0x000D2384 File Offset: 0x000D0584
		[CallerCount(0)]
		public unsafe virtual int PS4Input_MoveSetLightSphere(int id, int index, int red, int green, int blue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref red;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref green;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_MoveSetLightSphere_Public_Virtual_Final_New_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003879 RID: 14457 RVA: 0x000D2408 File Offset: 0x000D0608
		[CallerCount(0)]
		public unsafe virtual int PS4Input_MoveSetVibration(int id, int index, int motor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_PS4Input_MoveSetVibration_Public_Virtual_Final_New_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x000D2470 File Offset: 0x000D0670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87391, XrefRangeEnd = 87401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetDeviceVIDPIDs_Public_Virtual_Final_New_Void_byref_List_1_Int32_byref_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			vids = ((intPtr5 == 0) ? null : new List<int>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			pids = ((intPtr6 == 0) ? null : new List<int>(intPtr6));
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x000D24E4 File Offset: 0x000D06E4
		[CallerCount(0)]
		public unsafe virtual int GetAndroidAPILevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetAndroidAPILevel_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x000D2520 File Offset: 0x000D0720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87401, XrefRangeEnd = 87418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityUI_Graphic_GetRaycastTarget(global::Il2CppSystem.Object graphic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(graphic);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_UnityUI_Graphic_GetRaycastTarget_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x000D2570 File Offset: 0x000D0770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87418, XrefRangeEnd = 87435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityUI_Graphic_SetRaycastTarget(global::Il2CppSystem.Object graphic, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_UnityUI_Graphic_SetRaycastTarget_Public_Virtual_Final_New_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x0600387E RID: 14462 RVA: 0x000D25C0 File Offset: 0x000D07C0
		public unsafe virtual bool UnityInput_IsTouchPressureSupported
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87435, XrefRangeEnd = 87439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_get_UnityInput_IsTouchPressureSupported_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x000D25FC File Offset: 0x000D07FC
		[CallerCount(0)]
		public unsafe virtual float UnityInput_GetTouchPressure(ref Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &touch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_UnityInput_GetTouchPressure_Public_Virtual_Final_New_Single_byref_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x000D2648 File Offset: 0x000D0848
		[CallerCount(0)]
		public unsafe virtual float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &touch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_UnityInput_GetTouchMaximumPossiblePressure_Public_Virtual_Final_New_Single_byref_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x000D2694 File Offset: 0x000D0894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87439, XrefRangeEnd = 87443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IControllerTemplate CreateControllerTemplate(Guid typeGuid, global::Il2CppSystem.Object payload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeGuid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(payload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_CreateControllerTemplate_Public_Virtual_Final_New_IControllerTemplate_Guid_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplate>(intPtr3) : null;
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x000D26F4 File Offset: 0x000D08F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87443, XrefRangeEnd = 87451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Type> GetControllerTemplateTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetControllerTemplateTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x000D2734 File Offset: 0x000D0934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87451, XrefRangeEnd = 87459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Type> GetControllerTemplateInterfaceTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetControllerTemplateInterfaceTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x00024396 File Offset: 0x00022596
		public ExternalTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x06003885 RID: 14469 RVA: 0x000D2774 File Offset: 0x000D0974
		// (set) Token: 0x06003886 RID: 14470 RVA: 0x0002439F File Offset: 0x0002259F
		public unsafe static Func<global::Il2CppSystem.Object> _getPlatformInitializerDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExternalTools.NativeFieldInfoPtr__getPlatformInitializerDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<global::Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExternalTools.NativeFieldInfoPtr__getPlatformInitializerDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x06003887 RID: 14471 RVA: 0x000D279C File Offset: 0x000D099C
		// (set) Token: 0x06003888 RID: 14472 RVA: 0x000243B1 File Offset: 0x000225B1
		public unsafe bool _isEditorPaused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr__isEditorPaused);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr__isEditorPaused)) = value;
			}
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x06003889 RID: 14473 RVA: 0x000D27C4 File Offset: 0x000D09C4
		// (set) Token: 0x0600388A RID: 14474 RVA: 0x000243CC File Offset: 0x000225CC
		public unsafe Action<bool> _EditorPausedStateChangedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr__EditorPausedStateChangedEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr__EditorPausedStateChangedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x0600388B RID: 14475 RVA: 0x000D27F4 File Offset: 0x000D09F4
		// (set) Token: 0x0600388C RID: 14476 RVA: 0x000243EB File Offset: 0x000225EB
		public unsafe Action<uint, bool> XboxOneInput_OnGamepadStateChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr_XboxOneInput_OnGamepadStateChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<uint, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr_XboxOneInput_OnGamepadStateChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002160 RID: 8544
		private static readonly IntPtr NativeFieldInfoPtr__getPlatformInitializerDelegate;

		// Token: 0x04002161 RID: 8545
		private static readonly IntPtr NativeFieldInfoPtr__isEditorPaused;

		// Token: 0x04002162 RID: 8546
		private static readonly IntPtr NativeFieldInfoPtr__EditorPausedStateChangedEvent;

		// Token: 0x04002163 RID: 8547
		private static readonly IntPtr NativeFieldInfoPtr_XboxOneInput_OnGamepadStateChange;

		// Token: 0x04002164 RID: 8548
		private static readonly IntPtr NativeMethodInfoPtr_get_getPlatformInitializerDelegate_Public_Static_get_Func_1_Object_0;

		// Token: 0x04002165 RID: 8549
		private static readonly IntPtr NativeMethodInfoPtr_set_getPlatformInitializerDelegate_Public_Static_set_Void_Func_1_Object_0;

		// Token: 0x04002166 RID: 8550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002167 RID: 8551
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002168 RID: 8552
		private static readonly IntPtr NativeMethodInfoPtr_get_isEditorPaused_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002169 RID: 8553
		private static readonly IntPtr NativeMethodInfoPtr_add_EditorPausedStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Boolean_0;

		// Token: 0x0400216A RID: 8554
		private static readonly IntPtr NativeMethodInfoPtr_remove_EditorPausedStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Boolean_0;

		// Token: 0x0400216B RID: 8555
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformInitializer_Public_Virtual_Final_New_Object_0;

		// Token: 0x0400216C RID: 8556
		private static readonly IntPtr NativeMethodInfoPtr_GetFocusedEditorWindowTitle_Public_Virtual_Final_New_String_0;

		// Token: 0x0400216D RID: 8557
		private static readonly IntPtr NativeMethodInfoPtr_IsEditorSceneViewFocused_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400216E RID: 8558
		private static readonly IntPtr NativeMethodInfoPtr_LinuxInput_IsJoystickPreconfigured_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x0400216F RID: 8559
		private static readonly IntPtr NativeMethodInfoPtr_add_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_add_Void_Action_2_UInt32_Boolean_0;

		// Token: 0x04002170 RID: 8560
		private static readonly IntPtr NativeMethodInfoPtr_remove_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_rem_Void_Action_2_UInt32_Boolean_0;

		// Token: 0x04002171 RID: 8561
		private static readonly IntPtr NativeMethodInfoPtr_XboxOneInput_GetUserIdForGamepad_Public_Virtual_Final_New_Int32_UInt32_0;

		// Token: 0x04002172 RID: 8562
		private static readonly IntPtr NativeMethodInfoPtr_XboxOneInput_GetControllerId_Public_Virtual_Final_New_UInt64_UInt32_0;

		// Token: 0x04002173 RID: 8563
		private static readonly IntPtr NativeMethodInfoPtr_XboxOneInput_IsGamepadActive_Public_Virtual_Final_New_Boolean_UInt32_0;

		// Token: 0x04002174 RID: 8564
		private static readonly IntPtr NativeMethodInfoPtr_XboxOneInput_GetControllerType_Public_Virtual_Final_New_String_UInt64_0;

		// Token: 0x04002175 RID: 8565
		private static readonly IntPtr NativeMethodInfoPtr_XboxOneInput_GetJoystickId_Public_Virtual_Final_New_UInt32_UInt64_0;

		// Token: 0x04002176 RID: 8566
		private static readonly IntPtr NativeMethodInfoPtr_XboxOne_Gamepad_UpdatePlugin_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002177 RID: 8567
		private static readonly IntPtr NativeMethodInfoPtr_XboxOne_Gamepad_SetGamepadVibration_Public_Virtual_Final_New_Boolean_UInt64_Single_Single_Single_Single_0;

		// Token: 0x04002178 RID: 8568
		private static readonly IntPtr NativeMethodInfoPtr_XboxOne_Gamepad_PulseVibrateMotor_Public_Virtual_Final_New_Void_UInt64_Int32_Single_Single_UInt64_0;

		// Token: 0x04002179 RID: 8569
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetLastAcceleration_Public_Virtual_Final_New_Vector3_Int32_0;

		// Token: 0x0400217A RID: 8570
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetLastGyro_Public_Virtual_Final_New_Vector3_Int32_0;

		// Token: 0x0400217B RID: 8571
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetLastOrientation_Public_Virtual_Final_New_Vector4_Int32_0;

		// Token: 0x0400217C RID: 8572
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetLastTouchData_Public_Virtual_Final_New_Void_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x0400217D RID: 8573
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetPadControllerInformation_Public_Virtual_Final_New_Void_Int32_byref_Single_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x0400217E RID: 8574
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadSetMotionSensorState_Public_Virtual_Final_New_Void_Int32_Boolean_0;

		// Token: 0x0400217F RID: 8575
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadSetTiltCorrectionState_Public_Virtual_Final_New_Void_Int32_Boolean_0;

		// Token: 0x04002180 RID: 8576
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadSetAngularVelocityDeadbandState_Public_Virtual_Final_New_Void_Int32_Boolean_0;

		// Token: 0x04002181 RID: 8577
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadSetLightBar_Public_Virtual_Final_New_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002182 RID: 8578
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadResetLightBar_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04002183 RID: 8579
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadSetVibration_Public_Virtual_Final_New_Void_Int32_Int32_Int32_0;

		// Token: 0x04002184 RID: 8580
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadResetOrientation_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04002185 RID: 8581
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadIsConnected_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04002186 RID: 8582
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetUsersDetails_Public_Virtual_Final_New_Void_Int32_Object_0;

		// Token: 0x04002187 RID: 8583
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetDeviceClassForHandle_Public_Virtual_Final_New_Int32_Int32_0;

		// Token: 0x04002188 RID: 8584
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetDeviceClassString_Public_Virtual_Final_New_String_Int32_0;

		// Token: 0x04002189 RID: 8585
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadGetUsersHandles2_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400218A RID: 8586
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetSpecialControllerInformation_Public_Virtual_Final_New_Void_Int32_Int32_Object_0;

		// Token: 0x0400218B RID: 8587
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialGetLastAcceleration_Public_Virtual_Final_New_Vector3_Int32_0;

		// Token: 0x0400218C RID: 8588
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialGetLastGyro_Public_Virtual_Final_New_Vector3_Int32_0;

		// Token: 0x0400218D RID: 8589
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialGetLastOrientation_Public_Virtual_Final_New_Vector4_Int32_0;

		// Token: 0x0400218E RID: 8590
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialGetUsersHandles_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400218F RID: 8591
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialGetUsersHandles2_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002190 RID: 8592
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialIsConnected_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04002191 RID: 8593
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialResetLightSphere_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04002192 RID: 8594
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialResetOrientation_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04002193 RID: 8595
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialSetAngularVelocityDeadbandState_Public_Virtual_Final_New_Void_Int32_Boolean_0;

		// Token: 0x04002194 RID: 8596
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialSetLightSphere_Public_Virtual_Final_New_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002195 RID: 8597
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialSetMotionSensorState_Public_Virtual_Final_New_Void_Int32_Boolean_0;

		// Token: 0x04002196 RID: 8598
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialSetTiltCorrectionState_Public_Virtual_Final_New_Void_Int32_Boolean_0;

		// Token: 0x04002197 RID: 8599
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialSetVibration_Public_Virtual_Final_New_Void_Int32_Int32_Int32_0;

		// Token: 0x04002198 RID: 8600
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimGetLastAcceleration_Public_Virtual_Final_New_Vector3_Int32_0;

		// Token: 0x04002199 RID: 8601
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimGetLastGyro_Public_Virtual_Final_New_Vector3_Int32_0;

		// Token: 0x0400219A RID: 8602
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimGetLastOrientation_Public_Virtual_Final_New_Vector4_Int32_0;

		// Token: 0x0400219B RID: 8603
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimGetUsersHandles_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400219C RID: 8604
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimGetUsersHandles2_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400219D RID: 8605
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimIsConnected_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x0400219E RID: 8606
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimResetLightSphere_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x0400219F RID: 8607
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimResetOrientation_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x040021A0 RID: 8608
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimSetAngularVelocityDeadbandState_Public_Virtual_Final_New_Void_Int32_Boolean_0;

		// Token: 0x040021A1 RID: 8609
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimSetLightSphere_Public_Virtual_Final_New_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x040021A2 RID: 8610
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimSetMotionSensorState_Public_Virtual_Final_New_Void_Int32_Boolean_0;

		// Token: 0x040021A3 RID: 8611
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimSetTiltCorrectionState_Public_Virtual_Final_New_Void_Int32_Boolean_0;

		// Token: 0x040021A4 RID: 8612
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimSetVibration_Public_Virtual_Final_New_Void_Int32_Int32_Int32_0;

		// Token: 0x040021A5 RID: 8613
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetLastMoveAcceleration_Public_Virtual_Final_New_Vector3_Int32_Int32_0;

		// Token: 0x040021A6 RID: 8614
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetLastMoveGyro_Public_Virtual_Final_New_Vector3_Int32_Int32_0;

		// Token: 0x040021A7 RID: 8615
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveGetButtons_Public_Virtual_Final_New_Int32_Int32_Int32_0;

		// Token: 0x040021A8 RID: 8616
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveGetAnalogButton_Public_Virtual_Final_New_Int32_Int32_Int32_0;

		// Token: 0x040021A9 RID: 8617
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveIsConnected_Public_Virtual_Final_New_Boolean_Int32_Int32_0;

		// Token: 0x040021AA RID: 8618
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x040021AB RID: 8619
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Virtual_Final_New_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x040021AC RID: 8620
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Virtual_Final_New_Int32_Int32_0;

		// Token: 0x040021AD RID: 8621
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveGetControllerInputForTracking_Public_Virtual_Final_New_IntPtr_0;

		// Token: 0x040021AE RID: 8622
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveSetLightSphere_Public_Virtual_Final_New_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x040021AF RID: 8623
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveSetVibration_Public_Virtual_Final_New_Int32_Int32_Int32_Int32_0;

		// Token: 0x040021B0 RID: 8624
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceVIDPIDs_Public_Virtual_Final_New_Void_byref_List_1_Int32_byref_List_1_Int32_0;

		// Token: 0x040021B1 RID: 8625
		private static readonly IntPtr NativeMethodInfoPtr_GetAndroidAPILevel_Public_Virtual_Final_New_Int32_0;

		// Token: 0x040021B2 RID: 8626
		private static readonly IntPtr NativeMethodInfoPtr_UnityUI_Graphic_GetRaycastTarget_Public_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x040021B3 RID: 8627
		private static readonly IntPtr NativeMethodInfoPtr_UnityUI_Graphic_SetRaycastTarget_Public_Virtual_Final_New_Void_Object_Boolean_0;

		// Token: 0x040021B4 RID: 8628
		private static readonly IntPtr NativeMethodInfoPtr_get_UnityInput_IsTouchPressureSupported_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040021B5 RID: 8629
		private static readonly IntPtr NativeMethodInfoPtr_UnityInput_GetTouchPressure_Public_Virtual_Final_New_Single_byref_Touch_0;

		// Token: 0x040021B6 RID: 8630
		private static readonly IntPtr NativeMethodInfoPtr_UnityInput_GetTouchMaximumPossiblePressure_Public_Virtual_Final_New_Single_byref_Touch_0;

		// Token: 0x040021B7 RID: 8631
		private static readonly IntPtr NativeMethodInfoPtr_CreateControllerTemplate_Public_Virtual_Final_New_IControllerTemplate_Guid_Object_0;

		// Token: 0x040021B8 RID: 8632
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerTemplateTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040021B9 RID: 8633
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerTemplateInterfaceTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0;
	}
}
