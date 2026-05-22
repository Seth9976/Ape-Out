using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000082 RID: 130
	public class HelpBox : VisualElement
	{
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600030C RID: 780 RVA: 0x000042EA File Offset: 0x000024EA
		// (set) Token: 0x0600030D RID: 781 RVA: 0x000042F7 File Offset: 0x000024F7
		public string text
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

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00004304 File Offset: 0x00002504
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00004311 File Offset: 0x00002511
		public HelpBoxMessageType messageType
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

		// Token: 0x06000310 RID: 784 RVA: 0x0000431E File Offset: 0x0000251E
		public string GetIconClass(HelpBoxMessageType messageType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000432B File Offset: 0x0000252B
		public void UpdateIcon(HelpBoxMessageType messageType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020001CE RID: 462
		public new class UxmlFactory : UxmlFactory<HelpBox, HelpBox.UxmlTraits>
		{
		}

		// Token: 0x020001CF RID: 463
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
		}
	}
}
