using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x0200014F RID: 335
	[OriginalName("System.dll", "System.Net.Sockets", "SocketFlags")]
	[Flags]
	public enum SocketFlags
	{
		// Token: 0x0400111B RID: 4379
		None = 0,
		// Token: 0x0400111C RID: 4380
		OutOfBand = 1,
		// Token: 0x0400111D RID: 4381
		Peek = 2,
		// Token: 0x0400111E RID: 4382
		DontRoute = 4,
		// Token: 0x0400111F RID: 4383
		MaxIOVectorLength = 16,
		// Token: 0x04001120 RID: 4384
		Truncated = 256,
		// Token: 0x04001121 RID: 4385
		ControlDataTruncated = 512,
		// Token: 0x04001122 RID: 4386
		Broadcast = 1024,
		// Token: 0x04001123 RID: 4387
		Multicast = 2048,
		// Token: 0x04001124 RID: 4388
		Partial = 32768
	}
}
