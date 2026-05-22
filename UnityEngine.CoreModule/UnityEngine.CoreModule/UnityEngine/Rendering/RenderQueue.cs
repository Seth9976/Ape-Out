using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000298 RID: 664
	public enum RenderQueue
	{
		// Token: 0x04001CAF RID: 7343
		Background = 1000,
		// Token: 0x04001CB0 RID: 7344
		Geometry = 2000,
		// Token: 0x04001CB1 RID: 7345
		AlphaTest = 2450,
		// Token: 0x04001CB2 RID: 7346
		GeometryLast = 2500,
		// Token: 0x04001CB3 RID: 7347
		Transparent = 3000,
		// Token: 0x04001CB4 RID: 7348
		Overlay = 4000
	}
}
