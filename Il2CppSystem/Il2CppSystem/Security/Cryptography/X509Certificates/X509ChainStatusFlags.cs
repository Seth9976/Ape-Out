using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000AA RID: 170
	[OriginalName("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainStatusFlags")]
	[Flags]
	public enum X509ChainStatusFlags
	{
		// Token: 0x040006EC RID: 1772
		NoError = 0,
		// Token: 0x040006ED RID: 1773
		NotTimeValid = 1,
		// Token: 0x040006EE RID: 1774
		NotTimeNested = 2,
		// Token: 0x040006EF RID: 1775
		Revoked = 4,
		// Token: 0x040006F0 RID: 1776
		NotSignatureValid = 8,
		// Token: 0x040006F1 RID: 1777
		NotValidForUsage = 16,
		// Token: 0x040006F2 RID: 1778
		UntrustedRoot = 32,
		// Token: 0x040006F3 RID: 1779
		RevocationStatusUnknown = 64,
		// Token: 0x040006F4 RID: 1780
		Cyclic = 128,
		// Token: 0x040006F5 RID: 1781
		InvalidExtension = 256,
		// Token: 0x040006F6 RID: 1782
		InvalidPolicyConstraints = 512,
		// Token: 0x040006F7 RID: 1783
		InvalidBasicConstraints = 1024,
		// Token: 0x040006F8 RID: 1784
		InvalidNameConstraints = 2048,
		// Token: 0x040006F9 RID: 1785
		HasNotSupportedNameConstraint = 4096,
		// Token: 0x040006FA RID: 1786
		HasNotDefinedNameConstraint = 8192,
		// Token: 0x040006FB RID: 1787
		HasNotPermittedNameConstraint = 16384,
		// Token: 0x040006FC RID: 1788
		HasExcludedNameConstraint = 32768,
		// Token: 0x040006FD RID: 1789
		PartialChain = 65536,
		// Token: 0x040006FE RID: 1790
		CtlNotTimeValid = 131072,
		// Token: 0x040006FF RID: 1791
		CtlNotSignatureValid = 262144,
		// Token: 0x04000700 RID: 1792
		CtlNotValidForUsage = 524288,
		// Token: 0x04000701 RID: 1793
		OfflineRevocation = 16777216,
		// Token: 0x04000702 RID: 1794
		NoIssuanceChainPolicy = 33554432,
		// Token: 0x04000703 RID: 1795
		ExplicitDistrust = 67108864,
		// Token: 0x04000704 RID: 1796
		HasNotSupportedCriticalExtension = 134217728,
		// Token: 0x04000705 RID: 1797
		HasWeakSignature = 1048576
	}
}
