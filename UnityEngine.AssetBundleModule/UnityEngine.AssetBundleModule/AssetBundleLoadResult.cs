using System;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	public enum AssetBundleLoadResult
	{
		// Token: 0x04000023 RID: 35
		Success,
		// Token: 0x04000024 RID: 36
		Cancelled,
		// Token: 0x04000025 RID: 37
		NotMatchingCrc,
		// Token: 0x04000026 RID: 38
		FailedCache,
		// Token: 0x04000027 RID: 39
		NotValidAssetBundle,
		// Token: 0x04000028 RID: 40
		NoSerializedData,
		// Token: 0x04000029 RID: 41
		NotCompatible,
		// Token: 0x0400002A RID: 42
		AlreadyLoaded,
		// Token: 0x0400002B RID: 43
		FailedRead,
		// Token: 0x0400002C RID: 44
		FailedDecompression,
		// Token: 0x0400002D RID: 45
		FailedWrite,
		// Token: 0x0400002E RID: 46
		FailedDeleteRecompressionTarget,
		// Token: 0x0400002F RID: 47
		RecompressionTargetIsLoaded,
		// Token: 0x04000030 RID: 48
		RecompressionTargetExistsButNotArchive
	}
}
