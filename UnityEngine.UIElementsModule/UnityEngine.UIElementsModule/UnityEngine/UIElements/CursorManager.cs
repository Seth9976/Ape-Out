using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200000E RID: 14
	public class CursorManager
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002244 File Offset: 0x00000444
		public void ResetCursor()
		{
			Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
		}
	}
}
