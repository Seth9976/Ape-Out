using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200027F RID: 639
	[OriginalName("mscorlib.dll", "System.Threading", "StackCrawlMark")]
	[Serializable]
	public enum StackCrawlMark
	{
		// Token: 0x040026AF RID: 9903
		LookForMe,
		// Token: 0x040026B0 RID: 9904
		LookForMyCaller,
		// Token: 0x040026B1 RID: 9905
		LookForMyCallersCaller,
		// Token: 0x040026B2 RID: 9906
		LookForThread
	}
}
