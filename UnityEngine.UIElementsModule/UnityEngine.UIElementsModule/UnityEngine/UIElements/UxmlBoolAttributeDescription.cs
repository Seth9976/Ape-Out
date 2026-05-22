using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000143 RID: 323
	public class UxmlBoolAttributeDescription : TypedUxmlAttributeDescription<bool>
	{
		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00006FA0 File Offset: 0x000051A0
		public override string defaultValueAsString
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0000D75C File Offset: 0x0000B95C
		public static bool ConvertValueToBool(string v, bool defaultValue)
		{
			bool flag2;
			bool flag = v == null || !Boolean.TryParse(v, out flag2);
			bool flag3;
			if (flag)
			{
				flag3 = defaultValue;
			}
			else
			{
				flag3 = flag2;
			}
			return flag3;
		}

		// Token: 0x02000206 RID: 518
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
