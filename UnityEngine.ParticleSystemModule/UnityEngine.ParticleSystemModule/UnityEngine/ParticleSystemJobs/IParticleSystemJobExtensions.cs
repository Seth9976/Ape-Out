using System;
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;

namespace UnityEngine.ParticleSystemJobs
{
	// Token: 0x02000038 RID: 56
	public static class IParticleSystemJobExtensions
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x0000299E File Offset: 0x00000B9E
		public static JobHandle Schedule<T>(T jobData, ParticleSystem ps, [Optional] JobHandle dependsOn) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000029AB File Offset: 0x00000BAB
		public static JobHandle Schedule<T>(T jobData, ParticleSystem ps, int minIndicesPerJobCount, [Optional] JobHandle dependsOn) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000029B8 File Offset: 0x00000BB8
		public static JobHandle ScheduleBatch<T>(T jobData, ParticleSystem ps, int innerLoopBatchCount, [Optional] JobHandle dependsOn) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00004E04 File Offset: 0x00003004
		public static JobsUtility.JobScheduleParameters CreateScheduleParams<T>(ref T jobData, ParticleSystem ps, JobHandle dependsOn, IntPtr jobReflectionData) where T : struct
		{
			dependsOn = JobHandle.CombineDependencies(ps.GetManagedJobHandle(), dependsOn);
			return new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf<T>(ref jobData), jobReflectionData, dependsOn, ScheduleMode.Batched);
		}
	}
}
