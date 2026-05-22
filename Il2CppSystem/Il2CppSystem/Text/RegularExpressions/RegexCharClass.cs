using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000052 RID: 82
	public sealed class RegexCharClass : Object
	{
		// Token: 0x060004E2 RID: 1250 RVA: 0x00023A3C File Offset: 0x00021C3C
		// Note: this type is marked as 'beforefieldinit'.
		static RegexCharClass()
		{
			Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexCharClass");
			RegexCharClass.NativeFieldInfoPtr__rangelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_rangelist");
			RegexCharClass.NativeFieldInfoPtr__categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_categories");
			RegexCharClass.NativeFieldInfoPtr__canonical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_canonical");
			RegexCharClass.NativeFieldInfoPtr__negate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_negate");
			RegexCharClass.NativeFieldInfoPtr__subtractor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_subtractor");
			RegexCharClass.NativeFieldInfoPtr_InternalRegexIgnoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "InternalRegexIgnoreCase");
			RegexCharClass.NativeFieldInfoPtr_Space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "Space");
			RegexCharClass.NativeFieldInfoPtr_NotSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "NotSpace");
			RegexCharClass.NativeFieldInfoPtr_Word = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "Word");
			RegexCharClass.NativeFieldInfoPtr_NotWord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "NotWord");
			RegexCharClass.NativeFieldInfoPtr_SpaceClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "SpaceClass");
			RegexCharClass.NativeFieldInfoPtr_NotSpaceClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "NotSpaceClass");
			RegexCharClass.NativeFieldInfoPtr_WordClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "WordClass");
			RegexCharClass.NativeFieldInfoPtr_NotWordClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "NotWordClass");
			RegexCharClass.NativeFieldInfoPtr_DigitClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "DigitClass");
			RegexCharClass.NativeFieldInfoPtr_NotDigitClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "NotDigitClass");
			RegexCharClass.NativeFieldInfoPtr__definedCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_definedCategories");
			RegexCharClass.NativeFieldInfoPtr__propTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_propTable");
			RegexCharClass.NativeFieldInfoPtr__lcTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_lcTable");
			RegexCharClass.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664083);
			RegexCharClass.NativeMethodInfoPtr__ctor_Private_Void_Boolean_List_1_SingleRange_StringBuilder_RegexCharClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664084);
			RegexCharClass.NativeMethodInfoPtr_get_CanMerge_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664085);
			RegexCharClass.NativeMethodInfoPtr_set_Negate_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664086);
			RegexCharClass.NativeMethodInfoPtr_AddChar_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664087);
			RegexCharClass.NativeMethodInfoPtr_AddCharClass_Internal_Void_RegexCharClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664088);
			RegexCharClass.NativeMethodInfoPtr_AddSet_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664089);
			RegexCharClass.NativeMethodInfoPtr_AddSubtraction_Internal_Void_RegexCharClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664090);
			RegexCharClass.NativeMethodInfoPtr_AddRange_Internal_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664091);
			RegexCharClass.NativeMethodInfoPtr_AddCategoryFromName_Internal_Void_String_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664092);
			RegexCharClass.NativeMethodInfoPtr_AddCategory_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664093);
			RegexCharClass.NativeMethodInfoPtr_AddLowercase_Internal_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664094);
			RegexCharClass.NativeMethodInfoPtr_AddLowercaseRange_Private_Void_Char_Char_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664095);
			RegexCharClass.NativeMethodInfoPtr_AddWord_Internal_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664096);
			RegexCharClass.NativeMethodInfoPtr_AddSpace_Internal_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664097);
			RegexCharClass.NativeMethodInfoPtr_AddDigit_Internal_Void_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664098);
			RegexCharClass.NativeMethodInfoPtr_SingletonChar_Internal_Static_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664099);
			RegexCharClass.NativeMethodInfoPtr_IsMergeable_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664100);
			RegexCharClass.NativeMethodInfoPtr_IsEmpty_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664101);
			RegexCharClass.NativeMethodInfoPtr_IsSingleton_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664102);
			RegexCharClass.NativeMethodInfoPtr_IsSingletonInverse_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664103);
			RegexCharClass.NativeMethodInfoPtr_IsSubtraction_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664104);
			RegexCharClass.NativeMethodInfoPtr_IsNegated_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664105);
			RegexCharClass.NativeMethodInfoPtr_IsECMAWordChar_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664106);
			RegexCharClass.NativeMethodInfoPtr_IsWordChar_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664107);
			RegexCharClass.NativeMethodInfoPtr_CharInClass_Internal_Static_Boolean_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664108);
			RegexCharClass.NativeMethodInfoPtr_CharInClassRecursive_Internal_Static_Boolean_Char_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664109);
			RegexCharClass.NativeMethodInfoPtr_CharInClassInternal_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664110);
			RegexCharClass.NativeMethodInfoPtr_CharInCategory_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664111);
			RegexCharClass.NativeMethodInfoPtr_CharInCategoryGroup_Private_Static_Boolean_Char_UnicodeCategory_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664112);
			RegexCharClass.NativeMethodInfoPtr_NegateCategory_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664113);
			RegexCharClass.NativeMethodInfoPtr_Parse_Internal_Static_RegexCharClass_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664114);
			RegexCharClass.NativeMethodInfoPtr_ParseRecursive_Private_Static_RegexCharClass_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664115);
			RegexCharClass.NativeMethodInfoPtr_RangeCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664116);
			RegexCharClass.NativeMethodInfoPtr_ToStringClass_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664117);
			RegexCharClass.NativeMethodInfoPtr_GetRangeAt_Private_SingleRange_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664118);
			RegexCharClass.NativeMethodInfoPtr_Canonicalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664119);
			RegexCharClass.NativeMethodInfoPtr_SetFromProperty_Private_Static_String_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664120);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00023ED8 File Offset: 0x000220D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 370034, RefRangeEnd = 370038, XrefRangeStart = 370019, XrefRangeEnd = 370034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCharClass()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00023F14 File Offset: 0x00022114
		[CallerCount(0)]
		public unsafe RegexCharClass(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref negate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ranges);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(categories);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subtraction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr__ctor_Private_Void_Boolean_List_1_SingleRange_StringBuilder_RegexCharClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00023F94 File Offset: 0x00022194
		public unsafe bool CanMerge
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_get_CanMerge_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000193 RID: 403
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00023FD0 File Offset: 0x000221D0
		public unsafe bool Negate
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_set_Negate_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00024010 File Offset: 0x00022210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370038, XrefRangeEnd = 370039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChar(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddChar_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00024050 File Offset: 0x00022250
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370053, RefRangeEnd = 370055, XrefRangeStart = 370039, XrefRangeEnd = 370053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCharClass(RegexCharClass cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddCharClass_Internal_Void_RegexCharClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00024094 File Offset: 0x00022294
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370070, RefRangeEnd = 370073, XrefRangeStart = 370055, XrefRangeEnd = 370070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSet(string set)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddSet_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000240D8 File Offset: 0x000222D8
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSubtraction(RegexCharClass sub)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sub);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddSubtraction_Internal_Void_RegexCharClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0002411C File Offset: 0x0002231C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 370081, RefRangeEnd = 370088, XrefRangeStart = 370073, XrefRangeEnd = 370081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRange(char first, char last)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref first;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref last;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddRange_Internal_Void_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00024168 File Offset: 0x00022368
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370117, RefRangeEnd = 370119, XrefRangeStart = 370088, XrefRangeEnd = 370117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseInsensitive;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddCategoryFromName_Internal_Void_String_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000241DC File Offset: 0x000223DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370119, XrefRangeEnd = 370121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCategory(string category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddCategory_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00024220 File Offset: 0x00022420
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370128, RefRangeEnd = 370131, XrefRangeStart = 370121, XrefRangeEnd = 370128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLowercase(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddLowercase_Internal_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00024264 File Offset: 0x00022464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370149, RefRangeEnd = 370150, XrefRangeStart = 370131, XrefRangeEnd = 370149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLowercaseRange(char chMin, char chMax, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref chMin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chMax;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddLowercaseRange_Private_Void_Char_Char_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000242C4 File Offset: 0x000224C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370166, RefRangeEnd = 370167, XrefRangeStart = 370150, XrefRangeEnd = 370166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddWord(bool ecma, bool negate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ecma;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref negate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddWord_Internal_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00024310 File Offset: 0x00022510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370183, RefRangeEnd = 370184, XrefRangeStart = 370167, XrefRangeEnd = 370183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSpace(bool ecma, bool negate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ecma;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref negate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddSpace_Internal_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0002435C File Offset: 0x0002255C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370193, RefRangeEnd = 370194, XrefRangeStart = 370184, XrefRangeEnd = 370193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDigit(bool ecma, bool negate, string pattern)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ecma;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref negate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddDigit_Internal_Void_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x000243BC File Offset: 0x000225BC
		[CallerCount(0)]
		public unsafe static char SingletonChar(string set)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_SingletonChar_Internal_Static_Char_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00024400 File Offset: 0x00022600
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370198, RefRangeEnd = 370200, XrefRangeStart = 370194, XrefRangeEnd = 370198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMergeable(string charClass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsMergeable_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00024444 File Offset: 0x00022644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370200, XrefRangeEnd = 370204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEmpty(string charClass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsEmpty_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00024488 File Offset: 0x00022688
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370208, RefRangeEnd = 370209, XrefRangeStart = 370204, XrefRangeEnd = 370208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSingleton(string set)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsSingleton_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000244CC File Offset: 0x000226CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370209, XrefRangeEnd = 370213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSingletonInverse(string set)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsSingletonInverse_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00024510 File Offset: 0x00022710
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 370213, RefRangeEnd = 370217, XrefRangeStart = 370213, XrefRangeEnd = 370213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSubtraction(string charClass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsSubtraction_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00024554 File Offset: 0x00022754
		[CallerCount(0)]
		public unsafe static bool IsNegated(string set)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsNegated_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00024598 File Offset: 0x00022798
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370227, RefRangeEnd = 370229, XrefRangeStart = 370217, XrefRangeEnd = 370227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsECMAWordChar(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsECMAWordChar_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000245D8 File Offset: 0x000227D8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 370237, RefRangeEnd = 370243, XrefRangeStart = 370229, XrefRangeEnd = 370237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWordChar(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsWordChar_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00024618 File Offset: 0x00022818
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 370247, RefRangeEnd = 370252, XrefRangeStart = 370243, XrefRangeEnd = 370247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CharInClass(char ch, string set)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(set);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_CharInClass_Internal_Static_Boolean_Char_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00024668 File Offset: 0x00022868
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 370265, RefRangeEnd = 370269, XrefRangeStart = 370252, XrefRangeEnd = 370265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CharInClassRecursive(char ch, string set, int start)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(set);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_CharInClassRecursive_Internal_Static_Boolean_Char_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000246C8 File Offset: 0x000228C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370269, XrefRangeEnd = 370273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(set);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mySetLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref myCategoryLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_CharInClassInternal_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00024744 File Offset: 0x00022944
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370291, RefRangeEnd = 370293, XrefRangeStart = 370273, XrefRangeEnd = 370291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(set);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mySetLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref myCategoryLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_CharInCategory_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x000247C0 File Offset: 0x000229C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370294, RefRangeEnd = 370295, XrefRangeStart = 370293, XrefRangeEnd = 370294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chcategory;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(category);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_CharInCategoryGroup_Private_Static_Boolean_Char_UnicodeCategory_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0002482C File Offset: 0x00022A2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370304, RefRangeEnd = 370305, XrefRangeStart = 370295, XrefRangeEnd = 370304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NegateCategory(string category)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_NegateCategory_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00024868 File Offset: 0x00022A68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370309, RefRangeEnd = 370311, XrefRangeStart = 370305, XrefRangeEnd = 370309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexCharClass Parse(string charClass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_Parse_Internal_Static_RegexCharClass_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr3) : null;
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x000248AC File Offset: 0x00022AAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370337, RefRangeEnd = 370340, XrefRangeStart = 370311, XrefRangeEnd = 370337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexCharClass ParseRecursive(string charClass, int start)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_ParseRecursive_Private_Static_RegexCharClass_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr3) : null;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00024900 File Offset: 0x00022B00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370341, RefRangeEnd = 370342, XrefRangeStart = 370340, XrefRangeEnd = 370341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RangeCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_RangeCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0002493C File Offset: 0x00022B3C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 370364, RefRangeEnd = 370369, XrefRangeStart = 370342, XrefRangeEnd = 370364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToStringClass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_ToStringClass_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00024974 File Offset: 0x00022B74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370370, RefRangeEnd = 370373, XrefRangeStart = 370369, XrefRangeEnd = 370370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCharClass.SingleRange GetRangeAt(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_GetRangeAt_Private_SingleRange_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCharClass.SingleRange>(intPtr3) : null;
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000249C0 File Offset: 0x00022BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370387, RefRangeEnd = 370388, XrefRangeStart = 370373, XrefRangeEnd = 370387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Canonicalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_Canonicalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x000249F4 File Offset: 0x00022BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370388, XrefRangeEnd = 370407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SetFromProperty(string capname, bool invert, string pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(capname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_SetFromProperty_Private_Static_String_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00003CE1 File Offset: 0x00001EE1
		public RegexCharClass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00024A50 File Offset: 0x00022C50
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00003CEA File Offset: 0x00001EEA
		public unsafe List<RegexCharClass.SingleRange> _rangelist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__rangelist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RegexCharClass.SingleRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__rangelist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00024A80 File Offset: 0x00022C80
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00003D09 File Offset: 0x00001F09
		public unsafe StringBuilder _categories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__categories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00024AB0 File Offset: 0x00022CB0
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00003D28 File Offset: 0x00001F28
		public unsafe bool _canonical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__canonical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__canonical)) = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00024AD8 File Offset: 0x00022CD8
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00003D43 File Offset: 0x00001F43
		public unsafe bool _negate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__negate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__negate)) = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00024B00 File Offset: 0x00022D00
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00003D5E File Offset: 0x00001F5E
		public unsafe RegexCharClass _subtractor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__subtractor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__subtractor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00024B30 File Offset: 0x00022D30
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00003D7D File Offset: 0x00001F7D
		public unsafe static string InternalRegexIgnoreCase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_InternalRegexIgnoreCase, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_InternalRegexIgnoreCase, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00024B50 File Offset: 0x00022D50
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00003D8F File Offset: 0x00001F8F
		public unsafe static string Space
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_Space, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_Space, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00024B70 File Offset: 0x00022D70
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00003DA1 File Offset: 0x00001FA1
		public unsafe static string NotSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_NotSpace, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_NotSpace, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00024B90 File Offset: 0x00022D90
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00003DB3 File Offset: 0x00001FB3
		public unsafe static string Word
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_Word, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_Word, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00024BB0 File Offset: 0x00022DB0
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00003DC5 File Offset: 0x00001FC5
		public unsafe static string NotWord
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_NotWord, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_NotWord, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00024BD0 File Offset: 0x00022DD0
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00003DD7 File Offset: 0x00001FD7
		public unsafe static string SpaceClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_SpaceClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_SpaceClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00024BF0 File Offset: 0x00022DF0
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00003DE9 File Offset: 0x00001FE9
		public unsafe static string NotSpaceClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_NotSpaceClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_NotSpaceClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00024C10 File Offset: 0x00022E10
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00003DFB File Offset: 0x00001FFB
		public unsafe static string WordClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_WordClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_WordClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00024C30 File Offset: 0x00022E30
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00003E0D File Offset: 0x0000200D
		public unsafe static string NotWordClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_NotWordClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_NotWordClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00024C50 File Offset: 0x00022E50
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00003E1F File Offset: 0x0000201F
		public unsafe static string DigitClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_DigitClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_DigitClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00024C70 File Offset: 0x00022E70
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00003E31 File Offset: 0x00002031
		public unsafe static string NotDigitClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_NotDigitClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_NotDigitClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00024C90 File Offset: 0x00022E90
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00003E43 File Offset: 0x00002043
		public unsafe static Dictionary<string, string> _definedCategories
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr__definedCategories, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr__definedCategories, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00024CB8 File Offset: 0x00022EB8
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00003E55 File Offset: 0x00002055
		public unsafe static Il2CppObjectBase _propTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr__propTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr__propTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00024CE0 File Offset: 0x00022EE0
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00003E67 File Offset: 0x00002067
		public unsafe static Il2CppStructArray<RegexCharClass.LowerCaseMapping> _lcTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr__lcTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RegexCharClass.LowerCaseMapping>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr__lcTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeFieldInfoPtr__rangelist;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeFieldInfoPtr__categories;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeFieldInfoPtr__canonical;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeFieldInfoPtr__negate;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeFieldInfoPtr__subtractor;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeFieldInfoPtr_InternalRegexIgnoreCase;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeFieldInfoPtr_Space;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeFieldInfoPtr_NotSpace;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeFieldInfoPtr_Word;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeFieldInfoPtr_NotWord;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr_SpaceClass;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_NotSpaceClass;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_WordClass;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeFieldInfoPtr_NotWordClass;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeFieldInfoPtr_DigitClass;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr_NotDigitClass;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr__definedCategories;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr__propTable;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr__lcTable;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_List_1_SingleRange_StringBuilder_RegexCharClass_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_get_CanMerge_Internal_get_Boolean_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_set_Negate_Internal_set_Void_Boolean_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_AddChar_Internal_Void_Char_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_AddCharClass_Internal_Void_RegexCharClass_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_AddSet_Private_Void_String_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_AddSubtraction_Internal_Void_RegexCharClass_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Internal_Void_Char_Char_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_AddCategoryFromName_Internal_Void_String_Boolean_Boolean_String_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_AddCategory_Private_Void_String_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_AddLowercase_Internal_Void_CultureInfo_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_AddLowercaseRange_Private_Void_Char_Char_CultureInfo_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_AddWord_Internal_Void_Boolean_Boolean_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_AddSpace_Internal_Void_Boolean_Boolean_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_AddDigit_Internal_Void_Boolean_Boolean_String_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_SingletonChar_Internal_Static_Char_String_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_IsMergeable_Internal_Static_Boolean_String_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Internal_Static_Boolean_String_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_IsSingleton_Internal_Static_Boolean_String_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_IsSingletonInverse_Internal_Static_Boolean_String_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_IsSubtraction_Private_Static_Boolean_String_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_IsNegated_Internal_Static_Boolean_String_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_IsECMAWordChar_Internal_Static_Boolean_Char_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_IsWordChar_Internal_Static_Boolean_Char_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_CharInClass_Internal_Static_Boolean_Char_String_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_CharInClassRecursive_Internal_Static_Boolean_Char_String_Int32_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_CharInClassInternal_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_CharInCategory_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_CharInCategoryGroup_Private_Static_Boolean_Char_UnicodeCategory_String_byref_Int32_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_NegateCategory_Private_Static_String_String_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_RegexCharClass_String_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_ParseRecursive_Private_Static_RegexCharClass_String_Int32_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_RangeCount_Private_Int32_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_ToStringClass_Internal_String_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_GetRangeAt_Private_SingleRange_Int32_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_Canonicalize_Private_Void_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_SetFromProperty_Private_Static_String_String_Boolean_String_0;

		// Token: 0x020001B7 RID: 439
		[StructLayout(2)]
		public struct LowerCaseMapping
		{
			// Token: 0x060018FB RID: 6395 RVA: 0x0006BD3C File Offset: 0x00069F3C
			// Note: this type is marked as 'beforefieldinit'.
			static LowerCaseMapping()
			{
				Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "LowerCaseMapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr);
				RegexCharClass.LowerCaseMapping.NativeFieldInfoPtr__chMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, "_chMin");
				RegexCharClass.LowerCaseMapping.NativeFieldInfoPtr__chMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, "_chMax");
				RegexCharClass.LowerCaseMapping.NativeFieldInfoPtr__lcOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, "_lcOp");
				RegexCharClass.LowerCaseMapping.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, "_data");
				RegexCharClass.LowerCaseMapping.NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, 100664121);
			}

			// Token: 0x060018FC RID: 6396 RVA: 0x0006BDCC File Offset: 0x00069FCC
			[CallerCount(0)]
			public unsafe LowerCaseMapping(char chMin, char chMax, int lcOp, int data)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref chMin;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chMax;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lcOp;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.LowerCaseMapping.NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018FD RID: 6397 RVA: 0x0000CE59 File Offset: 0x0000B059
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, ref this));
			}

			// Token: 0x040013D7 RID: 5079
			private static readonly IntPtr NativeFieldInfoPtr__chMin;

			// Token: 0x040013D8 RID: 5080
			private static readonly IntPtr NativeFieldInfoPtr__chMax;

			// Token: 0x040013D9 RID: 5081
			private static readonly IntPtr NativeFieldInfoPtr__lcOp;

			// Token: 0x040013DA RID: 5082
			private static readonly IntPtr NativeFieldInfoPtr__data;

			// Token: 0x040013DB RID: 5083
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_Int32_Int32_0;

			// Token: 0x040013DC RID: 5084
			[FieldOffset(0)]
			public char _chMin;

			// Token: 0x040013DD RID: 5085
			[FieldOffset(2)]
			public char _chMax;

			// Token: 0x040013DE RID: 5086
			[FieldOffset(4)]
			public int _lcOp;

			// Token: 0x040013DF RID: 5087
			[FieldOffset(8)]
			public int _data;
		}

		// Token: 0x020001B8 RID: 440
		public sealed class SingleRangeComparer : Object
		{
			// Token: 0x060018FE RID: 6398 RVA: 0x0006BE28 File Offset: 0x0006A028
			// Note: this type is marked as 'beforefieldinit'.
			static SingleRangeComparer()
			{
				Il2CppClassPointerStore<RegexCharClass.SingleRangeComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "SingleRangeComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexCharClass.SingleRangeComparer>.NativeClassPtr);
				RegexCharClass.SingleRangeComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_SingleRange_SingleRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass.SingleRangeComparer>.NativeClassPtr, 100664122);
				RegexCharClass.SingleRangeComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass.SingleRangeComparer>.NativeClassPtr, 100664123);
			}

			// Token: 0x060018FF RID: 6399 RVA: 0x0006BE7C File Offset: 0x0006A07C
			[CallerCount(0)]
			public unsafe int Compare(RegexCharClass.SingleRange x, RegexCharClass.SingleRange y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.SingleRangeComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_SingleRange_SingleRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001900 RID: 6400 RVA: 0x0006BEDC File Offset: 0x0006A0DC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SingleRangeComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCharClass.SingleRangeComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.SingleRangeComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001901 RID: 6401 RVA: 0x0000CE6B File Offset: 0x0000B06B
			public SingleRangeComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040013E0 RID: 5088
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_SingleRange_SingleRange_0;

			// Token: 0x040013E1 RID: 5089
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001B9 RID: 441
		public sealed class SingleRange : Object
		{
			// Token: 0x06001902 RID: 6402 RVA: 0x0006BF18 File Offset: 0x0006A118
			// Note: this type is marked as 'beforefieldinit'.
			static SingleRange()
			{
				Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "SingleRange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr);
				RegexCharClass.SingleRange.NativeFieldInfoPtr__first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr, "_first");
				RegexCharClass.SingleRange.NativeFieldInfoPtr__last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr, "_last");
				RegexCharClass.SingleRange.NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr, 100664124);
			}

			// Token: 0x06001903 RID: 6403 RVA: 0x0006BF80 File Offset: 0x0006A180
			[CallerCount(0)]
			public unsafe SingleRange(char first, char last)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref first;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref last;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.SingleRange.NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001904 RID: 6404 RVA: 0x0000CE74 File Offset: 0x0000B074
			public SingleRange(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000803 RID: 2051
			// (get) Token: 0x06001905 RID: 6405 RVA: 0x0006BFD8 File Offset: 0x0006A1D8
			// (set) Token: 0x06001906 RID: 6406 RVA: 0x0000CE7D File Offset: 0x0000B07D
			public unsafe char _first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.SingleRange.NativeFieldInfoPtr__first);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.SingleRange.NativeFieldInfoPtr__first)) = value;
				}
			}

			// Token: 0x17000804 RID: 2052
			// (get) Token: 0x06001907 RID: 6407 RVA: 0x0006C000 File Offset: 0x0006A200
			// (set) Token: 0x06001908 RID: 6408 RVA: 0x0000CE98 File Offset: 0x0000B098
			public unsafe char _last
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.SingleRange.NativeFieldInfoPtr__last);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.SingleRange.NativeFieldInfoPtr__last)) = value;
				}
			}

			// Token: 0x040013E2 RID: 5090
			private static readonly IntPtr NativeFieldInfoPtr__first;

			// Token: 0x040013E3 RID: 5091
			private static readonly IntPtr NativeFieldInfoPtr__last;

			// Token: 0x040013E4 RID: 5092
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_0;
		}
	}
}
