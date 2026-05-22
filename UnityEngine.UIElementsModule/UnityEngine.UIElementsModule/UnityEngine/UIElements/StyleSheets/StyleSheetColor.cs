using System;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000183 RID: 387
	public static class StyleSheetColor
	{
		// Token: 0x060008E3 RID: 2275 RVA: 0x000081A1 File Offset: 0x000063A1
		public static bool TryGetColor(string name, out Color color)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0000F3EC File Offset: 0x0000D5EC
		public static Color32 HexToColor32(uint color)
		{
			byte b = (byte)(color & 255U);
			byte b2 = (byte)((color >> 8) & 255U);
			byte b3 = (byte)((color >> 16) & 255U);
			return new Color32(b3, b2, b, byte.MaxValue);
		}
	}
}
