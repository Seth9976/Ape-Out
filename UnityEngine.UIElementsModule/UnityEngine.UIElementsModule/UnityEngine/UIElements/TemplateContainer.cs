using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004E RID: 78
	public class TemplateContainer : BindableElement
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00002F9C File Offset: 0x0000119C
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00002FA9 File Offset: 0x000011A9
		public string templateId
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

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00002FB6 File Offset: 0x000011B6
		public override VisualElement contentContainer
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002FC3 File Offset: 0x000011C3
		public void SetContentContainer(VisualElement content)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020001A6 RID: 422
		public new class UxmlFactory : UxmlFactory<TemplateContainer, TemplateContainer.UxmlTraits>
		{
		}

		// Token: 0x020001A7 RID: 423
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x0200021C RID: 540
			public sealed class <get_uxmlChildElementsDescription>d__3
			{
			}
		}
	}
}
