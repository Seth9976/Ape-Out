using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200023E RID: 574
	[OriginalName("mscorlib.dll", "System.Globalization", "HebrewNumberParsingState")]
	public enum HebrewNumberParsingState
	{
		// Token: 0x0400229E RID: 8862
		InvalidHebrewNumber,
		// Token: 0x0400229F RID: 8863
		NotHebrewDigit,
		// Token: 0x040022A0 RID: 8864
		FoundEndOfHebrewNumber,
		// Token: 0x040022A1 RID: 8865
		ContinueParsing
	}
}
