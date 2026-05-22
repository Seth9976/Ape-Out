using System;

namespace Unity.Profiling.LowLevel
{
	// Token: 0x020001C3 RID: 451
	public enum ProfilerMarkerDataType : byte
	{
		// Token: 0x040019EA RID: 6634
		Int32 = 2,
		// Token: 0x040019EB RID: 6635
		UInt32,
		// Token: 0x040019EC RID: 6636
		Int64,
		// Token: 0x040019ED RID: 6637
		UInt64,
		// Token: 0x040019EE RID: 6638
		Float,
		// Token: 0x040019EF RID: 6639
		Double,
		// Token: 0x040019F0 RID: 6640
		String16 = 9,
		// Token: 0x040019F1 RID: 6641
		Blob8 = 11
	}
}
