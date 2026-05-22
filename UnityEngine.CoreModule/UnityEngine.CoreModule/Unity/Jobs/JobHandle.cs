using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Jobs
{
	// Token: 0x02000011 RID: 17
	[StructLayout(2)]
	public struct JobHandle
	{
		// Token: 0x0600004F RID: 79 RVA: 0x00016064 File Offset: 0x00014264
		// Note: this type is marked as 'beforefieldinit'.
		static JobHandle()
		{
			Il2CppClassPointerStore<JobHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs", "JobHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobHandle>.NativeClassPtr);
			JobHandle.NativeFieldInfoPtr_jobGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, "jobGroup");
			JobHandle.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, "version");
			JobHandle.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663323);
			JobHandle.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663324);
			JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663325);
			JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobsAndComplete_Private_Static_Void_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663326);
			JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobsAndIsCompleted_Private_Static_Boolean_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663327);
			JobHandle.ScheduleBatchedJobsAndCompleteAllDelegateField = IL2CPP.ResolveICall<JobHandle.ScheduleBatchedJobsAndCompleteAllDelegate>("Unity.Jobs.JobHandle::ScheduleBatchedJobsAndCompleteAll");
			JobHandle.CombineDependenciesInternal2_InjectedDelegateField = IL2CPP.ResolveICall<JobHandle.CombineDependenciesInternal2_InjectedDelegate>("Unity.Jobs.JobHandle::CombineDependenciesInternal2_Injected");
			JobHandle.CombineDependenciesInternal3_InjectedDelegateField = IL2CPP.ResolveICall<JobHandle.CombineDependenciesInternal3_InjectedDelegate>("Unity.Jobs.JobHandle::CombineDependenciesInternal3_Injected");
			JobHandle.CombineDependenciesInternalPtr_InjectedDelegateField = IL2CPP.ResolveICall<JobHandle.CombineDependenciesInternalPtr_InjectedDelegate>("Unity.Jobs.JobHandle::CombineDependenciesInternalPtr_Injected");
			JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField = IL2CPP.ResolveICall<JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate>("Unity.Jobs.JobHandle::CheckFenceIsDependencyOrDidSyncFence_Injected");
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0001616C File Offset: 0x0001436C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 485777, RefRangeEnd = 485781, XrefRangeStart = 485774, XrefRangeEnd = 485777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_Complete_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00016194 File Offset: 0x00014394
		public unsafe bool IsCompleted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485781, XrefRangeEnd = 485785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000161C4 File Offset: 0x000143C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485785, XrefRangeEnd = 485789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleBatchedJobs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000161EC File Offset: 0x000143EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485789, XrefRangeEnd = 485793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleBatchedJobsAndComplete(ref JobHandle job)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &job;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobsAndComplete_Private_Static_Void_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00016220 File Offset: 0x00014420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ScheduleBatchedJobsAndIsCompleted(ref JobHandle job)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &job;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobsAndIsCompleted_Private_Static_Boolean_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000243F File Offset: 0x0000063F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00016260 File Offset: 0x00014460
		public unsafe static void CompleteAll(ref JobHandle job0, ref JobHandle job1)
		{
			JobHandle* ptr;
			checked
			{
				ptr = stackalloc JobHandle[unchecked((UIntPtr)2) * (UIntPtr)sizeof(JobHandle)];
				*ptr = job0;
			}
			ptr[1] = job1;
			JobHandle.ScheduleBatchedJobsAndCompleteAll((void*)ptr, 2);
			job0 = default(JobHandle);
			job1 = default(JobHandle);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000162B0 File Offset: 0x000144B0
		public unsafe static void CompleteAll(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2)
		{
			JobHandle* ptr;
			checked
			{
				ptr = stackalloc JobHandle[unchecked((UIntPtr)3) * (UIntPtr)sizeof(JobHandle)];
				*ptr = job0;
			}
			ptr[1] = job1;
			ptr[2] = job2;
			JobHandle.ScheduleBatchedJobsAndCompleteAll((void*)ptr, 3);
			job0 = default(JobHandle);
			job1 = default(JobHandle);
			job2 = default(JobHandle);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002451 File Offset: 0x00000651
		public static void CompleteAll(Unity.Collections.NativeArray<JobHandle> jobs)
		{
			JobHandle.ScheduleBatchedJobsAndCompleteAll(jobs.GetUnsafeReadOnlyPtr<JobHandle>(), jobs.Length);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002467 File Offset: 0x00000667
		public unsafe static void ScheduleBatchedJobsAndCompleteAll(void* jobs, int count)
		{
			JobHandle.ScheduleBatchedJobsAndCompleteAllDelegateField(jobs, count);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0001631C File Offset: 0x0001451C
		public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1)
		{
			return JobHandle.CombineDependenciesInternal2(ref job0, ref job1);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00016338 File Offset: 0x00014538
		public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1, JobHandle job2)
		{
			return JobHandle.CombineDependenciesInternal3(ref job0, ref job1, ref job2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00016358 File Offset: 0x00014558
		public static JobHandle CombineDependencies(Unity.Collections.NativeArray<JobHandle> jobs)
		{
			return JobHandle.CombineDependenciesInternalPtr(jobs.GetUnsafeReadOnlyPtr<JobHandle>(), jobs.Length);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0001637C File Offset: 0x0001457C
		public static JobHandle CombineDependencies(Unity.Collections.NativeSlice<JobHandle> jobs)
		{
			return JobHandle.CombineDependenciesInternalPtr(Unity.Collections.LowLevel.Unsafe.NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<JobHandle>(jobs), jobs.Length);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000163A0 File Offset: 0x000145A0
		public static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1)
		{
			JobHandle jobHandle;
			JobHandle.CombineDependenciesInternal2_Injected(ref job0, ref job1, out jobHandle);
			return jobHandle;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000163B8 File Offset: 0x000145B8
		public static JobHandle CombineDependenciesInternal3(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2)
		{
			JobHandle jobHandle;
			JobHandle.CombineDependenciesInternal3_Injected(ref job0, ref job1, ref job2, out jobHandle);
			return jobHandle;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000163D0 File Offset: 0x000145D0
		public unsafe static JobHandle CombineDependenciesInternalPtr(void* jobs, int count)
		{
			JobHandle jobHandle;
			JobHandle.CombineDependenciesInternalPtr_Injected(jobs, count, out jobHandle);
			return jobHandle;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002475 File Offset: 0x00000675
		public static bool CheckFenceIsDependencyOrDidSyncFence(JobHandle jobHandle, JobHandle dependsOn)
		{
			return JobHandle.CheckFenceIsDependencyOrDidSyncFence_Injected(ref jobHandle, ref dependsOn);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002480 File Offset: 0x00000680
		public static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret)
		{
			JobHandle.CombineDependenciesInternal2_InjectedDelegateField(ref job0, ref job1, out ret);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000248F File Offset: 0x0000068F
		public static void CombineDependenciesInternal3_Injected(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2, out JobHandle ret)
		{
			JobHandle.CombineDependenciesInternal3_InjectedDelegateField(ref job0, ref job1, ref job2, out ret);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000249F File Offset: 0x0000069F
		public unsafe static void CombineDependenciesInternalPtr_Injected(void* jobs, int count, out JobHandle ret)
		{
			JobHandle.CombineDependenciesInternalPtr_InjectedDelegateField(jobs, count, out ret);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000024AE File Offset: 0x000006AE
		public static bool CheckFenceIsDependencyOrDidSyncFence_Injected(ref JobHandle jobHandle, ref JobHandle dependsOn)
		{
			return JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField(ref jobHandle, ref dependsOn);
		}

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_jobGroup;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleBatchedJobsAndComplete_Private_Static_Void_byref_JobHandle_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleBatchedJobsAndIsCompleted_Private_Static_Boolean_byref_JobHandle_0;

		// Token: 0x04000055 RID: 85
		[FieldOffset(0)]
		public IntPtr jobGroup;

		// Token: 0x04000056 RID: 86
		[FieldOffset(8)]
		public int version;

		// Token: 0x04000057 RID: 87
		private static readonly JobHandle.ScheduleBatchedJobsAndCompleteAllDelegate ScheduleBatchedJobsAndCompleteAllDelegateField;

		// Token: 0x04000058 RID: 88
		private static readonly JobHandle.CombineDependenciesInternal2_InjectedDelegate CombineDependenciesInternal2_InjectedDelegateField;

		// Token: 0x04000059 RID: 89
		private static readonly JobHandle.CombineDependenciesInternal3_InjectedDelegate CombineDependenciesInternal3_InjectedDelegateField;

		// Token: 0x0400005A RID: 90
		private static readonly JobHandle.CombineDependenciesInternalPtr_InjectedDelegate CombineDependenciesInternalPtr_InjectedDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField;

		// Token: 0x020002FD RID: 765
		// (Invoke) Token: 0x060023FD RID: 9213
		private delegate void ScheduleBatchedJobsAndCompleteAllDelegate(IntPtr jobs, int count);

		// Token: 0x020002FE RID: 766
		// (Invoke) Token: 0x060023FF RID: 9215
		private delegate void CombineDependenciesInternal2_InjectedDelegate(IntPtr job0, IntPtr job1, [Out] IntPtr ret);

		// Token: 0x020002FF RID: 767
		// (Invoke) Token: 0x06002401 RID: 9217
		private delegate void CombineDependenciesInternal3_InjectedDelegate(IntPtr job0, IntPtr job1, IntPtr job2, [Out] IntPtr ret);

		// Token: 0x02000300 RID: 768
		// (Invoke) Token: 0x06002403 RID: 9219
		private delegate void CombineDependenciesInternalPtr_InjectedDelegate(IntPtr jobs, int count, [Out] IntPtr ret);

		// Token: 0x02000301 RID: 769
		// (Invoke) Token: 0x06002405 RID: 9221
		private delegate bool CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate(IntPtr jobHandle, IntPtr dependsOn);
	}
}
