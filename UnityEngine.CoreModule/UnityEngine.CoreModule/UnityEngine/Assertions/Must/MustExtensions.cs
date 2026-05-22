using System;

namespace UnityEngine.Assertions.Must
{
	// Token: 0x020002DE RID: 734
	public static class MustExtensions
	{
		// Token: 0x06002399 RID: 9113 RVA: 0x000131F4 File Offset: 0x000113F4
		public static void MustBeTrue(bool value)
		{
			Assert.IsTrue(value);
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x000131FE File Offset: 0x000113FE
		public static void MustBeTrue(bool value, string message)
		{
			Assert.IsTrue(value, message);
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00013209 File Offset: 0x00011409
		public static void MustBeFalse(bool value)
		{
			Assert.IsFalse(value);
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x00013213 File Offset: 0x00011413
		public static void MustBeFalse(bool value, string message)
		{
			Assert.IsFalse(value, message);
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x0001321E File Offset: 0x0001141E
		public static void MustBeApproximatelyEqual(float actual, float expected)
		{
			Assert.AreApproximatelyEqual(actual, expected);
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x00013229 File Offset: 0x00011429
		public static void MustBeApproximatelyEqual(float actual, float expected, string message)
		{
			Assert.AreApproximatelyEqual(actual, expected, message);
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x00013235 File Offset: 0x00011435
		public static void MustBeApproximatelyEqual(float actual, float expected, float tolerance)
		{
			Assert.AreApproximatelyEqual(actual, expected, tolerance);
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x00013241 File Offset: 0x00011441
		public static void MustBeApproximatelyEqual(float actual, float expected, float tolerance, string message)
		{
			Assert.AreApproximatelyEqual(expected, actual, tolerance, message);
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x0001324E File Offset: 0x0001144E
		public static void MustNotBeApproximatelyEqual(float actual, float expected)
		{
			Assert.AreNotApproximatelyEqual(expected, actual);
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x00013259 File Offset: 0x00011459
		public static void MustNotBeApproximatelyEqual(float actual, float expected, string message)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, message);
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x00013265 File Offset: 0x00011465
		public static void MustNotBeApproximatelyEqual(float actual, float expected, float tolerance)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance);
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x00013271 File Offset: 0x00011471
		public static void MustNotBeApproximatelyEqual(float actual, float expected, float tolerance, string message)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance, message);
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x0001327E File Offset: 0x0001147E
		public static void MustBeEqual<T>(T actual, T expected)
		{
			Assert.AreEqual<T>(actual, expected);
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x00013289 File Offset: 0x00011489
		public static void MustBeEqual<T>(T actual, T expected, string message)
		{
			Assert.AreEqual<T>(expected, actual, message);
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x00013295 File Offset: 0x00011495
		public static void MustNotBeEqual<T>(T actual, T expected)
		{
			Assert.AreNotEqual<T>(actual, expected);
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x000132A0 File Offset: 0x000114A0
		public static void MustNotBeEqual<T>(T actual, T expected, string message)
		{
			Assert.AreNotEqual<T>(expected, actual, message);
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x000132AC File Offset: 0x000114AC
		public static void MustBeNull<T>(T expected) where T : class
		{
			Assert.IsNull<T>(expected);
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x000132B6 File Offset: 0x000114B6
		public static void MustBeNull<T>(T expected, string message) where T : class
		{
			Assert.IsNull<T>(expected, message);
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x000132C1 File Offset: 0x000114C1
		public static void MustNotBeNull<T>(T expected) where T : class
		{
			Assert.IsNotNull<T>(expected);
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x000132CB File Offset: 0x000114CB
		public static void MustNotBeNull<T>(T expected, string message) where T : class
		{
			Assert.IsNotNull<T>(expected, message);
		}
	}
}
