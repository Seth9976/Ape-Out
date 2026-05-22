using System;
using System.Runtime.InteropServices;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200000A RID: 10
	public class Clickable : PointerManipulator
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002129 File Offset: 0x00000329
		public void add_clickedWithEventInfo(Action<EventBase> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002136 File Offset: 0x00000336
		public void remove_clickedWithEventInfo(Action<EventBase> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002143 File Offset: 0x00000343
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002150 File Offset: 0x00000350
		public bool active
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

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000215D File Offset: 0x0000035D
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000216A File Offset: 0x0000036A
		public Vector2 lastMousePosition
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

		// Token: 0x0600001C RID: 28 RVA: 0x00002177 File Offset: 0x00000377
		public bool IsRepeatable()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002184 File Offset: 0x00000384
		public override void RegisterCallbacksOnTarget()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002191 File Offset: 0x00000391
		public override void UnregisterCallbacksFromTarget()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000219E File Offset: 0x0000039E
		public void Invoke(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000021AB File Offset: 0x000003AB
		public void OnMouseDown(MouseDownEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000021B8 File Offset: 0x000003B8
		public void OnMouseMove(MouseMoveEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000021C5 File Offset: 0x000003C5
		public void OnMouseUp(MouseUpEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000021D2 File Offset: 0x000003D2
		public void SimulateSingleClick(EventBase evt, [Optional] int delayMs)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000021DF File Offset: 0x000003DF
		public virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000851C File Offset: 0x0000671C
		public virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition)
		{
			this.lastMousePosition = localPosition;
			bool flag = base.target.ContainsPoint(localPosition);
			if (flag)
			{
				base.target.pseudoStates |= PseudoStates.Active;
			}
			else
			{
				base.target.pseudoStates &= (PseudoStates)(-2);
			}
			evt.StopPropagation();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000021EC File Offset: 0x000003EC
		public virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000021F9 File Offset: 0x000003F9
		public void <SimulateSingleClick>b__28_0()
		{
			base.target.pseudoStates &= (PseudoStates)(-2);
		}
	}
}
