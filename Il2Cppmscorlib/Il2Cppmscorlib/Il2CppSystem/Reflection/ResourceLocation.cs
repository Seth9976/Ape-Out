using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001AB RID: 427
	[OriginalName("mscorlib.dll", "System.Reflection", "ResourceLocation")]
	[Flags]
	[Serializable]
	public enum ResourceLocation
	{
		// Token: 0x0400199F RID: 6559
		Embedded = 1,
		// Token: 0x040019A0 RID: 6560
		ContainedInAnotherAssembly = 2,
		// Token: 0x040019A1 RID: 6561
		ContainedInManifestFile = 4
	}
}
