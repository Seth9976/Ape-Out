using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D6 RID: 214
	public class MouseCaptureDispatchingStrategy
	{
		// Token: 0x06000521 RID: 1313 RVA: 0x0000BC84 File Offset: 0x00009E84
		public bool CanDispatchEvent(EventBase evt)
		{
			return evt.TryCast<IMouseEvent>() != null || evt.imguiEvent != null;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00005999 File Offset: 0x00003B99
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020001F4 RID: 500
		public enum EventBehavior
		{
			// Token: 0x04000258 RID: 600
			None,
			// Token: 0x04000259 RID: 601
			IsCapturable,
			// Token: 0x0400025A RID: 602
			IsSentExclusivelyToCapturingElement
		}
	}
}
