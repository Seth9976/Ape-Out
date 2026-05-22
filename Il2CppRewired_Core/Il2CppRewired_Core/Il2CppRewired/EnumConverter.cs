using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppRewired.Config;
using Il2CppRewired.Data.Mapping;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired
{
	// Token: 0x02000031 RID: 49
	public static class EnumConverter : Object
	{
		// Token: 0x060003AB RID: 939 RVA: 0x0003BEB4 File Offset: 0x0003A0B4
		// Note: this type is marked as 'beforefieldinit'.
		static EnumConverter()
		{
			Il2CppClassPointerStore<EnumConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "EnumConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumConverter>.NativeClassPtr);
			EnumConverter.NativeMethodInfoPtr_ToUpdateLoopTypes_Public_Static_Int32_UpdateLoopSetting_List_1_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumConverter>.NativeClassPtr, 100663898);
			EnumConverter.NativeMethodInfoPtr_ToAlternateAxisCalibrationType_Public_Static_AlternateAxisCalibrationType_ThrottleCalibrationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumConverter>.NativeClassPtr, 100663899);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0003BF0C File Offset: 0x0003A10C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 244770, RefRangeEnd = 244782, XrefRangeStart = 244751, XrefRangeEnd = 244770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToUpdateLoopTypes(UpdateLoopSetting updateLoopSetting, List<UpdateLoopType> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoopSetting;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumConverter.NativeMethodInfoPtr_ToUpdateLoopTypes_Public_Static_Int32_UpdateLoopSetting_List_1_UpdateLoopType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0003BF5C File Offset: 0x0003A15C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 244782, RefRangeEnd = 244784, XrefRangeStart = 244782, XrefRangeEnd = 244782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AlternateAxisCalibrationType ToAlternateAxisCalibrationType(ThrottleCalibrationMode throttleCalibrationMode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throttleCalibrationMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumConverter.NativeMethodInfoPtr_ToAlternateAxisCalibrationType_Public_Static_AlternateAxisCalibrationType_ThrottleCalibrationMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000032C0 File Offset: 0x000014C0
		public EnumConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_ToUpdateLoopTypes_Public_Static_Int32_UpdateLoopSetting_List_1_UpdateLoopType_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_ToAlternateAxisCalibrationType_Public_Static_AlternateAxisCalibrationType_ThrottleCalibrationMode_0;
	}
}
