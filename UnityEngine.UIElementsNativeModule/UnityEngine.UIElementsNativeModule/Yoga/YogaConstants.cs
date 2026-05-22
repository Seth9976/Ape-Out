using System;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x0200000D RID: 13
	public static class YogaConstants
	{
		// Token: 0x06000133 RID: 307 RVA: 0x000048B4 File Offset: 0x00002AB4
		public static bool IsUndefined(float value)
		{
			return Single.IsNaN(value);
		}

		// Token: 0x040000AB RID: 171
		public const float Undefined = float.NaN;
	}
}
