using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200044C RID: 1100
	[OriginalName("mscorlib.dll", "System.Runtime.InteropServices", "DllImportSearchPath")]
	[Flags]
	public enum DllImportSearchPath
	{
		// Token: 0x04003757 RID: 14167
		UseDllDirectoryForDependencies = 256,
		// Token: 0x04003758 RID: 14168
		ApplicationDirectory = 512,
		// Token: 0x04003759 RID: 14169
		UserDirectories = 1024,
		// Token: 0x0400375A RID: 14170
		System32 = 2048,
		// Token: 0x0400375B RID: 14171
		SafeDirectories = 4096,
		// Token: 0x0400375C RID: 14172
		AssemblyDirectory = 2,
		// Token: 0x0400375D RID: 14173
		LegacyBehavior = 0
	}
}
