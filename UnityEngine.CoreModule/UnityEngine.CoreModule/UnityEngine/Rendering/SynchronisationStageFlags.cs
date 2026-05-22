using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020002B4 RID: 692
	public enum SynchronisationStageFlags
	{
		// Token: 0x04001D8D RID: 7565
		VertexProcessing = 1,
		// Token: 0x04001D8E RID: 7566
		PixelProcessing,
		// Token: 0x04001D8F RID: 7567
		ComputeProcessing = 4,
		// Token: 0x04001D90 RID: 7568
		AllGPUOperations = 7
	}
}
