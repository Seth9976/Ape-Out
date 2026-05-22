using System;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR.Implementation
{
	// Token: 0x02000173 RID: 371
	public class UIRStylePainter
	{
		// Token: 0x0600086A RID: 2154 RVA: 0x00007BB6 File Offset: 0x00005DB6
		public MeshWriteData GetPooledMeshWriteData()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00007BC3 File Offset: 0x00005DC3
		public MeshGenerationContext meshGenerationContext
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00007BD0 File Offset: 0x00005DD0
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x00007BDD File Offset: 0x00005DDD
		public VisualElement currentElement
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

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00007BEA File Offset: 0x00005DEA
		public UIRenderDevice device
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x00007BF7 File Offset: 0x00005DF7
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x00007C04 File Offset: 0x00005E04
		public int totalVertices
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

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00007C11 File Offset: 0x00005E11
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00007C1E File Offset: 0x00005E1E
		public int totalIndices
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

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00007C2B File Offset: 0x00005E2B
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00007C38 File Offset: 0x00005E38
		public bool disposed
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

		// Token: 0x06000875 RID: 2165 RVA: 0x00007C45 File Offset: 0x00005E45
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00007C57 File Offset: 0x00005E57
		public void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00007C64 File Offset: 0x00005E64
		public void Begin(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00007C71 File Offset: 0x00005E71
		public void LandClipUnregisterMeshDrawCommand(RenderChainCommand cmd)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00007C7E File Offset: 0x00005E7E
		public void LandClipRegisterMesh(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, int indexOffset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00007C8B File Offset: 0x00005E8B
		public MeshWriteData DrawMesh(int vertexCount, int indexCount, Texture texture, Material material, MeshGenerationContext.MeshFlags flags)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x0000EAE0 File Offset: 0x0000CCE0
		public VisualElement visualElement
		{
			get
			{
				return this.currentElement;
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00007C98 File Offset: 0x00005E98
		public void DrawVisualElementBackground()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00007CA5 File Offset: 0x00005EA5
		public void DrawVisualElementBorder()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00007CB2 File Offset: 0x00005EB2
		public void ApplyVisualElementClipping()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00007CBF File Offset: 0x00005EBF
		public void Reset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00007CCC File Offset: 0x00005ECC
		public void ValidateMeshWriteData()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00007CD9 File Offset: 0x00005ED9
		public void GenerateStencilClipEntryForRoundedRectBackground()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00007CE6 File Offset: 0x00005EE6
		public void GenerateStencilClipEntryForSVGBackground()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
