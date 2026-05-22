using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200011D RID: 285
	[OriginalName("System.Xml.dll", "System.Xml.Schema", "RestrictionFlags")]
	[Flags]
	public enum RestrictionFlags
	{
		// Token: 0x0400116B RID: 4459
		Length = 1,
		// Token: 0x0400116C RID: 4460
		MinLength = 2,
		// Token: 0x0400116D RID: 4461
		MaxLength = 4,
		// Token: 0x0400116E RID: 4462
		Pattern = 8,
		// Token: 0x0400116F RID: 4463
		Enumeration = 16,
		// Token: 0x04001170 RID: 4464
		WhiteSpace = 32,
		// Token: 0x04001171 RID: 4465
		MaxInclusive = 64,
		// Token: 0x04001172 RID: 4466
		MaxExclusive = 128,
		// Token: 0x04001173 RID: 4467
		MinInclusive = 256,
		// Token: 0x04001174 RID: 4468
		MinExclusive = 512,
		// Token: 0x04001175 RID: 4469
		TotalDigits = 1024,
		// Token: 0x04001176 RID: 4470
		FractionDigits = 2048
	}
}
