using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200031F RID: 799
	[OriginalName("mscorlib.dll", "System.Security.Cryptography.X509Certificates", "X509KeyStorageFlags")]
	[Flags]
	public enum X509KeyStorageFlags
	{
		// Token: 0x04002CC1 RID: 11457
		DefaultKeySet = 0,
		// Token: 0x04002CC2 RID: 11458
		UserKeySet = 1,
		// Token: 0x04002CC3 RID: 11459
		MachineKeySet = 2,
		// Token: 0x04002CC4 RID: 11460
		Exportable = 4,
		// Token: 0x04002CC5 RID: 11461
		UserProtected = 8,
		// Token: 0x04002CC6 RID: 11462
		PersistKeySet = 16,
		// Token: 0x04002CC7 RID: 11463
		EphemeralKeySet = 32
	}
}
