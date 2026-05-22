using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200025E RID: 606
	public class CancellationCallbackInfo : Object
	{
		// Token: 0x06002A69 RID: 10857 RVA: 0x000DE000 File Offset: 0x000DC200
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationCallbackInfo()
		{
			Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "CancellationCallbackInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr);
			CancellationCallbackInfo.NativeFieldInfoPtr_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "Callback");
			CancellationCallbackInfo.NativeFieldInfoPtr_StateForCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "StateForCallback");
			CancellationCallbackInfo.NativeFieldInfoPtr_TargetSyncContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "TargetSyncContext");
			CancellationCallbackInfo.NativeFieldInfoPtr_TargetExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "TargetExecutionContext");
			CancellationCallbackInfo.NativeFieldInfoPtr_CancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "CancellationTokenSource");
			CancellationCallbackInfo.NativeFieldInfoPtr_s_executionContextCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "s_executionContextCallback");
			CancellationCallbackInfo.NativeMethodInfoPtr__ctor_Internal_Void_Action_1_Object_Object_SynchronizationContext_ExecutionContext_CancellationTokenSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, 100670138);
			CancellationCallbackInfo.NativeMethodInfoPtr_ExecuteCallback_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, 100670139);
			CancellationCallbackInfo.NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, 100670140);
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x000DE0E4 File Offset: 0x000DC2E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200463, RefRangeEnd = 200464, XrefRangeStart = 200463, XrefRangeEnd = 200463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationCallbackInfo(Action<Object> callback, Object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateForCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetSyncContext);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetExecutionContext);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cancellationTokenSource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationCallbackInfo.NativeMethodInfoPtr__ctor_Internal_Void_Action_1_Object_Object_SynchronizationContext_ExecutionContext_CancellationTokenSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x000DE17C File Offset: 0x000DC37C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200484, RefRangeEnd = 200485, XrefRangeStart = 200464, XrefRangeEnd = 200484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationCallbackInfo.NativeMethodInfoPtr_ExecuteCallback_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x000DE1B0 File Offset: 0x000DC3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200485, XrefRangeEnd = 200491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutionContextCallback(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationCallbackInfo.NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		public CancellationCallbackInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x000DE1E8 File Offset: 0x000DC3E8
		// (set) Token: 0x06002A6F RID: 10863 RVA: 0x0000E9D9 File Offset: 0x0000CBD9
		public unsafe Action<Object> Callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_Callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06002A70 RID: 10864 RVA: 0x000DE218 File Offset: 0x000DC418
		// (set) Token: 0x06002A71 RID: 10865 RVA: 0x0000E9F8 File Offset: 0x0000CBF8
		public unsafe Object StateForCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_StateForCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_StateForCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06002A72 RID: 10866 RVA: 0x000DE248 File Offset: 0x000DC448
		// (set) Token: 0x06002A73 RID: 10867 RVA: 0x0000EA17 File Offset: 0x0000CC17
		public unsafe SynchronizationContext TargetSyncContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_TargetSyncContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_TargetSyncContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x000DE278 File Offset: 0x000DC478
		// (set) Token: 0x06002A75 RID: 10869 RVA: 0x0000EA36 File Offset: 0x0000CC36
		public unsafe ExecutionContext TargetExecutionContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_TargetExecutionContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_TargetExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x000DE2A8 File Offset: 0x000DC4A8
		// (set) Token: 0x06002A77 RID: 10871 RVA: 0x0000EA55 File Offset: 0x0000CC55
		public unsafe CancellationTokenSource CancellationTokenSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_CancellationTokenSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_CancellationTokenSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06002A78 RID: 10872 RVA: 0x000DE2D8 File Offset: 0x000DC4D8
		// (set) Token: 0x06002A79 RID: 10873 RVA: 0x0000EA74 File Offset: 0x0000CC74
		public unsafe static ContextCallback s_executionContextCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationCallbackInfo.NativeFieldInfoPtr_s_executionContextCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationCallbackInfo.NativeFieldInfoPtr_s_executionContextCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002555 RID: 9557
		private static readonly IntPtr NativeFieldInfoPtr_Callback;

		// Token: 0x04002556 RID: 9558
		private static readonly IntPtr NativeFieldInfoPtr_StateForCallback;

		// Token: 0x04002557 RID: 9559
		private static readonly IntPtr NativeFieldInfoPtr_TargetSyncContext;

		// Token: 0x04002558 RID: 9560
		private static readonly IntPtr NativeFieldInfoPtr_TargetExecutionContext;

		// Token: 0x04002559 RID: 9561
		private static readonly IntPtr NativeFieldInfoPtr_CancellationTokenSource;

		// Token: 0x0400255A RID: 9562
		private static readonly IntPtr NativeFieldInfoPtr_s_executionContextCallback;

		// Token: 0x0400255B RID: 9563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Action_1_Object_Object_SynchronizationContext_ExecutionContext_CancellationTokenSource_0;

		// Token: 0x0400255C RID: 9564
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCallback_Internal_Void_0;

		// Token: 0x0400255D RID: 9565
		private static readonly IntPtr NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0;
	}
}
