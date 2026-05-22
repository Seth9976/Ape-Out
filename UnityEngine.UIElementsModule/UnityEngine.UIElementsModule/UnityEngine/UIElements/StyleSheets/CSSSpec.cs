using System;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x0200017D RID: 381
	public static class CSSSpec
	{
		// Token: 0x060008B9 RID: 2233 RVA: 0x00007F89 File Offset: 0x00006189
		public static int GetSelectorSpecificity(string selector)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040001E6 RID: 486
		public const int typeSelectorWeight = 1;

		// Token: 0x040001E7 RID: 487
		public const int classSelectorWeight = 10;

		// Token: 0x040001E8 RID: 488
		public const int idSelectorWeight = 100;
	}
}
