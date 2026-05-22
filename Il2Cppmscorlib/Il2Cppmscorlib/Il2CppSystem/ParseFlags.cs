using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x020000B2 RID: 178
	[OriginalName("mscorlib.dll", "System", "ParseFlags")]
	[Flags]
	public enum ParseFlags
	{
		// Token: 0x04000AB2 RID: 2738
		HaveYear = 1,
		// Token: 0x04000AB3 RID: 2739
		HaveMonth = 2,
		// Token: 0x04000AB4 RID: 2740
		HaveDay = 4,
		// Token: 0x04000AB5 RID: 2741
		HaveHour = 8,
		// Token: 0x04000AB6 RID: 2742
		HaveMinute = 16,
		// Token: 0x04000AB7 RID: 2743
		HaveSecond = 32,
		// Token: 0x04000AB8 RID: 2744
		HaveTime = 64,
		// Token: 0x04000AB9 RID: 2745
		HaveDate = 128,
		// Token: 0x04000ABA RID: 2746
		TimeZoneUsed = 256,
		// Token: 0x04000ABB RID: 2747
		TimeZoneUtc = 512,
		// Token: 0x04000ABC RID: 2748
		ParsedMonthName = 1024,
		// Token: 0x04000ABD RID: 2749
		CaptureOffset = 2048,
		// Token: 0x04000ABE RID: 2750
		YearDefault = 4096,
		// Token: 0x04000ABF RID: 2751
		Rfc1123Pattern = 8192,
		// Token: 0x04000AC0 RID: 2752
		UtcSortPattern = 16384
	}
}
