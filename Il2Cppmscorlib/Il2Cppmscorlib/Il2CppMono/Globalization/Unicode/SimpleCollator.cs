using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x0200001C RID: 28
	public class SimpleCollator : Object
	{
		// Token: 0x0600012D RID: 301 RVA: 0x00026B3C File Offset: 0x00024D3C
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleCollator()
		{
			Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "SimpleCollator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr);
			SimpleCollator.NativeFieldInfoPtr_QuickCheckDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "QuickCheckDisabled");
			SimpleCollator.NativeFieldInfoPtr_invariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "invariant");
			SimpleCollator.NativeFieldInfoPtr_textInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "textInfo");
			SimpleCollator.NativeFieldInfoPtr_cjkIndexer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkIndexer");
			SimpleCollator.NativeFieldInfoPtr_contractions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "contractions");
			SimpleCollator.NativeFieldInfoPtr_level2Maps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "level2Maps");
			SimpleCollator.NativeFieldInfoPtr_unsafeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "unsafeFlags");
			SimpleCollator.NativeFieldInfoPtr_cjkCatTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkCatTable");
			SimpleCollator.NativeFieldInfoPtr_cjkLv1Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkLv1Table");
			SimpleCollator.NativeFieldInfoPtr_cjkLv2Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkLv2Table");
			SimpleCollator.NativeFieldInfoPtr_cjkLv2Indexer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkLv2Indexer");
			SimpleCollator.NativeFieldInfoPtr_lcid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "lcid");
			SimpleCollator.NativeFieldInfoPtr_frenchSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "frenchSort");
			SimpleCollator.NativeFieldInfoPtr_UnsafeFlagLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "UnsafeFlagLength");
			SimpleCollator.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663447);
			SimpleCollator.NativeMethodInfoPtr_SetCJKTable_Private_Void_CultureInfo_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663448);
			SimpleCollator.NativeMethodInfoPtr_GetNeutralCulture_Private_Static_CultureInfo_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663449);
			SimpleCollator.NativeMethodInfoPtr_Category_Private_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663450);
			SimpleCollator.NativeMethodInfoPtr_Level1_Private_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663451);
			SimpleCollator.NativeMethodInfoPtr_Level2_Private_Byte_Int32_ExtenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663452);
			SimpleCollator.NativeMethodInfoPtr_IsHalfKana_Private_Static_Boolean_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663453);
			SimpleCollator.NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663454);
			SimpleCollator.NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663455);
			SimpleCollator.NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663456);
			SimpleCollator.NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663457);
			SimpleCollator.NativeMethodInfoPtr_FilterOptions_Private_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663458);
			SimpleCollator.NativeMethodInfoPtr_GetExtenderType_Private_ExtenderType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663459);
			SimpleCollator.NativeMethodInfoPtr_ToDashTypeValue_Private_Static_Byte_ExtenderType_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663460);
			SimpleCollator.NativeMethodInfoPtr_FilterExtender_Private_Int32_Int32_ExtenderType_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663461);
			SimpleCollator.NativeMethodInfoPtr_IsIgnorable_Private_Static_Boolean_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663462);
			SimpleCollator.NativeMethodInfoPtr_IsSafe_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663463);
			SimpleCollator.NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663464);
			SimpleCollator.NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663465);
			SimpleCollator.NativeMethodInfoPtr_GetSortKey_Private_Void_String_Int32_Int32_SortKeyBuffer_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663466);
			SimpleCollator.NativeMethodInfoPtr_FillSortKeyRaw_Private_Void_Int32_ExtenderType_SortKeyBuffer_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663467);
			SimpleCollator.NativeMethodInfoPtr_FillSurrogateSortKeyRaw_Private_Void_Int32_SortKeyBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663468);
			SimpleCollator.NativeMethodInfoPtr_Compare_Internal_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663469);
			SimpleCollator.NativeMethodInfoPtr_ClearBuffer_Private_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663470);
			SimpleCollator.NativeMethodInfoPtr_CompareInternal_Private_Int32_String_Int32_Int32_String_Int32_Int32_byref_Boolean_byref_Boolean_Boolean_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663471);
			SimpleCollator.NativeMethodInfoPtr_CompareFlagPair_Private_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663472);
			SimpleCollator.NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663473);
			SimpleCollator.NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663474);
			SimpleCollator.NativeMethodInfoPtr_IsPrefix_Private_Boolean_String_String_Int32_Int32_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663475);
			SimpleCollator.NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663476);
			SimpleCollator.NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663477);
			SimpleCollator.NativeMethodInfoPtr_QuickIndexOf_Private_Int32_String_String_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663478);
			SimpleCollator.NativeMethodInfoPtr_IndexOf_Public_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663479);
			SimpleCollator.NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663480);
			SimpleCollator.NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663481);
			SimpleCollator.NativeMethodInfoPtr_IndexOfSortKey_Private_Int32_String_Int32_Int32_ptr_Byte_Char_Int32_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663482);
			SimpleCollator.NativeMethodInfoPtr_IndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663483);
			SimpleCollator.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663484);
			SimpleCollator.NativeMethodInfoPtr_LastIndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663485);
			SimpleCollator.NativeMethodInfoPtr_LastIndexOfSortKey_Private_Int32_String_Int32_Int32_Int32_ptr_Byte_Int32_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663486);
			SimpleCollator.NativeMethodInfoPtr_LastIndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663487);
			SimpleCollator.NativeMethodInfoPtr_MatchesForward_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663488);
			SimpleCollator.NativeMethodInfoPtr_MatchesForwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663489);
			SimpleCollator.NativeMethodInfoPtr_MatchesPrimitive_Private_Boolean_CompareOptions_ptr_Byte_Int32_ExtenderType_ptr_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663490);
			SimpleCollator.NativeMethodInfoPtr_MatchesBackward_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663491);
			SimpleCollator.NativeMethodInfoPtr_MatchesBackwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663492);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0002701C File Offset: 0x0002521C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131890, RefRangeEnd = 131891, XrefRangeStart = 131860, XrefRangeEnd = 131890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleCollator(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00027068 File Offset: 0x00025268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131891, XrefRangeEnd = 131900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cjkIndexer);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(catTable);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(lv1Table);
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(lv2Indexer);
			ptr5 = &intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5 = IL2CPP.Il2CppObjectBaseToPtr(lv2Table);
			ptr6 = &intPtr5;
			IntPtr intPtr7;
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_SetCJKTable_Private_Void_CultureInfo_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr7);
			Il2CppException.RaiseExceptionIfNecessary(intPtr7);
			IntPtr intPtr8 = intPtr;
			cjkIndexer = ((intPtr8 == 0) ? null : new CodePointIndexer(intPtr8));
			IntPtr intPtr9 = intPtr2;
			catTable = ((intPtr9 == 0) ? null : new byte*(intPtr9));
			IntPtr intPtr10 = intPtr3;
			lv1Table = ((intPtr10 == 0) ? null : new byte*(intPtr10));
			IntPtr intPtr11 = intPtr4;
			lv2Indexer = ((intPtr11 == 0) ? null : new CodePointIndexer(intPtr11));
			IntPtr intPtr12 = intPtr5;
			lv2Table = ((intPtr12 == 0) ? null : new byte*(intPtr12));
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0002717C File Offset: 0x0002537C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131900, XrefRangeEnd = 131901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo GetNeutralCulture(CultureInfo info)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetNeutralCulture_Private_Static_CultureInfo_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000271C0 File Offset: 0x000253C0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 131903, RefRangeEnd = 131914, XrefRangeStart = 131901, XrefRangeEnd = 131903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte Category(int cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_Category_Private_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0002720C File Offset: 0x0002540C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 131916, RefRangeEnd = 131923, XrefRangeStart = 131914, XrefRangeEnd = 131916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte Level1(int cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_Level1_Private_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00027258 File Offset: 0x00025458
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 131929, RefRangeEnd = 131942, XrefRangeStart = 131923, XrefRangeEnd = 131929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte Level2(int cp, SimpleCollator.ExtenderType ext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_Level2_Private_Byte_Int32_ExtenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000272B0 File Offset: 0x000254B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 131943, RefRangeEnd = 131948, XrefRangeStart = 131942, XrefRangeEnd = 131943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHalfKana(int cp, CompareOptions opt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsHalfKana_Private_Static_Boolean_Int32_CompareOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000272FC File Offset: 0x000254FC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 131954, RefRangeEnd = 131961, XrefRangeStart = 131948, XrefRangeEnd = 131954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contraction GetContraction(string s, int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contraction>(intPtr3) : null;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00027368 File Offset: 0x00025568
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131964, RefRangeEnd = 131966, XrefRangeStart = 131961, XrefRangeEnd = 131964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contraction GetContraction(string s, int start, int end, Il2CppReferenceArray<Contraction> clist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contraction>(intPtr3) : null;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000273E8 File Offset: 0x000255E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131966, XrefRangeEnd = 131972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contraction GetTailContraction(string s, int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contraction>(intPtr3) : null;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00027454 File Offset: 0x00025654
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131976, RefRangeEnd = 131978, XrefRangeStart = 131972, XrefRangeEnd = 131976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contraction GetTailContraction(string s, int start, int end, Il2CppReferenceArray<Contraction> clist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contraction>(intPtr3) : null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000274D4 File Offset: 0x000256D4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 132006, RefRangeEnd = 132014, XrefRangeStart = 131978, XrefRangeEnd = 132006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FilterOptions(int i, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_FilterOptions_Private_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0002752C File Offset: 0x0002572C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 132014, RefRangeEnd = 132019, XrefRangeStart = 132014, XrefRangeEnd = 132014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleCollator.ExtenderType GetExtenderType(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetExtenderType_Private_ExtenderType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00027578 File Offset: 0x00025778
		[CallerCount(0)]
		public unsafe static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ext;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_ToDashTypeValue_Private_Static_Byte_ExtenderType_CompareOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000275C4 File Offset: 0x000257C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 132041, RefRangeEnd = 132045, XrefRangeStart = 132019, XrefRangeEnd = 132041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_FilterExtender_Private_Int32_Int32_ExtenderType_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0002762C File Offset: 0x0002582C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 132049, RefRangeEnd = 132055, XrefRangeStart = 132045, XrefRangeEnd = 132049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIgnorable(int i, CompareOptions opt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsIgnorable_Private_Static_Boolean_Int32_CompareOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00027678 File Offset: 0x00025878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132055, RefRangeEnd = 132057, XrefRangeStart = 132055, XrefRangeEnd = 132055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSafe(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsSafe_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000276C4 File Offset: 0x000258C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132057, XrefRangeEnd = 132063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey GetSortKey(string s, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00027724 File Offset: 0x00025924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132063, XrefRangeEnd = 132069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey GetSortKey(string s, int start, int length, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000277A0 File Offset: 0x000259A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 132099, RefRangeEnd = 132102, XrefRangeStart = 132069, XrefRangeEnd = 132099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetSortKey_Private_Void_String_Int32_Int32_SortKeyBuffer_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00027820 File Offset: 0x00025A20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132112, RefRangeEnd = 132113, XrefRangeStart = 132102, XrefRangeEnd = 132112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_FillSortKeyRaw_Private_Void_Int32_ExtenderType_SortKeyBuffer_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0002788C File Offset: 0x00025A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132113, XrefRangeEnd = 132117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_FillSurrogateSortKeyRaw_Private_Void_Int32_SortKeyBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000278DC File Offset: 0x00025ADC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132118, RefRangeEnd = 132120, XrefRangeStart = 132117, XrefRangeEnd = 132118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_Compare_Internal_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00027984 File Offset: 0x00025B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132120, XrefRangeEnd = 132121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearBuffer(byte* buffer, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_ClearBuffer_Private_Void_ptr_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000279D0 File Offset: 0x00025BD0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 132254, RefRangeEnd = 132259, XrefRangeStart = 132121, XrefRangeEnd = 132254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &targetConsumed;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sourceConsumed;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipHeadingExtenders;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref immediateBreakup;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_CompareInternal_Private_Int32_String_Int32_Int32_String_Int32_Int32_byref_Boolean_byref_Boolean_Boolean_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00027AB4 File Offset: 0x00025CB4
		[CallerCount(0)]
		public unsafe int CompareFlagPair(bool b1, bool b2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_CompareFlagPair_Private_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00027B0C File Offset: 0x00025D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132259, XrefRangeEnd = 132260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPrefix(string src, string target, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00027B7C File Offset: 0x00025D7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132261, RefRangeEnd = 132262, XrefRangeStart = 132260, XrefRangeEnd = 132261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPrefix(string s, string target, int start, int length, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00027C08 File Offset: 0x00025E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132262, XrefRangeEnd = 132263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipHeadingExtenders;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsPrefix_Private_Boolean_String_String_Int32_Int32_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00027CA0 File Offset: 0x00025EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132263, XrefRangeEnd = 132264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSuffix(string src, string target, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00027D10 File Offset: 0x00025F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132264, XrefRangeEnd = 132265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSuffix(string s, string target, int start, int length, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00027D9C File Offset: 0x00025F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132265, XrefRangeEnd = 132272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &testWasUnable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_QuickIndexOf_Private_Int32_String_String_Int32_Int32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00027E28 File Offset: 0x00026028
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132278, RefRangeEnd = 132280, XrefRangeStart = 132272, XrefRangeEnd = 132278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string s, string target, int start, int length, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IndexOf_Public_Int32_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00027EB4 File Offset: 0x000260B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132280, XrefRangeEnd = 132283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfOrdinal(string s, string target, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00027F30 File Offset: 0x00026130
		[CallerCount(0)]
		public unsafe int IndexOfOrdinal(string s, char target, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00027FA8 File Offset: 0x000261A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132283, XrefRangeEnd = 132286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IndexOfSortKey_Private_Int32_String_Int32_Int32_ptr_Byte_Char_Int32_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00028058 File Offset: 0x00026258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132316, RefRangeEnd = 132317, XrefRangeStart = 132286, XrefRangeEnd = 132316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = targetSortKey;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000280F0 File Offset: 0x000262F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 132320, RefRangeEnd = 132323, XrefRangeStart = 132317, XrefRangeEnd = 132320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(string s, string target, int start, int length, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0002817C File Offset: 0x0002637C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132326, RefRangeEnd = 132327, XrefRangeStart = 132323, XrefRangeEnd = 132326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfOrdinal(string s, string target, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_LastIndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000281F8 File Offset: 0x000263F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132330, RefRangeEnd = 132331, XrefRangeStart = 132327, XrefRangeEnd = 132330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orgStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_LastIndexOfSortKey_Private_Int32_String_Int32_Int32_Int32_ptr_Byte_Int32_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000282A8 File Offset: 0x000264A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132359, RefRangeEnd = 132361, XrefRangeStart = 132331, XrefRangeEnd = 132359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = targetSortKey;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_LastIndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00028340 File Offset: 0x00026540
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132361, RefRangeEnd = 132363, XrefRangeStart = 132361, XrefRangeEnd = 132361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_MatchesForward_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000283E4 File Offset: 0x000265E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132363, XrefRangeEnd = 132366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(ct);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_MatchesForwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ct = ((intPtr4 == 0) ? null : new Contraction(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000284C0 File Offset: 0x000266C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132366, XrefRangeEnd = 132389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref si;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = target;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_MatchesPrimitive_Private_Boolean_CompareOptions_ptr_Byte_Int32_ExtenderType_ptr_Byte_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0002855C File Offset: 0x0002675C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132389, RefRangeEnd = 132390, XrefRangeStart = 132389, XrefRangeEnd = 132389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orgStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_MatchesBackward_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0002860C File Offset: 0x0002680C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132390, XrefRangeEnd = 132398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orgStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(ct);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_MatchesBackwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ct = ((intPtr4 == 0) ? null : new Contraction(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002774 File Offset: 0x00000974
		public SimpleCollator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000286F8 File Offset: 0x000268F8
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0000277D File Offset: 0x0000097D
		public unsafe static bool QuickCheckDisabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SimpleCollator.NativeFieldInfoPtr_QuickCheckDisabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SimpleCollator.NativeFieldInfoPtr_QuickCheckDisabled, (void*)(&value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00028714 File Offset: 0x00026914
		// (set) Token: 0x06000160 RID: 352 RVA: 0x0000278B File Offset: 0x0000098B
		public unsafe static SimpleCollator invariant
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SimpleCollator.NativeFieldInfoPtr_invariant, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleCollator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SimpleCollator.NativeFieldInfoPtr_invariant, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0002873C File Offset: 0x0002693C
		// (set) Token: 0x06000162 RID: 354 RVA: 0x0000279D File Offset: 0x0000099D
		public unsafe TextInfo textInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_textInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_textInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0002876C File Offset: 0x0002696C
		// (set) Token: 0x06000164 RID: 356 RVA: 0x000027BC File Offset: 0x000009BC
		public unsafe CodePointIndexer cjkIndexer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkIndexer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkIndexer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0002879C File Offset: 0x0002699C
		// (set) Token: 0x06000166 RID: 358 RVA: 0x000027DB File Offset: 0x000009DB
		public unsafe Il2CppReferenceArray<Contraction> contractions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_contractions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Contraction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_contractions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000287CC File Offset: 0x000269CC
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000027FA File Offset: 0x000009FA
		public unsafe Il2CppReferenceArray<Level2Map> level2Maps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_level2Maps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Level2Map>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_level2Maps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000287FC File Offset: 0x000269FC
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00002819 File Offset: 0x00000A19
		public unsafe Il2CppStructArray<byte> unsafeFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_unsafeFlags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_unsafeFlags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0002882C File Offset: 0x00026A2C
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00002838 File Offset: 0x00000A38
		public unsafe byte* cjkCatTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkCatTable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkCatTable)) = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00028850 File Offset: 0x00026A50
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002853 File Offset: 0x00000A53
		public unsafe byte* cjkLv1Table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv1Table);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv1Table)) = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00028874 File Offset: 0x00026A74
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0000286E File Offset: 0x00000A6E
		public unsafe byte* cjkLv2Table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv2Table);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv2Table)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00028898 File Offset: 0x00026A98
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002889 File Offset: 0x00000A89
		public unsafe CodePointIndexer cjkLv2Indexer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv2Indexer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv2Indexer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000288C8 File Offset: 0x00026AC8
		// (set) Token: 0x06000174 RID: 372 RVA: 0x000028A8 File Offset: 0x00000AA8
		public unsafe int lcid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_lcid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_lcid)) = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000288F0 File Offset: 0x00026AF0
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000028C3 File Offset: 0x00000AC3
		public unsafe bool frenchSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_frenchSort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_frenchSort)) = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00028918 File Offset: 0x00026B18
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000028DE File Offset: 0x00000ADE
		public unsafe static int UnsafeFlagLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SimpleCollator.NativeFieldInfoPtr_UnsafeFlagLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SimpleCollator.NativeFieldInfoPtr_UnsafeFlagLength, (void*)(&value));
			}
		}

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_QuickCheckDisabled;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_invariant;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_textInfo;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_cjkIndexer;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_contractions;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_level2Maps;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_unsafeFlags;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr_cjkCatTable;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_cjkLv1Table;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_cjkLv2Table;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_cjkLv2Indexer;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr_lcid;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr_frenchSort;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_UnsafeFlagLength;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_SetCJKTable_Private_Void_CultureInfo_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_GetNeutralCulture_Private_Static_CultureInfo_CultureInfo_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_Category_Private_Byte_Int32_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_Level1_Private_Byte_Int32_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_Level2_Private_Byte_Int32_ExtenderType_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_IsHalfKana_Private_Static_Boolean_Int32_CompareOptions_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_FilterOptions_Private_Int32_Int32_CompareOptions_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_GetExtenderType_Private_ExtenderType_Int32_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_ToDashTypeValue_Private_Static_Byte_ExtenderType_CompareOptions_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_FilterExtender_Private_Int32_Int32_ExtenderType_CompareOptions_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_IsIgnorable_Private_Static_Boolean_Int32_CompareOptions_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_IsSafe_Private_Boolean_Int32_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_CompareOptions_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_Int32_Int32_CompareOptions_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_GetSortKey_Private_Void_String_Int32_Int32_SortKeyBuffer_CompareOptions_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_FillSortKeyRaw_Private_Void_Int32_ExtenderType_SortKeyBuffer_CompareOptions_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_FillSurrogateSortKeyRaw_Private_Void_Int32_SortKeyBuffer_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Internal_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_ClearBuffer_Private_Void_ptr_Byte_Int32_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_CompareInternal_Private_Int32_String_Int32_Int32_String_Int32_Int32_byref_Boolean_byref_Boolean_Boolean_Boolean_byref_Context_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_CompareFlagPair_Private_Int32_Boolean_Boolean_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_CompareOptions_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_IsPrefix_Private_Boolean_String_String_Int32_Int32_Boolean_byref_Context_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_CompareOptions_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_QuickIndexOf_Private_Int32_String_String_Int32_Int32_byref_Boolean_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_Char_Int32_Int32_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfSortKey_Private_Int32_String_Int32_Int32_ptr_Byte_Char_Int32_Boolean_byref_Context_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfSortKey_Private_Int32_String_Int32_Int32_Int32_ptr_Byte_Int32_Boolean_byref_Context_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_MatchesForward_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_MatchesForwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_MatchesPrimitive_Private_Boolean_CompareOptions_ptr_Byte_Int32_ExtenderType_ptr_Byte_Int32_Boolean_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_MatchesBackward_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_MatchesBackwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0;

		// Token: 0x0200053D RID: 1341
		[StructLayout(2)]
		public struct Context
		{
			// Token: 0x06004F21 RID: 20257 RVA: 0x00168350 File Offset: 0x00166550
			// Note: this type is marked as 'beforefieldinit'.
			static Context()
			{
				Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "Context");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr);
				SimpleCollator.Context.NativeFieldInfoPtr_Option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "Option");
				SimpleCollator.Context.NativeFieldInfoPtr_NeverMatchFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "NeverMatchFlags");
				SimpleCollator.Context.NativeFieldInfoPtr_AlwaysMatchFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "AlwaysMatchFlags");
				SimpleCollator.Context.NativeFieldInfoPtr_Buffer1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "Buffer1");
				SimpleCollator.Context.NativeFieldInfoPtr_Buffer2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "Buffer2");
				SimpleCollator.Context.NativeFieldInfoPtr_PrevCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "PrevCode");
				SimpleCollator.Context.NativeFieldInfoPtr_PrevSortKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "PrevSortKey");
				SimpleCollator.Context.NativeMethodInfoPtr__ctor_Public_Void_CompareOptions_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, 100663494);
			}

			// Token: 0x06004F22 RID: 20258 RVA: 0x0016841C File Offset: 0x0016661C
			[CallerCount(0)]
			public unsafe Context(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref opt;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = alwaysMatchFlags;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = neverMatchFlags;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer1;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer2;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = prev1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.Context.NativeMethodInfoPtr__ctor_Public_Void_CompareOptions_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F23 RID: 20259 RVA: 0x0001DA1F File Offset: 0x0001BC1F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, ref this));
			}

			// Token: 0x04003FE4 RID: 16356
			private static readonly IntPtr NativeFieldInfoPtr_Option;

			// Token: 0x04003FE5 RID: 16357
			private static readonly IntPtr NativeFieldInfoPtr_NeverMatchFlags;

			// Token: 0x04003FE6 RID: 16358
			private static readonly IntPtr NativeFieldInfoPtr_AlwaysMatchFlags;

			// Token: 0x04003FE7 RID: 16359
			private static readonly IntPtr NativeFieldInfoPtr_Buffer1;

			// Token: 0x04003FE8 RID: 16360
			private static readonly IntPtr NativeFieldInfoPtr_Buffer2;

			// Token: 0x04003FE9 RID: 16361
			private static readonly IntPtr NativeFieldInfoPtr_PrevCode;

			// Token: 0x04003FEA RID: 16362
			private static readonly IntPtr NativeFieldInfoPtr_PrevSortKey;

			// Token: 0x04003FEB RID: 16363
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CompareOptions_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_0;

			// Token: 0x04003FEC RID: 16364
			[FieldOffset(0)]
			public readonly CompareOptions Option;

			// Token: 0x04003FED RID: 16365
			[FieldOffset(8)]
			public readonly IntPtr NeverMatchFlags;

			// Token: 0x04003FEE RID: 16366
			[FieldOffset(16)]
			public readonly IntPtr AlwaysMatchFlags;

			// Token: 0x04003FEF RID: 16367
			[FieldOffset(24)]
			public IntPtr Buffer1;

			// Token: 0x04003FF0 RID: 16368
			[FieldOffset(32)]
			public IntPtr Buffer2;

			// Token: 0x04003FF1 RID: 16369
			[FieldOffset(40)]
			public int PrevCode;

			// Token: 0x04003FF2 RID: 16370
			[FieldOffset(48)]
			public IntPtr PrevSortKey;
		}

		// Token: 0x0200053E RID: 1342
		[StructLayout(2)]
		public struct PreviousInfo
		{
			// Token: 0x06004F24 RID: 20260 RVA: 0x00168494 File Offset: 0x00166694
			// Note: this type is marked as 'beforefieldinit'.
			static PreviousInfo()
			{
				Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "PreviousInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr);
				SimpleCollator.PreviousInfo.NativeFieldInfoPtr_Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr, "Code");
				SimpleCollator.PreviousInfo.NativeFieldInfoPtr_SortKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr, "SortKey");
				SimpleCollator.PreviousInfo.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr, 100663495);
			}

			// Token: 0x06004F25 RID: 20261 RVA: 0x001684FC File Offset: 0x001666FC
			[CallerCount(0)]
			public unsafe PreviousInfo(bool dummy)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref dummy;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.PreviousInfo.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F26 RID: 20262 RVA: 0x0001DA31 File Offset: 0x0001BC31
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr, ref this));
			}

			// Token: 0x04003FF3 RID: 16371
			private static readonly IntPtr NativeFieldInfoPtr_Code;

			// Token: 0x04003FF4 RID: 16372
			private static readonly IntPtr NativeFieldInfoPtr_SortKey;

			// Token: 0x04003FF5 RID: 16373
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

			// Token: 0x04003FF6 RID: 16374
			[FieldOffset(0)]
			public int Code;

			// Token: 0x04003FF7 RID: 16375
			[FieldOffset(8)]
			public IntPtr SortKey;
		}

		// Token: 0x0200053F RID: 1343
		public sealed class Escape : ValueType
		{
			// Token: 0x06004F27 RID: 20263 RVA: 0x00168530 File Offset: 0x00166730
			// Note: this type is marked as 'beforefieldinit'.
			static Escape()
			{
				Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "Escape");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr);
				SimpleCollator.Escape.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr, "Source");
				SimpleCollator.Escape.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr, "Index");
				SimpleCollator.Escape.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr, "Start");
				SimpleCollator.Escape.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr, "End");
				SimpleCollator.Escape.NativeFieldInfoPtr_Optional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr, "Optional");
			}

			// Token: 0x06004F28 RID: 20264 RVA: 0x0001DA43 File Offset: 0x0001BC43
			public Escape(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004F29 RID: 20265 RVA: 0x0001DA4C File Offset: 0x0001BC4C
			public Escape()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr))
			{
			}

			// Token: 0x1700143D RID: 5181
			// (get) Token: 0x06004F2A RID: 20266 RVA: 0x001685C0 File Offset: 0x001667C0
			// (set) Token: 0x06004F2B RID: 20267 RVA: 0x0001DA5E File Offset: 0x0001BC5E
			public unsafe string Source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Source);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Source), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700143E RID: 5182
			// (get) Token: 0x06004F2C RID: 20268 RVA: 0x001685E8 File Offset: 0x001667E8
			// (set) Token: 0x06004F2D RID: 20269 RVA: 0x0001DA7D File Offset: 0x0001BC7D
			public unsafe int Index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Index)) = value;
				}
			}

			// Token: 0x1700143F RID: 5183
			// (get) Token: 0x06004F2E RID: 20270 RVA: 0x00168610 File Offset: 0x00166810
			// (set) Token: 0x06004F2F RID: 20271 RVA: 0x0001DA98 File Offset: 0x0001BC98
			public unsafe int Start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Start)) = value;
				}
			}

			// Token: 0x17001440 RID: 5184
			// (get) Token: 0x06004F30 RID: 20272 RVA: 0x00168638 File Offset: 0x00166838
			// (set) Token: 0x06004F31 RID: 20273 RVA: 0x0001DAB3 File Offset: 0x0001BCB3
			public unsafe int End
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_End);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_End)) = value;
				}
			}

			// Token: 0x17001441 RID: 5185
			// (get) Token: 0x06004F32 RID: 20274 RVA: 0x00168660 File Offset: 0x00166860
			// (set) Token: 0x06004F33 RID: 20275 RVA: 0x0001DACE File Offset: 0x0001BCCE
			public unsafe int Optional
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Optional);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Optional)) = value;
				}
			}

			// Token: 0x04003FF8 RID: 16376
			private static readonly IntPtr NativeFieldInfoPtr_Source;

			// Token: 0x04003FF9 RID: 16377
			private static readonly IntPtr NativeFieldInfoPtr_Index;

			// Token: 0x04003FFA RID: 16378
			private static readonly IntPtr NativeFieldInfoPtr_Start;

			// Token: 0x04003FFB RID: 16379
			private static readonly IntPtr NativeFieldInfoPtr_End;

			// Token: 0x04003FFC RID: 16380
			private static readonly IntPtr NativeFieldInfoPtr_Optional;
		}

		// Token: 0x02000540 RID: 1344
		[OriginalName("mscorlib.dll", "", "ExtenderType")]
		public enum ExtenderType
		{
			// Token: 0x04003FFE RID: 16382
			None,
			// Token: 0x04003FFF RID: 16383
			Simple,
			// Token: 0x04004000 RID: 16384
			Voiced,
			// Token: 0x04004001 RID: 16385
			Conditional,
			// Token: 0x04004002 RID: 16386
			Buggy
		}
	}
}
