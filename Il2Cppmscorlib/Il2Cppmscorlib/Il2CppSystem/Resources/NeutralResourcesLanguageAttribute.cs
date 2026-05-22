using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Resources
{
	// Token: 0x02000183 RID: 387
	public sealed class NeutralResourcesLanguageAttribute : Attribute
	{
		// Token: 0x06001AD5 RID: 6869 RVA: 0x0009E7C0 File Offset: 0x0009C9C0
		// Note: this type is marked as 'beforefieldinit'.
		static NeutralResourcesLanguageAttribute()
		{
			Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "NeutralResourcesLanguageAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr);
			NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, "_culture");
			NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__fallbackLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, "_fallbackLoc");
			NeutralResourcesLanguageAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, 100667896);
			NeutralResourcesLanguageAttribute.NativeMethodInfoPtr_get_CultureName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, 100667897);
			NeutralResourcesLanguageAttribute.NativeMethodInfoPtr_get_Location_Public_get_UltimateResourceFallbackLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, 100667898);
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0009E854 File Offset: 0x0009CA54
		[CallerCount(0)]
		public unsafe NeutralResourcesLanguageAttribute(string cultureName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NeutralResourcesLanguageAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x0009E8A0 File Offset: 0x0009CAA0
		public unsafe string CultureName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NeutralResourcesLanguageAttribute.NativeMethodInfoPtr_get_CultureName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x0009E8D8 File Offset: 0x0009CAD8
		public unsafe UltimateResourceFallbackLocation Location
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NeutralResourcesLanguageAttribute.NativeMethodInfoPtr_get_Location_Public_get_UltimateResourceFallbackLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00008FF8 File Offset: 0x000071F8
		public NeutralResourcesLanguageAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x0009E914 File Offset: 0x0009CB14
		// (set) Token: 0x06001ADB RID: 6875 RVA: 0x00009001 File Offset: 0x00007201
		public unsafe string _culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__culture);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__culture), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x0009E93C File Offset: 0x0009CB3C
		// (set) Token: 0x06001ADD RID: 6877 RVA: 0x00009020 File Offset: 0x00007220
		public unsafe UltimateResourceFallbackLocation _fallbackLoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__fallbackLoc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__fallbackLoc)) = value;
			}
		}

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeFieldInfoPtr__culture;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeFieldInfoPtr__fallbackLoc;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureName_Public_get_String_0;

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_get_UltimateResourceFallbackLocation_0;
	}
}
