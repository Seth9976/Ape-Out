using System;

namespace Unity.Profiling.LowLevel
{
	// Token: 0x0200000B RID: 11
	[Flags]
	public enum MarkerFlags : ushort
	{
		// Token: 0x04000019 RID: 25
		Default = 0,
		// Token: 0x0400001A RID: 26
		Script = 2,
		// Token: 0x0400001B RID: 27
		ScriptInvoke = 32,
		// Token: 0x0400001C RID: 28
		ScriptDeepProfiler = 64,
		// Token: 0x0400001D RID: 29
		AvailabilityEditor = 4,
		// Token: 0x0400001E RID: 30
		Warning = 16,
		// Token: 0x0400001F RID: 31
		Counter = 128
	}
}
