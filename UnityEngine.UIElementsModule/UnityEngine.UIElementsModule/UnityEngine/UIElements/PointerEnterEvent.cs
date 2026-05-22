using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F8 RID: 248
	public sealed class PointerEnterEvent : PointerEventBase<PointerEnterEvent>
	{
		// Token: 0x06000574 RID: 1396 RVA: 0x00005D00 File Offset: 0x00003F00
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00005D0D File Offset: 0x00003F0D
		public void LocalInit()
		{
			base.propagation = EventBase.EventPropagation.TricklesDown;
		}
	}
}
