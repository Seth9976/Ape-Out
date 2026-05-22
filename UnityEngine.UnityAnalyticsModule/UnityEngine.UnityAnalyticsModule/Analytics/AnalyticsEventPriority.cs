using System;

namespace UnityEngine.Analytics
{
	// Token: 0x0200000B RID: 11
	public enum AnalyticsEventPriority
	{
		// Token: 0x0400007F RID: 127
		FlushQueueFlag = 1,
		// Token: 0x04000080 RID: 128
		CacheImmediatelyFlag,
		// Token: 0x04000081 RID: 129
		AllowInStopModeFlag = 4,
		// Token: 0x04000082 RID: 130
		SendImmediateFlag = 8,
		// Token: 0x04000083 RID: 131
		NoCachingFlag = 16,
		// Token: 0x04000084 RID: 132
		NoRetryFlag = 32,
		// Token: 0x04000085 RID: 133
		NormalPriorityEvent = 0,
		// Token: 0x04000086 RID: 134
		NormalPriorityEvent_WithCaching = 2,
		// Token: 0x04000087 RID: 135
		NormalPriorityEvent_NoRetryNoCaching = 48,
		// Token: 0x04000088 RID: 136
		HighPriorityEvent = 1,
		// Token: 0x04000089 RID: 137
		HighPriorityEvent_InStopMode = 5,
		// Token: 0x0400008A RID: 138
		HighestPriorityEvent = 9,
		// Token: 0x0400008B RID: 139
		HighestPriorityEvent_NoRetryNoCaching = 49
	}
}
