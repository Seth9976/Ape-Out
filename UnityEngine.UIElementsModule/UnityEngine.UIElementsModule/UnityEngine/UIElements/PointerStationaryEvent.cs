using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F4 RID: 244
	public sealed class PointerStationaryEvent : PointerEventBase<PointerStationaryEvent>
	{
		// Token: 0x0600056B RID: 1387 RVA: 0x00005C89 File Offset: 0x00003E89
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00005C96 File Offset: 0x00003E96
		public void LocalInit()
		{
			this.recomputeTopElementUnderPointer = true;
		}
	}
}
