using System;
using Il2CppSystem;

namespace JetBrains.Annotations
{
	// Token: 0x020001DE RID: 478
	public sealed class BaseTypeRequiredAttribute : Attribute
	{
		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x00010A24 File Offset: 0x0000EC24
		public Type BaseType
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
