using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000038 RID: 56
	public class PointerClickable : Clickable
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00008F0C File Offset: 0x0000710C
		public Vector2 lastPointerPosition
		{
			get
			{
				return base.lastMousePosition;
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002E26 File Offset: 0x00001026
		public override void RegisterCallbacksOnTarget()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002E33 File Offset: 0x00001033
		public override void UnregisterCallbacksFromTarget()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002E40 File Offset: 0x00001040
		public void OnPointerDown(PointerDownEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002E4D File Offset: 0x0000104D
		public void OnPointerMove(PointerMoveEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002E5A File Offset: 0x0000105A
		public void OnPointerUp(PointerUpEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
