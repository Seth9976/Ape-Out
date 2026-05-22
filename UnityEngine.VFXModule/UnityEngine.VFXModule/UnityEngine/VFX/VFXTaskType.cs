using System;

namespace UnityEngine.VFX
{
	// Token: 0x02000011 RID: 17
	public enum VFXTaskType
	{
		// Token: 0x04000150 RID: 336
		None,
		// Token: 0x04000151 RID: 337
		Spawner = 268435456,
		// Token: 0x04000152 RID: 338
		Initialize = 536870912,
		// Token: 0x04000153 RID: 339
		Update = 805306368,
		// Token: 0x04000154 RID: 340
		Output = 1073741824,
		// Token: 0x04000155 RID: 341
		CameraSort = 805306369,
		// Token: 0x04000156 RID: 342
		PerCameraUpdate,
		// Token: 0x04000157 RID: 343
		PerCameraSort,
		// Token: 0x04000158 RID: 344
		ParticlePointOutput = 1073741824,
		// Token: 0x04000159 RID: 345
		ParticleLineOutput,
		// Token: 0x0400015A RID: 346
		ParticleQuadOutput,
		// Token: 0x0400015B RID: 347
		ParticleHexahedronOutput,
		// Token: 0x0400015C RID: 348
		ParticleMeshOutput,
		// Token: 0x0400015D RID: 349
		ParticleTriangleOutput,
		// Token: 0x0400015E RID: 350
		ParticleOctagonOutput,
		// Token: 0x0400015F RID: 351
		ConstantRateSpawner = 268435456,
		// Token: 0x04000160 RID: 352
		BurstSpawner,
		// Token: 0x04000161 RID: 353
		PeriodicBurstSpawner,
		// Token: 0x04000162 RID: 354
		VariableRateSpawner,
		// Token: 0x04000163 RID: 355
		CustomCallbackSpawner,
		// Token: 0x04000164 RID: 356
		SetAttributeSpawner,
		// Token: 0x04000165 RID: 357
		EvaluateExpressionsSpawner
	}
}
