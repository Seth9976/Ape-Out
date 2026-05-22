using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020002B8 RID: 696
	public enum CullingOptions
	{
		// Token: 0x04001D9D RID: 7581
		None,
		// Token: 0x04001D9E RID: 7582
		ForceEvenIfCameraIsNotActive,
		// Token: 0x04001D9F RID: 7583
		OcclusionCull,
		// Token: 0x04001DA0 RID: 7584
		NeedsLighting = 4,
		// Token: 0x04001DA1 RID: 7585
		NeedsReflectionProbes = 8,
		// Token: 0x04001DA2 RID: 7586
		Stereo = 16,
		// Token: 0x04001DA3 RID: 7587
		DisablePerObjectCulling = 32,
		// Token: 0x04001DA4 RID: 7588
		ShadowCasters = 64
	}
}
