using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000152 RID: 338
	[Flags]
	public enum MeshUpdateFlags
	{
		// Token: 0x040013AF RID: 5039
		Default = 0,
		// Token: 0x040013B0 RID: 5040
		DontValidateIndices = 1,
		// Token: 0x040013B1 RID: 5041
		DontResetBoneBounds = 2,
		// Token: 0x040013B2 RID: 5042
		DontNotifyMeshUsers = 4,
		// Token: 0x040013B3 RID: 5043
		DontRecalculateBounds = 8
	}
}
