using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x0200029E RID: 670
	[OriginalName("mscorlib.dll", "System.Threading.Tasks", "CausalityRelation")]
	public enum CausalityRelation
	{
		// Token: 0x040027BB RID: 10171
		AssignDelegate,
		// Token: 0x040027BC RID: 10172
		Join,
		// Token: 0x040027BD RID: 10173
		Choice,
		// Token: 0x040027BE RID: 10174
		Cancel,
		// Token: 0x040027BF RID: 10175
		Error
	}
}
