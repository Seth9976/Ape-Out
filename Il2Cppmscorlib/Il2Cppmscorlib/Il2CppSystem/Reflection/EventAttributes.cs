using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A3 RID: 419
	[OriginalName("mscorlib.dll", "System.Reflection", "EventAttributes")]
	[Flags]
	[Serializable]
	public enum EventAttributes
	{
		// Token: 0x0400196E RID: 6510
		None = 0,
		// Token: 0x0400196F RID: 6511
		SpecialName = 512,
		// Token: 0x04001970 RID: 6512
		ReservedMask = 1024,
		// Token: 0x04001971 RID: 6513
		RTSpecialName = 1024
	}
}
