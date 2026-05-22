using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000149 RID: 329
	public class UxmlValueMatches : UxmlTypeRestriction
	{
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x0000702F File Offset: 0x0000522F
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x0000703C File Offset: 0x0000523C
		public string regex
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0000D7CC File Offset: 0x0000B9CC
		public override bool Equals(UxmlTypeRestriction other)
		{
			UxmlValueMatches uxmlValueMatches = other.TryCast<UxmlValueMatches>();
			bool flag = uxmlValueMatches == null;
			return !flag && this.regex == uxmlValueMatches.regex;
		}
	}
}
