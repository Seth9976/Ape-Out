using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net
{
	// Token: 0x020000FA RID: 250
	[OriginalName("System.dll", "System.Net", "WebExceptionStatus")]
	public enum WebExceptionStatus
	{
		// Token: 0x04000A93 RID: 2707
		Success,
		// Token: 0x04000A94 RID: 2708
		NameResolutionFailure,
		// Token: 0x04000A95 RID: 2709
		ConnectFailure,
		// Token: 0x04000A96 RID: 2710
		ReceiveFailure,
		// Token: 0x04000A97 RID: 2711
		SendFailure,
		// Token: 0x04000A98 RID: 2712
		PipelineFailure,
		// Token: 0x04000A99 RID: 2713
		RequestCanceled,
		// Token: 0x04000A9A RID: 2714
		ProtocolError,
		// Token: 0x04000A9B RID: 2715
		ConnectionClosed,
		// Token: 0x04000A9C RID: 2716
		TrustFailure,
		// Token: 0x04000A9D RID: 2717
		SecureChannelFailure,
		// Token: 0x04000A9E RID: 2718
		ServerProtocolViolation,
		// Token: 0x04000A9F RID: 2719
		KeepAliveFailure,
		// Token: 0x04000AA0 RID: 2720
		Pending,
		// Token: 0x04000AA1 RID: 2721
		Timeout,
		// Token: 0x04000AA2 RID: 2722
		ProxyNameResolutionFailure,
		// Token: 0x04000AA3 RID: 2723
		UnknownError,
		// Token: 0x04000AA4 RID: 2724
		MessageLengthLimitExceeded,
		// Token: 0x04000AA5 RID: 2725
		CacheEntryNotFound,
		// Token: 0x04000AA6 RID: 2726
		RequestProhibitedByCachePolicy,
		// Token: 0x04000AA7 RID: 2727
		RequestProhibitedByProxy
	}
}
