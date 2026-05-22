using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A1 RID: 417
	[OriginalName("mscorlib.dll", "System.Reflection", "CallingConventions")]
	[Flags]
	[Serializable]
	public enum CallingConventions
	{
		// Token: 0x04001965 RID: 6501
		Standard = 1,
		// Token: 0x04001966 RID: 6502
		VarArgs = 2,
		// Token: 0x04001967 RID: 6503
		Any = 3,
		// Token: 0x04001968 RID: 6504
		HasThis = 32,
		// Token: 0x04001969 RID: 6505
		ExplicitThis = 64
	}
}
