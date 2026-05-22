using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E0 RID: 224
	public class MouseLeaveEvent : MouseEventBase<MouseLeaveEvent>
	{
		// Token: 0x0600053E RID: 1342 RVA: 0x00005A76 File Offset: 0x00003C76
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00005A83 File Offset: 0x00003C83
		public void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation)6;
		}
	}
}
