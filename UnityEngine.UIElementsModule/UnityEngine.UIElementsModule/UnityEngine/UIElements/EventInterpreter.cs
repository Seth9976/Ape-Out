using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000019 RID: 25
	public class EventInterpreter
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00002424 File Offset: 0x00000624
		public virtual bool IsActivationEvent(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002431 File Offset: 0x00000631
		public virtual bool IsCancellationEvent(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000243E File Offset: 0x0000063E
		public virtual bool IsNavigationEvent(EventBase evt, out NavigationDirection direction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000244B File Offset: 0x0000064B
		public NavigationDirection GetNavigationDirection(KeyDownEvent keyDownEvent)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
