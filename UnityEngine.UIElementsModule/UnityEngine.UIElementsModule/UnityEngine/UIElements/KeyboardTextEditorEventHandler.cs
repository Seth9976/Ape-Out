using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000085 RID: 133
	public class KeyboardTextEditorEventHandler : TextEditorEventHandler
	{
		// Token: 0x06000324 RID: 804 RVA: 0x00004406 File Offset: 0x00002606
		public override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00004413 File Offset: 0x00002613
		public void OnFocus(FocusEvent _)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00004420 File Offset: 0x00002620
		public void OnBlur(BlurEvent _)
		{
			GUIUtility.imeCompositionMode = IMECompositionMode.Auto;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000442A File Offset: 0x0000262A
		public void OnMouseDown(MouseDownEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00004437 File Offset: 0x00002637
		public void OnMouseUp(MouseUpEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00004444 File Offset: 0x00002644
		public void OnMouseMove(MouseMoveEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00004451 File Offset: 0x00002651
		public void OnKeyDown(KeyDownEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000445E File Offset: 0x0000265E
		public void OnValidateCommandEvent(ValidateCommandEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000446B File Offset: 0x0000266B
		public void OnExecuteCommandEvent(ExecuteCommandEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00004478 File Offset: 0x00002678
		public void PreDrawCursor(string newText)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00004485 File Offset: 0x00002685
		public void PostDrawCursor()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
