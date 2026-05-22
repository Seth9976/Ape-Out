using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200037E RID: 894
	public sealed class TypeInformation : Object
	{
		// Token: 0x06003A28 RID: 14888 RVA: 0x00117B20 File Offset: 0x00115D20
		// Note: this type is marked as 'beforefieldinit'.
		static TypeInformation()
		{
			Il2CppClassPointerStore<TypeInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "TypeInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr);
			TypeInformation.NativeFieldInfoPtr_fullTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, "fullTypeName");
			TypeInformation.NativeFieldInfoPtr_assemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, "assemblyString");
			TypeInformation.NativeFieldInfoPtr_hasTypeForwardedFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, "hasTypeForwardedFrom");
			TypeInformation.NativeMethodInfoPtr_get_FullTypeName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, 100672088);
			TypeInformation.NativeMethodInfoPtr_get_AssemblyString_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, 100672089);
			TypeInformation.NativeMethodInfoPtr_get_HasTypeForwardedFrom_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, 100672090);
			TypeInformation.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, 100672091);
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06003A29 RID: 14889 RVA: 0x00117BDC File Offset: 0x00115DDC
		public unsafe string FullTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInformation.NativeMethodInfoPtr_get_FullTypeName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06003A2A RID: 14890 RVA: 0x00117C14 File Offset: 0x00115E14
		public unsafe string AssemblyString
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInformation.NativeMethodInfoPtr_get_AssemblyString_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06003A2B RID: 14891 RVA: 0x00117C4C File Offset: 0x00115E4C
		public unsafe bool HasTypeForwardedFrom
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInformation.NativeMethodInfoPtr_get_HasTypeForwardedFrom_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x00117C88 File Offset: 0x00115E88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207526, RefRangeEnd = 207528, XrefRangeStart = 207526, XrefRangeEnd = 207528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullTypeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasTypeForwardedFrom;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInformation.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A2D RID: 14893 RVA: 0x0001538C File Offset: 0x0001358C
		public TypeInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06003A2E RID: 14894 RVA: 0x00117CF4 File Offset: 0x00115EF4
		// (set) Token: 0x06003A2F RID: 14895 RVA: 0x00015395 File Offset: 0x00013595
		public unsafe string fullTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_fullTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_fullTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06003A30 RID: 14896 RVA: 0x00117D1C File Offset: 0x00115F1C
		// (set) Token: 0x06003A31 RID: 14897 RVA: 0x000153B4 File Offset: 0x000135B4
		public unsafe string assemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_assemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_assemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06003A32 RID: 14898 RVA: 0x00117D44 File Offset: 0x00115F44
		// (set) Token: 0x06003A33 RID: 14899 RVA: 0x000153D3 File Offset: 0x000135D3
		public unsafe bool hasTypeForwardedFrom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_hasTypeForwardedFrom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_hasTypeForwardedFrom)) = value;
			}
		}

		// Token: 0x040030CE RID: 12494
		private static readonly IntPtr NativeFieldInfoPtr_fullTypeName;

		// Token: 0x040030CF RID: 12495
		private static readonly IntPtr NativeFieldInfoPtr_assemblyString;

		// Token: 0x040030D0 RID: 12496
		private static readonly IntPtr NativeFieldInfoPtr_hasTypeForwardedFrom;

		// Token: 0x040030D1 RID: 12497
		private static readonly IntPtr NativeMethodInfoPtr_get_FullTypeName_Internal_get_String_0;

		// Token: 0x040030D2 RID: 12498
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyString_Internal_get_String_0;

		// Token: 0x040030D3 RID: 12499
		private static readonly IntPtr NativeMethodInfoPtr_get_HasTypeForwardedFrom_Internal_get_Boolean_0;

		// Token: 0x040030D4 RID: 12500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0;
	}
}
