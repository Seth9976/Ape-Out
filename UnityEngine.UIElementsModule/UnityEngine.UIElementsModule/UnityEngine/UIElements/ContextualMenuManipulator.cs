using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200000C RID: 12
	public class ContextualMenuManipulator : MouseManipulator
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002210 File Offset: 0x00000410
		public override void RegisterCallbacksOnTarget()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000221D File Offset: 0x0000041D
		public override void UnregisterCallbacksFromTarget()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000085C4 File Offset: 0x000067C4
		public void OnMouseUpDownEvent(IMouseEvent evt)
		{
			bool flag = base.CanStartManipulation(evt);
			if (flag)
			{
				bool flag2 = base.target.elementPanel != null && base.target.elementPanel.contextualMenuManager != null;
				if (flag2)
				{
					EventBase eventBase = evt.TryCast<EventBase>();
					base.target.elementPanel.contextualMenuManager.DisplayMenu(eventBase, base.target);
					eventBase.StopPropagation();
					eventBase.PreventDefault();
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000222A File Offset: 0x0000042A
		public void OnKeyUpEvent(KeyUpEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002237 File Offset: 0x00000437
		public void OnContextualMenuEvent(ContextualMenuPopulateEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
