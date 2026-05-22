using System;
using System.Runtime.InteropServices;

namespace UnityEngine.UIElements
{
	// Token: 0x02000006 RID: 6
	public class AlignmentUtils
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000084B8 File Offset: 0x000066B8
		public static float RoundToPixelGrid(float v, float pixelsPerPoint, [Optional] float offset)
		{
			return Mathf.Floor(v * pixelsPerPoint + 0.5f + offset) / pixelsPerPoint;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000084DC File Offset: 0x000066DC
		public static float CeilToPixelGrid(float v, float pixelsPerPoint, [Optional] float offset)
		{
			return Mathf.Ceil(v * pixelsPerPoint + offset) / pixelsPerPoint;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000084FC File Offset: 0x000066FC
		public static float FloorToPixelGrid(float v, float pixelsPerPoint, [Optional] float offset)
		{
			return Mathf.Floor(v * pixelsPerPoint + offset) / pixelsPerPoint;
		}
	}
}
