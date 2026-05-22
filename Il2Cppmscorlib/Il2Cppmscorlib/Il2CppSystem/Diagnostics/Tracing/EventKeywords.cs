using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200052A RID: 1322
	[OriginalName("mscorlib.dll", "System.Diagnostics.Tracing", "EventKeywords")]
	[Flags]
	public enum EventKeywords : long
	{
		// Token: 0x04003ECD RID: 16077
		None = 0L,
		// Token: 0x04003ECE RID: 16078
		All = -1L,
		// Token: 0x04003ECF RID: 16079
		MicrosoftTelemetry = 562949953421312L,
		// Token: 0x04003ED0 RID: 16080
		WdiContext = 562949953421312L,
		// Token: 0x04003ED1 RID: 16081
		WdiDiagnostic = 1125899906842624L,
		// Token: 0x04003ED2 RID: 16082
		Sqm = 2251799813685248L,
		// Token: 0x04003ED3 RID: 16083
		AuditFailure = 4503599627370496L,
		// Token: 0x04003ED4 RID: 16084
		AuditSuccess = 9007199254740992L,
		// Token: 0x04003ED5 RID: 16085
		CorrelationHint = 4503599627370496L,
		// Token: 0x04003ED6 RID: 16086
		EventLogClassic = 36028797018963968L
	}
}
