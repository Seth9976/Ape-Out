using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000197 RID: 407
	public sealed class AssemblyInformationalVersionAttribute : Attribute
	{
		// Token: 0x06001BDC RID: 7132 RVA: 0x000A2014 File Offset: 0x000A0214
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyInformationalVersionAttribute()
		{
			Il2CppClassPointerStore<AssemblyInformationalVersionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyInformationalVersionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyInformationalVersionAttribute>.NativeClassPtr);
			AssemblyInformationalVersionAttribute.NativeFieldInfoPtr_m_informationalVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyInformationalVersionAttribute>.NativeClassPtr, "m_informationalVersion");
			AssemblyInformationalVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyInformationalVersionAttribute>.NativeClassPtr, 100668028);
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x000A206C File Offset: 0x000A026C
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyInformationalVersionAttribute(string informationalVersion)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyInformationalVersionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(informationalVersion);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyInformationalVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x00009799 File Offset: 0x00007999
		public AssemblyInformationalVersionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x000A20B8 File Offset: 0x000A02B8
		// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x000097A2 File Offset: 0x000079A2
		public unsafe string m_informationalVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyInformationalVersionAttribute.NativeFieldInfoPtr_m_informationalVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyInformationalVersionAttribute.NativeFieldInfoPtr_m_informationalVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeFieldInfoPtr_m_informationalVersion;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
