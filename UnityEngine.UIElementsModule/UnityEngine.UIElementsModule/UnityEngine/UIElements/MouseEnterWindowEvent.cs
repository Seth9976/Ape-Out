using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E1 RID: 225
	public class MouseEnterWindowEvent : MouseEventBase<MouseEnterWindowEvent>
	{
		// Token: 0x06000540 RID: 1344 RVA: 0x00005A8E File Offset: 0x00003C8E
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00005A9B File Offset: 0x00003C9B
		public void LocalInit()
		{
			base.propagation = EventBase.EventPropagation.Cancellable;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00005AA6 File Offset: 0x00003CA6
		public override void PostDispatch(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
