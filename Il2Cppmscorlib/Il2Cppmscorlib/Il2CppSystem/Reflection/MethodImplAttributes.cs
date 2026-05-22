using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001B4 RID: 436
	[OriginalName("mscorlib.dll", "System.Reflection", "MethodImplAttributes")]
	[Serializable]
	public enum MethodImplAttributes
	{
		// Token: 0x04001A24 RID: 6692
		CodeTypeMask = 3,
		// Token: 0x04001A25 RID: 6693
		IL = 0,
		// Token: 0x04001A26 RID: 6694
		Native,
		// Token: 0x04001A27 RID: 6695
		OPTIL,
		// Token: 0x04001A28 RID: 6696
		Runtime,
		// Token: 0x04001A29 RID: 6697
		ManagedMask,
		// Token: 0x04001A2A RID: 6698
		Unmanaged = 4,
		// Token: 0x04001A2B RID: 6699
		Managed = 0,
		// Token: 0x04001A2C RID: 6700
		ForwardRef = 16,
		// Token: 0x04001A2D RID: 6701
		PreserveSig = 128,
		// Token: 0x04001A2E RID: 6702
		InternalCall = 4096,
		// Token: 0x04001A2F RID: 6703
		Synchronized = 32,
		// Token: 0x04001A30 RID: 6704
		NoInlining = 8,
		// Token: 0x04001A31 RID: 6705
		AggressiveInlining = 256,
		// Token: 0x04001A32 RID: 6706
		NoOptimization = 64,
		// Token: 0x04001A33 RID: 6707
		MaxMethodImplVal = 65535
	}
}
