using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CC RID: 204
	public enum PropagationPhase
	{
		// Token: 0x040000CB RID: 203
		None,
		// Token: 0x040000CC RID: 204
		TrickleDown,
		// Token: 0x040000CD RID: 205
		AtTarget,
		// Token: 0x040000CE RID: 206
		DefaultActionAtTarget = 5,
		// Token: 0x040000CF RID: 207
		BubbleUp = 3,
		// Token: 0x040000D0 RID: 208
		DefaultAction
	}
}
