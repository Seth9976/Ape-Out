using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000059 RID: 89
	public enum VisualElementFlags
	{
		// Token: 0x04000077 RID: 119
		WorldTransformDirty = 1,
		// Token: 0x04000078 RID: 120
		WorldTransformInverseDirty,
		// Token: 0x04000079 RID: 121
		WorldClipDirty = 4,
		// Token: 0x0400007A RID: 122
		BoundingBoxDirty = 8,
		// Token: 0x0400007B RID: 123
		WorldBoundingBoxDirty = 16,
		// Token: 0x0400007C RID: 124
		LayoutManual = 32,
		// Token: 0x0400007D RID: 125
		CompositeRoot = 64,
		// Token: 0x0400007E RID: 126
		RequireMeasureFunction = 128,
		// Token: 0x0400007F RID: 127
		EnableViewDataPersistence = 256,
		// Token: 0x04000080 RID: 128
		NeedsAttachToPanelEvent = 1024,
		// Token: 0x04000081 RID: 129
		Init = 31
	}
}
