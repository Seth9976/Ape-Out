using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000149 RID: 329
	[OriginalName("System.dll", "System.Net.Sockets", "ProtocolType")]
	public enum ProtocolType
	{
		// Token: 0x04001012 RID: 4114
		IP,
		// Token: 0x04001013 RID: 4115
		IPv6HopByHopOptions = 0,
		// Token: 0x04001014 RID: 4116
		Icmp,
		// Token: 0x04001015 RID: 4117
		Igmp,
		// Token: 0x04001016 RID: 4118
		Ggp,
		// Token: 0x04001017 RID: 4119
		IPv4,
		// Token: 0x04001018 RID: 4120
		Tcp = 6,
		// Token: 0x04001019 RID: 4121
		Pup = 12,
		// Token: 0x0400101A RID: 4122
		Udp = 17,
		// Token: 0x0400101B RID: 4123
		Idp = 22,
		// Token: 0x0400101C RID: 4124
		IPv6 = 41,
		// Token: 0x0400101D RID: 4125
		IPv6RoutingHeader = 43,
		// Token: 0x0400101E RID: 4126
		IPv6FragmentHeader,
		// Token: 0x0400101F RID: 4127
		IPSecEncapsulatingSecurityPayload = 50,
		// Token: 0x04001020 RID: 4128
		IPSecAuthenticationHeader,
		// Token: 0x04001021 RID: 4129
		IcmpV6 = 58,
		// Token: 0x04001022 RID: 4130
		IPv6NoNextHeader,
		// Token: 0x04001023 RID: 4131
		IPv6DestinationOptions,
		// Token: 0x04001024 RID: 4132
		ND = 77,
		// Token: 0x04001025 RID: 4133
		Raw = 255,
		// Token: 0x04001026 RID: 4134
		Unspecified = 0,
		// Token: 0x04001027 RID: 4135
		Ipx = 1000,
		// Token: 0x04001028 RID: 4136
		Spx = 1256,
		// Token: 0x04001029 RID: 4137
		SpxII,
		// Token: 0x0400102A RID: 4138
		Unknown = -1
	}
}
