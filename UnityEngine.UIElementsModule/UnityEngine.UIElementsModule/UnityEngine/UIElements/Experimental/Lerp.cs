using System;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x02000196 RID: 406
	public static class Lerp
	{
		// Token: 0x0600093F RID: 2367 RVA: 0x0000FC34 File Offset: 0x0000DE34
		public static float Interpolate(float start, float end, float ratio)
		{
			return Mathf.LerpUnclamped(start, end, ratio);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0000FC50 File Offset: 0x0000DE50
		public static int Interpolate(int start, int end, float ratio)
		{
			return Mathf.RoundToInt(Mathf.LerpUnclamped((float)start, (float)end, ratio));
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0000FC74 File Offset: 0x0000DE74
		public static Rect Interpolate(Rect r1, Rect r2, float ratio)
		{
			return new Rect(Mathf.LerpUnclamped(r1.x, r2.x, ratio), Mathf.LerpUnclamped(r1.y, r2.y, ratio), Mathf.LerpUnclamped(r1.width, r2.width, ratio), Mathf.LerpUnclamped(r1.height, r2.height, ratio));
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0000FCDC File Offset: 0x0000DEDC
		public static Color Interpolate(Color start, Color end, float ratio)
		{
			return Color.LerpUnclamped(start, end, ratio);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0000FCF8 File Offset: 0x0000DEF8
		public static Vector2 Interpolate(Vector2 start, Vector2 end, float ratio)
		{
			return Vector2.LerpUnclamped(start, end, ratio);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0000FD14 File Offset: 0x0000DF14
		public static Vector3 Interpolate(Vector3 start, Vector3 end, float ratio)
		{
			return Vector3.LerpUnclamped(start, end, ratio);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0000FD30 File Offset: 0x0000DF30
		public static Quaternion Interpolate(Quaternion start, Quaternion end, float ratio)
		{
			return Quaternion.SlerpUnclamped(start, end, ratio);
		}
	}
}
