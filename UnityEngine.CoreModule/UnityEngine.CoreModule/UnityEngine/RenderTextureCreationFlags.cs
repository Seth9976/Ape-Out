using System;

namespace UnityEngine
{
	// Token: 0x02000089 RID: 137
	[Flags]
	public enum RenderTextureCreationFlags
	{
		// Token: 0x0400081F RID: 2079
		MipMap = 1,
		// Token: 0x04000820 RID: 2080
		AutoGenerateMips = 2,
		// Token: 0x04000821 RID: 2081
		SRGB = 4,
		// Token: 0x04000822 RID: 2082
		EyeTexture = 8,
		// Token: 0x04000823 RID: 2083
		EnableRandomWrite = 16,
		// Token: 0x04000824 RID: 2084
		CreatedFromScript = 32,
		// Token: 0x04000825 RID: 2085
		AllowVerticalFlip = 128,
		// Token: 0x04000826 RID: 2086
		NoResolvedColorSurface = 256,
		// Token: 0x04000827 RID: 2087
		DynamicallyScalable = 1024,
		// Token: 0x04000828 RID: 2088
		BindMS = 2048
	}
}
