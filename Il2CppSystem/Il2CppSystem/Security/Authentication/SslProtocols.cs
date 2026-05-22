using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Authentication
{
	// Token: 0x020000A1 RID: 161
	[OriginalName("System.dll", "System.Security.Authentication", "SslProtocols")]
	[Flags]
	public enum SslProtocols
	{
		// Token: 0x040006A3 RID: 1699
		None = 0,
		// Token: 0x040006A4 RID: 1700
		Ssl2 = 12,
		// Token: 0x040006A5 RID: 1701
		Ssl3 = 48,
		// Token: 0x040006A6 RID: 1702
		Tls = 192,
		// Token: 0x040006A7 RID: 1703
		Tls11 = 768,
		// Token: 0x040006A8 RID: 1704
		Tls12 = 3072,
		// Token: 0x040006A9 RID: 1705
		Default = 240
	}
}
