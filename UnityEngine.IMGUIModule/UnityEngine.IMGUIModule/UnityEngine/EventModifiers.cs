using System;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[Flags]
	public enum EventModifiers
	{
		// Token: 0x04000062 RID: 98
		None = 0,
		// Token: 0x04000063 RID: 99
		Shift = 1,
		// Token: 0x04000064 RID: 100
		Control = 2,
		// Token: 0x04000065 RID: 101
		Alt = 4,
		// Token: 0x04000066 RID: 102
		Command = 8,
		// Token: 0x04000067 RID: 103
		Numeric = 16,
		// Token: 0x04000068 RID: 104
		CapsLock = 32,
		// Token: 0x04000069 RID: 105
		FunctionKey = 64
	}
}
