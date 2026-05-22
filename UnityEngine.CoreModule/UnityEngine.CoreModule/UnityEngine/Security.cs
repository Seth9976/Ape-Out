using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x0200025A RID: 602
	public sealed class Security
	{
		// Token: 0x060021C9 RID: 8649 RVA: 0x00076E4C File Offset: 0x0007504C
		public static Assembly LoadAndVerifyAssembly(Il2CppStructArray<byte> assemblyData, string authorizationKey)
		{
			return null;
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x00076E60 File Offset: 0x00075060
		public static Assembly LoadAndVerifyAssembly(Il2CppStructArray<byte> assemblyData)
		{
			return null;
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x00076E74 File Offset: 0x00075074
		public static bool PrefetchSocketPolicy(string ip, int atPort)
		{
			int num = 3000;
			return Security.PrefetchSocketPolicy(ip, atPort, num);
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00076E94 File Offset: 0x00075094
		public static bool PrefetchSocketPolicy(string ip, int atPort, int timeout)
		{
			return false;
		}
	}
}
