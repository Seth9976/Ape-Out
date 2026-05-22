using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSteamworks
{
	// Token: 0x020000F3 RID: 243
	[OriginalName("Assembly-CSharp-firstpass.dll", "Steamworks", "ESNetSocketState")]
	public enum ESNetSocketState
	{
		// Token: 0x040009FD RID: 2557
		k_ESNetSocketStateInvalid,
		// Token: 0x040009FE RID: 2558
		k_ESNetSocketStateConnected,
		// Token: 0x040009FF RID: 2559
		k_ESNetSocketStateInitiated = 10,
		// Token: 0x04000A00 RID: 2560
		k_ESNetSocketStateLocalCandidatesFound,
		// Token: 0x04000A01 RID: 2561
		k_ESNetSocketStateReceivedRemoteCandidates,
		// Token: 0x04000A02 RID: 2562
		k_ESNetSocketStateChallengeHandshake = 15,
		// Token: 0x04000A03 RID: 2563
		k_ESNetSocketStateDisconnecting = 21,
		// Token: 0x04000A04 RID: 2564
		k_ESNetSocketStateLocalDisconnect,
		// Token: 0x04000A05 RID: 2565
		k_ESNetSocketStateTimeoutDuringConnect,
		// Token: 0x04000A06 RID: 2566
		k_ESNetSocketStateRemoteEndDisconnected,
		// Token: 0x04000A07 RID: 2567
		k_ESNetSocketStateConnectionBroken
	}
}
