using System;

namespace UnityEngine.Yoga
{
	// Token: 0x0200000A RID: 10
	public class MeasureOutput
	{
		// Token: 0x06000129 RID: 297 RVA: 0x00004870 File Offset: 0x00002A70
		public static YogaSize Make(float width, float height)
		{
			return new YogaSize
			{
				width = width,
				height = height
			};
		}
	}
}
