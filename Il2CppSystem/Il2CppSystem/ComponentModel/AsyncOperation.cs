using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200006C RID: 108
	public sealed class AsyncOperation : Object
	{
		// Token: 0x06000798 RID: 1944 RVA: 0x0002D8E8 File Offset: 0x0002BAE8
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncOperation()
		{
			Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "AsyncOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr);
			AsyncOperation.NativeFieldInfoPtr_syncContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, "syncContext");
			AsyncOperation.NativeFieldInfoPtr_userSuppliedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, "userSuppliedState");
			AsyncOperation.NativeFieldInfoPtr_alreadyCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, "alreadyCompleted");
			AsyncOperation.NativeMethodInfoPtr__ctor_Private_Void_Object_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664413);
			AsyncOperation.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664414);
			AsyncOperation.NativeMethodInfoPtr_Post_Public_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664415);
			AsyncOperation.NativeMethodInfoPtr_PostOperationCompleted_Public_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664416);
			AsyncOperation.NativeMethodInfoPtr_OperationCompletedCore_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664417);
			AsyncOperation.NativeMethodInfoPtr_VerifyNotCompleted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664418);
			AsyncOperation.NativeMethodInfoPtr_VerifyDelegateNotNull_Private_Void_SendOrPostCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664419);
			AsyncOperation.NativeMethodInfoPtr_CreateOperation_Internal_Static_AsyncOperation_Object_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664420);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0002D9F4 File Offset: 0x0002BBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372484, XrefRangeEnd = 372485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperation(Object userSuppliedState, SynchronizationContext syncContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(userSuppliedState);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syncContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr__ctor_Private_Void_Object_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0002DA54 File Offset: 0x0002BC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372485, XrefRangeEnd = 372486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0002DA88 File Offset: 0x0002BC88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 372502, RefRangeEnd = 372505, XrefRangeStart = 372486, XrefRangeEnd = 372502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Post(SendOrPostCallback d, Object arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_Post_Public_Void_SendOrPostCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0002DADC File Offset: 0x0002BCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372505, XrefRangeEnd = 372507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostOperationCompleted(SendOrPostCallback d, Object arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_PostOperationCompleted_Public_Void_SendOrPostCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0002DB30 File Offset: 0x0002BD30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372512, RefRangeEnd = 372514, XrefRangeStart = 372507, XrefRangeEnd = 372512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OperationCompletedCore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_OperationCompletedCore_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0002DB64 File Offset: 0x0002BD64
		[CallerCount(0)]
		public unsafe void VerifyNotCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_VerifyNotCompleted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0002DB98 File Offset: 0x0002BD98
		[CallerCount(0)]
		public unsafe void VerifyDelegateNotNull(SendOrPostCallback d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_VerifyDelegateNotNull_Private_Void_SendOrPostCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0002DBDC File Offset: 0x0002BDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372514, XrefRangeEnd = 372517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation CreateOperation(Object userSuppliedState, SynchronizationContext syncContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(userSuppliedState);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syncContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_CreateOperation_Internal_Static_AsyncOperation_Object_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00004FDA File Offset: 0x000031DA
		public AsyncOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x0002DC34 File Offset: 0x0002BE34
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x00004FE3 File Offset: 0x000031E3
		public unsafe SynchronizationContext syncContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_syncContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_syncContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x0002DC64 File Offset: 0x0002BE64
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x00005002 File Offset: 0x00003202
		public unsafe Object userSuppliedState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_userSuppliedState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_userSuppliedState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x0002DC94 File Offset: 0x0002BE94
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x00005021 File Offset: 0x00003221
		public unsafe bool alreadyCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_alreadyCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_alreadyCompleted)) = value;
			}
		}

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeFieldInfoPtr_syncContext;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeFieldInfoPtr_userSuppliedState;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeFieldInfoPtr_alreadyCompleted;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Object_SynchronizationContext_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Void_SendOrPostCallback_Object_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_PostOperationCompleted_Public_Void_SendOrPostCallback_Object_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_OperationCompletedCore_Private_Void_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_VerifyNotCompleted_Private_Void_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_VerifyDelegateNotNull_Private_Void_SendOrPostCallback_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_CreateOperation_Internal_Static_AsyncOperation_Object_SynchronizationContext_0;
	}
}
