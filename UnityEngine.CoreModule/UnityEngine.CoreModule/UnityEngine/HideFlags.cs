using System;

namespace UnityEngine
{
	// Token: 0x020000E9 RID: 233
	[Flags]
	public enum HideFlags
	{
		// Token: 0x04000F8E RID: 3982
		None = 0,
		// Token: 0x04000F8F RID: 3983
		HideInHierarchy = 1,
		// Token: 0x04000F90 RID: 3984
		HideInInspector = 2,
		// Token: 0x04000F91 RID: 3985
		DontSaveInEditor = 4,
		// Token: 0x04000F92 RID: 3986
		NotEditable = 8,
		// Token: 0x04000F93 RID: 3987
		DontSaveInBuild = 16,
		// Token: 0x04000F94 RID: 3988
		DontUnloadUnusedAsset = 32,
		// Token: 0x04000F95 RID: 3989
		DontSave = 52,
		// Token: 0x04000F96 RID: 3990
		HideAndDontSave = 61
	}
}
