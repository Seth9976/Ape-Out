using System;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000016 RID: 22
	public sealed class EventDispatcher
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002395 File Offset: 0x00000595
		public PointerDispatchState pointerState
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000023A2 File Offset: 0x000005A2
		public static EventDispatcher CreateDefault()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000869C File Offset: 0x0000689C
		public static EventDispatcher CreateForRuntime(IList<IEventDispatchingStrategy> strategies)
		{
			return new EventDispatcher(strategies);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000023AF File Offset: 0x000005AF
		public bool dispatchImmediately
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000023BC File Offset: 0x000005BC
		public void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000023C9 File Offset: 0x000005C9
		public void PushDispatcherContext()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000023D6 File Offset: 0x000005D6
		public void PopDispatcherContext()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000023E3 File Offset: 0x000005E3
		public void CloseGate()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000023F0 File Offset: 0x000005F0
		public void OpenGate()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000023FD File Offset: 0x000005FD
		public void ProcessEventQueue()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000240A File Offset: 0x0000060A
		public void ProcessEvent(EventBase evt, IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002417 File Offset: 0x00000617
		public void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
