using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000154 RID: 340
	[OriginalName("System.dll", "System.Net.Sockets", "TransmitFileOptions")]
	[Flags]
	public enum TransmitFileOptions
	{
		// Token: 0x04001166 RID: 4454
		UseDefaultWorkerThread = 0,
		// Token: 0x04001167 RID: 4455
		Disconnect = 1,
		// Token: 0x04001168 RID: 4456
		ReuseSocket = 2,
		// Token: 0x04001169 RID: 4457
		WriteBehind = 4,
		// Token: 0x0400116A RID: 4458
		UseSystemThread = 16,
		// Token: 0x0400116B RID: 4459
		UseKernelApc = 32
	}
}
