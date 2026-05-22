using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000529 RID: 1321
	[OriginalName("mscorlib.dll", "System.Diagnostics.Tracing", "EventChannel")]
	public enum EventChannel : byte
	{
		// Token: 0x04003EC7 RID: 16071
		None,
		// Token: 0x04003EC8 RID: 16072
		Admin = 16,
		// Token: 0x04003EC9 RID: 16073
		Operational,
		// Token: 0x04003ECA RID: 16074
		Analytic,
		// Token: 0x04003ECB RID: 16075
		Debug
	}
}
