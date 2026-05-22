using System;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000006 RID: 6
	[Flags]
	public enum TileFlags
	{
		// Token: 0x04000053 RID: 83
		None = 0,
		// Token: 0x04000054 RID: 84
		LockColor = 1,
		// Token: 0x04000055 RID: 85
		LockTransform = 2,
		// Token: 0x04000056 RID: 86
		InstantiateGameObjectRuntimeOnly = 4,
		// Token: 0x04000057 RID: 87
		LockAll = 3
	}
}
