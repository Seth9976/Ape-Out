using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x02000042 RID: 66
	[OriginalName("mscorlib.dll", "Microsoft.Win32", "RegistryValueKind")]
	public enum RegistryValueKind
	{
		// Token: 0x04000320 RID: 800
		Unknown,
		// Token: 0x04000321 RID: 801
		String,
		// Token: 0x04000322 RID: 802
		ExpandString,
		// Token: 0x04000323 RID: 803
		Binary,
		// Token: 0x04000324 RID: 804
		DWord,
		// Token: 0x04000325 RID: 805
		MultiString = 7,
		// Token: 0x04000326 RID: 806
		QWord = 11,
		// Token: 0x04000327 RID: 807
		None = -1
	}
}
