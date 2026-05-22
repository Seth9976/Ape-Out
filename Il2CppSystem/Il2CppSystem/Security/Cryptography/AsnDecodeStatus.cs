using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020000A7 RID: 167
	[OriginalName("System.dll", "System.Security.Cryptography", "AsnDecodeStatus")]
	public enum AsnDecodeStatus
	{
		// Token: 0x040006D2 RID: 1746
		NotDecoded = -1,
		// Token: 0x040006D3 RID: 1747
		Ok,
		// Token: 0x040006D4 RID: 1748
		BadAsn,
		// Token: 0x040006D5 RID: 1749
		BadTag,
		// Token: 0x040006D6 RID: 1750
		BadLength,
		// Token: 0x040006D7 RID: 1751
		InformationNotAvailable
	}
}
