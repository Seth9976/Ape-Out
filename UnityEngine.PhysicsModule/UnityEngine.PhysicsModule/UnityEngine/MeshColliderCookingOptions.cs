using System;

namespace UnityEngine
{
	// Token: 0x02000018 RID: 24
	public enum MeshColliderCookingOptions
	{
		// Token: 0x04000176 RID: 374
		None,
		// Token: 0x04000177 RID: 375
		InflateConvexMesh,
		// Token: 0x04000178 RID: 376
		CookForFasterSimulation,
		// Token: 0x04000179 RID: 377
		EnableMeshCleaning = 4,
		// Token: 0x0400017A RID: 378
		WeldColocatedVertices = 8,
		// Token: 0x0400017B RID: 379
		UseFastMidphase = 16
	}
}
