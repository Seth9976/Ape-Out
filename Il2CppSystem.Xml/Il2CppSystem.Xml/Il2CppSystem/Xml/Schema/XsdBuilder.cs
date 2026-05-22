using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001E9 RID: 489
	public sealed class XsdBuilder : SchemaBuilder
	{
		// Token: 0x060027A2 RID: 10146 RVA: 0x000B78B8 File Offset: 0x000B5AB8
		// Note: this type is marked as 'beforefieldinit'.
		static XsdBuilder()
		{
			Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr);
			XsdBuilder.NativeFieldInfoPtr_SchemaElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SchemaElement");
			XsdBuilder.NativeFieldInfoPtr_SchemaSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SchemaSubelements");
			XsdBuilder.NativeFieldInfoPtr_AttributeSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AttributeSubelements");
			XsdBuilder.NativeFieldInfoPtr_ElementSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ElementSubelements");
			XsdBuilder.NativeFieldInfoPtr_ComplexTypeSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexTypeSubelements");
			XsdBuilder.NativeFieldInfoPtr_SimpleContentSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentSubelements");
			XsdBuilder.NativeFieldInfoPtr_SimpleContentExtensionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentExtensionSubelements");
			XsdBuilder.NativeFieldInfoPtr_SimpleContentRestrictionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentRestrictionSubelements");
			XsdBuilder.NativeFieldInfoPtr_ComplexContentSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentSubelements");
			XsdBuilder.NativeFieldInfoPtr_ComplexContentExtensionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentExtensionSubelements");
			XsdBuilder.NativeFieldInfoPtr_ComplexContentRestrictionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentRestrictionSubelements");
			XsdBuilder.NativeFieldInfoPtr_SimpleTypeSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeSubelements");
			XsdBuilder.NativeFieldInfoPtr_SimpleTypeRestrictionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeRestrictionSubelements");
			XsdBuilder.NativeFieldInfoPtr_SimpleTypeListSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeListSubelements");
			XsdBuilder.NativeFieldInfoPtr_SimpleTypeUnionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeUnionSubelements");
			XsdBuilder.NativeFieldInfoPtr_RedefineSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "RedefineSubelements");
			XsdBuilder.NativeFieldInfoPtr_AttributeGroupSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AttributeGroupSubelements");
			XsdBuilder.NativeFieldInfoPtr_GroupSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "GroupSubelements");
			XsdBuilder.NativeFieldInfoPtr_AllSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AllSubelements");
			XsdBuilder.NativeFieldInfoPtr_ChoiceSequenceSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ChoiceSequenceSubelements");
			XsdBuilder.NativeFieldInfoPtr_IdentityConstraintSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "IdentityConstraintSubelements");
			XsdBuilder.NativeFieldInfoPtr_AnnotationSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AnnotationSubelements");
			XsdBuilder.NativeFieldInfoPtr_AnnotatedSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AnnotatedSubelements");
			XsdBuilder.NativeFieldInfoPtr_SchemaAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SchemaAttributes");
			XsdBuilder.NativeFieldInfoPtr_AttributeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AttributeAttributes");
			XsdBuilder.NativeFieldInfoPtr_ElementAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ElementAttributes");
			XsdBuilder.NativeFieldInfoPtr_ComplexTypeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexTypeAttributes");
			XsdBuilder.NativeFieldInfoPtr_SimpleContentAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentAttributes");
			XsdBuilder.NativeFieldInfoPtr_SimpleContentExtensionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentExtensionAttributes");
			XsdBuilder.NativeFieldInfoPtr_SimpleContentRestrictionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentRestrictionAttributes");
			XsdBuilder.NativeFieldInfoPtr_ComplexContentAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentAttributes");
			XsdBuilder.NativeFieldInfoPtr_ComplexContentExtensionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentExtensionAttributes");
			XsdBuilder.NativeFieldInfoPtr_ComplexContentRestrictionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentRestrictionAttributes");
			XsdBuilder.NativeFieldInfoPtr_SimpleTypeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeAttributes");
			XsdBuilder.NativeFieldInfoPtr_SimpleTypeRestrictionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeRestrictionAttributes");
			XsdBuilder.NativeFieldInfoPtr_SimpleTypeUnionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeUnionAttributes");
			XsdBuilder.NativeFieldInfoPtr_SimpleTypeListAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeListAttributes");
			XsdBuilder.NativeFieldInfoPtr_AttributeGroupAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AttributeGroupAttributes");
			XsdBuilder.NativeFieldInfoPtr_AttributeGroupRefAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AttributeGroupRefAttributes");
			XsdBuilder.NativeFieldInfoPtr_GroupAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "GroupAttributes");
			XsdBuilder.NativeFieldInfoPtr_GroupRefAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "GroupRefAttributes");
			XsdBuilder.NativeFieldInfoPtr_ParticleAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ParticleAttributes");
			XsdBuilder.NativeFieldInfoPtr_AnyAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AnyAttributes");
			XsdBuilder.NativeFieldInfoPtr_IdentityConstraintAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "IdentityConstraintAttributes");
			XsdBuilder.NativeFieldInfoPtr_SelectorAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SelectorAttributes");
			XsdBuilder.NativeFieldInfoPtr_FieldAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "FieldAttributes");
			XsdBuilder.NativeFieldInfoPtr_NotationAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "NotationAttributes");
			XsdBuilder.NativeFieldInfoPtr_IncludeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "IncludeAttributes");
			XsdBuilder.NativeFieldInfoPtr_ImportAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ImportAttributes");
			XsdBuilder.NativeFieldInfoPtr_FacetAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "FacetAttributes");
			XsdBuilder.NativeFieldInfoPtr_AnyAttributeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AnyAttributeAttributes");
			XsdBuilder.NativeFieldInfoPtr_DocumentationAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "DocumentationAttributes");
			XsdBuilder.NativeFieldInfoPtr_AppinfoAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AppinfoAttributes");
			XsdBuilder.NativeFieldInfoPtr_RedefineAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "RedefineAttributes");
			XsdBuilder.NativeFieldInfoPtr_AnnotationAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AnnotationAttributes");
			XsdBuilder.NativeFieldInfoPtr_SchemaEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SchemaEntries");
			XsdBuilder.NativeFieldInfoPtr_DerivationMethodValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "DerivationMethodValues");
			XsdBuilder.NativeFieldInfoPtr_DerivationMethodStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "DerivationMethodStrings");
			XsdBuilder.NativeFieldInfoPtr_FormStringValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "FormStringValues");
			XsdBuilder.NativeFieldInfoPtr_UseStringValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "UseStringValues");
			XsdBuilder.NativeFieldInfoPtr_ProcessContentsStringValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ProcessContentsStringValues");
			XsdBuilder.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "reader");
			XsdBuilder.NativeFieldInfoPtr_positionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "positionInfo");
			XsdBuilder.NativeFieldInfoPtr_currentEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "currentEntry");
			XsdBuilder.NativeFieldInfoPtr_nextEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "nextEntry");
			XsdBuilder.NativeFieldInfoPtr_hasChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "hasChild");
			XsdBuilder.NativeFieldInfoPtr_stateHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "stateHistory");
			XsdBuilder.NativeFieldInfoPtr_containerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "containerStack");
			XsdBuilder.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "nameTable");
			XsdBuilder.NativeFieldInfoPtr_schemaNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "schemaNames");
			XsdBuilder.NativeFieldInfoPtr_namespaceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "namespaceManager");
			XsdBuilder.NativeFieldInfoPtr_canIncludeImport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "canIncludeImport");
			XsdBuilder.NativeFieldInfoPtr_schema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "schema");
			XsdBuilder.NativeFieldInfoPtr_xso = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "xso");
			XsdBuilder.NativeFieldInfoPtr_element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "element");
			XsdBuilder.NativeFieldInfoPtr_anyElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "anyElement");
			XsdBuilder.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "attribute");
			XsdBuilder.NativeFieldInfoPtr_anyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "anyAttribute");
			XsdBuilder.NativeFieldInfoPtr_complexType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "complexType");
			XsdBuilder.NativeFieldInfoPtr_simpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleType");
			XsdBuilder.NativeFieldInfoPtr_complexContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "complexContent");
			XsdBuilder.NativeFieldInfoPtr_complexContentExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "complexContentExtension");
			XsdBuilder.NativeFieldInfoPtr_complexContentRestriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "complexContentRestriction");
			XsdBuilder.NativeFieldInfoPtr_simpleContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleContent");
			XsdBuilder.NativeFieldInfoPtr_simpleContentExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleContentExtension");
			XsdBuilder.NativeFieldInfoPtr_simpleContentRestriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleContentRestriction");
			XsdBuilder.NativeFieldInfoPtr_simpleTypeUnion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleTypeUnion");
			XsdBuilder.NativeFieldInfoPtr_simpleTypeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleTypeList");
			XsdBuilder.NativeFieldInfoPtr_simpleTypeRestriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleTypeRestriction");
			XsdBuilder.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "group");
			XsdBuilder.NativeFieldInfoPtr_groupRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "groupRef");
			XsdBuilder.NativeFieldInfoPtr_all = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "all");
			XsdBuilder.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "choice");
			XsdBuilder.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "sequence");
			XsdBuilder.NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "particle");
			XsdBuilder.NativeFieldInfoPtr_attributeGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "attributeGroup");
			XsdBuilder.NativeFieldInfoPtr_attributeGroupRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "attributeGroupRef");
			XsdBuilder.NativeFieldInfoPtr_notation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "notation");
			XsdBuilder.NativeFieldInfoPtr_identityConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "identityConstraint");
			XsdBuilder.NativeFieldInfoPtr_xpath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "xpath");
			XsdBuilder.NativeFieldInfoPtr_include = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "include");
			XsdBuilder.NativeFieldInfoPtr_import = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "import");
			XsdBuilder.NativeFieldInfoPtr_annotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "annotation");
			XsdBuilder.NativeFieldInfoPtr_appInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "appInfo");
			XsdBuilder.NativeFieldInfoPtr_documentation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "documentation");
			XsdBuilder.NativeFieldInfoPtr_facet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "facet");
			XsdBuilder.NativeFieldInfoPtr_markup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "markup");
			XsdBuilder.NativeFieldInfoPtr_redefine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "redefine");
			XsdBuilder.NativeFieldInfoPtr_validationEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "validationEventHandler");
			XsdBuilder.NativeFieldInfoPtr_unhandledAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "unhandledAttributes");
			XsdBuilder.NativeFieldInfoPtr_namespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "namespaces");
			XsdBuilder.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_XmlSchema_XmlNameTable_SchemaNames_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669008);
			XsdBuilder.NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669009);
			XsdBuilder.NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669010);
			XsdBuilder.NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669011);
			XsdBuilder.NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669012);
			XsdBuilder.NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669013);
			XsdBuilder.NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669014);
			XsdBuilder.NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669015);
			XsdBuilder.NativeMethodInfoPtr_Push_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669016);
			XsdBuilder.NativeMethodInfoPtr_Pop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669017);
			XsdBuilder.NativeMethodInfoPtr_get_CurrentElement_Private_get_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669018);
			XsdBuilder.NativeMethodInfoPtr_get_ParentElement_Private_get_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669019);
			XsdBuilder.NativeMethodInfoPtr_get_ParentContainer_Private_get_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669020);
			XsdBuilder.NativeMethodInfoPtr_GetContainer_Private_XmlSchemaObject_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669021);
			XsdBuilder.NativeMethodInfoPtr_SetContainer_Private_Void_State_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669022);
			XsdBuilder.NativeMethodInfoPtr_BuildAnnotated_Id_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669023);
			XsdBuilder.NativeMethodInfoPtr_BuildSchema_AttributeFormDefault_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669024);
			XsdBuilder.NativeMethodInfoPtr_BuildSchema_ElementFormDefault_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669025);
			XsdBuilder.NativeMethodInfoPtr_BuildSchema_TargetNamespace_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669026);
			XsdBuilder.NativeMethodInfoPtr_BuildSchema_Version_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669027);
			XsdBuilder.NativeMethodInfoPtr_BuildSchema_FinalDefault_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669028);
			XsdBuilder.NativeMethodInfoPtr_BuildSchema_BlockDefault_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669029);
			XsdBuilder.NativeMethodInfoPtr_InitSchema_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669030);
			XsdBuilder.NativeMethodInfoPtr_InitInclude_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669031);
			XsdBuilder.NativeMethodInfoPtr_BuildInclude_SchemaLocation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669032);
			XsdBuilder.NativeMethodInfoPtr_InitImport_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669033);
			XsdBuilder.NativeMethodInfoPtr_BuildImport_Namespace_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669034);
			XsdBuilder.NativeMethodInfoPtr_BuildImport_SchemaLocation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669035);
			XsdBuilder.NativeMethodInfoPtr_InitRedefine_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669036);
			XsdBuilder.NativeMethodInfoPtr_BuildRedefine_SchemaLocation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669037);
			XsdBuilder.NativeMethodInfoPtr_EndRedefine_Private_Static_Void_XsdBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669038);
			XsdBuilder.NativeMethodInfoPtr_InitAttribute_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669039);
			XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Default_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669040);
			XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Fixed_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669041);
			XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Form_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669042);
			XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Use_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669043);
			XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Ref_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669044);
			XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669045);
			XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Type_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669046);
			XsdBuilder.NativeMethodInfoPtr_InitElement_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669047);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Abstract_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669048);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Block_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669049);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Default_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669050);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Form_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669051);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_SubstitutionGroup_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669052);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Final_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669053);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Fixed_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669054);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_MaxOccurs_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669055);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_MinOccurs_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669056);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669057);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Nillable_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669058);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Ref_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669059);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Type_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669060);
			XsdBuilder.NativeMethodInfoPtr_InitSimpleType_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669061);
			XsdBuilder.NativeMethodInfoPtr_BuildSimpleType_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669062);
			XsdBuilder.NativeMethodInfoPtr_BuildSimpleType_Final_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669063);
			XsdBuilder.NativeMethodInfoPtr_InitSimpleTypeUnion_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669064);
			XsdBuilder.NativeMethodInfoPtr_BuildSimpleTypeUnion_MemberTypes_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669065);
			XsdBuilder.NativeMethodInfoPtr_InitSimpleTypeList_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669066);
			XsdBuilder.NativeMethodInfoPtr_BuildSimpleTypeList_ItemType_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669067);
			XsdBuilder.NativeMethodInfoPtr_InitSimpleTypeRestriction_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669068);
			XsdBuilder.NativeMethodInfoPtr_BuildSimpleTypeRestriction_Base_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669069);
			XsdBuilder.NativeMethodInfoPtr_InitComplexType_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669070);
			XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Abstract_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669071);
			XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Block_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669072);
			XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Final_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669073);
			XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Mixed_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669074);
			XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669075);
			XsdBuilder.NativeMethodInfoPtr_InitComplexContent_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669076);
			XsdBuilder.NativeMethodInfoPtr_BuildComplexContent_Mixed_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669077);
			XsdBuilder.NativeMethodInfoPtr_InitComplexContentExtension_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669078);
			XsdBuilder.NativeMethodInfoPtr_BuildComplexContentExtension_Base_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669079);
			XsdBuilder.NativeMethodInfoPtr_InitComplexContentRestriction_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669080);
			XsdBuilder.NativeMethodInfoPtr_BuildComplexContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669081);
			XsdBuilder.NativeMethodInfoPtr_InitSimpleContent_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669082);
			XsdBuilder.NativeMethodInfoPtr_InitSimpleContentExtension_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669083);
			XsdBuilder.NativeMethodInfoPtr_BuildSimpleContentExtension_Base_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669084);
			XsdBuilder.NativeMethodInfoPtr_InitSimpleContentRestriction_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669085);
			XsdBuilder.NativeMethodInfoPtr_BuildSimpleContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669086);
			XsdBuilder.NativeMethodInfoPtr_InitAttributeGroup_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669087);
			XsdBuilder.NativeMethodInfoPtr_BuildAttributeGroup_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669088);
			XsdBuilder.NativeMethodInfoPtr_InitAttributeGroupRef_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669089);
			XsdBuilder.NativeMethodInfoPtr_BuildAttributeGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669090);
			XsdBuilder.NativeMethodInfoPtr_InitAnyAttribute_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669091);
			XsdBuilder.NativeMethodInfoPtr_BuildAnyAttribute_Namespace_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669092);
			XsdBuilder.NativeMethodInfoPtr_BuildAnyAttribute_ProcessContents_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669093);
			XsdBuilder.NativeMethodInfoPtr_InitGroup_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669094);
			XsdBuilder.NativeMethodInfoPtr_BuildGroup_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669095);
			XsdBuilder.NativeMethodInfoPtr_InitGroupRef_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669096);
			XsdBuilder.NativeMethodInfoPtr_BuildParticle_MaxOccurs_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669097);
			XsdBuilder.NativeMethodInfoPtr_BuildParticle_MinOccurs_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669098);
			XsdBuilder.NativeMethodInfoPtr_BuildGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669099);
			XsdBuilder.NativeMethodInfoPtr_InitAll_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669100);
			XsdBuilder.NativeMethodInfoPtr_InitChoice_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669101);
			XsdBuilder.NativeMethodInfoPtr_InitSequence_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669102);
			XsdBuilder.NativeMethodInfoPtr_InitAny_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669103);
			XsdBuilder.NativeMethodInfoPtr_BuildAny_Namespace_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669104);
			XsdBuilder.NativeMethodInfoPtr_BuildAny_ProcessContents_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669105);
			XsdBuilder.NativeMethodInfoPtr_InitNotation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669106);
			XsdBuilder.NativeMethodInfoPtr_BuildNotation_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669107);
			XsdBuilder.NativeMethodInfoPtr_BuildNotation_Public_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669108);
			XsdBuilder.NativeMethodInfoPtr_BuildNotation_System_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669109);
			XsdBuilder.NativeMethodInfoPtr_InitFacet_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669110);
			XsdBuilder.NativeMethodInfoPtr_BuildFacet_Fixed_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669111);
			XsdBuilder.NativeMethodInfoPtr_BuildFacet_Value_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669112);
			XsdBuilder.NativeMethodInfoPtr_InitIdentityConstraint_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669113);
			XsdBuilder.NativeMethodInfoPtr_BuildIdentityConstraint_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669114);
			XsdBuilder.NativeMethodInfoPtr_BuildIdentityConstraint_Refer_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669115);
			XsdBuilder.NativeMethodInfoPtr_InitSelector_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669116);
			XsdBuilder.NativeMethodInfoPtr_BuildSelector_XPath_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669117);
			XsdBuilder.NativeMethodInfoPtr_InitField_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669118);
			XsdBuilder.NativeMethodInfoPtr_BuildField_XPath_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669119);
			XsdBuilder.NativeMethodInfoPtr_InitAnnotation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669120);
			XsdBuilder.NativeMethodInfoPtr_InitAppinfo_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669121);
			XsdBuilder.NativeMethodInfoPtr_BuildAppinfo_Source_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669122);
			XsdBuilder.NativeMethodInfoPtr_EndAppinfo_Private_Static_Void_XsdBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669123);
			XsdBuilder.NativeMethodInfoPtr_InitDocumentation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669124);
			XsdBuilder.NativeMethodInfoPtr_BuildDocumentation_Source_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669125);
			XsdBuilder.NativeMethodInfoPtr_BuildDocumentation_XmlLang_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669126);
			XsdBuilder.NativeMethodInfoPtr_EndDocumentation_Private_Static_Void_XsdBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669127);
			XsdBuilder.NativeMethodInfoPtr_AddAttribute_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669128);
			XsdBuilder.NativeMethodInfoPtr_AddParticle_Private_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669129);
			XsdBuilder.NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669130);
			XsdBuilder.NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669131);
			XsdBuilder.NativeMethodInfoPtr_SetMinOccurs_Private_Void_XmlSchemaParticle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669132);
			XsdBuilder.NativeMethodInfoPtr_SetMaxOccurs_Private_Void_XmlSchemaParticle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669133);
			XsdBuilder.NativeMethodInfoPtr_ParseBoolean_Private_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669134);
			XsdBuilder.NativeMethodInfoPtr_ParseEnum_Private_Int32_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669135);
			XsdBuilder.NativeMethodInfoPtr_ParseQName_Private_XmlQualifiedName_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669136);
			XsdBuilder.NativeMethodInfoPtr_ParseBlockFinalEnum_Private_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669137);
			XsdBuilder.NativeMethodInfoPtr_ParseUriReference_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669138);
			XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669139);
			XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669140);
			XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669141);
			XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669142);
			XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669143);
			XsdBuilder.NativeMethodInfoPtr_RecordPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669144);
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x000B8C48 File Offset: 0x000B6E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436942, XrefRangeEnd = 436965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdBuilder(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(curmgr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaNames);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventhandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_XmlSchema_XmlNameTable_SchemaNames_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x000B8CF0 File Offset: 0x000B6EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436965, XrefRangeEnd = 436973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ProcessElement(string prefix, string name, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x000B8D64 File Offset: 0x000B6F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436973, XrefRangeEnd = 436993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessAttribute(string prefix, string name, string ns, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x000B8DE0 File Offset: 0x000B6FE0
		[CallerCount(0)]
		public unsafe override bool IsContentParsed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x000B8E1C File Offset: 0x000B701C
		[CallerCount(0)]
		public unsafe override void ProcessMarkup(Il2CppReferenceArray<XmlNode> markup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(markup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x000B8E60 File Offset: 0x000B7060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436993, XrefRangeEnd = 436996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessCData(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x000B8EA4 File Offset: 0x000B70A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436996, XrefRangeEnd = 437008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x000B8ED8 File Offset: 0x000B70D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437008, XrefRangeEnd = 437013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x000B8F0C File Offset: 0x000B710C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437013, XrefRangeEnd = 437047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_Push_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x000B8F40 File Offset: 0x000B7140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437047, XrefRangeEnd = 437051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_Pop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x000B8F74 File Offset: 0x000B7174
		public unsafe SchemaNames.Token CurrentElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_get_CurrentElement_Private_get_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x000B8FB0 File Offset: 0x000B71B0
		public unsafe SchemaNames.Token ParentElement
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 437054, RefRangeEnd = 437066, XrefRangeStart = 437051, XrefRangeEnd = 437054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_get_ParentElement_Private_get_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x060027AF RID: 10159 RVA: 0x000B8FEC File Offset: 0x000B71EC
		public unsafe XmlSchemaObject ParentContainer
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 437068, RefRangeEnd = 437070, XrefRangeStart = 437066, XrefRangeEnd = 437068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_get_ParentContainer_Private_get_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
			}
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x000B902C File Offset: 0x000B722C
		[CallerCount(0)]
		public unsafe XmlSchemaObject GetContainer(XsdBuilder.State state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_GetContainer_Private_XmlSchemaObject_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
			}
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x000B9078 File Offset: 0x000B7278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 437104, RefRangeEnd = 437106, XrefRangeStart = 437070, XrefRangeEnd = 437104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContainer(XsdBuilder.State state, Object container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_SetContainer_Private_Void_State_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x000B90C8 File Offset: 0x000B72C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437106, XrefRangeEnd = 437107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAnnotated_Id(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAnnotated_Id_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x000B9110 File Offset: 0x000B7310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437107, XrefRangeEnd = 437114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSchema_AttributeFormDefault_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x000B9158 File Offset: 0x000B7358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437114, XrefRangeEnd = 437121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSchema_ElementFormDefault_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x000B91A0 File Offset: 0x000B73A0
		[CallerCount(0)]
		public unsafe static void BuildSchema_TargetNamespace(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSchema_TargetNamespace_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x000B91E8 File Offset: 0x000B73E8
		[CallerCount(0)]
		public unsafe static void BuildSchema_Version(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSchema_Version_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x000B9230 File Offset: 0x000B7430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437121, XrefRangeEnd = 437124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSchema_FinalDefault(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSchema_FinalDefault_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x000B9278 File Offset: 0x000B7478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437124, XrefRangeEnd = 437127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSchema_BlockDefault(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSchema_BlockDefault_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x000B92C0 File Offset: 0x000B74C0
		[CallerCount(0)]
		public unsafe static void InitSchema(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSchema_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x000B9308 File Offset: 0x000B7508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437127, XrefRangeEnd = 437137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitInclude(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitInclude_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x000B9350 File Offset: 0x000B7550
		[CallerCount(0)]
		public unsafe static void BuildInclude_SchemaLocation(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildInclude_SchemaLocation_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x000B9398 File Offset: 0x000B7598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437137, XrefRangeEnd = 437147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitImport(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitImport_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x000B93E0 File Offset: 0x000B75E0
		[CallerCount(0)]
		public unsafe static void BuildImport_Namespace(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildImport_Namespace_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x000B9428 File Offset: 0x000B7628
		[CallerCount(0)]
		public unsafe static void BuildImport_SchemaLocation(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildImport_SchemaLocation_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x000B9470 File Offset: 0x000B7670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437147, XrefRangeEnd = 437158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitRedefine(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitRedefine_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x000B94B8 File Offset: 0x000B76B8
		[CallerCount(0)]
		public unsafe static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildRedefine_SchemaLocation_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x000B9500 File Offset: 0x000B7700
		[CallerCount(0)]
		public unsafe static void EndRedefine(XsdBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_EndRedefine_Private_Static_Void_XsdBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x000B9538 File Offset: 0x000B7738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437158, XrefRangeEnd = 437168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAttribute(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitAttribute_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x000B9580 File Offset: 0x000B7780
		[CallerCount(0)]
		public unsafe static void BuildAttribute_Default(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Default_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x000B95C8 File Offset: 0x000B77C8
		[CallerCount(0)]
		public unsafe static void BuildAttribute_Fixed(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Fixed_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x000B9610 File Offset: 0x000B7810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437168, XrefRangeEnd = 437175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAttribute_Form(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Form_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x000B9658 File Offset: 0x000B7858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437175, XrefRangeEnd = 437182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAttribute_Use(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Use_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x000B96A0 File Offset: 0x000B78A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437182, XrefRangeEnd = 437191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAttribute_Ref(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Ref_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x000B96E8 File Offset: 0x000B78E8
		[CallerCount(0)]
		public unsafe static void BuildAttribute_Name(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Name_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x000B9730 File Offset: 0x000B7930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437191, XrefRangeEnd = 437200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAttribute_Type(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Type_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x000B9778 File Offset: 0x000B7978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437200, XrefRangeEnd = 437208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitElement(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitElement_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x000B97C0 File Offset: 0x000B79C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437208, XrefRangeEnd = 437211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Abstract(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Abstract_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x000B9808 File Offset: 0x000B7A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437211, XrefRangeEnd = 437214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Block(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Block_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x000B9850 File Offset: 0x000B7A50
		[CallerCount(0)]
		public unsafe static void BuildElement_Default(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Default_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x000B9898 File Offset: 0x000B7A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437214, XrefRangeEnd = 437221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Form(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Form_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x000B98E0 File Offset: 0x000B7AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437221, XrefRangeEnd = 437230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_SubstitutionGroup_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x000B9928 File Offset: 0x000B7B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437230, XrefRangeEnd = 437233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Final(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Final_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x000B9970 File Offset: 0x000B7B70
		[CallerCount(0)]
		public unsafe static void BuildElement_Fixed(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Fixed_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x000B99B8 File Offset: 0x000B7BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437233, XrefRangeEnd = 437235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_MaxOccurs(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_MaxOccurs_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x000B9A00 File Offset: 0x000B7C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437235, XrefRangeEnd = 437237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_MinOccurs(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_MinOccurs_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x000B9A48 File Offset: 0x000B7C48
		[CallerCount(0)]
		public unsafe static void BuildElement_Name(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Name_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x000B9A90 File Offset: 0x000B7C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437237, XrefRangeEnd = 437240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Nillable(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Nillable_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x000B9AD8 File Offset: 0x000B7CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437240, XrefRangeEnd = 437249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Ref(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Ref_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x000B9B20 File Offset: 0x000B7D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437249, XrefRangeEnd = 437258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Type(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Type_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x000B9B68 File Offset: 0x000B7D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437258, XrefRangeEnd = 437271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSimpleType(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSimpleType_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x000B9BB0 File Offset: 0x000B7DB0
		[CallerCount(0)]
		public unsafe static void BuildSimpleType_Name(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSimpleType_Name_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x000B9BF8 File Offset: 0x000B7DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437271, XrefRangeEnd = 437274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSimpleType_Final(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSimpleType_Final_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x000B9C40 File Offset: 0x000B7E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437274, XrefRangeEnd = 437284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSimpleTypeUnion(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSimpleTypeUnion_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x000B9C88 File Offset: 0x000B7E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437284, XrefRangeEnd = 437291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSimpleTypeUnion_MemberTypes_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x000B9CD0 File Offset: 0x000B7ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437291, XrefRangeEnd = 437298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSimpleTypeList(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSimpleTypeList_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x000B9D18 File Offset: 0x000B7F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437298, XrefRangeEnd = 437307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSimpleTypeList_ItemType_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x000B9D60 File Offset: 0x000B7F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437307, XrefRangeEnd = 437314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSimpleTypeRestriction(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSimpleTypeRestriction_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x000B9DA8 File Offset: 0x000B7FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437314, XrefRangeEnd = 437323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSimpleTypeRestriction_Base_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x000B9DF0 File Offset: 0x000B7FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437323, XrefRangeEnd = 437334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitComplexType(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitComplexType_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x000B9E38 File Offset: 0x000B8038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437334, XrefRangeEnd = 437337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildComplexType_Abstract(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Abstract_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x000B9E80 File Offset: 0x000B8080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437337, XrefRangeEnd = 437340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildComplexType_Block(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Block_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x000B9EC8 File Offset: 0x000B80C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437340, XrefRangeEnd = 437343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildComplexType_Final(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Final_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x000B9F10 File Offset: 0x000B8110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437343, XrefRangeEnd = 437347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildComplexType_Mixed(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Mixed_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x000B9F58 File Offset: 0x000B8158
		[CallerCount(0)]
		public unsafe static void BuildComplexType_Name(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Name_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x000B9FA0 File Offset: 0x000B81A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437347, XrefRangeEnd = 437356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitComplexContent(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitComplexContent_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x000B9FE8 File Offset: 0x000B81E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437356, XrefRangeEnd = 437359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildComplexContent_Mixed(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildComplexContent_Mixed_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x000BA030 File Offset: 0x000B8230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437359, XrefRangeEnd = 437376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitComplexContentExtension(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitComplexContentExtension_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x000BA078 File Offset: 0x000B8278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437376, XrefRangeEnd = 437385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildComplexContentExtension_Base(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildComplexContentExtension_Base_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x000BA0C0 File Offset: 0x000B82C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437385, XrefRangeEnd = 437397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitComplexContentRestriction(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitComplexContentRestriction_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x000BA108 File Offset: 0x000B8308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437397, XrefRangeEnd = 437406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildComplexContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x000BA150 File Offset: 0x000B8350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437406, XrefRangeEnd = 437415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSimpleContent(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSimpleContent_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x000BA198 File Offset: 0x000B8398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437415, XrefRangeEnd = 437432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSimpleContentExtension(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSimpleContentExtension_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x000BA1E0 File Offset: 0x000B83E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437432, XrefRangeEnd = 437441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSimpleContentExtension_Base_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x000BA228 File Offset: 0x000B8428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437441, XrefRangeEnd = 437461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSimpleContentRestriction(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSimpleContentRestriction_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x000BA270 File Offset: 0x000B8470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437461, XrefRangeEnd = 437470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSimpleContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x000BA2B8 File Offset: 0x000B84B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437470, XrefRangeEnd = 437478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAttributeGroup(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitAttributeGroup_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x000BA300 File Offset: 0x000B8500
		[CallerCount(0)]
		public unsafe static void BuildAttributeGroup_Name(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttributeGroup_Name_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x000BA348 File Offset: 0x000B8548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437478, XrefRangeEnd = 437487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAttributeGroupRef(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitAttributeGroupRef_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x000BA390 File Offset: 0x000B8590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437487, XrefRangeEnd = 437496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttributeGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x000BA3D8 File Offset: 0x000B85D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437496, XrefRangeEnd = 437506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAnyAttribute(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitAnyAttribute_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x000BA420 File Offset: 0x000B8620
		[CallerCount(0)]
		public unsafe static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAnyAttribute_Namespace_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x000BA468 File Offset: 0x000B8668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437506, XrefRangeEnd = 437513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAnyAttribute_ProcessContents_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x000BA4B0 File Offset: 0x000B86B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437513, XrefRangeEnd = 437524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitGroup(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitGroup_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x000BA4F8 File Offset: 0x000B86F8
		[CallerCount(0)]
		public unsafe static void BuildGroup_Name(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildGroup_Name_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x000BA540 File Offset: 0x000B8740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437524, XrefRangeEnd = 437537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitGroupRef(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitGroupRef_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x000BA588 File Offset: 0x000B8788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437537, XrefRangeEnd = 437539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildParticle_MaxOccurs(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildParticle_MaxOccurs_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x000BA5D0 File Offset: 0x000B87D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437539, XrefRangeEnd = 437541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildParticle_MinOccurs(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildParticle_MinOccurs_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x000BA618 File Offset: 0x000B8818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437541, XrefRangeEnd = 437550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildGroupRef_Ref(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x000BA660 File Offset: 0x000B8860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437550, XrefRangeEnd = 437556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAll(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitAll_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x000BA6A8 File Offset: 0x000B88A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437556, XrefRangeEnd = 437562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitChoice(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitChoice_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x000BA6F0 File Offset: 0x000B88F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437562, XrefRangeEnd = 437568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSequence(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSequence_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x000BA738 File Offset: 0x000B8938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437568, XrefRangeEnd = 437577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAny(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitAny_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x000BA780 File Offset: 0x000B8980
		[CallerCount(0)]
		public unsafe static void BuildAny_Namespace(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAny_Namespace_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x000BA7C8 File Offset: 0x000B89C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437577, XrefRangeEnd = 437584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAny_ProcessContents(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAny_ProcessContents_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x000BA810 File Offset: 0x000B8A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437584, XrefRangeEnd = 437595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitNotation(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitNotation_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x000BA858 File Offset: 0x000B8A58
		[CallerCount(0)]
		public unsafe static void BuildNotation_Name(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildNotation_Name_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x000BA8A0 File Offset: 0x000B8AA0
		[CallerCount(0)]
		public unsafe static void BuildNotation_Public(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildNotation_Public_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x000BA8E8 File Offset: 0x000B8AE8
		[CallerCount(0)]
		public unsafe static void BuildNotation_System(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildNotation_System_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x000BA930 File Offset: 0x000B8B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437595, XrefRangeEnd = 437652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitFacet(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitFacet_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x000BA978 File Offset: 0x000B8B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437652, XrefRangeEnd = 437656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildFacet_Fixed(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildFacet_Fixed_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x000BA9C0 File Offset: 0x000B8BC0
		[CallerCount(0)]
		public unsafe static void BuildFacet_Value(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildFacet_Value_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x000BAA08 File Offset: 0x000B8C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437656, XrefRangeEnd = 437681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitIdentityConstraint(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitIdentityConstraint_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x000BAA50 File Offset: 0x000B8C50
		[CallerCount(0)]
		public unsafe static void BuildIdentityConstraint_Name(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildIdentityConstraint_Name_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x000BAA98 File Offset: 0x000B8C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437681, XrefRangeEnd = 437694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildIdentityConstraint_Refer_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x000BAAE0 File Offset: 0x000B8CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437694, XrefRangeEnd = 437700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSelector(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSelector_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x000BAB28 File Offset: 0x000B8D28
		[CallerCount(0)]
		public unsafe static void BuildSelector_XPath(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSelector_XPath_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x000BAB70 File Offset: 0x000B8D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437700, XrefRangeEnd = 437710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitField(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitField_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x000BABB8 File Offset: 0x000B8DB8
		[CallerCount(0)]
		public unsafe static void BuildField_XPath(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildField_XPath_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x000BAC00 File Offset: 0x000B8E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437710, XrefRangeEnd = 437724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAnnotation(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitAnnotation_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x000BAC48 File Offset: 0x000B8E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437724, XrefRangeEnd = 437733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAppinfo(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitAppinfo_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x000BAC90 File Offset: 0x000B8E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437733, XrefRangeEnd = 437736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAppinfo_Source(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAppinfo_Source_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x000BACD8 File Offset: 0x000B8ED8
		[CallerCount(0)]
		public unsafe static void EndAppinfo(XsdBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_EndAppinfo_Private_Static_Void_XsdBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x000BAD10 File Offset: 0x000B8F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437736, XrefRangeEnd = 437745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitDocumentation(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitDocumentation_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x000BAD58 File Offset: 0x000B8F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437745, XrefRangeEnd = 437748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildDocumentation_Source(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildDocumentation_Source_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x000BADA0 File Offset: 0x000B8FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437748, XrefRangeEnd = 437757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildDocumentation_XmlLang(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildDocumentation_XmlLang_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x000BADE8 File Offset: 0x000B8FE8
		[CallerCount(0)]
		public unsafe static void EndDocumentation(XsdBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_EndDocumentation_Private_Static_Void_XsdBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x000BAE20 File Offset: 0x000B9020
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 437766, RefRangeEnd = 437768, XrefRangeStart = 437757, XrefRangeEnd = 437766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAttribute(XmlSchemaObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_AddAttribute_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x000BAE64 File Offset: 0x000B9064
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 437781, RefRangeEnd = 437786, XrefRangeStart = 437768, XrefRangeEnd = 437781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddParticle(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_AddParticle_Private_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x000BAEA8 File Offset: 0x000B90A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 437794, RefRangeEnd = 437795, XrefRangeStart = 437786, XrefRangeEnd = 437794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNextState(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x000BAEF8 File Offset: 0x000B90F8
		[CallerCount(0)]
		public unsafe bool IsSkipableElement(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x000BAF48 File Offset: 0x000B9148
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 437799, RefRangeEnd = 437801, XrefRangeStart = 437795, XrefRangeEnd = 437799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMinOccurs(XmlSchemaParticle particle, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_SetMinOccurs_Private_Void_XmlSchemaParticle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x000BAF9C File Offset: 0x000B919C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 437805, RefRangeEnd = 437807, XrefRangeStart = 437801, XrefRangeEnd = 437805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaxOccurs(XmlSchemaParticle particle, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_SetMaxOccurs_Private_Void_XmlSchemaParticle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x000BAFF0 File Offset: 0x000B91F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 437814, RefRangeEnd = 437820, XrefRangeStart = 437807, XrefRangeEnd = 437814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseBoolean(string value, string attributeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ParseBoolean_Private_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x000BB050 File Offset: 0x000B9250
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 437825, RefRangeEnd = 437832, XrefRangeStart = 437820, XrefRangeEnd = 437825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseEnum(string value, string attributeName, Il2CppStringArray values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ParseEnum_Private_Int32_String_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x000BB0C4 File Offset: 0x000B92C4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 437857, RefRangeEnd = 437871, XrefRangeStart = 437832, XrefRangeEnd = 437857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName ParseQName(string value, string attributeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ParseQName_Private_XmlQualifiedName_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x000BB128 File Offset: 0x000B9328
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 437897, RefRangeEnd = 437904, XrefRangeStart = 437871, XrefRangeEnd = 437897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseBlockFinalEnum(string value, string attributeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ParseBlockFinalEnum_Private_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x000BB188 File Offset: 0x000B9388
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseUriReference(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ParseUriReference_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x000BB1C4 File Offset: 0x000B93C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 437925, RefRangeEnd = 437928, XrefRangeStart = 437904, XrefRangeEnd = 437925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string arg0, string arg1, string arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x000BB240 File Offset: 0x000B9440
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 437934, RefRangeEnd = 437958, XrefRangeStart = 437928, XrefRangeEnd = 437934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x000BB294 File Offset: 0x000B9494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 437964, RefRangeEnd = 437965, XrefRangeStart = 437958, XrefRangeEnd = 437964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, Il2CppStringArray args, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x000BB2F8 File Offset: 0x000B94F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 437971, RefRangeEnd = 437977, XrefRangeStart = 437965, XrefRangeEnd = 437971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x000BB348 File Offset: 0x000B9548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437977, XrefRangeEnd = 437978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSchemaException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x000BB38C File Offset: 0x000B958C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437978, XrefRangeEnd = 437979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_RecordPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x00010B5F File Offset: 0x0000ED5F
		public XsdBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x000BB3C0 File Offset: 0x000B95C0
		// (set) Token: 0x0600282E RID: 10286 RVA: 0x00010B68 File Offset: 0x0000ED68
		public unsafe static Il2CppStructArray<XsdBuilder.State> SchemaElement
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SchemaElement, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SchemaElement, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x0600282F RID: 10287 RVA: 0x000BB3E8 File Offset: 0x000B95E8
		// (set) Token: 0x06002830 RID: 10288 RVA: 0x00010B7A File Offset: 0x0000ED7A
		public unsafe static Il2CppStructArray<XsdBuilder.State> SchemaSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SchemaSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SchemaSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x000BB410 File Offset: 0x000B9610
		// (set) Token: 0x06002832 RID: 10290 RVA: 0x00010B8C File Offset: 0x0000ED8C
		public unsafe static Il2CppStructArray<XsdBuilder.State> AttributeSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AttributeSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AttributeSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x000BB438 File Offset: 0x000B9638
		// (set) Token: 0x06002834 RID: 10292 RVA: 0x00010B9E File Offset: 0x0000ED9E
		public unsafe static Il2CppStructArray<XsdBuilder.State> ElementSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ElementSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ElementSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x000BB460 File Offset: 0x000B9660
		// (set) Token: 0x06002836 RID: 10294 RVA: 0x00010BB0 File Offset: 0x0000EDB0
		public unsafe static Il2CppStructArray<XsdBuilder.State> ComplexTypeSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ComplexTypeSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ComplexTypeSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06002837 RID: 10295 RVA: 0x000BB488 File Offset: 0x000B9688
		// (set) Token: 0x06002838 RID: 10296 RVA: 0x00010BC2 File Offset: 0x0000EDC2
		public unsafe static Il2CppStructArray<XsdBuilder.State> SimpleContentSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06002839 RID: 10297 RVA: 0x000BB4B0 File Offset: 0x000B96B0
		// (set) Token: 0x0600283A RID: 10298 RVA: 0x00010BD4 File Offset: 0x0000EDD4
		public unsafe static Il2CppStructArray<XsdBuilder.State> SimpleContentExtensionSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentExtensionSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentExtensionSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x000BB4D8 File Offset: 0x000B96D8
		// (set) Token: 0x0600283C RID: 10300 RVA: 0x00010BE6 File Offset: 0x0000EDE6
		public unsafe static Il2CppStructArray<XsdBuilder.State> SimpleContentRestrictionSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentRestrictionSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentRestrictionSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x000BB500 File Offset: 0x000B9700
		// (set) Token: 0x0600283E RID: 10302 RVA: 0x00010BF8 File Offset: 0x0000EDF8
		public unsafe static Il2CppStructArray<XsdBuilder.State> ComplexContentSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x000BB528 File Offset: 0x000B9728
		// (set) Token: 0x06002840 RID: 10304 RVA: 0x00010C0A File Offset: 0x0000EE0A
		public unsafe static Il2CppStructArray<XsdBuilder.State> ComplexContentExtensionSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentExtensionSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentExtensionSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06002841 RID: 10305 RVA: 0x000BB550 File Offset: 0x000B9750
		// (set) Token: 0x06002842 RID: 10306 RVA: 0x00010C1C File Offset: 0x0000EE1C
		public unsafe static Il2CppStructArray<XsdBuilder.State> ComplexContentRestrictionSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentRestrictionSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentRestrictionSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x000BB578 File Offset: 0x000B9778
		// (set) Token: 0x06002844 RID: 10308 RVA: 0x00010C2E File Offset: 0x0000EE2E
		public unsafe static Il2CppStructArray<XsdBuilder.State> SimpleTypeSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06002845 RID: 10309 RVA: 0x000BB5A0 File Offset: 0x000B97A0
		// (set) Token: 0x06002846 RID: 10310 RVA: 0x00010C40 File Offset: 0x0000EE40
		public unsafe static Il2CppStructArray<XsdBuilder.State> SimpleTypeRestrictionSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeRestrictionSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeRestrictionSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06002847 RID: 10311 RVA: 0x000BB5C8 File Offset: 0x000B97C8
		// (set) Token: 0x06002848 RID: 10312 RVA: 0x00010C52 File Offset: 0x0000EE52
		public unsafe static Il2CppStructArray<XsdBuilder.State> SimpleTypeListSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeListSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeListSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06002849 RID: 10313 RVA: 0x000BB5F0 File Offset: 0x000B97F0
		// (set) Token: 0x0600284A RID: 10314 RVA: 0x00010C64 File Offset: 0x0000EE64
		public unsafe static Il2CppStructArray<XsdBuilder.State> SimpleTypeUnionSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeUnionSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeUnionSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x0600284B RID: 10315 RVA: 0x000BB618 File Offset: 0x000B9818
		// (set) Token: 0x0600284C RID: 10316 RVA: 0x00010C76 File Offset: 0x0000EE76
		public unsafe static Il2CppStructArray<XsdBuilder.State> RedefineSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_RedefineSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_RedefineSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x0600284D RID: 10317 RVA: 0x000BB640 File Offset: 0x000B9840
		// (set) Token: 0x0600284E RID: 10318 RVA: 0x00010C88 File Offset: 0x0000EE88
		public unsafe static Il2CppStructArray<XsdBuilder.State> AttributeGroupSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AttributeGroupSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AttributeGroupSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x0600284F RID: 10319 RVA: 0x000BB668 File Offset: 0x000B9868
		// (set) Token: 0x06002850 RID: 10320 RVA: 0x00010C9A File Offset: 0x0000EE9A
		public unsafe static Il2CppStructArray<XsdBuilder.State> GroupSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_GroupSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_GroupSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06002851 RID: 10321 RVA: 0x000BB690 File Offset: 0x000B9890
		// (set) Token: 0x06002852 RID: 10322 RVA: 0x00010CAC File Offset: 0x0000EEAC
		public unsafe static Il2CppStructArray<XsdBuilder.State> AllSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AllSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AllSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06002853 RID: 10323 RVA: 0x000BB6B8 File Offset: 0x000B98B8
		// (set) Token: 0x06002854 RID: 10324 RVA: 0x00010CBE File Offset: 0x0000EEBE
		public unsafe static Il2CppStructArray<XsdBuilder.State> ChoiceSequenceSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ChoiceSequenceSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ChoiceSequenceSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06002855 RID: 10325 RVA: 0x000BB6E0 File Offset: 0x000B98E0
		// (set) Token: 0x06002856 RID: 10326 RVA: 0x00010CD0 File Offset: 0x0000EED0
		public unsafe static Il2CppStructArray<XsdBuilder.State> IdentityConstraintSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_IdentityConstraintSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_IdentityConstraintSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x000BB708 File Offset: 0x000B9908
		// (set) Token: 0x06002858 RID: 10328 RVA: 0x00010CE2 File Offset: 0x0000EEE2
		public unsafe static Il2CppStructArray<XsdBuilder.State> AnnotationSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AnnotationSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AnnotationSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06002859 RID: 10329 RVA: 0x000BB730 File Offset: 0x000B9930
		// (set) Token: 0x0600285A RID: 10330 RVA: 0x00010CF4 File Offset: 0x0000EEF4
		public unsafe static Il2CppStructArray<XsdBuilder.State> AnnotatedSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AnnotatedSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AnnotatedSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x000BB758 File Offset: 0x000B9958
		// (set) Token: 0x0600285C RID: 10332 RVA: 0x00010D06 File Offset: 0x0000EF06
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SchemaAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SchemaAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SchemaAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x0600285D RID: 10333 RVA: 0x000BB780 File Offset: 0x000B9980
		// (set) Token: 0x0600285E RID: 10334 RVA: 0x00010D18 File Offset: 0x0000EF18
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> AttributeAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AttributeAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AttributeAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x000BB7A8 File Offset: 0x000B99A8
		// (set) Token: 0x06002860 RID: 10336 RVA: 0x00010D2A File Offset: 0x0000EF2A
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> ElementAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ElementAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ElementAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06002861 RID: 10337 RVA: 0x000BB7D0 File Offset: 0x000B99D0
		// (set) Token: 0x06002862 RID: 10338 RVA: 0x00010D3C File Offset: 0x0000EF3C
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> ComplexTypeAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ComplexTypeAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ComplexTypeAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06002863 RID: 10339 RVA: 0x000BB7F8 File Offset: 0x000B99F8
		// (set) Token: 0x06002864 RID: 10340 RVA: 0x00010D4E File Offset: 0x0000EF4E
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SimpleContentAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06002865 RID: 10341 RVA: 0x000BB820 File Offset: 0x000B9A20
		// (set) Token: 0x06002866 RID: 10342 RVA: 0x00010D60 File Offset: 0x0000EF60
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SimpleContentExtensionAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentExtensionAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentExtensionAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06002867 RID: 10343 RVA: 0x000BB848 File Offset: 0x000B9A48
		// (set) Token: 0x06002868 RID: 10344 RVA: 0x00010D72 File Offset: 0x0000EF72
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SimpleContentRestrictionAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentRestrictionAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentRestrictionAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x000BB870 File Offset: 0x000B9A70
		// (set) Token: 0x0600286A RID: 10346 RVA: 0x00010D84 File Offset: 0x0000EF84
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> ComplexContentAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x000BB898 File Offset: 0x000B9A98
		// (set) Token: 0x0600286C RID: 10348 RVA: 0x00010D96 File Offset: 0x0000EF96
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> ComplexContentExtensionAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentExtensionAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentExtensionAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x0600286D RID: 10349 RVA: 0x000BB8C0 File Offset: 0x000B9AC0
		// (set) Token: 0x0600286E RID: 10350 RVA: 0x00010DA8 File Offset: 0x0000EFA8
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> ComplexContentRestrictionAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentRestrictionAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentRestrictionAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x0600286F RID: 10351 RVA: 0x000BB8E8 File Offset: 0x000B9AE8
		// (set) Token: 0x06002870 RID: 10352 RVA: 0x00010DBA File Offset: 0x0000EFBA
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SimpleTypeAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06002871 RID: 10353 RVA: 0x000BB910 File Offset: 0x000B9B10
		// (set) Token: 0x06002872 RID: 10354 RVA: 0x00010DCC File Offset: 0x0000EFCC
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SimpleTypeRestrictionAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeRestrictionAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeRestrictionAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06002873 RID: 10355 RVA: 0x000BB938 File Offset: 0x000B9B38
		// (set) Token: 0x06002874 RID: 10356 RVA: 0x00010DDE File Offset: 0x0000EFDE
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SimpleTypeUnionAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeUnionAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeUnionAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06002875 RID: 10357 RVA: 0x000BB960 File Offset: 0x000B9B60
		// (set) Token: 0x06002876 RID: 10358 RVA: 0x00010DF0 File Offset: 0x0000EFF0
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SimpleTypeListAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeListAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeListAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06002877 RID: 10359 RVA: 0x000BB988 File Offset: 0x000B9B88
		// (set) Token: 0x06002878 RID: 10360 RVA: 0x00010E02 File Offset: 0x0000F002
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> AttributeGroupAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AttributeGroupAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AttributeGroupAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06002879 RID: 10361 RVA: 0x000BB9B0 File Offset: 0x000B9BB0
		// (set) Token: 0x0600287A RID: 10362 RVA: 0x00010E14 File Offset: 0x0000F014
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> AttributeGroupRefAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AttributeGroupRefAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AttributeGroupRefAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x0600287B RID: 10363 RVA: 0x000BB9D8 File Offset: 0x000B9BD8
		// (set) Token: 0x0600287C RID: 10364 RVA: 0x00010E26 File Offset: 0x0000F026
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> GroupAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_GroupAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_GroupAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x0600287D RID: 10365 RVA: 0x000BBA00 File Offset: 0x000B9C00
		// (set) Token: 0x0600287E RID: 10366 RVA: 0x00010E38 File Offset: 0x0000F038
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> GroupRefAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_GroupRefAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_GroupRefAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x0600287F RID: 10367 RVA: 0x000BBA28 File Offset: 0x000B9C28
		// (set) Token: 0x06002880 RID: 10368 RVA: 0x00010E4A File Offset: 0x0000F04A
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> ParticleAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ParticleAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ParticleAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06002881 RID: 10369 RVA: 0x000BBA50 File Offset: 0x000B9C50
		// (set) Token: 0x06002882 RID: 10370 RVA: 0x00010E5C File Offset: 0x0000F05C
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> AnyAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AnyAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AnyAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06002883 RID: 10371 RVA: 0x000BBA78 File Offset: 0x000B9C78
		// (set) Token: 0x06002884 RID: 10372 RVA: 0x00010E6E File Offset: 0x0000F06E
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> IdentityConstraintAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_IdentityConstraintAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_IdentityConstraintAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06002885 RID: 10373 RVA: 0x000BBAA0 File Offset: 0x000B9CA0
		// (set) Token: 0x06002886 RID: 10374 RVA: 0x00010E80 File Offset: 0x0000F080
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SelectorAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SelectorAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SelectorAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06002887 RID: 10375 RVA: 0x000BBAC8 File Offset: 0x000B9CC8
		// (set) Token: 0x06002888 RID: 10376 RVA: 0x00010E92 File Offset: 0x0000F092
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> FieldAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_FieldAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_FieldAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06002889 RID: 10377 RVA: 0x000BBAF0 File Offset: 0x000B9CF0
		// (set) Token: 0x0600288A RID: 10378 RVA: 0x00010EA4 File Offset: 0x0000F0A4
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> NotationAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_NotationAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_NotationAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x0600288B RID: 10379 RVA: 0x000BBB18 File Offset: 0x000B9D18
		// (set) Token: 0x0600288C RID: 10380 RVA: 0x00010EB6 File Offset: 0x0000F0B6
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> IncludeAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_IncludeAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_IncludeAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x0600288D RID: 10381 RVA: 0x000BBB40 File Offset: 0x000B9D40
		// (set) Token: 0x0600288E RID: 10382 RVA: 0x00010EC8 File Offset: 0x0000F0C8
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> ImportAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ImportAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ImportAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x0600288F RID: 10383 RVA: 0x000BBB68 File Offset: 0x000B9D68
		// (set) Token: 0x06002890 RID: 10384 RVA: 0x00010EDA File Offset: 0x0000F0DA
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> FacetAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_FacetAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_FacetAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06002891 RID: 10385 RVA: 0x000BBB90 File Offset: 0x000B9D90
		// (set) Token: 0x06002892 RID: 10386 RVA: 0x00010EEC File Offset: 0x0000F0EC
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> AnyAttributeAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AnyAttributeAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AnyAttributeAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06002893 RID: 10387 RVA: 0x000BBBB8 File Offset: 0x000B9DB8
		// (set) Token: 0x06002894 RID: 10388 RVA: 0x00010EFE File Offset: 0x0000F0FE
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> DocumentationAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_DocumentationAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_DocumentationAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06002895 RID: 10389 RVA: 0x000BBBE0 File Offset: 0x000B9DE0
		// (set) Token: 0x06002896 RID: 10390 RVA: 0x00010F10 File Offset: 0x0000F110
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> AppinfoAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AppinfoAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AppinfoAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06002897 RID: 10391 RVA: 0x000BBC08 File Offset: 0x000B9E08
		// (set) Token: 0x06002898 RID: 10392 RVA: 0x00010F22 File Offset: 0x0000F122
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> RedefineAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_RedefineAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_RedefineAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x000BBC30 File Offset: 0x000B9E30
		// (set) Token: 0x0600289A RID: 10394 RVA: 0x00010F34 File Offset: 0x0000F134
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> AnnotationAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AnnotationAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AnnotationAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x0600289B RID: 10395 RVA: 0x000BBC58 File Offset: 0x000B9E58
		// (set) Token: 0x0600289C RID: 10396 RVA: 0x00010F46 File Offset: 0x0000F146
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdEntry> SchemaEntries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SchemaEntries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SchemaEntries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x000BBC80 File Offset: 0x000B9E80
		// (set) Token: 0x0600289E RID: 10398 RVA: 0x00010F58 File Offset: 0x0000F158
		public unsafe static Il2CppStructArray<int> DerivationMethodValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_DerivationMethodValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_DerivationMethodValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x000BBCA8 File Offset: 0x000B9EA8
		// (set) Token: 0x060028A0 RID: 10400 RVA: 0x00010F6A File Offset: 0x0000F16A
		public unsafe static Il2CppStringArray DerivationMethodStrings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_DerivationMethodStrings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_DerivationMethodStrings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x060028A1 RID: 10401 RVA: 0x000BBCD0 File Offset: 0x000B9ED0
		// (set) Token: 0x060028A2 RID: 10402 RVA: 0x00010F7C File Offset: 0x0000F17C
		public unsafe static Il2CppStringArray FormStringValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_FormStringValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_FormStringValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x000BBCF8 File Offset: 0x000B9EF8
		// (set) Token: 0x060028A4 RID: 10404 RVA: 0x00010F8E File Offset: 0x0000F18E
		public unsafe static Il2CppStringArray UseStringValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_UseStringValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_UseStringValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x060028A5 RID: 10405 RVA: 0x000BBD20 File Offset: 0x000B9F20
		// (set) Token: 0x060028A6 RID: 10406 RVA: 0x00010FA0 File Offset: 0x0000F1A0
		public unsafe static Il2CppStringArray ProcessContentsStringValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ProcessContentsStringValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ProcessContentsStringValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x000BBD48 File Offset: 0x000B9F48
		// (set) Token: 0x060028A8 RID: 10408 RVA: 0x00010FB2 File Offset: 0x0000F1B2
		public unsafe XmlReader reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x060028A9 RID: 10409 RVA: 0x000BBD78 File Offset: 0x000B9F78
		// (set) Token: 0x060028AA RID: 10410 RVA: 0x00010FD1 File Offset: 0x0000F1D1
		public unsafe PositionInfo positionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_positionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PositionInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_positionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x000BBDA8 File Offset: 0x000B9FA8
		// (set) Token: 0x060028AC RID: 10412 RVA: 0x00010FF0 File Offset: 0x0000F1F0
		public unsafe XsdBuilder.XsdEntry currentEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_currentEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XsdBuilder.XsdEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_currentEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x000BBDD8 File Offset: 0x000B9FD8
		// (set) Token: 0x060028AE RID: 10414 RVA: 0x0001100F File Offset: 0x0000F20F
		public unsafe XsdBuilder.XsdEntry nextEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_nextEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XsdBuilder.XsdEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_nextEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x000BBE08 File Offset: 0x000BA008
		// (set) Token: 0x060028B0 RID: 10416 RVA: 0x0001102E File Offset: 0x0000F22E
		public unsafe bool hasChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_hasChild);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_hasChild)) = value;
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x000BBE30 File Offset: 0x000BA030
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x00011049 File Offset: 0x0000F249
		public unsafe HWStack stateHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_stateHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HWStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_stateHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x000BBE60 File Offset: 0x000BA060
		// (set) Token: 0x060028B4 RID: 10420 RVA: 0x00011068 File Offset: 0x0000F268
		public unsafe Stack containerStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_containerStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_containerStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x000BBE90 File Offset: 0x000BA090
		// (set) Token: 0x060028B6 RID: 10422 RVA: 0x00011087 File Offset: 0x0000F287
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x000BBEC0 File Offset: 0x000BA0C0
		// (set) Token: 0x060028B8 RID: 10424 RVA: 0x000110A6 File Offset: 0x0000F2A6
		public unsafe SchemaNames schemaNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_schemaNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_schemaNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x000BBEF0 File Offset: 0x000BA0F0
		// (set) Token: 0x060028BA RID: 10426 RVA: 0x000110C5 File Offset: 0x0000F2C5
		public unsafe XmlNamespaceManager namespaceManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_namespaceManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_namespaceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x000BBF20 File Offset: 0x000BA120
		// (set) Token: 0x060028BC RID: 10428 RVA: 0x000110E4 File Offset: 0x0000F2E4
		public unsafe bool canIncludeImport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_canIncludeImport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_canIncludeImport)) = value;
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x000BBF48 File Offset: 0x000BA148
		// (set) Token: 0x060028BE RID: 10430 RVA: 0x000110FF File Offset: 0x0000F2FF
		public unsafe XmlSchema schema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_schema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_schema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x060028BF RID: 10431 RVA: 0x000BBF78 File Offset: 0x000BA178
		// (set) Token: 0x060028C0 RID: 10432 RVA: 0x0001111E File Offset: 0x0000F31E
		public unsafe XmlSchemaObject xso
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_xso);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_xso), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x060028C1 RID: 10433 RVA: 0x000BBFA8 File Offset: 0x000BA1A8
		// (set) Token: 0x060028C2 RID: 10434 RVA: 0x0001113D File Offset: 0x0000F33D
		public unsafe XmlSchemaElement element
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_element);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_element), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x060028C3 RID: 10435 RVA: 0x000BBFD8 File Offset: 0x000BA1D8
		// (set) Token: 0x060028C4 RID: 10436 RVA: 0x0001115C File Offset: 0x0000F35C
		public unsafe XmlSchemaAny anyElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_anyElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAny>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_anyElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x060028C5 RID: 10437 RVA: 0x000BC008 File Offset: 0x000BA208
		// (set) Token: 0x060028C6 RID: 10438 RVA: 0x0001117B File Offset: 0x0000F37B
		public unsafe XmlSchemaAttribute attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_attribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x060028C7 RID: 10439 RVA: 0x000BC038 File Offset: 0x000BA238
		// (set) Token: 0x060028C8 RID: 10440 RVA: 0x0001119A File Offset: 0x0000F39A
		public unsafe XmlSchemaAnyAttribute anyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_anyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_anyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x060028C9 RID: 10441 RVA: 0x000BC068 File Offset: 0x000BA268
		// (set) Token: 0x060028CA RID: 10442 RVA: 0x000111B9 File Offset: 0x0000F3B9
		public unsafe XmlSchemaComplexType complexType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_complexType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_complexType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x060028CB RID: 10443 RVA: 0x000BC098 File Offset: 0x000BA298
		// (set) Token: 0x060028CC RID: 10444 RVA: 0x000111D8 File Offset: 0x0000F3D8
		public unsafe XmlSchemaSimpleType simpleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x060028CD RID: 10445 RVA: 0x000BC0C8 File Offset: 0x000BA2C8
		// (set) Token: 0x060028CE RID: 10446 RVA: 0x000111F7 File Offset: 0x0000F3F7
		public unsafe XmlSchemaComplexContent complexContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_complexContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_complexContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x060028CF RID: 10447 RVA: 0x000BC0F8 File Offset: 0x000BA2F8
		// (set) Token: 0x060028D0 RID: 10448 RVA: 0x00011216 File Offset: 0x0000F416
		public unsafe XmlSchemaComplexContentExtension complexContentExtension
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_complexContentExtension);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexContentExtension>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_complexContentExtension), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x060028D1 RID: 10449 RVA: 0x000BC128 File Offset: 0x000BA328
		// (set) Token: 0x060028D2 RID: 10450 RVA: 0x00011235 File Offset: 0x0000F435
		public unsafe XmlSchemaComplexContentRestriction complexContentRestriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_complexContentRestriction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexContentRestriction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_complexContentRestriction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x060028D3 RID: 10451 RVA: 0x000BC158 File Offset: 0x000BA358
		// (set) Token: 0x060028D4 RID: 10452 RVA: 0x00011254 File Offset: 0x0000F454
		public unsafe XmlSchemaSimpleContent simpleContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x060028D5 RID: 10453 RVA: 0x000BC188 File Offset: 0x000BA388
		// (set) Token: 0x060028D6 RID: 10454 RVA: 0x00011273 File Offset: 0x0000F473
		public unsafe XmlSchemaSimpleContentExtension simpleContentExtension
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleContentExtension);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleContentExtension>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleContentExtension), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x060028D7 RID: 10455 RVA: 0x000BC1B8 File Offset: 0x000BA3B8
		// (set) Token: 0x060028D8 RID: 10456 RVA: 0x00011292 File Offset: 0x0000F492
		public unsafe XmlSchemaSimpleContentRestriction simpleContentRestriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleContentRestriction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleContentRestriction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleContentRestriction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x060028D9 RID: 10457 RVA: 0x000BC1E8 File Offset: 0x000BA3E8
		// (set) Token: 0x060028DA RID: 10458 RVA: 0x000112B1 File Offset: 0x0000F4B1
		public unsafe XmlSchemaSimpleTypeUnion simpleTypeUnion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleTypeUnion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleTypeUnion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleTypeUnion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x060028DB RID: 10459 RVA: 0x000BC218 File Offset: 0x000BA418
		// (set) Token: 0x060028DC RID: 10460 RVA: 0x000112D0 File Offset: 0x0000F4D0
		public unsafe XmlSchemaSimpleTypeList simpleTypeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleTypeList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleTypeList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleTypeList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x060028DD RID: 10461 RVA: 0x000BC248 File Offset: 0x000BA448
		// (set) Token: 0x060028DE RID: 10462 RVA: 0x000112EF File Offset: 0x0000F4EF
		public unsafe XmlSchemaSimpleTypeRestriction simpleTypeRestriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleTypeRestriction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleTypeRestriction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleTypeRestriction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x060028DF RID: 10463 RVA: 0x000BC278 File Offset: 0x000BA478
		// (set) Token: 0x060028E0 RID: 10464 RVA: 0x0001130E File Offset: 0x0000F50E
		public unsafe XmlSchemaGroup group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x060028E1 RID: 10465 RVA: 0x000BC2A8 File Offset: 0x000BA4A8
		// (set) Token: 0x060028E2 RID: 10466 RVA: 0x0001132D File Offset: 0x0000F52D
		public unsafe XmlSchemaGroupRef groupRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_groupRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaGroupRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_groupRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x060028E3 RID: 10467 RVA: 0x000BC2D8 File Offset: 0x000BA4D8
		// (set) Token: 0x060028E4 RID: 10468 RVA: 0x0001134C File Offset: 0x0000F54C
		public unsafe XmlSchemaAll all
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_all);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAll>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_all), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x060028E5 RID: 10469 RVA: 0x000BC308 File Offset: 0x000BA508
		// (set) Token: 0x060028E6 RID: 10470 RVA: 0x0001136B File Offset: 0x0000F56B
		public unsafe XmlSchemaChoice choice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_choice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_choice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x000BC338 File Offset: 0x000BA538
		// (set) Token: 0x060028E8 RID: 10472 RVA: 0x0001138A File Offset: 0x0000F58A
		public unsafe XmlSchemaSequence sequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_sequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x000BC368 File Offset: 0x000BA568
		// (set) Token: 0x060028EA RID: 10474 RVA: 0x000113A9 File Offset: 0x0000F5A9
		public unsafe XmlSchemaParticle particle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_particle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_particle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x060028EB RID: 10475 RVA: 0x000BC398 File Offset: 0x000BA598
		// (set) Token: 0x060028EC RID: 10476 RVA: 0x000113C8 File Offset: 0x0000F5C8
		public unsafe XmlSchemaAttributeGroup attributeGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_attributeGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttributeGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_attributeGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x060028ED RID: 10477 RVA: 0x000BC3C8 File Offset: 0x000BA5C8
		// (set) Token: 0x060028EE RID: 10478 RVA: 0x000113E7 File Offset: 0x0000F5E7
		public unsafe XmlSchemaAttributeGroupRef attributeGroupRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_attributeGroupRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttributeGroupRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_attributeGroupRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x000BC3F8 File Offset: 0x000BA5F8
		// (set) Token: 0x060028F0 RID: 10480 RVA: 0x00011406 File Offset: 0x0000F606
		public unsafe XmlSchemaNotation notation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_notation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaNotation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_notation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x060028F1 RID: 10481 RVA: 0x000BC428 File Offset: 0x000BA628
		// (set) Token: 0x060028F2 RID: 10482 RVA: 0x00011425 File Offset: 0x0000F625
		public unsafe XmlSchemaIdentityConstraint identityConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_identityConstraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaIdentityConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_identityConstraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x060028F3 RID: 10483 RVA: 0x000BC458 File Offset: 0x000BA658
		// (set) Token: 0x060028F4 RID: 10484 RVA: 0x00011444 File Offset: 0x0000F644
		public unsafe XmlSchemaXPath xpath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_xpath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaXPath>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_xpath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x060028F5 RID: 10485 RVA: 0x000BC488 File Offset: 0x000BA688
		// (set) Token: 0x060028F6 RID: 10486 RVA: 0x00011463 File Offset: 0x0000F663
		public unsafe XmlSchemaInclude include
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_include);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaInclude>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_include), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x060028F7 RID: 10487 RVA: 0x000BC4B8 File Offset: 0x000BA6B8
		// (set) Token: 0x060028F8 RID: 10488 RVA: 0x00011482 File Offset: 0x0000F682
		public unsafe XmlSchemaImport import
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_import);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaImport>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_import), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x060028F9 RID: 10489 RVA: 0x000BC4E8 File Offset: 0x000BA6E8
		// (set) Token: 0x060028FA RID: 10490 RVA: 0x000114A1 File Offset: 0x0000F6A1
		public unsafe XmlSchemaAnnotation annotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_annotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnnotation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_annotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x060028FB RID: 10491 RVA: 0x000BC518 File Offset: 0x000BA718
		// (set) Token: 0x060028FC RID: 10492 RVA: 0x000114C0 File Offset: 0x0000F6C0
		public unsafe XmlSchemaAppInfo appInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_appInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAppInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_appInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x060028FD RID: 10493 RVA: 0x000BC548 File Offset: 0x000BA748
		// (set) Token: 0x060028FE RID: 10494 RVA: 0x000114DF File Offset: 0x0000F6DF
		public unsafe XmlSchemaDocumentation documentation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_documentation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDocumentation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_documentation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x060028FF RID: 10495 RVA: 0x000BC578 File Offset: 0x000BA778
		// (set) Token: 0x06002900 RID: 10496 RVA: 0x000114FE File Offset: 0x0000F6FE
		public unsafe XmlSchemaFacet facet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_facet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaFacet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_facet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x000BC5A8 File Offset: 0x000BA7A8
		// (set) Token: 0x06002902 RID: 10498 RVA: 0x0001151D File Offset: 0x0000F71D
		public unsafe Il2CppReferenceArray<XmlNode> markup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_markup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_markup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06002903 RID: 10499 RVA: 0x000BC5D8 File Offset: 0x000BA7D8
		// (set) Token: 0x06002904 RID: 10500 RVA: 0x0001153C File Offset: 0x0000F73C
		public unsafe XmlSchemaRedefine redefine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_redefine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaRedefine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_redefine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x000BC608 File Offset: 0x000BA808
		// (set) Token: 0x06002906 RID: 10502 RVA: 0x0001155B File Offset: 0x0000F75B
		public unsafe ValidationEventHandler validationEventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_validationEventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_validationEventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x000BC638 File Offset: 0x000BA838
		// (set) Token: 0x06002908 RID: 10504 RVA: 0x0001157A File Offset: 0x0000F77A
		public unsafe ArrayList unhandledAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_unhandledAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_unhandledAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x000BC668 File Offset: 0x000BA868
		// (set) Token: 0x0600290A RID: 10506 RVA: 0x00011599 File Offset: 0x0000F799
		public unsafe Hashtable namespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_namespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_namespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DE2 RID: 7650
		private static readonly IntPtr NativeFieldInfoPtr_SchemaElement;

		// Token: 0x04001DE3 RID: 7651
		private static readonly IntPtr NativeFieldInfoPtr_SchemaSubelements;

		// Token: 0x04001DE4 RID: 7652
		private static readonly IntPtr NativeFieldInfoPtr_AttributeSubelements;

		// Token: 0x04001DE5 RID: 7653
		private static readonly IntPtr NativeFieldInfoPtr_ElementSubelements;

		// Token: 0x04001DE6 RID: 7654
		private static readonly IntPtr NativeFieldInfoPtr_ComplexTypeSubelements;

		// Token: 0x04001DE7 RID: 7655
		private static readonly IntPtr NativeFieldInfoPtr_SimpleContentSubelements;

		// Token: 0x04001DE8 RID: 7656
		private static readonly IntPtr NativeFieldInfoPtr_SimpleContentExtensionSubelements;

		// Token: 0x04001DE9 RID: 7657
		private static readonly IntPtr NativeFieldInfoPtr_SimpleContentRestrictionSubelements;

		// Token: 0x04001DEA RID: 7658
		private static readonly IntPtr NativeFieldInfoPtr_ComplexContentSubelements;

		// Token: 0x04001DEB RID: 7659
		private static readonly IntPtr NativeFieldInfoPtr_ComplexContentExtensionSubelements;

		// Token: 0x04001DEC RID: 7660
		private static readonly IntPtr NativeFieldInfoPtr_ComplexContentRestrictionSubelements;

		// Token: 0x04001DED RID: 7661
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypeSubelements;

		// Token: 0x04001DEE RID: 7662
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypeRestrictionSubelements;

		// Token: 0x04001DEF RID: 7663
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypeListSubelements;

		// Token: 0x04001DF0 RID: 7664
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypeUnionSubelements;

		// Token: 0x04001DF1 RID: 7665
		private static readonly IntPtr NativeFieldInfoPtr_RedefineSubelements;

		// Token: 0x04001DF2 RID: 7666
		private static readonly IntPtr NativeFieldInfoPtr_AttributeGroupSubelements;

		// Token: 0x04001DF3 RID: 7667
		private static readonly IntPtr NativeFieldInfoPtr_GroupSubelements;

		// Token: 0x04001DF4 RID: 7668
		private static readonly IntPtr NativeFieldInfoPtr_AllSubelements;

		// Token: 0x04001DF5 RID: 7669
		private static readonly IntPtr NativeFieldInfoPtr_ChoiceSequenceSubelements;

		// Token: 0x04001DF6 RID: 7670
		private static readonly IntPtr NativeFieldInfoPtr_IdentityConstraintSubelements;

		// Token: 0x04001DF7 RID: 7671
		private static readonly IntPtr NativeFieldInfoPtr_AnnotationSubelements;

		// Token: 0x04001DF8 RID: 7672
		private static readonly IntPtr NativeFieldInfoPtr_AnnotatedSubelements;

		// Token: 0x04001DF9 RID: 7673
		private static readonly IntPtr NativeFieldInfoPtr_SchemaAttributes;

		// Token: 0x04001DFA RID: 7674
		private static readonly IntPtr NativeFieldInfoPtr_AttributeAttributes;

		// Token: 0x04001DFB RID: 7675
		private static readonly IntPtr NativeFieldInfoPtr_ElementAttributes;

		// Token: 0x04001DFC RID: 7676
		private static readonly IntPtr NativeFieldInfoPtr_ComplexTypeAttributes;

		// Token: 0x04001DFD RID: 7677
		private static readonly IntPtr NativeFieldInfoPtr_SimpleContentAttributes;

		// Token: 0x04001DFE RID: 7678
		private static readonly IntPtr NativeFieldInfoPtr_SimpleContentExtensionAttributes;

		// Token: 0x04001DFF RID: 7679
		private static readonly IntPtr NativeFieldInfoPtr_SimpleContentRestrictionAttributes;

		// Token: 0x04001E00 RID: 7680
		private static readonly IntPtr NativeFieldInfoPtr_ComplexContentAttributes;

		// Token: 0x04001E01 RID: 7681
		private static readonly IntPtr NativeFieldInfoPtr_ComplexContentExtensionAttributes;

		// Token: 0x04001E02 RID: 7682
		private static readonly IntPtr NativeFieldInfoPtr_ComplexContentRestrictionAttributes;

		// Token: 0x04001E03 RID: 7683
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypeAttributes;

		// Token: 0x04001E04 RID: 7684
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypeRestrictionAttributes;

		// Token: 0x04001E05 RID: 7685
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypeUnionAttributes;

		// Token: 0x04001E06 RID: 7686
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypeListAttributes;

		// Token: 0x04001E07 RID: 7687
		private static readonly IntPtr NativeFieldInfoPtr_AttributeGroupAttributes;

		// Token: 0x04001E08 RID: 7688
		private static readonly IntPtr NativeFieldInfoPtr_AttributeGroupRefAttributes;

		// Token: 0x04001E09 RID: 7689
		private static readonly IntPtr NativeFieldInfoPtr_GroupAttributes;

		// Token: 0x04001E0A RID: 7690
		private static readonly IntPtr NativeFieldInfoPtr_GroupRefAttributes;

		// Token: 0x04001E0B RID: 7691
		private static readonly IntPtr NativeFieldInfoPtr_ParticleAttributes;

		// Token: 0x04001E0C RID: 7692
		private static readonly IntPtr NativeFieldInfoPtr_AnyAttributes;

		// Token: 0x04001E0D RID: 7693
		private static readonly IntPtr NativeFieldInfoPtr_IdentityConstraintAttributes;

		// Token: 0x04001E0E RID: 7694
		private static readonly IntPtr NativeFieldInfoPtr_SelectorAttributes;

		// Token: 0x04001E0F RID: 7695
		private static readonly IntPtr NativeFieldInfoPtr_FieldAttributes;

		// Token: 0x04001E10 RID: 7696
		private static readonly IntPtr NativeFieldInfoPtr_NotationAttributes;

		// Token: 0x04001E11 RID: 7697
		private static readonly IntPtr NativeFieldInfoPtr_IncludeAttributes;

		// Token: 0x04001E12 RID: 7698
		private static readonly IntPtr NativeFieldInfoPtr_ImportAttributes;

		// Token: 0x04001E13 RID: 7699
		private static readonly IntPtr NativeFieldInfoPtr_FacetAttributes;

		// Token: 0x04001E14 RID: 7700
		private static readonly IntPtr NativeFieldInfoPtr_AnyAttributeAttributes;

		// Token: 0x04001E15 RID: 7701
		private static readonly IntPtr NativeFieldInfoPtr_DocumentationAttributes;

		// Token: 0x04001E16 RID: 7702
		private static readonly IntPtr NativeFieldInfoPtr_AppinfoAttributes;

		// Token: 0x04001E17 RID: 7703
		private static readonly IntPtr NativeFieldInfoPtr_RedefineAttributes;

		// Token: 0x04001E18 RID: 7704
		private static readonly IntPtr NativeFieldInfoPtr_AnnotationAttributes;

		// Token: 0x04001E19 RID: 7705
		private static readonly IntPtr NativeFieldInfoPtr_SchemaEntries;

		// Token: 0x04001E1A RID: 7706
		private static readonly IntPtr NativeFieldInfoPtr_DerivationMethodValues;

		// Token: 0x04001E1B RID: 7707
		private static readonly IntPtr NativeFieldInfoPtr_DerivationMethodStrings;

		// Token: 0x04001E1C RID: 7708
		private static readonly IntPtr NativeFieldInfoPtr_FormStringValues;

		// Token: 0x04001E1D RID: 7709
		private static readonly IntPtr NativeFieldInfoPtr_UseStringValues;

		// Token: 0x04001E1E RID: 7710
		private static readonly IntPtr NativeFieldInfoPtr_ProcessContentsStringValues;

		// Token: 0x04001E1F RID: 7711
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x04001E20 RID: 7712
		private static readonly IntPtr NativeFieldInfoPtr_positionInfo;

		// Token: 0x04001E21 RID: 7713
		private static readonly IntPtr NativeFieldInfoPtr_currentEntry;

		// Token: 0x04001E22 RID: 7714
		private static readonly IntPtr NativeFieldInfoPtr_nextEntry;

		// Token: 0x04001E23 RID: 7715
		private static readonly IntPtr NativeFieldInfoPtr_hasChild;

		// Token: 0x04001E24 RID: 7716
		private static readonly IntPtr NativeFieldInfoPtr_stateHistory;

		// Token: 0x04001E25 RID: 7717
		private static readonly IntPtr NativeFieldInfoPtr_containerStack;

		// Token: 0x04001E26 RID: 7718
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04001E27 RID: 7719
		private static readonly IntPtr NativeFieldInfoPtr_schemaNames;

		// Token: 0x04001E28 RID: 7720
		private static readonly IntPtr NativeFieldInfoPtr_namespaceManager;

		// Token: 0x04001E29 RID: 7721
		private static readonly IntPtr NativeFieldInfoPtr_canIncludeImport;

		// Token: 0x04001E2A RID: 7722
		private static readonly IntPtr NativeFieldInfoPtr_schema;

		// Token: 0x04001E2B RID: 7723
		private static readonly IntPtr NativeFieldInfoPtr_xso;

		// Token: 0x04001E2C RID: 7724
		private static readonly IntPtr NativeFieldInfoPtr_element;

		// Token: 0x04001E2D RID: 7725
		private static readonly IntPtr NativeFieldInfoPtr_anyElement;

		// Token: 0x04001E2E RID: 7726
		private static readonly IntPtr NativeFieldInfoPtr_attribute;

		// Token: 0x04001E2F RID: 7727
		private static readonly IntPtr NativeFieldInfoPtr_anyAttribute;

		// Token: 0x04001E30 RID: 7728
		private static readonly IntPtr NativeFieldInfoPtr_complexType;

		// Token: 0x04001E31 RID: 7729
		private static readonly IntPtr NativeFieldInfoPtr_simpleType;

		// Token: 0x04001E32 RID: 7730
		private static readonly IntPtr NativeFieldInfoPtr_complexContent;

		// Token: 0x04001E33 RID: 7731
		private static readonly IntPtr NativeFieldInfoPtr_complexContentExtension;

		// Token: 0x04001E34 RID: 7732
		private static readonly IntPtr NativeFieldInfoPtr_complexContentRestriction;

		// Token: 0x04001E35 RID: 7733
		private static readonly IntPtr NativeFieldInfoPtr_simpleContent;

		// Token: 0x04001E36 RID: 7734
		private static readonly IntPtr NativeFieldInfoPtr_simpleContentExtension;

		// Token: 0x04001E37 RID: 7735
		private static readonly IntPtr NativeFieldInfoPtr_simpleContentRestriction;

		// Token: 0x04001E38 RID: 7736
		private static readonly IntPtr NativeFieldInfoPtr_simpleTypeUnion;

		// Token: 0x04001E39 RID: 7737
		private static readonly IntPtr NativeFieldInfoPtr_simpleTypeList;

		// Token: 0x04001E3A RID: 7738
		private static readonly IntPtr NativeFieldInfoPtr_simpleTypeRestriction;

		// Token: 0x04001E3B RID: 7739
		private static readonly IntPtr NativeFieldInfoPtr_group;

		// Token: 0x04001E3C RID: 7740
		private static readonly IntPtr NativeFieldInfoPtr_groupRef;

		// Token: 0x04001E3D RID: 7741
		private static readonly IntPtr NativeFieldInfoPtr_all;

		// Token: 0x04001E3E RID: 7742
		private static readonly IntPtr NativeFieldInfoPtr_choice;

		// Token: 0x04001E3F RID: 7743
		private static readonly IntPtr NativeFieldInfoPtr_sequence;

		// Token: 0x04001E40 RID: 7744
		private static readonly IntPtr NativeFieldInfoPtr_particle;

		// Token: 0x04001E41 RID: 7745
		private static readonly IntPtr NativeFieldInfoPtr_attributeGroup;

		// Token: 0x04001E42 RID: 7746
		private static readonly IntPtr NativeFieldInfoPtr_attributeGroupRef;

		// Token: 0x04001E43 RID: 7747
		private static readonly IntPtr NativeFieldInfoPtr_notation;

		// Token: 0x04001E44 RID: 7748
		private static readonly IntPtr NativeFieldInfoPtr_identityConstraint;

		// Token: 0x04001E45 RID: 7749
		private static readonly IntPtr NativeFieldInfoPtr_xpath;

		// Token: 0x04001E46 RID: 7750
		private static readonly IntPtr NativeFieldInfoPtr_include;

		// Token: 0x04001E47 RID: 7751
		private static readonly IntPtr NativeFieldInfoPtr_import;

		// Token: 0x04001E48 RID: 7752
		private static readonly IntPtr NativeFieldInfoPtr_annotation;

		// Token: 0x04001E49 RID: 7753
		private static readonly IntPtr NativeFieldInfoPtr_appInfo;

		// Token: 0x04001E4A RID: 7754
		private static readonly IntPtr NativeFieldInfoPtr_documentation;

		// Token: 0x04001E4B RID: 7755
		private static readonly IntPtr NativeFieldInfoPtr_facet;

		// Token: 0x04001E4C RID: 7756
		private static readonly IntPtr NativeFieldInfoPtr_markup;

		// Token: 0x04001E4D RID: 7757
		private static readonly IntPtr NativeFieldInfoPtr_redefine;

		// Token: 0x04001E4E RID: 7758
		private static readonly IntPtr NativeFieldInfoPtr_validationEventHandler;

		// Token: 0x04001E4F RID: 7759
		private static readonly IntPtr NativeFieldInfoPtr_unhandledAttributes;

		// Token: 0x04001E50 RID: 7760
		private static readonly IntPtr NativeFieldInfoPtr_namespaces;

		// Token: 0x04001E51 RID: 7761
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_XmlSchema_XmlNameTable_SchemaNames_ValidationEventHandler_0;

		// Token: 0x04001E52 RID: 7762
		private static readonly IntPtr NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0;

		// Token: 0x04001E53 RID: 7763
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0;

		// Token: 0x04001E54 RID: 7764
		private static readonly IntPtr NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0;

		// Token: 0x04001E55 RID: 7765
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0;

		// Token: 0x04001E56 RID: 7766
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0;

		// Token: 0x04001E57 RID: 7767
		private static readonly IntPtr NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0;

		// Token: 0x04001E58 RID: 7768
		private static readonly IntPtr NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0;

		// Token: 0x04001E59 RID: 7769
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_0;

		// Token: 0x04001E5A RID: 7770
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_Void_0;

		// Token: 0x04001E5B RID: 7771
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentElement_Private_get_Token_0;

		// Token: 0x04001E5C RID: 7772
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentElement_Private_get_Token_0;

		// Token: 0x04001E5D RID: 7773
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentContainer_Private_get_XmlSchemaObject_0;

		// Token: 0x04001E5E RID: 7774
		private static readonly IntPtr NativeMethodInfoPtr_GetContainer_Private_XmlSchemaObject_State_0;

		// Token: 0x04001E5F RID: 7775
		private static readonly IntPtr NativeMethodInfoPtr_SetContainer_Private_Void_State_Object_0;

		// Token: 0x04001E60 RID: 7776
		private static readonly IntPtr NativeMethodInfoPtr_BuildAnnotated_Id_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E61 RID: 7777
		private static readonly IntPtr NativeMethodInfoPtr_BuildSchema_AttributeFormDefault_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E62 RID: 7778
		private static readonly IntPtr NativeMethodInfoPtr_BuildSchema_ElementFormDefault_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E63 RID: 7779
		private static readonly IntPtr NativeMethodInfoPtr_BuildSchema_TargetNamespace_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E64 RID: 7780
		private static readonly IntPtr NativeMethodInfoPtr_BuildSchema_Version_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E65 RID: 7781
		private static readonly IntPtr NativeMethodInfoPtr_BuildSchema_FinalDefault_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E66 RID: 7782
		private static readonly IntPtr NativeMethodInfoPtr_BuildSchema_BlockDefault_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E67 RID: 7783
		private static readonly IntPtr NativeMethodInfoPtr_InitSchema_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E68 RID: 7784
		private static readonly IntPtr NativeMethodInfoPtr_InitInclude_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E69 RID: 7785
		private static readonly IntPtr NativeMethodInfoPtr_BuildInclude_SchemaLocation_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E6A RID: 7786
		private static readonly IntPtr NativeMethodInfoPtr_InitImport_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E6B RID: 7787
		private static readonly IntPtr NativeMethodInfoPtr_BuildImport_Namespace_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E6C RID: 7788
		private static readonly IntPtr NativeMethodInfoPtr_BuildImport_SchemaLocation_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E6D RID: 7789
		private static readonly IntPtr NativeMethodInfoPtr_InitRedefine_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E6E RID: 7790
		private static readonly IntPtr NativeMethodInfoPtr_BuildRedefine_SchemaLocation_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E6F RID: 7791
		private static readonly IntPtr NativeMethodInfoPtr_EndRedefine_Private_Static_Void_XsdBuilder_0;

		// Token: 0x04001E70 RID: 7792
		private static readonly IntPtr NativeMethodInfoPtr_InitAttribute_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E71 RID: 7793
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttribute_Default_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E72 RID: 7794
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttribute_Fixed_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E73 RID: 7795
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttribute_Form_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E74 RID: 7796
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttribute_Use_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E75 RID: 7797
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttribute_Ref_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E76 RID: 7798
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttribute_Name_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E77 RID: 7799
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttribute_Type_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E78 RID: 7800
		private static readonly IntPtr NativeMethodInfoPtr_InitElement_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E79 RID: 7801
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Abstract_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E7A RID: 7802
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Block_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E7B RID: 7803
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Default_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E7C RID: 7804
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Form_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E7D RID: 7805
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_SubstitutionGroup_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E7E RID: 7806
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Final_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E7F RID: 7807
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Fixed_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E80 RID: 7808
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_MaxOccurs_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E81 RID: 7809
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_MinOccurs_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E82 RID: 7810
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Name_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E83 RID: 7811
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Nillable_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E84 RID: 7812
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Ref_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E85 RID: 7813
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Type_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E86 RID: 7814
		private static readonly IntPtr NativeMethodInfoPtr_InitSimpleType_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E87 RID: 7815
		private static readonly IntPtr NativeMethodInfoPtr_BuildSimpleType_Name_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E88 RID: 7816
		private static readonly IntPtr NativeMethodInfoPtr_BuildSimpleType_Final_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E89 RID: 7817
		private static readonly IntPtr NativeMethodInfoPtr_InitSimpleTypeUnion_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E8A RID: 7818
		private static readonly IntPtr NativeMethodInfoPtr_BuildSimpleTypeUnion_MemberTypes_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E8B RID: 7819
		private static readonly IntPtr NativeMethodInfoPtr_InitSimpleTypeList_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E8C RID: 7820
		private static readonly IntPtr NativeMethodInfoPtr_BuildSimpleTypeList_ItemType_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E8D RID: 7821
		private static readonly IntPtr NativeMethodInfoPtr_InitSimpleTypeRestriction_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E8E RID: 7822
		private static readonly IntPtr NativeMethodInfoPtr_BuildSimpleTypeRestriction_Base_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E8F RID: 7823
		private static readonly IntPtr NativeMethodInfoPtr_InitComplexType_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E90 RID: 7824
		private static readonly IntPtr NativeMethodInfoPtr_BuildComplexType_Abstract_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E91 RID: 7825
		private static readonly IntPtr NativeMethodInfoPtr_BuildComplexType_Block_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E92 RID: 7826
		private static readonly IntPtr NativeMethodInfoPtr_BuildComplexType_Final_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E93 RID: 7827
		private static readonly IntPtr NativeMethodInfoPtr_BuildComplexType_Mixed_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E94 RID: 7828
		private static readonly IntPtr NativeMethodInfoPtr_BuildComplexType_Name_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E95 RID: 7829
		private static readonly IntPtr NativeMethodInfoPtr_InitComplexContent_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E96 RID: 7830
		private static readonly IntPtr NativeMethodInfoPtr_BuildComplexContent_Mixed_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E97 RID: 7831
		private static readonly IntPtr NativeMethodInfoPtr_InitComplexContentExtension_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E98 RID: 7832
		private static readonly IntPtr NativeMethodInfoPtr_BuildComplexContentExtension_Base_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E99 RID: 7833
		private static readonly IntPtr NativeMethodInfoPtr_InitComplexContentRestriction_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E9A RID: 7834
		private static readonly IntPtr NativeMethodInfoPtr_BuildComplexContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E9B RID: 7835
		private static readonly IntPtr NativeMethodInfoPtr_InitSimpleContent_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E9C RID: 7836
		private static readonly IntPtr NativeMethodInfoPtr_InitSimpleContentExtension_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E9D RID: 7837
		private static readonly IntPtr NativeMethodInfoPtr_BuildSimpleContentExtension_Base_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E9E RID: 7838
		private static readonly IntPtr NativeMethodInfoPtr_InitSimpleContentRestriction_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001E9F RID: 7839
		private static readonly IntPtr NativeMethodInfoPtr_BuildSimpleContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EA0 RID: 7840
		private static readonly IntPtr NativeMethodInfoPtr_InitAttributeGroup_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EA1 RID: 7841
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttributeGroup_Name_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EA2 RID: 7842
		private static readonly IntPtr NativeMethodInfoPtr_InitAttributeGroupRef_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttributeGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EA4 RID: 7844
		private static readonly IntPtr NativeMethodInfoPtr_InitAnyAttribute_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EA5 RID: 7845
		private static readonly IntPtr NativeMethodInfoPtr_BuildAnyAttribute_Namespace_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EA6 RID: 7846
		private static readonly IntPtr NativeMethodInfoPtr_BuildAnyAttribute_ProcessContents_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EA7 RID: 7847
		private static readonly IntPtr NativeMethodInfoPtr_InitGroup_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EA8 RID: 7848
		private static readonly IntPtr NativeMethodInfoPtr_BuildGroup_Name_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EA9 RID: 7849
		private static readonly IntPtr NativeMethodInfoPtr_InitGroupRef_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EAA RID: 7850
		private static readonly IntPtr NativeMethodInfoPtr_BuildParticle_MaxOccurs_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EAB RID: 7851
		private static readonly IntPtr NativeMethodInfoPtr_BuildParticle_MinOccurs_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EAC RID: 7852
		private static readonly IntPtr NativeMethodInfoPtr_BuildGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EAD RID: 7853
		private static readonly IntPtr NativeMethodInfoPtr_InitAll_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EAE RID: 7854
		private static readonly IntPtr NativeMethodInfoPtr_InitChoice_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EAF RID: 7855
		private static readonly IntPtr NativeMethodInfoPtr_InitSequence_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EB0 RID: 7856
		private static readonly IntPtr NativeMethodInfoPtr_InitAny_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EB1 RID: 7857
		private static readonly IntPtr NativeMethodInfoPtr_BuildAny_Namespace_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EB2 RID: 7858
		private static readonly IntPtr NativeMethodInfoPtr_BuildAny_ProcessContents_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EB3 RID: 7859
		private static readonly IntPtr NativeMethodInfoPtr_InitNotation_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EB4 RID: 7860
		private static readonly IntPtr NativeMethodInfoPtr_BuildNotation_Name_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EB5 RID: 7861
		private static readonly IntPtr NativeMethodInfoPtr_BuildNotation_Public_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EB6 RID: 7862
		private static readonly IntPtr NativeMethodInfoPtr_BuildNotation_System_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EB7 RID: 7863
		private static readonly IntPtr NativeMethodInfoPtr_InitFacet_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EB8 RID: 7864
		private static readonly IntPtr NativeMethodInfoPtr_BuildFacet_Fixed_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EB9 RID: 7865
		private static readonly IntPtr NativeMethodInfoPtr_BuildFacet_Value_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EBA RID: 7866
		private static readonly IntPtr NativeMethodInfoPtr_InitIdentityConstraint_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EBB RID: 7867
		private static readonly IntPtr NativeMethodInfoPtr_BuildIdentityConstraint_Name_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EBC RID: 7868
		private static readonly IntPtr NativeMethodInfoPtr_BuildIdentityConstraint_Refer_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EBD RID: 7869
		private static readonly IntPtr NativeMethodInfoPtr_InitSelector_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EBE RID: 7870
		private static readonly IntPtr NativeMethodInfoPtr_BuildSelector_XPath_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EBF RID: 7871
		private static readonly IntPtr NativeMethodInfoPtr_InitField_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EC0 RID: 7872
		private static readonly IntPtr NativeMethodInfoPtr_BuildField_XPath_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EC1 RID: 7873
		private static readonly IntPtr NativeMethodInfoPtr_InitAnnotation_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EC2 RID: 7874
		private static readonly IntPtr NativeMethodInfoPtr_InitAppinfo_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EC3 RID: 7875
		private static readonly IntPtr NativeMethodInfoPtr_BuildAppinfo_Source_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EC4 RID: 7876
		private static readonly IntPtr NativeMethodInfoPtr_EndAppinfo_Private_Static_Void_XsdBuilder_0;

		// Token: 0x04001EC5 RID: 7877
		private static readonly IntPtr NativeMethodInfoPtr_InitDocumentation_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EC6 RID: 7878
		private static readonly IntPtr NativeMethodInfoPtr_BuildDocumentation_Source_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EC7 RID: 7879
		private static readonly IntPtr NativeMethodInfoPtr_BuildDocumentation_XmlLang_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04001EC8 RID: 7880
		private static readonly IntPtr NativeMethodInfoPtr_EndDocumentation_Private_Static_Void_XsdBuilder_0;

		// Token: 0x04001EC9 RID: 7881
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Private_Void_XmlSchemaObject_0;

		// Token: 0x04001ECA RID: 7882
		private static readonly IntPtr NativeMethodInfoPtr_AddParticle_Private_Void_XmlSchemaParticle_0;

		// Token: 0x04001ECB RID: 7883
		private static readonly IntPtr NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0;

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0;

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeMethodInfoPtr_SetMinOccurs_Private_Void_XmlSchemaParticle_String_0;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeMethodInfoPtr_SetMaxOccurs_Private_Void_XmlSchemaParticle_String_0;

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeMethodInfoPtr_ParseBoolean_Private_Boolean_String_String_0;

		// Token: 0x04001ED0 RID: 7888
		private static readonly IntPtr NativeMethodInfoPtr_ParseEnum_Private_Int32_String_String_Il2CppStringArray_0;

		// Token: 0x04001ED1 RID: 7889
		private static readonly IntPtr NativeMethodInfoPtr_ParseQName_Private_XmlQualifiedName_String_String_0;

		// Token: 0x04001ED2 RID: 7890
		private static readonly IntPtr NativeMethodInfoPtr_ParseBlockFinalEnum_Private_Int32_String_String_0;

		// Token: 0x04001ED3 RID: 7891
		private static readonly IntPtr NativeMethodInfoPtr_ParseUriReference_Private_Static_String_String_0;

		// Token: 0x04001ED4 RID: 7892
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_String_String_0;

		// Token: 0x04001ED5 RID: 7893
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0;

		// Token: 0x04001ED6 RID: 7894
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0;

		// Token: 0x04001ED7 RID: 7895
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0;

		// Token: 0x04001ED8 RID: 7896
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_0;

		// Token: 0x04001ED9 RID: 7897
		private static readonly IntPtr NativeMethodInfoPtr_RecordPosition_Private_Void_0;

		// Token: 0x0200024C RID: 588
		[OriginalName("System.Xml.dll", "", "State")]
		public enum State
		{
			// Token: 0x040023C8 RID: 9160
			Root,
			// Token: 0x040023C9 RID: 9161
			Schema,
			// Token: 0x040023CA RID: 9162
			Annotation,
			// Token: 0x040023CB RID: 9163
			Include,
			// Token: 0x040023CC RID: 9164
			Import,
			// Token: 0x040023CD RID: 9165
			Element,
			// Token: 0x040023CE RID: 9166
			Attribute,
			// Token: 0x040023CF RID: 9167
			AttributeGroup,
			// Token: 0x040023D0 RID: 9168
			AttributeGroupRef,
			// Token: 0x040023D1 RID: 9169
			AnyAttribute,
			// Token: 0x040023D2 RID: 9170
			Group,
			// Token: 0x040023D3 RID: 9171
			GroupRef,
			// Token: 0x040023D4 RID: 9172
			All,
			// Token: 0x040023D5 RID: 9173
			Choice,
			// Token: 0x040023D6 RID: 9174
			Sequence,
			// Token: 0x040023D7 RID: 9175
			Any,
			// Token: 0x040023D8 RID: 9176
			Notation,
			// Token: 0x040023D9 RID: 9177
			SimpleType,
			// Token: 0x040023DA RID: 9178
			ComplexType,
			// Token: 0x040023DB RID: 9179
			ComplexContent,
			// Token: 0x040023DC RID: 9180
			ComplexContentRestriction,
			// Token: 0x040023DD RID: 9181
			ComplexContentExtension,
			// Token: 0x040023DE RID: 9182
			SimpleContent,
			// Token: 0x040023DF RID: 9183
			SimpleContentExtension,
			// Token: 0x040023E0 RID: 9184
			SimpleContentRestriction,
			// Token: 0x040023E1 RID: 9185
			SimpleTypeUnion,
			// Token: 0x040023E2 RID: 9186
			SimpleTypeList,
			// Token: 0x040023E3 RID: 9187
			SimpleTypeRestriction,
			// Token: 0x040023E4 RID: 9188
			Unique,
			// Token: 0x040023E5 RID: 9189
			Key,
			// Token: 0x040023E6 RID: 9190
			KeyRef,
			// Token: 0x040023E7 RID: 9191
			Selector,
			// Token: 0x040023E8 RID: 9192
			Field,
			// Token: 0x040023E9 RID: 9193
			MinExclusive,
			// Token: 0x040023EA RID: 9194
			MinInclusive,
			// Token: 0x040023EB RID: 9195
			MaxExclusive,
			// Token: 0x040023EC RID: 9196
			MaxInclusive,
			// Token: 0x040023ED RID: 9197
			TotalDigits,
			// Token: 0x040023EE RID: 9198
			FractionDigits,
			// Token: 0x040023EF RID: 9199
			Length,
			// Token: 0x040023F0 RID: 9200
			MinLength,
			// Token: 0x040023F1 RID: 9201
			MaxLength,
			// Token: 0x040023F2 RID: 9202
			Enumeration,
			// Token: 0x040023F3 RID: 9203
			Pattern,
			// Token: 0x040023F4 RID: 9204
			WhiteSpace,
			// Token: 0x040023F5 RID: 9205
			AppInfo,
			// Token: 0x040023F6 RID: 9206
			Documentation,
			// Token: 0x040023F7 RID: 9207
			Redefine
		}

		// Token: 0x0200024D RID: 589
		public sealed class XsdBuildFunction : MulticastDelegate
		{
			// Token: 0x06002D73 RID: 11635 RVA: 0x000C9874 File Offset: 0x000C7A74
			// Note: this type is marked as 'beforefieldinit'.
			static XsdBuildFunction()
			{
				Il2CppClassPointerStore<XsdBuilder.XsdBuildFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "XsdBuildFunction");
				XsdBuilder.XsdBuildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdBuildFunction>.NativeClassPtr, 100669146);
				XsdBuilder.XsdBuildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdBuildFunction>.NativeClassPtr, 100669147);
				XsdBuilder.XsdBuildFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XsdBuilder_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdBuildFunction>.NativeClassPtr, 100669148);
				XsdBuilder.XsdBuildFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdBuildFunction>.NativeClassPtr, 100669149);
			}

			// Token: 0x06002D74 RID: 11636 RVA: 0x000C98E8 File Offset: 0x000C7AE8
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XsdBuildFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdBuilder.XsdBuildFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdBuildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D75 RID: 11637 RVA: 0x000C9944 File Offset: 0x000C7B44
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 1337, RefRangeEnd = 1421, XrefRangeStart = 1337, XrefRangeEnd = 1421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(XsdBuilder builder, string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdBuildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D76 RID: 11638 RVA: 0x000C9998 File Offset: 0x000C7B98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(XsdBuilder builder, string value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdBuildFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XsdBuilder_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002D77 RID: 11639 RVA: 0x000C9A20 File Offset: 0x000C7C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdBuildFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D78 RID: 11640 RVA: 0x00013AF5 File Offset: 0x00011CF5
			public XsdBuildFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002D79 RID: 11641 RVA: 0x00013AFE File Offset: 0x00011CFE
			public static implicit operator XsdBuilder.XsdBuildFunction(Action<XsdBuilder, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<XsdBuilder.XsdBuildFunction>(A_0);
			}

			// Token: 0x06002D7A RID: 11642 RVA: 0x00013B06 File Offset: 0x00011D06
			public static XsdBuilder.XsdBuildFunction operator +(XsdBuilder.XsdBuildFunction A_0, XsdBuilder.XsdBuildFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XsdBuilder.XsdBuildFunction>();
			}

			// Token: 0x06002D7B RID: 11643 RVA: 0x00013B14 File Offset: 0x00011D14
			public static XsdBuilder.XsdBuildFunction operator -(XsdBuilder.XsdBuildFunction A_0, XsdBuilder.XsdBuildFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XsdBuilder.XsdBuildFunction>();
				}
				return delegate2;
			}

			// Token: 0x040023F8 RID: 9208
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040023F9 RID: 9209
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0;

			// Token: 0x040023FA RID: 9210
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XsdBuilder_String_AsyncCallback_Object_0;

			// Token: 0x040023FB RID: 9211
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200024E RID: 590
		public sealed class XsdInitFunction : MulticastDelegate
		{
			// Token: 0x06002D7C RID: 11644 RVA: 0x000C9A64 File Offset: 0x000C7C64
			// Note: this type is marked as 'beforefieldinit'.
			static XsdInitFunction()
			{
				Il2CppClassPointerStore<XsdBuilder.XsdInitFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "XsdInitFunction");
				XsdBuilder.XsdInitFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdInitFunction>.NativeClassPtr, 100669150);
				XsdBuilder.XsdInitFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdInitFunction>.NativeClassPtr, 100669151);
				XsdBuilder.XsdInitFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XsdBuilder_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdInitFunction>.NativeClassPtr, 100669152);
				XsdBuilder.XsdInitFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdInitFunction>.NativeClassPtr, 100669153);
			}

			// Token: 0x06002D7D RID: 11645 RVA: 0x000C9AD8 File Offset: 0x000C7CD8
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XsdInitFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdBuilder.XsdInitFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdInitFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D7E RID: 11646 RVA: 0x000C9B34 File Offset: 0x000C7D34
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 1337, RefRangeEnd = 1421, XrefRangeStart = 1337, XrefRangeEnd = 1421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(XsdBuilder builder, string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdInitFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D7F RID: 11647 RVA: 0x000C9B88 File Offset: 0x000C7D88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(XsdBuilder builder, string value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdInitFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XsdBuilder_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002D80 RID: 11648 RVA: 0x000C9C10 File Offset: 0x000C7E10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdInitFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D81 RID: 11649 RVA: 0x00013B25 File Offset: 0x00011D25
			public XsdInitFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002D82 RID: 11650 RVA: 0x00013B2E File Offset: 0x00011D2E
			public static implicit operator XsdBuilder.XsdInitFunction(Action<XsdBuilder, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<XsdBuilder.XsdInitFunction>(A_0);
			}

			// Token: 0x06002D83 RID: 11651 RVA: 0x00013B36 File Offset: 0x00011D36
			public static XsdBuilder.XsdInitFunction operator +(XsdBuilder.XsdInitFunction A_0, XsdBuilder.XsdInitFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XsdBuilder.XsdInitFunction>();
			}

			// Token: 0x06002D84 RID: 11652 RVA: 0x00013B44 File Offset: 0x00011D44
			public static XsdBuilder.XsdInitFunction operator -(XsdBuilder.XsdInitFunction A_0, XsdBuilder.XsdInitFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XsdBuilder.XsdInitFunction>();
				}
				return delegate2;
			}

			// Token: 0x040023FC RID: 9212
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040023FD RID: 9213
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0;

			// Token: 0x040023FE RID: 9214
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XsdBuilder_String_AsyncCallback_Object_0;

			// Token: 0x040023FF RID: 9215
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200024F RID: 591
		public sealed class XsdEndChildFunction : MulticastDelegate
		{
			// Token: 0x06002D85 RID: 11653 RVA: 0x000C9C54 File Offset: 0x000C7E54
			// Note: this type is marked as 'beforefieldinit'.
			static XsdEndChildFunction()
			{
				Il2CppClassPointerStore<XsdBuilder.XsdEndChildFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "XsdEndChildFunction");
				XsdBuilder.XsdEndChildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdEndChildFunction>.NativeClassPtr, 100669154);
				XsdBuilder.XsdEndChildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdEndChildFunction>.NativeClassPtr, 100669155);
				XsdBuilder.XsdEndChildFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XsdBuilder_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdEndChildFunction>.NativeClassPtr, 100669156);
				XsdBuilder.XsdEndChildFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdEndChildFunction>.NativeClassPtr, 100669157);
			}

			// Token: 0x06002D86 RID: 11654 RVA: 0x000C9CC8 File Offset: 0x000C7EC8
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XsdEndChildFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdBuilder.XsdEndChildFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdEndChildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D87 RID: 11655 RVA: 0x000C9D24 File Offset: 0x000C7F24
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1006, RefRangeEnd = 1022, XrefRangeStart = 1006, XrefRangeEnd = 1022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(XsdBuilder builder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdEndChildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D88 RID: 11656 RVA: 0x000C9D68 File Offset: 0x000C7F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(XsdBuilder builder, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdEndChildFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XsdBuilder_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002D89 RID: 11657 RVA: 0x000C9DDC File Offset: 0x000C7FDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdEndChildFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D8A RID: 11658 RVA: 0x00013B55 File Offset: 0x00011D55
			public XsdEndChildFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002D8B RID: 11659 RVA: 0x00013B5E File Offset: 0x00011D5E
			public static implicit operator XsdBuilder.XsdEndChildFunction(Action<XsdBuilder> A_0)
			{
				return DelegateSupport.ConvertDelegate<XsdBuilder.XsdEndChildFunction>(A_0);
			}

			// Token: 0x06002D8C RID: 11660 RVA: 0x00013B66 File Offset: 0x00011D66
			public static XsdBuilder.XsdEndChildFunction operator +(XsdBuilder.XsdEndChildFunction A_0, XsdBuilder.XsdEndChildFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XsdBuilder.XsdEndChildFunction>();
			}

			// Token: 0x06002D8D RID: 11661 RVA: 0x00013B74 File Offset: 0x00011D74
			public static XsdBuilder.XsdEndChildFunction operator -(XsdBuilder.XsdEndChildFunction A_0, XsdBuilder.XsdEndChildFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XsdBuilder.XsdEndChildFunction>();
				}
				return delegate2;
			}

			// Token: 0x04002400 RID: 9216
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002401 RID: 9217
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_0;

			// Token: 0x04002402 RID: 9218
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XsdBuilder_AsyncCallback_Object_0;

			// Token: 0x04002403 RID: 9219
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000250 RID: 592
		public sealed class XsdAttributeEntry : Object
		{
			// Token: 0x06002D8E RID: 11662 RVA: 0x000C9E20 File Offset: 0x000C8020
			// Note: this type is marked as 'beforefieldinit'.
			static XsdAttributeEntry()
			{
				Il2CppClassPointerStore<XsdBuilder.XsdAttributeEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "XsdAttributeEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdBuilder.XsdAttributeEntry>.NativeClassPtr);
				XsdBuilder.XsdAttributeEntry.NativeFieldInfoPtr_Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdAttributeEntry>.NativeClassPtr, "Attribute");
				XsdBuilder.XsdAttributeEntry.NativeFieldInfoPtr_BuildFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdAttributeEntry>.NativeClassPtr, "BuildFunc");
				XsdBuilder.XsdAttributeEntry.NativeMethodInfoPtr__ctor_Public_Void_Token_XsdBuildFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdAttributeEntry>.NativeClassPtr, 100669158);
			}

			// Token: 0x06002D8F RID: 11663 RVA: 0x000C9E88 File Offset: 0x000C8088
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 106068, RefRangeEnd = 106070, XrefRangeStart = 106068, XrefRangeEnd = 106070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XsdAttributeEntry(SchemaNames.Token a, XsdBuilder.XsdBuildFunction build)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdBuilder.XsdAttributeEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(build);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdAttributeEntry.NativeMethodInfoPtr__ctor_Public_Void_Token_XsdBuildFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D90 RID: 11664 RVA: 0x00013B85 File Offset: 0x00011D85
			public XsdAttributeEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F76 RID: 3958
			// (get) Token: 0x06002D91 RID: 11665 RVA: 0x000C9EE4 File Offset: 0x000C80E4
			// (set) Token: 0x06002D92 RID: 11666 RVA: 0x00013B8E File Offset: 0x00011D8E
			public unsafe SchemaNames.Token Attribute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdAttributeEntry.NativeFieldInfoPtr_Attribute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdAttributeEntry.NativeFieldInfoPtr_Attribute)) = value;
				}
			}

			// Token: 0x17000F77 RID: 3959
			// (get) Token: 0x06002D93 RID: 11667 RVA: 0x000C9F0C File Offset: 0x000C810C
			// (set) Token: 0x06002D94 RID: 11668 RVA: 0x00013BA9 File Offset: 0x00011DA9
			public unsafe XsdBuilder.XsdBuildFunction BuildFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdAttributeEntry.NativeFieldInfoPtr_BuildFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XsdBuilder.XsdBuildFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdAttributeEntry.NativeFieldInfoPtr_BuildFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002404 RID: 9220
			private static readonly IntPtr NativeFieldInfoPtr_Attribute;

			// Token: 0x04002405 RID: 9221
			private static readonly IntPtr NativeFieldInfoPtr_BuildFunc;

			// Token: 0x04002406 RID: 9222
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Token_XsdBuildFunction_0;
		}

		// Token: 0x02000251 RID: 593
		public sealed class XsdEntry : Object
		{
			// Token: 0x06002D95 RID: 11669 RVA: 0x000C9F3C File Offset: 0x000C813C
			// Note: this type is marked as 'beforefieldinit'.
			static XsdEntry()
			{
				Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "XsdEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr);
				XsdBuilder.XsdEntry.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr, "Name");
				XsdBuilder.XsdEntry.NativeFieldInfoPtr_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr, "CurrentState");
				XsdBuilder.XsdEntry.NativeFieldInfoPtr_NextStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr, "NextStates");
				XsdBuilder.XsdEntry.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr, "Attributes");
				XsdBuilder.XsdEntry.NativeFieldInfoPtr_InitFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr, "InitFunc");
				XsdBuilder.XsdEntry.NativeFieldInfoPtr_EndChildFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr, "EndChildFunc");
				XsdBuilder.XsdEntry.NativeFieldInfoPtr_ParseContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr, "ParseContent");
				XsdBuilder.XsdEntry.NativeMethodInfoPtr__ctor_Public_Void_Token_State_Il2CppStructArray_1_State_Il2CppReferenceArray_1_XsdAttributeEntry_XsdInitFunction_XsdEndChildFunction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr, 100669159);
			}

			// Token: 0x06002D96 RID: 11670 RVA: 0x000CA008 File Offset: 0x000C8208
			[CallerCount(0)]
			public unsafe XsdEntry(SchemaNames.Token n, XsdBuilder.State state, Il2CppStructArray<XsdBuilder.State> nextStates, Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> attributes, XsdBuilder.XsdInitFunction init, XsdBuilder.XsdEndChildFunction end, bool parseContent)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nextStates);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(init);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(end);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseContent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdEntry.NativeMethodInfoPtr__ctor_Public_Void_Token_State_Il2CppStructArray_1_State_Il2CppReferenceArray_1_XsdAttributeEntry_XsdInitFunction_XsdEndChildFunction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D97 RID: 11671 RVA: 0x00013BC8 File Offset: 0x00011DC8
			public XsdEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F78 RID: 3960
			// (get) Token: 0x06002D98 RID: 11672 RVA: 0x000CA0B8 File Offset: 0x000C82B8
			// (set) Token: 0x06002D99 RID: 11673 RVA: 0x00013BD1 File Offset: 0x00011DD1
			public unsafe SchemaNames.Token Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_Name);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_Name)) = value;
				}
			}

			// Token: 0x17000F79 RID: 3961
			// (get) Token: 0x06002D9A RID: 11674 RVA: 0x000CA0E0 File Offset: 0x000C82E0
			// (set) Token: 0x06002D9B RID: 11675 RVA: 0x00013BEC File Offset: 0x00011DEC
			public unsafe XsdBuilder.State CurrentState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_CurrentState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_CurrentState)) = value;
				}
			}

			// Token: 0x17000F7A RID: 3962
			// (get) Token: 0x06002D9C RID: 11676 RVA: 0x000CA108 File Offset: 0x000C8308
			// (set) Token: 0x06002D9D RID: 11677 RVA: 0x00013C07 File Offset: 0x00011E07
			public unsafe Il2CppStructArray<XsdBuilder.State> NextStates
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_NextStates);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_NextStates), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F7B RID: 3963
			// (get) Token: 0x06002D9E RID: 11678 RVA: 0x000CA138 File Offset: 0x000C8338
			// (set) Token: 0x06002D9F RID: 11679 RVA: 0x00013C26 File Offset: 0x00011E26
			public unsafe Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> Attributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_Attributes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F7C RID: 3964
			// (get) Token: 0x06002DA0 RID: 11680 RVA: 0x000CA168 File Offset: 0x000C8368
			// (set) Token: 0x06002DA1 RID: 11681 RVA: 0x00013C45 File Offset: 0x00011E45
			public unsafe XsdBuilder.XsdInitFunction InitFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_InitFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XsdBuilder.XsdInitFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_InitFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F7D RID: 3965
			// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x000CA198 File Offset: 0x000C8398
			// (set) Token: 0x06002DA3 RID: 11683 RVA: 0x00013C64 File Offset: 0x00011E64
			public unsafe XsdBuilder.XsdEndChildFunction EndChildFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_EndChildFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XsdBuilder.XsdEndChildFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_EndChildFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F7E RID: 3966
			// (get) Token: 0x06002DA4 RID: 11684 RVA: 0x000CA1C8 File Offset: 0x000C83C8
			// (set) Token: 0x06002DA5 RID: 11685 RVA: 0x00013C83 File Offset: 0x00011E83
			public unsafe bool ParseContent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_ParseContent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_ParseContent)) = value;
				}
			}

			// Token: 0x04002407 RID: 9223
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04002408 RID: 9224
			private static readonly IntPtr NativeFieldInfoPtr_CurrentState;

			// Token: 0x04002409 RID: 9225
			private static readonly IntPtr NativeFieldInfoPtr_NextStates;

			// Token: 0x0400240A RID: 9226
			private static readonly IntPtr NativeFieldInfoPtr_Attributes;

			// Token: 0x0400240B RID: 9227
			private static readonly IntPtr NativeFieldInfoPtr_InitFunc;

			// Token: 0x0400240C RID: 9228
			private static readonly IntPtr NativeFieldInfoPtr_EndChildFunc;

			// Token: 0x0400240D RID: 9229
			private static readonly IntPtr NativeFieldInfoPtr_ParseContent;

			// Token: 0x0400240E RID: 9230
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Token_State_Il2CppStructArray_1_State_Il2CppReferenceArray_1_XsdAttributeEntry_XsdInitFunction_XsdEndChildFunction_Boolean_0;
		}

		// Token: 0x02000252 RID: 594
		public class BuilderNamespaceManager : XmlNamespaceManager
		{
			// Token: 0x06002DA6 RID: 11686 RVA: 0x000CA1F0 File Offset: 0x000C83F0
			// Note: this type is marked as 'beforefieldinit'.
			static BuilderNamespaceManager()
			{
				Il2CppClassPointerStore<XsdBuilder.BuilderNamespaceManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "BuilderNamespaceManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdBuilder.BuilderNamespaceManager>.NativeClassPtr);
				XsdBuilder.BuilderNamespaceManager.NativeFieldInfoPtr_nsMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.BuilderNamespaceManager>.NativeClassPtr, "nsMgr");
				XsdBuilder.BuilderNamespaceManager.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.BuilderNamespaceManager>.NativeClassPtr, "reader");
				XsdBuilder.BuilderNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_XmlNamespaceManager_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.BuilderNamespaceManager>.NativeClassPtr, 100669160);
				XsdBuilder.BuilderNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.BuilderNamespaceManager>.NativeClassPtr, 100669161);
			}

			// Token: 0x06002DA7 RID: 11687 RVA: 0x000CA26C File Offset: 0x000C846C
			[CallerCount(0)]
			public unsafe BuilderNamespaceManager(XmlNamespaceManager nsMgr, XmlReader reader)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdBuilder.BuilderNamespaceManager>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nsMgr);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.BuilderNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_XmlNamespaceManager_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002DA8 RID: 11688 RVA: 0x000CA2CC File Offset: 0x000C84CC
			[CallerCount(0)]
			public unsafe override string LookupNamespace(string prefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdBuilder.BuilderNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002DA9 RID: 11689 RVA: 0x00013C9E File Offset: 0x00011E9E
			public BuilderNamespaceManager(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F7F RID: 3967
			// (get) Token: 0x06002DAA RID: 11690 RVA: 0x000CA320 File Offset: 0x000C8520
			// (set) Token: 0x06002DAB RID: 11691 RVA: 0x00013CA7 File Offset: 0x00011EA7
			public unsafe XmlNamespaceManager nsMgr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.BuilderNamespaceManager.NativeFieldInfoPtr_nsMgr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.BuilderNamespaceManager.NativeFieldInfoPtr_nsMgr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F80 RID: 3968
			// (get) Token: 0x06002DAC RID: 11692 RVA: 0x000CA350 File Offset: 0x000C8550
			// (set) Token: 0x06002DAD RID: 11693 RVA: 0x00013CC6 File Offset: 0x00011EC6
			public unsafe XmlReader reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.BuilderNamespaceManager.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.BuilderNamespaceManager.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400240F RID: 9231
			private static readonly IntPtr NativeFieldInfoPtr_nsMgr;

			// Token: 0x04002410 RID: 9232
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x04002411 RID: 9233
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNamespaceManager_XmlReader_0;

			// Token: 0x04002412 RID: 9234
			private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;
		}
	}
}
