using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000167 RID: 359
	[Flags]
	public enum CopyTextureSupport
	{
		// Token: 0x0400149B RID: 5275
		None = 0,
		// Token: 0x0400149C RID: 5276
		Basic = 1,
		// Token: 0x0400149D RID: 5277
		Copy3D = 2,
		// Token: 0x0400149E RID: 5278
		DifferentTypes = 4,
		// Token: 0x0400149F RID: 5279
		TextureToRT = 8,
		// Token: 0x040014A0 RID: 5280
		RTToTexture = 16
	}
}
