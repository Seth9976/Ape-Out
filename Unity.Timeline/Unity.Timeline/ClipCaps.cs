using System;

namespace UnityEngine.Timeline
{
	// Token: 0x02000016 RID: 22
	[Flags]
	public enum ClipCaps
	{
		// Token: 0x04000223 RID: 547
		None = 0,
		// Token: 0x04000224 RID: 548
		Looping = 1,
		// Token: 0x04000225 RID: 549
		Extrapolation = 2,
		// Token: 0x04000226 RID: 550
		ClipIn = 4,
		// Token: 0x04000227 RID: 551
		SpeedMultiplier = 8,
		// Token: 0x04000228 RID: 552
		Blending = 16,
		// Token: 0x04000229 RID: 553
		AutoScale = 40,
		// Token: 0x0400022A RID: 554
		All = -1
	}
}
