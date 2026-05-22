using System;

namespace UnityEngine.TextCore
{
	// Token: 0x02000012 RID: 18
	public static class ColorUtilities
	{
		// Token: 0x06000122 RID: 290 RVA: 0x00006D90 File Offset: 0x00004F90
		public static bool CompareColors(Color32 a, Color32 b)
		{
			return a.r == b.r && a.g == b.g && a.b == b.b && a.a == b.a;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00006DE0 File Offset: 0x00004FE0
		public static bool CompareColorsRgb(Color32 a, Color32 b)
		{
			return a.r == b.r && a.g == b.g && a.b == b.b;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00006E20 File Offset: 0x00005020
		public static bool CompareColors(Color a, Color b)
		{
			return Mathf.Approximately(a.r, b.r) && Mathf.Approximately(a.g, b.g) && Mathf.Approximately(a.b, b.b) && Mathf.Approximately(a.a, b.a);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00006E80 File Offset: 0x00005080
		public static bool CompareColorsRgb(Color a, Color b)
		{
			return Mathf.Approximately(a.r, b.r) && Mathf.Approximately(a.g, b.g) && Mathf.Approximately(a.b, b.b);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006ECC File Offset: 0x000050CC
		public static Color32 MultiplyColors(Color32 c1, Color32 c2)
		{
			byte b = (byte)((float)c1.r / 255f * ((float)c2.r / 255f) * 255f);
			byte b2 = (byte)((float)c1.g / 255f * ((float)c2.g / 255f) * 255f);
			byte b3 = (byte)((float)c1.b / 255f * ((float)c2.b / 255f) * 255f);
			byte b4 = (byte)((float)c1.a / 255f * ((float)c2.a / 255f) * 255f);
			return new Color32(b, b2, b3, b4);
		}
	}
}
