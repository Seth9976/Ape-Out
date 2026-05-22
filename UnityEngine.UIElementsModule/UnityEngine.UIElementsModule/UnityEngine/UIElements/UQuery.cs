using System;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x02000056 RID: 86
	public static class UQuery
	{
		// Token: 0x020001AC RID: 428
		public interface IVisualPredicateWrapper
		{
		}

		// Token: 0x020001AD RID: 429
		public abstract class UQueryMatcher : UnityEngine.UIElements.StyleSheets.HierarchyTraversal
		{
			// Token: 0x0200021E RID: 542
			[Serializable]
			public sealed class <>c
			{
			}
		}

		// Token: 0x020001AE RID: 430
		public abstract class SingleQueryMatcher : UQuery.UQueryMatcher
		{
		}

		// Token: 0x020001AF RID: 431
		public class FirstQueryMatcher : UQuery.SingleQueryMatcher
		{
		}

		// Token: 0x020001B0 RID: 432
		public class LastQueryMatcher : UQuery.SingleQueryMatcher
		{
		}

		// Token: 0x020001B1 RID: 433
		public class IndexQueryMatcher : UQuery.SingleQueryMatcher
		{
		}
	}
}
