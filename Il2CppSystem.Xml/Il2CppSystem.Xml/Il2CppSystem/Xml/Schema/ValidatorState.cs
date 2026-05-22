using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001D6 RID: 470
	[OriginalName("System.Xml.dll", "System.Xml.Schema", "ValidatorState")]
	public enum ValidatorState
	{
		// Token: 0x04001B96 RID: 7062
		None,
		// Token: 0x04001B97 RID: 7063
		Start,
		// Token: 0x04001B98 RID: 7064
		TopLevelAttribute,
		// Token: 0x04001B99 RID: 7065
		TopLevelTextOrWS,
		// Token: 0x04001B9A RID: 7066
		Element,
		// Token: 0x04001B9B RID: 7067
		Attribute,
		// Token: 0x04001B9C RID: 7068
		EndOfAttributes,
		// Token: 0x04001B9D RID: 7069
		Text,
		// Token: 0x04001B9E RID: 7070
		Whitespace,
		// Token: 0x04001B9F RID: 7071
		EndElement,
		// Token: 0x04001BA0 RID: 7072
		SkipToEndElement,
		// Token: 0x04001BA1 RID: 7073
		Finish
	}
}
