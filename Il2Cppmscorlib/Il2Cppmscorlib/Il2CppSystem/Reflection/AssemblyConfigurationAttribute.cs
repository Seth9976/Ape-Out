using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000195 RID: 405
	public sealed class AssemblyConfigurationAttribute : Attribute
	{
		// Token: 0x06001BD2 RID: 7122 RVA: 0x000A1E7C File Offset: 0x000A007C
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyConfigurationAttribute()
		{
			Il2CppClassPointerStore<AssemblyConfigurationAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyConfigurationAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyConfigurationAttribute>.NativeClassPtr);
			AssemblyConfigurationAttribute.NativeFieldInfoPtr_m_configuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyConfigurationAttribute>.NativeClassPtr, "m_configuration");
			AssemblyConfigurationAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyConfigurationAttribute>.NativeClassPtr, 100668026);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x000A1ED4 File Offset: 0x000A00D4
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyConfigurationAttribute(string configuration)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyConfigurationAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(configuration);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyConfigurationAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00009749 File Offset: 0x00007949
		public AssemblyConfigurationAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x000A1F20 File Offset: 0x000A0120
		// (set) Token: 0x06001BD6 RID: 7126 RVA: 0x00009752 File Offset: 0x00007952
		public unsafe string m_configuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyConfigurationAttribute.NativeFieldInfoPtr_m_configuration);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyConfigurationAttribute.NativeFieldInfoPtr_m_configuration), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001929 RID: 6441
		private static readonly IntPtr NativeFieldInfoPtr_m_configuration;

		// Token: 0x0400192A RID: 6442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
