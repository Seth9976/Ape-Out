using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B2 RID: 690
	public sealed class ContinuationTaskFromTask : Task
	{
		// Token: 0x06002F33 RID: 12083 RVA: 0x000F0614 File Offset: 0x000EE814
		// Note: this type is marked as 'beforefieldinit'.
		static ContinuationTaskFromTask()
		{
			Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "ContinuationTaskFromTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr);
			ContinuationTaskFromTask.NativeFieldInfoPtr_m_antecedent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr, "m_antecedent");
			ContinuationTaskFromTask.NativeMethodInfoPtr__ctor_Public_Void_Task_Delegate_Object_TaskCreationOptions_InternalTaskOptions_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr, 100670825);
			ContinuationTaskFromTask.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr, 100670826);
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x000F0680 File Offset: 0x000EE880
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 206802, RefRangeEnd = 206806, XrefRangeStart = 206784, XrefRangeEnd = 206802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinuationTaskFromTask(Task antecedent, Delegate action, Object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(antecedent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinuationTaskFromTask.NativeMethodInfoPtr__ctor_Public_Void_Task_Delegate_Object_TaskCreationOptions_InternalTaskOptions_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x000F071C File Offset: 0x000EE91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206806, XrefRangeEnd = 206815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InnerInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinuationTaskFromTask.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x0001054A File Offset: 0x0000E74A
		public ContinuationTaskFromTask(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002F37 RID: 12087 RVA: 0x000F0750 File Offset: 0x000EE950
		// (set) Token: 0x06002F38 RID: 12088 RVA: 0x00010553 File Offset: 0x0000E753
		public unsafe Task m_antecedent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinuationTaskFromTask.NativeFieldInfoPtr_m_antecedent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinuationTaskFromTask.NativeFieldInfoPtr_m_antecedent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028EC RID: 10476
		private static readonly IntPtr NativeFieldInfoPtr_m_antecedent;

		// Token: 0x040028ED RID: 10477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Task_Delegate_Object_TaskCreationOptions_InternalTaskOptions_byref_StackCrawlMark_0;

		// Token: 0x040028EE RID: 10478
		private static readonly IntPtr NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0;
	}
}
