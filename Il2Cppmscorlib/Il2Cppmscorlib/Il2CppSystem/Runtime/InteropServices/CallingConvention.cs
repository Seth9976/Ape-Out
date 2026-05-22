using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000451 RID: 1105
	[OriginalName("mscorlib.dll", "System.Runtime.InteropServices", "CallingConvention")]
	[Serializable]
	public enum CallingConvention
	{
		// Token: 0x04003776 RID: 14198
		Winapi = 1,
		// Token: 0x04003777 RID: 14199
		Cdecl,
		// Token: 0x04003778 RID: 14200
		StdCall,
		// Token: 0x04003779 RID: 14201
		ThisCall,
		// Token: 0x0400377A RID: 14202
		FastCall
	}
}
