using System;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public enum CollisionFlags
	{
		// Token: 0x0400001C RID: 28
		None,
		// Token: 0x0400001D RID: 29
		Sides,
		// Token: 0x0400001E RID: 30
		Above,
		// Token: 0x0400001F RID: 31
		Below = 4,
		// Token: 0x04000020 RID: 32
		CollidedSides = 1,
		// Token: 0x04000021 RID: 33
		CollidedAbove,
		// Token: 0x04000022 RID: 34
		CollidedBelow = 4
	}
}
