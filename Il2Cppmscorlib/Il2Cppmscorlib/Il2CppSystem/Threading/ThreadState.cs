using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200028C RID: 652
	[OriginalName("mscorlib.dll", "System.Threading", "ThreadState")]
	[Flags]
	[Serializable]
	public enum ThreadState
	{
		// Token: 0x040026F8 RID: 9976
		Running = 0,
		// Token: 0x040026F9 RID: 9977
		StopRequested = 1,
		// Token: 0x040026FA RID: 9978
		SuspendRequested = 2,
		// Token: 0x040026FB RID: 9979
		Background = 4,
		// Token: 0x040026FC RID: 9980
		Unstarted = 8,
		// Token: 0x040026FD RID: 9981
		Stopped = 16,
		// Token: 0x040026FE RID: 9982
		WaitSleepJoin = 32,
		// Token: 0x040026FF RID: 9983
		Suspended = 64,
		// Token: 0x04002700 RID: 9984
		AbortRequested = 128,
		// Token: 0x04002701 RID: 9985
		Aborted = 256
	}
}
