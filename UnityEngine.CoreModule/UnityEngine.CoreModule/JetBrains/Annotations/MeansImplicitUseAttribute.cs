using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001E0 RID: 480
	public sealed class MeansImplicitUseAttribute : Attribute
	{
		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06002011 RID: 8209 RVA: 0x00010A4B File Offset: 0x0000EC4B
		public ImplicitUseKindFlags UseKindFlags
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x00010A58 File Offset: 0x0000EC58
		public ImplicitUseTargetFlags TargetFlags
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
