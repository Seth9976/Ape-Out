using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A1 RID: 673
	public class Task<TResult> : Task
	{
		// Token: 0x06002DE9 RID: 11753 RVA: 0x000EA7C8 File Offset: 0x000E89C8
		// Note: this type is marked as 'beforefieldinit'.
		static Task()
		{
			Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "Task`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr);
			Task<TResult>.NativeFieldInfoPtr_m_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, "m_result");
			Task<TResult>.NativeFieldInfoPtr_s_Factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, "s_Factory");
			Task<TResult>.NativeFieldInfoPtr_TaskWhenAnyCast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, "TaskWhenAnyCast");
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670598);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670599);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670600);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TResult_TaskCreationOptions_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670601);
			Task<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670602);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Func_1_TResult_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670603);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Func_1_TResult_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670604);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Func_2_Object_TResult_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670605);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670606);
			Task<TResult>.NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_1_TResult_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670607);
			Task<TResult>.NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670608);
			Task<TResult>.NativeMethodInfoPtr_TrySetResult_Internal_Boolean_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670609);
			Task<TResult>.NativeMethodInfoPtr_DangerousSetResult_Internal_Void_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670610);
			Task<TResult>.NativeMethodInfoPtr_get_Result_Public_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670611);
			Task<TResult>.NativeMethodInfoPtr_get_ResultOnSuccess_Internal_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670612);
			Task<TResult>.NativeMethodInfoPtr_GetResultCore_Internal_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670613);
			Task<TResult>.NativeMethodInfoPtr_TrySetException_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670614);
			Task<TResult>.NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670615);
			Task<TResult>.NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670616);
			Task<TResult>.NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670617);
			Task<TResult>.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670618);
			Task<TResult>.NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670619);
			Task<TResult>.NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_1_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670620);
			Task<TResult>.NativeMethodInfoPtr_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskContinuationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670621);
			Task<TResult>.NativeMethodInfoPtr_ContinueWith_Internal_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670622);
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x000EAA64 File Offset: 0x000E8C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205058, XrefRangeEnd = 205061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x000EAAA0 File Offset: 0x000E8CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205061, XrefRangeEnd = 205065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Object state, TaskCreationOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x000EAAFC File Offset: 0x000E8CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205065, XrefRangeEnd = 205069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(TResult result)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x000EAB94 File Offset: 0x000E8D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205069, XrefRangeEnd = 205073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canceled;
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ct));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TResult_TaskCreationOptions_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x000EAC60 File Offset: 0x000E8E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205073, XrefRangeEnd = 205083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Func<Object, TResult> function, Object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x000EACE4 File Offset: 0x000E8EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205083, XrefRangeEnd = 205088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueSelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Func_1_TResult_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x000EAD98 File Offset: 0x000E8F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205088, XrefRangeEnd = 205094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueSelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Func_1_TResult_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x000EAE3C File Offset: 0x000E903C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205094, XrefRangeEnd = 205099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Func<Object, TResult> valueSelector, Object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueSelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Func_2_Object_TResult_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x000EAF04 File Offset: 0x000E9104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205099, XrefRangeEnd = 205105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Delegate valueSelector, Object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueSelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x000EAFBC File Offset: 0x000E91BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205105, XrefRangeEnd = 205111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_1_TResult_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x000EB068 File Offset: 0x000E9268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205111, XrefRangeEnd = 205117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> StartNew(Task parent, Func<Object, TResult> function, Object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x000EB128 File Offset: 0x000E9328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205117, XrefRangeEnd = 205123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetResult(TResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_TrySetResult_Internal_Boolean_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x000EB1C0 File Offset: 0x000E93C0
		[CallerCount(0)]
		public unsafe void DangerousSetResult(TResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_DangerousSetResult_Internal_Void_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06002DF7 RID: 11767 RVA: 0x000EB250 File Offset: 0x000E9450
		public unsafe TResult Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_get_Result_Public_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06002DF8 RID: 11768 RVA: 0x000EB28C File Offset: 0x000E948C
		public unsafe TResult ResultOnSuccess
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_get_ResultOnSuccess_Internal_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x000EB2C8 File Offset: 0x000E94C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205123, XrefRangeEnd = 205129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult GetResultCore(bool waitCompletionNotification)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref waitCompletionNotification;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_GetResultCore_Internal_TResult_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x000EB310 File Offset: 0x000E9510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205129, XrefRangeEnd = 205133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetException(Object exceptionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_TrySetException_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x000EB360 File Offset: 0x000E9560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205133, XrefRangeEnd = 205134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCanceled(CancellationToken tokenToRecord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tokenToRecord));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x000EB3B4 File Offset: 0x000E95B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205134, XrefRangeEnd = 205137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCanceled(CancellationToken tokenToRecord, Object cancellationException)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06002DFD RID: 11773 RVA: 0x000EB418 File Offset: 0x000E9618
		public new unsafe static TaskFactory<TResult> Factory
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205137, XrefRangeEnd = 205146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_1_TResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskFactory<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x000EB44C File Offset: 0x000E964C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205146, XrefRangeEnd = 205151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InnerInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task<TResult>.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x000EB488 File Offset: 0x000E9688
		[CallerCount(0)]
		public new unsafe TaskAwaiter<TResult> GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new TaskAwaiter<TResult>(intPtr);
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x000EB4C0 File Offset: 0x000E96C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205151, XrefRangeEnd = 205152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref continueOnCapturedContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_1_TResult_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ConfiguredTaskAwaitable<TResult>(intPtr);
			}
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x000EB504 File Offset: 0x000E9704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205152, XrefRangeEnd = 205156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationFunction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TNewResult>.MethodInfoStoreGeneric_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskContinuationOptions_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TNewResult>>(intPtr3) : null;
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x000EB564 File Offset: 0x000E9764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205156, XrefRangeEnd = 205163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationFunction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TNewResult>.MethodInfoStoreGeneric_ContinueWith_Internal_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TNewResult>>(intPtr3) : null;
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x0000FFE4 File Offset: 0x0000E1E4
		public Task(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06002E04 RID: 11780 RVA: 0x000EB5FC File Offset: 0x000E97FC
		// (set) Token: 0x06002E05 RID: 11781 RVA: 0x000EB624 File Offset: 0x000E9824
		public unsafe TResult m_result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task<TResult>.NativeFieldInfoPtr_m_result);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task<TResult>.NativeFieldInfoPtr_m_result);
				Type typeFromHandle = typeof(TResult);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002E06 RID: 11782 RVA: 0x000EB6CC File Offset: 0x000E98CC
		// (set) Token: 0x06002E07 RID: 11783 RVA: 0x0000FFED File Offset: 0x0000E1ED
		public unsafe static TaskFactory<TResult> s_Factory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task<TResult>.NativeFieldInfoPtr_s_Factory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskFactory<TResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task<TResult>.NativeFieldInfoPtr_s_Factory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06002E08 RID: 11784 RVA: 0x000EB6F4 File Offset: 0x000E98F4
		// (set) Token: 0x06002E09 RID: 11785 RVA: 0x0000FFFF File Offset: 0x0000E1FF
		public unsafe static Func<Task<Task>, Task<TResult>> TaskWhenAnyCast
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task<TResult>.NativeFieldInfoPtr_TaskWhenAnyCast, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Task<Task>, Task<TResult>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task<TResult>.NativeFieldInfoPtr_TaskWhenAnyCast, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027CA RID: 10186
		private static readonly IntPtr NativeFieldInfoPtr_m_result;

		// Token: 0x040027CB RID: 10187
		private static readonly IntPtr NativeFieldInfoPtr_s_Factory;

		// Token: 0x040027CC RID: 10188
		private static readonly IntPtr NativeFieldInfoPtr_TaskWhenAnyCast;

		// Token: 0x040027CD RID: 10189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040027CE RID: 10190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_0;

		// Token: 0x040027CF RID: 10191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TResult_0;

		// Token: 0x040027D0 RID: 10192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TResult_TaskCreationOptions_CancellationToken_0;

		// Token: 0x040027D1 RID: 10193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_0;

		// Token: 0x040027D2 RID: 10194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Func_1_TResult_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0;

		// Token: 0x040027D3 RID: 10195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Func_1_TResult_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0;

		// Token: 0x040027D4 RID: 10196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Func_2_Object_TResult_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0;

		// Token: 0x040027D5 RID: 10197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0;

		// Token: 0x040027D6 RID: 10198
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_1_TResult_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0;

		// Token: 0x040027D7 RID: 10199
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0;

		// Token: 0x040027D8 RID: 10200
		private static readonly IntPtr NativeMethodInfoPtr_TrySetResult_Internal_Boolean_TResult_0;

		// Token: 0x040027D9 RID: 10201
		private static readonly IntPtr NativeMethodInfoPtr_DangerousSetResult_Internal_Void_TResult_0;

		// Token: 0x040027DA RID: 10202
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_TResult_0;

		// Token: 0x040027DB RID: 10203
		private static readonly IntPtr NativeMethodInfoPtr_get_ResultOnSuccess_Internal_get_TResult_0;

		// Token: 0x040027DC RID: 10204
		private static readonly IntPtr NativeMethodInfoPtr_GetResultCore_Internal_TResult_Boolean_0;

		// Token: 0x040027DD RID: 10205
		private static readonly IntPtr NativeMethodInfoPtr_TrySetException_Internal_Boolean_Object_0;

		// Token: 0x040027DE RID: 10206
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_0;

		// Token: 0x040027DF RID: 10207
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_Object_0;

		// Token: 0x040027E0 RID: 10208
		private static readonly IntPtr NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_1_TResult_0;

		// Token: 0x040027E1 RID: 10209
		private static readonly IntPtr NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0;

		// Token: 0x040027E2 RID: 10210
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_1_TResult_0;

		// Token: 0x040027E3 RID: 10211
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_1_TResult_Boolean_0;

		// Token: 0x040027E4 RID: 10212
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskContinuationOptions_0;

		// Token: 0x040027E5 RID: 10213
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Internal_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0;

		// Token: 0x020005FE RID: 1534
		[ObfuscatedName("System.Threading.Tasks.Task`1+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06005482 RID: 21634 RVA: 0x0017BCE4 File Offset: 0x00179EE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Task<TResult>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task<TResult>.__c>.NativeClassPtr);
				Task<TResult>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task<TResult>.__c>.NativeClassPtr, "<>9");
				Task<TResult>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>.__c>.NativeClassPtr, 100670625);
				Task<TResult>.__c.NativeMethodInfoPtr___cctor_b__64_0_Internal_Task_1_TResult_Task_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>.__c>.NativeClassPtr, 100670626);
			}

			// Token: 0x06005483 RID: 21635 RVA: 0x0017BD88 File Offset: 0x00179F88
			[CallerCount(0)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005484 RID: 21636 RVA: 0x0017BDC4 File Offset: 0x00179FC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205054, XrefRangeEnd = 205058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<TResult> __cctor_b__64_0(Task<Task> completed)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(completed);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.__c.NativeMethodInfoPtr___cctor_b__64_0_Internal_Task_1_TResult_Task_1_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x06005485 RID: 21637 RVA: 0x0001FE73 File Offset: 0x0001E073
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015AC RID: 5548
			// (get) Token: 0x06005486 RID: 21638 RVA: 0x0017BE14 File Offset: 0x0017A014
			// (set) Token: 0x06005487 RID: 21639 RVA: 0x0001FE7C File Offset: 0x0001E07C
			public unsafe static Task<TResult>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Task<TResult>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Task<TResult>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004471 RID: 17521
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004472 RID: 17522
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004473 RID: 17523
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__64_0_Internal_Task_1_TResult_Task_1_Task_0;
		}

		// Token: 0x020005FF RID: 1535
		private sealed class MethodInfoStoreGeneric_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskContinuationOptions_0
		{
			// Token: 0x04004474 RID: 17524
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task<TNewResult>.NativeMethodInfoPtr_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskContinuationOptions_0, Il2CppClassPointerStore<Task<TNewResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNewResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000600 RID: 1536
		private sealed class MethodInfoStoreGeneric_ContinueWith_Internal_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0
		{
			// Token: 0x04004475 RID: 17525
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task<TNewResult>.NativeMethodInfoPtr_ContinueWith_Internal_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0, Il2CppClassPointerStore<Task<TNewResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNewResult>.NativeClassPtr)) }))));
		}
	}
}
