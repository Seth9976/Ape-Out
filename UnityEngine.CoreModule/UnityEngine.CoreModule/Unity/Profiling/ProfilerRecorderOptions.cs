using System;

namespace Unity.Profiling
{
	// Token: 0x020001BF RID: 447
	public enum ProfilerRecorderOptions
	{
		// Token: 0x040019DA RID: 6618
		None,
		// Token: 0x040019DB RID: 6619
		StartImmediately,
		// Token: 0x040019DC RID: 6620
		KeepAliveDuringDomainReload,
		// Token: 0x040019DD RID: 6621
		CollectOnlyOnCurrentThread = 4,
		// Token: 0x040019DE RID: 6622
		WrapAroundWhenCapacityReached = 8,
		// Token: 0x040019DF RID: 6623
		SumAllSamplesInFrame = 16,
		// Token: 0x040019E0 RID: 6624
		Default = 24
	}
}
