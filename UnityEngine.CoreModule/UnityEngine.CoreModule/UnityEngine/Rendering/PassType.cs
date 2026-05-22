using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020002A2 RID: 674
	public enum PassType
	{
		// Token: 0x04001D11 RID: 7441
		Normal,
		// Token: 0x04001D12 RID: 7442
		Vertex,
		// Token: 0x04001D13 RID: 7443
		VertexLM,
		// Token: 0x04001D14 RID: 7444
		VertexLMRGBM,
		// Token: 0x04001D15 RID: 7445
		ForwardBase,
		// Token: 0x04001D16 RID: 7446
		ForwardAdd,
		// Token: 0x04001D17 RID: 7447
		LightPrePassBase,
		// Token: 0x04001D18 RID: 7448
		LightPrePassFinal,
		// Token: 0x04001D19 RID: 7449
		ShadowCaster,
		// Token: 0x04001D1A RID: 7450
		Deferred = 10,
		// Token: 0x04001D1B RID: 7451
		Meta,
		// Token: 0x04001D1C RID: 7452
		MotionVectors,
		// Token: 0x04001D1D RID: 7453
		ScriptableRenderPipeline,
		// Token: 0x04001D1E RID: 7454
		ScriptableRenderPipelineDefaultUnlit
	}
}
