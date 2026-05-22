using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000193 RID: 403
	public sealed class AssemblyDescriptionAttribute : Attribute
	{
		// Token: 0x06001BC8 RID: 7112 RVA: 0x000A1CE4 File Offset: 0x0009FEE4
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyDescriptionAttribute()
		{
			Il2CppClassPointerStore<AssemblyDescriptionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyDescriptionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyDescriptionAttribute>.NativeClassPtr);
			AssemblyDescriptionAttribute.NativeFieldInfoPtr_m_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyDescriptionAttribute>.NativeClassPtr, "m_description");
			AssemblyDescriptionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyDescriptionAttribute>.NativeClassPtr, 100668024);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x000A1D3C File Offset: 0x0009FF3C
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyDescriptionAttribute(string description)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyDescriptionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyDescriptionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x000096F9 File Offset: 0x000078F9
		public AssemblyDescriptionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x000A1D88 File Offset: 0x0009FF88
		// (set) Token: 0x06001BCC RID: 7116 RVA: 0x00009702 File Offset: 0x00007902
		public unsafe string m_description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDescriptionAttribute.NativeFieldInfoPtr_m_description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDescriptionAttribute.NativeFieldInfoPtr_m_description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001925 RID: 6437
		private static readonly IntPtr NativeFieldInfoPtr_m_description;

		// Token: 0x04001926 RID: 6438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
