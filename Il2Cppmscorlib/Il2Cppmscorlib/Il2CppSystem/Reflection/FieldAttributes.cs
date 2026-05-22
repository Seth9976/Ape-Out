using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A4 RID: 420
	[OriginalName("mscorlib.dll", "System.Reflection", "FieldAttributes")]
	[Flags]
	[Serializable]
	public enum FieldAttributes
	{
		// Token: 0x04001973 RID: 6515
		FieldAccessMask = 7,
		// Token: 0x04001974 RID: 6516
		PrivateScope = 0,
		// Token: 0x04001975 RID: 6517
		Private = 1,
		// Token: 0x04001976 RID: 6518
		FamANDAssem = 2,
		// Token: 0x04001977 RID: 6519
		Assembly = 3,
		// Token: 0x04001978 RID: 6520
		Family = 4,
		// Token: 0x04001979 RID: 6521
		FamORAssem = 5,
		// Token: 0x0400197A RID: 6522
		Public = 6,
		// Token: 0x0400197B RID: 6523
		Static = 16,
		// Token: 0x0400197C RID: 6524
		InitOnly = 32,
		// Token: 0x0400197D RID: 6525
		Literal = 64,
		// Token: 0x0400197E RID: 6526
		NotSerialized = 128,
		// Token: 0x0400197F RID: 6527
		SpecialName = 512,
		// Token: 0x04001980 RID: 6528
		PinvokeImpl = 8192,
		// Token: 0x04001981 RID: 6529
		ReservedMask = 38144,
		// Token: 0x04001982 RID: 6530
		RTSpecialName = 1024,
		// Token: 0x04001983 RID: 6531
		HasFieldMarshal = 4096,
		// Token: 0x04001984 RID: 6532
		HasDefault = 32768,
		// Token: 0x04001985 RID: 6533
		HasFieldRVA = 256
	}
}
