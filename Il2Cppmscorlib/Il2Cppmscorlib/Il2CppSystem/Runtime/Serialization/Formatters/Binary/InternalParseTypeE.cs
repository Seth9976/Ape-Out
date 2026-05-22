using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200036E RID: 878
	[OriginalName("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "InternalParseTypeE")]
	[Serializable]
	public enum InternalParseTypeE
	{
		// Token: 0x04002FCB RID: 12235
		Empty,
		// Token: 0x04002FCC RID: 12236
		SerializedStreamHeader,
		// Token: 0x04002FCD RID: 12237
		Object,
		// Token: 0x04002FCE RID: 12238
		Member,
		// Token: 0x04002FCF RID: 12239
		ObjectEnd,
		// Token: 0x04002FD0 RID: 12240
		MemberEnd,
		// Token: 0x04002FD1 RID: 12241
		Headers,
		// Token: 0x04002FD2 RID: 12242
		HeadersEnd,
		// Token: 0x04002FD3 RID: 12243
		SerializedStreamHeaderEnd,
		// Token: 0x04002FD4 RID: 12244
		Envelope,
		// Token: 0x04002FD5 RID: 12245
		EnvelopeEnd,
		// Token: 0x04002FD6 RID: 12246
		Body,
		// Token: 0x04002FD7 RID: 12247
		BodyEnd
	}
}
