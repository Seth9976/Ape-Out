using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A5 RID: 677
	[OriginalName("mscorlib.dll", "System.Threading.Tasks", "TaskStatus")]
	public enum TaskStatus
	{
		// Token: 0x040027F5 RID: 10229
		Created,
		// Token: 0x040027F6 RID: 10230
		WaitingForActivation,
		// Token: 0x040027F7 RID: 10231
		WaitingToRun,
		// Token: 0x040027F8 RID: 10232
		Running,
		// Token: 0x040027F9 RID: 10233
		WaitingForChildrenToComplete,
		// Token: 0x040027FA RID: 10234
		RanToCompletion,
		// Token: 0x040027FB RID: 10235
		Canceled,
		// Token: 0x040027FC RID: 10236
		Faulted
	}
}
