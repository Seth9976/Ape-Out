using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSteamworks
{
	// Token: 0x02000116 RID: 278
	[OriginalName("Assembly-CSharp-firstpass.dll", "Steamworks", "EAuthSessionResponse")]
	public enum EAuthSessionResponse
	{
		// Token: 0x04000B75 RID: 2933
		k_EAuthSessionResponseOK,
		// Token: 0x04000B76 RID: 2934
		k_EAuthSessionResponseUserNotConnectedToSteam,
		// Token: 0x04000B77 RID: 2935
		k_EAuthSessionResponseNoLicenseOrExpired,
		// Token: 0x04000B78 RID: 2936
		k_EAuthSessionResponseVACBanned,
		// Token: 0x04000B79 RID: 2937
		k_EAuthSessionResponseLoggedInElseWhere,
		// Token: 0x04000B7A RID: 2938
		k_EAuthSessionResponseVACCheckTimedOut,
		// Token: 0x04000B7B RID: 2939
		k_EAuthSessionResponseAuthTicketCanceled,
		// Token: 0x04000B7C RID: 2940
		k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed,
		// Token: 0x04000B7D RID: 2941
		k_EAuthSessionResponseAuthTicketInvalid,
		// Token: 0x04000B7E RID: 2942
		k_EAuthSessionResponsePublisherIssuedBan
	}
}
