using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BF RID: 191
	public abstract class EventCallbackFunctorBase
	{
		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0000569F File Offset: 0x0000389F
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x000056AC File Offset: 0x000038AC
		public CallbackPhase phase
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0000BA88 File Offset: 0x00009C88
		public bool PhaseMatches(EventBase evt)
		{
			CallbackPhase phase = this.phase;
			CallbackPhase callbackPhase = phase;
			if (callbackPhase != CallbackPhase.TargetAndBubbleUp)
			{
				if (callbackPhase == CallbackPhase.TrickleDownAndTarget)
				{
					bool flag = evt.propagationPhase != PropagationPhase.TrickleDown && evt.propagationPhase != PropagationPhase.AtTarget;
					if (flag)
					{
						return false;
					}
				}
			}
			else
			{
				bool flag2 = evt.propagationPhase != PropagationPhase.AtTarget && evt.propagationPhase != PropagationPhase.BubbleUp;
				if (flag2)
				{
					return false;
				}
			}
			return true;
		}
	}
}
