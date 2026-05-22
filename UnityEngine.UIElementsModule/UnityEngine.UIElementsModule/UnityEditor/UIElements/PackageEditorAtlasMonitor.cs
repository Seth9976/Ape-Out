using System;
using UnityEngine.UIElements;
using UnityEngine.UIElements.UIR;

namespace UnityEditor.UIElements
{
	// Token: 0x02000005 RID: 5
	public static class PackageEditorAtlasMonitor
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002059 File Offset: 0x00000259
		public static void StaticInit()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00008468 File Offset: 0x00006668
		public static void OnPreRender()
		{
			bool flag = PackageEditorAtlasMonitor.CheckForColorSpaceChange();
			bool flag2 = PackageEditorAtlasMonitor.CheckForImportedTextures();
			bool flag3 = PackageEditorAtlasMonitor.CheckForImportedVectorImages();
			bool flag4 = PackageEditorAtlasMonitor.CheckForRenderTexturesTrashed();
			bool flag5 = flag || flag2 || flag4;
			if (flag5)
			{
				UnityEngine.UIElements.UIRAtlasManager.MarkAllForReset();
				UnityEngine.UIElements.UIR.VectorImageManager.MarkAllForReset();
			}
			else
			{
				bool flag6 = flag || flag3;
				if (flag6)
				{
					UnityEngine.UIElements.UIR.VectorImageManager.MarkAllForReset();
				}
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		public static bool CheckForColorSpaceChange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002073 File Offset: 0x00000273
		public static bool CheckForImportedTextures()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002080 File Offset: 0x00000280
		public static bool CheckForImportedVectorImages()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000208D File Offset: 0x0000028D
		public static bool CheckForRenderTexturesTrashed()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0200019A RID: 410
		public class TexturePostProcessor
		{
		}
	}
}
