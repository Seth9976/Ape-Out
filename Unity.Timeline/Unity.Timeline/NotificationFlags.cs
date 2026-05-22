using System;

namespace UnityEngine.Timeline
{
	// Token: 0x02000034 RID: 52
	[Flags]
	[Serializable]
	public enum NotificationFlags : short
	{
		// Token: 0x04000355 RID: 853
		TriggerInEditMode = 1,
		// Token: 0x04000356 RID: 854
		Retroactive = 2,
		// Token: 0x04000357 RID: 855
		TriggerOnce = 4
	}
}
