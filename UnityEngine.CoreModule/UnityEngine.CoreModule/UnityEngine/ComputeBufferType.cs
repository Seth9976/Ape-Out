using System;

namespace UnityEngine
{
	// Token: 0x02000079 RID: 121
	[Flags]
	public enum ComputeBufferType
	{
		// Token: 0x0400076B RID: 1899
		Default = 0,
		// Token: 0x0400076C RID: 1900
		Raw = 1,
		// Token: 0x0400076D RID: 1901
		Append = 2,
		// Token: 0x0400076E RID: 1902
		Counter = 4,
		// Token: 0x0400076F RID: 1903
		Constant = 8,
		// Token: 0x04000770 RID: 1904
		Structured = 16,
		// Token: 0x04000771 RID: 1905
		DrawIndirect = 256,
		// Token: 0x04000772 RID: 1906
		IndirectArguments = 256,
		// Token: 0x04000773 RID: 1907
		GPUMemory = 512
	}
}
