using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C8 RID: 200
	public class FocusOutEvent : FocusEventBase<FocusOutEvent>
	{
		// Token: 0x06000503 RID: 1283 RVA: 0x00005827 File Offset: 0x00003A27
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00005834 File Offset: 0x00003A34
		public void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation)3;
		}
	}
}
