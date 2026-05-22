using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002DE RID: 734
	[OriginalName("mscorlib.dll", "System.Security.Cryptography", "CspProviderFlags")]
	[Flags]
	[Serializable]
	public enum CspProviderFlags
	{
		// Token: 0x04002A71 RID: 10865
		NoFlags = 0,
		// Token: 0x04002A72 RID: 10866
		UseMachineKeyStore = 1,
		// Token: 0x04002A73 RID: 10867
		UseDefaultKeyContainer = 2,
		// Token: 0x04002A74 RID: 10868
		UseNonExportableKey = 4,
		// Token: 0x04002A75 RID: 10869
		UseExistingKey = 8,
		// Token: 0x04002A76 RID: 10870
		UseArchivableKey = 16,
		// Token: 0x04002A77 RID: 10871
		UseUserProtectedKey = 32,
		// Token: 0x04002A78 RID: 10872
		NoPrompt = 64,
		// Token: 0x04002A79 RID: 10873
		CreateEphemeralKey = 128
	}
}
