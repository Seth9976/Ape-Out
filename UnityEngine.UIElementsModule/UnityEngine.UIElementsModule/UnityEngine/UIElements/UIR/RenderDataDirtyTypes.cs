using System;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000154 RID: 340
	public enum RenderDataDirtyTypes
	{
		// Token: 0x04000153 RID: 339
		None,
		// Token: 0x04000154 RID: 340
		Transform,
		// Token: 0x04000155 RID: 341
		ClipRectSize,
		// Token: 0x04000156 RID: 342
		Clipping = 4,
		// Token: 0x04000157 RID: 343
		ClippingHierarchy = 8,
		// Token: 0x04000158 RID: 344
		Visuals = 16,
		// Token: 0x04000159 RID: 345
		VisualsHierarchy = 32,
		// Token: 0x0400015A RID: 346
		Opacity = 64,
		// Token: 0x0400015B RID: 347
		OpacityHierarchy = 128
	}
}
