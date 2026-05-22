using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A9 RID: 681
	[OriginalName("mscorlib.dll", "System.Threading.Tasks", "TaskCreationOptions")]
	[Flags]
	[Serializable]
	public enum TaskCreationOptions
	{
		// Token: 0x040028AF RID: 10415
		None = 0,
		// Token: 0x040028B0 RID: 10416
		PreferFairness = 1,
		// Token: 0x040028B1 RID: 10417
		LongRunning = 2,
		// Token: 0x040028B2 RID: 10418
		AttachedToParent = 4,
		// Token: 0x040028B3 RID: 10419
		DenyChildAttach = 8,
		// Token: 0x040028B4 RID: 10420
		HideScheduler = 16,
		// Token: 0x040028B5 RID: 10421
		RunContinuationsAsynchronously = 64
	}
}
