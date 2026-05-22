using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.ExceptionServices;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A6 RID: 678
	public class Task : Object
	{
		// Token: 0x06002E23 RID: 11811 RVA: 0x000EC044 File Offset: 0x000EA244
		// Note: this type is marked as 'beforefieldinit'.
		static Task()
		{
			Il2CppClassPointerStore<Task>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "Task");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task>.NativeClassPtr);
			Task.NativeFieldInfoPtr_t_currentTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "t_currentTask");
			Task.NativeFieldInfoPtr_t_stackGuard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "t_stackGuard");
			Task.NativeFieldInfoPtr_s_taskIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_taskIdCounter");
			Task.NativeFieldInfoPtr_s_factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_factory");
			Task.NativeFieldInfoPtr_m_taskId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_taskId");
			Task.NativeFieldInfoPtr_m_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_action");
			Task.NativeFieldInfoPtr_m_stateObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_stateObject");
			Task.NativeFieldInfoPtr_m_taskScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_taskScheduler");
			Task.NativeFieldInfoPtr_m_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_parent");
			Task.NativeFieldInfoPtr_m_stateFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_stateFlags");
			Task.NativeFieldInfoPtr_OptionsMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "OptionsMask");
			Task.NativeFieldInfoPtr_TASK_STATE_STARTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_STARTED");
			Task.NativeFieldInfoPtr_TASK_STATE_DELEGATE_INVOKED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_DELEGATE_INVOKED");
			Task.NativeFieldInfoPtr_TASK_STATE_DISPOSED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_DISPOSED");
			Task.NativeFieldInfoPtr_TASK_STATE_EXCEPTIONOBSERVEDBYPARENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_EXCEPTIONOBSERVEDBYPARENT");
			Task.NativeFieldInfoPtr_TASK_STATE_CANCELLATIONACKNOWLEDGED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_CANCELLATIONACKNOWLEDGED");
			Task.NativeFieldInfoPtr_TASK_STATE_FAULTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_FAULTED");
			Task.NativeFieldInfoPtr_TASK_STATE_CANCELED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_CANCELED");
			Task.NativeFieldInfoPtr_TASK_STATE_WAITING_ON_CHILDREN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_WAITING_ON_CHILDREN");
			Task.NativeFieldInfoPtr_TASK_STATE_RAN_TO_COMPLETION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_RAN_TO_COMPLETION");
			Task.NativeFieldInfoPtr_TASK_STATE_WAITINGFORACTIVATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_WAITINGFORACTIVATION");
			Task.NativeFieldInfoPtr_TASK_STATE_COMPLETION_RESERVED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_COMPLETION_RESERVED");
			Task.NativeFieldInfoPtr_TASK_STATE_THREAD_WAS_ABORTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_THREAD_WAS_ABORTED");
			Task.NativeFieldInfoPtr_TASK_STATE_WAIT_COMPLETION_NOTIFICATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_WAIT_COMPLETION_NOTIFICATION");
			Task.NativeFieldInfoPtr_TASK_STATE_EXECUTIONCONTEXT_IS_NULL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_EXECUTIONCONTEXT_IS_NULL");
			Task.NativeFieldInfoPtr_TASK_STATE_TASKSCHEDULED_WAS_FIRED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_TASKSCHEDULED_WAS_FIRED");
			Task.NativeFieldInfoPtr_TASK_STATE_COMPLETED_MASK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "TASK_STATE_COMPLETED_MASK");
			Task.NativeFieldInfoPtr_CANCELLATION_REQUESTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "CANCELLATION_REQUESTED");
			Task.NativeFieldInfoPtr_m_continuationObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_continuationObject");
			Task.NativeFieldInfoPtr_s_taskCompletionSentinel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_taskCompletionSentinel");
			Task.NativeFieldInfoPtr_s_asyncDebuggingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_asyncDebuggingEnabled");
			Task.NativeFieldInfoPtr_s_currentActiveTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_currentActiveTasks");
			Task.NativeFieldInfoPtr_s_activeTasksLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_activeTasksLock");
			Task.NativeFieldInfoPtr_m_contingentProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_contingentProperties");
			Task.NativeFieldInfoPtr_s_taskCancelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_taskCancelCallback");
			Task.NativeFieldInfoPtr_s_createContingentProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_createContingentProperties");
			Task.NativeFieldInfoPtr_s_completedTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_completedTask");
			Task.NativeFieldInfoPtr_s_IsExceptionObservedByParentPredicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_IsExceptionObservedByParentPredicate");
			Task.NativeFieldInfoPtr_s_ecCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_ecCallback");
			Task.NativeFieldInfoPtr_s_IsTaskContinuationNullPredicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_IsTaskContinuationNullPredicate");
			Task.NativeMethodInfoPtr_AddToActiveTasks_Internal_Static_Boolean_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670648);
			Task.NativeMethodInfoPtr_RemoveFromActiveTasks_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670649);
			Task.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TaskCreationOptions_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670650);
			Task.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670651);
			Task.NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670652);
			Task.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670653);
			Task.NativeMethodInfoPtr_TaskConstructorCore_Internal_Void_Object_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670654);
			Task.NativeMethodInfoPtr_AssignCancellationToken_Private_Void_CancellationToken_Task_TaskContinuation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670655);
			Task.NativeMethodInfoPtr_TaskCancelCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670656);
			Task.NativeMethodInfoPtr_PossiblyCaptureContext_Internal_Void_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670657);
			Task.NativeMethodInfoPtr_get_Options_Internal_get_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670658);
			Task.NativeMethodInfoPtr_OptionsMethod_Internal_Static_TaskCreationOptions_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670659);
			Task.NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670660);
			Task.NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670661);
			Task.NativeMethodInfoPtr_SetNotificationForWaitCompletion_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670662);
			Task.NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletionIfNecessary_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670663);
			Task.NativeMethodInfoPtr_get_IsWaitNotificationEnabledOrNotRanToCompletion_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670664);
			Task.NativeMethodInfoPtr_get_ShouldNotifyDebuggerOfWaitCompletion_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670665);
			Task.NativeMethodInfoPtr_get_IsWaitNotificationEnabled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670666);
			Task.NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670667);
			Task.NativeMethodInfoPtr_MarkStarted_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670668);
			Task.NativeMethodInfoPtr_FireTaskScheduledIfNeeded_Internal_Boolean_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670669);
			Task.NativeMethodInfoPtr_AddNewChild_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670670);
			Task.NativeMethodInfoPtr_DisregardChild_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670671);
			Task.NativeMethodInfoPtr_InternalStartNew_Internal_Static_Task_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670672);
			Task.NativeMethodInfoPtr_NewId_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670673);
			Task.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670674);
			Task.NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670675);
			Task.NativeMethodInfoPtr_InternalCurrentIfAttached_Internal_Static_Task_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670676);
			Task.NativeMethodInfoPtr_get_CurrentStackGuard_Internal_Static_get_StackGuard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670677);
			Task.NativeMethodInfoPtr_get_Exception_Public_get_AggregateException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670678);
			Task.NativeMethodInfoPtr_get_Status_Public_get_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670679);
			Task.NativeMethodInfoPtr_get_IsCanceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670680);
			Task.NativeMethodInfoPtr_get_IsCancellationRequested_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670681);
			Task.NativeMethodInfoPtr_EnsureContingentPropertiesInitialized_Internal_ContingentProperties_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670682);
			Task.NativeMethodInfoPtr_EnsureContingentPropertiesInitializedCore_Private_ContingentProperties_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670683);
			Task.NativeMethodInfoPtr_get_CancellationToken_Internal_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670684);
			Task.NativeMethodInfoPtr_get_IsCancellationAcknowledged_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670685);
			Task.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670686);
			Task.NativeMethodInfoPtr_IsCompletedMethod_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670687);
			Task.NativeMethodInfoPtr_get_IsRanToCompletion_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670688);
			Task.NativeMethodInfoPtr_get_CreationOptions_Public_get_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670689);
			Task.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670690);
			Task.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670691);
			Task.NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670692);
			Task.NativeMethodInfoPtr_get_ExecutingTaskScheduler_Internal_get_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670693);
			Task.NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670694);
			Task.NativeMethodInfoPtr_get_CompletedTask_Public_Static_get_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670695);
			Task.NativeMethodInfoPtr_get_CompletedEvent_Internal_get_ManualResetEventSlim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670696);
			Task.NativeMethodInfoPtr_get_IsSelfReplicatingRoot_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670697);
			Task.NativeMethodInfoPtr_get_IsChildReplica_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670698);
			Task.NativeMethodInfoPtr_get_ExceptionRecorded_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670699);
			Task.NativeMethodInfoPtr_get_IsFaulted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670700);
			Task.NativeMethodInfoPtr_get_CapturedContext_Internal_get_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670701);
			Task.NativeMethodInfoPtr_set_CapturedContext_Internal_set_Void_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670702);
			Task.NativeMethodInfoPtr_CopyExecutionContext_Private_Static_ExecutionContext_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670703);
			Task.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670704);
			Task.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670705);
			Task.NativeMethodInfoPtr_ScheduleAndStart_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670706);
			Task.NativeMethodInfoPtr_AddException_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670707);
			Task.NativeMethodInfoPtr_AddException_Internal_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670708);
			Task.NativeMethodInfoPtr_GetExceptions_Private_AggregateException_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670709);
			Task.NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670710);
			Task.NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670711);
			Task.NativeMethodInfoPtr_ThrowIfExceptional_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670712);
			Task.NativeMethodInfoPtr_UpdateExceptionObservedStatus_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670713);
			Task.NativeMethodInfoPtr_get_IsExceptionObservedByParent_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670714);
			Task.NativeMethodInfoPtr_get_IsDelegateInvoked_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670715);
			Task.NativeMethodInfoPtr_Finish_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670716);
			Task.NativeMethodInfoPtr_FinishStageTwo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670717);
			Task.NativeMethodInfoPtr_FinishStageThree_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670718);
			Task.NativeMethodInfoPtr_ProcessChildCompletion_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670719);
			Task.NativeMethodInfoPtr_AddExceptionsFromChildren_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670720);
			Task.NativeMethodInfoPtr_FinishThreadAbortedTask_Internal_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670721);
			Task.NativeMethodInfoPtr_Execute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670722);
			Task.NativeMethodInfoPtr_ShouldReplicate_Internal_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670723);
			Task.NativeMethodInfoPtr_CreateReplicaTask_Internal_Virtual_New_Task_Action_1_Object_Object_Task_TaskScheduler_TaskCreationOptions_InternalTaskOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670724);
			Task.NativeMethodInfoPtr_get_SavedStateForNextReplica_Internal_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670725);
			Task.NativeMethodInfoPtr_set_SavedStateFromPreviousReplica_Internal_Virtual_New_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670726);
			Task.NativeMethodInfoPtr_get_HandedOverChildReplica_Internal_Virtual_New_get_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670727);
			Task.NativeMethodInfoPtr_set_HandedOverChildReplica_Internal_Virtual_New_set_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670728);
			Task.NativeMethodInfoPtr_ExecuteSelfReplicating_Private_Static_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670729);
			Task.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670730);
			Task.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670731);
			Task.NativeMethodInfoPtr_ExecuteEntry_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670732);
			Task.NativeMethodInfoPtr_ExecuteWithThreadLocal_Private_Void_byref_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670733);
			Task.NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670734);
			Task.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670735);
			Task.NativeMethodInfoPtr_InnerInvokeWithArg_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670736);
			Task.NativeMethodInfoPtr_HandleException_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670737);
			Task.NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670738);
			Task.NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670739);
			Task.NativeMethodInfoPtr_SetContinuationForAwait_Internal_Void_Action_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670740);
			Task.NativeMethodInfoPtr_Wait_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670741);
			Task.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670742);
			Task.NativeMethodInfoPtr_WrappedTryRunInline_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670743);
			Task.NativeMethodInfoPtr_InternalWait_Internal_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670744);
			Task.NativeMethodInfoPtr_SpinThenBlockingWait_Private_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670745);
			Task.NativeMethodInfoPtr_SpinWait_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670746);
			Task.NativeMethodInfoPtr_InternalCancel_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670747);
			Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670748);
			Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670749);
			Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670750);
			Task.NativeMethodInfoPtr_CancellationCleanupLogic_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670751);
			Task.NativeMethodInfoPtr_SetCancellationAcknowledged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670752);
			Task.NativeMethodInfoPtr_FinishContinuations_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670753);
			Task.NativeMethodInfoPtr_LogFinishCompletionNotification_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670754);
			Task.NativeMethodInfoPtr_ContinueWith_Public_Task_Action_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670755);
			Task.NativeMethodInfoPtr_ContinueWith_Private_Task_Action_1_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670756);
			Task.NativeMethodInfoPtr_ContinueWith_Public_Task_Action_2_Task_Object_Object_CancellationToken_TaskContinuationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670757);
			Task.NativeMethodInfoPtr_ContinueWith_Private_Task_Action_2_Task_Object_Object_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670758);
			Task.NativeMethodInfoPtr_CreationOptionsFromContinuationOptions_Internal_Static_Void_TaskContinuationOptions_byref_TaskCreationOptions_byref_InternalTaskOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670759);
			Task.NativeMethodInfoPtr_ContinueWithCore_Internal_Void_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670760);
			Task.NativeMethodInfoPtr_AddCompletionAction_Internal_Void_ITaskCompletionAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670761);
			Task.NativeMethodInfoPtr_AddCompletionAction_Private_Void_ITaskCompletionAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670762);
			Task.NativeMethodInfoPtr_AddTaskContinuationComplex_Private_Boolean_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670763);
			Task.NativeMethodInfoPtr_AddTaskContinuation_Private_Boolean_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670764);
			Task.NativeMethodInfoPtr_RemoveContinuation_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670765);
			Task.NativeMethodInfoPtr_FromResult_Public_Static_Task_1_TResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670766);
			Task.NativeMethodInfoPtr_FromException_Public_Static_Task_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670767);
			Task.NativeMethodInfoPtr_FromException_Public_Static_Task_1_TResult_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670768);
			Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670769);
			Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670770);
			Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_OperationCanceledException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670771);
			Task.NativeMethodInfoPtr_Run_Public_Static_Task_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670772);
			Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670773);
			Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670774);
			Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670775);
			Task.NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670776);
			Task.NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670777);
			Task.NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_Il2CppReferenceArray_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670778);
			Task.NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_IEnumerable_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670779);
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x000ECDE4 File Offset: 0x000EAFE4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 205420, RefRangeEnd = 205431, XrefRangeStart = 205407, XrefRangeEnd = 205420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddToActiveTasks(Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddToActiveTasks_Internal_Static_Boolean_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x000ECE28 File Offset: 0x000EB028
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 205444, RefRangeEnd = 205451, XrefRangeStart = 205431, XrefRangeEnd = 205444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveFromActiveTasks(int taskId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref taskId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_RemoveFromActiveTasks_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x000ECE5C File Offset: 0x000EB05C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205455, RefRangeEnd = 205457, XrefRangeStart = 205451, XrefRangeEnd = 205455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canceled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ct));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TaskCreationOptions_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x000ECEC8 File Offset: 0x000EB0C8
		[CallerCount(0)]
		public unsafe Task()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x000ECF04 File Offset: 0x000EB104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205463, RefRangeEnd = 205464, XrefRangeStart = 205457, XrefRangeEnd = 205463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Object state, TaskCreationOptions creationOptions, bool promiseStyle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref promiseStyle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x000ECF6C File Offset: 0x000EB16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205464, XrefRangeEnd = 205472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Delegate action, Object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x000ED024 File Offset: 0x000EB224
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 205476, RefRangeEnd = 205486, XrefRangeStart = 205472, XrefRangeEnd = 205476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TaskConstructorCore(Object action, Object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_TaskConstructorCore_Internal_Void_Object_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x000ED0C0 File Offset: 0x000EB2C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 205515, RefRangeEnd = 205518, XrefRangeStart = 205486, XrefRangeEnd = 205515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(antecedent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AssignCancellationToken_Private_Void_CancellationToken_Task_TaskContinuation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x000ED12C File Offset: 0x000EB32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205518, XrefRangeEnd = 205528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TaskCancelCallback(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_TaskCancelCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x000ED164 File Offset: 0x000EB364
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 205533, RefRangeEnd = 205540, XrefRangeStart = 205528, XrefRangeEnd = 205533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PossiblyCaptureContext(ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &stackMark;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_PossiblyCaptureContext_Internal_Void_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002E2E RID: 11822 RVA: 0x000ED1A4 File Offset: 0x000EB3A4
		public unsafe TaskCreationOptions Options
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205540, XrefRangeEnd = 205543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_Options_Internal_get_TaskCreationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x000ED1E0 File Offset: 0x000EB3E0
		[CallerCount(0)]
		public unsafe static TaskCreationOptions OptionsMethod(int flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_OptionsMethod_Internal_Static_TaskCreationOptions_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x000ED220 File Offset: 0x000EB420
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 205544, RefRangeEnd = 205559, XrefRangeStart = 205543, XrefRangeEnd = 205544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AtomicStateUpdate(int newBits, int illegalBits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref illegalBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x000ED278 File Offset: 0x000EB478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205559, XrefRangeEnd = 205560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref illegalBits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &oldFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x000ED2E0 File Offset: 0x000EB4E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205563, RefRangeEnd = 205564, XrefRangeStart = 205560, XrefRangeEnd = 205563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNotificationForWaitCompletion(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_SetNotificationForWaitCompletion_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x000ED320 File Offset: 0x000EB520
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205565, RefRangeEnd = 205567, XrefRangeStart = 205564, XrefRangeEnd = 205565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NotifyDebuggerOfWaitCompletionIfNecessary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletionIfNecessary_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002E34 RID: 11828 RVA: 0x000ED35C File Offset: 0x000EB55C
		public unsafe bool IsWaitNotificationEnabledOrNotRanToCompletion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsWaitNotificationEnabledOrNotRanToCompletion_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002E35 RID: 11829 RVA: 0x000ED398 File Offset: 0x000EB598
		public unsafe virtual bool ShouldNotifyDebuggerOfWaitCompletion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_get_ShouldNotifyDebuggerOfWaitCompletion_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002E36 RID: 11830 RVA: 0x000ED3E0 File Offset: 0x000EB5E0
		public unsafe bool IsWaitNotificationEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsWaitNotificationEnabled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x000ED41C File Offset: 0x000EB61C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 205568, RefRangeEnd = 205573, XrefRangeStart = 205567, XrefRangeEnd = 205568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyDebuggerOfWaitCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x000ED450 File Offset: 0x000EB650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205573, XrefRangeEnd = 205574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MarkStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_MarkStarted_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x000ED48C File Offset: 0x000EB68C
		[CallerCount(0)]
		public unsafe bool FireTaskScheduledIfNeeded(TaskScheduler ts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FireTaskScheduledIfNeeded_Internal_Boolean_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x000ED4DC File Offset: 0x000EB6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205574, XrefRangeEnd = 205576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNewChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddNewChild_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x000ED510 File Offset: 0x000EB710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205576, XrefRangeEnd = 205577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisregardChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_DisregardChild_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x000ED544 File Offset: 0x000EB744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205577, XrefRangeEnd = 205584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task InternalStartNew(Task creatingTask, Delegate action, Object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(creatingTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_InternalStartNew_Internal_Static_Task_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions_byref_StackCrawlMark_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x000ED604 File Offset: 0x000EB804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205584, XrefRangeEnd = 205588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NewId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_NewId_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002E3E RID: 11838 RVA: 0x000ED634 File Offset: 0x000EB834
		public unsafe int Id
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 205596, RefRangeEnd = 205605, XrefRangeStart = 205588, XrefRangeEnd = 205596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002E3F RID: 11839 RVA: 0x000ED670 File Offset: 0x000EB870
		public unsafe static Task InternalCurrent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205605, XrefRangeEnd = 205610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x000ED6A4 File Offset: 0x000EB8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205610, XrefRangeEnd = 205614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref creationOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_InternalCurrentIfAttached_Internal_Static_Task_TaskCreationOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002E41 RID: 11841 RVA: 0x000ED6E4 File Offset: 0x000EB8E4
		public unsafe static StackGuard CurrentStackGuard
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 205626, RefRangeEnd = 205627, XrefRangeStart = 205614, XrefRangeEnd = 205626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CurrentStackGuard_Internal_Static_get_StackGuard_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StackGuard>(intPtr3) : null;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002E42 RID: 11842 RVA: 0x000ED718 File Offset: 0x000EB918
		public unsafe AggregateException Exception
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205627, XrefRangeEnd = 205628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_Exception_Public_get_AggregateException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AggregateException>(intPtr3) : null;
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002E43 RID: 11843 RVA: 0x000ED758 File Offset: 0x000EB958
		public unsafe TaskStatus Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_Status_Public_get_TaskStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06002E44 RID: 11844 RVA: 0x000ED794 File Offset: 0x000EB994
		public unsafe bool IsCanceled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsCanceled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x000ED7D0 File Offset: 0x000EB9D0
		public unsafe bool IsCancellationRequested
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsCancellationRequested_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x000ED80C File Offset: 0x000EBA0C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 205633, RefRangeEnd = 205649, XrefRangeStart = 205628, XrefRangeEnd = 205633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needsProtection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_EnsureContingentPropertiesInitialized_Internal_ContingentProperties_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task.ContingentProperties>(intPtr3) : null;
			}
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x000ED858 File Offset: 0x000EBA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205649, XrefRangeEnd = 205654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needsProtection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_EnsureContingentPropertiesInitializedCore_Private_ContingentProperties_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task.ContingentProperties>(intPtr3) : null;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002E48 RID: 11848 RVA: 0x000ED8A4 File Offset: 0x000EBAA4
		public unsafe CancellationToken CancellationToken
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CancellationToken_Internal_get_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationToken(intPtr);
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x000ED8DC File Offset: 0x000EBADC
		public unsafe bool IsCancellationAcknowledged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsCancellationAcknowledged_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002E4A RID: 11850 RVA: 0x000ED918 File Offset: 0x000EBB18
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 205657, RefRangeEnd = 205670, XrefRangeStart = 205654, XrefRangeEnd = 205657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x000ED954 File Offset: 0x000EBB54
		[CallerCount(0)]
		public unsafe static bool IsCompletedMethod(int flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_IsCompletedMethod_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06002E4C RID: 11852 RVA: 0x000ED994 File Offset: 0x000EBB94
		public unsafe bool IsRanToCompletion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsRanToCompletion_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x000ED9D0 File Offset: 0x000EBBD0
		public unsafe TaskCreationOptions CreationOptions
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 205673, RefRangeEnd = 205675, XrefRangeStart = 205670, XrefRangeEnd = 205673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CreationOptions_Public_get_TaskCreationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002E4E RID: 11854 RVA: 0x000EDA0C File Offset: 0x000EBC0C
		public unsafe virtual WaitHandle System.IAsyncResult.AsyncWaitHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205675, XrefRangeEnd = 205678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x000EDA4C File Offset: 0x000EBC4C
		public unsafe virtual Object AsyncState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06002E50 RID: 11856 RVA: 0x000EDA8C File Offset: 0x000EBC8C
		public unsafe virtual bool System.IAsyncResult.CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x000EDAC8 File Offset: 0x000EBCC8
		public unsafe TaskScheduler ExecutingTaskScheduler
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_ExecutingTaskScheduler_Internal_get_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06002E52 RID: 11858 RVA: 0x000EDB08 File Offset: 0x000EBD08
		public unsafe static TaskFactory Factory
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205678, XrefRangeEnd = 205682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskFactory>(intPtr3) : null;
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x000EDB3C File Offset: 0x000EBD3C
		public unsafe static Task CompletedTask
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 205691, RefRangeEnd = 205692, XrefRangeStart = 205682, XrefRangeEnd = 205691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CompletedTask_Public_Static_get_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06002E54 RID: 11860 RVA: 0x000EDB70 File Offset: 0x000EBD70
		public unsafe ManualResetEventSlim CompletedEvent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 205704, RefRangeEnd = 205705, XrefRangeStart = 205692, XrefRangeEnd = 205704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CompletedEvent_Internal_get_ManualResetEventSlim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManualResetEventSlim>(intPtr3) : null;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x000EDBB0 File Offset: 0x000EBDB0
		public unsafe bool IsSelfReplicatingRoot
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 205708, RefRangeEnd = 205712, XrefRangeStart = 205705, XrefRangeEnd = 205708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsSelfReplicatingRoot_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06002E56 RID: 11862 RVA: 0x000EDBEC File Offset: 0x000EBDEC
		public unsafe bool IsChildReplica
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 205715, RefRangeEnd = 205717, XrefRangeStart = 205712, XrefRangeEnd = 205715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsChildReplica_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x000EDC28 File Offset: 0x000EBE28
		public unsafe bool ExceptionRecorded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_ExceptionRecorded_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06002E58 RID: 11864 RVA: 0x000EDC64 File Offset: 0x000EBE64
		public unsafe bool IsFaulted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsFaulted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06002E59 RID: 11865 RVA: 0x000EDCA0 File Offset: 0x000EBEA0
		// (set) Token: 0x06002E5A RID: 11866 RVA: 0x000EDCE0 File Offset: 0x000EBEE0
		public unsafe ExecutionContext CapturedContext
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 205721, RefRangeEnd = 205723, XrefRangeStart = 205717, XrefRangeEnd = 205721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CapturedContext_Internal_get_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 205724, RefRangeEnd = 205725, XrefRangeStart = 205723, XrefRangeEnd = 205724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_set_CapturedContext_Internal_set_Void_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x000EDD24 File Offset: 0x000EBF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205725, XrefRangeEnd = 205730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capturedContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_CopyExecutionContext_Private_Static_ExecutionContext_ExecutionContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
			}
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x000EDD68 File Offset: 0x000EBF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205730, XrefRangeEnd = 205734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x000EDD9C File Offset: 0x000EBF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205734, XrefRangeEnd = 205741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x000EDDE8 File Offset: 0x000EBFE8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 205754, RefRangeEnd = 205761, XrefRangeStart = 205741, XrefRangeEnd = 205754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduleAndStart(bool needsProtection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needsProtection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ScheduleAndStart_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x000EDE28 File Offset: 0x000EC028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205761, XrefRangeEnd = 205762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddException(Object exceptionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddException_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x000EDE6C File Offset: 0x000EC06C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 205780, RefRangeEnd = 205786, XrefRangeStart = 205762, XrefRangeEnd = 205780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddException(Object exceptionObject, bool representsCancellation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref representsCancellation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddException_Internal_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x000EDEBC File Offset: 0x000EC0BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 205793, RefRangeEnd = 205797, XrefRangeStart = 205786, XrefRangeEnd = 205793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException GetExceptions(bool includeTaskCanceledExceptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeTaskCanceledExceptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_GetExceptions_Private_AggregateException_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AggregateException>(intPtr3) : null;
			}
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x000EDF08 File Offset: 0x000EC108
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205808, RefRangeEnd = 205810, XrefRangeStart = 205797, XrefRangeEnd = 205808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ExceptionDispatchInfo>>(intPtr3) : null;
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x000EDF48 File Offset: 0x000EC148
		[CallerCount(0)]
		public unsafe ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x000EDF88 File Offset: 0x000EC188
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205811, RefRangeEnd = 205813, XrefRangeStart = 205810, XrefRangeEnd = 205811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfExceptional(bool includeTaskCanceledExceptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeTaskCanceledExceptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ThrowIfExceptional_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x000EDFC8 File Offset: 0x000EC1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205813, XrefRangeEnd = 205821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateExceptionObservedStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_UpdateExceptionObservedStatus_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06002E66 RID: 11878 RVA: 0x000EDFFC File Offset: 0x000EC1FC
		public unsafe bool IsExceptionObservedByParent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsExceptionObservedByParent_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x000EE038 File Offset: 0x000EC238
		public unsafe bool IsDelegateInvoked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsDelegateInvoked_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x000EE074 File Offset: 0x000EC274
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 205837, RefRangeEnd = 205841, XrefRangeStart = 205821, XrefRangeEnd = 205837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finish(bool bUserDelegateExecuted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bUserDelegateExecuted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Finish_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x000EE0B4 File Offset: 0x000EC2B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 205855, RefRangeEnd = 205858, XrefRangeStart = 205841, XrefRangeEnd = 205855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishStageTwo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FinishStageTwo_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x000EE0E8 File Offset: 0x000EC2E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 205864, RefRangeEnd = 205870, XrefRangeStart = 205858, XrefRangeEnd = 205864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishStageThree()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FinishStageThree_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x000EE11C File Offset: 0x000EC31C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205884, RefRangeEnd = 205885, XrefRangeStart = 205870, XrefRangeEnd = 205884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessChildCompletion(Task childTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(childTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ProcessChildCompletion_Internal_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x000EE160 File Offset: 0x000EC360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205899, RefRangeEnd = 205900, XrefRangeStart = 205885, XrefRangeEnd = 205899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExceptionsFromChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddExceptionsFromChildren_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x000EE194 File Offset: 0x000EC394
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 205906, RefRangeEnd = 205909, XrefRangeStart = 205900, XrefRangeEnd = 205906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bTAEAddedToExceptionHolder;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delegateRan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FinishThreadAbortedTask_Internal_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x000EE1E0 File Offset: 0x000EC3E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205921, RefRangeEnd = 205923, XrefRangeStart = 205909, XrefRangeEnd = 205921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Execute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x000EE214 File Offset: 0x000EC414
		[CallerCount(0)]
		public unsafe virtual bool ShouldReplicate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_ShouldReplicate_Internal_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x000EE25C File Offset: 0x000EC45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205923, XrefRangeEnd = 205928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task CreateReplicaTask(Action<Object> taskReplicaDelegate, Object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(taskReplicaDelegate);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentTask);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(taskScheduler);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptionsForReplica;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptionsForReplica;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_CreateReplicaTask_Internal_Virtual_New_Task_Action_1_Object_Object_Task_TaskScheduler_TaskCreationOptions_InternalTaskOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06002E71 RID: 11889 RVA: 0x000EE30C File Offset: 0x000EC50C
		public unsafe virtual Object SavedStateForNextReplica
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_get_SavedStateForNextReplica_Internal_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (set) Token: 0x06002E72 RID: 11890 RVA: 0x000EE358 File Offset: 0x000EC558
		public unsafe virtual Object SavedStateFromPreviousReplica
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_set_SavedStateFromPreviousReplica_Internal_Virtual_New_set_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06002E73 RID: 11891 RVA: 0x000EE3A8 File Offset: 0x000EC5A8
		// (set) Token: 0x06002E74 RID: 11892 RVA: 0x000EE3F4 File Offset: 0x000EC5F4
		public unsafe virtual Task HandedOverChildReplica
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_get_HandedOverChildReplica_Internal_Virtual_New_get_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_set_HandedOverChildReplica_Internal_Virtual_New_set_Void_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x000EE444 File Offset: 0x000EC644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205944, RefRangeEnd = 205945, XrefRangeStart = 205928, XrefRangeEnd = 205944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteSelfReplicating(Task root)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ExecuteSelfReplicating_Private_Static_Void_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x000EE47C File Offset: 0x000EC67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205945, XrefRangeEnd = 205946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x000EE4B0 File Offset: 0x000EC6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205946, XrefRangeEnd = 205951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_MarkAborted(ThreadAbortException tae)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x000EE4F4 File Offset: 0x000EC6F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205962, RefRangeEnd = 205964, XrefRangeStart = 205951, XrefRangeEnd = 205962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ExecuteEntry(bool bPreventDoubleExecution)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bPreventDoubleExecution;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ExecuteEntry_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x000EE540 File Offset: 0x000EC740
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205997, RefRangeEnd = 205998, XrefRangeStart = 205964, XrefRangeEnd = 205997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteWithThreadLocal(ref Task currentTaskSlot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentTaskSlot);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ExecuteWithThreadLocal_Private_Void_byref_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				currentTaskSlot = ((intPtr4 == 0) ? null : new Task(intPtr4));
			}
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x000EE598 File Offset: 0x000EC798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205998, XrefRangeEnd = 206002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutionContextCallback(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x000EE5D0 File Offset: 0x000EC7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206002, XrefRangeEnd = 206010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InnerInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x000EE60C File Offset: 0x000EC80C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206011, RefRangeEnd = 206012, XrefRangeStart = 206010, XrefRangeEnd = 206011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InnerInvokeWithArg(Task childTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(childTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_InnerInvokeWithArg_Internal_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x000EE650 File Offset: 0x000EC850
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 206021, RefRangeEnd = 206026, XrefRangeStart = 206012, XrefRangeEnd = 206021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleException(Exception unhandledException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unhandledException);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_HandleException_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x000EE694 File Offset: 0x000EC894
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 206026, RefRangeEnd = 206033, XrefRangeStart = 206026, XrefRangeEnd = 206026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskAwaiter GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new TaskAwaiter(intPtr);
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x000EE6CC File Offset: 0x000EC8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206033, XrefRangeEnd = 206034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref continueOnCapturedContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ConfiguredTaskAwaitable(intPtr);
			}
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x000EE710 File Offset: 0x000EC910
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206065, RefRangeEnd = 206066, XrefRangeStart = 206034, XrefRangeEnd = 206065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowExecutionContext;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_SetContinuationForAwait_Internal_Void_Action_Boolean_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x000EE780 File Offset: 0x000EC980
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 206069, RefRangeEnd = 206074, XrefRangeStart = 206066, XrefRangeEnd = 206069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Wait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Wait_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x000EE7B4 File Offset: 0x000EC9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206074, XrefRangeEnd = 206077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x000EE814 File Offset: 0x000ECA14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206078, RefRangeEnd = 206079, XrefRangeStart = 206077, XrefRangeEnd = 206078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WrappedTryRunInline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_WrappedTryRunInline_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x000EE850 File Offset: 0x000ECA50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 206102, RefRangeEnd = 206106, XrefRangeStart = 206079, XrefRangeEnd = 206102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_InternalWait_Internal_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x000EE8B0 File Offset: 0x000ECAB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206138, RefRangeEnd = 206139, XrefRangeStart = 206106, XrefRangeEnd = 206138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_SpinThenBlockingWait_Private_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x000EE910 File Offset: 0x000ECB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206139, XrefRangeEnd = 206152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SpinWait(int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_SpinWait_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x000EE95C File Offset: 0x000ECB5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 206168, RefRangeEnd = 206172, XrefRangeStart = 206152, XrefRangeEnd = 206168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalCancel(bool bCancelNonExecutingOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bCancelNonExecutingOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_InternalCancel_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x000EE9A8 File Offset: 0x000ECBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206172, XrefRangeEnd = 206173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordInternalCancellationRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x000EE9DC File Offset: 0x000ECBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206173, XrefRangeEnd = 206178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordInternalCancellationRequest(CancellationToken tokenToRecord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tokenToRecord));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x000EEA24 File Offset: 0x000ECC24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206184, RefRangeEnd = 206185, XrefRangeStart = 206178, XrefRangeEnd = 206184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordInternalCancellationRequest(CancellationToken tokenToRecord, Object cancellationException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tokenToRecord));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cancellationException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x000EEA80 File Offset: 0x000ECC80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206196, RefRangeEnd = 206198, XrefRangeStart = 206185, XrefRangeEnd = 206196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancellationCleanupLogic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_CancellationCleanupLogic_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x000EEAB4 File Offset: 0x000ECCB4
		[CallerCount(0)]
		public unsafe void SetCancellationAcknowledged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_SetCancellationAcknowledged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x000EEAE8 File Offset: 0x000ECCE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206221, RefRangeEnd = 206222, XrefRangeStart = 206198, XrefRangeEnd = 206221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishContinuations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FinishContinuations_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x000EEB1C File Offset: 0x000ECD1C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 33858, RefRangeEnd = 33864, XrefRangeStart = 33858, XrefRangeEnd = 33864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogFinishCompletionNotification()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_LogFinishCompletionNotification_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x000EEB50 File Offset: 0x000ECD50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206234, RefRangeEnd = 206235, XrefRangeStart = 206222, XrefRangeEnd = 206234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ContinueWith(Action<Task> continuationAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ContinueWith_Public_Task_Action_1_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x000EEBA0 File Offset: 0x000ECDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206235, XrefRangeEnd = 206244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ContinueWith_Private_Task_Action_1_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x000EEC38 File Offset: 0x000ECE38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206253, RefRangeEnd = 206254, XrefRangeStart = 206244, XrefRangeEnd = 206253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ContinueWith(Action<Task, Object> continuationAction, Object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ContinueWith_Public_Task_Action_2_Task_Object_Object_CancellationToken_TaskContinuationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x000EECD4 File Offset: 0x000ECED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206254, XrefRangeEnd = 206263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ContinueWith(Action<Task, Object> continuationAction, Object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ContinueWith_Private_Task_Action_2_Task_Object_Object_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x000EED80 File Offset: 0x000ECF80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 206263, RefRangeEnd = 206267, XrefRangeStart = 206263, XrefRangeEnd = 206263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref continuationOptions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &creationOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &internalOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_CreationOptionsFromContinuationOptions_Internal_Static_Void_TaskContinuationOptions_byref_TaskCreationOptions_byref_InternalTaskOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x000EEDD0 File Offset: 0x000ECFD0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 206289, RefRangeEnd = 206294, XrefRangeStart = 206267, XrefRangeEnd = 206289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ContinueWithCore_Internal_Void_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x000EEE4C File Offset: 0x000ED04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206294, XrefRangeEnd = 206297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCompletionAction(ITaskCompletionAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddCompletionAction_Internal_Void_ITaskCompletionAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x000EEE90 File Offset: 0x000ED090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206297, XrefRangeEnd = 206300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addBeforeOthers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddCompletionAction_Private_Void_ITaskCompletionAction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x000EEEE0 File Offset: 0x000ED0E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206335, RefRangeEnd = 206336, XrefRangeStart = 206300, XrefRangeEnd = 206335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddTaskContinuationComplex(Object tc, bool addBeforeOthers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addBeforeOthers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddTaskContinuationComplex_Private_Boolean_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x000EEF3C File Offset: 0x000ED13C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 206342, RefRangeEnd = 206352, XrefRangeStart = 206336, XrefRangeEnd = 206342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddTaskContinuation(Object tc, bool addBeforeOthers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addBeforeOthers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddTaskContinuation_Private_Boolean_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x000EEF98 File Offset: 0x000ED198
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 206375, RefRangeEnd = 206379, XrefRangeStart = 206352, XrefRangeEnd = 206375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveContinuation(Object continuationObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_RemoveContinuation_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x000EEFDC File Offset: 0x000ED1DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206381, RefRangeEnd = 206383, XrefRangeStart = 206379, XrefRangeEnd = 206381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromResult<TResult>(TResult result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TResult ptr4;
				if (!typeof(TResult).IsValueType)
				{
					TResult tresult = result;
					if (!(tresult is string))
					{
						ref TResult ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tresult as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tresult as string);
					}
				}
				else
				{
					ptr4 = ref result;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_FromResult_Public_Static_Task_1_TResult_TResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x000EF06C File Offset: 0x000ED26C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206390, RefRangeEnd = 206391, XrefRangeStart = 206383, XrefRangeEnd = 206390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task FromException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FromException_Public_Static_Task_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x000EF0B0 File Offset: 0x000ED2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206391, XrefRangeEnd = 206393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromException<TResult>(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_FromException_Public_Static_Task_1_TResult_Exception_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x000EF0F4 File Offset: 0x000ED2F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 206397, RefRangeEnd = 206404, XrefRangeStart = 206393, XrefRangeEnd = 206397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task FromCancellation(CancellationToken cancellationToken)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x000EF140 File Offset: 0x000ED340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206404, XrefRangeEnd = 206406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_FromCancellation_Internal_Static_Task_1_TResult_CancellationToken_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x000EF18C File Offset: 0x000ED38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206406, XrefRangeEnd = 206408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_FromCancellation_Internal_Static_Task_1_TResult_OperationCanceledException_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x000EF1D0 File Offset: 0x000ED3D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 206422, RefRangeEnd = 206425, XrefRangeStart = 206408, XrefRangeEnd = 206422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task Run(Action action)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Run_Public_Static_Task_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x000EF214 File Offset: 0x000ED414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206433, RefRangeEnd = 206434, XrefRangeStart = 206425, XrefRangeEnd = 206433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> Run<TResult>(Func<TResult> function)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_TResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x000EF258 File Offset: 0x000ED458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206434, XrefRangeEnd = 206445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> Run<TResult>(Func<Task<TResult>> function)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x000EF29C File Offset: 0x000ED49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206445, XrefRangeEnd = 206461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_CancellationToken_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x000EF2F8 File Offset: 0x000ED4F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 206465, RefRangeEnd = 206470, XrefRangeStart = 206461, XrefRangeEnd = 206465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task Delay(int millisecondsDelay)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsDelay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x000EF338 File Offset: 0x000ED538
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 206521, RefRangeEnd = 206526, XrefRangeStart = 206470, XrefRangeEnd = 206521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsDelay;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x000EF390 File Offset: 0x000ED590
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 206559, RefRangeEnd = 206565, XrefRangeStart = 206526, XrefRangeEnd = 206559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Task> WhenAny([Optional] Il2CppReferenceArray<Task> tasks)
		{
			if (tasks == null)
			{
				tasks = new Il2CppReferenceArray<Task>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tasks);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_Il2CppReferenceArray_1_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Task>>(intPtr3) : null;
			}
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x000EF3E4 File Offset: 0x000ED5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206565, XrefRangeEnd = 206669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Task> WhenAny(IEnumerable<Task> tasks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tasks);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_IEnumerable_1_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Task>>(intPtr3) : null;
			}
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x000100AF File Offset: 0x0000E2AF
		public static Task<Task> WhenAny(params Task[] tasks)
		{
			return Task.WhenAny(new Il2CppReferenceArray<Task>(tasks));
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x000100BC File Offset: 0x0000E2BC
		public Task(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002EAA RID: 11946 RVA: 0x000EF428 File Offset: 0x000ED628
		// (set) Token: 0x06002EAB RID: 11947 RVA: 0x000100C5 File Offset: 0x0000E2C5
		public unsafe static Task t_currentTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_t_currentTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_t_currentTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06002EAC RID: 11948 RVA: 0x000EF450 File Offset: 0x000ED650
		// (set) Token: 0x06002EAD RID: 11949 RVA: 0x000100D7 File Offset: 0x0000E2D7
		public unsafe static StackGuard t_stackGuard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_t_stackGuard, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StackGuard>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_t_stackGuard, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06002EAE RID: 11950 RVA: 0x000EF478 File Offset: 0x000ED678
		// (set) Token: 0x06002EAF RID: 11951 RVA: 0x000100E9 File Offset: 0x0000E2E9
		public unsafe static int s_taskIdCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_taskIdCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_taskIdCounter, (void*)(&value));
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06002EB0 RID: 11952 RVA: 0x000EF494 File Offset: 0x000ED694
		// (set) Token: 0x06002EB1 RID: 11953 RVA: 0x000100F7 File Offset: 0x0000E2F7
		public unsafe static TaskFactory s_factory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_factory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskFactory>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_factory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06002EB2 RID: 11954 RVA: 0x000EF4BC File Offset: 0x000ED6BC
		// (set) Token: 0x06002EB3 RID: 11955 RVA: 0x00010109 File Offset: 0x0000E309
		public unsafe int m_taskId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_taskId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_taskId)) = value;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06002EB4 RID: 11956 RVA: 0x000EF4E4 File Offset: 0x000ED6E4
		// (set) Token: 0x06002EB5 RID: 11957 RVA: 0x00010124 File Offset: 0x0000E324
		public unsafe Object m_action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06002EB6 RID: 11958 RVA: 0x000EF514 File Offset: 0x000ED714
		// (set) Token: 0x06002EB7 RID: 11959 RVA: 0x00010143 File Offset: 0x0000E343
		public unsafe Object m_stateObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_stateObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_stateObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06002EB8 RID: 11960 RVA: 0x000EF544 File Offset: 0x000ED744
		// (set) Token: 0x06002EB9 RID: 11961 RVA: 0x00010162 File Offset: 0x0000E362
		public unsafe TaskScheduler m_taskScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_taskScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_taskScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002EBA RID: 11962 RVA: 0x000EF574 File Offset: 0x000ED774
		// (set) Token: 0x06002EBB RID: 11963 RVA: 0x00010181 File Offset: 0x0000E381
		public unsafe Task m_parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06002EBC RID: 11964 RVA: 0x000EF5A4 File Offset: 0x000ED7A4
		// (set) Token: 0x06002EBD RID: 11965 RVA: 0x000101A0 File Offset: 0x0000E3A0
		public unsafe int m_stateFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_stateFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_stateFlags)) = value;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06002EBE RID: 11966 RVA: 0x000EF5CC File Offset: 0x000ED7CC
		// (set) Token: 0x06002EBF RID: 11967 RVA: 0x000101BB File Offset: 0x0000E3BB
		public unsafe static int OptionsMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_OptionsMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_OptionsMask, (void*)(&value));
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x000EF5E8 File Offset: 0x000ED7E8
		// (set) Token: 0x06002EC1 RID: 11969 RVA: 0x000101C9 File Offset: 0x0000E3C9
		public unsafe static int TASK_STATE_STARTED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_STARTED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_STARTED, (void*)(&value));
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06002EC2 RID: 11970 RVA: 0x000EF604 File Offset: 0x000ED804
		// (set) Token: 0x06002EC3 RID: 11971 RVA: 0x000101D7 File Offset: 0x0000E3D7
		public unsafe static int TASK_STATE_DELEGATE_INVOKED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_DELEGATE_INVOKED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_DELEGATE_INVOKED, (void*)(&value));
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06002EC4 RID: 11972 RVA: 0x000EF620 File Offset: 0x000ED820
		// (set) Token: 0x06002EC5 RID: 11973 RVA: 0x000101E5 File Offset: 0x0000E3E5
		public unsafe static int TASK_STATE_DISPOSED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_DISPOSED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_DISPOSED, (void*)(&value));
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06002EC6 RID: 11974 RVA: 0x000EF63C File Offset: 0x000ED83C
		// (set) Token: 0x06002EC7 RID: 11975 RVA: 0x000101F3 File Offset: 0x0000E3F3
		public unsafe static int TASK_STATE_EXCEPTIONOBSERVEDBYPARENT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_EXCEPTIONOBSERVEDBYPARENT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_EXCEPTIONOBSERVEDBYPARENT, (void*)(&value));
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x000EF658 File Offset: 0x000ED858
		// (set) Token: 0x06002EC9 RID: 11977 RVA: 0x00010201 File Offset: 0x0000E401
		public unsafe static int TASK_STATE_CANCELLATIONACKNOWLEDGED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_CANCELLATIONACKNOWLEDGED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_CANCELLATIONACKNOWLEDGED, (void*)(&value));
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06002ECA RID: 11978 RVA: 0x000EF674 File Offset: 0x000ED874
		// (set) Token: 0x06002ECB RID: 11979 RVA: 0x0001020F File Offset: 0x0000E40F
		public unsafe static int TASK_STATE_FAULTED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_FAULTED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_FAULTED, (void*)(&value));
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06002ECC RID: 11980 RVA: 0x000EF690 File Offset: 0x000ED890
		// (set) Token: 0x06002ECD RID: 11981 RVA: 0x0001021D File Offset: 0x0000E41D
		public unsafe static int TASK_STATE_CANCELED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_CANCELED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_CANCELED, (void*)(&value));
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06002ECE RID: 11982 RVA: 0x000EF6AC File Offset: 0x000ED8AC
		// (set) Token: 0x06002ECF RID: 11983 RVA: 0x0001022B File Offset: 0x0000E42B
		public unsafe static int TASK_STATE_WAITING_ON_CHILDREN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_WAITING_ON_CHILDREN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_WAITING_ON_CHILDREN, (void*)(&value));
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06002ED0 RID: 11984 RVA: 0x000EF6C8 File Offset: 0x000ED8C8
		// (set) Token: 0x06002ED1 RID: 11985 RVA: 0x00010239 File Offset: 0x0000E439
		public unsafe static int TASK_STATE_RAN_TO_COMPLETION
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_RAN_TO_COMPLETION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_RAN_TO_COMPLETION, (void*)(&value));
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06002ED2 RID: 11986 RVA: 0x000EF6E4 File Offset: 0x000ED8E4
		// (set) Token: 0x06002ED3 RID: 11987 RVA: 0x00010247 File Offset: 0x0000E447
		public unsafe static int TASK_STATE_WAITINGFORACTIVATION
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_WAITINGFORACTIVATION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_WAITINGFORACTIVATION, (void*)(&value));
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06002ED4 RID: 11988 RVA: 0x000EF700 File Offset: 0x000ED900
		// (set) Token: 0x06002ED5 RID: 11989 RVA: 0x00010255 File Offset: 0x0000E455
		public unsafe static int TASK_STATE_COMPLETION_RESERVED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_COMPLETION_RESERVED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_COMPLETION_RESERVED, (void*)(&value));
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06002ED6 RID: 11990 RVA: 0x000EF71C File Offset: 0x000ED91C
		// (set) Token: 0x06002ED7 RID: 11991 RVA: 0x00010263 File Offset: 0x0000E463
		public unsafe static int TASK_STATE_THREAD_WAS_ABORTED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_THREAD_WAS_ABORTED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_THREAD_WAS_ABORTED, (void*)(&value));
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06002ED8 RID: 11992 RVA: 0x000EF738 File Offset: 0x000ED938
		// (set) Token: 0x06002ED9 RID: 11993 RVA: 0x00010271 File Offset: 0x0000E471
		public unsafe static int TASK_STATE_WAIT_COMPLETION_NOTIFICATION
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_WAIT_COMPLETION_NOTIFICATION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_WAIT_COMPLETION_NOTIFICATION, (void*)(&value));
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06002EDA RID: 11994 RVA: 0x000EF754 File Offset: 0x000ED954
		// (set) Token: 0x06002EDB RID: 11995 RVA: 0x0001027F File Offset: 0x0000E47F
		public unsafe static int TASK_STATE_EXECUTIONCONTEXT_IS_NULL
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_EXECUTIONCONTEXT_IS_NULL, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_EXECUTIONCONTEXT_IS_NULL, (void*)(&value));
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06002EDC RID: 11996 RVA: 0x000EF770 File Offset: 0x000ED970
		// (set) Token: 0x06002EDD RID: 11997 RVA: 0x0001028D File Offset: 0x0000E48D
		public unsafe static int TASK_STATE_TASKSCHEDULED_WAS_FIRED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_TASKSCHEDULED_WAS_FIRED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_TASKSCHEDULED_WAS_FIRED, (void*)(&value));
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06002EDE RID: 11998 RVA: 0x000EF78C File Offset: 0x000ED98C
		// (set) Token: 0x06002EDF RID: 11999 RVA: 0x0001029B File Offset: 0x0000E49B
		public unsafe static int TASK_STATE_COMPLETED_MASK
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_TASK_STATE_COMPLETED_MASK, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_TASK_STATE_COMPLETED_MASK, (void*)(&value));
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06002EE0 RID: 12000 RVA: 0x000EF7A8 File Offset: 0x000ED9A8
		// (set) Token: 0x06002EE1 RID: 12001 RVA: 0x000102A9 File Offset: 0x0000E4A9
		public unsafe static int CANCELLATION_REQUESTED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_CANCELLATION_REQUESTED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_CANCELLATION_REQUESTED, (void*)(&value));
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06002EE2 RID: 12002 RVA: 0x000EF7C4 File Offset: 0x000ED9C4
		// (set) Token: 0x06002EE3 RID: 12003 RVA: 0x000102B7 File Offset: 0x0000E4B7
		public unsafe Object m_continuationObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_continuationObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_continuationObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06002EE4 RID: 12004 RVA: 0x000EF7F4 File Offset: 0x000ED9F4
		// (set) Token: 0x06002EE5 RID: 12005 RVA: 0x000102D6 File Offset: 0x0000E4D6
		public unsafe static Object s_taskCompletionSentinel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_taskCompletionSentinel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_taskCompletionSentinel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x000EF81C File Offset: 0x000EDA1C
		// (set) Token: 0x06002EE7 RID: 12007 RVA: 0x000102E8 File Offset: 0x0000E4E8
		public unsafe static bool s_asyncDebuggingEnabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_asyncDebuggingEnabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_asyncDebuggingEnabled, (void*)(&value));
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06002EE8 RID: 12008 RVA: 0x000EF838 File Offset: 0x000EDA38
		// (set) Token: 0x06002EE9 RID: 12009 RVA: 0x000102F6 File Offset: 0x0000E4F6
		public unsafe static Dictionary<int, Task> s_currentActiveTasks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_currentActiveTasks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Task>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_currentActiveTasks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06002EEA RID: 12010 RVA: 0x000EF860 File Offset: 0x000EDA60
		// (set) Token: 0x06002EEB RID: 12011 RVA: 0x00010308 File Offset: 0x0000E508
		public unsafe static Object s_activeTasksLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_activeTasksLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_activeTasksLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002EEC RID: 12012 RVA: 0x000EF888 File Offset: 0x000EDA88
		// (set) Token: 0x06002EED RID: 12013 RVA: 0x0001031A File Offset: 0x0000E51A
		public unsafe Task.ContingentProperties m_contingentProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_contingentProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task.ContingentProperties>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_contingentProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06002EEE RID: 12014 RVA: 0x000EF8B8 File Offset: 0x000EDAB8
		// (set) Token: 0x06002EEF RID: 12015 RVA: 0x00010339 File Offset: 0x0000E539
		public unsafe static Action<Object> s_taskCancelCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_taskCancelCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_taskCancelCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002EF0 RID: 12016 RVA: 0x000EF8E0 File Offset: 0x000EDAE0
		// (set) Token: 0x06002EF1 RID: 12017 RVA: 0x0001034B File Offset: 0x0000E54B
		public unsafe static Func<Task.ContingentProperties> s_createContingentProperties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_createContingentProperties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Task.ContingentProperties>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_createContingentProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002EF2 RID: 12018 RVA: 0x000EF908 File Offset: 0x000EDB08
		// (set) Token: 0x06002EF3 RID: 12019 RVA: 0x0001035D File Offset: 0x0000E55D
		public unsafe static Task s_completedTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_completedTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_completedTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002EF4 RID: 12020 RVA: 0x000EF930 File Offset: 0x000EDB30
		// (set) Token: 0x06002EF5 RID: 12021 RVA: 0x0001036F File Offset: 0x0000E56F
		public unsafe static Predicate<Task> s_IsExceptionObservedByParentPredicate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_IsExceptionObservedByParentPredicate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Task>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_IsExceptionObservedByParentPredicate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002EF6 RID: 12022 RVA: 0x000EF958 File Offset: 0x000EDB58
		// (set) Token: 0x06002EF7 RID: 12023 RVA: 0x00010381 File Offset: 0x0000E581
		public unsafe static ContextCallback s_ecCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_ecCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_ecCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002EF8 RID: 12024 RVA: 0x000EF980 File Offset: 0x000EDB80
		// (set) Token: 0x06002EF9 RID: 12025 RVA: 0x00010393 File Offset: 0x0000E593
		public unsafe static Predicate<Object> s_IsTaskContinuationNullPredicate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_IsTaskContinuationNullPredicate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_IsTaskContinuationNullPredicate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027FD RID: 10237
		private static readonly IntPtr NativeFieldInfoPtr_t_currentTask;

		// Token: 0x040027FE RID: 10238
		private static readonly IntPtr NativeFieldInfoPtr_t_stackGuard;

		// Token: 0x040027FF RID: 10239
		private static readonly IntPtr NativeFieldInfoPtr_s_taskIdCounter;

		// Token: 0x04002800 RID: 10240
		private static readonly IntPtr NativeFieldInfoPtr_s_factory;

		// Token: 0x04002801 RID: 10241
		private static readonly IntPtr NativeFieldInfoPtr_m_taskId;

		// Token: 0x04002802 RID: 10242
		private static readonly IntPtr NativeFieldInfoPtr_m_action;

		// Token: 0x04002803 RID: 10243
		private static readonly IntPtr NativeFieldInfoPtr_m_stateObject;

		// Token: 0x04002804 RID: 10244
		private static readonly IntPtr NativeFieldInfoPtr_m_taskScheduler;

		// Token: 0x04002805 RID: 10245
		private static readonly IntPtr NativeFieldInfoPtr_m_parent;

		// Token: 0x04002806 RID: 10246
		private static readonly IntPtr NativeFieldInfoPtr_m_stateFlags;

		// Token: 0x04002807 RID: 10247
		private static readonly IntPtr NativeFieldInfoPtr_OptionsMask;

		// Token: 0x04002808 RID: 10248
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_STARTED;

		// Token: 0x04002809 RID: 10249
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_DELEGATE_INVOKED;

		// Token: 0x0400280A RID: 10250
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_DISPOSED;

		// Token: 0x0400280B RID: 10251
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_EXCEPTIONOBSERVEDBYPARENT;

		// Token: 0x0400280C RID: 10252
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_CANCELLATIONACKNOWLEDGED;

		// Token: 0x0400280D RID: 10253
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_FAULTED;

		// Token: 0x0400280E RID: 10254
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_CANCELED;

		// Token: 0x0400280F RID: 10255
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_WAITING_ON_CHILDREN;

		// Token: 0x04002810 RID: 10256
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_RAN_TO_COMPLETION;

		// Token: 0x04002811 RID: 10257
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_WAITINGFORACTIVATION;

		// Token: 0x04002812 RID: 10258
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_COMPLETION_RESERVED;

		// Token: 0x04002813 RID: 10259
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_THREAD_WAS_ABORTED;

		// Token: 0x04002814 RID: 10260
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_WAIT_COMPLETION_NOTIFICATION;

		// Token: 0x04002815 RID: 10261
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_EXECUTIONCONTEXT_IS_NULL;

		// Token: 0x04002816 RID: 10262
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_TASKSCHEDULED_WAS_FIRED;

		// Token: 0x04002817 RID: 10263
		private static readonly IntPtr NativeFieldInfoPtr_TASK_STATE_COMPLETED_MASK;

		// Token: 0x04002818 RID: 10264
		private static readonly IntPtr NativeFieldInfoPtr_CANCELLATION_REQUESTED;

		// Token: 0x04002819 RID: 10265
		private static readonly IntPtr NativeFieldInfoPtr_m_continuationObject;

		// Token: 0x0400281A RID: 10266
		private static readonly IntPtr NativeFieldInfoPtr_s_taskCompletionSentinel;

		// Token: 0x0400281B RID: 10267
		private static readonly IntPtr NativeFieldInfoPtr_s_asyncDebuggingEnabled;

		// Token: 0x0400281C RID: 10268
		private static readonly IntPtr NativeFieldInfoPtr_s_currentActiveTasks;

		// Token: 0x0400281D RID: 10269
		private static readonly IntPtr NativeFieldInfoPtr_s_activeTasksLock;

		// Token: 0x0400281E RID: 10270
		private static readonly IntPtr NativeFieldInfoPtr_m_contingentProperties;

		// Token: 0x0400281F RID: 10271
		private static readonly IntPtr NativeFieldInfoPtr_s_taskCancelCallback;

		// Token: 0x04002820 RID: 10272
		private static readonly IntPtr NativeFieldInfoPtr_s_createContingentProperties;

		// Token: 0x04002821 RID: 10273
		private static readonly IntPtr NativeFieldInfoPtr_s_completedTask;

		// Token: 0x04002822 RID: 10274
		private static readonly IntPtr NativeFieldInfoPtr_s_IsExceptionObservedByParentPredicate;

		// Token: 0x04002823 RID: 10275
		private static readonly IntPtr NativeFieldInfoPtr_s_ecCallback;

		// Token: 0x04002824 RID: 10276
		private static readonly IntPtr NativeFieldInfoPtr_s_IsTaskContinuationNullPredicate;

		// Token: 0x04002825 RID: 10277
		private static readonly IntPtr NativeMethodInfoPtr_AddToActiveTasks_Internal_Static_Boolean_Task_0;

		// Token: 0x04002826 RID: 10278
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromActiveTasks_Internal_Static_Void_Int32_0;

		// Token: 0x04002827 RID: 10279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TaskCreationOptions_CancellationToken_0;

		// Token: 0x04002828 RID: 10280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002829 RID: 10281
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_Boolean_0;

		// Token: 0x0400282A RID: 10282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0;

		// Token: 0x0400282B RID: 10283
		private static readonly IntPtr NativeMethodInfoPtr_TaskConstructorCore_Internal_Void_Object_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0;

		// Token: 0x0400282C RID: 10284
		private static readonly IntPtr NativeMethodInfoPtr_AssignCancellationToken_Private_Void_CancellationToken_Task_TaskContinuation_0;

		// Token: 0x0400282D RID: 10285
		private static readonly IntPtr NativeMethodInfoPtr_TaskCancelCallback_Private_Static_Void_Object_0;

		// Token: 0x0400282E RID: 10286
		private static readonly IntPtr NativeMethodInfoPtr_PossiblyCaptureContext_Internal_Void_byref_StackCrawlMark_0;

		// Token: 0x0400282F RID: 10287
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Internal_get_TaskCreationOptions_0;

		// Token: 0x04002830 RID: 10288
		private static readonly IntPtr NativeMethodInfoPtr_OptionsMethod_Internal_Static_TaskCreationOptions_Int32_0;

		// Token: 0x04002831 RID: 10289
		private static readonly IntPtr NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_0;

		// Token: 0x04002832 RID: 10290
		private static readonly IntPtr NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_byref_Int32_0;

		// Token: 0x04002833 RID: 10291
		private static readonly IntPtr NativeMethodInfoPtr_SetNotificationForWaitCompletion_Internal_Void_Boolean_0;

		// Token: 0x04002834 RID: 10292
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletionIfNecessary_Internal_Boolean_0;

		// Token: 0x04002835 RID: 10293
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWaitNotificationEnabledOrNotRanToCompletion_Internal_get_Boolean_0;

		// Token: 0x04002836 RID: 10294
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldNotifyDebuggerOfWaitCompletion_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x04002837 RID: 10295
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWaitNotificationEnabled_Internal_get_Boolean_0;

		// Token: 0x04002838 RID: 10296
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletion_Private_Void_0;

		// Token: 0x04002839 RID: 10297
		private static readonly IntPtr NativeMethodInfoPtr_MarkStarted_Internal_Boolean_0;

		// Token: 0x0400283A RID: 10298
		private static readonly IntPtr NativeMethodInfoPtr_FireTaskScheduledIfNeeded_Internal_Boolean_TaskScheduler_0;

		// Token: 0x0400283B RID: 10299
		private static readonly IntPtr NativeMethodInfoPtr_AddNewChild_Internal_Void_0;

		// Token: 0x0400283C RID: 10300
		private static readonly IntPtr NativeMethodInfoPtr_DisregardChild_Internal_Void_0;

		// Token: 0x0400283D RID: 10301
		private static readonly IntPtr NativeMethodInfoPtr_InternalStartNew_Internal_Static_Task_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions_byref_StackCrawlMark_0;

		// Token: 0x0400283E RID: 10302
		private static readonly IntPtr NativeMethodInfoPtr_NewId_Internal_Static_Int32_0;

		// Token: 0x0400283F RID: 10303
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002840 RID: 10304
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_Task_0;

		// Token: 0x04002841 RID: 10305
		private static readonly IntPtr NativeMethodInfoPtr_InternalCurrentIfAttached_Internal_Static_Task_TaskCreationOptions_0;

		// Token: 0x04002842 RID: 10306
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStackGuard_Internal_Static_get_StackGuard_0;

		// Token: 0x04002843 RID: 10307
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_get_AggregateException_0;

		// Token: 0x04002844 RID: 10308
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_TaskStatus_0;

		// Token: 0x04002845 RID: 10309
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCanceled_Public_get_Boolean_0;

		// Token: 0x04002846 RID: 10310
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCancellationRequested_Internal_get_Boolean_0;

		// Token: 0x04002847 RID: 10311
		private static readonly IntPtr NativeMethodInfoPtr_EnsureContingentPropertiesInitialized_Internal_ContingentProperties_Boolean_0;

		// Token: 0x04002848 RID: 10312
		private static readonly IntPtr NativeMethodInfoPtr_EnsureContingentPropertiesInitializedCore_Private_ContingentProperties_Boolean_0;

		// Token: 0x04002849 RID: 10313
		private static readonly IntPtr NativeMethodInfoPtr_get_CancellationToken_Internal_get_CancellationToken_0;

		// Token: 0x0400284A RID: 10314
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCancellationAcknowledged_Internal_get_Boolean_0;

		// Token: 0x0400284B RID: 10315
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400284C RID: 10316
		private static readonly IntPtr NativeMethodInfoPtr_IsCompletedMethod_Private_Static_Boolean_Int32_0;

		// Token: 0x0400284D RID: 10317
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRanToCompletion_Internal_get_Boolean_0;

		// Token: 0x0400284E RID: 10318
		private static readonly IntPtr NativeMethodInfoPtr_get_CreationOptions_Public_get_TaskCreationOptions_0;

		// Token: 0x0400284F RID: 10319
		private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0;

		// Token: 0x04002850 RID: 10320
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04002851 RID: 10321
		private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002852 RID: 10322
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutingTaskScheduler_Internal_get_TaskScheduler_0;

		// Token: 0x04002853 RID: 10323
		private static readonly IntPtr NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_0;

		// Token: 0x04002854 RID: 10324
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedTask_Public_Static_get_Task_0;

		// Token: 0x04002855 RID: 10325
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedEvent_Internal_get_ManualResetEventSlim_0;

		// Token: 0x04002856 RID: 10326
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSelfReplicatingRoot_Internal_get_Boolean_0;

		// Token: 0x04002857 RID: 10327
		private static readonly IntPtr NativeMethodInfoPtr_get_IsChildReplica_Internal_get_Boolean_0;

		// Token: 0x04002858 RID: 10328
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionRecorded_Internal_get_Boolean_0;

		// Token: 0x04002859 RID: 10329
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFaulted_Public_get_Boolean_0;

		// Token: 0x0400285A RID: 10330
		private static readonly IntPtr NativeMethodInfoPtr_get_CapturedContext_Internal_get_ExecutionContext_0;

		// Token: 0x0400285B RID: 10331
		private static readonly IntPtr NativeMethodInfoPtr_set_CapturedContext_Internal_set_Void_ExecutionContext_0;

		// Token: 0x0400285C RID: 10332
		private static readonly IntPtr NativeMethodInfoPtr_CopyExecutionContext_Private_Static_ExecutionContext_ExecutionContext_0;

		// Token: 0x0400285D RID: 10333
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400285E RID: 10334
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400285F RID: 10335
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleAndStart_Internal_Void_Boolean_0;

		// Token: 0x04002860 RID: 10336
		private static readonly IntPtr NativeMethodInfoPtr_AddException_Internal_Void_Object_0;

		// Token: 0x04002861 RID: 10337
		private static readonly IntPtr NativeMethodInfoPtr_AddException_Internal_Void_Object_Boolean_0;

		// Token: 0x04002862 RID: 10338
		private static readonly IntPtr NativeMethodInfoPtr_GetExceptions_Private_AggregateException_Boolean_0;

		// Token: 0x04002863 RID: 10339
		private static readonly IntPtr NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0;

		// Token: 0x04002864 RID: 10340
		private static readonly IntPtr NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0;

		// Token: 0x04002865 RID: 10341
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfExceptional_Internal_Void_Boolean_0;

		// Token: 0x04002866 RID: 10342
		private static readonly IntPtr NativeMethodInfoPtr_UpdateExceptionObservedStatus_Internal_Void_0;

		// Token: 0x04002867 RID: 10343
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExceptionObservedByParent_Internal_get_Boolean_0;

		// Token: 0x04002868 RID: 10344
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDelegateInvoked_Internal_get_Boolean_0;

		// Token: 0x04002869 RID: 10345
		private static readonly IntPtr NativeMethodInfoPtr_Finish_Internal_Void_Boolean_0;

		// Token: 0x0400286A RID: 10346
		private static readonly IntPtr NativeMethodInfoPtr_FinishStageTwo_Internal_Void_0;

		// Token: 0x0400286B RID: 10347
		private static readonly IntPtr NativeMethodInfoPtr_FinishStageThree_Internal_Void_0;

		// Token: 0x0400286C RID: 10348
		private static readonly IntPtr NativeMethodInfoPtr_ProcessChildCompletion_Internal_Void_Task_0;

		// Token: 0x0400286D RID: 10349
		private static readonly IntPtr NativeMethodInfoPtr_AddExceptionsFromChildren_Internal_Void_0;

		// Token: 0x0400286E RID: 10350
		private static readonly IntPtr NativeMethodInfoPtr_FinishThreadAbortedTask_Internal_Void_Boolean_Boolean_0;

		// Token: 0x0400286F RID: 10351
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_0;

		// Token: 0x04002870 RID: 10352
		private static readonly IntPtr NativeMethodInfoPtr_ShouldReplicate_Internal_Virtual_New_Boolean_0;

		// Token: 0x04002871 RID: 10353
		private static readonly IntPtr NativeMethodInfoPtr_CreateReplicaTask_Internal_Virtual_New_Task_Action_1_Object_Object_Task_TaskScheduler_TaskCreationOptions_InternalTaskOptions_0;

		// Token: 0x04002872 RID: 10354
		private static readonly IntPtr NativeMethodInfoPtr_get_SavedStateForNextReplica_Internal_Virtual_New_get_Object_0;

		// Token: 0x04002873 RID: 10355
		private static readonly IntPtr NativeMethodInfoPtr_set_SavedStateFromPreviousReplica_Internal_Virtual_New_set_Void_Object_0;

		// Token: 0x04002874 RID: 10356
		private static readonly IntPtr NativeMethodInfoPtr_get_HandedOverChildReplica_Internal_Virtual_New_get_Task_0;

		// Token: 0x04002875 RID: 10357
		private static readonly IntPtr NativeMethodInfoPtr_set_HandedOverChildReplica_Internal_Virtual_New_set_Void_Task_0;

		// Token: 0x04002876 RID: 10358
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteSelfReplicating_Private_Static_Void_Task_0;

		// Token: 0x04002877 RID: 10359
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

		// Token: 0x04002878 RID: 10360
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0;

		// Token: 0x04002879 RID: 10361
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteEntry_Internal_Boolean_Boolean_0;

		// Token: 0x0400287A RID: 10362
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteWithThreadLocal_Private_Void_byref_Task_0;

		// Token: 0x0400287B RID: 10363
		private static readonly IntPtr NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0;

		// Token: 0x0400287C RID: 10364
		private static readonly IntPtr NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_New_Void_0;

		// Token: 0x0400287D RID: 10365
		private static readonly IntPtr NativeMethodInfoPtr_InnerInvokeWithArg_Internal_Void_Task_0;

		// Token: 0x0400287E RID: 10366
		private static readonly IntPtr NativeMethodInfoPtr_HandleException_Private_Void_Exception_0;

		// Token: 0x0400287F RID: 10367
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_0;

		// Token: 0x04002880 RID: 10368
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_Boolean_0;

		// Token: 0x04002881 RID: 10369
		private static readonly IntPtr NativeMethodInfoPtr_SetContinuationForAwait_Internal_Void_Action_Boolean_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04002882 RID: 10370
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Void_0;

		// Token: 0x04002883 RID: 10371
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0;

		// Token: 0x04002884 RID: 10372
		private static readonly IntPtr NativeMethodInfoPtr_WrappedTryRunInline_Private_Boolean_0;

		// Token: 0x04002885 RID: 10373
		private static readonly IntPtr NativeMethodInfoPtr_InternalWait_Internal_Boolean_Int32_CancellationToken_0;

		// Token: 0x04002886 RID: 10374
		private static readonly IntPtr NativeMethodInfoPtr_SpinThenBlockingWait_Private_Boolean_Int32_CancellationToken_0;

		// Token: 0x04002887 RID: 10375
		private static readonly IntPtr NativeMethodInfoPtr_SpinWait_Private_Boolean_Int32_0;

		// Token: 0x04002888 RID: 10376
		private static readonly IntPtr NativeMethodInfoPtr_InternalCancel_Internal_Boolean_Boolean_0;

		// Token: 0x04002889 RID: 10377
		private static readonly IntPtr NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_0;

		// Token: 0x0400288A RID: 10378
		private static readonly IntPtr NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_0;

		// Token: 0x0400288B RID: 10379
		private static readonly IntPtr NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_Object_0;

		// Token: 0x0400288C RID: 10380
		private static readonly IntPtr NativeMethodInfoPtr_CancellationCleanupLogic_Internal_Void_0;

		// Token: 0x0400288D RID: 10381
		private static readonly IntPtr NativeMethodInfoPtr_SetCancellationAcknowledged_Private_Void_0;

		// Token: 0x0400288E RID: 10382
		private static readonly IntPtr NativeMethodInfoPtr_FinishContinuations_Internal_Void_0;

		// Token: 0x0400288F RID: 10383
		private static readonly IntPtr NativeMethodInfoPtr_LogFinishCompletionNotification_Private_Void_0;

		// Token: 0x04002890 RID: 10384
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Public_Task_Action_1_Task_0;

		// Token: 0x04002891 RID: 10385
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Private_Task_Action_1_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0;

		// Token: 0x04002892 RID: 10386
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Public_Task_Action_2_Task_Object_Object_CancellationToken_TaskContinuationOptions_TaskScheduler_0;

		// Token: 0x04002893 RID: 10387
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Private_Task_Action_2_Task_Object_Object_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0;

		// Token: 0x04002894 RID: 10388
		private static readonly IntPtr NativeMethodInfoPtr_CreationOptionsFromContinuationOptions_Internal_Static_Void_TaskContinuationOptions_byref_TaskCreationOptions_byref_InternalTaskOptions_0;

		// Token: 0x04002895 RID: 10389
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWithCore_Internal_Void_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_0;

		// Token: 0x04002896 RID: 10390
		private static readonly IntPtr NativeMethodInfoPtr_AddCompletionAction_Internal_Void_ITaskCompletionAction_0;

		// Token: 0x04002897 RID: 10391
		private static readonly IntPtr NativeMethodInfoPtr_AddCompletionAction_Private_Void_ITaskCompletionAction_Boolean_0;

		// Token: 0x04002898 RID: 10392
		private static readonly IntPtr NativeMethodInfoPtr_AddTaskContinuationComplex_Private_Boolean_Object_Boolean_0;

		// Token: 0x04002899 RID: 10393
		private static readonly IntPtr NativeMethodInfoPtr_AddTaskContinuation_Private_Boolean_Object_Boolean_0;

		// Token: 0x0400289A RID: 10394
		private static readonly IntPtr NativeMethodInfoPtr_RemoveContinuation_Internal_Void_Object_0;

		// Token: 0x0400289B RID: 10395
		private static readonly IntPtr NativeMethodInfoPtr_FromResult_Public_Static_Task_1_TResult_TResult_0;

		// Token: 0x0400289C RID: 10396
		private static readonly IntPtr NativeMethodInfoPtr_FromException_Public_Static_Task_Exception_0;

		// Token: 0x0400289D RID: 10397
		private static readonly IntPtr NativeMethodInfoPtr_FromException_Public_Static_Task_1_TResult_Exception_0;

		// Token: 0x0400289E RID: 10398
		private static readonly IntPtr NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_CancellationToken_0;

		// Token: 0x0400289F RID: 10399
		private static readonly IntPtr NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_CancellationToken_0;

		// Token: 0x040028A0 RID: 10400
		private static readonly IntPtr NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_OperationCanceledException_0;

		// Token: 0x040028A1 RID: 10401
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Task_Action_0;

		// Token: 0x040028A2 RID: 10402
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_TResult_0;

		// Token: 0x040028A3 RID: 10403
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_0;

		// Token: 0x040028A4 RID: 10404
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_CancellationToken_0;

		// Token: 0x040028A5 RID: 10405
		private static readonly IntPtr NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_0;

		// Token: 0x040028A6 RID: 10406
		private static readonly IntPtr NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_CancellationToken_0;

		// Token: 0x040028A7 RID: 10407
		private static readonly IntPtr NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_Il2CppReferenceArray_1_Task_0;

		// Token: 0x040028A8 RID: 10408
		private static readonly IntPtr NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_IEnumerable_1_Task_0;

		// Token: 0x02000608 RID: 1544
		public class ContingentProperties : Object
		{
			// Token: 0x060054BB RID: 21691 RVA: 0x0017CA5C File Offset: 0x0017AC5C
			// Note: this type is marked as 'beforefieldinit'.
			static ContingentProperties()
			{
				Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Task>.NativeClassPtr, "ContingentProperties");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr);
				Task.ContingentProperties.NativeFieldInfoPtr_m_capturedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_capturedContext");
				Task.ContingentProperties.NativeFieldInfoPtr_m_completionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_completionEvent");
				Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionsHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_exceptionsHolder");
				Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_cancellationToken");
				Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationRegistration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_cancellationRegistration");
				Task.ContingentProperties.NativeFieldInfoPtr_m_internalCancellationRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_internalCancellationRequested");
				Task.ContingentProperties.NativeFieldInfoPtr_m_completionCountdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_completionCountdown");
				Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionalChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_exceptionalChildren");
				Task.ContingentProperties.NativeMethodInfoPtr_SetCompleted_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, 100670781);
				Task.ContingentProperties.NativeMethodInfoPtr_DeregisterCancellationCallback_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, 100670782);
				Task.ContingentProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, 100670783);
			}

			// Token: 0x060054BC RID: 21692 RVA: 0x0017CB64 File Offset: 0x0017AD64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205320, XrefRangeEnd = 205321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetCompleted()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.ContingentProperties.NativeMethodInfoPtr_SetCompleted_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054BD RID: 21693 RVA: 0x0017CB98 File Offset: 0x0017AD98
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 205323, RefRangeEnd = 205325, XrefRangeStart = 205321, XrefRangeEnd = 205323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DeregisterCancellationCallback()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.ContingentProperties.NativeMethodInfoPtr_DeregisterCancellationCallback_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054BE RID: 21694 RVA: 0x0017CBCC File Offset: 0x0017ADCC
			[CallerCount(0)]
			public unsafe ContingentProperties()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.ContingentProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054BF RID: 21695 RVA: 0x00020022 File Offset: 0x0001E222
			public ContingentProperties(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015BA RID: 5562
			// (get) Token: 0x060054C0 RID: 21696 RVA: 0x0017CC08 File Offset: 0x0017AE08
			// (set) Token: 0x060054C1 RID: 21697 RVA: 0x0002002B File Offset: 0x0001E22B
			public unsafe ExecutionContext m_capturedContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_capturedContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_capturedContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015BB RID: 5563
			// (get) Token: 0x060054C2 RID: 21698 RVA: 0x0017CC38 File Offset: 0x0017AE38
			// (set) Token: 0x060054C3 RID: 21699 RVA: 0x0002004A File Offset: 0x0001E24A
			public unsafe ManualResetEventSlim m_completionEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_completionEvent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEventSlim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_completionEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015BC RID: 5564
			// (get) Token: 0x060054C4 RID: 21700 RVA: 0x0017CC68 File Offset: 0x0017AE68
			// (set) Token: 0x060054C5 RID: 21701 RVA: 0x00020069 File Offset: 0x0001E269
			public unsafe TaskExceptionHolder m_exceptionsHolder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionsHolder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskExceptionHolder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionsHolder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015BD RID: 5565
			// (get) Token: 0x060054C6 RID: 21702 RVA: 0x0017CC98 File Offset: 0x0017AE98
			// (set) Token: 0x060054C7 RID: 21703 RVA: 0x00020088 File Offset: 0x0001E288
			public CancellationToken m_cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170015BE RID: 5566
			// (get) Token: 0x060054C8 RID: 21704 RVA: 0x0017CCC8 File Offset: 0x0017AEC8
			// (set) Token: 0x060054C9 RID: 21705 RVA: 0x000200B6 File Offset: 0x0001E2B6
			public unsafe Shared<CancellationTokenRegistration> m_cancellationRegistration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationRegistration);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shared<CancellationTokenRegistration>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationRegistration), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015BF RID: 5567
			// (get) Token: 0x060054CA RID: 21706 RVA: 0x0017CCF8 File Offset: 0x0017AEF8
			// (set) Token: 0x060054CB RID: 21707 RVA: 0x000200D5 File Offset: 0x0001E2D5
			public unsafe int m_internalCancellationRequested
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_internalCancellationRequested);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_internalCancellationRequested)) = value;
				}
			}

			// Token: 0x170015C0 RID: 5568
			// (get) Token: 0x060054CC RID: 21708 RVA: 0x0017CD20 File Offset: 0x0017AF20
			// (set) Token: 0x060054CD RID: 21709 RVA: 0x000200F0 File Offset: 0x0001E2F0
			public unsafe int m_completionCountdown
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_completionCountdown);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_completionCountdown)) = value;
				}
			}

			// Token: 0x170015C1 RID: 5569
			// (get) Token: 0x060054CE RID: 21710 RVA: 0x0017CD48 File Offset: 0x0017AF48
			// (set) Token: 0x060054CF RID: 21711 RVA: 0x0002010B File Offset: 0x0001E30B
			public unsafe List<Task> m_exceptionalChildren
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionalChildren);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Task>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionalChildren), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004490 RID: 17552
			private static readonly IntPtr NativeFieldInfoPtr_m_capturedContext;

			// Token: 0x04004491 RID: 17553
			private static readonly IntPtr NativeFieldInfoPtr_m_completionEvent;

			// Token: 0x04004492 RID: 17554
			private static readonly IntPtr NativeFieldInfoPtr_m_exceptionsHolder;

			// Token: 0x04004493 RID: 17555
			private static readonly IntPtr NativeFieldInfoPtr_m_cancellationToken;

			// Token: 0x04004494 RID: 17556
			private static readonly IntPtr NativeFieldInfoPtr_m_cancellationRegistration;

			// Token: 0x04004495 RID: 17557
			private static readonly IntPtr NativeFieldInfoPtr_m_internalCancellationRequested;

			// Token: 0x04004496 RID: 17558
			private static readonly IntPtr NativeFieldInfoPtr_m_completionCountdown;

			// Token: 0x04004497 RID: 17559
			private static readonly IntPtr NativeFieldInfoPtr_m_exceptionalChildren;

			// Token: 0x04004498 RID: 17560
			private static readonly IntPtr NativeMethodInfoPtr_SetCompleted_Internal_Void_0;

			// Token: 0x04004499 RID: 17561
			private static readonly IntPtr NativeMethodInfoPtr_DeregisterCancellationCallback_Internal_Void_0;

			// Token: 0x0400449A RID: 17562
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000609 RID: 1545
		public sealed class SetOnInvokeMres : ManualResetEventSlim
		{
			// Token: 0x060054D0 RID: 21712 RVA: 0x0017CD78 File Offset: 0x0017AF78
			// Note: this type is marked as 'beforefieldinit'.
			static SetOnInvokeMres()
			{
				Il2CppClassPointerStore<Task.SetOnInvokeMres>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Task>.NativeClassPtr, "SetOnInvokeMres");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task.SetOnInvokeMres>.NativeClassPtr);
				Task.SetOnInvokeMres.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.SetOnInvokeMres>.NativeClassPtr, 100670784);
				Task.SetOnInvokeMres.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.SetOnInvokeMres>.NativeClassPtr, 100670785);
			}

			// Token: 0x060054D1 RID: 21713 RVA: 0x0017CDCC File Offset: 0x0017AFCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205325, XrefRangeEnd = 205329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetOnInvokeMres()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task.SetOnInvokeMres>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.SetOnInvokeMres.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054D2 RID: 21714 RVA: 0x0017CE08 File Offset: 0x0017B008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Task completingTask)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.SetOnInvokeMres.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060054D3 RID: 21715 RVA: 0x0002012A File Offset: 0x0001E32A
			public SetOnInvokeMres(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400449B RID: 17563
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x0400449C RID: 17564
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0;
		}

		// Token: 0x0200060A RID: 1546
		public sealed class DelayPromise : Task<VoidTaskResult>
		{
			// Token: 0x060054D4 RID: 21716 RVA: 0x0017CE4C File Offset: 0x0017B04C
			// Note: this type is marked as 'beforefieldinit'.
			static DelayPromise()
			{
				Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Task>.NativeClassPtr, "DelayPromise");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr);
				Task.DelayPromise.NativeFieldInfoPtr_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr, "Token");
				Task.DelayPromise.NativeFieldInfoPtr_Registration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr, "Registration");
				Task.DelayPromise.NativeFieldInfoPtr_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr, "Timer");
				Task.DelayPromise.NativeMethodInfoPtr__ctor_Internal_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr, 100670786);
				Task.DelayPromise.NativeMethodInfoPtr_Complete_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr, 100670787);
			}

			// Token: 0x060054D5 RID: 21717 RVA: 0x0017CEDC File Offset: 0x0017B0DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205329, XrefRangeEnd = 205343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DelayPromise(CancellationToken token)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.DelayPromise.NativeMethodInfoPtr__ctor_Internal_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060054D6 RID: 21718 RVA: 0x0017CF2C File Offset: 0x0017B12C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 205364, RefRangeEnd = 205366, XrefRangeStart = 205343, XrefRangeEnd = 205364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Complete()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.DelayPromise.NativeMethodInfoPtr_Complete_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054D7 RID: 21719 RVA: 0x00020133 File Offset: 0x0001E333
			public DelayPromise(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015C2 RID: 5570
			// (get) Token: 0x060054D8 RID: 21720 RVA: 0x0017CF60 File Offset: 0x0017B160
			// (set) Token: 0x060054D9 RID: 21721 RVA: 0x0002013C File Offset: 0x0001E33C
			public CancellationToken Token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Token);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Token), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170015C3 RID: 5571
			// (get) Token: 0x060054DA RID: 21722 RVA: 0x0017CF90 File Offset: 0x0017B190
			// (set) Token: 0x060054DB RID: 21723 RVA: 0x0002016A File Offset: 0x0001E36A
			public CancellationTokenRegistration Registration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Registration);
					return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Registration), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170015C4 RID: 5572
			// (get) Token: 0x060054DC RID: 21724 RVA: 0x0017CFC0 File Offset: 0x0017B1C0
			// (set) Token: 0x060054DD RID: 21725 RVA: 0x00020198 File Offset: 0x0001E398
			public unsafe Timer Timer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Timer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Timer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400449D RID: 17565
			private static readonly IntPtr NativeFieldInfoPtr_Token;

			// Token: 0x0400449E RID: 17566
			private static readonly IntPtr NativeFieldInfoPtr_Registration;

			// Token: 0x0400449F RID: 17567
			private static readonly IntPtr NativeFieldInfoPtr_Timer;

			// Token: 0x040044A0 RID: 17568
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CancellationToken_0;

			// Token: 0x040044A1 RID: 17569
			private static readonly IntPtr NativeMethodInfoPtr_Complete_Internal_Void_0;
		}

		// Token: 0x0200060B RID: 1547
		[ObfuscatedName("System.Threading.Tasks.Task+<>c__DisplayClass178_0")]
		public sealed class __c__DisplayClass178_0 : Object
		{
			// Token: 0x060054DE RID: 21726 RVA: 0x0017CFF0 File Offset: 0x0017B1F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass178_0()
			{
				Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Task>.NativeClassPtr, "<>c__DisplayClass178_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr);
				Task.__c__DisplayClass178_0.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr, "root");
				Task.__c__DisplayClass178_0.NativeFieldInfoPtr_replicasAreQuitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr, "replicasAreQuitting");
				Task.__c__DisplayClass178_0.NativeFieldInfoPtr_taskReplicaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr, "taskReplicaDelegate");
				Task.__c__DisplayClass178_0.NativeFieldInfoPtr_creationOptionsForReplicas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr, "creationOptionsForReplicas");
				Task.__c__DisplayClass178_0.NativeFieldInfoPtr_internalOptionsForReplicas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr, "internalOptionsForReplicas");
				Task.__c__DisplayClass178_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr, 100670788);
				Task.__c__DisplayClass178_0.NativeMethodInfoPtr__ExecuteSelfReplicating_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr, 100670789);
			}

			// Token: 0x060054DF RID: 21727 RVA: 0x0017D0A8 File Offset: 0x0017B2A8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass178_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c__DisplayClass178_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054E0 RID: 21728 RVA: 0x0017D0E4 File Offset: 0x0017B2E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205366, XrefRangeEnd = 205394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ExecuteSelfReplicating_b__0(Object <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c__DisplayClass178_0.NativeMethodInfoPtr__ExecuteSelfReplicating_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060054E1 RID: 21729 RVA: 0x000201B7 File Offset: 0x0001E3B7
			public __c__DisplayClass178_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015C5 RID: 5573
			// (get) Token: 0x060054E2 RID: 21730 RVA: 0x0017D128 File Offset: 0x0017B328
			// (set) Token: 0x060054E3 RID: 21731 RVA: 0x000201C0 File Offset: 0x0001E3C0
			public unsafe Task root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_root);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015C6 RID: 5574
			// (get) Token: 0x060054E4 RID: 21732 RVA: 0x0017D158 File Offset: 0x0017B358
			// (set) Token: 0x060054E5 RID: 21733 RVA: 0x000201DF File Offset: 0x0001E3DF
			public unsafe bool replicasAreQuitting
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_replicasAreQuitting);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_replicasAreQuitting)) = value;
				}
			}

			// Token: 0x170015C7 RID: 5575
			// (get) Token: 0x060054E6 RID: 21734 RVA: 0x0017D180 File Offset: 0x0017B380
			// (set) Token: 0x060054E7 RID: 21735 RVA: 0x000201FA File Offset: 0x0001E3FA
			public unsafe Action<Object> taskReplicaDelegate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_taskReplicaDelegate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_taskReplicaDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015C8 RID: 5576
			// (get) Token: 0x060054E8 RID: 21736 RVA: 0x0017D1B0 File Offset: 0x0017B3B0
			// (set) Token: 0x060054E9 RID: 21737 RVA: 0x00020219 File Offset: 0x0001E419
			public unsafe TaskCreationOptions creationOptionsForReplicas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_creationOptionsForReplicas);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_creationOptionsForReplicas)) = value;
				}
			}

			// Token: 0x170015C9 RID: 5577
			// (get) Token: 0x060054EA RID: 21738 RVA: 0x0017D1D8 File Offset: 0x0017B3D8
			// (set) Token: 0x060054EB RID: 21739 RVA: 0x00020234 File Offset: 0x0001E434
			public unsafe InternalTaskOptions internalOptionsForReplicas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_internalOptionsForReplicas);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_internalOptionsForReplicas)) = value;
				}
			}

			// Token: 0x040044A2 RID: 17570
			private static readonly IntPtr NativeFieldInfoPtr_root;

			// Token: 0x040044A3 RID: 17571
			private static readonly IntPtr NativeFieldInfoPtr_replicasAreQuitting;

			// Token: 0x040044A4 RID: 17572
			private static readonly IntPtr NativeFieldInfoPtr_taskReplicaDelegate;

			// Token: 0x040044A5 RID: 17573
			private static readonly IntPtr NativeFieldInfoPtr_creationOptionsForReplicas;

			// Token: 0x040044A6 RID: 17574
			private static readonly IntPtr NativeFieldInfoPtr_internalOptionsForReplicas;

			// Token: 0x040044A7 RID: 17575
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040044A8 RID: 17576
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteSelfReplicating_b__0_Internal_Void_Object_0;
		}

		// Token: 0x0200060C RID: 1548
		[ObfuscatedName("System.Threading.Tasks.Task+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060054EC RID: 21740 RVA: 0x0017D200 File Offset: 0x0017B400
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Task.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Task>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task.__c>.NativeClassPtr);
				Task.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, "<>9");
				Task.__c.NativeFieldInfoPtr___9__276_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, "<>9__276_0");
				Task.__c.NativeFieldInfoPtr___9__276_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, "<>9__276_1");
				Task.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100670791);
				Task.__c.NativeMethodInfoPtr__Delay_b__276_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100670792);
				Task.__c.NativeMethodInfoPtr__Delay_b__276_1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100670793);
				Task.__c.NativeMethodInfoPtr___cctor_b__295_0_Internal_ContingentProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100670794);
				Task.__c.NativeMethodInfoPtr___cctor_b__295_1_Internal_Boolean_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100670795);
				Task.__c.NativeMethodInfoPtr___cctor_b__295_2_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100670796);
			}

			// Token: 0x060054ED RID: 21741 RVA: 0x0017D2E0 File Offset: 0x0017B4E0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054EE RID: 21742 RVA: 0x0017D31C File Offset: 0x0017B51C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205394, XrefRangeEnd = 205399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Delay_b__276_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr__Delay_b__276_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060054EF RID: 21743 RVA: 0x0017D360 File Offset: 0x0017B560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205399, XrefRangeEnd = 205404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Delay_b__276_1(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr__Delay_b__276_1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060054F0 RID: 21744 RVA: 0x0017D3A4 File Offset: 0x0017B5A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205404, XrefRangeEnd = 205407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task.ContingentProperties __cctor_b__295_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr___cctor_b__295_0_Internal_ContingentProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task.ContingentProperties>(intPtr3) : null;
			}

			// Token: 0x060054F1 RID: 21745 RVA: 0x0017D3E4 File Offset: 0x0017B5E4
			[CallerCount(0)]
			public unsafe bool __cctor_b__295_1(Task t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr___cctor_b__295_1_Internal_Boolean_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060054F2 RID: 21746 RVA: 0x0017D434 File Offset: 0x0017B634
			[CallerCount(0)]
			public unsafe bool __cctor_b__295_2(Object tc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tc);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr___cctor_b__295_2_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060054F3 RID: 21747 RVA: 0x0002024F File Offset: 0x0001E44F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015CA RID: 5578
			// (get) Token: 0x060054F4 RID: 21748 RVA: 0x0017D484 File Offset: 0x0017B684
			// (set) Token: 0x060054F5 RID: 21749 RVA: 0x00020258 File Offset: 0x0001E458
			public unsafe static Task.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Task.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Task.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015CB RID: 5579
			// (get) Token: 0x060054F6 RID: 21750 RVA: 0x0017D4AC File Offset: 0x0017B6AC
			// (set) Token: 0x060054F7 RID: 21751 RVA: 0x0002026A File Offset: 0x0001E46A
			public unsafe static Action<Object> __9__276_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Task.__c.NativeFieldInfoPtr___9__276_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Task.__c.NativeFieldInfoPtr___9__276_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015CC RID: 5580
			// (get) Token: 0x060054F8 RID: 21752 RVA: 0x0017D4D4 File Offset: 0x0017B6D4
			// (set) Token: 0x060054F9 RID: 21753 RVA: 0x0002027C File Offset: 0x0001E47C
			public unsafe static TimerCallback __9__276_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Task.__c.NativeFieldInfoPtr___9__276_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Task.__c.NativeFieldInfoPtr___9__276_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044A9 RID: 17577
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040044AA RID: 17578
			private static readonly IntPtr NativeFieldInfoPtr___9__276_0;

			// Token: 0x040044AB RID: 17579
			private static readonly IntPtr NativeFieldInfoPtr___9__276_1;

			// Token: 0x040044AC RID: 17580
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040044AD RID: 17581
			private static readonly IntPtr NativeMethodInfoPtr__Delay_b__276_0_Internal_Void_Object_0;

			// Token: 0x040044AE RID: 17582
			private static readonly IntPtr NativeMethodInfoPtr__Delay_b__276_1_Internal_Void_Object_0;

			// Token: 0x040044AF RID: 17583
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__295_0_Internal_ContingentProperties_0;

			// Token: 0x040044B0 RID: 17584
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__295_1_Internal_Boolean_Task_0;

			// Token: 0x040044B1 RID: 17585
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__295_2_Internal_Boolean_Object_0;
		}

		// Token: 0x0200060D RID: 1549
		private sealed class MethodInfoStoreGeneric_FromResult_Public_Static_Task_1_TResult_TResult_0<TResult>
		{
			// Token: 0x040044B2 RID: 17586
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_FromResult_Public_Static_Task_1_TResult_TResult_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200060E RID: 1550
		private sealed class MethodInfoStoreGeneric_FromException_Public_Static_Task_1_TResult_Exception_0<TResult>
		{
			// Token: 0x040044B3 RID: 17587
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_FromException_Public_Static_Task_1_TResult_Exception_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200060F RID: 1551
		private sealed class MethodInfoStoreGeneric_FromCancellation_Internal_Static_Task_1_TResult_CancellationToken_0<TResult>
		{
			// Token: 0x040044B4 RID: 17588
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_CancellationToken_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000610 RID: 1552
		private sealed class MethodInfoStoreGeneric_FromCancellation_Internal_Static_Task_1_TResult_OperationCanceledException_0<TResult>
		{
			// Token: 0x040044B5 RID: 17589
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_OperationCanceledException_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000611 RID: 1553
		private sealed class MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_TResult_0<TResult>
		{
			// Token: 0x040044B6 RID: 17590
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_TResult_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000612 RID: 1554
		private sealed class MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_0<TResult>
		{
			// Token: 0x040044B7 RID: 17591
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000613 RID: 1555
		private sealed class MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_CancellationToken_0<TResult>
		{
			// Token: 0x040044B8 RID: 17592
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_CancellationToken_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}
	}
}
