using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000AB RID: 171
	[OriginalName("System.dll", "System.Security.Cryptography.X509Certificates", "X509KeyUsageFlags")]
	[Flags]
	public enum X509KeyUsageFlags
	{
		// Token: 0x04000707 RID: 1799
		None = 0,
		// Token: 0x04000708 RID: 1800
		EncipherOnly = 1,
		// Token: 0x04000709 RID: 1801
		CrlSign = 2,
		// Token: 0x0400070A RID: 1802
		KeyCertSign = 4,
		// Token: 0x0400070B RID: 1803
		KeyAgreement = 8,
		// Token: 0x0400070C RID: 1804
		DataEncipherment = 16,
		// Token: 0x0400070D RID: 1805
		KeyEncipherment = 32,
		// Token: 0x0400070E RID: 1806
		NonRepudiation = 64,
		// Token: 0x0400070F RID: 1807
		DigitalSignature = 128,
		// Token: 0x04000710 RID: 1808
		DecipherOnly = 32768
	}
}
