using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E6 RID: 230
	public static class MouseEventsHelper
	{
		// Token: 0x0600054F RID: 1359 RVA: 0x00005B55 File Offset: 0x00003D55
		public static void SendEnterLeave<TLeaveEvent, TEnterEvent>(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) where TLeaveEvent : new() where TEnterEvent : new()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00005B62 File Offset: 0x00003D62
		public static void SendMouseOverMouseOut(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
