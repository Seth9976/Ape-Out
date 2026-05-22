using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000092 RID: 146
	public class TextEditorEngine : TextEditor
	{
		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0000B214 File Offset: 0x00009414
		public override Rect localPosition
		{
			get
			{
				return new Rect(0f, 0f, base.position.width, base.position.height);
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00004CD1 File Offset: 0x00002ED1
		public override void OnDetectFocusChange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00004CDE File Offset: 0x00002EDE
		public override void OnCursorIndexChange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00004CEB File Offset: 0x00002EEB
		public override void OnSelectIndexChange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
