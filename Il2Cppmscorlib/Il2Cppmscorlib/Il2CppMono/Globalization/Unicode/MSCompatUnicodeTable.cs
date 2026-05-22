using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x02000019 RID: 25
	public class MSCompatUnicodeTable : Object
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x00025A4C File Offset: 0x00023C4C
		// Note: this type is marked as 'beforefieldinit'.
		static MSCompatUnicodeTable()
		{
			Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "MSCompatUnicodeTable");
			MSCompatUnicodeTable.NativeFieldInfoPtr_MaxExpansionLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "MaxExpansionLength");
			MSCompatUnicodeTable.NativeFieldInfoPtr_ignorableFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "ignorableFlags");
			MSCompatUnicodeTable.NativeFieldInfoPtr_categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "categories");
			MSCompatUnicodeTable.NativeFieldInfoPtr_level1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "level1");
			MSCompatUnicodeTable.NativeFieldInfoPtr_level2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "level2");
			MSCompatUnicodeTable.NativeFieldInfoPtr_level3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "level3");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHScategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkCHScategory");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHTcategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkCHTcategory");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkJAcategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkJAcategory");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOcategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkKOcategory");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHSlv1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkCHSlv1");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHTlv1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkCHTlv1");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkJAlv1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkJAlv1");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOlv1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkKOlv1");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOlv2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkKOlv2");
			MSCompatUnicodeTable.NativeFieldInfoPtr_tailoringArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "tailoringArr");
			MSCompatUnicodeTable.NativeFieldInfoPtr_tailoringInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "tailoringInfos");
			MSCompatUnicodeTable.NativeFieldInfoPtr_forLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "forLock");
			MSCompatUnicodeTable.NativeFieldInfoPtr_isReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "isReady");
			MSCompatUnicodeTable.NativeMethodInfoPtr_GetTailoringInfo_Public_Static_TailoringInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663419);
			MSCompatUnicodeTable.NativeMethodInfoPtr_BuildTailoringTables_Public_Static_Void_CultureInfo_TailoringInfo_byref_Il2CppReferenceArray_1_Contraction_byref_Il2CppReferenceArray_1_Level2Map_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663420);
			MSCompatUnicodeTable.NativeMethodInfoPtr_SetCJKReferences_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663421);
			MSCompatUnicodeTable.NativeMethodInfoPtr_Category_Public_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663422);
			MSCompatUnicodeTable.NativeMethodInfoPtr_Level1_Public_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663423);
			MSCompatUnicodeTable.NativeMethodInfoPtr_Level2_Public_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663424);
			MSCompatUnicodeTable.NativeMethodInfoPtr_Level3_Public_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663425);
			MSCompatUnicodeTable.NativeMethodInfoPtr_IsIgnorable_Public_Static_Boolean_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663426);
			MSCompatUnicodeTable.NativeMethodInfoPtr_IsIgnorableNonSpacing_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663427);
			MSCompatUnicodeTable.NativeMethodInfoPtr_ToKanaTypeInsensitive_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663428);
			MSCompatUnicodeTable.NativeMethodInfoPtr_ToWidthCompat_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663429);
			MSCompatUnicodeTable.NativeMethodInfoPtr_HasSpecialWeight_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663430);
			MSCompatUnicodeTable.NativeMethodInfoPtr_IsHalfWidthKana_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663431);
			MSCompatUnicodeTable.NativeMethodInfoPtr_IsHiragana_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663432);
			MSCompatUnicodeTable.NativeMethodInfoPtr_IsJapaneseSmallLetter_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663433);
			MSCompatUnicodeTable.NativeMethodInfoPtr_get_IsReady_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663434);
			MSCompatUnicodeTable.NativeMethodInfoPtr_GetResource_Private_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663435);
			MSCompatUnicodeTable.NativeMethodInfoPtr_UInt32FromBytePtr_Private_Static_UInt32_ptr_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663436);
			MSCompatUnicodeTable.NativeMethodInfoPtr_FillCJK_Public_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663438);
			MSCompatUnicodeTable.NativeMethodInfoPtr_FillCJKCore_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663439);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00025D80 File Offset: 0x00023F80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131535, RefRangeEnd = 131537, XrefRangeStart = 131526, XrefRangeEnd = 131535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TailoringInfo GetTailoringInfo(int lcid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lcid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_GetTailoringInfo_Public_Static_TailoringInfo_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TailoringInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00025DC0 File Offset: 0x00023FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131617, RefRangeEnd = 131618, XrefRangeStart = 131537, XrefRangeEnd = 131617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Il2CppReferenceArray<Contraction> contractions, ref Il2CppReferenceArray<Level2Map> diacriticals)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(contractions);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(diacriticals);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_BuildTailoringTables_Public_Static_Void_CultureInfo_TailoringInfo_byref_Il2CppReferenceArray_1_Contraction_byref_Il2CppReferenceArray_1_Level2Map_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			contractions = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<Contraction>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			diacriticals = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<Level2Map>(intPtr6));
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00025E58 File Offset: 0x00024058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131664, RefRangeEnd = 131665, XrefRangeStart = 131618, XrefRangeEnd = 131664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
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
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_SetCJKReferences_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0, 0, (void**)ptr, ref intPtr7);
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

		// Token: 0x060000D7 RID: 215 RVA: 0x00025F60 File Offset: 0x00024160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131665, XrefRangeEnd = 131674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte Category(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_Category_Public_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00025FA0 File Offset: 0x000241A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131674, XrefRangeEnd = 131683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte Level1(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_Level1_Public_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00025FE0 File Offset: 0x000241E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131692, RefRangeEnd = 131693, XrefRangeStart = 131683, XrefRangeEnd = 131692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte Level2(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_Level2_Public_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00026020 File Offset: 0x00024220
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 131702, RefRangeEnd = 131710, XrefRangeStart = 131693, XrefRangeEnd = 131702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte Level3(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_Level3_Public_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00026060 File Offset: 0x00024260
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131720, RefRangeEnd = 131722, XrefRangeStart = 131710, XrefRangeEnd = 131720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIgnorable(int cp, byte flag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_IsIgnorable_Public_Static_Boolean_Int32_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000260AC File Offset: 0x000242AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 131726, RefRangeEnd = 131731, XrefRangeStart = 131722, XrefRangeEnd = 131726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIgnorableNonSpacing(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_IsIgnorableNonSpacing_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000260EC File Offset: 0x000242EC
		[CallerCount(0)]
		public unsafe static int ToKanaTypeInsensitive(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_ToKanaTypeInsensitive_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0002612C File Offset: 0x0002432C
		[CallerCount(0)]
		public unsafe static int ToWidthCompat(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_ToWidthCompat_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0002616C File Offset: 0x0002436C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 131731, RefRangeEnd = 131737, XrefRangeStart = 131731, XrefRangeEnd = 131731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasSpecialWeight(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_HasSpecialWeight_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000261AC File Offset: 0x000243AC
		[CallerCount(0)]
		public unsafe static bool IsHalfWidthKana(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_IsHalfWidthKana_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000261EC File Offset: 0x000243EC
		[CallerCount(0)]
		public unsafe static bool IsHiragana(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_IsHiragana_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0002622C File Offset: 0x0002442C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 131737, RefRangeEnd = 131741, XrefRangeStart = 131737, XrefRangeEnd = 131737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsJapaneseSmallLetter(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_IsJapaneseSmallLetter_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0002626C File Offset: 0x0002446C
		public unsafe static bool IsReady
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131741, XrefRangeEnd = 131745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_get_IsReady_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0002629C File Offset: 0x0002449C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131749, RefRangeEnd = 131751, XrefRangeStart = 131745, XrefRangeEnd = 131749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetResource(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_GetResource_Private_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000262E0 File Offset: 0x000244E0
		[CallerCount(0)]
		public unsafe static uint UInt32FromBytePtr(byte* raw, uint idx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = raw;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_UInt32FromBytePtr_Private_Static_UInt32_ptr_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0002632C File Offset: 0x0002452C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131762, RefRangeEnd = 131764, XrefRangeStart = 131751, XrefRangeEnd = 131762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(culture);
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
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_FillCJK_Public_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0, 0, (void**)ptr, ref intPtr7);
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

		// Token: 0x060000E7 RID: 231 RVA: 0x00026434 File Offset: 0x00024634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131847, RefRangeEnd = 131848, XrefRangeStart = 131764, XrefRangeEnd = 131847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(culture);
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
			IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(cjkLv2Indexer);
			ptr5 = &intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5 = IL2CPP.Il2CppObjectBaseToPtr(lv2Table);
			ptr6 = &intPtr5;
			IntPtr intPtr7;
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_FillCJKCore_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0, 0, (void**)ptr, ref intPtr7);
			Il2CppException.RaiseExceptionIfNecessary(intPtr7);
			IntPtr intPtr8 = intPtr;
			cjkIndexer = ((intPtr8 == 0) ? null : new CodePointIndexer(intPtr8));
			IntPtr intPtr9 = intPtr2;
			catTable = ((intPtr9 == 0) ? null : new byte*(intPtr9));
			IntPtr intPtr10 = intPtr3;
			lv1Table = ((intPtr10 == 0) ? null : new byte*(intPtr10));
			IntPtr intPtr11 = intPtr4;
			cjkLv2Indexer = ((intPtr11 == 0) ? null : new CodePointIndexer(intPtr11));
			IntPtr intPtr12 = intPtr5;
			lv2Table = ((intPtr12 == 0) ? null : new byte*(intPtr12));
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002579 File Offset: 0x00000779
		public MSCompatUnicodeTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0002653C File Offset: 0x0002473C
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002582 File Offset: 0x00000782
		public unsafe static int MaxExpansionLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_MaxExpansionLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_MaxExpansionLength, (void*)(&value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00026558 File Offset: 0x00024758
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00002590 File Offset: 0x00000790
		public unsafe static byte* ignorableFlags
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_ignorableFlags, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_ignorableFlags, (void*)value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00026574 File Offset: 0x00024774
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000259D File Offset: 0x0000079D
		public unsafe static byte* categories
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_categories, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_categories, (void*)value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00026590 File Offset: 0x00024790
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000025AA File Offset: 0x000007AA
		public unsafe static byte* level1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_level1, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_level1, (void*)value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000265AC File Offset: 0x000247AC
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x000025B7 File Offset: 0x000007B7
		public unsafe static byte* level2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_level2, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_level2, (void*)value);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000265C8 File Offset: 0x000247C8
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x000025C4 File Offset: 0x000007C4
		public unsafe static byte* level3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_level3, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_level3, (void*)value);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000265E4 File Offset: 0x000247E4
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000025D1 File Offset: 0x000007D1
		public unsafe static byte* cjkCHScategory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHScategory, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHScategory, (void*)value);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00026600 File Offset: 0x00024800
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000025DE File Offset: 0x000007DE
		public unsafe static byte* cjkCHTcategory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHTcategory, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHTcategory, (void*)value);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0002661C File Offset: 0x0002481C
		// (set) Token: 0x060000FA RID: 250 RVA: 0x000025EB File Offset: 0x000007EB
		public unsafe static byte* cjkJAcategory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkJAcategory, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkJAcategory, (void*)value);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00026638 File Offset: 0x00024838
		// (set) Token: 0x060000FC RID: 252 RVA: 0x000025F8 File Offset: 0x000007F8
		public unsafe static byte* cjkKOcategory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOcategory, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOcategory, (void*)value);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00026654 File Offset: 0x00024854
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002605 File Offset: 0x00000805
		public unsafe static byte* cjkCHSlv1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHSlv1, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHSlv1, (void*)value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00026670 File Offset: 0x00024870
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002612 File Offset: 0x00000812
		public unsafe static byte* cjkCHTlv1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHTlv1, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHTlv1, (void*)value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0002668C File Offset: 0x0002488C
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0000261F File Offset: 0x0000081F
		public unsafe static byte* cjkJAlv1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkJAlv1, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkJAlv1, (void*)value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000266A8 File Offset: 0x000248A8
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000262C File Offset: 0x0000082C
		public unsafe static byte* cjkKOlv1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOlv1, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOlv1, (void*)value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000266C4 File Offset: 0x000248C4
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002639 File Offset: 0x00000839
		public unsafe static byte* cjkKOlv2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOlv2, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOlv2, (void*)value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000266E0 File Offset: 0x000248E0
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00002646 File Offset: 0x00000846
		public unsafe static Il2CppStructArray<char> tailoringArr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_tailoringArr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_tailoringArr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00026708 File Offset: 0x00024908
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00002658 File Offset: 0x00000858
		public unsafe static Il2CppReferenceArray<TailoringInfo> tailoringInfos
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_tailoringInfos, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TailoringInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_tailoringInfos, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00026730 File Offset: 0x00024930
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000266A File Offset: 0x0000086A
		public unsafe static Object forLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_forLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_forLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00026758 File Offset: 0x00024958
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000267C File Offset: 0x0000087C
		public unsafe static bool isReady
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_isReady, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_isReady, (void*)(&value));
			}
		}

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_MaxExpansionLength;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_ignorableFlags;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_categories;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr_level1;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr_level2;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeFieldInfoPtr_level3;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr_cjkCHScategory;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_cjkCHTcategory;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_cjkJAcategory;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_cjkKOcategory;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_cjkCHSlv1;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_cjkCHTlv1;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_cjkJAlv1;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_cjkKOlv1;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_cjkKOlv2;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_tailoringArr;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_tailoringInfos;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_forLock;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_isReady;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_GetTailoringInfo_Public_Static_TailoringInfo_Int32_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_BuildTailoringTables_Public_Static_Void_CultureInfo_TailoringInfo_byref_Il2CppReferenceArray_1_Contraction_byref_Il2CppReferenceArray_1_Level2Map_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_SetCJKReferences_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_Category_Public_Static_Byte_Int32_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_Level1_Public_Static_Byte_Int32_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_Level2_Public_Static_Byte_Int32_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_Level3_Public_Static_Byte_Int32_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_IsIgnorable_Public_Static_Boolean_Int32_Byte_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_IsIgnorableNonSpacing_Public_Static_Boolean_Int32_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_ToKanaTypeInsensitive_Public_Static_Int32_Int32_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_ToWidthCompat_Public_Static_Int32_Int32_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_HasSpecialWeight_Public_Static_Boolean_Char_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_IsHalfWidthKana_Public_Static_Boolean_Char_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_IsHiragana_Public_Static_Boolean_Char_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_IsJapaneseSmallLetter_Public_Static_Boolean_Char_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReady_Public_Static_get_Boolean_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_GetResource_Private_Static_IntPtr_String_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_UInt32FromBytePtr_Private_Static_UInt32_ptr_Byte_UInt32_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_FillCJK_Public_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_FillCJKCore_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0;

		// Token: 0x0200053C RID: 1340
		[ObfuscatedName("Mono.Globalization.Unicode.MSCompatUnicodeTable+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004F19 RID: 20249 RVA: 0x001681E8 File Offset: 0x001663E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MSCompatUnicodeTable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSCompatUnicodeTable.__c>.NativeClassPtr);
				MSCompatUnicodeTable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable.__c>.NativeClassPtr, "<>9");
				MSCompatUnicodeTable.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable.__c>.NativeClassPtr, "<>9__17_0");
				MSCompatUnicodeTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable.__c>.NativeClassPtr, 100663441);
				MSCompatUnicodeTable.__c.NativeMethodInfoPtr__BuildTailoringTables_b__17_0_Internal_Int32_Level2Map_Level2Map_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable.__c>.NativeClassPtr, 100663442);
			}

			// Token: 0x06004F1A RID: 20250 RVA: 0x00168264 File Offset: 0x00166464
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSCompatUnicodeTable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F1B RID: 20251 RVA: 0x001682A0 File Offset: 0x001664A0
			[CallerCount(0)]
			public unsafe int _BuildTailoringTables_b__17_0(Level2Map a, Level2Map b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.__c.NativeMethodInfoPtr__BuildTailoringTables_b__17_0_Internal_Int32_Level2Map_Level2Map_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F1C RID: 20252 RVA: 0x0001D9F2 File Offset: 0x0001BBF2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700143B RID: 5179
			// (get) Token: 0x06004F1D RID: 20253 RVA: 0x00168300 File Offset: 0x00166500
			// (set) Token: 0x06004F1E RID: 20254 RVA: 0x0001D9FB File Offset: 0x0001BBFB
			public unsafe static MSCompatUnicodeTable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSCompatUnicodeTable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700143C RID: 5180
			// (get) Token: 0x06004F1F RID: 20255 RVA: 0x00168328 File Offset: 0x00166528
			// (set) Token: 0x06004F20 RID: 20256 RVA: 0x0001DA0D File Offset: 0x0001BC0D
			public unsafe static Comparison<Level2Map> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Level2Map>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FE0 RID: 16352
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003FE1 RID: 16353
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04003FE2 RID: 16354
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003FE3 RID: 16355
			private static readonly IntPtr NativeMethodInfoPtr__BuildTailoringTables_b__17_0_Internal_Int32_Level2Map_Level2Map_0;
		}
	}
}
