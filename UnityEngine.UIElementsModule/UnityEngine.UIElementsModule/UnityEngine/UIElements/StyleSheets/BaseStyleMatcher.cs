using System;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000186 RID: 390
	public abstract class BaseStyleMatcher
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x000081AE File Offset: 0x000063AE
		public bool hasCurrent
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x000081BB File Offset: 0x000063BB
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x000081C8 File Offset: 0x000063C8
		public int matchedVariableCount
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

		// Token: 0x060008E8 RID: 2280 RVA: 0x000081D5 File Offset: 0x000063D5
		public void Initialize()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x000081E2 File Offset: 0x000063E2
		public void MoveNext()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x000081EF File Offset: 0x000063EF
		public void SaveMark()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x000081FC File Offset: 0x000063FC
		public void RestoreMark()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00008209 File Offset: 0x00006409
		public void DropMark()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00008216 File Offset: 0x00006416
		public bool Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00008223 File Offset: 0x00006423
		public bool MatchExpression(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00008230 File Offset: 0x00006430
		public bool MatchGroup(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0000823D File Offset: 0x0000643D
		public bool MatchCombinator(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0000824A File Offset: 0x0000644A
		public bool MatchOr(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0000F42C File Offset: 0x0000D62C
		public bool MatchOrOr(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			int num = this.MatchMany(exp);
			return num > 0;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00008257 File Offset: 0x00006457
		public bool MatchAndAnd(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00008264 File Offset: 0x00006464
		public int MatchMany(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00008271 File Offset: 0x00006471
		public bool MatchJuxtaposition(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0000827E File Offset: 0x0000647E
		public bool MatchDataType(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
