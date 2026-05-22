using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.XR.Provider
{
	// Token: 0x02000025 RID: 37
	public static class XRStats
	{
		// Token: 0x0600015A RID: 346 RVA: 0x00005954 File Offset: 0x00003B54
		public static bool TryGetStat(IntegratedSubsystem xrSubsystem, string tag, out float value)
		{
			return XRStats.TryGetStat_Internal(xrSubsystem.m_Ptr, tag, out value);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002D55 File Offset: 0x00000F55
		public static bool TryGetStat_Internal(IntPtr ptr, string tag, out float value)
		{
			return XRStats.TryGetStat_InternalDelegateField(ptr, IL2CPP.ManagedStringToIl2Cpp(tag), out value);
		}

		// Token: 0x0400013D RID: 317
		private static readonly XRStats.TryGetStat_InternalDelegate TryGetStat_InternalDelegateField = IL2CPP.ResolveICall<XRStats.TryGetStat_InternalDelegate>("UnityEngine.XR.Provider.XRStats::TryGetStat_Internal");

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x06000225 RID: 549
		private delegate bool TryGetStat_InternalDelegate(IntPtr ptr, IntPtr tag, [Out] IntPtr value);
	}
}
