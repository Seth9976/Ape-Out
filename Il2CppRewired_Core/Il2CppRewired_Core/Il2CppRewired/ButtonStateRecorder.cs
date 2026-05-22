using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200001A RID: 26
	public class ButtonStateRecorder : Object
	{
		// Token: 0x060001F7 RID: 503 RVA: 0x00035454 File Offset: 0x00033654
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonStateRecorder()
		{
			Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ButtonStateRecorder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr);
			ButtonStateRecorder.NativeFieldInfoPtr_ecRrQWMveyrtspRKHHCNAaPQoEj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, "ecRrQWMveyrtspRKHHCNAaPQoEj");
			ButtonStateRecorder.NativeFieldInfoPtr_WZJGJlGHePZBbvenKyBJWpZyYjh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, "WZJGJlGHePZBbvenKyBJWpZyYjh");
			ButtonStateRecorder.NativeFieldInfoPtr_NEJAAzjuTnFJqapKOHASTcVNajlo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, "NEJAAzjuTnFJqapKOHASTcVNajlo");
			ButtonStateRecorder.NativeFieldInfoPtr_zLmYYankjqimcqwibEdThACcOtt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, "zLmYYankjqimcqwibEdThACcOtt");
			ButtonStateRecorder.NativeFieldInfoPtr_WiOvzmAntVNCPbLTrUOLVBzCUFG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, "WiOvzmAntVNCPbLTrUOLVBzCUFG");
			ButtonStateRecorder.NativeFieldInfoPtr_LKJjsMjRuzTdFXlIafBOKFfChgcB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, "LKJjsMjRuzTdFXlIafBOKFfChgcB");
			ButtonStateRecorder.NativeMethodInfoPtr_get_timePressed_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663623);
			ButtonStateRecorder.NativeMethodInfoPtr_get_timeUnpressed_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663624);
			ButtonStateRecorder.NativeMethodInfoPtr_get_lastTimePressed_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663625);
			ButtonStateRecorder.NativeMethodInfoPtr_get_lastTimeUnpressed_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663626);
			ButtonStateRecorder.NativeMethodInfoPtr_get_lastTimeStateChangedToPressed_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663627);
			ButtonStateRecorder.NativeMethodInfoPtr_get_lastTimeStateChangedToUnpressed_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663628);
			ButtonStateRecorder.NativeMethodInfoPtr_get_lastTimeStateChanged_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663629);
			ButtonStateRecorder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663630);
			ButtonStateRecorder.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_Boolean_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663631);
			ButtonStateRecorder.NativeMethodInfoPtr_feyDOtAvtBEFDAJZDoQyNGbyZfuu_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663632);
			ButtonStateRecorder.NativeMethodInfoPtr_lsTurqsAnocHAPVTlPlyYcIcNVT_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663633);
			ButtonStateRecorder.NativeMethodInfoPtr_feyDOtAvtBEFDAJZDoQyNGbyZfuu_Private_Static_Boolean_Il2CppReferenceArray_1_jkNQkQoZzsneSNRSNZmPBHEaNTl_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663634);
			ButtonStateRecorder.NativeMethodInfoPtr_RvQMLrToBYEHiALiAnytDoraaHIB_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663635);
			ButtonStateRecorder.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663636);
			ButtonStateRecorder.NativeMethodInfoPtr_roAugCmsvTatLyZkSedgEuOZmRC_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663637);
			ButtonStateRecorder.NativeMethodInfoPtr_BACoBzImgHaXFAcmxhFKGuWLzdhm_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663638);
			ButtonStateRecorder.NativeMethodInfoPtr_iytgzhGnTodBhaYzaHzMetajKoeF_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, 100663639);
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00035650 File Offset: 0x00033850
		public unsafe double cEocKlvhZtuRluCJGzmgIlJNapj
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 243591, RefRangeEnd = 243607, XrefRangeStart = 243587, XrefRangeEnd = 243591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr_get_timePressed_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0003568C File Offset: 0x0003388C
		public unsafe double hECcXHFWMWhqUTaSSXhYNkfRnoO
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 243611, RefRangeEnd = 243620, XrefRangeStart = 243607, XrefRangeEnd = 243611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr_get_timeUnpressed_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001FA RID: 506 RVA: 0x000356C8 File Offset: 0x000338C8
		public unsafe double RswtHgaVtUDKLyQaYqalFTmOSlI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243620, XrefRangeEnd = 243621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr_get_lastTimePressed_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00035704 File Offset: 0x00033904
		public unsafe double GiSWCyKJlJRelKitWoqGDdfJcFo
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 243622, RefRangeEnd = 243626, XrefRangeStart = 243621, XrefRangeEnd = 243622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr_get_lastTimeUnpressed_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00035740 File Offset: 0x00033940
		public unsafe double YlEgPSJQjFdLCuJniCnZezsWxOku
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 243626, RefRangeEnd = 243630, XrefRangeStart = 243626, XrefRangeEnd = 243626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr_get_lastTimeStateChangedToPressed_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0003577C File Offset: 0x0003397C
		public unsafe double LPmCEYogEzPvqvqnPoSZqmatIzb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr_get_lastTimeStateChangedToUnpressed_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001FE RID: 510 RVA: 0x000357B8 File Offset: 0x000339B8
		public unsafe double xJYPHZTMWLVNyLqWMPnFNZUwEie
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr_get_lastTimeStateChanged_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000357F4 File Offset: 0x000339F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243645, RefRangeEnd = 243648, XrefRangeStart = 243630, XrefRangeEnd = 243645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonStateRecorder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00035830 File Offset: 0x00033A30
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 243654, RefRangeEnd = 243662, XrefRangeStart = 243648, XrefRangeEnd = 243654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void xozDTcGUrsCTUDmjINWIvPSceAOJ(bool A_1, bool A_2, double A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_Boolean_Boolean_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0003588C File Offset: 0x00033A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243662, XrefRangeEnd = 243663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool feyDOtAvtBEFDAJZDoQyNGbyZfuu(float A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr_feyDOtAvtBEFDAJZDoQyNGbyZfuu_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000358D8 File Offset: 0x00033AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243663, XrefRangeEnd = 243664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool lsTurqsAnocHAPVTlPlyYcIcNVT(float A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr_lsTurqsAnocHAPVTlPlyYcIcNVT_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00035924 File Offset: 0x00033B24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 243664, RefRangeEnd = 243668, XrefRangeStart = 243664, XrefRangeEnd = 243664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool feyDOtAvtBEFDAJZDoQyNGbyZfuu(Il2CppReferenceArray<ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl> A_0, int A_1, float A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr_feyDOtAvtBEFDAJZDoQyNGbyZfuu_Private_Static_Boolean_Il2CppReferenceArray_1_jkNQkQoZzsneSNRSNZmPBHEaNTl_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00035984 File Offset: 0x00033B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243668, RefRangeEnd = 243669, XrefRangeStart = 243668, XrefRangeEnd = 243668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RvQMLrToBYEHiALiAnytDoraaHIB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr_RvQMLrToBYEHiALiAnytDoraaHIB_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000359B8 File Offset: 0x00033BB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 243669, RefRangeEnd = 243673, XrefRangeStart = 243669, XrefRangeEnd = 243669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void vsfKIEzLYgmvYXdfRKJgdqwirYk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000359EC File Offset: 0x00033BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243673, XrefRangeEnd = 243674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void roAugCmsvTatLyZkSedgEuOZmRC(double A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr_roAugCmsvTatLyZkSedgEuOZmRC_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00035A2C File Offset: 0x00033C2C
		[CallerCount(0)]
		public unsafe static int BACoBzImgHaXFAcmxhFKGuWLzdhm(int A_0, int A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr_BACoBzImgHaXFAcmxhFKGuWLzdhm_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00035A78 File Offset: 0x00033C78
		[CallerCount(0)]
		public unsafe static int iytgzhGnTodBhaYzaHzMetajKoeF(int A_0, int A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.NativeMethodInfoPtr_iytgzhGnTodBhaYzaHzMetajKoeF_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000028DB File Offset: 0x00000ADB
		public ButtonStateRecorder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00035AC4 File Offset: 0x00033CC4
		// (set) Token: 0x0600020B RID: 523 RVA: 0x000028E4 File Offset: 0x00000AE4
		public unsafe static int ecRrQWMveyrtspRKHHCNAaPQoEj
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ButtonStateRecorder.NativeFieldInfoPtr_ecRrQWMveyrtspRKHHCNAaPQoEj, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ButtonStateRecorder.NativeFieldInfoPtr_ecRrQWMveyrtspRKHHCNAaPQoEj, (void*)(&value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00035AE0 File Offset: 0x00033CE0
		// (set) Token: 0x0600020D RID: 525 RVA: 0x000028F2 File Offset: 0x00000AF2
		public unsafe Il2CppReferenceArray<ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl> WZJGJlGHePZBbvenKyBJWpZyYjh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonStateRecorder.NativeFieldInfoPtr_WZJGJlGHePZBbvenKyBJWpZyYjh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonStateRecorder.NativeFieldInfoPtr_WZJGJlGHePZBbvenKyBJWpZyYjh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00035B10 File Offset: 0x00033D10
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00002911 File Offset: 0x00000B11
		public unsafe Il2CppReferenceArray<ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl> NEJAAzjuTnFJqapKOHASTcVNajlo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonStateRecorder.NativeFieldInfoPtr_NEJAAzjuTnFJqapKOHASTcVNajlo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonStateRecorder.NativeFieldInfoPtr_NEJAAzjuTnFJqapKOHASTcVNajlo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00035B40 File Offset: 0x00033D40
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00002930 File Offset: 0x00000B30
		public unsafe int zLmYYankjqimcqwibEdThACcOtt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonStateRecorder.NativeFieldInfoPtr_zLmYYankjqimcqwibEdThACcOtt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonStateRecorder.NativeFieldInfoPtr_zLmYYankjqimcqwibEdThACcOtt)) = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00035B68 File Offset: 0x00033D68
		// (set) Token: 0x06000213 RID: 531 RVA: 0x0000294B File Offset: 0x00000B4B
		public unsafe int WiOvzmAntVNCPbLTrUOLVBzCUFG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonStateRecorder.NativeFieldInfoPtr_WiOvzmAntVNCPbLTrUOLVBzCUFG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonStateRecorder.NativeFieldInfoPtr_WiOvzmAntVNCPbLTrUOLVBzCUFG)) = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00035B90 File Offset: 0x00033D90
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00002966 File Offset: 0x00000B66
		public unsafe uint LKJjsMjRuzTdFXlIafBOKFfChgcB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonStateRecorder.NativeFieldInfoPtr_LKJjsMjRuzTdFXlIafBOKFfChgcB);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonStateRecorder.NativeFieldInfoPtr_LKJjsMjRuzTdFXlIafBOKFfChgcB)) = value;
			}
		}

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeFieldInfoPtr_ecRrQWMveyrtspRKHHCNAaPQoEj;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeFieldInfoPtr_WZJGJlGHePZBbvenKyBJWpZyYjh;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeFieldInfoPtr_NEJAAzjuTnFJqapKOHASTcVNajlo;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeFieldInfoPtr_zLmYYankjqimcqwibEdThACcOtt;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeFieldInfoPtr_WiOvzmAntVNCPbLTrUOLVBzCUFG;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeFieldInfoPtr_LKJjsMjRuzTdFXlIafBOKFfChgcB;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_get_timePressed_Public_get_Double_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_get_timeUnpressed_Public_get_Double_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_get_lastTimePressed_Public_get_Double_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_get_lastTimeUnpressed_Public_get_Double_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_get_lastTimeStateChangedToPressed_Public_get_Double_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_get_lastTimeStateChangedToUnpressed_Public_get_Double_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_get_lastTimeStateChanged_Public_get_Double_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_Boolean_Boolean_Double_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_feyDOtAvtBEFDAJZDoQyNGbyZfuu_Public_Boolean_Single_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_lsTurqsAnocHAPVTlPlyYcIcNVT_Public_Boolean_Single_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_feyDOtAvtBEFDAJZDoQyNGbyZfuu_Private_Static_Boolean_Il2CppReferenceArray_1_jkNQkQoZzsneSNRSNZmPBHEaNTl_Int32_Single_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_RvQMLrToBYEHiALiAnytDoraaHIB_Private_Void_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Void_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_roAugCmsvTatLyZkSedgEuOZmRC_Public_Void_Double_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_BACoBzImgHaXFAcmxhFKGuWLzdhm_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_iytgzhGnTodBhaYzaHzMetajKoeF_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x0200021F RID: 543
		public class jkNQkQoZzsneSNRSNZmPBHEaNTl : Object
		{
			// Token: 0x0600376A RID: 14186 RVA: 0x00111718 File Offset: 0x0010F918
			// Note: this type is marked as 'beforefieldinit'.
			static jkNQkQoZzsneSNRSNZmPBHEaNTl()
			{
				Il2CppClassPointerStore<ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ButtonStateRecorder>.NativeClassPtr, "jkNQkQoZzsneSNRSNZmPBHEaNTl");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl>.NativeClassPtr);
				ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl.NativeFieldInfoPtr_SeRsAehrVXBLRGGatrXTXYlZUxA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl>.NativeClassPtr, "SeRsAehrVXBLRGGatrXTXYlZUxA");
				ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl.NativeFieldInfoPtr_dDtJyBCtADynZXagshpYdoieGue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl>.NativeClassPtr, "dDtJyBCtADynZXagshpYdoieGue");
				ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Public_Void_jkNQkQoZzsneSNRSNZmPBHEaNTl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl>.NativeClassPtr, 100663640);
				ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl>.NativeClassPtr, 100663641);
				ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl>.NativeClassPtr, 100663642);
			}

			// Token: 0x0600376B RID: 14187 RVA: 0x001117A8 File Offset: 0x0010F9A8
			[CallerCount(0)]
			public unsafe void qMMTpeQwXdHPjVTnNgIqFdgetDa(ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Public_Void_jkNQkQoZzsneSNRSNZmPBHEaNTl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600376C RID: 14188 RVA: 0x001117EC File Offset: 0x0010F9EC
			[CallerCount(0)]
			public unsafe void vsfKIEzLYgmvYXdfRKJgdqwirYk()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600376D RID: 14189 RVA: 0x00111820 File Offset: 0x0010FA20
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe jkNQkQoZzsneSNRSNZmPBHEaNTl()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600376E RID: 14190 RVA: 0x00013143 File Offset: 0x00011343
			public jkNQkQoZzsneSNRSNZmPBHEaNTl(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700108A RID: 4234
			// (get) Token: 0x0600376F RID: 14191 RVA: 0x0011185C File Offset: 0x0010FA5C
			// (set) Token: 0x06003770 RID: 14192 RVA: 0x0001314C File Offset: 0x0001134C
			public unsafe bool SeRsAehrVXBLRGGatrXTXYlZUxA
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl.NativeFieldInfoPtr_SeRsAehrVXBLRGGatrXTXYlZUxA);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl.NativeFieldInfoPtr_SeRsAehrVXBLRGGatrXTXYlZUxA)) = value;
				}
			}

			// Token: 0x1700108B RID: 4235
			// (get) Token: 0x06003771 RID: 14193 RVA: 0x00111884 File Offset: 0x0010FA84
			// (set) Token: 0x06003772 RID: 14194 RVA: 0x00013167 File Offset: 0x00011367
			public unsafe double dDtJyBCtADynZXagshpYdoieGue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl.NativeFieldInfoPtr_dDtJyBCtADynZXagshpYdoieGue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonStateRecorder.jkNQkQoZzsneSNRSNZmPBHEaNTl.NativeFieldInfoPtr_dDtJyBCtADynZXagshpYdoieGue)) = value;
				}
			}

			// Token: 0x04002EF3 RID: 12019
			private static readonly IntPtr NativeFieldInfoPtr_SeRsAehrVXBLRGGatrXTXYlZUxA;

			// Token: 0x04002EF4 RID: 12020
			private static readonly IntPtr NativeFieldInfoPtr_dDtJyBCtADynZXagshpYdoieGue;

			// Token: 0x04002EF5 RID: 12021
			private static readonly IntPtr NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Public_Void_jkNQkQoZzsneSNRSNZmPBHEaNTl_0;

			// Token: 0x04002EF6 RID: 12022
			private static readonly IntPtr NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Void_0;

			// Token: 0x04002EF7 RID: 12023
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
