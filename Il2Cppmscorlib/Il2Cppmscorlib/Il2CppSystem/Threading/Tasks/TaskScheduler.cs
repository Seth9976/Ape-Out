using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002BB RID: 699
	public class TaskScheduler : Object
	{
		// Token: 0x06002FA7 RID: 12199 RVA: 0x000F22EC File Offset: 0x000F04EC
		// Note: this type is marked as 'beforefieldinit'.
		static TaskScheduler()
		{
			Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskScheduler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr);
			TaskScheduler.NativeFieldInfoPtr_s_activeTaskSchedulers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "s_activeTaskSchedulers");
			TaskScheduler.NativeFieldInfoPtr_s_defaultTaskScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "s_defaultTaskScheduler");
			TaskScheduler.NativeFieldInfoPtr_s_taskSchedulerIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "s_taskSchedulerIdCounter");
			TaskScheduler.NativeFieldInfoPtr_m_taskSchedulerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "m_taskSchedulerId");
			TaskScheduler.NativeFieldInfoPtr__unobservedTaskException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "_unobservedTaskException");
			TaskScheduler.NativeFieldInfoPtr__unobservedTaskExceptionLockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "_unobservedTaskExceptionLockObject");
			TaskScheduler.NativeMethodInfoPtr_QueueTask_FamOrAssem_Abstract_Virtual_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670890);
			TaskScheduler.NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Abstract_Virtual_New_Boolean_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670891);
			TaskScheduler.NativeMethodInfoPtr_TryRunInline_Internal_Boolean_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670892);
			TaskScheduler.NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_New_Boolean_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670893);
			TaskScheduler.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670894);
			TaskScheduler.NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670895);
			TaskScheduler.NativeMethodInfoPtr_InternalQueueTask_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670896);
			TaskScheduler.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670897);
			TaskScheduler.NativeMethodInfoPtr_AddToActiveTaskSchedulers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670898);
			TaskScheduler.NativeMethodInfoPtr_get_Default_Public_Static_get_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670899);
			TaskScheduler.NativeMethodInfoPtr_get_Current_Public_Static_get_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670900);
			TaskScheduler.NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670901);
			TaskScheduler.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670902);
			TaskScheduler.NativeMethodInfoPtr_PublishUnobservedTaskException_Internal_Static_Void_Object_UnobservedTaskExceptionEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670903);
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x000F24AC File Offset: 0x000F06AC
		[CallerCount(0)]
		public unsafe virtual void QueueTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskScheduler.NativeMethodInfoPtr_QueueTask_FamOrAssem_Abstract_Virtual_New_Void_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x000F24FC File Offset: 0x000F06FC
		[CallerCount(0)]
		public unsafe virtual bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskScheduler.NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Abstract_Virtual_New_Boolean_Task_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x000F2564 File Offset: 0x000F0764
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207420, RefRangeEnd = 207423, XrefRangeStart = 207418, XrefRangeEnd = 207420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryRunInline(Task task, bool taskWasPreviouslyQueued)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_TryRunInline_Internal_Boolean_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x000F25C0 File Offset: 0x000F07C0
		[CallerCount(0)]
		public unsafe virtual bool TryDequeue(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskScheduler.NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_New_Boolean_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x000F2618 File Offset: 0x000F0818
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyWorkItemProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskScheduler.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06002FAD RID: 12205 RVA: 0x000F2654 File Offset: 0x000F0854
		public unsafe virtual bool RequiresAtomicStartTransition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskScheduler.NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x000F269C File Offset: 0x000F089C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207423, XrefRangeEnd = 207424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalQueueTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_InternalQueueTask_Internal_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x000F26E0 File Offset: 0x000F08E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207447, RefRangeEnd = 207448, XrefRangeStart = 207424, XrefRangeEnd = 207447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskScheduler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x000F271C File Offset: 0x000F091C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207448, XrefRangeEnd = 207465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToActiveTaskSchedulers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_AddToActiveTaskSchedulers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06002FB1 RID: 12209 RVA: 0x000F2750 File Offset: 0x000F0950
		public unsafe static TaskScheduler Default
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207465, XrefRangeEnd = 207469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_get_Default_Public_Static_get_TaskScheduler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06002FB2 RID: 12210 RVA: 0x000F2784 File Offset: 0x000F0984
		public unsafe static TaskScheduler Current
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 207476, RefRangeEnd = 207478, XrefRangeStart = 207469, XrefRangeEnd = 207476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_get_Current_Public_Static_get_TaskScheduler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x000F27B8 File Offset: 0x000F09B8
		public unsafe static TaskScheduler InternalCurrent
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 207485, RefRangeEnd = 207488, XrefRangeStart = 207478, XrefRangeEnd = 207485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_TaskScheduler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002FB4 RID: 12212 RVA: 0x000F27EC File Offset: 0x000F09EC
		public unsafe int Id
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207488, XrefRangeEnd = 207492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x000F2828 File Offset: 0x000F0A28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207505, RefRangeEnd = 207506, XrefRangeStart = 207492, XrefRangeEnd = 207505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PublishUnobservedTaskException(Object sender, UnobservedTaskExceptionEventArgs ueea)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ueea);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_PublishUnobservedTaskException_Internal_Static_Void_Object_UnobservedTaskExceptionEventArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FB6 RID: 12214 RVA: 0x0001080D File Offset: 0x0000EA0D
		public TaskScheduler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x000F2870 File Offset: 0x000F0A70
		// (set) Token: 0x06002FB8 RID: 12216 RVA: 0x00010816 File Offset: 0x0000EA16
		public unsafe static ConditionalWeakTable<TaskScheduler, Object> s_activeTaskSchedulers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaskScheduler.NativeFieldInfoPtr_s_activeTaskSchedulers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<TaskScheduler, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskScheduler.NativeFieldInfoPtr_s_activeTaskSchedulers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06002FB9 RID: 12217 RVA: 0x000F2898 File Offset: 0x000F0A98
		// (set) Token: 0x06002FBA RID: 12218 RVA: 0x00010828 File Offset: 0x0000EA28
		public unsafe static TaskScheduler s_defaultTaskScheduler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaskScheduler.NativeFieldInfoPtr_s_defaultTaskScheduler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskScheduler.NativeFieldInfoPtr_s_defaultTaskScheduler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002FBB RID: 12219 RVA: 0x000F28C0 File Offset: 0x000F0AC0
		// (set) Token: 0x06002FBC RID: 12220 RVA: 0x0001083A File Offset: 0x0000EA3A
		public unsafe static int s_taskSchedulerIdCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TaskScheduler.NativeFieldInfoPtr_s_taskSchedulerIdCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskScheduler.NativeFieldInfoPtr_s_taskSchedulerIdCounter, (void*)(&value));
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002FBD RID: 12221 RVA: 0x000F28DC File Offset: 0x000F0ADC
		// (set) Token: 0x06002FBE RID: 12222 RVA: 0x00010848 File Offset: 0x0000EA48
		public unsafe int m_taskSchedulerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskScheduler.NativeFieldInfoPtr_m_taskSchedulerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskScheduler.NativeFieldInfoPtr_m_taskSchedulerId)) = value;
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002FBF RID: 12223 RVA: 0x000F2904 File Offset: 0x000F0B04
		// (set) Token: 0x06002FC0 RID: 12224 RVA: 0x00010863 File Offset: 0x0000EA63
		public unsafe static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaskScheduler.NativeFieldInfoPtr__unobservedTaskException, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<UnobservedTaskExceptionEventArgs>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskScheduler.NativeFieldInfoPtr__unobservedTaskException, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06002FC1 RID: 12225 RVA: 0x000F292C File Offset: 0x000F0B2C
		// (set) Token: 0x06002FC2 RID: 12226 RVA: 0x00010875 File Offset: 0x0000EA75
		public unsafe static Object _unobservedTaskExceptionLockObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaskScheduler.NativeFieldInfoPtr__unobservedTaskExceptionLockObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskScheduler.NativeFieldInfoPtr__unobservedTaskExceptionLockObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002937 RID: 10551
		private static readonly IntPtr NativeFieldInfoPtr_s_activeTaskSchedulers;

		// Token: 0x04002938 RID: 10552
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultTaskScheduler;

		// Token: 0x04002939 RID: 10553
		private static readonly IntPtr NativeFieldInfoPtr_s_taskSchedulerIdCounter;

		// Token: 0x0400293A RID: 10554
		private static readonly IntPtr NativeFieldInfoPtr_m_taskSchedulerId;

		// Token: 0x0400293B RID: 10555
		private static readonly IntPtr NativeFieldInfoPtr__unobservedTaskException;

		// Token: 0x0400293C RID: 10556
		private static readonly IntPtr NativeFieldInfoPtr__unobservedTaskExceptionLockObject;

		// Token: 0x0400293D RID: 10557
		private static readonly IntPtr NativeMethodInfoPtr_QueueTask_FamOrAssem_Abstract_Virtual_New_Void_Task_0;

		// Token: 0x0400293E RID: 10558
		private static readonly IntPtr NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Abstract_Virtual_New_Boolean_Task_Boolean_0;

		// Token: 0x0400293F RID: 10559
		private static readonly IntPtr NativeMethodInfoPtr_TryRunInline_Internal_Boolean_Task_Boolean_0;

		// Token: 0x04002940 RID: 10560
		private static readonly IntPtr NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_New_Boolean_Task_0;

		// Token: 0x04002941 RID: 10561
		private static readonly IntPtr NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_New_Void_0;

		// Token: 0x04002942 RID: 10562
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x04002943 RID: 10563
		private static readonly IntPtr NativeMethodInfoPtr_InternalQueueTask_Internal_Void_Task_0;

		// Token: 0x04002944 RID: 10564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002945 RID: 10565
		private static readonly IntPtr NativeMethodInfoPtr_AddToActiveTaskSchedulers_Private_Void_0;

		// Token: 0x04002946 RID: 10566
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_TaskScheduler_0;

		// Token: 0x04002947 RID: 10567
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Static_get_TaskScheduler_0;

		// Token: 0x04002948 RID: 10568
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_TaskScheduler_0;

		// Token: 0x04002949 RID: 10569
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x0400294A RID: 10570
		private static readonly IntPtr NativeMethodInfoPtr_PublishUnobservedTaskException_Internal_Static_Void_Object_UnobservedTaskExceptionEventArgs_0;

		// Token: 0x0200061C RID: 1564
		public sealed class SystemThreadingTasks_TaskSchedulerDebugView : Object
		{
			// Token: 0x0600552A RID: 21802 RVA: 0x00020373 File Offset: 0x0001E573
			// Note: this type is marked as 'beforefieldinit'.
			static SystemThreadingTasks_TaskSchedulerDebugView()
			{
				Il2CppClassPointerStore<TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "SystemThreadingTasks_TaskSchedulerDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView>.NativeClassPtr);
			}

			// Token: 0x0600552B RID: 21803 RVA: 0x00020393 File Offset: 0x0001E593
			public SystemThreadingTasks_TaskSchedulerDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
