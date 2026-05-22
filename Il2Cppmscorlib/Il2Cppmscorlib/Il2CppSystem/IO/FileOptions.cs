using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.IO
{
	// Token: 0x0200021B RID: 539
	[OriginalName("mscorlib.dll", "System.IO", "FileOptions")]
	[Flags]
	[Serializable]
	public enum FileOptions
	{
		// Token: 0x04001F80 RID: 8064
		None = 0,
		// Token: 0x04001F81 RID: 8065
		Encrypted = 16384,
		// Token: 0x04001F82 RID: 8066
		DeleteOnClose = 67108864,
		// Token: 0x04001F83 RID: 8067
		SequentialScan = 134217728,
		// Token: 0x04001F84 RID: 8068
		RandomAccess = 268435456,
		// Token: 0x04001F85 RID: 8069
		Asynchronous = 1073741824,
		// Token: 0x04001F86 RID: 8070
		WriteThrough = -2147483648
	}
}
