using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020002A1 RID: 673
	public enum ShadowMapPass
	{
		// Token: 0x04001D02 RID: 7426
		PointlightPositiveX = 1,
		// Token: 0x04001D03 RID: 7427
		PointlightNegativeX,
		// Token: 0x04001D04 RID: 7428
		PointlightPositiveY = 4,
		// Token: 0x04001D05 RID: 7429
		PointlightNegativeY = 8,
		// Token: 0x04001D06 RID: 7430
		PointlightPositiveZ = 16,
		// Token: 0x04001D07 RID: 7431
		PointlightNegativeZ = 32,
		// Token: 0x04001D08 RID: 7432
		DirectionalCascade0 = 64,
		// Token: 0x04001D09 RID: 7433
		DirectionalCascade1 = 128,
		// Token: 0x04001D0A RID: 7434
		DirectionalCascade2 = 256,
		// Token: 0x04001D0B RID: 7435
		DirectionalCascade3 = 512,
		// Token: 0x04001D0C RID: 7436
		Spotlight = 1024,
		// Token: 0x04001D0D RID: 7437
		Pointlight = 63,
		// Token: 0x04001D0E RID: 7438
		Directional = 960,
		// Token: 0x04001D0F RID: 7439
		All = 2047
	}
}
