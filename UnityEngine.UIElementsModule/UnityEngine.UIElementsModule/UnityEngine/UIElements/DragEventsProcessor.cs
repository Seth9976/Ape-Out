using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200009F RID: 159
	public abstract class DragEventsProcessor
	{
		// Token: 0x06000461 RID: 1121 RVA: 0x00005212 File Offset: 0x00003412
		public void UnregisterCallbacksFromTarget(DetachFromPanelEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000521F File Offset: 0x0000341F
		public void OnPointerUp()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000522C File Offset: 0x0000342C
		public void OnPointerDownEvent(PointerDownEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00005239 File Offset: 0x00003439
		public void OnPointerUpEvent(PointerUpEvent evt)
		{
			this.OnPointerUp();
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00005243 File Offset: 0x00003443
		public void OnPointerLeaveEvent(PointerLeaveEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00005250 File Offset: 0x00003450
		public void OnDragExitedEvent(DragExitedEvent evt)
		{
			this.ClearDragAndDropUI();
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000525A File Offset: 0x0000345A
		public void OnDragPerformEvent(DragPerformEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00005267 File Offset: 0x00003467
		public void OnDragUpdate(DragUpdatedEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00005274 File Offset: 0x00003474
		public void OnPointerMoveEvent(PointerMoveEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000B5 RID: 181
		public const int k_DistanceToActivation = 5;
	}
}
