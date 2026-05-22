using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000103 RID: 259
	public class EventDebugger
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00005DD3 File Offset: 0x00003FD3
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00005DE0 File Offset: 0x00003FE0
		public IPanel panel
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

		// Token: 0x0600058B RID: 1419 RVA: 0x00005DED File Offset: 0x00003FED
		public void UpdateModificationCount()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00005DFA File Offset: 0x00003FFA
		public void BeginProcessEvent(EventBase evt, IEventHandler mouseCapture)
		{
			this.AddBeginProcessEvent(evt, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00005E0D File Offset: 0x0000400D
		public void EndProcessEvent(EventBase evt, long duration, IEventHandler mouseCapture)
		{
			this.AddEndProcessEvent(evt, duration, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0000C01C File Offset: 0x0000A21C
		public void LogCall(int cbHashCode, string cbName, EventBase evt, bool propagationHasStopped, bool immediatePropagationHasStopped, bool defaultHasBeenPrevented, long duration, IEventHandler mouseCapture)
		{
			this.AddCallObject(cbHashCode, cbName, evt, propagationHasStopped, immediatePropagationHasStopped, defaultHasBeenPrevented, duration, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00005E21 File Offset: 0x00004021
		public void LogIMGUICall(EventBase evt, long duration, IEventHandler mouseCapture)
		{
			this.AddIMGUICall(evt, duration, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00005E35 File Offset: 0x00004035
		public void LogExecuteDefaultAction(EventBase evt, PropagationPhase phase, long duration, IEventHandler mouseCapture)
		{
			this.AddExecuteDefaultAction(evt, phase, duration, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00005E4B File Offset: 0x0000404B
		public static void LogPropagationPaths(EventBase evt, PropagationPaths paths)
		{
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0000C048 File Offset: 0x0000A248
		public void LogPropagationPathsInternal(EventBase evt, PropagationPaths paths)
		{
			PropagationPaths propagationPaths = ((paths == null) ? new PropagationPaths() : new PropagationPaths(paths));
			this.AddPropagationPaths(evt, propagationPaths);
			this.UpdateModificationCount();
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00005E4E File Offset: 0x0000404E
		public List<EventDebuggerCallTrace> GetCalls(IPanel panel, [Optional] EventDebuggerEventRecord evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00005E5B File Offset: 0x0000405B
		public List<EventDebuggerDefaultActionTrace> GetDefaultActions(IPanel panel, [Optional] EventDebuggerEventRecord evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00005E68 File Offset: 0x00004068
		public List<EventDebuggerPathTrace> GetPropagationPaths(IPanel panel, [Optional] EventDebuggerEventRecord evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00005E75 File Offset: 0x00004075
		public List<EventDebuggerTrace> GetBeginEndProcessedEvents(IPanel panel, [Optional] EventDebuggerEventRecord evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00005E82 File Offset: 0x00004082
		public long GetModificationCount(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00005E8F File Offset: 0x0000408F
		public void ClearLogs()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00005E9C File Offset: 0x0000409C
		public void ReplayEvents(List<EventDebuggerEventRecord> eventBases)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00005EA9 File Offset: 0x000040A9
		public Dictionary<string, long> ComputeHistogram(List<EventDebuggerEventRecord> eventBases)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00005EB6 File Offset: 0x000040B6
		public void AddCallObject(int cbHashCode, string cbName, EventBase evt, bool propagationHasStopped, bool immediatePropagationHasStopped, bool defaultHasBeenPrevented, long duration, IEventHandler mouseCapture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00005EC3 File Offset: 0x000040C3
		public void AddExecuteDefaultAction(EventBase evt, PropagationPhase phase, long duration, IEventHandler mouseCapture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00005ED0 File Offset: 0x000040D0
		public void AddPropagationPaths(EventBase evt, PropagationPaths paths)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00005EDD File Offset: 0x000040DD
		public void AddIMGUICall(EventBase evt, long duration, IEventHandler mouseCapture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00005EEA File Offset: 0x000040EA
		public void AddBeginProcessEvent(EventBase evt, IEventHandler mouseCapture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00005EF7 File Offset: 0x000040F7
		public void AddEndProcessEvent(EventBase evt, long duration, IEventHandler mouseCapture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0000C078 File Offset: 0x0000A278
		public static string GetObjectDisplayName(Object obj, [Optional] bool withHashCode)
		{
			bool flag = obj == null;
			string text;
			if (flag)
			{
				text = String.Empty;
			}
			else
			{
				string text2 = obj.GetType().Name;
				bool flag2 = obj.TryCast<VisualElement>() != null;
				if (flag2)
				{
					VisualElement visualElement = obj.TryCast<VisualElement>();
					bool flag3 = !String.IsNullOrEmpty(visualElement.name);
					if (flag3)
					{
						text2 = String.Concat(text2, "#", visualElement.name);
					}
				}
				if (withHashCode)
				{
					text2 = String.Concat(text2, " (", obj.GetHashCode().ToString("x8"), ")");
				}
				text = text2;
			}
			return text;
		}
	}
}
