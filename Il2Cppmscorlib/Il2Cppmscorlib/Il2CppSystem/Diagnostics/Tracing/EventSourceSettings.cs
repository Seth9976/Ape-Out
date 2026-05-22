using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000515 RID: 1301
	[OriginalName("mscorlib.dll", "System.Diagnostics.Tracing", "EventSourceSettings")]
	[Flags]
	public enum EventSourceSettings
	{
		// Token: 0x04003DEA RID: 15850
		Default = 0,
		// Token: 0x04003DEB RID: 15851
		ThrowOnEventWriteErrors = 1,
		// Token: 0x04003DEC RID: 15852
		EtwManifestEventFormat = 4,
		// Token: 0x04003DED RID: 15853
		EtwSelfDescribingEventFormat = 8
	}
}
