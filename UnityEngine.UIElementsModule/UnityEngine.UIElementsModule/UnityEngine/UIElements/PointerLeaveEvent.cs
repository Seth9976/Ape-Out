using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F9 RID: 249
	public sealed class PointerLeaveEvent : PointerEventBase<PointerLeaveEvent>
	{
		// Token: 0x06000576 RID: 1398 RVA: 0x00005D18 File Offset: 0x00003F18
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00005D25 File Offset: 0x00003F25
		public void LocalInit()
		{
			base.propagation = EventBase.EventPropagation.TricklesDown;
		}
	}
}
