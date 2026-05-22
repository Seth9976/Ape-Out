using System;
using Unity.Baselib.LowLevel;

namespace Unity.Baselib
{
	// Token: 0x020001B9 RID: 441
	public class BaselibException : Exception
	{
		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x000106C3 File Offset: 0x0000E8C3
		public Unity.Baselib.LowLevel.Binding.Baselib_ErrorCode ErrorCode
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
