using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000037 RID: 55
	public static class UriHelper : Object
	{
		// Token: 0x06000338 RID: 824 RVA: 0x0001D68C File Offset: 0x0001B88C
		// Note: this type is marked as 'beforefieldinit'.
		static UriHelper()
		{
			Il2CppClassPointerStore<UriHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "UriHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UriHelper>.NativeClassPtr);
			UriHelper.NativeFieldInfoPtr_HexUpperChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, "HexUpperChars");
			UriHelper.NativeMethodInfoPtr_EscapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Boolean_Char_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100663901);
			UriHelper.NativeMethodInfoPtr_EnsureDestinationSize_Private_Static_Il2CppStructArray_1_Char_ptr_Char_Il2CppStructArray_1_Char_Int32_Int16_Int16_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100663902);
			UriHelper.NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100663903);
			UriHelper.NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_ptr_Char_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100663904);
			UriHelper.NativeMethodInfoPtr_MatchUTF8Sequence_Internal_Static_Void_ptr_Char_Il2CppStructArray_1_Char_byref_Int32_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100663905);
			UriHelper.NativeMethodInfoPtr_EscapeAsciiChar_Internal_Static_Void_Char_Il2CppStructArray_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100663906);
			UriHelper.NativeMethodInfoPtr_EscapedAscii_Internal_Static_Char_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100663907);
			UriHelper.NativeMethodInfoPtr_IsNotSafeForUnescape_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100663908);
			UriHelper.NativeMethodInfoPtr_IsReservedUnreservedOrHash_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100663909);
			UriHelper.NativeMethodInfoPtr_IsUnreserved_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100663910);
			UriHelper.NativeMethodInfoPtr_Is3986Unreserved_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100663911);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0001D7AC File Offset: 0x0001B9AC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 368585, RefRangeEnd = 368594, XrefRangeStart = 368540, XrefRangeEnd = 368585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> EscapeString(string input, int start, int end, Il2CppStructArray<char> dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destPos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isUriString;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force1;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force2;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rsvd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_EscapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Boolean_Char_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0001D868 File Offset: 0x0001BA68
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 368598, RefRangeEnd = 368603, XrefRangeStart = 368594, XrefRangeEnd = 368598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> EnsureDestinationSize(char* pStr, Il2CppStructArray<char> dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pStr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentInputPos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charsToAdd;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minReallocateChars;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destPos;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevInputPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_EnsureDestinationSize_Private_Static_Il2CppStructArray_1_Char_ptr_Char_Il2CppStructArray_1_Char_Int32_Int16_Int16_byref_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0001D900 File Offset: 0x0001BB00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368607, RefRangeEnd = 368608, XrefRangeStart = 368603, XrefRangeEnd = 368607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> UnescapeString(string input, int start, int end, Il2CppStructArray<char> dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destPosition;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rsvd1;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rsvd2;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rsvd3;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unescapeMode;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isQuery;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0001D9E0 File Offset: 0x0001BBE0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 368679, RefRangeEnd = 368687, XrefRangeStart = 368608, XrefRangeEnd = 368679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> UnescapeString(char* pStr, int start, int end, Il2CppStructArray<char> dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pStr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destPosition;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rsvd1;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rsvd2;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rsvd3;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unescapeMode;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isQuery;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_ptr_Char_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0001DAB8 File Offset: 0x0001BCB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368721, RefRangeEnd = 368723, XrefRangeStart = 368687, XrefRangeEnd = 368721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MatchUTF8Sequence(char* pDest, Il2CppStructArray<char> dest, ref int destOffset, Il2CppStructArray<char> unescapedChars, int charCount, Il2CppStructArray<byte> bytes, int byteCount, bool isQuery, bool iriParsing)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unescapedChars);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isQuery;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iriParsing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_MatchUTF8Sequence_Internal_Static_Void_ptr_Char_Il2CppStructArray_1_Char_byref_Int32_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0001DB68 File Offset: 0x0001BD68
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 368728, RefRangeEnd = 368738, XrefRangeStart = 368723, XrefRangeEnd = 368728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EscapeAsciiChar(char ch, Il2CppStructArray<char> to, ref int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_EscapeAsciiChar_Internal_Static_Void_Char_Il2CppStructArray_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0001DBBC File Offset: 0x0001BDBC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 368739, RefRangeEnd = 368748, XrefRangeStart = 368738, XrefRangeEnd = 368739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char EscapedAscii(char digit, char next)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref digit;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref next;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_EscapedAscii_Internal_Static_Char_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0001DC08 File Offset: 0x0001BE08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 368748, RefRangeEnd = 368751, XrefRangeStart = 368748, XrefRangeEnd = 368748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNotSafeForUnescape(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_IsNotSafeForUnescape_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0001DC48 File Offset: 0x0001BE48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368763, RefRangeEnd = 368764, XrefRangeStart = 368751, XrefRangeEnd = 368763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsReservedUnreservedOrHash(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_IsReservedUnreservedOrHash_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0001DC88 File Offset: 0x0001BE88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368777, RefRangeEnd = 368779, XrefRangeStart = 368764, XrefRangeEnd = 368777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUnreserved(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_IsUnreserved_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0001DCC8 File Offset: 0x0001BEC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368786, RefRangeEnd = 368787, XrefRangeStart = 368779, XrefRangeEnd = 368786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Is3986Unreserved(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_Is3986Unreserved_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000031EE File Offset: 0x000013EE
		public UriHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0001DD08 File Offset: 0x0001BF08
		// (set) Token: 0x06000346 RID: 838 RVA: 0x000031F7 File Offset: 0x000013F7
		public unsafe static Il2CppStructArray<char> HexUpperChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriHelper.NativeFieldInfoPtr_HexUpperChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriHelper.NativeFieldInfoPtr_HexUpperChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_HexUpperChars;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_EscapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Boolean_Char_Char_Char_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_EnsureDestinationSize_Private_Static_Il2CppStructArray_1_Char_ptr_Char_Il2CppStructArray_1_Char_Int32_Int16_Int16_byref_Int32_Int32_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_ptr_Char_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_MatchUTF8Sequence_Internal_Static_Void_ptr_Char_Il2CppStructArray_1_Char_byref_Int32_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_Boolean_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_EscapeAsciiChar_Internal_Static_Void_Char_Il2CppStructArray_1_Char_byref_Int32_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_EscapedAscii_Internal_Static_Char_Char_Char_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_IsNotSafeForUnescape_Internal_Static_Boolean_Char_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_IsReservedUnreservedOrHash_Private_Static_Boolean_Char_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_IsUnreserved_Internal_Static_Boolean_Char_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_Is3986Unreserved_Internal_Static_Boolean_Char_0;
	}
}
