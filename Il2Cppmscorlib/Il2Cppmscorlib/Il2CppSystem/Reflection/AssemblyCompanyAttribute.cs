using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000192 RID: 402
	public sealed class AssemblyCompanyAttribute : Attribute
	{
		// Token: 0x06001BC3 RID: 7107 RVA: 0x000A1C18 File Offset: 0x0009FE18
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyCompanyAttribute()
		{
			Il2CppClassPointerStore<AssemblyCompanyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyCompanyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyCompanyAttribute>.NativeClassPtr);
			AssemblyCompanyAttribute.NativeFieldInfoPtr_m_company = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyCompanyAttribute>.NativeClassPtr, "m_company");
			AssemblyCompanyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyCompanyAttribute>.NativeClassPtr, 100668023);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x000A1C70 File Offset: 0x0009FE70
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyCompanyAttribute(string company)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyCompanyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(company);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyCompanyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x000096D1 File Offset: 0x000078D1
		public AssemblyCompanyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x000A1CBC File Offset: 0x0009FEBC
		// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x000096DA File Offset: 0x000078DA
		public unsafe string m_company
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyCompanyAttribute.NativeFieldInfoPtr_m_company);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyCompanyAttribute.NativeFieldInfoPtr_m_company), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeFieldInfoPtr_m_company;

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
