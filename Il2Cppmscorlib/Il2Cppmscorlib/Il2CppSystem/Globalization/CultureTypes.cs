using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000230 RID: 560
	[OriginalName("mscorlib.dll", "System.Globalization", "CultureTypes")]
	[Flags]
	[Serializable]
	public enum CultureTypes
	{
		// Token: 0x04002145 RID: 8517
		NeutralCultures = 1,
		// Token: 0x04002146 RID: 8518
		SpecificCultures = 2,
		// Token: 0x04002147 RID: 8519
		InstalledWin32Cultures = 4,
		// Token: 0x04002148 RID: 8520
		AllCultures = 7,
		// Token: 0x04002149 RID: 8521
		UserCustomCulture = 8,
		// Token: 0x0400214A RID: 8522
		ReplacementCultures = 16,
		// Token: 0x0400214B RID: 8523
		WindowsOnlyCultures = 32,
		// Token: 0x0400214C RID: 8524
		FrameworkCultures = 64
	}
}
