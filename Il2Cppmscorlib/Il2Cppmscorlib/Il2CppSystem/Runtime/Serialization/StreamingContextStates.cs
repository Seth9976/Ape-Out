using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200034E RID: 846
	[OriginalName("mscorlib.dll", "System.Runtime.Serialization", "StreamingContextStates")]
	[Flags]
	[Serializable]
	public enum StreamingContextStates
	{
		// Token: 0x04002E84 RID: 11908
		CrossProcess = 1,
		// Token: 0x04002E85 RID: 11909
		CrossMachine = 2,
		// Token: 0x04002E86 RID: 11910
		File = 4,
		// Token: 0x04002E87 RID: 11911
		Persistence = 8,
		// Token: 0x04002E88 RID: 11912
		Remoting = 16,
		// Token: 0x04002E89 RID: 11913
		Other = 32,
		// Token: 0x04002E8A RID: 11914
		Clone = 64,
		// Token: 0x04002E8B RID: 11915
		CrossAppDomain = 128,
		// Token: 0x04002E8C RID: 11916
		All = 255
	}
}
