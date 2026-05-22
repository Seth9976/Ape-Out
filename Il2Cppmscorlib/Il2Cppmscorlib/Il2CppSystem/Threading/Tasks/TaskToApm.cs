using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002BE RID: 702
	public static class TaskToApm : Object
	{
		// Token: 0x06002FCF RID: 12239 RVA: 0x000F2BBC File Offset: 0x000F0DBC
		// Note: this type is marked as 'beforefieldinit'.
		static TaskToApm()
		{
			Il2CppClassPointerStore<TaskToApm>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskToApm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr);
			TaskToApm.NativeMethodInfoPtr_Begin_Public_Static_IAsyncResult_Task_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, 100670909);
			TaskToApm.NativeMethodInfoPtr_End_Public_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, 100670910);
			TaskToApm.NativeMethodInfoPtr_End_Public_Static_TResult_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, 100670911);
			TaskToApm.NativeMethodInfoPtr_InvokeCallbackWhenTaskCompletes_Private_Static_Void_Task_AsyncCallback_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, 100670912);
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x000F2C3C File Offset: 0x000F0E3C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 207552, RefRangeEnd = 207559, XrefRangeStart = 207538, XrefRangeEnd = 207552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IAsyncResult Begin(Task task, AsyncCallback callback, Object state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.NativeMethodInfoPtr_Begin_Public_Static_IAsyncResult_Task_AsyncCallback_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x000F2CA4 File Offset: 0x000F0EA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207565, RefRangeEnd = 207568, XrefRangeStart = 207559, XrefRangeEnd = 207565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void End(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.NativeMethodInfoPtr_End_Public_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x000F2CDC File Offset: 0x000F0EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207568, XrefRangeEnd = 207574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TResult End<TResult>(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.MethodInfoStoreGeneric_End_Public_Static_TResult_IAsyncResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x000F2D1C File Offset: 0x000F0F1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207584, RefRangeEnd = 207585, XrefRangeStart = 207574, XrefRangeEnd = 207584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(antecedent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.NativeMethodInfoPtr_InvokeCallbackWhenTaskCompletes_Private_Static_Void_Task_AsyncCallback_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x000108D3 File Offset: 0x0000EAD3
		public TaskToApm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002951 RID: 10577
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Static_IAsyncResult_Task_AsyncCallback_Object_0;

		// Token: 0x04002952 RID: 10578
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Static_Void_IAsyncResult_0;

		// Token: 0x04002953 RID: 10579
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Static_TResult_IAsyncResult_0;

		// Token: 0x04002954 RID: 10580
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCallbackWhenTaskCompletes_Private_Static_Void_Task_AsyncCallback_IAsyncResult_0;

		// Token: 0x0200061D RID: 1565
		public sealed class TaskWrapperAsyncResult : Object
		{
			// Token: 0x0600552C RID: 21804 RVA: 0x0017DED8 File Offset: 0x0017C0D8
			// Note: this type is marked as 'beforefieldinit'.
			static TaskWrapperAsyncResult()
			{
				Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, "TaskWrapperAsyncResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr);
				TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_Task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, "Task");
				TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_m_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, "m_state");
				TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_m_completedSynchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, "m_completedSynchronously");
				TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Task_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, 100670913);
				TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncState_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, 100670914);
				TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, 100670915);
				TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_IsCompleted_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, 100670916);
				TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, 100670917);
			}

			// Token: 0x0600552D RID: 21805 RVA: 0x0017DFA4 File Offset: 0x0017C1A4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 207526, RefRangeEnd = 207528, XrefRangeStart = 207526, XrefRangeEnd = 207526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TaskWrapperAsyncResult(Task task, Object state, bool completedSynchronously)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref completedSynchronously;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Task_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015D9 RID: 5593
			// (get) Token: 0x0600552E RID: 21806 RVA: 0x0017E010 File Offset: 0x0017C210
			public unsafe Object System.IAsyncResult.AsyncState
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncState_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170015DA RID: 5594
			// (get) Token: 0x0600552F RID: 21807 RVA: 0x0017E050 File Offset: 0x0017C250
			public unsafe bool System.IAsyncResult.CompletedSynchronously
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170015DB RID: 5595
			// (get) Token: 0x06005530 RID: 21808 RVA: 0x0017E08C File Offset: 0x0017C28C
			public unsafe bool System.IAsyncResult.IsCompleted
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207528, XrefRangeEnd = 207531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_IsCompleted_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170015DC RID: 5596
			// (get) Token: 0x06005531 RID: 21809 RVA: 0x0017E0C8 File Offset: 0x0017C2C8
			public unsafe WaitHandle System.IAsyncResult.AsyncWaitHandle
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207531, XrefRangeEnd = 207538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
				}
			}

			// Token: 0x06005532 RID: 21810 RVA: 0x0002039C File Offset: 0x0001E59C
			public TaskWrapperAsyncResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015D6 RID: 5590
			// (get) Token: 0x06005533 RID: 21811 RVA: 0x0017E108 File Offset: 0x0017C308
			// (set) Token: 0x06005534 RID: 21812 RVA: 0x000203A5 File Offset: 0x0001E5A5
			public unsafe Task Task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_Task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_Task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015D7 RID: 5591
			// (get) Token: 0x06005535 RID: 21813 RVA: 0x0017E138 File Offset: 0x0017C338
			// (set) Token: 0x06005536 RID: 21814 RVA: 0x000203C4 File Offset: 0x0001E5C4
			public unsafe Object m_state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_m_state);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_m_state), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015D8 RID: 5592
			// (get) Token: 0x06005537 RID: 21815 RVA: 0x0017E168 File Offset: 0x0017C368
			// (set) Token: 0x06005538 RID: 21816 RVA: 0x000203E3 File Offset: 0x0001E5E3
			public unsafe bool m_completedSynchronously
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_m_completedSynchronously);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_m_completedSynchronously)) = value;
				}
			}

			// Token: 0x040044CF RID: 17615
			private static readonly IntPtr NativeFieldInfoPtr_Task;

			// Token: 0x040044D0 RID: 17616
			private static readonly IntPtr NativeFieldInfoPtr_m_state;

			// Token: 0x040044D1 RID: 17617
			private static readonly IntPtr NativeFieldInfoPtr_m_completedSynchronously;

			// Token: 0x040044D2 RID: 17618
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_Object_Boolean_0;

			// Token: 0x040044D3 RID: 17619
			private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_AsyncState_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040044D4 RID: 17620
			private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040044D5 RID: 17621
			private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_IsCompleted_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040044D6 RID: 17622
			private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0;
		}

		// Token: 0x0200061E RID: 1566
		[ObfuscatedName("System.Threading.Tasks.TaskToApm+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06005539 RID: 21817 RVA: 0x0017E190 File Offset: 0x0017C390
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr);
				TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr, "callback");
				TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_asyncResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr, "asyncResult");
				TaskToApm.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr, 100670918);
				TaskToApm.__c__DisplayClass3_0.NativeMethodInfoPtr__InvokeCallbackWhenTaskCompletes_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr, 100670919);
			}

			// Token: 0x0600553A RID: 21818 RVA: 0x0017E20C File Offset: 0x0017C40C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600553B RID: 21819 RVA: 0x0017E248 File Offset: 0x0017C448
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InvokeCallbackWhenTaskCompletes_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.__c__DisplayClass3_0.NativeMethodInfoPtr__InvokeCallbackWhenTaskCompletes_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600553C RID: 21820 RVA: 0x000203FE File Offset: 0x0001E5FE
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015DD RID: 5597
			// (get) Token: 0x0600553D RID: 21821 RVA: 0x0017E27C File Offset: 0x0017C47C
			// (set) Token: 0x0600553E RID: 21822 RVA: 0x00020407 File Offset: 0x0001E607
			public unsafe AsyncCallback callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015DE RID: 5598
			// (get) Token: 0x0600553F RID: 21823 RVA: 0x0017E2AC File Offset: 0x0017C4AC
			// (set) Token: 0x06005540 RID: 21824 RVA: 0x00020426 File Offset: 0x0001E626
			public unsafe IAsyncResult asyncResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_asyncResult);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_asyncResult), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044D7 RID: 17623
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x040044D8 RID: 17624
			private static readonly IntPtr NativeFieldInfoPtr_asyncResult;

			// Token: 0x040044D9 RID: 17625
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040044DA RID: 17626
			private static readonly IntPtr NativeMethodInfoPtr__InvokeCallbackWhenTaskCompletes_b__0_Internal_Void_0;
		}

		// Token: 0x0200061F RID: 1567
		private sealed class MethodInfoStoreGeneric_End_Public_Static_TResult_IAsyncResult_0<TResult>
		{
			// Token: 0x040044DB RID: 17627
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskToApm.NativeMethodInfoPtr_End_Public_Static_TResult_IAsyncResult_0, Il2CppClassPointerStore<TaskToApm>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}
	}
}
