using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000067 RID: 103
	public class XsdValidatingReader : XmlReader
	{
		// Token: 0x06000A6E RID: 2670 RVA: 0x00040554 File Offset: 0x0003E754
		// Note: this type is marked as 'beforefieldinit'.
		static XsdValidatingReader()
		{
			Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XsdValidatingReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr);
			XsdValidatingReader.NativeFieldInfoPtr_coreReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "coreReader");
			XsdValidatingReader.NativeFieldInfoPtr_coreReaderNSResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "coreReaderNSResolver");
			XsdValidatingReader.NativeFieldInfoPtr_thisNSResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "thisNSResolver");
			XsdValidatingReader.NativeFieldInfoPtr_validator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "validator");
			XsdValidatingReader.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "xmlResolver");
			XsdValidatingReader.NativeFieldInfoPtr_validationEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "validationEvent");
			XsdValidatingReader.NativeFieldInfoPtr_validationState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "validationState");
			XsdValidatingReader.NativeFieldInfoPtr_valueGetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "valueGetter");
			XsdValidatingReader.NativeFieldInfoPtr_nsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "nsManager");
			XsdValidatingReader.NativeFieldInfoPtr_manageNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "manageNamespaces");
			XsdValidatingReader.NativeFieldInfoPtr_processInlineSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "processInlineSchema");
			XsdValidatingReader.NativeFieldInfoPtr_replayCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "replayCache");
			XsdValidatingReader.NativeFieldInfoPtr_cachedNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "cachedNode");
			XsdValidatingReader.NativeFieldInfoPtr_attributePSVI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "attributePSVI");
			XsdValidatingReader.NativeFieldInfoPtr_attributeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "attributeCount");
			XsdValidatingReader.NativeFieldInfoPtr_coreReaderAttributeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "coreReaderAttributeCount");
			XsdValidatingReader.NativeFieldInfoPtr_currentAttrIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "currentAttrIndex");
			XsdValidatingReader.NativeFieldInfoPtr_attributePSVINodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "attributePSVINodes");
			XsdValidatingReader.NativeFieldInfoPtr_defaultAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "defaultAttributes");
			XsdValidatingReader.NativeFieldInfoPtr_inlineSchemaParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "inlineSchemaParser");
			XsdValidatingReader.NativeFieldInfoPtr_atomicValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "atomicValue");
			XsdValidatingReader.NativeFieldInfoPtr_xmlSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "xmlSchemaInfo");
			XsdValidatingReader.NativeFieldInfoPtr_originalAtomicValueString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "originalAtomicValueString");
			XsdValidatingReader.NativeFieldInfoPtr_coreReaderNameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "coreReaderNameTable");
			XsdValidatingReader.NativeFieldInfoPtr_cachingReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "cachingReader");
			XsdValidatingReader.NativeFieldInfoPtr_textNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "textNode");
			XsdValidatingReader.NativeFieldInfoPtr_NsXmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "NsXmlNs");
			XsdValidatingReader.NativeFieldInfoPtr_NsXs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "NsXs");
			XsdValidatingReader.NativeFieldInfoPtr_NsXsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "NsXsi");
			XsdValidatingReader.NativeFieldInfoPtr_XsiType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "XsiType");
			XsdValidatingReader.NativeFieldInfoPtr_XsiNil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "XsiNil");
			XsdValidatingReader.NativeFieldInfoPtr_XsdSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "XsdSchema");
			XsdValidatingReader.NativeFieldInfoPtr_XsiSchemaLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "XsiSchemaLocation");
			XsdValidatingReader.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "XsiNoNamespaceSchemaLocation");
			XsdValidatingReader.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "xmlCharType");
			XsdValidatingReader.NativeFieldInfoPtr_lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "lineInfo");
			XsdValidatingReader.NativeFieldInfoPtr_readBinaryHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "readBinaryHelper");
			XsdValidatingReader.NativeFieldInfoPtr_savedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "savedState");
			XsdValidatingReader.NativeFieldInfoPtr_TypeOfString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "TypeOfString");
			XsdValidatingReader.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlResolver_XmlReaderSettings_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664961);
			XsdValidatingReader.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlResolver_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664962);
			XsdValidatingReader.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664963);
			XsdValidatingReader.NativeMethodInfoPtr_SetupValidator_Private_Void_XmlReaderSettings_XmlReader_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664964);
			XsdValidatingReader.NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664965);
			XsdValidatingReader.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664966);
			XsdValidatingReader.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664967);
			XsdValidatingReader.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664968);
			XsdValidatingReader.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664969);
			XsdValidatingReader.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664970);
			XsdValidatingReader.NativeMethodInfoPtr_get_HasValue_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664971);
			XsdValidatingReader.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664972);
			XsdValidatingReader.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664973);
			XsdValidatingReader.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664974);
			XsdValidatingReader.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664975);
			XsdValidatingReader.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664976);
			XsdValidatingReader.NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_get_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664977);
			XsdValidatingReader.NativeMethodInfoPtr_ReadContentAsString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664978);
			XsdValidatingReader.NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664979);
			XsdValidatingReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664980);
			XsdValidatingReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664981);
			XsdValidatingReader.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664982);
			XsdValidatingReader.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664983);
			XsdValidatingReader.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664984);
			XsdValidatingReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664985);
			XsdValidatingReader.NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664986);
			XsdValidatingReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664987);
			XsdValidatingReader.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664988);
			XsdValidatingReader.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664989);
			XsdValidatingReader.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664990);
			XsdValidatingReader.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664991);
			XsdValidatingReader.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664992);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsDefault_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664993);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsNil_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664994);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_Validity_Private_Virtual_Final_New_get_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664995);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_MemberType_Private_Virtual_Final_New_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664996);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaType_Private_Virtual_Final_New_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664997);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaElement_Private_Virtual_Final_New_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664998);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaAttribute_Private_Virtual_Final_New_get_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100664999);
			XsdValidatingReader.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665000);
			XsdValidatingReader.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665001);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665002);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665003);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665004);
			XsdValidatingReader.NativeMethodInfoPtr_GetStringValue_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665005);
			XsdValidatingReader.NativeMethodInfoPtr_get_ElementXmlType_Private_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665006);
			XsdValidatingReader.NativeMethodInfoPtr_get_AttributeXmlType_Private_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665007);
			XsdValidatingReader.NativeMethodInfoPtr_get_AttributeSchemaInfo_Private_get_XmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665008);
			XsdValidatingReader.NativeMethodInfoPtr_ProcessReaderEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665009);
			XsdValidatingReader.NativeMethodInfoPtr_ProcessElementEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665010);
			XsdValidatingReader.NativeMethodInfoPtr_ProcessEndElementEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665011);
			XsdValidatingReader.NativeMethodInfoPtr_ValidateAttributes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665012);
			XsdValidatingReader.NativeMethodInfoPtr_ClearAttributesInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665013);
			XsdValidatingReader.NativeMethodInfoPtr_GetAttributePSVI_Private_AttributePSVIInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665014);
			XsdValidatingReader.NativeMethodInfoPtr_GetAttributePSVI_Private_AttributePSVIInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665015);
			XsdValidatingReader.NativeMethodInfoPtr_GetDefaultAttribute_Private_ValidatingReaderNodeData_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665016);
			XsdValidatingReader.NativeMethodInfoPtr_GetDefaultAttribute_Private_ValidatingReaderNodeData_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665017);
			XsdValidatingReader.NativeMethodInfoPtr_AddAttributePSVI_Private_AttributePSVIInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665018);
			XsdValidatingReader.NativeMethodInfoPtr_IsXSDRoot_Private_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665019);
			XsdValidatingReader.NativeMethodInfoPtr_ProcessInlineSchema_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665020);
			XsdValidatingReader.NativeMethodInfoPtr_InternalReadContentAsObject_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665021);
			XsdValidatingReader.NativeMethodInfoPtr_InternalReadContentAsObject_Private_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665022);
			XsdValidatingReader.NativeMethodInfoPtr_InternalReadContentAsObject_Private_Object_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665023);
			XsdValidatingReader.NativeMethodInfoPtr_ReadTillEndElement_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665024);
			XsdValidatingReader.NativeMethodInfoPtr_SwitchReader_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665025);
			XsdValidatingReader.NativeMethodInfoPtr_ReadAheadForMemberType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665026);
			XsdValidatingReader.NativeMethodInfoPtr_GetIsDefault_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665027);
			XsdValidatingReader.NativeMethodInfoPtr_GetMemberType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665028);
			XsdValidatingReader.NativeMethodInfoPtr_ReturnBoxedValue_Private_Object_Object_XmlSchemaType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665029);
			XsdValidatingReader.NativeMethodInfoPtr_GetCachingReader_Private_XsdCachingReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665030);
			XsdValidatingReader.NativeMethodInfoPtr_CreateDummyTextNode_Internal_ValidatingReaderNodeData_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665031);
			XsdValidatingReader.NativeMethodInfoPtr_CachingCallBack_Internal_Void_XsdCachingReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665032);
			XsdValidatingReader.NativeMethodInfoPtr_GetOriginalAtomicValueStringOfElement_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665033);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00040E44 File Offset: 0x0003F044
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 396958, RefRangeEnd = 396960, XrefRangeStart = 396942, XrefRangeEnd = 396958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdValidatingReader(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xmlResolver);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(readerSettings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partialValidationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlResolver_XmlReaderSettings_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00040EC8 File Offset: 0x0003F0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396960, XrefRangeEnd = 396961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdValidatingReader(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xmlResolver);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(readerSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlResolver_XmlReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00040F38 File Offset: 0x0003F138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397001, RefRangeEnd = 397002, XrefRangeStart = 396961, XrefRangeEnd = 397001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00040F6C File Offset: 0x0003F16C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397017, RefRangeEnd = 397018, XrefRangeStart = 397002, XrefRangeEnd = 397017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(readerSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partialValidationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_SetupValidator_Private_Void_XmlReaderSettings_XmlReader_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00040FD4 File Offset: 0x0003F1D4
		public unsafe override XmlReaderSettings Settings
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397018, XrefRangeEnd = 397033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr3) : null;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x00041020 File Offset: 0x0003F220
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00041068 File Offset: 0x0003F268
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397033, XrefRangeEnd = 397043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x000410AC File Offset: 0x0003F2AC
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x000410F0 File Offset: 0x0003F2F0
		public unsafe override string NamespaceURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00041134 File Offset: 0x0003F334
		public unsafe override string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00041178 File Offset: 0x0003F378
		public unsafe override bool HasValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_HasValue_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x000411C0 File Offset: 0x0003F3C0
		public unsafe override string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x00041204 File Offset: 0x0003F404
		public unsafe override int Depth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0004124C File Offset: 0x0003F44C
		public unsafe override string BaseURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x00041290 File Offset: 0x0003F490
		public unsafe override bool IsEmptyElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x000412D8 File Offset: 0x0003F4D8
		public unsafe override bool IsDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00041320 File Offset: 0x0003F520
		public unsafe override IXmlSchemaInfo SchemaInfo
		{
			[CallerCount(397)]
			[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_get_IXmlSchemaInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlSchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0004136C File Offset: 0x0003F56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397043, XrefRangeEnd = 397054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadContentAsString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_ReadContentAsString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x000413B0 File Offset: 0x0003F5B0
		public unsafe override int AttributeCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x000413F8 File Offset: 0x0003F5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397054, XrefRangeEnd = 397058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00041450 File Offset: 0x0003F650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397058, XrefRangeEnd = 397065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MoveToAttribute(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0004149C File Offset: 0x0003F69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397065, XrefRangeEnd = 397066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToFirstAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x000414E4 File Offset: 0x0003F6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397066, XrefRangeEnd = 397067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToNextAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0004152C File Offset: 0x0003F72C
		[CallerCount(0)]
		public unsafe override bool MoveToElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00041574 File Offset: 0x0003F774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397067, XrefRangeEnd = 397068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x000415BC File Offset: 0x0003F7BC
		public unsafe override bool EOF
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00041604 File Offset: 0x0003F804
		[CallerCount(0)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x00041640 File Offset: 0x0003F840
		public unsafe override ReadState ReadState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00041688 File Offset: 0x0003F888
		public unsafe override XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x000416D4 File Offset: 0x0003F8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397068, XrefRangeEnd = 397072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00041728 File Offset: 0x0003F928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397072, XrefRangeEnd = 397077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResolveEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00041764 File Offset: 0x0003F964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397077, XrefRangeEnd = 397078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadAttributeValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x000417AC File Offset: 0x0003F9AC
		public unsafe virtual bool System.Xml.Schema.IXmlSchemaInfo.IsDefault
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397078, XrefRangeEnd = 397079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsDefault_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x000417E8 File Offset: 0x0003F9E8
		public unsafe virtual bool System.Xml.Schema.IXmlSchemaInfo.IsNil
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsNil_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00041824 File Offset: 0x0003FA24
		public unsafe virtual XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397079, XrefRangeEnd = 397080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_Validity_Private_Virtual_Final_New_get_XmlSchemaValidity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x00041860 File Offset: 0x0003FA60
		public unsafe virtual XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397080, XrefRangeEnd = 397085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_MemberType_Private_Virtual_Final_New_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x000418A0 File Offset: 0x0003FAA0
		public unsafe virtual XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaType_Private_Virtual_Final_New_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x000418E0 File Offset: 0x0003FAE0
		public unsafe virtual XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaElement_Private_Virtual_Final_New_get_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00041920 File Offset: 0x0003FB20
		public unsafe virtual XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaAttribute_Private_Virtual_Final_New_get_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x00041960 File Offset: 0x0003FB60
		public unsafe virtual int LineNumber
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397085, XrefRangeEnd = 397086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0004199C File Offset: 0x0003FB9C
		public unsafe virtual int LinePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397086, XrefRangeEnd = 397087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x000419D8 File Offset: 0x0003FBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397087, XrefRangeEnd = 397091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionary<string, string> System_Xml_IXmlNamespaceResolver_GetNamespacesInScope(XmlNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00041A24 File Offset: 0x0003FC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397091, XrefRangeEnd = 397095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00041A6C File Offset: 0x0003FC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397095, XrefRangeEnd = 397099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00041AB4 File Offset: 0x0003FCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetStringValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetStringValue_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00041AF4 File Offset: 0x0003FCF4
		public unsafe XmlSchemaType ElementXmlType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_get_ElementXmlType_Private_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00041B34 File Offset: 0x0003FD34
		public unsafe XmlSchemaType AttributeXmlType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_get_AttributeXmlType_Private_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x00041B74 File Offset: 0x0003FD74
		public unsafe XmlSchemaInfo AttributeSchemaInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_get_AttributeSchemaInfo_Private_get_XmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00041BB4 File Offset: 0x0003FDB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397102, RefRangeEnd = 397103, XrefRangeStart = 397099, XrefRangeEnd = 397102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessReaderEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_ProcessReaderEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00041BE8 File Offset: 0x0003FDE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397113, RefRangeEnd = 397114, XrefRangeStart = 397103, XrefRangeEnd = 397113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessElementEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_ProcessElementEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00041C1C File Offset: 0x0003FE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397114, XrefRangeEnd = 397116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEndElementEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_ProcessEndElementEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00041C50 File Offset: 0x0003FE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397116, XrefRangeEnd = 397120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_ValidateAttributes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00041C84 File Offset: 0x0003FE84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397120, RefRangeEnd = 397121, XrefRangeStart = 397120, XrefRangeEnd = 397120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAttributesInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_ClearAttributesInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00041CB8 File Offset: 0x0003FEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397121, XrefRangeEnd = 397131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributePSVIInfo GetAttributePSVI(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetAttributePSVI_Private_AttributePSVIInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributePSVIInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00041D08 File Offset: 0x0003FF08
		[CallerCount(0)]
		public unsafe AttributePSVIInfo GetAttributePSVI(string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetAttributePSVI_Private_AttributePSVIInfo_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributePSVIInfo>(intPtr3) : null;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00041D6C File Offset: 0x0003FF6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397145, RefRangeEnd = 397146, XrefRangeStart = 397131, XrefRangeEnd = 397145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updatePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetDefaultAttribute_Private_ValidatingReaderNodeData_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidatingReaderNodeData>(intPtr3) : null;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00041DCC File Offset: 0x0003FFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397146, XrefRangeEnd = 397149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attrLocalName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updatePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetDefaultAttribute_Private_ValidatingReaderNodeData_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidatingReaderNodeData>(intPtr3) : null;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00041E3C File Offset: 0x0004003C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397159, RefRangeEnd = 397160, XrefRangeStart = 397149, XrefRangeEnd = 397159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributePSVIInfo AddAttributePSVI(int attIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_AddAttributePSVI_Private_AttributePSVIInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributePSVIInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00041E88 File Offset: 0x00040088
		[CallerCount(0)]
		public unsafe bool IsXSDRoot(string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_IsXSDRoot_Private_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00041EE8 File Offset: 0x000400E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397160, XrefRangeEnd = 397165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessInlineSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_ProcessInlineSchema_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00041F1C File Offset: 0x0004011C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397165, XrefRangeEnd = 397166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InternalReadContentAsObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_InternalReadContentAsObject_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00041F5C File Offset: 0x0004015C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397166, XrefRangeEnd = 397167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InternalReadContentAsObject(bool unwrapTypedValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unwrapTypedValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_InternalReadContentAsObject_Private_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00041FA8 File Offset: 0x000401A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 397172, RefRangeEnd = 397175, XrefRangeStart = 397167, XrefRangeEnd = 397172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InternalReadContentAsObject(bool unwrapTypedValue, out string originalStringValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unwrapTypedValue;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_InternalReadContentAsObject_Private_Object_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			originalStringValue = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Object>(intPtr4) : null;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00042010 File Offset: 0x00040210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397180, RefRangeEnd = 397181, XrefRangeStart = 397175, XrefRangeEnd = 397180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadTillEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_ReadTillEndElement_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00042050 File Offset: 0x00040250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397181, XrefRangeEnd = 397183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchReader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_SwitchReader_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00042084 File Offset: 0x00040284
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 397201, RefRangeEnd = 397204, XrefRangeStart = 397183, XrefRangeEnd = 397201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadAheadForMemberType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_ReadAheadForMemberType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x000420B8 File Offset: 0x000402B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397228, RefRangeEnd = 397229, XrefRangeStart = 397204, XrefRangeEnd = 397228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIsDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetIsDefault_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x000420EC File Offset: 0x000402EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397229, XrefRangeEnd = 397234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMemberType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetMemberType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00042120 File Offset: 0x00040320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397239, RefRangeEnd = 397240, XrefRangeStart = 397234, XrefRangeEnd = 397239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReturnBoxedValue(Object typedValue, XmlSchemaType xmlType, bool unWrap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typedValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unWrap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_ReturnBoxedValue_Private_Object_Object_XmlSchemaType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00042190 File Offset: 0x00040390
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 397251, RefRangeEnd = 397254, XrefRangeStart = 397240, XrefRangeEnd = 397251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdCachingReader GetCachingReader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetCachingReader_Private_XsdCachingReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XsdCachingReader>(intPtr3) : null;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x000421D0 File Offset: 0x000403D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397254, XrefRangeEnd = 397258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attributeValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_CreateDummyTextNode_Internal_ValidatingReaderNodeData_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidatingReaderNodeData>(intPtr3) : null;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00042230 File Offset: 0x00040430
		[CallerCount(0)]
		public unsafe void CachingCallBack(XsdCachingReader cachingReader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cachingReader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_CachingCallBack_Internal_Void_XsdCachingReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00042274 File Offset: 0x00040474
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 397260, RefRangeEnd = 397263, XrefRangeStart = 397258, XrefRangeEnd = 397260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetOriginalAtomicValueStringOfElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetOriginalAtomicValueStringOfElement_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0000597A File Offset: 0x00003B7A
		public XsdValidatingReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x000422AC File Offset: 0x000404AC
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00005983 File Offset: 0x00003B83
		public unsafe XmlReader coreReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_coreReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_coreReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x000422DC File Offset: 0x000404DC
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x000059A2 File Offset: 0x00003BA2
		public unsafe IXmlNamespaceResolver coreReaderNSResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_coreReaderNSResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_coreReaderNSResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0004230C File Offset: 0x0004050C
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x000059C1 File Offset: 0x00003BC1
		public unsafe IXmlNamespaceResolver thisNSResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_thisNSResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_thisNSResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0004233C File Offset: 0x0004053C
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x000059E0 File Offset: 0x00003BE0
		public unsafe XmlSchemaValidator validator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_validator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaValidator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_validator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0004236C File Offset: 0x0004056C
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x000059FF File Offset: 0x00003BFF
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0004239C File Offset: 0x0004059C
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00005A1E File Offset: 0x00003C1E
		public unsafe ValidationEventHandler validationEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_validationEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_validationEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x000423CC File Offset: 0x000405CC
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00005A3D File Offset: 0x00003C3D
		public unsafe XsdValidatingReader.ValidatingReaderState validationState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_validationState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_validationState)) = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x000423F4 File Offset: 0x000405F4
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x00005A58 File Offset: 0x00003C58
		public unsafe XmlValueGetter valueGetter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_valueGetter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueGetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_valueGetter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x00042424 File Offset: 0x00040624
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x00005A77 File Offset: 0x00003C77
		public unsafe XmlNamespaceManager nsManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_nsManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_nsManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00042454 File Offset: 0x00040654
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00005A96 File Offset: 0x00003C96
		public unsafe bool manageNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_manageNamespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_manageNamespaces)) = value;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0004247C File Offset: 0x0004067C
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x00005AB1 File Offset: 0x00003CB1
		public unsafe bool processInlineSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_processInlineSchema);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_processInlineSchema)) = value;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x000424A4 File Offset: 0x000406A4
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x00005ACC File Offset: 0x00003CCC
		public unsafe bool replayCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_replayCache);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_replayCache)) = value;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x000424CC File Offset: 0x000406CC
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x00005AE7 File Offset: 0x00003CE7
		public unsafe ValidatingReaderNodeData cachedNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_cachedNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidatingReaderNodeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_cachedNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x000424FC File Offset: 0x000406FC
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00005B06 File Offset: 0x00003D06
		public unsafe AttributePSVIInfo attributePSVI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_attributePSVI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributePSVIInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_attributePSVI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0004252C File Offset: 0x0004072C
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00005B25 File Offset: 0x00003D25
		public unsafe int attributeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_attributeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_attributeCount)) = value;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00042554 File Offset: 0x00040754
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00005B40 File Offset: 0x00003D40
		public unsafe int coreReaderAttributeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_coreReaderAttributeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_coreReaderAttributeCount)) = value;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0004257C File Offset: 0x0004077C
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00005B5B File Offset: 0x00003D5B
		public unsafe int currentAttrIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_currentAttrIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_currentAttrIndex)) = value;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x000425A4 File Offset: 0x000407A4
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x00005B76 File Offset: 0x00003D76
		public unsafe Il2CppReferenceArray<AttributePSVIInfo> attributePSVINodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_attributePSVINodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AttributePSVIInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_attributePSVINodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x000425D4 File Offset: 0x000407D4
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x00005B95 File Offset: 0x00003D95
		public unsafe ArrayList defaultAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_defaultAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_defaultAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00042604 File Offset: 0x00040804
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00005BB4 File Offset: 0x00003DB4
		public unsafe Parser inlineSchemaParser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_inlineSchemaParser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Parser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_inlineSchemaParser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00042634 File Offset: 0x00040834
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x00005BD3 File Offset: 0x00003DD3
		public unsafe Object atomicValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_atomicValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_atomicValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00042664 File Offset: 0x00040864
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x00005BF2 File Offset: 0x00003DF2
		public unsafe XmlSchemaInfo xmlSchemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_xmlSchemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_xmlSchemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00042694 File Offset: 0x00040894
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x00005C11 File Offset: 0x00003E11
		public unsafe string originalAtomicValueString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_originalAtomicValueString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_originalAtomicValueString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x000426BC File Offset: 0x000408BC
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x00005C30 File Offset: 0x00003E30
		public unsafe XmlNameTable coreReaderNameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_coreReaderNameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_coreReaderNameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x000426EC File Offset: 0x000408EC
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x00005C4F File Offset: 0x00003E4F
		public unsafe XsdCachingReader cachingReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_cachingReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XsdCachingReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_cachingReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x0004271C File Offset: 0x0004091C
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x00005C6E File Offset: 0x00003E6E
		public unsafe ValidatingReaderNodeData textNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_textNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidatingReaderNodeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_textNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x0004274C File Offset: 0x0004094C
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x00005C8D File Offset: 0x00003E8D
		public unsafe string NsXmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_NsXmlNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_NsXmlNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00042774 File Offset: 0x00040974
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x00005CAC File Offset: 0x00003EAC
		public unsafe string NsXs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_NsXs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_NsXs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0004279C File Offset: 0x0004099C
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x00005CCB File Offset: 0x00003ECB
		public unsafe string NsXsi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_NsXsi);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_NsXsi), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x000427C4 File Offset: 0x000409C4
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00005CEA File Offset: 0x00003EEA
		public unsafe string XsiType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsiType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsiType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x000427EC File Offset: 0x000409EC
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00005D09 File Offset: 0x00003F09
		public unsafe string XsiNil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsiNil);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsiNil), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00042814 File Offset: 0x00040A14
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00005D28 File Offset: 0x00003F28
		public unsafe string XsdSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsdSchema);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsdSchema), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x0004283C File Offset: 0x00040A3C
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x00005D47 File Offset: 0x00003F47
		public unsafe string XsiSchemaLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsiSchemaLocation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsiSchemaLocation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00042864 File Offset: 0x00040A64
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x00005D66 File Offset: 0x00003F66
		public unsafe string XsiNoNamespaceSchemaLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x0004288C File Offset: 0x00040A8C
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x00005D85 File Offset: 0x00003F85
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x000428BC File Offset: 0x00040ABC
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x00005DB3 File Offset: 0x00003FB3
		public unsafe IXmlLineInfo lineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_lineInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlLineInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_lineInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x000428EC File Offset: 0x00040AEC
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x00005DD2 File Offset: 0x00003FD2
		public unsafe ReadContentAsBinaryHelper readBinaryHelper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_readBinaryHelper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadContentAsBinaryHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_readBinaryHelper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x0004291C File Offset: 0x00040B1C
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x00005DF1 File Offset: 0x00003FF1
		public unsafe XsdValidatingReader.ValidatingReaderState savedState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_savedState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_savedState)) = value;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x00042944 File Offset: 0x00040B44
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x00005E0C File Offset: 0x0000400C
		public unsafe static Type TypeOfString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdValidatingReader.NativeFieldInfoPtr_TypeOfString, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdValidatingReader.NativeFieldInfoPtr_TypeOfString, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeFieldInfoPtr_coreReader;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeFieldInfoPtr_coreReaderNSResolver;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeFieldInfoPtr_thisNSResolver;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeFieldInfoPtr_validator;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeFieldInfoPtr_validationEvent;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeFieldInfoPtr_validationState;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeFieldInfoPtr_valueGetter;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeFieldInfoPtr_nsManager;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeFieldInfoPtr_manageNamespaces;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeFieldInfoPtr_processInlineSchema;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeFieldInfoPtr_replayCache;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeFieldInfoPtr_cachedNode;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeFieldInfoPtr_attributePSVI;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeFieldInfoPtr_attributeCount;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeFieldInfoPtr_coreReaderAttributeCount;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeFieldInfoPtr_currentAttrIndex;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeFieldInfoPtr_attributePSVINodes;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeFieldInfoPtr_defaultAttributes;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeFieldInfoPtr_inlineSchemaParser;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeFieldInfoPtr_atomicValue;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeFieldInfoPtr_xmlSchemaInfo;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeFieldInfoPtr_originalAtomicValueString;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeFieldInfoPtr_coreReaderNameTable;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeFieldInfoPtr_cachingReader;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeFieldInfoPtr_textNode;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeFieldInfoPtr_NsXmlNs;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeFieldInfoPtr_NsXs;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeFieldInfoPtr_NsXsi;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeFieldInfoPtr_XsiType;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeFieldInfoPtr_XsiNil;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeFieldInfoPtr_XsdSchema;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeFieldInfoPtr_XsiSchemaLocation;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeFieldInfoPtr_lineInfo;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeFieldInfoPtr_readBinaryHelper;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeFieldInfoPtr_savedState;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeFieldInfoPtr_TypeOfString;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlResolver_XmlReaderSettings_XmlSchemaObject_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlResolver_XmlReaderSettings_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_SetupValidator_Private_Void_XmlReaderSettings_XmlReader_XmlSchemaObject_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValue_Public_Virtual_get_Boolean_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_get_IXmlSchemaInfo_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_ReadContentAsString_Public_Virtual_String_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsDefault_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsNil_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_Validity_Private_Virtual_Final_New_get_XmlSchemaValidity_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_MemberType_Private_Virtual_Final_New_get_XmlSchemaSimpleType_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaType_Private_Virtual_Final_New_get_XmlSchemaType_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaElement_Private_Virtual_Final_New_get_XmlSchemaElement_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaAttribute_Private_Virtual_Final_New_get_XmlSchemaAttribute_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_GetStringValue_Private_Object_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementXmlType_Private_get_XmlSchemaType_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeXmlType_Private_get_XmlSchemaType_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeSchemaInfo_Private_get_XmlSchemaInfo_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_ProcessReaderEvent_Private_Void_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_ProcessElementEvent_Private_Void_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEndElementEvent_Private_Void_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAttributes_Private_Void_0;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_ClearAttributesInfo_Private_Void_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributePSVI_Private_AttributePSVIInfo_String_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributePSVI_Private_AttributePSVIInfo_String_String_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultAttribute_Private_ValidatingReaderNodeData_String_Boolean_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultAttribute_Private_ValidatingReaderNodeData_String_String_Boolean_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributePSVI_Private_AttributePSVIInfo_Int32_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_IsXSDRoot_Private_Boolean_String_String_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_ProcessInlineSchema_Private_Void_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_InternalReadContentAsObject_Private_Object_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_InternalReadContentAsObject_Private_Object_Boolean_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_InternalReadContentAsObject_Private_Object_Boolean_byref_String_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_ReadTillEndElement_Private_Object_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_SwitchReader_Private_Void_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_ReadAheadForMemberType_Private_Void_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_GetIsDefault_Private_Void_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberType_Private_Void_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_ReturnBoxedValue_Private_Object_Object_XmlSchemaType_Boolean_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_GetCachingReader_Private_XsdCachingReader_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_CreateDummyTextNode_Internal_ValidatingReaderNodeData_String_Int32_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_CachingCallBack_Internal_Void_XsdCachingReader_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginalAtomicValueStringOfElement_Private_String_0;

		// Token: 0x0200021B RID: 539
		[OriginalName("System.Xml.dll", "", "ValidatingReaderState")]
		public enum ValidatingReaderState
		{
			// Token: 0x040021C6 RID: 8646
			None,
			// Token: 0x040021C7 RID: 8647
			Init,
			// Token: 0x040021C8 RID: 8648
			Read,
			// Token: 0x040021C9 RID: 8649
			OnDefaultAttribute = -1,
			// Token: 0x040021CA RID: 8650
			OnReadAttributeValue = -2,
			// Token: 0x040021CB RID: 8651
			OnAttribute = 3,
			// Token: 0x040021CC RID: 8652
			ClearAttributes,
			// Token: 0x040021CD RID: 8653
			ParseInlineSchema,
			// Token: 0x040021CE RID: 8654
			ReadAhead,
			// Token: 0x040021CF RID: 8655
			OnReadBinaryContent,
			// Token: 0x040021D0 RID: 8656
			ReaderClosed,
			// Token: 0x040021D1 RID: 8657
			EOF,
			// Token: 0x040021D2 RID: 8658
			Error
		}
	}
}
