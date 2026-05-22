using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x02000012 RID: 18
	public class NativeTypeAttribute : Attribute
	{
		// Token: 0x06000076 RID: 118 RVA: 0x000039EC File Offset: 0x00001BEC
		// Note: this type is marked as 'beforefieldinit'.
		static NativeTypeAttribute()
		{
			Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr);
			NativeTypeAttribute.NativeFieldInfoPtr__Header_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, "<Header>k__BackingField");
			NativeTypeAttribute.NativeFieldInfoPtr__IntermediateScriptingStructName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, "<IntermediateScriptingStructName>k__BackingField");
			NativeTypeAttribute.NativeFieldInfoPtr__CodegenOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, "<CodegenOptions>k__BackingField");
			NativeTypeAttribute.NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663333);
			NativeTypeAttribute.NativeMethodInfoPtr_set_IntermediateScriptingStructName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663334);
			NativeTypeAttribute.NativeMethodInfoPtr_set_CodegenOptions_Public_Virtual_Final_New_set_Void_CodegenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663335);
			NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663336);
			NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663337);
			NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663338);
			NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663339);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000024E6 File Offset: 0x000006E6
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00003AE4 File Offset: 0x00001CE4
		public unsafe virtual string Header
		{
			get
			{
				return this._Header_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000024EE File Offset: 0x000006EE
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00003B28 File Offset: 0x00001D28
		public unsafe string IntermediateScriptingStructName
		{
			get
			{
				return this._IntermediateScriptingStructName_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr_set_IntermediateScriptingStructName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000024F6 File Offset: 0x000006F6
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00003B6C File Offset: 0x00001D6C
		public unsafe virtual CodegenOptions CodegenOptions
		{
			get
			{
				return this._CodegenOptions_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr_set_CodegenOptions_Public_Virtual_Final_New_set_Void_CodegenOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003BAC File Offset: 0x00001DAC
		[CallerCount(0)]
		public unsafe NativeTypeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[CallerCount(0)]
		public unsafe NativeTypeAttribute(CodegenOptions codegenOptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codegenOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003C30 File Offset: 0x00001E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513977, XrefRangeEnd = 513993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeTypeAttribute(string header)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003C7C File Offset: 0x00001E7C
		[CallerCount(0)]
		public unsafe NativeTypeAttribute(CodegenOptions codegenOptions, string intermediateStructName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codegenOptions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(intermediateStructName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002484 File Offset: 0x00000684
		public NativeTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00003CD8 File Offset: 0x00001ED8
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000248D File Offset: 0x0000068D
		public unsafe string _Header_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__Header_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__Header_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00003D00 File Offset: 0x00001F00
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000024AC File Offset: 0x000006AC
		public unsafe string _IntermediateScriptingStructName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__IntermediateScriptingStructName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__IntermediateScriptingStructName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00003D28 File Offset: 0x00001F28
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000024CB File Offset: 0x000006CB
		public unsafe CodegenOptions _CodegenOptions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__CodegenOptions_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__CodegenOptions_k__BackingField)) = value;
			}
		}

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr__Header_k__BackingField;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr__IntermediateScriptingStructName_k__BackingField;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr__CodegenOptions_k__BackingField;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_set_IntermediateScriptingStructName_Public_set_Void_String_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_set_CodegenOptions_Public_Virtual_Final_New_set_Void_CodegenOptions_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_String_0;
	}
}
