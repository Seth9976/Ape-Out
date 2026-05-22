using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000061 RID: 97
	[OriginalName("System.dll", "System.Text.RegularExpressions", "RegexOptions")]
	[Flags]
	public enum RegexOptions
	{
		// Token: 0x040004D5 RID: 1237
		None = 0,
		// Token: 0x040004D6 RID: 1238
		IgnoreCase = 1,
		// Token: 0x040004D7 RID: 1239
		Multiline = 2,
		// Token: 0x040004D8 RID: 1240
		ExplicitCapture = 4,
		// Token: 0x040004D9 RID: 1241
		Compiled = 8,
		// Token: 0x040004DA RID: 1242
		Singleline = 16,
		// Token: 0x040004DB RID: 1243
		IgnorePatternWhitespace = 32,
		// Token: 0x040004DC RID: 1244
		RightToLeft = 64,
		// Token: 0x040004DD RID: 1245
		ECMAScript = 256,
		// Token: 0x040004DE RID: 1246
		CultureInvariant = 512
	}
}
