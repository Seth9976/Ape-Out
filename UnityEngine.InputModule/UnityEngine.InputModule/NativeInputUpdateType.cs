using System;

namespace UnityEngineInternal.Input
{
	// Token: 0x02000004 RID: 4
	[Flags]
	public enum NativeInputUpdateType
	{
		// Token: 0x0400000F RID: 15
		Dynamic = 1,
		// Token: 0x04000010 RID: 16
		Fixed = 2,
		// Token: 0x04000011 RID: 17
		BeforeRender = 4,
		// Token: 0x04000012 RID: 18
		Editor = 8,
		// Token: 0x04000013 RID: 19
		IgnoreFocus = -2147483648
	}
}
