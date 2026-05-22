using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net
{
	// Token: 0x020000DD RID: 221
	[OriginalName("System.dll", "System.Net", "SecurityProtocolType")]
	[Flags]
	public enum SecurityProtocolType
	{
		// Token: 0x04000962 RID: 2402
		SystemDefault = 0,
		// Token: 0x04000963 RID: 2403
		Ssl3 = 48,
		// Token: 0x04000964 RID: 2404
		Tls = 192,
		// Token: 0x04000965 RID: 2405
		Tls11 = 768,
		// Token: 0x04000966 RID: 2406
		Tls12 = 3072
	}
}
