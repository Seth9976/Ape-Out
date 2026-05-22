using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001E1 RID: 481
	public enum ImplicitUseKindFlags
	{
		// Token: 0x04001A1B RID: 6683
		Default = 7,
		// Token: 0x04001A1C RID: 6684
		Access = 1,
		// Token: 0x04001A1D RID: 6685
		Assign,
		// Token: 0x04001A1E RID: 6686
		InstantiatedWithFixedConstructorSignature = 4,
		// Token: 0x04001A1F RID: 6687
		InstantiatedNoFixedConstructorSignature = 8
	}
}
