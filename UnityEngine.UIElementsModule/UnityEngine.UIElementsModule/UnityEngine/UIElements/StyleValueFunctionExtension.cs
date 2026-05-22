using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200012B RID: 299
	public static class StyleValueFunctionExtension
	{
		// Token: 0x0600071B RID: 1819 RVA: 0x0000D550 File Offset: 0x0000B750
		public static StyleValueFunction FromUssString(string ussValue)
		{
			ussValue = ussValue.ToLower();
			string text = ussValue;
			string text2 = text;
			if (text2 != null)
			{
				StyleValueFunction styleValueFunction;
				if (!(text2 == "var"))
				{
					if (!(text2 == "env"))
					{
						if (!(text2 == "linear-gradient"))
						{
							goto IL_0045;
						}
						styleValueFunction = StyleValueFunction.LinearGradient;
					}
					else
					{
						styleValueFunction = StyleValueFunction.Env;
					}
				}
				else
				{
					styleValueFunction = StyleValueFunction.Var;
				}
				return styleValueFunction;
			}
			IL_0045:
			throw new ArgumentOutOfRangeException("ussValue", ussValue, "Unknown function name");
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0000D5B4 File Offset: 0x0000B7B4
		public static string ToUssString(StyleValueFunction svf)
		{
			string text;
			switch (svf)
			{
			case StyleValueFunction.Var:
				text = "var";
				break;
			case StyleValueFunction.Env:
				text = "env";
				break;
			case StyleValueFunction.LinearGradient:
				text = "linear-gradient";
				break;
			default:
				throw new ArgumentOutOfRangeException("svf", svf, "Unknown StyleValueFunction");
			}
			return text;
		}

		// Token: 0x04000123 RID: 291
		public const string k_Var = "var";

		// Token: 0x04000124 RID: 292
		public const string k_Env = "env";

		// Token: 0x04000125 RID: 293
		public const string k_LinearGradient = "linear-gradient";
	}
}
