using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000289 RID: 649
	public sealed class QueueUserWorkItemCallback : Object
	{
		// Token: 0x06002CA6 RID: 11430 RVA: 0x000E62F0 File Offset: 0x000E44F0
		// Note: this type is marked as 'beforefieldinit'.
		static QueueUserWorkItemCallback()
		{
			Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "QueueUserWorkItemCallback");
			QueueUserWorkItemCallback.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, "callback");
			QueueUserWorkItemCallback.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, "context");
			QueueUserWorkItemCallback.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, "state");
			QueueUserWorkItemCallback.NativeFieldInfoPtr_ccb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, "ccb");
			QueueUserWorkItemCallback.NativeMethodInfoPtr__ctor_Internal_Void_WaitCallback_Object_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, 100670463);
			QueueUserWorkItemCallback.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, 100670464);
			QueueUserWorkItemCallback.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, 100670465);
			QueueUserWorkItemCallback.NativeMethodInfoPtr_WaitCallback_Context_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, 100670466);
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x000E63B8 File Offset: 0x000E45B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204398, XrefRangeEnd = 204405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QueueUserWorkItemCallback(WaitCallback waitCallback, Object stateObj, bool compressStack, ref StackCrawlMark stackMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitCallback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateObj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compressStack;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueueUserWorkItemCallback.NativeMethodInfoPtr__ctor_Internal_Void_WaitCallback_Object_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x000E6434 File Offset: 0x000E4634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204405, XrefRangeEnd = 204413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueueUserWorkItemCallback.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x000E6468 File Offset: 0x000E4668
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Threading_IThreadPoolWorkItem_MarkAborted(ThreadAbortException tae)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueueUserWorkItemCallback.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x000E64AC File Offset: 0x000E46AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204413, XrefRangeEnd = 204418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WaitCallback_Context(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueueUserWorkItemCallback.NativeMethodInfoPtr_WaitCallback_Context_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x0000F660 File Offset: 0x0000D860
		public QueueUserWorkItemCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x000E64E4 File Offset: 0x000E46E4
		// (set) Token: 0x06002CAD RID: 11437 RVA: 0x0000F669 File Offset: 0x0000D869
		public unsafe WaitCallback callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06002CAE RID: 11438 RVA: 0x000E6514 File Offset: 0x000E4714
		// (set) Token: 0x06002CAF RID: 11439 RVA: 0x0000F688 File Offset: 0x0000D888
		public unsafe ExecutionContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x000E6544 File Offset: 0x000E4744
		// (set) Token: 0x06002CB1 RID: 11441 RVA: 0x0000F6A7 File Offset: 0x0000D8A7
		public unsafe Object state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x000E6574 File Offset: 0x000E4774
		// (set) Token: 0x06002CB3 RID: 11443 RVA: 0x0000F6C6 File Offset: 0x0000D8C6
		public unsafe static ContextCallback ccb
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(QueueUserWorkItemCallback.NativeFieldInfoPtr_ccb, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(QueueUserWorkItemCallback.NativeFieldInfoPtr_ccb, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026DB RID: 9947
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x040026DC RID: 9948
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x040026DD RID: 9949
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040026DE RID: 9950
		private static readonly IntPtr NativeFieldInfoPtr_ccb;

		// Token: 0x040026DF RID: 9951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_WaitCallback_Object_Boolean_byref_StackCrawlMark_0;

		// Token: 0x040026E0 RID: 9952
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

		// Token: 0x040026E1 RID: 9953
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0;

		// Token: 0x040026E2 RID: 9954
		private static readonly IntPtr NativeMethodInfoPtr_WaitCallback_Context_Private_Static_Void_Object_0;
	}
}
