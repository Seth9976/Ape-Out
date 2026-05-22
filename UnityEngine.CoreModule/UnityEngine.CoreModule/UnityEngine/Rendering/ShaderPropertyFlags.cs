using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000179 RID: 377
	[Flags]
	public enum ShaderPropertyFlags
	{
		// Token: 0x04001643 RID: 5699
		None = 0,
		// Token: 0x04001644 RID: 5700
		HideInInspector = 1,
		// Token: 0x04001645 RID: 5701
		PerRendererData = 2,
		// Token: 0x04001646 RID: 5702
		NoScaleOffset = 4,
		// Token: 0x04001647 RID: 5703
		Normal = 8,
		// Token: 0x04001648 RID: 5704
		HDR = 16,
		// Token: 0x04001649 RID: 5705
		Gamma = 32,
		// Token: 0x0400164A RID: 5706
		NonModifiableTextureData = 64,
		// Token: 0x0400164B RID: 5707
		MainTexture = 128,
		// Token: 0x0400164C RID: 5708
		MainColor = 256
	}
}
