using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Experimental.TerrainAPI
{
	// Token: 0x02000014 RID: 20
	public class PaintContext
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00003078 File Offset: 0x00001278
		public Terrain originTerrain
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00003085 File Offset: 0x00001285
		public RectInt pixelRect
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00003092 File Offset: 0x00001292
		public int targetTextureWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000309F File Offset: 0x0000129F
		public int targetTextureHeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600017D RID: 381 RVA: 0x000030AC File Offset: 0x000012AC
		public Vector2 pixelSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000030B9 File Offset: 0x000012B9
		// (set) Token: 0x0600017F RID: 383 RVA: 0x000030C6 File Offset: 0x000012C6
		public RenderTexture sourceRenderTexture
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000180 RID: 384 RVA: 0x000030D3 File Offset: 0x000012D3
		// (set) Token: 0x06000181 RID: 385 RVA: 0x000030E0 File Offset: 0x000012E0
		public RenderTexture destinationRenderTexture
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000030ED File Offset: 0x000012ED
		// (set) Token: 0x06000183 RID: 387 RVA: 0x000030FA File Offset: 0x000012FA
		public RenderTexture oldRenderTexture
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00003107 File Offset: 0x00001307
		public int terrainCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00003114 File Offset: 0x00001314
		public Terrain GetTerrain(int terrainIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00003121 File Offset: 0x00001321
		public RectInt GetClippedPixelRectInTerrainPixels(int terrainIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000312E File Offset: 0x0000132E
		public RectInt GetClippedPixelRectInRenderTexturePixels(int terrainIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0000313B File Offset: 0x0000133B
		public float heightWorldSpaceMin
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00003148 File Offset: 0x00001348
		public float heightWorldSpaceSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00003155 File Offset: 0x00001355
		public static float kNormalizedHeightScale
		{
			get
			{
				return 0.4999771f;
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00005DD8 File Offset: 0x00003FD8
		public static PaintContext CreateFromBounds(Terrain terrain, Rect boundsInTerrainSpace, int inputTextureWidth, int inputTextureHeight, [Optional] int extraBorderPixels, [Optional] bool texelPadding)
		{
			return new PaintContext(terrain, TerrainPaintUtility.CalcPixelRectFromBounds(terrain, boundsInTerrainSpace, inputTextureWidth, inputTextureHeight, extraBorderPixels, texelPadding), inputTextureWidth, inputTextureHeight, texelPadding);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000315C File Offset: 0x0000135C
		public void FindTerrainTilesUnlimited(bool texelPadding)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00005E04 File Offset: 0x00004004
		public void CreateRenderTargets(RenderTextureFormat colorFormat)
		{
			this.sourceRenderTexture = RenderTexture.GetTemporary(this.pixelRect.width, this.pixelRect.height, 0, colorFormat, RenderTextureReadWrite.Linear);
			this.destinationRenderTexture = RenderTexture.GetTemporary(this.pixelRect.width, this.pixelRect.height, 0, colorFormat, RenderTextureReadWrite.Linear);
			this.sourceRenderTexture.wrapMode = TextureWrapMode.Clamp;
			this.sourceRenderTexture.filterMode = FilterMode.Point;
			this.oldRenderTexture = RenderTexture.active;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00005E90 File Offset: 0x00004090
		public void Cleanup([Optional] bool restoreRenderTexture)
		{
			if (restoreRenderTexture)
			{
				RenderTexture.active = this.oldRenderTexture;
			}
			RenderTexture.ReleaseTemporary(this.sourceRenderTexture);
			RenderTexture.ReleaseTemporary(this.destinationRenderTexture);
			this.sourceRenderTexture = null;
			this.destinationRenderTexture = null;
			this.oldRenderTexture = null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00003169 File Offset: 0x00001369
		public void GatherHeightmap()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00003176 File Offset: 0x00001376
		public void ScatterHeightmap(string editorUndoName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00003183 File Offset: 0x00001383
		public void GatherHoles()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00003190 File Offset: 0x00001390
		public void ScatterHoles(string editorUndoName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000319D File Offset: 0x0000139D
		public void GatherNormals()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000031AA File Offset: 0x000013AA
		public PaintContext.SplatmapUserData GetTerrainLayerUserData(PaintContext.ITerrainInfo context, [Optional] TerrainLayer terrainLayer, [Optional] bool addLayerIfDoesntExist)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000031B7 File Offset: 0x000013B7
		public void GatherAlphamap(TerrainLayer inputLayer, [Optional] bool addLayerIfDoesntExist)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000031C4 File Offset: 0x000013C4
		public void ScatterAlphamap(string editorUndoName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000031D1 File Offset: 0x000013D1
		public static void OnTerrainPainted(PaintContext.ITerrainInfo tile, PaintContext.ToolAction action)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000031DE File Offset: 0x000013DE
		public static void ApplyDelayedActions()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020000C9 RID: 201
		public interface ITerrainInfo
		{
		}

		// Token: 0x020000CA RID: 202
		public class TerrainTile
		{
		}

		// Token: 0x020000CB RID: 203
		public class SplatmapUserData
		{
		}

		// Token: 0x020000CC RID: 204
		public enum ToolAction
		{
			// Token: 0x04000120 RID: 288
			None,
			// Token: 0x04000121 RID: 289
			PaintHeightmap,
			// Token: 0x04000122 RID: 290
			PaintTexture,
			// Token: 0x04000123 RID: 291
			PaintHoles = 4,
			// Token: 0x04000124 RID: 292
			AddTerrainLayer = 8
		}

		// Token: 0x020000CD RID: 205
		public sealed class <>c__DisplayClass50_0
		{
		}

		// Token: 0x020000CE RID: 206
		public sealed class <>c__DisplayClass57_0
		{
		}

		// Token: 0x020000CF RID: 207
		[Serializable]
		public sealed class <>c
		{
		}

		// Token: 0x020000D0 RID: 208
		public sealed class <>c__DisplayClass58_0
		{
		}

		// Token: 0x020000D1 RID: 209
		public sealed class <>c__DisplayClass60_0
		{
		}

		// Token: 0x020000D2 RID: 210
		public sealed class <>c__DisplayClass63_0
		{
		}

		// Token: 0x020000D3 RID: 211
		public sealed class <>c__DisplayClass64_0
		{
		}
	}
}
