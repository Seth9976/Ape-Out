using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000238 RID: 568
	[OriginalName("mscorlib.dll", "System.Globalization", "DateTimeStyles")]
	[Flags]
	[Serializable]
	public enum DateTimeStyles
	{
		// Token: 0x04002245 RID: 8773
		None = 0,
		// Token: 0x04002246 RID: 8774
		AllowLeadingWhite = 1,
		// Token: 0x04002247 RID: 8775
		AllowTrailingWhite = 2,
		// Token: 0x04002248 RID: 8776
		AllowInnerWhite = 4,
		// Token: 0x04002249 RID: 8777
		AllowWhiteSpaces = 7,
		// Token: 0x0400224A RID: 8778
		NoCurrentDateDefault = 8,
		// Token: 0x0400224B RID: 8779
		AdjustToUniversal = 16,
		// Token: 0x0400224C RID: 8780
		AssumeLocal = 32,
		// Token: 0x0400224D RID: 8781
		AssumeUniversal = 64,
		// Token: 0x0400224E RID: 8782
		RoundtripKind = 128
	}
}
