using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A3 RID: 675
	public class TaskFactory<TResult> : Object
	{
		// Token: 0x06002E0C RID: 11788 RVA: 0x000EB788 File Offset: 0x000E9988
		// Note: this type is marked as 'beforefieldinit'.
		static TaskFactory()
		{
			Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr);
			TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "m_defaultCancellationToken");
			TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "m_defaultScheduler");
			TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCreationOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "m_defaultCreationOptions");
			TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultContinuationOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "m_defaultContinuationOptions");
			TaskFactory<TResult>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100670627);
			TaskFactory<TResult>.NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100670628);
			TaskFactory<TResult>.NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_1_TResult_CancellationToken_TaskCreationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100670629);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncCoreLogic_Private_Static_Void_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Task_1_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100670630);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100670631);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100670632);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100670633);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100670634);
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x000EB8E4 File Offset: 0x000E9AE4
		[CallerCount(0)]
		public unsafe TaskFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x000EB920 File Offset: 0x000E9B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205180, XrefRangeEnd = 205181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x000EB9A0 File Offset: 0x000E9BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205181, XrefRangeEnd = 205194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_1_TResult_CancellationToken_TaskCreationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x000EBA28 File Offset: 0x000E9C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205194, XrefRangeEnd = 205226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endFunction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endAction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(promise);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiresSynchronization;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncCoreLogic_Private_Static_Void_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Task_1_TResult_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x000EBAA4 File Offset: 0x000E9CA4
		[CallerCount(0)]
		public unsafe Task<TResult> FromAsync(Func<AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x000EBB18 File Offset: 0x000E9D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205226, XrefRangeEnd = 205274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromAsyncImpl(Func<AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Object state, TaskCreationOptions creationOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endFunction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endAction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Object_TaskCreationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x000EBBA0 File Offset: 0x000E9DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205274, XrefRangeEnd = 205309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromAsyncImpl<TArg1>(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, Object state, TaskCreationOptions creationOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endFunction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endAction);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref TArg1 ptr4;
			if (!typeof(TArg1).IsValueType)
			{
				TArg1 targ = arg1;
				if (!(targ is string))
				{
					ref TArg1 ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(targ as Il2CppObjectBase));
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(targ as string);
				}
			}
			else
			{
				ptr4 = ref arg1;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TArg1>.MethodInfoStoreGeneric_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x000EBC88 File Offset: 0x000E9E88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205319, RefRangeEnd = 205320, XrefRangeStart = 205309, XrefRangeEnd = 205319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, Object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) where TInstance : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TInstance ptr4;
				if (!typeof(TInstance).IsValueType)
				{
					TInstance tinstance = thisRef;
					if (!(tinstance is string))
					{
						ref TInstance ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tinstance as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tinstance as string);
					}
				}
				else
				{
					ptr4 = ref thisRef;
				}
				*ptr2 = ref ptr4;
			}
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref TArgs ptr7;
			if (!typeof(TArgs).IsValueType)
			{
				TArgs targs = args;
				if (!(targs is string))
				{
					ref TArgs ptr6 = (ptr7 = IL2CPP.Il2CppObjectBaseToPtr(targs as Il2CppObjectBase));
					if ((ref ptr6) != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(targs as string);
				}
			}
			else
			{
				ptr7 = ref args;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TInstance>.MethodInfoStoreGeneric_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0<TArgs>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x0001001A File Offset: 0x0000E21A
		public TaskFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06002E16 RID: 11798 RVA: 0x000EBD98 File Offset: 0x000E9F98
		// (set) Token: 0x06002E17 RID: 11799 RVA: 0x00010023 File Offset: 0x0000E223
		public CancellationToken m_defaultCancellationToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCancellationToken);
				return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06002E18 RID: 11800 RVA: 0x000EBDC8 File Offset: 0x000E9FC8
		// (set) Token: 0x06002E19 RID: 11801 RVA: 0x00010051 File Offset: 0x0000E251
		public unsafe TaskScheduler m_defaultScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x000EBDF8 File Offset: 0x000E9FF8
		// (set) Token: 0x06002E1B RID: 11803 RVA: 0x00010070 File Offset: 0x0000E270
		public unsafe TaskCreationOptions m_defaultCreationOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCreationOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCreationOptions)) = value;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x000EBE20 File Offset: 0x000EA020
		// (set) Token: 0x06002E1D RID: 11805 RVA: 0x0001008B File Offset: 0x0000E28B
		public unsafe TaskContinuationOptions m_defaultContinuationOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultContinuationOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultContinuationOptions)) = value;
			}
		}

		// Token: 0x040027E6 RID: 10214
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultCancellationToken;

		// Token: 0x040027E7 RID: 10215
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultScheduler;

		// Token: 0x040027E8 RID: 10216
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultCreationOptions;

		// Token: 0x040027E9 RID: 10217
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultContinuationOptions;

		// Token: 0x040027EA RID: 10218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040027EB RID: 10219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0;

		// Token: 0x040027EC RID: 10220
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_1_TResult_CancellationToken_TaskCreationOptions_TaskScheduler_0;

		// Token: 0x040027ED RID: 10221
		private static readonly IntPtr NativeMethodInfoPtr_FromAsyncCoreLogic_Private_Static_Void_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Task_1_TResult_Boolean_0;

		// Token: 0x040027EE RID: 10222
		private static readonly IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Object_0;

		// Token: 0x040027EF RID: 10223
		private static readonly IntPtr NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Object_TaskCreationOptions_0;

		// Token: 0x040027F0 RID: 10224
		private static readonly IntPtr NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0;

		// Token: 0x040027F1 RID: 10225
		private static readonly IntPtr NativeMethodInfoPtr_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0;

		// Token: 0x02000601 RID: 1537
		public sealed class FromAsyncTrimPromise<TInstance> : Task<TResult> where TInstance : class
		{
			// Token: 0x0600548A RID: 21642 RVA: 0x0017BEE4 File Offset: 0x0017A0E4
			// Note: this type is marked as 'beforefieldinit'.
			static FromAsyncTrimPromise()
			{
				Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "FromAsyncTrimPromise`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInstance>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr);
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_s_completeFromAsyncResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, "s_completeFromAsyncResult");
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_thisRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, "m_thisRef");
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_endMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, "m_endMethod");
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr__ctor_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, 100670635);
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr_CompleteFromAsyncResult_Internal_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, 100670636);
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr_Complete_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_IAsyncResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, 100670637);
			}

			// Token: 0x0600548B RID: 21643 RVA: 0x0017BFD4 File Offset: 0x0017A1D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205163, XrefRangeEnd = 205167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FromAsyncTrimPromise(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TInstance ptr4;
					if (!typeof(TInstance).IsValueType)
					{
						TInstance tinstance = thisRef;
						if (!(tinstance is string))
						{
							ref TInstance ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tinstance as Il2CppObjectBase));
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
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(tinstance as string);
						}
					}
					else
					{
						ptr4 = ref thisRef;
					}
					*ptr2 = ref ptr4;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr__ctor_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600548C RID: 21644 RVA: 0x0017C07C File Offset: 0x0017A27C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205167, XrefRangeEnd = 205178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void CompleteFromAsyncResult(IAsyncResult asyncResult)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr_CompleteFromAsyncResult_Internal_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600548D RID: 21645 RVA: 0x0017C0B4 File Offset: 0x0017A2B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205178, XrefRangeEnd = 205180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TInstance ptr4;
					if (!typeof(TInstance).IsValueType)
					{
						TInstance tinstance = thisRef;
						if (!(tinstance is string))
						{
							ref TInstance ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tinstance as Il2CppObjectBase));
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
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(tinstance as string);
						}
					}
					else
					{
						ptr4 = ref thisRef;
					}
					*ptr2 = ref ptr4;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiresSynchronization;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr_Complete_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_IAsyncResult_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600548E RID: 21646 RVA: 0x0001FE8E File Offset: 0x0001E08E
			public FromAsyncTrimPromise(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015AD RID: 5549
			// (get) Token: 0x0600548F RID: 21647 RVA: 0x0017C174 File Offset: 0x0017A374
			// (set) Token: 0x06005490 RID: 21648 RVA: 0x0001FE97 File Offset: 0x0001E097
			public unsafe static AsyncCallback s_completeFromAsyncResult
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_s_completeFromAsyncResult, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_s_completeFromAsyncResult, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015AE RID: 5550
			// (get) Token: 0x06005491 RID: 21649 RVA: 0x0017C19C File Offset: 0x0017A39C
			// (set) Token: 0x06005492 RID: 21650 RVA: 0x0017C1C4 File Offset: 0x0017A3C4
			public unsafe TInstance m_thisRef
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_thisRef);
					return IL2CPP.PointerToValueGeneric<TInstance>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_thisRef);
					Type typeFromHandle = typeof(TInstance);
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

			// Token: 0x170015AF RID: 5551
			// (get) Token: 0x06005493 RID: 21651 RVA: 0x0017C26C File Offset: 0x0017A46C
			// (set) Token: 0x06005494 RID: 21652 RVA: 0x0001FEA9 File Offset: 0x0001E0A9
			public unsafe Func<TInstance, IAsyncResult, TResult> m_endMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_endMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TInstance, IAsyncResult, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_endMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004476 RID: 17526
			private static readonly IntPtr NativeFieldInfoPtr_s_completeFromAsyncResult;

			// Token: 0x04004477 RID: 17527
			private static readonly IntPtr NativeFieldInfoPtr_m_thisRef;

			// Token: 0x04004478 RID: 17528
			private static readonly IntPtr NativeFieldInfoPtr_m_endMethod;

			// Token: 0x04004479 RID: 17529
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_0;

			// Token: 0x0400447A RID: 17530
			private static readonly IntPtr NativeMethodInfoPtr_CompleteFromAsyncResult_Internal_Static_Void_IAsyncResult_0;

			// Token: 0x0400447B RID: 17531
			private static readonly IntPtr NativeMethodInfoPtr_Complete_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_IAsyncResult_Boolean_0;
		}

		// Token: 0x02000602 RID: 1538
		[ObfuscatedName("System.Threading.Tasks.TaskFactory`1+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Object
		{
			// Token: 0x06005495 RID: 21653 RVA: 0x0017C29C File Offset: 0x0017A49C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "<>c__DisplayClass35_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr);
				TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr, "endFunction");
				TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr, "endAction");
				TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_promise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr, "promise");
				TaskFactory<TResult>.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr, 100670639);
				TaskFactory<TResult>.__c__DisplayClass35_0.NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr, 100670640);
			}

			// Token: 0x06005496 RID: 21654 RVA: 0x0017C368 File Offset: 0x0017A568
			[CallerCount(0)]
			public unsafe __c__DisplayClass35_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005497 RID: 21655 RVA: 0x0017C3A4 File Offset: 0x0017A5A4
			[CallerCount(0)]
			public unsafe void _FromAsyncImpl_b__0(IAsyncResult iar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass35_0.NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005498 RID: 21656 RVA: 0x0001FEC8 File Offset: 0x0001E0C8
			public __c__DisplayClass35_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015B0 RID: 5552
			// (get) Token: 0x06005499 RID: 21657 RVA: 0x0017C3E8 File Offset: 0x0017A5E8
			// (set) Token: 0x0600549A RID: 21658 RVA: 0x0001FED1 File Offset: 0x0001E0D1
			public unsafe Func<IAsyncResult, TResult> endFunction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endFunction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAsyncResult, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B1 RID: 5553
			// (get) Token: 0x0600549B RID: 21659 RVA: 0x0017C418 File Offset: 0x0017A618
			// (set) Token: 0x0600549C RID: 21660 RVA: 0x0001FEF0 File Offset: 0x0001E0F0
			public unsafe Action<IAsyncResult> endAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B2 RID: 5554
			// (get) Token: 0x0600549D RID: 21661 RVA: 0x0017C448 File Offset: 0x0017A648
			// (set) Token: 0x0600549E RID: 21662 RVA: 0x0001FF0F File Offset: 0x0001E10F
			public unsafe Task<TResult> promise
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_promise);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_promise), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400447C RID: 17532
			private static readonly IntPtr NativeFieldInfoPtr_endFunction;

			// Token: 0x0400447D RID: 17533
			private static readonly IntPtr NativeFieldInfoPtr_endAction;

			// Token: 0x0400447E RID: 17534
			private static readonly IntPtr NativeFieldInfoPtr_promise;

			// Token: 0x0400447F RID: 17535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004480 RID: 17536
			private static readonly IntPtr NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0;
		}

		// Token: 0x02000603 RID: 1539
		[ObfuscatedName("System.Threading.Tasks.TaskFactory`1+<>c__DisplayClass35_1")]
		public sealed class __c__DisplayClass35_1 : Object
		{
			// Token: 0x0600549F RID: 21663 RVA: 0x0017C478 File Offset: 0x0017A678
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_1()
			{
				Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_1>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "<>c__DisplayClass35_1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_1>.NativeClassPtr);
				TaskFactory<TResult>.__c__DisplayClass35_1.NativeFieldInfoPtr_invoked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_1>.NativeClassPtr, "invoked");
				TaskFactory<TResult>.__c__DisplayClass35_1.NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_TResult_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_1>.NativeClassPtr, "CS$<>8__locals1");
				TaskFactory<TResult>.__c__DisplayClass35_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_1>.NativeClassPtr, 100670641);
				TaskFactory<TResult>.__c__DisplayClass35_1.NativeMethodInfoPtr__FromAsyncImpl_b__1_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_1>.NativeClassPtr, 100670642);
			}

			// Token: 0x060054A0 RID: 21664 RVA: 0x0017C530 File Offset: 0x0017A730
			[CallerCount(0)]
			public unsafe __c__DisplayClass35_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass35_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054A1 RID: 21665 RVA: 0x0017C56C File Offset: 0x0017A76C
			[CallerCount(0)]
			public unsafe void _FromAsyncImpl_b__1(IAsyncResult iar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass35_1.NativeMethodInfoPtr__FromAsyncImpl_b__1_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060054A2 RID: 21666 RVA: 0x0001FF2E File Offset: 0x0001E12E
			public __c__DisplayClass35_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015B3 RID: 5555
			// (get) Token: 0x060054A3 RID: 21667 RVA: 0x0017C5B0 File Offset: 0x0017A7B0
			// (set) Token: 0x060054A4 RID: 21668 RVA: 0x0001FF37 File Offset: 0x0001E137
			public unsafe AtomicBoolean invoked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_1.NativeFieldInfoPtr_invoked);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AtomicBoolean>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_1.NativeFieldInfoPtr_invoked), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B4 RID: 5556
			// (get) Token: 0x060054A5 RID: 21669 RVA: 0x0017C5E0 File Offset: 0x0017A7E0
			// (set) Token: 0x060054A6 RID: 21670 RVA: 0x0001FF56 File Offset: 0x0001E156
			public unsafe TaskFactory<TResult>.__c__DisplayClass35_0 field_Public___c__DisplayClass35_0_TResult_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_1.NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_TResult_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskFactory<TResult>.__c__DisplayClass35_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_1.NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_TResult_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004481 RID: 17537
			private static readonly IntPtr NativeFieldInfoPtr_invoked;

			// Token: 0x04004482 RID: 17538
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_TResult_0;

			// Token: 0x04004483 RID: 17539
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004484 RID: 17540
			private static readonly IntPtr NativeMethodInfoPtr__FromAsyncImpl_b__1_Internal_Void_IAsyncResult_0;
		}

		// Token: 0x02000604 RID: 1540
		[ObfuscatedName("System.Threading.Tasks.TaskFactory`1+<>c__DisplayClass38_0`1")]
		public sealed class __c__DisplayClass38_0<TArg1> : Object
		{
			// Token: 0x060054A7 RID: 21671 RVA: 0x0017C610 File Offset: 0x0017A810
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "<>c__DisplayClass38_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr);
				TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr, "endFunction");
				TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr, "endAction");
				TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_promise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr, "promise");
				TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr, 100670643);
				TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr, 100670644);
			}

			// Token: 0x060054A8 RID: 21672 RVA: 0x0017C6EC File Offset: 0x0017A8EC
			[CallerCount(0)]
			public unsafe __c__DisplayClass38_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054A9 RID: 21673 RVA: 0x0017C728 File Offset: 0x0017A928
			[CallerCount(0)]
			public unsafe void _FromAsyncImpl_b__0(IAsyncResult iar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060054AA RID: 21674 RVA: 0x0001FF75 File Offset: 0x0001E175
			public __c__DisplayClass38_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015B5 RID: 5557
			// (get) Token: 0x060054AB RID: 21675 RVA: 0x0017C76C File Offset: 0x0017A96C
			// (set) Token: 0x060054AC RID: 21676 RVA: 0x0001FF7E File Offset: 0x0001E17E
			public unsafe Func<IAsyncResult, TResult> endFunction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endFunction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAsyncResult, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B6 RID: 5558
			// (get) Token: 0x060054AD RID: 21677 RVA: 0x0017C79C File Offset: 0x0017A99C
			// (set) Token: 0x060054AE RID: 21678 RVA: 0x0001FF9D File Offset: 0x0001E19D
			public unsafe Action<IAsyncResult> endAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B7 RID: 5559
			// (get) Token: 0x060054AF RID: 21679 RVA: 0x0017C7CC File Offset: 0x0017A9CC
			// (set) Token: 0x060054B0 RID: 21680 RVA: 0x0001FFBC File Offset: 0x0001E1BC
			public unsafe Task<TResult> promise
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_promise);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_promise), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004485 RID: 17541
			private static readonly IntPtr NativeFieldInfoPtr_endFunction;

			// Token: 0x04004486 RID: 17542
			private static readonly IntPtr NativeFieldInfoPtr_endAction;

			// Token: 0x04004487 RID: 17543
			private static readonly IntPtr NativeFieldInfoPtr_promise;

			// Token: 0x04004488 RID: 17544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004489 RID: 17545
			private static readonly IntPtr NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0;
		}

		// Token: 0x02000605 RID: 1541
		[ObfuscatedName("System.Threading.Tasks.TaskFactory`1+<>c__DisplayClass38_1`1")]
		public sealed class __c__DisplayClass38_1<TArg1> : Object
		{
			// Token: 0x060054B1 RID: 21681 RVA: 0x0017C7FC File Offset: 0x0017A9FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_1()
			{
				Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "<>c__DisplayClass38_1`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>>.NativeClassPtr);
				TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeFieldInfoPtr_invoked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>>.NativeClassPtr, "invoked");
				TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeFieldInfoPtr_field_Public___c__DisplayClass38_0_1_TResult_TArg1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>>.NativeClassPtr, "CS$<>8__locals1");
				TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>>.NativeClassPtr, 100670645);
				TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeMethodInfoPtr__FromAsyncImpl_b__1_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>>.NativeClassPtr, 100670646);
			}

			// Token: 0x060054B2 RID: 21682 RVA: 0x0017C8C4 File Offset: 0x0017AAC4
			[CallerCount(0)]
			public unsafe __c__DisplayClass38_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054B3 RID: 21683 RVA: 0x0017C900 File Offset: 0x0017AB00
			[CallerCount(0)]
			public unsafe void _FromAsyncImpl_b__1(IAsyncResult iar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeMethodInfoPtr__FromAsyncImpl_b__1_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060054B4 RID: 21684 RVA: 0x0001FFDB File Offset: 0x0001E1DB
			public __c__DisplayClass38_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015B8 RID: 5560
			// (get) Token: 0x060054B5 RID: 21685 RVA: 0x0017C944 File Offset: 0x0017AB44
			// (set) Token: 0x060054B6 RID: 21686 RVA: 0x0001FFE4 File Offset: 0x0001E1E4
			public unsafe AtomicBoolean invoked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeFieldInfoPtr_invoked);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AtomicBoolean>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeFieldInfoPtr_invoked), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B9 RID: 5561
			// (get) Token: 0x060054B7 RID: 21687 RVA: 0x0017C974 File Offset: 0x0017AB74
			// (set) Token: 0x060054B8 RID: 21688 RVA: 0x00020003 File Offset: 0x0001E203
			public unsafe TaskFactory<TResult>.__c__DisplayClass38_0<TArg1> field_Public___c__DisplayClass38_0_1_TResult_TArg1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeFieldInfoPtr_field_Public___c__DisplayClass38_0_1_TResult_TArg1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeFieldInfoPtr_field_Public___c__DisplayClass38_0_1_TResult_TArg1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400448A RID: 17546
			private static readonly IntPtr NativeFieldInfoPtr_invoked;

			// Token: 0x0400448B RID: 17547
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass38_0_1_TResult_TArg1_0;

			// Token: 0x0400448C RID: 17548
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400448D RID: 17549
			private static readonly IntPtr NativeMethodInfoPtr__FromAsyncImpl_b__1_Internal_Void_IAsyncResult_0;
		}

		// Token: 0x02000606 RID: 1542
		private sealed class MethodInfoStoreGeneric_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0
		{
			// Token: 0x0400448E RID: 17550
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory<TArg1>.NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0, Il2CppClassPointerStore<TaskFactory<TArg1>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)) }))));
		}

		// Token: 0x02000607 RID: 1543
		private sealed class MethodInfoStoreGeneric_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0<TArgs>
		{
			// Token: 0x0400448F RID: 17551
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory<TInstance>.NativeMethodInfoPtr_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0, Il2CppClassPointerStore<TaskFactory<TInstance>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInstance>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArgs>.NativeClassPtr))
			}))));
		}
	}
}
