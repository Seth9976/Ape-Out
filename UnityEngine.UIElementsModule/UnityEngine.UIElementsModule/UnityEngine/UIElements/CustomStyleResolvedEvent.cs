using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000FD RID: 253
	public class CustomStyleResolvedEvent : EventBase<CustomStyleResolvedEvent>
	{
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0000BFBC File Offset: 0x0000A1BC
		public ICustomStyle customStyle
		{
			get
			{
				VisualElement visualElement = base.target.TryCast<VisualElement>();
				return (visualElement != null) ? visualElement.customStyle : null;
			}
		}
	}
}
