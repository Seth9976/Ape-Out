using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200011E RID: 286
	public static class StyleValueExtensions
	{
		// Token: 0x060006F2 RID: 1778 RVA: 0x0000D3A0 File Offset: 0x0000B5A0
		public static StyleKeyword ToStyleKeyword(StyleValueKeyword styleValueKeyword)
		{
			StyleKeyword styleKeyword;
			if (styleValueKeyword != StyleValueKeyword.Initial)
			{
				if (styleValueKeyword != StyleValueKeyword.Auto)
				{
					if (styleValueKeyword != StyleValueKeyword.None)
					{
						styleKeyword = StyleKeyword.Undefined;
					}
					else
					{
						styleKeyword = StyleKeyword.None;
					}
				}
				else
				{
					styleKeyword = StyleKeyword.Auto;
				}
			}
			else
			{
				styleKeyword = StyleKeyword.Initial;
			}
			return styleKeyword;
		}
	}
}
