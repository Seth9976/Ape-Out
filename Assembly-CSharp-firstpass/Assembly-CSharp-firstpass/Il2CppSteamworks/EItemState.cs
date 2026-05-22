using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSteamworks
{
	// Token: 0x02000104 RID: 260
	[OriginalName("Assembly-CSharp-firstpass.dll", "Steamworks", "EItemState")]
	[Flags]
	public enum EItemState
	{
		// Token: 0x04000A95 RID: 2709
		k_EItemStateNone = 0,
		// Token: 0x04000A96 RID: 2710
		k_EItemStateSubscribed = 1,
		// Token: 0x04000A97 RID: 2711
		k_EItemStateLegacyItem = 2,
		// Token: 0x04000A98 RID: 2712
		k_EItemStateInstalled = 4,
		// Token: 0x04000A99 RID: 2713
		k_EItemStateNeedsUpdate = 8,
		// Token: 0x04000A9A RID: 2714
		k_EItemStateDownloading = 16,
		// Token: 0x04000A9B RID: 2715
		k_EItemStateDownloadPending = 32
	}
}
