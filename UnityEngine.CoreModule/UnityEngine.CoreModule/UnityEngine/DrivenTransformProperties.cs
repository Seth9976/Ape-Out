using System;

namespace UnityEngine
{
	// Token: 0x02000102 RID: 258
	[Flags]
	public enum DrivenTransformProperties
	{
		// Token: 0x040010FA RID: 4346
		None = 0,
		// Token: 0x040010FB RID: 4347
		All = -1,
		// Token: 0x040010FC RID: 4348
		AnchoredPositionX = 2,
		// Token: 0x040010FD RID: 4349
		AnchoredPositionY = 4,
		// Token: 0x040010FE RID: 4350
		AnchoredPositionZ = 8,
		// Token: 0x040010FF RID: 4351
		Rotation = 16,
		// Token: 0x04001100 RID: 4352
		ScaleX = 32,
		// Token: 0x04001101 RID: 4353
		ScaleY = 64,
		// Token: 0x04001102 RID: 4354
		ScaleZ = 128,
		// Token: 0x04001103 RID: 4355
		AnchorMinX = 256,
		// Token: 0x04001104 RID: 4356
		AnchorMinY = 512,
		// Token: 0x04001105 RID: 4357
		AnchorMaxX = 1024,
		// Token: 0x04001106 RID: 4358
		AnchorMaxY = 2048,
		// Token: 0x04001107 RID: 4359
		SizeDeltaX = 4096,
		// Token: 0x04001108 RID: 4360
		SizeDeltaY = 8192,
		// Token: 0x04001109 RID: 4361
		PivotX = 16384,
		// Token: 0x0400110A RID: 4362
		PivotY = 32768,
		// Token: 0x0400110B RID: 4363
		AnchoredPosition = 6,
		// Token: 0x0400110C RID: 4364
		AnchoredPosition3D = 14,
		// Token: 0x0400110D RID: 4365
		Scale = 224,
		// Token: 0x0400110E RID: 4366
		AnchorMin = 768,
		// Token: 0x0400110F RID: 4367
		AnchorMax = 3072,
		// Token: 0x04001110 RID: 4368
		Anchors = 3840,
		// Token: 0x04001111 RID: 4369
		SizeDelta = 12288,
		// Token: 0x04001112 RID: 4370
		Pivot = 49152
	}
}
