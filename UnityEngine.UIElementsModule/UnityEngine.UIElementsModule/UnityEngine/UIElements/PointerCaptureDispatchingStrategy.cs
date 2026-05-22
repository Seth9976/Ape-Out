using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000EB RID: 235
	public class PointerCaptureDispatchingStrategy
	{
		// Token: 0x06000553 RID: 1363 RVA: 0x0000BE80 File Offset: 0x0000A080
		public bool CanDispatchEvent(EventBase evt)
		{
			return evt.TryCast<IPointerEvent>() != null;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00005B89 File Offset: 0x00003D89
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
