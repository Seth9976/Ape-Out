using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002DF RID: 735
	public sealed class CspParameters : Object
	{
		// Token: 0x0600315F RID: 12639 RVA: 0x000F845C File Offset: 0x000F665C
		// Note: this type is marked as 'beforefieldinit'.
		static CspParameters()
		{
			Il2CppClassPointerStore<CspParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CspParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CspParameters>.NativeClassPtr);
			CspParameters.NativeFieldInfoPtr_ProviderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "ProviderType");
			CspParameters.NativeFieldInfoPtr_ProviderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "ProviderName");
			CspParameters.NativeFieldInfoPtr_KeyContainerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "KeyContainerName");
			CspParameters.NativeFieldInfoPtr_KeyNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "KeyNumber");
			CspParameters.NativeFieldInfoPtr_m_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "m_flags");
			CspParameters.NativeMethodInfoPtr_get_Flags_Public_get_CspProviderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100671120);
			CspParameters.NativeMethodInfoPtr_set_Flags_Public_set_Void_CspProviderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100671121);
			CspParameters.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100671122);
			CspParameters.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100671123);
			CspParameters.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100671124);
			CspParameters.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_CspProviderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100671125);
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06003160 RID: 12640 RVA: 0x000F8568 File Offset: 0x000F6768
		// (set) Token: 0x06003161 RID: 12641 RVA: 0x000F85A4 File Offset: 0x000F67A4
		public unsafe CspProviderFlags Flags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr_get_Flags_Public_get_CspProviderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 209218, RefRangeEnd = 209227, XrefRangeStart = 209218, XrefRangeEnd = 209218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr_set_Flags_Public_set_Void_CspProviderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x000F85E4 File Offset: 0x000F67E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209227, XrefRangeEnd = 209228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CspParameters()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CspParameters>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x000F8620 File Offset: 0x000F6820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209228, XrefRangeEnd = 209229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CspParameters(int dwTypeIn)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CspParameters>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwTypeIn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x000F8668 File Offset: 0x000F6868
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 209230, RefRangeEnd = 209239, XrefRangeStart = 209229, XrefRangeEnd = 209230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CspParameters>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwTypeIn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strProviderNameIn);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strContainerNameIn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x000F86D4 File Offset: 0x000F68D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209239, XrefRangeEnd = 209240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CspParameters>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref providerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyContainerName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_CspProviderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x000113E8 File Offset: 0x0000F5E8
		public CspParameters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06003167 RID: 12647 RVA: 0x000F8750 File Offset: 0x000F6950
		// (set) Token: 0x06003168 RID: 12648 RVA: 0x000113F1 File Offset: 0x0000F5F1
		public unsafe int ProviderType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_ProviderType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_ProviderType)) = value;
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06003169 RID: 12649 RVA: 0x000F8778 File Offset: 0x000F6978
		// (set) Token: 0x0600316A RID: 12650 RVA: 0x0001140C File Offset: 0x0000F60C
		public unsafe string ProviderName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_ProviderName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_ProviderName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x000F87A0 File Offset: 0x000F69A0
		// (set) Token: 0x0600316C RID: 12652 RVA: 0x0001142B File Offset: 0x0000F62B
		public unsafe string KeyContainerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_KeyContainerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_KeyContainerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x0600316D RID: 12653 RVA: 0x000F87C8 File Offset: 0x000F69C8
		// (set) Token: 0x0600316E RID: 12654 RVA: 0x0001144A File Offset: 0x0000F64A
		public unsafe int KeyNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_KeyNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_KeyNumber)) = value;
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x0600316F RID: 12655 RVA: 0x000F87F0 File Offset: 0x000F69F0
		// (set) Token: 0x06003170 RID: 12656 RVA: 0x00011465 File Offset: 0x0000F665
		public unsafe int m_flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_m_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_m_flags)) = value;
			}
		}

		// Token: 0x04002A7A RID: 10874
		private static readonly IntPtr NativeFieldInfoPtr_ProviderType;

		// Token: 0x04002A7B RID: 10875
		private static readonly IntPtr NativeFieldInfoPtr_ProviderName;

		// Token: 0x04002A7C RID: 10876
		private static readonly IntPtr NativeFieldInfoPtr_KeyContainerName;

		// Token: 0x04002A7D RID: 10877
		private static readonly IntPtr NativeFieldInfoPtr_KeyNumber;

		// Token: 0x04002A7E RID: 10878
		private static readonly IntPtr NativeFieldInfoPtr_m_flags;

		// Token: 0x04002A7F RID: 10879
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_get_CspProviderFlags_0;

		// Token: 0x04002A80 RID: 10880
		private static readonly IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_CspProviderFlags_0;

		// Token: 0x04002A81 RID: 10881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A82 RID: 10882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002A83 RID: 10883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_0;

		// Token: 0x04002A84 RID: 10884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_CspProviderFlags_0;
	}
}
