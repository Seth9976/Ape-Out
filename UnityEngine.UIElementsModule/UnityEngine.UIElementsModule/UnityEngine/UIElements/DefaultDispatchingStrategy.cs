using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B6 RID: 182
	public class DefaultDispatchingStrategy
	{
		// Token: 0x0600048C RID: 1164 RVA: 0x0000B4F8 File Offset: 0x000096F8
		public bool CanDispatchEvent(EventBase evt)
		{
			return evt.TryCast<IMGUIEvent>() == null;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000053D7 File Offset: 0x000035D7
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
