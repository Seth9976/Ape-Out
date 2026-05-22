using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B5 RID: 181
	public class DebuggerEventDispatchingStrategy
	{
		// Token: 0x06000489 RID: 1161 RVA: 0x0000B4E4 File Offset: 0x000096E4
		public bool CanDispatchEvent(EventBase evt)
		{
			return false;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x000053D1 File Offset: 0x000035D1
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x000053D4 File Offset: 0x000035D4
		public void PostDispatch(EventBase evt, IPanel panel)
		{
		}
	}
}
