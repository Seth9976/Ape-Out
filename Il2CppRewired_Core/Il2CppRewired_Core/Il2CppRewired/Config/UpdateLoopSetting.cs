using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppRewired.Config
{
	// Token: 0x02000058 RID: 88
	[OriginalName("Rewired_Core.dll", "Rewired.Config", "UpdateLoopSetting")]
	[Flags]
	public enum UpdateLoopSetting
	{
		// Token: 0x040008BA RID: 2234
		None = 0,
		// Token: 0x040008BB RID: 2235
		Update = 1,
		// Token: 0x040008BC RID: 2236
		FixedUpdate = 2,
		// Token: 0x040008BD RID: 2237
		OnGUI = 4
	}
}
