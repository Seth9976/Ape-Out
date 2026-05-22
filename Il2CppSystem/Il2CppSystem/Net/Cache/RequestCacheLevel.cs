using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x02000171 RID: 369
	[OriginalName("System.dll", "System.Net.Cache", "RequestCacheLevel")]
	public enum RequestCacheLevel
	{
		// Token: 0x0400124E RID: 4686
		Default,
		// Token: 0x0400124F RID: 4687
		BypassCache,
		// Token: 0x04001250 RID: 4688
		CacheOnly,
		// Token: 0x04001251 RID: 4689
		CacheIfAvailable,
		// Token: 0x04001252 RID: 4690
		Revalidate,
		// Token: 0x04001253 RID: 4691
		Reload,
		// Token: 0x04001254 RID: 4692
		NoCacheNoStore
	}
}
