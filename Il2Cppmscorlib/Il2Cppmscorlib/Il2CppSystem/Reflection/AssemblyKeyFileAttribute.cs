using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000199 RID: 409
	public sealed class AssemblyKeyFileAttribute : Attribute
	{
		// Token: 0x06001BE6 RID: 7142 RVA: 0x000A21AC File Offset: 0x000A03AC
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyKeyFileAttribute()
		{
			Il2CppClassPointerStore<AssemblyKeyFileAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyKeyFileAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyKeyFileAttribute>.NativeClassPtr);
			AssemblyKeyFileAttribute.NativeFieldInfoPtr_m_keyFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyKeyFileAttribute>.NativeClassPtr, "m_keyFile");
			AssemblyKeyFileAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyKeyFileAttribute>.NativeClassPtr, 100668030);
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x000A2204 File Offset: 0x000A0404
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyKeyFileAttribute(string keyFile)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyKeyFileAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyKeyFileAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x000097E9 File Offset: 0x000079E9
		public AssemblyKeyFileAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x000A2250 File Offset: 0x000A0450
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x000097F2 File Offset: 0x000079F2
		public unsafe string m_keyFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyKeyFileAttribute.NativeFieldInfoPtr_m_keyFile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyKeyFileAttribute.NativeFieldInfoPtr_m_keyFile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeFieldInfoPtr_m_keyFile;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
