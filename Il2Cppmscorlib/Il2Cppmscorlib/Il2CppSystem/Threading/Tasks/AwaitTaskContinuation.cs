using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B8 RID: 696
	public class AwaitTaskContinuation : TaskContinuation
	{
		// Token: 0x06002F60 RID: 12128 RVA: 0x000F1044 File Offset: 0x000EF244
		// Note: this type is marked as 'beforefieldinit'.
		static AwaitTaskContinuation()
		{
			Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "AwaitTaskContinuation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr);
			AwaitTaskContinuation.NativeFieldInfoPtr_m_capturedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, "m_capturedContext");
			AwaitTaskContinuation.NativeFieldInfoPtr_m_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, "m_action");
			AwaitTaskContinuation.NativeFieldInfoPtr_s_invokeActionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, "s_invokeActionCallback");
			AwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670847);
			AwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670848);
			AwaitTaskContinuation.NativeMethodInfoPtr_CreateTask_Protected_Task_Action_1_Object_Object_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670849);
			AwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670850);
			AwaitTaskContinuation.NativeMethodInfoPtr_get_IsValidLocationForInlining_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670851);
			AwaitTaskContinuation.NativeMethodInfoPtr_ExecuteWorkItemHelper_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670852);
			AwaitTaskContinuation.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670853);
			AwaitTaskContinuation.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670854);
			AwaitTaskContinuation.NativeMethodInfoPtr_InvokeAction_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670855);
			AwaitTaskContinuation.NativeMethodInfoPtr_GetInvokeActionCallback_Protected_Static_ContextCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670856);
			AwaitTaskContinuation.NativeMethodInfoPtr_RunCallback_Protected_Void_ContextCallback_Object_byref_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670857);
			AwaitTaskContinuation.NativeMethodInfoPtr_RunOrScheduleAction_Internal_Static_Void_Action_Boolean_byref_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670858);
			AwaitTaskContinuation.NativeMethodInfoPtr_UnsafeScheduleAction_Internal_Static_Void_Action_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670859);
			AwaitTaskContinuation.NativeMethodInfoPtr_ThrowAsyncIfNecessary_Protected_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670860);
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x000F11C8 File Offset: 0x000EF3C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 206951, RefRangeEnd = 206956, XrefRangeStart = 206947, XrefRangeEnd = 206951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AwaitTaskContinuation(Action action, bool flowExecutionContext, ref StackCrawlMark stackMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowExecutionContext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x000F1230 File Offset: 0x000EF430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206956, XrefRangeEnd = 206960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AwaitTaskContinuation(Action action, bool flowExecutionContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowExecutionContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x000F128C File Offset: 0x000EF48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206960, XrefRangeEnd = 206966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task CreateTask(Action<Object> action, Object state, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_CreateTask_Protected_Task_Action_1_Object_Object_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x000F1300 File Offset: 0x000EF500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206966, XrefRangeEnd = 206974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Run(Task task, bool canInlineContinuationTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canInlineContinuationTask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06002F65 RID: 12133 RVA: 0x000F135C File Offset: 0x000EF55C
		public unsafe static bool IsValidLocationForInlining
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 206983, RefRangeEnd = 206986, XrefRangeStart = 206974, XrefRangeEnd = 206983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_get_IsValidLocationForInlining_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x000F138C File Offset: 0x000EF58C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206994, RefRangeEnd = 206995, XrefRangeStart = 206986, XrefRangeEnd = 206994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteWorkItemHelper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_ExecuteWorkItemHelper_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x000F13C0 File Offset: 0x000EF5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206995, XrefRangeEnd = 206998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x000F13F4 File Offset: 0x000EF5F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_MarkAborted(ThreadAbortException tae)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x000F1438 File Offset: 0x000EF638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206998, XrefRangeEnd = 207003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeAction(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_InvokeAction_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x000F1470 File Offset: 0x000EF670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207003, XrefRangeEnd = 207011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContextCallback GetInvokeActionCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_GetInvokeActionCallback_Protected_Static_ContextCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr3) : null;
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x000F14A4 File Offset: 0x000EF6A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207021, RefRangeEnd = 207024, XrefRangeStart = 207011, XrefRangeEnd = 207021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunCallback(ContextCallback callback, Object state, ref Task currentTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentTask);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_RunCallback_Protected_Void_ContextCallback_Object_byref_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			currentTask = ((intPtr4 == 0) ? null : new Task(intPtr4));
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x000F1520 File Offset: 0x000EF720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207024, XrefRangeEnd = 207033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowInlining;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentTask);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_RunOrScheduleAction_Internal_Static_Void_Action_Boolean_byref_Task_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			currentTask = ((intPtr4 == 0) ? null : new Task(intPtr4));
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x000F158C File Offset: 0x000EF78C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207038, RefRangeEnd = 207040, XrefRangeStart = 207033, XrefRangeEnd = 207038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnsafeScheduleAction(Action action, Task task)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(task);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_UnsafeScheduleAction_Internal_Static_Void_Action_Task_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x000F15D4 File Offset: 0x000EF7D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207060, RefRangeEnd = 207063, XrefRangeStart = 207040, XrefRangeEnd = 207060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowAsyncIfNecessary(Exception exc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_ThrowAsyncIfNecessary_Protected_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x00010679 File Offset: 0x0000E879
		public AwaitTaskContinuation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06002F70 RID: 12144 RVA: 0x000F160C File Offset: 0x000EF80C
		// (set) Token: 0x06002F71 RID: 12145 RVA: 0x00010682 File Offset: 0x0000E882
		public unsafe ExecutionContext m_capturedContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaitTaskContinuation.NativeFieldInfoPtr_m_capturedContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaitTaskContinuation.NativeFieldInfoPtr_m_capturedContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06002F72 RID: 12146 RVA: 0x000F163C File Offset: 0x000EF83C
		// (set) Token: 0x06002F73 RID: 12147 RVA: 0x000106A1 File Offset: 0x0000E8A1
		public unsafe Action m_action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaitTaskContinuation.NativeFieldInfoPtr_m_action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaitTaskContinuation.NativeFieldInfoPtr_m_action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06002F74 RID: 12148 RVA: 0x000F166C File Offset: 0x000EF86C
		// (set) Token: 0x06002F75 RID: 12149 RVA: 0x000106C0 File Offset: 0x0000E8C0
		public unsafe static ContextCallback s_invokeActionCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AwaitTaskContinuation.NativeFieldInfoPtr_s_invokeActionCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AwaitTaskContinuation.NativeFieldInfoPtr_s_invokeActionCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002904 RID: 10500
		private static readonly IntPtr NativeFieldInfoPtr_m_capturedContext;

		// Token: 0x04002905 RID: 10501
		private static readonly IntPtr NativeFieldInfoPtr_m_action;

		// Token: 0x04002906 RID: 10502
		private static readonly IntPtr NativeFieldInfoPtr_s_invokeActionCallback;

		// Token: 0x04002907 RID: 10503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04002908 RID: 10504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_0;

		// Token: 0x04002909 RID: 10505
		private static readonly IntPtr NativeMethodInfoPtr_CreateTask_Protected_Task_Action_1_Object_Object_TaskScheduler_0;

		// Token: 0x0400290A RID: 10506
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0;

		// Token: 0x0400290B RID: 10507
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValidLocationForInlining_Internal_Static_get_Boolean_0;

		// Token: 0x0400290C RID: 10508
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteWorkItemHelper_Private_Void_0;

		// Token: 0x0400290D RID: 10509
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400290E RID: 10510
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0;

		// Token: 0x0400290F RID: 10511
		private static readonly IntPtr NativeMethodInfoPtr_InvokeAction_Private_Static_Void_Object_0;

		// Token: 0x04002910 RID: 10512
		private static readonly IntPtr NativeMethodInfoPtr_GetInvokeActionCallback_Protected_Static_ContextCallback_0;

		// Token: 0x04002911 RID: 10513
		private static readonly IntPtr NativeMethodInfoPtr_RunCallback_Protected_Void_ContextCallback_Object_byref_Task_0;

		// Token: 0x04002912 RID: 10514
		private static readonly IntPtr NativeMethodInfoPtr_RunOrScheduleAction_Internal_Static_Void_Action_Boolean_byref_Task_0;

		// Token: 0x04002913 RID: 10515
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeScheduleAction_Internal_Static_Void_Action_Task_0;

		// Token: 0x04002914 RID: 10516
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAsyncIfNecessary_Protected_Static_Void_Exception_0;

		// Token: 0x02000617 RID: 1559
		[ObfuscatedName("System.Threading.Tasks.AwaitTaskContinuation+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005517 RID: 21783 RVA: 0x0017DB2C File Offset: 0x0017BD2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AwaitTaskContinuation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AwaitTaskContinuation.__c>.NativeClassPtr);
				AwaitTaskContinuation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitTaskContinuation.__c>.NativeClassPtr, "<>9");
				AwaitTaskContinuation.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitTaskContinuation.__c>.NativeClassPtr, "<>9__17_0");
				AwaitTaskContinuation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation.__c>.NativeClassPtr, 100670862);
				AwaitTaskContinuation.__c.NativeMethodInfoPtr__ThrowAsyncIfNecessary_b__17_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation.__c>.NativeClassPtr, 100670863);
			}

			// Token: 0x06005518 RID: 21784 RVA: 0x0017DBA8 File Offset: 0x0017BDA8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AwaitTaskContinuation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005519 RID: 21785 RVA: 0x0017DBE4 File Offset: 0x0017BDE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206940, XrefRangeEnd = 206947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ThrowAsyncIfNecessary_b__17_0(Object s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.__c.NativeMethodInfoPtr__ThrowAsyncIfNecessary_b__17_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600551A RID: 21786 RVA: 0x00020303 File Offset: 0x0001E503
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015D2 RID: 5586
			// (get) Token: 0x0600551B RID: 21787 RVA: 0x0017DC28 File Offset: 0x0017BE28
			// (set) Token: 0x0600551C RID: 21788 RVA: 0x0002030C File Offset: 0x0001E50C
			public unsafe static AwaitTaskContinuation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AwaitTaskContinuation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AwaitTaskContinuation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AwaitTaskContinuation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015D3 RID: 5587
			// (get) Token: 0x0600551D RID: 21789 RVA: 0x0017DC50 File Offset: 0x0017BE50
			// (set) Token: 0x0600551E RID: 21790 RVA: 0x0002031E File Offset: 0x0001E51E
			public unsafe static WaitCallback __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AwaitTaskContinuation.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AwaitTaskContinuation.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044C4 RID: 17604
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040044C5 RID: 17605
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x040044C6 RID: 17606
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040044C7 RID: 17607
			private static readonly IntPtr NativeMethodInfoPtr__ThrowAsyncIfNecessary_b__17_0_Internal_Void_Object_0;
		}
	}
}
