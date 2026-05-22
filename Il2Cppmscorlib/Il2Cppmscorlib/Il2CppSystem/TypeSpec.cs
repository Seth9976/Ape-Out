using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000146 RID: 326
	public class TypeSpec : Object
	{
		// Token: 0x0600170C RID: 5900 RVA: 0x0008C034 File Offset: 0x0008A234
		// Note: this type is marked as 'beforefieldinit'.
		static TypeSpec()
		{
			Il2CppClassPointerStore<TypeSpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeSpec");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr);
			TypeSpec.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "name");
			TypeSpec.NativeFieldInfoPtr_assembly_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "assembly_name");
			TypeSpec.NativeFieldInfoPtr_nested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "nested");
			TypeSpec.NativeFieldInfoPtr_generic_params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "generic_params");
			TypeSpec.NativeFieldInfoPtr_modifier_spec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "modifier_spec");
			TypeSpec.NativeFieldInfoPtr_is_byref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "is_byref");
			TypeSpec.NativeFieldInfoPtr_display_fullname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "display_fullname");
			TypeSpec.NativeMethodInfoPtr_get_HasModifiers_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667226);
			TypeSpec.NativeMethodInfoPtr_GetDisplayFullName_Private_String_DisplayNameFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667227);
			TypeSpec.NativeMethodInfoPtr_GetModifierString_Private_StringBuilder_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667228);
			TypeSpec.NativeMethodInfoPtr_get_DisplayFullName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667229);
			TypeSpec.NativeMethodInfoPtr_Parse_Internal_Static_TypeSpec_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667230);
			TypeSpec.NativeMethodInfoPtr_UnescapeInternalName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667231);
			TypeSpec.NativeMethodInfoPtr_Resolve_Internal_Type_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667232);
			TypeSpec.NativeMethodInfoPtr_AddName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667233);
			TypeSpec.NativeMethodInfoPtr_AddModifier_Private_Void_ModifierSpec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667234);
			TypeSpec.NativeMethodInfoPtr_SkipSpace_Private_Static_Void_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667235);
			TypeSpec.NativeMethodInfoPtr_BoundCheck_Private_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667236);
			TypeSpec.NativeMethodInfoPtr_ParsedTypeIdentifier_Private_Static_TypeIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667237);
			TypeSpec.NativeMethodInfoPtr_Parse_Private_Static_TypeSpec_String_byref_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667238);
			TypeSpec.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667239);
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x0008C208 File Offset: 0x0008A408
		public unsafe bool HasModifiers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_get_HasModifiers_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x0008C244 File Offset: 0x0008A444
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 178694, RefRangeEnd = 178697, XrefRangeStart = 178651, XrefRangeEnd = 178694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDisplayFullName(TypeSpec.DisplayNameFormat flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_GetDisplayFullName_Private_String_DisplayNameFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x0008C288 File Offset: 0x0008A488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178710, RefRangeEnd = 178711, XrefRangeStart = 178697, XrefRangeEnd = 178710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder GetModifierString(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_GetModifierString_Private_StringBuilder_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x0008C2D8 File Offset: 0x0008A4D8
		public unsafe string DisplayFullName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 178712, RefRangeEnd = 178713, XrefRangeStart = 178711, XrefRangeEnd = 178712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_get_DisplayFullName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x0008C310 File Offset: 0x0008A510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178713, XrefRangeEnd = 178714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeSpec Parse(string typeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_Parse_Internal_Static_TypeSpec_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeSpec>(intPtr3) : null;
			}
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x0008C354 File Offset: 0x0008A554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178714, XrefRangeEnd = 178730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnescapeInternalName(string displayName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_UnescapeInternalName_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x0008C390 File Offset: 0x0008A590
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178754, RefRangeEnd = 178756, XrefRangeStart = 178730, XrefRangeEnd = 178754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assemblyResolver);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeResolver);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_Resolve_Internal_Type_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x0008C410 File Offset: 0x0008A610
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178767, RefRangeEnd = 178769, XrefRangeStart = 178756, XrefRangeEnd = 178767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddName(string type_name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type_name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_AddName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x0008C454 File Offset: 0x0008A654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178769, XrefRangeEnd = 178779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddModifier(ModifierSpec md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_AddModifier_Private_Void_ModifierSpec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x0008C498 File Offset: 0x0008A698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178784, RefRangeEnd = 178785, XrefRangeStart = 178779, XrefRangeEnd = 178784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SkipSpace(string name, ref int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_SkipSpace_Private_Static_Void_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x0008C4DC File Offset: 0x0008A6DC
		[CallerCount(0)]
		public unsafe static void BoundCheck(int idx, string s)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_BoundCheck_Private_Static_Void_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x0008C520 File Offset: 0x0008A720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178785, XrefRangeEnd = 178786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeIdentifier ParsedTypeIdentifier(string displayName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_ParsedTypeIdentifier_Private_Static_TypeIdentifier_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x0008C564 File Offset: 0x0008A764
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 178801, RefRangeEnd = 178804, XrefRangeStart = 178786, XrefRangeEnd = 178801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &p;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref is_recurse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allow_aqn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_Parse_Private_Static_TypeSpec_String_byref_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeSpec>(intPtr3) : null;
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x0008C5D4 File Offset: 0x0008A7D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeSpec()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00008009 File Offset: 0x00006209
		public TypeSpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x0008C610 File Offset: 0x0008A810
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x00008012 File Offset: 0x00006212
		public unsafe TypeIdentifier name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeIdentifier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x0008C640 File Offset: 0x0008A840
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x00008031 File Offset: 0x00006231
		public unsafe string assembly_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_assembly_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_assembly_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x0008C668 File Offset: 0x0008A868
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x00008050 File Offset: 0x00006250
		public unsafe List<TypeIdentifier> nested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_nested);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TypeIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_nested), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x0008C698 File Offset: 0x0008A898
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x0000806F File Offset: 0x0000626F
		public unsafe List<TypeSpec> generic_params
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_generic_params);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TypeSpec>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_generic_params), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x0008C6C8 File Offset: 0x0008A8C8
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x0000808E File Offset: 0x0000628E
		public unsafe List<ModifierSpec> modifier_spec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_modifier_spec);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ModifierSpec>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_modifier_spec), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x0008C6F8 File Offset: 0x0008A8F8
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x000080AD File Offset: 0x000062AD
		public unsafe bool is_byref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_is_byref);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_is_byref)) = value;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x0008C720 File Offset: 0x0008A920
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x000080C8 File Offset: 0x000062C8
		public unsafe string display_fullname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_display_fullname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_display_fullname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeFieldInfoPtr_assembly_name;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeFieldInfoPtr_nested;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeFieldInfoPtr_generic_params;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeFieldInfoPtr_modifier_spec;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeFieldInfoPtr_is_byref;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeFieldInfoPtr_display_fullname;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr_get_HasModifiers_Internal_get_Boolean_0;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayFullName_Private_String_DisplayNameFormat_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr_GetModifierString_Private_StringBuilder_StringBuilder_0;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayFullName_Internal_get_String_0;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_TypeSpec_String_0;

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeInternalName_Internal_Static_String_String_0;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Internal_Type_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_0;

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeMethodInfoPtr_AddName_Private_Void_String_0;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeMethodInfoPtr_AddModifier_Private_Void_ModifierSpec_0;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeMethodInfoPtr_SkipSpace_Private_Static_Void_String_byref_Int32_0;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeMethodInfoPtr_BoundCheck_Private_Static_Void_Int32_String_0;

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeMethodInfoPtr_ParsedTypeIdentifier_Private_Static_TypeIdentifier_String_0;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Private_Static_TypeSpec_String_byref_Int32_Boolean_Boolean_0;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005B3 RID: 1459
		[OriginalName("mscorlib.dll", "", "DisplayNameFormat")]
		[Flags]
		public enum DisplayNameFormat
		{
			// Token: 0x0400426A RID: 17002
			Default = 0,
			// Token: 0x0400426B RID: 17003
			WANT_ASSEMBLY = 1,
			// Token: 0x0400426C RID: 17004
			NO_MODIFIERS = 2
		}
	}
}
