using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001B1 RID: 433
	[OriginalName("mscorlib.dll", "System.Reflection", "MethodAttributes")]
	[Flags]
	[Serializable]
	public enum MethodAttributes
	{
		// Token: 0x040019E2 RID: 6626
		MemberAccessMask = 7,
		// Token: 0x040019E3 RID: 6627
		PrivateScope = 0,
		// Token: 0x040019E4 RID: 6628
		Private = 1,
		// Token: 0x040019E5 RID: 6629
		FamANDAssem = 2,
		// Token: 0x040019E6 RID: 6630
		Assembly = 3,
		// Token: 0x040019E7 RID: 6631
		Family = 4,
		// Token: 0x040019E8 RID: 6632
		FamORAssem = 5,
		// Token: 0x040019E9 RID: 6633
		Public = 6,
		// Token: 0x040019EA RID: 6634
		Static = 16,
		// Token: 0x040019EB RID: 6635
		Final = 32,
		// Token: 0x040019EC RID: 6636
		Virtual = 64,
		// Token: 0x040019ED RID: 6637
		HideBySig = 128,
		// Token: 0x040019EE RID: 6638
		CheckAccessOnOverride = 512,
		// Token: 0x040019EF RID: 6639
		VtableLayoutMask = 256,
		// Token: 0x040019F0 RID: 6640
		ReuseSlot = 0,
		// Token: 0x040019F1 RID: 6641
		NewSlot = 256,
		// Token: 0x040019F2 RID: 6642
		Abstract = 1024,
		// Token: 0x040019F3 RID: 6643
		SpecialName = 2048,
		// Token: 0x040019F4 RID: 6644
		PinvokeImpl = 8192,
		// Token: 0x040019F5 RID: 6645
		UnmanagedExport = 8,
		// Token: 0x040019F6 RID: 6646
		RTSpecialName = 4096,
		// Token: 0x040019F7 RID: 6647
		ReservedMask = 53248,
		// Token: 0x040019F8 RID: 6648
		HasSecurity = 16384,
		// Token: 0x040019F9 RID: 6649
		RequireSecObject = 32768
	}
}
