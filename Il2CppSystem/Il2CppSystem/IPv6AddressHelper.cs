using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem
{
	// Token: 0x0200003C RID: 60
	public static class IPv6AddressHelper : Object
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x0001F458 File Offset: 0x0001D658
		// Note: this type is marked as 'beforefieldinit'.
		static IPv6AddressHelper()
		{
			Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IPv6AddressHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr);
			IPv6AddressHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_byref_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100663953);
			IPv6AddressHelper.NativeMethodInfoPtr_CreateCanonicalName_Internal_Static_String_ptr_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100663954);
			IPv6AddressHelper.NativeMethodInfoPtr_FindCompressionRange_Private_Static_KeyValuePair_2_Int32_Int32_ptr_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100663955);
			IPv6AddressHelper.NativeMethodInfoPtr_ShouldHaveIpv4Embedded_Private_Static_Boolean_ptr_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100663956);
			IPv6AddressHelper.NativeMethodInfoPtr_InternalIsValid_Private_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100663957);
			IPv6AddressHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100663958);
			IPv6AddressHelper.NativeMethodInfoPtr_IsValidStrict_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100663959);
			IPv6AddressHelper.NativeMethodInfoPtr_Parse_Internal_Static_Boolean_String_ptr_UInt16_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100663960);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0001F528 File Offset: 0x0001D728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369048, XrefRangeEnd = 369055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isLoopback;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(scopeId);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_byref_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			scopeId = IL2CPP.Il2CppStringToManaged(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0001F5A4 File Offset: 0x0001D7A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369120, RefRangeEnd = 369121, XrefRangeStart = 369055, XrefRangeEnd = 369120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateCanonicalName(ushort* numbers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = numbers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_CreateCanonicalName_Internal_Static_String_ptr_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0001F5DC File Offset: 0x0001D7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369121, XrefRangeEnd = 369123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static KeyValuePair<int, int> FindCompressionRange(ushort* numbers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = numbers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_FindCompressionRange_Private_Static_KeyValuePair_2_Int32_Int32_ptr_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new KeyValuePair<int, int>(intPtr);
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0001F614 File Offset: 0x0001D814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369123, XrefRangeEnd = 369124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldHaveIpv4Embedded(ushort* numbers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = numbers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_ShouldHaveIpv4Embedded_Private_Static_Boolean_ptr_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0001F650 File Offset: 0x0001D850
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 369139, RefRangeEnd = 369142, XrefRangeStart = 369124, XrefRangeEnd = 369139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validateStrictAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_InternalIsValid_Private_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0001F6B8 File Offset: 0x0001D8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369142, XrefRangeEnd = 369143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(char* name, int start, ref int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0001F710 File Offset: 0x0001D910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369143, XrefRangeEnd = 369144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidStrict(char* name, int start, ref int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_IsValidStrict_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0001F768 File Offset: 0x0001D968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369173, RefRangeEnd = 369174, XrefRangeStart = 369144, XrefRangeEnd = 369173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Parse(string address, ushort* numbers, int start, ref string scopeId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = numbers;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(scopeId);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_Parse_Internal_Static_Boolean_String_ptr_UInt16_Int32_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			scopeId = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000341D File Offset: 0x0000161D
		public IPv6AddressHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_byref_Boolean_byref_String_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_CreateCanonicalName_Internal_Static_String_ptr_UInt16_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_FindCompressionRange_Private_Static_KeyValuePair_2_Int32_Int32_ptr_UInt16_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_ShouldHaveIpv4Embedded_Private_Static_Boolean_ptr_UInt16_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsValid_Private_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_IsValidStrict_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_Boolean_String_ptr_UInt16_Int32_byref_String_0;
	}
}
