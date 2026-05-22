using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000DF RID: 223
	public class MouseEnterEvent : MouseEventBase<MouseEnterEvent>
	{
		// Token: 0x0600053C RID: 1340 RVA: 0x00005A5E File Offset: 0x00003C5E
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00005A6B File Offset: 0x00003C6B
		public void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation)6;
		}
	}
}
