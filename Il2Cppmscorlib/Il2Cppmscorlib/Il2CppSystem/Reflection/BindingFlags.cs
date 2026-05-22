using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A0 RID: 416
	[OriginalName("mscorlib.dll", "System.Reflection", "BindingFlags")]
	[Flags]
	[Serializable]
	public enum BindingFlags
	{
		// Token: 0x04001950 RID: 6480
		Default = 0,
		// Token: 0x04001951 RID: 6481
		IgnoreCase = 1,
		// Token: 0x04001952 RID: 6482
		DeclaredOnly = 2,
		// Token: 0x04001953 RID: 6483
		Instance = 4,
		// Token: 0x04001954 RID: 6484
		Static = 8,
		// Token: 0x04001955 RID: 6485
		Public = 16,
		// Token: 0x04001956 RID: 6486
		NonPublic = 32,
		// Token: 0x04001957 RID: 6487
		FlattenHierarchy = 64,
		// Token: 0x04001958 RID: 6488
		InvokeMethod = 256,
		// Token: 0x04001959 RID: 6489
		CreateInstance = 512,
		// Token: 0x0400195A RID: 6490
		GetField = 1024,
		// Token: 0x0400195B RID: 6491
		SetField = 2048,
		// Token: 0x0400195C RID: 6492
		GetProperty = 4096,
		// Token: 0x0400195D RID: 6493
		SetProperty = 8192,
		// Token: 0x0400195E RID: 6494
		PutDispProperty = 16384,
		// Token: 0x0400195F RID: 6495
		PutRefDispProperty = 32768,
		// Token: 0x04001960 RID: 6496
		ExactBinding = 65536,
		// Token: 0x04001961 RID: 6497
		SuppressChangeType = 131072,
		// Token: 0x04001962 RID: 6498
		OptionalParamBinding = 262144,
		// Token: 0x04001963 RID: 6499
		IgnoreReturn = 16777216
	}
}
