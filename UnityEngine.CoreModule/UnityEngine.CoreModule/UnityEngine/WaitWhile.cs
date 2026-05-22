using System;

namespace UnityEngine
{
	// Token: 0x02000259 RID: 601
	public sealed class WaitWhile : CustomYieldInstruction
	{
		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060021C8 RID: 8648 RVA: 0x00011F7A File Offset: 0x0001017A
		public override bool keepWaiting
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
