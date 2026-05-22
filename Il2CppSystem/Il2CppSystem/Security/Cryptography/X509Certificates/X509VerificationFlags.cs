using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000AF RID: 175
	[OriginalName("System.dll", "System.Security.Cryptography.X509Certificates", "X509VerificationFlags")]
	[Flags]
	public enum X509VerificationFlags
	{
		// Token: 0x0400071E RID: 1822
		NoFlag = 0,
		// Token: 0x0400071F RID: 1823
		IgnoreNotTimeValid = 1,
		// Token: 0x04000720 RID: 1824
		IgnoreCtlNotTimeValid = 2,
		// Token: 0x04000721 RID: 1825
		IgnoreNotTimeNested = 4,
		// Token: 0x04000722 RID: 1826
		IgnoreInvalidBasicConstraints = 8,
		// Token: 0x04000723 RID: 1827
		AllowUnknownCertificateAuthority = 16,
		// Token: 0x04000724 RID: 1828
		IgnoreWrongUsage = 32,
		// Token: 0x04000725 RID: 1829
		IgnoreInvalidName = 64,
		// Token: 0x04000726 RID: 1830
		IgnoreInvalidPolicy = 128,
		// Token: 0x04000727 RID: 1831
		IgnoreEndRevocationUnknown = 256,
		// Token: 0x04000728 RID: 1832
		IgnoreCtlSignerRevocationUnknown = 512,
		// Token: 0x04000729 RID: 1833
		IgnoreCertificateAuthorityRevocationUnknown = 1024,
		// Token: 0x0400072A RID: 1834
		IgnoreRootRevocationUnknown = 2048,
		// Token: 0x0400072B RID: 1835
		AllFlags = 4095
	}
}
