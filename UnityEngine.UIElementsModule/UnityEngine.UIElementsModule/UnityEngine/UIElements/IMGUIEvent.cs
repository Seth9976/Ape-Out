using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000FF RID: 255
	public class IMGUIEvent : EventBase<IMGUIEvent>
	{
		// Token: 0x06000583 RID: 1411 RVA: 0x00005DA5 File Offset: 0x00003FA5
		public static IMGUIEvent GetPooled(Event systemEvent)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00005DB2 File Offset: 0x00003FB2
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00005DBF File Offset: 0x00003FBF
		public void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation)7;
		}
	}
}
