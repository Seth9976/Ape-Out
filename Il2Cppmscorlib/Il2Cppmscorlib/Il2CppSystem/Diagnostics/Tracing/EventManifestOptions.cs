using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000522 RID: 1314
	[OriginalName("mscorlib.dll", "System.Diagnostics.Tracing", "EventManifestOptions")]
	[Flags]
	public enum EventManifestOptions
	{
		// Token: 0x04003E76 RID: 15990
		None = 0,
		// Token: 0x04003E77 RID: 15991
		Strict = 1,
		// Token: 0x04003E78 RID: 15992
		AllCultures = 2,
		// Token: 0x04003E79 RID: 15993
		OnlyIfNeededForRegistration = 4,
		// Token: 0x04003E7A RID: 15994
		AllowEventSourceOverride = 8
	}
}
