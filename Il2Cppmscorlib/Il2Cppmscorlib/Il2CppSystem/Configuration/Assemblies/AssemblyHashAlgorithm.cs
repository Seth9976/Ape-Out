using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Configuration.Assemblies
{
	// Token: 0x02000155 RID: 341
	[OriginalName("mscorlib.dll", "System.Configuration.Assemblies", "AssemblyHashAlgorithm")]
	[Serializable]
	public enum AssemblyHashAlgorithm
	{
		// Token: 0x040015D5 RID: 5589
		None,
		// Token: 0x040015D6 RID: 5590
		MD5 = 32771,
		// Token: 0x040015D7 RID: 5591
		SHA1,
		// Token: 0x040015D8 RID: 5592
		SHA256 = 32780,
		// Token: 0x040015D9 RID: 5593
		SHA384,
		// Token: 0x040015DA RID: 5594
		SHA512
	}
}
