using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020002BB RID: 699
	public enum PerObjectData
	{
		// Token: 0x04001DAD RID: 7597
		None,
		// Token: 0x04001DAE RID: 7598
		LightProbe,
		// Token: 0x04001DAF RID: 7599
		ReflectionProbes,
		// Token: 0x04001DB0 RID: 7600
		LightProbeProxyVolume = 4,
		// Token: 0x04001DB1 RID: 7601
		Lightmaps = 8,
		// Token: 0x04001DB2 RID: 7602
		LightData = 16,
		// Token: 0x04001DB3 RID: 7603
		MotionVectors = 32,
		// Token: 0x04001DB4 RID: 7604
		LightIndices = 64,
		// Token: 0x04001DB5 RID: 7605
		ReflectionProbeData = 128,
		// Token: 0x04001DB6 RID: 7606
		OcclusionProbe = 256,
		// Token: 0x04001DB7 RID: 7607
		OcclusionProbeProxyVolume = 512,
		// Token: 0x04001DB8 RID: 7608
		ShadowMask = 1024
	}
}
