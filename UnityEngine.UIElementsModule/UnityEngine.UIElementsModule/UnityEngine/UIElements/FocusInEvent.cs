using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CA RID: 202
	public class FocusInEvent : FocusEventBase<FocusInEvent>
	{
		// Token: 0x06000506 RID: 1286 RVA: 0x0000584C File Offset: 0x00003A4C
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00005859 File Offset: 0x00003A59
		public void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation)3;
		}
	}
}
