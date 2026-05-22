using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001D5 RID: 469
	[OriginalName("System.Xml.dll", "System.Xml.Schema", "XmlSchemaValidationFlags")]
	[Flags]
	public enum XmlSchemaValidationFlags
	{
		// Token: 0x04001B8F RID: 7055
		None = 0,
		// Token: 0x04001B90 RID: 7056
		ProcessInlineSchema = 1,
		// Token: 0x04001B91 RID: 7057
		ProcessSchemaLocation = 2,
		// Token: 0x04001B92 RID: 7058
		ReportValidationWarnings = 4,
		// Token: 0x04001B93 RID: 7059
		ProcessIdentityConstraints = 8,
		// Token: 0x04001B94 RID: 7060
		AllowXmlAttributes = 16
	}
}
