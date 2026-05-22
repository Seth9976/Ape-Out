using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Drivers.Interfaces;
using Il2CppRewired.Interfaces;
using Il2CppRewired.Utils.Classes.Utility;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.ControllerExtensions
{
	// Token: 0x02000066 RID: 102
	public sealed class DualSenseExtension : Controller.Extension
	{
		// Token: 0x06000E6B RID: 3691 RVA: 0x00061328 File Offset: 0x0005F528
		// Note: this type is marked as 'beforefieldinit'.
		static DualSenseExtension()
		{
			Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ControllerExtensions", "DualSenseExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr);
			DualSenseExtension.NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, "qtbpemUQyoPTMaHrxCYIFOqVxvz");
			DualSenseExtension.NativeFieldInfoPtr_CibDydbxAnvhtrCTUItBCQCBnsqW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, "CibDydbxAnvhtrCTUItBCQCBnsqW");
			DualSenseExtension.NativeFieldInfoPtr_KGQsYBfjblOxfiUZWLkipVdVFYP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, "KGQsYBfjblOxfiUZWLkipVdVFYP");
			DualSenseExtension.NativeMethodInfoPtr_get_joystick_Private_get_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665526);
			DualSenseExtension.NativeMethodInfoPtr__ctor_Internal_Void_IDriver_DualSense_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665527);
			DualSenseExtension.NativeMethodInfoPtr__ctor_Private_Void_DualSenseExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665528);
			DualSenseExtension.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665529);
			DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665530);
			DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665531);
			DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665532);
			DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665533);
			DualSenseExtension.NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665534);
			DualSenseExtension.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665535);
			DualSenseExtension.NativeMethodInfoPtr_GetVibration_Public_Single_DualShock4MotorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665536);
			DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665537);
			DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665538);
			DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665539);
			DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665540);
			DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665541);
			DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665542);
			DualSenseExtension.NativeMethodInfoPtr_get_lightColorRed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665543);
			DualSenseExtension.NativeMethodInfoPtr_set_lightColorRed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665544);
			DualSenseExtension.NativeMethodInfoPtr_get_lightColorGreen_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665545);
			DualSenseExtension.NativeMethodInfoPtr_set_lightColorGreen_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665546);
			DualSenseExtension.NativeMethodInfoPtr_get_lightColorBlue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665547);
			DualSenseExtension.NativeMethodInfoPtr_set_lightColorBlue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665548);
			DualSenseExtension.NativeMethodInfoPtr_GetLightColor_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665549);
			DualSenseExtension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665550);
			DualSenseExtension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665551);
			DualSenseExtension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665552);
			DualSenseExtension.NativeMethodInfoPtr_get_microphoneLightMode_Public_get_DualSenseMicrophoneLightMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665553);
			DualSenseExtension.NativeMethodInfoPtr_set_microphoneLightMode_Public_set_Void_DualSenseMicrophoneLightMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665554);
			DualSenseExtension.NativeMethodInfoPtr_get_otherLightBrightness_Public_get_DualSenseOtherLightBrightness_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665555);
			DualSenseExtension.NativeMethodInfoPtr_set_otherLightBrightness_Public_set_Void_DualSenseOtherLightBrightness_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665556);
			DualSenseExtension.NativeMethodInfoPtr_get_playerLights_Public_get_DualSensePlayerLightFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665557);
			DualSenseExtension.NativeMethodInfoPtr_set_playerLights_Public_set_Void_DualSensePlayerLightFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665558);
			DualSenseExtension.NativeMethodInfoPtr_GetAccelerometerValueRaw_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665559);
			DualSenseExtension.NativeMethodInfoPtr_GetAccelerometerValue_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665560);
			DualSenseExtension.NativeMethodInfoPtr_GetLastGyroscopeValueRaw_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665561);
			DualSenseExtension.NativeMethodInfoPtr_GetLastGyroscopeValue_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665562);
			DualSenseExtension.NativeMethodInfoPtr_GetGyroscopeValueRaw_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665563);
			DualSenseExtension.NativeMethodInfoPtr_GetGyroscopeValue_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665564);
			DualSenseExtension.NativeMethodInfoPtr_GetOrientation_Public_Virtual_Final_New_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665565);
			DualSenseExtension.NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665566);
			DualSenseExtension.NativeMethodInfoPtr_get_maxTouches_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665567);
			DualSenseExtension.NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665568);
			DualSenseExtension.NativeMethodInfoPtr_GetTouchId_Public_Virtual_Final_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665569);
			DualSenseExtension.NativeMethodInfoPtr_GetTouchPosition_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665570);
			DualSenseExtension.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665571);
			DualSenseExtension.NativeMethodInfoPtr_GetTouchPositionAbsolute_Public_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665572);
			DualSenseExtension.NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665573);
			DualSenseExtension.NativeMethodInfoPtr_IsTouching_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665574);
			DualSenseExtension.NativeMethodInfoPtr_IsTouchingByTouchId_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665575);
			DualSenseExtension.NativeMethodInfoPtr_get_batteryLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665576);
			DualSenseExtension.NativeMethodInfoPtr_get_batteryCharging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665577);
			DualSenseExtension.NativeMethodInfoPtr_TbnZibtYeYSFcPksjBqUcHFCgmw_Private_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665578);
			DualSenseExtension.NativeMethodInfoPtr_xDmkllxQHuTPcBJDzXtJLqbycZN_Private_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665579);
			DualSenseExtension.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665580);
			DualSenseExtension.NativeMethodInfoPtr_SouFSqCHNLMbAzpFusEqgKLXdOQA_Internal_Virtual_Void_IControllerExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665581);
			DualSenseExtension.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665582);
			DualSenseExtension.NativeMethodInfoPtr_BicogWPgevrFZwICbwpkHBEuTLD_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665583);
			DualSenseExtension.NativeMethodInfoPtr_mVQYCbUBHoFNvrjgeeLvwddRTuC_Private_Void_DualShock4MotorType_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, 100665584);
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00061830 File Offset: 0x0005FA30
		public unsafe Joystick joystick
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255341, XrefRangeEnd = 255343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_get_joystick_Private_get_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Joystick>(intPtr3) : null;
			}
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00061870 File Offset: 0x0005FA70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255361, RefRangeEnd = 255362, XrefRangeStart = 255343, XrefRangeEnd = 255361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DualSenseExtension(IDriver_DualSense driver)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(driver);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr__ctor_Internal_Void_IDriver_DualSense_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x000618BC File Offset: 0x0005FABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255382, RefRangeEnd = 255383, XrefRangeStart = 255362, XrefRangeEnd = 255382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DualSenseExtension(DualSenseExtension source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr__ctor_Private_Void_DualSenseExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x00061908 File Offset: 0x0005FB08
		public unsafe int vibrationMotorCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255383, XrefRangeEnd = 255387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00061944 File Offset: 0x0005FB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255387, XrefRangeEnd = 255388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(int motorIndex, float motorLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00061990 File Offset: 0x0005FB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255388, XrefRangeEnd = 255389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(int motorIndex, float motorLevel, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x000619EC File Offset: 0x0005FBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255389, XrefRangeEnd = 255390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopOtherMotors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00061A48 File Offset: 0x0005FC48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 255400, RefRangeEnd = 255405, XrefRangeStart = 255390, XrefRangeEnd = 255400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopOtherMotors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00061AB0 File Offset: 0x0005FCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255405, XrefRangeEnd = 255417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetVibration(int motorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00061AFC File Offset: 0x0005FCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255417, XrefRangeEnd = 255428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopVibration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00061B30 File Offset: 0x0005FD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255428, XrefRangeEnd = 255440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetVibration(DualShock4MotorType motor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_GetVibration_Public_Single_DualShock4MotorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00061B7C File Offset: 0x0005FD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255440, XrefRangeEnd = 255441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(DualShock4MotorType motor, float motorLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00061BC8 File Offset: 0x0005FDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255441, XrefRangeEnd = 255442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(DualShock4MotorType motor, float motorLevel, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00061C24 File Offset: 0x0005FE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255442, XrefRangeEnd = 255443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(DualShock4MotorType motor, float motorLevel, bool stopOtherMotors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopOtherMotors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00061C80 File Offset: 0x0005FE80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 255460, RefRangeEnd = 255464, XrefRangeStart = 255443, XrefRangeEnd = 255460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(DualShock4MotorType motor, float motorLevel, float duration, bool stopOtherMotors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopOtherMotors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00061CE8 File Offset: 0x0005FEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255464, XrefRangeEnd = 255465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(float leftMotorLevel, float rightMotorLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref leftMotorLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightMotorLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00061D34 File Offset: 0x0005FF34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255480, RefRangeEnd = 255481, XrefRangeStart = 255465, XrefRangeEnd = 255480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref leftMotorLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightMotorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftMotorDuration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightMotorDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x00061D9C File Offset: 0x0005FF9C
		// (set) Token: 0x06000E7E RID: 3710 RVA: 0x00061DD8 File Offset: 0x0005FFD8
		public unsafe float lightColorRed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255481, XrefRangeEnd = 255491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_get_lightColorRed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255491, XrefRangeEnd = 255494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_set_lightColorRed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x00061E18 File Offset: 0x00060018
		// (set) Token: 0x06000E80 RID: 3712 RVA: 0x00061E54 File Offset: 0x00060054
		public unsafe float lightColorGreen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255494, XrefRangeEnd = 255504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_get_lightColorGreen_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255504, XrefRangeEnd = 255507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_set_lightColorGreen_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x00061E94 File Offset: 0x00060094
		// (set) Token: 0x06000E82 RID: 3714 RVA: 0x00061ED0 File Offset: 0x000600D0
		public unsafe float lightColorBlue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255507, XrefRangeEnd = 255517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_get_lightColorBlue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255517, XrefRangeEnd = 255520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_set_lightColorBlue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00061F10 File Offset: 0x00060110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255520, XrefRangeEnd = 255531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetLightColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_GetLightColor_Public_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00061F4C File Offset: 0x0006014C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255531, XrefRangeEnd = 255543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLightColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00061F8C File Offset: 0x0006018C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255543, XrefRangeEnd = 255562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLightColor(float red, float green, float blue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref red;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref green;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00061FE8 File Offset: 0x000601E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255562, XrefRangeEnd = 255577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLightColor(float red, float green, float blue, float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref red;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref green;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x00062050 File Offset: 0x00060250
		// (set) Token: 0x06000E88 RID: 3720 RVA: 0x0006208C File Offset: 0x0006028C
		public unsafe DualSenseMicrophoneLightMode microphoneLightMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255577, XrefRangeEnd = 255587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_get_microphoneLightMode_Public_get_DualSenseMicrophoneLightMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255587, XrefRangeEnd = 255597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_set_microphoneLightMode_Public_set_Void_DualSenseMicrophoneLightMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x000620CC File Offset: 0x000602CC
		// (set) Token: 0x06000E8A RID: 3722 RVA: 0x00062108 File Offset: 0x00060308
		public unsafe DualSenseOtherLightBrightness otherLightBrightness
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255597, XrefRangeEnd = 255607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_get_otherLightBrightness_Public_get_DualSenseOtherLightBrightness_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255607, XrefRangeEnd = 255617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_set_otherLightBrightness_Public_set_Void_DualSenseOtherLightBrightness_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x00062148 File Offset: 0x00060348
		// (set) Token: 0x06000E8C RID: 3724 RVA: 0x00062184 File Offset: 0x00060384
		public unsafe DualSensePlayerLightFlags playerLights
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255617, XrefRangeEnd = 255627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_get_playerLights_Public_get_DualSensePlayerLightFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255627, XrefRangeEnd = 255637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_set_playerLights_Public_set_Void_DualSensePlayerLightFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x000621C4 File Offset: 0x000603C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255637, XrefRangeEnd = 255653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetAccelerometerValueRaw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_GetAccelerometerValueRaw_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00062200 File Offset: 0x00060400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255653, XrefRangeEnd = 255669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetAccelerometerValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_GetAccelerometerValue_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0006223C File Offset: 0x0006043C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255669, XrefRangeEnd = 255685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetLastGyroscopeValueRaw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_GetLastGyroscopeValueRaw_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00062278 File Offset: 0x00060478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255685, XrefRangeEnd = 255701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetLastGyroscopeValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_GetLastGyroscopeValue_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x000622B4 File Offset: 0x000604B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255701, XrefRangeEnd = 255717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetGyroscopeValueRaw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_GetGyroscopeValueRaw_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x000622F0 File Offset: 0x000604F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255717, XrefRangeEnd = 255733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetGyroscopeValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_GetGyroscopeValue_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0006232C File Offset: 0x0006052C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255733, XrefRangeEnd = 255750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion GetOrientation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_GetOrientation_Public_Virtual_Final_New_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00062368 File Offset: 0x00060568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255750, XrefRangeEnd = 255759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetOrientation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x0006239C File Offset: 0x0006059C
		public unsafe int maxTouches
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255759, XrefRangeEnd = 255768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_get_maxTouches_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x000623D8 File Offset: 0x000605D8
		public unsafe int touchCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255768, XrefRangeEnd = 255777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00062414 File Offset: 0x00060614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255777, XrefRangeEnd = 255790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTouchId(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_GetTouchId_Public_Virtual_Final_New_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00062460 File Offset: 0x00060660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255790, XrefRangeEnd = 255806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetTouchPosition(int index, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_GetTouchPosition_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x000624B8 File Offset: 0x000606B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255806, XrefRangeEnd = 255822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetTouchPositionByTouchId(int touchId, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00062510 File Offset: 0x00060710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255822, XrefRangeEnd = 255839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetTouchPositionAbsolute(int index, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_GetTouchPositionAbsolute_Public_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00062568 File Offset: 0x00060768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255839, XrefRangeEnd = 255856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetTouchPositionAbsoluteByTouchId(int touchId, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x000625C0 File Offset: 0x000607C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255856, XrefRangeEnd = 255869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTouching(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_IsTouching_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0006260C File Offset: 0x0006080C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255869, XrefRangeEnd = 255882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTouchingByTouchId(int touchId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_IsTouchingByTouchId_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x00062658 File Offset: 0x00060858
		public unsafe float batteryLevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255882, XrefRangeEnd = 255891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_get_batteryLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x00062694 File Offset: 0x00060894
		public unsafe bool batteryCharging
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255891, XrefRangeEnd = 255900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_get_batteryCharging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x000626D0 File Offset: 0x000608D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255900, XrefRangeEnd = 255916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TbnZibtYeYSFcPksjBqUcHFCgmw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_TbnZibtYeYSFcPksjBqUcHFCgmw_Private_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0006270C File Offset: 0x0006090C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255916, XrefRangeEnd = 255932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 xDmkllxQHuTPcBJDzXtJLqbycZN()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_xDmkllxQHuTPcBJDzXtJLqbycZN_Private_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00062748 File Offset: 0x00060948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255932, XrefRangeEnd = 255941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ZTVaYQHtFassaSGDSzEcxNiGpigu(UpdateLoopType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00062788 File Offset: 0x00060988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255941, XrefRangeEnd = 255945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SouFSqCHNLMbAzpFusEqgKLXdOQA(IControllerExtensionSource A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_SouFSqCHNLMbAzpFusEqgKLXdOQA_Internal_Virtual_Void_IControllerExtensionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x000627CC File Offset: 0x000609CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255945, XrefRangeEnd = 255949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Controller.Extension dLAxRoWNebGZzafOZSROBGeqqVrC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0006280C File Offset: 0x00060A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255949, XrefRangeEnd = 255957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BicogWPgevrFZwICbwpkHBEuTLD()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_BicogWPgevrFZwICbwpkHBEuTLD_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00062840 File Offset: 0x00060A40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 255959, RefRangeEnd = 255962, XrefRangeStart = 255957, XrefRangeEnd = 255959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void mVQYCbUBHoFNvrjgeeLvwddRTuC(DualShock4MotorType A_1, float A_2, float A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.NativeMethodInfoPtr_mVQYCbUBHoFNvrjgeeLvwddRTuC_Private_Void_DualShock4MotorType_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00006EDE File Offset: 0x000050DE
		public DualSenseExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x0006289C File Offset: 0x00060A9C
		// (set) Token: 0x06000EA9 RID: 3753 RVA: 0x00006EE7 File Offset: 0x000050E7
		public new unsafe DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY qtbpemUQyoPTMaHrxCYIFOqVxvz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseExtension.NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseExtension.NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x000628CC File Offset: 0x00060ACC
		// (set) Token: 0x06000EAB RID: 3755 RVA: 0x00006F06 File Offset: 0x00005106
		public unsafe bool CibDydbxAnvhtrCTUItBCQCBnsqW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseExtension.NativeFieldInfoPtr_CibDydbxAnvhtrCTUItBCQCBnsqW);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseExtension.NativeFieldInfoPtr_CibDydbxAnvhtrCTUItBCQCBnsqW)) = value;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x000628F4 File Offset: 0x00060AF4
		// (set) Token: 0x06000EAD RID: 3757 RVA: 0x00006F21 File Offset: 0x00005121
		public unsafe Il2CppReferenceArray<TimerAbs> KGQsYBfjblOxfiUZWLkipVdVFYP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseExtension.NativeFieldInfoPtr_KGQsYBfjblOxfiUZWLkipVdVFYP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TimerAbs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseExtension.NativeFieldInfoPtr_KGQsYBfjblOxfiUZWLkipVdVFYP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeFieldInfoPtr_CibDydbxAnvhtrCTUItBCQCBnsqW;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeFieldInfoPtr_KGQsYBfjblOxfiUZWLkipVdVFYP;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_get_joystick_Private_get_Joystick_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IDriver_DualSense_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_DualSenseExtension_0;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_GetVibration_Public_Single_DualShock4MotorType_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Single_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Boolean_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Single_Boolean_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_0;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeMethodInfoPtr_get_lightColorRed_Public_get_Single_0;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr_set_lightColorRed_Public_set_Void_Single_0;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeMethodInfoPtr_get_lightColorGreen_Public_get_Single_0;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_set_lightColorGreen_Public_set_Void_Single_0;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_get_lightColorBlue_Public_get_Single_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_set_lightColorBlue_Public_set_Void_Single_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_GetLightColor_Public_Color_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Color_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_get_microphoneLightMode_Public_get_DualSenseMicrophoneLightMode_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_set_microphoneLightMode_Public_set_Void_DualSenseMicrophoneLightMode_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_get_otherLightBrightness_Public_get_DualSenseOtherLightBrightness_0;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr_set_otherLightBrightness_Public_set_Void_DualSenseOtherLightBrightness_0;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_get_playerLights_Public_get_DualSensePlayerLightFlags_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr_set_playerLights_Public_set_Void_DualSensePlayerLightFlags_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_GetAccelerometerValueRaw_Public_Virtual_Final_New_Vector3_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr_GetAccelerometerValue_Public_Virtual_Final_New_Vector3_0;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeMethodInfoPtr_GetLastGyroscopeValueRaw_Public_Vector3_0;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr_GetLastGyroscopeValue_Public_Vector3_0;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeMethodInfoPtr_GetGyroscopeValueRaw_Public_Vector3_0;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr_GetGyroscopeValue_Public_Vector3_0;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_GetOrientation_Public_Virtual_Final_New_Quaternion_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_get_maxTouches_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchId_Public_Virtual_Final_New_Int32_Int32_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPosition_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsolute_Public_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr_IsTouching_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr_IsTouchingByTouchId_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr_get_batteryLevel_Public_get_Single_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_get_batteryCharging_Public_get_Boolean_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr_TbnZibtYeYSFcPksjBqUcHFCgmw_Private_Virtual_Final_New_Vector3_0;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr_xDmkllxQHuTPcBJDzXtJLqbycZN_Private_Virtual_Final_New_Vector3_0;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeMethodInfoPtr_SouFSqCHNLMbAzpFusEqgKLXdOQA_Internal_Virtual_Void_IControllerExtensionSource_0;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr_BicogWPgevrFZwICbwpkHBEuTLD_Private_Void_0;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr_mVQYCbUBHoFNvrjgeeLvwddRTuC_Private_Void_DualShock4MotorType_Single_Single_0;

		// Token: 0x02000285 RID: 645
		public class tRKZRJcgHFtOAwCAQRNCDZeNsrY : global::Il2CppSystem.Object
		{
			// Token: 0x06003AFB RID: 15099 RVA: 0x0011CC60 File Offset: 0x0011AE60
			// Note: this type is marked as 'beforefieldinit'.
			static tRKZRJcgHFtOAwCAQRNCDZeNsrY()
			{
				Il2CppClassPointerStore<DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualSenseExtension>.NativeClassPtr, "tRKZRJcgHFtOAwCAQRNCDZeNsrY");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY>.NativeClassPtr);
				DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY.NativeFieldInfoPtr_KawCpyGLfFBlzjAnKPJqxvWBPnRO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY>.NativeClassPtr, "KawCpyGLfFBlzjAnKPJqxvWBPnRO");
				DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY.NativeFieldInfoPtr_NHHSBHSGBsgbYzoafsilROcNHRd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY>.NativeClassPtr, "NHHSBHSGBsgbYzoafsilROcNHRd");
				DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY.NativeFieldInfoPtr_IrPGdvpUHdQviBLkVmFelgVaPvu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY>.NativeClassPtr, "IrPGdvpUHdQviBLkVmFelgVaPvu");
				DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY.NativeMethodInfoPtr__ctor_Public_Void_IDriver_DualSense_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY>.NativeClassPtr, 100665585);
			}

			// Token: 0x06003AFC RID: 15100 RVA: 0x0011CCDC File Offset: 0x0011AEDC
			[CallerCount(0)]
			public unsafe tRKZRJcgHFtOAwCAQRNCDZeNsrY(IDriver_DualSense driver, bool supportsVibration, int vibrationMotorCount)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(driver);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref supportsVibration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrationMotorCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY.NativeMethodInfoPtr__ctor_Public_Void_IDriver_DualSense_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AFD RID: 15101 RVA: 0x00014ECA File Offset: 0x000130CA
			public tRKZRJcgHFtOAwCAQRNCDZeNsrY(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011C2 RID: 4546
			// (get) Token: 0x06003AFE RID: 15102 RVA: 0x0011CD44 File Offset: 0x0011AF44
			// (set) Token: 0x06003AFF RID: 15103 RVA: 0x00014ED3 File Offset: 0x000130D3
			public unsafe IDriver_DualSense KawCpyGLfFBlzjAnKPJqxvWBPnRO
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY.NativeFieldInfoPtr_KawCpyGLfFBlzjAnKPJqxvWBPnRO);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDriver_DualSense>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY.NativeFieldInfoPtr_KawCpyGLfFBlzjAnKPJqxvWBPnRO), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011C3 RID: 4547
			// (get) Token: 0x06003B00 RID: 15104 RVA: 0x0011CD74 File Offset: 0x0011AF74
			// (set) Token: 0x06003B01 RID: 15105 RVA: 0x00014EF2 File Offset: 0x000130F2
			public unsafe bool NHHSBHSGBsgbYzoafsilROcNHRd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY.NativeFieldInfoPtr_NHHSBHSGBsgbYzoafsilROcNHRd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY.NativeFieldInfoPtr_NHHSBHSGBsgbYzoafsilROcNHRd)) = value;
				}
			}

			// Token: 0x170011C4 RID: 4548
			// (get) Token: 0x06003B02 RID: 15106 RVA: 0x0011CD9C File Offset: 0x0011AF9C
			// (set) Token: 0x06003B03 RID: 15107 RVA: 0x00014F0D File Offset: 0x0001310D
			public unsafe int IrPGdvpUHdQviBLkVmFelgVaPvu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY.NativeFieldInfoPtr_IrPGdvpUHdQviBLkVmFelgVaPvu);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseExtension.tRKZRJcgHFtOAwCAQRNCDZeNsrY.NativeFieldInfoPtr_IrPGdvpUHdQviBLkVmFelgVaPvu)) = value;
				}
			}

			// Token: 0x04003186 RID: 12678
			private static readonly IntPtr NativeFieldInfoPtr_KawCpyGLfFBlzjAnKPJqxvWBPnRO;

			// Token: 0x04003187 RID: 12679
			private static readonly IntPtr NativeFieldInfoPtr_NHHSBHSGBsgbYzoafsilROcNHRd;

			// Token: 0x04003188 RID: 12680
			private static readonly IntPtr NativeFieldInfoPtr_IrPGdvpUHdQviBLkVmFelgVaPvu;

			// Token: 0x04003189 RID: 12681
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDriver_DualSense_Boolean_Int32_0;
		}
	}
}
