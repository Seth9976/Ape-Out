using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppRewired.Utils.Classes.Utility;
using Il2CppSystem;

namespace Il2CppRewired.HID
{
	// Token: 0x02000120 RID: 288
	public class HidOutputReportHandler : Object
	{
		// Token: 0x06001D7D RID: 7549 RVA: 0x0009CA1C File Offset: 0x0009AC1C
		// Note: this type is marked as 'beforefieldinit'.
		static HidOutputReportHandler()
		{
			Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID", "HidOutputReportHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr);
			HidOutputReportHandler.NativeFieldInfoPtr_KJOVPkqVvCBREkLFVvZLIDWwfaR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, "KJOVPkqVvCBREkLFVvZLIDWwfaR");
			HidOutputReportHandler.NativeFieldInfoPtr_vsCedUeUDoAGCcudqcpVbzVFfkYh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, "vsCedUeUDoAGCcudqcpVbzVFfkYh");
			HidOutputReportHandler.NativeFieldInfoPtr_FQJhJVEkltdSVjbYYtjiogDBaRAz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, "FQJhJVEkltdSVjbYYtjiogDBaRAz");
			HidOutputReportHandler.NativeFieldInfoPtr_EbNjedtgmmFwfTnOvvmSghwMnPZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, "EbNjedtgmmFwfTnOvvmSghwMnPZ");
			HidOutputReportHandler.NativeFieldInfoPtr_opZcIuANSUThUUHxuFnnDUzRXqF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, "opZcIuANSUThUUHxuFnnDUzRXqF");
			HidOutputReportHandler.NativeFieldInfoPtr_IXfDiUHlttgJMAztKzxKKKnKekXj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, "IXfDiUHlttgJMAztKzxKKKnKekXj");
			HidOutputReportHandler.NativeFieldInfoPtr_oEZtbKVDQiwNaTKoOIOXEoeGHWQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, "oEZtbKVDQiwNaTKoOIOXEoeGHWQ");
			HidOutputReportHandler.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, "cyyBkkdxKBBsyXCzMlRPgcvSIBjT");
			HidOutputReportHandler.NativeFieldInfoPtr_uEwFyoeMgCufrsFnnEncStxVlIEv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, "uEwFyoeMgCufrsFnnEncStxVlIEv");
			HidOutputReportHandler.NativeFieldInfoPtr_cdCAGuDQKeaKyJtijkzMMgTMCCA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, "cdCAGuDQKeaKyJtijkzMMgTMCCA");
			HidOutputReportHandler.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
			HidOutputReportHandler.NativeMethodInfoPtr__ctor_Public_Void_WriteReportDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, 100669769);
			HidOutputReportHandler.NativeMethodInfoPtr_WriteReport_Public_Void_OutputReport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, 100669770);
			HidOutputReportHandler.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, 100669771);
			HidOutputReportHandler.NativeMethodInfoPtr_addlbLsYdhqtKsbAsBkBewwooiH_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, 100669772);
			HidOutputReportHandler.NativeMethodInfoPtr_ghRwtMydhLgIeEFZWwEssneMZlc_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, 100669773);
			HidOutputReportHandler.NativeMethodInfoPtr_NfgabPAPWmoQSIPODfBJRNPIOXjF_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, 100669774);
			HidOutputReportHandler.NativeMethodInfoPtr_nnJNOcVmLSOOFEAQKuGBiuIZmqh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, 100669775);
			HidOutputReportHandler.NativeMethodInfoPtr_vpTktjsNIYOfNfMFVDQlcGOYroVa_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, 100669776);
			HidOutputReportHandler.NativeMethodInfoPtr_khVkVIhFAUMrhObnIwpBwEBgHnb_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, 100669777);
			HidOutputReportHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, 100669778);
			HidOutputReportHandler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, 100669779);
			HidOutputReportHandler.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, 100669780);
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x0009CC18 File Offset: 0x0009AE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280599, XrefRangeEnd = 280609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HidOutputReportHandler(HidOutputReportHandler.WriteReportDelegate writeReportDelegate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writeReportDelegate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.NativeMethodInfoPtr__ctor_Public_Void_WriteReportDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x0009CC64 File Offset: 0x0009AE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280609, XrefRangeEnd = 280622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteReport(OutputReport report)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref report;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.NativeMethodInfoPtr_WriteReport_Public_Void_OutputReport_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x0009CCA4 File Offset: 0x0009AEA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280639, RefRangeEnd = 280640, XrefRangeStart = 280622, XrefRangeEnd = 280639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x0009CCD8 File Offset: 0x0009AED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280640, XrefRangeEnd = 280641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool addlbLsYdhqtKsbAsBkBewwooiH()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.NativeMethodInfoPtr_addlbLsYdhqtKsbAsBkBewwooiH_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x0009CD14 File Offset: 0x0009AF14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280674, RefRangeEnd = 280676, XrefRangeStart = 280641, XrefRangeEnd = 280674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ghRwtMydhLgIeEFZWwEssneMZlc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.NativeMethodInfoPtr_ghRwtMydhLgIeEFZWwEssneMZlc_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x0009CD50 File Offset: 0x0009AF50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280690, RefRangeEnd = 280691, XrefRangeStart = 280676, XrefRangeEnd = 280690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NfgabPAPWmoQSIPODfBJRNPIOXjF()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.NativeMethodInfoPtr_NfgabPAPWmoQSIPODfBJRNPIOXjF_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x0009CD84 File Offset: 0x0009AF84
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void nnJNOcVmLSOOFEAQKuGBiuIZmqh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.NativeMethodInfoPtr_nnJNOcVmLSOOFEAQKuGBiuIZmqh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x0009CDB8 File Offset: 0x0009AFB8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void vpTktjsNIYOfNfMFVDQlcGOYroVa()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.NativeMethodInfoPtr_vpTktjsNIYOfNfMFVDQlcGOYroVa_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x0009CDEC File Offset: 0x0009AFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280691, XrefRangeEnd = 280703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void khVkVIhFAUMrhObnIwpBwEBgHnb()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.NativeMethodInfoPtr_khVkVIhFAUMrhObnIwpBwEBgHnb_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x0009CE20 File Offset: 0x0009B020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280703, XrefRangeEnd = 280707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x0009CE54 File Offset: 0x0009B054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HidOutputReportHandler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x0009CE90 File Offset: 0x0009B090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280707, XrefRangeEnd = 280713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HidOutputReportHandler.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x0000C2F6 File Offset: 0x0000A4F6
		public HidOutputReportHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x0009CEDC File Offset: 0x0009B0DC
		// (set) Token: 0x06001D8C RID: 7564 RVA: 0x0000C2FF File Offset: 0x0000A4FF
		public unsafe static bool KJOVPkqVvCBREkLFVvZLIDWwfaR
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(HidOutputReportHandler.NativeFieldInfoPtr_KJOVPkqVvCBREkLFVvZLIDWwfaR, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HidOutputReportHandler.NativeFieldInfoPtr_KJOVPkqVvCBREkLFVvZLIDWwfaR, (void*)(&value));
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x0009CEF8 File Offset: 0x0009B0F8
		// (set) Token: 0x06001D8E RID: 7566 RVA: 0x0000C30D File Offset: 0x0000A50D
		public unsafe static int vsCedUeUDoAGCcudqcpVbzVFfkYh
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HidOutputReportHandler.NativeFieldInfoPtr_vsCedUeUDoAGCcudqcpVbzVFfkYh, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HidOutputReportHandler.NativeFieldInfoPtr_vsCedUeUDoAGCcudqcpVbzVFfkYh, (void*)(&value));
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x0009CF14 File Offset: 0x0009B114
		// (set) Token: 0x06001D90 RID: 7568 RVA: 0x0000C31B File Offset: 0x0000A51B
		public unsafe static int FQJhJVEkltdSVjbYYtjiogDBaRAz
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HidOutputReportHandler.NativeFieldInfoPtr_FQJhJVEkltdSVjbYYtjiogDBaRAz, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HidOutputReportHandler.NativeFieldInfoPtr_FQJhJVEkltdSVjbYYtjiogDBaRAz, (void*)(&value));
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x0009CF30 File Offset: 0x0009B130
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x0000C329 File Offset: 0x0000A529
		public unsafe ThreadHelper EbNjedtgmmFwfTnOvvmSghwMnPZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.NativeFieldInfoPtr_EbNjedtgmmFwfTnOvvmSghwMnPZ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.NativeFieldInfoPtr_EbNjedtgmmFwfTnOvvmSghwMnPZ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x0009CF60 File Offset: 0x0009B160
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x0000C348 File Offset: 0x0000A548
		public unsafe HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT opZcIuANSUThUUHxuFnnDUzRXqF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.NativeFieldInfoPtr_opZcIuANSUThUUHxuFnnDUzRXqF);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.NativeFieldInfoPtr_opZcIuANSUThUUHxuFnnDUzRXqF), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x0009CF90 File Offset: 0x0009B190
		// (set) Token: 0x06001D96 RID: 7574 RVA: 0x0000C367 File Offset: 0x0000A567
		public unsafe HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT IXfDiUHlttgJMAztKzxKKKnKekXj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.NativeFieldInfoPtr_IXfDiUHlttgJMAztKzxKKKnKekXj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.NativeFieldInfoPtr_IXfDiUHlttgJMAztKzxKKKnKekXj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x0009CFC0 File Offset: 0x0009B1C0
		// (set) Token: 0x06001D98 RID: 7576 RVA: 0x0000C386 File Offset: 0x0000A586
		public unsafe bool oEZtbKVDQiwNaTKoOIOXEoeGHWQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.NativeFieldInfoPtr_oEZtbKVDQiwNaTKoOIOXEoeGHWQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.NativeFieldInfoPtr_oEZtbKVDQiwNaTKoOIOXEoeGHWQ)) = value;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x0009CFE8 File Offset: 0x0009B1E8
		// (set) Token: 0x06001D9A RID: 7578 RVA: 0x0000C3A1 File Offset: 0x0000A5A1
		public unsafe bool cyyBkkdxKBBsyXCzMlRPgcvSIBjT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT)) = value;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x0009D010 File Offset: 0x0009B210
		// (set) Token: 0x06001D9C RID: 7580 RVA: 0x0000C3BC File Offset: 0x0000A5BC
		public unsafe Object uEwFyoeMgCufrsFnnEncStxVlIEv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.NativeFieldInfoPtr_uEwFyoeMgCufrsFnnEncStxVlIEv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.NativeFieldInfoPtr_uEwFyoeMgCufrsFnnEncStxVlIEv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x0009D040 File Offset: 0x0009B240
		// (set) Token: 0x06001D9E RID: 7582 RVA: 0x0000C3DB File Offset: 0x0000A5DB
		public unsafe HidOutputReportHandler.WriteReportDelegate cdCAGuDQKeaKyJtijkzMMgTMCCA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.NativeFieldInfoPtr_cdCAGuDQKeaKyJtijkzMMgTMCCA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HidOutputReportHandler.WriteReportDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.NativeFieldInfoPtr_cdCAGuDQKeaKyJtijkzMMgTMCCA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x0009D070 File Offset: 0x0009B270
		// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x0000C3FA File Offset: 0x0000A5FA
		public unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
			}
		}

		// Token: 0x040018A9 RID: 6313
		private static readonly IntPtr NativeFieldInfoPtr_KJOVPkqVvCBREkLFVvZLIDWwfaR;

		// Token: 0x040018AA RID: 6314
		private static readonly IntPtr NativeFieldInfoPtr_vsCedUeUDoAGCcudqcpVbzVFfkYh;

		// Token: 0x040018AB RID: 6315
		private static readonly IntPtr NativeFieldInfoPtr_FQJhJVEkltdSVjbYYtjiogDBaRAz;

		// Token: 0x040018AC RID: 6316
		private static readonly IntPtr NativeFieldInfoPtr_EbNjedtgmmFwfTnOvvmSghwMnPZ;

		// Token: 0x040018AD RID: 6317
		private static readonly IntPtr NativeFieldInfoPtr_opZcIuANSUThUUHxuFnnDUzRXqF;

		// Token: 0x040018AE RID: 6318
		private static readonly IntPtr NativeFieldInfoPtr_IXfDiUHlttgJMAztKzxKKKnKekXj;

		// Token: 0x040018AF RID: 6319
		private static readonly IntPtr NativeFieldInfoPtr_oEZtbKVDQiwNaTKoOIOXEoeGHWQ;

		// Token: 0x040018B0 RID: 6320
		private static readonly IntPtr NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT;

		// Token: 0x040018B1 RID: 6321
		private static readonly IntPtr NativeFieldInfoPtr_uEwFyoeMgCufrsFnnEncStxVlIEv;

		// Token: 0x040018B2 RID: 6322
		private static readonly IntPtr NativeFieldInfoPtr_cdCAGuDQKeaKyJtijkzMMgTMCCA;

		// Token: 0x040018B3 RID: 6323
		private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

		// Token: 0x040018B4 RID: 6324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WriteReportDelegate_0;

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeMethodInfoPtr_WriteReport_Public_Void_OutputReport_0;

		// Token: 0x040018B6 RID: 6326
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeMethodInfoPtr_addlbLsYdhqtKsbAsBkBewwooiH_Private_Boolean_0;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeMethodInfoPtr_ghRwtMydhLgIeEFZWwEssneMZlc_Private_Boolean_0;

		// Token: 0x040018B9 RID: 6329
		private static readonly IntPtr NativeMethodInfoPtr_NfgabPAPWmoQSIPODfBJRNPIOXjF_Private_Void_0;

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeMethodInfoPtr_nnJNOcVmLSOOFEAQKuGBiuIZmqh_Private_Void_0;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeMethodInfoPtr_vpTktjsNIYOfNfMFVDQlcGOYroVa_Private_Void_0;

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeMethodInfoPtr_khVkVIhFAUMrhObnIwpBwEBgHnb_Private_Void_0;

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x02000337 RID: 823
		public sealed class WriteReportDelegate : MulticastDelegate
		{
			// Token: 0x0600459A RID: 17818 RVA: 0x0014473C File Offset: 0x0014293C
			// Note: this type is marked as 'beforefieldinit'.
			static WriteReportDelegate()
			{
				Il2CppClassPointerStore<HidOutputReportHandler.WriteReportDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, "WriteReportDelegate");
				HidOutputReportHandler.WriteReportDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler.WriteReportDelegate>.NativeClassPtr, 100669781);
				HidOutputReportHandler.WriteReportDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_OutputReport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler.WriteReportDelegate>.NativeClassPtr, 100669782);
				HidOutputReportHandler.WriteReportDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_OutputReport_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler.WriteReportDelegate>.NativeClassPtr, 100669783);
				HidOutputReportHandler.WriteReportDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler.WriteReportDelegate>.NativeClassPtr, 100669784);
			}

			// Token: 0x0600459B RID: 17819 RVA: 0x001447B0 File Offset: 0x001429B0
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WriteReportDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HidOutputReportHandler.WriteReportDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.WriteReportDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600459C RID: 17820 RVA: 0x0014480C File Offset: 0x00142A0C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 280575, RefRangeEnd = 280579, XrefRangeStart = 280575, XrefRangeEnd = 280575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Invoke(OutputReport report)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref report;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.WriteReportDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_OutputReport_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600459D RID: 17821 RVA: 0x00144858 File Offset: 0x00142A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280579, XrefRangeEnd = 280583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(OutputReport report, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref report;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.WriteReportDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_OutputReport_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600459E RID: 17822 RVA: 0x001448C8 File Offset: 0x00142AC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.WriteReportDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600459F RID: 17823 RVA: 0x0001911F File Offset: 0x0001731F
			public WriteReportDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060045A0 RID: 17824 RVA: 0x00019128 File Offset: 0x00017328
			public static implicit operator HidOutputReportHandler.WriteReportDelegate(Func<OutputReport, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<HidOutputReportHandler.WriteReportDelegate>(A_0);
			}

			// Token: 0x060045A1 RID: 17825 RVA: 0x00019130 File Offset: 0x00017330
			public static HidOutputReportHandler.WriteReportDelegate operator +(HidOutputReportHandler.WriteReportDelegate A_0, HidOutputReportHandler.WriteReportDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<HidOutputReportHandler.WriteReportDelegate>();
			}

			// Token: 0x060045A2 RID: 17826 RVA: 0x0001913E File Offset: 0x0001733E
			public static HidOutputReportHandler.WriteReportDelegate operator -(HidOutputReportHandler.WriteReportDelegate A_0, HidOutputReportHandler.WriteReportDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<HidOutputReportHandler.WriteReportDelegate>();
				}
				return delegate2;
			}

			// Token: 0x040038E8 RID: 14568
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040038E9 RID: 14569
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_OutputReport_0;

			// Token: 0x040038EA RID: 14570
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_OutputReport_AsyncCallback_Object_0;

			// Token: 0x040038EB RID: 14571
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
		}

		// Token: 0x02000338 RID: 824
		public class aojCSgklbUWjLbAKnafeGAVevtMT : Object
		{
			// Token: 0x060045A3 RID: 17827 RVA: 0x00144918 File Offset: 0x00142B18
			// Note: this type is marked as 'beforefieldinit'.
			static aojCSgklbUWjLbAKnafeGAVevtMT()
			{
				Il2CppClassPointerStore<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HidOutputReportHandler>.NativeClassPtr, "aojCSgklbUWjLbAKnafeGAVevtMT");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>.NativeClassPtr);
				HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeFieldInfoPtr_fCaZTFdmCnjXGCAebDFEzujRcoe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>.NativeClassPtr, "fCaZTFdmCnjXGCAebDFEzujRcoe");
				HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeFieldInfoPtr_DylQSvImqYEcPpGJKegARlealsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>.NativeClassPtr, "DylQSvImqYEcPpGJKegARlealsg");
				HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeFieldInfoPtr_opZcIuANSUThUUHxuFnnDUzRXqF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>.NativeClassPtr, "opZcIuANSUThUUHxuFnnDUzRXqF");
				HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
				HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr_get_HasReport_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>.NativeClassPtr, 100669785);
				HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>.NativeClassPtr, 100669786);
				HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr_WhszaOPrXDgIaaTUEYWWpyVADMY_Public_Void_byref_OutputReport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>.NativeClassPtr, 100669787);
				HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr_TjpRxshBUfWrSHtsHVekSjCFeCo_Public_OutputReport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>.NativeClassPtr, 100669788);
				HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr_WHbnHPnJXYWQZzCjsaHQwwlEWTx_Public_OutputReport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>.NativeClassPtr, 100669789);
				HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>.NativeClassPtr, 100669790);
				HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>.NativeClassPtr, 100669791);
				HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>.NativeClassPtr, 100669792);
				HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr_oVDGrSAxKrDXHIrLCgtBQsySCAh_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>.NativeClassPtr, 100669793);
			}

			// Token: 0x170015BF RID: 5567
			// (get) Token: 0x060045A4 RID: 17828 RVA: 0x00144A48 File Offset: 0x00142C48
			public unsafe bool jcpvDuDWGLcqfCFikrkMQhgOxQA
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr_get_HasReport_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045A5 RID: 17829 RVA: 0x00144A84 File Offset: 0x00142C84
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 280587, RefRangeEnd = 280589, XrefRangeStart = 280583, XrefRangeEnd = 280587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe aojCSgklbUWjLbAKnafeGAVevtMT()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045A6 RID: 17830 RVA: 0x00144AC0 File Offset: 0x00142CC0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 280592, RefRangeEnd = 280593, XrefRangeStart = 280589, XrefRangeEnd = 280592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WhszaOPrXDgIaaTUEYWWpyVADMY(ref OutputReport A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr_WhszaOPrXDgIaaTUEYWWpyVADMY_Public_Void_byref_OutputReport_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060045A7 RID: 17831 RVA: 0x00144B00 File Offset: 0x00142D00
			[CallerCount(0)]
			public unsafe OutputReport TjpRxshBUfWrSHtsHVekSjCFeCo()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr_TjpRxshBUfWrSHtsHVekSjCFeCo_Public_OutputReport_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060045A8 RID: 17832 RVA: 0x00144B3C File Offset: 0x00142D3C
			[CallerCount(0)]
			public unsafe OutputReport WHbnHPnJXYWQZzCjsaHQwwlEWTx()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr_WHbnHPnJXYWQZzCjsaHQwwlEWTx_Public_OutputReport_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060045A9 RID: 17833 RVA: 0x00144B78 File Offset: 0x00142D78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280593, XrefRangeEnd = 280594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GMFpQqtyJcjzYToWCrZsZQAhPYh()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045AA RID: 17834 RVA: 0x00144BAC File Offset: 0x00142DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280594, XrefRangeEnd = 280598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045AB RID: 17835 RVA: 0x00144BE0 File Offset: 0x00142DE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void Finalize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045AC RID: 17836 RVA: 0x00144C1C File Offset: 0x00142E1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280598, XrefRangeEnd = 280599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void oVDGrSAxKrDXHIrLCgtBQsySCAh(bool A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeMethodInfoPtr_oVDGrSAxKrDXHIrLCgtBQsySCAh_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060045AD RID: 17837 RVA: 0x0001914F File Offset: 0x0001734F
			public aojCSgklbUWjLbAKnafeGAVevtMT(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015BB RID: 5563
			// (get) Token: 0x060045AE RID: 17838 RVA: 0x00144C68 File Offset: 0x00142E68
			// (set) Token: 0x060045AF RID: 17839 RVA: 0x00019158 File Offset: 0x00017358
			public unsafe bool fCaZTFdmCnjXGCAebDFEzujRcoe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeFieldInfoPtr_fCaZTFdmCnjXGCAebDFEzujRcoe);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeFieldInfoPtr_fCaZTFdmCnjXGCAebDFEzujRcoe)) = value;
				}
			}

			// Token: 0x170015BC RID: 5564
			// (get) Token: 0x060045B0 RID: 17840 RVA: 0x00144C90 File Offset: 0x00142E90
			// (set) Token: 0x060045B1 RID: 17841 RVA: 0x00019173 File Offset: 0x00017373
			public unsafe OutputReport DylQSvImqYEcPpGJKegARlealsg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeFieldInfoPtr_DylQSvImqYEcPpGJKegARlealsg);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeFieldInfoPtr_DylQSvImqYEcPpGJKegARlealsg)) = value;
				}
			}

			// Token: 0x170015BD RID: 5565
			// (get) Token: 0x060045B2 RID: 17842 RVA: 0x00144CB8 File Offset: 0x00142EB8
			// (set) Token: 0x060045B3 RID: 17843 RVA: 0x0001918E File Offset: 0x0001738E
			public unsafe NativeBuffer opZcIuANSUThUUHxuFnnDUzRXqF
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeFieldInfoPtr_opZcIuANSUThUUHxuFnnDUzRXqF);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeFieldInfoPtr_opZcIuANSUThUUHxuFnnDUzRXqF), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015BE RID: 5566
			// (get) Token: 0x060045B4 RID: 17844 RVA: 0x00144CE8 File Offset: 0x00142EE8
			// (set) Token: 0x060045B5 RID: 17845 RVA: 0x000191AD File Offset: 0x000173AD
			public unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidOutputReportHandler.aojCSgklbUWjLbAKnafeGAVevtMT.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
				}
			}

			// Token: 0x040038EC RID: 14572
			private static readonly IntPtr NativeFieldInfoPtr_fCaZTFdmCnjXGCAebDFEzujRcoe;

			// Token: 0x040038ED RID: 14573
			private static readonly IntPtr NativeFieldInfoPtr_DylQSvImqYEcPpGJKegARlealsg;

			// Token: 0x040038EE RID: 14574
			private static readonly IntPtr NativeFieldInfoPtr_opZcIuANSUThUUHxuFnnDUzRXqF;

			// Token: 0x040038EF RID: 14575
			private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

			// Token: 0x040038F0 RID: 14576
			private static readonly IntPtr NativeMethodInfoPtr_get_HasReport_Public_get_Boolean_0;

			// Token: 0x040038F1 RID: 14577
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040038F2 RID: 14578
			private static readonly IntPtr NativeMethodInfoPtr_WhszaOPrXDgIaaTUEYWWpyVADMY_Public_Void_byref_OutputReport_0;

			// Token: 0x040038F3 RID: 14579
			private static readonly IntPtr NativeMethodInfoPtr_TjpRxshBUfWrSHtsHVekSjCFeCo_Public_OutputReport_0;

			// Token: 0x040038F4 RID: 14580
			private static readonly IntPtr NativeMethodInfoPtr_WHbnHPnJXYWQZzCjsaHQwwlEWTx_Public_OutputReport_0;

			// Token: 0x040038F5 RID: 14581
			private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Void_0;

			// Token: 0x040038F6 RID: 14582
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040038F7 RID: 14583
			private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

			// Token: 0x040038F8 RID: 14584
			private static readonly IntPtr NativeMethodInfoPtr_oVDGrSAxKrDXHIrLCgtBQsySCAh_Protected_Virtual_New_Void_Boolean_0;
		}
	}
}
