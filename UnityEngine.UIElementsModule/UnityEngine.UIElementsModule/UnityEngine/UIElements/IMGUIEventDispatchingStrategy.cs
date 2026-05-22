using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CF RID: 207
	public class IMGUIEventDispatchingStrategy
	{
		// Token: 0x0600050C RID: 1292 RVA: 0x0000BC14 File Offset: 0x00009E14
		public bool CanDispatchEvent(EventBase evt)
		{
			return evt.TryCast<IMGUIEvent>() != null;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000BC30 File Offset: 0x00009E30
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
			bool flag = panel != null;
			if (flag)
			{
				EventDispatchUtilities.PropagateToIMGUIContainer(panel.visualTree, evt);
			}
			evt.propagateToIMGUI = false;
			evt.stopDispatch = true;
		}
	}
}
