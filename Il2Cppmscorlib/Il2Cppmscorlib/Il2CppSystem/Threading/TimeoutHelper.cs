using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000268 RID: 616
	public static class TimeoutHelper : Object
	{
		// Token: 0x06002B16 RID: 11030 RVA: 0x000E0514 File Offset: 0x000DE714
		// Note: this type is marked as 'beforefieldinit'.
		static TimeoutHelper()
		{
			Il2CppClassPointerStore<TimeoutHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "TimeoutHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeoutHelper>.NativeClassPtr);
			TimeoutHelper.NativeMethodInfoPtr_GetTime_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutHelper>.NativeClassPtr, 100670216);
			TimeoutHelper.NativeMethodInfoPtr_UpdateTimeOut_Public_Static_Int32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutHelper>.NativeClassPtr, 100670217);
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x000E056C File Offset: 0x000DE76C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 174137, RefRangeEnd = 174142, XrefRangeStart = 174137, XrefRangeEnd = 174142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeoutHelper.NativeMethodInfoPtr_GetTime_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000E059C File Offset: 0x000DE79C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 200975, RefRangeEnd = 200981, XrefRangeStart = 200975, XrefRangeEnd = 200975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int UpdateTimeOut(uint startTime, int originalWaitMillisecondsTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originalWaitMillisecondsTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeoutHelper.NativeMethodInfoPtr_UpdateTimeOut_Public_Static_Int32_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x0000EDFA File Offset: 0x0000CFFA
		public TimeoutHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025C8 RID: 9672
		private static readonly IntPtr NativeMethodInfoPtr_GetTime_Public_Static_UInt32_0;

		// Token: 0x040025C9 RID: 9673
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeOut_Public_Static_Int32_UInt32_Int32_0;
	}
}
