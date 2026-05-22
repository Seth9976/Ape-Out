using System;
using UnityEngine.Assertions;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D7 RID: 215
	public class MouseEventDispatchingStrategy
	{
		// Token: 0x06000523 RID: 1315 RVA: 0x0000BCAC File Offset: 0x00009EAC
		public bool CanDispatchEvent(EventBase evt)
		{
			return evt.TryCast<IMouseEvent>() != null;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000BCC8 File Offset: 0x00009EC8
		public void DispatchEvent(EventBase evt, IPanel iPanel)
		{
			bool flag = iPanel != null;
			if (flag)
			{
				Assert.IsTrue(iPanel.TryCast<BaseVisualElementPanel>() != null);
				BaseVisualElementPanel baseVisualElementPanel = iPanel.Cast<BaseVisualElementPanel>();
				MouseEventDispatchingStrategy.SetBestTargetForEvent(evt, baseVisualElementPanel);
				MouseEventDispatchingStrategy.SendEventToTarget(evt, baseVisualElementPanel);
			}
			evt.stopDispatch = true;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0000BD10 File Offset: 0x00009F10
		public static bool SendEventToTarget(EventBase evt, BaseVisualElementPanel panel)
		{
			return MouseEventDispatchingStrategy.SendEventToRegularTarget(evt, panel) || MouseEventDispatchingStrategy.SendEventToIMGUIContainer(evt, panel);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0000BD38 File Offset: 0x00009F38
		public static bool SendEventToRegularTarget(EventBase evt, BaseVisualElementPanel panel)
		{
			bool flag = evt.target == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				EventDispatchUtilities.PropagateEvent(evt);
				flag2 = MouseEventDispatchingStrategy.IsDone(evt);
			}
			return flag2;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x000059A6 File Offset: 0x00003BA6
		public static bool SendEventToIMGUIContainer(EventBase evt, BaseVisualElementPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0000BD68 File Offset: 0x00009F68
		public static void SetBestTargetForEvent(EventBase evt, BaseVisualElementPanel panel)
		{
			VisualElement visualElement;
			MouseEventDispatchingStrategy.UpdateElementUnderMouse(evt, panel, out visualElement);
			bool flag = evt.target != null;
			if (flag)
			{
				evt.propagateToIMGUI = false;
			}
			else
			{
				bool flag2 = visualElement != null;
				if (flag2)
				{
					evt.propagateToIMGUI = false;
					evt.target = visualElement;
				}
				else
				{
					evt.target = ((panel != null) ? panel.visualTree : null);
				}
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x000059B3 File Offset: 0x00003BB3
		public static void UpdateElementUnderMouse(EventBase evt, BaseVisualElementPanel panel, out VisualElement elementUnderMouse)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0000BDCC File Offset: 0x00009FCC
		public static bool IsDone(EventBase evt)
		{
			Event imguiEvent = evt.imguiEvent;
			bool flag = imguiEvent != null && imguiEvent.rawType == EventType.Used;
			if (flag)
			{
				evt.StopPropagation();
			}
			return evt.isPropagationStopped;
		}
	}
}
