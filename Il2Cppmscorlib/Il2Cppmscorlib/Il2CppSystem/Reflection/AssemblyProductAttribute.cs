using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000191 RID: 401
	public sealed class AssemblyProductAttribute : Attribute
	{
		// Token: 0x06001BBE RID: 7102 RVA: 0x000A1B4C File Offset: 0x0009FD4C
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyProductAttribute()
		{
			Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyProductAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr);
			AssemblyProductAttribute.NativeFieldInfoPtr_m_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr, "m_product");
			AssemblyProductAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr, 100668022);
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x000A1BA4 File Offset: 0x0009FDA4
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyProductAttribute(string product)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyProductAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x000096A9 File Offset: 0x000078A9
		public AssemblyProductAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x000A1BF0 File Offset: 0x0009FDF0
		// (set) Token: 0x06001BC2 RID: 7106 RVA: 0x000096B2 File Offset: 0x000078B2
		public unsafe string m_product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyProductAttribute.NativeFieldInfoPtr_m_product);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyProductAttribute.NativeFieldInfoPtr_m_product), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeFieldInfoPtr_m_product;

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
