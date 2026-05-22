using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000243 RID: 579
	[OriginalName("mscorlib.dll", "System.Globalization", "NumberStyles")]
	[Flags]
	[Serializable]
	public enum NumberStyles
	{
		// Token: 0x0400232F RID: 9007
		None = 0,
		// Token: 0x04002330 RID: 9008
		AllowLeadingWhite = 1,
		// Token: 0x04002331 RID: 9009
		AllowTrailingWhite = 2,
		// Token: 0x04002332 RID: 9010
		AllowLeadingSign = 4,
		// Token: 0x04002333 RID: 9011
		AllowTrailingSign = 8,
		// Token: 0x04002334 RID: 9012
		AllowParentheses = 16,
		// Token: 0x04002335 RID: 9013
		AllowDecimalPoint = 32,
		// Token: 0x04002336 RID: 9014
		AllowThousands = 64,
		// Token: 0x04002337 RID: 9015
		AllowExponent = 128,
		// Token: 0x04002338 RID: 9016
		AllowCurrencySymbol = 256,
		// Token: 0x04002339 RID: 9017
		AllowHexSpecifier = 512,
		// Token: 0x0400233A RID: 9018
		Integer = 7,
		// Token: 0x0400233B RID: 9019
		HexNumber = 515,
		// Token: 0x0400233C RID: 9020
		Number = 111,
		// Token: 0x0400233D RID: 9021
		Float = 167,
		// Token: 0x0400233E RID: 9022
		Currency = 383,
		// Token: 0x0400233F RID: 9023
		Any = 511
	}
}
