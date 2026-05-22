using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020003A3 RID: 931
	public class TypeEntry : Object
	{
		// Token: 0x06003DA2 RID: 15778 RVA: 0x00123D94 File Offset: 0x00121F94
		// Note: this type is marked as 'beforefieldinit'.
		static TypeEntry()
		{
			Il2CppClassPointerStore<TypeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "TypeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr);
			TypeEntry.NativeFieldInfoPtr_assembly_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, "assembly_name");
			TypeEntry.NativeFieldInfoPtr_type_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, "type_name");
			TypeEntry.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, 100672444);
			TypeEntry.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, 100672445);
			TypeEntry.NativeMethodInfoPtr_set_AssemblyName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, 100672446);
			TypeEntry.NativeMethodInfoPtr_get_TypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, 100672447);
			TypeEntry.NativeMethodInfoPtr_set_TypeName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, 100672448);
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x00123E50 File Offset: 0x00122050
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeEntry.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06003DA4 RID: 15780 RVA: 0x00123E8C File Offset: 0x0012208C
		// (set) Token: 0x06003DA5 RID: 15781 RVA: 0x00123EC4 File Offset: 0x001220C4
		public unsafe string AssemblyName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeEntry.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeEntry.NativeMethodInfoPtr_set_AssemblyName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06003DA6 RID: 15782 RVA: 0x00123F08 File Offset: 0x00122108
		// (set) Token: 0x06003DA7 RID: 15783 RVA: 0x00123F40 File Offset: 0x00122140
		public unsafe string TypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeEntry.NativeMethodInfoPtr_get_TypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeEntry.NativeMethodInfoPtr_set_TypeName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x00016F87 File Offset: 0x00015187
		public TypeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06003DA9 RID: 15785 RVA: 0x00123F84 File Offset: 0x00122184
		// (set) Token: 0x06003DAA RID: 15786 RVA: 0x00016F90 File Offset: 0x00015190
		public unsafe string assembly_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeEntry.NativeFieldInfoPtr_assembly_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeEntry.NativeFieldInfoPtr_assembly_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06003DAB RID: 15787 RVA: 0x00123FAC File Offset: 0x001221AC
		// (set) Token: 0x06003DAC RID: 15788 RVA: 0x00016FAF File Offset: 0x000151AF
		public unsafe string type_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeEntry.NativeFieldInfoPtr_type_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeEntry.NativeFieldInfoPtr_type_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003311 RID: 13073
		private static readonly IntPtr NativeFieldInfoPtr_assembly_name;

		// Token: 0x04003312 RID: 13074
		private static readonly IntPtr NativeFieldInfoPtr_type_name;

		// Token: 0x04003313 RID: 13075
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003314 RID: 13076
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0;

		// Token: 0x04003315 RID: 13077
		private static readonly IntPtr NativeMethodInfoPtr_set_AssemblyName_Public_set_Void_String_0;

		// Token: 0x04003316 RID: 13078
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_get_String_0;

		// Token: 0x04003317 RID: 13079
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeName_Public_set_Void_String_0;
	}
}
