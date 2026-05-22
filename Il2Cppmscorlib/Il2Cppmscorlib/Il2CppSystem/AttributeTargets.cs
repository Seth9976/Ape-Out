using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x0200007E RID: 126
	[OriginalName("mscorlib.dll", "System", "AttributeTargets")]
	[Flags]
	[Serializable]
	public enum AttributeTargets
	{
		// Token: 0x04000576 RID: 1398
		Assembly = 1,
		// Token: 0x04000577 RID: 1399
		Module = 2,
		// Token: 0x04000578 RID: 1400
		Class = 4,
		// Token: 0x04000579 RID: 1401
		Struct = 8,
		// Token: 0x0400057A RID: 1402
		Enum = 16,
		// Token: 0x0400057B RID: 1403
		Constructor = 32,
		// Token: 0x0400057C RID: 1404
		Method = 64,
		// Token: 0x0400057D RID: 1405
		Property = 128,
		// Token: 0x0400057E RID: 1406
		Field = 256,
		// Token: 0x0400057F RID: 1407
		Event = 512,
		// Token: 0x04000580 RID: 1408
		Interface = 1024,
		// Token: 0x04000581 RID: 1409
		Parameter = 2048,
		// Token: 0x04000582 RID: 1410
		Delegate = 4096,
		// Token: 0x04000583 RID: 1411
		ReturnValue = 8192,
		// Token: 0x04000584 RID: 1412
		GenericParameter = 16384,
		// Token: 0x04000585 RID: 1413
		All = 32767
	}
}
