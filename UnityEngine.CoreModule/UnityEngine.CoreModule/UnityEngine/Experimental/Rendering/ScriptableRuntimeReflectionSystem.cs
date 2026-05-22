using System;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020002D2 RID: 722
	public abstract class ScriptableRuntimeReflectionSystem
	{
		// Token: 0x06002304 RID: 8964 RVA: 0x00078AA4 File Offset: 0x00076CA4
		public virtual bool TickRealtimeProbes()
		{
			return false;
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x00012B93 File Offset: 0x00010D93
		public virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00012B96 File Offset: 0x00010D96
		public void System.IDisposable.Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
