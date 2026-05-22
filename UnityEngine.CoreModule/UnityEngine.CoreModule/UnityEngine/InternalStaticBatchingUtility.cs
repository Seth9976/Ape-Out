using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000262 RID: 610
	public class InternalStaticBatchingUtility
	{
		// Token: 0x060021F4 RID: 8692 RVA: 0x0001206A File Offset: 0x0001026A
		public static void CombineRoot(GameObject staticBatchRoot, InternalStaticBatchingUtility.StaticBatcherGOSorter sorter)
		{
			InternalStaticBatchingUtility.Combine(staticBatchRoot, false, false, sorter);
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x00012077 File Offset: 0x00010277
		public static void Combine(GameObject staticBatchRoot, bool combineOnlyStatic, bool isEditorPostprocessScene, InternalStaticBatchingUtility.StaticBatcherGOSorter sorter)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x00077630 File Offset: 0x00075830
		public static uint GetMeshFormatHash(Mesh mesh)
		{
			bool flag = mesh == null;
			uint num;
			if (flag)
			{
				num = 0U;
			}
			else
			{
				uint num2 = 1U;
				int vertexAttributeCount = mesh.vertexAttributeCount;
				for (int i = 0; i < vertexAttributeCount; i++)
				{
					UnityEngine.Rendering.VertexAttributeDescriptor vertexAttribute = mesh.GetVertexAttribute(i);
					uint num3 = (uint)(vertexAttribute.attribute | (UnityEngine.Rendering.VertexAttribute)((int)vertexAttribute.format << 4) | (UnityEngine.Rendering.VertexAttribute)((uint)vertexAttribute.dimension << 8));
					num2 = num2 * 2654435761U + num3;
				}
				num = num2;
			}
			return num;
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x00012084 File Offset: 0x00010284
		public static Il2CppReferenceArray<GameObject> SortGameObjectsForStaticBatching(Il2CppReferenceArray<GameObject> gos, InternalStaticBatchingUtility.StaticBatcherGOSorter sorter)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00012091 File Offset: 0x00010291
		public static void CombineGameObjects(Il2CppReferenceArray<GameObject> gos, GameObject staticBatchRoot, bool isEditorPostprocessScene, InternalStaticBatchingUtility.StaticBatcherGOSorter sorter)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001BF7 RID: 7159
		public const int MaxVerticesInBatch = 64000;

		// Token: 0x04001BF8 RID: 7160
		public const string CombinedMeshPrefix = "Combined Mesh";

		// Token: 0x02000B9B RID: 2971
		public class StaticBatcherGOSorter
		{
		}

		// Token: 0x02000B9C RID: 2972
		public sealed class <>c__DisplayClass5_0
		{
		}

		// Token: 0x02000B9D RID: 2973
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
