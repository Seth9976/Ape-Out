using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.IO
{
	// Token: 0x0200021C RID: 540
	[OriginalName("mscorlib.dll", "System.IO", "FileShare")]
	[Flags]
	[Serializable]
	public enum FileShare
	{
		// Token: 0x04001F88 RID: 8072
		None = 0,
		// Token: 0x04001F89 RID: 8073
		Read = 1,
		// Token: 0x04001F8A RID: 8074
		Write = 2,
		// Token: 0x04001F8B RID: 8075
		ReadWrite = 3,
		// Token: 0x04001F8C RID: 8076
		Delete = 4,
		// Token: 0x04001F8D RID: 8077
		Inheritable = 16
	}
}
