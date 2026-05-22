using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BA RID: 186
	public class DragLeaveEvent : DragAndDropEventBase<DragLeaveEvent>
	{
		// Token: 0x06000494 RID: 1172 RVA: 0x0000542E File Offset: 0x0000362E
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0000543B File Offset: 0x0000363B
		public void LocalInit()
		{
			base.propagation = EventBase.EventPropagation.TricklesDown;
		}
	}
}
