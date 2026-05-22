using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000177 RID: 375
	public sealed class SchemaElementDecl : SchemaDeclBase
	{
		// Token: 0x06001C70 RID: 7280 RVA: 0x0008B420 File Offset: 0x00089620
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaElementDecl()
		{
			Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaElementDecl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr);
			SchemaElementDecl.NativeFieldInfoPtr_attdefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "attdefs");
			SchemaElementDecl.NativeFieldInfoPtr_defaultAttdefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "defaultAttdefs");
			SchemaElementDecl.NativeFieldInfoPtr_isIdDeclared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "isIdDeclared");
			SchemaElementDecl.NativeFieldInfoPtr_hasNonCDataAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "hasNonCDataAttribute");
			SchemaElementDecl.NativeFieldInfoPtr_isAbstract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "isAbstract");
			SchemaElementDecl.NativeFieldInfoPtr_isNillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "isNillable");
			SchemaElementDecl.NativeFieldInfoPtr_hasRequiredAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "hasRequiredAttribute");
			SchemaElementDecl.NativeFieldInfoPtr_isNotationDeclared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "isNotationDeclared");
			SchemaElementDecl.NativeFieldInfoPtr_prohibitedAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "prohibitedAttributes");
			SchemaElementDecl.NativeFieldInfoPtr_contentValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "contentValidator");
			SchemaElementDecl.NativeFieldInfoPtr_anyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "anyAttribute");
			SchemaElementDecl.NativeFieldInfoPtr_block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "block");
			SchemaElementDecl.NativeFieldInfoPtr_constraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "constraints");
			SchemaElementDecl.NativeFieldInfoPtr_schemaElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "schemaElement");
			SchemaElementDecl.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "Empty");
			SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667510);
			SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667511);
			SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667512);
			SchemaElementDecl.NativeMethodInfoPtr_CreateAnyTypeElementDecl_Internal_Static_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667513);
			SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667514);
			SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupAttribute_Private_Virtual_Final_New_IDtdAttributeInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667515);
			SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupDefaultAttributes_Private_Virtual_Final_New_IEnumerable_1_IDtdDefaultAttributeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667516);
			SchemaElementDecl.NativeMethodInfoPtr_get_IsIdDeclared_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667517);
			SchemaElementDecl.NativeMethodInfoPtr_set_IsIdDeclared_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667518);
			SchemaElementDecl.NativeMethodInfoPtr_get_HasNonCDataAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667519);
			SchemaElementDecl.NativeMethodInfoPtr_set_HasNonCDataAttribute_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667520);
			SchemaElementDecl.NativeMethodInfoPtr_Clone_Internal_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667521);
			SchemaElementDecl.NativeMethodInfoPtr_get_IsAbstract_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667522);
			SchemaElementDecl.NativeMethodInfoPtr_set_IsAbstract_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667523);
			SchemaElementDecl.NativeMethodInfoPtr_get_IsNillable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667524);
			SchemaElementDecl.NativeMethodInfoPtr_set_IsNillable_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667525);
			SchemaElementDecl.NativeMethodInfoPtr_get_Block_Internal_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667526);
			SchemaElementDecl.NativeMethodInfoPtr_set_Block_Internal_set_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667527);
			SchemaElementDecl.NativeMethodInfoPtr_get_IsNotationDeclared_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667528);
			SchemaElementDecl.NativeMethodInfoPtr_set_IsNotationDeclared_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667529);
			SchemaElementDecl.NativeMethodInfoPtr_get_HasDefaultAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667530);
			SchemaElementDecl.NativeMethodInfoPtr_get_HasRequiredAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667531);
			SchemaElementDecl.NativeMethodInfoPtr_get_ContentValidator_Internal_get_ContentValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667532);
			SchemaElementDecl.NativeMethodInfoPtr_set_ContentValidator_Internal_set_Void_ContentValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667533);
			SchemaElementDecl.NativeMethodInfoPtr_get_AnyAttribute_Internal_get_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667534);
			SchemaElementDecl.NativeMethodInfoPtr_set_AnyAttribute_Internal_set_Void_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667535);
			SchemaElementDecl.NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_CompiledIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667536);
			SchemaElementDecl.NativeMethodInfoPtr_set_Constraints_Internal_set_Void_Il2CppReferenceArray_1_CompiledIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667537);
			SchemaElementDecl.NativeMethodInfoPtr_get_SchemaElement_Internal_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667538);
			SchemaElementDecl.NativeMethodInfoPtr_set_SchemaElement_Internal_set_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667539);
			SchemaElementDecl.NativeMethodInfoPtr_AddAttDef_Internal_Void_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667540);
			SchemaElementDecl.NativeMethodInfoPtr_GetAttDef_Internal_SchemaAttDef_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667541);
			SchemaElementDecl.NativeMethodInfoPtr_get_DefaultAttDefs_Internal_get_IList_1_IDtdDefaultAttributeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667542);
			SchemaElementDecl.NativeMethodInfoPtr_get_AttDefs_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667543);
			SchemaElementDecl.NativeMethodInfoPtr_get_ProhibitedAttributes_Internal_get_Dictionary_2_XmlQualifiedName_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667544);
			SchemaElementDecl.NativeMethodInfoPtr_CheckAttributes_Internal_Void_Hashtable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100667545);
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0008B84C File Offset: 0x00089A4C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 420154, RefRangeEnd = 420160, XrefRangeStart = 420142, XrefRangeEnd = 420154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0008B888 File Offset: 0x00089A88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 420175, RefRangeEnd = 420178, XrefRangeStart = 420160, XrefRangeEnd = 420175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl(XmlSchemaDatatype dtype)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0008B8D4 File Offset: 0x00089AD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 420190, RefRangeEnd = 420193, XrefRangeStart = 420178, XrefRangeEnd = 420190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl(XmlQualifiedName name, string prefix)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0008B934 File Offset: 0x00089B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 420201, RefRangeEnd = 420202, XrefRangeStart = 420193, XrefRangeEnd = 420201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SchemaElementDecl CreateAnyTypeElementDecl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_CreateAnyTypeElementDecl_Internal_Static_SchemaElementDecl_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x0008B968 File Offset: 0x00089B68
		public unsafe bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0008B9A4 File Offset: 0x00089BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 420202, XrefRangeEnd = 420208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDtdAttributeInfo System_Xml_IDtdAttributeListInfo_LookupAttribute(string prefix, string localName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupAttribute_Private_Virtual_Final_New_IDtdAttributeInfo_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdAttributeInfo>(intPtr3) : null;
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0008BA08 File Offset: 0x00089C08
		[CallerCount(0)]
		public unsafe IEnumerable<IDtdDefaultAttributeInfo> System_Xml_IDtdAttributeListInfo_LookupDefaultAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupDefaultAttributes_Private_Virtual_Final_New_IEnumerable_1_IDtdDefaultAttributeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IDtdDefaultAttributeInfo>>(intPtr3) : null;
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x0008BA48 File Offset: 0x00089C48
		// (set) Token: 0x06001C79 RID: 7289 RVA: 0x0008BA84 File Offset: 0x00089C84
		public unsafe bool IsIdDeclared
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_IsIdDeclared_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_IsIdDeclared_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x0008BAC4 File Offset: 0x00089CC4
		// (set) Token: 0x06001C7B RID: 7291 RVA: 0x0008BB00 File Offset: 0x00089D00
		public unsafe bool HasNonCDataAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_HasNonCDataAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_HasNonCDataAttribute_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0008BB40 File Offset: 0x00089D40
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 420211, RefRangeEnd = 420222, XrefRangeStart = 420208, XrefRangeEnd = 420211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_Clone_Internal_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x0008BB80 File Offset: 0x00089D80
		// (set) Token: 0x06001C7E RID: 7294 RVA: 0x0008BBBC File Offset: 0x00089DBC
		public unsafe bool IsAbstract
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_IsAbstract_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_IsAbstract_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x0008BBFC File Offset: 0x00089DFC
		// (set) Token: 0x06001C80 RID: 7296 RVA: 0x0008BC38 File Offset: 0x00089E38
		public unsafe bool IsNillable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_IsNillable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_IsNillable_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x0008BC78 File Offset: 0x00089E78
		// (set) Token: 0x06001C82 RID: 7298 RVA: 0x0008BCB4 File Offset: 0x00089EB4
		public unsafe XmlSchemaDerivationMethod Block
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_Block_Internal_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_Block_Internal_set_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x0008BCF4 File Offset: 0x00089EF4
		// (set) Token: 0x06001C84 RID: 7300 RVA: 0x0008BD30 File Offset: 0x00089F30
		public unsafe bool IsNotationDeclared
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_IsNotationDeclared_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_IsNotationDeclared_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x0008BD70 File Offset: 0x00089F70
		public unsafe bool HasDefaultAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_HasDefaultAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x0008BDAC File Offset: 0x00089FAC
		public unsafe bool HasRequiredAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_HasRequiredAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x0008BDE8 File Offset: 0x00089FE8
		// (set) Token: 0x06001C88 RID: 7304 RVA: 0x0008BE28 File Offset: 0x0008A028
		public unsafe ContentValidator ContentValidator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_ContentValidator_Internal_get_ContentValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr3) : null;
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 382561, RefRangeEnd = 382571, XrefRangeStart = 382561, XrefRangeEnd = 382571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_ContentValidator_Internal_set_Void_ContentValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x0008BE6C File Offset: 0x0008A06C
		// (set) Token: 0x06001C8A RID: 7306 RVA: 0x0008BEAC File Offset: 0x0008A0AC
		public unsafe XmlSchemaAnyAttribute AnyAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_AnyAttribute_Internal_get_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 161221, RefRangeEnd = 161228, XrefRangeStart = 161221, XrefRangeEnd = 161228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_AnyAttribute_Internal_set_Void_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x0008BEF0 File Offset: 0x0008A0F0
		// (set) Token: 0x06001C8C RID: 7308 RVA: 0x0008BF30 File Offset: 0x0008A130
		public unsafe Il2CppReferenceArray<CompiledIdentityConstraint> Constraints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_CompiledIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CompiledIdentityConstraint>>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 224553, RefRangeEnd = 224561, XrefRangeStart = 224553, XrefRangeEnd = 224561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_Constraints_Internal_set_Void_Il2CppReferenceArray_1_CompiledIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x0008BF74 File Offset: 0x0008A174
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x0008BFB4 File Offset: 0x0008A1B4
		public unsafe XmlSchemaElement SchemaElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_SchemaElement_Internal_get_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 413738, RefRangeEnd = 413741, XrefRangeStart = 413738, XrefRangeEnd = 413741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_SchemaElement_Internal_set_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0008BFF8 File Offset: 0x0008A1F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 420233, RefRangeEnd = 420237, XrefRangeStart = 420222, XrefRangeEnd = 420233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAttDef(SchemaAttDef attdef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attdef);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_AddAttDef_Internal_Void_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0008C03C File Offset: 0x0008A23C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 420239, RefRangeEnd = 420243, XrefRangeStart = 420237, XrefRangeEnd = 420239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef GetAttDef(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_GetAttDef_Internal_SchemaAttDef_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr3) : null;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x0008C08C File Offset: 0x0008A28C
		public unsafe IList<IDtdDefaultAttributeInfo> DefaultAttDefs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_DefaultAttDefs_Internal_get_IList_1_IDtdDefaultAttributeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IDtdDefaultAttributeInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001C92 RID: 7314 RVA: 0x0008C0CC File Offset: 0x0008A2CC
		public unsafe Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_AttDefs_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaAttDef>>(intPtr3) : null;
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x0008C10C File Offset: 0x0008A30C
		public unsafe Dictionary<XmlQualifiedName, XmlQualifiedName> ProhibitedAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_ProhibitedAttributes_Internal_get_Dictionary_2_XmlQualifiedName_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, XmlQualifiedName>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0008C14C File Offset: 0x0008A34C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 420254, RefRangeEnd = 420257, XrefRangeStart = 420243, XrefRangeEnd = 420254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAttributes(Hashtable presence, bool standalone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(presence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref standalone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_CheckAttributes_Internal_Void_Hashtable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x0000BEAF File Offset: 0x0000A0AF
		public SchemaElementDecl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x0008C19C File Offset: 0x0008A39C
		// (set) Token: 0x06001C97 RID: 7319 RVA: 0x0000BEB8 File Offset: 0x0000A0B8
		public unsafe Dictionary<XmlQualifiedName, SchemaAttDef> attdefs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_attdefs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaAttDef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_attdefs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x0008C1CC File Offset: 0x0008A3CC
		// (set) Token: 0x06001C99 RID: 7321 RVA: 0x0000BED7 File Offset: 0x0000A0D7
		public unsafe List<IDtdDefaultAttributeInfo> defaultAttdefs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_defaultAttdefs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IDtdDefaultAttributeInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_defaultAttdefs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x0008C1FC File Offset: 0x0008A3FC
		// (set) Token: 0x06001C9B RID: 7323 RVA: 0x0000BEF6 File Offset: 0x0000A0F6
		public unsafe bool isIdDeclared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isIdDeclared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isIdDeclared)) = value;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x0008C224 File Offset: 0x0008A424
		// (set) Token: 0x06001C9D RID: 7325 RVA: 0x0000BF11 File Offset: 0x0000A111
		public unsafe bool hasNonCDataAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_hasNonCDataAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_hasNonCDataAttribute)) = value;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001C9E RID: 7326 RVA: 0x0008C24C File Offset: 0x0008A44C
		// (set) Token: 0x06001C9F RID: 7327 RVA: 0x0000BF2C File Offset: 0x0000A12C
		public unsafe bool isAbstract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isAbstract);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isAbstract)) = value;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x0008C274 File Offset: 0x0008A474
		// (set) Token: 0x06001CA1 RID: 7329 RVA: 0x0000BF47 File Offset: 0x0000A147
		public unsafe bool isNillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isNillable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isNillable)) = value;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x0008C29C File Offset: 0x0008A49C
		// (set) Token: 0x06001CA3 RID: 7331 RVA: 0x0000BF62 File Offset: 0x0000A162
		public unsafe bool hasRequiredAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_hasRequiredAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_hasRequiredAttribute)) = value;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x0008C2C4 File Offset: 0x0008A4C4
		// (set) Token: 0x06001CA5 RID: 7333 RVA: 0x0000BF7D File Offset: 0x0000A17D
		public unsafe bool isNotationDeclared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isNotationDeclared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isNotationDeclared)) = value;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x0008C2EC File Offset: 0x0008A4EC
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x0000BF98 File Offset: 0x0000A198
		public unsafe Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_prohibitedAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, XmlQualifiedName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_prohibitedAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x0008C31C File Offset: 0x0008A51C
		// (set) Token: 0x06001CA9 RID: 7337 RVA: 0x0000BFB7 File Offset: 0x0000A1B7
		public unsafe ContentValidator contentValidator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_contentValidator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_contentValidator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x0008C34C File Offset: 0x0008A54C
		// (set) Token: 0x06001CAB RID: 7339 RVA: 0x0000BFD6 File Offset: 0x0000A1D6
		public unsafe XmlSchemaAnyAttribute anyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_anyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_anyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x0008C37C File Offset: 0x0008A57C
		// (set) Token: 0x06001CAD RID: 7341 RVA: 0x0000BFF5 File Offset: 0x0000A1F5
		public unsafe XmlSchemaDerivationMethod block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_block);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_block)) = value;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x0008C3A4 File Offset: 0x0008A5A4
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x0000C010 File Offset: 0x0000A210
		public unsafe Il2CppReferenceArray<CompiledIdentityConstraint> constraints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_constraints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CompiledIdentityConstraint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_constraints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x0008C3D4 File Offset: 0x0008A5D4
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x0000C02F File Offset: 0x0000A22F
		public unsafe XmlSchemaElement schemaElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_schemaElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_schemaElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x0008C404 File Offset: 0x0008A604
		// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x0000C04E File Offset: 0x0000A24E
		public unsafe static SchemaElementDecl Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SchemaElementDecl.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SchemaElementDecl.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400154C RID: 5452
		private static readonly IntPtr NativeFieldInfoPtr_attdefs;

		// Token: 0x0400154D RID: 5453
		private static readonly IntPtr NativeFieldInfoPtr_defaultAttdefs;

		// Token: 0x0400154E RID: 5454
		private static readonly IntPtr NativeFieldInfoPtr_isIdDeclared;

		// Token: 0x0400154F RID: 5455
		private static readonly IntPtr NativeFieldInfoPtr_hasNonCDataAttribute;

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeFieldInfoPtr_isAbstract;

		// Token: 0x04001551 RID: 5457
		private static readonly IntPtr NativeFieldInfoPtr_isNillable;

		// Token: 0x04001552 RID: 5458
		private static readonly IntPtr NativeFieldInfoPtr_hasRequiredAttribute;

		// Token: 0x04001553 RID: 5459
		private static readonly IntPtr NativeFieldInfoPtr_isNotationDeclared;

		// Token: 0x04001554 RID: 5460
		private static readonly IntPtr NativeFieldInfoPtr_prohibitedAttributes;

		// Token: 0x04001555 RID: 5461
		private static readonly IntPtr NativeFieldInfoPtr_contentValidator;

		// Token: 0x04001556 RID: 5462
		private static readonly IntPtr NativeFieldInfoPtr_anyAttribute;

		// Token: 0x04001557 RID: 5463
		private static readonly IntPtr NativeFieldInfoPtr_block;

		// Token: 0x04001558 RID: 5464
		private static readonly IntPtr NativeFieldInfoPtr_constraints;

		// Token: 0x04001559 RID: 5465
		private static readonly IntPtr NativeFieldInfoPtr_schemaElement;

		// Token: 0x0400155A RID: 5466
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x0400155B RID: 5467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400155C RID: 5468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaDatatype_0;

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_String_0;

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeMethodInfoPtr_CreateAnyTypeElementDecl_Internal_Static_SchemaElementDecl_0;

		// Token: 0x0400155F RID: 5471
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001560 RID: 5472
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupAttribute_Private_Virtual_Final_New_IDtdAttributeInfo_String_String_0;

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupDefaultAttributes_Private_Virtual_Final_New_IEnumerable_1_IDtdDefaultAttributeInfo_0;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeMethodInfoPtr_get_IsIdDeclared_Internal_get_Boolean_0;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeMethodInfoPtr_set_IsIdDeclared_Internal_set_Void_Boolean_0;

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNonCDataAttribute_Internal_get_Boolean_0;

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeMethodInfoPtr_set_HasNonCDataAttribute_Internal_set_Void_Boolean_0;

		// Token: 0x04001566 RID: 5478
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_SchemaElementDecl_0;

		// Token: 0x04001567 RID: 5479
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAbstract_Internal_get_Boolean_0;

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAbstract_Internal_set_Void_Boolean_0;

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNillable_Internal_get_Boolean_0;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeMethodInfoPtr_set_IsNillable_Internal_set_Void_Boolean_0;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeMethodInfoPtr_get_Block_Internal_get_XmlSchemaDerivationMethod_0;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeMethodInfoPtr_set_Block_Internal_set_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNotationDeclared_Internal_get_Boolean_0;

		// Token: 0x0400156E RID: 5486
		private static readonly IntPtr NativeMethodInfoPtr_set_IsNotationDeclared_Internal_set_Void_Boolean_0;

		// Token: 0x0400156F RID: 5487
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDefaultAttribute_Internal_get_Boolean_0;

		// Token: 0x04001570 RID: 5488
		private static readonly IntPtr NativeMethodInfoPtr_get_HasRequiredAttribute_Internal_get_Boolean_0;

		// Token: 0x04001571 RID: 5489
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentValidator_Internal_get_ContentValidator_0;

		// Token: 0x04001572 RID: 5490
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentValidator_Internal_set_Void_ContentValidator_0;

		// Token: 0x04001573 RID: 5491
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyAttribute_Internal_get_XmlSchemaAnyAttribute_0;

		// Token: 0x04001574 RID: 5492
		private static readonly IntPtr NativeMethodInfoPtr_set_AnyAttribute_Internal_set_Void_XmlSchemaAnyAttribute_0;

		// Token: 0x04001575 RID: 5493
		private static readonly IntPtr NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_CompiledIdentityConstraint_0;

		// Token: 0x04001576 RID: 5494
		private static readonly IntPtr NativeMethodInfoPtr_set_Constraints_Internal_set_Void_Il2CppReferenceArray_1_CompiledIdentityConstraint_0;

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaElement_Internal_get_XmlSchemaElement_0;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaElement_Internal_set_Void_XmlSchemaElement_0;

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeMethodInfoPtr_AddAttDef_Internal_Void_SchemaAttDef_0;

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeMethodInfoPtr_GetAttDef_Internal_SchemaAttDef_XmlQualifiedName_0;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultAttDefs_Internal_get_IList_1_IDtdDefaultAttributeInfo_0;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeMethodInfoPtr_get_AttDefs_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0;

		// Token: 0x0400157D RID: 5501
		private static readonly IntPtr NativeMethodInfoPtr_get_ProhibitedAttributes_Internal_get_Dictionary_2_XmlQualifiedName_XmlQualifiedName_0;

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeMethodInfoPtr_CheckAttributes_Internal_Void_Hashtable_Boolean_0;
	}
}
