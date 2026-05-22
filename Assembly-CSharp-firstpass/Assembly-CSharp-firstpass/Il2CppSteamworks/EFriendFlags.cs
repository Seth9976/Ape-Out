using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSteamworks
{
	// Token: 0x020000E3 RID: 227
	[OriginalName("Assembly-CSharp-firstpass.dll", "Steamworks", "EFriendFlags")]
	[Flags]
	public enum EFriendFlags
	{
		// Token: 0x0400096E RID: 2414
		k_EFriendFlagNone = 0,
		// Token: 0x0400096F RID: 2415
		k_EFriendFlagBlocked = 1,
		// Token: 0x04000970 RID: 2416
		k_EFriendFlagFriendshipRequested = 2,
		// Token: 0x04000971 RID: 2417
		k_EFriendFlagImmediate = 4,
		// Token: 0x04000972 RID: 2418
		k_EFriendFlagClanMember = 8,
		// Token: 0x04000973 RID: 2419
		k_EFriendFlagOnGameServer = 16,
		// Token: 0x04000974 RID: 2420
		k_EFriendFlagRequestingFriendship = 128,
		// Token: 0x04000975 RID: 2421
		k_EFriendFlagRequestingInfo = 256,
		// Token: 0x04000976 RID: 2422
		k_EFriendFlagIgnored = 512,
		// Token: 0x04000977 RID: 2423
		k_EFriendFlagIgnoredFriend = 1024,
		// Token: 0x04000978 RID: 2424
		k_EFriendFlagChatMember = 4096,
		// Token: 0x04000979 RID: 2425
		k_EFriendFlagAll = 65535
	}
}
