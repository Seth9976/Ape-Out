using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000112 RID: 274
	public static class UIRUtility
	{
		// Token: 0x06000632 RID: 1586 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
		public static Vector4 ToVector4(Rect rc)
		{
			return new Vector4(rc.xMin, rc.yMin, rc.xMax, rc.yMax);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0000C618 File Offset: 0x0000A818
		public static bool IsRoundRect(VisualElement ve)
		{
			IResolvedStyle resolvedStyle = ve.resolvedStyle;
			return resolvedStyle.borderTopLeftRadius >= 1E-30f || resolvedStyle.borderTopRightRadius >= 1E-30f || resolvedStyle.borderBottomLeftRadius >= 1E-30f || resolvedStyle.borderBottomRightRadius >= 1E-30f;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000065D6 File Offset: 0x000047D6
		public static bool IsVectorImageBackground(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0000C66C File Offset: 0x0000A86C
		public static void Destroy(Object obj)
		{
			bool flag = obj == null;
			if (!flag)
			{
				bool isPlaying = Application.isPlaying;
				if (isPlaying)
				{
					Object.Destroy(obj);
				}
				else
				{
					Object.DestroyImmediate(obj);
				}
			}
		}

		// Token: 0x040000DA RID: 218
		public const float k_Epsilon = 1E-30f;

		// Token: 0x040000DB RID: 219
		public const float k_ClearZ = 0.99f;

		// Token: 0x040000DC RID: 220
		public const float k_MeshPosZ = 0f;

		// Token: 0x040000DD RID: 221
		public const float k_MaskPosZ = 1f;
	}
}
