using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001AC RID: 428
	[OriginalName("mscorlib.dll", "System.Reflection", "PInvokeAttributes")]
	[Flags]
	[Serializable]
	public enum PInvokeAttributes
	{
		// Token: 0x040019A3 RID: 6563
		NoMangle = 1,
		// Token: 0x040019A4 RID: 6564
		CharSetMask = 6,
		// Token: 0x040019A5 RID: 6565
		CharSetNotSpec = 0,
		// Token: 0x040019A6 RID: 6566
		CharSetAnsi = 2,
		// Token: 0x040019A7 RID: 6567
		CharSetUnicode = 4,
		// Token: 0x040019A8 RID: 6568
		CharSetAuto = 6,
		// Token: 0x040019A9 RID: 6569
		BestFitUseAssem = 0,
		// Token: 0x040019AA RID: 6570
		BestFitEnabled = 16,
		// Token: 0x040019AB RID: 6571
		BestFitDisabled = 32,
		// Token: 0x040019AC RID: 6572
		BestFitMask = 48,
		// Token: 0x040019AD RID: 6573
		ThrowOnUnmappableCharUseAssem = 0,
		// Token: 0x040019AE RID: 6574
		ThrowOnUnmappableCharEnabled = 4096,
		// Token: 0x040019AF RID: 6575
		ThrowOnUnmappableCharDisabled = 8192,
		// Token: 0x040019B0 RID: 6576
		ThrowOnUnmappableCharMask = 12288,
		// Token: 0x040019B1 RID: 6577
		SupportsLastError = 64,
		// Token: 0x040019B2 RID: 6578
		CallConvMask = 1792,
		// Token: 0x040019B3 RID: 6579
		CallConvWinapi = 256,
		// Token: 0x040019B4 RID: 6580
		CallConvCdecl = 512,
		// Token: 0x040019B5 RID: 6581
		CallConvStdcall = 768,
		// Token: 0x040019B6 RID: 6582
		CallConvThiscall = 1024,
		// Token: 0x040019B7 RID: 6583
		CallConvFastcall = 1280,
		// Token: 0x040019B8 RID: 6584
		MaxValue = 65535
	}
}
