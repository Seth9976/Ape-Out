using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200033B RID: 827
	public class TypeLoadExceptionHolder : Object
	{
		// Token: 0x0600365E RID: 13918 RVA: 0x0010AF10 File Offset: 0x00109110
		// Note: this type is marked as 'beforefieldinit'.
		static TypeLoadExceptionHolder()
		{
			Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "TypeLoadExceptionHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr);
			TypeLoadExceptionHolder.NativeFieldInfoPtr_m_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr, "m_typeName");
			TypeLoadExceptionHolder.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr, 100671754);
			TypeLoadExceptionHolder.NativeMethodInfoPtr_get_TypeName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr, 100671755);
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x0010AF7C File Offset: 0x0010917C
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeLoadExceptionHolder(string typeName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadExceptionHolder.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06003660 RID: 13920 RVA: 0x0010AFC8 File Offset: 0x001091C8
		public unsafe string TypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadExceptionHolder.NativeMethodInfoPtr_get_TypeName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x000133F3 File Offset: 0x000115F3
		public TypeLoadExceptionHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06003662 RID: 13922 RVA: 0x0010B000 File Offset: 0x00109200
		// (set) Token: 0x06003663 RID: 13923 RVA: 0x000133FC File Offset: 0x000115FC
		public unsafe string m_typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadExceptionHolder.NativeFieldInfoPtr_m_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadExceptionHolder.NativeFieldInfoPtr_m_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002DE8 RID: 11752
		private static readonly IntPtr NativeFieldInfoPtr_m_typeName;

		// Token: 0x04002DE9 RID: 11753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04002DEA RID: 11754
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Internal_get_String_0;
	}
}
