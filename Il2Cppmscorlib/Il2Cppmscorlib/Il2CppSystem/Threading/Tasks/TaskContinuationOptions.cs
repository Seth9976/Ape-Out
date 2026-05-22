using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002AB RID: 683
	[OriginalName("mscorlib.dll", "System.Threading.Tasks", "TaskContinuationOptions")]
	[Flags]
	[Serializable]
	public enum TaskContinuationOptions
	{
		// Token: 0x040028C1 RID: 10433
		None = 0,
		// Token: 0x040028C2 RID: 10434
		PreferFairness = 1,
		// Token: 0x040028C3 RID: 10435
		LongRunning = 2,
		// Token: 0x040028C4 RID: 10436
		AttachedToParent = 4,
		// Token: 0x040028C5 RID: 10437
		DenyChildAttach = 8,
		// Token: 0x040028C6 RID: 10438
		HideScheduler = 16,
		// Token: 0x040028C7 RID: 10439
		LazyCancellation = 32,
		// Token: 0x040028C8 RID: 10440
		RunContinuationsAsynchronously = 64,
		// Token: 0x040028C9 RID: 10441
		NotOnRanToCompletion = 65536,
		// Token: 0x040028CA RID: 10442
		NotOnFaulted = 131072,
		// Token: 0x040028CB RID: 10443
		NotOnCanceled = 262144,
		// Token: 0x040028CC RID: 10444
		OnlyOnRanToCompletion = 393216,
		// Token: 0x040028CD RID: 10445
		OnlyOnFaulted = 327680,
		// Token: 0x040028CE RID: 10446
		OnlyOnCanceled = 196608,
		// Token: 0x040028CF RID: 10447
		ExecuteSynchronously = 524288
	}
}
