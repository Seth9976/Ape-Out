using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSteamworks
{
	// Token: 0x020000EF RID: 239
	[OriginalName("Assembly-CSharp-firstpass.dll", "Steamworks", "EChatMemberStateChange")]
	[Flags]
	public enum EChatMemberStateChange
	{
		// Token: 0x040009E6 RID: 2534
		k_EChatMemberStateChangeEntered = 1,
		// Token: 0x040009E7 RID: 2535
		k_EChatMemberStateChangeLeft = 2,
		// Token: 0x040009E8 RID: 2536
		k_EChatMemberStateChangeDisconnected = 4,
		// Token: 0x040009E9 RID: 2537
		k_EChatMemberStateChangeKicked = 8,
		// Token: 0x040009EA RID: 2538
		k_EChatMemberStateChangeBanned = 16
	}
}
