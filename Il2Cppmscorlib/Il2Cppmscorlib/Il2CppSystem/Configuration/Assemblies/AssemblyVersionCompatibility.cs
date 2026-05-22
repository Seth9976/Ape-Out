using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Configuration.Assemblies
{
	// Token: 0x02000156 RID: 342
	[OriginalName("mscorlib.dll", "System.Configuration.Assemblies", "AssemblyVersionCompatibility")]
	[Serializable]
	public enum AssemblyVersionCompatibility
	{
		// Token: 0x040015DC RID: 5596
		SameMachine = 1,
		// Token: 0x040015DD RID: 5597
		SameProcess,
		// Token: 0x040015DE RID: 5598
		SameDomain
	}
}
