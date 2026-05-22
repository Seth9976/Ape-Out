using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001E8 RID: 488
	public sealed class PathReferenceAttribute : Attribute
	{
		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x00010A7F File Offset: 0x0000EC7F
		public string BasePath
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
