using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x02000068 RID: 104
	public class Stopwatch : Object
	{
		// Token: 0x06000771 RID: 1905 RVA: 0x0002D220 File Offset: 0x0002B420
		// Note: this type is marked as 'beforefieldinit'.
		static Stopwatch()
		{
			Il2CppClassPointerStore<Stopwatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "Stopwatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr);
			Stopwatch.NativeFieldInfoPtr_Frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "Frequency");
			Stopwatch.NativeFieldInfoPtr_IsHighResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "IsHighResolution");
			Stopwatch.NativeFieldInfoPtr_elapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "elapsed");
			Stopwatch.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "started");
			Stopwatch.NativeFieldInfoPtr_is_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "is_running");
			Stopwatch.NativeMethodInfoPtr_GetTimestamp_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100664397);
			Stopwatch.NativeMethodInfoPtr_StartNew_Public_Static_Stopwatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100664398);
			Stopwatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100664399);
			Stopwatch.NativeMethodInfoPtr_get_Elapsed_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100664400);
			Stopwatch.NativeMethodInfoPtr_get_ElapsedMilliseconds_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100664401);
			Stopwatch.NativeMethodInfoPtr_get_ElapsedTicks_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100664402);
			Stopwatch.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100664403);
			Stopwatch.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100664404);
			Stopwatch.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100664405);
			Stopwatch.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100664406);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0002D37C File Offset: 0x0002B57C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 205051, RefRangeEnd = 205054, XrefRangeStart = 205051, XrefRangeEnd = 205054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetTimestamp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_GetTimestamp_Public_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0002D3AC File Offset: 0x0002B5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372429, XrefRangeEnd = 372436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stopwatch StartNew()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_StartNew_Public_Static_Stopwatch_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr3) : null;
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0002D3E0 File Offset: 0x0002B5E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stopwatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x0002D41C File Offset: 0x0002B61C
		public unsafe TimeSpan Elapsed
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 372444, RefRangeEnd = 372447, XrefRangeStart = 372436, XrefRangeEnd = 372444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_Elapsed_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x0002D458 File Offset: 0x0002B658
		public unsafe long ElapsedMilliseconds
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 372454, RefRangeEnd = 372456, XrefRangeStart = 372447, XrefRangeEnd = 372454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_ElapsedMilliseconds_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x0002D494 File Offset: 0x0002B694
		public unsafe long ElapsedTicks
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 372460, RefRangeEnd = 372466, XrefRangeStart = 372456, XrefRangeEnd = 372460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_ElapsedTicks_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0002D4D0 File Offset: 0x0002B6D0
		public unsafe bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0002D50C File Offset: 0x0002B70C
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0002D540 File Offset: 0x0002B740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372466, XrefRangeEnd = 372470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0002D574 File Offset: 0x0002B774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372470, XrefRangeEnd = 372474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00004E7E File Offset: 0x0000307E
		public Stopwatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x0002D5A8 File Offset: 0x0002B7A8
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x00004E87 File Offset: 0x00003087
		public unsafe static long Frequency
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Stopwatch.NativeFieldInfoPtr_Frequency, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stopwatch.NativeFieldInfoPtr_Frequency, (void*)(&value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x0002D5C4 File Offset: 0x0002B7C4
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x00004E95 File Offset: 0x00003095
		public unsafe static bool IsHighResolution
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Stopwatch.NativeFieldInfoPtr_IsHighResolution, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stopwatch.NativeFieldInfoPtr_IsHighResolution, (void*)(&value));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x0002D5E0 File Offset: 0x0002B7E0
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x00004EA3 File Offset: 0x000030A3
		public unsafe long elapsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_elapsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_elapsed)) = value;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x0002D608 File Offset: 0x0002B808
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x00004EBE File Offset: 0x000030BE
		public unsafe long started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x0002D630 File Offset: 0x0002B830
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x00004ED9 File Offset: 0x000030D9
		public unsafe bool is_running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_is_running);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_is_running)) = value;
			}
		}

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeFieldInfoPtr_Frequency;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeFieldInfoPtr_IsHighResolution;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeFieldInfoPtr_elapsed;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeFieldInfoPtr_is_running;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_GetTimestamp_Public_Static_Int64_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Public_Static_Stopwatch_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_get_Elapsed_Public_get_TimeSpan_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_get_ElapsedMilliseconds_Public_get_Int64_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_get_ElapsedTicks_Public_get_Int64_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
	}
}
