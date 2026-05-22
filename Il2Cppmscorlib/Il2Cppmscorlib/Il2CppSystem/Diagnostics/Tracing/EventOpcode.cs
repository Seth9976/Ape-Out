using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000528 RID: 1320
	[OriginalName("mscorlib.dll", "System.Diagnostics.Tracing", "EventOpcode")]
	public enum EventOpcode
	{
		// Token: 0x04003EBB RID: 16059
		Info,
		// Token: 0x04003EBC RID: 16060
		Start,
		// Token: 0x04003EBD RID: 16061
		Stop,
		// Token: 0x04003EBE RID: 16062
		DataCollectionStart,
		// Token: 0x04003EBF RID: 16063
		DataCollectionStop,
		// Token: 0x04003EC0 RID: 16064
		Extension,
		// Token: 0x04003EC1 RID: 16065
		Reply,
		// Token: 0x04003EC2 RID: 16066
		Resume,
		// Token: 0x04003EC3 RID: 16067
		Suspend,
		// Token: 0x04003EC4 RID: 16068
		Send,
		// Token: 0x04003EC5 RID: 16069
		Receive = 240
	}
}
