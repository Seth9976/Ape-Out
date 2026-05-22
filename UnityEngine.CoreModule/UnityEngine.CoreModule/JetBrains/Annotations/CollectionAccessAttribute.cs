using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001EB RID: 491
	public sealed class CollectionAccessAttribute : Attribute
	{
		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x00010ADA File Offset: 0x0000ECDA
		public CollectionAccessType CollectionAccessType
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
