using System;

namespace UnityEngine.VFX
{
	// Token: 0x0200000F RID: 15
	public enum VFXExpressionOperation
	{
		// Token: 0x040000B7 RID: 183
		None,
		// Token: 0x040000B8 RID: 184
		Value,
		// Token: 0x040000B9 RID: 185
		Combine2f,
		// Token: 0x040000BA RID: 186
		Combine3f,
		// Token: 0x040000BB RID: 187
		Combine4f,
		// Token: 0x040000BC RID: 188
		ExtractComponent,
		// Token: 0x040000BD RID: 189
		DeltaTime,
		// Token: 0x040000BE RID: 190
		TotalTime,
		// Token: 0x040000BF RID: 191
		SystemSeed,
		// Token: 0x040000C0 RID: 192
		LocalToWorld,
		// Token: 0x040000C1 RID: 193
		WorldToLocal,
		// Token: 0x040000C2 RID: 194
		FrameIndex,
		// Token: 0x040000C3 RID: 195
		PlayRate,
		// Token: 0x040000C4 RID: 196
		UnscaledDeltaTime,
		// Token: 0x040000C5 RID: 197
		ManagerMaxDeltaTime,
		// Token: 0x040000C6 RID: 198
		ManagerFixedTimeStep,
		// Token: 0x040000C7 RID: 199
		GameDeltaTime,
		// Token: 0x040000C8 RID: 200
		GameUnscaledDeltaTime,
		// Token: 0x040000C9 RID: 201
		GameSmoothDeltaTime,
		// Token: 0x040000CA RID: 202
		GameTotalTime,
		// Token: 0x040000CB RID: 203
		GameUnscaledTotalTime,
		// Token: 0x040000CC RID: 204
		GameTotalTimeSinceSceneLoad,
		// Token: 0x040000CD RID: 205
		GameTimeScale,
		// Token: 0x040000CE RID: 206
		Sin,
		// Token: 0x040000CF RID: 207
		Cos,
		// Token: 0x040000D0 RID: 208
		Tan,
		// Token: 0x040000D1 RID: 209
		ASin,
		// Token: 0x040000D2 RID: 210
		ACos,
		// Token: 0x040000D3 RID: 211
		ATan,
		// Token: 0x040000D4 RID: 212
		Abs,
		// Token: 0x040000D5 RID: 213
		Sign,
		// Token: 0x040000D6 RID: 214
		Saturate,
		// Token: 0x040000D7 RID: 215
		Ceil,
		// Token: 0x040000D8 RID: 216
		Round,
		// Token: 0x040000D9 RID: 217
		Frac,
		// Token: 0x040000DA RID: 218
		Floor,
		// Token: 0x040000DB RID: 219
		Log2,
		// Token: 0x040000DC RID: 220
		Mul,
		// Token: 0x040000DD RID: 221
		Divide,
		// Token: 0x040000DE RID: 222
		Add,
		// Token: 0x040000DF RID: 223
		Subtract,
		// Token: 0x040000E0 RID: 224
		Min,
		// Token: 0x040000E1 RID: 225
		Max,
		// Token: 0x040000E2 RID: 226
		Pow,
		// Token: 0x040000E3 RID: 227
		ATan2,
		// Token: 0x040000E4 RID: 228
		TRSToMatrix,
		// Token: 0x040000E5 RID: 229
		InverseMatrix,
		// Token: 0x040000E6 RID: 230
		InverseTRSMatrix,
		// Token: 0x040000E7 RID: 231
		TransposeMatrix,
		// Token: 0x040000E8 RID: 232
		ExtractPositionFromMatrix,
		// Token: 0x040000E9 RID: 233
		ExtractAnglesFromMatrix,
		// Token: 0x040000EA RID: 234
		ExtractScaleFromMatrix,
		// Token: 0x040000EB RID: 235
		TransformMatrix,
		// Token: 0x040000EC RID: 236
		TransformPos,
		// Token: 0x040000ED RID: 237
		TransformVec,
		// Token: 0x040000EE RID: 238
		TransformDir,
		// Token: 0x040000EF RID: 239
		TransformVector4,
		// Token: 0x040000F0 RID: 240
		Vector3sToMatrix,
		// Token: 0x040000F1 RID: 241
		Vector4sToMatrix,
		// Token: 0x040000F2 RID: 242
		MatrixToVector3s,
		// Token: 0x040000F3 RID: 243
		MatrixToVector4s,
		// Token: 0x040000F4 RID: 244
		SampleCurve,
		// Token: 0x040000F5 RID: 245
		SampleGradient,
		// Token: 0x040000F6 RID: 246
		SampleMeshFloat,
		// Token: 0x040000F7 RID: 247
		SampleMeshFloat2,
		// Token: 0x040000F8 RID: 248
		SampleMeshFloat3,
		// Token: 0x040000F9 RID: 249
		SampleMeshFloat4,
		// Token: 0x040000FA RID: 250
		SampleMeshColor,
		// Token: 0x040000FB RID: 251
		BakeCurve,
		// Token: 0x040000FC RID: 252
		BakeGradient,
		// Token: 0x040000FD RID: 253
		BitwiseLeftShift,
		// Token: 0x040000FE RID: 254
		BitwiseRightShift,
		// Token: 0x040000FF RID: 255
		BitwiseOr,
		// Token: 0x04000100 RID: 256
		BitwiseAnd,
		// Token: 0x04000101 RID: 257
		BitwiseXor,
		// Token: 0x04000102 RID: 258
		BitwiseComplement,
		// Token: 0x04000103 RID: 259
		CastUintToFloat,
		// Token: 0x04000104 RID: 260
		CastIntToFloat,
		// Token: 0x04000105 RID: 261
		CastFloatToUint,
		// Token: 0x04000106 RID: 262
		CastIntToUint,
		// Token: 0x04000107 RID: 263
		CastFloatToInt,
		// Token: 0x04000108 RID: 264
		CastUintToInt,
		// Token: 0x04000109 RID: 265
		RGBtoHSV,
		// Token: 0x0400010A RID: 266
		HSVtoRGB,
		// Token: 0x0400010B RID: 267
		Condition,
		// Token: 0x0400010C RID: 268
		Branch,
		// Token: 0x0400010D RID: 269
		GenerateRandom,
		// Token: 0x0400010E RID: 270
		GenerateFixedRandom,
		// Token: 0x0400010F RID: 271
		ExtractMatrixFromMainCamera,
		// Token: 0x04000110 RID: 272
		ExtractFOVFromMainCamera,
		// Token: 0x04000111 RID: 273
		ExtractNearPlaneFromMainCamera,
		// Token: 0x04000112 RID: 274
		ExtractFarPlaneFromMainCamera,
		// Token: 0x04000113 RID: 275
		ExtractAspectRatioFromMainCamera,
		// Token: 0x04000114 RID: 276
		ExtractPixelDimensionsFromMainCamera,
		// Token: 0x04000115 RID: 277
		GetBufferFromMainCamera,
		// Token: 0x04000116 RID: 278
		LogicalAnd,
		// Token: 0x04000117 RID: 279
		LogicalOr,
		// Token: 0x04000118 RID: 280
		LogicalNot,
		// Token: 0x04000119 RID: 281
		ValueNoise1D,
		// Token: 0x0400011A RID: 282
		ValueNoise2D,
		// Token: 0x0400011B RID: 283
		ValueNoise3D,
		// Token: 0x0400011C RID: 284
		ValueCurlNoise2D,
		// Token: 0x0400011D RID: 285
		ValueCurlNoise3D,
		// Token: 0x0400011E RID: 286
		PerlinNoise1D,
		// Token: 0x0400011F RID: 287
		PerlinNoise2D,
		// Token: 0x04000120 RID: 288
		PerlinNoise3D,
		// Token: 0x04000121 RID: 289
		PerlinCurlNoise2D,
		// Token: 0x04000122 RID: 290
		PerlinCurlNoise3D,
		// Token: 0x04000123 RID: 291
		CellularNoise1D,
		// Token: 0x04000124 RID: 292
		CellularNoise2D,
		// Token: 0x04000125 RID: 293
		CellularNoise3D,
		// Token: 0x04000126 RID: 294
		CellularCurlNoise2D,
		// Token: 0x04000127 RID: 295
		CellularCurlNoise3D,
		// Token: 0x04000128 RID: 296
		VoroNoise2D,
		// Token: 0x04000129 RID: 297
		MeshVertexCount,
		// Token: 0x0400012A RID: 298
		MeshChannelOffset,
		// Token: 0x0400012B RID: 299
		MeshVertexStride,
		// Token: 0x0400012C RID: 300
		BufferCount,
		// Token: 0x0400012D RID: 301
		TextureWidth,
		// Token: 0x0400012E RID: 302
		TextureHeight,
		// Token: 0x0400012F RID: 303
		TextureDepth,
		// Token: 0x04000130 RID: 304
		ReadEventAttribute,
		// Token: 0x04000131 RID: 305
		SpawnerStateNewLoop,
		// Token: 0x04000132 RID: 306
		SpawnerStateLoopState,
		// Token: 0x04000133 RID: 307
		SpawnerStateSpawnCount,
		// Token: 0x04000134 RID: 308
		SpawnerStateDeltaTime,
		// Token: 0x04000135 RID: 309
		SpawnerStateTotalTime,
		// Token: 0x04000136 RID: 310
		SpawnerStateDelayBeforeLoop,
		// Token: 0x04000137 RID: 311
		SpawnerStateLoopDuration,
		// Token: 0x04000138 RID: 312
		SpawnerStateDelayAfterLoop,
		// Token: 0x04000139 RID: 313
		SpawnerStateLoopIndex,
		// Token: 0x0400013A RID: 314
		SpawnerStateLoopCount
	}
}
