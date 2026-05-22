using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B1 RID: 177
	public class CommandEventDispatchingStrategy
	{
		// Token: 0x06000487 RID: 1159 RVA: 0x0000B4C8 File Offset: 0x000096C8
		public bool CanDispatchEvent(EventBase evt)
		{
			return evt.TryCast<ICommandEvent>() != null;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000053C4 File Offset: 0x000035C4
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
