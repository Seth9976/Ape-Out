using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x0200013C RID: 316
	[Serializable]
	public sealed class Axis2DCalibration : global::Il2CppSystem.Object
	{
		// Token: 0x060022AF RID: 8879 RVA: 0x000B155C File Offset: 0x000AF75C
		// Note: this type is marked as 'beforefieldinit'.
		static Axis2DCalibration()
		{
			Il2CppClassPointerStore<Axis2DCalibration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "Axis2DCalibration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Axis2DCalibration>.NativeClassPtr);
			Axis2DCalibration.NativeFieldInfoPtr__deadZoneType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Axis2DCalibration>.NativeClassPtr, "_deadZoneType");
			Axis2DCalibration.NativeFieldInfoPtr__sensitivityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Axis2DCalibration>.NativeClassPtr, "_sensitivityType");
			Axis2DCalibration.NativeMethodInfoPtr_get_deadZoneType_Public_get_DeadZone2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis2DCalibration>.NativeClassPtr, 100670738);
			Axis2DCalibration.NativeMethodInfoPtr_set_deadZoneType_Public_set_Void_DeadZone2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis2DCalibration>.NativeClassPtr, 100670739);
			Axis2DCalibration.NativeMethodInfoPtr_get_sensitivityType_Public_get_AxisSensitivity2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis2DCalibration>.NativeClassPtr, 100670740);
			Axis2DCalibration.NativeMethodInfoPtr_set_sensitivityType_Public_set_Void_AxisSensitivity2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis2DCalibration>.NativeClassPtr, 100670741);
			Axis2DCalibration.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis2DCalibration>.NativeClassPtr, 100670742);
			Axis2DCalibration.NativeMethodInfoPtr_GetCalibrated2DValue_Internal_Vector2_Single_Single_AxisCalibration_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis2DCalibration>.NativeClassPtr, 100670743);
			Axis2DCalibration.NativeMethodInfoPtr_GetCalibrated2DValue_Internal_Static_Vector2_Single_Single_AxisCalibration_AxisCalibration_DeadZone2DType_AxisSensitivity2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis2DCalibration>.NativeClassPtr, 100670744);
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x000B1640 File Offset: 0x000AF840
		// (set) Token: 0x060022B1 RID: 8881 RVA: 0x000B167C File Offset: 0x000AF87C
		public unsafe DeadZone2DType deadZoneType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis2DCalibration.NativeMethodInfoPtr_get_deadZoneType_Public_get_DeadZone2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis2DCalibration.NativeMethodInfoPtr_set_deadZoneType_Public_set_Void_DeadZone2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x000B16BC File Offset: 0x000AF8BC
		// (set) Token: 0x060022B3 RID: 8883 RVA: 0x000B16F8 File Offset: 0x000AF8F8
		public unsafe AxisSensitivity2DType sensitivityType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis2DCalibration.NativeMethodInfoPtr_get_sensitivityType_Public_get_AxisSensitivity2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis2DCalibration.NativeMethodInfoPtr_set_sensitivityType_Public_set_Void_AxisSensitivity2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x000B1738 File Offset: 0x000AF938
		[CallerCount(0)]
		public unsafe Axis2DCalibration()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Axis2DCalibration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis2DCalibration.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x000B1774 File Offset: 0x000AF974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288076, XrefRangeEnd = 288077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valueRawX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueRawY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xAxis);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(yAxis);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis2DCalibration.NativeMethodInfoPtr_GetCalibrated2DValue_Internal_Vector2_Single_Single_AxisCalibration_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x000B17F0 File Offset: 0x000AF9F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 288107, RefRangeEnd = 288113, XrefRangeStart = 288077, XrefRangeEnd = 288107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valueRawX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueRawY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xAxis);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(yAxis);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deadZoneType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivityType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis2DCalibration.NativeMethodInfoPtr_GetCalibrated2DValue_Internal_Static_Vector2_Single_Single_AxisCalibration_AxisCalibration_DeadZone2DType_AxisSensitivity2DType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x0000DFD9 File Offset: 0x0000C1D9
		public Axis2DCalibration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x000B187C File Offset: 0x000AFA7C
		// (set) Token: 0x060022B9 RID: 8889 RVA: 0x0000DFE2 File Offset: 0x0000C1E2
		public unsafe DeadZone2DType _deadZoneType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis2DCalibration.NativeFieldInfoPtr__deadZoneType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis2DCalibration.NativeFieldInfoPtr__deadZoneType)) = value;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x000B18A4 File Offset: 0x000AFAA4
		// (set) Token: 0x060022BB RID: 8891 RVA: 0x0000DFFD File Offset: 0x0000C1FD
		public unsafe AxisSensitivity2DType _sensitivityType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis2DCalibration.NativeFieldInfoPtr__sensitivityType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis2DCalibration.NativeFieldInfoPtr__sensitivityType)) = value;
			}
		}

		// Token: 0x04001C96 RID: 7318
		private static readonly IntPtr NativeFieldInfoPtr__deadZoneType;

		// Token: 0x04001C97 RID: 7319
		private static readonly IntPtr NativeFieldInfoPtr__sensitivityType;

		// Token: 0x04001C98 RID: 7320
		private static readonly IntPtr NativeMethodInfoPtr_get_deadZoneType_Public_get_DeadZone2DType_0;

		// Token: 0x04001C99 RID: 7321
		private static readonly IntPtr NativeMethodInfoPtr_set_deadZoneType_Public_set_Void_DeadZone2DType_0;

		// Token: 0x04001C9A RID: 7322
		private static readonly IntPtr NativeMethodInfoPtr_get_sensitivityType_Public_get_AxisSensitivity2DType_0;

		// Token: 0x04001C9B RID: 7323
		private static readonly IntPtr NativeMethodInfoPtr_set_sensitivityType_Public_set_Void_AxisSensitivity2DType_0;

		// Token: 0x04001C9C RID: 7324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001C9D RID: 7325
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibrated2DValue_Internal_Vector2_Single_Single_AxisCalibration_AxisCalibration_0;

		// Token: 0x04001C9E RID: 7326
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibrated2DValue_Internal_Static_Vector2_Single_Single_AxisCalibration_AxisCalibration_DeadZone2DType_AxisSensitivity2DType_0;
	}
}
