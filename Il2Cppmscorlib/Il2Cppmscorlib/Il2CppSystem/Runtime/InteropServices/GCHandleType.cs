using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200045A RID: 1114
	[OriginalName("mscorlib.dll", "System.Runtime.InteropServices", "GCHandleType")]
	[Serializable]
	public enum GCHandleType
	{
		// Token: 0x040037BE RID: 14270
		Weak,
		// Token: 0x040037BF RID: 14271
		WeakTrackResurrection,
		// Token: 0x040037C0 RID: 14272
		Normal,
		// Token: 0x040037C1 RID: 14273
		Pinned
	}
}
