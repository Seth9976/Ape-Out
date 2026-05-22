using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E7 RID: 231
	public static class PointerEventsHelper
	{
		// Token: 0x06000551 RID: 1361 RVA: 0x00005B6F File Offset: 0x00003D6F
		public static void SendEnterLeave<TLeaveEvent, TEnterEvent>(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId) where TLeaveEvent : new() where TEnterEvent : new()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00005B7C File Offset: 0x00003D7C
		public static void SendOverOut(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
