using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001BF RID: 447
	[OriginalName("mscorlib.dll", "System.Reflection", "TypeAttributes")]
	[Flags]
	[Serializable]
	public enum TypeAttributes
	{
		// Token: 0x04001A6F RID: 6767
		VisibilityMask = 7,
		// Token: 0x04001A70 RID: 6768
		NotPublic = 0,
		// Token: 0x04001A71 RID: 6769
		Public = 1,
		// Token: 0x04001A72 RID: 6770
		NestedPublic = 2,
		// Token: 0x04001A73 RID: 6771
		NestedPrivate = 3,
		// Token: 0x04001A74 RID: 6772
		NestedFamily = 4,
		// Token: 0x04001A75 RID: 6773
		NestedAssembly = 5,
		// Token: 0x04001A76 RID: 6774
		NestedFamANDAssem = 6,
		// Token: 0x04001A77 RID: 6775
		NestedFamORAssem = 7,
		// Token: 0x04001A78 RID: 6776
		LayoutMask = 24,
		// Token: 0x04001A79 RID: 6777
		AutoLayout = 0,
		// Token: 0x04001A7A RID: 6778
		SequentialLayout = 8,
		// Token: 0x04001A7B RID: 6779
		ExplicitLayout = 16,
		// Token: 0x04001A7C RID: 6780
		ClassSemanticsMask = 32,
		// Token: 0x04001A7D RID: 6781
		Class = 0,
		// Token: 0x04001A7E RID: 6782
		Interface = 32,
		// Token: 0x04001A7F RID: 6783
		Abstract = 128,
		// Token: 0x04001A80 RID: 6784
		Sealed = 256,
		// Token: 0x04001A81 RID: 6785
		SpecialName = 1024,
		// Token: 0x04001A82 RID: 6786
		Import = 4096,
		// Token: 0x04001A83 RID: 6787
		Serializable = 8192,
		// Token: 0x04001A84 RID: 6788
		WindowsRuntime = 16384,
		// Token: 0x04001A85 RID: 6789
		StringFormatMask = 196608,
		// Token: 0x04001A86 RID: 6790
		AnsiClass = 0,
		// Token: 0x04001A87 RID: 6791
		UnicodeClass = 65536,
		// Token: 0x04001A88 RID: 6792
		AutoClass = 131072,
		// Token: 0x04001A89 RID: 6793
		CustomFormatClass = 196608,
		// Token: 0x04001A8A RID: 6794
		CustomFormatMask = 12582912,
		// Token: 0x04001A8B RID: 6795
		BeforeFieldInit = 1048576,
		// Token: 0x04001A8C RID: 6796
		ReservedMask = 264192,
		// Token: 0x04001A8D RID: 6797
		RTSpecialName = 2048,
		// Token: 0x04001A8E RID: 6798
		HasSecurity = 262144
	}
}
