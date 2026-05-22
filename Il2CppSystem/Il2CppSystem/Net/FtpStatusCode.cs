using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net
{
	// Token: 0x020000E3 RID: 227
	[OriginalName("System.dll", "System.Net", "FtpStatusCode")]
	public enum FtpStatusCode
	{
		// Token: 0x0400097A RID: 2426
		Undefined,
		// Token: 0x0400097B RID: 2427
		RestartMarker = 110,
		// Token: 0x0400097C RID: 2428
		ServiceTemporarilyNotAvailable = 120,
		// Token: 0x0400097D RID: 2429
		DataAlreadyOpen = 125,
		// Token: 0x0400097E RID: 2430
		OpeningData = 150,
		// Token: 0x0400097F RID: 2431
		CommandOK = 200,
		// Token: 0x04000980 RID: 2432
		CommandExtraneous = 202,
		// Token: 0x04000981 RID: 2433
		DirectoryStatus = 212,
		// Token: 0x04000982 RID: 2434
		FileStatus,
		// Token: 0x04000983 RID: 2435
		SystemType = 215,
		// Token: 0x04000984 RID: 2436
		SendUserCommand = 220,
		// Token: 0x04000985 RID: 2437
		ClosingControl,
		// Token: 0x04000986 RID: 2438
		ClosingData = 226,
		// Token: 0x04000987 RID: 2439
		EnteringPassive,
		// Token: 0x04000988 RID: 2440
		LoggedInProceed = 230,
		// Token: 0x04000989 RID: 2441
		ServerWantsSecureSession = 234,
		// Token: 0x0400098A RID: 2442
		FileActionOK = 250,
		// Token: 0x0400098B RID: 2443
		PathnameCreated = 257,
		// Token: 0x0400098C RID: 2444
		SendPasswordCommand = 331,
		// Token: 0x0400098D RID: 2445
		NeedLoginAccount,
		// Token: 0x0400098E RID: 2446
		FileCommandPending = 350,
		// Token: 0x0400098F RID: 2447
		ServiceNotAvailable = 421,
		// Token: 0x04000990 RID: 2448
		CantOpenData = 425,
		// Token: 0x04000991 RID: 2449
		ConnectionClosed,
		// Token: 0x04000992 RID: 2450
		ActionNotTakenFileUnavailableOrBusy = 450,
		// Token: 0x04000993 RID: 2451
		ActionAbortedLocalProcessingError,
		// Token: 0x04000994 RID: 2452
		ActionNotTakenInsufficientSpace,
		// Token: 0x04000995 RID: 2453
		CommandSyntaxError = 500,
		// Token: 0x04000996 RID: 2454
		ArgumentSyntaxError,
		// Token: 0x04000997 RID: 2455
		CommandNotImplemented,
		// Token: 0x04000998 RID: 2456
		BadCommandSequence,
		// Token: 0x04000999 RID: 2457
		NotLoggedIn = 530,
		// Token: 0x0400099A RID: 2458
		AccountNeeded = 532,
		// Token: 0x0400099B RID: 2459
		ActionNotTakenFileUnavailable = 550,
		// Token: 0x0400099C RID: 2460
		ActionAbortedUnknownPageType,
		// Token: 0x0400099D RID: 2461
		FileActionAborted,
		// Token: 0x0400099E RID: 2462
		ActionNotTakenFilenameNotAllowed
	}
}
