using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000179 RID: 377
	[OriginalName("System.Xml.dll", "System.Xml.Schema", "AttributeMatchState")]
	public enum AttributeMatchState
	{
		// Token: 0x040015B2 RID: 5554
		AttributeFound,
		// Token: 0x040015B3 RID: 5555
		AnyIdAttributeFound,
		// Token: 0x040015B4 RID: 5556
		UndeclaredElementAndAttribute,
		// Token: 0x040015B5 RID: 5557
		UndeclaredAttribute,
		// Token: 0x040015B6 RID: 5558
		AnyAttributeLax,
		// Token: 0x040015B7 RID: 5559
		AnyAttributeSkip,
		// Token: 0x040015B8 RID: 5560
		ProhibitedAnyAttribute,
		// Token: 0x040015B9 RID: 5561
		ProhibitedAttribute,
		// Token: 0x040015BA RID: 5562
		AttributeNameMismatch,
		// Token: 0x040015BB RID: 5563
		ValidateAttributeInvalidCall
	}
}
