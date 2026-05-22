using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001DF RID: 479
	public sealed class UsedImplicitlyAttribute : Attribute
	{
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x0600200F RID: 8207 RVA: 0x00010A31 File Offset: 0x0000EC31
		public ImplicitUseKindFlags UseKindFlags
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x00010A3E File Offset: 0x0000EC3E
		public ImplicitUseTargetFlags TargetFlags
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
