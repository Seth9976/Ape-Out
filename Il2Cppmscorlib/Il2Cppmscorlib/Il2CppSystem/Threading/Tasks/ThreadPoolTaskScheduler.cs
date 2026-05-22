using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002BF RID: 703
	public sealed class ThreadPoolTaskScheduler : TaskScheduler
	{
		// Token: 0x06002FD5 RID: 12245 RVA: 0x000F2D78 File Offset: 0x000F0F78
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPoolTaskScheduler()
		{
			Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "ThreadPoolTaskScheduler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr);
			ThreadPoolTaskScheduler.NativeFieldInfoPtr_s_longRunningThreadWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, "s_longRunningThreadWork");
			ThreadPoolTaskScheduler.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100670920);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_LongRunningThreadWork_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100670921);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_QueueTask_FamOrAssem_Virtual_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100670922);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Virtual_Boolean_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100670923);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_Boolean_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100670924);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100670925);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100670926);
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x000F2E48 File Offset: 0x000F1048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207585, XrefRangeEnd = 207593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadPoolTaskScheduler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x000F2E84 File Offset: 0x000F1084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207593, XrefRangeEnd = 207597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LongRunningThreadWork(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_LongRunningThreadWork_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x000F2EBC File Offset: 0x000F10BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207597, XrefRangeEnd = 207621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void QueueTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_QueueTask_FamOrAssem_Virtual_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x000F2F00 File Offset: 0x000F1100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207621, XrefRangeEnd = 207622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taskWasPreviouslyQueued;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Virtual_Boolean_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x000F2F5C File Offset: 0x000F115C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207622, XrefRangeEnd = 207630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryDequeue(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_Boolean_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x000F2FAC File Offset: 0x000F11AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NotifyWorkItemProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06002FDC RID: 12252 RVA: 0x000F2FE0 File Offset: 0x000F11E0
		public unsafe override bool RequiresAtomicStartTransition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x000108DC File Offset: 0x0000EADC
		public ThreadPoolTaskScheduler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06002FDE RID: 12254 RVA: 0x000F301C File Offset: 0x000F121C
		// (set) Token: 0x06002FDF RID: 12255 RVA: 0x000108E5 File Offset: 0x0000EAE5
		public unsafe static ParameterizedThreadStart s_longRunningThreadWork
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolTaskScheduler.NativeFieldInfoPtr_s_longRunningThreadWork, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParameterizedThreadStart>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolTaskScheduler.NativeFieldInfoPtr_s_longRunningThreadWork, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002955 RID: 10581
		private static readonly IntPtr NativeFieldInfoPtr_s_longRunningThreadWork;

		// Token: 0x04002956 RID: 10582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002957 RID: 10583
		private static readonly IntPtr NativeMethodInfoPtr_LongRunningThreadWork_Private_Static_Void_Object_0;

		// Token: 0x04002958 RID: 10584
		private static readonly IntPtr NativeMethodInfoPtr_QueueTask_FamOrAssem_Virtual_Void_Task_0;

		// Token: 0x04002959 RID: 10585
		private static readonly IntPtr NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Virtual_Boolean_Task_Boolean_0;

		// Token: 0x0400295A RID: 10586
		private static readonly IntPtr NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_Boolean_Task_0;

		// Token: 0x0400295B RID: 10587
		private static readonly IntPtr NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_Void_0;

		// Token: 0x0400295C RID: 10588
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_get_Boolean_0;
	}
}
