using System;

namespace UnityEngine.Lumin
{
	// Token: 0x0200028E RID: 654
	public sealed class UsesLuminPrivilegeAttribute : Attribute
	{
		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x0001286C File Offset: 0x00010A6C
		public string privilege
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
