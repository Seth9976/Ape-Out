using System;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public enum TerrainChangedFlags
	{
		// Token: 0x040000B6 RID: 182
		Heightmap = 1,
		// Token: 0x040000B7 RID: 183
		TreeInstances,
		// Token: 0x040000B8 RID: 184
		DelayedHeightmapUpdate = 4,
		// Token: 0x040000B9 RID: 185
		FlushEverythingImmediately = 8,
		// Token: 0x040000BA RID: 186
		RemoveDirtyDetailsImmediately = 16,
		// Token: 0x040000BB RID: 187
		HeightmapResolution = 32,
		// Token: 0x040000BC RID: 188
		Holes = 64,
		// Token: 0x040000BD RID: 189
		DelayedHolesUpdate = 128,
		// Token: 0x040000BE RID: 190
		WillBeDestroyed = 256
	}
}
