using System;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x02000140 RID: 320
	public class UxmlDoubleAttributeDescription : TypedUxmlAttributeDescription<double>
	{
		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00006F79 File Offset: 0x00005179
		public override string defaultValueAsString
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0000D6CC File Offset: 0x0000B8CC
		public static double ConvertValueToDouble(string v, double defaultValue)
		{
			double num;
			bool flag = v == null || !Double.TryParse(v, NumberStyles.Float, CultureInfo.InvariantCulture, out num);
			double num2;
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

		// Token: 0x02000203 RID: 515
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
