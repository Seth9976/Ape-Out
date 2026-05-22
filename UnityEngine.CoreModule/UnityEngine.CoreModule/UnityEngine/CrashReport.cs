using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020001FE RID: 510
	public sealed class CrashReport
	{
		// Token: 0x06002043 RID: 8259 RVA: 0x00010C48 File Offset: 0x0000EE48
		public static int Compare(CrashReport c1, CrashReport c2)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x00010C55 File Offset: 0x0000EE55
		public static void PopulateReports()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x00010C62 File Offset: 0x0000EE62
		public static Il2CppReferenceArray<CrashReport> reports
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06002046 RID: 8262 RVA: 0x00010C6F File Offset: 0x0000EE6F
		public static CrashReport lastReport
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x00010C7C File Offset: 0x0000EE7C
		public static void RemoveAll()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x00010C89 File Offset: 0x0000EE89
		public void Remove()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x0007453C File Offset: 0x0007273C
		public static Il2CppStringArray GetReports()
		{
			IntPtr intPtr = CrashReport.GetReportsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00074564 File Offset: 0x00072764
		public static string GetReportData(string id, out double secondsSinceUnixEpoch)
		{
			IntPtr intPtr = CrashReport.GetReportDataDelegateField(IL2CPP.ManagedStringToIl2Cpp(id), out secondsSinceUnixEpoch);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00010C96 File Offset: 0x0000EE96
		public static bool RemoveReport(string id)
		{
			return CrashReport.RemoveReportDelegateField(IL2CPP.ManagedStringToIl2Cpp(id));
		}

		// Token: 0x04001A6E RID: 6766
		private static readonly CrashReport.GetReportsDelegate GetReportsDelegateField = IL2CPP.ResolveICall<CrashReport.GetReportsDelegate>("UnityEngine.CrashReport::GetReports");

		// Token: 0x04001A6F RID: 6767
		private static readonly CrashReport.GetReportDataDelegate GetReportDataDelegateField = IL2CPP.ResolveICall<CrashReport.GetReportDataDelegate>("UnityEngine.CrashReport::GetReportData");

		// Token: 0x04001A70 RID: 6768
		private static readonly CrashReport.RemoveReportDelegate RemoveReportDelegateField = IL2CPP.ResolveICall<CrashReport.RemoveReportDelegate>("UnityEngine.CrashReport::RemoveReport");

		// Token: 0x02000AD1 RID: 2769
		// (Invoke) Token: 0x06003406 RID: 13318
		private delegate IntPtr GetReportsDelegate();

		// Token: 0x02000AD2 RID: 2770
		// (Invoke) Token: 0x06003408 RID: 13320
		private delegate IntPtr GetReportDataDelegate(IntPtr id, [Out] IntPtr secondsSinceUnixEpoch);

		// Token: 0x02000AD3 RID: 2771
		// (Invoke) Token: 0x0600340A RID: 13322
		private delegate bool RemoveReportDelegate(IntPtr id);
	}
}
