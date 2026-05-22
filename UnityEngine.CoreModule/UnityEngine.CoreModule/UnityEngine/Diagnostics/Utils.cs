using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Diagnostics
{
	// Token: 0x020002CD RID: 717
	public static class Utils
	{
		// Token: 0x060022F7 RID: 8951 RVA: 0x00012AEF File Offset: 0x00010CEF
		public static void ForceCrash(ForcedCrashCategory crashCategory)
		{
			Utils.ForceCrashDelegateField(crashCategory);
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x00012AFC File Offset: 0x00010CFC
		public static void NativeAssert(string message)
		{
			Utils.NativeAssertDelegateField(IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00012B0E File Offset: 0x00010D0E
		public static void NativeError(string message)
		{
			Utils.NativeErrorDelegateField(IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00012B20 File Offset: 0x00010D20
		public static void NativeWarning(string message)
		{
			Utils.NativeWarningDelegateField(IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x04001E0E RID: 7694
		private static readonly Utils.ForceCrashDelegate ForceCrashDelegateField = IL2CPP.ResolveICall<Utils.ForceCrashDelegate>("UnityEngine.Diagnostics.Utils::ForceCrash");

		// Token: 0x04001E0F RID: 7695
		private static readonly Utils.NativeAssertDelegate NativeAssertDelegateField = IL2CPP.ResolveICall<Utils.NativeAssertDelegate>("UnityEngine.Diagnostics.Utils::NativeAssert");

		// Token: 0x04001E10 RID: 7696
		private static readonly Utils.NativeErrorDelegate NativeErrorDelegateField = IL2CPP.ResolveICall<Utils.NativeErrorDelegate>("UnityEngine.Diagnostics.Utils::NativeError");

		// Token: 0x04001E11 RID: 7697
		private static readonly Utils.NativeWarningDelegate NativeWarningDelegateField = IL2CPP.ResolveICall<Utils.NativeWarningDelegate>("UnityEngine.Diagnostics.Utils::NativeWarning");

		// Token: 0x02000C06 RID: 3078
		// (Invoke) Token: 0x06003662 RID: 13922
		private delegate void ForceCrashDelegate(ForcedCrashCategory crashCategory);

		// Token: 0x02000C07 RID: 3079
		// (Invoke) Token: 0x06003664 RID: 13924
		private delegate void NativeAssertDelegate(IntPtr message);

		// Token: 0x02000C08 RID: 3080
		// (Invoke) Token: 0x06003666 RID: 13926
		private delegate void NativeErrorDelegate(IntPtr message);

		// Token: 0x02000C09 RID: 3081
		// (Invoke) Token: 0x06003668 RID: 13928
		private delegate void NativeWarningDelegate(IntPtr message);
	}
}
