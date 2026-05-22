using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000196 RID: 406
	public sealed class AssemblyDefaultAliasAttribute : Attribute
	{
		// Token: 0x06001BD7 RID: 7127 RVA: 0x000A1F48 File Offset: 0x000A0148
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyDefaultAliasAttribute()
		{
			Il2CppClassPointerStore<AssemblyDefaultAliasAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyDefaultAliasAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyDefaultAliasAttribute>.NativeClassPtr);
			AssemblyDefaultAliasAttribute.NativeFieldInfoPtr_m_defaultAlias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyDefaultAliasAttribute>.NativeClassPtr, "m_defaultAlias");
			AssemblyDefaultAliasAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyDefaultAliasAttribute>.NativeClassPtr, 100668027);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x000A1FA0 File Offset: 0x000A01A0
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyDefaultAliasAttribute(string defaultAlias)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyDefaultAliasAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(defaultAlias);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyDefaultAliasAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x00009771 File Offset: 0x00007971
		public AssemblyDefaultAliasAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x000A1FEC File Offset: 0x000A01EC
		// (set) Token: 0x06001BDB RID: 7131 RVA: 0x0000977A File Offset: 0x0000797A
		public unsafe string m_defaultAlias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDefaultAliasAttribute.NativeFieldInfoPtr_m_defaultAlias);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDefaultAliasAttribute.NativeFieldInfoPtr_m_defaultAlias), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400192B RID: 6443
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultAlias;

		// Token: 0x0400192C RID: 6444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
