using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000419 RID: 1049
	public sealed class AsyncMethodBuilderCore : ValueType
	{
		// Token: 0x060042CA RID: 17098 RVA: 0x00136334 File Offset: 0x00134534
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncMethodBuilderCore()
		{
			Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncMethodBuilderCore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr);
			AsyncMethodBuilderCore.NativeFieldInfoPtr_m_stateMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "m_stateMachine");
			AsyncMethodBuilderCore.NativeFieldInfoPtr_m_defaultContextAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "m_defaultContextAction");
			AsyncMethodBuilderCore.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100673062);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_GetCompletionAction_Internal_Action_Task_byref_MoveNextRunner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100673063);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_OutputAsyncCausalityEvents_Private_Action_Task_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100673064);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_PostBoxInitialization_Internal_Void_IAsyncStateMachine_MoveNextRunner_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100673065);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_ThrowAsync_Internal_Static_Void_Exception_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100673066);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_CreateContinuationWrapper_Internal_Static_Action_Action_Action_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100673067);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_TryGetContinuationTask_Internal_Static_Task_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100673068);
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x00136418 File Offset: 0x00134618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x00136460 File Offset: 0x00134660
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 226360, RefRangeEnd = 226363, XrefRangeStart = 226332, XrefRangeEnd = 226360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action GetCompletionAction(Task taskForTracing, ref AsyncMethodBuilderCore.MoveNextRunner runnerToInitialize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(taskForTracing);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(runnerToInitialize);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_GetCompletionAction_Internal_Action_Task_byref_MoveNextRunner_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			runnerToInitialize = ((intPtr4 == 0) ? null : new AsyncMethodBuilderCore.MoveNextRunner(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Action>(intPtr5) : null;
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x001364E0 File Offset: 0x001346E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226373, RefRangeEnd = 226375, XrefRangeStart = 226363, XrefRangeEnd = 226373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action OutputAsyncCausalityEvents(Task innerTask, Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_OutputAsyncCausalityEvents_Private_Action_Task_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x00136548 File Offset: 0x00134748
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226385, RefRangeEnd = 226387, XrefRangeStart = 226375, XrefRangeEnd = 226385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostBoxInitialization(IAsyncStateMachine stateMachine, AsyncMethodBuilderCore.MoveNextRunner runner, Task builtTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builtTask);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_PostBoxInitialization_Internal_Void_IAsyncStateMachine_MoveNextRunner_Task_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x001365B4 File Offset: 0x001347B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 226429, RefRangeEnd = 226435, XrefRangeStart = 226387, XrefRangeEnd = 226429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowAsync(Exception exception, SynchronizationContext targetContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_ThrowAsync_Internal_Static_Void_Exception_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x001365FC File Offset: 0x001347FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226446, RefRangeEnd = 226447, XrefRangeStart = 226435, XrefRangeEnd = 226446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(invokeAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerTask);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_CreateContinuationWrapper_Internal_Static_Action_Action_Action_Task_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x00136664 File Offset: 0x00134864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226447, XrefRangeEnd = 226449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task TryGetContinuationTask(Action action)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_TryGetContinuationTask_Internal_Static_Task_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060042D2 RID: 17106 RVA: 0x000193CD File Offset: 0x000175CD
		public AsyncMethodBuilderCore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x000193D6 File Offset: 0x000175D6
		public AsyncMethodBuilderCore()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr))
		{
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x060042D4 RID: 17108 RVA: 0x001366A8 File Offset: 0x001348A8
		// (set) Token: 0x060042D5 RID: 17109 RVA: 0x000193E8 File Offset: 0x000175E8
		public unsafe IAsyncStateMachine m_stateMachine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.NativeFieldInfoPtr_m_stateMachine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncStateMachine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.NativeFieldInfoPtr_m_stateMachine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x060042D6 RID: 17110 RVA: 0x001366D8 File Offset: 0x001348D8
		// (set) Token: 0x060042D7 RID: 17111 RVA: 0x00019407 File Offset: 0x00017607
		public unsafe Action m_defaultContextAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.NativeFieldInfoPtr_m_defaultContextAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.NativeFieldInfoPtr_m_defaultContextAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400366D RID: 13933
		private static readonly IntPtr NativeFieldInfoPtr_m_stateMachine;

		// Token: 0x0400366E RID: 13934
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultContextAction;

		// Token: 0x0400366F RID: 13935
		private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0;

		// Token: 0x04003670 RID: 13936
		private static readonly IntPtr NativeMethodInfoPtr_GetCompletionAction_Internal_Action_Task_byref_MoveNextRunner_0;

		// Token: 0x04003671 RID: 13937
		private static readonly IntPtr NativeMethodInfoPtr_OutputAsyncCausalityEvents_Private_Action_Task_Action_0;

		// Token: 0x04003672 RID: 13938
		private static readonly IntPtr NativeMethodInfoPtr_PostBoxInitialization_Internal_Void_IAsyncStateMachine_MoveNextRunner_Task_0;

		// Token: 0x04003673 RID: 13939
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAsync_Internal_Static_Void_Exception_SynchronizationContext_0;

		// Token: 0x04003674 RID: 13940
		private static readonly IntPtr NativeMethodInfoPtr_CreateContinuationWrapper_Internal_Static_Action_Action_Action_Task_0;

		// Token: 0x04003675 RID: 13941
		private static readonly IntPtr NativeMethodInfoPtr_TryGetContinuationTask_Internal_Static_Task_Action_0;

		// Token: 0x0200063E RID: 1598
		public sealed class MoveNextRunner : Object
		{
			// Token: 0x0600563C RID: 22076 RVA: 0x00180F20 File Offset: 0x0017F120
			// Note: this type is marked as 'beforefieldinit'.
			static MoveNextRunner()
			{
				Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "MoveNextRunner");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr);
				AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, "m_context");
				AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_stateMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, "m_stateMachine");
				AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_s_invokeMoveNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, "s_invokeMoveNext");
				AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr__ctor_Internal_Void_ExecutionContext_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, 100673069);
				AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr_Run_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, 100673070);
				AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr_InvokeMoveNext_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, 100673071);
			}

			// Token: 0x0600563D RID: 22077 RVA: 0x00180FC4 File Offset: 0x0017F1C4
			[CallerCount(76)]
			[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MoveNextRunner(ExecutionContext context, IAsyncStateMachine stateMachine)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr__ctor_Internal_Void_ExecutionContext_IAsyncStateMachine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600563E RID: 22078 RVA: 0x00181024 File Offset: 0x0017F224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226280, XrefRangeEnd = 226296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Run()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr_Run_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600563F RID: 22079 RVA: 0x00181058 File Offset: 0x0017F258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226296, XrefRangeEnd = 226310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void InvokeMoveNext(Object stateMachine)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr_InvokeMoveNext_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005640 RID: 22080 RVA: 0x00020DD3 File Offset: 0x0001EFD3
			public MoveNextRunner(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700162F RID: 5679
			// (get) Token: 0x06005641 RID: 22081 RVA: 0x00181090 File Offset: 0x0017F290
			// (set) Token: 0x06005642 RID: 22082 RVA: 0x00020DDC File Offset: 0x0001EFDC
			public unsafe ExecutionContext m_context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001630 RID: 5680
			// (get) Token: 0x06005643 RID: 22083 RVA: 0x001810C0 File Offset: 0x0017F2C0
			// (set) Token: 0x06005644 RID: 22084 RVA: 0x00020DFB File Offset: 0x0001EFFB
			public unsafe IAsyncStateMachine m_stateMachine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_stateMachine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncStateMachine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_stateMachine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001631 RID: 5681
			// (get) Token: 0x06005645 RID: 22085 RVA: 0x001810F0 File Offset: 0x0017F2F0
			// (set) Token: 0x06005646 RID: 22086 RVA: 0x00020E1A File Offset: 0x0001F01A
			public unsafe static ContextCallback s_invokeMoveNext
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_s_invokeMoveNext, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_s_invokeMoveNext, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400456B RID: 17771
			private static readonly IntPtr NativeFieldInfoPtr_m_context;

			// Token: 0x0400456C RID: 17772
			private static readonly IntPtr NativeFieldInfoPtr_m_stateMachine;

			// Token: 0x0400456D RID: 17773
			private static readonly IntPtr NativeFieldInfoPtr_s_invokeMoveNext;

			// Token: 0x0400456E RID: 17774
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ExecutionContext_IAsyncStateMachine_0;

			// Token: 0x0400456F RID: 17775
			private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Void_0;

			// Token: 0x04004570 RID: 17776
			private static readonly IntPtr NativeMethodInfoPtr_InvokeMoveNext_Private_Static_Void_Object_0;
		}

		// Token: 0x0200063F RID: 1599
		public class ContinuationWrapper : Object
		{
			// Token: 0x06005647 RID: 22087 RVA: 0x00181118 File Offset: 0x0017F318
			// Note: this type is marked as 'beforefieldinit'.
			static ContinuationWrapper()
			{
				Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "ContinuationWrapper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr);
				AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr, "m_continuation");
				AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_invokeAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr, "m_invokeAction");
				AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_innerTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr, "m_innerTask");
				AsyncMethodBuilderCore.ContinuationWrapper.NativeMethodInfoPtr__ctor_Internal_Void_Action_Action_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr, 100673072);
				AsyncMethodBuilderCore.ContinuationWrapper.NativeMethodInfoPtr_Invoke_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr, 100673073);
			}

			// Token: 0x06005648 RID: 22088 RVA: 0x001811A8 File Offset: 0x0017F3A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226310, XrefRangeEnd = 226313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContinuationWrapper(Action continuation, Action invokeAction, Task innerTask)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(invokeAction);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.ContinuationWrapper.NativeMethodInfoPtr__ctor_Internal_Void_Action_Action_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005649 RID: 22089 RVA: 0x00181218 File Offset: 0x0017F418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226313, XrefRangeEnd = 226315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.ContinuationWrapper.NativeMethodInfoPtr_Invoke_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600564A RID: 22090 RVA: 0x00020E2C File Offset: 0x0001F02C
			public ContinuationWrapper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001632 RID: 5682
			// (get) Token: 0x0600564B RID: 22091 RVA: 0x0018124C File Offset: 0x0017F44C
			// (set) Token: 0x0600564C RID: 22092 RVA: 0x00020E35 File Offset: 0x0001F035
			public unsafe Action m_continuation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_continuation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_continuation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001633 RID: 5683
			// (get) Token: 0x0600564D RID: 22093 RVA: 0x0018127C File Offset: 0x0017F47C
			// (set) Token: 0x0600564E RID: 22094 RVA: 0x00020E54 File Offset: 0x0001F054
			public unsafe Action m_invokeAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_invokeAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_invokeAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001634 RID: 5684
			// (get) Token: 0x0600564F RID: 22095 RVA: 0x001812AC File Offset: 0x0017F4AC
			// (set) Token: 0x06005650 RID: 22096 RVA: 0x00020E73 File Offset: 0x0001F073
			public unsafe Task m_innerTask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_innerTask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_innerTask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004571 RID: 17777
			private static readonly IntPtr NativeFieldInfoPtr_m_continuation;

			// Token: 0x04004572 RID: 17778
			private static readonly IntPtr NativeFieldInfoPtr_m_invokeAction;

			// Token: 0x04004573 RID: 17779
			private static readonly IntPtr NativeFieldInfoPtr_m_innerTask;

			// Token: 0x04004574 RID: 17780
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Action_Action_Task_0;

			// Token: 0x04004575 RID: 17781
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Internal_Void_0;
		}

		// Token: 0x02000640 RID: 1600
		[ObfuscatedName("System.Runtime.CompilerServices.AsyncMethodBuilderCore+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06005651 RID: 22097 RVA: 0x001812DC File Offset: 0x0017F4DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass4_0>.NativeClassPtr);
				AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeFieldInfoPtr_innerTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass4_0>.NativeClassPtr, "innerTask");
				AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeFieldInfoPtr_continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass4_0>.NativeClassPtr, "continuation");
				AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass4_0>.NativeClassPtr, 100673074);
				AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeMethodInfoPtr__OutputAsyncCausalityEvents_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass4_0>.NativeClassPtr, 100673075);
			}

			// Token: 0x06005652 RID: 22098 RVA: 0x00181358 File Offset: 0x0017F558
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005653 RID: 22099 RVA: 0x00181394 File Offset: 0x0017F594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226315, XrefRangeEnd = 226318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OutputAsyncCausalityEvents_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeMethodInfoPtr__OutputAsyncCausalityEvents_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005654 RID: 22100 RVA: 0x00020E92 File Offset: 0x0001F092
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001635 RID: 5685
			// (get) Token: 0x06005655 RID: 22101 RVA: 0x001813C8 File Offset: 0x0017F5C8
			// (set) Token: 0x06005656 RID: 22102 RVA: 0x00020E9B File Offset: 0x0001F09B
			public unsafe Task innerTask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeFieldInfoPtr_innerTask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeFieldInfoPtr_innerTask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001636 RID: 5686
			// (get) Token: 0x06005657 RID: 22103 RVA: 0x001813F8 File Offset: 0x0017F5F8
			// (set) Token: 0x06005658 RID: 22104 RVA: 0x00020EBA File Offset: 0x0001F0BA
			public unsafe Action continuation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeFieldInfoPtr_continuation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeFieldInfoPtr_continuation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004576 RID: 17782
			private static readonly IntPtr NativeFieldInfoPtr_innerTask;

			// Token: 0x04004577 RID: 17783
			private static readonly IntPtr NativeFieldInfoPtr_continuation;

			// Token: 0x04004578 RID: 17784
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004579 RID: 17785
			private static readonly IntPtr NativeMethodInfoPtr__OutputAsyncCausalityEvents_b__0_Internal_Void_0;
		}

		// Token: 0x02000641 RID: 1601
		[ObfuscatedName("System.Runtime.CompilerServices.AsyncMethodBuilderCore+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005659 RID: 22105 RVA: 0x00181428 File Offset: 0x0017F628
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr);
				AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, "<>9");
				AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, "<>9__6_0");
				AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, "<>9__6_1");
				AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, 100673077);
				AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ThrowAsync_b__6_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, 100673078);
				AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ThrowAsync_b__6_1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, 100673079);
			}

			// Token: 0x0600565A RID: 22106 RVA: 0x001814CC File Offset: 0x0017F6CC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600565B RID: 22107 RVA: 0x00181508 File Offset: 0x0017F708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226318, XrefRangeEnd = 226325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ThrowAsync_b__6_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ThrowAsync_b__6_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600565C RID: 22108 RVA: 0x0018154C File Offset: 0x0017F74C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226325, XrefRangeEnd = 226332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ThrowAsync_b__6_1(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ThrowAsync_b__6_1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600565D RID: 22109 RVA: 0x00020ED9 File Offset: 0x0001F0D9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001637 RID: 5687
			// (get) Token: 0x0600565E RID: 22110 RVA: 0x00181590 File Offset: 0x0017F790
			// (set) Token: 0x0600565F RID: 22111 RVA: 0x00020EE2 File Offset: 0x0001F0E2
			public unsafe static AsyncMethodBuilderCore.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncMethodBuilderCore.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001638 RID: 5688
			// (get) Token: 0x06005660 RID: 22112 RVA: 0x001815B8 File Offset: 0x0017F7B8
			// (set) Token: 0x06005661 RID: 22113 RVA: 0x00020EF4 File Offset: 0x0001F0F4
			public unsafe static SendOrPostCallback __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001639 RID: 5689
			// (get) Token: 0x06005662 RID: 22114 RVA: 0x001815E0 File Offset: 0x0017F7E0
			// (set) Token: 0x06005663 RID: 22115 RVA: 0x00020F06 File Offset: 0x0001F106
			public unsafe static WaitCallback __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400457A RID: 17786
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400457B RID: 17787
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400457C RID: 17788
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x0400457D RID: 17789
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400457E RID: 17790
			private static readonly IntPtr NativeMethodInfoPtr__ThrowAsync_b__6_0_Internal_Void_Object_0;

			// Token: 0x0400457F RID: 17791
			private static readonly IntPtr NativeMethodInfoPtr__ThrowAsync_b__6_1_Internal_Void_Object_0;
		}
	}
}
