using System;
using Il2CppSystem;

namespace UnityEngine.Assertions
{
	// Token: 0x020002DD RID: 733
	public class AssertionMessageUtil
	{
		// Token: 0x06002394 RID: 9108 RVA: 0x000131C0 File Offset: 0x000113C0
		public static string GetMessage(string failureMessage)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x000131CD File Offset: 0x000113CD
		public static string GetMessage(string failureMessage, string expected)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x000131DA File Offset: 0x000113DA
		public static string GetEqualityMessage(Object actual, Object expected, bool expectEqual)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x000131E7 File Offset: 0x000113E7
		public static string NullFailureMessage(Object value, bool expectNull)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x000794BC File Offset: 0x000776BC
		public static string BooleanFailureMessage(bool expected)
		{
			return AssertionMessageUtil.GetMessage(String.Concat("Value was ", (!expected).ToString()), expected.ToString());
		}

		// Token: 0x04001E43 RID: 7747
		public const string k_Expected = "Expected:";

		// Token: 0x04001E44 RID: 7748
		public const string k_AssertionFailed = "Assertion failure.";
	}
}
