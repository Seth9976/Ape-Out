using System;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x0200001A RID: 26
	public enum ProcessingState
	{
		// Token: 0x0400009C RID: 156
		Unknown,
		// Token: 0x0400009D RID: 157
		InQueue,
		// Token: 0x0400009E RID: 158
		Reading,
		// Token: 0x0400009F RID: 159
		Completed,
		// Token: 0x040000A0 RID: 160
		Failed,
		// Token: 0x040000A1 RID: 161
		Canceled
	}
}
