using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Globalization.Unicode;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200022E RID: 558
	[Serializable]
	public class CompareInfo : Object
	{
		// Token: 0x060024E0 RID: 9440 RVA: 0x000C9758 File Offset: 0x000C7958
		// Note: this type is marked as 'beforefieldinit'.
		static CompareInfo()
		{
			Il2CppClassPointerStore<CompareInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CompareInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr);
			CompareInfo.NativeFieldInfoPtr_ValidIndexMaskOffFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "ValidIndexMaskOffFlags");
			CompareInfo.NativeFieldInfoPtr_ValidCompareMaskOffFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "ValidCompareMaskOffFlags");
			CompareInfo.NativeFieldInfoPtr_ValidHashCodeOfStringMaskOffFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "ValidHashCodeOfStringMaskOffFlags");
			CompareInfo.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "m_name");
			CompareInfo.NativeFieldInfoPtr_m_sortName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "m_sortName");
			CompareInfo.NativeFieldInfoPtr_win32LCID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "win32LCID");
			CompareInfo.NativeFieldInfoPtr_culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "culture");
			CompareInfo.NativeFieldInfoPtr_LINGUISTIC_IGNORECASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "LINGUISTIC_IGNORECASE");
			CompareInfo.NativeFieldInfoPtr_NORM_IGNORECASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "NORM_IGNORECASE");
			CompareInfo.NativeFieldInfoPtr_NORM_IGNOREKANATYPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "NORM_IGNOREKANATYPE");
			CompareInfo.NativeFieldInfoPtr_LINGUISTIC_IGNOREDIACRITIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "LINGUISTIC_IGNOREDIACRITIC");
			CompareInfo.NativeFieldInfoPtr_NORM_IGNORENONSPACE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "NORM_IGNORENONSPACE");
			CompareInfo.NativeFieldInfoPtr_NORM_IGNORESYMBOLS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "NORM_IGNORESYMBOLS");
			CompareInfo.NativeFieldInfoPtr_NORM_IGNOREWIDTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "NORM_IGNOREWIDTH");
			CompareInfo.NativeFieldInfoPtr_SORT_STRINGSORT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "SORT_STRINGSORT");
			CompareInfo.NativeFieldInfoPtr_COMPARE_OPTIONS_ORDINAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "COMPARE_OPTIONS_ORDINAL");
			CompareInfo.NativeFieldInfoPtr_NORM_LINGUISTIC_CASING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "NORM_LINGUISTIC_CASING");
			CompareInfo.NativeFieldInfoPtr_RESERVED_FIND_ASCII_STRING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "RESERVED_FIND_ASCII_STRING");
			CompareInfo.NativeFieldInfoPtr_SORT_VERSION_WHIDBEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "SORT_VERSION_WHIDBEY");
			CompareInfo.NativeFieldInfoPtr_SORT_VERSION_V4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "SORT_VERSION_V4");
			CompareInfo.NativeFieldInfoPtr_m_SortVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "m_SortVersion");
			CompareInfo.NativeFieldInfoPtr_collator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "collator");
			CompareInfo.NativeFieldInfoPtr_collators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "collators");
			CompareInfo.NativeFieldInfoPtr_managedCollation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "managedCollation");
			CompareInfo.NativeFieldInfoPtr_managedCollationChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "managedCollationChecked");
			CompareInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669483);
			CompareInfo.NativeMethodInfoPtr_GetCompareInfo_Public_Static_CompareInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669484);
			CompareInfo.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669485);
			CompareInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669486);
			CompareInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669487);
			CompareInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669488);
			CompareInfo.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669489);
			CompareInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669490);
			CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669491);
			CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669492);
			CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669493);
			CompareInfo.NativeMethodInfoPtr_CompareOrdinal_Private_Static_Int32_String_Int32_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669494);
			CompareInfo.NativeMethodInfoPtr_IsPrefix_Public_Virtual_New_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669495);
			CompareInfo.NativeMethodInfoPtr_IsSuffix_Public_Virtual_New_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669496);
			CompareInfo.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669497);
			CompareInfo.NativeMethodInfoPtr_LastIndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669498);
			CompareInfo.NativeMethodInfoPtr_GetSortKey_Public_Virtual_New_SortKey_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669499);
			CompareInfo.NativeMethodInfoPtr_CreateSortKey_Private_SortKey_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669500);
			CompareInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669501);
			CompareInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669502);
			CompareInfo.NativeMethodInfoPtr_GetHashCodeOfString_Internal_Int32_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669503);
			CompareInfo.NativeMethodInfoPtr_GetHashCodeOfString_Internal_Int32_String_CompareOptions_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669504);
			CompareInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669505);
			CompareInfo.NativeMethodInfoPtr_get_UseManagedCollation_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669506);
			CompareInfo.NativeMethodInfoPtr_GetCollator_Private_SimpleCollator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669507);
			CompareInfo.NativeMethodInfoPtr_CreateSortKeyCore_Private_SortKey_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669508);
			CompareInfo.NativeMethodInfoPtr_internal_index_switch_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669509);
			CompareInfo.NativeMethodInfoPtr_internal_compare_switch_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669510);
			CompareInfo.NativeMethodInfoPtr_internal_compare_managed_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669511);
			CompareInfo.NativeMethodInfoPtr_internal_index_managed_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669512);
			CompareInfo.NativeMethodInfoPtr_assign_sortkey_Private_Void_Object_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669513);
			CompareInfo.NativeMethodInfoPtr_internal_compare_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669514);
			CompareInfo.NativeMethodInfoPtr_internal_index_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669515);
			CompareInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669516);
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x000C9C24 File Offset: 0x000C7E24
		[CallerCount(0)]
		public unsafe CompareInfo(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x000C9C70 File Offset: 0x000C7E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194292, XrefRangeEnd = 194303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CompareInfo GetCompareInfo(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_GetCompareInfo_Public_Static_CompareInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x000C9CB4 File Offset: 0x000C7EB4
		[CallerCount(0)]
		public unsafe void OnDeserializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x000C9CFC File Offset: 0x000C7EFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194310, RefRangeEnd = 194312, XrefRangeStart = 194303, XrefRangeEnd = 194310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x000C9D30 File Offset: 0x000C7F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194312, XrefRangeEnd = 194313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x000C9D78 File Offset: 0x000C7F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194313, XrefRangeEnd = 194317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x000C9DC0 File Offset: 0x000C7FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x000C9E04 File Offset: 0x000C8004
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194317, XrefRangeEnd = 194321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x000C9E48 File Offset: 0x000C8048
		[CallerCount(0)]
		public unsafe virtual int Compare(string string1, string string2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(string1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(string2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x000C9EB4 File Offset: 0x000C80B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194321, XrefRangeEnd = 194322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(string string1, string string2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(string1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(string2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x000C9F2C File Offset: 0x000C812C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194322, XrefRangeEnd = 194326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(string1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(string2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x000C9FE0 File Offset: 0x000C81E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194326, XrefRangeEnd = 194327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinal(string string1, int offset1, int length1, string string2, int offset2, int length2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(string1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(string2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_CompareOrdinal_Private_Static_Int32_String_Int32_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x000CA06C File Offset: 0x000C826C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194327, XrefRangeEnd = 194329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsPrefix(string source, string prefix, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_IsPrefix_Public_Virtual_New_Boolean_String_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x000CA0E4 File Offset: 0x000C82E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194329, XrefRangeEnd = 194331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsSuffix(string source, string suffix, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(suffix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_IsSuffix_Public_Virtual_New_Boolean_String_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x000CA15C File Offset: 0x000C835C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194331, XrefRangeEnd = 194332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x000CA1F0 File Offset: 0x000C83F0
		[CallerCount(0)]
		public unsafe virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_LastIndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x000CA284 File Offset: 0x000C8484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194332, XrefRangeEnd = 194349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SortKey GetSortKey(string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_GetSortKey_Public_Virtual_New_SortKey_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x000CA2F0 File Offset: 0x000C84F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey CreateSortKey(string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_CreateSortKey_Private_SortKey_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x000CA350 File Offset: 0x000C8550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194349, XrefRangeEnd = 194351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x000CA3A8 File Offset: 0x000C85A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194351, XrefRangeEnd = 194352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x000CA3F0 File Offset: 0x000C85F0
		[CallerCount(0)]
		public unsafe int GetHashCodeOfString(string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_GetHashCodeOfString_Internal_Int32_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x000CA44C File Offset: 0x000C864C
		[CallerCount(0)]
		public unsafe int GetHashCodeOfString(string source, CompareOptions options, bool forceRandomizedHashing, long additionalEntropy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceRandomizedHashing;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalEntropy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_GetHashCodeOfString_Internal_Int32_String_CompareOptions_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x000CA4C4 File Offset: 0x000C86C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194352, XrefRangeEnd = 194355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x000CA508 File Offset: 0x000C8708
		public unsafe static bool UseManagedCollation
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 194370, RefRangeEnd = 194375, XrefRangeStart = 194355, XrefRangeEnd = 194370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_get_UseManagedCollation_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x000CA538 File Offset: 0x000C8738
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 194407, RefRangeEnd = 194411, XrefRangeStart = 194375, XrefRangeEnd = 194407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleCollator GetCollator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_GetCollator_Private_SimpleCollator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleCollator>(intPtr3) : null;
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x000CA578 File Offset: 0x000C8778
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194422, RefRangeEnd = 194424, XrefRangeStart = 194411, XrefRangeEnd = 194422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey CreateSortKeyCore(string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_CreateSortKeyCore_Private_SortKey_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x000CA5D8 File Offset: 0x000C87D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194427, RefRangeEnd = 194428, XrefRangeStart = 194424, XrefRangeEnd = 194427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sindex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_index_switch_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x000CA670 File Offset: 0x000C8870
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194433, RefRangeEnd = 194435, XrefRangeStart = 194428, XrefRangeEnd = 194433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_compare_switch_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x000CA718 File Offset: 0x000C8918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194435, XrefRangeEnd = 194438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_compare_managed_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x000CA7C0 File Offset: 0x000C89C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194438, XrefRangeEnd = 194442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sindex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_index_managed_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x000CA858 File Offset: 0x000C8A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194442, XrefRangeEnd = 194450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void assign_sortkey(Object key, string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_assign_sortkey_Private_Void_Object_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x000CA8BC File Offset: 0x000C8ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194450, XrefRangeEnd = 194451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_compare_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x000CA964 File Offset: 0x000C8B64
		[CallerCount(0)]
		public unsafe int internal_index(string source, int sindex, int count, string value, CompareOptions options, bool first)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sindex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_index_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x000CA9FC File Offset: 0x000C8BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194451, XrefRangeEnd = 194454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompareInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x0000C561 File Offset: 0x0000A761
		public CompareInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06002504 RID: 9476 RVA: 0x000CAA38 File Offset: 0x000C8C38
		// (set) Token: 0x06002505 RID: 9477 RVA: 0x0000C56A File Offset: 0x0000A76A
		public unsafe static CompareOptions ValidIndexMaskOffFlags
		{
			get
			{
				CompareOptions compareOptions;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_ValidIndexMaskOffFlags, (void*)(&compareOptions));
				return compareOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_ValidIndexMaskOffFlags, (void*)(&value));
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06002506 RID: 9478 RVA: 0x000CAA54 File Offset: 0x000C8C54
		// (set) Token: 0x06002507 RID: 9479 RVA: 0x0000C578 File Offset: 0x0000A778
		public unsafe static CompareOptions ValidCompareMaskOffFlags
		{
			get
			{
				CompareOptions compareOptions;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_ValidCompareMaskOffFlags, (void*)(&compareOptions));
				return compareOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_ValidCompareMaskOffFlags, (void*)(&value));
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06002508 RID: 9480 RVA: 0x000CAA70 File Offset: 0x000C8C70
		// (set) Token: 0x06002509 RID: 9481 RVA: 0x0000C586 File Offset: 0x0000A786
		public unsafe static CompareOptions ValidHashCodeOfStringMaskOffFlags
		{
			get
			{
				CompareOptions compareOptions;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_ValidHashCodeOfStringMaskOffFlags, (void*)(&compareOptions));
				return compareOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_ValidHashCodeOfStringMaskOffFlags, (void*)(&value));
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x0600250A RID: 9482 RVA: 0x000CAA8C File Offset: 0x000C8C8C
		// (set) Token: 0x0600250B RID: 9483 RVA: 0x0000C594 File Offset: 0x0000A794
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x0600250C RID: 9484 RVA: 0x000CAAB4 File Offset: 0x000C8CB4
		// (set) Token: 0x0600250D RID: 9485 RVA: 0x0000C5B3 File Offset: 0x0000A7B3
		public unsafe string m_sortName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_m_sortName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_m_sortName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x0600250E RID: 9486 RVA: 0x000CAADC File Offset: 0x000C8CDC
		// (set) Token: 0x0600250F RID: 9487 RVA: 0x0000C5D2 File Offset: 0x0000A7D2
		public unsafe int win32LCID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_win32LCID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_win32LCID)) = value;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06002510 RID: 9488 RVA: 0x000CAB04 File Offset: 0x000C8D04
		// (set) Token: 0x06002511 RID: 9489 RVA: 0x0000C5ED File Offset: 0x0000A7ED
		public unsafe int culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_culture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_culture)) = value;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x000CAB2C File Offset: 0x000C8D2C
		// (set) Token: 0x06002513 RID: 9491 RVA: 0x0000C608 File Offset: 0x0000A808
		public unsafe static int LINGUISTIC_IGNORECASE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_LINGUISTIC_IGNORECASE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_LINGUISTIC_IGNORECASE, (void*)(&value));
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x000CAB48 File Offset: 0x000C8D48
		// (set) Token: 0x06002515 RID: 9493 RVA: 0x0000C616 File Offset: 0x0000A816
		public unsafe static int NORM_IGNORECASE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNORECASE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNORECASE, (void*)(&value));
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x000CAB64 File Offset: 0x000C8D64
		// (set) Token: 0x06002517 RID: 9495 RVA: 0x0000C624 File Offset: 0x0000A824
		public unsafe static int NORM_IGNOREKANATYPE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNOREKANATYPE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNOREKANATYPE, (void*)(&value));
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x000CAB80 File Offset: 0x000C8D80
		// (set) Token: 0x06002519 RID: 9497 RVA: 0x0000C632 File Offset: 0x0000A832
		public unsafe static int LINGUISTIC_IGNOREDIACRITIC
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_LINGUISTIC_IGNOREDIACRITIC, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_LINGUISTIC_IGNOREDIACRITIC, (void*)(&value));
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x000CAB9C File Offset: 0x000C8D9C
		// (set) Token: 0x0600251B RID: 9499 RVA: 0x0000C640 File Offset: 0x0000A840
		public unsafe static int NORM_IGNORENONSPACE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNORENONSPACE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNORENONSPACE, (void*)(&value));
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x000CABB8 File Offset: 0x000C8DB8
		// (set) Token: 0x0600251D RID: 9501 RVA: 0x0000C64E File Offset: 0x0000A84E
		public unsafe static int NORM_IGNORESYMBOLS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNORESYMBOLS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNORESYMBOLS, (void*)(&value));
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x000CABD4 File Offset: 0x000C8DD4
		// (set) Token: 0x0600251F RID: 9503 RVA: 0x0000C65C File Offset: 0x0000A85C
		public unsafe static int NORM_IGNOREWIDTH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNOREWIDTH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNOREWIDTH, (void*)(&value));
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x000CABF0 File Offset: 0x000C8DF0
		// (set) Token: 0x06002521 RID: 9505 RVA: 0x0000C66A File Offset: 0x0000A86A
		public unsafe static int SORT_STRINGSORT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_SORT_STRINGSORT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_SORT_STRINGSORT, (void*)(&value));
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x000CAC0C File Offset: 0x000C8E0C
		// (set) Token: 0x06002523 RID: 9507 RVA: 0x0000C678 File Offset: 0x0000A878
		public unsafe static int COMPARE_OPTIONS_ORDINAL
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_COMPARE_OPTIONS_ORDINAL, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_COMPARE_OPTIONS_ORDINAL, (void*)(&value));
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06002524 RID: 9508 RVA: 0x000CAC28 File Offset: 0x000C8E28
		// (set) Token: 0x06002525 RID: 9509 RVA: 0x0000C686 File Offset: 0x0000A886
		public unsafe static int NORM_LINGUISTIC_CASING
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_NORM_LINGUISTIC_CASING, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_NORM_LINGUISTIC_CASING, (void*)(&value));
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x000CAC44 File Offset: 0x000C8E44
		// (set) Token: 0x06002527 RID: 9511 RVA: 0x0000C694 File Offset: 0x0000A894
		public unsafe static int RESERVED_FIND_ASCII_STRING
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_RESERVED_FIND_ASCII_STRING, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_RESERVED_FIND_ASCII_STRING, (void*)(&value));
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x000CAC60 File Offset: 0x000C8E60
		// (set) Token: 0x06002529 RID: 9513 RVA: 0x0000C6A2 File Offset: 0x0000A8A2
		public unsafe static int SORT_VERSION_WHIDBEY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_SORT_VERSION_WHIDBEY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_SORT_VERSION_WHIDBEY, (void*)(&value));
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x000CAC7C File Offset: 0x000C8E7C
		// (set) Token: 0x0600252B RID: 9515 RVA: 0x0000C6B0 File Offset: 0x0000A8B0
		public unsafe static int SORT_VERSION_V4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_SORT_VERSION_V4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_SORT_VERSION_V4, (void*)(&value));
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x000CAC98 File Offset: 0x000C8E98
		// (set) Token: 0x0600252D RID: 9517 RVA: 0x0000C6BE File Offset: 0x0000A8BE
		public unsafe SortVersion m_SortVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_m_SortVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortVersion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_m_SortVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x000CACC8 File Offset: 0x000C8EC8
		// (set) Token: 0x0600252F RID: 9519 RVA: 0x0000C6DD File Offset: 0x0000A8DD
		public unsafe SimpleCollator collator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_collator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleCollator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_collator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x000CACF8 File Offset: 0x000C8EF8
		// (set) Token: 0x06002531 RID: 9521 RVA: 0x0000C6FC File Offset: 0x0000A8FC
		public unsafe static Dictionary<string, SimpleCollator> collators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_collators, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SimpleCollator>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_collators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x000CAD20 File Offset: 0x000C8F20
		// (set) Token: 0x06002533 RID: 9523 RVA: 0x0000C70E File Offset: 0x0000A90E
		public unsafe static bool managedCollation
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_managedCollation, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_managedCollation, (void*)(&value));
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x000CAD3C File Offset: 0x000C8F3C
		// (set) Token: 0x06002535 RID: 9525 RVA: 0x0000C71C File Offset: 0x0000A91C
		public unsafe static bool managedCollationChecked
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_managedCollationChecked, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_managedCollationChecked, (void*)(&value));
			}
		}

		// Token: 0x040020FD RID: 8445
		private static readonly IntPtr NativeFieldInfoPtr_ValidIndexMaskOffFlags;

		// Token: 0x040020FE RID: 8446
		private static readonly IntPtr NativeFieldInfoPtr_ValidCompareMaskOffFlags;

		// Token: 0x040020FF RID: 8447
		private static readonly IntPtr NativeFieldInfoPtr_ValidHashCodeOfStringMaskOffFlags;

		// Token: 0x04002100 RID: 8448
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x04002101 RID: 8449
		private static readonly IntPtr NativeFieldInfoPtr_m_sortName;

		// Token: 0x04002102 RID: 8450
		private static readonly IntPtr NativeFieldInfoPtr_win32LCID;

		// Token: 0x04002103 RID: 8451
		private static readonly IntPtr NativeFieldInfoPtr_culture;

		// Token: 0x04002104 RID: 8452
		private static readonly IntPtr NativeFieldInfoPtr_LINGUISTIC_IGNORECASE;

		// Token: 0x04002105 RID: 8453
		private static readonly IntPtr NativeFieldInfoPtr_NORM_IGNORECASE;

		// Token: 0x04002106 RID: 8454
		private static readonly IntPtr NativeFieldInfoPtr_NORM_IGNOREKANATYPE;

		// Token: 0x04002107 RID: 8455
		private static readonly IntPtr NativeFieldInfoPtr_LINGUISTIC_IGNOREDIACRITIC;

		// Token: 0x04002108 RID: 8456
		private static readonly IntPtr NativeFieldInfoPtr_NORM_IGNORENONSPACE;

		// Token: 0x04002109 RID: 8457
		private static readonly IntPtr NativeFieldInfoPtr_NORM_IGNORESYMBOLS;

		// Token: 0x0400210A RID: 8458
		private static readonly IntPtr NativeFieldInfoPtr_NORM_IGNOREWIDTH;

		// Token: 0x0400210B RID: 8459
		private static readonly IntPtr NativeFieldInfoPtr_SORT_STRINGSORT;

		// Token: 0x0400210C RID: 8460
		private static readonly IntPtr NativeFieldInfoPtr_COMPARE_OPTIONS_ORDINAL;

		// Token: 0x0400210D RID: 8461
		private static readonly IntPtr NativeFieldInfoPtr_NORM_LINGUISTIC_CASING;

		// Token: 0x0400210E RID: 8462
		private static readonly IntPtr NativeFieldInfoPtr_RESERVED_FIND_ASCII_STRING;

		// Token: 0x0400210F RID: 8463
		private static readonly IntPtr NativeFieldInfoPtr_SORT_VERSION_WHIDBEY;

		// Token: 0x04002110 RID: 8464
		private static readonly IntPtr NativeFieldInfoPtr_SORT_VERSION_V4;

		// Token: 0x04002111 RID: 8465
		private static readonly IntPtr NativeFieldInfoPtr_m_SortVersion;

		// Token: 0x04002112 RID: 8466
		private static readonly IntPtr NativeFieldInfoPtr_collator;

		// Token: 0x04002113 RID: 8467
		private static readonly IntPtr NativeFieldInfoPtr_collators;

		// Token: 0x04002114 RID: 8468
		private static readonly IntPtr NativeFieldInfoPtr_managedCollation;

		// Token: 0x04002115 RID: 8469
		private static readonly IntPtr NativeFieldInfoPtr_managedCollationChecked;

		// Token: 0x04002116 RID: 8470
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_0;

		// Token: 0x04002117 RID: 8471
		private static readonly IntPtr NativeMethodInfoPtr_GetCompareInfo_Public_Static_CompareInfo_String_0;

		// Token: 0x04002118 RID: 8472
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0;

		// Token: 0x04002119 RID: 8473
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_0;

		// Token: 0x0400211A RID: 8474
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x0400211B RID: 8475
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x0400211C RID: 8476
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400211D RID: 8477
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x0400211E RID: 8478
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_0;

		// Token: 0x0400211F RID: 8479
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_CompareOptions_0;

		// Token: 0x04002120 RID: 8480
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04002121 RID: 8481
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinal_Private_Static_Int32_String_Int32_Int32_String_Int32_Int32_0;

		// Token: 0x04002122 RID: 8482
		private static readonly IntPtr NativeMethodInfoPtr_IsPrefix_Public_Virtual_New_Boolean_String_String_CompareOptions_0;

		// Token: 0x04002123 RID: 8483
		private static readonly IntPtr NativeMethodInfoPtr_IsSuffix_Public_Virtual_New_Boolean_String_String_CompareOptions_0;

		// Token: 0x04002124 RID: 8484
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04002125 RID: 8485
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04002126 RID: 8486
		private static readonly IntPtr NativeMethodInfoPtr_GetSortKey_Public_Virtual_New_SortKey_String_CompareOptions_0;

		// Token: 0x04002127 RID: 8487
		private static readonly IntPtr NativeMethodInfoPtr_CreateSortKey_Private_SortKey_String_CompareOptions_0;

		// Token: 0x04002128 RID: 8488
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002129 RID: 8489
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400212A RID: 8490
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeOfString_Internal_Int32_String_CompareOptions_0;

		// Token: 0x0400212B RID: 8491
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeOfString_Internal_Int32_String_CompareOptions_Boolean_Int64_0;

		// Token: 0x0400212C RID: 8492
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400212D RID: 8493
		private static readonly IntPtr NativeMethodInfoPtr_get_UseManagedCollation_Private_Static_get_Boolean_0;

		// Token: 0x0400212E RID: 8494
		private static readonly IntPtr NativeMethodInfoPtr_GetCollator_Private_SimpleCollator_0;

		// Token: 0x0400212F RID: 8495
		private static readonly IntPtr NativeMethodInfoPtr_CreateSortKeyCore_Private_SortKey_String_CompareOptions_0;

		// Token: 0x04002130 RID: 8496
		private static readonly IntPtr NativeMethodInfoPtr_internal_index_switch_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0;

		// Token: 0x04002131 RID: 8497
		private static readonly IntPtr NativeMethodInfoPtr_internal_compare_switch_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04002132 RID: 8498
		private static readonly IntPtr NativeMethodInfoPtr_internal_compare_managed_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04002133 RID: 8499
		private static readonly IntPtr NativeMethodInfoPtr_internal_index_managed_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0;

		// Token: 0x04002134 RID: 8500
		private static readonly IntPtr NativeMethodInfoPtr_assign_sortkey_Private_Void_Object_String_CompareOptions_0;

		// Token: 0x04002135 RID: 8501
		private static readonly IntPtr NativeMethodInfoPtr_internal_compare_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04002136 RID: 8502
		private static readonly IntPtr NativeMethodInfoPtr_internal_index_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0;

		// Token: 0x04002137 RID: 8503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
