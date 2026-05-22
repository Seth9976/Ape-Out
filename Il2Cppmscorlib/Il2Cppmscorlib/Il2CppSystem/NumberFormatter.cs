using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x0200012A RID: 298
	public sealed class NumberFormatter : Object
	{
		// Token: 0x0600152B RID: 5419 RVA: 0x00084D58 File Offset: 0x00082F58
		// Note: this type is marked as 'beforefieldinit'.
		static NumberFormatter()
		{
			Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NumberFormatter");
			NumberFormatter.NativeFieldInfoPtr_MantissaBitsTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "MantissaBitsTable");
			NumberFormatter.NativeFieldInfoPtr_TensExponentTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "TensExponentTable");
			NumberFormatter.NativeFieldInfoPtr_DigitLowerTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "DigitLowerTable");
			NumberFormatter.NativeFieldInfoPtr_DigitUpperTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "DigitUpperTable");
			NumberFormatter.NativeFieldInfoPtr_TenPowersList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "TenPowersList");
			NumberFormatter.NativeFieldInfoPtr_DecHexDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "DecHexDigits");
			NumberFormatter.NativeFieldInfoPtr__nfi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_nfi");
			NumberFormatter.NativeFieldInfoPtr__cbuf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_cbuf");
			NumberFormatter.NativeFieldInfoPtr__NaN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_NaN");
			NumberFormatter.NativeFieldInfoPtr__infinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_infinity");
			NumberFormatter.NativeFieldInfoPtr__isCustomFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_isCustomFormat");
			NumberFormatter.NativeFieldInfoPtr__specifierIsUpper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_specifierIsUpper");
			NumberFormatter.NativeFieldInfoPtr__positive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_positive");
			NumberFormatter.NativeFieldInfoPtr__specifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_specifier");
			NumberFormatter.NativeFieldInfoPtr__precision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_precision");
			NumberFormatter.NativeFieldInfoPtr__defPrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_defPrecision");
			NumberFormatter.NativeFieldInfoPtr__digitsLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_digitsLen");
			NumberFormatter.NativeFieldInfoPtr__offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_offset");
			NumberFormatter.NativeFieldInfoPtr__decPointPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_decPointPos");
			NumberFormatter.NativeFieldInfoPtr__val1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_val1");
			NumberFormatter.NativeFieldInfoPtr__val2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_val2");
			NumberFormatter.NativeFieldInfoPtr__val3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_val3");
			NumberFormatter.NativeFieldInfoPtr__val4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_val4");
			NumberFormatter.NativeFieldInfoPtr__ind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_ind");
			NumberFormatter.NativeFieldInfoPtr_threadNumberFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "threadNumberFormatter");
			NumberFormatter.NativeFieldInfoPtr_userFormatProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "userFormatProvider");
			NumberFormatter.NativeMethodInfoPtr_GetFormatterTables_Private_Static_Void_byref_ptr_UInt64_byref_ptr_Int32_byref_ptr_Char_byref_ptr_Char_byref_ptr_Int64_byref_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666963);
			NumberFormatter.NativeMethodInfoPtr_GetTenPowerOf_Private_Static_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666965);
			NumberFormatter.NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666966);
			NumberFormatter.NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666967);
			NumberFormatter.NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666968);
			NumberFormatter.NativeMethodInfoPtr_FastToDecHex_Private_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666969);
			NumberFormatter.NativeMethodInfoPtr_ToDecHex_Private_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666970);
			NumberFormatter.NativeMethodInfoPtr_FastDecHexLen_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666971);
			NumberFormatter.NativeMethodInfoPtr_DecHexLen_Private_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666972);
			NumberFormatter.NativeMethodInfoPtr_DecHexLen_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666973);
			NumberFormatter.NativeMethodInfoPtr_ScaleOrder_Private_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666974);
			NumberFormatter.NativeMethodInfoPtr_InitialFloatingPrecision_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666975);
			NumberFormatter.NativeMethodInfoPtr_ParsePrecision_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666976);
			NumberFormatter.NativeMethodInfoPtr__ctor_Private_Void_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666977);
			NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666978);
			NumberFormatter.NativeMethodInfoPtr_InitHex_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666979);
			NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666980);
			NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666981);
			NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666982);
			NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666983);
			NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666984);
			NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666985);
			NumberFormatter.NativeMethodInfoPtr_ResetCharBuf_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666986);
			NumberFormatter.NativeMethodInfoPtr_Resize_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666987);
			NumberFormatter.NativeMethodInfoPtr_Append_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666988);
			NumberFormatter.NativeMethodInfoPtr_Append_Private_Void_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666989);
			NumberFormatter.NativeMethodInfoPtr_Append_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666990);
			NumberFormatter.NativeMethodInfoPtr_GetNumberFormatInstance_Private_NumberFormatInfo_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666991);
			NumberFormatter.NativeMethodInfoPtr_set_CurrentCulture_Private_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666992);
			NumberFormatter.NativeMethodInfoPtr_get_IntegerDigits_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666993);
			NumberFormatter.NativeMethodInfoPtr_get_DecimalDigits_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666994);
			NumberFormatter.NativeMethodInfoPtr_get_IsFloatingSource_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666995);
			NumberFormatter.NativeMethodInfoPtr_get_IsZero_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666996);
			NumberFormatter.NativeMethodInfoPtr_get_IsZeroInteger_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666997);
			NumberFormatter.NativeMethodInfoPtr_RoundPos_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666998);
			NumberFormatter.NativeMethodInfoPtr_RoundDecimal_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666999);
			NumberFormatter.NativeMethodInfoPtr_RoundBits_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667000);
			NumberFormatter.NativeMethodInfoPtr_RemoveTrailingZeros_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667001);
			NumberFormatter.NativeMethodInfoPtr_AddOneToDecHex_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667002);
			NumberFormatter.NativeMethodInfoPtr_AddOneToDecHex_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667003);
			NumberFormatter.NativeMethodInfoPtr_CountTrailingZeros_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667004);
			NumberFormatter.NativeMethodInfoPtr_CountTrailingZeros_Private_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667005);
			NumberFormatter.NativeMethodInfoPtr_GetInstance_Private_Static_NumberFormatter_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667006);
			NumberFormatter.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667007);
			NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667008);
			NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667009);
			NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667010);
			NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667011);
			NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667012);
			NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667013);
			NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667014);
			NumberFormatter.NativeMethodInfoPtr_IntegerToString_Private_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667015);
			NumberFormatter.NativeMethodInfoPtr_NumberToString_Private_String_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667016);
			NumberFormatter.NativeMethodInfoPtr_FormatCurrency_Private_String_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667017);
			NumberFormatter.NativeMethodInfoPtr_FormatDecimal_Private_String_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667018);
			NumberFormatter.NativeMethodInfoPtr_FormatHexadecimal_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667019);
			NumberFormatter.NativeMethodInfoPtr_FormatFixedPoint_Private_String_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667020);
			NumberFormatter.NativeMethodInfoPtr_FormatRoundtrip_Private_String_Double_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667021);
			NumberFormatter.NativeMethodInfoPtr_FormatRoundtrip_Private_String_Single_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667022);
			NumberFormatter.NativeMethodInfoPtr_FormatGeneral_Private_String_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667023);
			NumberFormatter.NativeMethodInfoPtr_FormatNumber_Private_String_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667024);
			NumberFormatter.NativeMethodInfoPtr_FormatPercent_Private_String_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667025);
			NumberFormatter.NativeMethodInfoPtr_FormatExponential_Private_String_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667026);
			NumberFormatter.NativeMethodInfoPtr_FormatExponential_Private_String_Int32_NumberFormatInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667027);
			NumberFormatter.NativeMethodInfoPtr_FormatCustom_Private_String_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667028);
			NumberFormatter.NativeMethodInfoPtr_ZeroTrimEnd_Private_Static_Void_StringBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667029);
			NumberFormatter.NativeMethodInfoPtr_IsZeroOnly_Private_Static_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667030);
			NumberFormatter.NativeMethodInfoPtr_AppendNonNegativeNumber_Private_Static_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667031);
			NumberFormatter.NativeMethodInfoPtr_AppendIntegerString_Private_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667032);
			NumberFormatter.NativeMethodInfoPtr_AppendIntegerString_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667033);
			NumberFormatter.NativeMethodInfoPtr_AppendDecimalString_Private_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667034);
			NumberFormatter.NativeMethodInfoPtr_AppendDecimalString_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667035);
			NumberFormatter.NativeMethodInfoPtr_AppendIntegerStringWithGroupSeparator_Private_Void_Il2CppStructArray_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667036);
			NumberFormatter.NativeMethodInfoPtr_AppendExponent_Private_Void_NumberFormatInfo_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667037);
			NumberFormatter.NativeMethodInfoPtr_AppendOneDigit_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667038);
			NumberFormatter.NativeMethodInfoPtr_AppendDigits_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667039);
			NumberFormatter.NativeMethodInfoPtr_AppendDigits_Private_Void_Int32_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667040);
			NumberFormatter.NativeMethodInfoPtr_Multiply10_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667041);
			NumberFormatter.NativeMethodInfoPtr_Divide10_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667042);
			NumberFormatter.NativeMethodInfoPtr_GetClone_Private_NumberFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100667043);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x000855C8 File Offset: 0x000837C8
		[CallerCount(0)]
		public unsafe static void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5 = 0;
			ptr6 = &intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6 = 0;
			ptr7 = &intPtr6;
			IntPtr intPtr8;
			IntPtr intPtr7 = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_GetFormatterTables_Private_Static_Void_byref_ptr_UInt64_byref_ptr_Int32_byref_ptr_Char_byref_ptr_Char_byref_ptr_Int64_byref_ptr_Int32_0, 0, (void**)ptr, ref intPtr8);
			Il2CppException.RaiseExceptionIfNecessary(intPtr8);
			IntPtr intPtr9 = intPtr;
			MantissaBitsTable = ((intPtr9 == 0) ? null : new ulong*(intPtr9));
			IntPtr intPtr10 = intPtr2;
			TensExponentTable = ((intPtr10 == 0) ? null : new int*(intPtr10));
			IntPtr intPtr11 = intPtr3;
			DigitLowerTable = ((intPtr11 == 0) ? null : new char*(intPtr11));
			IntPtr intPtr12 = intPtr4;
			DigitUpperTable = ((intPtr12 == 0) ? null : new char*(intPtr12));
			IntPtr intPtr13 = intPtr5;
			TenPowersList = ((intPtr13 == 0) ? null : new long*(intPtr13));
			IntPtr intPtr14 = intPtr6;
			DecHexDigits = ((intPtr14 == 0) ? null : new int*(intPtr14));
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x000856C0 File Offset: 0x000838C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 176246, RefRangeEnd = 176248, XrefRangeStart = 176242, XrefRangeEnd = 176246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetTenPowerOf(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_GetTenPowerOf_Private_Static_Int64_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00085700 File Offset: 0x00083900
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 176255, RefRangeEnd = 176261, XrefRangeStart = 176248, XrefRangeEnd = 176255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitDecHexDigits(uint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00085740 File Offset: 0x00083940
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 176271, RefRangeEnd = 176278, XrefRangeStart = 176261, XrefRangeEnd = 176271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitDecHexDigits(ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00085780 File Offset: 0x00083980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176278, XrefRangeEnd = 176291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitDecHexDigits(uint hi, ulong lo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hi;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt32_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x000857CC File Offset: 0x000839CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 176295, RefRangeEnd = 176299, XrefRangeStart = 176291, XrefRangeEnd = 176295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint FastToDecHex(int val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FastToDecHex_Private_Static_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0008580C File Offset: 0x00083A0C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 176306, RefRangeEnd = 176314, XrefRangeStart = 176299, XrefRangeEnd = 176306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToDecHex(int val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_ToDecHex_Private_Static_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0008584C File Offset: 0x00083A4C
		[CallerCount(0)]
		public unsafe static int FastDecHexLen(int val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FastDecHexLen_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0008588C File Offset: 0x00083A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176314, XrefRangeEnd = 176317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DecHexLen(uint val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_DecHexLen_Private_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x000858CC File Offset: 0x00083ACC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 176318, RefRangeEnd = 176340, XrefRangeStart = 176317, XrefRangeEnd = 176318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DecHexLen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_DecHexLen_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00085908 File Offset: 0x00083B08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 176344, RefRangeEnd = 176347, XrefRangeStart = 176340, XrefRangeEnd = 176344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ScaleOrder(long hi)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_ScaleOrder_Private_Static_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x00085948 File Offset: 0x00083B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176347, XrefRangeEnd = 176348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InitialFloatingPrecision()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_InitialFloatingPrecision_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00085984 File Offset: 0x00083B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176348, XrefRangeEnd = 176349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParsePrecision(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_ParsePrecision_Private_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x000859C8 File Offset: 0x00083BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176349, XrefRangeEnd = 176355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFormatter(Thread current)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr__ctor_Private_Void_Thread_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00085A14 File Offset: 0x00083C14
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 176362, RefRangeEnd = 176376, XrefRangeStart = 176355, XrefRangeEnd = 176362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00085A58 File Offset: 0x00083C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176376, XrefRangeEnd = 176377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitHex(ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_InitHex_Private_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00085A98 File Offset: 0x00083C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176377, XrefRangeEnd = 176380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string format, int value, int defPrecision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defPrecision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00085AF8 File Offset: 0x00083CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176380, XrefRangeEnd = 176383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string format, uint value, int defPrecision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defPrecision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00085B58 File Offset: 0x00083D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176383, XrefRangeEnd = 176386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string format, long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x00085BA8 File Offset: 0x00083DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176386, XrefRangeEnd = 176389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string format, ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x00085BF8 File Offset: 0x00083DF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 176428, RefRangeEnd = 176430, XrefRangeStart = 176389, XrefRangeEnd = 176428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string format, double value, int defPrecision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defPrecision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00085C58 File Offset: 0x00083E58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 176435, RefRangeEnd = 176437, XrefRangeStart = 176430, XrefRangeEnd = 176435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string format, Decimal value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x00085CA8 File Offset: 0x00083EA8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 176440, RefRangeEnd = 176449, XrefRangeStart = 176437, XrefRangeEnd = 176440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCharBuf(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_ResetCharBuf_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00085CE8 File Offset: 0x00083EE8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 176455, RefRangeEnd = 176463, XrefRangeStart = 176449, XrefRangeEnd = 176455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize(int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref len;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Resize_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00085D28 File Offset: 0x00083F28
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 176464, RefRangeEnd = 176482, XrefRangeStart = 176463, XrefRangeEnd = 176464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Append_Private_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x00085D68 File Offset: 0x00083F68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 176483, RefRangeEnd = 176485, XrefRangeStart = 176482, XrefRangeEnd = 176483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(char c, int cnt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Append_Private_Void_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x00085DB4 File Offset: 0x00083FB4
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 176486, RefRangeEnd = 176518, XrefRangeStart = 176485, XrefRangeEnd = 176486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Append_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00085DF8 File Offset: 0x00083FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176518, XrefRangeEnd = 176519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_GetNumberFormatInstance_Private_NumberFormatInfo_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (set) Token: 0x06001548 RID: 5448 RVA: 0x00085E48 File Offset: 0x00084048
		public unsafe CultureInfo CurrentCulture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 176520, RefRangeEnd = 176521, XrefRangeStart = 176519, XrefRangeEnd = 176520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_set_CurrentCulture_Private_set_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x00085E8C File Offset: 0x0008408C
		public unsafe int IntegerDigits
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_get_IntegerDigits_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x00085EC8 File Offset: 0x000840C8
		public unsafe int DecimalDigits
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_get_DecimalDigits_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x00085F04 File Offset: 0x00084104
		public unsafe bool IsFloatingSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_get_IsFloatingSource_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x00085F40 File Offset: 0x00084140
		public unsafe bool IsZero
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_get_IsZero_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x00085F7C File Offset: 0x0008417C
		public unsafe bool IsZeroInteger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_get_IsZeroInteger_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00085FB8 File Offset: 0x000841B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176521, XrefRangeEnd = 176522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RoundPos(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_RoundPos_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x00085FF8 File Offset: 0x000841F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176522, XrefRangeEnd = 176523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RoundDecimal(int decimals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref decimals;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_RoundDecimal_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x00086044 File Offset: 0x00084244
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 176544, RefRangeEnd = 176554, XrefRangeStart = 176523, XrefRangeEnd = 176544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RoundBits(int shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_RoundBits_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00086090 File Offset: 0x00084290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176554, XrefRangeEnd = 176555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrailingZeros()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_RemoveTrailingZeros_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x000860C4 File Offset: 0x000842C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176555, XrefRangeEnd = 176559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOneToDecHex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AddOneToDecHex_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x000860F8 File Offset: 0x000842F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 176559, RefRangeEnd = 176563, XrefRangeStart = 176559, XrefRangeEnd = 176559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint AddOneToDecHex(uint val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AddOneToDecHex_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x00086138 File Offset: 0x00084338
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 176564, RefRangeEnd = 176567, XrefRangeStart = 176563, XrefRangeEnd = 176564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CountTrailingZeros()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_CountTrailingZeros_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00086174 File Offset: 0x00084374
		[CallerCount(0)]
		public unsafe static int CountTrailingZeros(uint val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_CountTrailingZeros_Private_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x000861B4 File Offset: 0x000843B4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 176577, RefRangeEnd = 176589, XrefRangeStart = 176567, XrefRangeEnd = 176577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NumberFormatter GetInstance(IFormatProvider fp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_GetInstance_Private_Static_NumberFormatter_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatter>(intPtr3) : null;
			}
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x000861F8 File Offset: 0x000843F8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 176598, RefRangeEnd = 176610, XrefRangeStart = 176589, XrefRangeEnd = 176598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x0008622C File Offset: 0x0008442C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176610, XrefRangeEnd = 176621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NumberToString(string format, uint value, IFormatProvider fp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_UInt32_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00086288 File Offset: 0x00084488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176621, XrefRangeEnd = 176632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NumberToString(string format, int value, IFormatProvider fp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Int32_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x000862E4 File Offset: 0x000844E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176632, XrefRangeEnd = 176643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NumberToString(string format, ulong value, IFormatProvider fp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_UInt64_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00086340 File Offset: 0x00084540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176643, XrefRangeEnd = 176654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NumberToString(string format, long value, IFormatProvider fp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Int64_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0008639C File Offset: 0x0008459C
		[CallerCount(68)]
		[CachedScanResults(RefRangeStart = 176673, RefRangeEnd = 176741, XrefRangeStart = 176654, XrefRangeEnd = 176673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NumberToString(string format, float value, IFormatProvider fp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Single_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x000863F8 File Offset: 0x000845F8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 176762, RefRangeEnd = 176783, XrefRangeStart = 176741, XrefRangeEnd = 176762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NumberToString(string format, double value, IFormatProvider fp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Double_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00086454 File Offset: 0x00084654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176783, XrefRangeEnd = 176791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NumberToString(string format, Decimal value, IFormatProvider fp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Decimal_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x000864B0 File Offset: 0x000846B0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 176805, RefRangeEnd = 176813, XrefRangeStart = 176791, XrefRangeEnd = 176805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string IntegerToString(string format, IFormatProvider fp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_IntegerToString_Private_String_String_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x0008650C File Offset: 0x0008470C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 176828, RefRangeEnd = 176832, XrefRangeStart = 176813, XrefRangeEnd = 176828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string NumberToString(string format, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_NumberToString_Private_String_String_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00086568 File Offset: 0x00084768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176878, RefRangeEnd = 176879, XrefRangeStart = 176832, XrefRangeEnd = 176878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatCurrency(int precision, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatCurrency_Private_String_Int32_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x000865C0 File Offset: 0x000847C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176879, XrefRangeEnd = 176884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatDecimal(int precision, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatDecimal_Private_String_Int32_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00086618 File Offset: 0x00084818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176884, XrefRangeEnd = 176896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatHexadecimal(int precision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatHexadecimal_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x0008665C File Offset: 0x0008485C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176905, RefRangeEnd = 176906, XrefRangeStart = 176896, XrefRangeEnd = 176905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatFixedPoint(int precision, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatFixedPoint_Private_String_Int32_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x000866B4 File Offset: 0x000848B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176906, XrefRangeEnd = 176914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatRoundtrip(double origval, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origval;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatRoundtrip_Private_String_Double_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x0008670C File Offset: 0x0008490C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176914, XrefRangeEnd = 176920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatRoundtrip(float origval, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origval;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatRoundtrip_Private_String_Single_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00086764 File Offset: 0x00084964
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 176931, RefRangeEnd = 176938, XrefRangeStart = 176920, XrefRangeEnd = 176931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatGeneral(int precision, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatGeneral_Private_String_Int32_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x000867BC File Offset: 0x000849BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176954, RefRangeEnd = 176955, XrefRangeStart = 176938, XrefRangeEnd = 176954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatNumber(int precision, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatNumber_Private_String_Int32_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00086814 File Offset: 0x00084A14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 176973, RefRangeEnd = 176975, XrefRangeStart = 176955, XrefRangeEnd = 176973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatPercent(int precision, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatPercent_Private_String_Int32_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0008686C File Offset: 0x00084A6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176977, RefRangeEnd = 176978, XrefRangeStart = 176975, XrefRangeEnd = 176977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatExponential(int precision, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatExponential_Private_String_Int32_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x000868C4 File Offset: 0x00084AC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176992, RefRangeEnd = 176993, XrefRangeStart = 176978, XrefRangeEnd = 176992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expDigits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatExponential_Private_String_Int32_NumberFormatInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00086928 File Offset: 0x00084B28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177074, RefRangeEnd = 177075, XrefRangeStart = 176993, XrefRangeEnd = 177074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatCustom(string format, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatCustom_Private_String_String_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00086984 File Offset: 0x00084B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177075, XrefRangeEnd = 177079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ZeroTrimEnd(StringBuilder sb, bool canEmpty)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canEmpty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_ZeroTrimEnd_Private_Static_Void_StringBuilder_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x000869C8 File Offset: 0x00084BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177079, XrefRangeEnd = 177086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsZeroOnly(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_IsZeroOnly_Private_Static_Boolean_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00086A0C File Offset: 0x00084C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177086, XrefRangeEnd = 177102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendNonNegativeNumber(StringBuilder sb, int v)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendNonNegativeNumber_Private_Static_Void_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00086A50 File Offset: 0x00084C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177102, XrefRangeEnd = 177104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendIntegerString(int minLength, StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendIntegerString_Private_Void_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00086AA0 File Offset: 0x00084CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177104, XrefRangeEnd = 177110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendIntegerString(int minLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendIntegerString_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00086AE0 File Offset: 0x00084CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177110, XrefRangeEnd = 177111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendDecimalString(int precision, StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendDecimalString_Private_Void_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00086B30 File Offset: 0x00084D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177111, XrefRangeEnd = 177112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendDecimalString(int precision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendDecimalString_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00086B70 File Offset: 0x00084D70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177141, RefRangeEnd = 177144, XrefRangeStart = 177112, XrefRangeEnd = 177141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendIntegerStringWithGroupSeparator(Il2CppStructArray<int> groups, string groupSeparator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(groups);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(groupSeparator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendIntegerStringWithGroupSeparator_Private_Void_Il2CppStructArray_1_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00086BC4 File Offset: 0x00084DC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177154, RefRangeEnd = 177155, XrefRangeStart = 177144, XrefRangeEnd = 177154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exponent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDigits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendExponent_Private_Void_NumberFormatInfo_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00086C24 File Offset: 0x00084E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177155, XrefRangeEnd = 177160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendOneDigit(int start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendOneDigit_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00086C64 File Offset: 0x00084E64
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 177166, RefRangeEnd = 177179, XrefRangeStart = 177160, XrefRangeEnd = 177166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendDigits(int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendDigits_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00086CB0 File Offset: 0x00084EB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 177193, RefRangeEnd = 177197, XrefRangeStart = 177179, XrefRangeEnd = 177193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendDigits(int start, int end, StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendDigits_Private_Void_Int32_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00086D10 File Offset: 0x00084F10
		[CallerCount(0)]
		public unsafe void Multiply10(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Multiply10_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00086D50 File Offset: 0x00084F50
		[CallerCount(0)]
		public unsafe void Divide10(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Divide10_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00086D90 File Offset: 0x00084F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177197, XrefRangeEnd = 177200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFormatter GetClone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_GetClone_Private_NumberFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatter>(intPtr3) : null;
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x0000744D File Offset: 0x0000564D
		public NumberFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x00086DD0 File Offset: 0x00084FD0
		// (set) Token: 0x0600157E RID: 5502 RVA: 0x00007456 File Offset: 0x00005656
		public unsafe static ulong* MantissaBitsTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatter.NativeFieldInfoPtr_MantissaBitsTable, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatter.NativeFieldInfoPtr_MantissaBitsTable, (void*)value);
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x00086DEC File Offset: 0x00084FEC
		// (set) Token: 0x06001580 RID: 5504 RVA: 0x00007463 File Offset: 0x00005663
		public unsafe static int* TensExponentTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatter.NativeFieldInfoPtr_TensExponentTable, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatter.NativeFieldInfoPtr_TensExponentTable, (void*)value);
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x00086E08 File Offset: 0x00085008
		// (set) Token: 0x06001582 RID: 5506 RVA: 0x00007470 File Offset: 0x00005670
		public unsafe static char* DigitLowerTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatter.NativeFieldInfoPtr_DigitLowerTable, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatter.NativeFieldInfoPtr_DigitLowerTable, (void*)value);
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x00086E24 File Offset: 0x00085024
		// (set) Token: 0x06001584 RID: 5508 RVA: 0x0000747D File Offset: 0x0000567D
		public unsafe static char* DigitUpperTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatter.NativeFieldInfoPtr_DigitUpperTable, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatter.NativeFieldInfoPtr_DigitUpperTable, (void*)value);
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x00086E40 File Offset: 0x00085040
		// (set) Token: 0x06001586 RID: 5510 RVA: 0x0000748A File Offset: 0x0000568A
		public unsafe static long* TenPowersList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatter.NativeFieldInfoPtr_TenPowersList, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatter.NativeFieldInfoPtr_TenPowersList, (void*)value);
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x00086E5C File Offset: 0x0008505C
		// (set) Token: 0x06001588 RID: 5512 RVA: 0x00007497 File Offset: 0x00005697
		public unsafe static int* DecHexDigits
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatter.NativeFieldInfoPtr_DecHexDigits, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatter.NativeFieldInfoPtr_DecHexDigits, (void*)value);
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x00086E78 File Offset: 0x00085078
		// (set) Token: 0x0600158A RID: 5514 RVA: 0x000074A4 File Offset: 0x000056A4
		public unsafe NumberFormatInfo _nfi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__nfi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__nfi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x0600158B RID: 5515 RVA: 0x00086EA8 File Offset: 0x000850A8
		// (set) Token: 0x0600158C RID: 5516 RVA: 0x000074C3 File Offset: 0x000056C3
		public unsafe Il2CppStructArray<char> _cbuf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__cbuf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__cbuf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x00086ED8 File Offset: 0x000850D8
		// (set) Token: 0x0600158E RID: 5518 RVA: 0x000074E2 File Offset: 0x000056E2
		public unsafe bool _NaN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__NaN);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__NaN)) = value;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x00086F00 File Offset: 0x00085100
		// (set) Token: 0x06001590 RID: 5520 RVA: 0x000074FD File Offset: 0x000056FD
		public unsafe bool _infinity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__infinity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__infinity)) = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x00086F28 File Offset: 0x00085128
		// (set) Token: 0x06001592 RID: 5522 RVA: 0x00007518 File Offset: 0x00005718
		public unsafe bool _isCustomFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__isCustomFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__isCustomFormat)) = value;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x00086F50 File Offset: 0x00085150
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x00007533 File Offset: 0x00005733
		public unsafe bool _specifierIsUpper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__specifierIsUpper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__specifierIsUpper)) = value;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x00086F78 File Offset: 0x00085178
		// (set) Token: 0x06001596 RID: 5526 RVA: 0x0000754E File Offset: 0x0000574E
		public unsafe bool _positive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__positive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__positive)) = value;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x00086FA0 File Offset: 0x000851A0
		// (set) Token: 0x06001598 RID: 5528 RVA: 0x00007569 File Offset: 0x00005769
		public unsafe char _specifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__specifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__specifier)) = value;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x00086FC8 File Offset: 0x000851C8
		// (set) Token: 0x0600159A RID: 5530 RVA: 0x00007584 File Offset: 0x00005784
		public unsafe int _precision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__precision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__precision)) = value;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x00086FF0 File Offset: 0x000851F0
		// (set) Token: 0x0600159C RID: 5532 RVA: 0x0000759F File Offset: 0x0000579F
		public unsafe int _defPrecision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__defPrecision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__defPrecision)) = value;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x00087018 File Offset: 0x00085218
		// (set) Token: 0x0600159E RID: 5534 RVA: 0x000075BA File Offset: 0x000057BA
		public unsafe int _digitsLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__digitsLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__digitsLen)) = value;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x00087040 File Offset: 0x00085240
		// (set) Token: 0x060015A0 RID: 5536 RVA: 0x000075D5 File Offset: 0x000057D5
		public unsafe int _offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__offset)) = value;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x00087068 File Offset: 0x00085268
		// (set) Token: 0x060015A2 RID: 5538 RVA: 0x000075F0 File Offset: 0x000057F0
		public unsafe int _decPointPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__decPointPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__decPointPos)) = value;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x060015A3 RID: 5539 RVA: 0x00087090 File Offset: 0x00085290
		// (set) Token: 0x060015A4 RID: 5540 RVA: 0x0000760B File Offset: 0x0000580B
		public unsafe uint _val1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__val1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__val1)) = value;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x000870B8 File Offset: 0x000852B8
		// (set) Token: 0x060015A6 RID: 5542 RVA: 0x00007626 File Offset: 0x00005826
		public unsafe uint _val2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__val2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__val2)) = value;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x000870E0 File Offset: 0x000852E0
		// (set) Token: 0x060015A8 RID: 5544 RVA: 0x00007641 File Offset: 0x00005841
		public unsafe uint _val3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__val3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__val3)) = value;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x00087108 File Offset: 0x00085308
		// (set) Token: 0x060015AA RID: 5546 RVA: 0x0000765C File Offset: 0x0000585C
		public unsafe uint _val4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__val4);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__val4)) = value;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x00087130 File Offset: 0x00085330
		// (set) Token: 0x060015AC RID: 5548 RVA: 0x00007677 File Offset: 0x00005877
		public unsafe int _ind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__ind);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__ind)) = value;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x00087158 File Offset: 0x00085358
		// (set) Token: 0x060015AE RID: 5550 RVA: 0x00007692 File Offset: 0x00005892
		public unsafe static NumberFormatter threadNumberFormatter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatter.NativeFieldInfoPtr_threadNumberFormatter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFormatter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatter.NativeFieldInfoPtr_threadNumberFormatter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x00087180 File Offset: 0x00085380
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x000076A4 File Offset: 0x000058A4
		public unsafe static NumberFormatter userFormatProvider
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatter.NativeFieldInfoPtr_userFormatProvider, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFormatter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatter.NativeFieldInfoPtr_userFormatProvider, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeFieldInfoPtr_MantissaBitsTable;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeFieldInfoPtr_TensExponentTable;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeFieldInfoPtr_DigitLowerTable;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeFieldInfoPtr_DigitUpperTable;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeFieldInfoPtr_TenPowersList;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeFieldInfoPtr_DecHexDigits;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeFieldInfoPtr__nfi;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeFieldInfoPtr__cbuf;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeFieldInfoPtr__NaN;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeFieldInfoPtr__infinity;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeFieldInfoPtr__isCustomFormat;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeFieldInfoPtr__specifierIsUpper;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeFieldInfoPtr__positive;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeFieldInfoPtr__specifier;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeFieldInfoPtr__precision;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeFieldInfoPtr__defPrecision;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeFieldInfoPtr__digitsLen;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeFieldInfoPtr__offset;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeFieldInfoPtr__decPointPos;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeFieldInfoPtr__val1;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeFieldInfoPtr__val2;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeFieldInfoPtr__val3;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeFieldInfoPtr__val4;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeFieldInfoPtr__ind;

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeFieldInfoPtr_threadNumberFormatter;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeFieldInfoPtr_userFormatProvider;

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatterTables_Private_Static_Void_byref_ptr_UInt64_byref_ptr_Int32_byref_ptr_Char_byref_ptr_Char_byref_ptr_Int64_byref_ptr_Int32_0;

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeMethodInfoPtr_GetTenPowerOf_Private_Static_Int64_Int32_0;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt32_0;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt64_0;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt32_UInt64_0;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeMethodInfoPtr_FastToDecHex_Private_Static_UInt32_Int32_0;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeMethodInfoPtr_ToDecHex_Private_Static_UInt32_Int32_0;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeMethodInfoPtr_FastDecHexLen_Private_Static_Int32_Int32_0;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeMethodInfoPtr_DecHexLen_Private_Static_Int32_UInt32_0;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeMethodInfoPtr_DecHexLen_Private_Int32_0;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeMethodInfoPtr_ScaleOrder_Private_Static_Int32_Int64_0;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeMethodInfoPtr_InitialFloatingPrecision_Private_Int32_0;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr_ParsePrecision_Private_Static_Int32_String_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Thread_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr_InitHex_Private_Void_UInt64_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_Int32_Int32_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_UInt32_Int32_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_Int64_0;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_UInt64_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_Double_Int32_0;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_Decimal_0;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeMethodInfoPtr_ResetCharBuf_Private_Void_Int32_0;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Private_Void_Int32_0;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr_Append_Private_Void_Char_0;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_Append_Private_Void_Char_Int32_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_Append_Private_Void_String_0;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberFormatInstance_Private_NumberFormatInfo_IFormatProvider_0;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentCulture_Private_set_Void_CultureInfo_0;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeMethodInfoPtr_get_IntegerDigits_Private_get_Int32_0;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeMethodInfoPtr_get_DecimalDigits_Private_get_Int32_0;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFloatingSource_Private_get_Boolean_0;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeMethodInfoPtr_get_IsZero_Private_get_Boolean_0;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeMethodInfoPtr_get_IsZeroInteger_Private_get_Boolean_0;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeMethodInfoPtr_RoundPos_Private_Void_Int32_0;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeMethodInfoPtr_RoundDecimal_Private_Boolean_Int32_0;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeMethodInfoPtr_RoundBits_Private_Boolean_Int32_0;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrailingZeros_Private_Void_0;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeMethodInfoPtr_AddOneToDecHex_Private_Void_0;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeMethodInfoPtr_AddOneToDecHex_Private_Static_UInt32_UInt32_0;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeMethodInfoPtr_CountTrailingZeros_Private_Int32_0;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeMethodInfoPtr_CountTrailingZeros_Private_Static_Int32_UInt32_0;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Private_Static_NumberFormatter_IFormatProvider_0;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Public_Static_String_String_UInt32_IFormatProvider_0;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Int32_IFormatProvider_0;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Public_Static_String_String_UInt64_IFormatProvider_0;

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Int64_IFormatProvider_0;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Single_IFormatProvider_0;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Double_IFormatProvider_0;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Decimal_IFormatProvider_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_IntegerToString_Private_String_String_IFormatProvider_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Private_String_String_NumberFormatInfo_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr_FormatCurrency_Private_String_Int32_NumberFormatInfo_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr_FormatDecimal_Private_String_Int32_NumberFormatInfo_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_FormatHexadecimal_Private_String_Int32_0;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr_FormatFixedPoint_Private_String_Int32_NumberFormatInfo_0;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeMethodInfoPtr_FormatRoundtrip_Private_String_Double_NumberFormatInfo_0;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeMethodInfoPtr_FormatRoundtrip_Private_String_Single_NumberFormatInfo_0;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeMethodInfoPtr_FormatGeneral_Private_String_Int32_NumberFormatInfo_0;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeMethodInfoPtr_FormatNumber_Private_String_Int32_NumberFormatInfo_0;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeMethodInfoPtr_FormatPercent_Private_String_Int32_NumberFormatInfo_0;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeMethodInfoPtr_FormatExponential_Private_String_Int32_NumberFormatInfo_0;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeMethodInfoPtr_FormatExponential_Private_String_Int32_NumberFormatInfo_Int32_0;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeMethodInfoPtr_FormatCustom_Private_String_String_NumberFormatInfo_0;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeMethodInfoPtr_ZeroTrimEnd_Private_Static_Void_StringBuilder_Boolean_0;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeMethodInfoPtr_IsZeroOnly_Private_Static_Boolean_StringBuilder_0;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeMethodInfoPtr_AppendNonNegativeNumber_Private_Static_Void_StringBuilder_Int32_0;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeMethodInfoPtr_AppendIntegerString_Private_Void_Int32_StringBuilder_0;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeMethodInfoPtr_AppendIntegerString_Private_Void_Int32_0;

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeMethodInfoPtr_AppendDecimalString_Private_Void_Int32_StringBuilder_0;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeMethodInfoPtr_AppendDecimalString_Private_Void_Int32_0;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeMethodInfoPtr_AppendIntegerStringWithGroupSeparator_Private_Void_Il2CppStructArray_1_Int32_String_0;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeMethodInfoPtr_AppendExponent_Private_Void_NumberFormatInfo_Int32_Int32_0;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeMethodInfoPtr_AppendOneDigit_Private_Void_Int32_0;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeMethodInfoPtr_AppendDigits_Private_Void_Int32_Int32_0;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeMethodInfoPtr_AppendDigits_Private_Void_Int32_Int32_StringBuilder_0;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeMethodInfoPtr_Multiply10_Private_Void_Int32_0;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeMethodInfoPtr_Divide10_Private_Void_Int32_0;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeMethodInfoPtr_GetClone_Private_NumberFormatter_0;

		// Token: 0x020005AE RID: 1454
		public class CustomInfo : Object
		{
			// Token: 0x06005162 RID: 20834 RVA: 0x00170AC0 File Offset: 0x0016ECC0
			// Note: this type is marked as 'beforefieldinit'.
			static CustomInfo()
			{
				Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "CustomInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr);
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_UseGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "UseGroup");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "DecimalDigits");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalPointPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "DecimalPointPos");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalTailSharpDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "DecimalTailSharpDigits");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "IntegerDigits");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerHeadSharpDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "IntegerHeadSharpDigits");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerHeadPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "IntegerHeadPos");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_UseExponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "UseExponent");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "ExponentDigits");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentTailSharpDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "ExponentTailSharpDigits");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentNegativeSignOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "ExponentNegativeSignOnly");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_DividePlaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "DividePlaces");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_Percents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "Percents");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_Permilles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "Permilles");
				NumberFormatter.CustomInfo.NativeMethodInfoPtr_GetActiveSection_Public_Static_Void_String_byref_Boolean_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, 100667044);
				NumberFormatter.CustomInfo.NativeMethodInfoPtr_Parse_Public_Static_CustomInfo_String_Int32_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, 100667045);
				NumberFormatter.CustomInfo.NativeMethodInfoPtr_Format_Public_String_String_Int32_Int32_NumberFormatInfo_Boolean_StringBuilder_StringBuilder_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, 100667046);
				NumberFormatter.CustomInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, 100667047);
			}

			// Token: 0x06005163 RID: 20835 RVA: 0x00170C54 File Offset: 0x0016EE54
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 176155, RefRangeEnd = 176156, XrefRangeStart = 176147, XrefRangeEnd = 176155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void GetActiveSection(string format, ref bool positive, bool zero, ref int offset, ref int length)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &positive;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zero;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.CustomInfo.NativeMethodInfoPtr_GetActiveSection_Public_Static_Void_String_byref_Boolean_Boolean_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005164 RID: 20836 RVA: 0x00170CC4 File Offset: 0x0016EEC4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 176176, RefRangeEnd = 176177, XrefRangeStart = 176156, XrefRangeEnd = 176176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static NumberFormatter.CustomInfo Parse(string format, int offset, int length, NumberFormatInfo nfi)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.CustomInfo.NativeMethodInfoPtr_Parse_Public_Static_CustomInfo_String_Int32_Int32_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatter.CustomInfo>(intPtr3) : null;
			}

			// Token: 0x06005165 RID: 20837 RVA: 0x00170D38 File Offset: 0x0016EF38
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 176241, RefRangeEnd = 176242, XrefRangeStart = 176177, XrefRangeEnd = 176241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string Format(string format, int offset, int length, NumberFormatInfo nfi, bool positive, StringBuilder sb_int, StringBuilder sb_dec, StringBuilder sb_exp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positive;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb_int);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb_dec);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb_exp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.CustomInfo.NativeMethodInfoPtr_Format_Public_String_String_Int32_Int32_NumberFormatInfo_Boolean_StringBuilder_StringBuilder_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06005166 RID: 20838 RVA: 0x00170DF8 File Offset: 0x0016EFF8
			[CallerCount(0)]
			public unsafe CustomInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.CustomInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005167 RID: 20839 RVA: 0x0001E88F File Offset: 0x0001CA8F
			public CustomInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014CE RID: 5326
			// (get) Token: 0x06005168 RID: 20840 RVA: 0x00170E34 File Offset: 0x0016F034
			// (set) Token: 0x06005169 RID: 20841 RVA: 0x0001E898 File Offset: 0x0001CA98
			public unsafe bool UseGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_UseGroup);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_UseGroup)) = value;
				}
			}

			// Token: 0x170014CF RID: 5327
			// (get) Token: 0x0600516A RID: 20842 RVA: 0x00170E5C File Offset: 0x0016F05C
			// (set) Token: 0x0600516B RID: 20843 RVA: 0x0001E8B3 File Offset: 0x0001CAB3
			public unsafe int DecimalDigits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalDigits);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalDigits)) = value;
				}
			}

			// Token: 0x170014D0 RID: 5328
			// (get) Token: 0x0600516C RID: 20844 RVA: 0x00170E84 File Offset: 0x0016F084
			// (set) Token: 0x0600516D RID: 20845 RVA: 0x0001E8CE File Offset: 0x0001CACE
			public unsafe int DecimalPointPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalPointPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalPointPos)) = value;
				}
			}

			// Token: 0x170014D1 RID: 5329
			// (get) Token: 0x0600516E RID: 20846 RVA: 0x00170EAC File Offset: 0x0016F0AC
			// (set) Token: 0x0600516F RID: 20847 RVA: 0x0001E8E9 File Offset: 0x0001CAE9
			public unsafe int DecimalTailSharpDigits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalTailSharpDigits);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalTailSharpDigits)) = value;
				}
			}

			// Token: 0x170014D2 RID: 5330
			// (get) Token: 0x06005170 RID: 20848 RVA: 0x00170ED4 File Offset: 0x0016F0D4
			// (set) Token: 0x06005171 RID: 20849 RVA: 0x0001E904 File Offset: 0x0001CB04
			public unsafe int IntegerDigits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerDigits);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerDigits)) = value;
				}
			}

			// Token: 0x170014D3 RID: 5331
			// (get) Token: 0x06005172 RID: 20850 RVA: 0x00170EFC File Offset: 0x0016F0FC
			// (set) Token: 0x06005173 RID: 20851 RVA: 0x0001E91F File Offset: 0x0001CB1F
			public unsafe int IntegerHeadSharpDigits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerHeadSharpDigits);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerHeadSharpDigits)) = value;
				}
			}

			// Token: 0x170014D4 RID: 5332
			// (get) Token: 0x06005174 RID: 20852 RVA: 0x00170F24 File Offset: 0x0016F124
			// (set) Token: 0x06005175 RID: 20853 RVA: 0x0001E93A File Offset: 0x0001CB3A
			public unsafe int IntegerHeadPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerHeadPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerHeadPos)) = value;
				}
			}

			// Token: 0x170014D5 RID: 5333
			// (get) Token: 0x06005176 RID: 20854 RVA: 0x00170F4C File Offset: 0x0016F14C
			// (set) Token: 0x06005177 RID: 20855 RVA: 0x0001E955 File Offset: 0x0001CB55
			public unsafe bool UseExponent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_UseExponent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_UseExponent)) = value;
				}
			}

			// Token: 0x170014D6 RID: 5334
			// (get) Token: 0x06005178 RID: 20856 RVA: 0x00170F74 File Offset: 0x0016F174
			// (set) Token: 0x06005179 RID: 20857 RVA: 0x0001E970 File Offset: 0x0001CB70
			public unsafe int ExponentDigits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentDigits);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentDigits)) = value;
				}
			}

			// Token: 0x170014D7 RID: 5335
			// (get) Token: 0x0600517A RID: 20858 RVA: 0x00170F9C File Offset: 0x0016F19C
			// (set) Token: 0x0600517B RID: 20859 RVA: 0x0001E98B File Offset: 0x0001CB8B
			public unsafe int ExponentTailSharpDigits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentTailSharpDigits);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentTailSharpDigits)) = value;
				}
			}

			// Token: 0x170014D8 RID: 5336
			// (get) Token: 0x0600517C RID: 20860 RVA: 0x00170FC4 File Offset: 0x0016F1C4
			// (set) Token: 0x0600517D RID: 20861 RVA: 0x0001E9A6 File Offset: 0x0001CBA6
			public unsafe bool ExponentNegativeSignOnly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentNegativeSignOnly);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentNegativeSignOnly)) = value;
				}
			}

			// Token: 0x170014D9 RID: 5337
			// (get) Token: 0x0600517E RID: 20862 RVA: 0x00170FEC File Offset: 0x0016F1EC
			// (set) Token: 0x0600517F RID: 20863 RVA: 0x0001E9C1 File Offset: 0x0001CBC1
			public unsafe int DividePlaces
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_DividePlaces);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_DividePlaces)) = value;
				}
			}

			// Token: 0x170014DA RID: 5338
			// (get) Token: 0x06005180 RID: 20864 RVA: 0x00171014 File Offset: 0x0016F214
			// (set) Token: 0x06005181 RID: 20865 RVA: 0x0001E9DC File Offset: 0x0001CBDC
			public unsafe int Percents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_Percents);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_Percents)) = value;
				}
			}

			// Token: 0x170014DB RID: 5339
			// (get) Token: 0x06005182 RID: 20866 RVA: 0x0017103C File Offset: 0x0016F23C
			// (set) Token: 0x06005183 RID: 20867 RVA: 0x0001E9F7 File Offset: 0x0001CBF7
			public unsafe int Permilles
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_Permilles);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_Permilles)) = value;
				}
			}

			// Token: 0x0400423E RID: 16958
			private static readonly IntPtr NativeFieldInfoPtr_UseGroup;

			// Token: 0x0400423F RID: 16959
			private static readonly IntPtr NativeFieldInfoPtr_DecimalDigits;

			// Token: 0x04004240 RID: 16960
			private static readonly IntPtr NativeFieldInfoPtr_DecimalPointPos;

			// Token: 0x04004241 RID: 16961
			private static readonly IntPtr NativeFieldInfoPtr_DecimalTailSharpDigits;

			// Token: 0x04004242 RID: 16962
			private static readonly IntPtr NativeFieldInfoPtr_IntegerDigits;

			// Token: 0x04004243 RID: 16963
			private static readonly IntPtr NativeFieldInfoPtr_IntegerHeadSharpDigits;

			// Token: 0x04004244 RID: 16964
			private static readonly IntPtr NativeFieldInfoPtr_IntegerHeadPos;

			// Token: 0x04004245 RID: 16965
			private static readonly IntPtr NativeFieldInfoPtr_UseExponent;

			// Token: 0x04004246 RID: 16966
			private static readonly IntPtr NativeFieldInfoPtr_ExponentDigits;

			// Token: 0x04004247 RID: 16967
			private static readonly IntPtr NativeFieldInfoPtr_ExponentTailSharpDigits;

			// Token: 0x04004248 RID: 16968
			private static readonly IntPtr NativeFieldInfoPtr_ExponentNegativeSignOnly;

			// Token: 0x04004249 RID: 16969
			private static readonly IntPtr NativeFieldInfoPtr_DividePlaces;

			// Token: 0x0400424A RID: 16970
			private static readonly IntPtr NativeFieldInfoPtr_Percents;

			// Token: 0x0400424B RID: 16971
			private static readonly IntPtr NativeFieldInfoPtr_Permilles;

			// Token: 0x0400424C RID: 16972
			private static readonly IntPtr NativeMethodInfoPtr_GetActiveSection_Public_Static_Void_String_byref_Boolean_Boolean_byref_Int32_byref_Int32_0;

			// Token: 0x0400424D RID: 16973
			private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_CustomInfo_String_Int32_Int32_NumberFormatInfo_0;

			// Token: 0x0400424E RID: 16974
			private static readonly IntPtr NativeMethodInfoPtr_Format_Public_String_String_Int32_Int32_NumberFormatInfo_Boolean_StringBuilder_StringBuilder_StringBuilder_0;

			// Token: 0x0400424F RID: 16975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
