using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F6 RID: 246
	public sealed class PointerCancelEvent : PointerEventBase<PointerCancelEvent>
	{
		// Token: 0x06000570 RID: 1392 RVA: 0x00005CC6 File Offset: 0x00003EC6
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00005CD3 File Offset: 0x00003ED3
		public void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation)3;
			this.recomputeTopElementUnderPointer = true;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00005CE6 File Offset: 0x00003EE6
		public override void PostDispatch(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
