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
	// Token: 0x02000068 RID: 104
	public sealed class DualShock4Extension : Controller.Extension
	{
		// Token: 0x06000EB0 RID: 3760 RVA: 0x00062924 File Offset: 0x00060B24
		// Note: this type is marked as 'beforefieldinit'.
		static DualShock4Extension()
		{
			Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ControllerExtensions", "DualShock4Extension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr);
			DualShock4Extension.NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, "qtbpemUQyoPTMaHrxCYIFOqVxvz");
			DualShock4Extension.NativeFieldInfoPtr_CibDydbxAnvhtrCTUItBCQCBnsqW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, "CibDydbxAnvhtrCTUItBCQCBnsqW");
			DualShock4Extension.NativeFieldInfoPtr_KGQsYBfjblOxfiUZWLkipVdVFYP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, "KGQsYBfjblOxfiUZWLkipVdVFYP");
			DualShock4Extension.NativeMethodInfoPtr_get_joystick_Private_get_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665586);
			DualShock4Extension.NativeMethodInfoPtr__ctor_Internal_Void_IDriver_DualShock4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665587);
			DualShock4Extension.NativeMethodInfoPtr__ctor_Private_Void_DualShock4Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665588);
			DualShock4Extension.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665589);
			DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665590);
			DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665591);
			DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665592);
			DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665593);
			DualShock4Extension.NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665594);
			DualShock4Extension.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665595);
			DualShock4Extension.NativeMethodInfoPtr_GetVibration_Public_Single_DualShock4MotorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665596);
			DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665597);
			DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665598);
			DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665599);
			DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665600);
			DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665601);
			DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665602);
			DualShock4Extension.NativeMethodInfoPtr_get_lightColorRed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665603);
			DualShock4Extension.NativeMethodInfoPtr_set_lightColorRed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665604);
			DualShock4Extension.NativeMethodInfoPtr_get_lightColorGreen_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665605);
			DualShock4Extension.NativeMethodInfoPtr_set_lightColorGreen_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665606);
			DualShock4Extension.NativeMethodInfoPtr_get_lightColorBlue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665607);
			DualShock4Extension.NativeMethodInfoPtr_set_lightColorBlue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665608);
			DualShock4Extension.NativeMethodInfoPtr_GetLightColor_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665609);
			DualShock4Extension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665610);
			DualShock4Extension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665611);
			DualShock4Extension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665612);
			DualShock4Extension.NativeMethodInfoPtr_SetLightFlash_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665613);
			DualShock4Extension.NativeMethodInfoPtr_StopLightFlash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665614);
			DualShock4Extension.NativeMethodInfoPtr_GetAccelerometerValueRaw_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665615);
			DualShock4Extension.NativeMethodInfoPtr_GetAccelerometerValue_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665616);
			DualShock4Extension.NativeMethodInfoPtr_GetLastGyroscopeValueRaw_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665617);
			DualShock4Extension.NativeMethodInfoPtr_GetLastGyroscopeValue_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665618);
			DualShock4Extension.NativeMethodInfoPtr_GetGyroscopeValueRaw_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665619);
			DualShock4Extension.NativeMethodInfoPtr_GetGyroscopeValue_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665620);
			DualShock4Extension.NativeMethodInfoPtr_GetOrientation_Public_Virtual_Final_New_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665621);
			DualShock4Extension.NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665622);
			DualShock4Extension.NativeMethodInfoPtr_get_maxTouches_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665623);
			DualShock4Extension.NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665624);
			DualShock4Extension.NativeMethodInfoPtr_GetTouchId_Public_Virtual_Final_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665625);
			DualShock4Extension.NativeMethodInfoPtr_GetTouchPosition_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665626);
			DualShock4Extension.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665627);
			DualShock4Extension.NativeMethodInfoPtr_GetTouchPositionAbsolute_Public_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665628);
			DualShock4Extension.NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665629);
			DualShock4Extension.NativeMethodInfoPtr_IsTouching_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665630);
			DualShock4Extension.NativeMethodInfoPtr_IsTouchingByTouchId_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665631);
			DualShock4Extension.NativeMethodInfoPtr_get_batteryLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665632);
			DualShock4Extension.NativeMethodInfoPtr_TbnZibtYeYSFcPksjBqUcHFCgmw_Private_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665633);
			DualShock4Extension.NativeMethodInfoPtr_xDmkllxQHuTPcBJDzXtJLqbycZN_Private_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665634);
			DualShock4Extension.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665635);
			DualShock4Extension.NativeMethodInfoPtr_SouFSqCHNLMbAzpFusEqgKLXdOQA_Internal_Virtual_Void_IControllerExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665636);
			DualShock4Extension.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665637);
			DualShock4Extension.NativeMethodInfoPtr_BicogWPgevrFZwICbwpkHBEuTLD_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665638);
			DualShock4Extension.NativeMethodInfoPtr_mVQYCbUBHoFNvrjgeeLvwddRTuC_Private_Void_DualShock4MotorType_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, 100665639);
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x00062DC8 File Offset: 0x00060FC8
		public unsafe Joystick joystick
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255962, XrefRangeEnd = 255964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_get_joystick_Private_get_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Joystick>(intPtr3) : null;
			}
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00062E08 File Offset: 0x00061008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255982, RefRangeEnd = 255983, XrefRangeStart = 255964, XrefRangeEnd = 255982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DualShock4Extension(IDriver_DualShock4 driver)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(driver);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr__ctor_Internal_Void_IDriver_DualShock4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00062E54 File Offset: 0x00061054
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256003, RefRangeEnd = 256004, XrefRangeStart = 255983, XrefRangeEnd = 256003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DualShock4Extension(DualShock4Extension source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr__ctor_Private_Void_DualShock4Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x00062EA0 File Offset: 0x000610A0
		public unsafe int vibrationMotorCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256004, XrefRangeEnd = 256008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00062EDC File Offset: 0x000610DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256008, XrefRangeEnd = 256009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00062F28 File Offset: 0x00061128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256009, XrefRangeEnd = 256010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00062F84 File Offset: 0x00061184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256010, XrefRangeEnd = 256011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00062FE0 File Offset: 0x000611E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 256021, RefRangeEnd = 256026, XrefRangeStart = 256011, XrefRangeEnd = 256021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00063048 File Offset: 0x00061248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256026, XrefRangeEnd = 256038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetVibration(int motorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00063094 File Offset: 0x00061294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256038, XrefRangeEnd = 256049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopVibration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x000630C8 File Offset: 0x000612C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256049, XrefRangeEnd = 256061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetVibration(DualShock4MotorType motor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_GetVibration_Public_Single_DualShock4MotorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00063114 File Offset: 0x00061314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256061, XrefRangeEnd = 256062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00063160 File Offset: 0x00061360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256062, XrefRangeEnd = 256063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x000631BC File Offset: 0x000613BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256063, XrefRangeEnd = 256064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00063218 File Offset: 0x00061418
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 256081, RefRangeEnd = 256085, XrefRangeStart = 256064, XrefRangeEnd = 256081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00063280 File Offset: 0x00061480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256085, XrefRangeEnd = 256086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x000632CC File Offset: 0x000614CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256101, RefRangeEnd = 256102, XrefRangeStart = 256086, XrefRangeEnd = 256101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x00063334 File Offset: 0x00061534
		// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x00063370 File Offset: 0x00061570
		public unsafe float lightColorRed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256102, XrefRangeEnd = 256112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_get_lightColorRed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256112, XrefRangeEnd = 256115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_set_lightColorRed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x000633B0 File Offset: 0x000615B0
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x000633EC File Offset: 0x000615EC
		public unsafe float lightColorGreen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256115, XrefRangeEnd = 256125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_get_lightColorGreen_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256125, XrefRangeEnd = 256128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_set_lightColorGreen_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x0006342C File Offset: 0x0006162C
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x00063468 File Offset: 0x00061668
		public unsafe float lightColorBlue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256128, XrefRangeEnd = 256138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_get_lightColorBlue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256138, XrefRangeEnd = 256141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_set_lightColorBlue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x000634A8 File Offset: 0x000616A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256141, XrefRangeEnd = 256152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetLightColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_GetLightColor_Public_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x000634E4 File Offset: 0x000616E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256152, XrefRangeEnd = 256164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLightColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00063524 File Offset: 0x00061724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256164, XrefRangeEnd = 256183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x00063580 File Offset: 0x00061780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256183, XrefRangeEnd = 256198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x000635E8 File Offset: 0x000617E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256198, XrefRangeEnd = 256211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLightFlash(float onDuration, float offDuration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onDuration;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_SetLightFlash_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00063634 File Offset: 0x00061834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256211, XrefRangeEnd = 256221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopLightFlash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_StopLightFlash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00063668 File Offset: 0x00061868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256221, XrefRangeEnd = 256237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetAccelerometerValueRaw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_GetAccelerometerValueRaw_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x000636A4 File Offset: 0x000618A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256237, XrefRangeEnd = 256253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetAccelerometerValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_GetAccelerometerValue_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000636E0 File Offset: 0x000618E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256253, XrefRangeEnd = 256269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetLastGyroscopeValueRaw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_GetLastGyroscopeValueRaw_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0006371C File Offset: 0x0006191C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256269, XrefRangeEnd = 256285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetLastGyroscopeValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_GetLastGyroscopeValue_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00063758 File Offset: 0x00061958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256285, XrefRangeEnd = 256301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetGyroscopeValueRaw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_GetGyroscopeValueRaw_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00063794 File Offset: 0x00061994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256301, XrefRangeEnd = 256317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetGyroscopeValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_GetGyroscopeValue_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x000637D0 File Offset: 0x000619D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256317, XrefRangeEnd = 256334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion GetOrientation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_GetOrientation_Public_Virtual_Final_New_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0006380C File Offset: 0x00061A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256334, XrefRangeEnd = 256343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetOrientation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x00063840 File Offset: 0x00061A40
		public unsafe int maxTouches
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256343, XrefRangeEnd = 256352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_get_maxTouches_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x0006387C File Offset: 0x00061A7C
		public unsafe int touchCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256352, XrefRangeEnd = 256361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x000638B8 File Offset: 0x00061AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256361, XrefRangeEnd = 256374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTouchId(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_GetTouchId_Public_Virtual_Final_New_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00063904 File Offset: 0x00061B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256374, XrefRangeEnd = 256390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_GetTouchPosition_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0006395C File Offset: 0x00061B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256390, XrefRangeEnd = 256406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x000639B4 File Offset: 0x00061BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256406, XrefRangeEnd = 256423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_GetTouchPositionAbsolute_Public_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00063A0C File Offset: 0x00061C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256423, XrefRangeEnd = 256440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00063A64 File Offset: 0x00061C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256440, XrefRangeEnd = 256453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTouching(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_IsTouching_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00063AB0 File Offset: 0x00061CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256453, XrefRangeEnd = 256466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTouchingByTouchId(int touchId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_IsTouchingByTouchId_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x00063AFC File Offset: 0x00061CFC
		public unsafe float batteryLevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256466, XrefRangeEnd = 256475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_get_batteryLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00063B38 File Offset: 0x00061D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256475, XrefRangeEnd = 256491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TbnZibtYeYSFcPksjBqUcHFCgmw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_TbnZibtYeYSFcPksjBqUcHFCgmw_Private_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00063B74 File Offset: 0x00061D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256491, XrefRangeEnd = 256507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 xDmkllxQHuTPcBJDzXtJLqbycZN()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_xDmkllxQHuTPcBJDzXtJLqbycZN_Private_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00063BB0 File Offset: 0x00061DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256507, XrefRangeEnd = 256516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ZTVaYQHtFassaSGDSzEcxNiGpigu(UpdateLoopType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00063BF0 File Offset: 0x00061DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256516, XrefRangeEnd = 256520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SouFSqCHNLMbAzpFusEqgKLXdOQA(IControllerExtensionSource A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_SouFSqCHNLMbAzpFusEqgKLXdOQA_Internal_Virtual_Void_IControllerExtensionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00063C34 File Offset: 0x00061E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256520, XrefRangeEnd = 256524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Controller.Extension dLAxRoWNebGZzafOZSROBGeqqVrC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00063C74 File Offset: 0x00061E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256524, XrefRangeEnd = 256532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BicogWPgevrFZwICbwpkHBEuTLD()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_BicogWPgevrFZwICbwpkHBEuTLD_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00063CA8 File Offset: 0x00061EA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 256534, RefRangeEnd = 256537, XrefRangeStart = 256532, XrefRangeEnd = 256534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.NativeMethodInfoPtr_mVQYCbUBHoFNvrjgeeLvwddRTuC_Private_Void_DualShock4MotorType_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00006F64 File Offset: 0x00005164
		public DualShock4Extension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00063D04 File Offset: 0x00061F04
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x00006F6D File Offset: 0x0000516D
		public new unsafe DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ qtbpemUQyoPTMaHrxCYIFOqVxvz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Extension.NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Extension.NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x00063D34 File Offset: 0x00061F34
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x00006F8C File Offset: 0x0000518C
		public unsafe bool CibDydbxAnvhtrCTUItBCQCBnsqW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Extension.NativeFieldInfoPtr_CibDydbxAnvhtrCTUItBCQCBnsqW);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Extension.NativeFieldInfoPtr_CibDydbxAnvhtrCTUItBCQCBnsqW)) = value;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x00063D5C File Offset: 0x00061F5C
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x00006FA7 File Offset: 0x000051A7
		public unsafe Il2CppReferenceArray<TimerAbs> KGQsYBfjblOxfiUZWLkipVdVFYP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Extension.NativeFieldInfoPtr_KGQsYBfjblOxfiUZWLkipVdVFYP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TimerAbs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Extension.NativeFieldInfoPtr_KGQsYBfjblOxfiUZWLkipVdVFYP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeFieldInfoPtr_CibDydbxAnvhtrCTUItBCQCBnsqW;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeFieldInfoPtr_KGQsYBfjblOxfiUZWLkipVdVFYP;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_get_joystick_Private_get_Joystick_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IDriver_DualShock4_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_DualShock4Extension_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_GetVibration_Public_Single_DualShock4MotorType_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Single_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Boolean_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_DualShock4MotorType_Single_Single_Boolean_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_get_lightColorRed_Public_get_Single_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_set_lightColorRed_Public_set_Void_Single_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_get_lightColorGreen_Public_get_Single_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_set_lightColorGreen_Public_set_Void_Single_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_get_lightColorBlue_Public_get_Single_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_set_lightColorBlue_Public_set_Void_Single_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_GetLightColor_Public_Color_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Color_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_SetLightFlash_Public_Void_Single_Single_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_StopLightFlash_Public_Void_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_GetAccelerometerValueRaw_Public_Virtual_Final_New_Vector3_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_GetAccelerometerValue_Public_Virtual_Final_New_Vector3_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_GetLastGyroscopeValueRaw_Public_Vector3_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_GetLastGyroscopeValue_Public_Vector3_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_GetGyroscopeValueRaw_Public_Vector3_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_GetGyroscopeValue_Public_Vector3_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_GetOrientation_Public_Virtual_Final_New_Quaternion_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_get_maxTouches_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchId_Public_Virtual_Final_New_Int32_Int32_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPosition_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsolute_Public_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_IsTouching_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_IsTouchingByTouchId_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_get_batteryLevel_Public_get_Single_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_TbnZibtYeYSFcPksjBqUcHFCgmw_Private_Virtual_Final_New_Vector3_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_xDmkllxQHuTPcBJDzXtJLqbycZN_Private_Virtual_Final_New_Vector3_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_SouFSqCHNLMbAzpFusEqgKLXdOQA_Internal_Virtual_Void_IControllerExtensionSource_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr_BicogWPgevrFZwICbwpkHBEuTLD_Private_Void_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr_mVQYCbUBHoFNvrjgeeLvwddRTuC_Private_Void_DualShock4MotorType_Single_Single_0;

		// Token: 0x02000286 RID: 646
		public class nFejViFCWKGocSKAzpcgbdtfIirQ : global::Il2CppSystem.Object
		{
			// Token: 0x06003B04 RID: 15108 RVA: 0x0011CDC4 File Offset: 0x0011AFC4
			// Note: this type is marked as 'beforefieldinit'.
			static nFejViFCWKGocSKAzpcgbdtfIirQ()
			{
				Il2CppClassPointerStore<DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualShock4Extension>.NativeClassPtr, "nFejViFCWKGocSKAzpcgbdtfIirQ");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ>.NativeClassPtr);
				DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ.NativeFieldInfoPtr_KawCpyGLfFBlzjAnKPJqxvWBPnRO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ>.NativeClassPtr, "KawCpyGLfFBlzjAnKPJqxvWBPnRO");
				DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ.NativeFieldInfoPtr_NHHSBHSGBsgbYzoafsilROcNHRd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ>.NativeClassPtr, "NHHSBHSGBsgbYzoafsilROcNHRd");
				DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ.NativeFieldInfoPtr_IrPGdvpUHdQviBLkVmFelgVaPvu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ>.NativeClassPtr, "IrPGdvpUHdQviBLkVmFelgVaPvu");
				DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ.NativeMethodInfoPtr__ctor_Public_Void_IDriver_DualShock4_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ>.NativeClassPtr, 100665640);
			}

			// Token: 0x06003B05 RID: 15109 RVA: 0x0011CE40 File Offset: 0x0011B040
			[CallerCount(0)]
			public unsafe nFejViFCWKGocSKAzpcgbdtfIirQ(IDriver_DualShock4 driver, bool supportsVibration, int vibrationMotorCount)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ>.NativeClassPtr))
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ.NativeMethodInfoPtr__ctor_Public_Void_IDriver_DualShock4_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B06 RID: 15110 RVA: 0x00014F28 File Offset: 0x00013128
			public nFejViFCWKGocSKAzpcgbdtfIirQ(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011C5 RID: 4549
			// (get) Token: 0x06003B07 RID: 15111 RVA: 0x0011CEA8 File Offset: 0x0011B0A8
			// (set) Token: 0x06003B08 RID: 15112 RVA: 0x00014F31 File Offset: 0x00013131
			public unsafe IDriver_DualShock4 KawCpyGLfFBlzjAnKPJqxvWBPnRO
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ.NativeFieldInfoPtr_KawCpyGLfFBlzjAnKPJqxvWBPnRO);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDriver_DualShock4>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ.NativeFieldInfoPtr_KawCpyGLfFBlzjAnKPJqxvWBPnRO), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011C6 RID: 4550
			// (get) Token: 0x06003B09 RID: 15113 RVA: 0x0011CED8 File Offset: 0x0011B0D8
			// (set) Token: 0x06003B0A RID: 15114 RVA: 0x00014F50 File Offset: 0x00013150
			public unsafe bool NHHSBHSGBsgbYzoafsilROcNHRd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ.NativeFieldInfoPtr_NHHSBHSGBsgbYzoafsilROcNHRd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ.NativeFieldInfoPtr_NHHSBHSGBsgbYzoafsilROcNHRd)) = value;
				}
			}

			// Token: 0x170011C7 RID: 4551
			// (get) Token: 0x06003B0B RID: 15115 RVA: 0x0011CF00 File Offset: 0x0011B100
			// (set) Token: 0x06003B0C RID: 15116 RVA: 0x00014F6B File Offset: 0x0001316B
			public unsafe int IrPGdvpUHdQviBLkVmFelgVaPvu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ.NativeFieldInfoPtr_IrPGdvpUHdQviBLkVmFelgVaPvu);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Extension.nFejViFCWKGocSKAzpcgbdtfIirQ.NativeFieldInfoPtr_IrPGdvpUHdQviBLkVmFelgVaPvu)) = value;
				}
			}

			// Token: 0x0400318A RID: 12682
			private static readonly IntPtr NativeFieldInfoPtr_KawCpyGLfFBlzjAnKPJqxvWBPnRO;

			// Token: 0x0400318B RID: 12683
			private static readonly IntPtr NativeFieldInfoPtr_NHHSBHSGBsgbYzoafsilROcNHRd;

			// Token: 0x0400318C RID: 12684
			private static readonly IntPtr NativeFieldInfoPtr_IrPGdvpUHdQviBLkVmFelgVaPvu;

			// Token: 0x0400318D RID: 12685
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDriver_DualShock4_Boolean_Int32_0;
		}
	}
}
