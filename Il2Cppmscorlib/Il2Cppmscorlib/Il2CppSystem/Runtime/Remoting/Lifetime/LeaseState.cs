using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020003B3 RID: 947
	[OriginalName("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "LeaseState")]
	[Serializable]
	public enum LeaseState
	{
		// Token: 0x0400338F RID: 13199
		Null,
		// Token: 0x04003390 RID: 13200
		Initial,
		// Token: 0x04003391 RID: 13201
		Active,
		// Token: 0x04003392 RID: 13202
		Renewing,
		// Token: 0x04003393 RID: 13203
		Expired
	}
}
