using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A5 RID: 421
	[OriginalName("mscorlib.dll", "System.Reflection", "GenericParameterAttributes")]
	[Flags]
	public enum GenericParameterAttributes
	{
		// Token: 0x04001987 RID: 6535
		None = 0,
		// Token: 0x04001988 RID: 6536
		VarianceMask = 3,
		// Token: 0x04001989 RID: 6537
		Covariant = 1,
		// Token: 0x0400198A RID: 6538
		Contravariant = 2,
		// Token: 0x0400198B RID: 6539
		SpecialConstraintMask = 28,
		// Token: 0x0400198C RID: 6540
		ReferenceTypeConstraint = 4,
		// Token: 0x0400198D RID: 6541
		NotNullableValueTypeConstraint = 8,
		// Token: 0x0400198E RID: 6542
		DefaultConstructorConstraint = 16
	}
}
