using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001DB RID: 475
	public sealed class ContractAnnotationAttribute : Attribute
	{
		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x000109FD File Offset: 0x0000EBFD
		public string Contract
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x00010A0A File Offset: 0x0000EC0A
		public bool ForceFullStates
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
