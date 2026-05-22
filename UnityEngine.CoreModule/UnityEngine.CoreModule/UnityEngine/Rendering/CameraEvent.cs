using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200015A RID: 346
	public enum CameraEvent
	{
		// Token: 0x040013F3 RID: 5107
		BeforeDepthTexture,
		// Token: 0x040013F4 RID: 5108
		AfterDepthTexture,
		// Token: 0x040013F5 RID: 5109
		BeforeDepthNormalsTexture,
		// Token: 0x040013F6 RID: 5110
		AfterDepthNormalsTexture,
		// Token: 0x040013F7 RID: 5111
		BeforeGBuffer,
		// Token: 0x040013F8 RID: 5112
		AfterGBuffer,
		// Token: 0x040013F9 RID: 5113
		BeforeLighting,
		// Token: 0x040013FA RID: 5114
		AfterLighting,
		// Token: 0x040013FB RID: 5115
		BeforeFinalPass,
		// Token: 0x040013FC RID: 5116
		AfterFinalPass,
		// Token: 0x040013FD RID: 5117
		BeforeForwardOpaque,
		// Token: 0x040013FE RID: 5118
		AfterForwardOpaque,
		// Token: 0x040013FF RID: 5119
		BeforeImageEffectsOpaque,
		// Token: 0x04001400 RID: 5120
		AfterImageEffectsOpaque,
		// Token: 0x04001401 RID: 5121
		BeforeSkybox,
		// Token: 0x04001402 RID: 5122
		AfterSkybox,
		// Token: 0x04001403 RID: 5123
		BeforeForwardAlpha,
		// Token: 0x04001404 RID: 5124
		AfterForwardAlpha,
		// Token: 0x04001405 RID: 5125
		BeforeImageEffects,
		// Token: 0x04001406 RID: 5126
		AfterImageEffects,
		// Token: 0x04001407 RID: 5127
		AfterEverything,
		// Token: 0x04001408 RID: 5128
		BeforeReflections,
		// Token: 0x04001409 RID: 5129
		AfterReflections,
		// Token: 0x0400140A RID: 5130
		BeforeHaloAndLensFlares,
		// Token: 0x0400140B RID: 5131
		AfterHaloAndLensFlares
	}
}
