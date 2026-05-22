using System;

namespace Unity.Jobs
{
	// Token: 0x020001C5 RID: 453
	public static class IJobForExtensions
	{
		// Token: 0x06001FC3 RID: 8131 RVA: 0x000107A0 File Offset: 0x0000E9A0
		public static JobHandle Schedule<T>(T jobData, int arrayLength, JobHandle dependency) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x000107AD File Offset: 0x0000E9AD
		public static JobHandle ScheduleParallel<T>(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependency) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x000107BA File Offset: 0x0000E9BA
		public static void Run<T>(T jobData, int arrayLength) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
