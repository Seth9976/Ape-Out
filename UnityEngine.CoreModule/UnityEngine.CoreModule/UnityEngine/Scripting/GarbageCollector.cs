using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting
{
	// Token: 0x02000280 RID: 640
	public static class GarbageCollector
	{
		// Token: 0x06002298 RID: 8856 RVA: 0x00012756 File Offset: 0x00010956
		public static void add_GCModeChanged(Action<GarbageCollector.Mode> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x00012763 File Offset: 0x00010963
		public static void remove_GCModeChanged(Action<GarbageCollector.Mode> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x00078420 File Offset: 0x00076620
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x00012770 File Offset: 0x00010970
		public static GarbageCollector.Mode GCMode
		{
			get
			{
				return GarbageCollector.GetMode();
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x0001277D File Offset: 0x0001097D
		public static void SetMode(GarbageCollector.Mode mode)
		{
			GarbageCollector.SetModeDelegateField(mode);
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x0001278A File Offset: 0x0001098A
		public static GarbageCollector.Mode GetMode()
		{
			return GarbageCollector.GetModeDelegateField();
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x0600229E RID: 8862 RVA: 0x00012796 File Offset: 0x00010996
		public static bool isIncremental
		{
			get
			{
				return GarbageCollector.get_isIncrementalDelegateField();
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x000127A2 File Offset: 0x000109A2
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x000127AE File Offset: 0x000109AE
		public static ulong incrementalTimeSliceNanoseconds
		{
			get
			{
				return GarbageCollector.get_incrementalTimeSliceNanosecondsDelegateField();
			}
			set
			{
				GarbageCollector.set_incrementalTimeSliceNanosecondsDelegateField(value);
			}
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x000127BB File Offset: 0x000109BB
		public static bool CollectIncremental([Optional] ulong nanoseconds)
		{
			return GarbageCollector.CollectIncrementalDelegateField(nanoseconds);
		}

		// Token: 0x04001C81 RID: 7297
		private static readonly GarbageCollector.SetModeDelegate SetModeDelegateField = IL2CPP.ResolveICall<GarbageCollector.SetModeDelegate>("UnityEngine.Scripting.GarbageCollector::SetMode");

		// Token: 0x04001C82 RID: 7298
		private static readonly GarbageCollector.GetModeDelegate GetModeDelegateField = IL2CPP.ResolveICall<GarbageCollector.GetModeDelegate>("UnityEngine.Scripting.GarbageCollector::GetMode");

		// Token: 0x04001C83 RID: 7299
		private static readonly GarbageCollector.get_isIncrementalDelegate get_isIncrementalDelegateField = IL2CPP.ResolveICall<GarbageCollector.get_isIncrementalDelegate>("UnityEngine.Scripting.GarbageCollector::get_isIncremental");

		// Token: 0x04001C84 RID: 7300
		private static readonly GarbageCollector.get_incrementalTimeSliceNanosecondsDelegate get_incrementalTimeSliceNanosecondsDelegateField = IL2CPP.ResolveICall<GarbageCollector.get_incrementalTimeSliceNanosecondsDelegate>("UnityEngine.Scripting.GarbageCollector::get_incrementalTimeSliceNanoseconds");

		// Token: 0x04001C85 RID: 7301
		private static readonly GarbageCollector.set_incrementalTimeSliceNanosecondsDelegate set_incrementalTimeSliceNanosecondsDelegateField = IL2CPP.ResolveICall<GarbageCollector.set_incrementalTimeSliceNanosecondsDelegate>("UnityEngine.Scripting.GarbageCollector::set_incrementalTimeSliceNanoseconds");

		// Token: 0x04001C86 RID: 7302
		private static readonly GarbageCollector.CollectIncrementalDelegate CollectIncrementalDelegateField = IL2CPP.ResolveICall<GarbageCollector.CollectIncrementalDelegate>("UnityEngine.Scripting.GarbageCollector::CollectIncremental");

		// Token: 0x02000BDF RID: 3039
		public enum Mode
		{
			// Token: 0x04002057 RID: 8279
			Disabled,
			// Token: 0x04002058 RID: 8280
			Enabled,
			// Token: 0x04002059 RID: 8281
			Manual
		}

		// Token: 0x02000BE0 RID: 3040
		// (Invoke) Token: 0x06003618 RID: 13848
		private delegate void SetModeDelegate(GarbageCollector.Mode mode);

		// Token: 0x02000BE1 RID: 3041
		// (Invoke) Token: 0x0600361A RID: 13850
		private delegate GarbageCollector.Mode GetModeDelegate();

		// Token: 0x02000BE2 RID: 3042
		// (Invoke) Token: 0x0600361C RID: 13852
		private delegate bool get_isIncrementalDelegate();

		// Token: 0x02000BE3 RID: 3043
		// (Invoke) Token: 0x0600361E RID: 13854
		private delegate ulong get_incrementalTimeSliceNanosecondsDelegate();

		// Token: 0x02000BE4 RID: 3044
		// (Invoke) Token: 0x06003620 RID: 13856
		private delegate void set_incrementalTimeSliceNanosecondsDelegate(ulong value);

		// Token: 0x02000BE5 RID: 3045
		// (Invoke) Token: 0x06003622 RID: 13858
		private delegate bool CollectIncrementalDelegate(ulong nanoseconds);
	}
}
