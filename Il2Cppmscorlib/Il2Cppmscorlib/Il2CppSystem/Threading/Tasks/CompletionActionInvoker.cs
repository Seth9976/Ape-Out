using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A7 RID: 679
	public sealed class CompletionActionInvoker : Object
	{
		// Token: 0x06002EFA RID: 12026 RVA: 0x000EF9A8 File Offset: 0x000EDBA8
		// Note: this type is marked as 'beforefieldinit'.
		static CompletionActionInvoker()
		{
			Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "CompletionActionInvoker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr);
			CompletionActionInvoker.NativeFieldInfoPtr_m_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr, "m_action");
			CompletionActionInvoker.NativeFieldInfoPtr_m_completingTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr, "m_completingTask");
			CompletionActionInvoker.NativeMethodInfoPtr__ctor_Internal_Void_ITaskCompletionAction_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr, 100670797);
			CompletionActionInvoker.NativeMethodInfoPtr_ExecuteWorkItem_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr, 100670798);
			CompletionActionInvoker.NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr, 100670799);
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x000EFA3C File Offset: 0x000EDC3C
		[CallerCount(76)]
		[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompletionActionInvoker(ITaskCompletionAction action, Task completingTask)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompletionActionInvoker.NativeMethodInfoPtr__ctor_Internal_Void_ITaskCompletionAction_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x000EFA9C File Offset: 0x000EDC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206669, XrefRangeEnd = 206672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompletionActionInvoker.NativeMethodInfoPtr_ExecuteWorkItem_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EFD RID: 12029 RVA: 0x000EFAD0 File Offset: 0x000EDCD0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkAborted(ThreadAbortException tae)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompletionActionInvoker.NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x000103A5 File Offset: 0x0000E5A5
		public CompletionActionInvoker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06002EFF RID: 12031 RVA: 0x000EFB14 File Offset: 0x000EDD14
		// (set) Token: 0x06002F00 RID: 12032 RVA: 0x000103AE File Offset: 0x0000E5AE
		public unsafe ITaskCompletionAction m_action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompletionActionInvoker.NativeFieldInfoPtr_m_action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITaskCompletionAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompletionActionInvoker.NativeFieldInfoPtr_m_action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06002F01 RID: 12033 RVA: 0x000EFB44 File Offset: 0x000EDD44
		// (set) Token: 0x06002F02 RID: 12034 RVA: 0x000103CD File Offset: 0x0000E5CD
		public unsafe Task m_completingTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompletionActionInvoker.NativeFieldInfoPtr_m_completingTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompletionActionInvoker.NativeFieldInfoPtr_m_completingTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028A9 RID: 10409
		private static readonly IntPtr NativeFieldInfoPtr_m_action;

		// Token: 0x040028AA RID: 10410
		private static readonly IntPtr NativeFieldInfoPtr_m_completingTask;

		// Token: 0x040028AB RID: 10411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ITaskCompletionAction_Task_0;

		// Token: 0x040028AC RID: 10412
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteWorkItem_Public_Virtual_Final_New_Void_0;

		// Token: 0x040028AD RID: 10413
		private static readonly IntPtr NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0;
	}
}
