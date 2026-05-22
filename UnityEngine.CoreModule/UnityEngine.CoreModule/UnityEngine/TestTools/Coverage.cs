using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.TestTools
{
	// Token: 0x020002E3 RID: 739
	public static class Coverage
	{
		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x000133A7 File Offset: 0x000115A7
		// (set) Token: 0x060023BE RID: 9150 RVA: 0x000133B3 File Offset: 0x000115B3
		public static bool enabled
		{
			get
			{
				return Coverage.get_enabledDelegateField();
			}
			set
			{
				Coverage.set_enabledDelegateField(value);
			}
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x000133C0 File Offset: 0x000115C0
		public static void ResetFor_Internal(MethodBase method)
		{
			Coverage.ResetFor_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(method));
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x000796FC File Offset: 0x000778FC
		public static void ResetFor(MethodBase method)
		{
			bool flag = method == null;
			if (flag)
			{
				throw new ArgumentNullException("method");
			}
			Coverage.ResetFor_Internal(method);
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x000133D2 File Offset: 0x000115D2
		public static void ResetAll()
		{
			Coverage.ResetAllDelegateField();
		}

		// Token: 0x04001E4D RID: 7757
		private static readonly Coverage.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<Coverage.get_enabledDelegate>("UnityEngine.TestTools.Coverage::get_enabled");

		// Token: 0x04001E4E RID: 7758
		private static readonly Coverage.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<Coverage.set_enabledDelegate>("UnityEngine.TestTools.Coverage::set_enabled");

		// Token: 0x04001E4F RID: 7759
		private static readonly Coverage.ResetFor_InternalDelegate ResetFor_InternalDelegateField = IL2CPP.ResolveICall<Coverage.ResetFor_InternalDelegate>("UnityEngine.TestTools.Coverage::ResetFor_Internal");

		// Token: 0x04001E50 RID: 7760
		private static readonly Coverage.ResetAllDelegate ResetAllDelegateField = IL2CPP.ResolveICall<Coverage.ResetAllDelegate>("UnityEngine.TestTools.Coverage::ResetAll");

		// Token: 0x02000C33 RID: 3123
		// (Invoke) Token: 0x060036B8 RID: 14008
		private delegate bool get_enabledDelegate();

		// Token: 0x02000C34 RID: 3124
		// (Invoke) Token: 0x060036BA RID: 14010
		private delegate void set_enabledDelegate(bool value);

		// Token: 0x02000C35 RID: 3125
		// (Invoke) Token: 0x060036BC RID: 14012
		private delegate void ResetFor_InternalDelegate(IntPtr method);

		// Token: 0x02000C36 RID: 3126
		// (Invoke) Token: 0x060036BE RID: 14014
		private delegate void ResetAllDelegate();
	}
}
