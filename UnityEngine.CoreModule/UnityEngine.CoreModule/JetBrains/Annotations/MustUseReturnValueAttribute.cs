using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001E6 RID: 486
	public sealed class MustUseReturnValueAttribute : Attribute
	{
		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x00010A72 File Offset: 0x0000EC72
		public string Justification
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
