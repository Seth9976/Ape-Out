using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000142 RID: 322
	public class UxmlLongAttributeDescription : TypedUxmlAttributeDescription<long>
	{
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00006F93 File Offset: 0x00005193
		public override string defaultValueAsString
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0000D730 File Offset: 0x0000B930
		public static long ConvertValueToLong(string v, long defaultValue)
		{
			long num;
			bool flag = v == null || !Int64.TryParse(v, out num);
			long num2;
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

		// Token: 0x02000205 RID: 517
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
