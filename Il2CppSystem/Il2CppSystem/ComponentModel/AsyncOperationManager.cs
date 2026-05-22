using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200006D RID: 109
	public static class AsyncOperationManager : Object
	{
		// Token: 0x060007A8 RID: 1960 RVA: 0x0002DCBC File Offset: 0x0002BEBC
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncOperationManager()
		{
			Il2CppClassPointerStore<AsyncOperationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "AsyncOperationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperationManager>.NativeClassPtr);
			AsyncOperationManager.NativeMethodInfoPtr_CreateOperation_Public_Static_AsyncOperation_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationManager>.NativeClassPtr, 100664421);
			AsyncOperationManager.NativeMethodInfoPtr_get_SynchronizationContext_Public_Static_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationManager>.NativeClassPtr, 100664422);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0002DD14 File Offset: 0x0002BF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372517, XrefRangeEnd = 372526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation CreateOperation(Object userSuppliedState)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(userSuppliedState);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationManager.NativeMethodInfoPtr_CreateOperation_Public_Static_AsyncOperation_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x0002DD58 File Offset: 0x0002BF58
		public unsafe static SynchronizationContext SynchronizationContext
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372526, XrefRangeEnd = 372532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationManager.NativeMethodInfoPtr_get_SynchronizationContext_Public_Static_get_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0000503C File Offset: 0x0000323C
		public AsyncOperationManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_CreateOperation_Public_Static_AsyncOperation_Object_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizationContext_Public_Static_get_SynchronizationContext_0;
	}
}
