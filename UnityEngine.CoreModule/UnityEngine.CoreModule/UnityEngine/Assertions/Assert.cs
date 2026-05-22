using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Assertions.Comparers;

namespace UnityEngine.Assertions
{
	// Token: 0x020002DB RID: 731
	public static class Assert
	{
		// Token: 0x06002352 RID: 9042 RVA: 0x000130CA File Offset: 0x000112CA
		public static void Fail(string message, string userMessage)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x000130D7 File Offset: 0x000112D7
		public static bool Equals(Object obj1, Object obj2)
		{
			throw new InvalidOperationException("Assert.Equals should not be used for Assertions");
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x000130E4 File Offset: 0x000112E4
		public static bool ReferenceEquals(Object obj1, Object obj2)
		{
			throw new InvalidOperationException("Assert.ReferenceEquals should not be used for Assertions");
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x00078D28 File Offset: 0x00076F28
		public static void IsTrue(bool condition)
		{
			bool flag = !condition;
			if (flag)
			{
				Assert.IsTrue(condition, null);
			}
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x00078D48 File Offset: 0x00076F48
		public static void IsTrue(bool condition, string message)
		{
			bool flag = !condition;
			if (flag)
			{
				Assert.Fail(AssertionMessageUtil.BooleanFailureMessage(true), message);
			}
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x00078D6C File Offset: 0x00076F6C
		public static void IsFalse(bool condition)
		{
			if (condition)
			{
				Assert.IsFalse(condition, null);
			}
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x00078D88 File Offset: 0x00076F88
		public static void IsFalse(bool condition, string message)
		{
			if (condition)
			{
				Assert.Fail(AssertionMessageUtil.BooleanFailureMessage(false), message);
			}
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x000130F1 File Offset: 0x000112F1
		public static void AreApproximatelyEqual(float expected, float actual)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x000130FE File Offset: 0x000112FE
		public static void AreApproximatelyEqual(float expected, float actual, string message)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x0001310B File Offset: 0x0001130B
		public static void AreApproximatelyEqual(float expected, float actual, float tolerance)
		{
			Assert.AreApproximatelyEqual(expected, actual, tolerance, null);
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x00013118 File Offset: 0x00011318
		public static void AreApproximatelyEqual(float expected, float actual, float tolerance, string message)
		{
			Assert.AreEqual<float>(expected, actual, message, new UnityEngine.Assertions.Comparers.FloatComparer(tolerance));
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x0001312A File Offset: 0x0001132A
		public static void AreNotApproximatelyEqual(float expected, float actual)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x00013137 File Offset: 0x00011337
		public static void AreNotApproximatelyEqual(float expected, float actual, string message)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x00013144 File Offset: 0x00011344
		public static void AreNotApproximatelyEqual(float expected, float actual, float tolerance)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance, null);
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x00013151 File Offset: 0x00011351
		public static void AreNotApproximatelyEqual(float expected, float actual, float tolerance, string message)
		{
			Assert.AreNotEqual<float>(expected, actual, message, new UnityEngine.Assertions.Comparers.FloatComparer(tolerance));
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x00013163 File Offset: 0x00011363
		public static void AreEqual<T>(T expected, T actual)
		{
			Assert.AreEqual<T>(expected, actual, null);
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x0001316F File Offset: 0x0001136F
		public static void AreEqual<T>(T expected, T actual, string message)
		{
			Assert.AreEqual<T>(expected, actual, message, EqualityComparer<T>.Default);
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x00078DA8 File Offset: 0x00076FA8
		public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer)
		{
			bool flag = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()).IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag)
			{
				Assert.AreEqual(expected.TryCast<Object>(), actual.TryCast<Object>(), message);
			}
			else
			{
				bool flag2 = !comparer.Equals(actual, expected);
				if (flag2)
				{
					Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, true), message);
				}
			}
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x00078E1C File Offset: 0x0007701C
		public static void AreEqual(Object expected, Object actual, string message)
		{
			bool flag = actual != expected;
			if (flag)
			{
				Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, true), message);
			}
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x00013180 File Offset: 0x00011380
		public static void AreNotEqual<T>(T expected, T actual)
		{
			Assert.AreNotEqual<T>(expected, actual, null);
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x0001318C File Offset: 0x0001138C
		public static void AreNotEqual<T>(T expected, T actual, string message)
		{
			Assert.AreNotEqual<T>(expected, actual, message, EqualityComparer<T>.Default);
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x00078E44 File Offset: 0x00077044
		public static void AreNotEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer)
		{
			bool flag = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()).IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag)
			{
				Assert.AreNotEqual(expected.TryCast<Object>(), actual.TryCast<Object>(), message);
			}
			else
			{
				bool flag2 = comparer.Equals(actual, expected);
				if (flag2)
				{
					Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, false), message);
				}
			}
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x00078EB4 File Offset: 0x000770B4
		public static void AreNotEqual(Object expected, Object actual, string message)
		{
			bool flag = actual == expected;
			if (flag)
			{
				Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, false), message);
			}
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x0001319D File Offset: 0x0001139D
		public static void IsNull<T>(T value) where T : class
		{
			Assert.IsNull<T>(value, null);
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x00078EDC File Offset: 0x000770DC
		public static void IsNull<T>(T value, string message) where T : class
		{
			bool flag = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()).IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag)
			{
				Assert.IsNull(value.TryCast<Object>(), message);
			}
			else
			{
				bool flag2 = value != null;
				if (flag2)
				{
					Assert.Fail(AssertionMessageUtil.NullFailureMessage(value, true), message);
				}
			}
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x00078F40 File Offset: 0x00077140
		public static void IsNull(Object value, string message)
		{
			bool flag = value != null;
			if (flag)
			{
				Assert.Fail(AssertionMessageUtil.NullFailureMessage(value, true), message);
			}
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x000131A8 File Offset: 0x000113A8
		public static void IsNotNull<T>(T value) where T : class
		{
			Assert.IsNotNull<T>(value, null);
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x00078F68 File Offset: 0x00077168
		public static void IsNotNull<T>(T value, string message) where T : class
		{
			bool flag = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()).IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag)
			{
				Assert.IsNotNull(value.TryCast<Object>(), message);
			}
			else
			{
				bool flag2 = value == null;
				if (flag2)
				{
					Assert.Fail(AssertionMessageUtil.NullFailureMessage(value, false), message);
				}
			}
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x00078FCC File Offset: 0x000771CC
		public static void IsNotNull(Object value, string message)
		{
			bool flag = value == null;
			if (flag)
			{
				Assert.Fail(AssertionMessageUtil.NullFailureMessage(value, false), message);
			}
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x00078FF4 File Offset: 0x000771F4
		public static void AreEqual(sbyte expected, sbyte actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<sbyte>(expected, actual, null);
			}
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x00079018 File Offset: 0x00077218
		public static void AreEqual(sbyte expected, sbyte actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<sbyte>(expected, actual, message);
			}
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x0007903C File Offset: 0x0007723C
		public static void AreNotEqual(sbyte expected, sbyte actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<sbyte>(expected, actual, null);
			}
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x0007905C File Offset: 0x0007725C
		public static void AreNotEqual(sbyte expected, sbyte actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<sbyte>(expected, actual, message);
			}
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x0007907C File Offset: 0x0007727C
		public static void AreEqual(byte expected, byte actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<byte>(expected, actual, null);
			}
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x000790A0 File Offset: 0x000772A0
		public static void AreEqual(byte expected, byte actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<byte>(expected, actual, message);
			}
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x000790C4 File Offset: 0x000772C4
		public static void AreNotEqual(byte expected, byte actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<byte>(expected, actual, null);
			}
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x000790E4 File Offset: 0x000772E4
		public static void AreNotEqual(byte expected, byte actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<byte>(expected, actual, message);
			}
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x00079104 File Offset: 0x00077304
		public static void AreEqual(char expected, char actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<char>(expected, actual, null);
			}
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x00079128 File Offset: 0x00077328
		public static void AreEqual(char expected, char actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<char>(expected, actual, message);
			}
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x0007914C File Offset: 0x0007734C
		public static void AreNotEqual(char expected, char actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<char>(expected, actual, null);
			}
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x0007916C File Offset: 0x0007736C
		public static void AreNotEqual(char expected, char actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<char>(expected, actual, message);
			}
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x0007918C File Offset: 0x0007738C
		public static void AreEqual(short expected, short actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<short>(expected, actual, null);
			}
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x000791B0 File Offset: 0x000773B0
		public static void AreEqual(short expected, short actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<short>(expected, actual, message);
			}
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x000791D4 File Offset: 0x000773D4
		public static void AreNotEqual(short expected, short actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<short>(expected, actual, null);
			}
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x000791F4 File Offset: 0x000773F4
		public static void AreNotEqual(short expected, short actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<short>(expected, actual, message);
			}
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x00079214 File Offset: 0x00077414
		public static void AreEqual(ushort expected, ushort actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<ushort>(expected, actual, null);
			}
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x00079238 File Offset: 0x00077438
		public static void AreEqual(ushort expected, ushort actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<ushort>(expected, actual, message);
			}
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x0007925C File Offset: 0x0007745C
		public static void AreNotEqual(ushort expected, ushort actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<ushort>(expected, actual, null);
			}
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x0007927C File Offset: 0x0007747C
		public static void AreNotEqual(ushort expected, ushort actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<ushort>(expected, actual, message);
			}
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x0007929C File Offset: 0x0007749C
		public static void AreEqual(int expected, int actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<int>(expected, actual, null);
			}
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x000792C0 File Offset: 0x000774C0
		public static void AreEqual(int expected, int actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<int>(expected, actual, message);
			}
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x000792E4 File Offset: 0x000774E4
		public static void AreNotEqual(int expected, int actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<int>(expected, actual, null);
			}
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x00079304 File Offset: 0x00077504
		public static void AreNotEqual(int expected, int actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<int>(expected, actual, message);
			}
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x00079324 File Offset: 0x00077524
		public static void AreEqual(uint expected, uint actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<uint>(expected, actual, null);
			}
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x00079348 File Offset: 0x00077548
		public static void AreEqual(uint expected, uint actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<uint>(expected, actual, message);
			}
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x0007936C File Offset: 0x0007756C
		public static void AreNotEqual(uint expected, uint actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<uint>(expected, actual, null);
			}
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x0007938C File Offset: 0x0007758C
		public static void AreNotEqual(uint expected, uint actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<uint>(expected, actual, message);
			}
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x000793AC File Offset: 0x000775AC
		public static void AreEqual(long expected, long actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<long>(expected, actual, null);
			}
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x000793D0 File Offset: 0x000775D0
		public static void AreEqual(long expected, long actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<long>(expected, actual, message);
			}
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x000793F4 File Offset: 0x000775F4
		public static void AreNotEqual(long expected, long actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<long>(expected, actual, null);
			}
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x00079414 File Offset: 0x00077614
		public static void AreNotEqual(long expected, long actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<long>(expected, actual, message);
			}
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x00079434 File Offset: 0x00077634
		public static void AreEqual(ulong expected, ulong actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<ulong>(expected, actual, null);
			}
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x00079458 File Offset: 0x00077658
		public static void AreEqual(ulong expected, ulong actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<ulong>(expected, actual, message);
			}
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x0007947C File Offset: 0x0007767C
		public static void AreNotEqual(ulong expected, ulong actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<ulong>(expected, actual, null);
			}
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x0007949C File Offset: 0x0007769C
		public static void AreNotEqual(ulong expected, ulong actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<ulong>(expected, actual, message);
			}
		}

		// Token: 0x04001E42 RID: 7746
		public const string UNITY_ASSERTIONS = "UNITY_ASSERTIONS";
	}
}
