using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x02000112 RID: 274
	public sealed class HeaderVariantInfo : ValueType
	{
		// Token: 0x06000F41 RID: 3905 RVA: 0x00049B40 File Offset: 0x00047D40
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderVariantInfo()
		{
			Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HeaderVariantInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr);
			HeaderVariantInfo.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, "m_name");
			HeaderVariantInfo.NativeFieldInfoPtr_m_variant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, "m_variant");
			HeaderVariantInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_CookieVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, 100665487);
			HeaderVariantInfo.NativeMethodInfoPtr_get_Name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, 100665488);
			HeaderVariantInfo.NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, 100665489);
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00049BD4 File Offset: 0x00047DD4
		[CallerCount(0)]
		public unsafe HeaderVariantInfo(string name, CookieVariant variant)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref variant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderVariantInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_CookieVariant_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00049C34 File Offset: 0x00047E34
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderVariantInfo.NativeMethodInfoPtr_get_Name_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x00049C70 File Offset: 0x00047E70
		public unsafe CookieVariant Variant
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderVariantInfo.NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00007FF8 File Offset: 0x000061F8
		public HeaderVariantInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00008001 File Offset: 0x00006201
		public HeaderVariantInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr))
		{
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x00049CB4 File Offset: 0x00047EB4
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x00008013 File Offset: 0x00006213
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderVariantInfo.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderVariantInfo.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x00049CDC File Offset: 0x00047EDC
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x00008032 File Offset: 0x00006232
		public unsafe CookieVariant m_variant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderVariantInfo.NativeFieldInfoPtr_m_variant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderVariantInfo.NativeFieldInfoPtr_m_variant)) = value;
			}
		}

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeFieldInfoPtr_m_variant;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_CookieVariant_0;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_String_0;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0;
	}
}
