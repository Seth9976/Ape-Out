using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000091 RID: 145
	public class DtdParser : Object
	{
		// Token: 0x06000E5C RID: 3676 RVA: 0x00051B48 File Offset: 0x0004FD48
		// Note: this type is marked as 'beforefieldinit'.
		static DtdParser()
		{
			Il2CppClassPointerStore<DtdParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "DtdParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DtdParser>.NativeClassPtr);
			DtdParser.NativeFieldInfoPtr_readerAdapter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "readerAdapter");
			DtdParser.NativeFieldInfoPtr_readerAdapterWithValidation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "readerAdapterWithValidation");
			DtdParser.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "nameTable");
			DtdParser.NativeFieldInfoPtr_schemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "schemaInfo");
			DtdParser.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "xmlCharType");
			DtdParser.NativeFieldInfoPtr_systemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "systemId");
			DtdParser.NativeFieldInfoPtr_publicId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "publicId");
			DtdParser.NativeFieldInfoPtr_normalize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "normalize");
			DtdParser.NativeFieldInfoPtr_validate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "validate");
			DtdParser.NativeFieldInfoPtr_supportNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "supportNamespaces");
			DtdParser.NativeFieldInfoPtr_v1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "v1Compat");
			DtdParser.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "chars");
			DtdParser.NativeFieldInfoPtr_charsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "charsUsed");
			DtdParser.NativeFieldInfoPtr_curPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "curPos");
			DtdParser.NativeFieldInfoPtr_scanningFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "scanningFunction");
			DtdParser.NativeFieldInfoPtr_nextScaningFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "nextScaningFunction");
			DtdParser.NativeFieldInfoPtr_savedScanningFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "savedScanningFunction");
			DtdParser.NativeFieldInfoPtr_whitespaceSeen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "whitespaceSeen");
			DtdParser.NativeFieldInfoPtr_tokenStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "tokenStartPos");
			DtdParser.NativeFieldInfoPtr_colonPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "colonPos");
			DtdParser.NativeFieldInfoPtr_internalSubsetValueSb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "internalSubsetValueSb");
			DtdParser.NativeFieldInfoPtr_externalEntitiesDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "externalEntitiesDepth");
			DtdParser.NativeFieldInfoPtr_currentEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "currentEntityId");
			DtdParser.NativeFieldInfoPtr_freeFloatingDtd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "freeFloatingDtd");
			DtdParser.NativeFieldInfoPtr_hasFreeFloatingInternalSubset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "hasFreeFloatingInternalSubset");
			DtdParser.NativeFieldInfoPtr_stringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "stringBuilder");
			DtdParser.NativeFieldInfoPtr_condSectionDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "condSectionDepth");
			DtdParser.NativeFieldInfoPtr_literalLineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "literalLineInfo");
			DtdParser.NativeFieldInfoPtr_literalQuoteChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "literalQuoteChar");
			DtdParser.NativeFieldInfoPtr_documentBaseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "documentBaseUri");
			DtdParser.NativeFieldInfoPtr_externalDtdBaseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "externalDtdBaseUri");
			DtdParser.NativeFieldInfoPtr_undeclaredNotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "undeclaredNotations");
			DtdParser.NativeFieldInfoPtr_condSectionEntityIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "condSectionEntityIds");
			DtdParser.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665572);
			DtdParser.NativeMethodInfoPtr_Create_Internal_Static_IDtdParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665573);
			DtdParser.NativeMethodInfoPtr_Initialize_Private_Void_IDtdParserAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665574);
			DtdParser.NativeMethodInfoPtr_InitializeFreeFloatingDtd_Private_Void_String_String_String_String_String_IDtdParserAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665575);
			DtdParser.NativeMethodInfoPtr_System_Xml_IDtdParser_ParseInternalDtd_Private_Virtual_Final_New_IDtdInfo_IDtdParserAdapter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665576);
			DtdParser.NativeMethodInfoPtr_System_Xml_IDtdParser_ParseFreeFloatingDtd_Private_Virtual_Final_New_IDtdInfo_String_String_String_String_String_IDtdParserAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665577);
			DtdParser.NativeMethodInfoPtr_get_ParsingInternalSubset_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665578);
			DtdParser.NativeMethodInfoPtr_get_IgnoreEntityReferences_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665579);
			DtdParser.NativeMethodInfoPtr_get_SaveInternalSubsetValue_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665580);
			DtdParser.NativeMethodInfoPtr_get_ParsingTopLevelMarkup_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665581);
			DtdParser.NativeMethodInfoPtr_get_SupportNamespaces_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665582);
			DtdParser.NativeMethodInfoPtr_get_Normalize_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665583);
			DtdParser.NativeMethodInfoPtr_Parse_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665584);
			DtdParser.NativeMethodInfoPtr_ParseInDocumentDtd_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665585);
			DtdParser.NativeMethodInfoPtr_ParseFreeFloatingDtd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665586);
			DtdParser.NativeMethodInfoPtr_ParseInternalSubset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665587);
			DtdParser.NativeMethodInfoPtr_ParseExternalSubset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665588);
			DtdParser.NativeMethodInfoPtr_ParseSubset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665589);
			DtdParser.NativeMethodInfoPtr_ParseAttlistDecl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665590);
			DtdParser.NativeMethodInfoPtr_ParseAttlistType_Private_Void_SchemaAttDef_SchemaElementDecl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665591);
			DtdParser.NativeMethodInfoPtr_ParseAttlistDefault_Private_Void_SchemaAttDef_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665592);
			DtdParser.NativeMethodInfoPtr_ParseElementDecl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665593);
			DtdParser.NativeMethodInfoPtr_ParseElementOnlyContent_Private_Void_ParticleContentValidator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665594);
			DtdParser.NativeMethodInfoPtr_ParseHowMany_Private_Void_ParticleContentValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665595);
			DtdParser.NativeMethodInfoPtr_ParseElementMixedContent_Private_Void_ParticleContentValidator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665596);
			DtdParser.NativeMethodInfoPtr_ParseEntityDecl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665597);
			DtdParser.NativeMethodInfoPtr_ParseNotationDecl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665598);
			DtdParser.NativeMethodInfoPtr_AddUndeclaredNotation_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665599);
			DtdParser.NativeMethodInfoPtr_ParseComment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665600);
			DtdParser.NativeMethodInfoPtr_ParsePI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665601);
			DtdParser.NativeMethodInfoPtr_ParseCondSection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665602);
			DtdParser.NativeMethodInfoPtr_ParseExternalId_Private_Void_Token_Token_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665603);
			DtdParser.NativeMethodInfoPtr_GetToken_Private_Token_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665604);
			DtdParser.NativeMethodInfoPtr_ScanSubsetContent_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665605);
			DtdParser.NativeMethodInfoPtr_ScanNameExpected_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665606);
			DtdParser.NativeMethodInfoPtr_ScanQNameExpected_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665607);
			DtdParser.NativeMethodInfoPtr_ScanNmtokenExpected_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665608);
			DtdParser.NativeMethodInfoPtr_ScanDoctype1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665609);
			DtdParser.NativeMethodInfoPtr_ScanDoctype2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665610);
			DtdParser.NativeMethodInfoPtr_ScanClosingTag_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665611);
			DtdParser.NativeMethodInfoPtr_ScanElement1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665612);
			DtdParser.NativeMethodInfoPtr_ScanElement2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665613);
			DtdParser.NativeMethodInfoPtr_ScanElement3_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665614);
			DtdParser.NativeMethodInfoPtr_ScanElement4_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665615);
			DtdParser.NativeMethodInfoPtr_ScanElement5_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665616);
			DtdParser.NativeMethodInfoPtr_ScanElement6_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665617);
			DtdParser.NativeMethodInfoPtr_ScanElement7_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665618);
			DtdParser.NativeMethodInfoPtr_ScanAttlist1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665619);
			DtdParser.NativeMethodInfoPtr_ScanAttlist2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665620);
			DtdParser.NativeMethodInfoPtr_ScanAttlist3_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665621);
			DtdParser.NativeMethodInfoPtr_ScanAttlist4_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665622);
			DtdParser.NativeMethodInfoPtr_ScanAttlist5_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665623);
			DtdParser.NativeMethodInfoPtr_ScanAttlist6_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665624);
			DtdParser.NativeMethodInfoPtr_ScanAttlist7_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665625);
			DtdParser.NativeMethodInfoPtr_ScanLiteral_Private_Token_LiteralType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665626);
			DtdParser.NativeMethodInfoPtr_ScanEntityName_Private_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665627);
			DtdParser.NativeMethodInfoPtr_ScanNotation1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665628);
			DtdParser.NativeMethodInfoPtr_ScanSystemId_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665629);
			DtdParser.NativeMethodInfoPtr_ScanEntity1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665630);
			DtdParser.NativeMethodInfoPtr_ScanEntity2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665631);
			DtdParser.NativeMethodInfoPtr_ScanEntity3_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665632);
			DtdParser.NativeMethodInfoPtr_ScanPublicId1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665633);
			DtdParser.NativeMethodInfoPtr_ScanPublicId2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665634);
			DtdParser.NativeMethodInfoPtr_ScanCondSection1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665635);
			DtdParser.NativeMethodInfoPtr_ScanCondSection2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665636);
			DtdParser.NativeMethodInfoPtr_ScanCondSection3_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665637);
			DtdParser.NativeMethodInfoPtr_ScanName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665638);
			DtdParser.NativeMethodInfoPtr_ScanQName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665639);
			DtdParser.NativeMethodInfoPtr_ScanQName_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665640);
			DtdParser.NativeMethodInfoPtr_ReadDataInName_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665641);
			DtdParser.NativeMethodInfoPtr_ScanNmtoken_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665642);
			DtdParser.NativeMethodInfoPtr_EatPublicKeyword_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665643);
			DtdParser.NativeMethodInfoPtr_EatSystemKeyword_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665644);
			DtdParser.NativeMethodInfoPtr_GetNameQualified_Private_XmlQualifiedName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665645);
			DtdParser.NativeMethodInfoPtr_GetNameString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665646);
			DtdParser.NativeMethodInfoPtr_GetNmtokenString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665647);
			DtdParser.NativeMethodInfoPtr_GetValue_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665648);
			DtdParser.NativeMethodInfoPtr_GetValueWithStrippedSpaces_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665649);
			DtdParser.NativeMethodInfoPtr_ReadData_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665650);
			DtdParser.NativeMethodInfoPtr_LoadParsingBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665651);
			DtdParser.NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665652);
			DtdParser.NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665653);
			DtdParser.NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665654);
			DtdParser.NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_XmlQualifiedName_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665655);
			DtdParser.NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665656);
			DtdParser.NativeMethodInfoPtr_VerifyEntityReference_Private_SchemaEntity_XmlQualifiedName_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665657);
			DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_Int32_XmlSeverityType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665658);
			DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665659);
			DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665660);
			DtdParser.NativeMethodInfoPtr_IsAttributeValueType_Private_Boolean_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665661);
			DtdParser.NativeMethodInfoPtr_get_LineNo_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665662);
			DtdParser.NativeMethodInfoPtr_get_LinePos_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665663);
			DtdParser.NativeMethodInfoPtr_get_BaseUriStr_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665664);
			DtdParser.NativeMethodInfoPtr_OnUnexpectedError_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665665);
			DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665666);
			DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665667);
			DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665668);
			DtdParser.NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665669);
			DtdParser.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665670);
			DtdParser.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665671);
			DtdParser.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665672);
			DtdParser.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665673);
			DtdParser.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665674);
			DtdParser.NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665675);
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0005262C File Offset: 0x0005082C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 399190, RefRangeEnd = 399197, XrefRangeStart = 399184, XrefRangeEnd = 399190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DtdParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00052668 File Offset: 0x00050868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399197, XrefRangeEnd = 399201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDtdParser Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Create_Internal_Static_IDtdParser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdParser>(intPtr3) : null;
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x0005269C File Offset: 0x0005089C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 399234, RefRangeEnd = 399236, XrefRangeStart = 399201, XrefRangeEnd = 399234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(IDtdParserAdapter readerAdapter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(readerAdapter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Initialize_Private_Void_IDtdParserAdapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x000526E0 File Offset: 0x000508E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399271, RefRangeEnd = 399272, XrefRangeStart = 399236, XrefRangeEnd = 399271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(docTypeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adapter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_InitializeFreeFloatingDtd_Private_Void_String_String_String_String_String_IDtdParserAdapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00052780 File Offset: 0x00050980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399272, XrefRangeEnd = 399274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDtdInfo System_Xml_IDtdParser_ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(adapter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveInternalSubset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_System_Xml_IDtdParser_ParseInternalDtd_Private_Virtual_Final_New_IDtdInfo_IDtdParserAdapter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr3) : null;
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x000527E0 File Offset: 0x000509E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399274, XrefRangeEnd = 399276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDtdInfo System_Xml_IDtdParser_ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(docTypeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adapter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_System_Xml_IDtdParser_ParseFreeFloatingDtd_Private_Virtual_Final_New_IDtdInfo_String_String_String_String_String_IDtdParserAdapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr3) : null;
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00052890 File Offset: 0x00050A90
		public unsafe bool ParsingInternalSubset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_ParsingInternalSubset_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x000528CC File Offset: 0x00050ACC
		public unsafe bool IgnoreEntityReferences
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_IgnoreEntityReferences_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x00052908 File Offset: 0x00050B08
		public unsafe bool SaveInternalSubsetValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399276, XrefRangeEnd = 399279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_SaveInternalSubsetValue_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x00052944 File Offset: 0x00050B44
		public unsafe bool ParsingTopLevelMarkup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_ParsingTopLevelMarkup_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x00052980 File Offset: 0x00050B80
		public unsafe bool SupportNamespaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_SupportNamespaces_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x000529BC File Offset: 0x00050BBC
		public unsafe bool Normalize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_Normalize_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x000529F8 File Offset: 0x00050BF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 399305, RefRangeEnd = 399307, XrefRangeStart = 399279, XrefRangeEnd = 399305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Parse(bool saveInternalSubset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref saveInternalSubset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Parse_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00052A38 File Offset: 0x00050C38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399328, RefRangeEnd = 399329, XrefRangeStart = 399307, XrefRangeEnd = 399328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseInDocumentDtd(bool saveInternalSubset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref saveInternalSubset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseInDocumentDtd_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00052A78 File Offset: 0x00050C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399329, XrefRangeEnd = 399333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseFreeFloatingDtd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseFreeFloatingDtd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00052AAC File Offset: 0x00050CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399333, XrefRangeEnd = 399334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseInternalSubset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseInternalSubset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00052AE0 File Offset: 0x00050CE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 399344, RefRangeEnd = 399347, XrefRangeStart = 399334, XrefRangeEnd = 399344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseExternalSubset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseExternalSubset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00052B14 File Offset: 0x00050D14
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 399419, RefRangeEnd = 399424, XrefRangeStart = 399347, XrefRangeEnd = 399419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseSubset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseSubset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00052B48 File Offset: 0x00050D48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399497, RefRangeEnd = 399498, XrefRangeStart = 399424, XrefRangeEnd = 399497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseAttlistDecl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseAttlistDecl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00052B7C File Offset: 0x00050D7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399535, RefRangeEnd = 399536, XrefRangeStart = 399498, XrefRangeEnd = 399535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrDef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementDecl);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreErrors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseAttlistType_Private_Void_SchemaAttDef_SchemaElementDecl_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00052BE0 File Offset: 0x00050DE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399554, RefRangeEnd = 399555, XrefRangeStart = 399536, XrefRangeEnd = 399554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrDef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreErrors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseAttlistDefault_Private_Void_SchemaAttDef_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00052C30 File Offset: 0x00050E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399607, RefRangeEnd = 399608, XrefRangeStart = 399555, XrefRangeEnd = 399607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseElementDecl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseElementDecl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00052C64 File Offset: 0x00050E64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399682, RefRangeEnd = 399683, XrefRangeStart = 399608, XrefRangeEnd = 399682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pcv);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startParenEntityId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseElementOnlyContent_Private_Void_ParticleContentValidator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00052CB4 File Offset: 0x00050EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399683, XrefRangeEnd = 399694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseHowMany(ParticleContentValidator pcv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pcv);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseHowMany_Private_Void_ParticleContentValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00052CF8 File Offset: 0x00050EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399726, RefRangeEnd = 399727, XrefRangeStart = 399694, XrefRangeEnd = 399726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pcv);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startParenEntityId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseElementMixedContent_Private_Void_ParticleContentValidator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00052D48 File Offset: 0x00050F48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399766, RefRangeEnd = 399767, XrefRangeStart = 399727, XrefRangeEnd = 399766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseEntityDecl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseEntityDecl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00052D7C File Offset: 0x00050F7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399794, RefRangeEnd = 399795, XrefRangeStart = 399767, XrefRangeEnd = 399794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseNotationDecl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseNotationDecl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00052DB0 File Offset: 0x00050FB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399813, RefRangeEnd = 399814, XrefRangeStart = 399795, XrefRangeEnd = 399813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUndeclaredNotation(string notationName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(notationName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_AddUndeclaredNotation_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00052DF4 File Offset: 0x00050FF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399838, RefRangeEnd = 399839, XrefRangeStart = 399814, XrefRangeEnd = 399838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseComment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseComment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00052E28 File Offset: 0x00051028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399839, XrefRangeEnd = 399852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParsePI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParsePI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00052E5C File Offset: 0x0005105C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399882, RefRangeEnd = 399883, XrefRangeStart = 399852, XrefRangeEnd = 399882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseCondSection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseCondSection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00052E90 File Offset: 0x00051090
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 399914, RefRangeEnd = 399917, XrefRangeStart = 399883, XrefRangeEnd = 399914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, out string publicId, out string systemId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idTokenType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref declType;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseExternalId_Private_Void_Token_Token_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			publicId = IL2CPP.Il2CppStringToManaged(intPtr);
			systemId = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00052F14 File Offset: 0x00051114
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 399962, RefRangeEnd = 400005, XrefRangeStart = 399917, XrefRangeEnd = 399962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token GetToken(bool needWhiteSpace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needWhiteSpace;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetToken_Private_Token_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00052F60 File Offset: 0x00051160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 400010, RefRangeEnd = 400011, XrefRangeStart = 400005, XrefRangeEnd = 400010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanSubsetContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanSubsetContent_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00052F9C File Offset: 0x0005119C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400011, XrefRangeEnd = 400012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanNameExpected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanNameExpected_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00052FD8 File Offset: 0x000511D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400012, XrefRangeEnd = 400013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanQNameExpected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanQNameExpected_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00053014 File Offset: 0x00051214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400013, XrefRangeEnd = 400014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanNmtokenExpected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanNmtokenExpected_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00053050 File Offset: 0x00051250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400014, XrefRangeEnd = 400018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanDoctype1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanDoctype1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0005308C File Offset: 0x0005128C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400018, XrefRangeEnd = 400019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanDoctype2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanDoctype2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x000530C8 File Offset: 0x000512C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400019, XrefRangeEnd = 400022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanClosingTag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanClosingTag_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00053104 File Offset: 0x00051304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400022, XrefRangeEnd = 400024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanElement1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00053140 File Offset: 0x00051340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400024, XrefRangeEnd = 400033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanElement2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0005317C File Offset: 0x0005137C
		[CallerCount(0)]
		public unsafe DtdParser.Token ScanElement3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement3_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x000531B8 File Offset: 0x000513B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400033, XrefRangeEnd = 400038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanElement4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement4_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x000531F4 File Offset: 0x000513F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400038, XrefRangeEnd = 400039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanElement5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement5_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00053230 File Offset: 0x00051430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400039, XrefRangeEnd = 400041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanElement6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement6_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0005326C File Offset: 0x0005146C
		[CallerCount(0)]
		public unsafe DtdParser.Token ScanElement7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement7_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x000532A8 File Offset: 0x000514A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400041, XrefRangeEnd = 400046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x000532E4 File Offset: 0x000514E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400046, XrefRangeEnd = 400073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00053320 File Offset: 0x00051520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400073, XrefRangeEnd = 400076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist3_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0005335C File Offset: 0x0005155C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400076, XrefRangeEnd = 400078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist4_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00053398 File Offset: 0x00051598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400078, XrefRangeEnd = 400080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist5_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x000533D4 File Offset: 0x000515D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400080, XrefRangeEnd = 400100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist6_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00053410 File Offset: 0x00051610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400100, XrefRangeEnd = 400105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist7_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0005344C File Offset: 0x0005164C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 400228, RefRangeEnd = 400230, XrefRangeStart = 400105, XrefRangeEnd = 400228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref literalType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanLiteral_Private_Token_LiteralType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00053498 File Offset: 0x00051698
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 400239, RefRangeEnd = 400244, XrefRangeStart = 400230, XrefRangeEnd = 400239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName ScanEntityName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanEntityName_Private_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x000534D8 File Offset: 0x000516D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400244, XrefRangeEnd = 400249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanNotation1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanNotation1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00053514 File Offset: 0x00051714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400249, XrefRangeEnd = 400255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanSystemId()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanSystemId_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00053550 File Offset: 0x00051750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400255, XrefRangeEnd = 400256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanEntity1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanEntity1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0005358C File Offset: 0x0005178C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400256, XrefRangeEnd = 400261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanEntity2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanEntity2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x000535C8 File Offset: 0x000517C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400261, XrefRangeEnd = 400262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanEntity3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanEntity3_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00053604 File Offset: 0x00051804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400262, XrefRangeEnd = 400268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanPublicId1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanPublicId1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00053640 File Offset: 0x00051840
		[CallerCount(0)]
		public unsafe DtdParser.Token ScanPublicId2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanPublicId2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0005367C File Offset: 0x0005187C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400268, XrefRangeEnd = 400283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanCondSection1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanCondSection1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x000536B8 File Offset: 0x000518B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400283, XrefRangeEnd = 400286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanCondSection2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanCondSection2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x000536F4 File Offset: 0x000518F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400286, XrefRangeEnd = 400316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanCondSection3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanCondSection3_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00053730 File Offset: 0x00051930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400316, XrefRangeEnd = 400317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00053764 File Offset: 0x00051964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400317, XrefRangeEnd = 400318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanQName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanQName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00053798 File Offset: 0x00051998
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 400339, RefRangeEnd = 400348, XrefRangeStart = 400318, XrefRangeEnd = 400339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanQName(bool isQName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isQName;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanQName_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x000537D8 File Offset: 0x000519D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400348, XrefRangeEnd = 400349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadDataInName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ReadDataInName_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00053814 File Offset: 0x00051A14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 400362, RefRangeEnd = 400363, XrefRangeStart = 400349, XrefRangeEnd = 400362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanNmtoken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanNmtoken_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00053848 File Offset: 0x00051A48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 400364, RefRangeEnd = 400366, XrefRangeStart = 400363, XrefRangeEnd = 400364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EatPublicKeyword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_EatPublicKeyword_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00053884 File Offset: 0x00051A84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 400367, RefRangeEnd = 400368, XrefRangeStart = 400366, XrefRangeEnd = 400367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EatSystemKeyword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_EatSystemKeyword_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x000538C0 File Offset: 0x00051AC0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 400373, RefRangeEnd = 400383, XrefRangeStart = 400368, XrefRangeEnd = 400373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName GetNameQualified(bool canHavePrefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canHavePrefix;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetNameQualified_Private_XmlQualifiedName_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x0005390C File Offset: 0x00051B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400383, XrefRangeEnd = 400384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNameString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetNameString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00053944 File Offset: 0x00051B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNmtokenString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetNmtokenString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x0005397C File Offset: 0x00051B7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 400385, RefRangeEnd = 400388, XrefRangeStart = 400384, XrefRangeEnd = 400385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetValue_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x000539B4 File Offset: 0x00051BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400388, XrefRangeEnd = 400392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetValueWithStrippedSpaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetValueWithStrippedSpaces_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x000539EC File Offset: 0x00051BEC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 400397, RefRangeEnd = 400402, XrefRangeStart = 400392, XrefRangeEnd = 400397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ReadData_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00053A28 File Offset: 0x00051C28
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 400409, RefRangeEnd = 400434, XrefRangeStart = 400402, XrefRangeEnd = 400409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadParsingBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_LoadParsingBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00053A5C File Offset: 0x00051C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400434, XrefRangeEnd = 400435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveParsingBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00053A90 File Offset: 0x00051C90
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 400445, RefRangeEnd = 400472, XrefRangeStart = 400435, XrefRangeEnd = 400445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveParsingBuffer(int internalSubsetValueEndPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref internalSubsetValueEndPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00053AD0 File Offset: 0x00051CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400472, XrefRangeEnd = 400474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref paramEntity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inLiteral;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inAttribute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00053B38 File Offset: 0x00051D38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 400486, RefRangeEnd = 400488, XrefRangeStart = 400474, XrefRangeEnd = 400486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paramEntity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inLiteral;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inAttribute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_XmlQualifiedName_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00053BB0 File Offset: 0x00051DB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 400496, RefRangeEnd = 400499, XrefRangeStart = 400488, XrefRangeEnd = 400496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleEntityEnd(bool inLiteral)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inLiteral;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00053BFC File Offset: 0x00051DFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 400515, RefRangeEnd = 400519, XrefRangeStart = 400499, XrefRangeEnd = 400515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paramEntity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustBeDeclared;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inAttribute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_VerifyEntityReference_Private_SchemaEntity_XmlQualifiedName_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaEntity>(intPtr3) : null;
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00053C78 File Offset: 0x00051E78
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 400532, RefRangeEnd = 400544, XrefRangeStart = 400519, XrefRangeEnd = 400532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_Int32_XmlSeverityType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00053CEC File Offset: 0x00051EEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 400557, RefRangeEnd = 400559, XrefRangeStart = 400544, XrefRangeEnd = 400557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSeverityType severity, string code, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref severity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00053D50 File Offset: 0x00051F50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 400565, RefRangeEnd = 400569, XrefRangeStart = 400559, XrefRangeEnd = 400565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref severity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00053DA0 File Offset: 0x00051FA0
		[CallerCount(0)]
		public unsafe bool IsAttributeValueType(DtdParser.Token token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_IsAttributeValueType_Private_Boolean_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x00053DEC File Offset: 0x00051FEC
		public unsafe int LineNo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400569, XrefRangeEnd = 400573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_LineNo_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x00053E28 File Offset: 0x00052028
		public unsafe int LinePos
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400573, XrefRangeEnd = 400576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_LinePos_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x00053E64 File Offset: 0x00052064
		public unsafe string BaseUriStr
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 400583, RefRangeEnd = 400588, XrefRangeStart = 400576, XrefRangeEnd = 400583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_BaseUriStr_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00053E9C File Offset: 0x0005209C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 400593, RefRangeEnd = 400602, XrefRangeStart = 400588, XrefRangeEnd = 400593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUnexpectedError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_OnUnexpectedError_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00053ED0 File Offset: 0x000520D0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 400605, RefRangeEnd = 400619, XrefRangeStart = 400602, XrefRangeEnd = 400605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int curPos, string res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref curPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00053F20 File Offset: 0x00052120
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 400637, RefRangeEnd = 400668, XrefRangeStart = 400619, XrefRangeEnd = 400637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int curPos, string res, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref curPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00053F84 File Offset: 0x00052184
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 400686, RefRangeEnd = 400691, XrefRangeStart = 400668, XrefRangeEnd = 400686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int curPos, string res, Il2CppStringArray args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref curPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00053FE8 File Offset: 0x000521E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 400703, RefRangeEnd = 400707, XrefRangeStart = 400691, XrefRangeEnd = 400703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00054058 File Offset: 0x00052258
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 400711, RefRangeEnd = 400714, XrefRangeStart = 400707, XrefRangeEnd = 400711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowInvalidChar(int pos, string data, int invCharPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invCharPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x000540B8 File Offset: 0x000522B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 400724, RefRangeEnd = 400725, XrefRangeStart = 400714, XrefRangeEnd = 400724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00054118 File Offset: 0x00052318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400725, XrefRangeEnd = 400726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00054168 File Offset: 0x00052368
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 400738, RefRangeEnd = 400751, XrefRangeStart = 400726, XrefRangeEnd = 400738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x000541CC File Offset: 0x000523CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 400752, RefRangeEnd = 400755, XrefRangeStart = 400751, XrefRangeEnd = 400752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseUnexpectedToken(int startPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00054210 File Offset: 0x00052410
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 400768, RefRangeEnd = 400771, XrefRangeStart = 400755, XrefRangeEnd = 400768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StripSpaces(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00006E30 File Offset: 0x00005030
		public DtdParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x0005424C File Offset: 0x0005244C
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x00006E39 File Offset: 0x00005039
		public unsafe IDtdParserAdapter readerAdapter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_readerAdapter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdParserAdapter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_readerAdapter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x0005427C File Offset: 0x0005247C
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x00006E58 File Offset: 0x00005058
		public unsafe IDtdParserAdapterWithValidation readerAdapterWithValidation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_readerAdapterWithValidation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdParserAdapterWithValidation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_readerAdapterWithValidation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x000542AC File Offset: 0x000524AC
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x00006E77 File Offset: 0x00005077
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x000542DC File Offset: 0x000524DC
		// (set) Token: 0x06000ECD RID: 3789 RVA: 0x00006E96 File Offset: 0x00005096
		public unsafe SchemaInfo schemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_schemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_schemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0005430C File Offset: 0x0005250C
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x00006EB5 File Offset: 0x000050B5
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x0005433C File Offset: 0x0005253C
		// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x00006EE3 File Offset: 0x000050E3
		public unsafe string systemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_systemId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_systemId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x00054364 File Offset: 0x00052564
		// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x00006F02 File Offset: 0x00005102
		public unsafe string publicId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_publicId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_publicId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x0005438C File Offset: 0x0005258C
		// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x00006F21 File Offset: 0x00005121
		public unsafe bool normalize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_normalize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_normalize)) = value;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x000543B4 File Offset: 0x000525B4
		// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x00006F3C File Offset: 0x0000513C
		public unsafe bool validate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_validate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_validate)) = value;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x000543DC File Offset: 0x000525DC
		// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x00006F57 File Offset: 0x00005157
		public unsafe bool supportNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_supportNamespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_supportNamespaces)) = value;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x00054404 File Offset: 0x00052604
		// (set) Token: 0x06000EDB RID: 3803 RVA: 0x00006F72 File Offset: 0x00005172
		public unsafe bool v1Compat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_v1Compat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_v1Compat)) = value;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x0005442C File Offset: 0x0005262C
		// (set) Token: 0x06000EDD RID: 3805 RVA: 0x00006F8D File Offset: 0x0000518D
		public unsafe Il2CppStructArray<char> chars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_chars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_chars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x0005445C File Offset: 0x0005265C
		// (set) Token: 0x06000EDF RID: 3807 RVA: 0x00006FAC File Offset: 0x000051AC
		public unsafe int charsUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_charsUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_charsUsed)) = value;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x00054484 File Offset: 0x00052684
		// (set) Token: 0x06000EE1 RID: 3809 RVA: 0x00006FC7 File Offset: 0x000051C7
		public unsafe int curPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_curPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_curPos)) = value;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x000544AC File Offset: 0x000526AC
		// (set) Token: 0x06000EE3 RID: 3811 RVA: 0x00006FE2 File Offset: 0x000051E2
		public unsafe DtdParser.ScanningFunction scanningFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_scanningFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_scanningFunction)) = value;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x000544D4 File Offset: 0x000526D4
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x00006FFD File Offset: 0x000051FD
		public unsafe DtdParser.ScanningFunction nextScaningFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_nextScaningFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_nextScaningFunction)) = value;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x000544FC File Offset: 0x000526FC
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x00007018 File Offset: 0x00005218
		public unsafe DtdParser.ScanningFunction savedScanningFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_savedScanningFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_savedScanningFunction)) = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00054524 File Offset: 0x00052724
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x00007033 File Offset: 0x00005233
		public unsafe bool whitespaceSeen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_whitespaceSeen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_whitespaceSeen)) = value;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x0005454C File Offset: 0x0005274C
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x0000704E File Offset: 0x0000524E
		public unsafe int tokenStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_tokenStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_tokenStartPos)) = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x00054574 File Offset: 0x00052774
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x00007069 File Offset: 0x00005269
		public unsafe int colonPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_colonPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_colonPos)) = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x0005459C File Offset: 0x0005279C
		// (set) Token: 0x06000EEF RID: 3823 RVA: 0x00007084 File Offset: 0x00005284
		public unsafe StringBuilder internalSubsetValueSb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_internalSubsetValueSb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_internalSubsetValueSb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x000545CC File Offset: 0x000527CC
		// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x000070A3 File Offset: 0x000052A3
		public unsafe int externalEntitiesDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_externalEntitiesDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_externalEntitiesDepth)) = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x000545F4 File Offset: 0x000527F4
		// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x000070BE File Offset: 0x000052BE
		public unsafe int currentEntityId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_currentEntityId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_currentEntityId)) = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x0005461C File Offset: 0x0005281C
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x000070D9 File Offset: 0x000052D9
		public unsafe bool freeFloatingDtd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_freeFloatingDtd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_freeFloatingDtd)) = value;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x00054644 File Offset: 0x00052844
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x000070F4 File Offset: 0x000052F4
		public unsafe bool hasFreeFloatingInternalSubset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_hasFreeFloatingInternalSubset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_hasFreeFloatingInternalSubset)) = value;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x0005466C File Offset: 0x0005286C
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x0000710F File Offset: 0x0000530F
		public unsafe StringBuilder stringBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_stringBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_stringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x0005469C File Offset: 0x0005289C
		// (set) Token: 0x06000EFB RID: 3835 RVA: 0x0000712E File Offset: 0x0000532E
		public unsafe int condSectionDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_condSectionDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_condSectionDepth)) = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x000546C4 File Offset: 0x000528C4
		// (set) Token: 0x06000EFD RID: 3837 RVA: 0x00007149 File Offset: 0x00005349
		public unsafe LineInfo literalLineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_literalLineInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_literalLineInfo)) = value;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x000546EC File Offset: 0x000528EC
		// (set) Token: 0x06000EFF RID: 3839 RVA: 0x00007164 File Offset: 0x00005364
		public unsafe char literalQuoteChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_literalQuoteChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_literalQuoteChar)) = value;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00054714 File Offset: 0x00052914
		// (set) Token: 0x06000F01 RID: 3841 RVA: 0x0000717F File Offset: 0x0000537F
		public unsafe string documentBaseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_documentBaseUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_documentBaseUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0005473C File Offset: 0x0005293C
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x0000719E File Offset: 0x0000539E
		public unsafe string externalDtdBaseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_externalDtdBaseUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_externalDtdBaseUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x00054764 File Offset: 0x00052964
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x000071BD File Offset: 0x000053BD
		public unsafe Dictionary<string, DtdParser.UndeclaredNotation> undeclaredNotations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_undeclaredNotations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, DtdParser.UndeclaredNotation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_undeclaredNotations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x00054794 File Offset: 0x00052994
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x000071DC File Offset: 0x000053DC
		public unsafe Il2CppStructArray<int> condSectionEntityIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_condSectionEntityIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_condSectionEntityIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeFieldInfoPtr_readerAdapter;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeFieldInfoPtr_readerAdapterWithValidation;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeFieldInfoPtr_schemaInfo;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeFieldInfoPtr_systemId;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeFieldInfoPtr_publicId;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeFieldInfoPtr_normalize;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeFieldInfoPtr_validate;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeFieldInfoPtr_supportNamespaces;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeFieldInfoPtr_v1Compat;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeFieldInfoPtr_chars;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeFieldInfoPtr_charsUsed;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeFieldInfoPtr_curPos;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeFieldInfoPtr_scanningFunction;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeFieldInfoPtr_nextScaningFunction;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeFieldInfoPtr_savedScanningFunction;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeFieldInfoPtr_whitespaceSeen;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeFieldInfoPtr_tokenStartPos;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeFieldInfoPtr_colonPos;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeFieldInfoPtr_internalSubsetValueSb;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeFieldInfoPtr_externalEntitiesDepth;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeFieldInfoPtr_currentEntityId;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeFieldInfoPtr_freeFloatingDtd;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeFieldInfoPtr_hasFreeFloatingInternalSubset;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeFieldInfoPtr_stringBuilder;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeFieldInfoPtr_condSectionDepth;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeFieldInfoPtr_literalLineInfo;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeFieldInfoPtr_literalQuoteChar;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeFieldInfoPtr_documentBaseUri;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeFieldInfoPtr_externalDtdBaseUri;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeFieldInfoPtr_undeclaredNotations;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeFieldInfoPtr_condSectionEntityIds;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_IDtdParser_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_IDtdParserAdapter_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_InitializeFreeFloatingDtd_Private_Void_String_String_String_String_String_IDtdParserAdapter_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParser_ParseInternalDtd_Private_Virtual_Final_New_IDtdInfo_IDtdParserAdapter_Boolean_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParser_ParseFreeFloatingDtd_Private_Virtual_Final_New_IDtdInfo_String_String_String_String_String_IDtdParserAdapter_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr_get_ParsingInternalSubset_Private_get_Boolean_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreEntityReferences_Private_get_Boolean_0;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveInternalSubsetValue_Private_get_Boolean_0;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr_get_ParsingTopLevelMarkup_Private_get_Boolean_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportNamespaces_Private_get_Boolean_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_get_Normalize_Private_get_Boolean_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Private_Void_Boolean_0;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr_ParseInDocumentDtd_Private_Void_Boolean_0;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr_ParseFreeFloatingDtd_Private_Void_0;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeMethodInfoPtr_ParseInternalSubset_Private_Void_0;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr_ParseExternalSubset_Private_Void_0;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr_ParseSubset_Private_Void_0;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttlistDecl_Private_Void_0;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttlistType_Private_Void_SchemaAttDef_SchemaElementDecl_Boolean_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttlistDefault_Private_Void_SchemaAttDef_Boolean_0;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr_ParseElementDecl_Private_Void_0;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_ParseElementOnlyContent_Private_Void_ParticleContentValidator_Int32_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_ParseHowMany_Private_Void_ParticleContentValidator_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_ParseElementMixedContent_Private_Void_ParticleContentValidator_Int32_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_ParseEntityDecl_Private_Void_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_ParseNotationDecl_Private_Void_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_AddUndeclaredNotation_Private_Void_String_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_ParseComment_Private_Void_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_ParsePI_Private_Void_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_ParseCondSection_Private_Void_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_ParseExternalId_Private_Void_Token_Token_byref_String_byref_String_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_GetToken_Private_Token_Boolean_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_ScanSubsetContent_Private_Token_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_ScanNameExpected_Private_Token_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_ScanQNameExpected_Private_Token_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_ScanNmtokenExpected_Private_Token_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_ScanDoctype1_Private_Token_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_ScanDoctype2_Private_Token_0;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_ScanClosingTag_Private_Token_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement1_Private_Token_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement2_Private_Token_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement3_Private_Token_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement4_Private_Token_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement5_Private_Token_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement6_Private_Token_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement7_Private_Token_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist1_Private_Token_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist2_Private_Token_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist3_Private_Token_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist4_Private_Token_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist5_Private_Token_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist6_Private_Token_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist7_Private_Token_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_ScanLiteral_Private_Token_LiteralType_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_ScanEntityName_Private_XmlQualifiedName_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_ScanNotation1_Private_Token_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_ScanSystemId_Private_Token_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_ScanEntity1_Private_Token_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_ScanEntity2_Private_Token_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_ScanEntity3_Private_Token_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_ScanPublicId1_Private_Token_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_ScanPublicId2_Private_Token_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_ScanCondSection1_Private_Token_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_ScanCondSection2_Private_Token_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_ScanCondSection3_Private_Token_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_ScanName_Private_Void_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_ScanQName_Private_Void_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_ScanQName_Private_Void_Boolean_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_ReadDataInName_Private_Boolean_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_ScanNmtoken_Private_Void_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_EatPublicKeyword_Private_Boolean_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_EatSystemKeyword_Private_Boolean_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_GetNameQualified_Private_XmlQualifiedName_Boolean_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr_GetNameString_Private_String_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr_GetNmtokenString_Private_String_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Private_String_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_GetValueWithStrippedSpaces_Private_String_0;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_ReadData_Private_Int32_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_LoadParsingBuffer_Private_Void_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_Int32_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_XmlQualifiedName_Boolean_Boolean_Boolean_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr_VerifyEntityReference_Private_SchemaEntity_XmlQualifiedName_Boolean_Boolean_Boolean_0;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_Int32_XmlSeverityType_String_String_0;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_0;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr_IsAttributeValueType_Private_Boolean_Token_0;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNo_Private_get_Int32_0;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePos_Private_get_Int32_0;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUriStr_Private_get_String_0;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeMethodInfoPtr_OnUnexpectedError_Private_Void_0;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Int32_String_Int32_0;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0;

		// Token: 0x0200021E RID: 542
		[OriginalName("System.Xml.dll", "", "Token")]
		public enum Token
		{
			// Token: 0x040021DF RID: 8671
			CDATA,
			// Token: 0x040021E0 RID: 8672
			ID,
			// Token: 0x040021E1 RID: 8673
			IDREF,
			// Token: 0x040021E2 RID: 8674
			IDREFS,
			// Token: 0x040021E3 RID: 8675
			ENTITY,
			// Token: 0x040021E4 RID: 8676
			ENTITIES,
			// Token: 0x040021E5 RID: 8677
			NMTOKEN,
			// Token: 0x040021E6 RID: 8678
			NMTOKENS,
			// Token: 0x040021E7 RID: 8679
			NOTATION,
			// Token: 0x040021E8 RID: 8680
			None,
			// Token: 0x040021E9 RID: 8681
			PERef,
			// Token: 0x040021EA RID: 8682
			AttlistDecl,
			// Token: 0x040021EB RID: 8683
			ElementDecl,
			// Token: 0x040021EC RID: 8684
			EntityDecl,
			// Token: 0x040021ED RID: 8685
			NotationDecl,
			// Token: 0x040021EE RID: 8686
			Comment,
			// Token: 0x040021EF RID: 8687
			PI,
			// Token: 0x040021F0 RID: 8688
			CondSectionStart,
			// Token: 0x040021F1 RID: 8689
			CondSectionEnd,
			// Token: 0x040021F2 RID: 8690
			Eof,
			// Token: 0x040021F3 RID: 8691
			REQUIRED,
			// Token: 0x040021F4 RID: 8692
			IMPLIED,
			// Token: 0x040021F5 RID: 8693
			FIXED,
			// Token: 0x040021F6 RID: 8694
			QName,
			// Token: 0x040021F7 RID: 8695
			Name,
			// Token: 0x040021F8 RID: 8696
			Nmtoken,
			// Token: 0x040021F9 RID: 8697
			Quote,
			// Token: 0x040021FA RID: 8698
			LeftParen,
			// Token: 0x040021FB RID: 8699
			RightParen,
			// Token: 0x040021FC RID: 8700
			GreaterThan,
			// Token: 0x040021FD RID: 8701
			Or,
			// Token: 0x040021FE RID: 8702
			LeftBracket,
			// Token: 0x040021FF RID: 8703
			RightBracket,
			// Token: 0x04002200 RID: 8704
			PUBLIC,
			// Token: 0x04002201 RID: 8705
			SYSTEM,
			// Token: 0x04002202 RID: 8706
			Literal,
			// Token: 0x04002203 RID: 8707
			DOCTYPE,
			// Token: 0x04002204 RID: 8708
			NData,
			// Token: 0x04002205 RID: 8709
			Percent,
			// Token: 0x04002206 RID: 8710
			Star,
			// Token: 0x04002207 RID: 8711
			QMark,
			// Token: 0x04002208 RID: 8712
			Plus,
			// Token: 0x04002209 RID: 8713
			PCDATA,
			// Token: 0x0400220A RID: 8714
			Comma,
			// Token: 0x0400220B RID: 8715
			ANY,
			// Token: 0x0400220C RID: 8716
			EMPTY,
			// Token: 0x0400220D RID: 8717
			IGNORE,
			// Token: 0x0400220E RID: 8718
			INCLUDE
		}

		// Token: 0x0200021F RID: 543
		[OriginalName("System.Xml.dll", "", "ScanningFunction")]
		public enum ScanningFunction
		{
			// Token: 0x04002210 RID: 8720
			SubsetContent,
			// Token: 0x04002211 RID: 8721
			Name,
			// Token: 0x04002212 RID: 8722
			QName,
			// Token: 0x04002213 RID: 8723
			Nmtoken,
			// Token: 0x04002214 RID: 8724
			Doctype1,
			// Token: 0x04002215 RID: 8725
			Doctype2,
			// Token: 0x04002216 RID: 8726
			Element1,
			// Token: 0x04002217 RID: 8727
			Element2,
			// Token: 0x04002218 RID: 8728
			Element3,
			// Token: 0x04002219 RID: 8729
			Element4,
			// Token: 0x0400221A RID: 8730
			Element5,
			// Token: 0x0400221B RID: 8731
			Element6,
			// Token: 0x0400221C RID: 8732
			Element7,
			// Token: 0x0400221D RID: 8733
			Attlist1,
			// Token: 0x0400221E RID: 8734
			Attlist2,
			// Token: 0x0400221F RID: 8735
			Attlist3,
			// Token: 0x04002220 RID: 8736
			Attlist4,
			// Token: 0x04002221 RID: 8737
			Attlist5,
			// Token: 0x04002222 RID: 8738
			Attlist6,
			// Token: 0x04002223 RID: 8739
			Attlist7,
			// Token: 0x04002224 RID: 8740
			Entity1,
			// Token: 0x04002225 RID: 8741
			Entity2,
			// Token: 0x04002226 RID: 8742
			Entity3,
			// Token: 0x04002227 RID: 8743
			Notation1,
			// Token: 0x04002228 RID: 8744
			CondSection1,
			// Token: 0x04002229 RID: 8745
			CondSection2,
			// Token: 0x0400222A RID: 8746
			CondSection3,
			// Token: 0x0400222B RID: 8747
			Literal,
			// Token: 0x0400222C RID: 8748
			SystemId,
			// Token: 0x0400222D RID: 8749
			PublicId1,
			// Token: 0x0400222E RID: 8750
			PublicId2,
			// Token: 0x0400222F RID: 8751
			ClosingTag,
			// Token: 0x04002230 RID: 8752
			ParamEntitySpace,
			// Token: 0x04002231 RID: 8753
			None
		}

		// Token: 0x02000220 RID: 544
		[OriginalName("System.Xml.dll", "", "LiteralType")]
		public enum LiteralType
		{
			// Token: 0x04002233 RID: 8755
			AttributeValue,
			// Token: 0x04002234 RID: 8756
			EntityReplText,
			// Token: 0x04002235 RID: 8757
			SystemOrPublicID
		}

		// Token: 0x02000221 RID: 545
		public class UndeclaredNotation : Object
		{
			// Token: 0x06002BAD RID: 11181 RVA: 0x000C47F4 File Offset: 0x000C29F4
			// Note: this type is marked as 'beforefieldinit'.
			static UndeclaredNotation()
			{
				Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "UndeclaredNotation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr);
				DtdParser.UndeclaredNotation.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr, "name");
				DtdParser.UndeclaredNotation.NativeFieldInfoPtr_lineNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr, "lineNo");
				DtdParser.UndeclaredNotation.NativeFieldInfoPtr_linePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr, "linePos");
				DtdParser.UndeclaredNotation.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr, "next");
				DtdParser.UndeclaredNotation.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr, 100665676);
			}

			// Token: 0x06002BAE RID: 11182 RVA: 0x000C4884 File Offset: 0x000C2A84
			[CallerCount(0)]
			public unsafe UndeclaredNotation(string name, int lineNo, int linePos)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.UndeclaredNotation.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BAF RID: 11183 RVA: 0x000129C6 File Offset: 0x00010BC6
			public UndeclaredNotation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EE7 RID: 3815
			// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x000C48EC File Offset: 0x000C2AEC
			// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x000129CF File Offset: 0x00010BCF
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EE8 RID: 3816
			// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x000C4914 File Offset: 0x000C2B14
			// (set) Token: 0x06002BB3 RID: 11187 RVA: 0x000129EE File Offset: 0x00010BEE
			public unsafe int lineNo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_lineNo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_lineNo)) = value;
				}
			}

			// Token: 0x17000EE9 RID: 3817
			// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x000C493C File Offset: 0x000C2B3C
			// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x00012A09 File Offset: 0x00010C09
			public unsafe int linePos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_linePos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_linePos)) = value;
				}
			}

			// Token: 0x17000EEA RID: 3818
			// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x000C4964 File Offset: 0x000C2B64
			// (set) Token: 0x06002BB7 RID: 11191 RVA: 0x00012A24 File Offset: 0x00010C24
			public unsafe DtdParser.UndeclaredNotation next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DtdParser.UndeclaredNotation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002236 RID: 8758
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04002237 RID: 8759
			private static readonly IntPtr NativeFieldInfoPtr_lineNo;

			// Token: 0x04002238 RID: 8760
			private static readonly IntPtr NativeFieldInfoPtr_linePos;

			// Token: 0x04002239 RID: 8761
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x0400223A RID: 8762
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_0;
		}

		// Token: 0x02000222 RID: 546
		public class ParseElementOnlyContent_LocalFrame : Object
		{
			// Token: 0x06002BB8 RID: 11192 RVA: 0x000C4994 File Offset: 0x000C2B94
			// Note: this type is marked as 'beforefieldinit'.
			static ParseElementOnlyContent_LocalFrame()
			{
				Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "ParseElementOnlyContent_LocalFrame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr);
				DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_startParenEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr, "startParenEntityId");
				DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_parsingSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr, "parsingSchema");
				DtdParser.ParseElementOnlyContent_LocalFrame.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr, 100665677);
			}

			// Token: 0x06002BB9 RID: 11193 RVA: 0x000C49FC File Offset: 0x000C2BFC
			[CallerCount(0)]
			public unsafe ParseElementOnlyContent_LocalFrame(int startParentEntityIdParam)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref startParentEntityIdParam;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.ParseElementOnlyContent_LocalFrame.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002BBA RID: 11194 RVA: 0x00012A43 File Offset: 0x00010C43
			public ParseElementOnlyContent_LocalFrame(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EEB RID: 3819
			// (get) Token: 0x06002BBB RID: 11195 RVA: 0x000C4A44 File Offset: 0x000C2C44
			// (set) Token: 0x06002BBC RID: 11196 RVA: 0x00012A4C File Offset: 0x00010C4C
			public unsafe int startParenEntityId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_startParenEntityId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_startParenEntityId)) = value;
				}
			}

			// Token: 0x17000EEC RID: 3820
			// (get) Token: 0x06002BBD RID: 11197 RVA: 0x000C4A6C File Offset: 0x000C2C6C
			// (set) Token: 0x06002BBE RID: 11198 RVA: 0x00012A67 File Offset: 0x00010C67
			public unsafe DtdParser.Token parsingSchema
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_parsingSchema);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_parsingSchema)) = value;
				}
			}

			// Token: 0x0400223B RID: 8763
			private static readonly IntPtr NativeFieldInfoPtr_startParenEntityId;

			// Token: 0x0400223C RID: 8764
			private static readonly IntPtr NativeFieldInfoPtr_parsingSchema;

			// Token: 0x0400223D RID: 8765
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}
	}
}
