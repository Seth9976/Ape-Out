using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000141 RID: 321
	public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription<int>
	{
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00006F86 File Offset: 0x00005186
		public override string defaultValueAsString
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0000D704 File Offset: 0x0000B904
		public static int ConvertValueToInt(string v, int defaultValue)
		{
			int num;
			bool flag = v == null || !Int32.TryParse(v, out num);
			int num2;
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

		// Token: 0x02000204 RID: 516
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
