using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Interfaces;
using Il2CppRewired.Utils.Classes.Utility;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppRewired
{
	// Token: 0x0200006E RID: 110
	public class Joystick : ControllerWithAxes
	{
		// Token: 0x06000F1D RID: 3869 RVA: 0x00064CC4 File Offset: 0x00062EC4
		// Note: this type is marked as 'beforefieldinit'.
		static Joystick()
		{
			Il2CppClassPointerStore<Joystick>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "Joystick");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Joystick>.NativeClassPtr);
			Joystick.NativeFieldInfoPtr_AEsdjlGVwWGNcpvbGJArGOOOfzU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Joystick>.NativeClassPtr, "AEsdjlGVwWGNcpvbGJArGOOOfzU");
			Joystick.NativeFieldInfoPtr_fFTvCfHAfJJoUQSgzzebIMBoiVA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Joystick>.NativeClassPtr, "fFTvCfHAfJJoUQSgzzebIMBoiVA");
			Joystick.NativeFieldInfoPtr_SCcpHGmKkKHrhjNArxMwLrKriajd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Joystick>.NativeClassPtr, "SCcpHGmKkKHrhjNArxMwLrKriajd");
			Joystick.NativeFieldInfoPtr_HOWhuOzXWOaRjtfeNkKkNxLUBqS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Joystick>.NativeClassPtr, "HOWhuOzXWOaRjtfeNkKkNxLUBqS");
			Joystick.NativeFieldInfoPtr_eVRuJsSbYUIPtExWgOPEcmhifAz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Joystick>.NativeClassPtr, "eVRuJsSbYUIPtExWgOPEcmhifAz");
			Joystick.NativeFieldInfoPtr_GpmFnBAxUAdXwLkqaXOSEemYXrFI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Joystick>.NativeClassPtr, "GpmFnBAxUAdXwLkqaXOSEemYXrFI");
			Joystick.NativeFieldInfoPtr_cUrKEUZCFlKCrmVTkHgbrJZEKZA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Joystick>.NativeClassPtr, "cUrKEUZCFlKCrmVTkHgbrJZEKZA");
			Joystick.NativeFieldInfoPtr_tLLssZQnFqTggAZWaCSOsEdqnLi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Joystick>.NativeClassPtr, "tLLssZQnFqTggAZWaCSOsEdqnLi");
			Joystick.NativeFieldInfoPtr_VVhgLAeFmigjNmGXNcHtgCjEiapm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Joystick>.NativeClassPtr, "VVhgLAeFmigjNmGXNcHtgCjEiapm");
			Joystick.NativeFieldInfoPtr_cLLBlpsDXvfsYCchjcUtbZigMYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Joystick>.NativeClassPtr, "cLLBlpsDXvfsYCchjcUtbZigMYS");
			Joystick.NativeFieldInfoPtr_gHIVPONHlarbrgDHNByMDTYKqarF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Joystick>.NativeClassPtr, "gHIVPONHlarbrgDHNByMDTYKqarF");
			Joystick.NativeFieldInfoPtr_zDyyBaxsowomSCnDgbuHSLXwmRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Joystick>.NativeClassPtr, "zDyyBaxsowomSCnDgbuHSLXwmRp");
			Joystick.NativeFieldInfoPtr_lOVOKHbRvmrBECkaooLEUBWSVFk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Joystick>.NativeClassPtr, "lOVOKHbRvmrBECkaooLEUBWSVFk");
			Joystick.NativeFieldInfoPtr_LIVqABZIEhjfebFiaeDYMYMlDg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Joystick>.NativeClassPtr, "LIVqABZIEhjfebFiaeDYMYMlDg");
			Joystick.NativeMethodInfoPtr_get_joystickTypes_Internal_get_IList_1_JoystickType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665682);
			Joystick.NativeMethodInfoPtr_get_systemId_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665683);
			Joystick.NativeMethodInfoPtr_get_unityId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665684);
			Joystick.NativeMethodInfoPtr_get_deviceInstanceGuid_Public_Virtual_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665685);
			Joystick.NativeMethodInfoPtr_get_supportsVibration_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665686);
			Joystick.NativeMethodInfoPtr_get_vibrationLeftMotor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665687);
			Joystick.NativeMethodInfoPtr_set_vibrationLeftMotor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665688);
			Joystick.NativeMethodInfoPtr_get_vibrationRightMotor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665689);
			Joystick.NativeMethodInfoPtr_set_vibrationRightMotor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665690);
			Joystick.NativeMethodInfoPtr_get_vibrationMotorCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665691);
			Joystick.NativeMethodInfoPtr_get_hatCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665692);
			Joystick.NativeMethodInfoPtr_get_Hats_Public_get_IList_1_Hat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665693);
			Joystick.NativeMethodInfoPtr_get_inputManagerId_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665694);
			Joystick.NativeMethodInfoPtr_get_hardwareJoystickMapIdentifier_Internal_get_HardwareControllerMapIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665695);
			Joystick.NativeMethodInfoPtr__ctor_Internal_Void_BridgedController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665696);
			Joystick.NativeMethodInfoPtr__ctor_Private_Void_Int32_InputSource_String_String_String_Guid_Int32_Int32_Il2CppStructArray_1_Boolean_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665697);
			Joystick.NativeMethodInfoPtr_pzSAPtkDmWJcEYzUtRfKDMnXdSKj_Internal_Boolean_JoystickType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665698);
			Joystick.NativeMethodInfoPtr_GetCalibrationMapSaveData_Public_JoystickCalibrationMapSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665699);
			Joystick.NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665700);
			Joystick.NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665701);
			Joystick.NativeMethodInfoPtr_SetVibration_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665702);
			Joystick.NativeMethodInfoPtr_SetVibration_Public_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665703);
			Joystick.NativeMethodInfoPtr_SetVibration_Public_Void_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665704);
			Joystick.NativeMethodInfoPtr_SetVibration_Public_Void_Int32_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665705);
			Joystick.NativeMethodInfoPtr_GetVibration_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665706);
			Joystick.NativeMethodInfoPtr_StopVibration_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665707);
			Joystick.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665708);
			Joystick.NativeMethodInfoPtr_EXhlSeorjNzEIHugqDlyUldaKiw_Internal_Void_UpdateControllerInfoEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665709);
			Joystick.NativeMethodInfoPtr_EXhlSeorjNzEIHugqDlyUldaKiw_Internal_Void_BridgedController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665710);
			Joystick.NativeMethodInfoPtr_EXhlSeorjNzEIHugqDlyUldaKiw_Private_Void_IInputManagerJoystickPublic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665711);
			Joystick.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665712);
			Joystick.NativeMethodInfoPtr_zmCSqHjkWDCylUlUderSfqqEXvh_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665713);
			Joystick.NativeMethodInfoPtr_Disconnected_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665714);
			Joystick.NativeMethodInfoPtr_BicogWPgevrFZwICbwpkHBEuTLD_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665715);
			Joystick.NativeMethodInfoPtr_ldAIQKxjQFodHEUZeGmcSizXhQa_Private_Void_Int32_Single_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665716);
			Joystick.NativeMethodInfoPtr_NdkCWjftCZbkhJqjBFAJjLorAcw_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665717);
			Joystick.NativeMethodInfoPtr_dbTjMYAbOjFqFnMKaRABcDWexVJ_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665718);
			Joystick.NativeMethodInfoPtr_DpGZptroiKHjdiDdLdyrYqbNCOtb_Internal_Static_Int32_Joystick_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joystick>.NativeClassPtr, 100665719);
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x00065104 File Offset: 0x00063304
		public unsafe IList<JoystickType> joystickTypes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256799, XrefRangeEnd = 256804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_get_joystickTypes_Internal_get_IList_1_JoystickType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JoystickType>>(intPtr3) : null;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x00065144 File Offset: 0x00063344
		public unsafe Nullable<long> systemId
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 256811, RefRangeEnd = 256813, XrefRangeStart = 256804, XrefRangeEnd = 256811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_get_systemId_Public_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<long>(intPtr);
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x0006517C File Offset: 0x0006337C
		public unsafe int unityId
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 256822, RefRangeEnd = 256824, XrefRangeStart = 256813, XrefRangeEnd = 256822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_get_unityId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x000651B8 File Offset: 0x000633B8
		public unsafe override Guid deviceInstanceGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256824, XrefRangeEnd = 256838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Joystick.NativeMethodInfoPtr_get_deviceInstanceGuid_Public_Virtual_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x00065200 File Offset: 0x00063400
		public unsafe bool supportsVibration
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 256842, RefRangeEnd = 256846, XrefRangeStart = 256838, XrefRangeEnd = 256842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_get_supportsVibration_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x0006523C File Offset: 0x0006343C
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x00065278 File Offset: 0x00063478
		public unsafe float vibrationLeftMotor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256846, XrefRangeEnd = 256858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_get_vibrationLeftMotor_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256858, XrefRangeEnd = 256867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_set_vibrationLeftMotor_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x000652B8 File Offset: 0x000634B8
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x000652F4 File Offset: 0x000634F4
		public unsafe float vibrationRightMotor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256867, XrefRangeEnd = 256879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_get_vibrationRightMotor_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256879, XrefRangeEnd = 256888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_set_vibrationRightMotor_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x00065334 File Offset: 0x00063534
		public unsafe int vibrationMotorCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 256896, RefRangeEnd = 256897, XrefRangeStart = 256888, XrefRangeEnd = 256896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_get_vibrationMotorCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00065370 File Offset: 0x00063570
		public unsafe int hatCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 256901, RefRangeEnd = 256902, XrefRangeStart = 256897, XrefRangeEnd = 256901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_get_hatCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x000653AC File Offset: 0x000635AC
		public unsafe IList<Controller.Hat> Hats
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256902, XrefRangeEnd = 256907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_get_Hats_Public_get_IList_1_Hat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Controller.Hat>>(intPtr3) : null;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x000653EC File Offset: 0x000635EC
		public unsafe int inputManagerId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 256911, RefRangeEnd = 256912, XrefRangeStart = 256907, XrefRangeEnd = 256911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_get_inputManagerId_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x00065428 File Offset: 0x00063628
		public unsafe HardwareControllerMapIdentifier hardwareJoystickMapIdentifier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_get_hardwareJoystickMapIdentifier_Internal_get_HardwareControllerMapIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00065464 File Offset: 0x00063664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257011, RefRangeEnd = 257012, XrefRangeStart = 256912, XrefRangeEnd = 257011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Joystick(BridgedController controller)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Joystick>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr__ctor_Internal_Void_BridgedController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x000654B0 File Offset: 0x000636B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257098, RefRangeEnd = 257099, XrefRangeStart = 257012, XrefRangeEnd = 257098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Joystick(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, Guid hardwareTypeGuid, int axisCount, int buttonCount, Il2CppStructArray<bool> isButtonPressureSensitive, HardwareControllerMap_Game hardwareMap, Controller.Extension extension, ControllerDataUpdater dataUpdater)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Joystick>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputSource;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hardwareName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hardwareIdentifier);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hardwareTypeGuid;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonCount;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(isButtonPressureSensitive);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hardwareMap);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extension);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataUpdater);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr__ctor_Private_Void_Int32_InputSource_String_String_String_Guid_Int32_Int32_Il2CppStructArray_1_Boolean_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x000655B8 File Offset: 0x000637B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257099, XrefRangeEnd = 257103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool pzSAPtkDmWJcEYzUtRfKDMnXdSKj(JoystickType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_pzSAPtkDmWJcEYzUtRfKDMnXdSKj_Internal_Boolean_JoystickType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00065604 File Offset: 0x00063804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257103, XrefRangeEnd = 257112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoystickCalibrationMapSaveData GetCalibrationMapSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_GetCalibrationMapSaveData_Public_JoystickCalibrationMapSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JoystickCalibrationMapSaveData>(intPtr3) : null;
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00065644 File Offset: 0x00063844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257112, XrefRangeEnd = 257120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00065690 File Offset: 0x00063890
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257139, RefRangeEnd = 257141, XrefRangeStart = 257120, XrefRangeEnd = 257139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x000656F8 File Offset: 0x000638F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257141, XrefRangeEnd = 257142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_SetVibration_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00065744 File Offset: 0x00063944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257142, XrefRangeEnd = 257143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_SetVibration_Public_Void_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x000657A0 File Offset: 0x000639A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257143, XrefRangeEnd = 257144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_SetVibration_Public_Void_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x000657FC File Offset: 0x000639FC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 257155, RefRangeEnd = 257161, XrefRangeStart = 257144, XrefRangeEnd = 257155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_SetVibration_Public_Void_Int32_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00065864 File Offset: 0x00063A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257173, RefRangeEnd = 257174, XrefRangeStart = 257161, XrefRangeEnd = 257173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetVibration(int motorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_GetVibration_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x000658B0 File Offset: 0x00063AB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 257190, RefRangeEnd = 257194, XrefRangeStart = 257174, XrefRangeEnd = 257190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopVibration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_StopVibration_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x000658E4 File Offset: 0x00063AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257194, XrefRangeEnd = 257203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ZTVaYQHtFassaSGDSzEcxNiGpigu(UpdateLoopType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Joystick.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00065930 File Offset: 0x00063B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257203, XrefRangeEnd = 257204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EXhlSeorjNzEIHugqDlyUldaKiw(UpdateControllerInfoEventArgs A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_EXhlSeorjNzEIHugqDlyUldaKiw_Internal_Void_UpdateControllerInfoEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00065974 File Offset: 0x00063B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257204, XrefRangeEnd = 257205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EXhlSeorjNzEIHugqDlyUldaKiw(BridgedController A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_EXhlSeorjNzEIHugqDlyUldaKiw_Internal_Void_BridgedController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x000659B8 File Offset: 0x00063BB8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 257220, RefRangeEnd = 257225, XrefRangeStart = 257205, XrefRangeEnd = 257220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EXhlSeorjNzEIHugqDlyUldaKiw(IInputManagerJoystickPublic A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_EXhlSeorjNzEIHugqDlyUldaKiw_Private_Void_IInputManagerJoystickPublic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x000659FC File Offset: 0x00063BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257225, XrefRangeEnd = 257227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GMFpQqtyJcjzYToWCrZsZQAhPYh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Joystick.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00065A38 File Offset: 0x00063C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257227, XrefRangeEnd = 257243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void zmCSqHjkWDCylUlUderSfqqEXvh(bool A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Joystick.NativeMethodInfoPtr_zmCSqHjkWDCylUlUderSfqqEXvh_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00065A84 File Offset: 0x00063C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257243, XrefRangeEnd = 257252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disconnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Joystick.NativeMethodInfoPtr_Disconnected_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00065AC0 File Offset: 0x00063CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257252, XrefRangeEnd = 257259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BicogWPgevrFZwICbwpkHBEuTLD()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_BicogWPgevrFZwICbwpkHBEuTLD_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00065AF4 File Offset: 0x00063CF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257264, RefRangeEnd = 257265, XrefRangeStart = 257259, XrefRangeEnd = 257264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ldAIQKxjQFodHEUZeGmcSizXhQa(int A_1, float A_2, float A_3, bool A_4, bool A_5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_5;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_ldAIQKxjQFodHEUZeGmcSizXhQa_Private_Void_Int32_Single_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00065B6C File Offset: 0x00063D6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257270, RefRangeEnd = 257272, XrefRangeStart = 257265, XrefRangeEnd = 257270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NdkCWjftCZbkhJqjBFAJjLorAcw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_NdkCWjftCZbkhJqjBFAJjLorAcw_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00065BA0 File Offset: 0x00063DA0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dbTjMYAbOjFqFnMKaRABcDWexVJ()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_dbTjMYAbOjFqFnMKaRABcDWexVJ_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00065BD4 File Offset: 0x00063DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257272, XrefRangeEnd = 257284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DpGZptroiKHjdiDdLdyrYqbNCOtb(Joystick A_0, Joystick A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Joystick.NativeMethodInfoPtr_DpGZptroiKHjdiDdLdyrYqbNCOtb_Internal_Static_Int32_Joystick_Joystick_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00007016 File Offset: 0x00005216
		public Joystick(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x00065C28 File Offset: 0x00063E28
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x0000701F File Offset: 0x0000521F
		public unsafe static int AEsdjlGVwWGNcpvbGJArGOOOfzU
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Joystick.NativeFieldInfoPtr_AEsdjlGVwWGNcpvbGJArGOOOfzU, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Joystick.NativeFieldInfoPtr_AEsdjlGVwWGNcpvbGJArGOOOfzU, (void*)(&value));
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x00065C44 File Offset: 0x00063E44
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x0000702D File Offset: 0x0000522D
		public unsafe static int fFTvCfHAfJJoUQSgzzebIMBoiVA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Joystick.NativeFieldInfoPtr_fFTvCfHAfJJoUQSgzzebIMBoiVA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Joystick.NativeFieldInfoPtr_fFTvCfHAfJJoUQSgzzebIMBoiVA, (void*)(&value));
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x00065C60 File Offset: 0x00063E60
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x0000703B File Offset: 0x0000523B
		public unsafe IInputManagerJoystickPublic SCcpHGmKkKHrhjNArxMwLrKriajd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_SCcpHGmKkKHrhjNArxMwLrKriajd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IInputManagerJoystickPublic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_SCcpHGmKkKHrhjNArxMwLrKriajd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x00065C90 File Offset: 0x00063E90
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x0000705A File Offset: 0x0000525A
		public unsafe Il2CppStructArray<JoystickType> HOWhuOzXWOaRjtfeNkKkNxLUBqS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_HOWhuOzXWOaRjtfeNkKkNxLUBqS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<JoystickType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_HOWhuOzXWOaRjtfeNkKkNxLUBqS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00065CC0 File Offset: 0x00063EC0
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x00007079 File Offset: 0x00005279
		public unsafe ReadOnlyCollection<JoystickType> eVRuJsSbYUIPtExWgOPEcmhifAz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_eVRuJsSbYUIPtExWgOPEcmhifAz);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<JoystickType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_eVRuJsSbYUIPtExWgOPEcmhifAz), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x00065CF0 File Offset: 0x00063EF0
		// (set) Token: 0x06000F50 RID: 3920 RVA: 0x00007098 File Offset: 0x00005298
		public unsafe bool GpmFnBAxUAdXwLkqaXOSEemYXrFI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_GpmFnBAxUAdXwLkqaXOSEemYXrFI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_GpmFnBAxUAdXwLkqaXOSEemYXrFI)) = value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x00065D18 File Offset: 0x00063F18
		// (set) Token: 0x06000F52 RID: 3922 RVA: 0x000070B3 File Offset: 0x000052B3
		public unsafe bool cUrKEUZCFlKCrmVTkHgbrJZEKZA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_cUrKEUZCFlKCrmVTkHgbrJZEKZA);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_cUrKEUZCFlKCrmVTkHgbrJZEKZA)) = value;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x00065D40 File Offset: 0x00063F40
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x000070CE File Offset: 0x000052CE
		public unsafe bool tLLssZQnFqTggAZWaCSOsEdqnLi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_tLLssZQnFqTggAZWaCSOsEdqnLi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_tLLssZQnFqTggAZWaCSOsEdqnLi)) = value;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x00065D68 File Offset: 0x00063F68
		// (set) Token: 0x06000F56 RID: 3926 RVA: 0x000070E9 File Offset: 0x000052E9
		public unsafe int VVhgLAeFmigjNmGXNcHtgCjEiapm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_VVhgLAeFmigjNmGXNcHtgCjEiapm);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_VVhgLAeFmigjNmGXNcHtgCjEiapm)) = value;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x00065D90 File Offset: 0x00063F90
		// (set) Token: 0x06000F58 RID: 3928 RVA: 0x00007104 File Offset: 0x00005304
		public unsafe Il2CppStructArray<float> cLLBlpsDXvfsYCchjcUtbZigMYS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_cLLBlpsDXvfsYCchjcUtbZigMYS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_cLLBlpsDXvfsYCchjcUtbZigMYS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x00065DC0 File Offset: 0x00063FC0
		// (set) Token: 0x06000F5A RID: 3930 RVA: 0x00007123 File Offset: 0x00005323
		public unsafe Il2CppReferenceArray<TimerAbs> gHIVPONHlarbrgDHNByMDTYKqarF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_gHIVPONHlarbrgDHNByMDTYKqarF);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TimerAbs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_gHIVPONHlarbrgDHNByMDTYKqarF), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x00065DF0 File Offset: 0x00063FF0
		// (set) Token: 0x06000F5C RID: 3932 RVA: 0x00007142 File Offset: 0x00005342
		public unsafe int zDyyBaxsowomSCnDgbuHSLXwmRp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_zDyyBaxsowomSCnDgbuHSLXwmRp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_zDyyBaxsowomSCnDgbuHSLXwmRp)) = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x00065E18 File Offset: 0x00064018
		// (set) Token: 0x06000F5E RID: 3934 RVA: 0x0000715D File Offset: 0x0000535D
		public unsafe Il2CppReferenceArray<Controller.Hat> lOVOKHbRvmrBECkaooLEUBWSVFk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_lOVOKHbRvmrBECkaooLEUBWSVFk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Controller.Hat>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_lOVOKHbRvmrBECkaooLEUBWSVFk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00065E48 File Offset: 0x00064048
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x0000717C File Offset: 0x0000537C
		public unsafe ReadOnlyCollection<Controller.Hat> LIVqABZIEhjfebFiaeDYMYMlDg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_LIVqABZIEhjfebFiaeDYMYMlDg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Controller.Hat>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Joystick.NativeFieldInfoPtr_LIVqABZIEhjfebFiaeDYMYMlDg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeFieldInfoPtr_AEsdjlGVwWGNcpvbGJArGOOOfzU;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeFieldInfoPtr_fFTvCfHAfJJoUQSgzzebIMBoiVA;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeFieldInfoPtr_SCcpHGmKkKHrhjNArxMwLrKriajd;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeFieldInfoPtr_HOWhuOzXWOaRjtfeNkKkNxLUBqS;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeFieldInfoPtr_eVRuJsSbYUIPtExWgOPEcmhifAz;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeFieldInfoPtr_GpmFnBAxUAdXwLkqaXOSEemYXrFI;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeFieldInfoPtr_cUrKEUZCFlKCrmVTkHgbrJZEKZA;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeFieldInfoPtr_tLLssZQnFqTggAZWaCSOsEdqnLi;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeFieldInfoPtr_VVhgLAeFmigjNmGXNcHtgCjEiapm;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeFieldInfoPtr_cLLBlpsDXvfsYCchjcUtbZigMYS;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeFieldInfoPtr_gHIVPONHlarbrgDHNByMDTYKqarF;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeFieldInfoPtr_zDyyBaxsowomSCnDgbuHSLXwmRp;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeFieldInfoPtr_lOVOKHbRvmrBECkaooLEUBWSVFk;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeFieldInfoPtr_LIVqABZIEhjfebFiaeDYMYMlDg;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_get_joystickTypes_Internal_get_IList_1_JoystickType_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_get_systemId_Public_get_Nullable_1_Int64_0;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_get_unityId_Public_get_Int32_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceInstanceGuid_Public_Virtual_get_Guid_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsVibration_Public_get_Boolean_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_get_vibrationLeftMotor_Public_get_Single_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_set_vibrationLeftMotor_Public_set_Void_Single_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_get_vibrationRightMotor_Public_get_Single_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_set_vibrationRightMotor_Public_set_Void_Single_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_get_vibrationMotorCount_Public_get_Int32_0;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_get_hatCount_Public_get_Int32_0;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_get_Hats_Public_get_IList_1_Hat_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr_get_inputManagerId_Internal_get_Int32_0;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr_get_hardwareJoystickMapIdentifier_Internal_get_HardwareControllerMapIdentifier_0;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BridgedController_0;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_InputSource_String_String_String_Guid_Int32_Int32_Il2CppStructArray_1_Boolean_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr_pzSAPtkDmWJcEYzUtRfKDMnXdSKj_Internal_Boolean_JoystickType_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibrationMapSaveData_Public_JoystickCalibrationMapSaveData_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_Int32_Single_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_Int32_Single_Single_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_Int32_Single_Boolean_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_Int32_Single_Single_Boolean_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_GetVibration_Public_Single_Int32_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Void_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_EXhlSeorjNzEIHugqDlyUldaKiw_Internal_Void_UpdateControllerInfoEventArgs_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_EXhlSeorjNzEIHugqDlyUldaKiw_Internal_Void_BridgedController_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_EXhlSeorjNzEIHugqDlyUldaKiw_Private_Void_IInputManagerJoystickPublic_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_zmCSqHjkWDCylUlUderSfqqEXvh_Internal_Virtual_Void_Boolean_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr_Disconnected_Protected_Virtual_Void_0;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr_BicogWPgevrFZwICbwpkHBEuTLD_Private_Void_0;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_ldAIQKxjQFodHEUZeGmcSizXhQa_Private_Void_Int32_Single_Single_Boolean_Boolean_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_NdkCWjftCZbkhJqjBFAJjLorAcw_Private_Void_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_dbTjMYAbOjFqFnMKaRABcDWexVJ_Private_Void_0;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr_DpGZptroiKHjdiDdLdyrYqbNCOtb_Internal_Static_Int32_Joystick_Joystick_0;
	}
}
