using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text.RegularExpressions;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000098 RID: 152
	public class XmlConvert : Object
	{
		// Token: 0x06000F40 RID: 3904 RVA: 0x000558F4 File Offset: 0x00053AF4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlConvert()
		{
			Il2CppClassPointerStore<XmlConvert>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlConvert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr);
			XmlConvert.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "xmlCharType");
			XmlConvert.NativeFieldInfoPtr_crt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "crt");
			XmlConvert.NativeFieldInfoPtr_c_EncodedCharLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "c_EncodedCharLength");
			XmlConvert.NativeFieldInfoPtr_c_EncodeCharPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "c_EncodeCharPattern");
			XmlConvert.NativeFieldInfoPtr_WhitespaceChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "WhitespaceChars");
			XmlConvert.NativeMethodInfoPtr_EncodeName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665720);
			XmlConvert.NativeMethodInfoPtr_EncodeLocalName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665721);
			XmlConvert.NativeMethodInfoPtr_EncodeName_Private_Static_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665722);
			XmlConvert.NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665723);
			XmlConvert.NativeMethodInfoPtr_ToBinHexString_Internal_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665724);
			XmlConvert.NativeMethodInfoPtr_VerifyName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665725);
			XmlConvert.NativeMethodInfoPtr_TryVerifyName_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665726);
			XmlConvert.NativeMethodInfoPtr_VerifyQName_Internal_Static_String_String_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665727);
			XmlConvert.NativeMethodInfoPtr_VerifyNCName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665728);
			XmlConvert.NativeMethodInfoPtr_VerifyNCName_Internal_Static_String_String_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665729);
			XmlConvert.NativeMethodInfoPtr_TryVerifyNCName_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665730);
			XmlConvert.NativeMethodInfoPtr_VerifyTOKEN_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665731);
			XmlConvert.NativeMethodInfoPtr_TryVerifyTOKEN_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665732);
			XmlConvert.NativeMethodInfoPtr_TryVerifyNMTOKEN_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665733);
			XmlConvert.NativeMethodInfoPtr_TryVerifyNormalizedString_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665734);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665735);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665736);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665737);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665738);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665739);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665740);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665741);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665742);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665743);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665744);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665745);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665746);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_XmlDateTimeSerializationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665747);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665748);
			XmlConvert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665749);
			XmlConvert.NativeMethodInfoPtr_TryToBoolean_Internal_Static_Exception_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665750);
			XmlConvert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665751);
			XmlConvert.NativeMethodInfoPtr_TryToChar_Internal_Static_Exception_String_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665752);
			XmlConvert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665753);
			XmlConvert.NativeMethodInfoPtr_TryToDecimal_Internal_Static_Exception_String_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665754);
			XmlConvert.NativeMethodInfoPtr_ToInteger_Internal_Static_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665755);
			XmlConvert.NativeMethodInfoPtr_TryToInteger_Internal_Static_Exception_String_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665756);
			XmlConvert.NativeMethodInfoPtr_TryToSByte_Internal_Static_Exception_String_byref_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665757);
			XmlConvert.NativeMethodInfoPtr_TryToInt16_Internal_Static_Exception_String_byref_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665758);
			XmlConvert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665759);
			XmlConvert.NativeMethodInfoPtr_TryToInt32_Internal_Static_Exception_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665760);
			XmlConvert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665761);
			XmlConvert.NativeMethodInfoPtr_TryToInt64_Internal_Static_Exception_String_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665762);
			XmlConvert.NativeMethodInfoPtr_TryToByte_Internal_Static_Exception_String_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665763);
			XmlConvert.NativeMethodInfoPtr_TryToUInt16_Internal_Static_Exception_String_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665764);
			XmlConvert.NativeMethodInfoPtr_TryToUInt32_Internal_Static_Exception_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665765);
			XmlConvert.NativeMethodInfoPtr_TryToUInt64_Internal_Static_Exception_String_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665766);
			XmlConvert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665767);
			XmlConvert.NativeMethodInfoPtr_TryToSingle_Internal_Static_Exception_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665768);
			XmlConvert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665769);
			XmlConvert.NativeMethodInfoPtr_TryToDouble_Internal_Static_Exception_String_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665770);
			XmlConvert.NativeMethodInfoPtr_ToXPathDouble_Internal_Static_Double_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665771);
			XmlConvert.NativeMethodInfoPtr_TryToTimeSpan_Internal_Static_Exception_String_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665772);
			XmlConvert.NativeMethodInfoPtr_ToGuid_Public_Static_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665773);
			XmlConvert.NativeMethodInfoPtr_TryToGuid_Internal_Static_Exception_String_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665774);
			XmlConvert.NativeMethodInfoPtr_SwitchToLocalTime_Private_Static_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665775);
			XmlConvert.NativeMethodInfoPtr_SwitchToUtcTime_Private_Static_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665776);
			XmlConvert.NativeMethodInfoPtr_ToUri_Internal_Static_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665777);
			XmlConvert.NativeMethodInfoPtr_TryToUri_Internal_Static_Exception_String_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665778);
			XmlConvert.NativeMethodInfoPtr_StrEqual_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665779);
			XmlConvert.NativeMethodInfoPtr_TrimString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665780);
			XmlConvert.NativeMethodInfoPtr_TrimStringStart_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665781);
			XmlConvert.NativeMethodInfoPtr_TrimStringEnd_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665782);
			XmlConvert.NativeMethodInfoPtr_SplitString_Internal_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665783);
			XmlConvert.NativeMethodInfoPtr_IsNegativeZero_Internal_Static_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665784);
			XmlConvert.NativeMethodInfoPtr_DoubleToInt64Bits_Private_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665785);
			XmlConvert.NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_String_ExceptionType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665786);
			XmlConvert.NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665787);
			XmlConvert.NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665788);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665789);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665790);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665791);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665792);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665793);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665794);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidCharException_Internal_Static_Exception_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665795);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidCharException_Internal_Static_Exception_Char_Char_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665796);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidNameCharException_Internal_Static_Exception_String_Int32_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665797);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidNameArgumentException_Internal_Static_ArgumentException_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665798);
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00055FB4 File Offset: 0x000541B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401095, RefRangeEnd = 401096, XrefRangeStart = 401091, XrefRangeEnd = 401095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncodeName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_EncodeName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00055FF0 File Offset: 0x000541F0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 401100, RefRangeEnd = 401108, XrefRangeStart = 401096, XrefRangeEnd = 401100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncodeLocalName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_EncodeLocalName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0005602C File Offset: 0x0005422C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 401219, RefRangeEnd = 401223, XrefRangeStart = 401108, XrefRangeEnd = 401219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncodeName(string name, bool first, bool local)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref local;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_EncodeName_Private_Static_String_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00056084 File Offset: 0x00054284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401223, XrefRangeEnd = 401231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromBinHexString(string s, bool allowOddCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowOddCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x000560D8 File Offset: 0x000542D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401236, RefRangeEnd = 401237, XrefRangeStart = 401231, XrefRangeEnd = 401236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToBinHexString(Il2CppStructArray<byte> inArray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToBinHexString_Internal_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00056114 File Offset: 0x00054314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401237, XrefRangeEnd = 401241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string VerifyName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_VerifyName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00056150 File Offset: 0x00054350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401241, XrefRangeEnd = 401250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryVerifyName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryVerifyName_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00056194 File Offset: 0x00054394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401250, XrefRangeEnd = 401254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string VerifyQName(string name, ExceptionType exceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_VerifyQName_Internal_Static_String_String_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x000561E0 File Offset: 0x000543E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 401261, RefRangeEnd = 401265, XrefRangeStart = 401254, XrefRangeEnd = 401261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string VerifyNCName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_VerifyNCName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0005621C File Offset: 0x0005441C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401265, XrefRangeEnd = 401269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string VerifyNCName(string name, ExceptionType exceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_VerifyNCName_Internal_Static_String_String_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00056268 File Offset: 0x00054468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401269, XrefRangeEnd = 401277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryVerifyNCName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryVerifyNCName_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x000562AC File Offset: 0x000544AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 401290, RefRangeEnd = 401292, XrefRangeStart = 401277, XrefRangeEnd = 401290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string VerifyTOKEN(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_VerifyTOKEN_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x000562E8 File Offset: 0x000544E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401307, RefRangeEnd = 401308, XrefRangeStart = 401292, XrefRangeEnd = 401307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryVerifyTOKEN(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryVerifyTOKEN_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0005632C File Offset: 0x0005452C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401324, RefRangeEnd = 401325, XrefRangeStart = 401308, XrefRangeEnd = 401324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryVerifyNMTOKEN(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryVerifyNMTOKEN_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00056370 File Offset: 0x00054570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401325, XrefRangeEnd = 401332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryVerifyNormalizedString(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryVerifyNormalizedString_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x000563B4 File Offset: 0x000545B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401332, XrefRangeEnd = 401336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x000563EC File Offset: 0x000545EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401336, XrefRangeEnd = 401339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00056424 File Offset: 0x00054624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401339, XrefRangeEnd = 401342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0005645C File Offset: 0x0005465C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401342, XrefRangeEnd = 401345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00056494 File Offset: 0x00054694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401345, XrefRangeEnd = 401348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x000564CC File Offset: 0x000546CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401351, RefRangeEnd = 401352, XrefRangeStart = 401348, XrefRangeEnd = 401351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00056504 File Offset: 0x00054704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401352, XrefRangeEnd = 401355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0005653C File Offset: 0x0005473C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401355, XrefRangeEnd = 401358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00056574 File Offset: 0x00054774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401358, XrefRangeEnd = 401361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x000565AC File Offset: 0x000547AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401361, XrefRangeEnd = 401364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x000565E4 File Offset: 0x000547E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 401377, RefRangeEnd = 401381, XrefRangeStart = 401364, XrefRangeEnd = 401377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0005661C File Offset: 0x0005481C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 401391, RefRangeEnd = 401395, XrefRangeStart = 401381, XrefRangeEnd = 401391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00056654 File Offset: 0x00054854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401395, XrefRangeEnd = 401412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTimeOption;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_XmlDateTimeSerializationMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0005669C File Offset: 0x0005489C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401412, XrefRangeEnd = 401415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Guid value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x000566D4 File Offset: 0x000548D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 401432, RefRangeEnd = 401439, XrefRangeStart = 401415, XrefRangeEnd = 401432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00056718 File Offset: 0x00054918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401473, RefRangeEnd = 401474, XrefRangeStart = 401439, XrefRangeEnd = 401473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToBoolean(string s, out bool result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToBoolean_Internal_Static_Exception_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x0005676C File Offset: 0x0005496C
		[CallerCount(0)]
		public unsafe static char ToChar(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x000567B0 File Offset: 0x000549B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401474, XrefRangeEnd = 401481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToChar(string s, out char result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToChar_Internal_Static_Exception_String_byref_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00056804 File Offset: 0x00054A04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 401487, RefRangeEnd = 401492, XrefRangeStart = 401481, XrefRangeEnd = 401487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00056848 File Offset: 0x00054A48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 401502, RefRangeEnd = 401504, XrefRangeStart = 401492, XrefRangeEnd = 401502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToDecimal(string s, out Decimal result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToDecimal_Internal_Static_Exception_String_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x0005689C File Offset: 0x00054A9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 401510, RefRangeEnd = 401512, XrefRangeStart = 401504, XrefRangeEnd = 401510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToInteger(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToInteger_Internal_Static_Decimal_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x000568E0 File Offset: 0x00054AE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401522, RefRangeEnd = 401523, XrefRangeStart = 401512, XrefRangeEnd = 401522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToInteger(string s, out Decimal result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToInteger_Internal_Static_Exception_String_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00056934 File Offset: 0x00054B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401523, XrefRangeEnd = 401530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToSByte(string s, out sbyte result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToSByte_Internal_Static_Exception_String_byref_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00056988 File Offset: 0x00054B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401530, XrefRangeEnd = 401537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToInt16(string s, out short result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToInt16_Internal_Static_Exception_String_byref_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x000569DC File Offset: 0x00054BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401537, XrefRangeEnd = 401540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00056A20 File Offset: 0x00054C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401540, XrefRangeEnd = 401547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToInt32(string s, out int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToInt32_Internal_Static_Exception_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00056A74 File Offset: 0x00054C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401547, XrefRangeEnd = 401550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00056AB8 File Offset: 0x00054CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401550, XrefRangeEnd = 401557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToInt64(string s, out long result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToInt64_Internal_Static_Exception_String_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00056B0C File Offset: 0x00054D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401557, XrefRangeEnd = 401563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToByte(string s, out byte result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToByte_Internal_Static_Exception_String_byref_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00056B60 File Offset: 0x00054D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401563, XrefRangeEnd = 401569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToUInt16(string s, out ushort result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToUInt16_Internal_Static_Exception_String_byref_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00056BB4 File Offset: 0x00054DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401569, XrefRangeEnd = 401576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToUInt32(string s, out uint result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToUInt32_Internal_Static_Exception_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00056C08 File Offset: 0x00054E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401576, XrefRangeEnd = 401583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToUInt64(string s, out ulong result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToUInt64_Internal_Static_Exception_String_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00056C5C File Offset: 0x00054E5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 401599, RefRangeEnd = 401603, XrefRangeStart = 401583, XrefRangeEnd = 401599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00056CA0 File Offset: 0x00054EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401623, RefRangeEnd = 401624, XrefRangeStart = 401603, XrefRangeEnd = 401623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToSingle(string s, out float result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToSingle_Internal_Static_Exception_String_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00056CF4 File Offset: 0x00054EF4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 401642, RefRangeEnd = 401647, XrefRangeStart = 401624, XrefRangeEnd = 401642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00056D38 File Offset: 0x00054F38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401669, RefRangeEnd = 401670, XrefRangeStart = 401647, XrefRangeEnd = 401669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToDouble(string s, out double result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToDouble_Internal_Static_Exception_String_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00056D8C File Offset: 0x00054F8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 401677, RefRangeEnd = 401679, XrefRangeStart = 401670, XrefRangeEnd = 401677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToXPathDouble(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToXPathDouble_Internal_Static_Double_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00056DD0 File Offset: 0x00054FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401679, XrefRangeEnd = 401682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToTimeSpan(string s, out TimeSpan result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToTimeSpan_Internal_Static_Exception_String_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00056E24 File Offset: 0x00055024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401682, XrefRangeEnd = 401683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid ToGuid(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToGuid_Public_Static_Guid_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00056E68 File Offset: 0x00055068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401709, RefRangeEnd = 401710, XrefRangeStart = 401683, XrefRangeEnd = 401709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToGuid(string s, out Guid result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToGuid_Internal_Static_Exception_String_byref_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00056EBC File Offset: 0x000550BC
		[CallerCount(0)]
		public unsafe static DateTime SwitchToLocalTime(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_SwitchToLocalTime_Private_Static_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00056EFC File Offset: 0x000550FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401710, XrefRangeEnd = 401712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime SwitchToUtcTime(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_SwitchToUtcTime_Private_Static_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00056F3C File Offset: 0x0005513C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 401732, RefRangeEnd = 401745, XrefRangeStart = 401712, XrefRangeEnd = 401732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Uri ToUri(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToUri_Internal_Static_Uri_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00056F80 File Offset: 0x00055180
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 401769, RefRangeEnd = 401771, XrefRangeStart = 401745, XrefRangeEnd = 401769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToUri(string s, out Uri result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToUri_Internal_Static_Exception_String_byref_Uri_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Uri(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr5) : null;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00056FE8 File Offset: 0x000551E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 401771, RefRangeEnd = 401777, XrefRangeStart = 401771, XrefRangeEnd = 401771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StrEqual(Il2CppStructArray<char> chars, int strPos1, int strLen1, string str2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strPos1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strLen1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_StrEqual_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00057058 File Offset: 0x00055258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401777, XrefRangeEnd = 401783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TrimString(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TrimString_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00057094 File Offset: 0x00055294
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401794, RefRangeEnd = 401795, XrefRangeStart = 401783, XrefRangeEnd = 401794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TrimStringStart(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TrimStringStart_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x000570D0 File Offset: 0x000552D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401801, RefRangeEnd = 401802, XrefRangeStart = 401795, XrefRangeEnd = 401801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TrimStringEnd(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TrimStringEnd_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x0005710C File Offset: 0x0005530C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401807, RefRangeEnd = 401808, XrefRangeStart = 401802, XrefRangeEnd = 401807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray SplitString(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_SplitString_Internal_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00057150 File Offset: 0x00055350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401811, RefRangeEnd = 401812, XrefRangeStart = 401808, XrefRangeEnd = 401811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNegativeZero(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_IsNegativeZero_Internal_Static_Boolean_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00057190 File Offset: 0x00055390
		[CallerCount(0)]
		public unsafe static long DoubleToInt64Bits(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_DoubleToInt64Bits_Private_Static_Int64_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x000571D0 File Offset: 0x000553D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401812, XrefRangeEnd = 401827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_String_ExceptionType_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00057250 File Offset: 0x00055450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401827, XrefRangeEnd = 401831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateException(string res, Il2CppStringArray args, ExceptionType exceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x000572B4 File Offset: 0x000554B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 401841, RefRangeEnd = 401845, XrefRangeStart = 401831, XrefRangeEnd = 401841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateException(string res, Il2CppStringArray args, ExceptionType exceptionType, int lineNo, int linePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00057334 File Offset: 0x00055534
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 401853, RefRangeEnd = 401855, XrefRangeStart = 401845, XrefRangeEnd = 401853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidSurrogatePairException(char low, char hi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref low;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00057384 File Offset: 0x00055584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401855, XrefRangeEnd = 401859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref low;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x000573E0 File Offset: 0x000555E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 401896, RefRangeEnd = 401898, XrefRangeStart = 401859, XrefRangeEnd = 401896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref low;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00057458 File Offset: 0x00055658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401898, XrefRangeEnd = 401906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidHighSurrogateCharException(char hi)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00057498 File Offset: 0x00055698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401906, XrefRangeEnd = 401910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hi;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x000574E8 File Offset: 0x000556E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 401942, RefRangeEnd = 401944, XrefRangeStart = 401910, XrefRangeEnd = 401942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hi;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00057554 File Offset: 0x00055754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401944, XrefRangeEnd = 401963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidCharException(char invChar, char nextChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref invChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidCharException_Internal_Static_Exception_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x000575A4 File Offset: 0x000557A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401963, XrefRangeEnd = 401974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref invChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidCharException_Internal_Static_Exception_Char_Char_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00057600 File Offset: 0x00055800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401974, XrefRangeEnd = 401983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidNameCharException_Internal_Static_Exception_String_Int32_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00057660 File Offset: 0x00055860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401983, XrefRangeEnd = 401991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(argumentName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidNameArgumentException_Internal_Static_ArgumentException_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentException>(intPtr3) : null;
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00007282 File Offset: 0x00005482
		public XmlConvert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x000576B8 File Offset: 0x000558B8
		// (set) Token: 0x06000F92 RID: 3986 RVA: 0x0000728B File Offset: 0x0000548B
		public unsafe static XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(XmlConvert.NativeFieldInfoPtr_xmlCharType, intPtr);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlConvert.NativeFieldInfoPtr_xmlCharType, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x000576F4 File Offset: 0x000558F4
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x000072A2 File Offset: 0x000054A2
		public unsafe static Il2CppStructArray<char> crt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlConvert.NativeFieldInfoPtr_crt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlConvert.NativeFieldInfoPtr_crt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x0005771C File Offset: 0x0005591C
		// (set) Token: 0x06000F96 RID: 3990 RVA: 0x000072B4 File Offset: 0x000054B4
		public unsafe static int c_EncodedCharLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XmlConvert.NativeFieldInfoPtr_c_EncodedCharLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlConvert.NativeFieldInfoPtr_c_EncodedCharLength, (void*)(&value));
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x00057738 File Offset: 0x00055938
		// (set) Token: 0x06000F98 RID: 3992 RVA: 0x000072C2 File Offset: 0x000054C2
		public unsafe static Regex c_EncodeCharPattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlConvert.NativeFieldInfoPtr_c_EncodeCharPattern, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlConvert.NativeFieldInfoPtr_c_EncodeCharPattern, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x00057760 File Offset: 0x00055960
		// (set) Token: 0x06000F9A RID: 3994 RVA: 0x000072D4 File Offset: 0x000054D4
		public unsafe static Il2CppStructArray<char> WhitespaceChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlConvert.NativeFieldInfoPtr_WhitespaceChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlConvert.NativeFieldInfoPtr_WhitespaceChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeFieldInfoPtr_crt;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeFieldInfoPtr_c_EncodedCharLength;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeFieldInfoPtr_c_EncodeCharPattern;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeFieldInfoPtr_WhitespaceChars;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr_EncodeName_Public_Static_String_String_0;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr_EncodeLocalName_Public_Static_String_String_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_EncodeName_Private_Static_String_String_Boolean_Boolean_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_Boolean_0;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_ToBinHexString_Internal_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr_VerifyName_Public_Static_String_String_0;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeMethodInfoPtr_TryVerifyName_Internal_Static_Exception_String_0;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeMethodInfoPtr_VerifyQName_Internal_Static_String_String_ExceptionType_0;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeMethodInfoPtr_VerifyNCName_Public_Static_String_String_0;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeMethodInfoPtr_VerifyNCName_Internal_Static_String_String_ExceptionType_0;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeMethodInfoPtr_TryVerifyNCName_Internal_Static_Exception_String_0;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr_VerifyTOKEN_Public_Static_String_String_0;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeMethodInfoPtr_TryVerifyTOKEN_Internal_Static_Exception_String_0;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr_TryVerifyNMTOKEN_Internal_Static_Exception_String_0;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr_TryVerifyNormalizedString_Internal_Static_Exception_String_0;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Boolean_0;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Decimal_0;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_SByte_0;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int16_0;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Byte_0;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_0;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt64_0;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Single_0;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Double_0;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_XmlDateTimeSerializationMode_0;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Guid_0;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr_TryToBoolean_Internal_Static_Exception_String_byref_Boolean_0;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr_TryToChar_Internal_Static_Exception_String_byref_Char_0;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_0;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr_TryToDecimal_Internal_Static_Exception_String_byref_Decimal_0;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeMethodInfoPtr_ToInteger_Internal_Static_Decimal_String_0;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr_TryToInteger_Internal_Static_Exception_String_byref_Decimal_0;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr_TryToSByte_Internal_Static_Exception_String_byref_SByte_0;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_TryToInt16_Internal_Static_Exception_String_byref_Int16_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr_TryToInt32_Internal_Static_Exception_String_byref_Int32_0;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr_TryToInt64_Internal_Static_Exception_String_byref_Int64_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr_TryToByte_Internal_Static_Exception_String_byref_Byte_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_TryToUInt16_Internal_Static_Exception_String_byref_UInt16_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr_TryToUInt32_Internal_Static_Exception_String_byref_UInt32_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_TryToUInt64_Internal_Static_Exception_String_byref_UInt64_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_TryToSingle_Internal_Static_Exception_String_byref_Single_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_0;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_TryToDouble_Internal_Static_Exception_String_byref_Double_0;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr_ToXPathDouble_Internal_Static_Double_Object_0;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr_TryToTimeSpan_Internal_Static_Exception_String_byref_TimeSpan_0;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr_ToGuid_Public_Static_Guid_String_0;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr_TryToGuid_Internal_Static_Exception_String_byref_Guid_0;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeMethodInfoPtr_SwitchToLocalTime_Private_Static_DateTime_DateTime_0;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeMethodInfoPtr_SwitchToUtcTime_Private_Static_DateTime_DateTime_0;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeMethodInfoPtr_ToUri_Internal_Static_Uri_String_0;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr_TryToUri_Internal_Static_Exception_String_byref_Uri_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_StrEqual_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_Int32_String_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_TrimString_Internal_Static_String_String_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_TrimStringStart_Internal_Static_String_String_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_TrimStringEnd_Internal_Static_String_String_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr_SplitString_Internal_Static_Il2CppStringArray_String_0;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr_IsNegativeZero_Internal_Static_Boolean_Double_0;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr_DoubleToInt64Bits_Private_Static_Int64_Double_0;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_String_ExceptionType_Int32_Int32_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_0;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_Int32_Int32_0;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_0;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_Int32_Int32_0;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_Int32_Int32_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidCharException_Internal_Static_Exception_Char_Char_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidCharException_Internal_Static_Exception_Char_Char_ExceptionType_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidNameCharException_Internal_Static_Exception_String_Int32_ExceptionType_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidNameArgumentException_Internal_Static_ArgumentException_String_String_0;
	}
}
