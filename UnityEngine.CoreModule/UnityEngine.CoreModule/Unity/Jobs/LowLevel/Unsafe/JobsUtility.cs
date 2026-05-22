using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000015 RID: 21
	public static class JobsUtility : Object
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00016564 File Offset: 0x00014764
		// Note: this type is marked as 'beforefieldinit'.
		static JobsUtility()
		{
			Il2CppClassPointerStore<JobsUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs.LowLevel.Unsafe", "JobsUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr);
			JobsUtility.NativeFieldInfoPtr_PanicFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, "PanicFunction");
			JobsUtility.NativeMethodInfoPtr_GetWorkStealingRange_Public_Static_Boolean_byref_JobRanges_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663329);
			JobsUtility.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_byref_JobScheduleParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663330);
			JobsUtility.NativeMethodInfoPtr_ScheduleParallelFor_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663331);
			JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Private_Static_IntPtr_Type_Type_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663332);
			JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663333);
			JobsUtility.NativeMethodInfoPtr_get_IsExecutingJob_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663334);
			JobsUtility.NativeMethodInfoPtr_set_JobCompilerEnabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663335);
			JobsUtility.NativeMethodInfoPtr_InvokePanicFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663336);
			JobsUtility.NativeMethodInfoPtr_Schedule_Injected_Private_Static_Void_byref_JobScheduleParameters_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663337);
			JobsUtility.NativeMethodInfoPtr_ScheduleParallelFor_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_Int32_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663338);
			JobsUtility.PatchBufferMinMaxRangesDelegateField = IL2CPP.ResolveICall<JobsUtility.PatchBufferMinMaxRangesDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::PatchBufferMinMaxRanges");
			JobsUtility.get_JobDebuggerEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.get_JobDebuggerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobDebuggerEnabled");
			JobsUtility.set_JobDebuggerEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.set_JobDebuggerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::set_JobDebuggerEnabled");
			JobsUtility.get_JobCompilerEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.get_JobCompilerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobCompilerEnabled");
			JobsUtility.GetJobQueueWorkerThreadCountDelegateField = IL2CPP.ResolveICall<JobsUtility.GetJobQueueWorkerThreadCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetJobQueueWorkerThreadCount");
			JobsUtility.SetJobQueueMaximumActiveThreadCountDelegateField = IL2CPP.ResolveICall<JobsUtility.SetJobQueueMaximumActiveThreadCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::SetJobQueueMaximumActiveThreadCount");
			JobsUtility.get_JobWorkerMaximumCountDelegateField = IL2CPP.ResolveICall<JobsUtility.get_JobWorkerMaximumCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobWorkerMaximumCount");
			JobsUtility.ResetJobWorkerCountDelegateField = IL2CPP.ResolveICall<JobsUtility.ResetJobWorkerCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ResetJobWorkerCount");
			JobsUtility.GetSystemIdCellPtrDelegateField = IL2CPP.ResolveICall<JobsUtility.GetSystemIdCellPtrDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetSystemIdCellPtr");
			JobsUtility.ClearSystemIdsDelegateField = IL2CPP.ResolveICall<JobsUtility.ClearSystemIdsDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ClearSystemIds");
			JobsUtility.GetSystemIdMappingsDelegateField = IL2CPP.ResolveICall<JobsUtility.GetSystemIdMappingsDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetSystemIdMappings");
			JobsUtility.ScheduleParallelForDeferArraySize_InjectedDelegateField = IL2CPP.ResolveICall<JobsUtility.ScheduleParallelForDeferArraySize_InjectedDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ScheduleParallelForDeferArraySize_Injected");
			JobsUtility.ScheduleParallelForTransform_InjectedDelegateField = IL2CPP.ResolveICall<JobsUtility.ScheduleParallelForTransform_InjectedDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ScheduleParallelForTransform_Injected");
			JobsUtility.ScheduleParallelForTransformReadOnly_InjectedDelegateField = IL2CPP.ResolveICall<JobsUtility.ScheduleParallelForTransformReadOnly_InjectedDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ScheduleParallelForTransformReadOnly_Injected");
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00016744 File Offset: 0x00014944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485793, XrefRangeEnd = 485797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ranges;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &beginIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_GetWorkStealingRange_Public_Static_Boolean_byref_JobRanges_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000167AC File Offset: 0x000149AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485797, XrefRangeEnd = 485799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle Schedule(ref JobsUtility.JobScheduleParameters parameters)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &parameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_byref_JobScheduleParameters_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000167EC File Offset: 0x000149EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485799, XrefRangeEnd = 485801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle ScheduleParallelFor(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &parameters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref innerloopBatchCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_ScheduleParallelFor_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00016848 File Offset: 0x00014A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485801, XrefRangeEnd = 485805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, Object managedJobFunction0, Object managedJobFunction1, Object managedJobFunction2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wrapperJobType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userJobType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Private_Static_IntPtr_Type_Type_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000168D4 File Offset: 0x00014AD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 485809, RefRangeEnd = 485811, XrefRangeStart = 485805, XrefRangeEnd = 485809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateJobReflectionData(Type type, Object managedJobFunction0, Object managedJobFunction1 = null, Object managedJobFunction2 = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0001694C File Offset: 0x00014B4C
		public unsafe static bool IsExecutingJob
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485811, XrefRangeEnd = 485815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_get_IsExecutingJob_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002542 File Offset: 0x00000742
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0001697C File Offset: 0x00014B7C
		public unsafe static bool JobCompilerEnabled
		{
			get
			{
				return JobsUtility.get_JobCompilerEnabledDelegateField();
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485815, XrefRangeEnd = 485819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_set_JobCompilerEnabled_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000169B0 File Offset: 0x00014BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485819, XrefRangeEnd = 485822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokePanicFunction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_InvokePanicFunction_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000169D8 File Offset: 0x00014BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485822, XrefRangeEnd = 485826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Schedule_Injected(ref JobsUtility.JobScheduleParameters parameters, out JobHandle ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &parameters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_Schedule_Injected_Private_Static_Void_byref_JobScheduleParameters_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00016A18 File Offset: 0x00014C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485826, XrefRangeEnd = 485830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleParallelFor_Injected(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &parameters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref innerloopBatchCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_ScheduleParallelFor_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_Int32_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000024FE File Offset: 0x000006FE
		public JobsUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00016A74 File Offset: 0x00014C74
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002507 File Offset: 0x00000707
		public unsafe static JobsUtility.PanicFunction_ PanicFunction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JobsUtility.NativeFieldInfoPtr_PanicFunction, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JobsUtility.PanicFunction_>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JobsUtility.NativeFieldInfoPtr_PanicFunction, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00016A9C File Offset: 0x00014C9C
		public unsafe static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex)
		{
			int* ptr = (int*)(void*)ranges.StartEndIndex;
			beginIndex = ptr[jobIndex * 2];
			endIndex = ptr[jobIndex * 2 + 1];
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00016AD0 File Offset: 0x00014CD0
		public unsafe static JobHandle ScheduleParallelForDeferArraySize(ref JobsUtility.JobScheduleParameters parameters, int innerloopBatchCount, void* listData, void* listDataAtomicSafetyHandle)
		{
			JobHandle jobHandle;
			JobsUtility.ScheduleParallelForDeferArraySize_Injected(ref parameters, innerloopBatchCount, listData, listDataAtomicSafetyHandle, out jobHandle);
			return jobHandle;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00016AEC File Offset: 0x00014CEC
		public static JobHandle ScheduleParallelForTransform(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray)
		{
			JobHandle jobHandle;
			JobsUtility.ScheduleParallelForTransform_Injected(ref parameters, transfromAccesssArray, out jobHandle);
			return jobHandle;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00016B04 File Offset: 0x00014D04
		public static JobHandle ScheduleParallelForTransformReadOnly(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray, int innerloopBatchCount)
		{
			JobHandle jobHandle;
			JobsUtility.ScheduleParallelForTransformReadOnly_Injected(ref parameters, transfromAccesssArray, innerloopBatchCount, out jobHandle);
			return jobHandle;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002519 File Offset: 0x00000719
		public unsafe static void PatchBufferMinMaxRanges(IntPtr bufferRangePatchData, void* jobdata, int startIndex, int rangeSize)
		{
			JobsUtility.PatchBufferMinMaxRangesDelegateField(bufferRangePatchData, jobdata, startIndex, rangeSize);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00016B1C File Offset: 0x00014D1C
		public static IntPtr CreateJobReflectionData(Type type, JobType jobType, Object managedJobFunction0, [Optional] Object managedJobFunction1, [Optional] Object managedJobFunction2)
		{
			return JobsUtility.CreateJobReflectionData(type, type, managedJobFunction0, managedJobFunction1, managedJobFunction2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00016B3C File Offset: 0x00014D3C
		public static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, JobType jobType, Object managedJobFunction0)
		{
			return JobsUtility.CreateJobReflectionData(wrapperJobType, userJobType, managedJobFunction0, null, null);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00016B58 File Offset: 0x00014D58
		public static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, Object managedJobFunction0)
		{
			return JobsUtility.CreateJobReflectionData(wrapperJobType, userJobType, managedJobFunction0, null, null);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002529 File Offset: 0x00000729
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002535 File Offset: 0x00000735
		public static bool JobDebuggerEnabled
		{
			get
			{
				return JobsUtility.get_JobDebuggerEnabledDelegateField();
			}
			set
			{
				JobsUtility.set_JobDebuggerEnabledDelegateField(value);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000254E File Offset: 0x0000074E
		public static int GetJobQueueWorkerThreadCount()
		{
			return JobsUtility.GetJobQueueWorkerThreadCountDelegateField();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000255A File Offset: 0x0000075A
		public static void SetJobQueueMaximumActiveThreadCount(int count)
		{
			JobsUtility.SetJobQueueMaximumActiveThreadCountDelegateField(count);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002567 File Offset: 0x00000767
		public static int JobWorkerMaximumCount
		{
			get
			{
				return JobsUtility.get_JobWorkerMaximumCountDelegateField();
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002573 File Offset: 0x00000773
		public static void ResetJobWorkerCount()
		{
			JobsUtility.ResetJobWorkerCountDelegateField();
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00016B74 File Offset: 0x00014D74
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00016B8C File Offset: 0x00014D8C
		public static int JobWorkerCount
		{
			get
			{
				return JobsUtility.GetJobQueueWorkerThreadCount();
			}
			set
			{
				bool flag = value < 0 || value > JobsUtility.JobWorkerMaximumCount;
				if (flag)
				{
					throw new ArgumentOutOfRangeException("JobWorkerCount", String.Format("Invalid JobWorkerCount {0} must be in the range 0 -> {1}", value, JobsUtility.JobWorkerMaximumCount));
				}
				JobsUtility.SetJobQueueMaximumActiveThreadCount(value);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000257F File Offset: 0x0000077F
		public static IntPtr GetSystemIdCellPtr()
		{
			return JobsUtility.GetSystemIdCellPtrDelegateField();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000258B File Offset: 0x0000078B
		public static void ClearSystemIds()
		{
			JobsUtility.ClearSystemIdsDelegateField();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002597 File Offset: 0x00000797
		public unsafe static int GetSystemIdMappings(JobHandle* handles, int* systemIds, int maxCount)
		{
			return JobsUtility.GetSystemIdMappingsDelegateField(handles, systemIds, maxCount);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000025A6 File Offset: 0x000007A6
		public unsafe static void ScheduleParallelForDeferArraySize_Injected(ref JobsUtility.JobScheduleParameters parameters, int innerloopBatchCount, void* listData, void* listDataAtomicSafetyHandle, out JobHandle ret)
		{
			JobsUtility.ScheduleParallelForDeferArraySize_InjectedDelegateField(ref parameters, innerloopBatchCount, listData, listDataAtomicSafetyHandle, out ret);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000025B8 File Offset: 0x000007B8
		public static void ScheduleParallelForTransform_Injected(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray, out JobHandle ret)
		{
			JobsUtility.ScheduleParallelForTransform_InjectedDelegateField(ref parameters, transfromAccesssArray, out ret);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000025C7 File Offset: 0x000007C7
		public static void ScheduleParallelForTransformReadOnly_Injected(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray, int innerloopBatchCount, out JobHandle ret)
		{
			JobsUtility.ScheduleParallelForTransformReadOnly_InjectedDelegateField(ref parameters, transfromAccesssArray, innerloopBatchCount, out ret);
		}

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_PanicFunction;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_GetWorkStealingRange_Public_Static_Boolean_byref_JobRanges_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_byref_JobScheduleParameters_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleParallelFor_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_Int32_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Private_Static_IntPtr_Type_Type_Object_Object_Object_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Object_Object_Object_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExecutingJob_Public_Static_get_Boolean_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_set_JobCompilerEnabled_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_InvokePanicFunction_Private_Static_Void_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Injected_Private_Static_Void_byref_JobScheduleParameters_byref_JobHandle_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleParallelFor_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_Int32_byref_JobHandle_0;

		// Token: 0x0400007A RID: 122
		public const int MaxJobThreadCount = 128;

		// Token: 0x0400007B RID: 123
		public const int CacheLineSize = 64;

		// Token: 0x0400007C RID: 124
		private static readonly JobsUtility.PatchBufferMinMaxRangesDelegate PatchBufferMinMaxRangesDelegateField;

		// Token: 0x0400007D RID: 125
		private static readonly JobsUtility.get_JobDebuggerEnabledDelegate get_JobDebuggerEnabledDelegateField;

		// Token: 0x0400007E RID: 126
		private static readonly JobsUtility.set_JobDebuggerEnabledDelegate set_JobDebuggerEnabledDelegateField;

		// Token: 0x0400007F RID: 127
		private static readonly JobsUtility.get_JobCompilerEnabledDelegate get_JobCompilerEnabledDelegateField;

		// Token: 0x04000080 RID: 128
		private static readonly JobsUtility.GetJobQueueWorkerThreadCountDelegate GetJobQueueWorkerThreadCountDelegateField;

		// Token: 0x04000081 RID: 129
		private static readonly JobsUtility.SetJobQueueMaximumActiveThreadCountDelegate SetJobQueueMaximumActiveThreadCountDelegateField;

		// Token: 0x04000082 RID: 130
		private static readonly JobsUtility.get_JobWorkerMaximumCountDelegate get_JobWorkerMaximumCountDelegateField;

		// Token: 0x04000083 RID: 131
		private static readonly JobsUtility.ResetJobWorkerCountDelegate ResetJobWorkerCountDelegateField;

		// Token: 0x04000084 RID: 132
		private static readonly JobsUtility.GetSystemIdCellPtrDelegate GetSystemIdCellPtrDelegateField;

		// Token: 0x04000085 RID: 133
		private static readonly JobsUtility.ClearSystemIdsDelegate ClearSystemIdsDelegateField;

		// Token: 0x04000086 RID: 134
		private static readonly JobsUtility.GetSystemIdMappingsDelegate GetSystemIdMappingsDelegateField;

		// Token: 0x04000087 RID: 135
		private static readonly JobsUtility.ScheduleParallelForDeferArraySize_InjectedDelegate ScheduleParallelForDeferArraySize_InjectedDelegateField;

		// Token: 0x04000088 RID: 136
		private static readonly JobsUtility.ScheduleParallelForTransform_InjectedDelegate ScheduleParallelForTransform_InjectedDelegateField;

		// Token: 0x04000089 RID: 137
		private static readonly JobsUtility.ScheduleParallelForTransformReadOnly_InjectedDelegate ScheduleParallelForTransformReadOnly_InjectedDelegateField;

		// Token: 0x02000302 RID: 770
		[StructLayout(2)]
		public struct JobScheduleParameters
		{
			// Token: 0x06002406 RID: 9222 RVA: 0x00079ABC File Offset: 0x00077CBC
			// Note: this type is marked as 'beforefieldinit'.
			static JobScheduleParameters()
			{
				Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, "JobScheduleParameters");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr);
				JobsUtility.JobScheduleParameters.NativeFieldInfoPtr_Dependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, "Dependency");
				JobsUtility.JobScheduleParameters.NativeFieldInfoPtr_ScheduleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, "ScheduleMode");
				JobsUtility.JobScheduleParameters.NativeFieldInfoPtr_ReflectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, "ReflectionData");
				JobsUtility.JobScheduleParameters.NativeFieldInfoPtr_JobDataPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, "JobDataPtr");
				JobsUtility.JobScheduleParameters.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_IntPtr_JobHandle_ScheduleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, 100663339);
			}

			// Token: 0x06002407 RID: 9223 RVA: 0x00079B4C File Offset: 0x00077D4C
			[CallerCount(0)]
			public unsafe JobScheduleParameters(void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = i_jobData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i_reflectionData;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i_dependency;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i_scheduleMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.JobScheduleParameters.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_IntPtr_JobHandle_ScheduleMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002408 RID: 9224 RVA: 0x00013430 File Offset: 0x00011630
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, ref this));
			}

			// Token: 0x04001E59 RID: 7769
			private static readonly IntPtr NativeFieldInfoPtr_Dependency;

			// Token: 0x04001E5A RID: 7770
			private static readonly IntPtr NativeFieldInfoPtr_ScheduleMode;

			// Token: 0x04001E5B RID: 7771
			private static readonly IntPtr NativeFieldInfoPtr_ReflectionData;

			// Token: 0x04001E5C RID: 7772
			private static readonly IntPtr NativeFieldInfoPtr_JobDataPtr;

			// Token: 0x04001E5D RID: 7773
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_IntPtr_JobHandle_ScheduleMode_0;

			// Token: 0x04001E5E RID: 7774
			[FieldOffset(0)]
			public JobHandle Dependency;

			// Token: 0x04001E5F RID: 7775
			[FieldOffset(16)]
			public int ScheduleMode;

			// Token: 0x04001E60 RID: 7776
			[FieldOffset(24)]
			public IntPtr ReflectionData;

			// Token: 0x04001E61 RID: 7777
			[FieldOffset(32)]
			public IntPtr JobDataPtr;
		}

		// Token: 0x02000303 RID: 771
		public sealed class PanicFunction_ : MulticastDelegate
		{
			// Token: 0x06002409 RID: 9225 RVA: 0x00079BA8 File Offset: 0x00077DA8
			// Note: this type is marked as 'beforefieldinit'.
			static PanicFunction_()
			{
				Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, "PanicFunction_");
				JobsUtility.PanicFunction_.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr, 100663340);
				JobsUtility.PanicFunction_.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr, 100663341);
				JobsUtility.PanicFunction_.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr, 100663342);
				JobsUtility.PanicFunction_.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr, 100663343);
			}

			// Token: 0x0600240A RID: 9226 RVA: 0x00079C1C File Offset: 0x00077E1C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PanicFunction_(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.PanicFunction_.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600240B RID: 9227 RVA: 0x00079C78 File Offset: 0x00077E78
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.PanicFunction_.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600240C RID: 9228 RVA: 0x00079CAC File Offset: 0x00077EAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.PanicFunction_.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600240D RID: 9229 RVA: 0x00079D10 File Offset: 0x00077F10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.PanicFunction_.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600240E RID: 9230 RVA: 0x00013442 File Offset: 0x00011642
			public PanicFunction_(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600240F RID: 9231 RVA: 0x0001344B File Offset: 0x0001164B
			public static implicit operator JobsUtility.PanicFunction_(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<JobsUtility.PanicFunction_>(A_0);
			}

			// Token: 0x06002410 RID: 9232 RVA: 0x00013453 File Offset: 0x00011653
			public static JobsUtility.PanicFunction_ operator +(JobsUtility.PanicFunction_ A_0, JobsUtility.PanicFunction_ A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<JobsUtility.PanicFunction_>();
			}

			// Token: 0x06002411 RID: 9233 RVA: 0x00013461 File Offset: 0x00011661
			public static JobsUtility.PanicFunction_ operator -(JobsUtility.PanicFunction_ A_0, JobsUtility.PanicFunction_ A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<JobsUtility.PanicFunction_>();
				}
				return delegate2;
			}

			// Token: 0x04001E62 RID: 7778
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001E63 RID: 7779
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04001E64 RID: 7780
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04001E65 RID: 7781
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000304 RID: 772
		// (Invoke) Token: 0x06002413 RID: 9235
		private delegate void PatchBufferMinMaxRangesDelegate(IntPtr bufferRangePatchData, IntPtr jobdata, int startIndex, int rangeSize);

		// Token: 0x02000305 RID: 773
		// (Invoke) Token: 0x06002415 RID: 9237
		private delegate bool get_JobDebuggerEnabledDelegate();

		// Token: 0x02000306 RID: 774
		// (Invoke) Token: 0x06002417 RID: 9239
		private delegate void set_JobDebuggerEnabledDelegate(bool value);

		// Token: 0x02000307 RID: 775
		// (Invoke) Token: 0x06002419 RID: 9241
		private delegate bool get_JobCompilerEnabledDelegate();

		// Token: 0x02000308 RID: 776
		// (Invoke) Token: 0x0600241B RID: 9243
		private delegate int GetJobQueueWorkerThreadCountDelegate();

		// Token: 0x02000309 RID: 777
		// (Invoke) Token: 0x0600241D RID: 9245
		private delegate void SetJobQueueMaximumActiveThreadCountDelegate(int count);

		// Token: 0x0200030A RID: 778
		// (Invoke) Token: 0x0600241F RID: 9247
		private delegate int get_JobWorkerMaximumCountDelegate();

		// Token: 0x0200030B RID: 779
		// (Invoke) Token: 0x06002421 RID: 9249
		private delegate void ResetJobWorkerCountDelegate();

		// Token: 0x0200030C RID: 780
		// (Invoke) Token: 0x06002423 RID: 9251
		private delegate IntPtr GetSystemIdCellPtrDelegate();

		// Token: 0x0200030D RID: 781
		// (Invoke) Token: 0x06002425 RID: 9253
		private delegate void ClearSystemIdsDelegate();

		// Token: 0x0200030E RID: 782
		// (Invoke) Token: 0x06002427 RID: 9255
		private delegate int GetSystemIdMappingsDelegate(IntPtr handles, IntPtr systemIds, int maxCount);

		// Token: 0x0200030F RID: 783
		// (Invoke) Token: 0x06002429 RID: 9257
		private delegate void ScheduleParallelForDeferArraySize_InjectedDelegate(IntPtr parameters, int innerloopBatchCount, IntPtr listData, IntPtr listDataAtomicSafetyHandle, [Out] IntPtr ret);

		// Token: 0x02000310 RID: 784
		// (Invoke) Token: 0x0600242B RID: 9259
		private delegate void ScheduleParallelForTransform_InjectedDelegate(IntPtr parameters, IntPtr transfromAccesssArray, [Out] IntPtr ret);

		// Token: 0x02000311 RID: 785
		// (Invoke) Token: 0x0600242D RID: 9261
		private delegate void ScheduleParallelForTransformReadOnly_InjectedDelegate(IntPtr parameters, IntPtr transfromAccesssArray, int innerloopBatchCount, [Out] IntPtr ret);
	}
}
