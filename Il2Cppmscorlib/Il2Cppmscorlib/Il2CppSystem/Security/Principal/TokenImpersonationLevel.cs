using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Principal
{
	// Token: 0x020002CF RID: 719
	[OriginalName("mscorlib.dll", "System.Security.Principal", "TokenImpersonationLevel")]
	[Serializable]
	public enum TokenImpersonationLevel
	{
		// Token: 0x040029E8 RID: 10728
		Anonymous = 1,
		// Token: 0x040029E9 RID: 10729
		Delegation = 4,
		// Token: 0x040029EA RID: 10730
		Identification = 2,
		// Token: 0x040029EB RID: 10731
		Impersonation,
		// Token: 0x040029EC RID: 10732
		None = 0
	}
}
