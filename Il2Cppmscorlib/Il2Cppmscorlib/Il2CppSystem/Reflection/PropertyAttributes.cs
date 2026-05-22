using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001BA RID: 442
	[OriginalName("mscorlib.dll", "System.Reflection", "PropertyAttributes")]
	[Flags]
	[Serializable]
	public enum PropertyAttributes
	{
		// Token: 0x04001A56 RID: 6742
		None = 0,
		// Token: 0x04001A57 RID: 6743
		SpecialName = 512,
		// Token: 0x04001A58 RID: 6744
		ReservedMask = 62464,
		// Token: 0x04001A59 RID: 6745
		RTSpecialName = 1024,
		// Token: 0x04001A5A RID: 6746
		HasDefault = 4096,
		// Token: 0x04001A5B RID: 6747
		Reserved2 = 8192,
		// Token: 0x04001A5C RID: 6748
		Reserved3 = 16384,
		// Token: 0x04001A5D RID: 6749
		Reserved4 = 32768
	}
}
