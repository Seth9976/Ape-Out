using System;

namespace UnityEngine.Profiling.Memory.Experimental
{
	// Token: 0x02000278 RID: 632
	public enum CaptureFlags : uint
	{
		// Token: 0x04001C7C RID: 7292
		ManagedObjects = 1U,
		// Token: 0x04001C7D RID: 7293
		NativeObjects,
		// Token: 0x04001C7E RID: 7294
		NativeAllocations = 4U,
		// Token: 0x04001C7F RID: 7295
		NativeAllocationSites = 8U,
		// Token: 0x04001C80 RID: 7296
		NativeStackTraces = 16U
	}
}
