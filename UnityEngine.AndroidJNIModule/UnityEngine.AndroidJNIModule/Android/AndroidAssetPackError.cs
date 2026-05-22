using System;

namespace UnityEngine.Android
{
	// Token: 0x02000011 RID: 17
	public enum AndroidAssetPackError
	{
		// Token: 0x04000173 RID: 371
		NoError,
		// Token: 0x04000174 RID: 372
		AppUnavailable = -1,
		// Token: 0x04000175 RID: 373
		PackUnavailable = -2,
		// Token: 0x04000176 RID: 374
		InvalidRequest = -3,
		// Token: 0x04000177 RID: 375
		DownloadNotFound = -4,
		// Token: 0x04000178 RID: 376
		ApiNotAvailable = -5,
		// Token: 0x04000179 RID: 377
		NetworkError = -6,
		// Token: 0x0400017A RID: 378
		AccessDenied = -7,
		// Token: 0x0400017B RID: 379
		InsufficientStorage = -10,
		// Token: 0x0400017C RID: 380
		PlayStoreNotFound = -11,
		// Token: 0x0400017D RID: 381
		NetworkUnrestricted = -12,
		// Token: 0x0400017E RID: 382
		AppNotOwned = -13,
		// Token: 0x0400017F RID: 383
		InternalError = -100
	}
}
