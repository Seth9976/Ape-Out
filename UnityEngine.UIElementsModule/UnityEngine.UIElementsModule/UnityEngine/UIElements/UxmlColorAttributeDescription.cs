using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000144 RID: 324
	public class UxmlColorAttributeDescription : TypedUxmlAttributeDescription<Color>
	{
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00006FAD File Offset: 0x000051AD
		public override string defaultValueAsString
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0000D788 File Offset: 0x0000B988
		public static Color ConvertValueToColor(string v, Color defaultValue)
		{
			Color color;
			bool flag = v == null || !ColorUtility.TryParseHtmlString(v, out color);
			Color color2;
			if (flag)
			{
				color2 = defaultValue;
			}
			else
			{
				color2 = color;
			}
			return color2;
		}

		// Token: 0x02000207 RID: 519
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
