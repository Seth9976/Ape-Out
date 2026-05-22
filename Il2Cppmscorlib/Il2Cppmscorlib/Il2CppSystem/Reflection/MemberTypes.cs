using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001B0 RID: 432
	[OriginalName("mscorlib.dll", "System.Reflection", "MemberTypes")]
	[Flags]
	[Serializable]
	public enum MemberTypes
	{
		// Token: 0x040019D8 RID: 6616
		Constructor = 1,
		// Token: 0x040019D9 RID: 6617
		Event = 2,
		// Token: 0x040019DA RID: 6618
		Field = 4,
		// Token: 0x040019DB RID: 6619
		Method = 8,
		// Token: 0x040019DC RID: 6620
		Property = 16,
		// Token: 0x040019DD RID: 6621
		TypeInfo = 32,
		// Token: 0x040019DE RID: 6622
		Custom = 64,
		// Token: 0x040019DF RID: 6623
		NestedType = 128,
		// Token: 0x040019E0 RID: 6624
		All = 191
	}
}
