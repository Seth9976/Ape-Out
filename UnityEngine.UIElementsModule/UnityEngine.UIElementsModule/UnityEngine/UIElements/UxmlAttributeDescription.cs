using System;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200013D RID: 317
	public abstract class UxmlAttributeDescription
	{
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00006EC3 File Offset: 0x000050C3
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x00006ED0 File Offset: 0x000050D0
		public string name
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

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00006EDD File Offset: 0x000050DD
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00006EEA File Offset: 0x000050EA
		public IEnumerable<string> obsoleteNames
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

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00006EF7 File Offset: 0x000050F7
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00006F04 File Offset: 0x00005104
		public string type
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

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00006F11 File Offset: 0x00005111
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00006F1E File Offset: 0x0000511E
		public string typeNamespace
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

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x00006F2B File Offset: 0x0000512B
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x00006F38 File Offset: 0x00005138
		public UxmlAttributeDescription.Use use
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

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00006F45 File Offset: 0x00005145
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00006F52 File Offset: 0x00005152
		public UxmlTypeRestriction restriction
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

		// Token: 0x04000146 RID: 326
		public const string xmlSchemaNamespace = "http://www.w3.org/2001/XMLSchema";

		// Token: 0x02000200 RID: 512
		public enum Use
		{
			// Token: 0x04000269 RID: 617
			None,
			// Token: 0x0400026A RID: 618
			Optional,
			// Token: 0x0400026B RID: 619
			Prohibited,
			// Token: 0x0400026C RID: 620
			Required
		}
	}
}
