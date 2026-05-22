using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B9 RID: 185
	public class DragEnterEvent : DragAndDropEventBase<DragEnterEvent>
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x00005416 File Offset: 0x00003616
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00005423 File Offset: 0x00003623
		public void LocalInit()
		{
			base.propagation = EventBase.EventPropagation.TricklesDown;
		}
	}
}
