using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Security
{
	// Token: 0x0200015D RID: 349
	[OriginalName("System.dll", "System.Net.Security", "SslPolicyErrors")]
	[Flags]
	public enum SslPolicyErrors
	{
		// Token: 0x040011E6 RID: 4582
		None = 0,
		// Token: 0x040011E7 RID: 4583
		RemoteCertificateNotAvailable = 1,
		// Token: 0x040011E8 RID: 4584
		RemoteCertificateNameMismatch = 2,
		// Token: 0x040011E9 RID: 4585
		RemoteCertificateChainErrors = 4
	}
}
