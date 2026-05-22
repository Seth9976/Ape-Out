using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B7 RID: 695
	public sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
	{
		// Token: 0x06002F5A RID: 12122 RVA: 0x000F0EDC File Offset: 0x000EF0DC
		// Note: this type is marked as 'beforefieldinit'.
		static TaskSchedulerAwaitTaskContinuation()
		{
			Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskSchedulerAwaitTaskContinuation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr);
			TaskSchedulerAwaitTaskContinuation.NativeFieldInfoPtr_m_scheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr, "m_scheduler");
			TaskSchedulerAwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_TaskScheduler_Action_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr, 100670842);
			TaskSchedulerAwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr, 100670843);
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x000F0F48 File Offset: 0x000EF148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskSchedulerAwaitTaskContinuation(TaskScheduler scheduler, Action action, bool flowExecutionContext, ref StackCrawlMark stackMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowExecutionContext;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerAwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_TaskScheduler_Action_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x000F0FC4 File Offset: 0x000EF1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206894, XrefRangeEnd = 206940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Run(Task ignored, bool canInlineContinuationTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ignored);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canInlineContinuationTask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerAwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x00010651 File Offset: 0x0000E851
		public TaskSchedulerAwaitTaskContinuation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06002F5E RID: 12126 RVA: 0x000F1014 File Offset: 0x000EF214
		// (set) Token: 0x06002F5F RID: 12127 RVA: 0x0001065A File Offset: 0x0000E85A
		public unsafe TaskScheduler m_scheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskSchedulerAwaitTaskContinuation.NativeFieldInfoPtr_m_scheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskSchedulerAwaitTaskContinuation.NativeFieldInfoPtr_m_scheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002901 RID: 10497
		private static readonly IntPtr NativeFieldInfoPtr_m_scheduler;

		// Token: 0x04002902 RID: 10498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TaskScheduler_Action_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04002903 RID: 10499
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0;

		// Token: 0x02000616 RID: 1558
		[ObfuscatedName("System.Threading.Tasks.TaskSchedulerAwaitTaskContinuation+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600550F RID: 21775 RVA: 0x0017D9E0 File Offset: 0x0017BBE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr);
				TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr, "<>9");
				TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr, "<>9__2_0");
				TaskSchedulerAwaitTaskContinuation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr, 100670845);
				TaskSchedulerAwaitTaskContinuation.__c.NativeMethodInfoPtr__Run_b__2_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr, 100670846);
			}

			// Token: 0x06005510 RID: 21776 RVA: 0x0017DA5C File Offset: 0x0017BC5C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerAwaitTaskContinuation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005511 RID: 21777 RVA: 0x0017DA98 File Offset: 0x0017BC98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206889, XrefRangeEnd = 206894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Run_b__2_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerAwaitTaskContinuation.__c.NativeMethodInfoPtr__Run_b__2_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005512 RID: 21778 RVA: 0x000202D6 File Offset: 0x0001E4D6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015D0 RID: 5584
			// (get) Token: 0x06005513 RID: 21779 RVA: 0x0017DADC File Offset: 0x0017BCDC
			// (set) Token: 0x06005514 RID: 21780 RVA: 0x000202DF File Offset: 0x0001E4DF
			public unsafe static TaskSchedulerAwaitTaskContinuation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskSchedulerAwaitTaskContinuation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015D1 RID: 5585
			// (get) Token: 0x06005515 RID: 21781 RVA: 0x0017DB04 File Offset: 0x0017BD04
			// (set) Token: 0x06005516 RID: 21782 RVA: 0x000202F1 File Offset: 0x0001E4F1
			public unsafe static Action<Object> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044C0 RID: 17600
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040044C1 RID: 17601
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040044C2 RID: 17602
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040044C3 RID: 17603
			private static readonly IntPtr NativeMethodInfoPtr__Run_b__2_0_Internal_Void_Object_0;
		}
	}
}
