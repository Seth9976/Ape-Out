using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x020001CC RID: 460
	public static class AsyncReadManagerMetrics
	{
		// Token: 0x06001FCC RID: 8140 RVA: 0x00010828 File Offset: 0x0000EA28
		public static bool IsEnabled()
		{
			return AsyncReadManagerMetrics.IsEnabledDelegateField();
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x00010834 File Offset: 0x0000EA34
		public static void ClearMetrics_Internal()
		{
			AsyncReadManagerMetrics.ClearMetrics_InternalDelegateField();
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x00010840 File Offset: 0x0000EA40
		public static void ClearCompletedMetrics()
		{
			AsyncReadManagerMetrics.ClearMetrics_Internal();
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00073DDC File Offset: 0x00071FDC
		public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics_Internal(bool clear)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetMetrics_InternalDelegateField(clear);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AsyncReadManagerRequestMetric>>(intPtr2) : null;
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x00010849 File Offset: 0x0000EA49
		public static void GetMetrics_NoAlloc_Internal(List<AsyncReadManagerRequestMetric> metrics, bool clear)
		{
			AsyncReadManagerMetrics.GetMetrics_NoAlloc_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics), clear);
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x00073E04 File Offset: 0x00072004
		public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics_Filtered_Internal(AsyncReadManagerMetricsFilters filters, bool clear)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetMetrics_Filtered_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(filters), clear);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AsyncReadManagerRequestMetric>>(intPtr2) : null;
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x0001085C File Offset: 0x0000EA5C
		public static void GetMetrics_NoAlloc_Filtered_Internal(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters filters, bool clear)
		{
			AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics), IL2CPP.Il2CppObjectBaseToPtr(filters), clear);
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x00073E34 File Offset: 0x00072034
		public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics(AsyncReadManagerMetricsFilters filters, AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			return AsyncReadManagerMetrics.GetMetrics_Filtered_Internal(filters, flag);
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x00073E58 File Offset: 0x00072058
		public static void GetMetrics(List<AsyncReadManagerRequestMetric> outMetrics, AsyncReadManagerMetricsFilters filters, AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_Internal(outMetrics, filters, flag);
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x00073E7C File Offset: 0x0007207C
		public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics(AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			return AsyncReadManagerMetrics.GetMetrics_Internal(flag);
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x00073EA0 File Offset: 0x000720A0
		public static void GetMetrics(List<AsyncReadManagerRequestMetric> outMetrics, AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			AsyncReadManagerMetrics.GetMetrics_NoAlloc_Internal(outMetrics, flag);
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x00010875 File Offset: 0x0000EA75
		public static void StartCollectingMetrics()
		{
			AsyncReadManagerMetrics.StartCollectingMetricsDelegateField();
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x00010881 File Offset: 0x0000EA81
		public static void StopCollectingMetrics()
		{
			AsyncReadManagerMetrics.StopCollectingMetricsDelegateField();
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00073EC4 File Offset: 0x000720C4
		public static AsyncReadManagerSummaryMetrics GetSummaryMetrics_Internal(bool clear)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryMetrics_InternalDelegateField(clear);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x00073EEC File Offset: 0x000720EC
		public static AsyncReadManagerSummaryMetrics GetCurrentSummaryMetrics(AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			return AsyncReadManagerMetrics.GetSummaryMetrics_Internal(flag);
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x00073F10 File Offset: 0x00072110
		public static AsyncReadManagerSummaryMetrics GetSummaryMetricsWithFilters_Internal(AsyncReadManagerMetricsFilters metricsFilters, bool clear)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metricsFilters), clear);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x00073F40 File Offset: 0x00072140
		public static AsyncReadManagerSummaryMetrics GetCurrentSummaryMetrics(AsyncReadManagerMetricsFilters metricsFilters, AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			return AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_Internal(metricsFilters, flag);
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x00073F64 File Offset: 0x00072164
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics_Internal(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryOfMetrics_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x00073F90 File Offset: 0x00072190
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics)
		{
			return AsyncReadManagerMetrics.GetSummaryOfMetrics_Internal(metrics);
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x00073FA8 File Offset: 0x000721A8
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics_FromContainer_Internal(List<AsyncReadManagerRequestMetric> metrics)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00073FD4 File Offset: 0x000721D4
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(List<AsyncReadManagerRequestMetric> metrics)
		{
			return AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_Internal(metrics);
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00073FEC File Offset: 0x000721EC
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetricsWithFilters_Internal(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics), IL2CPP.Il2CppObjectBaseToPtr(metricsFilters));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00074020 File Offset: 0x00072220
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
		{
			return AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_Internal(metrics, metricsFilters);
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x0007403C File Offset: 0x0007223C
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetricsWithFilters_FromContainer_Internal(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics), IL2CPP.Il2CppObjectBaseToPtr(metricsFilters));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00074070 File Offset: 0x00072270
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
		{
			return AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_Internal(metrics, metricsFilters);
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x0001088D File Offset: 0x0000EA8D
		public static ulong GetTotalSizeOfNonASRMReadsBytes(bool emptyAfterRead)
		{
			return AsyncReadManagerMetrics.GetTotalSizeOfNonASRMReadsBytesDelegateField(emptyAfterRead);
		}

		// Token: 0x04001A06 RID: 6662
		private static readonly AsyncReadManagerMetrics.IsEnabledDelegate IsEnabledDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.IsEnabledDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::IsEnabled");

		// Token: 0x04001A07 RID: 6663
		private static readonly AsyncReadManagerMetrics.ClearMetrics_InternalDelegate ClearMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.ClearMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::ClearMetrics_Internal");

		// Token: 0x04001A08 RID: 6664
		private static readonly AsyncReadManagerMetrics.GetMetrics_InternalDelegate GetMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_Internal");

		// Token: 0x04001A09 RID: 6665
		private static readonly AsyncReadManagerMetrics.GetMetrics_NoAlloc_InternalDelegate GetMetrics_NoAlloc_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_NoAlloc_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_NoAlloc_Internal");

		// Token: 0x04001A0A RID: 6666
		private static readonly AsyncReadManagerMetrics.GetMetrics_Filtered_InternalDelegate GetMetrics_Filtered_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_Filtered_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_Filtered_Internal");

		// Token: 0x04001A0B RID: 6667
		private static readonly AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_InternalDelegate GetMetrics_NoAlloc_Filtered_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_NoAlloc_Filtered_Internal");

		// Token: 0x04001A0C RID: 6668
		private static readonly AsyncReadManagerMetrics.StartCollectingMetricsDelegate StartCollectingMetricsDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.StartCollectingMetricsDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::StartCollectingMetrics");

		// Token: 0x04001A0D RID: 6669
		private static readonly AsyncReadManagerMetrics.StopCollectingMetricsDelegate StopCollectingMetricsDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.StopCollectingMetricsDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::StopCollectingMetrics");

		// Token: 0x04001A0E RID: 6670
		private static readonly AsyncReadManagerMetrics.GetSummaryMetrics_InternalDelegate GetSummaryMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryMetrics_Internal");

		// Token: 0x04001A0F RID: 6671
		private static readonly AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_InternalDelegate GetSummaryMetricsWithFilters_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryMetricsWithFilters_Internal");

		// Token: 0x04001A10 RID: 6672
		private static readonly AsyncReadManagerMetrics.GetSummaryOfMetrics_InternalDelegate GetSummaryOfMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetrics_Internal");

		// Token: 0x04001A11 RID: 6673
		private static readonly AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_InternalDelegate GetSummaryOfMetrics_FromContainer_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetrics_FromContainer_Internal");

		// Token: 0x04001A12 RID: 6674
		private static readonly AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_InternalDelegate GetSummaryOfMetricsWithFilters_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetricsWithFilters_Internal");

		// Token: 0x04001A13 RID: 6675
		private static readonly AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetricsWithFilters_FromContainer_Internal");

		// Token: 0x04001A14 RID: 6676
		private static readonly AsyncReadManagerMetrics.GetTotalSizeOfNonASRMReadsBytesDelegate GetTotalSizeOfNonASRMReadsBytesDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetTotalSizeOfNonASRMReadsBytesDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetTotalSizeOfNonASRMReadsBytes");

		// Token: 0x02000AAF RID: 2735
		public enum Flags
		{
			// Token: 0x0400204B RID: 8267
			None,
			// Token: 0x0400204C RID: 8268
			ClearOnRead
		}

		// Token: 0x02000AB0 RID: 2736
		// (Invoke) Token: 0x060033C4 RID: 13252
		private delegate bool IsEnabledDelegate();

		// Token: 0x02000AB1 RID: 2737
		// (Invoke) Token: 0x060033C6 RID: 13254
		private delegate void ClearMetrics_InternalDelegate();

		// Token: 0x02000AB2 RID: 2738
		// (Invoke) Token: 0x060033C8 RID: 13256
		private delegate IntPtr GetMetrics_InternalDelegate(bool clear);

		// Token: 0x02000AB3 RID: 2739
		// (Invoke) Token: 0x060033CA RID: 13258
		private delegate void GetMetrics_NoAlloc_InternalDelegate(IntPtr metrics, bool clear);

		// Token: 0x02000AB4 RID: 2740
		// (Invoke) Token: 0x060033CC RID: 13260
		private delegate IntPtr GetMetrics_Filtered_InternalDelegate(IntPtr filters, bool clear);

		// Token: 0x02000AB5 RID: 2741
		// (Invoke) Token: 0x060033CE RID: 13262
		private delegate void GetMetrics_NoAlloc_Filtered_InternalDelegate(IntPtr metrics, IntPtr filters, bool clear);

		// Token: 0x02000AB6 RID: 2742
		// (Invoke) Token: 0x060033D0 RID: 13264
		private delegate void StartCollectingMetricsDelegate();

		// Token: 0x02000AB7 RID: 2743
		// (Invoke) Token: 0x060033D2 RID: 13266
		private delegate void StopCollectingMetricsDelegate();

		// Token: 0x02000AB8 RID: 2744
		// (Invoke) Token: 0x060033D4 RID: 13268
		private delegate IntPtr GetSummaryMetrics_InternalDelegate(bool clear);

		// Token: 0x02000AB9 RID: 2745
		// (Invoke) Token: 0x060033D6 RID: 13270
		private delegate IntPtr GetSummaryMetricsWithFilters_InternalDelegate(IntPtr metricsFilters, bool clear);

		// Token: 0x02000ABA RID: 2746
		// (Invoke) Token: 0x060033D8 RID: 13272
		private delegate IntPtr GetSummaryOfMetrics_InternalDelegate(IntPtr metrics);

		// Token: 0x02000ABB RID: 2747
		// (Invoke) Token: 0x060033DA RID: 13274
		private delegate IntPtr GetSummaryOfMetrics_FromContainer_InternalDelegate(IntPtr metrics);

		// Token: 0x02000ABC RID: 2748
		// (Invoke) Token: 0x060033DC RID: 13276
		private delegate IntPtr GetSummaryOfMetricsWithFilters_InternalDelegate(IntPtr metrics, IntPtr metricsFilters);

		// Token: 0x02000ABD RID: 2749
		// (Invoke) Token: 0x060033DE RID: 13278
		private delegate IntPtr GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate(IntPtr metrics, IntPtr metricsFilters);

		// Token: 0x02000ABE RID: 2750
		// (Invoke) Token: 0x060033E0 RID: 13280
		private delegate ulong GetTotalSizeOfNonASRMReadsBytesDelegate(bool emptyAfterRead);
	}
}
