using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BD RID: 189
	public class ElementUnderPointer
	{
		// Token: 0x06000499 RID: 1177 RVA: 0x0000546D File Offset: 0x0000366D
		public VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0000547A File Offset: 0x0000367A
		public VisualElement GetTopElementUnderPointer(int pointerId)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00005487 File Offset: 0x00003687
		public void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0000B518 File Offset: 0x00009718
		public Vector2 GetEventPointerPosition(EventBase triggerEvent)
		{
			IPointerEvent pointerEvent = triggerEvent.TryCast<IPointerEvent>();
			bool flag = pointerEvent != null;
			Vector2 vector;
			if (flag)
			{
				vector = new Vector2(pointerEvent.position.x, pointerEvent.position.y);
			}
			else
			{
				IMouseEvent mouseEvent = triggerEvent.TryCast<IMouseEvent>();
				bool flag2 = mouseEvent != null;
				if (flag2)
				{
					vector = mouseEvent.mousePosition;
				}
				else
				{
					vector = new Vector2(float.MinValue, float.MinValue);
				}
			}
			return vector;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00005494 File Offset: 0x00003694
		public void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent)
		{
			this.SetElementUnderPointer(newElementUnderPointer, triggerEvent, true);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x000054A1 File Offset: 0x000036A1
		public void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent)
		{
			this.SetElementUnderPointer(newElementUnderPointer, triggerEvent, false);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x000054AE File Offset: 0x000036AE
		public void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent, bool temporary)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x000054BB File Offset: 0x000036BB
		public void CommitElementUnderPointers(EventDispatcher dispatcher)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
