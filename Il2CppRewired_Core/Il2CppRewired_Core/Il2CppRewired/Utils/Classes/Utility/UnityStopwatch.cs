using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x0200020D RID: 525
	public sealed class UnityStopwatch : StopwatchBase
	{
		// Token: 0x0600368A RID: 13962 RVA: 0x0010DE98 File Offset: 0x0010C098
		// Note: this type is marked as 'beforefieldinit'.
		static UnityStopwatch()
		{
			Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "UnityStopwatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr);
			UnityStopwatch.NativeFieldInfoPtr_zYspcaXlXvZccqPXXcbaGdIzDTxl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, "zYspcaXlXvZccqPXXcbaGdIzDTxl");
			UnityStopwatch.NativeFieldInfoPtr_ccWawHXeXuOGwrOhrlHmczFqZwJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, "ccWawHXeXuOGwrOhrlHmczFqZwJ");
			UnityStopwatch.NativeFieldInfoPtr_awIRcauAfKIIrMTeMOPobpDBtok = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, "awIRcauAfKIIrMTeMOPobpDBtok");
			UnityStopwatch.NativeFieldInfoPtr_bDBljzKoJjVdIwHepTvzpPRSELgG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, "bDBljzKoJjVdIwHepTvzpPRSELgG");
			UnityStopwatch.NativeFieldInfoPtr_UdBifkmkLTImvyVbCbzjAepZLhZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, "UdBifkmkLTImvyVbCbzjAepZLhZ");
			UnityStopwatch.NativeMethodInfoPtr_get_Global_Public_Static_get_UnityStopwatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676748);
			UnityStopwatch.NativeMethodInfoPtr_get_frequency_Public_Static_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676749);
			UnityStopwatch.NativeMethodInfoPtr_StartNew_Public_Static_UnityStopwatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676750);
			UnityStopwatch.NativeMethodInfoPtr_ConvertTo100NSTicks_Public_Static_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676751);
			UnityStopwatch.NativeMethodInfoPtr_get_offsetSeconds_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676752);
			UnityStopwatch.NativeMethodInfoPtr_set_offsetSeconds_Public_Virtual_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676753);
			UnityStopwatch.NativeMethodInfoPtr_get_offsetTicks_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676754);
			UnityStopwatch.NativeMethodInfoPtr_set_offsetTicks_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676755);
			UnityStopwatch.NativeMethodInfoPtr_get_elapsedSeconds_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676756);
			UnityStopwatch.NativeMethodInfoPtr_get_elapsedSecondsRaw_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676757);
			UnityStopwatch.NativeMethodInfoPtr_get_elapsedMilliseconds_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676758);
			UnityStopwatch.NativeMethodInfoPtr_get_elapsedMillisecondsRaw_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676759);
			UnityStopwatch.NativeMethodInfoPtr_get_elapsedTicks_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676760);
			UnityStopwatch.NativeMethodInfoPtr_get_elapsedTicksRaw_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676761);
			UnityStopwatch.NativeMethodInfoPtr_get_isRunning_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676762);
			UnityStopwatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676763);
			UnityStopwatch.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676764);
			UnityStopwatch.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676765);
			UnityStopwatch.NativeMethodInfoPtr_Stop_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676766);
			UnityStopwatch.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676767);
			UnityStopwatch.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676768);
			UnityStopwatch.NativeMethodInfoPtr_BMXSoVGPXcXHcKJuYKhCGzLoQzQ_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676769);
			UnityStopwatch.NativeMethodInfoPtr_VhyJzKMGhrsnBBtGRfRLPOeHbuKG_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676770);
			UnityStopwatch.NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Private_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, 100676771);
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x0600368B RID: 13963 RVA: 0x0010E10C File Offset: 0x0010C30C
		public unsafe static UnityStopwatch Global
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346840, XrefRangeEnd = 346845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_get_Global_Public_Static_get_UnityStopwatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityStopwatch>(intPtr3) : null;
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x0600368C RID: 13964 RVA: 0x0010E140 File Offset: 0x0010C340
		public unsafe static long frequency
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_get_frequency_Public_Static_get_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x0010E170 File Offset: 0x0010C370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346845, XrefRangeEnd = 346849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityStopwatch StartNew()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_StartNew_Public_Static_UnityStopwatch_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityStopwatch>(intPtr3) : null;
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x0010E1A4 File Offset: 0x0010C3A4
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ConvertTo100NSTicks(long ticks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_ConvertTo100NSTicks_Public_Static_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x0600368F RID: 13967 RVA: 0x0010E1E4 File Offset: 0x0010C3E4
		// (set) Token: 0x06003690 RID: 13968 RVA: 0x0010E220 File Offset: 0x0010C420
		public unsafe override double offsetSeconds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_get_offsetSeconds_Public_Virtual_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_set_offsetSeconds_Public_Virtual_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06003691 RID: 13969 RVA: 0x0010E260 File Offset: 0x0010C460
		// (set) Token: 0x06003692 RID: 13970 RVA: 0x0010E29C File Offset: 0x0010C49C
		public unsafe override long offsetTicks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_get_offsetTicks_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_set_offsetTicks_Public_Virtual_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06003693 RID: 13971 RVA: 0x0010E2DC File Offset: 0x0010C4DC
		public unsafe override double elapsedSeconds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346849, XrefRangeEnd = 346850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_get_elapsedSeconds_Public_Virtual_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06003694 RID: 13972 RVA: 0x0010E318 File Offset: 0x0010C518
		public unsafe override double elapsedSecondsRaw
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346850, XrefRangeEnd = 346852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_get_elapsedSecondsRaw_Public_Virtual_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06003695 RID: 13973 RVA: 0x0010E354 File Offset: 0x0010C554
		public unsafe override long elapsedMilliseconds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346852, XrefRangeEnd = 346853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_get_elapsedMilliseconds_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06003696 RID: 13974 RVA: 0x0010E390 File Offset: 0x0010C590
		public unsafe override long elapsedMillisecondsRaw
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346853, XrefRangeEnd = 346854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_get_elapsedMillisecondsRaw_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06003697 RID: 13975 RVA: 0x0010E3CC File Offset: 0x0010C5CC
		public unsafe override long elapsedTicks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_get_elapsedTicks_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06003698 RID: 13976 RVA: 0x0010E408 File Offset: 0x0010C608
		public unsafe override long elapsedTicksRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_get_elapsedTicksRaw_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06003699 RID: 13977 RVA: 0x0010E444 File Offset: 0x0010C644
		public unsafe override bool isRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_get_isRunning_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x0010E480 File Offset: 0x0010C680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346854, XrefRangeEnd = 346855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityStopwatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x0010E4BC File Offset: 0x0010C6BC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 346859, RefRangeEnd = 346866, XrefRangeStart = 346855, XrefRangeEnd = 346859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityStopwatch(bool isGlobal)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isGlobal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x0010E504 File Offset: 0x0010C704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346866, XrefRangeEnd = 346868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x0010E538 File Offset: 0x0010C738
		[CallerCount(0)]
		public unsafe override void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_Stop_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x0010E56C File Offset: 0x0010C76C
		[CallerCount(0)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_Start_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x0010E5A0 File Offset: 0x0010C7A0
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x0010E5D4 File Offset: 0x0010C7D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346887, RefRangeEnd = 346888, XrefRangeStart = 346868, XrefRangeEnd = 346887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BMXSoVGPXcXHcKJuYKhCGzLoQzQ()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_BMXSoVGPXcXHcKJuYKhCGzLoQzQ_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x0010E608 File Offset: 0x0010C808
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346906, RefRangeEnd = 346908, XrefRangeStart = 346888, XrefRangeEnd = 346906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VhyJzKMGhrsnBBtGRfRLPOeHbuKG()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_VhyJzKMGhrsnBBtGRfRLPOeHbuKG_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x0010E63C File Offset: 0x0010C83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346908, XrefRangeEnd = 346910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NFTSnGXuZXafcZHIgcYanOLckXY(UpdateLoopType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Private_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x00012D0B File Offset: 0x00010F0B
		public UnityStopwatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x060036A4 RID: 13988 RVA: 0x0010E67C File Offset: 0x0010C87C
		// (set) Token: 0x060036A5 RID: 13989 RVA: 0x00012D14 File Offset: 0x00010F14
		public unsafe static long zYspcaXlXvZccqPXXcbaGdIzDTxl
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(UnityStopwatch.NativeFieldInfoPtr_zYspcaXlXvZccqPXXcbaGdIzDTxl, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityStopwatch.NativeFieldInfoPtr_zYspcaXlXvZccqPXXcbaGdIzDTxl, (void*)(&value));
			}
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x060036A6 RID: 13990 RVA: 0x0010E698 File Offset: 0x0010C898
		// (set) Token: 0x060036A7 RID: 13991 RVA: 0x00012D22 File Offset: 0x00010F22
		public unsafe static UnityStopwatch ccWawHXeXuOGwrOhrlHmczFqZwJ
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityStopwatch.NativeFieldInfoPtr_ccWawHXeXuOGwrOhrlHmczFqZwJ, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityStopwatch>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityStopwatch.NativeFieldInfoPtr_ccWawHXeXuOGwrOhrlHmczFqZwJ, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x060036A8 RID: 13992 RVA: 0x0010E6C0 File Offset: 0x0010C8C0
		// (set) Token: 0x060036A9 RID: 13993 RVA: 0x00012D34 File Offset: 0x00010F34
		public unsafe UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov awIRcauAfKIIrMTeMOPobpDBtok
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityStopwatch.NativeFieldInfoPtr_awIRcauAfKIIrMTeMOPobpDBtok);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityStopwatch.NativeFieldInfoPtr_awIRcauAfKIIrMTeMOPobpDBtok), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x060036AA RID: 13994 RVA: 0x0010E6F0 File Offset: 0x0010C8F0
		// (set) Token: 0x060036AB RID: 13995 RVA: 0x00012D53 File Offset: 0x00010F53
		public unsafe bool bDBljzKoJjVdIwHepTvzpPRSELgG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityStopwatch.NativeFieldInfoPtr_bDBljzKoJjVdIwHepTvzpPRSELgG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityStopwatch.NativeFieldInfoPtr_bDBljzKoJjVdIwHepTvzpPRSELgG)) = value;
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x060036AC RID: 13996 RVA: 0x0010E718 File Offset: 0x0010C918
		// (set) Token: 0x060036AD RID: 13997 RVA: 0x00012D6E File Offset: 0x00010F6E
		public unsafe double UdBifkmkLTImvyVbCbzjAepZLhZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityStopwatch.NativeFieldInfoPtr_UdBifkmkLTImvyVbCbzjAepZLhZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityStopwatch.NativeFieldInfoPtr_UdBifkmkLTImvyVbCbzjAepZLhZ)) = value;
			}
		}

		// Token: 0x04002E3C RID: 11836
		private static readonly IntPtr NativeFieldInfoPtr_zYspcaXlXvZccqPXXcbaGdIzDTxl;

		// Token: 0x04002E3D RID: 11837
		private static readonly IntPtr NativeFieldInfoPtr_ccWawHXeXuOGwrOhrlHmczFqZwJ;

		// Token: 0x04002E3E RID: 11838
		private static readonly IntPtr NativeFieldInfoPtr_awIRcauAfKIIrMTeMOPobpDBtok;

		// Token: 0x04002E3F RID: 11839
		private static readonly IntPtr NativeFieldInfoPtr_bDBljzKoJjVdIwHepTvzpPRSELgG;

		// Token: 0x04002E40 RID: 11840
		private static readonly IntPtr NativeFieldInfoPtr_UdBifkmkLTImvyVbCbzjAepZLhZ;

		// Token: 0x04002E41 RID: 11841
		private static readonly IntPtr NativeMethodInfoPtr_get_Global_Public_Static_get_UnityStopwatch_0;

		// Token: 0x04002E42 RID: 11842
		private static readonly IntPtr NativeMethodInfoPtr_get_frequency_Public_Static_get_Int64_0;

		// Token: 0x04002E43 RID: 11843
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Public_Static_UnityStopwatch_0;

		// Token: 0x04002E44 RID: 11844
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTo100NSTicks_Public_Static_Int64_Int64_0;

		// Token: 0x04002E45 RID: 11845
		private static readonly IntPtr NativeMethodInfoPtr_get_offsetSeconds_Public_Virtual_get_Double_0;

		// Token: 0x04002E46 RID: 11846
		private static readonly IntPtr NativeMethodInfoPtr_set_offsetSeconds_Public_Virtual_set_Void_Double_0;

		// Token: 0x04002E47 RID: 11847
		private static readonly IntPtr NativeMethodInfoPtr_get_offsetTicks_Public_Virtual_get_Int64_0;

		// Token: 0x04002E48 RID: 11848
		private static readonly IntPtr NativeMethodInfoPtr_set_offsetTicks_Public_Virtual_set_Void_Int64_0;

		// Token: 0x04002E49 RID: 11849
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedSeconds_Public_Virtual_get_Double_0;

		// Token: 0x04002E4A RID: 11850
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedSecondsRaw_Public_Virtual_get_Double_0;

		// Token: 0x04002E4B RID: 11851
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedMilliseconds_Public_Virtual_get_Int64_0;

		// Token: 0x04002E4C RID: 11852
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedMillisecondsRaw_Public_Virtual_get_Int64_0;

		// Token: 0x04002E4D RID: 11853
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedTicks_Public_Virtual_get_Int64_0;

		// Token: 0x04002E4E RID: 11854
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedTicksRaw_Public_Virtual_get_Int64_0;

		// Token: 0x04002E4F RID: 11855
		private static readonly IntPtr NativeMethodInfoPtr_get_isRunning_Public_Virtual_get_Boolean_0;

		// Token: 0x04002E50 RID: 11856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002E51 RID: 11857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x04002E52 RID: 11858
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002E53 RID: 11859
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_Void_0;

		// Token: 0x04002E54 RID: 11860
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04002E55 RID: 11861
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04002E56 RID: 11862
		private static readonly IntPtr NativeMethodInfoPtr_BMXSoVGPXcXHcKJuYKhCGzLoQzQ_Private_Void_0;

		// Token: 0x04002E57 RID: 11863
		private static readonly IntPtr NativeMethodInfoPtr_VhyJzKMGhrsnBBtGRfRLPOeHbuKG_Private_Void_0;

		// Token: 0x04002E58 RID: 11864
		private static readonly IntPtr NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Private_Void_UpdateLoopType_0;

		// Token: 0x020004AB RID: 1195
		public class bDTRHhGCioHrpOoNgzOYtKYssov : Object
		{
			// Token: 0x060051A3 RID: 20899 RVA: 0x00173548 File Offset: 0x00171748
			// Note: this type is marked as 'beforefieldinit'.
			static bDTRHhGCioHrpOoNgzOYtKYssov()
			{
				Il2CppClassPointerStore<UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityStopwatch>.NativeClassPtr, "bDTRHhGCioHrpOoNgzOYtKYssov");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov>.NativeClassPtr);
				UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeFieldInfoPtr_wuzIZNkDcCgyKxVidQrciJygSMl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov>.NativeClassPtr, "wuzIZNkDcCgyKxVidQrciJygSMl");
				UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeFieldInfoPtr_UgtfhaKgymTFIqvxwWIghZzzJfzh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov>.NativeClassPtr, "UgtfhaKgymTFIqvxwWIghZzzJfzh");
				UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeFieldInfoPtr_JyBkzjloFznhMwXryFkNCyxJENW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov>.NativeClassPtr, "JyBkzjloFznhMwXryFkNCyxJENW");
				UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeFieldInfoPtr_IazdtdlCeOAEwAIlzilallbRIbQd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov>.NativeClassPtr, "IazdtdlCeOAEwAIlzilallbRIbQd");
				UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeFieldInfoPtr_XSKyuIPUDDLRicDiJWNpfmHUXij = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov>.NativeClassPtr, "XSKyuIPUDDLRicDiJWNpfmHUXij");
				UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov>.NativeClassPtr, 100676772);
				UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeMethodInfoPtr_get_ElapsedSeconds_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov>.NativeClassPtr, 100676773);
				UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov>.NativeClassPtr, 100676774);
				UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov>.NativeClassPtr, 100676775);
				UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov>.NativeClassPtr, 100676776);
				UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeMethodInfoPtr_zfahqYjiIdfMojMAGLXbLAnHRnwb_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov>.NativeClassPtr, 100676777);
				UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov>.NativeClassPtr, 100676778);
			}

			// Token: 0x17001913 RID: 6419
			// (get) Token: 0x060051A4 RID: 20900 RVA: 0x00173664 File Offset: 0x00171864
			public unsafe bool LZiFzZrEdtgsxFlhhiNfWvMsJab
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001914 RID: 6420
			// (get) Token: 0x060051A5 RID: 20901 RVA: 0x001736A0 File Offset: 0x001718A0
			public unsafe double tnbqglxnLwIXoyHhjpAIAmGAMBv
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 346834, RefRangeEnd = 346838, XrefRangeStart = 346832, XrefRangeEnd = 346834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeMethodInfoPtr_get_ElapsedSeconds_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051A6 RID: 20902 RVA: 0x001736DC File Offset: 0x001718DC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bDTRHhGCioHrpOoNgzOYtKYssov()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051A7 RID: 20903 RVA: 0x00173718 File Offset: 0x00171918
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346838, XrefRangeEnd = 346840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void xozDTcGUrsCTUDmjINWIvPSceAOJ()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051A8 RID: 20904 RVA: 0x0017374C File Offset: 0x0017194C
			[CallerCount(0)]
			public unsafe void qeDEyDaZsAupdNZCUOgsfUHyXvg()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051A9 RID: 20905 RVA: 0x00173780 File Offset: 0x00171980
			[CallerCount(0)]
			public unsafe void zfahqYjiIdfMojMAGLXbLAnHRnwb()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeMethodInfoPtr_zfahqYjiIdfMojMAGLXbLAnHRnwb_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051AA RID: 20906 RVA: 0x001737B4 File Offset: 0x001719B4
			[CallerCount(0)]
			public unsafe void vsfKIEzLYgmvYXdfRKJgdqwirYk()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051AB RID: 20907 RVA: 0x0001D784 File Offset: 0x0001B984
			public bDTRHhGCioHrpOoNgzOYtKYssov(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700190E RID: 6414
			// (get) Token: 0x060051AC RID: 20908 RVA: 0x001737E8 File Offset: 0x001719E8
			// (set) Token: 0x060051AD RID: 20909 RVA: 0x0001D78D File Offset: 0x0001B98D
			public unsafe static long wuzIZNkDcCgyKxVidQrciJygSMl
			{
				get
				{
					long num;
					IL2CPP.il2cpp_field_static_get_value(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeFieldInfoPtr_wuzIZNkDcCgyKxVidQrciJygSMl, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeFieldInfoPtr_wuzIZNkDcCgyKxVidQrciJygSMl, (void*)(&value));
				}
			}

			// Token: 0x1700190F RID: 6415
			// (get) Token: 0x060051AE RID: 20910 RVA: 0x00173804 File Offset: 0x00171A04
			// (set) Token: 0x060051AF RID: 20911 RVA: 0x0001D79B File Offset: 0x0001B99B
			public unsafe double UgtfhaKgymTFIqvxwWIghZzzJfzh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeFieldInfoPtr_UgtfhaKgymTFIqvxwWIghZzzJfzh);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeFieldInfoPtr_UgtfhaKgymTFIqvxwWIghZzzJfzh)) = value;
				}
			}

			// Token: 0x17001910 RID: 6416
			// (get) Token: 0x060051B0 RID: 20912 RVA: 0x0017382C File Offset: 0x00171A2C
			// (set) Token: 0x060051B1 RID: 20913 RVA: 0x0001D7B6 File Offset: 0x0001B9B6
			public unsafe bool JyBkzjloFznhMwXryFkNCyxJENW
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeFieldInfoPtr_JyBkzjloFznhMwXryFkNCyxJENW);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeFieldInfoPtr_JyBkzjloFznhMwXryFkNCyxJENW)) = value;
				}
			}

			// Token: 0x17001911 RID: 6417
			// (get) Token: 0x060051B2 RID: 20914 RVA: 0x00173854 File Offset: 0x00171A54
			// (set) Token: 0x060051B3 RID: 20915 RVA: 0x0001D7D1 File Offset: 0x0001B9D1
			public unsafe double IazdtdlCeOAEwAIlzilallbRIbQd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeFieldInfoPtr_IazdtdlCeOAEwAIlzilallbRIbQd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeFieldInfoPtr_IazdtdlCeOAEwAIlzilallbRIbQd)) = value;
				}
			}

			// Token: 0x17001912 RID: 6418
			// (get) Token: 0x060051B4 RID: 20916 RVA: 0x0017387C File Offset: 0x00171A7C
			// (set) Token: 0x060051B5 RID: 20917 RVA: 0x0001D7EC File Offset: 0x0001B9EC
			public unsafe double XSKyuIPUDDLRicDiJWNpfmHUXij
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeFieldInfoPtr_XSKyuIPUDDLRicDiJWNpfmHUXij);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityStopwatch.bDTRHhGCioHrpOoNgzOYtKYssov.NativeFieldInfoPtr_XSKyuIPUDDLRicDiJWNpfmHUXij)) = value;
				}
			}

			// Token: 0x040044A3 RID: 17571
			private static readonly IntPtr NativeFieldInfoPtr_wuzIZNkDcCgyKxVidQrciJygSMl;

			// Token: 0x040044A4 RID: 17572
			private static readonly IntPtr NativeFieldInfoPtr_UgtfhaKgymTFIqvxwWIghZzzJfzh;

			// Token: 0x040044A5 RID: 17573
			private static readonly IntPtr NativeFieldInfoPtr_JyBkzjloFznhMwXryFkNCyxJENW;

			// Token: 0x040044A6 RID: 17574
			private static readonly IntPtr NativeFieldInfoPtr_IazdtdlCeOAEwAIlzilallbRIbQd;

			// Token: 0x040044A7 RID: 17575
			private static readonly IntPtr NativeFieldInfoPtr_XSKyuIPUDDLRicDiJWNpfmHUXij;

			// Token: 0x040044A8 RID: 17576
			private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0;

			// Token: 0x040044A9 RID: 17577
			private static readonly IntPtr NativeMethodInfoPtr_get_ElapsedSeconds_Public_get_Double_0;

			// Token: 0x040044AA RID: 17578
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040044AB RID: 17579
			private static readonly IntPtr NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_0;

			// Token: 0x040044AC RID: 17580
			private static readonly IntPtr NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_0;

			// Token: 0x040044AD RID: 17581
			private static readonly IntPtr NativeMethodInfoPtr_zfahqYjiIdfMojMAGLXbLAnHRnwb_Public_Void_0;

			// Token: 0x040044AE RID: 17582
			private static readonly IntPtr NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Void_0;
		}
	}
}
