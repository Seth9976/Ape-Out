using System;
using System.Runtime.InteropServices;
using Unity.Baselib.LowLevel;

namespace Unity.Baselib
{
	// Token: 0x020001B8 RID: 440
	public struct ErrorState
	{
		// Token: 0x06001FAD RID: 8109 RVA: 0x00073B90 File Offset: 0x00071D90
		public void ThrowIfFailed()
		{
			bool flag = this.ErrorCode > Unity.Baselib.LowLevel.Binding.Baselib_ErrorCode.Success;
			if (flag)
			{
				throw new BaselibException(this);
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001FAE RID: 8110 RVA: 0x000106A9 File Offset: 0x0000E8A9
		public Unity.Baselib.LowLevel.Binding.Baselib_ErrorCode ErrorCode
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x000106B6 File Offset: 0x0000E8B6
		public string Explain([Optional] Unity.Baselib.LowLevel.Binding.Baselib_ErrorState_ExplainVerbosity verbosity)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
