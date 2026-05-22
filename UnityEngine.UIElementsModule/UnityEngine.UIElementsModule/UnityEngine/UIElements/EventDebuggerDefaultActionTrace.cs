using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000107 RID: 263
	public class EventDebuggerDefaultActionTrace : EventDebuggerTrace
	{
		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x000061F6 File Offset: 0x000043F6
		public PropagationPhase phase
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x0000C358 File Offset: 0x0000A558
		public string targetName
		{
			get
			{
				return base.eventBase.target.GetType().FullName;
			}
		}
	}
}
