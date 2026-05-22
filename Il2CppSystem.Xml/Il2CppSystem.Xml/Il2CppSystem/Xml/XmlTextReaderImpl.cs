using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;
using Il2CppSystem.Threading.Tasks;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000057 RID: 87
	public class XmlTextReaderImpl : XmlReader
	{
		// Token: 0x06000636 RID: 1590 RVA: 0x0002E83C File Offset: 0x0002CA3C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTextReaderImpl()
		{
			Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlTextReaderImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr);
			XmlTextReaderImpl.NativeFieldInfoPtr_useAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "useAsync");
			XmlTextReaderImpl.NativeFieldInfoPtr_laterInitParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "laterInitParam");
			XmlTextReaderImpl.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "xmlCharType");
			XmlTextReaderImpl.NativeFieldInfoPtr_ps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "ps");
			XmlTextReaderImpl.NativeFieldInfoPtr_parsingFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "parsingFunction");
			XmlTextReaderImpl.NativeFieldInfoPtr_nextParsingFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nextParsingFunction");
			XmlTextReaderImpl.NativeFieldInfoPtr_nextNextParsingFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nextNextParsingFunction");
			XmlTextReaderImpl.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nodes");
			XmlTextReaderImpl.NativeFieldInfoPtr_curNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "curNode");
			XmlTextReaderImpl.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "index");
			XmlTextReaderImpl.NativeFieldInfoPtr_curAttrIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "curAttrIndex");
			XmlTextReaderImpl.NativeFieldInfoPtr_attrCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attrCount");
			XmlTextReaderImpl.NativeFieldInfoPtr_attrHashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attrHashtable");
			XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplWalkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attrDuplWalkCount");
			XmlTextReaderImpl.NativeFieldInfoPtr_attrNeedNamespaceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attrNeedNamespaceLookup");
			XmlTextReaderImpl.NativeFieldInfoPtr_fullAttrCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "fullAttrCleanup");
			XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplSortingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attrDuplSortingArray");
			XmlTextReaderImpl.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nameTable");
			XmlTextReaderImpl.NativeFieldInfoPtr_nameTableFromSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nameTableFromSettings");
			XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "xmlResolver");
			XmlTextReaderImpl.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "url");
			XmlTextReaderImpl.NativeFieldInfoPtr_normalize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "normalize");
			XmlTextReaderImpl.NativeFieldInfoPtr_supportNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "supportNamespaces");
			XmlTextReaderImpl.NativeFieldInfoPtr_whitespaceHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "whitespaceHandling");
			XmlTextReaderImpl.NativeFieldInfoPtr_dtdProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "dtdProcessing");
			XmlTextReaderImpl.NativeFieldInfoPtr_entityHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "entityHandling");
			XmlTextReaderImpl.NativeFieldInfoPtr_ignorePIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "ignorePIs");
			XmlTextReaderImpl.NativeFieldInfoPtr_ignoreComments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "ignoreComments");
			XmlTextReaderImpl.NativeFieldInfoPtr_checkCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "checkCharacters");
			XmlTextReaderImpl.NativeFieldInfoPtr_lineNumberOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "lineNumberOffset");
			XmlTextReaderImpl.NativeFieldInfoPtr_linePositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "linePositionOffset");
			XmlTextReaderImpl.NativeFieldInfoPtr_closeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "closeInput");
			XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersInDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "maxCharactersInDocument");
			XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersFromEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "maxCharactersFromEntities");
			XmlTextReaderImpl.NativeFieldInfoPtr_v1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "v1Compat");
			XmlTextReaderImpl.NativeFieldInfoPtr_namespaceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "namespaceManager");
			XmlTextReaderImpl.NativeFieldInfoPtr_lastPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "lastPrefix");
			XmlTextReaderImpl.NativeFieldInfoPtr_xmlContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "xmlContext");
			XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "parsingStatesStack");
			XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStackTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "parsingStatesStackTop");
			XmlTextReaderImpl.NativeFieldInfoPtr_reportedBaseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "reportedBaseUri");
			XmlTextReaderImpl.NativeFieldInfoPtr_reportedEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "reportedEncoding");
			XmlTextReaderImpl.NativeFieldInfoPtr_dtdInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "dtdInfo");
			XmlTextReaderImpl.NativeFieldInfoPtr_fragmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "fragmentType");
			XmlTextReaderImpl.NativeFieldInfoPtr_fragmentParserContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "fragmentParserContext");
			XmlTextReaderImpl.NativeFieldInfoPtr_fragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "fragment");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadDecoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadDecoder");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadState");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadLineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadLineInfo");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadDepth");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadLeftStartPos");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftEndPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadLeftEndPos");
			XmlTextReaderImpl.NativeFieldInfoPtr_attributeValueBaseEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attributeValueBaseEntityId");
			XmlTextReaderImpl.NativeFieldInfoPtr_emptyEntityInAttributeResolved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "emptyEntityInAttributeResolved");
			XmlTextReaderImpl.NativeFieldInfoPtr_validationEventHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "validationEventHandling");
			XmlTextReaderImpl.NativeFieldInfoPtr_onDefaultAttributeUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "onDefaultAttributeUse");
			XmlTextReaderImpl.NativeFieldInfoPtr_validatingReaderCompatFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "validatingReaderCompatFlag");
			XmlTextReaderImpl.NativeFieldInfoPtr_addDefaultAttributesAndNormalize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "addDefaultAttributesAndNormalize");
			XmlTextReaderImpl.NativeFieldInfoPtr_stringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "stringBuilder");
			XmlTextReaderImpl.NativeFieldInfoPtr_rootElementParsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "rootElementParsed");
			XmlTextReaderImpl.NativeFieldInfoPtr_standalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "standalone");
			XmlTextReaderImpl.NativeFieldInfoPtr_nextEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nextEntityId");
			XmlTextReaderImpl.NativeFieldInfoPtr_parsingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "parsingMode");
			XmlTextReaderImpl.NativeFieldInfoPtr_readState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "readState");
			XmlTextReaderImpl.NativeFieldInfoPtr_lastEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "lastEntity");
			XmlTextReaderImpl.NativeFieldInfoPtr_afterResetState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "afterResetState");
			XmlTextReaderImpl.NativeFieldInfoPtr_documentStartBytePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "documentStartBytePos");
			XmlTextReaderImpl.NativeFieldInfoPtr_readValueOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "readValueOffset");
			XmlTextReaderImpl.NativeFieldInfoPtr_charactersInDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "charactersInDocument");
			XmlTextReaderImpl.NativeFieldInfoPtr_charactersFromEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "charactersFromEntities");
			XmlTextReaderImpl.NativeFieldInfoPtr_currentEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "currentEntities");
			XmlTextReaderImpl.NativeFieldInfoPtr_disableUndeclaredEntityCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "disableUndeclaredEntityCheck");
			XmlTextReaderImpl.NativeFieldInfoPtr_outerReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "outerReader");
			XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolverIsSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "xmlResolverIsSet");
			XmlTextReaderImpl.NativeFieldInfoPtr_Xml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "Xml");
			XmlTextReaderImpl.NativeFieldInfoPtr_XmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "XmlNs");
			XmlTextReaderImpl.NativeFieldInfoPtr_parseText_dummyTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "parseText_dummyTask");
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664225);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Private_Void_XmlResolver_XmlReaderSettings_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664226);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_Stream_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664227);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664228);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_TextReader_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664229);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_XmlNodeType_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664230);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664231);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitUriString_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664232);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_Stream_Il2CppStructArray_1_Byte_Int32_XmlReaderSettings_Uri_String_XmlParserContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664233);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitStream_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664234);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_XmlReaderSettings_String_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664235);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitTextReader_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664236);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664237);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664238);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664239);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664240);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664241);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664242);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664243);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664244);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664245);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664246);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664247);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664248);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664249);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664250);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664251);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664252);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664253);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664254);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664255);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664256);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664257);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664258);
			XmlTextReaderImpl.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664259);
			XmlTextReaderImpl.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664260);
			XmlTextReaderImpl.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664261);
			XmlTextReaderImpl.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664262);
			XmlTextReaderImpl.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664263);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_OuterReader_Internal_set_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664264);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664265);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664266);
			XmlTextReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664267);
			XmlTextReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664268);
			XmlTextReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664269);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetNamespacesInScope_Internal_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664270);
			XmlTextReaderImpl.NativeMethodInfoPtr_LookupPrefix_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664271);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_Namespaces_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664272);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_EntityHandling_Internal_set_Void_EntityHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664273);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_IsResolverSet_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664274);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664275);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_NameTable_Internal_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664276);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_NamespaceResolver_Internal_get_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664277);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_DtdValidation_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664278);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_Normalization_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664279);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_Namespaces_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664280);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_V1CompatibilityMode_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664281);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_BaseUri_Internal_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664282);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_IsEof_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664283);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ParsingBuffer_Internal_get_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664284);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ParsingBufferLength_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664285);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_CurrentPosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664286);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_DtdParserProxy_CurrentPosition_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664287);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_EntityStackLength_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664288);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_IsEntityEolNormalized_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664289);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ValidationEventHandling_Internal_get_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664290);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnNewLine_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664291);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_LineNo_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664292);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_LineStartPosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664293);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ReadData_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664294);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseNumericCharRef_Internal_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664295);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseNamedCharRef_Internal_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664296);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParsePI_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664297);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseComment_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664298);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_IsResolverNull_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664299);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetTempResolver_Private_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664300);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushEntity_Internal_Boolean_IDtdEntityInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664301);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PopEntity_Internal_Boolean_byref_IDtdEntityInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664302);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushExternalSubset_Internal_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664303);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushInternalDtd_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664304);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_Throw_Internal_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664305);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnSystemId_Internal_Void_String_LineInfo_LineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664306);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnPublicId_Internal_Void_String_LineInfo_LineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664307);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664308);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664309);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664310);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664311);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664312);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664313);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664314);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664315);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664316);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664317);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664318);
			XmlTextReaderImpl.NativeMethodInfoPtr_ReThrow_Private_Void_Exception_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664319);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664320);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664321);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_Il2CppStringArray_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664322);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664323);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetErrorState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664324);
			XmlTextReaderImpl.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664325);
			XmlTextReaderImpl.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664326);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_InAttributeValueIterator_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664327);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishAttributeValueIterator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664328);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdValidation_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664329);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664330);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_String_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664331);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664332);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664333);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Il2CppStructArray_1_Byte_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664334);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664335);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_Uri_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664336);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitStringInput_Private_Void_String_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664337);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitFragmentReader_Private_Void_XmlNodeType_XmlParserContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664338);
			XmlTextReaderImpl.NativeMethodInfoPtr_ProcessDtdFromParserContext_Private_Void_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664339);
			XmlTextReaderImpl.NativeMethodInfoPtr_OpenUrl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664340);
			XmlTextReaderImpl.NativeMethodInfoPtr_OpenUrlDelegate_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664341);
			XmlTextReaderImpl.NativeMethodInfoPtr_DetectEncoding_Private_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664342);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetupEncoding_Private_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664343);
			XmlTextReaderImpl.NativeMethodInfoPtr_SwitchEncoding_Private_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664344);
			XmlTextReaderImpl.NativeMethodInfoPtr_CheckEncoding_Private_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664345);
			XmlTextReaderImpl.NativeMethodInfoPtr_UnDecodeChars_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664346);
			XmlTextReaderImpl.NativeMethodInfoPtr_SwitchEncodingToUTF8_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664347);
			XmlTextReaderImpl.NativeMethodInfoPtr_ReadData_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664348);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetChars_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664349);
			XmlTextReaderImpl.NativeMethodInfoPtr_InvalidCharRecovery_Private_Void_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664350);
			XmlTextReaderImpl.NativeMethodInfoPtr_Close_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664351);
			XmlTextReaderImpl.NativeMethodInfoPtr_ShiftBuffer_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664352);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseXmlDeclaration_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664353);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseDocumentContent_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664354);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseElementContent_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664355);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnclosedElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664356);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664357);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributesAndNormalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664358);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseEndElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664359);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowTagMismatch_Private_Void_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664360);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664361);
			XmlTextReaderImpl.NativeMethodInfoPtr_ElementNamespaceLookup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664362);
			XmlTextReaderImpl.NativeMethodInfoPtr_AttributeNamespaceLookup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664363);
			XmlTextReaderImpl.NativeMethodInfoPtr_AttributeDuplCheck_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664364);
			XmlTextReaderImpl.NativeMethodInfoPtr_OnDefaultNamespaceDecl_Private_Void_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664365);
			XmlTextReaderImpl.NativeMethodInfoPtr_OnNamespaceDecl_Private_Void_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664366);
			XmlTextReaderImpl.NativeMethodInfoPtr_OnXmlReservedAttribute_Private_Void_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664367);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributeValueSlow_Private_Void_Int32_Char_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664368);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddAttributeChunkToList_Private_Void_NodeData_NodeData_byref_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664369);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseText_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664370);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseText_Private_Boolean_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664371);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishPartialValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664372);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishOtherValueIterator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664373);
			XmlTextReaderImpl.NativeMethodInfoPtr_SkipPartialTextValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664374);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadValueChunk_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664375);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadContentAsBinary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664376);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadElementContentAsBinary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664377);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseRootLevelWhitespace_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664378);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseEntityReference_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664379);
			XmlTextReaderImpl.NativeMethodInfoPtr_HandleEntityReference_Private_EntityType_Boolean_EntityExpandType_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664380);
			XmlTextReaderImpl.NativeMethodInfoPtr_HandleGeneralEntityReference_Private_EntityType_String_Boolean_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664381);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_InEntity_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664382);
			XmlTextReaderImpl.NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664383);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetupEndEntityNodeInContent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664384);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetupEndEntityNodeInAttribute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664385);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParsePI_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664386);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParsePI_Private_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664387);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParsePIValue_Private_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664388);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseComment_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664389);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseCData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664390);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseCDataOrComment_Private_Void_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664391);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseCDataOrComment_Private_Boolean_XmlNodeType_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664392);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseDoctypeDecl_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664393);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseDtd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664394);
			XmlTextReaderImpl.NativeMethodInfoPtr_SkipDtd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664395);
			XmlTextReaderImpl.NativeMethodInfoPtr_SkipPublicOrSystemIdLiteral_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664396);
			XmlTextReaderImpl.NativeMethodInfoPtr_SkipUntil_Private_Void_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664397);
			XmlTextReaderImpl.NativeMethodInfoPtr_EatWhitespaces_Private_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664398);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseCharRefInline_Private_Int32_Int32_byref_Int32_byref_EntityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664399);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseNumericCharRef_Private_Int32_Boolean_StringBuilder_byref_EntityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664400);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseNumericCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_byref_Int32_byref_EntityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664401);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseNamedCharRef_Private_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664402);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseNamedCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664403);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseName_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664404);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseQName_Private_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664405);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseQName_Private_Int32_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664406);
			XmlTextReaderImpl.NativeMethodInfoPtr_ReadDataInName_Private_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664407);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseEntityName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664408);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddNode_Private_NodeData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664409);
			XmlTextReaderImpl.NativeMethodInfoPtr_AllocNode_Private_NodeData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664410);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddAttributeNoChecks_Private_NodeData_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664411);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddAttribute_Private_NodeData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664412);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddAttribute_Private_NodeData_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664413);
			XmlTextReaderImpl.NativeMethodInfoPtr_PopElementContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664414);
			XmlTextReaderImpl.NativeMethodInfoPtr_OnNewLine_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664415);
			XmlTextReaderImpl.NativeMethodInfoPtr_OnEof_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664416);
			XmlTextReaderImpl.NativeMethodInfoPtr_LookupNamespace_Private_String_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664417);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664418);
			XmlTextReaderImpl.NativeMethodInfoPtr_ResetAttributes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664419);
			XmlTextReaderImpl.NativeMethodInfoPtr_FullAttributeCleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664420);
			XmlTextReaderImpl.NativeMethodInfoPtr_PushXmlContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664421);
			XmlTextReaderImpl.NativeMethodInfoPtr_PopXmlContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664422);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetWhitespaceType_Private_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664423);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetTextNodeType_Private_XmlNodeType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664424);
			XmlTextReaderImpl.NativeMethodInfoPtr_PushExternalEntityOrSubset_Private_Void_String_String_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664425);
			XmlTextReaderImpl.NativeMethodInfoPtr_OpenAndPush_Private_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664426);
			XmlTextReaderImpl.NativeMethodInfoPtr_PushExternalEntity_Private_Boolean_IDtdEntityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664427);
			XmlTextReaderImpl.NativeMethodInfoPtr_PushInternalEntity_Private_Void_IDtdEntityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664428);
			XmlTextReaderImpl.NativeMethodInfoPtr_PopEntity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664429);
			XmlTextReaderImpl.NativeMethodInfoPtr_RegisterEntity_Private_Void_IDtdEntityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664430);
			XmlTextReaderImpl.NativeMethodInfoPtr_UnregisterEntity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664431);
			XmlTextReaderImpl.NativeMethodInfoPtr_PushParsingState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664432);
			XmlTextReaderImpl.NativeMethodInfoPtr_PopParsingState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664433);
			XmlTextReaderImpl.NativeMethodInfoPtr_IncrementalRead_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664434);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishIncrementalRead_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664435);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseFragmentAttribute_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664436);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributeValueChunk_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664437);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseXmlDeclarationFragment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664438);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664439);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664440);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664441);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664442);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664443);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664444);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowExpectingWhitespace_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664445);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetIndexOfAttributeWithoutPrefix_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664446);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetIndexOfAttributeWithPrefix_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664447);
			XmlTextReaderImpl.NativeMethodInfoPtr_ZeroEndingStream_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664448);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseDtdFromParserContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664449);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToNextContentNode_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664450);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetupFromParserContext_Private_Void_XmlParserContext_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664451);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_get_IDtdInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664452);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetDtdInfo_Internal_Void_IDtdInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664453);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_ValidationEventHandling_Internal_set_Void_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664454);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_OnDefaultAttributeUse_Internal_set_Void_OnDefaultAttributeUseDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664455);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_XmlValidatingReaderCompatibilityMode_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664456);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_FragmentType_Internal_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664457);
			XmlTextReaderImpl.NativeMethodInfoPtr_ChangeCurrentNodeType_Internal_Void_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664458);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664459);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_InternalSchemaType_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664460);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_InternalTypedValue_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664461);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_InternalTypedValue_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664462);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_StandAlone_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664463);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_NamespaceManager_Internal_Virtual_get_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664464);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_V1Compat_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664465);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributeDtd_Private_Boolean_IDtdDefaultAttributeInfo_Boolean_Il2CppReferenceArray_1_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664466);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributeNonDtd_Internal_Boolean_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664467);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributeInternal_Private_NodeData_String_String_String_String_Int32_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664468);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_DisableUndeclaredEntityCheck_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664469);
			XmlTextReaderImpl.NativeMethodInfoPtr_UriEqual_Private_Boolean_Uri_String_String_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664470);
			XmlTextReaderImpl.NativeMethodInfoPtr_RegisterConsumedCharacters_Private_Void_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664471);
			XmlTextReaderImpl.NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664472);
			XmlTextReaderImpl.NativeMethodInfoPtr_StripSpaces_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664473);
			XmlTextReaderImpl.NativeMethodInfoPtr_BlockCopyChars_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664474);
			XmlTextReaderImpl.NativeMethodInfoPtr_BlockCopy_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664475);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0003020C File Offset: 0x0002E40C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 392425, RefRangeEnd = 392430, XrefRangeStart = 392378, XrefRangeEnd = 392425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(XmlNameTable nt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00030258 File Offset: 0x0002E458
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 392484, RefRangeEnd = 392486, XrefRangeStart = 392430, XrefRangeEnd = 392484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Private_Void_XmlResolver_XmlReaderSettings_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x000302C8 File Offset: 0x0002E4C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392494, RefRangeEnd = 392495, XrefRangeStart = 392486, XrefRangeEnd = 392494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(string url, Stream input, XmlNameTable nt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_Stream_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00030338 File Offset: 0x0002E538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392495, XrefRangeEnd = 392498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(TextReader input, XmlNameTable nt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00030398 File Offset: 0x0002E598
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 392506, RefRangeEnd = 392509, XrefRangeStart = 392498, XrefRangeEnd = 392506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(string url, TextReader input, XmlNameTable nt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_TextReader_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00030408 File Offset: 0x0002E608
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 392520, RefRangeEnd = 392522, XrefRangeStart = 392509, XrefRangeEnd = 392520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(string xmlFragment, XmlNodeType fragType, XmlParserContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlFragment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fragType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_XmlNodeType_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00030474 File Offset: 0x0002E674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392522, XrefRangeEnd = 392538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(string xmlFragment, XmlParserContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlFragment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000304D4 File Offset: 0x0002E6D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392559, RefRangeEnd = 392560, XrefRangeStart = 392538, XrefRangeEnd = 392559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishInitUriString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitUriString_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00030508 File Offset: 0x0002E708
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 392571, RefRangeEnd = 392573, XrefRangeStart = 392560, XrefRangeEnd = 392571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(Stream stream, Il2CppStructArray<byte> bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref closeInput;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_Stream_Il2CppStructArray_1_Byte_Int32_XmlReaderSettings_Uri_String_XmlParserContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x000305D0 File Offset: 0x0002E7D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392577, RefRangeEnd = 392578, XrefRangeStart = 392573, XrefRangeEnd = 392577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishInitStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitStream_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00030604 File Offset: 0x0002E804
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 392582, RefRangeEnd = 392584, XrefRangeStart = 392578, XrefRangeEnd = 392582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_XmlReaderSettings_String_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00030688 File Offset: 0x0002E888
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 392587, RefRangeEnd = 392589, XrefRangeStart = 392584, XrefRangeEnd = 392587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishInitTextReader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitTextReader_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x000306BC File Offset: 0x0002E8BC
		public unsafe override XmlReaderSettings Settings
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392589, XrefRangeEnd = 392632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00030708 File Offset: 0x0002E908
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x00030750 File Offset: 0x0002E950
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392632, XrefRangeEnd = 392634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00030794 File Offset: 0x0002E994
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x000307D8 File Offset: 0x0002E9D8
		public unsafe override string NamespaceURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x0003081C File Offset: 0x0002EA1C
		public unsafe override string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00030860 File Offset: 0x0002EA60
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392634, XrefRangeEnd = 392649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x000308A4 File Offset: 0x0002EAA4
		public unsafe override int Depth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x000308EC File Offset: 0x0002EAEC
		public unsafe override string BaseURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00030930 File Offset: 0x0002EB30
		public unsafe override bool IsEmptyElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00030978 File Offset: 0x0002EB78
		public unsafe override bool IsDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x000309C0 File Offset: 0x0002EBC0
		public unsafe override ReadState ReadState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00030A08 File Offset: 0x0002EC08
		public unsafe override bool EOF
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00030A50 File Offset: 0x0002EC50
		public unsafe override XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00030A9C File Offset: 0x0002EC9C
		public unsafe override bool CanResolveEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x00030AE4 File Offset: 0x0002ECE4
		public unsafe override int AttributeCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00030B2C File Offset: 0x0002ED2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392649, XrefRangeEnd = 392651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00030B84 File Offset: 0x0002ED84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392651, XrefRangeEnd = 392662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MoveToAttribute(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00030BD0 File Offset: 0x0002EDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392662, XrefRangeEnd = 392663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToFirstAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00030C18 File Offset: 0x0002EE18
		[CallerCount(0)]
		public unsafe override bool MoveToNextAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00030C60 File Offset: 0x0002EE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392663, XrefRangeEnd = 392665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00030CA8 File Offset: 0x0002EEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392665, XrefRangeEnd = 392666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00030CDC File Offset: 0x0002EEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392666, XrefRangeEnd = 392728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00030D24 File Offset: 0x0002EF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392728, XrefRangeEnd = 392729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00030D60 File Offset: 0x0002EF60
		[CallerCount(0)]
		public unsafe override string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00030DB4 File Offset: 0x0002EFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392729, XrefRangeEnd = 392734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadAttributeValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00030DFC File Offset: 0x0002EFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392734, XrefRangeEnd = 392742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResolveEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000263 RID: 611
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x00030E38 File Offset: 0x0002F038
		public unsafe XmlReader OuterReader
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_OuterReader_Internal_set_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x00030E7C File Offset: 0x0002F07C
		public unsafe virtual int LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00030EB8 File Offset: 0x0002F0B8
		public unsafe virtual int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00030EF4 File Offset: 0x0002F0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392742, XrefRangeEnd = 392743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionary<string, string> System_Xml_IXmlNamespaceResolver_GetNamespacesInScope(XmlNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00030F40 File Offset: 0x0002F140
		[CallerCount(0)]
		public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00030F88 File Offset: 0x0002F188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392743, XrefRangeEnd = 392744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00030FD0 File Offset: 0x0002F1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetNamespacesInScope_Internal_IDictionary_2_String_String_XmlNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0003101C File Offset: 0x0002F21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_LookupPrefix_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000266 RID: 614
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x00031064 File Offset: 0x0002F264
		public unsafe bool Namespaces
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 392767, RefRangeEnd = 392769, XrefRangeStart = 392744, XrefRangeEnd = 392767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_Namespaces_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000267 RID: 615
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x000310A4 File Offset: 0x0002F2A4
		public unsafe EntityHandling EntityHandling
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_EntityHandling_Internal_set_Void_EntityHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x000310E4 File Offset: 0x0002F2E4
		public unsafe bool IsResolverSet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_IsResolverSet_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000269 RID: 617
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00031120 File Offset: 0x0002F320
		public unsafe XmlResolver XmlResolver
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 392769, RefRangeEnd = 392776, XrefRangeStart = 392769, XrefRangeEnd = 392769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00031164 File Offset: 0x0002F364
		public unsafe XmlNameTable DtdParserProxy_NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_NameTable_Internal_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x000311A4 File Offset: 0x0002F3A4
		public unsafe IXmlNamespaceResolver DtdParserProxy_NamespaceResolver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_NamespaceResolver_Internal_get_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr3) : null;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x000311E4 File Offset: 0x0002F3E4
		public unsafe bool DtdParserProxy_DtdValidation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_DtdValidation_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x00031220 File Offset: 0x0002F420
		public unsafe bool DtdParserProxy_Normalization
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_Normalization_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0003125C File Offset: 0x0002F45C
		public unsafe bool DtdParserProxy_Namespaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_Namespaces_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x00031298 File Offset: 0x0002F498
		public unsafe bool DtdParserProxy_V1CompatibilityMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_V1CompatibilityMode_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x000312D4 File Offset: 0x0002F4D4
		public unsafe Uri DtdParserProxy_BaseUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392776, XrefRangeEnd = 392780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_BaseUri_Internal_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x00031314 File Offset: 0x0002F514
		public unsafe bool DtdParserProxy_IsEof
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_IsEof_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00031350 File Offset: 0x0002F550
		public unsafe Il2CppStructArray<char> DtdParserProxy_ParsingBuffer
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ParsingBuffer_Internal_get_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x00031390 File Offset: 0x0002F590
		public unsafe int DtdParserProxy_ParsingBufferLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ParsingBufferLength_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x000313CC File Offset: 0x0002F5CC
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x00031408 File Offset: 0x0002F608
		public unsafe int DtdParserProxy_CurrentPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_CurrentPosition_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_DtdParserProxy_CurrentPosition_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x00031448 File Offset: 0x0002F648
		public unsafe int DtdParserProxy_EntityStackLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_EntityStackLength_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00031484 File Offset: 0x0002F684
		public unsafe bool DtdParserProxy_IsEntityEolNormalized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_IsEntityEolNormalized_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x000314C0 File Offset: 0x0002F6C0
		public unsafe IValidationEventHandling DtdParserProxy_ValidationEventHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ValidationEventHandling_Internal_get_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IValidationEventHandling>(intPtr3) : null;
			}
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00031500 File Offset: 0x0002F700
		[CallerCount(0)]
		public unsafe void DtdParserProxy_OnNewLine(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnNewLine_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00031540 File Offset: 0x0002F740
		public unsafe int DtdParserProxy_LineNo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_LineNo_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x0003157C File Offset: 0x0002F77C
		public unsafe int DtdParserProxy_LineStartPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_LineStartPosition_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x000315B8 File Offset: 0x0002F7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392780, XrefRangeEnd = 392781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DtdParserProxy_ReadData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ReadData_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x000315F4 File Offset: 0x0002F7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392781, XrefRangeEnd = 392785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseNumericCharRef_Internal_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00031644 File Offset: 0x0002F844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392785, XrefRangeEnd = 392786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expand;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseNamedCharRef_Internal_Int32_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x000316A0 File Offset: 0x0002F8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392786, XrefRangeEnd = 392788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_ParsePI(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParsePI_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x000316E4 File Offset: 0x0002F8E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392800, RefRangeEnd = 392801, XrefRangeStart = 392788, XrefRangeEnd = 392800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_ParseComment(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseComment_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x00031728 File Offset: 0x0002F928
		public unsafe bool IsResolverNull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_IsResolverNull_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00031764 File Offset: 0x0002F964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392801, XrefRangeEnd = 392804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlResolver GetTempResolver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetTempResolver_Private_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000317A4 File Offset: 0x0002F9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392804, XrefRangeEnd = 392810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushEntity_Internal_Boolean_IDtdEntityInfo_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00031800 File Offset: 0x0002FA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392810, XrefRangeEnd = 392811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &newEntityId;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PopEntity_Internal_Boolean_byref_IDtdEntityInfo_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			oldEntity = ((intPtr4 == 0) ? null : new IDtdEntityInfo(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0003186C File Offset: 0x0002FA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392811, XrefRangeEnd = 392818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DtdParserProxy_PushExternalSubset(string systemId, string publicId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(systemId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushExternalSubset_Internal_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000318CC File Offset: 0x0002FACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392818, XrefRangeEnd = 392822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalDtd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushInternalDtd_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00031920 File Offset: 0x0002FB20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392823, RefRangeEnd = 392824, XrefRangeStart = 392822, XrefRangeEnd = 392823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_Throw(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_Throw_Internal_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00031964 File Offset: 0x0002FB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392824, XrefRangeEnd = 392827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(systemId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywordLineInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref systemLiteralLineInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnSystemId_Internal_Void_String_LineInfo_LineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x000319C4 File Offset: 0x0002FBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392827, XrefRangeEnd = 392830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(publicId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywordLineInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref publicLiteralLineInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnPublicId_Internal_Void_String_LineInfo_LineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00031A24 File Offset: 0x0002FC24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 392833, RefRangeEnd = 392835, XrefRangeStart = 392830, XrefRangeEnd = 392833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int pos, string res, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00031A88 File Offset: 0x0002FC88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392838, RefRangeEnd = 392839, XrefRangeStart = 392835, XrefRangeEnd = 392838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int pos, string res, Il2CppStringArray args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00031AEC File Offset: 0x0002FCEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 392846, RefRangeEnd = 392848, XrefRangeStart = 392839, XrefRangeEnd = 392846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int pos, string res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00031B3C File Offset: 0x0002FD3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 392853, RefRangeEnd = 392855, XrefRangeStart = 392848, XrefRangeEnd = 392853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00031B80 File Offset: 0x0002FD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392855, XrefRangeEnd = 392866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, int lineNo, int linePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00031BE0 File Offset: 0x0002FDE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 392875, RefRangeEnd = 392879, XrefRangeStart = 392866, XrefRangeEnd = 392875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00031C34 File Offset: 0x0002FE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392879, XrefRangeEnd = 392886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, string arg, int lineNo, int linePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00031CA4 File Offset: 0x0002FEA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 392895, RefRangeEnd = 392899, XrefRangeStart = 392886, XrefRangeEnd = 392895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, Il2CppStringArray args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00031CF8 File Offset: 0x0002FEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392899, XrefRangeEnd = 392906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, string arg, Exception innerException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00031D60 File Offset: 0x0002FF60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392915, RefRangeEnd = 392916, XrefRangeStart = 392906, XrefRangeEnd = 392915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, Il2CppStringArray args, Exception innerException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00031DC8 File Offset: 0x0002FFC8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 392928, RefRangeEnd = 392938, XrefRangeStart = 392916, XrefRangeEnd = 392928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00031E0C File Offset: 0x0003000C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392938, XrefRangeEnd = 392947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReThrow(Exception e, int lineNo, int linePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ReThrow_Private_Void_Exception_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00031E6C File Offset: 0x0003006C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392947, XrefRangeEnd = 392958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowWithoutLineInfo(string res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00031EB0 File Offset: 0x000300B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392958, XrefRangeEnd = 392965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowWithoutLineInfo(string res, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00031F04 File Offset: 0x00030104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392965, XrefRangeEnd = 392972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowWithoutLineInfo(string res, Il2CppStringArray args, Exception innerException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_Il2CppStringArray_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00031F6C File Offset: 0x0003016C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392972, XrefRangeEnd = 392976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowInvalidChar(Il2CppStructArray<char> data, int length, int invCharPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invCharPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00031FCC File Offset: 0x000301CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392976, RefRangeEnd = 392977, XrefRangeStart = 392976, XrefRangeEnd = 392976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetErrorState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetErrorState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00032000 File Offset: 0x00030200
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 392984, RefRangeEnd = 392987, XrefRangeStart = 392977, XrefRangeEnd = 392984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref severity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00032080 File Offset: 0x00030280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392987, XrefRangeEnd = 392990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref severity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x000320D0 File Offset: 0x000302D0
		public unsafe bool InAttributeValueIterator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_InAttributeValueIterator_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0003210C File Offset: 0x0003030C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 392995, RefRangeEnd = 392999, XrefRangeStart = 392990, XrefRangeEnd = 392995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishAttributeValueIterator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishAttributeValueIterator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00032140 File Offset: 0x00030340
		public unsafe bool DtdValidation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdValidation_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0003217C File Offset: 0x0003037C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392999, XrefRangeEnd = 393002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStreamInput(Stream stream, Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x000321D0 File Offset: 0x000303D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393002, XrefRangeEnd = 393003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_String_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00032238 File Offset: 0x00030438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393003, XrefRangeEnd = 393004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x000322A0 File Offset: 0x000304A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393004, XrefRangeEnd = 393005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0003231C File Offset: 0x0003051C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 393029, RefRangeEnd = 393038, XrefRangeStart = 393005, XrefRangeEnd = 393029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Il2CppStructArray<byte> bytes, int byteCount, Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Il2CppStructArray_1_Byte_Int32_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x000323B8 File Offset: 0x000305B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393038, XrefRangeEnd = 393039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitTextReaderInput(string baseUriStr, TextReader input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_TextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0003240C File Offset: 0x0003060C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 393045, RefRangeEnd = 393049, XrefRangeStart = 393039, XrefRangeEnd = 393045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_Uri_TextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00032474 File Offset: 0x00030674
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 393053, RefRangeEnd = 393060, XrefRangeStart = 393049, XrefRangeEnd = 393053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStringInput(string baseUriStr, Encoding originalEncoding, string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originalEncoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitStringInput_Private_Void_String_Encoding_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x000324DC File Offset: 0x000306DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 393079, RefRangeEnd = 393082, XrefRangeStart = 393060, XrefRangeEnd = 393079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fragmentType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parserContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowXmlDeclFragment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitFragmentReader_Private_Void_XmlNodeType_XmlParserContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0003253C File Offset: 0x0003073C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 393084, RefRangeEnd = 393087, XrefRangeStart = 393082, XrefRangeEnd = 393084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessDtdFromParserContext(XmlParserContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ProcessDtdFromParserContext_Private_Void_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00032580 File Offset: 0x00030780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 393108, RefRangeEnd = 393109, XrefRangeStart = 393087, XrefRangeEnd = 393108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenUrl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OpenUrl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x000325B4 File Offset: 0x000307B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393109, XrefRangeEnd = 393120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenUrlDelegate(Object xmlResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlResolver);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OpenUrlDelegate_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x000325F8 File Offset: 0x000307F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 393131, RefRangeEnd = 393132, XrefRangeStart = 393120, XrefRangeEnd = 393131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Encoding DetectEncoding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DetectEncoding_Private_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00032638 File Offset: 0x00030838
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 393151, RefRangeEnd = 393154, XrefRangeStart = 393132, XrefRangeEnd = 393151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupEncoding(Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetupEncoding_Private_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0003267C File Offset: 0x0003087C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 393158, RefRangeEnd = 393159, XrefRangeStart = 393154, XrefRangeEnd = 393158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchEncoding(Encoding newEncoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEncoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SwitchEncoding_Private_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x000326C0 File Offset: 0x000308C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 393206, RefRangeEnd = 393207, XrefRangeStart = 393159, XrefRangeEnd = 393206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Encoding CheckEncoding(string newEncodingName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newEncodingName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_CheckEncoding_Private_Encoding_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00032710 File Offset: 0x00030910
		[CallerCount(0)]
		public unsafe void UnDecodeChars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_UnDecodeChars_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00032744 File Offset: 0x00030944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 393211, RefRangeEnd = 393212, XrefRangeStart = 393207, XrefRangeEnd = 393211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchEncodingToUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SwitchEncodingToUTF8_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00032778 File Offset: 0x00030978
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 393235, RefRangeEnd = 393270, XrefRangeStart = 393212, XrefRangeEnd = 393235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ReadData_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x000327B4 File Offset: 0x000309B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 393272, RefRangeEnd = 393273, XrefRangeStart = 393270, XrefRangeEnd = 393272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetChars(int maxCharsCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxCharsCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetChars_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00032800 File Offset: 0x00030A00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 393276, RefRangeEnd = 393277, XrefRangeStart = 393273, XrefRangeEnd = 393276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvalidCharRecovery(ref int bytesCount, out int charsCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &bytesCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InvalidCharRecovery_Private_Void_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0003284C File Offset: 0x00030A4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 393289, RefRangeEnd = 393290, XrefRangeStart = 393277, XrefRangeEnd = 393289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool closeInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeInput;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Close_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0003288C File Offset: 0x00030A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393290, XrefRangeEnd = 393291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShiftBuffer(int sourcePos, int destPos, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourcePos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ShiftBuffer_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x000328E8 File Offset: 0x00030AE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 393406, RefRangeEnd = 393410, XrefRangeStart = 393291, XrefRangeEnd = 393406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseXmlDeclaration(bool isTextDecl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isTextDecl;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseXmlDeclaration_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00032934 File Offset: 0x00030B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 393424, RefRangeEnd = 393425, XrefRangeStart = 393410, XrefRangeEnd = 393424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseDocumentContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseDocumentContent_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00032970 File Offset: 0x00030B70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 393433, RefRangeEnd = 393434, XrefRangeStart = 393425, XrefRangeEnd = 393433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseElementContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseElementContent_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x000329AC File Offset: 0x00030BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393434, XrefRangeEnd = 393475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowUnclosedElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnclosedElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x000329E0 File Offset: 0x00030BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393475, XrefRangeEnd = 393494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00032A14 File Offset: 0x00030C14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 393560, RefRangeEnd = 393562, XrefRangeStart = 393494, XrefRangeEnd = 393560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDefaultAttributesAndNormalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributesAndNormalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00032A48 File Offset: 0x00030C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393562, XrefRangeEnd = 393580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseEndElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00032A7C File Offset: 0x00030C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393580, XrefRangeEnd = 393624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startTag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowTagMismatch_Private_Void_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00032AC0 File Offset: 0x00030CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393624, XrefRangeEnd = 393657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00032AF4 File Offset: 0x00030CF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 393658, RefRangeEnd = 393660, XrefRangeStart = 393657, XrefRangeEnd = 393658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ElementNamespaceLookup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ElementNamespaceLookup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00032B28 File Offset: 0x00030D28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 393662, RefRangeEnd = 393664, XrefRangeStart = 393660, XrefRangeEnd = 393662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttributeNamespaceLookup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AttributeNamespaceLookup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00032B5C File Offset: 0x00030D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 393671, RefRangeEnd = 393672, XrefRangeStart = 393664, XrefRangeEnd = 393671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttributeDuplCheck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AttributeDuplCheck_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00032B90 File Offset: 0x00030D90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 393679, RefRangeEnd = 393681, XrefRangeStart = 393672, XrefRangeEnd = 393679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OnDefaultNamespaceDecl_Private_Void_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00032BD4 File Offset: 0x00030DD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 393684, RefRangeEnd = 393686, XrefRangeStart = 393681, XrefRangeEnd = 393684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OnNamespaceDecl_Private_Void_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00032C18 File Offset: 0x00030E18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 393697, RefRangeEnd = 393699, XrefRangeStart = 393686, XrefRangeEnd = 393697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OnXmlReservedAttribute_Private_Void_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00032C5C File Offset: 0x00030E5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 393772, RefRangeEnd = 393775, XrefRangeStart = 393699, XrefRangeEnd = 393772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref curPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quoteChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributeValueSlow_Private_Void_Int32_Char_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00032CBC File Offset: 0x00030EBC
		[CallerCount(0)]
		public unsafe void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, ref XmlTextReaderImpl.NodeData lastChunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chunk);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lastChunk);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddAttributeChunkToList_Private_Void_NodeData_NodeData_byref_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			lastChunk = ((intPtr4 == 0) ? null : new XmlTextReaderImpl.NodeData(intPtr4));
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00032D38 File Offset: 0x00030F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 393810, RefRangeEnd = 393812, XrefRangeStart = 393775, XrefRangeEnd = 393810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseText_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00032D74 File Offset: 0x00030F74
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 393834, RefRangeEnd = 393842, XrefRangeStart = 393812, XrefRangeEnd = 393834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseText(out int startPos, out int endPos, ref int outOrChars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &startPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &endPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outOrChars;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseText_Private_Boolean_byref_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00032DDC File Offset: 0x00030FDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 393858, RefRangeEnd = 393862, XrefRangeStart = 393842, XrefRangeEnd = 393858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishPartialValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishPartialValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00032E10 File Offset: 0x00031010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393862, XrefRangeEnd = 393866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishOtherValueIterator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishOtherValueIterator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00032E44 File Offset: 0x00031044
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 393867, RefRangeEnd = 393870, XrefRangeStart = 393866, XrefRangeEnd = 393867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipPartialTextValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SkipPartialTextValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00032E78 File Offset: 0x00031078
		[CallerCount(0)]
		public unsafe void FinishReadValueChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadValueChunk_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00032EAC File Offset: 0x000310AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 393873, RefRangeEnd = 393877, XrefRangeStart = 393870, XrefRangeEnd = 393873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishReadContentAsBinary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadContentAsBinary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00032EE0 File Offset: 0x000310E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393877, XrefRangeEnd = 393891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishReadElementContentAsBinary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadElementContentAsBinary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00032F14 File Offset: 0x00031114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 393897, RefRangeEnd = 393898, XrefRangeStart = 393891, XrefRangeEnd = 393897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseRootLevelWhitespace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseRootLevelWhitespace_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00032F50 File Offset: 0x00031150
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 393902, RefRangeEnd = 393904, XrefRangeStart = 393898, XrefRangeEnd = 393902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseEntityReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseEntityReference_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00032F84 File Offset: 0x00031184
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 393912, RefRangeEnd = 393915, XrefRangeStart = 393904, XrefRangeEnd = 393912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, out int charRefEndPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isInAttributeValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expandType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charRefEndPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_HandleEntityReference_Private_EntityType_Boolean_EntityExpandType_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00032FEC File Offset: 0x000311EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 393951, RefRangeEnd = 393954, XrefRangeStart = 393915, XrefRangeEnd = 393951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInAttributeValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pushFakeEntityIfNullResolver;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entityStartLinePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_HandleGeneralEntityReference_Private_EntityType_String_Boolean_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00033064 File Offset: 0x00031264
		public unsafe bool InEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_InEntity_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x000330A0 File Offset: 0x000312A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 393959, RefRangeEnd = 393963, XrefRangeStart = 393954, XrefRangeEnd = 393959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleEntityEnd(bool checkEntityNesting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref checkEntityNesting;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x000330EC File Offset: 0x000312EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 393969, RefRangeEnd = 393971, XrefRangeStart = 393963, XrefRangeEnd = 393969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupEndEntityNodeInContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetupEndEntityNodeInContent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00033120 File Offset: 0x00031320
		[CallerCount(0)]
		public unsafe void SetupEndEntityNodeInAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetupEndEntityNodeInAttribute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00033154 File Offset: 0x00031354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393971, XrefRangeEnd = 393972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParsePI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParsePI_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00033190 File Offset: 0x00031390
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 394002, RefRangeEnd = 394007, XrefRangeStart = 393972, XrefRangeEnd = 394002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParsePI(StringBuilder piInDtdStringBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(piInDtdStringBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParsePI_Private_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x000331E0 File Offset: 0x000313E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 394020, RefRangeEnd = 394023, XrefRangeStart = 394007, XrefRangeEnd = 394020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParsePIValue(out int outStartPos, out int outEndPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &outStartPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outEndPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParsePIValue_Private_Boolean_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00033238 File Offset: 0x00031438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394023, XrefRangeEnd = 394024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseComment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseComment_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00033274 File Offset: 0x00031474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394024, XrefRangeEnd = 394025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseCData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000332A8 File Offset: 0x000314A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 394026, RefRangeEnd = 394030, XrefRangeStart = 394025, XrefRangeEnd = 394026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseCDataOrComment(XmlNodeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseCDataOrComment_Private_Void_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x000332E8 File Offset: 0x000314E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 394036, RefRangeEnd = 394037, XrefRangeStart = 394030, XrefRangeEnd = 394036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outStartPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outEndPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseCDataOrComment_Private_Boolean_XmlNodeType_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00033350 File Offset: 0x00031550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394037, XrefRangeEnd = 394052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseDoctypeDecl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseDoctypeDecl_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0003338C File Offset: 0x0003158C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394052, XrefRangeEnd = 394074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseDtd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseDtd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000333C0 File Offset: 0x000315C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 394107, RefRangeEnd = 394108, XrefRangeStart = 394074, XrefRangeEnd = 394107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipDtd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SkipDtd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000333F4 File Offset: 0x000315F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 394117, RefRangeEnd = 394119, XrefRangeStart = 394108, XrefRangeEnd = 394117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipPublicOrSystemIdLiteral()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SkipPublicOrSystemIdLiteral_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00033428 File Offset: 0x00031628
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 394133, RefRangeEnd = 394135, XrefRangeStart = 394119, XrefRangeEnd = 394133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipUntil(char stopChar, bool recognizeLiterals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stopChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recognizeLiterals;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SkipUntil_Private_Void_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00033474 File Offset: 0x00031674
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 394145, RefRangeEnd = 394161, XrefRangeStart = 394135, XrefRangeEnd = 394145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EatWhitespaces(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_EatWhitespaces_Private_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x000334C4 File Offset: 0x000316C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394161, XrefRangeEnd = 394163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseCharRefInline(int startPos, out int charCount, out XmlTextReaderImpl.EntityType entityType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseCharRefInline_Private_Int32_Int32_byref_Int32_byref_EntityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0003352C File Offset: 0x0003172C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394163, XrefRangeEnd = 394167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out XmlTextReaderImpl.EntityType entityType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expand;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseNumericCharRef_Private_Int32_Boolean_StringBuilder_byref_EntityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00033598 File Offset: 0x00031798
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 394180, RefRangeEnd = 394185, XrefRangeStart = 394167, XrefRangeEnd = 394180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out XmlTextReaderImpl.EntityType entityType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expand;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseNumericCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_byref_Int32_byref_EntityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00033620 File Offset: 0x00031820
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 394187, RefRangeEnd = 394190, XrefRangeStart = 394185, XrefRangeEnd = 394187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expand;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseNamedCharRef_Private_Int32_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0003367C File Offset: 0x0003187C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 394192, RefRangeEnd = 394195, XrefRangeStart = 394190, XrefRangeEnd = 394192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expand;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseNamedCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x000336E8 File Offset: 0x000318E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394195, XrefRangeEnd = 394196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseName_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00033724 File Offset: 0x00031924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 394197, RefRangeEnd = 394198, XrefRangeStart = 394196, XrefRangeEnd = 394197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseQName(out int colonPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &colonPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseQName_Private_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00033770 File Offset: 0x00031970
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 394209, RefRangeEnd = 394218, XrefRangeStart = 394198, XrefRangeEnd = 394209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseQName(bool isQName, int startOffset, out int colonPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isQName;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &colonPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseQName_Private_Int32_Boolean_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x000337D8 File Offset: 0x000319D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394218, XrefRangeEnd = 394219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadDataInName(ref int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ReadDataInName_Private_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00033824 File Offset: 0x00031A24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 394221, RefRangeEnd = 394225, XrefRangeStart = 394219, XrefRangeEnd = 394221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseEntityName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseEntityName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0003385C File Offset: 0x00031A5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 394226, RefRangeEnd = 394227, XrefRangeStart = 394225, XrefRangeEnd = 394226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodeDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddNode_Private_NodeData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x000338B8 File Offset: 0x00031AB8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 394237, RefRangeEnd = 394244, XrefRangeStart = 394227, XrefRangeEnd = 394237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodeDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AllocNode_Private_NodeData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00033914 File Offset: 0x00031B14
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 394249, RefRangeEnd = 394256, XrefRangeStart = 394244, XrefRangeEnd = 394249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attrDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddAttributeNoChecks_Private_NodeData_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00033974 File Offset: 0x00031B74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 394261, RefRangeEnd = 394262, XrefRangeStart = 394256, XrefRangeEnd = 394261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref endNamePos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colonPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddAttribute_Private_NodeData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x000339D0 File Offset: 0x00031BD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 394267, RefRangeEnd = 394269, XrefRangeStart = 394262, XrefRangeEnd = 394267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nameWPrefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddAttribute_Private_NodeData_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00033A44 File Offset: 0x00031C44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 394269, RefRangeEnd = 394270, XrefRangeStart = 394269, XrefRangeEnd = 394269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopElementContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PopElementContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00033A78 File Offset: 0x00031C78
		[CallerCount(0)]
		public unsafe void OnNewLine(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OnNewLine_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00033AB8 File Offset: 0x00031CB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 394271, RefRangeEnd = 394273, XrefRangeStart = 394270, XrefRangeEnd = 394271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEof()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OnEof_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00033AEC File Offset: 0x00031CEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 394274, RefRangeEnd = 394276, XrefRangeStart = 394273, XrefRangeEnd = 394274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LookupNamespace(XmlTextReaderImpl.NodeData node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_LookupNamespace_Private_String_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00033B34 File Offset: 0x00031D34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 394286, RefRangeEnd = 394288, XrefRangeStart = 394276, XrefRangeEnd = 394286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00033B9C File Offset: 0x00031D9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 394288, RefRangeEnd = 394292, XrefRangeStart = 394288, XrefRangeEnd = 394288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ResetAttributes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00033BD0 File Offset: 0x00031DD0
		[CallerCount(0)]
		public unsafe void FullAttributeCleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FullAttributeCleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00033C04 File Offset: 0x00031E04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 394295, RefRangeEnd = 394297, XrefRangeStart = 394292, XrefRangeEnd = 394295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushXmlContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PushXmlContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00033C38 File Offset: 0x00031E38
		[CallerCount(0)]
		public unsafe void PopXmlContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PopXmlContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00033C6C File Offset: 0x00031E6C
		[CallerCount(0)]
		public unsafe XmlNodeType GetWhitespaceType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetWhitespaceType_Private_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00033CA8 File Offset: 0x00031EA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 394297, RefRangeEnd = 394300, XrefRangeStart = 394297, XrefRangeEnd = 394297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeType GetTextNodeType(int orChars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref orChars;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetTextNodeType_Private_XmlNodeType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00033CF4 File Offset: 0x00031EF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 394312, RefRangeEnd = 394314, XrefRangeStart = 394300, XrefRangeEnd = 394312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(publicId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entityName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PushExternalEntityOrSubset_Private_Void_String_String_Uri_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00033D70 File Offset: 0x00031F70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 394337, RefRangeEnd = 394339, XrefRangeStart = 394314, XrefRangeEnd = 394337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OpenAndPush(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OpenAndPush_Private_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00033DC0 File Offset: 0x00031FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 394348, RefRangeEnd = 394349, XrefRangeStart = 394339, XrefRangeEnd = 394348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PushExternalEntity(IDtdEntityInfo entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PushExternalEntity_Private_Boolean_IDtdEntityInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00033E10 File Offset: 0x00032010
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 394371, RefRangeEnd = 394374, XrefRangeStart = 394349, XrefRangeEnd = 394371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushInternalEntity(IDtdEntityInfo entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PushInternalEntity_Private_Void_IDtdEntityInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00033E54 File Offset: 0x00032054
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 394378, RefRangeEnd = 394381, XrefRangeStart = 394374, XrefRangeEnd = 394378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PopEntity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00033E88 File Offset: 0x00032088
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 394393, RefRangeEnd = 394395, XrefRangeStart = 394381, XrefRangeEnd = 394393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterEntity(IDtdEntityInfo entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_RegisterEntity_Private_Void_IDtdEntityInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00033ECC File Offset: 0x000320CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394395, XrefRangeEnd = 394398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_UnregisterEntity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00033F00 File Offset: 0x00032100
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 394410, RefRangeEnd = 394416, XrefRangeStart = 394398, XrefRangeEnd = 394410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushParsingState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PushParsingState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00033F34 File Offset: 0x00032134
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 394417, RefRangeEnd = 394419, XrefRangeStart = 394416, XrefRangeEnd = 394417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopParsingState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PopParsingState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00033F68 File Offset: 0x00032168
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 394422, RefRangeEnd = 394424, XrefRangeStart = 394419, XrefRangeEnd = 394422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IncrementalRead()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_IncrementalRead_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00033FA4 File Offset: 0x000321A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394424, XrefRangeEnd = 394428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishIncrementalRead()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishIncrementalRead_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00033FD8 File Offset: 0x000321D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394428, XrefRangeEnd = 394431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseFragmentAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseFragmentAttribute_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00034014 File Offset: 0x00032214
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 394449, RefRangeEnd = 394450, XrefRangeStart = 394431, XrefRangeEnd = 394449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseAttributeValueChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributeValueChunk_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00034050 File Offset: 0x00032250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 394451, RefRangeEnd = 394452, XrefRangeStart = 394450, XrefRangeEnd = 394451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseXmlDeclarationFragment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseXmlDeclarationFragment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00034084 File Offset: 0x00032284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394452, XrefRangeEnd = 394453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowUnexpectedToken(int pos, string expectedToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expectedToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000340D4 File Offset: 0x000322D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394453, XrefRangeEnd = 394454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowUnexpectedToken(string expectedToken1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expectedToken1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00034118 File Offset: 0x00032318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 394457, RefRangeEnd = 394458, XrefRangeStart = 394454, XrefRangeEnd = 394457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expectedToken1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expectedToken2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0003417C File Offset: 0x0003237C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 394487, RefRangeEnd = 394490, XrefRangeStart = 394458, XrefRangeEnd = 394487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowUnexpectedToken(string expectedToken1, string expectedToken2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expectedToken1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expectedToken2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000341D0 File Offset: 0x000323D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394490, XrefRangeEnd = 394491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseUnexpectedToken(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00034214 File Offset: 0x00032414
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 394492, RefRangeEnd = 394495, XrefRangeStart = 394491, XrefRangeEnd = 394492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseUnexpectedToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0003424C File Offset: 0x0003244C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394495, XrefRangeEnd = 394502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowExpectingWhitespace(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowExpectingWhitespace_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0003428C File Offset: 0x0003248C
		[CallerCount(0)]
		public unsafe int GetIndexOfAttributeWithoutPrefix(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetIndexOfAttributeWithoutPrefix_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000342DC File Offset: 0x000324DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394502, XrefRangeEnd = 394503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetIndexOfAttributeWithPrefix(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetIndexOfAttributeWithPrefix_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0003432C File Offset: 0x0003252C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394503, XrefRangeEnd = 394504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ZeroEndingStream(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ZeroEndingStream_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00034378 File Offset: 0x00032578
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 394518, RefRangeEnd = 394520, XrefRangeStart = 394504, XrefRangeEnd = 394518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseDtdFromParserContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseDtdFromParserContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x000343AC File Offset: 0x000325AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394520, XrefRangeEnd = 394521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToNextContentNode(bool moveIfOnContentNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveIfOnContentNode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_MoveToNextContentNode_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x000343F8 File Offset: 0x000325F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 394535, RefRangeEnd = 394536, XrefRangeStart = 394521, XrefRangeEnd = 394535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetupFromParserContext_Private_Void_XmlParserContext_XmlReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0003444C File Offset: 0x0003264C
		public unsafe override IDtdInfo DtdInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_get_IDtdInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00034498 File Offset: 0x00032698
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 394541, RefRangeEnd = 394544, XrefRangeStart = 394536, XrefRangeEnd = 394541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDtdInfo(IDtdInfo newDtdInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newDtdInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetDtdInfo_Internal_Void_IDtdInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700027F RID: 639
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x000344DC File Offset: 0x000326DC
		public unsafe IValidationEventHandling ValidationEventHandling
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_ValidationEventHandling_Internal_set_Void_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000280 RID: 640
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x00034520 File Offset: 0x00032720
		public unsafe XmlTextReaderImpl.OnDefaultAttributeUseDelegate OnDefaultAttributeUse
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_OnDefaultAttributeUse_Internal_set_Void_OnDefaultAttributeUseDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000281 RID: 641
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x00034564 File Offset: 0x00032764
		public unsafe bool XmlValidatingReaderCompatibilityMode
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 394550, RefRangeEnd = 394555, XrefRangeStart = 394544, XrefRangeEnd = 394550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_XmlValidatingReaderCompatibilityMode_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x000345A4 File Offset: 0x000327A4
		public unsafe XmlNodeType FragmentType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_FragmentType_Internal_get_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000345E0 File Offset: 0x000327E0
		[CallerCount(0)]
		public unsafe void ChangeCurrentNodeType(XmlNodeType newNodeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newNodeType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ChangeCurrentNodeType_Internal_Void_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00034620 File Offset: 0x00032820
		[CallerCount(0)]
		public unsafe XmlResolver GetResolver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x17000283 RID: 643
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x00034660 File Offset: 0x00032860
		public unsafe Object InternalSchemaType
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 394555, RefRangeEnd = 394564, XrefRangeStart = 394555, XrefRangeEnd = 394555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_InternalSchemaType_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x000346A4 File Offset: 0x000328A4
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x000346E4 File Offset: 0x000328E4
		public unsafe Object InternalTypedValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_InternalTypedValue_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 394564, RefRangeEnd = 394571, XrefRangeStart = 394564, XrefRangeEnd = 394564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_InternalTypedValue_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x00034728 File Offset: 0x00032928
		public unsafe bool StandAlone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_StandAlone_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00034764 File Offset: 0x00032964
		public unsafe override XmlNamespaceManager NamespaceManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_NamespaceManager_Internal_Virtual_get_XmlNamespaceManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr3) : null;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x000347B0 File Offset: 0x000329B0
		public unsafe bool V1Compat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_V1Compat_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000347EC File Offset: 0x000329EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 394607, RefRangeEnd = 394608, XrefRangeStart = 394571, XrefRangeEnd = 394607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, Il2CppReferenceArray<XmlTextReaderImpl.NodeData> nameSortedNodeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(defAttrInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref definedInDtd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameSortedNodeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributeDtd_Private_Boolean_IDtdDefaultAttributeInfo_Boolean_Il2CppReferenceArray_1_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0003485C File Offset: 0x00032A5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 394615, RefRangeEnd = 394617, XrefRangeStart = 394608, XrefRangeEnd = 394615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrDef);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributeNonDtd_Internal_Boolean_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x000348AC File Offset: 0x00032AAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 394625, RefRangeEnd = 394628, XrefRangeStart = 394617, XrefRangeEnd = 394625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueLineNo;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueLinePos;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isXmlAttribute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributeInternal_Private_NodeData_String_String_String_String_Int32_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x17000288 RID: 648
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x0003497C File Offset: 0x00032B7C
		public unsafe bool DisableUndeclaredEntityCheck
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_DisableUndeclaredEntityCheck_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000349BC File Offset: 0x00032BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394628, XrefRangeEnd = 394634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri1Str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri2Str);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_UriEqual_Private_Boolean_Uri_String_String_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00034A40 File Offset: 0x00032C40
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 394637, RefRangeEnd = 394642, XrefRangeStart = 394634, XrefRangeEnd = 394637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterConsumedCharacters(long characters, bool inEntityReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref characters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inEntityReference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_RegisterConsumedCharacters_Private_Void_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00034A8C File Offset: 0x00032C8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 394655, RefRangeEnd = 394656, XrefRangeStart = 394642, XrefRangeEnd = 394655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StripSpaces(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00034AC8 File Offset: 0x00032CC8
		[CallerCount(0)]
		public unsafe static void StripSpaces(Il2CppStructArray<char> value, int index, ref int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_StripSpaces_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00034B1C File Offset: 0x00032D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394656, XrefRangeEnd = 394657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlockCopyChars(Il2CppStructArray<char> src, int srcOffset, Il2CppStructArray<char> dst, int dstOffset, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_BlockCopyChars_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00034B90 File Offset: 0x00032D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394657, XrefRangeEnd = 394662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlockCopy(Il2CppStructArray<byte> src, int srcOffset, Il2CppStructArray<byte> dst, int dstOffset, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_BlockCopy_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00004092 File Offset: 0x00002292
		public XmlTextReaderImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00034C04 File Offset: 0x00032E04
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x0000409B File Offset: 0x0000229B
		public unsafe bool useAsync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_useAsync);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_useAsync)) = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00034C2C File Offset: 0x00032E2C
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x000040B6 File Offset: 0x000022B6
		public unsafe XmlTextReaderImpl.LaterInitParam laterInitParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_laterInitParam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.LaterInitParam>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_laterInitParam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00034C5C File Offset: 0x00032E5C
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x000040D5 File Offset: 0x000022D5
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x00034C8C File Offset: 0x00032E8C
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x00004103 File Offset: 0x00002303
		public XmlTextReaderImpl.ParsingState ps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ps);
				return new XmlTextReaderImpl.ParsingState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ps), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00034CBC File Offset: 0x00032EBC
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x00004131 File Offset: 0x00002331
		public unsafe XmlTextReaderImpl.ParsingFunction parsingFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingFunction)) = value;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00034CE4 File Offset: 0x00032EE4
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x0000414C File Offset: 0x0000234C
		public unsafe XmlTextReaderImpl.ParsingFunction nextParsingFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextParsingFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextParsingFunction)) = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00034D0C File Offset: 0x00032F0C
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x00004167 File Offset: 0x00002367
		public unsafe XmlTextReaderImpl.ParsingFunction nextNextParsingFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextNextParsingFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextNextParsingFunction)) = value;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00034D34 File Offset: 0x00032F34
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x00004182 File Offset: 0x00002382
		public unsafe Il2CppReferenceArray<XmlTextReaderImpl.NodeData> nodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlTextReaderImpl.NodeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00034D64 File Offset: 0x00032F64
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x000041A1 File Offset: 0x000023A1
		public unsafe XmlTextReaderImpl.NodeData curNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_curNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_curNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00034D94 File Offset: 0x00032F94
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x000041C0 File Offset: 0x000023C0
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00034DBC File Offset: 0x00032FBC
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x000041DB File Offset: 0x000023DB
		public unsafe int curAttrIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_curAttrIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_curAttrIndex)) = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x00034DE4 File Offset: 0x00032FE4
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x000041F6 File Offset: 0x000023F6
		public unsafe int attrCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrCount)) = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00034E0C File Offset: 0x0003300C
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00004211 File Offset: 0x00002411
		public unsafe int attrHashtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrHashtable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrHashtable)) = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00034E34 File Offset: 0x00033034
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x0000422C File Offset: 0x0000242C
		public unsafe int attrDuplWalkCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplWalkCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplWalkCount)) = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00034E5C File Offset: 0x0003305C
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x00004247 File Offset: 0x00002447
		public unsafe bool attrNeedNamespaceLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrNeedNamespaceLookup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrNeedNamespaceLookup)) = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00034E84 File Offset: 0x00033084
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00004262 File Offset: 0x00002462
		public unsafe bool fullAttrCleanup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fullAttrCleanup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fullAttrCleanup)) = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00034EAC File Offset: 0x000330AC
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x0000427D File Offset: 0x0000247D
		public unsafe Il2CppReferenceArray<XmlTextReaderImpl.NodeData> attrDuplSortingArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplSortingArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlTextReaderImpl.NodeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplSortingArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00034EDC File Offset: 0x000330DC
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x0000429C File Offset: 0x0000249C
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00034F0C File Offset: 0x0003310C
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x000042BB File Offset: 0x000024BB
		public unsafe bool nameTableFromSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nameTableFromSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nameTableFromSettings)) = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00034F34 File Offset: 0x00033134
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x000042D6 File Offset: 0x000024D6
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00034F64 File Offset: 0x00033164
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x000042F5 File Offset: 0x000024F5
		public unsafe string url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00034F8C File Offset: 0x0003318C
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00004314 File Offset: 0x00002514
		public unsafe bool normalize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_normalize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_normalize)) = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00034FB4 File Offset: 0x000331B4
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x0000432F File Offset: 0x0000252F
		public unsafe bool supportNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_supportNamespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_supportNamespaces)) = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00034FDC File Offset: 0x000331DC
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x0000434A File Offset: 0x0000254A
		public unsafe WhitespaceHandling whitespaceHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_whitespaceHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_whitespaceHandling)) = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00035004 File Offset: 0x00033204
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x00004365 File Offset: 0x00002565
		public unsafe DtdProcessing dtdProcessing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_dtdProcessing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_dtdProcessing)) = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x0003502C File Offset: 0x0003322C
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00004380 File Offset: 0x00002580
		public unsafe EntityHandling entityHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_entityHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_entityHandling)) = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00035054 File Offset: 0x00033254
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x0000439B File Offset: 0x0000259B
		public unsafe bool ignorePIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ignorePIs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ignorePIs)) = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x0003507C File Offset: 0x0003327C
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x000043B6 File Offset: 0x000025B6
		public unsafe bool ignoreComments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ignoreComments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ignoreComments)) = value;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x000350A4 File Offset: 0x000332A4
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x000043D1 File Offset: 0x000025D1
		public unsafe bool checkCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_checkCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_checkCharacters)) = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x000350CC File Offset: 0x000332CC
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x000043EC File Offset: 0x000025EC
		public unsafe int lineNumberOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lineNumberOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lineNumberOffset)) = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x000350F4 File Offset: 0x000332F4
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x00004407 File Offset: 0x00002607
		public unsafe int linePositionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_linePositionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_linePositionOffset)) = value;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x0003511C File Offset: 0x0003331C
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x00004422 File Offset: 0x00002622
		public unsafe bool closeInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_closeInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_closeInput)) = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00035144 File Offset: 0x00033344
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x0000443D File Offset: 0x0000263D
		public unsafe long maxCharactersInDocument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersInDocument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersInDocument)) = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x0003516C File Offset: 0x0003336C
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x00004458 File Offset: 0x00002658
		public unsafe long maxCharactersFromEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersFromEntities);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersFromEntities)) = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x00035194 File Offset: 0x00033394
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x00004473 File Offset: 0x00002673
		public unsafe bool v1Compat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_v1Compat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_v1Compat)) = value;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x000351BC File Offset: 0x000333BC
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x0000448E File Offset: 0x0000268E
		public unsafe XmlNamespaceManager namespaceManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_namespaceManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_namespaceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x000351EC File Offset: 0x000333EC
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x000044AD File Offset: 0x000026AD
		public unsafe string lastPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lastPrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lastPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x00035214 File Offset: 0x00033414
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x000044CC File Offset: 0x000026CC
		public unsafe XmlTextReaderImpl.XmlContext xmlContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.XmlContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x00035244 File Offset: 0x00033444
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x000044EB File Offset: 0x000026EB
		public unsafe Il2CppReferenceArray<XmlTextReaderImpl.ParsingState> parsingStatesStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlTextReaderImpl.ParsingState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00035274 File Offset: 0x00033474
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x0000450A File Offset: 0x0000270A
		public unsafe int parsingStatesStackTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStackTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStackTop)) = value;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x0003529C File Offset: 0x0003349C
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x00004525 File Offset: 0x00002725
		public unsafe string reportedBaseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_reportedBaseUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_reportedBaseUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x000352C4 File Offset: 0x000334C4
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x00004544 File Offset: 0x00002744
		public unsafe Encoding reportedEncoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_reportedEncoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_reportedEncoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x000352F4 File Offset: 0x000334F4
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x00004563 File Offset: 0x00002763
		public unsafe IDtdInfo dtdInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_dtdInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_dtdInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00035324 File Offset: 0x00033524
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x00004582 File Offset: 0x00002782
		public unsafe XmlNodeType fragmentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragmentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragmentType)) = value;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x0003534C File Offset: 0x0003354C
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x0000459D File Offset: 0x0000279D
		public unsafe XmlParserContext fragmentParserContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragmentParserContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlParserContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragmentParserContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x0003537C File Offset: 0x0003357C
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x000045BC File Offset: 0x000027BC
		public unsafe bool fragment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragment)) = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x000353A4 File Offset: 0x000335A4
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x000045D7 File Offset: 0x000027D7
		public unsafe IncrementalReadDecoder incReadDecoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadDecoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncrementalReadDecoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadDecoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x000353D4 File Offset: 0x000335D4
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x000045F6 File Offset: 0x000027F6
		public unsafe XmlTextReaderImpl.IncrementalReadState incReadState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadState)) = value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x000353FC File Offset: 0x000335FC
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x00004611 File Offset: 0x00002811
		public unsafe LineInfo incReadLineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLineInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLineInfo)) = value;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00035424 File Offset: 0x00033624
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x0000462C File Offset: 0x0000282C
		public unsafe int incReadDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadDepth)) = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x0003544C File Offset: 0x0003364C
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x00004647 File Offset: 0x00002847
		public unsafe int incReadLeftStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftStartPos)) = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00035474 File Offset: 0x00033674
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x00004662 File Offset: 0x00002862
		public unsafe int incReadLeftEndPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftEndPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftEndPos)) = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x0003549C File Offset: 0x0003369C
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x0000467D File Offset: 0x0000287D
		public unsafe int attributeValueBaseEntityId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attributeValueBaseEntityId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attributeValueBaseEntityId)) = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x000354C4 File Offset: 0x000336C4
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x00004698 File Offset: 0x00002898
		public unsafe bool emptyEntityInAttributeResolved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_emptyEntityInAttributeResolved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_emptyEntityInAttributeResolved)) = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x000354EC File Offset: 0x000336EC
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x000046B3 File Offset: 0x000028B3
		public unsafe IValidationEventHandling validationEventHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_validationEventHandling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IValidationEventHandling>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_validationEventHandling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0003551C File Offset: 0x0003371C
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x000046D2 File Offset: 0x000028D2
		public unsafe XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_onDefaultAttributeUse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_onDefaultAttributeUse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x0003554C File Offset: 0x0003374C
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x000046F1 File Offset: 0x000028F1
		public unsafe bool validatingReaderCompatFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_validatingReaderCompatFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_validatingReaderCompatFlag)) = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x00035574 File Offset: 0x00033774
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x0000470C File Offset: 0x0000290C
		public unsafe bool addDefaultAttributesAndNormalize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_addDefaultAttributesAndNormalize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_addDefaultAttributesAndNormalize)) = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x0003559C File Offset: 0x0003379C
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00004727 File Offset: 0x00002927
		public unsafe StringBuilder stringBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_stringBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_stringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x000355CC File Offset: 0x000337CC
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x00004746 File Offset: 0x00002946
		public unsafe bool rootElementParsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_rootElementParsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_rootElementParsed)) = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x000355F4 File Offset: 0x000337F4
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x00004761 File Offset: 0x00002961
		public unsafe bool standalone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_standalone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_standalone)) = value;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x0003561C File Offset: 0x0003381C
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x0000477C File Offset: 0x0000297C
		public unsafe int nextEntityId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextEntityId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextEntityId)) = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x00035644 File Offset: 0x00033844
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x00004797 File Offset: 0x00002997
		public unsafe XmlTextReaderImpl.ParsingMode parsingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingMode)) = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x0003566C File Offset: 0x0003386C
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x000047B2 File Offset: 0x000029B2
		public unsafe ReadState readState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_readState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_readState)) = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00035694 File Offset: 0x00033894
		// (set) Token: 0x060007B4 RID: 1972 RVA: 0x000047CD File Offset: 0x000029CD
		public unsafe IDtdEntityInfo lastEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lastEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdEntityInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lastEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x000356C4 File Offset: 0x000338C4
		// (set) Token: 0x060007B6 RID: 1974 RVA: 0x000047EC File Offset: 0x000029EC
		public unsafe bool afterResetState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_afterResetState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_afterResetState)) = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x000356EC File Offset: 0x000338EC
		// (set) Token: 0x060007B8 RID: 1976 RVA: 0x00004807 File Offset: 0x00002A07
		public unsafe int documentStartBytePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_documentStartBytePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_documentStartBytePos)) = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00035714 File Offset: 0x00033914
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x00004822 File Offset: 0x00002A22
		public unsafe int readValueOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_readValueOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_readValueOffset)) = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x0003573C File Offset: 0x0003393C
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x0000483D File Offset: 0x00002A3D
		public unsafe long charactersInDocument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_charactersInDocument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_charactersInDocument)) = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x00035764 File Offset: 0x00033964
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x00004858 File Offset: 0x00002A58
		public unsafe long charactersFromEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_charactersFromEntities);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_charactersFromEntities)) = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x0003578C File Offset: 0x0003398C
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x00004873 File Offset: 0x00002A73
		public unsafe Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_currentEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IDtdEntityInfo, IDtdEntityInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_currentEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x000357BC File Offset: 0x000339BC
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x00004892 File Offset: 0x00002A92
		public unsafe bool disableUndeclaredEntityCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_disableUndeclaredEntityCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_disableUndeclaredEntityCheck)) = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x000357E4 File Offset: 0x000339E4
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x000048AD File Offset: 0x00002AAD
		public unsafe XmlReader outerReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_outerReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_outerReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00035814 File Offset: 0x00033A14
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x000048CC File Offset: 0x00002ACC
		public unsafe bool xmlResolverIsSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolverIsSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolverIsSet)) = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x0003583C File Offset: 0x00033A3C
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x000048E7 File Offset: 0x00002AE7
		public unsafe string Xml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_Xml);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_Xml), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00035864 File Offset: 0x00033A64
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x00004906 File Offset: 0x00002B06
		public unsafe string XmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_XmlNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_XmlNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x0003588C File Offset: 0x00033A8C
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x00004925 File Offset: 0x00002B25
		public unsafe Task<Tuple<int, int, int, bool>> parseText_dummyTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parseText_dummyTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<Tuple<int, int, int, bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parseText_dummyTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr_useAsync;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr_laterInitParam;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeFieldInfoPtr_ps;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeFieldInfoPtr_parsingFunction;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeFieldInfoPtr_nextParsingFunction;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeFieldInfoPtr_nextNextParsingFunction;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeFieldInfoPtr_nodes;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeFieldInfoPtr_curNode;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeFieldInfoPtr_curAttrIndex;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeFieldInfoPtr_attrCount;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeFieldInfoPtr_attrHashtable;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeFieldInfoPtr_attrDuplWalkCount;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeFieldInfoPtr_attrNeedNamespaceLookup;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeFieldInfoPtr_fullAttrCleanup;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeFieldInfoPtr_attrDuplSortingArray;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeFieldInfoPtr_nameTableFromSettings;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeFieldInfoPtr_url;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeFieldInfoPtr_normalize;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeFieldInfoPtr_supportNamespaces;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeFieldInfoPtr_whitespaceHandling;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeFieldInfoPtr_dtdProcessing;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeFieldInfoPtr_entityHandling;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeFieldInfoPtr_ignorePIs;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeFieldInfoPtr_ignoreComments;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeFieldInfoPtr_checkCharacters;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeFieldInfoPtr_lineNumberOffset;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeFieldInfoPtr_linePositionOffset;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeFieldInfoPtr_closeInput;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeFieldInfoPtr_maxCharactersInDocument;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeFieldInfoPtr_maxCharactersFromEntities;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeFieldInfoPtr_v1Compat;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeFieldInfoPtr_namespaceManager;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeFieldInfoPtr_lastPrefix;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr_xmlContext;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr_parsingStatesStack;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeFieldInfoPtr_parsingStatesStackTop;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeFieldInfoPtr_reportedBaseUri;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeFieldInfoPtr_reportedEncoding;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeFieldInfoPtr_dtdInfo;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeFieldInfoPtr_fragmentType;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeFieldInfoPtr_fragmentParserContext;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeFieldInfoPtr_fragment;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeFieldInfoPtr_incReadDecoder;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeFieldInfoPtr_incReadState;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeFieldInfoPtr_incReadLineInfo;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeFieldInfoPtr_incReadDepth;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeFieldInfoPtr_incReadLeftStartPos;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeFieldInfoPtr_incReadLeftEndPos;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeFieldInfoPtr_attributeValueBaseEntityId;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeFieldInfoPtr_emptyEntityInAttributeResolved;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeFieldInfoPtr_validationEventHandling;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeFieldInfoPtr_onDefaultAttributeUse;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeFieldInfoPtr_validatingReaderCompatFlag;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeFieldInfoPtr_addDefaultAttributesAndNormalize;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeFieldInfoPtr_stringBuilder;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeFieldInfoPtr_rootElementParsed;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeFieldInfoPtr_standalone;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeFieldInfoPtr_nextEntityId;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeFieldInfoPtr_parsingMode;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeFieldInfoPtr_readState;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeFieldInfoPtr_lastEntity;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeFieldInfoPtr_afterResetState;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeFieldInfoPtr_documentStartBytePos;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeFieldInfoPtr_readValueOffset;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeFieldInfoPtr_charactersInDocument;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeFieldInfoPtr_charactersFromEntities;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeFieldInfoPtr_currentEntities;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeFieldInfoPtr_disableUndeclaredEntityCheck;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeFieldInfoPtr_outerReader;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolverIsSet;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeFieldInfoPtr_Xml;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeFieldInfoPtr_XmlNs;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeFieldInfoPtr_parseText_dummyTask;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlNameTable_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_XmlResolver_XmlReaderSettings_XmlParserContext_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Stream_XmlNameTable_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TextReader_XmlNameTable_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_TextReader_XmlNameTable_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_XmlNodeType_XmlParserContext_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_XmlParserContext_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_FinishInitUriString_Private_Void_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_Il2CppStructArray_1_Byte_Int32_XmlReaderSettings_Uri_String_XmlParserContext_Boolean_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_FinishInitStream_Private_Void_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TextReader_XmlReaderSettings_String_XmlParserContext_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_FinishInitTextReader_Private_Void_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_get_Boolean_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_FinishInit_Private_Void_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_set_OuterReader_Internal_set_Void_XmlReader_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_GetNamespacesInScope_Internal_IDictionary_2_String_String_XmlNamespaceScope_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Internal_String_String_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespaces_Internal_set_Void_Boolean_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_set_EntityHandling_Internal_set_Void_EntityHandling_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_get_IsResolverSet_Internal_get_Boolean_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_NameTable_Internal_get_XmlNameTable_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_NamespaceResolver_Internal_get_IXmlNamespaceResolver_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_DtdValidation_Internal_get_Boolean_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_Normalization_Internal_get_Boolean_0;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_Namespaces_Internal_get_Boolean_0;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_V1CompatibilityMode_Internal_get_Boolean_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_BaseUri_Internal_get_Uri_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_IsEof_Internal_get_Boolean_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_ParsingBuffer_Internal_get_Il2CppStructArray_1_Char_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_ParsingBufferLength_Internal_get_Int32_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_CurrentPosition_Internal_get_Int32_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_set_DtdParserProxy_CurrentPosition_Internal_set_Void_Int32_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_EntityStackLength_Internal_get_Int32_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_IsEntityEolNormalized_Internal_get_Boolean_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_ValidationEventHandling_Internal_get_IValidationEventHandling_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_OnNewLine_Internal_Void_Int32_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_LineNo_Internal_get_Int32_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_LineStartPosition_Internal_get_Int32_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_ReadData_Internal_Int32_0;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_ParseNumericCharRef_Internal_Int32_StringBuilder_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_ParseNamedCharRef_Internal_Int32_Boolean_StringBuilder_0;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_ParsePI_Internal_Void_StringBuilder_0;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_ParseComment_Internal_Void_StringBuilder_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_get_IsResolverNull_Private_get_Boolean_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_GetTempResolver_Private_XmlResolver_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_PushEntity_Internal_Boolean_IDtdEntityInfo_byref_Int32_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_PopEntity_Internal_Boolean_byref_IDtdEntityInfo_byref_Int32_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_PushExternalSubset_Internal_Boolean_String_String_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_PushInternalDtd_Internal_Void_String_String_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_Throw_Internal_Void_Exception_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_OnSystemId_Internal_Void_String_LineInfo_LineInfo_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_OnPublicId_Internal_Void_String_LineInfo_LineInfo_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_Int32_Int32_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_String_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_String_Exception_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_Exception_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Exception_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_ReThrow_Private_Void_Exception_Int32_Int32_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_String_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_Il2CppStringArray_Exception_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_SetErrorState_Private_Void_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_Int32_Int32_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_get_InAttributeValueIterator_Private_get_Boolean_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_FinishAttributeValueIterator_Private_Void_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdValidation_Private_get_Boolean_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_InitStreamInput_Private_Void_Stream_Encoding_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_InitStreamInput_Private_Void_String_Stream_Encoding_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_Stream_Encoding_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Encoding_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Il2CppStructArray_1_Byte_Int32_Encoding_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_TextReader_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_Uri_TextReader_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_InitStringInput_Private_Void_String_Encoding_String_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_InitFragmentReader_Private_Void_XmlNodeType_XmlParserContext_Boolean_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDtdFromParserContext_Private_Void_XmlParserContext_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_OpenUrl_Private_Void_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_OpenUrlDelegate_Private_Void_Object_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_DetectEncoding_Private_Encoding_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_SetupEncoding_Private_Void_Encoding_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_SwitchEncoding_Private_Void_Encoding_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_CheckEncoding_Private_Encoding_String_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_UnDecodeChars_Private_Void_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_SwitchEncodingToUTF8_Private_Void_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_ReadData_Private_Int32_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Private_Int32_Int32_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_InvalidCharRecovery_Private_Void_byref_Int32_byref_Int32_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_Close_Internal_Void_Boolean_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_ShiftBuffer_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_ParseXmlDeclaration_Private_Boolean_Boolean_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_ParseDocumentContent_Private_Boolean_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_ParseElementContent_Private_Boolean_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnclosedElements_Private_Void_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_ParseElement_Private_Void_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultAttributesAndNormalize_Private_Void_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_ParseEndElement_Private_Void_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_ThrowTagMismatch_Private_Void_NodeData_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttributes_Private_Void_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_ElementNamespaceLookup_Private_Void_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_AttributeNamespaceLookup_Private_Void_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_AttributeDuplCheck_Private_Void_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_OnDefaultNamespaceDecl_Private_Void_NodeData_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_OnNamespaceDecl_Private_Void_NodeData_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_OnXmlReservedAttribute_Private_Void_NodeData_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttributeValueSlow_Private_Void_Int32_Char_NodeData_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributeChunkToList_Private_Void_NodeData_NodeData_byref_NodeData_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_ParseText_Private_Boolean_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_ParseText_Private_Boolean_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_FinishPartialValue_Private_Void_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_FinishOtherValueIterator_Private_Void_0;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeMethodInfoPtr_SkipPartialTextValue_Private_Void_0;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeMethodInfoPtr_FinishReadValueChunk_Private_Void_0;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr_FinishReadContentAsBinary_Private_Void_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_FinishReadElementContentAsBinary_Private_Void_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_ParseRootLevelWhitespace_Private_Boolean_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_ParseEntityReference_Private_Void_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_HandleEntityReference_Private_EntityType_Boolean_EntityExpandType_byref_Int32_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_HandleGeneralEntityReference_Private_EntityType_String_Boolean_Boolean_Int32_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_get_InEntity_Private_get_Boolean_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_SetupEndEntityNodeInContent_Private_Void_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_SetupEndEntityNodeInAttribute_Private_Void_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_ParsePI_Private_Boolean_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_ParsePI_Private_Boolean_StringBuilder_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_ParsePIValue_Private_Boolean_byref_Int32_byref_Int32_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_ParseComment_Private_Boolean_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_ParseCData_Private_Void_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_ParseCDataOrComment_Private_Void_XmlNodeType_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_ParseCDataOrComment_Private_Boolean_XmlNodeType_byref_Int32_byref_Int32_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_ParseDoctypeDecl_Private_Boolean_0;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr_ParseDtd_Private_Void_0;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeMethodInfoPtr_SkipDtd_Private_Void_0;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr_SkipPublicOrSystemIdLiteral_Private_Void_0;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr_SkipUntil_Private_Void_Char_Boolean_0;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_EatWhitespaces_Private_Int32_StringBuilder_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_ParseCharRefInline_Private_Int32_Int32_byref_Int32_byref_EntityType_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumericCharRef_Private_Int32_Boolean_StringBuilder_byref_EntityType_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumericCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_byref_Int32_byref_EntityType_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_ParseNamedCharRef_Private_Int32_Boolean_StringBuilder_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_ParseNamedCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_ParseName_Private_Int32_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_ParseQName_Private_Int32_byref_Int32_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_ParseQName_Private_Int32_Boolean_Int32_byref_Int32_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_ReadDataInName_Private_Boolean_byref_Int32_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_ParseEntityName_Private_String_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_AddNode_Private_NodeData_Int32_Int32_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_AllocNode_Private_NodeData_Int32_Int32_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributeNoChecks_Private_NodeData_String_Int32_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Private_NodeData_Int32_Int32_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Private_NodeData_String_String_String_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_PopElementContext_Private_Void_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_OnNewLine_Private_Void_Int32_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_OnEof_Private_Void_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Private_String_NodeData_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_NodeData_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_ResetAttributes_Private_Void_0;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_FullAttributeCleanup_Private_Void_0;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_PushXmlContext_Private_Void_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_PopXmlContext_Private_Void_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_GetWhitespaceType_Private_XmlNodeType_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_GetTextNodeType_Private_XmlNodeType_Int32_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_PushExternalEntityOrSubset_Private_Void_String_String_Uri_String_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_OpenAndPush_Private_Boolean_Uri_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_PushExternalEntity_Private_Boolean_IDtdEntityInfo_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_PushInternalEntity_Private_Void_IDtdEntityInfo_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_PopEntity_Private_Void_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEntity_Private_Void_IDtdEntityInfo_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterEntity_Private_Void_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_PushParsingState_Private_Void_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_PopParsingState_Private_Void_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_IncrementalRead_Private_Int32_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_FinishIncrementalRead_Private_Void_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_ParseFragmentAttribute_Private_Boolean_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttributeValueChunk_Private_Boolean_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_ParseXmlDeclarationFragment_Private_Void_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_String_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_ThrowExpectingWhitespace_Private_Void_Int32_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexOfAttributeWithoutPrefix_Private_Int32_String_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexOfAttributeWithPrefix_Private_Int32_String_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_ZeroEndingStream_Private_Boolean_Int32_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_ParseDtdFromParserContext_Private_Void_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextContentNode_Private_Boolean_Boolean_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_SetupFromParserContext_Private_Void_XmlParserContext_XmlReaderSettings_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_get_IDtdInfo_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_SetDtdInfo_Internal_Void_IDtdInfo_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_set_ValidationEventHandling_Internal_set_Void_IValidationEventHandling_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_set_OnDefaultAttributeUse_Internal_set_Void_OnDefaultAttributeUseDelegate_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlValidatingReaderCompatibilityMode_Internal_set_Void_Boolean_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_get_FragmentType_Internal_get_XmlNodeType_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCurrentNodeType_Internal_Void_XmlNodeType_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_set_InternalSchemaType_Internal_set_Void_Object_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalTypedValue_Internal_get_Object_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_set_InternalTypedValue_Internal_set_Void_Object_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_get_StandAlone_Internal_get_Boolean_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceManager_Internal_Virtual_get_XmlNamespaceManager_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_get_V1Compat_Internal_get_Boolean_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultAttributeDtd_Private_Boolean_IDtdDefaultAttributeInfo_Boolean_Il2CppReferenceArray_1_NodeData_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultAttributeNonDtd_Internal_Boolean_SchemaAttDef_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultAttributeInternal_Private_NodeData_String_String_String_String_Int32_Int32_Int32_Int32_Boolean_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_set_DisableUndeclaredEntityCheck_Internal_set_Void_Boolean_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_UriEqual_Private_Boolean_Uri_String_String_XmlResolver_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_RegisterConsumedCharacters_Private_Void_Int64_Boolean_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_StripSpaces_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_byref_Int32_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_BlockCopyChars_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_BlockCopy_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x020001FB RID: 507
		[OriginalName("System.Xml.dll", "", "ParsingFunction")]
		public enum ParsingFunction
		{
			// Token: 0x04002047 RID: 8263
			ElementContent,
			// Token: 0x04002048 RID: 8264
			NoData,
			// Token: 0x04002049 RID: 8265
			OpenUrl,
			// Token: 0x0400204A RID: 8266
			SwitchToInteractive,
			// Token: 0x0400204B RID: 8267
			SwitchToInteractiveXmlDecl,
			// Token: 0x0400204C RID: 8268
			DocumentContent,
			// Token: 0x0400204D RID: 8269
			MoveToElementContent,
			// Token: 0x0400204E RID: 8270
			PopElementContext,
			// Token: 0x0400204F RID: 8271
			PopEmptyElementContext,
			// Token: 0x04002050 RID: 8272
			ResetAttributesRootLevel,
			// Token: 0x04002051 RID: 8273
			Error,
			// Token: 0x04002052 RID: 8274
			Eof,
			// Token: 0x04002053 RID: 8275
			ReaderClosed,
			// Token: 0x04002054 RID: 8276
			EntityReference,
			// Token: 0x04002055 RID: 8277
			InIncrementalRead,
			// Token: 0x04002056 RID: 8278
			FragmentAttribute,
			// Token: 0x04002057 RID: 8279
			ReportEndEntity,
			// Token: 0x04002058 RID: 8280
			AfterResolveEntityInContent,
			// Token: 0x04002059 RID: 8281
			AfterResolveEmptyEntityInContent,
			// Token: 0x0400205A RID: 8282
			XmlDeclarationFragment,
			// Token: 0x0400205B RID: 8283
			GoToEof,
			// Token: 0x0400205C RID: 8284
			PartialTextValue,
			// Token: 0x0400205D RID: 8285
			InReadAttributeValue,
			// Token: 0x0400205E RID: 8286
			InReadValueChunk,
			// Token: 0x0400205F RID: 8287
			InReadContentAsBinary,
			// Token: 0x04002060 RID: 8288
			InReadElementContentAsBinary
		}

		// Token: 0x020001FC RID: 508
		[OriginalName("System.Xml.dll", "", "ParsingMode")]
		public enum ParsingMode
		{
			// Token: 0x04002062 RID: 8290
			Full,
			// Token: 0x04002063 RID: 8291
			SkipNode,
			// Token: 0x04002064 RID: 8292
			SkipContent
		}

		// Token: 0x020001FD RID: 509
		[OriginalName("System.Xml.dll", "", "EntityType")]
		public enum EntityType
		{
			// Token: 0x04002066 RID: 8294
			CharacterDec,
			// Token: 0x04002067 RID: 8295
			CharacterHex,
			// Token: 0x04002068 RID: 8296
			CharacterNamed,
			// Token: 0x04002069 RID: 8297
			Expanded,
			// Token: 0x0400206A RID: 8298
			Skipped,
			// Token: 0x0400206B RID: 8299
			FakeExpanded,
			// Token: 0x0400206C RID: 8300
			Unexpanded,
			// Token: 0x0400206D RID: 8301
			ExpandedInAttribute
		}

		// Token: 0x020001FE RID: 510
		[OriginalName("System.Xml.dll", "", "EntityExpandType")]
		public enum EntityExpandType
		{
			// Token: 0x0400206F RID: 8303
			All,
			// Token: 0x04002070 RID: 8304
			OnlyGeneral,
			// Token: 0x04002071 RID: 8305
			OnlyCharacter
		}

		// Token: 0x020001FF RID: 511
		[OriginalName("System.Xml.dll", "", "IncrementalReadState")]
		public enum IncrementalReadState
		{
			// Token: 0x04002073 RID: 8307
			Text,
			// Token: 0x04002074 RID: 8308
			StartTag,
			// Token: 0x04002075 RID: 8309
			PI,
			// Token: 0x04002076 RID: 8310
			CDATA,
			// Token: 0x04002077 RID: 8311
			Comment,
			// Token: 0x04002078 RID: 8312
			Attributes,
			// Token: 0x04002079 RID: 8313
			AttributeValue,
			// Token: 0x0400207A RID: 8314
			ReadData,
			// Token: 0x0400207B RID: 8315
			EndElement,
			// Token: 0x0400207C RID: 8316
			End,
			// Token: 0x0400207D RID: 8317
			ReadValueChunk_OnCachedValue,
			// Token: 0x0400207E RID: 8318
			ReadValueChunk_OnPartialValue,
			// Token: 0x0400207F RID: 8319
			ReadContentAsBinary_OnCachedValue,
			// Token: 0x04002080 RID: 8320
			ReadContentAsBinary_OnPartialValue,
			// Token: 0x04002081 RID: 8321
			ReadContentAsBinary_End
		}

		// Token: 0x02000200 RID: 512
		public class LaterInitParam : Object
		{
			// Token: 0x06002A47 RID: 10823 RVA: 0x000C01A0 File Offset: 0x000BE3A0
			// Note: this type is marked as 'beforefieldinit'.
			static LaterInitParam()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "LaterInitParam");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr);
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_useAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "useAsync");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputStream");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputBytes");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputByteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputByteCount");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputbaseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputbaseUri");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputUriStr");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputUriResolver");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputContext");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputTextReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputTextReader");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_initType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "initType");
				XmlTextReaderImpl.LaterInitParam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, 100664476);
			}

			// Token: 0x06002A48 RID: 10824 RVA: 0x000C02A8 File Offset: 0x000BE4A8
			[CallerCount(0)]
			public unsafe LaterInitParam()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.LaterInitParam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A49 RID: 10825 RVA: 0x00011D9D File Offset: 0x0000FF9D
			public LaterInitParam(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E68 RID: 3688
			// (get) Token: 0x06002A4A RID: 10826 RVA: 0x000C02E4 File Offset: 0x000BE4E4
			// (set) Token: 0x06002A4B RID: 10827 RVA: 0x00011DA6 File Offset: 0x0000FFA6
			public unsafe bool useAsync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_useAsync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_useAsync)) = value;
				}
			}

			// Token: 0x17000E69 RID: 3689
			// (get) Token: 0x06002A4C RID: 10828 RVA: 0x000C030C File Offset: 0x000BE50C
			// (set) Token: 0x06002A4D RID: 10829 RVA: 0x00011DC1 File Offset: 0x0000FFC1
			public unsafe Stream inputStream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputStream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputStream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E6A RID: 3690
			// (get) Token: 0x06002A4E RID: 10830 RVA: 0x000C033C File Offset: 0x000BE53C
			// (set) Token: 0x06002A4F RID: 10831 RVA: 0x00011DE0 File Offset: 0x0000FFE0
			public unsafe Il2CppStructArray<byte> inputBytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputBytes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E6B RID: 3691
			// (get) Token: 0x06002A50 RID: 10832 RVA: 0x000C036C File Offset: 0x000BE56C
			// (set) Token: 0x06002A51 RID: 10833 RVA: 0x00011DFF File Offset: 0x0000FFFF
			public unsafe int inputByteCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputByteCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputByteCount)) = value;
				}
			}

			// Token: 0x17000E6C RID: 3692
			// (get) Token: 0x06002A52 RID: 10834 RVA: 0x000C0394 File Offset: 0x000BE594
			// (set) Token: 0x06002A53 RID: 10835 RVA: 0x00011E1A File Offset: 0x0001001A
			public unsafe Uri inputbaseUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputbaseUri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputbaseUri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E6D RID: 3693
			// (get) Token: 0x06002A54 RID: 10836 RVA: 0x000C03C4 File Offset: 0x000BE5C4
			// (set) Token: 0x06002A55 RID: 10837 RVA: 0x00011E39 File Offset: 0x00010039
			public unsafe string inputUriStr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriStr);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriStr), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000E6E RID: 3694
			// (get) Token: 0x06002A56 RID: 10838 RVA: 0x000C03EC File Offset: 0x000BE5EC
			// (set) Token: 0x06002A57 RID: 10839 RVA: 0x00011E58 File Offset: 0x00010058
			public unsafe XmlResolver inputUriResolver
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriResolver);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E6F RID: 3695
			// (get) Token: 0x06002A58 RID: 10840 RVA: 0x000C041C File Offset: 0x000BE61C
			// (set) Token: 0x06002A59 RID: 10841 RVA: 0x00011E77 File Offset: 0x00010077
			public unsafe XmlParserContext inputContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlParserContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E70 RID: 3696
			// (get) Token: 0x06002A5A RID: 10842 RVA: 0x000C044C File Offset: 0x000BE64C
			// (set) Token: 0x06002A5B RID: 10843 RVA: 0x00011E96 File Offset: 0x00010096
			public unsafe TextReader inputTextReader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputTextReader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputTextReader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E71 RID: 3697
			// (get) Token: 0x06002A5C RID: 10844 RVA: 0x000C047C File Offset: 0x000BE67C
			// (set) Token: 0x06002A5D RID: 10845 RVA: 0x00011EB5 File Offset: 0x000100B5
			public unsafe XmlTextReaderImpl.InitInputType initType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_initType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_initType)) = value;
				}
			}

			// Token: 0x04002082 RID: 8322
			private static readonly IntPtr NativeFieldInfoPtr_useAsync;

			// Token: 0x04002083 RID: 8323
			private static readonly IntPtr NativeFieldInfoPtr_inputStream;

			// Token: 0x04002084 RID: 8324
			private static readonly IntPtr NativeFieldInfoPtr_inputBytes;

			// Token: 0x04002085 RID: 8325
			private static readonly IntPtr NativeFieldInfoPtr_inputByteCount;

			// Token: 0x04002086 RID: 8326
			private static readonly IntPtr NativeFieldInfoPtr_inputbaseUri;

			// Token: 0x04002087 RID: 8327
			private static readonly IntPtr NativeFieldInfoPtr_inputUriStr;

			// Token: 0x04002088 RID: 8328
			private static readonly IntPtr NativeFieldInfoPtr_inputUriResolver;

			// Token: 0x04002089 RID: 8329
			private static readonly IntPtr NativeFieldInfoPtr_inputContext;

			// Token: 0x0400208A RID: 8330
			private static readonly IntPtr NativeFieldInfoPtr_inputTextReader;

			// Token: 0x0400208B RID: 8331
			private static readonly IntPtr NativeFieldInfoPtr_initType;

			// Token: 0x0400208C RID: 8332
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000201 RID: 513
		[OriginalName("System.Xml.dll", "", "InitInputType")]
		public enum InitInputType
		{
			// Token: 0x0400208E RID: 8334
			UriString,
			// Token: 0x0400208F RID: 8335
			Stream,
			// Token: 0x04002090 RID: 8336
			TextReader,
			// Token: 0x04002091 RID: 8337
			Invalid
		}

		// Token: 0x02000202 RID: 514
		public sealed class ParsingState : ValueType
		{
			// Token: 0x06002A5E RID: 10846 RVA: 0x000C04A4 File Offset: 0x000BE6A4
			// Note: this type is marked as 'beforefieldinit'.
			static ParsingState()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "ParsingState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr);
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "chars");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "charPos");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "charsUsed");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "encoding");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_appendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "appendMode");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "stream");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "decoder");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "bytes");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "bytePos");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytesUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "bytesUsed");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_textReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "textReader");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "lineNo");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "lineStartPos");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUriStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "baseUriStr");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "baseUri");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isEof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "isEof");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isStreamEof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "isStreamEof");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "entity");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "entityId");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_eolNormalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "eolNormalized");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityResolvedManually = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "entityResolvedManually");
				XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, 100664477);
				XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_Close_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, 100664478);
				XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, 100664479);
				XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, 100664480);
			}

			// Token: 0x06002A5F RID: 10847 RVA: 0x000C06C4 File Offset: 0x000BE8C4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 392191, RefRangeEnd = 392192, XrefRangeStart = 392189, XrefRangeEnd = 392191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A60 RID: 10848 RVA: 0x000C06FC File Offset: 0x000BE8FC
			[CallerCount(0)]
			public unsafe void Close(bool closeInput)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref closeInput;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_Close_Internal_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000E87 RID: 3719
			// (get) Token: 0x06002A61 RID: 10849 RVA: 0x000C0740 File Offset: 0x000BE940
			public unsafe int LineNo
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 93966, RefRangeEnd = 93969, XrefRangeStart = 93966, XrefRangeEnd = 93969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E88 RID: 3720
			// (get) Token: 0x06002A62 RID: 10850 RVA: 0x000C0784 File Offset: 0x000BE984
			public unsafe int LinePos
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 392192, RefRangeEnd = 392195, XrefRangeStart = 392192, XrefRangeEnd = 392192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002A63 RID: 10851 RVA: 0x00011ED0 File Offset: 0x000100D0
			public ParsingState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002A64 RID: 10852 RVA: 0x00011ED9 File Offset: 0x000100D9
			public ParsingState()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr))
			{
			}

			// Token: 0x17000E72 RID: 3698
			// (get) Token: 0x06002A65 RID: 10853 RVA: 0x000C07C8 File Offset: 0x000BE9C8
			// (set) Token: 0x06002A66 RID: 10854 RVA: 0x00011EEB File Offset: 0x000100EB
			public unsafe Il2CppStructArray<char> chars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_chars);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_chars), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E73 RID: 3699
			// (get) Token: 0x06002A67 RID: 10855 RVA: 0x000C07F8 File Offset: 0x000BE9F8
			// (set) Token: 0x06002A68 RID: 10856 RVA: 0x00011F0A File Offset: 0x0001010A
			public unsafe int charPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charPos)) = value;
				}
			}

			// Token: 0x17000E74 RID: 3700
			// (get) Token: 0x06002A69 RID: 10857 RVA: 0x000C0820 File Offset: 0x000BEA20
			// (set) Token: 0x06002A6A RID: 10858 RVA: 0x00011F25 File Offset: 0x00010125
			public unsafe int charsUsed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charsUsed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charsUsed)) = value;
				}
			}

			// Token: 0x17000E75 RID: 3701
			// (get) Token: 0x06002A6B RID: 10859 RVA: 0x000C0848 File Offset: 0x000BEA48
			// (set) Token: 0x06002A6C RID: 10860 RVA: 0x00011F40 File Offset: 0x00010140
			public unsafe Encoding encoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_encoding);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E76 RID: 3702
			// (get) Token: 0x06002A6D RID: 10861 RVA: 0x000C0878 File Offset: 0x000BEA78
			// (set) Token: 0x06002A6E RID: 10862 RVA: 0x00011F5F File Offset: 0x0001015F
			public unsafe bool appendMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_appendMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_appendMode)) = value;
				}
			}

			// Token: 0x17000E77 RID: 3703
			// (get) Token: 0x06002A6F RID: 10863 RVA: 0x000C08A0 File Offset: 0x000BEAA0
			// (set) Token: 0x06002A70 RID: 10864 RVA: 0x00011F7A File Offset: 0x0001017A
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E78 RID: 3704
			// (get) Token: 0x06002A71 RID: 10865 RVA: 0x000C08D0 File Offset: 0x000BEAD0
			// (set) Token: 0x06002A72 RID: 10866 RVA: 0x00011F99 File Offset: 0x00010199
			public unsafe Decoder decoder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_decoder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E79 RID: 3705
			// (get) Token: 0x06002A73 RID: 10867 RVA: 0x000C0900 File Offset: 0x000BEB00
			// (set) Token: 0x06002A74 RID: 10868 RVA: 0x00011FB8 File Offset: 0x000101B8
			public unsafe Il2CppStructArray<byte> bytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E7A RID: 3706
			// (get) Token: 0x06002A75 RID: 10869 RVA: 0x000C0930 File Offset: 0x000BEB30
			// (set) Token: 0x06002A76 RID: 10870 RVA: 0x00011FD7 File Offset: 0x000101D7
			public unsafe int bytePos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytePos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytePos)) = value;
				}
			}

			// Token: 0x17000E7B RID: 3707
			// (get) Token: 0x06002A77 RID: 10871 RVA: 0x000C0958 File Offset: 0x000BEB58
			// (set) Token: 0x06002A78 RID: 10872 RVA: 0x00011FF2 File Offset: 0x000101F2
			public unsafe int bytesUsed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytesUsed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytesUsed)) = value;
				}
			}

			// Token: 0x17000E7C RID: 3708
			// (get) Token: 0x06002A79 RID: 10873 RVA: 0x000C0980 File Offset: 0x000BEB80
			// (set) Token: 0x06002A7A RID: 10874 RVA: 0x0001200D File Offset: 0x0001020D
			public unsafe TextReader textReader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_textReader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_textReader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E7D RID: 3709
			// (get) Token: 0x06002A7B RID: 10875 RVA: 0x000C09B0 File Offset: 0x000BEBB0
			// (set) Token: 0x06002A7C RID: 10876 RVA: 0x0001202C File Offset: 0x0001022C
			public unsafe int lineNo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineNo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineNo)) = value;
				}
			}

			// Token: 0x17000E7E RID: 3710
			// (get) Token: 0x06002A7D RID: 10877 RVA: 0x000C09D8 File Offset: 0x000BEBD8
			// (set) Token: 0x06002A7E RID: 10878 RVA: 0x00012047 File Offset: 0x00010247
			public unsafe int lineStartPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineStartPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineStartPos)) = value;
				}
			}

			// Token: 0x17000E7F RID: 3711
			// (get) Token: 0x06002A7F RID: 10879 RVA: 0x000C0A00 File Offset: 0x000BEC00
			// (set) Token: 0x06002A80 RID: 10880 RVA: 0x00012062 File Offset: 0x00010262
			public unsafe string baseUriStr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUriStr);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUriStr), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000E80 RID: 3712
			// (get) Token: 0x06002A81 RID: 10881 RVA: 0x000C0A28 File Offset: 0x000BEC28
			// (set) Token: 0x06002A82 RID: 10882 RVA: 0x00012081 File Offset: 0x00010281
			public unsafe Uri baseUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E81 RID: 3713
			// (get) Token: 0x06002A83 RID: 10883 RVA: 0x000C0A58 File Offset: 0x000BEC58
			// (set) Token: 0x06002A84 RID: 10884 RVA: 0x000120A0 File Offset: 0x000102A0
			public unsafe bool isEof
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isEof);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isEof)) = value;
				}
			}

			// Token: 0x17000E82 RID: 3714
			// (get) Token: 0x06002A85 RID: 10885 RVA: 0x000C0A80 File Offset: 0x000BEC80
			// (set) Token: 0x06002A86 RID: 10886 RVA: 0x000120BB File Offset: 0x000102BB
			public unsafe bool isStreamEof
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isStreamEof);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isStreamEof)) = value;
				}
			}

			// Token: 0x17000E83 RID: 3715
			// (get) Token: 0x06002A87 RID: 10887 RVA: 0x000C0AA8 File Offset: 0x000BECA8
			// (set) Token: 0x06002A88 RID: 10888 RVA: 0x000120D6 File Offset: 0x000102D6
			public unsafe IDtdEntityInfo entity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdEntityInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E84 RID: 3716
			// (get) Token: 0x06002A89 RID: 10889 RVA: 0x000C0AD8 File Offset: 0x000BECD8
			// (set) Token: 0x06002A8A RID: 10890 RVA: 0x000120F5 File Offset: 0x000102F5
			public unsafe int entityId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityId)) = value;
				}
			}

			// Token: 0x17000E85 RID: 3717
			// (get) Token: 0x06002A8B RID: 10891 RVA: 0x000C0B00 File Offset: 0x000BED00
			// (set) Token: 0x06002A8C RID: 10892 RVA: 0x00012110 File Offset: 0x00010310
			public unsafe bool eolNormalized
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_eolNormalized);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_eolNormalized)) = value;
				}
			}

			// Token: 0x17000E86 RID: 3718
			// (get) Token: 0x06002A8D RID: 10893 RVA: 0x000C0B28 File Offset: 0x000BED28
			// (set) Token: 0x06002A8E RID: 10894 RVA: 0x0001212B File Offset: 0x0001032B
			public unsafe bool entityResolvedManually
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityResolvedManually);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityResolvedManually)) = value;
				}
			}

			// Token: 0x04002092 RID: 8338
			private static readonly IntPtr NativeFieldInfoPtr_chars;

			// Token: 0x04002093 RID: 8339
			private static readonly IntPtr NativeFieldInfoPtr_charPos;

			// Token: 0x04002094 RID: 8340
			private static readonly IntPtr NativeFieldInfoPtr_charsUsed;

			// Token: 0x04002095 RID: 8341
			private static readonly IntPtr NativeFieldInfoPtr_encoding;

			// Token: 0x04002096 RID: 8342
			private static readonly IntPtr NativeFieldInfoPtr_appendMode;

			// Token: 0x04002097 RID: 8343
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x04002098 RID: 8344
			private static readonly IntPtr NativeFieldInfoPtr_decoder;

			// Token: 0x04002099 RID: 8345
			private static readonly IntPtr NativeFieldInfoPtr_bytes;

			// Token: 0x0400209A RID: 8346
			private static readonly IntPtr NativeFieldInfoPtr_bytePos;

			// Token: 0x0400209B RID: 8347
			private static readonly IntPtr NativeFieldInfoPtr_bytesUsed;

			// Token: 0x0400209C RID: 8348
			private static readonly IntPtr NativeFieldInfoPtr_textReader;

			// Token: 0x0400209D RID: 8349
			private static readonly IntPtr NativeFieldInfoPtr_lineNo;

			// Token: 0x0400209E RID: 8350
			private static readonly IntPtr NativeFieldInfoPtr_lineStartPos;

			// Token: 0x0400209F RID: 8351
			private static readonly IntPtr NativeFieldInfoPtr_baseUriStr;

			// Token: 0x040020A0 RID: 8352
			private static readonly IntPtr NativeFieldInfoPtr_baseUri;

			// Token: 0x040020A1 RID: 8353
			private static readonly IntPtr NativeFieldInfoPtr_isEof;

			// Token: 0x040020A2 RID: 8354
			private static readonly IntPtr NativeFieldInfoPtr_isStreamEof;

			// Token: 0x040020A3 RID: 8355
			private static readonly IntPtr NativeFieldInfoPtr_entity;

			// Token: 0x040020A4 RID: 8356
			private static readonly IntPtr NativeFieldInfoPtr_entityId;

			// Token: 0x040020A5 RID: 8357
			private static readonly IntPtr NativeFieldInfoPtr_eolNormalized;

			// Token: 0x040020A6 RID: 8358
			private static readonly IntPtr NativeFieldInfoPtr_entityResolvedManually;

			// Token: 0x040020A7 RID: 8359
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

			// Token: 0x040020A8 RID: 8360
			private static readonly IntPtr NativeMethodInfoPtr_Close_Internal_Void_Boolean_0;

			// Token: 0x040020A9 RID: 8361
			private static readonly IntPtr NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0;

			// Token: 0x040020AA RID: 8362
			private static readonly IntPtr NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0;
		}

		// Token: 0x02000203 RID: 515
		public class XmlContext : Object
		{
			// Token: 0x06002A8F RID: 10895 RVA: 0x000C0B50 File Offset: 0x000BED50
			// Note: this type is marked as 'beforefieldinit'.
			static XmlContext()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "XmlContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr);
				XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, "xmlSpace");
				XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, "xmlLang");
				XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_defaultNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, "defaultNamespace");
				XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_previousContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, "previousContext");
				XmlTextReaderImpl.XmlContext.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, 100664481);
				XmlTextReaderImpl.XmlContext.NativeMethodInfoPtr__ctor_Internal_Void_XmlContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, 100664482);
			}

			// Token: 0x06002A90 RID: 10896 RVA: 0x000C0BF4 File Offset: 0x000BEDF4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 392198, RefRangeEnd = 392200, XrefRangeStart = 392195, XrefRangeEnd = 392198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XmlContext()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.XmlContext.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A91 RID: 10897 RVA: 0x000C0C30 File Offset: 0x000BEE30
			[CallerCount(0)]
			public unsafe XmlContext(XmlTextReaderImpl.XmlContext previousContext)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousContext);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.XmlContext.NativeMethodInfoPtr__ctor_Internal_Void_XmlContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A92 RID: 10898 RVA: 0x00012146 File Offset: 0x00010346
			public XmlContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E89 RID: 3721
			// (get) Token: 0x06002A93 RID: 10899 RVA: 0x000C0C7C File Offset: 0x000BEE7C
			// (set) Token: 0x06002A94 RID: 10900 RVA: 0x0001214F File Offset: 0x0001034F
			public unsafe XmlSpace xmlSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlSpace)) = value;
				}
			}

			// Token: 0x17000E8A RID: 3722
			// (get) Token: 0x06002A95 RID: 10901 RVA: 0x000C0CA4 File Offset: 0x000BEEA4
			// (set) Token: 0x06002A96 RID: 10902 RVA: 0x0001216A File Offset: 0x0001036A
			public unsafe string xmlLang
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlLang);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlLang), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000E8B RID: 3723
			// (get) Token: 0x06002A97 RID: 10903 RVA: 0x000C0CCC File Offset: 0x000BEECC
			// (set) Token: 0x06002A98 RID: 10904 RVA: 0x00012189 File Offset: 0x00010389
			public unsafe string defaultNamespace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_defaultNamespace);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_defaultNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000E8C RID: 3724
			// (get) Token: 0x06002A99 RID: 10905 RVA: 0x000C0CF4 File Offset: 0x000BEEF4
			// (set) Token: 0x06002A9A RID: 10906 RVA: 0x000121A8 File Offset: 0x000103A8
			public unsafe XmlTextReaderImpl.XmlContext previousContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_previousContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.XmlContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_previousContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020AB RID: 8363
			private static readonly IntPtr NativeFieldInfoPtr_xmlSpace;

			// Token: 0x040020AC RID: 8364
			private static readonly IntPtr NativeFieldInfoPtr_xmlLang;

			// Token: 0x040020AD RID: 8365
			private static readonly IntPtr NativeFieldInfoPtr_defaultNamespace;

			// Token: 0x040020AE RID: 8366
			private static readonly IntPtr NativeFieldInfoPtr_previousContext;

			// Token: 0x040020AF RID: 8367
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x040020B0 RID: 8368
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlContext_0;
		}

		// Token: 0x02000204 RID: 516
		public class NoNamespaceManager : XmlNamespaceManager
		{
			// Token: 0x06002A9B RID: 10907 RVA: 0x000C0D24 File Offset: 0x000BEF24
			// Note: this type is marked as 'beforefieldinit'.
			static NoNamespaceManager()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "NoNamespaceManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664483);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664484);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_PushScope_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664485);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_PopScope_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664486);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_AddNamespace_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664487);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664488);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664489);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664490);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664491);
			}

			// Token: 0x06002A9C RID: 10908 RVA: 0x000C0E04 File Offset: 0x000BF004
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NoNamespaceManager()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E8D RID: 3725
			// (get) Token: 0x06002A9D RID: 10909 RVA: 0x000C0E40 File Offset: 0x000BF040
			public unsafe override string DefaultNamespace
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392200, XrefRangeEnd = 392202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002A9E RID: 10910 RVA: 0x000C0E84 File Offset: 0x000BF084
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void PushScope()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_PushScope_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A9F RID: 10911 RVA: 0x000C0EC0 File Offset: 0x000BF0C0
			[CallerCount(0)]
			public unsafe override bool PopScope()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_PopScope_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002AA0 RID: 10912 RVA: 0x000C0F08 File Offset: 0x000BF108
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void AddNamespace(string prefix, string uri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_AddNamespace_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AA1 RID: 10913 RVA: 0x000C0F68 File Offset: 0x000BF168
			[CallerCount(0)]
			public unsafe override IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002AA2 RID: 10914 RVA: 0x000C0FB4 File Offset: 0x000BF1B4
			[CallerCount(0)]
			public unsafe override IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref scope;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_IDictionary_2_String_String_XmlNamespaceScope_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
				}
			}

			// Token: 0x06002AA3 RID: 10915 RVA: 0x000C100C File Offset: 0x000BF20C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392202, XrefRangeEnd = 392204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string LookupNamespace(string prefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002AA4 RID: 10916 RVA: 0x000C1060 File Offset: 0x000BF260
			[CallerCount(0)]
			public unsafe override string LookupPrefix(string uri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002AA5 RID: 10917 RVA: 0x000121C7 File Offset: 0x000103C7
			public NoNamespaceManager(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040020B1 RID: 8369
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040020B2 RID: 8370
			private static readonly IntPtr NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_get_String_0;

			// Token: 0x040020B3 RID: 8371
			private static readonly IntPtr NativeMethodInfoPtr_PushScope_Public_Virtual_Void_0;

			// Token: 0x040020B4 RID: 8372
			private static readonly IntPtr NativeMethodInfoPtr_PopScope_Public_Virtual_Boolean_0;

			// Token: 0x040020B5 RID: 8373
			private static readonly IntPtr NativeMethodInfoPtr_AddNamespace_Public_Virtual_Void_String_String_0;

			// Token: 0x040020B6 RID: 8374
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0;

			// Token: 0x040020B7 RID: 8375
			private static readonly IntPtr NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_IDictionary_2_String_String_XmlNamespaceScope_0;

			// Token: 0x040020B8 RID: 8376
			private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;

			// Token: 0x040020B9 RID: 8377
			private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0;
		}

		// Token: 0x02000205 RID: 517
		public class DtdParserProxy : Object
		{
			// Token: 0x06002AA6 RID: 10918 RVA: 0x000C10B4 File Offset: 0x000BF2B4
			// Note: this type is marked as 'beforefieldinit'.
			static DtdParserProxy()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "DtdParserProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr);
				XmlTextReaderImpl.DtdParserProxy.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, "reader");
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr__ctor_Internal_Void_XmlTextReaderImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664492);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NameTable_Private_Virtual_Final_New_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664493);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NamespaceResolver_Private_Virtual_Final_New_get_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664494);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_BaseUri_Private_Virtual_Final_New_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664495);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEof_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664496);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBuffer_Private_Virtual_Final_New_get_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664497);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBufferLength_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664498);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_CurrentPosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664499);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_set_CurrentPosition_Private_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664500);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_EntityStackLength_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664501);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEntityEolNormalized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664502);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnNewLine_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664503);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineNo_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664504);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineStartPosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664505);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ReadData_Private_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664506);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNumericCharRef_Private_Virtual_Final_New_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664507);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNamedCharRef_Private_Virtual_Final_New_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664508);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParsePI_Private_Virtual_Final_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664509);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseComment_Private_Virtual_Final_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664510);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushEntity_Private_Virtual_Final_New_Boolean_IDtdEntityInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664511);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PopEntity_Private_Virtual_Final_New_Boolean_byref_IDtdEntityInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664512);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushExternalSubset_Private_Virtual_Final_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664513);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushInternalDtd_Private_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664514);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_Throw_Private_Virtual_Final_New_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664515);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnSystemId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664516);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnPublicId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664517);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_DtdValidation_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664518);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_ValidationEventHandling_Private_Virtual_Final_New_get_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664519);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Normalization_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664520);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Namespaces_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664521);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_V1CompatibilityMode_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664522);
			}

			// Token: 0x06002AA7 RID: 10919 RVA: 0x000C1360 File Offset: 0x000BF560
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DtdParserProxy(XmlTextReaderImpl reader)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr__ctor_Internal_Void_XmlTextReaderImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000E8F RID: 3727
			// (get) Token: 0x06002AA8 RID: 10920 RVA: 0x000C13AC File Offset: 0x000BF5AC
			public unsafe virtual XmlNameTable System.Xml.IDtdParserAdapter.NameTable
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NameTable_Private_Virtual_Final_New_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
				}
			}

			// Token: 0x17000E90 RID: 3728
			// (get) Token: 0x06002AA9 RID: 10921 RVA: 0x000C13EC File Offset: 0x000BF5EC
			public unsafe virtual IXmlNamespaceResolver System.Xml.IDtdParserAdapter.NamespaceResolver
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NamespaceResolver_Private_Virtual_Final_New_get_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr3) : null;
				}
			}

			// Token: 0x17000E91 RID: 3729
			// (get) Token: 0x06002AAA RID: 10922 RVA: 0x000C142C File Offset: 0x000BF62C
			public unsafe virtual Uri System.Xml.IDtdParserAdapter.BaseUri
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392204, XrefRangeEnd = 392208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_BaseUri_Private_Virtual_Final_New_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
				}
			}

			// Token: 0x17000E92 RID: 3730
			// (get) Token: 0x06002AAB RID: 10923 RVA: 0x000C146C File Offset: 0x000BF66C
			public unsafe virtual bool System.Xml.IDtdParserAdapter.IsEof
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEof_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E93 RID: 3731
			// (get) Token: 0x06002AAC RID: 10924 RVA: 0x000C14A8 File Offset: 0x000BF6A8
			public unsafe virtual Il2CppStructArray<char> System.Xml.IDtdParserAdapter.ParsingBuffer
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBuffer_Private_Virtual_Final_New_get_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
				}
			}

			// Token: 0x17000E94 RID: 3732
			// (get) Token: 0x06002AAD RID: 10925 RVA: 0x000C14E8 File Offset: 0x000BF6E8
			public unsafe virtual int System.Xml.IDtdParserAdapter.ParsingBufferLength
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBufferLength_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E95 RID: 3733
			// (get) Token: 0x06002AAE RID: 10926 RVA: 0x000C1524 File Offset: 0x000BF724
			// (set) Token: 0x06002AAF RID: 10927 RVA: 0x000C1560 File Offset: 0x000BF760
			public unsafe virtual int System.Xml.IDtdParserAdapter.CurrentPosition
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_CurrentPosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_set_CurrentPosition_Private_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000E96 RID: 3734
			// (get) Token: 0x06002AB0 RID: 10928 RVA: 0x000C15A0 File Offset: 0x000BF7A0
			public unsafe virtual int System.Xml.IDtdParserAdapter.EntityStackLength
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_EntityStackLength_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E97 RID: 3735
			// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x000C15DC File Offset: 0x000BF7DC
			public unsafe virtual bool System.Xml.IDtdParserAdapter.IsEntityEolNormalized
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEntityEolNormalized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002AB2 RID: 10930 RVA: 0x000C1618 File Offset: 0x000BF818
			[CallerCount(0)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_OnNewLine(int pos)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref pos;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnNewLine_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000E98 RID: 3736
			// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x000C1658 File Offset: 0x000BF858
			public unsafe virtual int System.Xml.IDtdParserAdapter.LineNo
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineNo_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E99 RID: 3737
			// (get) Token: 0x06002AB4 RID: 10932 RVA: 0x000C1694 File Offset: 0x000BF894
			public unsafe virtual int System.Xml.IDtdParserAdapter.LineStartPosition
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineStartPosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002AB5 RID: 10933 RVA: 0x000C16D0 File Offset: 0x000BF8D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392208, XrefRangeEnd = 392210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Xml_IDtdParserAdapter_ReadData()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ReadData_Private_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002AB6 RID: 10934 RVA: 0x000C170C File Offset: 0x000BF90C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392210, XrefRangeEnd = 392214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Xml_IDtdParserAdapter_ParseNumericCharRef(StringBuilder internalSubsetBuilder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNumericCharRef_Private_Virtual_Final_New_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002AB7 RID: 10935 RVA: 0x000C175C File Offset: 0x000BF95C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392214, XrefRangeEnd = 392216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Xml_IDtdParserAdapter_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref expand;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNamedCharRef_Private_Virtual_Final_New_Int32_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002AB8 RID: 10936 RVA: 0x000C17B8 File Offset: 0x000BF9B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392216, XrefRangeEnd = 392218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_ParsePI(StringBuilder sb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParsePI_Private_Virtual_Final_New_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002AB9 RID: 10937 RVA: 0x000C17FC File Offset: 0x000BF9FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392218, XrefRangeEnd = 392220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_ParseComment(StringBuilder sb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseComment_Private_Virtual_Final_New_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002ABA RID: 10938 RVA: 0x000C1840 File Offset: 0x000BFA40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392220, XrefRangeEnd = 392224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Xml_IDtdParserAdapter_PushEntity(IDtdEntityInfo entity, out int entityId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushEntity_Private_Virtual_Final_New_Boolean_IDtdEntityInfo_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002ABB RID: 10939 RVA: 0x000C189C File Offset: 0x000BFA9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392224, XrefRangeEnd = 392225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Xml_IDtdParserAdapter_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = 0;
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &newEntityId;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PopEntity_Private_Virtual_Final_New_Boolean_byref_IDtdEntityInfo_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				oldEntity = ((intPtr4 == 0) ? null : new IDtdEntityInfo(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06002ABC RID: 10940 RVA: 0x000C1908 File Offset: 0x000BFB08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392225, XrefRangeEnd = 392232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Xml_IDtdParserAdapter_PushExternalSubset(string systemId, string publicId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(systemId);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushExternalSubset_Private_Virtual_Final_New_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002ABD RID: 10941 RVA: 0x000C1968 File Offset: 0x000BFB68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392232, XrefRangeEnd = 392236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_PushInternalDtd(string baseUri, string internalDtd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalDtd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushInternalDtd_Private_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ABE RID: 10942 RVA: 0x000C19BC File Offset: 0x000BFBBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392236, XrefRangeEnd = 392239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_Throw(Exception e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_Throw_Private_Virtual_Final_New_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002ABF RID: 10943 RVA: 0x000C1A00 File Offset: 0x000BFC00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392239, XrefRangeEnd = 392242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(systemId);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywordLineInfo;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref systemLiteralLineInfo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnSystemId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AC0 RID: 10944 RVA: 0x000C1A60 File Offset: 0x000BFC60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392242, XrefRangeEnd = 392245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(publicId);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywordLineInfo;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref publicLiteralLineInfo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnPublicId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E9A RID: 3738
			// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x000C1AC0 File Offset: 0x000BFCC0
			public unsafe virtual bool System.Xml.IDtdParserAdapterWithValidation.DtdValidation
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_DtdValidation_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E9B RID: 3739
			// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x000C1AFC File Offset: 0x000BFCFC
			public unsafe virtual IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.ValidationEventHandling
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_ValidationEventHandling_Private_Virtual_Final_New_get_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IValidationEventHandling>(intPtr3) : null;
				}
			}

			// Token: 0x17000E9C RID: 3740
			// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x000C1B3C File Offset: 0x000BFD3C
			public unsafe virtual bool System.Xml.IDtdParserAdapterV1.Normalization
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Normalization_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E9D RID: 3741
			// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x000C1B78 File Offset: 0x000BFD78
			public unsafe virtual bool System.Xml.IDtdParserAdapterV1.Namespaces
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Namespaces_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E9E RID: 3742
			// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x000C1BB4 File Offset: 0x000BFDB4
			public unsafe virtual bool System.Xml.IDtdParserAdapterV1.V1CompatibilityMode
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_V1CompatibilityMode_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002AC6 RID: 10950 RVA: 0x000121D0 File Offset: 0x000103D0
			public DtdParserProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E8E RID: 3726
			// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x000C1BF0 File Offset: 0x000BFDF0
			// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x000121D9 File Offset: 0x000103D9
			public unsafe XmlTextReaderImpl reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.DtdParserProxy.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.DtdParserProxy.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020BA RID: 8378
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x040020BB RID: 8379
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlTextReaderImpl_0;

			// Token: 0x040020BC RID: 8380
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NameTable_Private_Virtual_Final_New_get_XmlNameTable_0;

			// Token: 0x040020BD RID: 8381
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NamespaceResolver_Private_Virtual_Final_New_get_IXmlNamespaceResolver_0;

			// Token: 0x040020BE RID: 8382
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_BaseUri_Private_Virtual_Final_New_get_Uri_0;

			// Token: 0x040020BF RID: 8383
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEof_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040020C0 RID: 8384
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBuffer_Private_Virtual_Final_New_get_Il2CppStructArray_1_Char_0;

			// Token: 0x040020C1 RID: 8385
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBufferLength_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x040020C2 RID: 8386
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_CurrentPosition_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x040020C3 RID: 8387
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_set_CurrentPosition_Private_Virtual_Final_New_set_Void_Int32_0;

			// Token: 0x040020C4 RID: 8388
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_EntityStackLength_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x040020C5 RID: 8389
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEntityEolNormalized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040020C6 RID: 8390
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnNewLine_Private_Virtual_Final_New_Void_Int32_0;

			// Token: 0x040020C7 RID: 8391
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineNo_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x040020C8 RID: 8392
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineStartPosition_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x040020C9 RID: 8393
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ReadData_Private_Virtual_Final_New_Int32_0;

			// Token: 0x040020CA RID: 8394
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNumericCharRef_Private_Virtual_Final_New_Int32_StringBuilder_0;

			// Token: 0x040020CB RID: 8395
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNamedCharRef_Private_Virtual_Final_New_Int32_Boolean_StringBuilder_0;

			// Token: 0x040020CC RID: 8396
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParsePI_Private_Virtual_Final_New_Void_StringBuilder_0;

			// Token: 0x040020CD RID: 8397
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseComment_Private_Virtual_Final_New_Void_StringBuilder_0;

			// Token: 0x040020CE RID: 8398
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushEntity_Private_Virtual_Final_New_Boolean_IDtdEntityInfo_byref_Int32_0;

			// Token: 0x040020CF RID: 8399
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PopEntity_Private_Virtual_Final_New_Boolean_byref_IDtdEntityInfo_byref_Int32_0;

			// Token: 0x040020D0 RID: 8400
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushExternalSubset_Private_Virtual_Final_New_Boolean_String_String_0;

			// Token: 0x040020D1 RID: 8401
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushInternalDtd_Private_Virtual_Final_New_Void_String_String_0;

			// Token: 0x040020D2 RID: 8402
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_Throw_Private_Virtual_Final_New_Void_Exception_0;

			// Token: 0x040020D3 RID: 8403
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnSystemId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0;

			// Token: 0x040020D4 RID: 8404
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnPublicId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0;

			// Token: 0x040020D5 RID: 8405
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_DtdValidation_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040020D6 RID: 8406
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_ValidationEventHandling_Private_Virtual_Final_New_get_IValidationEventHandling_0;

			// Token: 0x040020D7 RID: 8407
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Normalization_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040020D8 RID: 8408
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Namespaces_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040020D9 RID: 8409
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_V1CompatibilityMode_Private_Virtual_Final_New_get_Boolean_0;
		}

		// Token: 0x02000206 RID: 518
		public class NodeData : Object
		{
			// Token: 0x06002AC9 RID: 10953 RVA: 0x000C1C20 File Offset: 0x000BFE20
			// Note: this type is marked as 'beforefieldinit'.
			static NodeData()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "NodeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr);
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_s_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "s_None");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "type");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "localName");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "prefix");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "ns");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nameWPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "nameWPrefix");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "value");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "chars");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "valueStartPos");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "valueLength");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "lineInfo");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "lineInfo2");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_quoteChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "quoteChar");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "depth");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_isEmptyOrDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "isEmptyOrDefault");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_entityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "entityId");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_xmlContextPushed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "xmlContextPushed");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nextAttrValueChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "nextAttrValueChunk");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "schemaType");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_typedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "typedValue");
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_None_Internal_Static_get_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664523);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664524);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664525);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664526);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_IsEmptyElement_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664527);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_set_IsEmptyElement_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664528);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_IsDefaultAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664529);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_set_IsDefaultAttribute_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664530);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_ValueBuffered_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664531);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_StringValue_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664532);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_TrimSpacesInValue_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664533);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_Clear_Internal_Void_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664534);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_ClearName_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664535);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664536);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetLineInfo2_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664537);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664538);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664539);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664540);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664541);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValue_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664542);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValue_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664543);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_OnBufferInvalidated_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664544);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_CopyTo_Internal_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664545);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_GetNameWPrefix_Internal_String_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664546);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_CreateNameWPrefix_Internal_String_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664547);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664548);
			}

			// Token: 0x17000EB3 RID: 3763
			// (get) Token: 0x06002ACA RID: 10954 RVA: 0x000C1FE4 File Offset: 0x000C01E4
			public unsafe static XmlTextReaderImpl.NodeData None
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392245, XrefRangeEnd = 392252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_None_Internal_Static_get_NodeData_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
				}
			}

			// Token: 0x06002ACB RID: 10955 RVA: 0x000C2018 File Offset: 0x000C0218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392252, XrefRangeEnd = 392253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NodeData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000EB4 RID: 3764
			// (get) Token: 0x06002ACC RID: 10956 RVA: 0x000C2054 File Offset: 0x000C0254
			public unsafe int LineNo
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000EB5 RID: 3765
			// (get) Token: 0x06002ACD RID: 10957 RVA: 0x000C2090 File Offset: 0x000C0290
			public unsafe int LinePos
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000EB6 RID: 3766
			// (get) Token: 0x06002ACE RID: 10958 RVA: 0x000C20CC File Offset: 0x000C02CC
			// (set) Token: 0x06002ACF RID: 10959 RVA: 0x000C2108 File Offset: 0x000C0308
			public unsafe bool IsEmptyElement
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_IsEmptyElement_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_set_IsEmptyElement_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000EB7 RID: 3767
			// (get) Token: 0x06002AD0 RID: 10960 RVA: 0x000C2148 File Offset: 0x000C0348
			// (set) Token: 0x06002AD1 RID: 10961 RVA: 0x000C2184 File Offset: 0x000C0384
			public unsafe bool IsDefaultAttribute
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_IsDefaultAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_set_IsDefaultAttribute_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000EB8 RID: 3768
			// (get) Token: 0x06002AD2 RID: 10962 RVA: 0x000C21C4 File Offset: 0x000C03C4
			public unsafe bool ValueBuffered
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_ValueBuffered_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000EB9 RID: 3769
			// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x000C2200 File Offset: 0x000C0400
			public unsafe string StringValue
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 392254, RefRangeEnd = 392261, XrefRangeStart = 392253, XrefRangeEnd = 392254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_StringValue_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002AD4 RID: 10964 RVA: 0x000C2238 File Offset: 0x000C0438
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 392262, RefRangeEnd = 392264, XrefRangeStart = 392261, XrefRangeEnd = 392262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void TrimSpacesInValue()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_TrimSpacesInValue_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AD5 RID: 10965 RVA: 0x000C226C File Offset: 0x000C046C
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 392268, RefRangeEnd = 392280, XrefRangeStart = 392264, XrefRangeEnd = 392268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear(XmlNodeType type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_Clear_Internal_Void_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002AD6 RID: 10966 RVA: 0x000C22AC File Offset: 0x000C04AC
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 392285, RefRangeEnd = 392291, XrefRangeStart = 392280, XrefRangeEnd = 392285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ClearName()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_ClearName_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AD7 RID: 10967 RVA: 0x000C22E0 File Offset: 0x000C04E0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 392291, RefRangeEnd = 392292, XrefRangeStart = 392291, XrefRangeEnd = 392291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetLineInfo(int lineNo, int linePos)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lineNo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AD8 RID: 10968 RVA: 0x000C232C File Offset: 0x000C052C
			[CallerCount(0)]
			public unsafe void SetLineInfo2(int lineNo, int linePos)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lineNo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetLineInfo2_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AD9 RID: 10969 RVA: 0x000C2378 File Offset: 0x000C0578
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 392293, RefRangeEnd = 392297, XrefRangeStart = 392292, XrefRangeEnd = 392293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetValueNode(XmlNodeType type, string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ADA RID: 10970 RVA: 0x000C23C8 File Offset: 0x000C05C8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 392298, RefRangeEnd = 392300, XrefRangeStart = 392297, XrefRangeEnd = 392298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetValueNode(XmlNodeType type, Il2CppStructArray<char> chars, int startPos, int len)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ADB RID: 10971 RVA: 0x000C2434 File Offset: 0x000C0634
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 392303, RefRangeEnd = 392305, XrefRangeStart = 392300, XrefRangeEnd = 392303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetNamedNode(XmlNodeType type, string localName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ADC RID: 10972 RVA: 0x000C2484 File Offset: 0x000C0684
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 392308, RefRangeEnd = 392319, XrefRangeStart = 392305, XrefRangeEnd = 392308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nameWPrefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ADD RID: 10973 RVA: 0x000C24FC File Offset: 0x000C06FC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 392319, RefRangeEnd = 392326, XrefRangeStart = 392319, XrefRangeEnd = 392319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetValue(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValue_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002ADE RID: 10974 RVA: 0x000C2540 File Offset: 0x000C0740
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 392326, RefRangeEnd = 392329, XrefRangeStart = 392326, XrefRangeEnd = 392326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetValue(Il2CppStructArray<char> chars, int startPos, int len)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValue_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ADF RID: 10975 RVA: 0x000C25A0 File Offset: 0x000C07A0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 392330, RefRangeEnd = 392332, XrefRangeStart = 392329, XrefRangeEnd = 392330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnBufferInvalidated()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_OnBufferInvalidated_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AE0 RID: 10976 RVA: 0x000C25D4 File Offset: 0x000C07D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392332, XrefRangeEnd = 392333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyTo(int valueOffset, StringBuilder sb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref valueOffset;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_CopyTo_Internal_Void_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AE1 RID: 10977 RVA: 0x000C2624 File Offset: 0x000C0824
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 392337, RefRangeEnd = 392343, XrefRangeStart = 392333, XrefRangeEnd = 392337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetNameWPrefix(XmlNameTable nt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_GetNameWPrefix_Internal_String_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002AE2 RID: 10978 RVA: 0x000C266C File Offset: 0x000C086C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392343, XrefRangeEnd = 392346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string CreateNameWPrefix(XmlNameTable nt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_CreateNameWPrefix_Internal_String_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002AE3 RID: 10979 RVA: 0x000C26B4 File Offset: 0x000C08B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392346, XrefRangeEnd = 392349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_IComparable_CompareTo(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002AE4 RID: 10980 RVA: 0x000121F8 File Offset: 0x000103F8
			public NodeData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E9F RID: 3743
			// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x000C2704 File Offset: 0x000C0904
			// (set) Token: 0x06002AE6 RID: 10982 RVA: 0x00012201 File Offset: 0x00010401
			public unsafe static XmlTextReaderImpl.NodeData s_None
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_s_None, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_s_None, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EA0 RID: 3744
			// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x000C272C File Offset: 0x000C092C
			// (set) Token: 0x06002AE8 RID: 10984 RVA: 0x00012213 File Offset: 0x00010413
			public unsafe XmlNodeType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x17000EA1 RID: 3745
			// (get) Token: 0x06002AE9 RID: 10985 RVA: 0x000C2754 File Offset: 0x000C0954
			// (set) Token: 0x06002AEA RID: 10986 RVA: 0x0001222E File Offset: 0x0001042E
			public unsafe string localName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_localName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EA2 RID: 3746
			// (get) Token: 0x06002AEB RID: 10987 RVA: 0x000C277C File Offset: 0x000C097C
			// (set) Token: 0x06002AEC RID: 10988 RVA: 0x0001224D File Offset: 0x0001044D
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EA3 RID: 3747
			// (get) Token: 0x06002AED RID: 10989 RVA: 0x000C27A4 File Offset: 0x000C09A4
			// (set) Token: 0x06002AEE RID: 10990 RVA: 0x0001226C File Offset: 0x0001046C
			public unsafe string ns
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_ns);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EA4 RID: 3748
			// (get) Token: 0x06002AEF RID: 10991 RVA: 0x000C27CC File Offset: 0x000C09CC
			// (set) Token: 0x06002AF0 RID: 10992 RVA: 0x0001228B File Offset: 0x0001048B
			public unsafe string nameWPrefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nameWPrefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nameWPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EA5 RID: 3749
			// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x000C27F4 File Offset: 0x000C09F4
			// (set) Token: 0x06002AF2 RID: 10994 RVA: 0x000122AA File Offset: 0x000104AA
			public unsafe string value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EA6 RID: 3750
			// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x000C281C File Offset: 0x000C0A1C
			// (set) Token: 0x06002AF4 RID: 10996 RVA: 0x000122C9 File Offset: 0x000104C9
			public unsafe Il2CppStructArray<char> chars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_chars);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_chars), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EA7 RID: 3751
			// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x000C284C File Offset: 0x000C0A4C
			// (set) Token: 0x06002AF6 RID: 10998 RVA: 0x000122E8 File Offset: 0x000104E8
			public unsafe int valueStartPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueStartPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueStartPos)) = value;
				}
			}

			// Token: 0x17000EA8 RID: 3752
			// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x000C2874 File Offset: 0x000C0A74
			// (set) Token: 0x06002AF8 RID: 11000 RVA: 0x00012303 File Offset: 0x00010503
			public unsafe int valueLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueLength)) = value;
				}
			}

			// Token: 0x17000EA9 RID: 3753
			// (get) Token: 0x06002AF9 RID: 11001 RVA: 0x000C289C File Offset: 0x000C0A9C
			// (set) Token: 0x06002AFA RID: 11002 RVA: 0x0001231E File Offset: 0x0001051E
			public unsafe LineInfo lineInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo)) = value;
				}
			}

			// Token: 0x17000EAA RID: 3754
			// (get) Token: 0x06002AFB RID: 11003 RVA: 0x000C28C4 File Offset: 0x000C0AC4
			// (set) Token: 0x06002AFC RID: 11004 RVA: 0x00012339 File Offset: 0x00010539
			public unsafe LineInfo lineInfo2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo2)) = value;
				}
			}

			// Token: 0x17000EAB RID: 3755
			// (get) Token: 0x06002AFD RID: 11005 RVA: 0x000C28EC File Offset: 0x000C0AEC
			// (set) Token: 0x06002AFE RID: 11006 RVA: 0x00012354 File Offset: 0x00010554
			public unsafe char quoteChar
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_quoteChar);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_quoteChar)) = value;
				}
			}

			// Token: 0x17000EAC RID: 3756
			// (get) Token: 0x06002AFF RID: 11007 RVA: 0x000C2914 File Offset: 0x000C0B14
			// (set) Token: 0x06002B00 RID: 11008 RVA: 0x0001236F File Offset: 0x0001056F
			public unsafe int depth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_depth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_depth)) = value;
				}
			}

			// Token: 0x17000EAD RID: 3757
			// (get) Token: 0x06002B01 RID: 11009 RVA: 0x000C293C File Offset: 0x000C0B3C
			// (set) Token: 0x06002B02 RID: 11010 RVA: 0x0001238A File Offset: 0x0001058A
			public unsafe bool isEmptyOrDefault
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_isEmptyOrDefault);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_isEmptyOrDefault)) = value;
				}
			}

			// Token: 0x17000EAE RID: 3758
			// (get) Token: 0x06002B03 RID: 11011 RVA: 0x000C2964 File Offset: 0x000C0B64
			// (set) Token: 0x06002B04 RID: 11012 RVA: 0x000123A5 File Offset: 0x000105A5
			public unsafe int entityId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_entityId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_entityId)) = value;
				}
			}

			// Token: 0x17000EAF RID: 3759
			// (get) Token: 0x06002B05 RID: 11013 RVA: 0x000C298C File Offset: 0x000C0B8C
			// (set) Token: 0x06002B06 RID: 11014 RVA: 0x000123C0 File Offset: 0x000105C0
			public unsafe bool xmlContextPushed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_xmlContextPushed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_xmlContextPushed)) = value;
				}
			}

			// Token: 0x17000EB0 RID: 3760
			// (get) Token: 0x06002B07 RID: 11015 RVA: 0x000C29B4 File Offset: 0x000C0BB4
			// (set) Token: 0x06002B08 RID: 11016 RVA: 0x000123DB File Offset: 0x000105DB
			public unsafe XmlTextReaderImpl.NodeData nextAttrValueChunk
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nextAttrValueChunk);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nextAttrValueChunk), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EB1 RID: 3761
			// (get) Token: 0x06002B09 RID: 11017 RVA: 0x000C29E4 File Offset: 0x000C0BE4
			// (set) Token: 0x06002B0A RID: 11018 RVA: 0x000123FA File Offset: 0x000105FA
			public unsafe Object schemaType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_schemaType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_schemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EB2 RID: 3762
			// (get) Token: 0x06002B0B RID: 11019 RVA: 0x000C2A14 File Offset: 0x000C0C14
			// (set) Token: 0x06002B0C RID: 11020 RVA: 0x00012419 File Offset: 0x00010619
			public unsafe Object typedValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_typedValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_typedValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020DA RID: 8410
			private static readonly IntPtr NativeFieldInfoPtr_s_None;

			// Token: 0x040020DB RID: 8411
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040020DC RID: 8412
			private static readonly IntPtr NativeFieldInfoPtr_localName;

			// Token: 0x040020DD RID: 8413
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x040020DE RID: 8414
			private static readonly IntPtr NativeFieldInfoPtr_ns;

			// Token: 0x040020DF RID: 8415
			private static readonly IntPtr NativeFieldInfoPtr_nameWPrefix;

			// Token: 0x040020E0 RID: 8416
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040020E1 RID: 8417
			private static readonly IntPtr NativeFieldInfoPtr_chars;

			// Token: 0x040020E2 RID: 8418
			private static readonly IntPtr NativeFieldInfoPtr_valueStartPos;

			// Token: 0x040020E3 RID: 8419
			private static readonly IntPtr NativeFieldInfoPtr_valueLength;

			// Token: 0x040020E4 RID: 8420
			private static readonly IntPtr NativeFieldInfoPtr_lineInfo;

			// Token: 0x040020E5 RID: 8421
			private static readonly IntPtr NativeFieldInfoPtr_lineInfo2;

			// Token: 0x040020E6 RID: 8422
			private static readonly IntPtr NativeFieldInfoPtr_quoteChar;

			// Token: 0x040020E7 RID: 8423
			private static readonly IntPtr NativeFieldInfoPtr_depth;

			// Token: 0x040020E8 RID: 8424
			private static readonly IntPtr NativeFieldInfoPtr_isEmptyOrDefault;

			// Token: 0x040020E9 RID: 8425
			private static readonly IntPtr NativeFieldInfoPtr_entityId;

			// Token: 0x040020EA RID: 8426
			private static readonly IntPtr NativeFieldInfoPtr_xmlContextPushed;

			// Token: 0x040020EB RID: 8427
			private static readonly IntPtr NativeFieldInfoPtr_nextAttrValueChunk;

			// Token: 0x040020EC RID: 8428
			private static readonly IntPtr NativeFieldInfoPtr_schemaType;

			// Token: 0x040020ED RID: 8429
			private static readonly IntPtr NativeFieldInfoPtr_typedValue;

			// Token: 0x040020EE RID: 8430
			private static readonly IntPtr NativeMethodInfoPtr_get_None_Internal_Static_get_NodeData_0;

			// Token: 0x040020EF RID: 8431
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x040020F0 RID: 8432
			private static readonly IntPtr NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0;

			// Token: 0x040020F1 RID: 8433
			private static readonly IntPtr NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0;

			// Token: 0x040020F2 RID: 8434
			private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptyElement_Internal_get_Boolean_0;

			// Token: 0x040020F3 RID: 8435
			private static readonly IntPtr NativeMethodInfoPtr_set_IsEmptyElement_Internal_set_Void_Boolean_0;

			// Token: 0x040020F4 RID: 8436
			private static readonly IntPtr NativeMethodInfoPtr_get_IsDefaultAttribute_Internal_get_Boolean_0;

			// Token: 0x040020F5 RID: 8437
			private static readonly IntPtr NativeMethodInfoPtr_set_IsDefaultAttribute_Internal_set_Void_Boolean_0;

			// Token: 0x040020F6 RID: 8438
			private static readonly IntPtr NativeMethodInfoPtr_get_ValueBuffered_Internal_get_Boolean_0;

			// Token: 0x040020F7 RID: 8439
			private static readonly IntPtr NativeMethodInfoPtr_get_StringValue_Internal_get_String_0;

			// Token: 0x040020F8 RID: 8440
			private static readonly IntPtr NativeMethodInfoPtr_TrimSpacesInValue_Internal_Void_0;

			// Token: 0x040020F9 RID: 8441
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_XmlNodeType_0;

			// Token: 0x040020FA RID: 8442
			private static readonly IntPtr NativeMethodInfoPtr_ClearName_Internal_Void_0;

			// Token: 0x040020FB RID: 8443
			private static readonly IntPtr NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0;

			// Token: 0x040020FC RID: 8444
			private static readonly IntPtr NativeMethodInfoPtr_SetLineInfo2_Internal_Void_Int32_Int32_0;

			// Token: 0x040020FD RID: 8445
			private static readonly IntPtr NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_String_0;

			// Token: 0x040020FE RID: 8446
			private static readonly IntPtr NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x040020FF RID: 8447
			private static readonly IntPtr NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_0;

			// Token: 0x04002100 RID: 8448
			private static readonly IntPtr NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_String_String_0;

			// Token: 0x04002101 RID: 8449
			private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Void_String_0;

			// Token: 0x04002102 RID: 8450
			private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04002103 RID: 8451
			private static readonly IntPtr NativeMethodInfoPtr_OnBufferInvalidated_Internal_Void_0;

			// Token: 0x04002104 RID: 8452
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Internal_Void_Int32_StringBuilder_0;

			// Token: 0x04002105 RID: 8453
			private static readonly IntPtr NativeMethodInfoPtr_GetNameWPrefix_Internal_String_XmlNameTable_0;

			// Token: 0x04002106 RID: 8454
			private static readonly IntPtr NativeMethodInfoPtr_CreateNameWPrefix_Internal_String_XmlNameTable_0;

			// Token: 0x04002107 RID: 8455
			private static readonly IntPtr NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0;
		}

		// Token: 0x02000207 RID: 519
		public class DtdDefaultAttributeInfoToNodeDataComparer : Object
		{
			// Token: 0x06002B0D RID: 11021 RVA: 0x000C2A44 File Offset: 0x000C0C44
			// Note: this type is marked as 'beforefieldinit'.
			static DtdDefaultAttributeInfoToNodeDataComparer()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "DtdDefaultAttributeInfoToNodeDataComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr);
				XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr, "s_instance");
				XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr_get_Instance_Internal_Static_get_IComparer_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr, 100664549);
				XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr, 100664550);
				XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr, 100664551);
			}

			// Token: 0x17000EBB RID: 3771
			// (get) Token: 0x06002B0E RID: 11022 RVA: 0x000C2AC0 File Offset: 0x000C0CC0
			public unsafe static IComparer<Object> Instance
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392349, XrefRangeEnd = 392353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr_get_Instance_Internal_Static_get_IComparer_1_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer<Object>>(intPtr3) : null;
				}
			}

			// Token: 0x06002B0F RID: 11023 RVA: 0x000C2AF4 File Offset: 0x000C0CF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392353, XrefRangeEnd = 392378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Compare(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002B10 RID: 11024 RVA: 0x000C2B54 File Offset: 0x000C0D54
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DtdDefaultAttributeInfoToNodeDataComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B11 RID: 11025 RVA: 0x00012438 File Offset: 0x00010638
			public DtdDefaultAttributeInfoToNodeDataComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EBA RID: 3770
			// (get) Token: 0x06002B12 RID: 11026 RVA: 0x000C2B90 File Offset: 0x000C0D90
			// (set) Token: 0x06002B13 RID: 11027 RVA: 0x00012441 File Offset: 0x00010641
			public unsafe static IComparer<Object> s_instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeFieldInfoPtr_s_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002108 RID: 8456
			private static readonly IntPtr NativeFieldInfoPtr_s_instance;

			// Token: 0x04002109 RID: 8457
			private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Internal_Static_get_IComparer_1_Object_0;

			// Token: 0x0400210A RID: 8458
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;

			// Token: 0x0400210B RID: 8459
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000208 RID: 520
		public sealed class OnDefaultAttributeUseDelegate : MulticastDelegate
		{
			// Token: 0x06002B14 RID: 11028 RVA: 0x000C2BB8 File Offset: 0x000C0DB8
			// Note: this type is marked as 'beforefieldinit'.
			static OnDefaultAttributeUseDelegate()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "OnDefaultAttributeUseDelegate");
				XmlTextReaderImpl.OnDefaultAttributeUseDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>.NativeClassPtr, 100664553);
				XmlTextReaderImpl.OnDefaultAttributeUseDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IDtdDefaultAttributeInfo_XmlTextReaderImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>.NativeClassPtr, 100664554);
				XmlTextReaderImpl.OnDefaultAttributeUseDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IDtdDefaultAttributeInfo_XmlTextReaderImpl_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>.NativeClassPtr, 100664555);
				XmlTextReaderImpl.OnDefaultAttributeUseDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>.NativeClassPtr, 100664556);
			}

			// Token: 0x06002B15 RID: 11029 RVA: 0x000C2C2C File Offset: 0x000C0E2C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnDefaultAttributeUseDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.OnDefaultAttributeUseDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B16 RID: 11030 RVA: 0x000C2C88 File Offset: 0x000C0E88
			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 41391, RefRangeEnd = 41473, XrefRangeStart = 41391, XrefRangeEnd = 41473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(defaultAttribute);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coreReader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.OnDefaultAttributeUseDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IDtdDefaultAttributeInfo_XmlTextReaderImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B17 RID: 11031 RVA: 0x000C2CDC File Offset: 0x000C0EDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(defaultAttribute);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coreReader);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.OnDefaultAttributeUseDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IDtdDefaultAttributeInfo_XmlTextReaderImpl_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002B18 RID: 11032 RVA: 0x000C2D64 File Offset: 0x000C0F64
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.OnDefaultAttributeUseDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B19 RID: 11033 RVA: 0x00012453 File Offset: 0x00010653
			public OnDefaultAttributeUseDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002B1A RID: 11034 RVA: 0x0001245C File Offset: 0x0001065C
			public static implicit operator XmlTextReaderImpl.OnDefaultAttributeUseDelegate(Action<IDtdDefaultAttributeInfo, XmlTextReaderImpl> A_0)
			{
				return DelegateSupport.ConvertDelegate<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>(A_0);
			}

			// Token: 0x06002B1B RID: 11035 RVA: 0x00012464 File Offset: 0x00010664
			public static XmlTextReaderImpl.OnDefaultAttributeUseDelegate operator +(XmlTextReaderImpl.OnDefaultAttributeUseDelegate A_0, XmlTextReaderImpl.OnDefaultAttributeUseDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>();
			}

			// Token: 0x06002B1C RID: 11036 RVA: 0x00012472 File Offset: 0x00010672
			public static XmlTextReaderImpl.OnDefaultAttributeUseDelegate operator -(XmlTextReaderImpl.OnDefaultAttributeUseDelegate A_0, XmlTextReaderImpl.OnDefaultAttributeUseDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>();
				}
				return delegate2;
			}

			// Token: 0x0400210C RID: 8460
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400210D RID: 8461
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IDtdDefaultAttributeInfo_XmlTextReaderImpl_0;

			// Token: 0x0400210E RID: 8462
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IDtdDefaultAttributeInfo_XmlTextReaderImpl_AsyncCallback_Object_0;

			// Token: 0x0400210F RID: 8463
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
