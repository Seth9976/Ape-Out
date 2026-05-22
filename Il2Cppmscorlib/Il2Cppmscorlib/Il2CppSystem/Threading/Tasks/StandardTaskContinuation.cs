using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B5 RID: 693
	public class StandardTaskContinuation : TaskContinuation
	{
		// Token: 0x06002F44 RID: 12100 RVA: 0x000F0A84 File Offset: 0x000EEC84
		// Note: this type is marked as 'beforefieldinit'.
		static StandardTaskContinuation()
		{
			Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "StandardTaskContinuation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr);
			StandardTaskContinuation.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr, "m_task");
			StandardTaskContinuation.NativeFieldInfoPtr_m_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr, "m_options");
			StandardTaskContinuation.NativeFieldInfoPtr_m_taskScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr, "m_taskScheduler");
			StandardTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_Task_TaskContinuationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr, 100670832);
			StandardTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr, 100670833);
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x000F0B18 File Offset: 0x000EED18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206841, XrefRangeEnd = 206849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandardTaskContinuation(Task task, TaskContinuationOptions options, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_Task_TaskContinuationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x000F0B84 File Offset: 0x000EED84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206849, XrefRangeEnd = 206852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Run(Task completedTask, bool bCanInlineContinuationTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completedTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCanInlineContinuationTask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x000105A3 File Offset: 0x0000E7A3
		public StandardTaskContinuation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002F48 RID: 12104 RVA: 0x000F0BE0 File Offset: 0x000EEDE0
		// (set) Token: 0x06002F49 RID: 12105 RVA: 0x000105AC File Offset: 0x0000E7AC
		public unsafe Task m_task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002F4A RID: 12106 RVA: 0x000F0C10 File Offset: 0x000EEE10
		// (set) Token: 0x06002F4B RID: 12107 RVA: 0x000105CB File Offset: 0x0000E7CB
		public unsafe TaskContinuationOptions m_options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_options)) = value;
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002F4C RID: 12108 RVA: 0x000F0C38 File Offset: 0x000EEE38
		// (set) Token: 0x06002F4D RID: 12109 RVA: 0x000105E6 File Offset: 0x0000E7E6
		public unsafe TaskScheduler m_taskScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_taskScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_taskScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028F5 RID: 10485
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x040028F6 RID: 10486
		private static readonly IntPtr NativeFieldInfoPtr_m_options;

		// Token: 0x040028F7 RID: 10487
		private static readonly IntPtr NativeFieldInfoPtr_m_taskScheduler;

		// Token: 0x040028F8 RID: 10488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_TaskContinuationOptions_TaskScheduler_0;

		// Token: 0x040028F9 RID: 10489
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0;
	}
}
