using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004CC RID: 1228
	[OriginalName("mscorlib.dll", "System.Diagnostics.Tracing", "EventFieldFormat")]
	public enum EventFieldFormat
	{
		// Token: 0x04003B7B RID: 15227
		Default,
		// Token: 0x04003B7C RID: 15228
		String = 2,
		// Token: 0x04003B7D RID: 15229
		Boolean,
		// Token: 0x04003B7E RID: 15230
		Hexadecimal,
		// Token: 0x04003B7F RID: 15231
		Xml = 11,
		// Token: 0x04003B80 RID: 15232
		Json,
		// Token: 0x04003B81 RID: 15233
		HResult = 15
	}
}
