using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CB RID: 203
	public class FocusEvent : FocusEventBase<FocusEvent>
	{
		// Token: 0x06000508 RID: 1288 RVA: 0x00005864 File Offset: 0x00003A64
		public override void PreDispatch(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
