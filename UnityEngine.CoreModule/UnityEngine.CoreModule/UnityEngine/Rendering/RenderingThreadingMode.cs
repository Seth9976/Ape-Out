using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020002B1 RID: 689
	public enum RenderingThreadingMode
	{
		// Token: 0x04001D7A RID: 7546
		Direct,
		// Token: 0x04001D7B RID: 7547
		SingleThreaded,
		// Token: 0x04001D7C RID: 7548
		MultiThreaded,
		// Token: 0x04001D7D RID: 7549
		LegacyJobified,
		// Token: 0x04001D7E RID: 7550
		NativeGraphicsJobs,
		// Token: 0x04001D7F RID: 7551
		NativeGraphicsJobsWithoutRenderThread
	}
}
