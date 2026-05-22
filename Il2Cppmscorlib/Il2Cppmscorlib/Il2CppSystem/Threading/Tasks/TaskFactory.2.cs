using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002BA RID: 698
	public class TaskFactory : Object
	{
		// Token: 0x06002F94 RID: 12180 RVA: 0x000F1D10 File Offset: 0x000EFF10
		// Note: this type is marked as 'beforefieldinit'.
		static TaskFactory()
		{
			Il2CppClassPointerStore<TaskFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr);
			TaskFactory.NativeFieldInfoPtr_m_defaultCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "m_defaultCancellationToken");
			TaskFactory.NativeFieldInfoPtr_m_defaultScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "m_defaultScheduler");
			TaskFactory.NativeFieldInfoPtr_m_defaultCreationOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "m_defaultCreationOptions");
			TaskFactory.NativeFieldInfoPtr_m_defaultContinuationOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "m_defaultContinuationOptions");
			TaskFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670879);
			TaskFactory.NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670880);
			TaskFactory.NativeMethodInfoPtr_CheckCreationOptions_Internal_Static_Void_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670881);
			TaskFactory.NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670882);
			TaskFactory.NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670883);
			TaskFactory.NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670884);
			TaskFactory.NativeMethodInfoPtr_CheckFromAsyncOptions_Internal_Static_Void_TaskCreationOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670885);
			TaskFactory.NativeMethodInfoPtr_CommonCWAnyLogic_Internal_Static_Task_1_Task_IList_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670886);
			TaskFactory.NativeMethodInfoPtr_CheckMultiTaskContinuationOptions_Internal_Static_Void_TaskContinuationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670887);
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x000F1E44 File Offset: 0x000F0044
		[CallerCount(0)]
		public unsafe TaskFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x000F1E80 File Offset: 0x000F0080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207366, XrefRangeEnd = 207367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F97 RID: 12183 RVA: 0x000F1F00 File Offset: 0x000F0100
		[CallerCount(0)]
		public unsafe static void CheckCreationOptions(TaskCreationOptions creationOptions)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref creationOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr_CheckCreationOptions_Internal_Static_Void_TaskCreationOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x000F1F34 File Offset: 0x000F0134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207380, RefRangeEnd = 207381, XrefRangeStart = 207367, XrefRangeEnd = 207380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TResult> StartNew<TResult>(Func<Object, TResult> function, Object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.MethodInfoStoreGeneric_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0<TResult>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x000F1FD0 File Offset: 0x000F01D0
		[CallerCount(0)]
		public unsafe Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.MethodInfoStoreGeneric_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0<TArg1>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x000F20A4 File Offset: 0x000F02A4
		[CallerCount(0)]
		public unsafe Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, Object state, TaskCreationOptions creationOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.MethodInfoStoreGeneric_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0<TArg1>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x000F2184 File Offset: 0x000F0384
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207381, RefRangeEnd = 207383, XrefRangeStart = 207381, XrefRangeEnd = 207381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref creationOptions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasBeginMethod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr_CheckFromAsyncOptions_Internal_Static_Void_TaskCreationOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x000F21C4 File Offset: 0x000F03C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207414, RefRangeEnd = 207416, XrefRangeStart = 207383, XrefRangeEnd = 207414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Task> CommonCWAnyLogic(IList<Task> tasks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tasks);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr_CommonCWAnyLogic_Internal_Static_Task_1_Task_IList_1_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Task>>(intPtr3) : null;
			}
		}

		// Token: 0x06002F9D RID: 12189 RVA: 0x000F2208 File Offset: 0x000F0408
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207416, RefRangeEnd = 207418, XrefRangeStart = 207416, XrefRangeEnd = 207416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref continuationOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr_CheckMultiTaskContinuationOptions_Internal_Static_Void_TaskContinuationOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x00010781 File Offset: 0x0000E981
		public TaskFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002F9F RID: 12191 RVA: 0x000F223C File Offset: 0x000F043C
		// (set) Token: 0x06002FA0 RID: 12192 RVA: 0x0001078A File Offset: 0x0000E98A
		public CancellationToken m_defaultCancellationToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultCancellationToken);
				return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002FA1 RID: 12193 RVA: 0x000F226C File Offset: 0x000F046C
		// (set) Token: 0x06002FA2 RID: 12194 RVA: 0x000107B8 File Offset: 0x0000E9B8
		public unsafe TaskScheduler m_defaultScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x000F229C File Offset: 0x000F049C
		// (set) Token: 0x06002FA4 RID: 12196 RVA: 0x000107D7 File Offset: 0x0000E9D7
		public unsafe TaskCreationOptions m_defaultCreationOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultCreationOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultCreationOptions)) = value;
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x000F22C4 File Offset: 0x000F04C4
		// (set) Token: 0x06002FA6 RID: 12198 RVA: 0x000107F2 File Offset: 0x0000E9F2
		public unsafe TaskContinuationOptions m_defaultContinuationOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultContinuationOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultContinuationOptions)) = value;
			}
		}

		// Token: 0x0400292A RID: 10538
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultCancellationToken;

		// Token: 0x0400292B RID: 10539
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultScheduler;

		// Token: 0x0400292C RID: 10540
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultCreationOptions;

		// Token: 0x0400292D RID: 10541
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultContinuationOptions;

		// Token: 0x0400292E RID: 10542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400292F RID: 10543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0;

		// Token: 0x04002930 RID: 10544
		private static readonly IntPtr NativeMethodInfoPtr_CheckCreationOptions_Internal_Static_Void_TaskCreationOptions_0;

		// Token: 0x04002931 RID: 10545
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0;

		// Token: 0x04002932 RID: 10546
		private static readonly IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0;

		// Token: 0x04002933 RID: 10547
		private static readonly IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0;

		// Token: 0x04002934 RID: 10548
		private static readonly IntPtr NativeMethodInfoPtr_CheckFromAsyncOptions_Internal_Static_Void_TaskCreationOptions_Boolean_0;

		// Token: 0x04002935 RID: 10549
		private static readonly IntPtr NativeMethodInfoPtr_CommonCWAnyLogic_Internal_Static_Task_1_Task_IList_1_Task_0;

		// Token: 0x04002936 RID: 10550
		private static readonly IntPtr NativeMethodInfoPtr_CheckMultiTaskContinuationOptions_Internal_Static_Void_TaskContinuationOptions_0;

		// Token: 0x02000618 RID: 1560
		public sealed class CompleteOnInvokePromise : Task<Task>
		{
			// Token: 0x0600551F RID: 21791 RVA: 0x0017DC78 File Offset: 0x0017BE78
			// Note: this type is marked as 'beforefieldinit'.
			static CompleteOnInvokePromise()
			{
				Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "CompleteOnInvokePromise");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr);
				TaskFactory.CompleteOnInvokePromise.NativeFieldInfoPtr__tasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr, "_tasks");
				TaskFactory.CompleteOnInvokePromise.NativeFieldInfoPtr_m_firstTaskAlreadyCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr, "m_firstTaskAlreadyCompleted");
				TaskFactory.CompleteOnInvokePromise.NativeMethodInfoPtr__ctor_Public_Void_IList_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr, 100670888);
				TaskFactory.CompleteOnInvokePromise.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr, 100670889);
			}

			// Token: 0x06005520 RID: 21792 RVA: 0x0017DCF4 File Offset: 0x0017BEF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207327, XrefRangeEnd = 207341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CompleteOnInvokePromise(IList<Task> tasks)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tasks);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.CompleteOnInvokePromise.NativeMethodInfoPtr__ctor_Public_Void_IList_1_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005521 RID: 21793 RVA: 0x0017DD40 File Offset: 0x0017BF40
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 207365, RefRangeEnd = 207366, XrefRangeStart = 207341, XrefRangeEnd = 207365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Task completingTask)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.CompleteOnInvokePromise.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005522 RID: 21794 RVA: 0x00020330 File Offset: 0x0001E530
			public CompleteOnInvokePromise(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015D4 RID: 5588
			// (get) Token: 0x06005523 RID: 21795 RVA: 0x0017DD84 File Offset: 0x0017BF84
			// (set) Token: 0x06005524 RID: 21796 RVA: 0x00020339 File Offset: 0x0001E539
			public unsafe IList<Task> _tasks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.CompleteOnInvokePromise.NativeFieldInfoPtr__tasks);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Task>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.CompleteOnInvokePromise.NativeFieldInfoPtr__tasks), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015D5 RID: 5589
			// (get) Token: 0x06005525 RID: 21797 RVA: 0x0017DDB4 File Offset: 0x0017BFB4
			// (set) Token: 0x06005526 RID: 21798 RVA: 0x00020358 File Offset: 0x0001E558
			public unsafe int m_firstTaskAlreadyCompleted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.CompleteOnInvokePromise.NativeFieldInfoPtr_m_firstTaskAlreadyCompleted);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.CompleteOnInvokePromise.NativeFieldInfoPtr_m_firstTaskAlreadyCompleted)) = value;
				}
			}

			// Token: 0x040044C8 RID: 17608
			private static readonly IntPtr NativeFieldInfoPtr__tasks;

			// Token: 0x040044C9 RID: 17609
			private static readonly IntPtr NativeFieldInfoPtr_m_firstTaskAlreadyCompleted;

			// Token: 0x040044CA RID: 17610
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_Task_0;

			// Token: 0x040044CB RID: 17611
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0;
		}

		// Token: 0x02000619 RID: 1561
		private sealed class MethodInfoStoreGeneric_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0<TResult>
		{
			// Token: 0x040044CC RID: 17612
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory.NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200061A RID: 1562
		private sealed class MethodInfoStoreGeneric_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0<TArg1>
		{
			// Token: 0x040044CD RID: 17613
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory.NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)) }))));
		}

		// Token: 0x0200061B RID: 1563
		private sealed class MethodInfoStoreGeneric_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0<TArg1>
		{
			// Token: 0x040044CE RID: 17614
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory.NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)) }))));
		}
	}
}
