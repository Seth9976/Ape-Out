using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A1 RID: 417
	public class XmlSchemaElement : XmlSchemaParticle
	{
		// Token: 0x0600221E RID: 8734 RVA: 0x0009FD5C File Offset: 0x0009DF5C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaElement()
		{
			Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr);
			XmlSchemaElement.NativeFieldInfoPtr_isAbstract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "isAbstract");
			XmlSchemaElement.NativeFieldInfoPtr_hasAbstractAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "hasAbstractAttribute");
			XmlSchemaElement.NativeFieldInfoPtr_isNillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "isNillable");
			XmlSchemaElement.NativeFieldInfoPtr_hasNillableAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "hasNillableAttribute");
			XmlSchemaElement.NativeFieldInfoPtr_isLocalTypeDerivationChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "isLocalTypeDerivationChecked");
			XmlSchemaElement.NativeFieldInfoPtr_block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "block");
			XmlSchemaElement.NativeFieldInfoPtr_final = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "final");
			XmlSchemaElement.NativeFieldInfoPtr_form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "form");
			XmlSchemaElement.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "defaultValue");
			XmlSchemaElement.NativeFieldInfoPtr_fixedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "fixedValue");
			XmlSchemaElement.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "name");
			XmlSchemaElement.NativeFieldInfoPtr_refName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "refName");
			XmlSchemaElement.NativeFieldInfoPtr_substitutionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "substitutionGroup");
			XmlSchemaElement.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "typeName");
			XmlSchemaElement.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "type");
			XmlSchemaElement.NativeFieldInfoPtr_qualifiedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "qualifiedName");
			XmlSchemaElement.NativeFieldInfoPtr_elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "elementType");
			XmlSchemaElement.NativeFieldInfoPtr_blockResolved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "blockResolved");
			XmlSchemaElement.NativeFieldInfoPtr_finalResolved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "finalResolved");
			XmlSchemaElement.NativeFieldInfoPtr_constraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "constraints");
			XmlSchemaElement.NativeFieldInfoPtr_elementDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "elementDecl");
			XmlSchemaElement.NativeMethodInfoPtr_get_IsAbstract_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668166);
			XmlSchemaElement.NativeMethodInfoPtr_set_IsAbstract_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668167);
			XmlSchemaElement.NativeMethodInfoPtr_get_Block_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668168);
			XmlSchemaElement.NativeMethodInfoPtr_set_Block_Public_set_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668169);
			XmlSchemaElement.NativeMethodInfoPtr_get_DefaultValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668170);
			XmlSchemaElement.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668171);
			XmlSchemaElement.NativeMethodInfoPtr_get_Final_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668172);
			XmlSchemaElement.NativeMethodInfoPtr_set_Final_Public_set_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668173);
			XmlSchemaElement.NativeMethodInfoPtr_get_FixedValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668174);
			XmlSchemaElement.NativeMethodInfoPtr_set_FixedValue_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668175);
			XmlSchemaElement.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668176);
			XmlSchemaElement.NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668177);
			XmlSchemaElement.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668178);
			XmlSchemaElement.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668179);
			XmlSchemaElement.NativeMethodInfoPtr_get_IsNillable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668180);
			XmlSchemaElement.NativeMethodInfoPtr_set_IsNillable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668181);
			XmlSchemaElement.NativeMethodInfoPtr_get_HasNillableAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668182);
			XmlSchemaElement.NativeMethodInfoPtr_get_HasAbstractAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668183);
			XmlSchemaElement.NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668184);
			XmlSchemaElement.NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668185);
			XmlSchemaElement.NativeMethodInfoPtr_get_SubstitutionGroup_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668186);
			XmlSchemaElement.NativeMethodInfoPtr_set_SubstitutionGroup_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668187);
			XmlSchemaElement.NativeMethodInfoPtr_get_SchemaTypeName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668188);
			XmlSchemaElement.NativeMethodInfoPtr_set_SchemaTypeName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668189);
			XmlSchemaElement.NativeMethodInfoPtr_get_SchemaType_Public_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668190);
			XmlSchemaElement.NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668191);
			XmlSchemaElement.NativeMethodInfoPtr_get_Constraints_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668192);
			XmlSchemaElement.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668193);
			XmlSchemaElement.NativeMethodInfoPtr_get_ElementSchemaType_Public_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668194);
			XmlSchemaElement.NativeMethodInfoPtr_get_BlockResolved_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668195);
			XmlSchemaElement.NativeMethodInfoPtr_get_FinalResolved_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668196);
			XmlSchemaElement.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668197);
			XmlSchemaElement.NativeMethodInfoPtr_SetElementType_Internal_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668198);
			XmlSchemaElement.NativeMethodInfoPtr_SetBlockResolved_Internal_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668199);
			XmlSchemaElement.NativeMethodInfoPtr_SetFinalResolved_Internal_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668200);
			XmlSchemaElement.NativeMethodInfoPtr_get_HasConstraints_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668201);
			XmlSchemaElement.NativeMethodInfoPtr_get_IsLocalTypeDerivationChecked_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668202);
			XmlSchemaElement.NativeMethodInfoPtr_set_IsLocalTypeDerivationChecked_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668203);
			XmlSchemaElement.NativeMethodInfoPtr_get_ElementDecl_Internal_get_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668204);
			XmlSchemaElement.NativeMethodInfoPtr_set_ElementDecl_Internal_set_Void_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668205);
			XmlSchemaElement.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668206);
			XmlSchemaElement.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668207);
			XmlSchemaElement.NativeMethodInfoPtr_get_NameString_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668208);
			XmlSchemaElement.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668209);
			XmlSchemaElement.NativeMethodInfoPtr_Clone_Internal_XmlSchemaObject_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668210);
			XmlSchemaElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668211);
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x0600221F RID: 8735 RVA: 0x000A02C8 File Offset: 0x0009E4C8
		// (set) Token: 0x06002220 RID: 8736 RVA: 0x000A0304 File Offset: 0x0009E504
		public unsafe bool IsAbstract
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_IsAbstract_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_IsAbstract_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06002221 RID: 8737 RVA: 0x000A0344 File Offset: 0x0009E544
		// (set) Token: 0x06002222 RID: 8738 RVA: 0x000A0380 File Offset: 0x0009E580
		public unsafe XmlSchemaDerivationMethod Block
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_Block_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_Block_Public_set_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x000A03C0 File Offset: 0x0009E5C0
		// (set) Token: 0x06002224 RID: 8740 RVA: 0x000A03F8 File Offset: 0x0009E5F8
		public unsafe string DefaultValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_DefaultValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 388203, RefRangeEnd = 388211, XrefRangeStart = 388203, XrefRangeEnd = 388211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06002225 RID: 8741 RVA: 0x000A043C File Offset: 0x0009E63C
		// (set) Token: 0x06002226 RID: 8742 RVA: 0x000A0478 File Offset: 0x0009E678
		public unsafe XmlSchemaDerivationMethod Final
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_Final_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_Final_Public_set_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06002227 RID: 8743 RVA: 0x000A04B8 File Offset: 0x0009E6B8
		// (set) Token: 0x06002228 RID: 8744 RVA: 0x000A04F0 File Offset: 0x0009E6F0
		public unsafe string FixedValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_FixedValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 224553, RefRangeEnd = 224561, XrefRangeStart = 224553, XrefRangeEnd = 224561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_FixedValue_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06002229 RID: 8745 RVA: 0x000A0534 File Offset: 0x0009E734
		// (set) Token: 0x0600222A RID: 8746 RVA: 0x000A0570 File Offset: 0x0009E770
		public unsafe XmlSchemaForm Form
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x0600222B RID: 8747 RVA: 0x000A05B0 File Offset: 0x0009E7B0
		// (set) Token: 0x0600222C RID: 8748 RVA: 0x000A05E8 File Offset: 0x0009E7E8
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 413738, RefRangeEnd = 413741, XrefRangeStart = 413738, XrefRangeEnd = 413741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x0600222D RID: 8749 RVA: 0x000A062C File Offset: 0x0009E82C
		// (set) Token: 0x0600222E RID: 8750 RVA: 0x000A0668 File Offset: 0x0009E868
		public unsafe bool IsNillable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_IsNillable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_IsNillable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x000A06A8 File Offset: 0x0009E8A8
		public unsafe bool HasNillableAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_HasNillableAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x000A06E4 File Offset: 0x0009E8E4
		public unsafe bool HasAbstractAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_HasAbstractAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06002231 RID: 8753 RVA: 0x000A0720 File Offset: 0x0009E920
		// (set) Token: 0x06002232 RID: 8754 RVA: 0x000A0760 File Offset: 0x0009E960
		public unsafe XmlQualifiedName RefName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427146, XrefRangeEnd = 427152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06002233 RID: 8755 RVA: 0x000A07A4 File Offset: 0x0009E9A4
		// (set) Token: 0x06002234 RID: 8756 RVA: 0x000A07E4 File Offset: 0x0009E9E4
		public unsafe XmlQualifiedName SubstitutionGroup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_SubstitutionGroup_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427152, XrefRangeEnd = 427158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_SubstitutionGroup_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x000A0828 File Offset: 0x0009EA28
		// (set) Token: 0x06002236 RID: 8758 RVA: 0x000A0868 File Offset: 0x0009EA68
		public unsafe XmlQualifiedName SchemaTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_SchemaTypeName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 427164, RefRangeEnd = 427165, XrefRangeStart = 427158, XrefRangeEnd = 427164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_SchemaTypeName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002237 RID: 8759 RVA: 0x000A08AC File Offset: 0x0009EAAC
		// (set) Token: 0x06002238 RID: 8760 RVA: 0x000A08EC File Offset: 0x0009EAEC
		public unsafe XmlSchemaType SchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_SchemaType_Public_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 386301, RefRangeEnd = 386305, XrefRangeStart = 386301, XrefRangeEnd = 386305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x000A0930 File Offset: 0x0009EB30
		public unsafe XmlSchemaObjectCollection Constraints
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 427169, RefRangeEnd = 427185, XrefRangeStart = 427165, XrefRangeEnd = 427169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_Constraints_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x000A0970 File Offset: 0x0009EB70
		public unsafe XmlQualifiedName QualifiedName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x0600223B RID: 8763 RVA: 0x000A09B0 File Offset: 0x0009EBB0
		public unsafe XmlSchemaType ElementSchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_ElementSchemaType_Public_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x000A09F0 File Offset: 0x0009EBF0
		public unsafe XmlSchemaDerivationMethod BlockResolved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_BlockResolved_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x0600223D RID: 8765 RVA: 0x000A0A2C File Offset: 0x0009EC2C
		public unsafe XmlSchemaDerivationMethod FinalResolved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_FinalResolved_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x000A0A68 File Offset: 0x0009EC68
		[CallerCount(0)]
		public unsafe void SetQualifiedName(XmlQualifiedName value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x000A0AAC File Offset: 0x0009ECAC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 386310, RefRangeEnd = 386323, XrefRangeStart = 386310, XrefRangeEnd = 386323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetElementType(XmlSchemaType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_SetElementType_Internal_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x000A0AF0 File Offset: 0x0009ECF0
		[CallerCount(0)]
		public unsafe void SetBlockResolved(XmlSchemaDerivationMethod value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_SetBlockResolved_Internal_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x000A0B30 File Offset: 0x0009ED30
		[CallerCount(0)]
		public unsafe void SetFinalResolved(XmlSchemaDerivationMethod value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_SetFinalResolved_Internal_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x000A0B70 File Offset: 0x0009ED70
		public unsafe bool HasConstraints
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 427185, RefRangeEnd = 427189, XrefRangeStart = 427185, XrefRangeEnd = 427185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_HasConstraints_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002243 RID: 8771 RVA: 0x000A0BAC File Offset: 0x0009EDAC
		// (set) Token: 0x06002244 RID: 8772 RVA: 0x000A0BE8 File Offset: 0x0009EDE8
		public unsafe bool IsLocalTypeDerivationChecked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_IsLocalTypeDerivationChecked_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_IsLocalTypeDerivationChecked_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x000A0C28 File Offset: 0x0009EE28
		// (set) Token: 0x06002246 RID: 8774 RVA: 0x000A0C68 File Offset: 0x0009EE68
		public unsafe SchemaElementDecl ElementDecl
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_ElementDecl_Internal_get_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 92148, RefRangeEnd = 92153, XrefRangeStart = 92148, XrefRangeEnd = 92153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_ElementDecl_Internal_set_Void_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x000A0CAC File Offset: 0x0009EEAC
		// (set) Token: 0x06002248 RID: 8776 RVA: 0x000A0CF0 File Offset: 0x0009EEF0
		public unsafe override string NameAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaElement.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 413738, RefRangeEnd = 413741, XrefRangeStart = 413738, XrefRangeEnd = 413741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaElement.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x000A0D40 File Offset: 0x0009EF40
		public unsafe override string NameString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427189, XrefRangeEnd = 427190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaElement.NativeMethodInfoPtr_get_NameString_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x000A0D84 File Offset: 0x0009EF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427190, XrefRangeEnd = 427191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlSchemaObject Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaElement.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x000A0DD0 File Offset: 0x0009EFD0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 427206, RefRangeEnd = 427210, XrefRangeStart = 427191, XrefRangeEnd = 427206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaObject Clone(XmlSchema parentSchema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_Clone_Internal_XmlSchemaObject_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x000A0E20 File Offset: 0x0009F020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 427221, RefRangeEnd = 427222, XrefRangeStart = 427210, XrefRangeEnd = 427221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x0000EC47 File Offset: 0x0000CE47
		public XmlSchemaElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x000A0E5C File Offset: 0x0009F05C
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x0000EC50 File Offset: 0x0000CE50
		public unsafe bool isAbstract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_isAbstract);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_isAbstract)) = value;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x000A0E84 File Offset: 0x0009F084
		// (set) Token: 0x06002251 RID: 8785 RVA: 0x0000EC6B File Offset: 0x0000CE6B
		public unsafe bool hasAbstractAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_hasAbstractAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_hasAbstractAttribute)) = value;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x000A0EAC File Offset: 0x0009F0AC
		// (set) Token: 0x06002253 RID: 8787 RVA: 0x0000EC86 File Offset: 0x0000CE86
		public unsafe bool isNillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_isNillable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_isNillable)) = value;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x000A0ED4 File Offset: 0x0009F0D4
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x0000ECA1 File Offset: 0x0000CEA1
		public unsafe bool hasNillableAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_hasNillableAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_hasNillableAttribute)) = value;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x000A0EFC File Offset: 0x0009F0FC
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x0000ECBC File Offset: 0x0000CEBC
		public unsafe bool isLocalTypeDerivationChecked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_isLocalTypeDerivationChecked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_isLocalTypeDerivationChecked)) = value;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06002258 RID: 8792 RVA: 0x000A0F24 File Offset: 0x0009F124
		// (set) Token: 0x06002259 RID: 8793 RVA: 0x0000ECD7 File Offset: 0x0000CED7
		public unsafe XmlSchemaDerivationMethod block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_block);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_block)) = value;
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x000A0F4C File Offset: 0x0009F14C
		// (set) Token: 0x0600225B RID: 8795 RVA: 0x0000ECF2 File Offset: 0x0000CEF2
		public unsafe XmlSchemaDerivationMethod final
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_final);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_final)) = value;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x000A0F74 File Offset: 0x0009F174
		// (set) Token: 0x0600225D RID: 8797 RVA: 0x0000ED0D File Offset: 0x0000CF0D
		public unsafe XmlSchemaForm form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_form);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_form)) = value;
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x000A0F9C File Offset: 0x0009F19C
		// (set) Token: 0x0600225F RID: 8799 RVA: 0x0000ED28 File Offset: 0x0000CF28
		public unsafe string defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_defaultValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_defaultValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x000A0FC4 File Offset: 0x0009F1C4
		// (set) Token: 0x06002261 RID: 8801 RVA: 0x0000ED47 File Offset: 0x0000CF47
		public unsafe string fixedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_fixedValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_fixedValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x000A0FEC File Offset: 0x0009F1EC
		// (set) Token: 0x06002263 RID: 8803 RVA: 0x0000ED66 File Offset: 0x0000CF66
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x000A1014 File Offset: 0x0009F214
		// (set) Token: 0x06002265 RID: 8805 RVA: 0x0000ED85 File Offset: 0x0000CF85
		public unsafe XmlQualifiedName refName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_refName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_refName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x000A1044 File Offset: 0x0009F244
		// (set) Token: 0x06002267 RID: 8807 RVA: 0x0000EDA4 File Offset: 0x0000CFA4
		public unsafe XmlQualifiedName substitutionGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_substitutionGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_substitutionGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x000A1074 File Offset: 0x0009F274
		// (set) Token: 0x06002269 RID: 8809 RVA: 0x0000EDC3 File Offset: 0x0000CFC3
		public unsafe XmlQualifiedName typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_typeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_typeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x000A10A4 File Offset: 0x0009F2A4
		// (set) Token: 0x0600226B RID: 8811 RVA: 0x0000EDE2 File Offset: 0x0000CFE2
		public unsafe XmlSchemaType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x000A10D4 File Offset: 0x0009F2D4
		// (set) Token: 0x0600226D RID: 8813 RVA: 0x0000EE01 File Offset: 0x0000D001
		public unsafe XmlQualifiedName qualifiedName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_qualifiedName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_qualifiedName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x000A1104 File Offset: 0x0009F304
		// (set) Token: 0x0600226F RID: 8815 RVA: 0x0000EE20 File Offset: 0x0000D020
		public unsafe XmlSchemaType elementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_elementType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_elementType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06002270 RID: 8816 RVA: 0x000A1134 File Offset: 0x0009F334
		// (set) Token: 0x06002271 RID: 8817 RVA: 0x0000EE3F File Offset: 0x0000D03F
		public unsafe XmlSchemaDerivationMethod blockResolved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_blockResolved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_blockResolved)) = value;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x000A115C File Offset: 0x0009F35C
		// (set) Token: 0x06002273 RID: 8819 RVA: 0x0000EE5A File Offset: 0x0000D05A
		public unsafe XmlSchemaDerivationMethod finalResolved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_finalResolved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_finalResolved)) = value;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x000A1184 File Offset: 0x0009F384
		// (set) Token: 0x06002275 RID: 8821 RVA: 0x0000EE75 File Offset: 0x0000D075
		public unsafe XmlSchemaObjectCollection constraints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_constraints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_constraints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x000A11B4 File Offset: 0x0009F3B4
		// (set) Token: 0x06002277 RID: 8823 RVA: 0x0000EE94 File Offset: 0x0000D094
		public unsafe SchemaElementDecl elementDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_elementDecl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_elementDecl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400195E RID: 6494
		private static readonly IntPtr NativeFieldInfoPtr_isAbstract;

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeFieldInfoPtr_hasAbstractAttribute;

		// Token: 0x04001960 RID: 6496
		private static readonly IntPtr NativeFieldInfoPtr_isNillable;

		// Token: 0x04001961 RID: 6497
		private static readonly IntPtr NativeFieldInfoPtr_hasNillableAttribute;

		// Token: 0x04001962 RID: 6498
		private static readonly IntPtr NativeFieldInfoPtr_isLocalTypeDerivationChecked;

		// Token: 0x04001963 RID: 6499
		private static readonly IntPtr NativeFieldInfoPtr_block;

		// Token: 0x04001964 RID: 6500
		private static readonly IntPtr NativeFieldInfoPtr_final;

		// Token: 0x04001965 RID: 6501
		private static readonly IntPtr NativeFieldInfoPtr_form;

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeFieldInfoPtr_defaultValue;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeFieldInfoPtr_fixedValue;

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeFieldInfoPtr_refName;

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeFieldInfoPtr_substitutionGroup;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeFieldInfoPtr_qualifiedName;

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeFieldInfoPtr_elementType;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeFieldInfoPtr_blockResolved;

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeFieldInfoPtr_finalResolved;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeFieldInfoPtr_constraints;

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeFieldInfoPtr_elementDecl;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAbstract_Public_get_Boolean_0;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAbstract_Public_set_Void_Boolean_0;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeMethodInfoPtr_get_Block_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeMethodInfoPtr_set_Block_Public_set_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_get_String_0;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_String_0;

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeMethodInfoPtr_get_Final_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeMethodInfoPtr_set_Final_Public_set_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x0400197B RID: 6523
		private static readonly IntPtr NativeMethodInfoPtr_get_FixedValue_Public_get_String_0;

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeMethodInfoPtr_set_FixedValue_Public_set_Void_String_0;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0;

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0;

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNillable_Public_get_Boolean_0;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeMethodInfoPtr_set_IsNillable_Public_set_Void_Boolean_0;

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNillableAttribute_Internal_get_Boolean_0;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeMethodInfoPtr_get_HasAbstractAttribute_Internal_get_Boolean_0;

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeMethodInfoPtr_get_SubstitutionGroup_Public_get_XmlQualifiedName_0;

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeMethodInfoPtr_set_SubstitutionGroup_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaTypeName_Public_get_XmlQualifiedName_0;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaTypeName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Public_get_XmlSchemaType_0;

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaType_0;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeMethodInfoPtr_get_Constraints_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x0400198E RID: 6542
		private static readonly IntPtr NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0;

		// Token: 0x0400198F RID: 6543
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementSchemaType_Public_get_XmlSchemaType_0;

		// Token: 0x04001990 RID: 6544
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockResolved_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x04001991 RID: 6545
		private static readonly IntPtr NativeMethodInfoPtr_get_FinalResolved_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x04001992 RID: 6546
		private static readonly IntPtr NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0;

		// Token: 0x04001993 RID: 6547
		private static readonly IntPtr NativeMethodInfoPtr_SetElementType_Internal_Void_XmlSchemaType_0;

		// Token: 0x04001994 RID: 6548
		private static readonly IntPtr NativeMethodInfoPtr_SetBlockResolved_Internal_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001995 RID: 6549
		private static readonly IntPtr NativeMethodInfoPtr_SetFinalResolved_Internal_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001996 RID: 6550
		private static readonly IntPtr NativeMethodInfoPtr_get_HasConstraints_Internal_get_Boolean_0;

		// Token: 0x04001997 RID: 6551
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalTypeDerivationChecked_Internal_get_Boolean_0;

		// Token: 0x04001998 RID: 6552
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLocalTypeDerivationChecked_Internal_set_Void_Boolean_0;

		// Token: 0x04001999 RID: 6553
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementDecl_Internal_get_SchemaElementDecl_0;

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeMethodInfoPtr_set_ElementDecl_Internal_set_Void_SchemaElementDecl_0;

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0;

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeMethodInfoPtr_get_NameString_Internal_Virtual_get_String_0;

		// Token: 0x0400199E RID: 6558
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0;

		// Token: 0x0400199F RID: 6559
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_XmlSchemaObject_XmlSchema_0;

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
