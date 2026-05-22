using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000050 RID: 80
	public sealed class RegexBoyerMoore : Object
	{
		// Token: 0x060004B8 RID: 1208 RVA: 0x00023194 File Offset: 0x00021394
		// Note: this type is marked as 'beforefieldinit'.
		static RegexBoyerMoore()
		{
			Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexBoyerMoore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr);
			RegexBoyerMoore.NativeFieldInfoPtr__positive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_positive");
			RegexBoyerMoore.NativeFieldInfoPtr__negativeASCII = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_negativeASCII");
			RegexBoyerMoore.NativeFieldInfoPtr__negativeUnicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_negativeUnicode");
			RegexBoyerMoore.NativeFieldInfoPtr__pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_pattern");
			RegexBoyerMoore.NativeFieldInfoPtr__lowASCII = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_lowASCII");
			RegexBoyerMoore.NativeFieldInfoPtr__highASCII = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_highASCII");
			RegexBoyerMoore.NativeFieldInfoPtr__rightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_rightToLeft");
			RegexBoyerMoore.NativeFieldInfoPtr__caseInsensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_caseInsensitive");
			RegexBoyerMoore.NativeFieldInfoPtr__culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_culture");
			RegexBoyerMoore.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, 100664068);
			RegexBoyerMoore.NativeMethodInfoPtr_MatchPattern_Private_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, 100664069);
			RegexBoyerMoore.NativeMethodInfoPtr_IsMatch_Internal_Boolean_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, 100664070);
			RegexBoyerMoore.NativeMethodInfoPtr_Scan_Internal_Int32_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, 100664071);
			RegexBoyerMoore.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, 100664072);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x000232DC File Offset: 0x000214DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369987, RefRangeEnd = 369988, XrefRangeStart = 369957, XrefRangeEnd = 369987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseInsensitive;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightToLeft;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexBoyerMoore.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00023358 File Offset: 0x00021558
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369990, RefRangeEnd = 369992, XrefRangeStart = 369988, XrefRangeEnd = 369990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchPattern(string text, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexBoyerMoore.NativeMethodInfoPtr_MatchPattern_Private_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000233B4 File Offset: 0x000215B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369992, XrefRangeEnd = 369994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatch(string text, int index, int beglimit, int endlimit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beglimit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endlimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexBoyerMoore.NativeMethodInfoPtr_IsMatch_Internal_Boolean_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0002342C File Offset: 0x0002162C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369994, XrefRangeEnd = 370006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Scan(string text, int index, int beglimit, int endlimit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beglimit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endlimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexBoyerMoore.NativeMethodInfoPtr_Scan_Internal_Int32_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000234A4 File Offset: 0x000216A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexBoyerMoore.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00003B73 File Offset: 0x00001D73
		public RegexBoyerMoore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x000234DC File Offset: 0x000216DC
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00003B7C File Offset: 0x00001D7C
		public unsafe Il2CppStructArray<int> _positive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__positive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__positive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x0002350C File Offset: 0x0002170C
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00003B9B File Offset: 0x00001D9B
		public unsafe Il2CppStructArray<int> _negativeASCII
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__negativeASCII);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__negativeASCII), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x0002353C File Offset: 0x0002173C
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00003BBA File Offset: 0x00001DBA
		public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> _negativeUnicode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__negativeUnicode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__negativeUnicode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0002356C File Offset: 0x0002176C
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00003BD9 File Offset: 0x00001DD9
		public unsafe string _pattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__pattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__pattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00023594 File Offset: 0x00021794
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00003BF8 File Offset: 0x00001DF8
		public unsafe int _lowASCII
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__lowASCII);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__lowASCII)) = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x000235BC File Offset: 0x000217BC
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00003C13 File Offset: 0x00001E13
		public unsafe int _highASCII
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__highASCII);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__highASCII)) = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x000235E4 File Offset: 0x000217E4
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x00003C2E File Offset: 0x00001E2E
		public unsafe bool _rightToLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__rightToLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__rightToLeft)) = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x0002360C File Offset: 0x0002180C
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00003C49 File Offset: 0x00001E49
		public unsafe bool _caseInsensitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__caseInsensitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__caseInsensitive)) = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00023634 File Offset: 0x00021834
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00003C64 File Offset: 0x00001E64
		public unsafe CultureInfo _culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeFieldInfoPtr__positive;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeFieldInfoPtr__negativeASCII;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeFieldInfoPtr__negativeUnicode;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr__pattern;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeFieldInfoPtr__lowASCII;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeFieldInfoPtr__highASCII;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeFieldInfoPtr__rightToLeft;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeFieldInfoPtr__caseInsensitive;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeFieldInfoPtr__culture;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_CultureInfo_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_MatchPattern_Private_Boolean_String_Int32_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Internal_Boolean_String_Int32_Int32_Int32_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_Scan_Internal_Int32_String_Int32_Int32_Int32_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
