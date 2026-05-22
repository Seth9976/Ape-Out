using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B4 RID: 692
	public class TaskContinuation : Object
	{
		// Token: 0x06002F3F RID: 12095 RVA: 0x000F093C File Offset: 0x000EEB3C
		// Note: this type is marked as 'beforefieldinit'.
		static TaskContinuation()
		{
			Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskContinuation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr);
			TaskContinuation.NativeMethodInfoPtr_Run_Internal_Abstract_Virtual_New_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr, 100670829);
			TaskContinuation.NativeMethodInfoPtr_InlineIfPossibleOrElseQueue_Protected_Static_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr, 100670830);
			TaskContinuation.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr, 100670831);
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x000F09A8 File Offset: 0x000EEBA8
		[CallerCount(0)]
		public unsafe virtual void Run(Task completedTask, bool bCanInlineContinuationTask)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskContinuation.NativeMethodInfoPtr_Run_Internal_Abstract_Virtual_New_Void_Task_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x000F0A04 File Offset: 0x000EEC04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206840, RefRangeEnd = 206841, XrefRangeStart = 206835, XrefRangeEnd = 206840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needsProtection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskContinuation.NativeMethodInfoPtr_InlineIfPossibleOrElseQueue_Protected_Static_Void_Task_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x000F0A48 File Offset: 0x000EEC48
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskContinuation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskContinuation.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x0001059A File Offset: 0x0000E79A
		public TaskContinuation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040028F2 RID: 10482
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Abstract_Virtual_New_Void_Task_Boolean_0;

		// Token: 0x040028F3 RID: 10483
		private static readonly IntPtr NativeMethodInfoPtr_InlineIfPossibleOrElseQueue_Protected_Static_Void_Task_Boolean_0;

		// Token: 0x040028F4 RID: 10484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
