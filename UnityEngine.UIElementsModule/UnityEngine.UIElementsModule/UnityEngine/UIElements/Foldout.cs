using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000080 RID: 128
	public class Foldout : BindableElement
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00004282 File Offset: 0x00002482
		public override VisualElement contentContainer
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000428F File Offset: 0x0000248F
		// (set) Token: 0x06000306 RID: 774 RVA: 0x0000429C File Offset: 0x0000249C
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

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000307 RID: 775 RVA: 0x000042A9 File Offset: 0x000024A9
		// (set) Token: 0x06000308 RID: 776 RVA: 0x000042B6 File Offset: 0x000024B6
		public bool value
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

		// Token: 0x06000309 RID: 777 RVA: 0x000042C3 File Offset: 0x000024C3
		public void SetValueWithoutNotify(bool newValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000042D0 File Offset: 0x000024D0
		public override void OnViewDataReady()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000042DD File Offset: 0x000024DD
		public void OnAttachToPanel(AttachToPanelEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020001CC RID: 460
		public new class UxmlFactory : UxmlFactory<Foldout, Foldout.UxmlTraits>
		{
		}

		// Token: 0x020001CD RID: 461
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
		}
	}
}
