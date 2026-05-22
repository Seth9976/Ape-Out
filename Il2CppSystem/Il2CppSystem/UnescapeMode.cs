using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x02000036 RID: 54
	[OriginalName("System.dll", "System", "UnescapeMode")]
	[Flags]
	public enum UnescapeMode
	{
		// Token: 0x04000281 RID: 641
		CopyOnly = 0,
		// Token: 0x04000282 RID: 642
		Escape = 1,
		// Token: 0x04000283 RID: 643
		Unescape = 2,
		// Token: 0x04000284 RID: 644
		EscapeUnescape = 3,
		// Token: 0x04000285 RID: 645
		V1ToStringFlag = 4,
		// Token: 0x04000286 RID: 646
		UnescapeAll = 8,
		// Token: 0x04000287 RID: 647
		UnescapeAllOrThrow = 24
	}
}
