using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001E3 RID: 483
	public sealed class PublicAPIAttribute : Attribute
	{
		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06002013 RID: 8211 RVA: 0x00010A65 File Offset: 0x0000EC65
		public string Comment
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
