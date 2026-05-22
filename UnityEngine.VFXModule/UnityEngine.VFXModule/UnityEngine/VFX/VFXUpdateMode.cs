using System;

namespace UnityEngine.VFX
{
	// Token: 0x02000014 RID: 20
	public enum VFXUpdateMode
	{
		// Token: 0x04000172 RID: 370
		FixedDeltaTime,
		// Token: 0x04000173 RID: 371
		DeltaTime,
		// Token: 0x04000174 RID: 372
		IgnoreTimeScale,
		// Token: 0x04000175 RID: 373
		ExactFixedTimeStep = 4,
		// Token: 0x04000176 RID: 374
		DeltaTimeAndIgnoreTimeScale = 3,
		// Token: 0x04000177 RID: 375
		FixedDeltaAndExactTime,
		// Token: 0x04000178 RID: 376
		FixedDeltaAndExactTimeAndIgnoreTimeScale = 6
	}
}
