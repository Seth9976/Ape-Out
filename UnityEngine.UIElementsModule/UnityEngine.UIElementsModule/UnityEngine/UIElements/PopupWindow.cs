using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200008A RID: 138
	public class PopupWindow : TextElement
	{
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00004951 File Offset: 0x00002B51
		public override VisualElement contentContainer
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x020001DA RID: 474
		public new class UxmlFactory : UxmlFactory<PopupWindow, PopupWindow.UxmlTraits>
		{
		}

		// Token: 0x020001DB RID: 475
		public new class UxmlTraits : TextElement.UxmlTraits
		{
			// Token: 0x02000222 RID: 546
			public sealed class <get_uxmlChildElementsDescription>d__1
			{
			}
		}
	}
}
