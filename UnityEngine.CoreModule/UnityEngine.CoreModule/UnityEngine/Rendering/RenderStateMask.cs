using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020002BD RID: 701
	public enum RenderStateMask
	{
		// Token: 0x04001DBF RID: 7615
		Nothing,
		// Token: 0x04001DC0 RID: 7616
		Blend,
		// Token: 0x04001DC1 RID: 7617
		Raster,
		// Token: 0x04001DC2 RID: 7618
		Depth = 4,
		// Token: 0x04001DC3 RID: 7619
		Stencil = 8,
		// Token: 0x04001DC4 RID: 7620
		Everything = 15
	}
}
