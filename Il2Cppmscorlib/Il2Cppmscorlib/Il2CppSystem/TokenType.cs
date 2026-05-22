using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x020000B5 RID: 181
	[OriginalName("mscorlib.dll", "System", "TokenType")]
	public enum TokenType
	{
		// Token: 0x04000AE0 RID: 2784
		NumberToken = 1,
		// Token: 0x04000AE1 RID: 2785
		YearNumberToken,
		// Token: 0x04000AE2 RID: 2786
		Am,
		// Token: 0x04000AE3 RID: 2787
		Pm,
		// Token: 0x04000AE4 RID: 2788
		MonthToken,
		// Token: 0x04000AE5 RID: 2789
		EndOfString,
		// Token: 0x04000AE6 RID: 2790
		DayOfWeekToken,
		// Token: 0x04000AE7 RID: 2791
		TimeZoneToken,
		// Token: 0x04000AE8 RID: 2792
		EraToken,
		// Token: 0x04000AE9 RID: 2793
		DateWordToken,
		// Token: 0x04000AEA RID: 2794
		UnknownToken,
		// Token: 0x04000AEB RID: 2795
		HebrewNumber,
		// Token: 0x04000AEC RID: 2796
		JapaneseEraToken,
		// Token: 0x04000AED RID: 2797
		TEraToken,
		// Token: 0x04000AEE RID: 2798
		IgnorableSymbol,
		// Token: 0x04000AEF RID: 2799
		SEP_Unk = 256,
		// Token: 0x04000AF0 RID: 2800
		SEP_End = 512,
		// Token: 0x04000AF1 RID: 2801
		SEP_Space = 768,
		// Token: 0x04000AF2 RID: 2802
		SEP_Am = 1024,
		// Token: 0x04000AF3 RID: 2803
		SEP_Pm = 1280,
		// Token: 0x04000AF4 RID: 2804
		SEP_Date = 1536,
		// Token: 0x04000AF5 RID: 2805
		SEP_Time = 1792,
		// Token: 0x04000AF6 RID: 2806
		SEP_YearSuff = 2048,
		// Token: 0x04000AF7 RID: 2807
		SEP_MonthSuff = 2304,
		// Token: 0x04000AF8 RID: 2808
		SEP_DaySuff = 2560,
		// Token: 0x04000AF9 RID: 2809
		SEP_HourSuff = 2816,
		// Token: 0x04000AFA RID: 2810
		SEP_MinuteSuff = 3072,
		// Token: 0x04000AFB RID: 2811
		SEP_SecondSuff = 3328,
		// Token: 0x04000AFC RID: 2812
		SEP_LocalTimeMark = 3584,
		// Token: 0x04000AFD RID: 2813
		SEP_DateOrOffset = 3840,
		// Token: 0x04000AFE RID: 2814
		RegularTokenMask = 255,
		// Token: 0x04000AFF RID: 2815
		SeparatorTokenMask = 65280
	}
}
