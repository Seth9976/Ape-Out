using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200022D RID: 557
	[OriginalName("mscorlib.dll", "System.Globalization", "CompareOptions")]
	[Flags]
	[Serializable]
	public enum CompareOptions
	{
		// Token: 0x040020F4 RID: 8436
		None = 0,
		// Token: 0x040020F5 RID: 8437
		IgnoreCase = 1,
		// Token: 0x040020F6 RID: 8438
		IgnoreNonSpace = 2,
		// Token: 0x040020F7 RID: 8439
		IgnoreSymbols = 4,
		// Token: 0x040020F8 RID: 8440
		IgnoreKanaType = 8,
		// Token: 0x040020F9 RID: 8441
		IgnoreWidth = 16,
		// Token: 0x040020FA RID: 8442
		OrdinalIgnoreCase = 268435456,
		// Token: 0x040020FB RID: 8443
		StringSort = 536870912,
		// Token: 0x040020FC RID: 8444
		Ordinal = 1073741824
	}
}
