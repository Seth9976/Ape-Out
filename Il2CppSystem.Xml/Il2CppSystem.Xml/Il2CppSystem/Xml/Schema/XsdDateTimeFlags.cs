using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001EA RID: 490
	[OriginalName("System.Xml.dll", "System.Xml.Schema", "XsdDateTimeFlags")]
	[Flags]
	public enum XsdDateTimeFlags
	{
		// Token: 0x04001EDB RID: 7899
		DateTime = 1,
		// Token: 0x04001EDC RID: 7900
		Time = 2,
		// Token: 0x04001EDD RID: 7901
		Date = 4,
		// Token: 0x04001EDE RID: 7902
		GYearMonth = 8,
		// Token: 0x04001EDF RID: 7903
		GYear = 16,
		// Token: 0x04001EE0 RID: 7904
		GMonthDay = 32,
		// Token: 0x04001EE1 RID: 7905
		GDay = 64,
		// Token: 0x04001EE2 RID: 7906
		GMonth = 128,
		// Token: 0x04001EE3 RID: 7907
		XdrDateTimeNoTz = 256,
		// Token: 0x04001EE4 RID: 7908
		XdrDateTime = 512,
		// Token: 0x04001EE5 RID: 7909
		XdrTimeNoTz = 1024,
		// Token: 0x04001EE6 RID: 7910
		AllXsd = 255
	}
}
