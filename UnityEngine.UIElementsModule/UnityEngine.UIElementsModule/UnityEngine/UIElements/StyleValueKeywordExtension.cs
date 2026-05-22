using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200012D RID: 301
	public static class StyleValueKeywordExtension
	{
		// Token: 0x0600071D RID: 1821 RVA: 0x0000D60C File Offset: 0x0000B80C
		public static string ToUssString(StyleValueKeyword svk)
		{
			string text;
			switch (svk)
			{
			case StyleValueKeyword.Inherit:
				text = "inherit";
				break;
			case StyleValueKeyword.Initial:
				text = "initial";
				break;
			case StyleValueKeyword.Auto:
				text = "auto";
				break;
			case StyleValueKeyword.Unset:
				text = "unset";
				break;
			case StyleValueKeyword.True:
				text = "true";
				break;
			case StyleValueKeyword.False:
				text = "false";
				break;
			case StyleValueKeyword.None:
				text = "none";
				break;
			default:
				throw new ArgumentOutOfRangeException("svk", svk, "Unknown StyleValueKeyword");
			}
			return text;
		}
	}
}
