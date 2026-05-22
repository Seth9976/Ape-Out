using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000161 RID: 353
	[Flags]
	public enum RenderTargetFlags
	{
		// Token: 0x04001477 RID: 5239
		None = 0,
		// Token: 0x04001478 RID: 5240
		ReadOnlyDepth = 1,
		// Token: 0x04001479 RID: 5241
		ReadOnlyStencil = 2,
		// Token: 0x0400147A RID: 5242
		ReadOnlyDepthStencil = 3
	}
}
