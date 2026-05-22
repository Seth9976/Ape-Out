using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200003A RID: 58
	public class DomainNameHelper : Object
	{
		// Token: 0x06000391 RID: 913 RVA: 0x0001EB40 File Offset: 0x0001CD40
		// Note: this type is marked as 'beforefieldinit'.
		static DomainNameHelper()
		{
			Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "DomainNameHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr);
			DomainNameHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663935);
			DomainNameHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663936);
			DomainNameHelper.NativeMethodInfoPtr_IsValidByIri_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663937);
			DomainNameHelper.NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663938);
			DomainNameHelper.NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663939);
			DomainNameHelper.NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663940);
			DomainNameHelper.NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663941);
			DomainNameHelper.NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_String_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663942);
			DomainNameHelper.NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663943);
			DomainNameHelper.NativeMethodInfoPtr_IsASCIILetterOrDigit_Private_Static_Boolean_Char_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663944);
			DomainNameHelper.NativeMethodInfoPtr_IsValidDomainLabelCharacter_Private_Static_Boolean_Char_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663945);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0001EC4C File Offset: 0x0001CE4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368927, RefRangeEnd = 368928, XrefRangeStart = 368914, XrefRangeEnd = 368927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseCanonicalName(string str, int start, int end, ref bool loopback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &loopback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0001ECB4 File Offset: 0x0001CEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368928, XrefRangeEnd = 368929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &returnedEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &notCanonical;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notImplicitFile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0001ED28 File Offset: 0x0001CF28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368932, RefRangeEnd = 368933, XrefRangeStart = 368929, XrefRangeEnd = 368932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &returnedEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &notCanonical;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notImplicitFile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsValidByIri_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0001ED9C File Offset: 0x0001CF9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368935, RefRangeEnd = 368936, XrefRangeStart = 368933, XrefRangeEnd = 368935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = hostname;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &allAscii;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &atLeastOneValidIdn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0001EE0C File Offset: 0x0001D00C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368950, RefRangeEnd = 368952, XrefRangeStart = 368936, XrefRangeEnd = 368950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = hostname;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &allAscii;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(bidiStrippedHost);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			bidiStrippedHost = IL2CPP.Il2CppStringToManaged(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0001EE90 File Offset: 0x0001D090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368954, RefRangeEnd = 368955, XrefRangeStart = 368952, XrefRangeEnd = 368954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIdnAce(string input, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0001EEE0 File Offset: 0x0001D0E0
		[CallerCount(0)]
		public unsafe static bool IsIdnAce(char* input, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0001EF2C File Offset: 0x0001D12C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368960, RefRangeEnd = 368961, XrefRangeStart = 368955, XrefRangeEnd = 368960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnicodeEquivalent(string idnHost, char* hostname, int start, int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(idnHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hostname;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_String_ptr_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0001EF94 File Offset: 0x0001D194
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 368990, RefRangeEnd = 368993, XrefRangeStart = 368961, XrefRangeEnd = 368990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = hostname;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &allAscii;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &atLeastOneValidIdn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0001F004 File Offset: 0x0001D204
		[CallerCount(0)]
		public unsafe static bool IsASCIILetterOrDigit(char character, ref bool notCanonical)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &notCanonical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsASCIILetterOrDigit_Private_Static_Boolean_Char_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0001F050 File Offset: 0x0001D250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368993, RefRangeEnd = 368994, XrefRangeStart = 368993, XrefRangeEnd = 368993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &notCanonical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsValidDomainLabelCharacter_Private_Static_Boolean_Char_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000340B File Offset: 0x0000160B
		public DomainNameHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_IsValidByIri_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_String_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_String_Int32_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_ptr_Char_Int32_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_String_ptr_Char_Int32_Int32_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_IsASCIILetterOrDigit_Private_Static_Boolean_Char_byref_Boolean_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_IsValidDomainLabelCharacter_Private_Static_Boolean_Char_byref_Boolean_0;
	}
}
