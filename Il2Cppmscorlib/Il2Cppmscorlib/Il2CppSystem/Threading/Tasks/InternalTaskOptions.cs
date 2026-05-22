using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002AA RID: 682
	[OriginalName("mscorlib.dll", "System.Threading.Tasks", "InternalTaskOptions")]
	[Flags]
	[Serializable]
	public enum InternalTaskOptions
	{
		// Token: 0x040028B7 RID: 10423
		None = 0,
		// Token: 0x040028B8 RID: 10424
		InternalOptionsMask = 65280,
		// Token: 0x040028B9 RID: 10425
		ChildReplica = 256,
		// Token: 0x040028BA RID: 10426
		ContinuationTask = 512,
		// Token: 0x040028BB RID: 10427
		PromiseTask = 1024,
		// Token: 0x040028BC RID: 10428
		SelfReplicating = 2048,
		// Token: 0x040028BD RID: 10429
		LazyCancellation = 4096,
		// Token: 0x040028BE RID: 10430
		QueuedByRuntime = 8192,
		// Token: 0x040028BF RID: 10431
		DoNotDispose = 16384
	}
}
