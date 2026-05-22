using System;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x0200013F RID: 319
	public class UxmlFloatAttributeDescription : TypedUxmlAttributeDescription<float>
	{
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00006F6C File Offset: 0x0000516C
		public override string defaultValueAsString
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0000D694 File Offset: 0x0000B894
		public static float ConvertValueToFloat(string v, float defaultValue)
		{
			float num;
			bool flag = v == null || !Single.TryParse(v, NumberStyles.Float, CultureInfo.InvariantCulture, out num);
			float num2;
			if (flag)
			{
				num2 = defaultValue;
			}
			else
			{
				num2 = num;
			}
			return num2;
		}

		// Token: 0x02000202 RID: 514
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
