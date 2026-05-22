using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Data.Mapping;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x0200013A RID: 314
	[Serializable]
	public sealed class AxisCalibration : global::Il2CppSystem.Object
	{
		// Token: 0x06002250 RID: 8784 RVA: 0x000AFE88 File Offset: 0x000AE088
		// Note: this type is marked as 'beforefieldinit'.
		static AxisCalibration()
		{
			Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "AxisCalibration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr);
			AxisCalibration.NativeFieldInfoPtr__calibrationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, "_calibrationMode");
			AxisCalibration.NativeFieldInfoPtr__hardwareCalibrations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, "_hardwareCalibrations");
			AxisCalibration.NativeFieldInfoPtr__enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, "_enabled");
			AxisCalibration.NativeFieldInfoPtr__deadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, "_deadZone");
			AxisCalibration.NativeFieldInfoPtr__calibratedZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, "_calibratedZero");
			AxisCalibration.NativeFieldInfoPtr__calibratedMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, "_calibratedMin");
			AxisCalibration.NativeFieldInfoPtr__calibratedMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, "_calibratedMax");
			AxisCalibration.NativeFieldInfoPtr__invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, "_invert");
			AxisCalibration.NativeFieldInfoPtr__sensitivityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, "_sensitivityType");
			AxisCalibration.NativeFieldInfoPtr__sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, "_sensitivity");
			AxisCalibration.NativeFieldInfoPtr__sensitivityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, "_sensitivityCurve");
			AxisCalibration.NativeFieldInfoPtr__applyRangeCalibration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, "_applyRangeCalibration");
			AxisCalibration.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670694);
			AxisCalibration.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670695);
			AxisCalibration.NativeMethodInfoPtr_get_deadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670696);
			AxisCalibration.NativeMethodInfoPtr_set_deadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670697);
			AxisCalibration.NativeMethodInfoPtr_get_calibratedZero_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670698);
			AxisCalibration.NativeMethodInfoPtr_set_calibratedZero_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670699);
			AxisCalibration.NativeMethodInfoPtr_get_calibratedMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670700);
			AxisCalibration.NativeMethodInfoPtr_set_calibratedMin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670701);
			AxisCalibration.NativeMethodInfoPtr_get_calibratedMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670702);
			AxisCalibration.NativeMethodInfoPtr_set_calibratedMax_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670703);
			AxisCalibration.NativeMethodInfoPtr_get_invert_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670704);
			AxisCalibration.NativeMethodInfoPtr_set_invert_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670705);
			AxisCalibration.NativeMethodInfoPtr_get_sensitivityType_Public_get_AxisSensitivityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670706);
			AxisCalibration.NativeMethodInfoPtr_set_sensitivityType_Public_set_Void_AxisSensitivityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670707);
			AxisCalibration.NativeMethodInfoPtr_get_sensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670708);
			AxisCalibration.NativeMethodInfoPtr_set_sensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670709);
			AxisCalibration.NativeMethodInfoPtr_get_sensitivityCurve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670710);
			AxisCalibration.NativeMethodInfoPtr_set_sensitivityCurve_Public_set_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670711);
			AxisCalibration.NativeMethodInfoPtr_get_applyRangeCalibration_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670712);
			AxisCalibration.NativeMethodInfoPtr_set_applyRangeCalibration_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670713);
			AxisCalibration.NativeMethodInfoPtr_get_calibrationMode_Internal_get_AlternateAxisCalibrationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670714);
			AxisCalibration.NativeMethodInfoPtr_set_calibrationMode_Internal_set_Void_AlternateAxisCalibrationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670715);
			AxisCalibration.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670716);
			AxisCalibration.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Dictionary_2_Int32_AxisCalibrationInfo_Single_Single_Single_Single_Boolean_Boolean_AxisSensitivityType_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670717);
			AxisCalibration.NativeMethodInfoPtr__ctor_Internal_Void_AxisCalibrationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670718);
			AxisCalibration.NativeMethodInfoPtr_CopyFrom_Internal_Void_AxisCalibration_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670719);
			AxisCalibration.NativeMethodInfoPtr_GetCalibratedValue_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670720);
			AxisCalibration.NativeMethodInfoPtr_GetCalibratedValue_Internal_Single_Single_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670721);
			AxisCalibration.NativeMethodInfoPtr_GetCalibratedValue_Public_Single_Single_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670722);
			AxisCalibration.NativeMethodInfoPtr_GetCalibratedValue_Internal_Single_Single_AxisRange_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670723);
			AxisCalibration.NativeMethodInfoPtr_GetData_Public_AxisCalibrationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670724);
			AxisCalibration.NativeMethodInfoPtr_SetData_Public_Void_AxisCalibrationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670725);
			AxisCalibration.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670726);
			AxisCalibration.NativeMethodInfoPtr_ExportData_Internal_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670727);
			AxisCalibration.NativeMethodInfoPtr_Import_Internal_Void_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670728);
			AxisCalibration.NativeMethodInfoPtr_InitHardwareCalibrations_Private_Void_Dictionary_2_Int32_AxisCalibrationInfo_AxisCalibrationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670729);
			AxisCalibration.NativeMethodInfoPtr_CreateDefaultHardwareCalibration_Private_Void_AxisCalibrationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670730);
			AxisCalibration.NativeMethodInfoPtr_GetHardwareDefault_Private_AxisCalibrationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670731);
			AxisCalibration.NativeMethodInfoPtr_CreateRelative_Internal_Static_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr, 100670732);
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x000B02B4 File Offset: 0x000AE4B4
		// (set) Token: 0x06002252 RID: 8786 RVA: 0x000B02F0 File Offset: 0x000AE4F0
		public unsafe bool enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002253 RID: 8787 RVA: 0x000B0330 File Offset: 0x000AE530
		// (set) Token: 0x06002254 RID: 8788 RVA: 0x000B036C File Offset: 0x000AE56C
		public unsafe float deadZone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_get_deadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287714, XrefRangeEnd = 287715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_set_deadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002255 RID: 8789 RVA: 0x000B03AC File Offset: 0x000AE5AC
		// (set) Token: 0x06002256 RID: 8790 RVA: 0x000B03E8 File Offset: 0x000AE5E8
		public unsafe float calibratedZero
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_get_calibratedZero_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_set_calibratedZero_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002257 RID: 8791 RVA: 0x000B0428 File Offset: 0x000AE628
		// (set) Token: 0x06002258 RID: 8792 RVA: 0x000B0464 File Offset: 0x000AE664
		public unsafe float calibratedMin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_get_calibratedMin_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_set_calibratedMin_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x000B04A4 File Offset: 0x000AE6A4
		// (set) Token: 0x0600225A RID: 8794 RVA: 0x000B04E0 File Offset: 0x000AE6E0
		public unsafe float calibratedMax
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_get_calibratedMax_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_set_calibratedMax_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x000B0520 File Offset: 0x000AE720
		// (set) Token: 0x0600225C RID: 8796 RVA: 0x000B055C File Offset: 0x000AE75C
		public unsafe bool invert
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_get_invert_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_set_invert_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x0600225D RID: 8797 RVA: 0x000B059C File Offset: 0x000AE79C
		// (set) Token: 0x0600225E RID: 8798 RVA: 0x000B05D8 File Offset: 0x000AE7D8
		public unsafe AxisSensitivityType sensitivityType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_get_sensitivityType_Public_get_AxisSensitivityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_set_sensitivityType_Public_set_Void_AxisSensitivityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x0600225F RID: 8799 RVA: 0x000B0618 File Offset: 0x000AE818
		// (set) Token: 0x06002260 RID: 8800 RVA: 0x000B0654 File Offset: 0x000AE854
		public unsafe float sensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_get_sensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_set_sensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06002261 RID: 8801 RVA: 0x000B0694 File Offset: 0x000AE894
		// (set) Token: 0x06002262 RID: 8802 RVA: 0x000B06D4 File Offset: 0x000AE8D4
		public unsafe AnimationCurve sensitivityCurve
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_get_sensitivityCurve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_set_sensitivityCurve_Public_set_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06002263 RID: 8803 RVA: 0x000B0718 File Offset: 0x000AE918
		// (set) Token: 0x06002264 RID: 8804 RVA: 0x000B0754 File Offset: 0x000AE954
		public unsafe bool applyRangeCalibration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_get_applyRangeCalibration_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_set_applyRangeCalibration_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06002265 RID: 8805 RVA: 0x000B0794 File Offset: 0x000AE994
		// (set) Token: 0x06002266 RID: 8806 RVA: 0x000B07D0 File Offset: 0x000AE9D0
		public unsafe AlternateAxisCalibrationType calibrationMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_get_calibrationMode_Internal_get_AlternateAxisCalibrationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287715, XrefRangeEnd = 287716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_set_calibrationMode_Internal_set_Void_AlternateAxisCalibrationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x000B0810 File Offset: 0x000AEA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287716, XrefRangeEnd = 287729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisCalibration()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x000B084C File Offset: 0x000AEA4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287742, RefRangeEnd = 287743, XrefRangeStart = 287729, XrefRangeEnd = 287742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisCalibration(bool enabled, Dictionary<int, AxisCalibrationInfo> hardwareCalibrations, float deadZone, float calibratedZero, float calibratedMin, float calibratedMax, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hardwareCalibrations);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deadZone;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calibratedZero;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calibratedMin;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calibratedMax;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyRangeCalibration;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivityType;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivity;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sensitivityCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Dictionary_2_Int32_AxisCalibrationInfo_Single_Single_Single_Single_Boolean_Boolean_AxisSensitivityType_Single_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x000B092C File Offset: 0x000AEB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287743, XrefRangeEnd = 287755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisCalibration(AxisCalibrationData hardwareData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisCalibration>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hardwareData));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr__ctor_Internal_Void_AxisCalibrationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x000B097C File Offset: 0x000AEB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287755, XrefRangeEnd = 287767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(AxisCalibration data, bool copyHardwareData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyHardwareData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_CopyFrom_Internal_Void_AxisCalibration_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x000B09CC File Offset: 0x000AEBCC
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 287768, RefRangeEnd = 287800, XrefRangeStart = 287767, XrefRangeEnd = 287768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCalibratedValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_GetCalibratedValue_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x000B0A18 File Offset: 0x000AEC18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287802, RefRangeEnd = 287804, XrefRangeStart = 287800, XrefRangeEnd = 287802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCalibratedValue(float value, float customDeadzone, bool applySensitivity, bool applyInversion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref customDeadzone;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applySensitivity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyInversion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_GetCalibratedValue_Internal_Single_Single_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x000B0A8C File Offset: 0x000AEC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287804, XrefRangeEnd = 287805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCalibratedValue(float value, AxisRange axisRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_GetCalibratedValue_Public_Single_Single_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x000B0AE4 File Offset: 0x000AECE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287808, RefRangeEnd = 287811, XrefRangeStart = 287805, XrefRangeEnd = 287808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCalibratedValue(float value, AxisRange axisRange, float customDeadzone, bool applySensitivity, bool applyInversion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisRange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref customDeadzone;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applySensitivity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyInversion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_GetCalibratedValue_Internal_Single_Single_AxisRange_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x000B0B68 File Offset: 0x000AED68
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 287818, RefRangeEnd = 287824, XrefRangeStart = 287811, XrefRangeEnd = 287818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisCalibrationData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_GetData_Public_AxisCalibrationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AxisCalibrationData(intPtr);
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x000B0BA0 File Offset: 0x000AEDA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 287825, RefRangeEnd = 287829, XrefRangeStart = 287824, XrefRangeEnd = 287825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(AxisCalibrationData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_SetData_Public_Void_AxisCalibrationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x000B0BE8 File Offset: 0x000AEDE8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 287835, RefRangeEnd = 287847, XrefRangeStart = 287829, XrefRangeEnd = 287835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x000B0C1C File Offset: 0x000AEE1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287888, RefRangeEnd = 287889, XrefRangeStart = 287847, XrefRangeEnd = 287888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedObject ExportData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_ExportData_Internal_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedObject>(intPtr3) : null;
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x000B0C5C File Offset: 0x000AEE5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287925, RefRangeEnd = 287926, XrefRangeStart = 287889, XrefRangeEnd = 287925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Import(SerializedObject serializedObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_Import_Internal_Void_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x000B0CA0 File Offset: 0x000AEEA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287948, RefRangeEnd = 287951, XrefRangeStart = 287926, XrefRangeEnd = 287948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitHardwareCalibrations(Dictionary<int, AxisCalibrationInfo> hardwareCalibrations, AxisCalibrationData defaultData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hardwareCalibrations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(defaultData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_InitHardwareCalibrations_Private_Void_Dictionary_2_Int32_AxisCalibrationInfo_AxisCalibrationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x000B0CFC File Offset: 0x000AEEFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287956, RefRangeEnd = 287959, XrefRangeStart = 287951, XrefRangeEnd = 287956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateDefaultHardwareCalibration(AxisCalibrationData defaultData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(defaultData));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_CreateDefaultHardwareCalibration_Private_Void_AxisCalibrationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x000B0D44 File Offset: 0x000AEF44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287965, RefRangeEnd = 287966, XrefRangeStart = 287959, XrefRangeEnd = 287965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisCalibrationInfo GetHardwareDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_GetHardwareDefault_Private_AxisCalibrationInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisCalibrationInfo>(intPtr3) : null;
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x000B0D84 File Offset: 0x000AEF84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287990, RefRangeEnd = 287991, XrefRangeStart = 287966, XrefRangeEnd = 287990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AxisCalibration CreateRelative()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibration.NativeMethodInfoPtr_CreateRelative_Internal_Static_AxisCalibration_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisCalibration>(intPtr3) : null;
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x0000DD38 File Offset: 0x0000BF38
		public AxisCalibration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x000B0DB8 File Offset: 0x000AEFB8
		// (set) Token: 0x0600227A RID: 8826 RVA: 0x0000DD41 File Offset: 0x0000BF41
		public unsafe AlternateAxisCalibrationType _calibrationMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__calibrationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__calibrationMode)) = value;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x000B0DE0 File Offset: 0x000AEFE0
		// (set) Token: 0x0600227C RID: 8828 RVA: 0x0000DD5C File Offset: 0x0000BF5C
		public unsafe Dictionary<int, AxisCalibrationInfo> _hardwareCalibrations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__hardwareCalibrations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, AxisCalibrationInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__hardwareCalibrations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x000B0E10 File Offset: 0x000AF010
		// (set) Token: 0x0600227E RID: 8830 RVA: 0x0000DD7B File Offset: 0x0000BF7B
		public unsafe bool _enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__enabled)) = value;
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x0600227F RID: 8831 RVA: 0x000B0E38 File Offset: 0x000AF038
		// (set) Token: 0x06002280 RID: 8832 RVA: 0x0000DD96 File Offset: 0x0000BF96
		public unsafe float _deadZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__deadZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__deadZone)) = value;
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06002281 RID: 8833 RVA: 0x000B0E60 File Offset: 0x000AF060
		// (set) Token: 0x06002282 RID: 8834 RVA: 0x0000DDB1 File Offset: 0x0000BFB1
		public unsafe float _calibratedZero
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__calibratedZero);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__calibratedZero)) = value;
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x000B0E88 File Offset: 0x000AF088
		// (set) Token: 0x06002284 RID: 8836 RVA: 0x0000DDCC File Offset: 0x0000BFCC
		public unsafe float _calibratedMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__calibratedMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__calibratedMin)) = value;
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06002285 RID: 8837 RVA: 0x000B0EB0 File Offset: 0x000AF0B0
		// (set) Token: 0x06002286 RID: 8838 RVA: 0x0000DDE7 File Offset: 0x0000BFE7
		public unsafe float _calibratedMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__calibratedMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__calibratedMax)) = value;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x000B0ED8 File Offset: 0x000AF0D8
		// (set) Token: 0x06002288 RID: 8840 RVA: 0x0000DE02 File Offset: 0x0000C002
		public unsafe bool _invert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__invert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__invert)) = value;
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x000B0F00 File Offset: 0x000AF100
		// (set) Token: 0x0600228A RID: 8842 RVA: 0x0000DE1D File Offset: 0x0000C01D
		public unsafe AxisSensitivityType _sensitivityType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__sensitivityType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__sensitivityType)) = value;
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x0600228B RID: 8843 RVA: 0x000B0F28 File Offset: 0x000AF128
		// (set) Token: 0x0600228C RID: 8844 RVA: 0x0000DE38 File Offset: 0x0000C038
		public unsafe float _sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__sensitivity)) = value;
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x000B0F50 File Offset: 0x000AF150
		// (set) Token: 0x0600228E RID: 8846 RVA: 0x0000DE53 File Offset: 0x0000C053
		public unsafe AnimationCurve _sensitivityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__sensitivityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__sensitivityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x0600228F RID: 8847 RVA: 0x000B0F80 File Offset: 0x000AF180
		// (set) Token: 0x06002290 RID: 8848 RVA: 0x0000DE72 File Offset: 0x0000C072
		public unsafe bool _applyRangeCalibration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__applyRangeCalibration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibration.NativeFieldInfoPtr__applyRangeCalibration)) = value;
			}
		}

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeFieldInfoPtr__calibrationMode;

		// Token: 0x04001C54 RID: 7252
		private static readonly IntPtr NativeFieldInfoPtr__hardwareCalibrations;

		// Token: 0x04001C55 RID: 7253
		private static readonly IntPtr NativeFieldInfoPtr__enabled;

		// Token: 0x04001C56 RID: 7254
		private static readonly IntPtr NativeFieldInfoPtr__deadZone;

		// Token: 0x04001C57 RID: 7255
		private static readonly IntPtr NativeFieldInfoPtr__calibratedZero;

		// Token: 0x04001C58 RID: 7256
		private static readonly IntPtr NativeFieldInfoPtr__calibratedMin;

		// Token: 0x04001C59 RID: 7257
		private static readonly IntPtr NativeFieldInfoPtr__calibratedMax;

		// Token: 0x04001C5A RID: 7258
		private static readonly IntPtr NativeFieldInfoPtr__invert;

		// Token: 0x04001C5B RID: 7259
		private static readonly IntPtr NativeFieldInfoPtr__sensitivityType;

		// Token: 0x04001C5C RID: 7260
		private static readonly IntPtr NativeFieldInfoPtr__sensitivity;

		// Token: 0x04001C5D RID: 7261
		private static readonly IntPtr NativeFieldInfoPtr__sensitivityCurve;

		// Token: 0x04001C5E RID: 7262
		private static readonly IntPtr NativeFieldInfoPtr__applyRangeCalibration;

		// Token: 0x04001C5F RID: 7263
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x04001C60 RID: 7264
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x04001C61 RID: 7265
		private static readonly IntPtr NativeMethodInfoPtr_get_deadZone_Public_get_Single_0;

		// Token: 0x04001C62 RID: 7266
		private static readonly IntPtr NativeMethodInfoPtr_set_deadZone_Public_set_Void_Single_0;

		// Token: 0x04001C63 RID: 7267
		private static readonly IntPtr NativeMethodInfoPtr_get_calibratedZero_Public_get_Single_0;

		// Token: 0x04001C64 RID: 7268
		private static readonly IntPtr NativeMethodInfoPtr_set_calibratedZero_Public_set_Void_Single_0;

		// Token: 0x04001C65 RID: 7269
		private static readonly IntPtr NativeMethodInfoPtr_get_calibratedMin_Public_get_Single_0;

		// Token: 0x04001C66 RID: 7270
		private static readonly IntPtr NativeMethodInfoPtr_set_calibratedMin_Public_set_Void_Single_0;

		// Token: 0x04001C67 RID: 7271
		private static readonly IntPtr NativeMethodInfoPtr_get_calibratedMax_Public_get_Single_0;

		// Token: 0x04001C68 RID: 7272
		private static readonly IntPtr NativeMethodInfoPtr_set_calibratedMax_Public_set_Void_Single_0;

		// Token: 0x04001C69 RID: 7273
		private static readonly IntPtr NativeMethodInfoPtr_get_invert_Public_get_Boolean_0;

		// Token: 0x04001C6A RID: 7274
		private static readonly IntPtr NativeMethodInfoPtr_set_invert_Public_set_Void_Boolean_0;

		// Token: 0x04001C6B RID: 7275
		private static readonly IntPtr NativeMethodInfoPtr_get_sensitivityType_Public_get_AxisSensitivityType_0;

		// Token: 0x04001C6C RID: 7276
		private static readonly IntPtr NativeMethodInfoPtr_set_sensitivityType_Public_set_Void_AxisSensitivityType_0;

		// Token: 0x04001C6D RID: 7277
		private static readonly IntPtr NativeMethodInfoPtr_get_sensitivity_Public_get_Single_0;

		// Token: 0x04001C6E RID: 7278
		private static readonly IntPtr NativeMethodInfoPtr_set_sensitivity_Public_set_Void_Single_0;

		// Token: 0x04001C6F RID: 7279
		private static readonly IntPtr NativeMethodInfoPtr_get_sensitivityCurve_Public_get_AnimationCurve_0;

		// Token: 0x04001C70 RID: 7280
		private static readonly IntPtr NativeMethodInfoPtr_set_sensitivityCurve_Public_set_Void_AnimationCurve_0;

		// Token: 0x04001C71 RID: 7281
		private static readonly IntPtr NativeMethodInfoPtr_get_applyRangeCalibration_Public_get_Boolean_0;

		// Token: 0x04001C72 RID: 7282
		private static readonly IntPtr NativeMethodInfoPtr_set_applyRangeCalibration_Public_set_Void_Boolean_0;

		// Token: 0x04001C73 RID: 7283
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrationMode_Internal_get_AlternateAxisCalibrationType_0;

		// Token: 0x04001C74 RID: 7284
		private static readonly IntPtr NativeMethodInfoPtr_set_calibrationMode_Internal_set_Void_AlternateAxisCalibrationType_0;

		// Token: 0x04001C75 RID: 7285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001C76 RID: 7286
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Dictionary_2_Int32_AxisCalibrationInfo_Single_Single_Single_Single_Boolean_Boolean_AxisSensitivityType_Single_AnimationCurve_0;

		// Token: 0x04001C77 RID: 7287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_AxisCalibrationData_0;

		// Token: 0x04001C78 RID: 7288
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Internal_Void_AxisCalibration_Boolean_0;

		// Token: 0x04001C79 RID: 7289
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibratedValue_Public_Single_Single_0;

		// Token: 0x04001C7A RID: 7290
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibratedValue_Internal_Single_Single_Single_Boolean_Boolean_0;

		// Token: 0x04001C7B RID: 7291
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibratedValue_Public_Single_Single_AxisRange_0;

		// Token: 0x04001C7C RID: 7292
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibratedValue_Internal_Single_Single_AxisRange_Single_Boolean_Boolean_0;

		// Token: 0x04001C7D RID: 7293
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_AxisCalibrationData_0;

		// Token: 0x04001C7E RID: 7294
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_AxisCalibrationData_0;

		// Token: 0x04001C7F RID: 7295
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04001C80 RID: 7296
		private static readonly IntPtr NativeMethodInfoPtr_ExportData_Internal_SerializedObject_0;

		// Token: 0x04001C81 RID: 7297
		private static readonly IntPtr NativeMethodInfoPtr_Import_Internal_Void_SerializedObject_0;

		// Token: 0x04001C82 RID: 7298
		private static readonly IntPtr NativeMethodInfoPtr_InitHardwareCalibrations_Private_Void_Dictionary_2_Int32_AxisCalibrationInfo_AxisCalibrationData_0;

		// Token: 0x04001C83 RID: 7299
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultHardwareCalibration_Private_Void_AxisCalibrationData_0;

		// Token: 0x04001C84 RID: 7300
		private static readonly IntPtr NativeMethodInfoPtr_GetHardwareDefault_Private_AxisCalibrationInfo_0;

		// Token: 0x04001C85 RID: 7301
		private static readonly IntPtr NativeMethodInfoPtr_CreateRelative_Internal_Static_AxisCalibration_0;
	}
}
