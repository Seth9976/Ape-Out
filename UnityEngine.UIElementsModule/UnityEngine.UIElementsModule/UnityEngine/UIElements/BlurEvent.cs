using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C9 RID: 201
	public class BlurEvent : FocusEventBase<BlurEvent>
	{
		// Token: 0x06000505 RID: 1285 RVA: 0x0000583F File Offset: 0x00003A3F
		public override void PreDispatch(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
