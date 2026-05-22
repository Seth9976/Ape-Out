using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Diagnostics;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x0200020C RID: 524
	public sealed class Stopwatch : StopwatchBase
	{
		// Token: 0x0600366C RID: 13932 RVA: 0x0010D7D4 File Offset: 0x0010B9D4
		// Note: this type is marked as 'beforefieldinit'.
		static Stopwatch()
		{
			Il2CppClassPointerStore<Stopwatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "Stopwatch");
			Stopwatch.NativeFieldInfoPtr_zYspcaXlXvZccqPXXcbaGdIzDTxl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "zYspcaXlXvZccqPXXcbaGdIzDTxl");
			Stopwatch.NativeFieldInfoPtr_Global = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "Global");
			Stopwatch.NativeFieldInfoPtr_AulkvaBmDKCwqfjuzCVXQdYYiip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "AulkvaBmDKCwqfjuzCVXQdYYiip");
			Stopwatch.NativeFieldInfoPtr_awIRcauAfKIIrMTeMOPobpDBtok = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "awIRcauAfKIIrMTeMOPobpDBtok");
			Stopwatch.NativeFieldInfoPtr_sDcEVAeVPHKFomrPeepUcAqYukKW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "sDcEVAeVPHKFomrPeepUcAqYukKW");
			Stopwatch.NativeMethodInfoPtr_get_frequency_Public_Static_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676729);
			Stopwatch.NativeMethodInfoPtr_StartNew_Public_Static_Stopwatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676731);
			Stopwatch.NativeMethodInfoPtr_ConvertTo100NSTicks_Public_Static_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676732);
			Stopwatch.NativeMethodInfoPtr_get_offsetSeconds_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676733);
			Stopwatch.NativeMethodInfoPtr_set_offsetSeconds_Public_Virtual_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676734);
			Stopwatch.NativeMethodInfoPtr_get_offsetTicks_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676735);
			Stopwatch.NativeMethodInfoPtr_set_offsetTicks_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676736);
			Stopwatch.NativeMethodInfoPtr_get_elapsedSeconds_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676737);
			Stopwatch.NativeMethodInfoPtr_get_elapsedSecondsRaw_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676738);
			Stopwatch.NativeMethodInfoPtr_get_elapsedMilliseconds_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676739);
			Stopwatch.NativeMethodInfoPtr_get_elapsedMillisecondsRaw_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676740);
			Stopwatch.NativeMethodInfoPtr_get_elapsedTicks_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676741);
			Stopwatch.NativeMethodInfoPtr_get_elapsedTicksRaw_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676742);
			Stopwatch.NativeMethodInfoPtr_get_isRunning_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676743);
			Stopwatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676744);
			Stopwatch.NativeMethodInfoPtr_Stop_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676745);
			Stopwatch.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676746);
			Stopwatch.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100676747);
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x0600366D RID: 13933 RVA: 0x0010D9C8 File Offset: 0x0010BBC8
		public unsafe static long frequency
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346766, XrefRangeEnd = 346770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_frequency_Public_Static_get_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x0010D9F8 File Offset: 0x0010BBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346770, XrefRangeEnd = 346774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stopwatch StartNew()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_StartNew_Public_Static_Stopwatch_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr3) : null;
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x0010DA2C File Offset: 0x0010BC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346774, XrefRangeEnd = 346780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ConvertTo100NSTicks(long ticks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_ConvertTo100NSTicks_Public_Static_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x06003670 RID: 13936 RVA: 0x0010DA6C File Offset: 0x0010BC6C
		// (set) Token: 0x06003671 RID: 13937 RVA: 0x0010DAA8 File Offset: 0x0010BCA8
		public unsafe override double offsetSeconds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346780, XrefRangeEnd = 346784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_offsetSeconds_Public_Virtual_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346784, XrefRangeEnd = 346788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_set_offsetSeconds_Public_Virtual_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06003672 RID: 13938 RVA: 0x0010DAE8 File Offset: 0x0010BCE8
		// (set) Token: 0x06003673 RID: 13939 RVA: 0x0010DB24 File Offset: 0x0010BD24
		public unsafe override long offsetTicks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_offsetTicks_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_set_offsetTicks_Public_Virtual_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x06003674 RID: 13940 RVA: 0x0010DB64 File Offset: 0x0010BD64
		public unsafe override double elapsedSeconds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346788, XrefRangeEnd = 346793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_elapsedSeconds_Public_Virtual_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x06003675 RID: 13941 RVA: 0x0010DBA0 File Offset: 0x0010BDA0
		public unsafe override double elapsedSecondsRaw
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346793, XrefRangeEnd = 346798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_elapsedSecondsRaw_Public_Virtual_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x06003676 RID: 13942 RVA: 0x0010DBDC File Offset: 0x0010BDDC
		public unsafe override long elapsedMilliseconds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346798, XrefRangeEnd = 346803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_elapsedMilliseconds_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06003677 RID: 13943 RVA: 0x0010DC18 File Offset: 0x0010BE18
		public unsafe override long elapsedMillisecondsRaw
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346803, XrefRangeEnd = 346805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_elapsedMillisecondsRaw_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06003678 RID: 13944 RVA: 0x0010DC54 File Offset: 0x0010BE54
		public unsafe override long elapsedTicks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346805, XrefRangeEnd = 346806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_elapsedTicks_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06003679 RID: 13945 RVA: 0x0010DC90 File Offset: 0x0010BE90
		public unsafe override long elapsedTicksRaw
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346806, XrefRangeEnd = 346808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_elapsedTicksRaw_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x0600367A RID: 13946 RVA: 0x0010DCCC File Offset: 0x0010BECC
		public unsafe override bool isRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_isRunning_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x0010DD08 File Offset: 0x0010BF08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346811, RefRangeEnd = 346812, XrefRangeStart = 346808, XrefRangeEnd = 346811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stopwatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x0010DD44 File Offset: 0x0010BF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346812, XrefRangeEnd = 346820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_Stop_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x0010DD78 File Offset: 0x0010BF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346820, XrefRangeEnd = 346828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_Start_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x0010DDAC File Offset: 0x0010BFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346828, XrefRangeEnd = 346832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x00012C9A File Offset: 0x00010E9A
		public Stopwatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x06003680 RID: 13952 RVA: 0x0010DDE0 File Offset: 0x0010BFE0
		// (set) Token: 0x06003681 RID: 13953 RVA: 0x00012CA3 File Offset: 0x00010EA3
		public unsafe static long zYspcaXlXvZccqPXXcbaGdIzDTxl
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Stopwatch.NativeFieldInfoPtr_zYspcaXlXvZccqPXXcbaGdIzDTxl, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stopwatch.NativeFieldInfoPtr_zYspcaXlXvZccqPXXcbaGdIzDTxl, (void*)(&value));
			}
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x06003682 RID: 13954 RVA: 0x0010DDFC File Offset: 0x0010BFFC
		// (set) Token: 0x06003683 RID: 13955 RVA: 0x00012CB1 File Offset: 0x00010EB1
		public unsafe static Stopwatch Global
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Stopwatch.NativeFieldInfoPtr_Global, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stopwatch.NativeFieldInfoPtr_Global, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x06003684 RID: 13956 RVA: 0x0010DE24 File Offset: 0x0010C024
		// (set) Token: 0x06003685 RID: 13957 RVA: 0x00012CC3 File Offset: 0x00010EC3
		public unsafe static long AulkvaBmDKCwqfjuzCVXQdYYiip
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Stopwatch.NativeFieldInfoPtr_AulkvaBmDKCwqfjuzCVXQdYYiip, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stopwatch.NativeFieldInfoPtr_AulkvaBmDKCwqfjuzCVXQdYYiip, (void*)(&value));
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x06003686 RID: 13958 RVA: 0x0010DE40 File Offset: 0x0010C040
		// (set) Token: 0x06003687 RID: 13959 RVA: 0x00012CD1 File Offset: 0x00010ED1
		public unsafe Stopwatch awIRcauAfKIIrMTeMOPobpDBtok
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_awIRcauAfKIIrMTeMOPobpDBtok);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_awIRcauAfKIIrMTeMOPobpDBtok), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x06003688 RID: 13960 RVA: 0x0010DE70 File Offset: 0x0010C070
		// (set) Token: 0x06003689 RID: 13961 RVA: 0x00012CF0 File Offset: 0x00010EF0
		public unsafe long sDcEVAeVPHKFomrPeepUcAqYukKW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_sDcEVAeVPHKFomrPeepUcAqYukKW);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_sDcEVAeVPHKFomrPeepUcAqYukKW)) = value;
			}
		}

		// Token: 0x04002E25 RID: 11813
		private static readonly IntPtr NativeFieldInfoPtr_zYspcaXlXvZccqPXXcbaGdIzDTxl;

		// Token: 0x04002E26 RID: 11814
		private static readonly IntPtr NativeFieldInfoPtr_Global;

		// Token: 0x04002E27 RID: 11815
		private static readonly IntPtr NativeFieldInfoPtr_AulkvaBmDKCwqfjuzCVXQdYYiip;

		// Token: 0x04002E28 RID: 11816
		private static readonly IntPtr NativeFieldInfoPtr_awIRcauAfKIIrMTeMOPobpDBtok;

		// Token: 0x04002E29 RID: 11817
		private static readonly IntPtr NativeFieldInfoPtr_sDcEVAeVPHKFomrPeepUcAqYukKW;

		// Token: 0x04002E2A RID: 11818
		private static readonly IntPtr NativeMethodInfoPtr_get_frequency_Public_Static_get_Int64_0;

		// Token: 0x04002E2B RID: 11819
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Public_Static_Stopwatch_0;

		// Token: 0x04002E2C RID: 11820
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTo100NSTicks_Public_Static_Int64_Int64_0;

		// Token: 0x04002E2D RID: 11821
		private static readonly IntPtr NativeMethodInfoPtr_get_offsetSeconds_Public_Virtual_get_Double_0;

		// Token: 0x04002E2E RID: 11822
		private static readonly IntPtr NativeMethodInfoPtr_set_offsetSeconds_Public_Virtual_set_Void_Double_0;

		// Token: 0x04002E2F RID: 11823
		private static readonly IntPtr NativeMethodInfoPtr_get_offsetTicks_Public_Virtual_get_Int64_0;

		// Token: 0x04002E30 RID: 11824
		private static readonly IntPtr NativeMethodInfoPtr_set_offsetTicks_Public_Virtual_set_Void_Int64_0;

		// Token: 0x04002E31 RID: 11825
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedSeconds_Public_Virtual_get_Double_0;

		// Token: 0x04002E32 RID: 11826
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedSecondsRaw_Public_Virtual_get_Double_0;

		// Token: 0x04002E33 RID: 11827
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedMilliseconds_Public_Virtual_get_Int64_0;

		// Token: 0x04002E34 RID: 11828
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedMillisecondsRaw_Public_Virtual_get_Int64_0;

		// Token: 0x04002E35 RID: 11829
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedTicks_Public_Virtual_get_Int64_0;

		// Token: 0x04002E36 RID: 11830
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedTicksRaw_Public_Virtual_get_Int64_0;

		// Token: 0x04002E37 RID: 11831
		private static readonly IntPtr NativeMethodInfoPtr_get_isRunning_Public_Virtual_get_Boolean_0;

		// Token: 0x04002E38 RID: 11832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002E39 RID: 11833
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_Void_0;

		// Token: 0x04002E3A RID: 11834
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04002E3B RID: 11835
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
	}
}
