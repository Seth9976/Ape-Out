using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.IO
{
	// Token: 0x020002C8 RID: 712
	public static class File
	{
		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x00078918 File Offset: 0x00076B18
		public static ulong totalOpenCalls
		{
			get
			{
				return File.GetTotalOpenCalls();
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060022DA RID: 8922 RVA: 0x00078930 File Offset: 0x00076B30
		public static ulong totalCloseCalls
		{
			get
			{
				return File.GetTotalCloseCalls();
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x00078948 File Offset: 0x00076B48
		public static ulong totalReadCalls
		{
			get
			{
				return File.GetTotalReadCalls();
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x00078960 File Offset: 0x00076B60
		public static ulong totalWriteCalls
		{
			get
			{
				return File.GetTotalWriteCalls();
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x00078978 File Offset: 0x00076B78
		public static ulong totalSeekCalls
		{
			get
			{
				return File.GetTotalSeekCalls();
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x00078990 File Offset: 0x00076B90
		public static ulong totalZeroSeekCalls
		{
			get
			{
				return File.GetTotalZeroSeekCalls();
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x000789A8 File Offset: 0x00076BA8
		public static ulong totalFilesOpened
		{
			get
			{
				return File.GetTotalFilesOpened();
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x000789C0 File Offset: 0x00076BC0
		public static ulong totalFilesClosed
		{
			get
			{
				return File.GetTotalFilesClosed();
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x000789D8 File Offset: 0x00076BD8
		public static ulong totalBytesRead
		{
			get
			{
				return File.GetTotalBytesRead();
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x000789F0 File Offset: 0x00076BF0
		public static ulong totalBytesWritten
		{
			get
			{
				return File.GetTotalBytesWritten();
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x00078A08 File Offset: 0x00076C08
		// (set) Token: 0x060022E3 RID: 8931 RVA: 0x000129E6 File Offset: 0x00010BE6
		public static bool recordZeroSeeks
		{
			get
			{
				return File.GetRecordZeroSeeks();
			}
			set
			{
				File.SetRecordZeroSeeks(value);
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x00078A20 File Offset: 0x00076C20
		// (set) Token: 0x060022E6 RID: 8934 RVA: 0x000129F0 File Offset: 0x00010BF0
		public static ThreadIORestrictionMode MainThreadIORestrictionMode
		{
			get
			{
				return File.GetMainThreadFileIORestriction();
			}
			set
			{
				File.SetMainThreadFileIORestriction(value);
			}
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x000129FA File Offset: 0x00010BFA
		public static void SetRecordZeroSeeks(bool enable)
		{
			File.SetRecordZeroSeeksDelegateField(enable);
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x00012A07 File Offset: 0x00010C07
		public static bool GetRecordZeroSeeks()
		{
			return File.GetRecordZeroSeeksDelegateField();
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x00012A13 File Offset: 0x00010C13
		public static ulong GetTotalOpenCalls()
		{
			return File.GetTotalOpenCallsDelegateField();
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00012A1F File Offset: 0x00010C1F
		public static ulong GetTotalCloseCalls()
		{
			return File.GetTotalCloseCallsDelegateField();
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00012A2B File Offset: 0x00010C2B
		public static ulong GetTotalReadCalls()
		{
			return File.GetTotalReadCallsDelegateField();
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x00012A37 File Offset: 0x00010C37
		public static ulong GetTotalWriteCalls()
		{
			return File.GetTotalWriteCallsDelegateField();
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x00012A43 File Offset: 0x00010C43
		public static ulong GetTotalSeekCalls()
		{
			return File.GetTotalSeekCallsDelegateField();
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x00012A4F File Offset: 0x00010C4F
		public static ulong GetTotalZeroSeekCalls()
		{
			return File.GetTotalZeroSeekCallsDelegateField();
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00012A5B File Offset: 0x00010C5B
		public static ulong GetTotalFilesOpened()
		{
			return File.GetTotalFilesOpenedDelegateField();
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x00012A67 File Offset: 0x00010C67
		public static ulong GetTotalFilesClosed()
		{
			return File.GetTotalFilesClosedDelegateField();
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x00012A73 File Offset: 0x00010C73
		public static ulong GetTotalBytesRead()
		{
			return File.GetTotalBytesReadDelegateField();
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x00012A7F File Offset: 0x00010C7F
		public static ulong GetTotalBytesWritten()
		{
			return File.GetTotalBytesWrittenDelegateField();
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x00012A8B File Offset: 0x00010C8B
		public static void SetMainThreadFileIORestriction(ThreadIORestrictionMode mode)
		{
			File.SetMainThreadFileIORestrictionDelegateField(mode);
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x00012A98 File Offset: 0x00010C98
		public static ThreadIORestrictionMode GetMainThreadFileIORestriction()
		{
			return File.GetMainThreadFileIORestrictionDelegateField();
		}

		// Token: 0x04001DF0 RID: 7664
		private static readonly File.SetRecordZeroSeeksDelegate SetRecordZeroSeeksDelegateField = IL2CPP.ResolveICall<File.SetRecordZeroSeeksDelegate>("UnityEngine.IO.File::SetRecordZeroSeeks");

		// Token: 0x04001DF1 RID: 7665
		private static readonly File.GetRecordZeroSeeksDelegate GetRecordZeroSeeksDelegateField = IL2CPP.ResolveICall<File.GetRecordZeroSeeksDelegate>("UnityEngine.IO.File::GetRecordZeroSeeks");

		// Token: 0x04001DF2 RID: 7666
		private static readonly File.GetTotalOpenCallsDelegate GetTotalOpenCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalOpenCallsDelegate>("UnityEngine.IO.File::GetTotalOpenCalls");

		// Token: 0x04001DF3 RID: 7667
		private static readonly File.GetTotalCloseCallsDelegate GetTotalCloseCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalCloseCallsDelegate>("UnityEngine.IO.File::GetTotalCloseCalls");

		// Token: 0x04001DF4 RID: 7668
		private static readonly File.GetTotalReadCallsDelegate GetTotalReadCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalReadCallsDelegate>("UnityEngine.IO.File::GetTotalReadCalls");

		// Token: 0x04001DF5 RID: 7669
		private static readonly File.GetTotalWriteCallsDelegate GetTotalWriteCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalWriteCallsDelegate>("UnityEngine.IO.File::GetTotalWriteCalls");

		// Token: 0x04001DF6 RID: 7670
		private static readonly File.GetTotalSeekCallsDelegate GetTotalSeekCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalSeekCallsDelegate>("UnityEngine.IO.File::GetTotalSeekCalls");

		// Token: 0x04001DF7 RID: 7671
		private static readonly File.GetTotalZeroSeekCallsDelegate GetTotalZeroSeekCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalZeroSeekCallsDelegate>("UnityEngine.IO.File::GetTotalZeroSeekCalls");

		// Token: 0x04001DF8 RID: 7672
		private static readonly File.GetTotalFilesOpenedDelegate GetTotalFilesOpenedDelegateField = IL2CPP.ResolveICall<File.GetTotalFilesOpenedDelegate>("UnityEngine.IO.File::GetTotalFilesOpened");

		// Token: 0x04001DF9 RID: 7673
		private static readonly File.GetTotalFilesClosedDelegate GetTotalFilesClosedDelegateField = IL2CPP.ResolveICall<File.GetTotalFilesClosedDelegate>("UnityEngine.IO.File::GetTotalFilesClosed");

		// Token: 0x04001DFA RID: 7674
		private static readonly File.GetTotalBytesReadDelegate GetTotalBytesReadDelegateField = IL2CPP.ResolveICall<File.GetTotalBytesReadDelegate>("UnityEngine.IO.File::GetTotalBytesRead");

		// Token: 0x04001DFB RID: 7675
		private static readonly File.GetTotalBytesWrittenDelegate GetTotalBytesWrittenDelegateField = IL2CPP.ResolveICall<File.GetTotalBytesWrittenDelegate>("UnityEngine.IO.File::GetTotalBytesWritten");

		// Token: 0x04001DFC RID: 7676
		private static readonly File.SetMainThreadFileIORestrictionDelegate SetMainThreadFileIORestrictionDelegateField = IL2CPP.ResolveICall<File.SetMainThreadFileIORestrictionDelegate>("UnityEngine.IO.File::SetMainThreadFileIORestriction");

		// Token: 0x04001DFD RID: 7677
		private static readonly File.GetMainThreadFileIORestrictionDelegate GetMainThreadFileIORestrictionDelegateField = IL2CPP.ResolveICall<File.GetMainThreadFileIORestrictionDelegate>("UnityEngine.IO.File::GetMainThreadFileIORestriction");

		// Token: 0x02000BF8 RID: 3064
		// (Invoke) Token: 0x06003646 RID: 13894
		private delegate void SetRecordZeroSeeksDelegate(bool enable);

		// Token: 0x02000BF9 RID: 3065
		// (Invoke) Token: 0x06003648 RID: 13896
		private delegate bool GetRecordZeroSeeksDelegate();

		// Token: 0x02000BFA RID: 3066
		// (Invoke) Token: 0x0600364A RID: 13898
		private delegate ulong GetTotalOpenCallsDelegate();

		// Token: 0x02000BFB RID: 3067
		// (Invoke) Token: 0x0600364C RID: 13900
		private delegate ulong GetTotalCloseCallsDelegate();

		// Token: 0x02000BFC RID: 3068
		// (Invoke) Token: 0x0600364E RID: 13902
		private delegate ulong GetTotalReadCallsDelegate();

		// Token: 0x02000BFD RID: 3069
		// (Invoke) Token: 0x06003650 RID: 13904
		private delegate ulong GetTotalWriteCallsDelegate();

		// Token: 0x02000BFE RID: 3070
		// (Invoke) Token: 0x06003652 RID: 13906
		private delegate ulong GetTotalSeekCallsDelegate();

		// Token: 0x02000BFF RID: 3071
		// (Invoke) Token: 0x06003654 RID: 13908
		private delegate ulong GetTotalZeroSeekCallsDelegate();

		// Token: 0x02000C00 RID: 3072
		// (Invoke) Token: 0x06003656 RID: 13910
		private delegate ulong GetTotalFilesOpenedDelegate();

		// Token: 0x02000C01 RID: 3073
		// (Invoke) Token: 0x06003658 RID: 13912
		private delegate ulong GetTotalFilesClosedDelegate();

		// Token: 0x02000C02 RID: 3074
		// (Invoke) Token: 0x0600365A RID: 13914
		private delegate ulong GetTotalBytesReadDelegate();

		// Token: 0x02000C03 RID: 3075
		// (Invoke) Token: 0x0600365C RID: 13916
		private delegate ulong GetTotalBytesWrittenDelegate();

		// Token: 0x02000C04 RID: 3076
		// (Invoke) Token: 0x0600365E RID: 13918
		private delegate void SetMainThreadFileIORestrictionDelegate(ThreadIORestrictionMode mode);

		// Token: 0x02000C05 RID: 3077
		// (Invoke) Token: 0x06003660 RID: 13920
		private delegate ThreadIORestrictionMode GetMainThreadFileIORestrictionDelegate();
	}
}
