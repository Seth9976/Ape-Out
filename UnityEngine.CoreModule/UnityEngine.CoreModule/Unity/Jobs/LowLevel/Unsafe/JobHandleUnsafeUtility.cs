using System;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x020001C6 RID: 454
	public static class JobHandleUnsafeUtility
	{
		// Token: 0x06001FC6 RID: 8134 RVA: 0x00073CD0 File Offset: 0x00071ED0
		public unsafe static JobHandle CombineDependencies(JobHandle* jobs, int count)
		{
			return JobHandle.CombineDependenciesInternalPtr((void*)jobs, count);
		}
	}
}
