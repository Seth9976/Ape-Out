using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D1 RID: 209
	public class KeyboardEventDispatchingStrategy
	{
		// Token: 0x06000515 RID: 1301 RVA: 0x0000BC68 File Offset: 0x00009E68
		public bool CanDispatchEvent(EventBase evt)
		{
			return evt.TryCast<IKeyboardEvent>() != null;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000058F4 File Offset: 0x00003AF4
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
