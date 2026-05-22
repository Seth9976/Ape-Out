using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSteamworks
{
	// Token: 0x020000E4 RID: 228
	[OriginalName("Assembly-CSharp-firstpass.dll", "Steamworks", "EUserRestriction")]
	public enum EUserRestriction
	{
		// Token: 0x0400097B RID: 2427
		k_nUserRestrictionNone,
		// Token: 0x0400097C RID: 2428
		k_nUserRestrictionUnknown,
		// Token: 0x0400097D RID: 2429
		k_nUserRestrictionAnyChat,
		// Token: 0x0400097E RID: 2430
		k_nUserRestrictionVoiceChat = 4,
		// Token: 0x0400097F RID: 2431
		k_nUserRestrictionGroupChat = 8,
		// Token: 0x04000980 RID: 2432
		k_nUserRestrictionRating = 16,
		// Token: 0x04000981 RID: 2433
		k_nUserRestrictionGameInvites = 32,
		// Token: 0x04000982 RID: 2434
		k_nUserRestrictionTrading = 64
	}
}
