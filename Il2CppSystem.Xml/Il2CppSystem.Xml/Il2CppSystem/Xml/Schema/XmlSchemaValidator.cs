using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001D8 RID: 472
	public sealed class XmlSchemaValidator : Object
	{
		// Token: 0x06002531 RID: 9521 RVA: 0x000AB3A4 File Offset: 0x000A95A4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaValidator()
		{
			Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr);
			XmlSchemaValidator.NativeFieldInfoPtr_schemaSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "schemaSet");
			XmlSchemaValidator.NativeFieldInfoPtr_validationFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "validationFlags");
			XmlSchemaValidator.NativeFieldInfoPtr_startIDConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "startIDConstraint");
			XmlSchemaValidator.NativeFieldInfoPtr_isRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "isRoot");
			XmlSchemaValidator.NativeFieldInfoPtr_rootHasSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "rootHasSchema");
			XmlSchemaValidator.NativeFieldInfoPtr_attrValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "attrValid");
			XmlSchemaValidator.NativeFieldInfoPtr_checkEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "checkEntity");
			XmlSchemaValidator.NativeFieldInfoPtr_compiledSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "compiledSchemaInfo");
			XmlSchemaValidator.NativeFieldInfoPtr_dtdSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "dtdSchemaInfo");
			XmlSchemaValidator.NativeFieldInfoPtr_validatedNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "validatedNamespaces");
			XmlSchemaValidator.NativeFieldInfoPtr_validationStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "validationStack");
			XmlSchemaValidator.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "context");
			XmlSchemaValidator.NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "currentState");
			XmlSchemaValidator.NativeFieldInfoPtr_attPresence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "attPresence");
			XmlSchemaValidator.NativeFieldInfoPtr_wildID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "wildID");
			XmlSchemaValidator.NativeFieldInfoPtr_IDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "IDs");
			XmlSchemaValidator.NativeFieldInfoPtr_idRefListHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "idRefListHead");
			XmlSchemaValidator.NativeFieldInfoPtr_contextQName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "contextQName");
			XmlSchemaValidator.NativeFieldInfoPtr_NsXs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "NsXs");
			XmlSchemaValidator.NativeFieldInfoPtr_NsXsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "NsXsi");
			XmlSchemaValidator.NativeFieldInfoPtr_NsXmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "NsXmlNs");
			XmlSchemaValidator.NativeFieldInfoPtr_NsXml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "NsXml");
			XmlSchemaValidator.NativeFieldInfoPtr_partialValidationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "partialValidationType");
			XmlSchemaValidator.NativeFieldInfoPtr_textValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "textValue");
			XmlSchemaValidator.NativeFieldInfoPtr_eventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "eventHandler");
			XmlSchemaValidator.NativeFieldInfoPtr_validationEventSender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "validationEventSender");
			XmlSchemaValidator.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "nameTable");
			XmlSchemaValidator.NativeFieldInfoPtr_positionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "positionInfo");
			XmlSchemaValidator.NativeFieldInfoPtr_dummyPositionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "dummyPositionInfo");
			XmlSchemaValidator.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "xmlResolver");
			XmlSchemaValidator.NativeFieldInfoPtr_sourceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "sourceUri");
			XmlSchemaValidator.NativeFieldInfoPtr_sourceUriString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "sourceUriString");
			XmlSchemaValidator.NativeFieldInfoPtr_nsResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "nsResolver");
			XmlSchemaValidator.NativeFieldInfoPtr_processContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "processContents");
			XmlSchemaValidator.NativeFieldInfoPtr_xsiTypeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "xsiTypeString");
			XmlSchemaValidator.NativeFieldInfoPtr_xsiNilString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "xsiNilString");
			XmlSchemaValidator.NativeFieldInfoPtr_xsiSchemaLocationString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "xsiSchemaLocationString");
			XmlSchemaValidator.NativeFieldInfoPtr_xsiNoNamespaceSchemaLocationString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "xsiNoNamespaceSchemaLocationString");
			XmlSchemaValidator.NativeFieldInfoPtr_dtQName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "dtQName");
			XmlSchemaValidator.NativeFieldInfoPtr_dtCDATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "dtCDATA");
			XmlSchemaValidator.NativeFieldInfoPtr_dtStringArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "dtStringArray");
			XmlSchemaValidator.NativeFieldInfoPtr_EmptyParticleArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "EmptyParticleArray");
			XmlSchemaValidator.NativeFieldInfoPtr_EmptyAttributeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "EmptyAttributeArray");
			XmlSchemaValidator.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "xmlCharType");
			XmlSchemaValidator.NativeFieldInfoPtr_ValidStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "ValidStates");
			XmlSchemaValidator.NativeFieldInfoPtr_MethodNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "MethodNames");
			XmlSchemaValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlSchemaSet_IXmlNamespaceResolver_XmlSchemaValidationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668584);
			XmlSchemaValidator.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668585);
			XmlSchemaValidator.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668586);
			XmlSchemaValidator.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668587);
			XmlSchemaValidator.NativeMethodInfoPtr_set_LineInfoProvider_Public_set_Void_IXmlLineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668588);
			XmlSchemaValidator.NativeMethodInfoPtr_set_SourceUri_Public_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668589);
			XmlSchemaValidator.NativeMethodInfoPtr_set_ValidationEventSender_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668590);
			XmlSchemaValidator.NativeMethodInfoPtr_add_ValidationEventHandler_Public_add_Void_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668591);
			XmlSchemaValidator.NativeMethodInfoPtr_remove_ValidationEventHandler_Public_rem_Void_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668592);
			XmlSchemaValidator.NativeMethodInfoPtr_AddSchema_Public_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668593);
			XmlSchemaValidator.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668594);
			XmlSchemaValidator.NativeMethodInfoPtr_Initialize_Public_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668595);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateElement_Public_Void_String_String_XmlSchemaInfo_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668596);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateAttribute_Public_Object_String_String_XmlValueGetter_XmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668597);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateAttribute_Private_Object_String_String_XmlValueGetter_String_XmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668598);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateEndOfAttributes_Public_Void_XmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668599);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateText_Public_Void_XmlValueGetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668600);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateText_Private_Void_String_XmlValueGetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668601);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateWhitespace_Public_Void_XmlValueGetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668602);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateWhitespace_Private_Void_String_XmlValueGetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668603);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateEndElement_Public_Object_XmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668604);
			XmlSchemaValidator.NativeMethodInfoPtr_EndValidation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668605);
			XmlSchemaValidator.NativeMethodInfoPtr_GetUnspecifiedDefaultAttributes_Internal_Void_ArrayList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668606);
			XmlSchemaValidator.NativeMethodInfoPtr_get_SchemaSet_Internal_get_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668607);
			XmlSchemaValidator.NativeMethodInfoPtr_get_ValidationFlags_Internal_get_XmlSchemaValidationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668608);
			XmlSchemaValidator.NativeMethodInfoPtr_get_CurrentContentType_Internal_get_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668609);
			XmlSchemaValidator.NativeMethodInfoPtr_SetDtdSchemaInfo_Internal_Void_IDtdInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668610);
			XmlSchemaValidator.NativeMethodInfoPtr_get_StrictlyAssessed_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668611);
			XmlSchemaValidator.NativeMethodInfoPtr_get_HasSchema_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668612);
			XmlSchemaValidator.NativeMethodInfoPtr_GetConcatenatedValue_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668613);
			XmlSchemaValidator.NativeMethodInfoPtr_InternalValidateEndElement_Private_Object_XmlSchemaInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668614);
			XmlSchemaValidator.NativeMethodInfoPtr_ProcessSchemaLocations_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668615);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateElementContext_Private_Object_XmlQualifiedName_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668616);
			XmlSchemaValidator.NativeMethodInfoPtr_GetSubstitutionGroupHead_Private_XmlSchemaElement_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668617);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateAtomicValue_Private_Object_String_byref_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668618);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateAtomicValue_Private_Object_Object_byref_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668619);
			XmlSchemaValidator.NativeMethodInfoPtr_GetTypeName_Private_String_SchemaDeclBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668620);
			XmlSchemaValidator.NativeMethodInfoPtr_SaveTextValue_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668621);
			XmlSchemaValidator.NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668622);
			XmlSchemaValidator.NativeMethodInfoPtr_Pop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668623);
			XmlSchemaValidator.NativeMethodInfoPtr_FastGetElementDecl_Private_SchemaElementDecl_XmlQualifiedName_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668624);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckXsiTypeAndNil_Private_SchemaElementDecl_SchemaElementDecl_String_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668625);
			XmlSchemaValidator.NativeMethodInfoPtr_ThrowDeclNotFoundWarningOrError_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668626);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckElementProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668627);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateStartElementIdentityConstraints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668628);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckIsXmlAttribute_Private_SchemaAttDef_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668629);
			XmlSchemaValidator.NativeMethodInfoPtr_AddXmlNamespaceSchema_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668630);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckMixedValueConstraint_Internal_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668631);
			XmlSchemaValidator.NativeMethodInfoPtr_LoadSchema_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668632);
			XmlSchemaValidator.NativeMethodInfoPtr_RecompileSchemaSet_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668633);
			XmlSchemaValidator.NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668634);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckAttributeValue_Private_Object_Object_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668635);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckElementValue_Private_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668636);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckTokenizedTypes_Private_Void_XmlSchemaDatatype_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668637);
			XmlSchemaValidator.NativeMethodInfoPtr_FindId_Private_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668638);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668639);
			XmlSchemaValidator.NativeMethodInfoPtr_get_HasIdentityConstraints_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668640);
			XmlSchemaValidator.NativeMethodInfoPtr_get_ProcessIdentityConstraints_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668641);
			XmlSchemaValidator.NativeMethodInfoPtr_get_ReportValidationWarnings_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668642);
			XmlSchemaValidator.NativeMethodInfoPtr_get_ProcessSchemaHints_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668643);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckStateTransition_Private_Void_ValidatorState_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668644);
			XmlSchemaValidator.NativeMethodInfoPtr_ClearPSVI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668645);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckRequiredAttributes_Private_Void_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668646);
			XmlSchemaValidator.NativeMethodInfoPtr_GetSchemaElement_Private_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668647);
			XmlSchemaValidator.NativeMethodInfoPtr_GetDefaultAttributePrefix_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668648);
			XmlSchemaValidator.NativeMethodInfoPtr_AddIdentityConstraints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668649);
			XmlSchemaValidator.NativeMethodInfoPtr_ElementIdentityConstraints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668650);
			XmlSchemaValidator.NativeMethodInfoPtr_AttributeIdentityConstraints_Private_Void_String_String_Object_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668651);
			XmlSchemaValidator.NativeMethodInfoPtr_EndElementIdentityConstraints_Private_Void_Object_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668652);
			XmlSchemaValidator.NativeMethodInfoPtr_ElementValidationError_Internal_Static_Void_XmlQualifiedName_ValidationState_ValidationEventHandler_Object_String_Int32_Int32_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668653);
			XmlSchemaValidator.NativeMethodInfoPtr_CompleteValidationError_Internal_Static_Void_ValidationState_ValidationEventHandler_Object_String_Int32_Int32_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668654);
			XmlSchemaValidator.NativeMethodInfoPtr_PrintExpectedElements_Internal_Static_String_ArrayList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668655);
			XmlSchemaValidator.NativeMethodInfoPtr_PrintNames_Private_Static_String_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668656);
			XmlSchemaValidator.NativeMethodInfoPtr_PrintNamesWithNS_Private_Static_Void_ArrayList_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668657);
			XmlSchemaValidator.NativeMethodInfoPtr_EnumerateAny_Private_Static_Void_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668658);
			XmlSchemaValidator.NativeMethodInfoPtr_QNameString_Internal_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668659);
			XmlSchemaValidator.NativeMethodInfoPtr_BuildElementName_Internal_Static_String_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668660);
			XmlSchemaValidator.NativeMethodInfoPtr_BuildElementName_Internal_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668661);
			XmlSchemaValidator.NativeMethodInfoPtr_ProcessEntity_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668662);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668663);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668664);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668665);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668666);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_Exception_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668667);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668668);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaValidationException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668669);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668670);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668671);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaValidationException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668672);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Internal_Static_Void_ValidationEventHandler_Object_XmlSchemaValidationException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100668673);
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x000ABE74 File Offset: 0x000AA074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429450, RefRangeEnd = 429451, XrefRangeStart = 429415, XrefRangeEnd = 429450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaValidator(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemas);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceResolver);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validationFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlSchemaSet_IXmlNamespaceResolver_XmlSchemaValidationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x000ABEF4 File Offset: 0x000AA0F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429498, RefRangeEnd = 429499, XrefRangeStart = 429451, XrefRangeEnd = 429498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x000ABF28 File Offset: 0x000AA128
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 429500, RefRangeEnd = 429503, XrefRangeStart = 429499, XrefRangeEnd = 429500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D3A RID: 3386
		// (set) Token: 0x06002535 RID: 9525 RVA: 0x000ABF5C File Offset: 0x000AA15C
		public unsafe XmlResolver XmlResolver
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 429503, RefRangeEnd = 429504, XrefRangeStart = 429503, XrefRangeEnd = 429503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (set) Token: 0x06002536 RID: 9526 RVA: 0x000ABFA0 File Offset: 0x000AA1A0
		public unsafe IXmlLineInfo LineInfoProvider
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_set_LineInfoProvider_Public_set_Void_IXmlLineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (set) Token: 0x06002537 RID: 9527 RVA: 0x000ABFE4 File Offset: 0x000AA1E4
		public unsafe Uri SourceUri
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_set_SourceUri_Public_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (set) Token: 0x06002538 RID: 9528 RVA: 0x000AC028 File Offset: 0x000AA228
		public unsafe Object ValidationEventSender
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_set_ValidationEventSender_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x000AC06C File Offset: 0x000AA26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429504, XrefRangeEnd = 429507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ValidationEventHandler(ValidationEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_add_ValidationEventHandler_Public_add_Void_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x000AC0B0 File Offset: 0x000AA2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429507, XrefRangeEnd = 429510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ValidationEventHandler(ValidationEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_remove_ValidationEventHandler_Public_rem_Void_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x000AC0F4 File Offset: 0x000AA2F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429541, RefRangeEnd = 429542, XrefRangeStart = 429510, XrefRangeEnd = 429541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSchema(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_AddSchema_Public_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x000AC138 File Offset: 0x000AA338
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429573, RefRangeEnd = 429574, XrefRangeStart = 429542, XrefRangeEnd = 429573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x000AC16C File Offset: 0x000AA36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429574, XrefRangeEnd = 429625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(XmlSchemaObject partialValidationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(partialValidationType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_Initialize_Public_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x000AC1B0 File Offset: 0x000AA3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429625, XrefRangeEnd = 429654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xsiType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xsiNil);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xsiSchemaLocation);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xsiNoNamespaceSchemaLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateElement_Public_Void_String_String_XmlSchemaInfo_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x000AC264 File Offset: 0x000AA464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429654, XrefRangeEnd = 429655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateAttribute_Public_Object_String_String_XmlValueGetter_XmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x000AC2EC File Offset: 0x000AA4EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 429734, RefRangeEnd = 429736, XrefRangeStart = 429655, XrefRangeEnd = 429734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeValueGetter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeStringValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateAttribute_Private_Object_String_String_XmlValueGetter_String_XmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x000AC388 File Offset: 0x000AA588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429736, XrefRangeEnd = 429742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateEndOfAttributes_Public_Void_XmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x000AC3CC File Offset: 0x000AA5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429742, XrefRangeEnd = 429749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateText(XmlValueGetter elementValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateText_Public_Void_XmlValueGetter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x000AC410 File Offset: 0x000AA610
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 429782, RefRangeEnd = 429785, XrefRangeStart = 429749, XrefRangeEnd = 429782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementStringValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementValueGetter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateText_Private_Void_String_XmlValueGetter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x000AC464 File Offset: 0x000AA664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429785, XrefRangeEnd = 429792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateWhitespace(XmlValueGetter elementValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateWhitespace_Public_Void_XmlValueGetter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x000AC4A8 File Offset: 0x000AA6A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 429808, RefRangeEnd = 429811, XrefRangeStart = 429792, XrefRangeEnd = 429808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementStringValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementValueGetter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateWhitespace_Private_Void_String_XmlValueGetter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x000AC4FC File Offset: 0x000AA6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429811, XrefRangeEnd = 429812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ValidateEndElement(XmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateEndElement_Public_Object_XmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x000AC54C File Offset: 0x000AA74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429812, XrefRangeEnd = 429825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndValidation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_EndValidation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x000AC580 File Offset: 0x000AA780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429877, RefRangeEnd = 429878, XrefRangeStart = 429825, XrefRangeEnd = 429877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(defaultAttributes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createNodeData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_GetUnspecifiedDefaultAttributes_Internal_Void_ArrayList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x000AC5D0 File Offset: 0x000AA7D0
		public unsafe XmlSchemaSet SchemaSet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_SchemaSet_Internal_get_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSet>(intPtr3) : null;
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x0600254A RID: 9546 RVA: 0x000AC610 File Offset: 0x000AA810
		public unsafe XmlSchemaValidationFlags ValidationFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_ValidationFlags_Internal_get_XmlSchemaValidationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x0600254B RID: 9547 RVA: 0x000AC64C File Offset: 0x000AA84C
		public unsafe XmlSchemaContentType CurrentContentType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_CurrentContentType_Internal_get_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x000AC688 File Offset: 0x000AA888
		[CallerCount(0)]
		public unsafe void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtdSchemaInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SetDtdSchemaInfo_Internal_Void_IDtdInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x0600254D RID: 9549 RVA: 0x000AC6CC File Offset: 0x000AA8CC
		public unsafe bool StrictlyAssessed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_StrictlyAssessed_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x0600254E RID: 9550 RVA: 0x000AC708 File Offset: 0x000AA908
		public unsafe bool HasSchema
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429878, XrefRangeEnd = 429879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_HasSchema_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x000AC744 File Offset: 0x000AA944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429879, XrefRangeEnd = 429880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetConcatenatedValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_GetConcatenatedValue_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x000AC77C File Offset: 0x000AA97C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 429916, RefRangeEnd = 429920, XrefRangeStart = 429880, XrefRangeEnd = 429916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InternalValidateEndElement(XmlSchemaInfo schemaInfo, Object typedValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typedValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_InternalValidateEndElement_Private_Object_XmlSchemaInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x000AC7E0 File Offset: 0x000AA9E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429961, RefRangeEnd = 429962, XrefRangeStart = 429920, XrefRangeEnd = 429961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xsiSchemaLocation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xsiNoNamespaceSchemaLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ProcessSchemaLocations_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x000AC834 File Offset: 0x000AAA34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429976, RefRangeEnd = 429977, XrefRangeStart = 429962, XrefRangeEnd = 429976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &invalidElementInContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateElementContext_Private_Object_XmlQualifiedName_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x000AC894 File Offset: 0x000AAA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429977, XrefRangeEnd = 429992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_GetSubstitutionGroupHead_Private_XmlSchemaElement_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x000AC8E4 File Offset: 0x000AAAE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430019, RefRangeEnd = 430020, XrefRangeStart = 429992, XrefRangeEnd = 430019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringValue);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateAtomicValue_Private_Object_String_byref_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			memberType = ((intPtr4 == 0) ? null : new XmlSchemaSimpleType(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x000AC958 File Offset: 0x000AAB58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430037, RefRangeEnd = 430038, XrefRangeStart = 430020, XrefRangeEnd = 430037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ValidateAtomicValue(Object parsedValue, out XmlSchemaSimpleType memberType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parsedValue);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateAtomicValue_Private_Object_Object_byref_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			memberType = ((intPtr4 == 0) ? null : new XmlSchemaSimpleType(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x000AC9CC File Offset: 0x000AABCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430038, XrefRangeEnd = 430039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTypeName(SchemaDeclBase decl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_GetTypeName_Private_String_SchemaDeclBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x000ACA14 File Offset: 0x000AAC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430039, XrefRangeEnd = 430041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveTextValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SaveTextValue_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x000ACA58 File Offset: 0x000AAC58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430049, RefRangeEnd = 430051, XrefRangeStart = 430041, XrefRangeEnd = 430049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(XmlQualifiedName elementName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x000ACA9C File Offset: 0x000AAC9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430058, RefRangeEnd = 430059, XrefRangeStart = 430051, XrefRangeEnd = 430058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_Pop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x000ACAD0 File Offset: 0x000AACD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430068, RefRangeEnd = 430069, XrefRangeStart = 430059, XrefRangeEnd = 430068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_FastGetElementDecl_Private_SchemaElementDecl_XmlQualifiedName_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x000ACB34 File Offset: 0x000AAD34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430159, RefRangeEnd = 430160, XrefRangeStart = 430069, XrefRangeEnd = 430159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementDecl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xsiType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xsiNil);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &declFound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckXsiTypeAndNil_Private_SchemaElementDecl_SchemaElementDecl_String_String_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x000ACBB8 File Offset: 0x000AADB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430178, RefRangeEnd = 430179, XrefRangeStart = 430160, XrefRangeEnd = 430178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowDeclNotFoundWarningOrError(bool declFound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref declFound;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ThrowDeclNotFoundWarningOrError_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x000ACBF8 File Offset: 0x000AADF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430179, XrefRangeEnd = 430188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckElementProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckElementProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x000ACC2C File Offset: 0x000AAE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430188, XrefRangeEnd = 430190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateStartElementIdentityConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateStartElementIdentityConstraints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x000ACC60 File Offset: 0x000AAE60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 430206, RefRangeEnd = 430209, XrefRangeStart = 430190, XrefRangeEnd = 430206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attQName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckIsXmlAttribute_Private_SchemaAttDef_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr3) : null;
			}
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x000ACCB0 File Offset: 0x000AAEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430209, XrefRangeEnd = 430223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddXmlNamespaceSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_AddXmlNamespaceSchema_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x000ACCE4 File Offset: 0x000AAEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430223, XrefRangeEnd = 430228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CheckMixedValueConstraint(string elementValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckMixedValueConstraint_Internal_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x000ACD34 File Offset: 0x000AAF34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430259, RefRangeEnd = 430261, XrefRangeStart = 430228, XrefRangeEnd = 430259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSchema(string uri, string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_LoadSchema_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x000ACD88 File Offset: 0x000AAF88
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 430264, RefRangeEnd = 430269, XrefRangeStart = 430261, XrefRangeEnd = 430264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecompileSchemaSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_RecompileSchemaSet_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x000ACDBC File Offset: 0x000AAFBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430283, RefRangeEnd = 430285, XrefRangeStart = 430269, XrefRangeEnd = 430283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ttype;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attrValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x000ACE1C File Offset: 0x000AB01C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430293, RefRangeEnd = 430294, XrefRangeStart = 430285, XrefRangeEnd = 430293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CheckAttributeValue(Object value, SchemaAttDef attdef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attdef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckAttributeValue_Private_Object_Object_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x000ACE80 File Offset: 0x000AB080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430305, RefRangeEnd = 430306, XrefRangeStart = 430294, XrefRangeEnd = 430305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CheckElementValue(string stringValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckElementValue_Private_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x000ACED0 File Offset: 0x000AB0D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 430315, RefRangeEnd = 430319, XrefRangeStart = 430306, XrefRangeEnd = 430315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTokenizedTypes(XmlSchemaDatatype dtype, Object typedValue, bool attrValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typedValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attrValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckTokenizedTypes_Private_Void_XmlSchemaDatatype_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x000ACF34 File Offset: 0x000AB134
		[CallerCount(0)]
		public unsafe Object FindId(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_FindId_Private_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x000ACF84 File Offset: 0x000AB184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430319, XrefRangeEnd = 430327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForwardRefs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x000ACFB8 File Offset: 0x000AB1B8
		public unsafe bool HasIdentityConstraints
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 430327, RefRangeEnd = 430328, XrefRangeStart = 430327, XrefRangeEnd = 430327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_HasIdentityConstraints_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x000ACFF4 File Offset: 0x000AB1F4
		public unsafe bool ProcessIdentityConstraints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_ProcessIdentityConstraints_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x000AD030 File Offset: 0x000AB230
		public unsafe bool ReportValidationWarnings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_ReportValidationWarnings_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x000AD06C File Offset: 0x000AB26C
		public unsafe bool ProcessSchemaHints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_ProcessSchemaHints_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x000AD0A8 File Offset: 0x000AB2A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 430332, RefRangeEnd = 430339, XrefRangeStart = 430328, XrefRangeEnd = 430332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStateTransition(ValidatorState toState, string methodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref toState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckStateTransition_Private_Void_ValidatorState_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x000AD0F8 File Offset: 0x000AB2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430339, XrefRangeEnd = 430340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPSVI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ClearPSVI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x000AD12C File Offset: 0x000AB32C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430354, RefRangeEnd = 430356, XrefRangeStart = 430340, XrefRangeEnd = 430354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRequiredAttributes(SchemaElementDecl currentElementDecl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentElementDecl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckRequiredAttributes_Private_Void_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x000AD170 File Offset: 0x000AB370
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430368, RefRangeEnd = 430370, XrefRangeStart = 430356, XrefRangeEnd = 430368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaElement GetSchemaElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_GetSchemaElement_Private_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x000AD1B0 File Offset: 0x000AB3B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430390, RefRangeEnd = 430392, XrefRangeStart = 430370, XrefRangeEnd = 430390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDefaultAttributePrefix(string attributeNS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attributeNS);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_GetDefaultAttributePrefix_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x000AD1F8 File Offset: 0x000AB3F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430429, RefRangeEnd = 430431, XrefRangeStart = 430392, XrefRangeEnd = 430429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddIdentityConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_AddIdentityConstraints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x000AD22C File Offset: 0x000AB42C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430453, RefRangeEnd = 430455, XrefRangeStart = 430431, XrefRangeEnd = 430453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ElementIdentityConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ElementIdentityConstraints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x000AD260 File Offset: 0x000AB460
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430476, RefRangeEnd = 430478, XrefRangeStart = 430455, XrefRangeEnd = 430476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttributeIdentityConstraints(string name, string ns, Object obj, string sobj, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sobj);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_AttributeIdentityConstraints_Private_Void_String_String_Object_String_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x000AD2EC File Offset: 0x000AB4EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430570, RefRangeEnd = 430571, XrefRangeStart = 430478, XrefRangeEnd = 430570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndElementIdentityConstraints(Object typedValue, string stringValue, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typedValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stringValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_EndElementIdentityConstraints_Private_Void_Object_String_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x000AD354 File Offset: 0x000AB554
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 430604, RefRangeEnd = 430609, XrefRangeStart = 430571, XrefRangeEnd = 430604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, Object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ElementValidationError_Internal_Static_Void_XmlQualifiedName_ValidationState_ValidationEventHandler_Object_String_Int32_Int32_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x000AD404 File Offset: 0x000AB604
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 430637, RefRangeEnd = 430641, XrefRangeStart = 430609, XrefRangeEnd = 430637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, Object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CompleteValidationError_Internal_Static_Void_ValidationState_ValidationEventHandler_Object_String_Int32_Int32_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x000AD4A0 File Offset: 0x000AB6A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 430688, RefRangeEnd = 430691, XrefRangeStart = 430641, XrefRangeEnd = 430688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PrintExpectedElements(ArrayList expected, bool getParticles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expected);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getParticles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_PrintExpectedElements_Internal_Static_String_ArrayList_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000AD4EC File Offset: 0x000AB6EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430710, RefRangeEnd = 430711, XrefRangeStart = 430691, XrefRangeEnd = 430710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PrintNames(ArrayList expected)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expected);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_PrintNames_Private_Static_String_ArrayList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x000AD528 File Offset: 0x000AB728
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430764, RefRangeEnd = 430766, XrefRangeStart = 430711, XrefRangeEnd = 430764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrintNamesWithNS(ArrayList expected, StringBuilder builder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expected);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_PrintNamesWithNS_Private_Static_Void_ArrayList_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x000AD570 File Offset: 0x000AB770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430766, XrefRangeEnd = 430810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnumerateAny(StringBuilder builder, string namespaces)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaces);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_EnumerateAny_Private_Static_Void_StringBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x000AD5B8 File Offset: 0x000AB7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430810, XrefRangeEnd = 430813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string QNameString(string localName, string ns)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_QNameString_Internal_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x000AD608 File Offset: 0x000AB808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430813, XrefRangeEnd = 430818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string BuildElementName(XmlQualifiedName qname)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_BuildElementName_Internal_Static_String_XmlQualifiedName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x000AD644 File Offset: 0x000AB844
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 430841, RefRangeEnd = 430847, XrefRangeStart = 430818, XrefRangeEnd = 430841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string BuildElementName(string localName, string ns)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_BuildElementName_Internal_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x000AD694 File Offset: 0x000AB894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430847, XrefRangeEnd = 430859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEntity(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ProcessEntity_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x000AD6D8 File Offset: 0x000AB8D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430862, RefRangeEnd = 430863, XrefRangeStart = 430859, XrefRangeEnd = 430862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x000AD71C File Offset: 0x000AB91C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 430874, RefRangeEnd = 430880, XrefRangeStart = 430863, XrefRangeEnd = 430874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, Il2CppStringArray args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x000AD770 File Offset: 0x000AB970
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 430891, RefRangeEnd = 430913, XrefRangeStart = 430880, XrefRangeEnd = 430891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x000AD7C4 File Offset: 0x000AB9C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430935, RefRangeEnd = 430936, XrefRangeStart = 430913, XrefRangeEnd = 430935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string arg1, string arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x000AD82C File Offset: 0x000ABA2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430946, RefRangeEnd = 430947, XrefRangeStart = 430936, XrefRangeEnd = 430946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, Il2CppStringArray args, Exception innerException, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_Exception_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x000AD8A0 File Offset: 0x000ABAA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 430961, RefRangeEnd = 430965, XrefRangeStart = 430947, XrefRangeEnd = 430961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, Il2CppStringArray args, Exception innerException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x000AD908 File Offset: 0x000ABB08
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 430970, RefRangeEnd = 430975, XrefRangeStart = 430965, XrefRangeEnd = 430970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSchemaValidationException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaValidationException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x000AD94C File Offset: 0x000ABB4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430984, RefRangeEnd = 430986, XrefRangeStart = 430975, XrefRangeEnd = 430984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSchemaException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x000AD990 File Offset: 0x000ABB90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 430996, RefRangeEnd = 431001, XrefRangeStart = 430986, XrefRangeEnd = 430996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string msg, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x000AD9F4 File Offset: 0x000ABBF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 431009, RefRangeEnd = 431013, XrefRangeStart = 431001, XrefRangeEnd = 431009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaValidationException_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x000ADA44 File Offset: 0x000ABC44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431019, RefRangeEnd = 431020, XrefRangeStart = 431013, XrefRangeEnd = 431019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendValidationEvent(ValidationEventHandler eventHandler, Object sender, XmlSchemaValidationException e, XmlSeverityType severity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Internal_Static_Void_ValidationEventHandler_Object_XmlSchemaValidationException_XmlSeverityType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x0001025D File Offset: 0x0000E45D
		public XmlSchemaValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x000ADAAC File Offset: 0x000ABCAC
		// (set) Token: 0x0600258E RID: 9614 RVA: 0x00010266 File Offset: 0x0000E466
		public unsafe XmlSchemaSet schemaSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_schemaSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_schemaSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x0600258F RID: 9615 RVA: 0x000ADADC File Offset: 0x000ABCDC
		// (set) Token: 0x06002590 RID: 9616 RVA: 0x00010285 File Offset: 0x0000E485
		public unsafe XmlSchemaValidationFlags validationFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_validationFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_validationFlags)) = value;
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x000ADB04 File Offset: 0x000ABD04
		// (set) Token: 0x06002592 RID: 9618 RVA: 0x000102A0 File Offset: 0x0000E4A0
		public unsafe int startIDConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_startIDConstraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_startIDConstraint)) = value;
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06002593 RID: 9619 RVA: 0x000ADB2C File Offset: 0x000ABD2C
		// (set) Token: 0x06002594 RID: 9620 RVA: 0x000102BB File Offset: 0x0000E4BB
		public unsafe bool isRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_isRoot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_isRoot)) = value;
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x000ADB54 File Offset: 0x000ABD54
		// (set) Token: 0x06002596 RID: 9622 RVA: 0x000102D6 File Offset: 0x0000E4D6
		public unsafe bool rootHasSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_rootHasSchema);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_rootHasSchema)) = value;
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x000ADB7C File Offset: 0x000ABD7C
		// (set) Token: 0x06002598 RID: 9624 RVA: 0x000102F1 File Offset: 0x0000E4F1
		public unsafe bool attrValid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_attrValid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_attrValid)) = value;
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06002599 RID: 9625 RVA: 0x000ADBA4 File Offset: 0x000ABDA4
		// (set) Token: 0x0600259A RID: 9626 RVA: 0x0001030C File Offset: 0x0000E50C
		public unsafe bool checkEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_checkEntity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_checkEntity)) = value;
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x0600259B RID: 9627 RVA: 0x000ADBCC File Offset: 0x000ABDCC
		// (set) Token: 0x0600259C RID: 9628 RVA: 0x00010327 File Offset: 0x0000E527
		public unsafe SchemaInfo compiledSchemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_compiledSchemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_compiledSchemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x000ADBFC File Offset: 0x000ABDFC
		// (set) Token: 0x0600259E RID: 9630 RVA: 0x00010346 File Offset: 0x0000E546
		public unsafe IDtdInfo dtdSchemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_dtdSchemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_dtdSchemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x000ADC2C File Offset: 0x000ABE2C
		// (set) Token: 0x060025A0 RID: 9632 RVA: 0x00010365 File Offset: 0x0000E565
		public unsafe Hashtable validatedNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_validatedNamespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_validatedNamespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x060025A1 RID: 9633 RVA: 0x000ADC5C File Offset: 0x000ABE5C
		// (set) Token: 0x060025A2 RID: 9634 RVA: 0x00010384 File Offset: 0x0000E584
		public unsafe HWStack validationStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_validationStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HWStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_validationStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x060025A3 RID: 9635 RVA: 0x000ADC8C File Offset: 0x000ABE8C
		// (set) Token: 0x060025A4 RID: 9636 RVA: 0x000103A3 File Offset: 0x0000E5A3
		public unsafe ValidationState context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x060025A5 RID: 9637 RVA: 0x000ADCBC File Offset: 0x000ABEBC
		// (set) Token: 0x060025A6 RID: 9638 RVA: 0x000103C2 File Offset: 0x0000E5C2
		public unsafe ValidatorState currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_currentState)) = value;
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x060025A7 RID: 9639 RVA: 0x000ADCE4 File Offset: 0x000ABEE4
		// (set) Token: 0x060025A8 RID: 9640 RVA: 0x000103DD File Offset: 0x0000E5DD
		public unsafe Hashtable attPresence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_attPresence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_attPresence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x000ADD14 File Offset: 0x000ABF14
		// (set) Token: 0x060025AA RID: 9642 RVA: 0x000103FC File Offset: 0x0000E5FC
		public unsafe SchemaAttDef wildID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_wildID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_wildID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x000ADD44 File Offset: 0x000ABF44
		// (set) Token: 0x060025AC RID: 9644 RVA: 0x0001041B File Offset: 0x0000E61B
		public unsafe Hashtable IDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_IDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_IDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x000ADD74 File Offset: 0x000ABF74
		// (set) Token: 0x060025AE RID: 9646 RVA: 0x0001043A File Offset: 0x0000E63A
		public unsafe IdRefNode idRefListHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_idRefListHead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IdRefNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_idRefListHead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x000ADDA4 File Offset: 0x000ABFA4
		// (set) Token: 0x060025B0 RID: 9648 RVA: 0x00010459 File Offset: 0x0000E659
		public unsafe XmlQualifiedName contextQName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_contextQName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_contextQName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x000ADDD4 File Offset: 0x000ABFD4
		// (set) Token: 0x060025B2 RID: 9650 RVA: 0x00010478 File Offset: 0x0000E678
		public unsafe string NsXs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_NsXs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_NsXs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x000ADDFC File Offset: 0x000ABFFC
		// (set) Token: 0x060025B4 RID: 9652 RVA: 0x00010497 File Offset: 0x0000E697
		public unsafe string NsXsi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_NsXsi);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_NsXsi), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x000ADE24 File Offset: 0x000AC024
		// (set) Token: 0x060025B6 RID: 9654 RVA: 0x000104B6 File Offset: 0x0000E6B6
		public unsafe string NsXmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_NsXmlNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_NsXmlNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x000ADE4C File Offset: 0x000AC04C
		// (set) Token: 0x060025B8 RID: 9656 RVA: 0x000104D5 File Offset: 0x0000E6D5
		public unsafe string NsXml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_NsXml);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_NsXml), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x000ADE74 File Offset: 0x000AC074
		// (set) Token: 0x060025BA RID: 9658 RVA: 0x000104F4 File Offset: 0x0000E6F4
		public unsafe XmlSchemaObject partialValidationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_partialValidationType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_partialValidationType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x000ADEA4 File Offset: 0x000AC0A4
		// (set) Token: 0x060025BC RID: 9660 RVA: 0x00010513 File Offset: 0x0000E713
		public unsafe StringBuilder textValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_textValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_textValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x060025BD RID: 9661 RVA: 0x000ADED4 File Offset: 0x000AC0D4
		// (set) Token: 0x060025BE RID: 9662 RVA: 0x00010532 File Offset: 0x0000E732
		public unsafe ValidationEventHandler eventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_eventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_eventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x060025BF RID: 9663 RVA: 0x000ADF04 File Offset: 0x000AC104
		// (set) Token: 0x060025C0 RID: 9664 RVA: 0x00010551 File Offset: 0x0000E751
		public unsafe Object validationEventSender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_validationEventSender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_validationEventSender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x060025C1 RID: 9665 RVA: 0x000ADF34 File Offset: 0x000AC134
		// (set) Token: 0x060025C2 RID: 9666 RVA: 0x00010570 File Offset: 0x0000E770
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x060025C3 RID: 9667 RVA: 0x000ADF64 File Offset: 0x000AC164
		// (set) Token: 0x060025C4 RID: 9668 RVA: 0x0001058F File Offset: 0x0000E78F
		public unsafe IXmlLineInfo positionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_positionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlLineInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_positionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x060025C5 RID: 9669 RVA: 0x000ADF94 File Offset: 0x000AC194
		// (set) Token: 0x060025C6 RID: 9670 RVA: 0x000105AE File Offset: 0x0000E7AE
		public unsafe IXmlLineInfo dummyPositionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_dummyPositionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlLineInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_dummyPositionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x060025C7 RID: 9671 RVA: 0x000ADFC4 File Offset: 0x000AC1C4
		// (set) Token: 0x060025C8 RID: 9672 RVA: 0x000105CD File Offset: 0x0000E7CD
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x060025C9 RID: 9673 RVA: 0x000ADFF4 File Offset: 0x000AC1F4
		// (set) Token: 0x060025CA RID: 9674 RVA: 0x000105EC File Offset: 0x0000E7EC
		public unsafe Uri sourceUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_sourceUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_sourceUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x060025CB RID: 9675 RVA: 0x000AE024 File Offset: 0x000AC224
		// (set) Token: 0x060025CC RID: 9676 RVA: 0x0001060B File Offset: 0x0000E80B
		public unsafe string sourceUriString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_sourceUriString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_sourceUriString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x060025CD RID: 9677 RVA: 0x000AE04C File Offset: 0x000AC24C
		// (set) Token: 0x060025CE RID: 9678 RVA: 0x0001062A File Offset: 0x0000E82A
		public unsafe IXmlNamespaceResolver nsResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_nsResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_nsResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x060025CF RID: 9679 RVA: 0x000AE07C File Offset: 0x000AC27C
		// (set) Token: 0x060025D0 RID: 9680 RVA: 0x00010649 File Offset: 0x0000E849
		public unsafe XmlSchemaContentProcessing processContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_processContents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_processContents)) = value;
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x060025D1 RID: 9681 RVA: 0x000AE0A4 File Offset: 0x000AC2A4
		// (set) Token: 0x060025D2 RID: 9682 RVA: 0x00010664 File Offset: 0x0000E864
		public unsafe string xsiTypeString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xsiTypeString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xsiTypeString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x060025D3 RID: 9683 RVA: 0x000AE0CC File Offset: 0x000AC2CC
		// (set) Token: 0x060025D4 RID: 9684 RVA: 0x00010683 File Offset: 0x0000E883
		public unsafe string xsiNilString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xsiNilString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xsiNilString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x060025D5 RID: 9685 RVA: 0x000AE0F4 File Offset: 0x000AC2F4
		// (set) Token: 0x060025D6 RID: 9686 RVA: 0x000106A2 File Offset: 0x0000E8A2
		public unsafe string xsiSchemaLocationString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xsiSchemaLocationString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xsiSchemaLocationString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x000AE11C File Offset: 0x000AC31C
		// (set) Token: 0x060025D8 RID: 9688 RVA: 0x000106C1 File Offset: 0x0000E8C1
		public unsafe string xsiNoNamespaceSchemaLocationString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xsiNoNamespaceSchemaLocationString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xsiNoNamespaceSchemaLocationString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x000AE144 File Offset: 0x000AC344
		// (set) Token: 0x060025DA RID: 9690 RVA: 0x000106E0 File Offset: 0x0000E8E0
		public unsafe static XmlSchemaDatatype dtQName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaValidator.NativeFieldInfoPtr_dtQName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaValidator.NativeFieldInfoPtr_dtQName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x060025DB RID: 9691 RVA: 0x000AE16C File Offset: 0x000AC36C
		// (set) Token: 0x060025DC RID: 9692 RVA: 0x000106F2 File Offset: 0x0000E8F2
		public unsafe static XmlSchemaDatatype dtCDATA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaValidator.NativeFieldInfoPtr_dtCDATA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaValidator.NativeFieldInfoPtr_dtCDATA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x060025DD RID: 9693 RVA: 0x000AE194 File Offset: 0x000AC394
		// (set) Token: 0x060025DE RID: 9694 RVA: 0x00010704 File Offset: 0x0000E904
		public unsafe static XmlSchemaDatatype dtStringArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaValidator.NativeFieldInfoPtr_dtStringArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaValidator.NativeFieldInfoPtr_dtStringArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x000AE1BC File Offset: 0x000AC3BC
		// (set) Token: 0x060025E0 RID: 9696 RVA: 0x00010716 File Offset: 0x0000E916
		public unsafe static Il2CppReferenceArray<XmlSchemaParticle> EmptyParticleArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaValidator.NativeFieldInfoPtr_EmptyParticleArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaParticle>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaValidator.NativeFieldInfoPtr_EmptyParticleArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x000AE1E4 File Offset: 0x000AC3E4
		// (set) Token: 0x060025E2 RID: 9698 RVA: 0x00010728 File Offset: 0x0000E928
		public unsafe static Il2CppReferenceArray<XmlSchemaAttribute> EmptyAttributeArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaValidator.NativeFieldInfoPtr_EmptyAttributeArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaValidator.NativeFieldInfoPtr_EmptyAttributeArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x000AE20C File Offset: 0x000AC40C
		// (set) Token: 0x060025E4 RID: 9700 RVA: 0x0001073A File Offset: 0x0000E93A
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x000AE23C File Offset: 0x000AC43C
		// (set) Token: 0x060025E6 RID: 9702 RVA: 0x00010768 File Offset: 0x0000E968
		public unsafe static Il2CppObjectBase ValidStates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaValidator.NativeFieldInfoPtr_ValidStates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaValidator.NativeFieldInfoPtr_ValidStates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x060025E7 RID: 9703 RVA: 0x000AE264 File Offset: 0x000AC464
		// (set) Token: 0x060025E8 RID: 9704 RVA: 0x0001077A File Offset: 0x0000E97A
		public unsafe static Il2CppStringArray MethodNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaValidator.NativeFieldInfoPtr_MethodNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaValidator.NativeFieldInfoPtr_MethodNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BA7 RID: 7079
		private static readonly IntPtr NativeFieldInfoPtr_schemaSet;

		// Token: 0x04001BA8 RID: 7080
		private static readonly IntPtr NativeFieldInfoPtr_validationFlags;

		// Token: 0x04001BA9 RID: 7081
		private static readonly IntPtr NativeFieldInfoPtr_startIDConstraint;

		// Token: 0x04001BAA RID: 7082
		private static readonly IntPtr NativeFieldInfoPtr_isRoot;

		// Token: 0x04001BAB RID: 7083
		private static readonly IntPtr NativeFieldInfoPtr_rootHasSchema;

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeFieldInfoPtr_attrValid;

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeFieldInfoPtr_checkEntity;

		// Token: 0x04001BAE RID: 7086
		private static readonly IntPtr NativeFieldInfoPtr_compiledSchemaInfo;

		// Token: 0x04001BAF RID: 7087
		private static readonly IntPtr NativeFieldInfoPtr_dtdSchemaInfo;

		// Token: 0x04001BB0 RID: 7088
		private static readonly IntPtr NativeFieldInfoPtr_validatedNamespaces;

		// Token: 0x04001BB1 RID: 7089
		private static readonly IntPtr NativeFieldInfoPtr_validationStack;

		// Token: 0x04001BB2 RID: 7090
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04001BB3 RID: 7091
		private static readonly IntPtr NativeFieldInfoPtr_currentState;

		// Token: 0x04001BB4 RID: 7092
		private static readonly IntPtr NativeFieldInfoPtr_attPresence;

		// Token: 0x04001BB5 RID: 7093
		private static readonly IntPtr NativeFieldInfoPtr_wildID;

		// Token: 0x04001BB6 RID: 7094
		private static readonly IntPtr NativeFieldInfoPtr_IDs;

		// Token: 0x04001BB7 RID: 7095
		private static readonly IntPtr NativeFieldInfoPtr_idRefListHead;

		// Token: 0x04001BB8 RID: 7096
		private static readonly IntPtr NativeFieldInfoPtr_contextQName;

		// Token: 0x04001BB9 RID: 7097
		private static readonly IntPtr NativeFieldInfoPtr_NsXs;

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeFieldInfoPtr_NsXsi;

		// Token: 0x04001BBB RID: 7099
		private static readonly IntPtr NativeFieldInfoPtr_NsXmlNs;

		// Token: 0x04001BBC RID: 7100
		private static readonly IntPtr NativeFieldInfoPtr_NsXml;

		// Token: 0x04001BBD RID: 7101
		private static readonly IntPtr NativeFieldInfoPtr_partialValidationType;

		// Token: 0x04001BBE RID: 7102
		private static readonly IntPtr NativeFieldInfoPtr_textValue;

		// Token: 0x04001BBF RID: 7103
		private static readonly IntPtr NativeFieldInfoPtr_eventHandler;

		// Token: 0x04001BC0 RID: 7104
		private static readonly IntPtr NativeFieldInfoPtr_validationEventSender;

		// Token: 0x04001BC1 RID: 7105
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeFieldInfoPtr_positionInfo;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeFieldInfoPtr_dummyPositionInfo;

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeFieldInfoPtr_sourceUri;

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeFieldInfoPtr_sourceUriString;

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeFieldInfoPtr_nsResolver;

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeFieldInfoPtr_processContents;

		// Token: 0x04001BC9 RID: 7113
		private static readonly IntPtr NativeFieldInfoPtr_xsiTypeString;

		// Token: 0x04001BCA RID: 7114
		private static readonly IntPtr NativeFieldInfoPtr_xsiNilString;

		// Token: 0x04001BCB RID: 7115
		private static readonly IntPtr NativeFieldInfoPtr_xsiSchemaLocationString;

		// Token: 0x04001BCC RID: 7116
		private static readonly IntPtr NativeFieldInfoPtr_xsiNoNamespaceSchemaLocationString;

		// Token: 0x04001BCD RID: 7117
		private static readonly IntPtr NativeFieldInfoPtr_dtQName;

		// Token: 0x04001BCE RID: 7118
		private static readonly IntPtr NativeFieldInfoPtr_dtCDATA;

		// Token: 0x04001BCF RID: 7119
		private static readonly IntPtr NativeFieldInfoPtr_dtStringArray;

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeFieldInfoPtr_EmptyParticleArray;

		// Token: 0x04001BD1 RID: 7121
		private static readonly IntPtr NativeFieldInfoPtr_EmptyAttributeArray;

		// Token: 0x04001BD2 RID: 7122
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04001BD3 RID: 7123
		private static readonly IntPtr NativeFieldInfoPtr_ValidStates;

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeFieldInfoPtr_MethodNames;

		// Token: 0x04001BD5 RID: 7125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlSchemaSet_IXmlNamespaceResolver_XmlSchemaValidationFlags_0;

		// Token: 0x04001BD6 RID: 7126
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeMethodInfoPtr_set_LineInfoProvider_Public_set_Void_IXmlLineInfo_0;

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceUri_Public_set_Void_Uri_0;

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeMethodInfoPtr_set_ValidationEventSender_Public_set_Void_Object_0;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeMethodInfoPtr_add_ValidationEventHandler_Public_add_Void_ValidationEventHandler_0;

		// Token: 0x04001BDD RID: 7133
		private static readonly IntPtr NativeMethodInfoPtr_remove_ValidationEventHandler_Public_rem_Void_ValidationEventHandler_0;

		// Token: 0x04001BDE RID: 7134
		private static readonly IntPtr NativeMethodInfoPtr_AddSchema_Public_Void_XmlSchema_0;

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_XmlSchemaObject_0;

		// Token: 0x04001BE1 RID: 7137
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Public_Void_String_String_XmlSchemaInfo_String_String_String_String_0;

		// Token: 0x04001BE2 RID: 7138
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAttribute_Public_Object_String_String_XmlValueGetter_XmlSchemaInfo_0;

		// Token: 0x04001BE3 RID: 7139
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAttribute_Private_Object_String_String_XmlValueGetter_String_XmlSchemaInfo_0;

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndOfAttributes_Public_Void_XmlSchemaInfo_0;

		// Token: 0x04001BE5 RID: 7141
		private static readonly IntPtr NativeMethodInfoPtr_ValidateText_Public_Void_XmlValueGetter_0;

		// Token: 0x04001BE6 RID: 7142
		private static readonly IntPtr NativeMethodInfoPtr_ValidateText_Private_Void_String_XmlValueGetter_0;

		// Token: 0x04001BE7 RID: 7143
		private static readonly IntPtr NativeMethodInfoPtr_ValidateWhitespace_Public_Void_XmlValueGetter_0;

		// Token: 0x04001BE8 RID: 7144
		private static readonly IntPtr NativeMethodInfoPtr_ValidateWhitespace_Private_Void_String_XmlValueGetter_0;

		// Token: 0x04001BE9 RID: 7145
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndElement_Public_Object_XmlSchemaInfo_0;

		// Token: 0x04001BEA RID: 7146
		private static readonly IntPtr NativeMethodInfoPtr_EndValidation_Public_Void_0;

		// Token: 0x04001BEB RID: 7147
		private static readonly IntPtr NativeMethodInfoPtr_GetUnspecifiedDefaultAttributes_Internal_Void_ArrayList_Boolean_0;

		// Token: 0x04001BEC RID: 7148
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaSet_Internal_get_XmlSchemaSet_0;

		// Token: 0x04001BED RID: 7149
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidationFlags_Internal_get_XmlSchemaValidationFlags_0;

		// Token: 0x04001BEE RID: 7150
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentContentType_Internal_get_XmlSchemaContentType_0;

		// Token: 0x04001BEF RID: 7151
		private static readonly IntPtr NativeMethodInfoPtr_SetDtdSchemaInfo_Internal_Void_IDtdInfo_0;

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeMethodInfoPtr_get_StrictlyAssessed_Private_get_Boolean_0;

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSchema_Private_get_Boolean_0;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeMethodInfoPtr_GetConcatenatedValue_Internal_String_0;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeMethodInfoPtr_InternalValidateEndElement_Private_Object_XmlSchemaInfo_Object_0;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSchemaLocations_Private_Void_String_String_0;

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElementContext_Private_Object_XmlQualifiedName_byref_Boolean_0;

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeMethodInfoPtr_GetSubstitutionGroupHead_Private_XmlSchemaElement_XmlQualifiedName_0;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAtomicValue_Private_Object_String_byref_XmlSchemaSimpleType_0;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAtomicValue_Private_Object_Object_byref_XmlSchemaSimpleType_0;

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeName_Private_String_SchemaDeclBase_0;

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeMethodInfoPtr_SaveTextValue_Private_Void_Object_0;

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_Void_0;

		// Token: 0x04001BFD RID: 7165
		private static readonly IntPtr NativeMethodInfoPtr_FastGetElementDecl_Private_SchemaElementDecl_XmlQualifiedName_Object_0;

		// Token: 0x04001BFE RID: 7166
		private static readonly IntPtr NativeMethodInfoPtr_CheckXsiTypeAndNil_Private_SchemaElementDecl_SchemaElementDecl_String_String_byref_Boolean_0;

		// Token: 0x04001BFF RID: 7167
		private static readonly IntPtr NativeMethodInfoPtr_ThrowDeclNotFoundWarningOrError_Private_Void_Boolean_0;

		// Token: 0x04001C00 RID: 7168
		private static readonly IntPtr NativeMethodInfoPtr_CheckElementProperties_Private_Void_0;

		// Token: 0x04001C01 RID: 7169
		private static readonly IntPtr NativeMethodInfoPtr_ValidateStartElementIdentityConstraints_Private_Void_0;

		// Token: 0x04001C02 RID: 7170
		private static readonly IntPtr NativeMethodInfoPtr_CheckIsXmlAttribute_Private_SchemaAttDef_XmlQualifiedName_0;

		// Token: 0x04001C03 RID: 7171
		private static readonly IntPtr NativeMethodInfoPtr_AddXmlNamespaceSchema_Private_Void_0;

		// Token: 0x04001C04 RID: 7172
		private static readonly IntPtr NativeMethodInfoPtr_CheckMixedValueConstraint_Internal_Object_String_0;

		// Token: 0x04001C05 RID: 7173
		private static readonly IntPtr NativeMethodInfoPtr_LoadSchema_Private_Void_String_String_0;

		// Token: 0x04001C06 RID: 7174
		private static readonly IntPtr NativeMethodInfoPtr_RecompileSchemaSet_Internal_Void_0;

		// Token: 0x04001C07 RID: 7175
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_Boolean_0;

		// Token: 0x04001C08 RID: 7176
		private static readonly IntPtr NativeMethodInfoPtr_CheckAttributeValue_Private_Object_Object_SchemaAttDef_0;

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeMethodInfoPtr_CheckElementValue_Private_Object_String_0;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeMethodInfoPtr_CheckTokenizedTypes_Private_Void_XmlSchemaDatatype_Object_Boolean_0;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeMethodInfoPtr_FindId_Private_Object_String_0;

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeMethodInfoPtr_get_HasIdentityConstraints_Private_get_Boolean_0;

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessIdentityConstraints_Internal_get_Boolean_0;

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeMethodInfoPtr_get_ReportValidationWarnings_Internal_get_Boolean_0;

		// Token: 0x04001C10 RID: 7184
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessSchemaHints_Internal_get_Boolean_0;

		// Token: 0x04001C11 RID: 7185
		private static readonly IntPtr NativeMethodInfoPtr_CheckStateTransition_Private_Void_ValidatorState_String_0;

		// Token: 0x04001C12 RID: 7186
		private static readonly IntPtr NativeMethodInfoPtr_ClearPSVI_Private_Void_0;

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeMethodInfoPtr_CheckRequiredAttributes_Private_Void_SchemaElementDecl_0;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaElement_Private_XmlSchemaElement_0;

		// Token: 0x04001C15 RID: 7189
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultAttributePrefix_Internal_String_String_0;

		// Token: 0x04001C16 RID: 7190
		private static readonly IntPtr NativeMethodInfoPtr_AddIdentityConstraints_Private_Void_0;

		// Token: 0x04001C17 RID: 7191
		private static readonly IntPtr NativeMethodInfoPtr_ElementIdentityConstraints_Private_Void_0;

		// Token: 0x04001C18 RID: 7192
		private static readonly IntPtr NativeMethodInfoPtr_AttributeIdentityConstraints_Private_Void_String_String_Object_String_XmlSchemaDatatype_0;

		// Token: 0x04001C19 RID: 7193
		private static readonly IntPtr NativeMethodInfoPtr_EndElementIdentityConstraints_Private_Void_Object_String_XmlSchemaDatatype_0;

		// Token: 0x04001C1A RID: 7194
		private static readonly IntPtr NativeMethodInfoPtr_ElementValidationError_Internal_Static_Void_XmlQualifiedName_ValidationState_ValidationEventHandler_Object_String_Int32_Int32_XmlSchemaSet_0;

		// Token: 0x04001C1B RID: 7195
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidationError_Internal_Static_Void_ValidationState_ValidationEventHandler_Object_String_Int32_Int32_XmlSchemaSet_0;

		// Token: 0x04001C1C RID: 7196
		private static readonly IntPtr NativeMethodInfoPtr_PrintExpectedElements_Internal_Static_String_ArrayList_Boolean_0;

		// Token: 0x04001C1D RID: 7197
		private static readonly IntPtr NativeMethodInfoPtr_PrintNames_Private_Static_String_ArrayList_0;

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeMethodInfoPtr_PrintNamesWithNS_Private_Static_Void_ArrayList_StringBuilder_0;

		// Token: 0x04001C1F RID: 7199
		private static readonly IntPtr NativeMethodInfoPtr_EnumerateAny_Private_Static_Void_StringBuilder_String_0;

		// Token: 0x04001C20 RID: 7200
		private static readonly IntPtr NativeMethodInfoPtr_QNameString_Internal_Static_String_String_String_0;

		// Token: 0x04001C21 RID: 7201
		private static readonly IntPtr NativeMethodInfoPtr_BuildElementName_Internal_Static_String_XmlQualifiedName_0;

		// Token: 0x04001C22 RID: 7202
		private static readonly IntPtr NativeMethodInfoPtr_BuildElementName_Internal_Static_String_String_String_0;

		// Token: 0x04001C23 RID: 7203
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEntity_Private_Void_String_0;

		// Token: 0x04001C24 RID: 7204
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_0;

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_0;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0;

		// Token: 0x04001C27 RID: 7207
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_String_0;

		// Token: 0x04001C28 RID: 7208
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_Exception_XmlSeverityType_0;

		// Token: 0x04001C29 RID: 7209
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_Exception_0;

		// Token: 0x04001C2A RID: 7210
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaValidationException_0;

		// Token: 0x04001C2B RID: 7211
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_0;

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_XmlSeverityType_0;

		// Token: 0x04001C2D RID: 7213
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaValidationException_XmlSeverityType_0;

		// Token: 0x04001C2E RID: 7214
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Internal_Static_Void_ValidationEventHandler_Object_XmlSchemaValidationException_XmlSeverityType_0;
	}
}
