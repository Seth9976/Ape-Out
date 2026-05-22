using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x0200014E RID: 334
	[OriginalName("System.dll", "System.Net.Sockets", "SocketError")]
	public enum SocketError
	{
		// Token: 0x040010EB RID: 4331
		Success,
		// Token: 0x040010EC RID: 4332
		SocketError = -1,
		// Token: 0x040010ED RID: 4333
		Interrupted = 10004,
		// Token: 0x040010EE RID: 4334
		AccessDenied = 10013,
		// Token: 0x040010EF RID: 4335
		Fault,
		// Token: 0x040010F0 RID: 4336
		InvalidArgument = 10022,
		// Token: 0x040010F1 RID: 4337
		TooManyOpenSockets = 10024,
		// Token: 0x040010F2 RID: 4338
		WouldBlock = 10035,
		// Token: 0x040010F3 RID: 4339
		InProgress,
		// Token: 0x040010F4 RID: 4340
		AlreadyInProgress,
		// Token: 0x040010F5 RID: 4341
		NotSocket,
		// Token: 0x040010F6 RID: 4342
		DestinationAddressRequired,
		// Token: 0x040010F7 RID: 4343
		MessageSize,
		// Token: 0x040010F8 RID: 4344
		ProtocolType,
		// Token: 0x040010F9 RID: 4345
		ProtocolOption,
		// Token: 0x040010FA RID: 4346
		ProtocolNotSupported,
		// Token: 0x040010FB RID: 4347
		SocketNotSupported,
		// Token: 0x040010FC RID: 4348
		OperationNotSupported,
		// Token: 0x040010FD RID: 4349
		ProtocolFamilyNotSupported,
		// Token: 0x040010FE RID: 4350
		AddressFamilyNotSupported,
		// Token: 0x040010FF RID: 4351
		AddressAlreadyInUse,
		// Token: 0x04001100 RID: 4352
		AddressNotAvailable,
		// Token: 0x04001101 RID: 4353
		NetworkDown,
		// Token: 0x04001102 RID: 4354
		NetworkUnreachable,
		// Token: 0x04001103 RID: 4355
		NetworkReset,
		// Token: 0x04001104 RID: 4356
		ConnectionAborted,
		// Token: 0x04001105 RID: 4357
		ConnectionReset,
		// Token: 0x04001106 RID: 4358
		NoBufferSpaceAvailable,
		// Token: 0x04001107 RID: 4359
		IsConnected,
		// Token: 0x04001108 RID: 4360
		NotConnected,
		// Token: 0x04001109 RID: 4361
		Shutdown,
		// Token: 0x0400110A RID: 4362
		TimedOut = 10060,
		// Token: 0x0400110B RID: 4363
		ConnectionRefused,
		// Token: 0x0400110C RID: 4364
		HostDown = 10064,
		// Token: 0x0400110D RID: 4365
		HostUnreachable,
		// Token: 0x0400110E RID: 4366
		ProcessLimit = 10067,
		// Token: 0x0400110F RID: 4367
		SystemNotReady = 10091,
		// Token: 0x04001110 RID: 4368
		VersionNotSupported,
		// Token: 0x04001111 RID: 4369
		NotInitialized,
		// Token: 0x04001112 RID: 4370
		Disconnecting = 10101,
		// Token: 0x04001113 RID: 4371
		TypeNotFound = 10109,
		// Token: 0x04001114 RID: 4372
		HostNotFound = 11001,
		// Token: 0x04001115 RID: 4373
		TryAgain,
		// Token: 0x04001116 RID: 4374
		NoRecovery,
		// Token: 0x04001117 RID: 4375
		NoData,
		// Token: 0x04001118 RID: 4376
		IOPending = 997,
		// Token: 0x04001119 RID: 4377
		OperationAborted = 995
	}
}
