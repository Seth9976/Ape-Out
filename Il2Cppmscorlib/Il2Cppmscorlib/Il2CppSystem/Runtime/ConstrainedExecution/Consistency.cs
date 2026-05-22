using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.ConstrainedExecution
{
	// Token: 0x02000410 RID: 1040
	[OriginalName("mscorlib.dll", "System.Runtime.ConstrainedExecution", "Consistency")]
	[Serializable]
	public enum Consistency
	{
		// Token: 0x04003638 RID: 13880
		MayCorruptProcess,
		// Token: 0x04003639 RID: 13881
		MayCorruptAppDomain,
		// Token: 0x0400363A RID: 13882
		MayCorruptInstance,
		// Token: 0x0400363B RID: 13883
		WillNotCorruptState
	}
}
