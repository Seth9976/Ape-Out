using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired.Utils.Interfaces
{
	// Token: 0x020000F3 RID: 243
	public class IExternalTools : Il2CppObjectBase
	{
		// Token: 0x060018A6 RID: 6310 RVA: 0x0008C3F0 File Offset: 0x0008A5F0
		// Note: this type is marked as 'beforefieldinit'.
		static IExternalTools()
		{
			Il2CppClassPointerStore<IExternalTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Interfaces", "IExternalTools");
			IExternalTools.NativeMethodInfoPtr_get_isEditorPaused_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669281);
			IExternalTools.NativeMethodInfoPtr_add_EditorPausedStateChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669282);
			IExternalTools.NativeMethodInfoPtr_remove_EditorPausedStateChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669283);
			IExternalTools.NativeMethodInfoPtr_Destroy_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669284);
			IExternalTools.NativeMethodInfoPtr_GetPlatformInitializer_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669285);
			IExternalTools.NativeMethodInfoPtr_GetFocusedEditorWindowTitle_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669286);
			IExternalTools.NativeMethodInfoPtr_IsEditorSceneViewFocused_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669287);
			IExternalTools.NativeMethodInfoPtr_LinuxInput_IsJoystickPreconfigured_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669288);
			IExternalTools.NativeMethodInfoPtr_XboxOneInput_GetUserIdForGamepad_Public_Abstract_Virtual_New_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669289);
			IExternalTools.NativeMethodInfoPtr_XboxOneInput_GetControllerId_Public_Abstract_Virtual_New_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669290);
			IExternalTools.NativeMethodInfoPtr_add_XboxOneInput_OnGamepadStateChange_Public_Abstract_Virtual_New_add_Void_Action_2_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669291);
			IExternalTools.NativeMethodInfoPtr_remove_XboxOneInput_OnGamepadStateChange_Public_Abstract_Virtual_New_rem_Void_Action_2_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669292);
			IExternalTools.NativeMethodInfoPtr_XboxOneInput_IsGamepadActive_Public_Abstract_Virtual_New_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669293);
			IExternalTools.NativeMethodInfoPtr_XboxOneInput_GetControllerType_Public_Abstract_Virtual_New_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669294);
			IExternalTools.NativeMethodInfoPtr_XboxOneInput_GetJoystickId_Public_Abstract_Virtual_New_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669295);
			IExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_UpdatePlugin_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669296);
			IExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_SetGamepadVibration_Public_Abstract_Virtual_New_Boolean_UInt64_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669297);
			IExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_PulseVibrateMotor_Public_Abstract_Virtual_New_Void_UInt64_Int32_Single_Single_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669298);
			IExternalTools.NativeMethodInfoPtr_PS4Input_GetLastAcceleration_Public_Abstract_Virtual_New_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669299);
			IExternalTools.NativeMethodInfoPtr_PS4Input_GetLastGyro_Public_Abstract_Virtual_New_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669300);
			IExternalTools.NativeMethodInfoPtr_PS4Input_GetLastOrientation_Public_Abstract_Virtual_New_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669301);
			IExternalTools.NativeMethodInfoPtr_PS4Input_GetLastTouchData_Public_Abstract_Virtual_New_Void_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669302);
			IExternalTools.NativeMethodInfoPtr_PS4Input_GetPadControllerInformation_Public_Abstract_Virtual_New_Void_Int32_byref_Single_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669303);
			IExternalTools.NativeMethodInfoPtr_PS4Input_PadSetMotionSensorState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669304);
			IExternalTools.NativeMethodInfoPtr_PS4Input_PadSetTiltCorrectionState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669305);
			IExternalTools.NativeMethodInfoPtr_PS4Input_PadSetAngularVelocityDeadbandState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669306);
			IExternalTools.NativeMethodInfoPtr_PS4Input_PadSetLightBar_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669307);
			IExternalTools.NativeMethodInfoPtr_PS4Input_PadResetLightBar_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669308);
			IExternalTools.NativeMethodInfoPtr_PS4Input_PadSetVibration_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669309);
			IExternalTools.NativeMethodInfoPtr_PS4Input_PadResetOrientation_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669310);
			IExternalTools.NativeMethodInfoPtr_PS4Input_PadIsConnected_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669311);
			IExternalTools.NativeMethodInfoPtr_PS4Input_GetUsersDetails_Public_Abstract_Virtual_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669312);
			IExternalTools.NativeMethodInfoPtr_PS4Input_GetDeviceClassForHandle_Public_Abstract_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669313);
			IExternalTools.NativeMethodInfoPtr_PS4Input_GetDeviceClassString_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669314);
			IExternalTools.NativeMethodInfoPtr_PS4Input_PadGetUsersHandles2_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669315);
			IExternalTools.NativeMethodInfoPtr_PS4Input_GetSpecialControllerInformation_Public_Abstract_Virtual_New_Void_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669316);
			IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetLastAcceleration_Public_Abstract_Virtual_New_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669317);
			IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetLastGyro_Public_Abstract_Virtual_New_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669318);
			IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetLastOrientation_Public_Abstract_Virtual_New_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669319);
			IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetUsersHandles_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669320);
			IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetUsersHandles2_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669321);
			IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialIsConnected_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669322);
			IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialResetLightSphere_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669323);
			IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialResetOrientation_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669324);
			IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetAngularVelocityDeadbandState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669325);
			IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetLightSphere_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669326);
			IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetMotionSensorState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669327);
			IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetTiltCorrectionState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669328);
			IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetVibration_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669329);
			IExternalTools.NativeMethodInfoPtr_PS4Input_AimGetLastAcceleration_Public_Abstract_Virtual_New_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669330);
			IExternalTools.NativeMethodInfoPtr_PS4Input_AimGetLastGyro_Public_Abstract_Virtual_New_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669331);
			IExternalTools.NativeMethodInfoPtr_PS4Input_AimGetLastOrientation_Public_Abstract_Virtual_New_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669332);
			IExternalTools.NativeMethodInfoPtr_PS4Input_AimGetUsersHandles_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669333);
			IExternalTools.NativeMethodInfoPtr_PS4Input_AimGetUsersHandles2_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669334);
			IExternalTools.NativeMethodInfoPtr_PS4Input_AimIsConnected_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669335);
			IExternalTools.NativeMethodInfoPtr_PS4Input_AimResetLightSphere_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669336);
			IExternalTools.NativeMethodInfoPtr_PS4Input_AimResetOrientation_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669337);
			IExternalTools.NativeMethodInfoPtr_PS4Input_AimSetAngularVelocityDeadbandState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669338);
			IExternalTools.NativeMethodInfoPtr_PS4Input_AimSetLightSphere_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669339);
			IExternalTools.NativeMethodInfoPtr_PS4Input_AimSetMotionSensorState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669340);
			IExternalTools.NativeMethodInfoPtr_PS4Input_AimSetTiltCorrectionState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669341);
			IExternalTools.NativeMethodInfoPtr_PS4Input_AimSetVibration_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669342);
			IExternalTools.NativeMethodInfoPtr_PS4Input_GetLastMoveAcceleration_Public_Abstract_Virtual_New_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669343);
			IExternalTools.NativeMethodInfoPtr_PS4Input_GetLastMoveGyro_Public_Abstract_Virtual_New_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669344);
			IExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetButtons_Public_Abstract_Virtual_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669345);
			IExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetAnalogButton_Public_Abstract_Virtual_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669346);
			IExternalTools.NativeMethodInfoPtr_PS4Input_MoveIsConnected_Public_Abstract_Virtual_New_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669347);
			IExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669348);
			IExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669349);
			IExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Abstract_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669350);
			IExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetControllerInputForTracking_Public_Abstract_Virtual_New_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669351);
			IExternalTools.NativeMethodInfoPtr_PS4Input_MoveSetLightSphere_Public_Abstract_Virtual_New_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669352);
			IExternalTools.NativeMethodInfoPtr_PS4Input_MoveSetVibration_Public_Abstract_Virtual_New_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669353);
			IExternalTools.NativeMethodInfoPtr_GetDeviceVIDPIDs_Public_Abstract_Virtual_New_Void_byref_List_1_Int32_byref_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669354);
			IExternalTools.NativeMethodInfoPtr_GetAndroidAPILevel_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669355);
			IExternalTools.NativeMethodInfoPtr_UnityUI_Graphic_GetRaycastTarget_Public_Abstract_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669356);
			IExternalTools.NativeMethodInfoPtr_UnityUI_Graphic_SetRaycastTarget_Public_Abstract_Virtual_New_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669357);
			IExternalTools.NativeMethodInfoPtr_get_UnityInput_IsTouchPressureSupported_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669358);
			IExternalTools.NativeMethodInfoPtr_UnityInput_GetTouchPressure_Public_Abstract_Virtual_New_Single_byref_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669359);
			IExternalTools.NativeMethodInfoPtr_UnityInput_GetTouchMaximumPossiblePressure_Public_Abstract_Virtual_New_Single_byref_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669360);
			IExternalTools.NativeMethodInfoPtr_CreateControllerTemplate_Public_Abstract_Virtual_New_IControllerTemplate_Guid_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669361);
			IExternalTools.NativeMethodInfoPtr_GetControllerTemplateTypes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669362);
			IExternalTools.NativeMethodInfoPtr_GetControllerTemplateInterfaceTypes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalTools>.NativeClassPtr, 100669363);
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x0008CA94 File Offset: 0x0008AC94
		public unsafe virtual bool isEditorPaused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_get_isEditorPaused_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0008CADC File Offset: 0x0008ACDC
		[CallerCount(0)]
		public unsafe virtual void add_EditorPausedStateChangedEvent(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_add_EditorPausedStateChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x0008CB2C File Offset: 0x0008AD2C
		[CallerCount(0)]
		public unsafe virtual void remove_EditorPausedStateChangedEvent(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_remove_EditorPausedStateChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0008CB7C File Offset: 0x0008AD7C
		[CallerCount(0)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_Destroy_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0008CBB8 File Offset: 0x0008ADB8
		[CallerCount(0)]
		public unsafe virtual global::Il2CppSystem.Object GetPlatformInitializer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_GetPlatformInitializer_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0008CC04 File Offset: 0x0008AE04
		[CallerCount(0)]
		public unsafe virtual string GetFocusedEditorWindowTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_GetFocusedEditorWindowTitle_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0008CC48 File Offset: 0x0008AE48
		[CallerCount(0)]
		public unsafe virtual bool IsEditorSceneViewFocused()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_IsEditorSceneViewFocused_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x0008CC90 File Offset: 0x0008AE90
		[CallerCount(0)]
		public unsafe virtual bool LinuxInput_IsJoystickPreconfigured(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_LinuxInput_IsJoystickPreconfigured_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0008CCE8 File Offset: 0x0008AEE8
		[CallerCount(0)]
		public unsafe virtual int XboxOneInput_GetUserIdForGamepad(uint id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_XboxOneInput_GetUserIdForGamepad_Public_Abstract_Virtual_New_Int32_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0008CD3C File Offset: 0x0008AF3C
		[CallerCount(0)]
		public unsafe virtual ulong XboxOneInput_GetControllerId(uint unityJoystickId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unityJoystickId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_XboxOneInput_GetControllerId_Public_Abstract_Virtual_New_UInt64_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0008CD90 File Offset: 0x0008AF90
		[CallerCount(0)]
		public unsafe virtual void add_XboxOneInput_OnGamepadStateChange(Action<uint, bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_add_XboxOneInput_OnGamepadStateChange_Public_Abstract_Virtual_New_add_Void_Action_2_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0008CDE0 File Offset: 0x0008AFE0
		[CallerCount(0)]
		public unsafe virtual void remove_XboxOneInput_OnGamepadStateChange(Action<uint, bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_remove_XboxOneInput_OnGamepadStateChange_Public_Abstract_Virtual_New_rem_Void_Action_2_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x0008CE30 File Offset: 0x0008B030
		[CallerCount(0)]
		public unsafe virtual bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unityJoystickId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_XboxOneInput_IsGamepadActive_Public_Abstract_Virtual_New_Boolean_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0008CE84 File Offset: 0x0008B084
		[CallerCount(0)]
		public unsafe virtual string XboxOneInput_GetControllerType(ulong xboxControllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xboxControllerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_XboxOneInput_GetControllerType_Public_Abstract_Virtual_New_String_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0008CED4 File Offset: 0x0008B0D4
		[CallerCount(0)]
		public unsafe virtual uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xboxControllerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_XboxOneInput_GetJoystickId_Public_Abstract_Virtual_New_UInt32_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0008CF28 File Offset: 0x0008B128
		[CallerCount(0)]
		public unsafe virtual void XboxOne_Gamepad_UpdatePlugin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_UpdatePlugin_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x0008CF64 File Offset: 0x0008B164
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_SetGamepadVibration_Public_Abstract_Virtual_New_Boolean_UInt64_Single_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0008CFF0 File Offset: 0x0008B1F0
		[CallerCount(0)]
		public unsafe virtual void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motor, float startLevel, float endLevel, ulong durationMS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xboxOneJoystickId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_PulseVibrateMotor_Public_Abstract_Virtual_New_Void_UInt64_Int32_Single_Single_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x0008D074 File Offset: 0x0008B274
		[CallerCount(0)]
		public unsafe virtual Vector3 PS4Input_GetLastAcceleration(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_GetLastAcceleration_Public_Abstract_Virtual_New_Vector3_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x0008D0C8 File Offset: 0x0008B2C8
		[CallerCount(0)]
		public unsafe virtual Vector3 PS4Input_GetLastGyro(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_GetLastGyro_Public_Abstract_Virtual_New_Vector3_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x0008D11C File Offset: 0x0008B31C
		[CallerCount(0)]
		public unsafe virtual Vector4 PS4Input_GetLastOrientation(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_GetLastOrientation_Public_Abstract_Virtual_New_Vector4_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x0008D170 File Offset: 0x0008B370
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_GetLastTouchData_Public_Abstract_Virtual_New_Void_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x0008D220 File Offset: 0x0008B420
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_GetPadControllerInformation_Public_Abstract_Virtual_New_Void_Int32_byref_Single_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0008D2C4 File Offset: 0x0008B4C4
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_PadSetMotionSensorState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0008D31C File Offset: 0x0008B51C
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_PadSetTiltCorrectionState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x0008D374 File Offset: 0x0008B574
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_PadSetAngularVelocityDeadbandState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x0008D3CC File Offset: 0x0008B5CC
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_PadSetLightBar_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0008D440 File Offset: 0x0008B640
		[CallerCount(0)]
		public unsafe virtual void PS4Input_PadResetLightBar(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_PadResetLightBar_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x0008D48C File Offset: 0x0008B68C
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_PadSetVibration_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x0008D4F4 File Offset: 0x0008B6F4
		[CallerCount(0)]
		public unsafe virtual void PS4Input_PadResetOrientation(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_PadResetOrientation_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x0008D540 File Offset: 0x0008B740
		[CallerCount(0)]
		public unsafe virtual bool PS4Input_PadIsConnected(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_PadIsConnected_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x0008D594 File Offset: 0x0008B794
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_GetUsersDetails_Public_Abstract_Virtual_New_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x0008D5F0 File Offset: 0x0008B7F0
		[CallerCount(0)]
		public unsafe virtual int PS4Input_GetDeviceClassForHandle(int handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_GetDeviceClassForHandle_Public_Abstract_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x0008D644 File Offset: 0x0008B844
		[CallerCount(0)]
		public unsafe virtual string PS4Input_GetDeviceClassString(int intValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_GetDeviceClassString_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x0008D694 File Offset: 0x0008B894
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_PadGetUsersHandles2_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x0008D6FC File Offset: 0x0008B8FC
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_GetSpecialControllerInformation_Public_Abstract_Virtual_New_Void_Int32_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x0008D768 File Offset: 0x0008B968
		[CallerCount(0)]
		public unsafe virtual Vector3 PS4Input_SpecialGetLastAcceleration(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetLastAcceleration_Public_Abstract_Virtual_New_Vector3_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0008D7BC File Offset: 0x0008B9BC
		[CallerCount(0)]
		public unsafe virtual Vector3 PS4Input_SpecialGetLastGyro(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetLastGyro_Public_Abstract_Virtual_New_Vector3_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x0008D810 File Offset: 0x0008BA10
		[CallerCount(0)]
		public unsafe virtual Vector4 PS4Input_SpecialGetLastOrientation(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetLastOrientation_Public_Abstract_Virtual_New_Vector4_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0008D864 File Offset: 0x0008BA64
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetUsersHandles_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0008D8CC File Offset: 0x0008BACC
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialGetUsersHandles2_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0008D934 File Offset: 0x0008BB34
		[CallerCount(0)]
		public unsafe virtual bool PS4Input_SpecialIsConnected(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialIsConnected_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x0008D988 File Offset: 0x0008BB88
		[CallerCount(0)]
		public unsafe virtual void PS4Input_SpecialResetLightSphere(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialResetLightSphere_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0008D9D4 File Offset: 0x0008BBD4
		[CallerCount(0)]
		public unsafe virtual void PS4Input_SpecialResetOrientation(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialResetOrientation_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0008DA20 File Offset: 0x0008BC20
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetAngularVelocityDeadbandState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0008DA78 File Offset: 0x0008BC78
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetLightSphere_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0008DAEC File Offset: 0x0008BCEC
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetMotionSensorState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0008DB44 File Offset: 0x0008BD44
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetTiltCorrectionState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0008DB9C File Offset: 0x0008BD9C
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_SpecialSetVibration_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x0008DC04 File Offset: 0x0008BE04
		[CallerCount(0)]
		public unsafe virtual Vector3 PS4Input_AimGetLastAcceleration(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_AimGetLastAcceleration_Public_Abstract_Virtual_New_Vector3_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0008DC58 File Offset: 0x0008BE58
		[CallerCount(0)]
		public unsafe virtual Vector3 PS4Input_AimGetLastGyro(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_AimGetLastGyro_Public_Abstract_Virtual_New_Vector3_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x0008DCAC File Offset: 0x0008BEAC
		[CallerCount(0)]
		public unsafe virtual Vector4 PS4Input_AimGetLastOrientation(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_AimGetLastOrientation_Public_Abstract_Virtual_New_Vector4_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x0008DD00 File Offset: 0x0008BF00
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_AimGetUsersHandles_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x0008DD68 File Offset: 0x0008BF68
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_AimGetUsersHandles2_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0008DDD0 File Offset: 0x0008BFD0
		[CallerCount(0)]
		public unsafe virtual bool PS4Input_AimIsConnected(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_AimIsConnected_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0008DE24 File Offset: 0x0008C024
		[CallerCount(0)]
		public unsafe virtual void PS4Input_AimResetLightSphere(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_AimResetLightSphere_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0008DE70 File Offset: 0x0008C070
		[CallerCount(0)]
		public unsafe virtual void PS4Input_AimResetOrientation(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_AimResetOrientation_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0008DEBC File Offset: 0x0008C0BC
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_AimSetAngularVelocityDeadbandState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0008DF14 File Offset: 0x0008C114
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_AimSetLightSphere_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x0008DF88 File Offset: 0x0008C188
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_AimSetMotionSensorState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0008DFE0 File Offset: 0x0008C1E0
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_AimSetTiltCorrectionState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x0008E038 File Offset: 0x0008C238
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_AimSetVibration_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0008E0A0 File Offset: 0x0008C2A0
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_GetLastMoveAcceleration_Public_Abstract_Virtual_New_Vector3_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0008E104 File Offset: 0x0008C304
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_GetLastMoveGyro_Public_Abstract_Virtual_New_Vector3_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0008E168 File Offset: 0x0008C368
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetButtons_Public_Abstract_Virtual_New_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0008E1CC File Offset: 0x0008C3CC
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetAnalogButton_Public_Abstract_Virtual_New_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x0008E230 File Offset: 0x0008C430
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_MoveIsConnected_Public_Abstract_Virtual_New_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x0008E294 File Offset: 0x0008C494
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x0008E30C File Offset: 0x0008C50C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x0008E374 File Offset: 0x0008C574
		[CallerCount(0)]
		public unsafe virtual int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxNumberControllers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Abstract_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0008E3C8 File Offset: 0x0008C5C8
		[CallerCount(0)]
		public unsafe virtual IntPtr PS4Input_MoveGetControllerInputForTracking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_MoveGetControllerInputForTracking_Public_Abstract_Virtual_New_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0008E410 File Offset: 0x0008C610
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_MoveSetLightSphere_Public_Abstract_Virtual_New_Int32_Int32_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x0008E49C File Offset: 0x0008C69C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_PS4Input_MoveSetVibration_Public_Abstract_Virtual_New_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x0008E50C File Offset: 0x0008C70C
		[CallerCount(0)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_GetDeviceVIDPIDs_Public_Abstract_Virtual_New_Void_byref_List_1_Int32_byref_List_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			vids = ((intPtr5 == 0) ? null : new List<int>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			pids = ((intPtr6 == 0) ? null : new List<int>(intPtr6));
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0008E58C File Offset: 0x0008C78C
		[CallerCount(0)]
		public unsafe virtual int GetAndroidAPILevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_GetAndroidAPILevel_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0008E5D4 File Offset: 0x0008C7D4
		[CallerCount(0)]
		public unsafe virtual bool UnityUI_Graphic_GetRaycastTarget(global::Il2CppSystem.Object graphic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(graphic);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_UnityUI_Graphic_GetRaycastTarget_Public_Abstract_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x0008E62C File Offset: 0x0008C82C
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_UnityUI_Graphic_SetRaycastTarget_Public_Abstract_Virtual_New_Void_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x0008E688 File Offset: 0x0008C888
		public unsafe virtual bool UnityInput_IsTouchPressureSupported
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_get_UnityInput_IsTouchPressureSupported_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0008E6D0 File Offset: 0x0008C8D0
		[CallerCount(0)]
		public unsafe virtual float UnityInput_GetTouchPressure(ref Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &touch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_UnityInput_GetTouchPressure_Public_Abstract_Virtual_New_Single_byref_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x0008E724 File Offset: 0x0008C924
		[CallerCount(0)]
		public unsafe virtual float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &touch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_UnityInput_GetTouchMaximumPossiblePressure_Public_Abstract_Virtual_New_Single_byref_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0008E778 File Offset: 0x0008C978
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_CreateControllerTemplate_Public_Abstract_Virtual_New_IControllerTemplate_Guid_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplate>(intPtr3) : null;
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x0008E7E4 File Offset: 0x0008C9E4
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Type> GetControllerTemplateTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_GetControllerTemplateTypes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x0008E830 File Offset: 0x0008CA30
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Type> GetControllerTemplateInterfaceTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalTools.NativeMethodInfoPtr_GetControllerTemplateInterfaceTypes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x0000A252 File Offset: 0x00008452
		public IExternalTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeMethodInfoPtr_get_isEditorPaused_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeMethodInfoPtr_add_EditorPausedStateChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_1_Boolean_0;

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeMethodInfoPtr_remove_EditorPausedStateChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_1_Boolean_0;

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformInitializer_Public_Abstract_Virtual_New_Object_0;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeMethodInfoPtr_GetFocusedEditorWindowTitle_Public_Abstract_Virtual_New_String_0;

		// Token: 0x0400157D RID: 5501
		private static readonly IntPtr NativeMethodInfoPtr_IsEditorSceneViewFocused_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeMethodInfoPtr_LinuxInput_IsJoystickPreconfigured_Public_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeMethodInfoPtr_XboxOneInput_GetUserIdForGamepad_Public_Abstract_Virtual_New_Int32_UInt32_0;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeMethodInfoPtr_XboxOneInput_GetControllerId_Public_Abstract_Virtual_New_UInt64_UInt32_0;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeMethodInfoPtr_add_XboxOneInput_OnGamepadStateChange_Public_Abstract_Virtual_New_add_Void_Action_2_UInt32_Boolean_0;

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeMethodInfoPtr_remove_XboxOneInput_OnGamepadStateChange_Public_Abstract_Virtual_New_rem_Void_Action_2_UInt32_Boolean_0;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeMethodInfoPtr_XboxOneInput_IsGamepadActive_Public_Abstract_Virtual_New_Boolean_UInt32_0;

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeMethodInfoPtr_XboxOneInput_GetControllerType_Public_Abstract_Virtual_New_String_UInt64_0;

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeMethodInfoPtr_XboxOneInput_GetJoystickId_Public_Abstract_Virtual_New_UInt32_UInt64_0;

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeMethodInfoPtr_XboxOne_Gamepad_UpdatePlugin_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeMethodInfoPtr_XboxOne_Gamepad_SetGamepadVibration_Public_Abstract_Virtual_New_Boolean_UInt64_Single_Single_Single_Single_0;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeMethodInfoPtr_XboxOne_Gamepad_PulseVibrateMotor_Public_Abstract_Virtual_New_Void_UInt64_Int32_Single_Single_UInt64_0;

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetLastAcceleration_Public_Abstract_Virtual_New_Vector3_Int32_0;

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetLastGyro_Public_Abstract_Virtual_New_Vector3_Int32_0;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetLastOrientation_Public_Abstract_Virtual_New_Vector4_Int32_0;

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetLastTouchData_Public_Abstract_Virtual_New_Void_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x0400158D RID: 5517
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetPadControllerInformation_Public_Abstract_Virtual_New_Void_Int32_byref_Single_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x0400158E RID: 5518
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadSetMotionSensorState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x0400158F RID: 5519
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadSetTiltCorrectionState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x04001590 RID: 5520
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadSetAngularVelocityDeadbandState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x04001591 RID: 5521
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadSetLightBar_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001592 RID: 5522
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadResetLightBar_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x04001593 RID: 5523
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadSetVibration_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0;

		// Token: 0x04001594 RID: 5524
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadResetOrientation_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadIsConnected_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetUsersDetails_Public_Abstract_Virtual_New_Void_Int32_Object_0;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetDeviceClassForHandle_Public_Abstract_Virtual_New_Int32_Int32_0;

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetDeviceClassString_Public_Abstract_Virtual_New_String_Int32_0;

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_PadGetUsersHandles2_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400159A RID: 5530
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetSpecialControllerInformation_Public_Abstract_Virtual_New_Void_Int32_Int32_Object_0;

		// Token: 0x0400159B RID: 5531
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialGetLastAcceleration_Public_Abstract_Virtual_New_Vector3_Int32_0;

		// Token: 0x0400159C RID: 5532
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialGetLastGyro_Public_Abstract_Virtual_New_Vector3_Int32_0;

		// Token: 0x0400159D RID: 5533
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialGetLastOrientation_Public_Abstract_Virtual_New_Vector4_Int32_0;

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialGetUsersHandles_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400159F RID: 5535
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialGetUsersHandles2_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialIsConnected_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialResetLightSphere_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialResetOrientation_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x040015A3 RID: 5539
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialSetAngularVelocityDeadbandState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x040015A4 RID: 5540
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialSetLightSphere_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x040015A5 RID: 5541
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialSetMotionSensorState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x040015A6 RID: 5542
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialSetTiltCorrectionState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x040015A7 RID: 5543
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_SpecialSetVibration_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0;

		// Token: 0x040015A8 RID: 5544
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimGetLastAcceleration_Public_Abstract_Virtual_New_Vector3_Int32_0;

		// Token: 0x040015A9 RID: 5545
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimGetLastGyro_Public_Abstract_Virtual_New_Vector3_Int32_0;

		// Token: 0x040015AA RID: 5546
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimGetLastOrientation_Public_Abstract_Virtual_New_Vector4_Int32_0;

		// Token: 0x040015AB RID: 5547
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimGetUsersHandles_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x040015AC RID: 5548
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimGetUsersHandles2_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x040015AD RID: 5549
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimIsConnected_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x040015AE RID: 5550
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimResetLightSphere_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x040015AF RID: 5551
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimResetOrientation_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x040015B0 RID: 5552
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimSetAngularVelocityDeadbandState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x040015B1 RID: 5553
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimSetLightSphere_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x040015B2 RID: 5554
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimSetMotionSensorState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x040015B3 RID: 5555
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimSetTiltCorrectionState_Public_Abstract_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x040015B4 RID: 5556
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_AimSetVibration_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0;

		// Token: 0x040015B5 RID: 5557
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetLastMoveAcceleration_Public_Abstract_Virtual_New_Vector3_Int32_Int32_0;

		// Token: 0x040015B6 RID: 5558
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_GetLastMoveGyro_Public_Abstract_Virtual_New_Vector3_Int32_Int32_0;

		// Token: 0x040015B7 RID: 5559
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveGetButtons_Public_Abstract_Virtual_New_Int32_Int32_Int32_0;

		// Token: 0x040015B8 RID: 5560
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveGetAnalogButton_Public_Abstract_Virtual_New_Int32_Int32_Int32_0;

		// Token: 0x040015B9 RID: 5561
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveIsConnected_Public_Abstract_Virtual_New_Boolean_Int32_Int32_0;

		// Token: 0x040015BA RID: 5562
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x040015BB RID: 5563
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Abstract_Virtual_New_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x040015BC RID: 5564
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveGetUsersMoveHandles_Public_Abstract_Virtual_New_Int32_Int32_0;

		// Token: 0x040015BD RID: 5565
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveGetControllerInputForTracking_Public_Abstract_Virtual_New_IntPtr_0;

		// Token: 0x040015BE RID: 5566
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveSetLightSphere_Public_Abstract_Virtual_New_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x040015BF RID: 5567
		private static readonly IntPtr NativeMethodInfoPtr_PS4Input_MoveSetVibration_Public_Abstract_Virtual_New_Int32_Int32_Int32_Int32_0;

		// Token: 0x040015C0 RID: 5568
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceVIDPIDs_Public_Abstract_Virtual_New_Void_byref_List_1_Int32_byref_List_1_Int32_0;

		// Token: 0x040015C1 RID: 5569
		private static readonly IntPtr NativeMethodInfoPtr_GetAndroidAPILevel_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x040015C2 RID: 5570
		private static readonly IntPtr NativeMethodInfoPtr_UnityUI_Graphic_GetRaycastTarget_Public_Abstract_Virtual_New_Boolean_Object_0;

		// Token: 0x040015C3 RID: 5571
		private static readonly IntPtr NativeMethodInfoPtr_UnityUI_Graphic_SetRaycastTarget_Public_Abstract_Virtual_New_Void_Object_Boolean_0;

		// Token: 0x040015C4 RID: 5572
		private static readonly IntPtr NativeMethodInfoPtr_get_UnityInput_IsTouchPressureSupported_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040015C5 RID: 5573
		private static readonly IntPtr NativeMethodInfoPtr_UnityInput_GetTouchPressure_Public_Abstract_Virtual_New_Single_byref_Touch_0;

		// Token: 0x040015C6 RID: 5574
		private static readonly IntPtr NativeMethodInfoPtr_UnityInput_GetTouchMaximumPossiblePressure_Public_Abstract_Virtual_New_Single_byref_Touch_0;

		// Token: 0x040015C7 RID: 5575
		private static readonly IntPtr NativeMethodInfoPtr_CreateControllerTemplate_Public_Abstract_Virtual_New_IControllerTemplate_Guid_Object_0;

		// Token: 0x040015C8 RID: 5576
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerTemplateTypes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040015C9 RID: 5577
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerTemplateInterfaceTypes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_0;
	}
}
