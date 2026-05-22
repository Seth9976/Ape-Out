using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200019C RID: 412
	[OriginalName("mscorlib.dll", "System.Reflection", "AssemblyNameFlags")]
	[Flags]
	[Serializable]
	public enum AssemblyNameFlags
	{
		// Token: 0x04001939 RID: 6457
		None = 0,
		// Token: 0x0400193A RID: 6458
		PublicKey = 1,
		// Token: 0x0400193B RID: 6459
		EnableJITcompileOptimizer = 16384,
		// Token: 0x0400193C RID: 6460
		EnableJITcompileTracking = 32768,
		// Token: 0x0400193D RID: 6461
		Retargetable = 256
	}
}
