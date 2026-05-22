using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001EB RID: 491
	[StructLayout(2)]
	public struct XsdDateTime
	{
		// Token: 0x0600290B RID: 10507 RVA: 0x000BC698 File Offset: 0x000BA898
		// Note: this type is marked as 'beforefieldinit'.
		static XsdDateTime()
		{
			Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdDateTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr);
			XsdDateTime.NativeFieldInfoPtr_dt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "dt");
			XsdDateTime.NativeFieldInfoPtr_extra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "extra");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_MM");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_MM_");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_MM_dd");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_ddT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_MM_ddT");
			XsdDateTime.NativeFieldInfoPtr_LzHH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH");
			XsdDateTime.NativeFieldInfoPtr_LzHH_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH_");
			XsdDateTime.NativeFieldInfoPtr_LzHH_mm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH_mm");
			XsdDateTime.NativeFieldInfoPtr_LzHH_mm_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH_mm_");
			XsdDateTime.NativeFieldInfoPtr_LzHH_mm_ss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH_mm_ss");
			XsdDateTime.NativeFieldInfoPtr_Lz_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz_");
			XsdDateTime.NativeFieldInfoPtr_Lz_zz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz_zz");
			XsdDateTime.NativeFieldInfoPtr_Lz_zz_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz_zz_");
			XsdDateTime.NativeFieldInfoPtr_Lz_zz_zz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz_zz_zz");
			XsdDateTime.NativeFieldInfoPtr_Lz__ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__");
			XsdDateTime.NativeFieldInfoPtr_Lz__mm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__mm");
			XsdDateTime.NativeFieldInfoPtr_Lz__mm_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__mm_");
			XsdDateTime.NativeFieldInfoPtr_Lz__mm__ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__mm__");
			XsdDateTime.NativeFieldInfoPtr_Lz__mm_dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__mm_dd");
			XsdDateTime.NativeFieldInfoPtr_Lz___ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz___");
			XsdDateTime.NativeFieldInfoPtr_Lz___dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz___dd");
			XsdDateTime.NativeFieldInfoPtr_typeCodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "typeCodes");
			XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_String_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669162);
			XsdDateTime.NativeMethodInfoPtr__ctor_Private_Void_Parser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669163);
			XsdDateTime.NativeMethodInfoPtr_InitiateXsdDateTime_Private_Void_Parser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669164);
			XsdDateTime.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_XsdDateTimeFlags_byref_XsdDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669165);
			XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_DateTime_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669166);
			XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669167);
			XsdDateTime.NativeMethodInfoPtr_get_InternalTypeCode_Private_get_DateTimeTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669168);
			XsdDateTime.NativeMethodInfoPtr_get_InternalKind_Private_get_XsdDateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669169);
			XsdDateTime.NativeMethodInfoPtr_get_Year_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669170);
			XsdDateTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669171);
			XsdDateTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669172);
			XsdDateTime.NativeMethodInfoPtr_get_Hour_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669173);
			XsdDateTime.NativeMethodInfoPtr_get_Minute_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669174);
			XsdDateTime.NativeMethodInfoPtr_get_Second_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669175);
			XsdDateTime.NativeMethodInfoPtr_get_Fraction_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669176);
			XsdDateTime.NativeMethodInfoPtr_get_ZoneHour_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669177);
			XsdDateTime.NativeMethodInfoPtr_get_ZoneMinute_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669178);
			XsdDateTime.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTime_XsdDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669179);
			XsdDateTime.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_XsdDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669180);
			XsdDateTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669181);
			XsdDateTime.NativeMethodInfoPtr_PrintDate_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669182);
			XsdDateTime.NativeMethodInfoPtr_PrintTime_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669183);
			XsdDateTime.NativeMethodInfoPtr_PrintZone_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669184);
			XsdDateTime.NativeMethodInfoPtr_IntToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669185);
			XsdDateTime.NativeMethodInfoPtr_ShortToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669186);
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x000BCAB0 File Offset: 0x000BACB0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 438103, RefRangeEnd = 438124, XrefRangeStart = 438101, XrefRangeEnd = 438103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDateTime(string text, XsdDateTimeFlags kinds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kinds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_String_XsdDateTimeFlags_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x000BCAF4 File Offset: 0x000BACF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438124, XrefRangeEnd = 438125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDateTime(XsdDateTime.Parser parser)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parser));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr__ctor_Private_Void_Parser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x000BCB30 File Offset: 0x000BAD30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 438131, RefRangeEnd = 438135, XrefRangeStart = 438125, XrefRangeEnd = 438131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitiateXsdDateTime(XsdDateTime.Parser parser)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parser));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_InitiateXsdDateTime_Private_Void_Parser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x000BCB6C File Offset: 0x000BAD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438135, XrefRangeEnd = 438137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kinds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_XsdDateTimeFlags_byref_XsdDateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x000BCBCC File Offset: 0x000BADCC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 438146, RefRangeEnd = 438158, XrefRangeStart = 438137, XrefRangeEnd = 438146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDateTime(DateTime dateTime, XsdDateTimeFlags kinds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kinds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_DateTime_XsdDateTimeFlags_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x000BCC0C File Offset: 0x000BAE0C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 438169, RefRangeEnd = 438179, XrefRangeStart = 438158, XrefRangeEnd = 438169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDateTime(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTimeOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kinds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_XsdDateTimeFlags_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06002912 RID: 10514 RVA: 0x000BCC4C File Offset: 0x000BAE4C
		public unsafe XsdDateTime.DateTimeTypeCode InternalTypeCode
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_InternalTypeCode_Private_get_DateTimeTypeCode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06002913 RID: 10515 RVA: 0x000BCC7C File Offset: 0x000BAE7C
		public unsafe XsdDateTime.XsdDateTimeKind InternalKind
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_InternalKind_Private_get_XsdDateTimeKind_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06002914 RID: 10516 RVA: 0x000BCCAC File Offset: 0x000BAEAC
		public unsafe int Year
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Year_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06002915 RID: 10517 RVA: 0x000BCCDC File Offset: 0x000BAEDC
		public unsafe int Month
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06002916 RID: 10518 RVA: 0x000BCD0C File Offset: 0x000BAF0C
		public unsafe int Day
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x000BCD3C File Offset: 0x000BAF3C
		public unsafe int Hour
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Hour_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06002918 RID: 10520 RVA: 0x000BCD6C File Offset: 0x000BAF6C
		public unsafe int Minute
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Minute_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06002919 RID: 10521 RVA: 0x000BCD9C File Offset: 0x000BAF9C
		public unsafe int Second
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Second_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x0600291A RID: 10522 RVA: 0x000BCDCC File Offset: 0x000BAFCC
		public unsafe int Fraction
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 438187, RefRangeEnd = 438188, XrefRangeStart = 438179, XrefRangeEnd = 438187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Fraction_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x000BCDFC File Offset: 0x000BAFFC
		public unsafe int ZoneHour
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_ZoneHour_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x0600291C RID: 10524 RVA: 0x000BCE2C File Offset: 0x000BB02C
		public unsafe int ZoneMinute
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_ZoneMinute_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x000BCE5C File Offset: 0x000BB05C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 438258, RefRangeEnd = 438269, XrefRangeStart = 438188, XrefRangeEnd = 438258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DateTime(XsdDateTime xdt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xdt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTime_XsdDateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x000BCE9C File Offset: 0x000BB09C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 438314, RefRangeEnd = 438325, XrefRangeStart = 438269, XrefRangeEnd = 438314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DateTimeOffset(XsdDateTime xdt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xdt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_XsdDateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x000BCEDC File Offset: 0x000BB0DC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 438433, RefRangeEnd = 438455, XrefRangeStart = 438325, XrefRangeEnd = 438433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x000BCF08 File Offset: 0x000BB108
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 438470, RefRangeEnd = 438472, XrefRangeStart = 438455, XrefRangeEnd = 438470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintDate(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_PrintDate_Private_Void_StringBuilder_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x000BCF40 File Offset: 0x000BB140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438488, RefRangeEnd = 438489, XrefRangeStart = 438472, XrefRangeEnd = 438488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintTime(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_PrintTime_Private_Void_StringBuilder_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x000BCF78 File Offset: 0x000BB178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438509, RefRangeEnd = 438510, XrefRangeStart = 438489, XrefRangeEnd = 438509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintZone(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_PrintZone_Private_Void_StringBuilder_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x000BCFB0 File Offset: 0x000BB1B0
		[CallerCount(0)]
		public unsafe void IntToCharArray(Il2CppStructArray<char> text, int start, int value, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_IntToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x000BD010 File Offset: 0x000BB210
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 438510, RefRangeEnd = 438515, XrefRangeStart = 438510, XrefRangeEnd = 438510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShortToCharArray(Il2CppStructArray<char> text, int start, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_ShortToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x000115B8 File Offset: 0x0000F7B8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, ref this));
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06002926 RID: 10534 RVA: 0x000BD064 File Offset: 0x000BB264
		// (set) Token: 0x06002927 RID: 10535 RVA: 0x000115CA File Offset: 0x0000F7CA
		public unsafe static int Lzyyyy
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy, (void*)(&value));
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06002928 RID: 10536 RVA: 0x000BD080 File Offset: 0x000BB280
		// (set) Token: 0x06002929 RID: 10537 RVA: 0x000115D8 File Offset: 0x0000F7D8
		public unsafe static int Lzyyyy_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_, (void*)(&value));
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x0600292A RID: 10538 RVA: 0x000BD09C File Offset: 0x000BB29C
		// (set) Token: 0x0600292B RID: 10539 RVA: 0x000115E6 File Offset: 0x0000F7E6
		public unsafe static int Lzyyyy_MM
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM, (void*)(&value));
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x0600292C RID: 10540 RVA: 0x000BD0B8 File Offset: 0x000BB2B8
		// (set) Token: 0x0600292D RID: 10541 RVA: 0x000115F4 File Offset: 0x0000F7F4
		public unsafe static int Lzyyyy_MM_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_, (void*)(&value));
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x000BD0D4 File Offset: 0x000BB2D4
		// (set) Token: 0x0600292F RID: 10543 RVA: 0x00011602 File Offset: 0x0000F802
		public unsafe static int Lzyyyy_MM_dd
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_dd, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_dd, (void*)(&value));
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x000BD0F0 File Offset: 0x000BB2F0
		// (set) Token: 0x06002931 RID: 10545 RVA: 0x00011610 File Offset: 0x0000F810
		public unsafe static int Lzyyyy_MM_ddT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_ddT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_ddT, (void*)(&value));
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06002932 RID: 10546 RVA: 0x000BD10C File Offset: 0x000BB30C
		// (set) Token: 0x06002933 RID: 10547 RVA: 0x0001161E File Offset: 0x0000F81E
		public unsafe static int LzHH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_LzHH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_LzHH, (void*)(&value));
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06002934 RID: 10548 RVA: 0x000BD128 File Offset: 0x000BB328
		// (set) Token: 0x06002935 RID: 10549 RVA: 0x0001162C File Offset: 0x0000F82C
		public unsafe static int LzHH_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_LzHH_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_LzHH_, (void*)(&value));
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06002936 RID: 10550 RVA: 0x000BD144 File Offset: 0x000BB344
		// (set) Token: 0x06002937 RID: 10551 RVA: 0x0001163A File Offset: 0x0000F83A
		public unsafe static int LzHH_mm
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm, (void*)(&value));
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06002938 RID: 10552 RVA: 0x000BD160 File Offset: 0x000BB360
		// (set) Token: 0x06002939 RID: 10553 RVA: 0x00011648 File Offset: 0x0000F848
		public unsafe static int LzHH_mm_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm_, (void*)(&value));
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x0600293A RID: 10554 RVA: 0x000BD17C File Offset: 0x000BB37C
		// (set) Token: 0x0600293B RID: 10555 RVA: 0x00011656 File Offset: 0x0000F856
		public unsafe static int LzHH_mm_ss
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm_ss, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm_ss, (void*)(&value));
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x0600293C RID: 10556 RVA: 0x000BD198 File Offset: 0x000BB398
		// (set) Token: 0x0600293D RID: 10557 RVA: 0x00011664 File Offset: 0x0000F864
		public unsafe static int Lz_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz_, (void*)(&value));
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x000BD1B4 File Offset: 0x000BB3B4
		// (set) Token: 0x0600293F RID: 10559 RVA: 0x00011672 File Offset: 0x0000F872
		public unsafe static int Lz_zz
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz, (void*)(&value));
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x000BD1D0 File Offset: 0x000BB3D0
		// (set) Token: 0x06002941 RID: 10561 RVA: 0x00011680 File Offset: 0x0000F880
		public unsafe static int Lz_zz_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz_, (void*)(&value));
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06002942 RID: 10562 RVA: 0x000BD1EC File Offset: 0x000BB3EC
		// (set) Token: 0x06002943 RID: 10563 RVA: 0x0001168E File Offset: 0x0000F88E
		public unsafe static int Lz_zz_zz
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz_zz, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz_zz, (void*)(&value));
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06002944 RID: 10564 RVA: 0x000BD208 File Offset: 0x000BB408
		// (set) Token: 0x06002945 RID: 10565 RVA: 0x0001169C File Offset: 0x0000F89C
		public unsafe static int Lz__
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz__, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz__, (void*)(&value));
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06002946 RID: 10566 RVA: 0x000BD224 File Offset: 0x000BB424
		// (set) Token: 0x06002947 RID: 10567 RVA: 0x000116AA File Offset: 0x0000F8AA
		public unsafe static int Lz__mm
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm, (void*)(&value));
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06002948 RID: 10568 RVA: 0x000BD240 File Offset: 0x000BB440
		// (set) Token: 0x06002949 RID: 10569 RVA: 0x000116B8 File Offset: 0x0000F8B8
		public unsafe static int Lz__mm_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm_, (void*)(&value));
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x0600294A RID: 10570 RVA: 0x000BD25C File Offset: 0x000BB45C
		// (set) Token: 0x0600294B RID: 10571 RVA: 0x000116C6 File Offset: 0x0000F8C6
		public unsafe static int Lz__mm__
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm__, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm__, (void*)(&value));
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x0600294C RID: 10572 RVA: 0x000BD278 File Offset: 0x000BB478
		// (set) Token: 0x0600294D RID: 10573 RVA: 0x000116D4 File Offset: 0x0000F8D4
		public unsafe static int Lz__mm_dd
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm_dd, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm_dd, (void*)(&value));
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x000BD294 File Offset: 0x000BB494
		// (set) Token: 0x0600294F RID: 10575 RVA: 0x000116E2 File Offset: 0x0000F8E2
		public unsafe static int Lz___
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz___, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz___, (void*)(&value));
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x000BD2B0 File Offset: 0x000BB4B0
		// (set) Token: 0x06002951 RID: 10577 RVA: 0x000116F0 File Offset: 0x0000F8F0
		public unsafe static int Lz___dd
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz___dd, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz___dd, (void*)(&value));
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06002952 RID: 10578 RVA: 0x000BD2CC File Offset: 0x000BB4CC
		// (set) Token: 0x06002953 RID: 10579 RVA: 0x000116FE File Offset: 0x0000F8FE
		public unsafe static Il2CppStructArray<XmlTypeCode> typeCodes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_typeCodes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XmlTypeCode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_typeCodes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001EE7 RID: 7911
		private static readonly IntPtr NativeFieldInfoPtr_dt;

		// Token: 0x04001EE8 RID: 7912
		private static readonly IntPtr NativeFieldInfoPtr_extra;

		// Token: 0x04001EE9 RID: 7913
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy;

		// Token: 0x04001EEA RID: 7914
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_;

		// Token: 0x04001EEB RID: 7915
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_MM;

		// Token: 0x04001EEC RID: 7916
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_MM_;

		// Token: 0x04001EED RID: 7917
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_MM_dd;

		// Token: 0x04001EEE RID: 7918
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_MM_ddT;

		// Token: 0x04001EEF RID: 7919
		private static readonly IntPtr NativeFieldInfoPtr_LzHH;

		// Token: 0x04001EF0 RID: 7920
		private static readonly IntPtr NativeFieldInfoPtr_LzHH_;

		// Token: 0x04001EF1 RID: 7921
		private static readonly IntPtr NativeFieldInfoPtr_LzHH_mm;

		// Token: 0x04001EF2 RID: 7922
		private static readonly IntPtr NativeFieldInfoPtr_LzHH_mm_;

		// Token: 0x04001EF3 RID: 7923
		private static readonly IntPtr NativeFieldInfoPtr_LzHH_mm_ss;

		// Token: 0x04001EF4 RID: 7924
		private static readonly IntPtr NativeFieldInfoPtr_Lz_;

		// Token: 0x04001EF5 RID: 7925
		private static readonly IntPtr NativeFieldInfoPtr_Lz_zz;

		// Token: 0x04001EF6 RID: 7926
		private static readonly IntPtr NativeFieldInfoPtr_Lz_zz_;

		// Token: 0x04001EF7 RID: 7927
		private static readonly IntPtr NativeFieldInfoPtr_Lz_zz_zz;

		// Token: 0x04001EF8 RID: 7928
		private static readonly IntPtr NativeFieldInfoPtr_Lz__;

		// Token: 0x04001EF9 RID: 7929
		private static readonly IntPtr NativeFieldInfoPtr_Lz__mm;

		// Token: 0x04001EFA RID: 7930
		private static readonly IntPtr NativeFieldInfoPtr_Lz__mm_;

		// Token: 0x04001EFB RID: 7931
		private static readonly IntPtr NativeFieldInfoPtr_Lz__mm__;

		// Token: 0x04001EFC RID: 7932
		private static readonly IntPtr NativeFieldInfoPtr_Lz__mm_dd;

		// Token: 0x04001EFD RID: 7933
		private static readonly IntPtr NativeFieldInfoPtr_Lz___;

		// Token: 0x04001EFE RID: 7934
		private static readonly IntPtr NativeFieldInfoPtr_Lz___dd;

		// Token: 0x04001EFF RID: 7935
		private static readonly IntPtr NativeFieldInfoPtr_typeCodes;

		// Token: 0x04001F00 RID: 7936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_XsdDateTimeFlags_0;

		// Token: 0x04001F01 RID: 7937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Parser_0;

		// Token: 0x04001F02 RID: 7938
		private static readonly IntPtr NativeMethodInfoPtr_InitiateXsdDateTime_Private_Void_Parser_0;

		// Token: 0x04001F03 RID: 7939
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_XsdDateTimeFlags_byref_XsdDateTime_0;

		// Token: 0x04001F04 RID: 7940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_XsdDateTimeFlags_0;

		// Token: 0x04001F05 RID: 7941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_XsdDateTimeFlags_0;

		// Token: 0x04001F06 RID: 7942
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalTypeCode_Private_get_DateTimeTypeCode_0;

		// Token: 0x04001F07 RID: 7943
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalKind_Private_get_XsdDateTimeKind_0;

		// Token: 0x04001F08 RID: 7944
		private static readonly IntPtr NativeMethodInfoPtr_get_Year_Public_get_Int32_0;

		// Token: 0x04001F09 RID: 7945
		private static readonly IntPtr NativeMethodInfoPtr_get_Month_Public_get_Int32_0;

		// Token: 0x04001F0A RID: 7946
		private static readonly IntPtr NativeMethodInfoPtr_get_Day_Public_get_Int32_0;

		// Token: 0x04001F0B RID: 7947
		private static readonly IntPtr NativeMethodInfoPtr_get_Hour_Public_get_Int32_0;

		// Token: 0x04001F0C RID: 7948
		private static readonly IntPtr NativeMethodInfoPtr_get_Minute_Public_get_Int32_0;

		// Token: 0x04001F0D RID: 7949
		private static readonly IntPtr NativeMethodInfoPtr_get_Second_Public_get_Int32_0;

		// Token: 0x04001F0E RID: 7950
		private static readonly IntPtr NativeMethodInfoPtr_get_Fraction_Public_get_Int32_0;

		// Token: 0x04001F0F RID: 7951
		private static readonly IntPtr NativeMethodInfoPtr_get_ZoneHour_Public_get_Int32_0;

		// Token: 0x04001F10 RID: 7952
		private static readonly IntPtr NativeMethodInfoPtr_get_ZoneMinute_Public_get_Int32_0;

		// Token: 0x04001F11 RID: 7953
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DateTime_XsdDateTime_0;

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_XsdDateTime_0;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeMethodInfoPtr_PrintDate_Private_Void_StringBuilder_0;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeMethodInfoPtr_PrintTime_Private_Void_StringBuilder_0;

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeMethodInfoPtr_PrintZone_Private_Void_StringBuilder_0;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeMethodInfoPtr_IntToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_Int32_0;

		// Token: 0x04001F18 RID: 7960
		private static readonly IntPtr NativeMethodInfoPtr_ShortToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001F19 RID: 7961
		[FieldOffset(0)]
		public DateTime dt;

		// Token: 0x04001F1A RID: 7962
		[FieldOffset(8)]
		public uint extra;

		// Token: 0x02000253 RID: 595
		[OriginalName("System.Xml.dll", "", "DateTimeTypeCode")]
		public enum DateTimeTypeCode
		{
			// Token: 0x04002414 RID: 9236
			DateTime,
			// Token: 0x04002415 RID: 9237
			Time,
			// Token: 0x04002416 RID: 9238
			Date,
			// Token: 0x04002417 RID: 9239
			GYearMonth,
			// Token: 0x04002418 RID: 9240
			GYear,
			// Token: 0x04002419 RID: 9241
			GMonthDay,
			// Token: 0x0400241A RID: 9242
			GDay,
			// Token: 0x0400241B RID: 9243
			GMonth,
			// Token: 0x0400241C RID: 9244
			XdrDateTime
		}

		// Token: 0x02000254 RID: 596
		[OriginalName("System.Xml.dll", "", "XsdDateTimeKind")]
		public enum XsdDateTimeKind
		{
			// Token: 0x0400241E RID: 9246
			Unspecified,
			// Token: 0x0400241F RID: 9247
			Zulu,
			// Token: 0x04002420 RID: 9248
			LocalWestOfZulu,
			// Token: 0x04002421 RID: 9249
			LocalEastOfZulu
		}

		// Token: 0x02000255 RID: 597
		public sealed class Parser : ValueType
		{
			// Token: 0x06002DAE RID: 11694 RVA: 0x000CA380 File Offset: 0x000C8580
			// Note: this type is marked as 'beforefieldinit'.
			static Parser()
			{
				Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Parser");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr);
				XsdDateTime.Parser.NativeFieldInfoPtr_typeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "typeCode");
				XsdDateTime.Parser.NativeFieldInfoPtr_year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "year");
				XsdDateTime.Parser.NativeFieldInfoPtr_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "month");
				XsdDateTime.Parser.NativeFieldInfoPtr_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "day");
				XsdDateTime.Parser.NativeFieldInfoPtr_hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "hour");
				XsdDateTime.Parser.NativeFieldInfoPtr_minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "minute");
				XsdDateTime.Parser.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "second");
				XsdDateTime.Parser.NativeFieldInfoPtr_fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "fraction");
				XsdDateTime.Parser.NativeFieldInfoPtr_kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "kind");
				XsdDateTime.Parser.NativeFieldInfoPtr_zoneHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "zoneHour");
				XsdDateTime.Parser.NativeFieldInfoPtr_zoneMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "zoneMinute");
				XsdDateTime.Parser.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "text");
				XsdDateTime.Parser.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "length");
				XsdDateTime.Parser.NativeFieldInfoPtr_Power10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "Power10");
				XsdDateTime.Parser.NativeMethodInfoPtr_Parse_Public_Boolean_String_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669188);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseDate_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669189);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseTimeAndZoneAndWhitespace_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669190);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseTimeAndWhitespace_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669191);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseTime_Private_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669192);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseZoneAndWhitespace_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669193);
				XsdDateTime.Parser.NativeMethodInfoPtr_Parse4Dig_Private_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669194);
				XsdDateTime.Parser.NativeMethodInfoPtr_Parse2Dig_Private_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669195);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseChar_Private_Boolean_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669196);
				XsdDateTime.Parser.NativeMethodInfoPtr_Test_Private_Static_Boolean_XsdDateTimeFlags_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669197);
			}

			// Token: 0x06002DAF RID: 11695 RVA: 0x000CA58C File Offset: 0x000C878C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 438001, RefRangeEnd = 438004, XrefRangeStart = 437979, XrefRangeEnd = 438001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Parse(string text, XsdDateTimeFlags kinds)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kinds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_Parse_Public_Boolean_String_XsdDateTimeFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002DB0 RID: 11696 RVA: 0x000CA5EC File Offset: 0x000C87EC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 438027, RefRangeEnd = 438028, XrefRangeStart = 438004, XrefRangeEnd = 438027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ParseDate(int start)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseDate_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002DB1 RID: 11697 RVA: 0x000CA63C File Offset: 0x000C883C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438028, XrefRangeEnd = 438030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ParseTimeAndZoneAndWhitespace(int start)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseTimeAndZoneAndWhitespace_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002DB2 RID: 11698 RVA: 0x000CA68C File Offset: 0x000C888C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438030, XrefRangeEnd = 438031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ParseTimeAndWhitespace(int start)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseTimeAndWhitespace_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002DB3 RID: 11699 RVA: 0x000CA6DC File Offset: 0x000C88DC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 438061, RefRangeEnd = 438064, XrefRangeStart = 438031, XrefRangeEnd = 438061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ParseTime(ref int start)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &start;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseTime_Private_Boolean_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002DB4 RID: 11700 RVA: 0x000CA72C File Offset: 0x000C892C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 438084, RefRangeEnd = 438086, XrefRangeStart = 438064, XrefRangeEnd = 438084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ParseZoneAndWhitespace(int start)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseZoneAndWhitespace_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002DB5 RID: 11701 RVA: 0x000CA77C File Offset: 0x000C897C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 438087, RefRangeEnd = 438088, XrefRangeStart = 438086, XrefRangeEnd = 438087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Parse4Dig(int start, ref int num)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_Parse4Dig_Private_Boolean_Int32_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002DB6 RID: 11702 RVA: 0x000CA7D8 File Offset: 0x000C89D8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 438088, RefRangeEnd = 438095, XrefRangeStart = 438088, XrefRangeEnd = 438088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Parse2Dig(int start, ref int num)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_Parse2Dig_Private_Boolean_Int32_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002DB7 RID: 11703 RVA: 0x000CA834 File Offset: 0x000C8A34
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 438095, RefRangeEnd = 438101, XrefRangeStart = 438095, XrefRangeEnd = 438095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ParseChar(int start, char ch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseChar_Private_Boolean_Int32_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002DB8 RID: 11704 RVA: 0x000CA890 File Offset: 0x000C8A90
			[CallerCount(0)]
			public unsafe static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref left;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_Test_Private_Static_Boolean_XsdDateTimeFlags_XsdDateTimeFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002DB9 RID: 11705 RVA: 0x00013CE5 File Offset: 0x00011EE5
			public Parser(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002DBA RID: 11706 RVA: 0x00013CEE File Offset: 0x00011EEE
			public Parser()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr))
			{
			}

			// Token: 0x17000F81 RID: 3969
			// (get) Token: 0x06002DBB RID: 11707 RVA: 0x000CA8DC File Offset: 0x000C8ADC
			// (set) Token: 0x06002DBC RID: 11708 RVA: 0x00013D00 File Offset: 0x00011F00
			public unsafe XsdDateTime.DateTimeTypeCode typeCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_typeCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_typeCode)) = value;
				}
			}

			// Token: 0x17000F82 RID: 3970
			// (get) Token: 0x06002DBD RID: 11709 RVA: 0x000CA904 File Offset: 0x000C8B04
			// (set) Token: 0x06002DBE RID: 11710 RVA: 0x00013D1B File Offset: 0x00011F1B
			public unsafe int year
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_year);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_year)) = value;
				}
			}

			// Token: 0x17000F83 RID: 3971
			// (get) Token: 0x06002DBF RID: 11711 RVA: 0x000CA92C File Offset: 0x000C8B2C
			// (set) Token: 0x06002DC0 RID: 11712 RVA: 0x00013D36 File Offset: 0x00011F36
			public unsafe int month
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_month);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_month)) = value;
				}
			}

			// Token: 0x17000F84 RID: 3972
			// (get) Token: 0x06002DC1 RID: 11713 RVA: 0x000CA954 File Offset: 0x000C8B54
			// (set) Token: 0x06002DC2 RID: 11714 RVA: 0x00013D51 File Offset: 0x00011F51
			public unsafe int day
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_day);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_day)) = value;
				}
			}

			// Token: 0x17000F85 RID: 3973
			// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x000CA97C File Offset: 0x000C8B7C
			// (set) Token: 0x06002DC4 RID: 11716 RVA: 0x00013D6C File Offset: 0x00011F6C
			public unsafe int hour
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_hour);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_hour)) = value;
				}
			}

			// Token: 0x17000F86 RID: 3974
			// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x000CA9A4 File Offset: 0x000C8BA4
			// (set) Token: 0x06002DC6 RID: 11718 RVA: 0x00013D87 File Offset: 0x00011F87
			public unsafe int minute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_minute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_minute)) = value;
				}
			}

			// Token: 0x17000F87 RID: 3975
			// (get) Token: 0x06002DC7 RID: 11719 RVA: 0x000CA9CC File Offset: 0x000C8BCC
			// (set) Token: 0x06002DC8 RID: 11720 RVA: 0x00013DA2 File Offset: 0x00011FA2
			public unsafe int second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_second);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_second)) = value;
				}
			}

			// Token: 0x17000F88 RID: 3976
			// (get) Token: 0x06002DC9 RID: 11721 RVA: 0x000CA9F4 File Offset: 0x000C8BF4
			// (set) Token: 0x06002DCA RID: 11722 RVA: 0x00013DBD File Offset: 0x00011FBD
			public unsafe int fraction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_fraction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_fraction)) = value;
				}
			}

			// Token: 0x17000F89 RID: 3977
			// (get) Token: 0x06002DCB RID: 11723 RVA: 0x000CAA1C File Offset: 0x000C8C1C
			// (set) Token: 0x06002DCC RID: 11724 RVA: 0x00013DD8 File Offset: 0x00011FD8
			public unsafe XsdDateTime.XsdDateTimeKind kind
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_kind);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_kind)) = value;
				}
			}

			// Token: 0x17000F8A RID: 3978
			// (get) Token: 0x06002DCD RID: 11725 RVA: 0x000CAA44 File Offset: 0x000C8C44
			// (set) Token: 0x06002DCE RID: 11726 RVA: 0x00013DF3 File Offset: 0x00011FF3
			public unsafe int zoneHour
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_zoneHour);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_zoneHour)) = value;
				}
			}

			// Token: 0x17000F8B RID: 3979
			// (get) Token: 0x06002DCF RID: 11727 RVA: 0x000CAA6C File Offset: 0x000C8C6C
			// (set) Token: 0x06002DD0 RID: 11728 RVA: 0x00013E0E File Offset: 0x0001200E
			public unsafe int zoneMinute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_zoneMinute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_zoneMinute)) = value;
				}
			}

			// Token: 0x17000F8C RID: 3980
			// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x000CAA94 File Offset: 0x000C8C94
			// (set) Token: 0x06002DD2 RID: 11730 RVA: 0x00013E29 File Offset: 0x00012029
			public unsafe string text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000F8D RID: 3981
			// (get) Token: 0x06002DD3 RID: 11731 RVA: 0x000CAABC File Offset: 0x000C8CBC
			// (set) Token: 0x06002DD4 RID: 11732 RVA: 0x00013E48 File Offset: 0x00012048
			public unsafe int length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_length)) = value;
				}
			}

			// Token: 0x17000F8E RID: 3982
			// (get) Token: 0x06002DD5 RID: 11733 RVA: 0x000CAAE4 File Offset: 0x000C8CE4
			// (set) Token: 0x06002DD6 RID: 11734 RVA: 0x00013E63 File Offset: 0x00012063
			public unsafe static Il2CppStructArray<int> Power10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XsdDateTime.Parser.NativeFieldInfoPtr_Power10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XsdDateTime.Parser.NativeFieldInfoPtr_Power10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002422 RID: 9250
			private static readonly IntPtr NativeFieldInfoPtr_typeCode;

			// Token: 0x04002423 RID: 9251
			private static readonly IntPtr NativeFieldInfoPtr_year;

			// Token: 0x04002424 RID: 9252
			private static readonly IntPtr NativeFieldInfoPtr_month;

			// Token: 0x04002425 RID: 9253
			private static readonly IntPtr NativeFieldInfoPtr_day;

			// Token: 0x04002426 RID: 9254
			private static readonly IntPtr NativeFieldInfoPtr_hour;

			// Token: 0x04002427 RID: 9255
			private static readonly IntPtr NativeFieldInfoPtr_minute;

			// Token: 0x04002428 RID: 9256
			private static readonly IntPtr NativeFieldInfoPtr_second;

			// Token: 0x04002429 RID: 9257
			private static readonly IntPtr NativeFieldInfoPtr_fraction;

			// Token: 0x0400242A RID: 9258
			private static readonly IntPtr NativeFieldInfoPtr_kind;

			// Token: 0x0400242B RID: 9259
			private static readonly IntPtr NativeFieldInfoPtr_zoneHour;

			// Token: 0x0400242C RID: 9260
			private static readonly IntPtr NativeFieldInfoPtr_zoneMinute;

			// Token: 0x0400242D RID: 9261
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x0400242E RID: 9262
			private static readonly IntPtr NativeFieldInfoPtr_length;

			// Token: 0x0400242F RID: 9263
			private static readonly IntPtr NativeFieldInfoPtr_Power10;

			// Token: 0x04002430 RID: 9264
			private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Boolean_String_XsdDateTimeFlags_0;

			// Token: 0x04002431 RID: 9265
			private static readonly IntPtr NativeMethodInfoPtr_ParseDate_Private_Boolean_Int32_0;

			// Token: 0x04002432 RID: 9266
			private static readonly IntPtr NativeMethodInfoPtr_ParseTimeAndZoneAndWhitespace_Private_Boolean_Int32_0;

			// Token: 0x04002433 RID: 9267
			private static readonly IntPtr NativeMethodInfoPtr_ParseTimeAndWhitespace_Private_Boolean_Int32_0;

			// Token: 0x04002434 RID: 9268
			private static readonly IntPtr NativeMethodInfoPtr_ParseTime_Private_Boolean_byref_Int32_0;

			// Token: 0x04002435 RID: 9269
			private static readonly IntPtr NativeMethodInfoPtr_ParseZoneAndWhitespace_Private_Boolean_Int32_0;

			// Token: 0x04002436 RID: 9270
			private static readonly IntPtr NativeMethodInfoPtr_Parse4Dig_Private_Boolean_Int32_byref_Int32_0;

			// Token: 0x04002437 RID: 9271
			private static readonly IntPtr NativeMethodInfoPtr_Parse2Dig_Private_Boolean_Int32_byref_Int32_0;

			// Token: 0x04002438 RID: 9272
			private static readonly IntPtr NativeMethodInfoPtr_ParseChar_Private_Boolean_Int32_Char_0;

			// Token: 0x04002439 RID: 9273
			private static readonly IntPtr NativeMethodInfoPtr_Test_Private_Static_Boolean_XsdDateTimeFlags_XsdDateTimeFlags_0;
		}
	}
}
