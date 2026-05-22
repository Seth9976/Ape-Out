using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000ED RID: 237
	public class PointerEventDispatchingStrategy
	{
		// Token: 0x0600055E RID: 1374 RVA: 0x0000BE9C File Offset: 0x0000A09C
		public bool CanDispatchEvent(EventBase evt)
		{
			return evt.TryCast<IPointerEvent>() != null;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00005C0B File Offset: 0x00003E0B
		public virtual void DispatchEvent(EventBase evt, IPanel panel)
		{
			PointerEventDispatchingStrategy.SetBestTargetForEvent(evt, panel);
			PointerEventDispatchingStrategy.SendEventToTarget(evt);
			evt.stopDispatch = true;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0000BEB8 File Offset: 0x0000A0B8
		public static void SendEventToTarget(EventBase evt)
		{
			bool flag = evt.target != null;
			if (flag)
			{
				EventDispatchUtilities.PropagateEvent(evt);
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0000BEDC File Offset: 0x0000A0DC
		public static void SetBestTargetForEvent(EventBase evt, IPanel panel)
		{
			VisualElement visualElement;
			PointerEventDispatchingStrategy.UpdateElementUnderPointer(evt, panel, out visualElement);
			bool flag = evt.target == null && visualElement != null;
			if (flag)
			{
				evt.propagateToIMGUI = false;
				evt.target = visualElement;
			}
			else
			{
				bool flag2 = evt.target == null && visualElement == null;
				if (flag2)
				{
					evt.target = ((panel != null) ? panel.visualTree : null);
				}
				else
				{
					bool flag3 = evt.target != null;
					if (flag3)
					{
						evt.propagateToIMGUI = false;
					}
				}
			}
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0000BF5C File Offset: 0x0000A15C
		public static void UpdateElementUnderPointer(EventBase evt, IPanel panel, out VisualElement elementUnderPointer)
		{
			IPointerEvent pointerEvent = evt.TryCast<IPointerEvent>();
			BaseVisualElementPanel baseVisualElementPanel = panel.TryCast<BaseVisualElementPanel>();
			IPointerEventInternal pointerEventInternal = evt.TryCast<IPointerEventInternal>();
			elementUnderPointer = ((pointerEventInternal == null || pointerEventInternal.recomputeTopElementUnderPointer) ? ((baseVisualElementPanel != null) ? baseVisualElementPanel.RecomputeTopElementUnderPointer(pointerEvent.position, evt) : null) : ((baseVisualElementPanel != null) ? baseVisualElementPanel.GetTopElementUnderPointer(pointerEvent.pointerId) : null));
		}
	}
}
