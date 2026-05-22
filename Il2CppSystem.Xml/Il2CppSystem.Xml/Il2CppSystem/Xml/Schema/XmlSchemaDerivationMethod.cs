using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200019F RID: 415
	[OriginalName("System.Xml.dll", "System.Xml.Schema", "XmlSchemaDerivationMethod")]
	[Flags]
	public enum XmlSchemaDerivationMethod
	{
		// Token: 0x0400194E RID: 6478
		Empty = 0,
		// Token: 0x0400194F RID: 6479
		Substitution = 1,
		// Token: 0x04001950 RID: 6480
		Extension = 2,
		// Token: 0x04001951 RID: 6481
		Restriction = 4,
		// Token: 0x04001952 RID: 6482
		List = 8,
		// Token: 0x04001953 RID: 6483
		Union = 16,
		// Token: 0x04001954 RID: 6484
		All = 255,
		// Token: 0x04001955 RID: 6485
		None = 256
	}
}
