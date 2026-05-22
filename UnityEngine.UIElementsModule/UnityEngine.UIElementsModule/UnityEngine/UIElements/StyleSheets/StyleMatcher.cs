using System;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000187 RID: 391
	public class StyleMatcher : BaseStyleMatcher
	{
		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0000828B File Offset: 0x0000648B
		public string current
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00008298 File Offset: 0x00006498
		public override int valueCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x000082A5 File Offset: 0x000064A5
		public override bool isVariable
		{
			get
			{
				return base.hasCurrent && this.current.StartsWith("var(");
			}
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x000082C2 File Offset: 0x000064C2
		public void Initialize(string propertyValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0000F44C File Offset: 0x0000D64C
		public override bool MatchKeyword(string keyword)
		{
			return this.current != null && keyword == this.current.ToLower();
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x000082CF File Offset: 0x000064CF
		public override bool MatchNumber()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x000082DC File Offset: 0x000064DC
		public override bool MatchInteger()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x000082E9 File Offset: 0x000064E9
		public override bool MatchLength()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x000082F6 File Offset: 0x000064F6
		public override bool MatchPercentage()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00008303 File Offset: 0x00006503
		public override bool MatchColor()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00008310 File Offset: 0x00006510
		public override bool MatchResource()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0000831D File Offset: 0x0000651D
		public override bool MatchUrl()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
