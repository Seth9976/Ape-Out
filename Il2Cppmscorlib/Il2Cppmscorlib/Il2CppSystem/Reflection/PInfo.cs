using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001E1 RID: 481
	[OriginalName("mscorlib.dll", "System.Reflection", "PInfo")]
	[Flags]
	public enum PInfo
	{
		// Token: 0x04001C55 RID: 7253
		Attributes = 1,
		// Token: 0x04001C56 RID: 7254
		GetMethod = 2,
		// Token: 0x04001C57 RID: 7255
		SetMethod = 4,
		// Token: 0x04001C58 RID: 7256
		ReflectedType = 8,
		// Token: 0x04001C59 RID: 7257
		DeclaringType = 16,
		// Token: 0x04001C5A RID: 7258
		Name = 32
	}
}
