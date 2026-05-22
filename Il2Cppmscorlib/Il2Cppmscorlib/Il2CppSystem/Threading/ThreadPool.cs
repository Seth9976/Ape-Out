using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200028A RID: 650
	public static class ThreadPool : Object
	{
		// Token: 0x06002CB4 RID: 11444 RVA: 0x000E659C File Offset: 0x000E479C
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPool()
		{
			Il2CppClassPointerStore<ThreadPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr);
			ThreadPool.NativeMethodInfoPtr_RegisterWaitForSingleObject_Private_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_UInt32_Boolean_byref_StackCrawlMark_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670467);
			ThreadPool.NativeMethodInfoPtr_RegisterWaitForSingleObject_Public_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670468);
			ThreadPool.NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670469);
			ThreadPool.NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670470);
			ThreadPool.NativeMethodInfoPtr_UnsafeQueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670471);
			ThreadPool.NativeMethodInfoPtr_QueueUserWorkItemHelper_Private_Static_Boolean_WaitCallback_Object_byref_StackCrawlMark_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670472);
			ThreadPool.NativeMethodInfoPtr_UnsafeQueueCustomWorkItem_Internal_Static_Void_IThreadPoolWorkItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670473);
			ThreadPool.NativeMethodInfoPtr_TryPopCustomWorkItem_Internal_Static_Boolean_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670474);
			ThreadPool.NativeMethodInfoPtr_RequestWorkerThread_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670475);
			ThreadPool.NativeMethodInfoPtr_EnsureVMInitialized_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670476);
			ThreadPool.NativeMethodInfoPtr_NotifyWorkItemComplete_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670477);
			ThreadPool.NativeMethodInfoPtr_ReportThreadStatus_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670478);
			ThreadPool.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670479);
			ThreadPool.NativeMethodInfoPtr_NotifyWorkItemProgressNative_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670480);
			ThreadPool.NativeMethodInfoPtr_IsThreadPoolHosted_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670481);
			ThreadPool.NativeMethodInfoPtr_InitializeVMTp_Private_Static_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670482);
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x000E670C File Offset: 0x000E490C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204429, RefRangeEnd = 204430, XrefRangeStart = 204418, XrefRangeEnd = 204429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, Object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeOutInterval;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref executeOnlyOnce;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compressStack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_RegisterWaitForSingleObject_Private_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_UInt32_Boolean_byref_StackCrawlMark_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegisteredWaitHandle>(intPtr3) : null;
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x000E67B0 File Offset: 0x000E49B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204432, RefRangeEnd = 204433, XrefRangeStart = 204430, XrefRangeEnd = 204432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, Object state, TimeSpan timeout, bool executeOnlyOnce)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref executeOnlyOnce;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_RegisterWaitForSingleObject_Public_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegisteredWaitHandle>(intPtr3) : null;
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x000E6834 File Offset: 0x000E4A34
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 204434, RefRangeEnd = 204441, XrefRangeStart = 204433, XrefRangeEnd = 204434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool QueueUserWorkItem(WaitCallback callBack, Object state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x000E6888 File Offset: 0x000E4A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204442, RefRangeEnd = 204443, XrefRangeStart = 204441, XrefRangeEnd = 204442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool QueueUserWorkItem(WaitCallback callBack)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callBack);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x000E68CC File Offset: 0x000E4ACC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 204444, RefRangeEnd = 204448, XrefRangeStart = 204443, XrefRangeEnd = 204444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UnsafeQueueUserWorkItem(WaitCallback callBack, Object state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_UnsafeQueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x000E6920 File Offset: 0x000E4B20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204464, RefRangeEnd = 204467, XrefRangeStart = 204448, XrefRangeEnd = 204464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool QueueUserWorkItemHelper(WaitCallback callBack, Object state, ref StackCrawlMark stackMark, bool compressStack)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compressStack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_QueueUserWorkItemHelper_Private_Static_Boolean_WaitCallback_Object_byref_StackCrawlMark_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x000E6990 File Offset: 0x000E4B90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 204473, RefRangeEnd = 204478, XrefRangeStart = 204467, XrefRangeEnd = 204473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(workItem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceGlobal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_UnsafeQueueCustomWorkItem_Internal_Static_Void_IThreadPoolWorkItem_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x000E69D4 File Offset: 0x000E4BD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204489, RefRangeEnd = 204491, XrefRangeStart = 204478, XrefRangeEnd = 204489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(workItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_TryPopCustomWorkItem_Internal_Static_Boolean_IThreadPoolWorkItem_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x000E6A18 File Offset: 0x000E4C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204491, XrefRangeEnd = 204494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequestWorkerThread()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_RequestWorkerThread_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x000E6A48 File Offset: 0x000E4C48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204503, RefRangeEnd = 204505, XrefRangeStart = 204494, XrefRangeEnd = 204503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureVMInitialized()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_EnsureVMInitialized_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x000E6A70 File Offset: 0x000E4C70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204505, RefRangeEnd = 204506, XrefRangeStart = 204505, XrefRangeEnd = 204505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NotifyWorkItemComplete()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_NotifyWorkItemComplete_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x000E6AA0 File Offset: 0x000E4CA0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 131113, RefRangeEnd = 131119, XrefRangeStart = 131113, XrefRangeEnd = 131119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReportThreadStatus(bool isWorking)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isWorking;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_ReportThreadStatus_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x000E6AD4 File Offset: 0x000E4CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204506, XrefRangeEnd = 204517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyWorkItemProgress()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x000E6AFC File Offset: 0x000E4CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204517, XrefRangeEnd = 204520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyWorkItemProgressNative()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_NotifyWorkItemProgressNative_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x000E6B24 File Offset: 0x000E4D24
		[CallerCount(0)]
		public unsafe static bool IsThreadPoolHosted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_IsThreadPoolHosted_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x000E6B54 File Offset: 0x000E4D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204520, XrefRangeEnd = 204533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeVMTp(ref bool enableWorkerTracking)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &enableWorkerTracking;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_InitializeVMTp_Private_Static_Void_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
		public ThreadPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040026E3 RID: 9955
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWaitForSingleObject_Private_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_UInt32_Boolean_byref_StackCrawlMark_Boolean_0;

		// Token: 0x040026E4 RID: 9956
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWaitForSingleObject_Public_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0;

		// Token: 0x040026E5 RID: 9957
		private static readonly IntPtr NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0;

		// Token: 0x040026E6 RID: 9958
		private static readonly IntPtr NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_0;

		// Token: 0x040026E7 RID: 9959
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeQueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0;

		// Token: 0x040026E8 RID: 9960
		private static readonly IntPtr NativeMethodInfoPtr_QueueUserWorkItemHelper_Private_Static_Boolean_WaitCallback_Object_byref_StackCrawlMark_Boolean_0;

		// Token: 0x040026E9 RID: 9961
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeQueueCustomWorkItem_Internal_Static_Void_IThreadPoolWorkItem_Boolean_0;

		// Token: 0x040026EA RID: 9962
		private static readonly IntPtr NativeMethodInfoPtr_TryPopCustomWorkItem_Internal_Static_Boolean_IThreadPoolWorkItem_0;

		// Token: 0x040026EB RID: 9963
		private static readonly IntPtr NativeMethodInfoPtr_RequestWorkerThread_Internal_Static_Boolean_0;

		// Token: 0x040026EC RID: 9964
		private static readonly IntPtr NativeMethodInfoPtr_EnsureVMInitialized_Private_Static_Void_0;

		// Token: 0x040026ED RID: 9965
		private static readonly IntPtr NativeMethodInfoPtr_NotifyWorkItemComplete_Internal_Static_Boolean_0;

		// Token: 0x040026EE RID: 9966
		private static readonly IntPtr NativeMethodInfoPtr_ReportThreadStatus_Internal_Static_Void_Boolean_0;

		// Token: 0x040026EF RID: 9967
		private static readonly IntPtr NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Static_Void_0;

		// Token: 0x040026F0 RID: 9968
		private static readonly IntPtr NativeMethodInfoPtr_NotifyWorkItemProgressNative_Internal_Static_Void_0;

		// Token: 0x040026F1 RID: 9969
		private static readonly IntPtr NativeMethodInfoPtr_IsThreadPoolHosted_Internal_Static_Boolean_0;

		// Token: 0x040026F2 RID: 9970
		private static readonly IntPtr NativeMethodInfoPtr_InitializeVMTp_Private_Static_Void_byref_Boolean_0;
	}
}
