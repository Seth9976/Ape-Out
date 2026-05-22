using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Data.Mapping;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x0200013B RID: 315
	public sealed class AxisCalibrationData : ValueType
	{
		// Token: 0x06002291 RID: 8849 RVA: 0x000B0FA8 File Offset: 0x000AF1A8
		// Note: this type is marked as 'beforefieldinit'.
		static AxisCalibrationData()
		{
			Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "AxisCalibrationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr);
			AxisCalibrationData.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, "enabled");
			AxisCalibrationData.NativeFieldInfoPtr_deadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, "deadZone");
			AxisCalibrationData.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, "zero");
			AxisCalibrationData.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, "min");
			AxisCalibrationData.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, "max");
			AxisCalibrationData.NativeFieldInfoPtr_invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, "invert");
			AxisCalibrationData.NativeFieldInfoPtr_sensitivityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, "sensitivityType");
			AxisCalibrationData.NativeFieldInfoPtr_sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, "sensitivity");
			AxisCalibrationData.NativeFieldInfoPtr_sensitivityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, "sensitivityCurve");
			AxisCalibrationData.NativeFieldInfoPtr_applyRangeCalibration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, "applyRangeCalibration");
			AxisCalibrationData.NativeFieldInfoPtr_calibrations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, "calibrations");
			AxisCalibrationData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_Single_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, 100670733);
			AxisCalibrationData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_Single_Single_Boolean_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, 100670734);
			AxisCalibrationData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_Single_Single_Boolean_Boolean_AxisSensitivityType_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, 100670735);
			AxisCalibrationData.NativeMethodInfoPtr_get_Default_Public_Static_get_AxisCalibrationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, 100670736);
			AxisCalibrationData.NativeMethodInfoPtr_get_Raw_Internal_Static_get_AxisCalibrationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, 100670737);
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x000B1118 File Offset: 0x000AF318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287991, XrefRangeEnd = 288000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisCalibrationData(bool enabled, float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deadZone;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zero;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyRangeCalibration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_Single_Single_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x000B11B8 File Offset: 0x000AF3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288000, XrefRangeEnd = 288009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisCalibrationData(bool enabled, float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration, float sensitivity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deadZone;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zero;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyRangeCalibration;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_Single_Single_Boolean_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x000B1268 File Offset: 0x000AF468
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 288009, RefRangeEnd = 288014, XrefRangeStart = 288009, XrefRangeEnd = 288009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisCalibrationData(bool enabled, float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deadZone;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zero;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyRangeCalibration;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivityType;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivity;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sensitivityCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_Single_Single_Boolean_Boolean_AxisSensitivityType_Single_AnimationCurve_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06002295 RID: 8853 RVA: 0x000B133C File Offset: 0x000AF53C
		public unsafe static AxisCalibrationData Default
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 288024, RefRangeEnd = 288064, XrefRangeStart = 288014, XrefRangeEnd = 288024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationData.NativeMethodInfoPtr_get_Default_Public_Static_get_AxisCalibrationData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AxisCalibrationData(intPtr);
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x000B1368 File Offset: 0x000AF568
		public unsafe static AxisCalibrationData Raw
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 288074, RefRangeEnd = 288076, XrefRangeStart = 288064, XrefRangeEnd = 288074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationData.NativeMethodInfoPtr_get_Raw_Internal_Static_get_AxisCalibrationData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AxisCalibrationData(intPtr);
			}
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x0000DE8D File Offset: 0x0000C08D
		public AxisCalibrationData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x0000DE96 File Offset: 0x0000C096
		public AxisCalibrationData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr))
		{
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06002299 RID: 8857 RVA: 0x000B1394 File Offset: 0x000AF594
		// (set) Token: 0x0600229A RID: 8858 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		public unsafe bool enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_enabled)) = value;
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x0600229B RID: 8859 RVA: 0x000B13BC File Offset: 0x000AF5BC
		// (set) Token: 0x0600229C RID: 8860 RVA: 0x0000DEC3 File Offset: 0x0000C0C3
		public unsafe float deadZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_deadZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_deadZone)) = value;
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600229D RID: 8861 RVA: 0x000B13E4 File Offset: 0x000AF5E4
		// (set) Token: 0x0600229E RID: 8862 RVA: 0x0000DEDE File Offset: 0x0000C0DE
		public unsafe float zero
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_zero);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_zero)) = value;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x000B140C File Offset: 0x000AF60C
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x0000DEF9 File Offset: 0x0000C0F9
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x000B1434 File Offset: 0x000AF634
		// (set) Token: 0x060022A2 RID: 8866 RVA: 0x0000DF14 File Offset: 0x0000C114
		public unsafe float max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x000B145C File Offset: 0x000AF65C
		// (set) Token: 0x060022A4 RID: 8868 RVA: 0x0000DF2F File Offset: 0x0000C12F
		public unsafe bool invert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_invert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_invert)) = value;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x000B1484 File Offset: 0x000AF684
		// (set) Token: 0x060022A6 RID: 8870 RVA: 0x0000DF4A File Offset: 0x0000C14A
		public unsafe AxisSensitivityType sensitivityType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_sensitivityType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_sensitivityType)) = value;
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x000B14AC File Offset: 0x000AF6AC
		// (set) Token: 0x060022A8 RID: 8872 RVA: 0x0000DF65 File Offset: 0x0000C165
		public unsafe float sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_sensitivity)) = value;
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x000B14D4 File Offset: 0x000AF6D4
		// (set) Token: 0x060022AA RID: 8874 RVA: 0x0000DF80 File Offset: 0x0000C180
		public unsafe AnimationCurve sensitivityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_sensitivityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_sensitivityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x000B1504 File Offset: 0x000AF704
		// (set) Token: 0x060022AC RID: 8876 RVA: 0x0000DF9F File Offset: 0x0000C19F
		public unsafe bool applyRangeCalibration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_applyRangeCalibration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_applyRangeCalibration)) = value;
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x000B152C File Offset: 0x000AF72C
		// (set) Token: 0x060022AE RID: 8878 RVA: 0x0000DFBA File Offset: 0x0000C1BA
		public unsafe Dictionary<int, AxisCalibrationInfo> calibrations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_calibrations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, AxisCalibrationInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationData.NativeFieldInfoPtr_calibrations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C86 RID: 7302
		private static readonly IntPtr NativeFieldInfoPtr_enabled;

		// Token: 0x04001C87 RID: 7303
		private static readonly IntPtr NativeFieldInfoPtr_deadZone;

		// Token: 0x04001C88 RID: 7304
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001C89 RID: 7305
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04001C8A RID: 7306
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04001C8B RID: 7307
		private static readonly IntPtr NativeFieldInfoPtr_invert;

		// Token: 0x04001C8C RID: 7308
		private static readonly IntPtr NativeFieldInfoPtr_sensitivityType;

		// Token: 0x04001C8D RID: 7309
		private static readonly IntPtr NativeFieldInfoPtr_sensitivity;

		// Token: 0x04001C8E RID: 7310
		private static readonly IntPtr NativeFieldInfoPtr_sensitivityCurve;

		// Token: 0x04001C8F RID: 7311
		private static readonly IntPtr NativeFieldInfoPtr_applyRangeCalibration;

		// Token: 0x04001C90 RID: 7312
		private static readonly IntPtr NativeFieldInfoPtr_calibrations;

		// Token: 0x04001C91 RID: 7313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_Single_Single_Boolean_Boolean_0;

		// Token: 0x04001C92 RID: 7314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_Single_Single_Boolean_Boolean_Single_0;

		// Token: 0x04001C93 RID: 7315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_Single_Single_Boolean_Boolean_AxisSensitivityType_Single_AnimationCurve_0;

		// Token: 0x04001C94 RID: 7316
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_AxisCalibrationData_0;

		// Token: 0x04001C95 RID: 7317
		private static readonly IntPtr NativeMethodInfoPtr_get_Raw_Internal_Static_get_AxisCalibrationData_0;
	}
}
