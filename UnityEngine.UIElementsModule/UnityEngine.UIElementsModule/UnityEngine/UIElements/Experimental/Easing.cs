using System;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x02000194 RID: 404
	public static class Easing
	{
		// Token: 0x06000922 RID: 2338 RVA: 0x0000F59C File Offset: 0x0000D79C
		public static float Step(float t)
		{
			return (float)((t < 0.5f) ? 0 : 1);
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0000F5BC File Offset: 0x0000D7BC
		public static float Linear(float t)
		{
			return t;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		public static float InSine(float t)
		{
			return Mathf.Sin(1.5707964f * (t - 1f)) + 1f;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0000F5FC File Offset: 0x0000D7FC
		public static float OutSine(float t)
		{
			return Mathf.Sin(t * 1.5707964f);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0000F61C File Offset: 0x0000D81C
		public static float InOutSine(float t)
		{
			return (Mathf.Sin(3.1415927f * (t - 0.5f)) + 1f) * 0.5f;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0000F64C File Offset: 0x0000D84C
		public static float InQuad(float t)
		{
			return t * t;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0000F664 File Offset: 0x0000D864
		public static float OutQuad(float t)
		{
			return t * (2f - t);
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0000F680 File Offset: 0x0000D880
		public static float InOutQuad(float t)
		{
			t *= 2f;
			bool flag = t < 1f;
			float num;
			if (flag)
			{
				num = t * t * 0.5f;
			}
			else
			{
				num = -0.5f * ((t - 1f) * (t - 3f) - 1f);
			}
			return num;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0000F6D0 File Offset: 0x0000D8D0
		public static float InCubic(float t)
		{
			return Easing.InPower(t, 3);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0000F6EC File Offset: 0x0000D8EC
		public static float OutCubic(float t)
		{
			return Easing.OutPower(t, 3);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0000F708 File Offset: 0x0000D908
		public static float InOutCubic(float t)
		{
			return Easing.InOutPower(t, 3);
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0000F724 File Offset: 0x0000D924
		public static float InPower(float t, int power)
		{
			return Mathf.Pow(t, (float)power);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0000F740 File Offset: 0x0000D940
		public static float OutPower(float t, int power)
		{
			int num = ((power % 2 == 0) ? (-1) : 1);
			return (float)num * (Mathf.Pow(t - 1f, (float)power) + (float)num);
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0000F774 File Offset: 0x0000D974
		public static float InOutPower(float t, int power)
		{
			t *= 2f;
			bool flag = t < 1f;
			float num;
			if (flag)
			{
				num = Easing.InPower(t, power) * 0.5f;
			}
			else
			{
				int num2 = ((power % 2 == 0) ? (-1) : 1);
				num = (float)num2 * 0.5f * (Mathf.Pow(t - 2f, (float)power) + (float)(num2 * 2));
			}
			return num;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0000F7D4 File Offset: 0x0000D9D4
		public static float InBounce(float t)
		{
			return 1f - Easing.OutBounce(1f - t);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		public static float OutBounce(float t)
		{
			bool flag = t < 0.36363637f;
			float num;
			if (flag)
			{
				num = 7.5625f * t * t;
			}
			else
			{
				bool flag2 = t < 0.72727275f;
				if (flag2)
				{
					float num2;
					t = (num2 = t - 0.54545456f);
					num = 7.5625f * num2 * t + 0.75f;
				}
				else
				{
					bool flag3 = t < 0.90909094f;
					if (flag3)
					{
						float num3;
						t = (num3 = t - 0.8181818f);
						num = 7.5625f * num3 * t + 0.9375f;
					}
					else
					{
						float num4;
						t = (num4 = t - 0.95454544f);
						num = 7.5625f * num4 * t + 0.984375f;
					}
				}
			}
			return num;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0000F898 File Offset: 0x0000DA98
		public static float InOutBounce(float t)
		{
			bool flag = t < 0.5f;
			float num;
			if (flag)
			{
				num = Easing.InBounce(t * 2f) * 0.5f;
			}
			else
			{
				num = Easing.OutBounce((t - 0.5f) * 2f) * 0.5f + 0.5f;
			}
			return num;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0000F8EC File Offset: 0x0000DAEC
		public static float InElastic(float t)
		{
			bool flag = t == 0f;
			float num;
			if (flag)
			{
				num = 0f;
			}
			else
			{
				bool flag2 = t == 1f;
				if (flag2)
				{
					num = 1f;
				}
				else
				{
					float num2 = 0.3f;
					float num3 = num2 / 4f;
					float num4 = Mathf.Pow(2f, 10f * (t -= 1f));
					num = -(num4 * Mathf.Sin((t - num3) * 6.2831855f / num2));
				}
			}
			return num;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0000F968 File Offset: 0x0000DB68
		public static float OutElastic(float t)
		{
			bool flag = t == 0f;
			float num;
			if (flag)
			{
				num = 0f;
			}
			else
			{
				bool flag2 = t == 1f;
				if (flag2)
				{
					num = 1f;
				}
				else
				{
					float num2 = 0.3f;
					float num3 = num2 / 4f;
					num = Mathf.Pow(2f, -10f * t) * Mathf.Sin((t - num3) * 6.2831855f / num2) + 1f;
				}
			}
			return num;
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0000F9DC File Offset: 0x0000DBDC
		public static float InOutElastic(float t)
		{
			bool flag = t < 0.5f;
			float num;
			if (flag)
			{
				num = Easing.InElastic(t * 2f) * 0.5f;
			}
			else
			{
				num = Easing.OutElastic((t - 0.5f) * 2f) * 0.5f + 0.5f;
			}
			return num;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0000FA30 File Offset: 0x0000DC30
		public static float InBack(float t)
		{
			float num = 1.70158f;
			return t * t * ((num + 1f) * t - num);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0000FA58 File Offset: 0x0000DC58
		public static float OutBack(float t)
		{
			return 1f - Easing.InBack(1f - t);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0000FA7C File Offset: 0x0000DC7C
		public static float InOutBack(float t)
		{
			bool flag = t < 0.5f;
			float num;
			if (flag)
			{
				num = Easing.InBack(t * 2f) * 0.5f;
			}
			else
			{
				num = Easing.OutBack((t - 0.5f) * 2f) * 0.5f + 0.5f;
			}
			return num;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0000FAD0 File Offset: 0x0000DCD0
		public static float InBack(float t, float s)
		{
			return t * t * ((s + 1f) * t - s);
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0000FAF4 File Offset: 0x0000DCF4
		public static float OutBack(float t, float s)
		{
			return 1f - Easing.InBack(1f - t, s);
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0000FB1C File Offset: 0x0000DD1C
		public static float InOutBack(float t, float s)
		{
			bool flag = t < 0.5f;
			float num;
			if (flag)
			{
				num = Easing.InBack(t * 2f, s) * 0.5f;
			}
			else
			{
				num = Easing.OutBack((t - 0.5f) * 2f, s) * 0.5f + 0.5f;
			}
			return num;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0000FB74 File Offset: 0x0000DD74
		public static float InCirc(float t)
		{
			return -(Mathf.Sqrt(1f - t * t) - 1f);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		public static float OutCirc(float t)
		{
			t -= 1f;
			return Mathf.Sqrt(1f - t * t);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0000FBC8 File Offset: 0x0000DDC8
		public static float InOutCirc(float t)
		{
			t *= 2f;
			bool flag = t < 1f;
			float num;
			if (flag)
			{
				num = -0.5f * (Mathf.Sqrt(1f - t * t) - 1f);
			}
			else
			{
				t -= 2f;
				num = 0.5f * (Mathf.Sqrt(1f - t * t) + 1f);
			}
			return num;
		}

		// Token: 0x04000229 RID: 553
		public const float HalfPi = 1.5707964f;
	}
}
