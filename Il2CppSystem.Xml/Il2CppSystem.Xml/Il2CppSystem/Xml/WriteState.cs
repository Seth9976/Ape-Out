using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200005E RID: 94
	[OriginalName("System.Xml.dll", "System.Xml", "WriteState")]
	public enum WriteState
	{
		// Token: 0x04000762 RID: 1890
		Start,
		// Token: 0x04000763 RID: 1891
		Prolog,
		// Token: 0x04000764 RID: 1892
		Element,
		// Token: 0x04000765 RID: 1893
		Attribute,
		// Token: 0x04000766 RID: 1894
		Content,
		// Token: 0x04000767 RID: 1895
		Closed,
		// Token: 0x04000768 RID: 1896
		Error
	}
}
