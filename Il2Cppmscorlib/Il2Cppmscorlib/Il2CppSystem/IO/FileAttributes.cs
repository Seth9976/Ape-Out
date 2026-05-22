using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.IO
{
	// Token: 0x02000219 RID: 537
	[OriginalName("mscorlib.dll", "System.IO", "FileAttributes")]
	[Flags]
	[Serializable]
	public enum FileAttributes
	{
		// Token: 0x04001F68 RID: 8040
		Archive = 32,
		// Token: 0x04001F69 RID: 8041
		Compressed = 2048,
		// Token: 0x04001F6A RID: 8042
		Device = 64,
		// Token: 0x04001F6B RID: 8043
		Directory = 16,
		// Token: 0x04001F6C RID: 8044
		Encrypted = 16384,
		// Token: 0x04001F6D RID: 8045
		Hidden = 2,
		// Token: 0x04001F6E RID: 8046
		Normal = 128,
		// Token: 0x04001F6F RID: 8047
		NotContentIndexed = 8192,
		// Token: 0x04001F70 RID: 8048
		Offline = 4096,
		// Token: 0x04001F71 RID: 8049
		ReadOnly = 1,
		// Token: 0x04001F72 RID: 8050
		ReparsePoint = 1024,
		// Token: 0x04001F73 RID: 8051
		SparseFile = 512,
		// Token: 0x04001F74 RID: 8052
		System = 4,
		// Token: 0x04001F75 RID: 8053
		Temporary = 256,
		// Token: 0x04001F76 RID: 8054
		IntegrityStream = 32768,
		// Token: 0x04001F77 RID: 8055
		NoScrubData = 131072
	}
}
