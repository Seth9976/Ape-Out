using System;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x0200018B RID: 395
	public class StyleValidator
	{
		// Token: 0x06000911 RID: 2321 RVA: 0x0000F47C File Offset: 0x0000D67C
		public bool IsUnitMissing(string propertySyntax, string propertyValue)
		{
			float num;
			return Single.TryParse(propertyValue, out num) && (propertySyntax.Contains("<length>") || propertySyntax.Contains("<percentage>"));
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0000F4B8 File Offset: 0x0000D6B8
		public bool IsUnsupportedColor(string propertySyntax)
		{
			return propertySyntax.StartsWith("<color>");
		}
	}
}
