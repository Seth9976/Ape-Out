using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CE RID: 206
	public static class EventDispatchUtilities
	{
		// Token: 0x06000509 RID: 1289 RVA: 0x00005871 File Offset: 0x00003A71
		public static void PropagateEvent(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000587E File Offset: 0x00003A7E
		public static void PropagateToIMGUIContainer(VisualElement root, EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000BB90 File Offset: 0x00009D90
		public static void ExecuteDefaultAction(EventBase evt, IPanel panel)
		{
			bool flag = evt.target == null && panel != null;
			if (flag)
			{
				evt.target = panel.visualTree;
			}
			bool flag2 = evt.target != null;
			if (flag2)
			{
				evt.dispatch = true;
				evt.currentTarget = evt.target;
				evt.propagationPhase = PropagationPhase.DefaultAction;
				evt.currentTarget.HandleEvent(evt);
				evt.propagationPhase = PropagationPhase.None;
				evt.currentTarget = null;
				evt.dispatch = false;
			}
		}
	}
}
