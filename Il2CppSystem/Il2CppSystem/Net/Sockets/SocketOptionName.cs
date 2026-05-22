using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000151 RID: 337
	[OriginalName("System.dll", "System.Net.Sockets", "SocketOptionName")]
	public enum SocketOptionName
	{
		// Token: 0x0400112C RID: 4396
		Debug = 1,
		// Token: 0x0400112D RID: 4397
		AcceptConnection,
		// Token: 0x0400112E RID: 4398
		ReuseAddress = 4,
		// Token: 0x0400112F RID: 4399
		KeepAlive = 8,
		// Token: 0x04001130 RID: 4400
		DontRoute = 16,
		// Token: 0x04001131 RID: 4401
		Broadcast = 32,
		// Token: 0x04001132 RID: 4402
		UseLoopback = 64,
		// Token: 0x04001133 RID: 4403
		Linger = 128,
		// Token: 0x04001134 RID: 4404
		OutOfBandInline = 256,
		// Token: 0x04001135 RID: 4405
		DontLinger = -129,
		// Token: 0x04001136 RID: 4406
		ExclusiveAddressUse = -5,
		// Token: 0x04001137 RID: 4407
		SendBuffer = 4097,
		// Token: 0x04001138 RID: 4408
		ReceiveBuffer,
		// Token: 0x04001139 RID: 4409
		SendLowWater,
		// Token: 0x0400113A RID: 4410
		ReceiveLowWater,
		// Token: 0x0400113B RID: 4411
		SendTimeout,
		// Token: 0x0400113C RID: 4412
		ReceiveTimeout,
		// Token: 0x0400113D RID: 4413
		Error,
		// Token: 0x0400113E RID: 4414
		Type,
		// Token: 0x0400113F RID: 4415
		ReuseUnicastPort = 12295,
		// Token: 0x04001140 RID: 4416
		MaxConnections = 2147483647,
		// Token: 0x04001141 RID: 4417
		IPOptions = 1,
		// Token: 0x04001142 RID: 4418
		HeaderIncluded,
		// Token: 0x04001143 RID: 4419
		TypeOfService,
		// Token: 0x04001144 RID: 4420
		IpTimeToLive,
		// Token: 0x04001145 RID: 4421
		MulticastInterface = 9,
		// Token: 0x04001146 RID: 4422
		MulticastTimeToLive,
		// Token: 0x04001147 RID: 4423
		MulticastLoopback,
		// Token: 0x04001148 RID: 4424
		AddMembership,
		// Token: 0x04001149 RID: 4425
		DropMembership,
		// Token: 0x0400114A RID: 4426
		DontFragment,
		// Token: 0x0400114B RID: 4427
		AddSourceMembership,
		// Token: 0x0400114C RID: 4428
		DropSourceMembership,
		// Token: 0x0400114D RID: 4429
		BlockSource,
		// Token: 0x0400114E RID: 4430
		UnblockSource,
		// Token: 0x0400114F RID: 4431
		PacketInformation,
		// Token: 0x04001150 RID: 4432
		HopLimit = 21,
		// Token: 0x04001151 RID: 4433
		IPProtectionLevel = 23,
		// Token: 0x04001152 RID: 4434
		IPv6Only = 27,
		// Token: 0x04001153 RID: 4435
		NoDelay = 1,
		// Token: 0x04001154 RID: 4436
		BsdUrgent,
		// Token: 0x04001155 RID: 4437
		Expedited = 2,
		// Token: 0x04001156 RID: 4438
		NoChecksum = 1,
		// Token: 0x04001157 RID: 4439
		ChecksumCoverage = 20,
		// Token: 0x04001158 RID: 4440
		UpdateAcceptContext = 28683,
		// Token: 0x04001159 RID: 4441
		UpdateConnectContext = 28688
	}
}
