using System;
using System.Runtime.InteropServices;

namespace UnityEngine.UIElements
{
	// Token: 0x02000110 RID: 272
	public class MeshGenerationContext
	{
		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00006506 File Offset: 0x00004706
		public VisualElement visualElement
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00006513 File Offset: 0x00004713
		public MeshWriteData Allocate(int vertexCount, int indexCount, [Optional] Texture texture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00006520 File Offset: 0x00004720
		public MeshWriteData Allocate(int vertexCount, int indexCount, Texture texture, Material material, MeshGenerationContext.MeshFlags flags)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020001F8 RID: 504
		public enum MeshFlags
		{
			// Token: 0x04000260 RID: 608
			None,
			// Token: 0x04000261 RID: 609
			UVisDisplacement,
			// Token: 0x04000262 RID: 610
			IsSVGGradients,
			// Token: 0x04000263 RID: 611
			IsCustomSVGGradients
		}
	}
}
