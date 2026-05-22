using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000232 RID: 562
	[OriginalName("mscorlib.dll", "System.Globalization", "DateTimeFormatFlags")]
	[Flags]
	public enum DateTimeFormatFlags
	{
		// Token: 0x04002152 RID: 8530
		None = 0,
		// Token: 0x04002153 RID: 8531
		UseGenitiveMonth = 1,
		// Token: 0x04002154 RID: 8532
		UseLeapYearMonth = 2,
		// Token: 0x04002155 RID: 8533
		UseSpacesInMonthNames = 4,
		// Token: 0x04002156 RID: 8534
		UseHebrewRule = 8,
		// Token: 0x04002157 RID: 8535
		UseSpacesInDayNames = 16,
		// Token: 0x04002158 RID: 8536
		UseDigitPrefixInTokens = 32,
		// Token: 0x04002159 RID: 8537
		NotInitialized = -1
	}
}
