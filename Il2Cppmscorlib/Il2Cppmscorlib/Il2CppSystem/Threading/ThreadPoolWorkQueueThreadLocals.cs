using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000287 RID: 647
	public sealed class ThreadPoolWorkQueueThreadLocals : Object
	{
		// Token: 0x06002C96 RID: 11414 RVA: 0x000E6098 File Offset: 0x000E4298
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPoolWorkQueueThreadLocals()
		{
			Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadPoolWorkQueueThreadLocals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr);
			ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_threadLocals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, "threadLocals");
			ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, "workQueue");
			ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workStealingQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, "workStealingQueue");
			ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, "random");
			ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr__ctor_Public_Void_ThreadPoolWorkQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, 100670458);
			ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr_CleanUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, 100670459);
			ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, 100670460);
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x000E6154 File Offset: 0x000E4354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204373, RefRangeEnd = 204375, XrefRangeStart = 204353, XrefRangeEnd = 204373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadPoolWorkQueueThreadLocals(ThreadPoolWorkQueue tpq)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tpq);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr__ctor_Public_Void_ThreadPoolWorkQueue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x000E61A0 File Offset: 0x000E43A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204385, RefRangeEnd = 204386, XrefRangeStart = 204375, XrefRangeEnd = 204385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr_CleanUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x000E61D4 File Offset: 0x000E43D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204386, XrefRangeEnd = 204394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x0000F5A6 File Offset: 0x0000D7A6
		public ThreadPoolWorkQueueThreadLocals(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06002C9B RID: 11419 RVA: 0x000E6208 File Offset: 0x000E4408
		// (set) Token: 0x06002C9C RID: 11420 RVA: 0x0000F5AF File Offset: 0x0000D7AF
		public unsafe static ThreadPoolWorkQueueThreadLocals threadLocals
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_threadLocals, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueueThreadLocals>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_threadLocals, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06002C9D RID: 11421 RVA: 0x000E6230 File Offset: 0x000E4430
		// (set) Token: 0x06002C9E RID: 11422 RVA: 0x0000F5C1 File Offset: 0x0000D7C1
		public unsafe ThreadPoolWorkQueue workQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06002C9F RID: 11423 RVA: 0x000E6260 File Offset: 0x000E4460
		// (set) Token: 0x06002CA0 RID: 11424 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
		public unsafe ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workStealingQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue.WorkStealingQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workStealingQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06002CA1 RID: 11425 RVA: 0x000E6290 File Offset: 0x000E4490
		// (set) Token: 0x06002CA2 RID: 11426 RVA: 0x0000F5FF File Offset: 0x0000D7FF
		public unsafe Random random
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_random);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_random), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026D3 RID: 9939
		private static readonly IntPtr NativeFieldInfoPtr_threadLocals;

		// Token: 0x040026D4 RID: 9940
		private static readonly IntPtr NativeFieldInfoPtr_workQueue;

		// Token: 0x040026D5 RID: 9941
		private static readonly IntPtr NativeFieldInfoPtr_workStealingQueue;

		// Token: 0x040026D6 RID: 9942
		private static readonly IntPtr NativeFieldInfoPtr_random;

		// Token: 0x040026D7 RID: 9943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ThreadPoolWorkQueue_0;

		// Token: 0x040026D8 RID: 9944
		private static readonly IntPtr NativeMethodInfoPtr_CleanUp_Private_Void_0;

		// Token: 0x040026D9 RID: 9945
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
