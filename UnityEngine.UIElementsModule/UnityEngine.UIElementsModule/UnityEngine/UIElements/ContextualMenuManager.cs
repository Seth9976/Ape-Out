using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200000B RID: 11
	public abstract class ContextualMenuManager
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00008578 File Offset: 0x00006778
		public void DisplayMenu(EventBase triggerEvent, IEventHandler target)
		{
			DropdownMenu dropdownMenu = new DropdownMenu();
			using (ContextualMenuPopulateEvent pooled = ContextualMenuPopulateEvent.GetPooled(triggerEvent, dropdownMenu, target, this))
			{
				if (target != null)
				{
					target.SendEvent(pooled);
				}
			}
		}
	}
}
