using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000DA RID: 218
	public class MouseDownEvent : MouseEventBase<MouseDownEvent>
	{
		// Token: 0x0600052B RID: 1323 RVA: 0x000059C0 File Offset: 0x00003BC0
		public static MouseDownEvent GetPooled(Event systemEvent)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000059CD File Offset: 0x00003BCD
		public static MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0000BE08 File Offset: 0x0000A008
		public static MouseDownEvent GetPooled(PointerDownEvent pointerEvent)
		{
			return MouseDownEvent.MakeFromPointerEvent(pointerEvent);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0000BE20 File Offset: 0x0000A020
		public static MouseDownEvent GetPooled(PointerMoveEvent pointerEvent)
		{
			return MouseDownEvent.MakeFromPointerEvent(pointerEvent);
		}
	}
}
