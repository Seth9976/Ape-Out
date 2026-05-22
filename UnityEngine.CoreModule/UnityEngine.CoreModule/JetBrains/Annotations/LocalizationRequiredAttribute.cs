using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001DC RID: 476
	public sealed class LocalizationRequiredAttribute : Attribute
	{
		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600200D RID: 8205 RVA: 0x00010A17 File Offset: 0x0000EC17
		public bool Required
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
