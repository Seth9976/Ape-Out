using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000DB RID: 219
	public class MouseUpEvent : MouseEventBase<MouseUpEvent>
	{
		// Token: 0x0600052F RID: 1327 RVA: 0x000059DA File Offset: 0x00003BDA
		public static MouseUpEvent GetPooled(Event systemEvent)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000059E7 File Offset: 0x00003BE7
		public static MouseUpEvent MakeFromPointerEvent(IPointerEvent pointerEvent)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0000BE38 File Offset: 0x0000A038
		public static MouseUpEvent GetPooled(PointerUpEvent pointerEvent)
		{
			return MouseUpEvent.MakeFromPointerEvent(pointerEvent);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0000BE50 File Offset: 0x0000A050
		public static MouseUpEvent GetPooled(PointerMoveEvent pointerEvent)
		{
			return MouseUpEvent.MakeFromPointerEvent(pointerEvent);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0000BE68 File Offset: 0x0000A068
		public static MouseUpEvent GetPooled(PointerCancelEvent pointerEvent)
		{
			return MouseUpEvent.MakeFromPointerEvent(pointerEvent);
		}
	}
}
