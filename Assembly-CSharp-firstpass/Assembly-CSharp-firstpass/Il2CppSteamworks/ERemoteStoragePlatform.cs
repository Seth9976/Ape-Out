using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSteamworks
{
	// Token: 0x020000F6 RID: 246
	[OriginalName("Assembly-CSharp-firstpass.dll", "Steamworks", "ERemoteStoragePlatform")]
	[Flags]
	public enum ERemoteStoragePlatform
	{
		// Token: 0x04000A1C RID: 2588
		k_ERemoteStoragePlatformNone = 0,
		// Token: 0x04000A1D RID: 2589
		k_ERemoteStoragePlatformWindows = 1,
		// Token: 0x04000A1E RID: 2590
		k_ERemoteStoragePlatformOSX = 2,
		// Token: 0x04000A1F RID: 2591
		k_ERemoteStoragePlatformPS3 = 4,
		// Token: 0x04000A20 RID: 2592
		k_ERemoteStoragePlatformLinux = 8,
		// Token: 0x04000A21 RID: 2593
		k_ERemoteStoragePlatformReserved2 = 16,
		// Token: 0x04000A22 RID: 2594
		k_ERemoteStoragePlatformAll = -1
	}
}
