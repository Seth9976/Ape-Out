using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C6 RID: 198
	public abstract class CallbackEventHandler
	{
		// Token: 0x060004FD RID: 1277 RVA: 0x000057CA File Offset: 0x000039CA
		public void HandleEventAtTargetPhase(EventBase evt)
		{
			evt.currentTarget = evt.target;
			evt.propagationPhase = PropagationPhase.AtTarget;
			this.HandleEvent(evt);
			evt.propagationPhase = PropagationPhase.DefaultActionAtTarget;
			this.HandleEvent(evt);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000057FA File Offset: 0x000039FA
		public virtual void HandleEvent(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00005807 File Offset: 0x00003A07
		public bool HasTrickleDownHandlers()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00005814 File Offset: 0x00003A14
		public bool HasBubbleUpHandlers()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00005821 File Offset: 0x00003A21
		public virtual void ExecuteDefaultActionAtTarget(EventBase evt)
		{
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00005824 File Offset: 0x00003A24
		public virtual void ExecuteDefaultAction(EventBase evt)
		{
		}
	}
}
