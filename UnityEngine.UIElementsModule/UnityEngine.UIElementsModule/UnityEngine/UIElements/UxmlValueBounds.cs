using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200014A RID: 330
	public class UxmlValueBounds : UxmlTypeRestriction
	{
		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00007049 File Offset: 0x00005249
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00007056 File Offset: 0x00005256
		public string min
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

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00007063 File Offset: 0x00005263
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00007070 File Offset: 0x00005270
		public string max
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

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x0000707D File Offset: 0x0000527D
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x0000708A File Offset: 0x0000528A
		public bool excludeMin
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

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00007097 File Offset: 0x00005297
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x000070A4 File Offset: 0x000052A4
		public bool excludeMax
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

		// Token: 0x0600076F RID: 1903 RVA: 0x0000D804 File Offset: 0x0000BA04
		public override bool Equals(UxmlTypeRestriction other)
		{
			UxmlValueBounds uxmlValueBounds = other.TryCast<UxmlValueBounds>();
			bool flag = uxmlValueBounds == null;
			return !flag && (this.min == uxmlValueBounds.min && this.max == uxmlValueBounds.max && this.excludeMin == uxmlValueBounds.excludeMin) && this.excludeMax == uxmlValueBounds.excludeMax;
		}
	}
}
