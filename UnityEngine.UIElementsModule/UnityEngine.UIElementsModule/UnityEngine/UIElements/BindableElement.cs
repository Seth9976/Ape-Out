using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000007 RID: 7
	public class BindableElement : VisualElement
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000209A File Offset: 0x0000029A
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000020A7 File Offset: 0x000002A7
		public IBinding binding
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020B4 File Offset: 0x000002B4
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000020C1 File Offset: 0x000002C1
		public string bindingPath
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0200019B RID: 411
		public new class UxmlFactory : UxmlFactory<BindableElement, BindableElement.UxmlTraits>
		{
		}

		// Token: 0x0200019C RID: 412
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
		}
	}
}
