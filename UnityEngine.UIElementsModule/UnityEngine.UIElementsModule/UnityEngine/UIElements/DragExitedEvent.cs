using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B8 RID: 184
	public class DragExitedEvent : DragAndDropEventBase<DragExitedEvent>
	{
		// Token: 0x0600048E RID: 1166 RVA: 0x000053E4 File Offset: 0x000035E4
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000053F1 File Offset: 0x000035F1
		public void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation)3;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000053FC File Offset: 0x000035FC
		public static DragExitedEvent GetPooled(Event systemEvent)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00005409 File Offset: 0x00003609
		public override void PostDispatch(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
