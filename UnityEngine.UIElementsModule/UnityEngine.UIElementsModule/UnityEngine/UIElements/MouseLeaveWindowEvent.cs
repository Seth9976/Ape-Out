using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E2 RID: 226
	public class MouseLeaveWindowEvent : MouseEventBase<MouseLeaveWindowEvent>
	{
		// Token: 0x06000543 RID: 1347 RVA: 0x00005AB3 File Offset: 0x00003CB3
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00005AC0 File Offset: 0x00003CC0
		public void LocalInit()
		{
			base.propagation = EventBase.EventPropagation.Cancellable;
			this.recomputeTopElementUnderMouse = false;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00005AD3 File Offset: 0x00003CD3
		public static MouseLeaveWindowEvent GetPooled(Event systemEvent)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00005AE0 File Offset: 0x00003CE0
		public override void PostDispatch(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
