using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000143 RID: 323
	[OriginalName("System.dll", "System.Net.Sockets", "IOControlCode")]
	public enum IOControlCode : long
	{
		// Token: 0x04000FC1 RID: 4033
		AsyncIO = 2147772029L,
		// Token: 0x04000FC2 RID: 4034
		NonBlockingIO,
		// Token: 0x04000FC3 RID: 4035
		DataToRead = 1074030207L,
		// Token: 0x04000FC4 RID: 4036
		OobDataRead = 1074033415L,
		// Token: 0x04000FC5 RID: 4037
		AssociateHandle = 2281701377L,
		// Token: 0x04000FC6 RID: 4038
		EnableCircularQueuing = 671088642L,
		// Token: 0x04000FC7 RID: 4039
		Flush = 671088644L,
		// Token: 0x04000FC8 RID: 4040
		GetBroadcastAddress = 1207959557L,
		// Token: 0x04000FC9 RID: 4041
		GetExtensionFunctionPointer = 3355443206L,
		// Token: 0x04000FCA RID: 4042
		GetQos,
		// Token: 0x04000FCB RID: 4043
		GetGroupQos,
		// Token: 0x04000FCC RID: 4044
		MultipointLoopback = 2281701385L,
		// Token: 0x04000FCD RID: 4045
		MulticastScope,
		// Token: 0x04000FCE RID: 4046
		SetQos,
		// Token: 0x04000FCF RID: 4047
		SetGroupQos,
		// Token: 0x04000FD0 RID: 4048
		TranslateHandle = 3355443213L,
		// Token: 0x04000FD1 RID: 4049
		RoutingInterfaceQuery = 3355443220L,
		// Token: 0x04000FD2 RID: 4050
		RoutingInterfaceChange = 2281701397L,
		// Token: 0x04000FD3 RID: 4051
		AddressListQuery = 1207959574L,
		// Token: 0x04000FD4 RID: 4052
		AddressListChange = 671088663L,
		// Token: 0x04000FD5 RID: 4053
		QueryTargetPnpHandle = 1207959576L,
		// Token: 0x04000FD6 RID: 4054
		NamespaceChange = 2281701401L,
		// Token: 0x04000FD7 RID: 4055
		AddressListSort = 3355443225L,
		// Token: 0x04000FD8 RID: 4056
		ReceiveAll = 2550136833L,
		// Token: 0x04000FD9 RID: 4057
		ReceiveAllMulticast,
		// Token: 0x04000FDA RID: 4058
		ReceiveAllIgmpMulticast,
		// Token: 0x04000FDB RID: 4059
		KeepAliveValues,
		// Token: 0x04000FDC RID: 4060
		AbsorbRouterAlert,
		// Token: 0x04000FDD RID: 4061
		UnicastInterface,
		// Token: 0x04000FDE RID: 4062
		LimitBroadcasts,
		// Token: 0x04000FDF RID: 4063
		BindToInterface,
		// Token: 0x04000FE0 RID: 4064
		MulticastInterface,
		// Token: 0x04000FE1 RID: 4065
		AddMulticastGroupOnInterface,
		// Token: 0x04000FE2 RID: 4066
		DeleteMulticastGroupFromInterface
	}
}
