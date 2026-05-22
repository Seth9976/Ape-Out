using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x020000D5 RID: 213
	public class Number : Object
	{
		// Token: 0x06000E47 RID: 3655 RVA: 0x0006484C File Offset: 0x00062A4C
		// Note: this type is marked as 'beforefieldinit'.
		static Number()
		{
			Il2CppClassPointerStore<Number>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Number");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Number>.NativeClassPtr);
			Number.NativeMethodInfoPtr_NumberBufferToDecimal_Public_Static_Boolean_ptr_Byte_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665719);
			Number.NativeMethodInfoPtr_NumberBufferToDouble_Internal_Static_Boolean_ptr_Byte_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665720);
			Number.NativeMethodInfoPtr_FormatDecimal_Public_Static_String_Decimal_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665721);
			Number.NativeMethodInfoPtr_FormatDouble_Public_Static_String_Double_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665722);
			Number.NativeMethodInfoPtr_FormatInt32_Public_Static_String_Int32_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665723);
			Number.NativeMethodInfoPtr_FormatUInt32_Public_Static_String_UInt32_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665724);
			Number.NativeMethodInfoPtr_FormatInt64_Public_Static_String_Int64_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665725);
			Number.NativeMethodInfoPtr_FormatUInt64_Public_Static_String_UInt64_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665726);
			Number.NativeMethodInfoPtr_FormatSingle_Public_Static_String_Single_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665727);
			Number.NativeMethodInfoPtr_HexNumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665728);
			Number.NativeMethodInfoPtr_HexNumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665729);
			Number.NativeMethodInfoPtr_HexNumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665730);
			Number.NativeMethodInfoPtr_HexNumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665731);
			Number.NativeMethodInfoPtr_IsWhite_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665732);
			Number.NativeMethodInfoPtr_NumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665733);
			Number.NativeMethodInfoPtr_NumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665734);
			Number.NativeMethodInfoPtr_NumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665735);
			Number.NativeMethodInfoPtr_NumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665736);
			Number.NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665737);
			Number.NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665738);
			Number.NativeMethodInfoPtr_ParseDecimal_Internal_Static_Decimal_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665739);
			Number.NativeMethodInfoPtr_ParseDouble_Internal_Static_Double_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665740);
			Number.NativeMethodInfoPtr_ParseInt32_Internal_Static_Int32_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665741);
			Number.NativeMethodInfoPtr_ParseInt64_Internal_Static_Int64_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665742);
			Number.NativeMethodInfoPtr_ParseNumber_Private_Static_Boolean_byref_ptr_Char_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665743);
			Number.NativeMethodInfoPtr_ParseSingle_Internal_Static_Single_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665744);
			Number.NativeMethodInfoPtr_ParseUInt32_Internal_Static_UInt32_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665745);
			Number.NativeMethodInfoPtr_ParseUInt64_Internal_Static_UInt64_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665746);
			Number.NativeMethodInfoPtr_StringToNumber_Private_Static_Void_String_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665747);
			Number.NativeMethodInfoPtr_TrailingZeros_Private_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665748);
			Number.NativeMethodInfoPtr_TryParseDecimal_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665749);
			Number.NativeMethodInfoPtr_TryParseDouble_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665750);
			Number.NativeMethodInfoPtr_TryParseInt32_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665751);
			Number.NativeMethodInfoPtr_TryParseInt64_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665752);
			Number.NativeMethodInfoPtr_TryParseSingle_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665753);
			Number.NativeMethodInfoPtr_TryParseUInt32_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665754);
			Number.NativeMethodInfoPtr_TryParseUInt64_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665755);
			Number.NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_String_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665756);
			Number.NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_String_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665757);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00064B88 File Offset: 0x00062D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160039, XrefRangeEnd = 160040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NumberBufferToDecimal(byte* number, ref Decimal value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberBufferToDecimal_Public_Static_Boolean_ptr_Byte_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00064BD4 File Offset: 0x00062DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160040, XrefRangeEnd = 160041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NumberBufferToDouble(byte* number, ref double value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberBufferToDouble_Internal_Static_Boolean_ptr_Byte_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00064C20 File Offset: 0x00062E20
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 160053, RefRangeEnd = 160069, XrefRangeStart = 160041, XrefRangeEnd = 160053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatDecimal(Decimal value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatDecimal_Public_Static_String_Decimal_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00064C7C File Offset: 0x00062E7C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 160073, RefRangeEnd = 160086, XrefRangeStart = 160069, XrefRangeEnd = 160073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatDouble(double value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatDouble_Public_Static_String_Double_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00064CD8 File Offset: 0x00062ED8
		[CallerCount(356)]
		[CachedScanResults(RefRangeStart = 160101, RefRangeEnd = 160457, XrefRangeStart = 160086, XrefRangeEnd = 160101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatInt32(int value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatInt32_Public_Static_String_Int32_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00064D34 File Offset: 0x00062F34
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 160472, RefRangeEnd = 160536, XrefRangeStart = 160457, XrefRangeEnd = 160472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatUInt32(uint value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatUInt32_Public_Static_String_UInt32_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00064D90 File Offset: 0x00062F90
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 160551, RefRangeEnd = 160576, XrefRangeStart = 160536, XrefRangeEnd = 160551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatInt64(long value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatInt64_Public_Static_String_Int64_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00064DEC File Offset: 0x00062FEC
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 160591, RefRangeEnd = 160632, XrefRangeStart = 160576, XrefRangeEnd = 160591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatUInt64(ulong value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatUInt64_Public_Static_String_UInt64_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00064E48 File Offset: 0x00063048
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 160636, RefRangeEnd = 160700, XrefRangeStart = 160632, XrefRangeEnd = 160636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatSingle(float value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatSingle_Public_Static_String_Single_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00064EA4 File Offset: 0x000630A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160700, XrefRangeEnd = 160702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HexNumberToInt32(ref Number.NumberBuffer number, ref int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_HexNumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00064EF0 File Offset: 0x000630F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160702, XrefRangeEnd = 160703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HexNumberToInt64(ref Number.NumberBuffer number, ref long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_HexNumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00064F3C File Offset: 0x0006313C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160703, XrefRangeEnd = 160704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HexNumberToUInt32(ref Number.NumberBuffer number, ref uint value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_HexNumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00064F88 File Offset: 0x00063188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160704, XrefRangeEnd = 160705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HexNumberToUInt64(ref Number.NumberBuffer number, ref ulong value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_HexNumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00064FD4 File Offset: 0x000631D4
		[CallerCount(0)]
		public unsafe static bool IsWhite(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_IsWhite_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00065014 File Offset: 0x00063214
		[CallerCount(0)]
		public unsafe static bool NumberToInt32(ref Number.NumberBuffer number, ref int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00065060 File Offset: 0x00063260
		[CallerCount(0)]
		public unsafe static bool NumberToInt64(ref Number.NumberBuffer number, ref long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x000650AC File Offset: 0x000632AC
		[CallerCount(0)]
		public unsafe static bool NumberToUInt32(ref Number.NumberBuffer number, ref uint value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x000650F8 File Offset: 0x000632F8
		[CallerCount(0)]
		public unsafe static bool NumberToUInt64(ref Number.NumberBuffer number, ref ulong value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00065144 File Offset: 0x00063344
		[CallerCount(0)]
		public unsafe static char* MatchChars(char* p, string str)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00065188 File Offset: 0x00063388
		[CallerCount(0)]
		public unsafe static char* MatchChars(char* p, char* str)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = str;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000651C8 File Offset: 0x000633C8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 160715, RefRangeEnd = 160726, XrefRangeStart = 160705, XrefRangeEnd = 160715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseDecimal_Internal_Static_Decimal_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0006522C File Offset: 0x0006342C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 160736, RefRangeEnd = 160740, XrefRangeStart = 160726, XrefRangeEnd = 160736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseDouble_Internal_Static_Double_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00065290 File Offset: 0x00063490
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 160752, RefRangeEnd = 160788, XrefRangeStart = 160740, XrefRangeEnd = 160752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseInt32(string s, NumberStyles style, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseInt32_Internal_Static_Int32_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x000652F4 File Offset: 0x000634F4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 160800, RefRangeEnd = 160813, XrefRangeStart = 160788, XrefRangeEnd = 160800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ParseInt64(string value, NumberStyles options, NumberFormatInfo numfmt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseInt64_Internal_Static_Int64_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00065358 File Offset: 0x00063558
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 160835, RefRangeEnd = 160852, XrefRangeStart = 160813, XrefRangeEnd = 160835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseNumber(ref char* str, NumberStyles options, ref Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(str);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseDecimal;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseNumber_Private_Static_Boolean_byref_ptr_Char_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			str = ((intPtr4 == 0) ? null : new char*(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00065400 File Offset: 0x00063600
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 160864, RefRangeEnd = 160872, XrefRangeStart = 160852, XrefRangeEnd = 160864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseSingle_Internal_Static_Single_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00065464 File Offset: 0x00063664
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 160883, RefRangeEnd = 160891, XrefRangeStart = 160872, XrefRangeEnd = 160883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ParseUInt32(string value, NumberStyles options, NumberFormatInfo numfmt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseUInt32_Internal_Static_UInt32_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x000654C8 File Offset: 0x000636C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 160902, RefRangeEnd = 160906, XrefRangeStart = 160891, XrefRangeEnd = 160902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ParseUInt64(string value, NumberStyles options, NumberFormatInfo numfmt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseUInt64_Internal_Static_UInt64_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x0006552C File Offset: 0x0006372C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160906, XrefRangeEnd = 160908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseDecimal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_StringToNumber_Private_Static_Void_String_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000655A0 File Offset: 0x000637A0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 160909, RefRangeEnd = 160926, XrefRangeStart = 160908, XrefRangeEnd = 160909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrailingZeros(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TrailingZeros_Private_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x000655F0 File Offset: 0x000637F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 160937, RefRangeEnd = 160943, XrefRangeStart = 160926, XrefRangeEnd = 160937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt, out Decimal result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseDecimal_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00065660 File Offset: 0x00063860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160954, RefRangeEnd = 160955, XrefRangeStart = 160943, XrefRangeEnd = 160954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt, out double result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseDouble_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x000656D0 File Offset: 0x000638D0
		[CallerCount(67)]
		[CachedScanResults(RefRangeStart = 160968, RefRangeEnd = 161035, XrefRangeStart = 160955, XrefRangeEnd = 160968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseInt32(string s, NumberStyles style, NumberFormatInfo info, out int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseInt32_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00065740 File Offset: 0x00063940
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 161044, RefRangeEnd = 161059, XrefRangeStart = 161035, XrefRangeEnd = 161044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseInt64(string s, NumberStyles style, NumberFormatInfo info, out long result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseInt64_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x000657B0 File Offset: 0x000639B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161070, RefRangeEnd = 161072, XrefRangeStart = 161059, XrefRangeEnd = 161070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt, out float result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseSingle_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00065820 File Offset: 0x00063A20
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 161084, RefRangeEnd = 161100, XrefRangeStart = 161072, XrefRangeEnd = 161084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseUInt32(string s, NumberStyles style, NumberFormatInfo info, out uint result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseUInt32_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00065890 File Offset: 0x00063A90
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 161112, RefRangeEnd = 161118, XrefRangeStart = 161100, XrefRangeEnd = 161112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseUInt64(string s, NumberStyles style, NumberFormatInfo info, out ulong result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseUInt64_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00065900 File Offset: 0x00063B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161118, XrefRangeEnd = 161120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryStringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo numfmt, bool parseDecimal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseDecimal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_String_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00065980 File Offset: 0x00063B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161120, XrefRangeEnd = 161122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryStringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseDecimal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_String_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00005A60 File Offset: 0x00003C60
		public Number(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_NumberBufferToDecimal_Public_Static_Boolean_ptr_Byte_byref_Decimal_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_NumberBufferToDouble_Internal_Static_Boolean_ptr_Byte_byref_Double_0;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_FormatDecimal_Public_Static_String_Decimal_String_NumberFormatInfo_0;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr_FormatDouble_Public_Static_String_Double_String_NumberFormatInfo_0;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr_FormatInt32_Public_Static_String_Int32_String_NumberFormatInfo_0;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr_FormatUInt32_Public_Static_String_UInt32_String_NumberFormatInfo_0;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr_FormatInt64_Public_Static_String_Int64_String_NumberFormatInfo_0;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeMethodInfoPtr_FormatUInt64_Public_Static_String_UInt64_String_NumberFormatInfo_0;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeMethodInfoPtr_FormatSingle_Public_Static_String_Single_String_NumberFormatInfo_0;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeMethodInfoPtr_HexNumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr_HexNumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_HexNumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_HexNumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_IsWhite_Private_Static_Boolean_Char_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_NumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr_NumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr_NumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr_NumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_String_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_0;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr_ParseDecimal_Internal_Static_Decimal_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr_ParseDouble_Internal_Static_Double_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr_ParseInt32_Internal_Static_Int32_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr_ParseInt64_Internal_Static_Int64_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumber_Private_Static_Boolean_byref_ptr_Char_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_ParseSingle_Internal_Static_Single_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_ParseUInt32_Internal_Static_UInt32_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_ParseUInt64_Internal_Static_UInt64_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_StringToNumber_Private_Static_Void_String_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_TrailingZeros_Private_Static_Boolean_String_Int32_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDecimal_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Decimal_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDouble_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Double_0;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_TryParseInt32_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Int32_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr_TryParseInt64_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Int64_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr_TryParseSingle_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Single_0;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeMethodInfoPtr_TryParseUInt32_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_UInt32_0;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr_TryParseUInt64_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_UInt64_0;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_String_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_String_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0;

		// Token: 0x0200059D RID: 1437
		[StructLayout(2)]
		public struct NumberBuffer
		{
			// Token: 0x060050B8 RID: 20664 RVA: 0x0016E748 File Offset: 0x0016C948
			// Note: this type is marked as 'beforefieldinit'.
			static NumberBuffer()
			{
				Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Number>.NativeClassPtr, "NumberBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr);
				Number.NumberBuffer.NativeFieldInfoPtr_NumberBufferBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "NumberBufferBytes");
				Number.NumberBuffer.NativeFieldInfoPtr_baseAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "baseAddress");
				Number.NumberBuffer.NativeFieldInfoPtr_digits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "digits");
				Number.NumberBuffer.NativeFieldInfoPtr_precision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "precision");
				Number.NumberBuffer.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "scale");
				Number.NumberBuffer.NativeFieldInfoPtr_sign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "sign");
				Number.NumberBuffer.NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, 100665758);
				Number.NumberBuffer.NativeMethodInfoPtr_PackForNative_Public_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, 100665759);
			}

			// Token: 0x060050B9 RID: 20665 RVA: 0x0016E814 File Offset: 0x0016CA14
			[CallerCount(0)]
			public unsafe NumberBuffer(byte* stackBuffer)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = stackBuffer;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NumberBuffer.NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050BA RID: 20666 RVA: 0x0016E848 File Offset: 0x0016CA48
			[CallerCount(0)]
			public unsafe byte* PackForNative()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NumberBuffer.NativeMethodInfoPtr_PackForNative_Public_ptr_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}

			// Token: 0x060050BB RID: 20667 RVA: 0x0001E374 File Offset: 0x0001C574
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x17001498 RID: 5272
			// (get) Token: 0x060050BC RID: 20668 RVA: 0x0016E870 File Offset: 0x0016CA70
			// (set) Token: 0x060050BD RID: 20669 RVA: 0x0001E386 File Offset: 0x0001C586
			public unsafe static int NumberBufferBytes
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Number.NumberBuffer.NativeFieldInfoPtr_NumberBufferBytes, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Number.NumberBuffer.NativeFieldInfoPtr_NumberBufferBytes, (void*)(&value));
				}
			}

			// Token: 0x04004178 RID: 16760
			private static readonly IntPtr NativeFieldInfoPtr_NumberBufferBytes;

			// Token: 0x04004179 RID: 16761
			private static readonly IntPtr NativeFieldInfoPtr_baseAddress;

			// Token: 0x0400417A RID: 16762
			private static readonly IntPtr NativeFieldInfoPtr_digits;

			// Token: 0x0400417B RID: 16763
			private static readonly IntPtr NativeFieldInfoPtr_precision;

			// Token: 0x0400417C RID: 16764
			private static readonly IntPtr NativeFieldInfoPtr_scale;

			// Token: 0x0400417D RID: 16765
			private static readonly IntPtr NativeFieldInfoPtr_sign;

			// Token: 0x0400417E RID: 16766
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_0;

			// Token: 0x0400417F RID: 16767
			private static readonly IntPtr NativeMethodInfoPtr_PackForNative_Public_ptr_Byte_0;

			// Token: 0x04004180 RID: 16768
			[FieldOffset(0)]
			public IntPtr baseAddress;

			// Token: 0x04004181 RID: 16769
			[FieldOffset(8)]
			public IntPtr digits;

			// Token: 0x04004182 RID: 16770
			[FieldOffset(16)]
			public int precision;

			// Token: 0x04004183 RID: 16771
			[FieldOffset(20)]
			public int scale;

			// Token: 0x04004184 RID: 16772
			[FieldOffset(24)]
			[MarshalAs(4)]
			public bool sign;
		}
	}
}
