using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001B7 RID: 439
	[OriginalName("mscorlib.dll", "System.Reflection", "ParameterAttributes")]
	[Flags]
	[Serializable]
	public enum ParameterAttributes
	{
		// Token: 0x04001A43 RID: 6723
		None = 0,
		// Token: 0x04001A44 RID: 6724
		In = 1,
		// Token: 0x04001A45 RID: 6725
		Out = 2,
		// Token: 0x04001A46 RID: 6726
		Lcid = 4,
		// Token: 0x04001A47 RID: 6727
		Retval = 8,
		// Token: 0x04001A48 RID: 6728
		Optional = 16,
		// Token: 0x04001A49 RID: 6729
		ReservedMask = 61440,
		// Token: 0x04001A4A RID: 6730
		HasDefault = 4096,
		// Token: 0x04001A4B RID: 6731
		HasFieldMarshal = 8192,
		// Token: 0x04001A4C RID: 6732
		Reserved3 = 16384,
		// Token: 0x04001A4D RID: 6733
		Reserved4 = 32768
	}
}
