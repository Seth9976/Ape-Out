using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppSystem
{
	// Token: 0x020000B6 RID: 182
	[Serializable]
	[StructLayout(2)]
	public struct Guid
	{
		// Token: 0x06000CF0 RID: 3312 RVA: 0x0005E25C File Offset: 0x0005C45C
		// Note: this type is marked as 'beforefieldinit'.
		static Guid()
		{
			Il2CppClassPointerStore<Guid>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Guid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Guid>.NativeClassPtr);
			Guid.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "Empty");
			Guid.NativeFieldInfoPtr__a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_a");
			Guid.NativeFieldInfoPtr__b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_b");
			Guid.NativeFieldInfoPtr__c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_c");
			Guid.NativeFieldInfoPtr__d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_d");
			Guid.NativeFieldInfoPtr__e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_e");
			Guid.NativeFieldInfoPtr__f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_f");
			Guid.NativeFieldInfoPtr__g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_g");
			Guid.NativeFieldInfoPtr__h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_h");
			Guid.NativeFieldInfoPtr__i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_i");
			Guid.NativeFieldInfoPtr__j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_j");
			Guid.NativeFieldInfoPtr__k = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_k");
			Guid.NativeFieldInfoPtr__rngAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_rngAccess");
			Guid.NativeFieldInfoPtr__rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_rng");
			Guid.NativeFieldInfoPtr__fastRng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_fastRng");
			Guid.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665468);
			Guid.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt16_UInt16_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665469);
			Guid.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665470);
			Guid.NativeMethodInfoPtr_Parse_Public_Static_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665471);
			Guid.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665472);
			Guid.NativeMethodInfoPtr_TryParseGuid_Private_Static_Boolean_String_GuidStyles_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665473);
			Guid.NativeMethodInfoPtr_TryParseGuidWithHexPrefix_Private_Static_Boolean_String_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665474);
			Guid.NativeMethodInfoPtr_TryParseGuidWithNoStyle_Private_Static_Boolean_String_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665475);
			Guid.NativeMethodInfoPtr_TryParseGuidWithDashes_Private_Static_Boolean_String_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665476);
			Guid.NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_String_Int32_Int32_byref_Int16_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665477);
			Guid.NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_String_ptr_Int32_Int32_Int32_byref_Int16_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665478);
			Guid.NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_Int32_Int32_byref_Int32_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665479);
			Guid.NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_byref_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665480);
			Guid.NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_ptr_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665481);
			Guid.NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_String_byref_Int32_Int32_byref_Int64_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665482);
			Guid.NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_String_ptr_Int32_Int32_byref_Int64_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665483);
			Guid.NativeMethodInfoPtr_EatAllWhitespace_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665484);
			Guid.NativeMethodInfoPtr_IsHexPrefix_Private_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665485);
			Guid.NativeMethodInfoPtr_ToByteArray_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665486);
			Guid.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665487);
			Guid.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665488);
			Guid.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665489);
			Guid.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665490);
			Guid.NativeMethodInfoPtr_GetResult_Private_Int32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665491);
			Guid.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665492);
			Guid.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665493);
			Guid.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Guid_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665494);
			Guid.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Guid_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665495);
			Guid.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665496);
			Guid.NativeMethodInfoPtr_HexToChar_Private_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665497);
			Guid.NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665498);
			Guid.NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665499);
			Guid.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665500);
			Guid.NativeMethodInfoPtr_NewGuid_Public_Static_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665501);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0005E660 File Offset: 0x0005C860
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 157173, RefRangeEnd = 157178, XrefRangeStart = 157173, XrefRangeEnd = 157173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Guid(Il2CppStructArray<byte> b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0005E698 File Offset: 0x0005C898
		[CallerCount(0)]
		public unsafe Guid(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref e;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref k;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt16_UInt16_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0005E75C File Offset: 0x0005C95C
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 157187, RefRangeEnd = 157220, XrefRangeStart = 157178, XrefRangeEnd = 157187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Guid(string g)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(g);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0005E794 File Offset: 0x0005C994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157220, XrefRangeEnd = 157227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid Parse(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_Parse_Public_Static_Guid_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0005E7D8 File Offset: 0x0005C9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157227, XrefRangeEnd = 157237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string input, out Guid result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0005E828 File Offset: 0x0005CA28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 157243, RefRangeEnd = 157247, XrefRangeStart = 157237, XrefRangeEnd = 157243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseGuid(string g, Guid.GuidStyles flags, ref Guid.GuidResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(g);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParseGuid_Private_Static_Boolean_String_GuidStyles_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0005E890 File Offset: 0x0005CA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157247, XrefRangeEnd = 157323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseGuidWithHexPrefix(string guidString, ref Guid.GuidResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guidString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParseGuidWithHexPrefix_Private_Static_Boolean_String_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0005E8EC File Offset: 0x0005CAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157323, XrefRangeEnd = 157336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseGuidWithNoStyle(string guidString, ref Guid.GuidResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guidString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParseGuidWithNoStyle_Private_Static_Boolean_String_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0005E948 File Offset: 0x0005CB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157336, XrefRangeEnd = 157342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseGuidWithDashes(string guidString, ref Guid.GuidResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guidString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParseGuidWithDashes_Private_Static_Boolean_String_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0005E9A4 File Offset: 0x0005CBA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157349, RefRangeEnd = 157351, XrefRangeStart = 157342, XrefRangeEnd = 157349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToShort(string str, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_String_Int32_Int32_byref_Int16_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0005EA28 File Offset: 0x0005CC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157351, XrefRangeEnd = 157355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToShort(string str, int* parsePos, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = parsePos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_String_ptr_Int32_Int32_Int32_byref_Int16_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0005EABC File Offset: 0x0005CCBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157359, RefRangeEnd = 157360, XrefRangeStart = 157355, XrefRangeEnd = 157359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToInt(string str, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_Int32_Int32_byref_Int32_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0005EB40 File Offset: 0x0005CD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157360, XrefRangeEnd = 157364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToInt(string str, ref int parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parsePos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_byref_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0005EBD4 File Offset: 0x0005CDD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 157368, RefRangeEnd = 157372, XrefRangeStart = 157364, XrefRangeEnd = 157368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToInt(string str, int* parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = parsePos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_ptr_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0005EC68 File Offset: 0x0005CE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157372, XrefRangeEnd = 157376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToLong(string str, ref int parsePos, int flags, out long result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parsePos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_String_byref_Int32_Int32_byref_Int64_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x0005ECEC File Offset: 0x0005CEEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157377, RefRangeEnd = 157378, XrefRangeStart = 157376, XrefRangeEnd = 157377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToLong(string str, int* parsePos, int flags, out long result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = parsePos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_String_ptr_Int32_Int32_byref_Int64_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0005ED70 File Offset: 0x0005CF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157378, XrefRangeEnd = 157387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EatAllWhitespace(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_EatAllWhitespace_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x0005EDAC File Offset: 0x0005CFAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 157395, RefRangeEnd = 157399, XrefRangeStart = 157387, XrefRangeEnd = 157395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHexPrefix(string str, int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_IsHexPrefix_Private_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0005EDFC File Offset: 0x0005CFFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157402, RefRangeEnd = 157404, XrefRangeStart = 157399, XrefRangeEnd = 157402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ToByteArray()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_ToByteArray_Public_Il2CppStructArray_1_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0005EE30 File Offset: 0x0005D030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157404, XrefRangeEnd = 157407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0005EE5C File Offset: 0x0005D05C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0005EE8C File Offset: 0x0005D08C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157409, RefRangeEnd = 157410, XrefRangeStart = 157407, XrefRangeEnd = 157409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0005EED0 File Offset: 0x0005D0D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157410, RefRangeEnd = 157411, XrefRangeStart = 157410, XrefRangeEnd = 157410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Guid g)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref g;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Guid_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0005EF10 File Offset: 0x0005D110
		[CallerCount(0)]
		public unsafe int GetResult(uint me, uint them)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref me;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref them;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_GetResult_Private_Int32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0005EF5C File Offset: 0x0005D15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157411, XrefRangeEnd = 157413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0005EFA0 File Offset: 0x0005D1A0
		[CallerCount(0)]
		public unsafe int CompareTo(Guid value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Guid_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0005EFE0 File Offset: 0x0005D1E0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 157413, RefRangeEnd = 157527, XrefRangeStart = 157413, XrefRangeEnd = 157413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Guid a, Guid b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Guid_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0005F02C File Offset: 0x0005D22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157527, XrefRangeEnd = 157531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Guid a, Guid b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Guid_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0005F078 File Offset: 0x0005D278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157531, XrefRangeEnd = 157532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x0005F0B4 File Offset: 0x0005D2B4
		[CallerCount(0)]
		public unsafe static char HexToChar(int a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_HexToChar_Private_Static_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x0005F0F4 File Offset: 0x0005D2F4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 157536, RefRangeEnd = 157548, XrefRangeStart = 157532, XrefRangeEnd = 157536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int HexsToChars(char* guidChars, int offset, int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = guidChars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0005F15C File Offset: 0x0005D35C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 157553, RefRangeEnd = 157558, XrefRangeStart = 157548, XrefRangeEnd = 157553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int HexsToChars(char* guidChars, int offset, int a, int b, bool hex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = guidChars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0005F1D0 File Offset: 0x0005D3D0
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 157599, RefRangeEnd = 157648, XrefRangeStart = 157558, XrefRangeEnd = 157599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x0005F220 File Offset: 0x0005D420
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 157669, RefRangeEnd = 157673, XrefRangeStart = 157648, XrefRangeEnd = 157669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid NewGuid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_NewGuid_Public_Static_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00005645 File Offset: 0x00003845
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Guid>.NativeClassPtr, ref this));
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0005F250 File Offset: 0x0005D450
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x00005657 File Offset: 0x00003857
		public unsafe static Guid Empty
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(Guid.NativeFieldInfoPtr_Empty, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Guid.NativeFieldInfoPtr_Empty, (void*)(&value));
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0005F26C File Offset: 0x0005D46C
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x00005665 File Offset: 0x00003865
		public unsafe static Object _rngAccess
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Guid.NativeFieldInfoPtr__rngAccess, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Guid.NativeFieldInfoPtr__rngAccess, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x0005F294 File Offset: 0x0005D494
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x00005677 File Offset: 0x00003877
		public unsafe static RandomNumberGenerator _rng
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Guid.NativeFieldInfoPtr__rng, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Guid.NativeFieldInfoPtr__rng, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x0005F2BC File Offset: 0x0005D4BC
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x00005689 File Offset: 0x00003889
		public unsafe static RandomNumberGenerator _fastRng
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Guid.NativeFieldInfoPtr__fastRng, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Guid.NativeFieldInfoPtr__fastRng, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeFieldInfoPtr__a;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeFieldInfoPtr__b;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeFieldInfoPtr__c;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeFieldInfoPtr__d;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeFieldInfoPtr__e;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeFieldInfoPtr__f;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeFieldInfoPtr__g;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeFieldInfoPtr__h;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeFieldInfoPtr__i;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeFieldInfoPtr__j;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeFieldInfoPtr__k;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeFieldInfoPtr__rngAccess;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeFieldInfoPtr__rng;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeFieldInfoPtr__fastRng;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt16_UInt16_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Guid_String_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Guid_0;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeMethodInfoPtr_TryParseGuid_Private_Static_Boolean_String_GuidStyles_byref_GuidResult_0;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeMethodInfoPtr_TryParseGuidWithHexPrefix_Private_Static_Boolean_String_byref_GuidResult_0;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr_TryParseGuidWithNoStyle_Private_Static_Boolean_String_byref_GuidResult_0;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeMethodInfoPtr_TryParseGuidWithDashes_Private_Static_Boolean_String_byref_GuidResult_0;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_String_Int32_Int32_byref_Int16_byref_GuidResult_0;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_String_ptr_Int32_Int32_Int32_byref_Int16_byref_GuidResult_0;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_Int32_Int32_byref_Int32_byref_GuidResult_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_byref_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_ptr_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_String_byref_Int32_Int32_byref_Int64_byref_GuidResult_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_String_ptr_Int32_Int32_byref_Int64_byref_GuidResult_0;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_EatAllWhitespace_Private_Static_String_String_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_IsHexPrefix_Private_Static_Boolean_String_Int32_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_ToByteArray_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Guid_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Private_Int32_UInt32_UInt32_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Guid_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Guid_Guid_0;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Guid_Guid_0;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr_HexToChar_Private_Static_Char_Int32_0;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_Int32_0;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_Int32_Boolean_0;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_NewGuid_Public_Static_Guid_0;

		// Token: 0x04000B31 RID: 2865
		[FieldOffset(0)]
		public int _a;

		// Token: 0x04000B32 RID: 2866
		[FieldOffset(4)]
		public short _b;

		// Token: 0x04000B33 RID: 2867
		[FieldOffset(6)]
		public short _c;

		// Token: 0x04000B34 RID: 2868
		[FieldOffset(8)]
		public byte _d;

		// Token: 0x04000B35 RID: 2869
		[FieldOffset(9)]
		public byte _e;

		// Token: 0x04000B36 RID: 2870
		[FieldOffset(10)]
		public byte _f;

		// Token: 0x04000B37 RID: 2871
		[FieldOffset(11)]
		public byte _g;

		// Token: 0x04000B38 RID: 2872
		[FieldOffset(12)]
		public byte _h;

		// Token: 0x04000B39 RID: 2873
		[FieldOffset(13)]
		public byte _i;

		// Token: 0x04000B3A RID: 2874
		[FieldOffset(14)]
		public byte _j;

		// Token: 0x04000B3B RID: 2875
		[FieldOffset(15)]
		public byte _k;

		// Token: 0x02000599 RID: 1433
		[OriginalName("mscorlib.dll", "", "GuidStyles")]
		[Flags]
		public enum GuidStyles
		{
			// Token: 0x04004151 RID: 16721
			None = 0,
			// Token: 0x04004152 RID: 16722
			AllowParenthesis = 1,
			// Token: 0x04004153 RID: 16723
			AllowBraces = 2,
			// Token: 0x04004154 RID: 16724
			AllowDashes = 4,
			// Token: 0x04004155 RID: 16725
			AllowHexPrefix = 8,
			// Token: 0x04004156 RID: 16726
			RequireParenthesis = 16,
			// Token: 0x04004157 RID: 16727
			RequireBraces = 32,
			// Token: 0x04004158 RID: 16728
			RequireDashes = 64,
			// Token: 0x04004159 RID: 16729
			RequireHexPrefix = 128,
			// Token: 0x0400415A RID: 16730
			HexFormat = 160,
			// Token: 0x0400415B RID: 16731
			NumberFormat = 0,
			// Token: 0x0400415C RID: 16732
			DigitFormat = 64,
			// Token: 0x0400415D RID: 16733
			BraceFormat = 96,
			// Token: 0x0400415E RID: 16734
			ParenthesisFormat = 80,
			// Token: 0x0400415F RID: 16735
			Any = 15
		}

		// Token: 0x0200059A RID: 1434
		[OriginalName("mscorlib.dll", "", "GuidParseThrowStyle")]
		public enum GuidParseThrowStyle
		{
			// Token: 0x04004161 RID: 16737
			None,
			// Token: 0x04004162 RID: 16738
			All,
			// Token: 0x04004163 RID: 16739
			AllButOverflow
		}

		// Token: 0x0200059B RID: 1435
		[OriginalName("mscorlib.dll", "", "ParseFailureKind")]
		public enum ParseFailureKind
		{
			// Token: 0x04004165 RID: 16741
			None,
			// Token: 0x04004166 RID: 16742
			ArgumentNull,
			// Token: 0x04004167 RID: 16743
			Format,
			// Token: 0x04004168 RID: 16744
			FormatWithParameter,
			// Token: 0x04004169 RID: 16745
			NativeException,
			// Token: 0x0400416A RID: 16746
			FormatWithInnerException
		}

		// Token: 0x0200059C RID: 1436
		public sealed class GuidResult : ValueType
		{
			// Token: 0x060050A1 RID: 20641 RVA: 0x0016E2D0 File Offset: 0x0016C4D0
			// Note: this type is marked as 'beforefieldinit'.
			static GuidResult()
			{
				Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Guid>.NativeClassPtr, "GuidResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr);
				Guid.GuidResult.NativeFieldInfoPtr_parsedGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "parsedGuid");
				Guid.GuidResult.NativeFieldInfoPtr_throwStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "throwStyle");
				Guid.GuidResult.NativeFieldInfoPtr_m_failure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "m_failure");
				Guid.GuidResult.NativeFieldInfoPtr_m_failureMessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "m_failureMessageID");
				Guid.GuidResult.NativeFieldInfoPtr_m_failureMessageFormatArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "m_failureMessageFormatArgument");
				Guid.GuidResult.NativeFieldInfoPtr_m_failureArgumentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "m_failureArgumentName");
				Guid.GuidResult.NativeFieldInfoPtr_m_innerException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "m_innerException");
				Guid.GuidResult.NativeMethodInfoPtr_Init_Internal_Void_GuidParseThrowStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665503);
				Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665504);
				Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665505);
				Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665506);
				Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665507);
				Guid.GuidResult.NativeMethodInfoPtr_GetGuidParseException_Internal_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665508);
			}

			// Token: 0x060050A2 RID: 20642 RVA: 0x0016E400 File Offset: 0x0016C600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157151, XrefRangeEnd = 157155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(Guid.GuidParseThrowStyle canThrow)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref canThrow;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_Init_Internal_Void_GuidParseThrowStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050A3 RID: 20643 RVA: 0x0016E444 File Offset: 0x0016C644
			[CallerCount(0)]
			public unsafe void SetFailure(Exception nativeException)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nativeException);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050A4 RID: 20644 RVA: 0x0016E48C File Offset: 0x0016C68C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157155, XrefRangeEnd = 157156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFailure(Guid.ParseFailureKind failure, string failureMessageID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050A5 RID: 20645 RVA: 0x0016E4E4 File Offset: 0x0016C6E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157156, XrefRangeEnd = 157157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, Object failureMessageFormatArgument)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(failureMessageFormatArgument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050A6 RID: 20646 RVA: 0x0016E54C File Offset: 0x0016C74C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 157157, RefRangeEnd = 157164, XrefRangeStart = 157157, XrefRangeEnd = 157157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, Object failureMessageFormatArgument, string failureArgumentName, Exception innerException)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(failureMessageFormatArgument);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureArgumentName);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050A7 RID: 20647 RVA: 0x0016E5DC File Offset: 0x0016C7DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157164, XrefRangeEnd = 157173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Exception GetGuidParseException()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_GetGuidParseException_Internal_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}

			// Token: 0x060050A8 RID: 20648 RVA: 0x0001E28C File Offset: 0x0001C48C
			public GuidResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060050A9 RID: 20649 RVA: 0x0001E295 File Offset: 0x0001C495
			public GuidResult()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr))
			{
			}

			// Token: 0x17001491 RID: 5265
			// (get) Token: 0x060050AA RID: 20650 RVA: 0x0016E620 File Offset: 0x0016C820
			// (set) Token: 0x060050AB RID: 20651 RVA: 0x0001E2A7 File Offset: 0x0001C4A7
			public unsafe Guid parsedGuid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_parsedGuid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_parsedGuid)) = value;
				}
			}

			// Token: 0x17001492 RID: 5266
			// (get) Token: 0x060050AC RID: 20652 RVA: 0x0016E648 File Offset: 0x0016C848
			// (set) Token: 0x060050AD RID: 20653 RVA: 0x0001E2C2 File Offset: 0x0001C4C2
			public unsafe Guid.GuidParseThrowStyle throwStyle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_throwStyle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_throwStyle)) = value;
				}
			}

			// Token: 0x17001493 RID: 5267
			// (get) Token: 0x060050AE RID: 20654 RVA: 0x0016E670 File Offset: 0x0016C870
			// (set) Token: 0x060050AF RID: 20655 RVA: 0x0001E2DD File Offset: 0x0001C4DD
			public unsafe Guid.ParseFailureKind m_failure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_failure);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_failure)) = value;
				}
			}

			// Token: 0x17001494 RID: 5268
			// (get) Token: 0x060050B0 RID: 20656 RVA: 0x0016E698 File Offset: 0x0016C898
			// (set) Token: 0x060050B1 RID: 20657 RVA: 0x0001E2F8 File Offset: 0x0001C4F8
			public unsafe string m_failureMessageID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_failureMessageID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_failureMessageID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001495 RID: 5269
			// (get) Token: 0x060050B2 RID: 20658 RVA: 0x0016E6C0 File Offset: 0x0016C8C0
			// (set) Token: 0x060050B3 RID: 20659 RVA: 0x0001E317 File Offset: 0x0001C517
			public unsafe Object m_failureMessageFormatArgument
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_failureMessageFormatArgument);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_failureMessageFormatArgument), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001496 RID: 5270
			// (get) Token: 0x060050B4 RID: 20660 RVA: 0x0016E6F0 File Offset: 0x0016C8F0
			// (set) Token: 0x060050B5 RID: 20661 RVA: 0x0001E336 File Offset: 0x0001C536
			public unsafe string m_failureArgumentName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_failureArgumentName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_failureArgumentName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001497 RID: 5271
			// (get) Token: 0x060050B6 RID: 20662 RVA: 0x0016E718 File Offset: 0x0016C918
			// (set) Token: 0x060050B7 RID: 20663 RVA: 0x0001E355 File Offset: 0x0001C555
			public unsafe Exception m_innerException
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_innerException);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_innerException), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400416B RID: 16747
			private static readonly IntPtr NativeFieldInfoPtr_parsedGuid;

			// Token: 0x0400416C RID: 16748
			private static readonly IntPtr NativeFieldInfoPtr_throwStyle;

			// Token: 0x0400416D RID: 16749
			private static readonly IntPtr NativeFieldInfoPtr_m_failure;

			// Token: 0x0400416E RID: 16750
			private static readonly IntPtr NativeFieldInfoPtr_m_failureMessageID;

			// Token: 0x0400416F RID: 16751
			private static readonly IntPtr NativeFieldInfoPtr_m_failureMessageFormatArgument;

			// Token: 0x04004170 RID: 16752
			private static readonly IntPtr NativeFieldInfoPtr_m_failureArgumentName;

			// Token: 0x04004171 RID: 16753
			private static readonly IntPtr NativeFieldInfoPtr_m_innerException;

			// Token: 0x04004172 RID: 16754
			private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_GuidParseThrowStyle_0;

			// Token: 0x04004173 RID: 16755
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0;

			// Token: 0x04004174 RID: 16756
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0;

			// Token: 0x04004175 RID: 16757
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0;

			// Token: 0x04004176 RID: 16758
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_Exception_0;

			// Token: 0x04004177 RID: 16759
			private static readonly IntPtr NativeMethodInfoPtr_GetGuidParseException_Internal_Exception_0;
		}
	}
}
