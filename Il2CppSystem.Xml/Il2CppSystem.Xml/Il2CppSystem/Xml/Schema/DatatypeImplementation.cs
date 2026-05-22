using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000120 RID: 288
	public class DatatypeImplementation : XmlSchemaDatatype
	{
		// Token: 0x06001711 RID: 5905 RVA: 0x00074DB4 File Offset: 0x00072FB4
		// Note: this type is marked as 'beforefieldinit'.
		static DatatypeImplementation()
		{
			Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "DatatypeImplementation");
			DatatypeImplementation.NativeFieldInfoPtr_variety = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "variety");
			DatatypeImplementation.NativeFieldInfoPtr_restriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "restriction");
			DatatypeImplementation.NativeFieldInfoPtr_baseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "baseType");
			DatatypeImplementation.NativeFieldInfoPtr_valueConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "valueConverter");
			DatatypeImplementation.NativeFieldInfoPtr_parentSchemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "parentSchemaType");
			DatatypeImplementation.NativeFieldInfoPtr_builtinTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "builtinTypes");
			DatatypeImplementation.NativeFieldInfoPtr_enumToTypeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "enumToTypeCode");
			DatatypeImplementation.NativeFieldInfoPtr_anySimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "anySimpleType");
			DatatypeImplementation.NativeFieldInfoPtr_anyAtomicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "anyAtomicType");
			DatatypeImplementation.NativeFieldInfoPtr_untypedAtomicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "untypedAtomicType");
			DatatypeImplementation.NativeFieldInfoPtr_yearMonthDurationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "yearMonthDurationType");
			DatatypeImplementation.NativeFieldInfoPtr_dayTimeDurationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "dayTimeDurationType");
			DatatypeImplementation.NativeFieldInfoPtr_normalizedStringTypeV1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "normalizedStringTypeV1Compat");
			DatatypeImplementation.NativeFieldInfoPtr_tokenTypeV1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "tokenTypeV1Compat");
			DatatypeImplementation.NativeFieldInfoPtr_QnAnySimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "QnAnySimpleType");
			DatatypeImplementation.NativeFieldInfoPtr_QnAnyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "QnAnyType");
			DatatypeImplementation.NativeFieldInfoPtr_stringFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "stringFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_miscFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "miscFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_numeric2FacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "numeric2FacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_binaryFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "binaryFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_dateTimeFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "dateTimeFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_durationFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "durationFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_listFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "listFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_qnameFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "qnameFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_unionFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "unionFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_c_anySimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_anySimpleType");
			DatatypeImplementation.NativeFieldInfoPtr_c_anyURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_anyURI");
			DatatypeImplementation.NativeFieldInfoPtr_c_base64Binary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_base64Binary");
			DatatypeImplementation.NativeFieldInfoPtr_c_boolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_boolean");
			DatatypeImplementation.NativeFieldInfoPtr_c_byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_byte");
			DatatypeImplementation.NativeFieldInfoPtr_c_char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_char");
			DatatypeImplementation.NativeFieldInfoPtr_c_date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_date");
			DatatypeImplementation.NativeFieldInfoPtr_c_dateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_dateTime");
			DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeNoTz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_dateTimeNoTz");
			DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeTz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_dateTimeTz");
			DatatypeImplementation.NativeFieldInfoPtr_c_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_day");
			DatatypeImplementation.NativeFieldInfoPtr_c_decimal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_decimal");
			DatatypeImplementation.NativeFieldInfoPtr_c_double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_double");
			DatatypeImplementation.NativeFieldInfoPtr_c_doubleXdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_doubleXdr");
			DatatypeImplementation.NativeFieldInfoPtr_c_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_duration");
			DatatypeImplementation.NativeFieldInfoPtr_c_ENTITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_ENTITY");
			DatatypeImplementation.NativeFieldInfoPtr_c_ENTITIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_ENTITIES");
			DatatypeImplementation.NativeFieldInfoPtr_c_ENUMERATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_ENUMERATION");
			DatatypeImplementation.NativeFieldInfoPtr_c_fixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_fixed");
			DatatypeImplementation.NativeFieldInfoPtr_c_float = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_float");
			DatatypeImplementation.NativeFieldInfoPtr_c_floatXdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_floatXdr");
			DatatypeImplementation.NativeFieldInfoPtr_c_hexBinary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_hexBinary");
			DatatypeImplementation.NativeFieldInfoPtr_c_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_ID");
			DatatypeImplementation.NativeFieldInfoPtr_c_IDREF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_IDREF");
			DatatypeImplementation.NativeFieldInfoPtr_c_IDREFS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_IDREFS");
			DatatypeImplementation.NativeFieldInfoPtr_c_int = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_int");
			DatatypeImplementation.NativeFieldInfoPtr_c_integer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_integer");
			DatatypeImplementation.NativeFieldInfoPtr_c_language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_language");
			DatatypeImplementation.NativeFieldInfoPtr_c_long = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_long");
			DatatypeImplementation.NativeFieldInfoPtr_c_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_month");
			DatatypeImplementation.NativeFieldInfoPtr_c_monthDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_monthDay");
			DatatypeImplementation.NativeFieldInfoPtr_c_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_Name");
			DatatypeImplementation.NativeFieldInfoPtr_c_NCName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_NCName");
			DatatypeImplementation.NativeFieldInfoPtr_c_negativeInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_negativeInteger");
			DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_NMTOKEN");
			DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKENS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_NMTOKENS");
			DatatypeImplementation.NativeFieldInfoPtr_c_nonNegativeInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_nonNegativeInteger");
			DatatypeImplementation.NativeFieldInfoPtr_c_nonPositiveInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_nonPositiveInteger");
			DatatypeImplementation.NativeFieldInfoPtr_c_normalizedString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_normalizedString");
			DatatypeImplementation.NativeFieldInfoPtr_c_NOTATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_NOTATION");
			DatatypeImplementation.NativeFieldInfoPtr_c_positiveInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_positiveInteger");
			DatatypeImplementation.NativeFieldInfoPtr_c_QName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_QName");
			DatatypeImplementation.NativeFieldInfoPtr_c_QNameXdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_QNameXdr");
			DatatypeImplementation.NativeFieldInfoPtr_c_short = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_short");
			DatatypeImplementation.NativeFieldInfoPtr_c_string = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_string");
			DatatypeImplementation.NativeFieldInfoPtr_c_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_time");
			DatatypeImplementation.NativeFieldInfoPtr_c_timeNoTz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_timeNoTz");
			DatatypeImplementation.NativeFieldInfoPtr_c_timeTz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_timeTz");
			DatatypeImplementation.NativeFieldInfoPtr_c_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_token");
			DatatypeImplementation.NativeFieldInfoPtr_c_unsignedByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_unsignedByte");
			DatatypeImplementation.NativeFieldInfoPtr_c_unsignedInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_unsignedInt");
			DatatypeImplementation.NativeFieldInfoPtr_c_unsignedLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_unsignedLong");
			DatatypeImplementation.NativeFieldInfoPtr_c_unsignedShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_unsignedShort");
			DatatypeImplementation.NativeFieldInfoPtr_c_uuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_uuid");
			DatatypeImplementation.NativeFieldInfoPtr_c_year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_year");
			DatatypeImplementation.NativeFieldInfoPtr_c_yearMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_yearMonth");
			DatatypeImplementation.NativeFieldInfoPtr_c_normalizedStringV1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_normalizedStringV1Compat");
			DatatypeImplementation.NativeFieldInfoPtr_c_tokenV1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_tokenV1Compat");
			DatatypeImplementation.NativeFieldInfoPtr_c_anyAtomicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_anyAtomicType");
			DatatypeImplementation.NativeFieldInfoPtr_c_dayTimeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_dayTimeDuration");
			DatatypeImplementation.NativeFieldInfoPtr_c_untypedAtomicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_untypedAtomicType");
			DatatypeImplementation.NativeFieldInfoPtr_c_yearMonthDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_yearMonthDuration");
			DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_tokenizedTypes");
			DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypesXsd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_tokenizedTypesXsd");
			DatatypeImplementation.NativeFieldInfoPtr_c_XdrTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_XdrTypes");
			DatatypeImplementation.NativeFieldInfoPtr_c_XsdTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_XsdTypes");
			DatatypeImplementation.NativeMethodInfoPtr_get_AnySimpleType_Internal_Static_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666735);
			DatatypeImplementation.NativeMethodInfoPtr_get_UntypedAtomicType_Internal_Static_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666736);
			DatatypeImplementation.NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_DatatypeImplementation_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666737);
			DatatypeImplementation.NativeMethodInfoPtr_FromXmlTokenizedTypeXsd_Internal_Static_DatatypeImplementation_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666738);
			DatatypeImplementation.NativeMethodInfoPtr_FromXdrName_Internal_Static_DatatypeImplementation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666739);
			DatatypeImplementation.NativeMethodInfoPtr_FromTypeName_Private_Static_DatatypeImplementation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666740);
			DatatypeImplementation.NativeMethodInfoPtr_StartBuiltinType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666741);
			DatatypeImplementation.NativeMethodInfoPtr_FinishBuiltinType_Internal_Static_Void_XmlSchemaSimpleType_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666742);
			DatatypeImplementation.NativeMethodInfoPtr_CreateBuiltinTypes_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666743);
			DatatypeImplementation.NativeMethodInfoPtr_GetSimpleTypeFromTypeCode_Internal_Static_XmlSchemaSimpleType_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666744);
			DatatypeImplementation.NativeMethodInfoPtr_GetSimpleTypeFromXsdType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666745);
			DatatypeImplementation.NativeMethodInfoPtr_GetNormalizedStringTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666746);
			DatatypeImplementation.NativeMethodInfoPtr_GetTokenTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666747);
			DatatypeImplementation.NativeMethodInfoPtr_GetBuiltInTypes_Internal_Static_Il2CppReferenceArray_1_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666748);
			DatatypeImplementation.NativeMethodInfoPtr_GetPrimitiveTypeCode_Internal_Static_XmlTypeCode_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666749);
			DatatypeImplementation.NativeMethodInfoPtr_DeriveByRestriction_Internal_Virtual_XmlSchemaDatatype_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666750);
			DatatypeImplementation.NativeMethodInfoPtr_DeriveByList_Internal_Virtual_XmlSchemaDatatype_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666751);
			DatatypeImplementation.NativeMethodInfoPtr_DeriveByList_Internal_XmlSchemaDatatype_Int32_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666752);
			DatatypeImplementation.NativeMethodInfoPtr_DeriveByUnion_Internal_Static_DatatypeImplementation_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666753);
			DatatypeImplementation.NativeMethodInfoPtr_VerifySchemaValid_Internal_Virtual_Void_XmlSchemaObjectTable_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666754);
			DatatypeImplementation.NativeMethodInfoPtr_IsDerivedFrom_Public_Virtual_Boolean_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666755);
			DatatypeImplementation.NativeMethodInfoPtr_IsEqual_Internal_Virtual_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666756);
			DatatypeImplementation.NativeMethodInfoPtr_IsComparable_Internal_Virtual_Boolean_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666757);
			DatatypeImplementation.NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_New_XmlValueConverter_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666758);
			DatatypeImplementation.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666759);
			DatatypeImplementation.NativeMethodInfoPtr_get_ValueConverter_Internal_Virtual_get_XmlValueConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666760);
			DatatypeImplementation.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666761);
			DatatypeImplementation.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666762);
			DatatypeImplementation.NativeMethodInfoPtr_get_Variety_Public_Virtual_get_XmlSchemaDatatypeVariety_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666763);
			DatatypeImplementation.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666764);
			DatatypeImplementation.NativeMethodInfoPtr_get_Restriction_Internal_Virtual_get_RestrictionFacets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666765);
			DatatypeImplementation.NativeMethodInfoPtr_get_HasLexicalFacets_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666766);
			DatatypeImplementation.NativeMethodInfoPtr_get_HasValueFacets_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666767);
			DatatypeImplementation.NativeMethodInfoPtr_get_Base_Protected_get_DatatypeImplementation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666768);
			DatatypeImplementation.NativeMethodInfoPtr_get_ListValueType_Internal_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666769);
			DatatypeImplementation.NativeMethodInfoPtr_get_ValidRestrictionFlags_Internal_Abstract_Virtual_New_get_RestrictionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666770);
			DatatypeImplementation.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666771);
			DatatypeImplementation.NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666772);
			DatatypeImplementation.NativeMethodInfoPtr_ParseValue_Internal_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666773);
			DatatypeImplementation.NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_Object_XmlNameTable_IXmlNamespaceResolver_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666774);
			DatatypeImplementation.NativeMethodInfoPtr_GetTypeName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666775);
			DatatypeImplementation.NativeMethodInfoPtr_Compare_Protected_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666776);
			DatatypeImplementation.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666777);
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x00075854 File Offset: 0x00073A54
		public unsafe static XmlSchemaSimpleType AnySimpleType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410147, XrefRangeEnd = 410151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_get_AnySimpleType_Internal_Static_get_XmlSchemaSimpleType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x00075888 File Offset: 0x00073A88
		public unsafe static XmlSchemaSimpleType UntypedAtomicType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410151, XrefRangeEnd = 410155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_get_UntypedAtomicType_Internal_Static_get_XmlSchemaSimpleType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x000758BC File Offset: 0x00073ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410155, XrefRangeEnd = 410159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_DatatypeImplementation_XmlTokenizedType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
			}
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000758FC File Offset: 0x00073AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410159, XrefRangeEnd = 410163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_FromXmlTokenizedTypeXsd_Internal_Static_DatatypeImplementation_XmlTokenizedType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
			}
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x0007593C File Offset: 0x00073B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410163, XrefRangeEnd = 410170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static DatatypeImplementation FromXdrName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_FromXdrName_Internal_Static_DatatypeImplementation_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
			}
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00075980 File Offset: 0x00073B80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 410177, RefRangeEnd = 410179, XrefRangeStart = 410170, XrefRangeEnd = 410177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DatatypeImplementation FromTypeName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_FromTypeName_Private_Static_DatatypeImplementation_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
			}
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x000759C4 File Offset: 0x00073BC4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 410187, RefRangeEnd = 410193, XrefRangeStart = 410179, XrefRangeEnd = 410187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_StartBuiltinType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_XmlSchemaDatatype_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00075A1C File Offset: 0x00073C1C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 410221, RefRangeEnd = 410226, XrefRangeStart = 410193, XrefRangeEnd = 410221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_FinishBuiltinType_Internal_Static_Void_XmlSchemaSimpleType_XmlSchemaSimpleType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00075A64 File Offset: 0x00073C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410226, XrefRangeEnd = 410421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateBuiltinTypes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_CreateBuiltinTypes_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00075A8C File Offset: 0x00073C8C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 410425, RefRangeEnd = 410434, XrefRangeStart = 410421, XrefRangeEnd = 410425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_GetSimpleTypeFromTypeCode_Internal_Static_XmlSchemaSimpleType_XmlTypeCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00075ACC File Offset: 0x00073CCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 410440, RefRangeEnd = 410443, XrefRangeStart = 410434, XrefRangeEnd = 410440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_GetSimpleTypeFromXsdType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x00075B10 File Offset: 0x00073D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410443, XrefRangeEnd = 410462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_GetNormalizedStringTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00075B44 File Offset: 0x00073D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410462, XrefRangeEnd = 410481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaSimpleType GetTokenTypeV1Compat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_GetTokenTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x00075B78 File Offset: 0x00073D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410481, XrefRangeEnd = 410485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<XmlSchemaSimpleType> GetBuiltInTypes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_GetBuiltInTypes_Internal_Static_Il2CppReferenceArray_1_XmlSchemaSimpleType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaSimpleType>>(intPtr3) : null;
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x00075BAC File Offset: 0x00073DAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 410502, RefRangeEnd = 410504, XrefRangeStart = 410485, XrefRangeEnd = 410502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_GetPrimitiveTypeCode_Internal_Static_XmlTypeCode_XmlTypeCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x00075BEC File Offset: 0x00073DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410504, XrefRangeEnd = 410508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(facets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_DeriveByRestriction_Internal_Virtual_XmlSchemaDatatype_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x00075C6C File Offset: 0x00073E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410508, XrefRangeEnd = 410509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_DeriveByList_Internal_Virtual_XmlSchemaDatatype_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00075CC8 File Offset: 0x00073EC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 410527, RefRangeEnd = 410528, XrefRangeStart = 410509, XrefRangeEnd = 410527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_DeriveByList_Internal_XmlSchemaDatatype_Int32_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x00075D28 File Offset: 0x00073F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 410541, RefRangeEnd = 410542, XrefRangeStart = 410528, XrefRangeEnd = 410541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static DatatypeImplementation DeriveByUnion(Il2CppReferenceArray<XmlSchemaSimpleType> types, XmlSchemaType schemaType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(types);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_DeriveByUnion_Internal_Static_DatatypeImplementation_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00075D80 File Offset: 0x00073F80
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caller);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_VerifySchemaValid_Internal_Virtual_Void_XmlSchemaObjectTable_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00075DE0 File Offset: 0x00073FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410542, XrefRangeEnd = 410548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDerivedFrom(XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(datatype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_IsDerivedFrom_Public_Virtual_Boolean_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00075E38 File Offset: 0x00074038
		[CallerCount(0)]
		public unsafe override bool IsEqual(Object o1, Object o2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_IsEqual_Internal_Virtual_Boolean_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00075EA4 File Offset: 0x000740A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410548, XrefRangeEnd = 410553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsComparable(XmlSchemaDatatype dtype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_IsComparable_Internal_Virtual_Boolean_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x00075EFC File Offset: 0x000740FC
		[CallerCount(0)]
		public unsafe virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_New_XmlValueConverter_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x00075F58 File Offset: 0x00074158
		public unsafe override FacetsChecker FacetsChecker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410553, XrefRangeEnd = 410557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr3) : null;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x00075FA4 File Offset: 0x000741A4
		public unsafe override XmlValueConverter ValueConverter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_ValueConverter_Internal_Virtual_get_XmlValueConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x00075FF0 File Offset: 0x000741F0
		public unsafe override XmlTokenizedType TokenizedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x00076038 File Offset: 0x00074238
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410557, XrefRangeEnd = 410563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x00076084 File Offset: 0x00074284
		public unsafe override XmlSchemaDatatypeVariety Variety
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_Variety_Public_Virtual_get_XmlSchemaDatatypeVariety_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x000760CC File Offset: 0x000742CC
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x00076114 File Offset: 0x00074314
		public unsafe override RestrictionFacets Restriction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_Restriction_Internal_Virtual_get_RestrictionFacets_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr3) : null;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x00076160 File Offset: 0x00074360
		public unsafe override bool HasLexicalFacets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_HasLexicalFacets_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x000761A8 File Offset: 0x000743A8
		public unsafe override bool HasValueFacets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_HasValueFacets_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x000761F0 File Offset: 0x000743F0
		public unsafe DatatypeImplementation Base
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_get_Base_Protected_get_DatatypeImplementation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x00076230 File Offset: 0x00074430
		public unsafe virtual Type ListValueType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_ListValueType_Internal_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x0007627C File Offset: 0x0007447C
		public unsafe virtual RestrictionFlags ValidRestrictionFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_ValidRestrictionFlags_Internal_Abstract_Virtual_New_get_RestrictionFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x000762C4 File Offset: 0x000744C4
		public unsafe override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0007630C File Offset: 0x0007450C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410563, XrefRangeEnd = 410564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0007638C File Offset: 0x0007458C
		[CallerCount(0)]
		public unsafe override Object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createAtomicValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_ParseValue_Internal_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0007641C File Offset: 0x0007461C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410564, XrefRangeEnd = 410594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception TryParseValue(Object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out Object typedValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceResolver);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_Object_XmlNameTable_IXmlNamespaceResolver_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typedValue = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr5) : null;
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x000764C0 File Offset: 0x000746C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410594, XrefRangeEnd = 410595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTypeName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_GetTypeName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x000764F8 File Offset: 0x000746F8
		[CallerCount(0)]
		public unsafe int Compare(Il2CppStructArray<byte> value1, Il2CppStructArray<byte> value2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_Compare_Protected_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00076558 File Offset: 0x00074758
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DatatypeImplementation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x0000A4B2 File Offset: 0x000086B2
		public DatatypeImplementation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x00076594 File Offset: 0x00074794
		// (set) Token: 0x0600173F RID: 5951 RVA: 0x0000A4BB File Offset: 0x000086BB
		public unsafe XmlSchemaDatatypeVariety variety
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_variety);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_variety)) = value;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x000765BC File Offset: 0x000747BC
		// (set) Token: 0x06001741 RID: 5953 RVA: 0x0000A4D6 File Offset: 0x000086D6
		public unsafe RestrictionFacets restriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_restriction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_restriction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x000765EC File Offset: 0x000747EC
		// (set) Token: 0x06001743 RID: 5955 RVA: 0x0000A4F5 File Offset: 0x000086F5
		public unsafe DatatypeImplementation baseType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_baseType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_baseType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x0007661C File Offset: 0x0007481C
		// (set) Token: 0x06001745 RID: 5957 RVA: 0x0000A514 File Offset: 0x00008714
		public unsafe XmlValueConverter valueConverter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_valueConverter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_valueConverter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x0007664C File Offset: 0x0007484C
		// (set) Token: 0x06001747 RID: 5959 RVA: 0x0000A533 File Offset: 0x00008733
		public unsafe XmlSchemaType parentSchemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_parentSchemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_parentSchemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x0007667C File Offset: 0x0007487C
		// (set) Token: 0x06001749 RID: 5961 RVA: 0x0000A552 File Offset: 0x00008752
		public unsafe static Hashtable builtinTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_builtinTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_builtinTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x000766A4 File Offset: 0x000748A4
		// (set) Token: 0x0600174B RID: 5963 RVA: 0x0000A564 File Offset: 0x00008764
		public unsafe static Il2CppReferenceArray<XmlSchemaSimpleType> enumToTypeCode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_enumToTypeCode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaSimpleType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_enumToTypeCode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x000766CC File Offset: 0x000748CC
		// (set) Token: 0x0600174D RID: 5965 RVA: 0x0000A576 File Offset: 0x00008776
		public unsafe static XmlSchemaSimpleType anySimpleType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_anySimpleType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_anySimpleType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x000766F4 File Offset: 0x000748F4
		// (set) Token: 0x0600174F RID: 5967 RVA: 0x0000A588 File Offset: 0x00008788
		public unsafe static XmlSchemaSimpleType anyAtomicType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_anyAtomicType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_anyAtomicType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x0007671C File Offset: 0x0007491C
		// (set) Token: 0x06001751 RID: 5969 RVA: 0x0000A59A File Offset: 0x0000879A
		public unsafe static XmlSchemaSimpleType untypedAtomicType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_untypedAtomicType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_untypedAtomicType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x00076744 File Offset: 0x00074944
		// (set) Token: 0x06001753 RID: 5971 RVA: 0x0000A5AC File Offset: 0x000087AC
		public unsafe static XmlSchemaSimpleType yearMonthDurationType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_yearMonthDurationType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_yearMonthDurationType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x0007676C File Offset: 0x0007496C
		// (set) Token: 0x06001755 RID: 5973 RVA: 0x0000A5BE File Offset: 0x000087BE
		public unsafe static XmlSchemaSimpleType dayTimeDurationType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_dayTimeDurationType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_dayTimeDurationType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x00076794 File Offset: 0x00074994
		// (set) Token: 0x06001757 RID: 5975 RVA: 0x0000A5D0 File Offset: 0x000087D0
		public unsafe static XmlSchemaSimpleType normalizedStringTypeV1Compat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_normalizedStringTypeV1Compat, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_normalizedStringTypeV1Compat, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001758 RID: 5976 RVA: 0x000767BC File Offset: 0x000749BC
		// (set) Token: 0x06001759 RID: 5977 RVA: 0x0000A5E2 File Offset: 0x000087E2
		public unsafe static XmlSchemaSimpleType tokenTypeV1Compat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_tokenTypeV1Compat, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_tokenTypeV1Compat, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x000767E4 File Offset: 0x000749E4
		// (set) Token: 0x0600175B RID: 5979 RVA: 0x0000A5F4 File Offset: 0x000087F4
		public unsafe static XmlQualifiedName QnAnySimpleType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_QnAnySimpleType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_QnAnySimpleType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x0007680C File Offset: 0x00074A0C
		// (set) Token: 0x0600175D RID: 5981 RVA: 0x0000A606 File Offset: 0x00008806
		public unsafe static XmlQualifiedName QnAnyType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_QnAnyType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_QnAnyType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x00076834 File Offset: 0x00074A34
		// (set) Token: 0x0600175F RID: 5983 RVA: 0x0000A618 File Offset: 0x00008818
		public unsafe static FacetsChecker stringFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_stringFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_stringFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x0007685C File Offset: 0x00074A5C
		// (set) Token: 0x06001761 RID: 5985 RVA: 0x0000A62A File Offset: 0x0000882A
		public unsafe static FacetsChecker miscFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_miscFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_miscFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x00076884 File Offset: 0x00074A84
		// (set) Token: 0x06001763 RID: 5987 RVA: 0x0000A63C File Offset: 0x0000883C
		public unsafe static FacetsChecker numeric2FacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_numeric2FacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_numeric2FacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001764 RID: 5988 RVA: 0x000768AC File Offset: 0x00074AAC
		// (set) Token: 0x06001765 RID: 5989 RVA: 0x0000A64E File Offset: 0x0000884E
		public unsafe static FacetsChecker binaryFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_binaryFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_binaryFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x000768D4 File Offset: 0x00074AD4
		// (set) Token: 0x06001767 RID: 5991 RVA: 0x0000A660 File Offset: 0x00008860
		public unsafe static FacetsChecker dateTimeFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_dateTimeFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_dateTimeFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x000768FC File Offset: 0x00074AFC
		// (set) Token: 0x06001769 RID: 5993 RVA: 0x0000A672 File Offset: 0x00008872
		public unsafe static FacetsChecker durationFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_durationFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_durationFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x00076924 File Offset: 0x00074B24
		// (set) Token: 0x0600176B RID: 5995 RVA: 0x0000A684 File Offset: 0x00008884
		public unsafe static FacetsChecker listFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_listFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_listFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x0007694C File Offset: 0x00074B4C
		// (set) Token: 0x0600176D RID: 5997 RVA: 0x0000A696 File Offset: 0x00008896
		public unsafe static FacetsChecker qnameFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_qnameFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_qnameFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x00076974 File Offset: 0x00074B74
		// (set) Token: 0x0600176F RID: 5999 RVA: 0x0000A6A8 File Offset: 0x000088A8
		public unsafe static FacetsChecker unionFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_unionFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_unionFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x0007699C File Offset: 0x00074B9C
		// (set) Token: 0x06001771 RID: 6001 RVA: 0x0000A6BA File Offset: 0x000088BA
		public unsafe static DatatypeImplementation c_anySimpleType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_anySimpleType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_anySimpleType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x000769C4 File Offset: 0x00074BC4
		// (set) Token: 0x06001773 RID: 6003 RVA: 0x0000A6CC File Offset: 0x000088CC
		public unsafe static DatatypeImplementation c_anyURI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_anyURI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_anyURI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x000769EC File Offset: 0x00074BEC
		// (set) Token: 0x06001775 RID: 6005 RVA: 0x0000A6DE File Offset: 0x000088DE
		public unsafe static DatatypeImplementation c_base64Binary
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_base64Binary, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_base64Binary, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x00076A14 File Offset: 0x00074C14
		// (set) Token: 0x06001777 RID: 6007 RVA: 0x0000A6F0 File Offset: 0x000088F0
		public unsafe static DatatypeImplementation c_boolean
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_boolean, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_boolean, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x00076A3C File Offset: 0x00074C3C
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x0000A702 File Offset: 0x00008902
		public unsafe static DatatypeImplementation c_byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x00076A64 File Offset: 0x00074C64
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x0000A714 File Offset: 0x00008914
		public unsafe static DatatypeImplementation c_char
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_char, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_char, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x00076A8C File Offset: 0x00074C8C
		// (set) Token: 0x0600177D RID: 6013 RVA: 0x0000A726 File Offset: 0x00008926
		public unsafe static DatatypeImplementation c_date
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_date, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_date, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x00076AB4 File Offset: 0x00074CB4
		// (set) Token: 0x0600177F RID: 6015 RVA: 0x0000A738 File Offset: 0x00008938
		public unsafe static DatatypeImplementation c_dateTime
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTime, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTime, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x00076ADC File Offset: 0x00074CDC
		// (set) Token: 0x06001781 RID: 6017 RVA: 0x0000A74A File Offset: 0x0000894A
		public unsafe static DatatypeImplementation c_dateTimeNoTz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeNoTz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeNoTz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x00076B04 File Offset: 0x00074D04
		// (set) Token: 0x06001783 RID: 6019 RVA: 0x0000A75C File Offset: 0x0000895C
		public unsafe static DatatypeImplementation c_dateTimeTz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeTz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeTz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x00076B2C File Offset: 0x00074D2C
		// (set) Token: 0x06001785 RID: 6021 RVA: 0x0000A76E File Offset: 0x0000896E
		public unsafe static DatatypeImplementation c_day
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_day, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_day, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x00076B54 File Offset: 0x00074D54
		// (set) Token: 0x06001787 RID: 6023 RVA: 0x0000A780 File Offset: 0x00008980
		public unsafe static DatatypeImplementation c_decimal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_decimal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_decimal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x00076B7C File Offset: 0x00074D7C
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x0000A792 File Offset: 0x00008992
		public unsafe static DatatypeImplementation c_double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x00076BA4 File Offset: 0x00074DA4
		// (set) Token: 0x0600178B RID: 6027 RVA: 0x0000A7A4 File Offset: 0x000089A4
		public unsafe static DatatypeImplementation c_doubleXdr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_doubleXdr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_doubleXdr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x00076BCC File Offset: 0x00074DCC
		// (set) Token: 0x0600178D RID: 6029 RVA: 0x0000A7B6 File Offset: 0x000089B6
		public unsafe static DatatypeImplementation c_duration
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_duration, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_duration, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x00076BF4 File Offset: 0x00074DF4
		// (set) Token: 0x0600178F RID: 6031 RVA: 0x0000A7C8 File Offset: 0x000089C8
		public unsafe static DatatypeImplementation c_ENTITY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENTITY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENTITY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x00076C1C File Offset: 0x00074E1C
		// (set) Token: 0x06001791 RID: 6033 RVA: 0x0000A7DA File Offset: 0x000089DA
		public unsafe static DatatypeImplementation c_ENTITIES
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENTITIES, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENTITIES, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x00076C44 File Offset: 0x00074E44
		// (set) Token: 0x06001793 RID: 6035 RVA: 0x0000A7EC File Offset: 0x000089EC
		public unsafe static DatatypeImplementation c_ENUMERATION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENUMERATION, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENUMERATION, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001794 RID: 6036 RVA: 0x00076C6C File Offset: 0x00074E6C
		// (set) Token: 0x06001795 RID: 6037 RVA: 0x0000A7FE File Offset: 0x000089FE
		public unsafe static DatatypeImplementation c_fixed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_fixed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_fixed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x00076C94 File Offset: 0x00074E94
		// (set) Token: 0x06001797 RID: 6039 RVA: 0x0000A810 File Offset: 0x00008A10
		public unsafe static DatatypeImplementation c_float
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_float, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_float, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x00076CBC File Offset: 0x00074EBC
		// (set) Token: 0x06001799 RID: 6041 RVA: 0x0000A822 File Offset: 0x00008A22
		public unsafe static DatatypeImplementation c_floatXdr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_floatXdr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_floatXdr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x00076CE4 File Offset: 0x00074EE4
		// (set) Token: 0x0600179B RID: 6043 RVA: 0x0000A834 File Offset: 0x00008A34
		public unsafe static DatatypeImplementation c_hexBinary
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_hexBinary, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_hexBinary, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x00076D0C File Offset: 0x00074F0C
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x0000A846 File Offset: 0x00008A46
		public unsafe static DatatypeImplementation c_ID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_ID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_ID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x00076D34 File Offset: 0x00074F34
		// (set) Token: 0x0600179F RID: 6047 RVA: 0x0000A858 File Offset: 0x00008A58
		public unsafe static DatatypeImplementation c_IDREF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_IDREF, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_IDREF, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x00076D5C File Offset: 0x00074F5C
		// (set) Token: 0x060017A1 RID: 6049 RVA: 0x0000A86A File Offset: 0x00008A6A
		public unsafe static DatatypeImplementation c_IDREFS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_IDREFS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_IDREFS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x00076D84 File Offset: 0x00074F84
		// (set) Token: 0x060017A3 RID: 6051 RVA: 0x0000A87C File Offset: 0x00008A7C
		public unsafe static DatatypeImplementation c_int
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_int, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_int, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x00076DAC File Offset: 0x00074FAC
		// (set) Token: 0x060017A5 RID: 6053 RVA: 0x0000A88E File Offset: 0x00008A8E
		public unsafe static DatatypeImplementation c_integer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_integer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_integer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x00076DD4 File Offset: 0x00074FD4
		// (set) Token: 0x060017A7 RID: 6055 RVA: 0x0000A8A0 File Offset: 0x00008AA0
		public unsafe static DatatypeImplementation c_language
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_language, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_language, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00076DFC File Offset: 0x00074FFC
		// (set) Token: 0x060017A9 RID: 6057 RVA: 0x0000A8B2 File Offset: 0x00008AB2
		public unsafe static DatatypeImplementation c_long
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_long, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_long, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x00076E24 File Offset: 0x00075024
		// (set) Token: 0x060017AB RID: 6059 RVA: 0x0000A8C4 File Offset: 0x00008AC4
		public unsafe static DatatypeImplementation c_month
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_month, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_month, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x00076E4C File Offset: 0x0007504C
		// (set) Token: 0x060017AD RID: 6061 RVA: 0x0000A8D6 File Offset: 0x00008AD6
		public unsafe static DatatypeImplementation c_monthDay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_monthDay, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_monthDay, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x00076E74 File Offset: 0x00075074
		// (set) Token: 0x060017AF RID: 6063 RVA: 0x0000A8E8 File Offset: 0x00008AE8
		public unsafe static DatatypeImplementation c_Name
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_Name, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_Name, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x00076E9C File Offset: 0x0007509C
		// (set) Token: 0x060017B1 RID: 6065 RVA: 0x0000A8FA File Offset: 0x00008AFA
		public unsafe static DatatypeImplementation c_NCName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_NCName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_NCName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x00076EC4 File Offset: 0x000750C4
		// (set) Token: 0x060017B3 RID: 6067 RVA: 0x0000A90C File Offset: 0x00008B0C
		public unsafe static DatatypeImplementation c_negativeInteger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_negativeInteger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_negativeInteger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x00076EEC File Offset: 0x000750EC
		// (set) Token: 0x060017B5 RID: 6069 RVA: 0x0000A91E File Offset: 0x00008B1E
		public unsafe static DatatypeImplementation c_NMTOKEN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKEN, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKEN, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x00076F14 File Offset: 0x00075114
		// (set) Token: 0x060017B7 RID: 6071 RVA: 0x0000A930 File Offset: 0x00008B30
		public unsafe static DatatypeImplementation c_NMTOKENS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKENS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKENS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x00076F3C File Offset: 0x0007513C
		// (set) Token: 0x060017B9 RID: 6073 RVA: 0x0000A942 File Offset: 0x00008B42
		public unsafe static DatatypeImplementation c_nonNegativeInteger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_nonNegativeInteger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_nonNegativeInteger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x00076F64 File Offset: 0x00075164
		// (set) Token: 0x060017BB RID: 6075 RVA: 0x0000A954 File Offset: 0x00008B54
		public unsafe static DatatypeImplementation c_nonPositiveInteger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_nonPositiveInteger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_nonPositiveInteger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x00076F8C File Offset: 0x0007518C
		// (set) Token: 0x060017BD RID: 6077 RVA: 0x0000A966 File Offset: 0x00008B66
		public unsafe static DatatypeImplementation c_normalizedString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_normalizedString, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_normalizedString, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x00076FB4 File Offset: 0x000751B4
		// (set) Token: 0x060017BF RID: 6079 RVA: 0x0000A978 File Offset: 0x00008B78
		public unsafe static DatatypeImplementation c_NOTATION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_NOTATION, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_NOTATION, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x00076FDC File Offset: 0x000751DC
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x0000A98A File Offset: 0x00008B8A
		public unsafe static DatatypeImplementation c_positiveInteger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_positiveInteger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_positiveInteger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x00077004 File Offset: 0x00075204
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x0000A99C File Offset: 0x00008B9C
		public unsafe static DatatypeImplementation c_QName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_QName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_QName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x0007702C File Offset: 0x0007522C
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x0000A9AE File Offset: 0x00008BAE
		public unsafe static DatatypeImplementation c_QNameXdr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_QNameXdr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_QNameXdr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x00077054 File Offset: 0x00075254
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x0000A9C0 File Offset: 0x00008BC0
		public unsafe static DatatypeImplementation c_short
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_short, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_short, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x0007707C File Offset: 0x0007527C
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x0000A9D2 File Offset: 0x00008BD2
		public unsafe static DatatypeImplementation c_string
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_string, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_string, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x000770A4 File Offset: 0x000752A4
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x0000A9E4 File Offset: 0x00008BE4
		public unsafe static DatatypeImplementation c_time
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_time, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_time, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x000770CC File Offset: 0x000752CC
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x0000A9F6 File Offset: 0x00008BF6
		public unsafe static DatatypeImplementation c_timeNoTz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_timeNoTz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_timeNoTz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x000770F4 File Offset: 0x000752F4
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x0000AA08 File Offset: 0x00008C08
		public unsafe static DatatypeImplementation c_timeTz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_timeTz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_timeTz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x0007711C File Offset: 0x0007531C
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x0000AA1A File Offset: 0x00008C1A
		public unsafe static DatatypeImplementation c_token
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_token, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_token, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x00077144 File Offset: 0x00075344
		// (set) Token: 0x060017D3 RID: 6099 RVA: 0x0000AA2C File Offset: 0x00008C2C
		public unsafe static DatatypeImplementation c_unsignedByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x0007716C File Offset: 0x0007536C
		// (set) Token: 0x060017D5 RID: 6101 RVA: 0x0000AA3E File Offset: 0x00008C3E
		public unsafe static DatatypeImplementation c_unsignedInt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedInt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedInt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x00077194 File Offset: 0x00075394
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x0000AA50 File Offset: 0x00008C50
		public unsafe static DatatypeImplementation c_unsignedLong
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedLong, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedLong, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x000771BC File Offset: 0x000753BC
		// (set) Token: 0x060017D9 RID: 6105 RVA: 0x0000AA62 File Offset: 0x00008C62
		public unsafe static DatatypeImplementation c_unsignedShort
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedShort, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedShort, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x000771E4 File Offset: 0x000753E4
		// (set) Token: 0x060017DB RID: 6107 RVA: 0x0000AA74 File Offset: 0x00008C74
		public unsafe static DatatypeImplementation c_uuid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_uuid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_uuid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x0007720C File Offset: 0x0007540C
		// (set) Token: 0x060017DD RID: 6109 RVA: 0x0000AA86 File Offset: 0x00008C86
		public unsafe static DatatypeImplementation c_year
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_year, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_year, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x00077234 File Offset: 0x00075434
		// (set) Token: 0x060017DF RID: 6111 RVA: 0x0000AA98 File Offset: 0x00008C98
		public unsafe static DatatypeImplementation c_yearMonth
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_yearMonth, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_yearMonth, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x0007725C File Offset: 0x0007545C
		// (set) Token: 0x060017E1 RID: 6113 RVA: 0x0000AAAA File Offset: 0x00008CAA
		public unsafe static DatatypeImplementation c_normalizedStringV1Compat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_normalizedStringV1Compat, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_normalizedStringV1Compat, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x00077284 File Offset: 0x00075484
		// (set) Token: 0x060017E3 RID: 6115 RVA: 0x0000AABC File Offset: 0x00008CBC
		public unsafe static DatatypeImplementation c_tokenV1Compat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenV1Compat, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenV1Compat, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x000772AC File Offset: 0x000754AC
		// (set) Token: 0x060017E5 RID: 6117 RVA: 0x0000AACE File Offset: 0x00008CCE
		public unsafe static DatatypeImplementation c_anyAtomicType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_anyAtomicType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_anyAtomicType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x000772D4 File Offset: 0x000754D4
		// (set) Token: 0x060017E7 RID: 6119 RVA: 0x0000AAE0 File Offset: 0x00008CE0
		public unsafe static DatatypeImplementation c_dayTimeDuration
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_dayTimeDuration, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_dayTimeDuration, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x000772FC File Offset: 0x000754FC
		// (set) Token: 0x060017E9 RID: 6121 RVA: 0x0000AAF2 File Offset: 0x00008CF2
		public unsafe static DatatypeImplementation c_untypedAtomicType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_untypedAtomicType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_untypedAtomicType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x00077324 File Offset: 0x00075524
		// (set) Token: 0x060017EB RID: 6123 RVA: 0x0000AB04 File Offset: 0x00008D04
		public unsafe static DatatypeImplementation c_yearMonthDuration
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_yearMonthDuration, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_yearMonthDuration, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x0007734C File Offset: 0x0007554C
		// (set) Token: 0x060017ED RID: 6125 RVA: 0x0000AB16 File Offset: 0x00008D16
		public unsafe static Il2CppReferenceArray<DatatypeImplementation> c_tokenizedTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DatatypeImplementation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x00077374 File Offset: 0x00075574
		// (set) Token: 0x060017EF RID: 6127 RVA: 0x0000AB28 File Offset: 0x00008D28
		public unsafe static Il2CppReferenceArray<DatatypeImplementation> c_tokenizedTypesXsd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypesXsd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DatatypeImplementation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypesXsd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x0007739C File Offset: 0x0007559C
		// (set) Token: 0x060017F1 RID: 6129 RVA: 0x0000AB3A File Offset: 0x00008D3A
		public unsafe static Il2CppReferenceArray<DatatypeImplementation.SchemaDatatypeMap> c_XdrTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_XdrTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DatatypeImplementation.SchemaDatatypeMap>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_XdrTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x000773C4 File Offset: 0x000755C4
		// (set) Token: 0x060017F3 RID: 6131 RVA: 0x0000AB4C File Offset: 0x00008D4C
		public unsafe static Il2CppReferenceArray<DatatypeImplementation.SchemaDatatypeMap> c_XsdTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_XsdTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DatatypeImplementation.SchemaDatatypeMap>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_XsdTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeFieldInfoPtr_variety;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeFieldInfoPtr_restriction;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeFieldInfoPtr_baseType;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeFieldInfoPtr_valueConverter;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeFieldInfoPtr_parentSchemaType;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeFieldInfoPtr_builtinTypes;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeFieldInfoPtr_enumToTypeCode;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeFieldInfoPtr_anySimpleType;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeFieldInfoPtr_anyAtomicType;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeFieldInfoPtr_untypedAtomicType;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeFieldInfoPtr_yearMonthDurationType;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeFieldInfoPtr_dayTimeDurationType;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeFieldInfoPtr_normalizedStringTypeV1Compat;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeFieldInfoPtr_tokenTypeV1Compat;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeFieldInfoPtr_QnAnySimpleType;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeFieldInfoPtr_QnAnyType;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeFieldInfoPtr_stringFacetsChecker;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeFieldInfoPtr_miscFacetsChecker;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeFieldInfoPtr_numeric2FacetsChecker;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeFieldInfoPtr_binaryFacetsChecker;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeFieldInfoPtr_dateTimeFacetsChecker;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeFieldInfoPtr_durationFacetsChecker;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeFieldInfoPtr_listFacetsChecker;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeFieldInfoPtr_qnameFacetsChecker;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeFieldInfoPtr_unionFacetsChecker;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeFieldInfoPtr_c_anySimpleType;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeFieldInfoPtr_c_anyURI;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeFieldInfoPtr_c_base64Binary;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeFieldInfoPtr_c_boolean;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeFieldInfoPtr_c_byte;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeFieldInfoPtr_c_char;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeFieldInfoPtr_c_date;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeFieldInfoPtr_c_dateTime;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeFieldInfoPtr_c_dateTimeNoTz;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeFieldInfoPtr_c_dateTimeTz;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeFieldInfoPtr_c_day;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeFieldInfoPtr_c_decimal;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeFieldInfoPtr_c_double;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeFieldInfoPtr_c_doubleXdr;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeFieldInfoPtr_c_duration;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeFieldInfoPtr_c_ENTITY;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeFieldInfoPtr_c_ENTITIES;

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeFieldInfoPtr_c_ENUMERATION;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeFieldInfoPtr_c_fixed;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeFieldInfoPtr_c_float;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeFieldInfoPtr_c_floatXdr;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeFieldInfoPtr_c_hexBinary;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeFieldInfoPtr_c_ID;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeFieldInfoPtr_c_IDREF;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeFieldInfoPtr_c_IDREFS;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeFieldInfoPtr_c_int;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeFieldInfoPtr_c_integer;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeFieldInfoPtr_c_language;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeFieldInfoPtr_c_long;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeFieldInfoPtr_c_month;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeFieldInfoPtr_c_monthDay;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeFieldInfoPtr_c_Name;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeFieldInfoPtr_c_NCName;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeFieldInfoPtr_c_negativeInteger;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeFieldInfoPtr_c_NMTOKEN;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeFieldInfoPtr_c_NMTOKENS;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeFieldInfoPtr_c_nonNegativeInteger;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeFieldInfoPtr_c_nonPositiveInteger;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeFieldInfoPtr_c_normalizedString;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeFieldInfoPtr_c_NOTATION;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeFieldInfoPtr_c_positiveInteger;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeFieldInfoPtr_c_QName;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeFieldInfoPtr_c_QNameXdr;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeFieldInfoPtr_c_short;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeFieldInfoPtr_c_string;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeFieldInfoPtr_c_time;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeFieldInfoPtr_c_timeNoTz;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeFieldInfoPtr_c_timeTz;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeFieldInfoPtr_c_token;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeFieldInfoPtr_c_unsignedByte;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeFieldInfoPtr_c_unsignedInt;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeFieldInfoPtr_c_unsignedLong;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeFieldInfoPtr_c_unsignedShort;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeFieldInfoPtr_c_uuid;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeFieldInfoPtr_c_year;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeFieldInfoPtr_c_yearMonth;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeFieldInfoPtr_c_normalizedStringV1Compat;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeFieldInfoPtr_c_tokenV1Compat;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeFieldInfoPtr_c_anyAtomicType;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeFieldInfoPtr_c_dayTimeDuration;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeFieldInfoPtr_c_untypedAtomicType;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeFieldInfoPtr_c_yearMonthDuration;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeFieldInfoPtr_c_tokenizedTypes;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeFieldInfoPtr_c_tokenizedTypesXsd;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeFieldInfoPtr_c_XdrTypes;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeFieldInfoPtr_c_XsdTypes;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeMethodInfoPtr_get_AnySimpleType_Internal_Static_get_XmlSchemaSimpleType_0;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeMethodInfoPtr_get_UntypedAtomicType_Internal_Static_get_XmlSchemaSimpleType_0;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_DatatypeImplementation_XmlTokenizedType_0;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlTokenizedTypeXsd_Internal_Static_DatatypeImplementation_XmlTokenizedType_0;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeMethodInfoPtr_FromXdrName_Internal_Static_DatatypeImplementation_String_0;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeMethodInfoPtr_FromTypeName_Private_Static_DatatypeImplementation_String_0;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeMethodInfoPtr_StartBuiltinType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_XmlSchemaDatatype_0;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeMethodInfoPtr_FinishBuiltinType_Internal_Static_Void_XmlSchemaSimpleType_XmlSchemaSimpleType_0;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeMethodInfoPtr_CreateBuiltinTypes_Internal_Static_Void_0;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleTypeFromTypeCode_Internal_Static_XmlSchemaSimpleType_XmlTypeCode_0;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleTypeFromXsdType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_0;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalizedStringTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeMethodInfoPtr_GetTokenTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeMethodInfoPtr_GetBuiltInTypes_Internal_Static_Il2CppReferenceArray_1_XmlSchemaSimpleType_0;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimitiveTypeCode_Internal_Static_XmlTypeCode_XmlTypeCode_0;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeMethodInfoPtr_DeriveByRestriction_Internal_Virtual_XmlSchemaDatatype_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType_0;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeMethodInfoPtr_DeriveByList_Internal_Virtual_XmlSchemaDatatype_XmlSchemaType_0;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeMethodInfoPtr_DeriveByList_Internal_XmlSchemaDatatype_Int32_XmlSchemaType_0;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeMethodInfoPtr_DeriveByUnion_Internal_Static_DatatypeImplementation_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaType_0;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeMethodInfoPtr_VerifySchemaValid_Internal_Virtual_Void_XmlSchemaObjectTable_XmlSchemaObject_0;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeMethodInfoPtr_IsDerivedFrom_Public_Virtual_Boolean_XmlSchemaDatatype_0;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeMethodInfoPtr_IsEqual_Internal_Virtual_Boolean_Object_Object_0;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeMethodInfoPtr_IsComparable_Internal_Virtual_Boolean_XmlSchemaDatatype_0;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_New_XmlValueConverter_XmlSchemaType_0;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueConverter_Internal_Virtual_get_XmlValueConverter_0;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeMethodInfoPtr_get_Variety_Public_Virtual_get_XmlSchemaDatatypeVariety_0;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeMethodInfoPtr_get_Restriction_Internal_Virtual_get_RestrictionFacets_0;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeMethodInfoPtr_get_HasLexicalFacets_Internal_Virtual_get_Boolean_0;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValueFacets_Internal_Virtual_get_Boolean_0;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr_get_Base_Protected_get_DatatypeImplementation_0;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeMethodInfoPtr_get_ListValueType_Internal_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidRestrictionFlags_Internal_Abstract_Virtual_New_get_RestrictionFlags_0;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Internal_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_Boolean_0;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_Object_XmlNameTable_IXmlNamespaceResolver_byref_Object_0;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeName_Internal_String_0;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Protected_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000230 RID: 560
		public class SchemaDatatypeMap : Object
		{
			// Token: 0x06002C4C RID: 11340 RVA: 0x000C61AC File Offset: 0x000C43AC
			// Note: this type is marked as 'beforefieldinit'.
			static SchemaDatatypeMap()
			{
				Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "SchemaDatatypeMap");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr);
				DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, "name");
				DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, "type");
				DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_parentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, "parentIndex");
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100666778);
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100666779);
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_op_Explicit_Public_Static_DatatypeImplementation_SchemaDatatypeMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100666780);
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100666781);
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_get_ParentIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100666782);
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100666783);
			}

			// Token: 0x06002C4D RID: 11341 RVA: 0x000C628C File Offset: 0x000C448C
			[CallerCount(76)]
			[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SchemaDatatypeMap(string name, DatatypeImplementation type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C4E RID: 11342 RVA: 0x000C62EC File Offset: 0x000C44EC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 186110, RefRangeEnd = 186112, XrefRangeStart = 186110, XrefRangeEnd = 186112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SchemaDatatypeMap(string name, DatatypeImplementation type, int parentIndex)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C4F RID: 11343 RVA: 0x000C6358 File Offset: 0x000C4558
			[CallerCount(0)]
			public unsafe static explicit operator DatatypeImplementation(DatatypeImplementation.SchemaDatatypeMap sdm)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sdm);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_op_Explicit_Public_Static_DatatypeImplementation_SchemaDatatypeMap_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
				}
			}

			// Token: 0x17000F1E RID: 3870
			// (get) Token: 0x06002C50 RID: 11344 RVA: 0x000C639C File Offset: 0x000C459C
			public unsafe string Name
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000F1F RID: 3871
			// (get) Token: 0x06002C51 RID: 11345 RVA: 0x000C63D4 File Offset: 0x000C45D4
			public unsafe int ParentIndex
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_get_ParentIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C52 RID: 11346 RVA: 0x000C6410 File Offset: 0x000C4610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410141, XrefRangeEnd = 410147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int CompareTo(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C53 RID: 11347 RVA: 0x0001305E File Offset: 0x0001125E
			public SchemaDatatypeMap(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F1B RID: 3867
			// (get) Token: 0x06002C54 RID: 11348 RVA: 0x000C6460 File Offset: 0x000C4660
			// (set) Token: 0x06002C55 RID: 11349 RVA: 0x00013067 File Offset: 0x00011267
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000F1C RID: 3868
			// (get) Token: 0x06002C56 RID: 11350 RVA: 0x000C6488 File Offset: 0x000C4688
			// (set) Token: 0x06002C57 RID: 11351 RVA: 0x00013086 File Offset: 0x00011286
			public unsafe DatatypeImplementation type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F1D RID: 3869
			// (get) Token: 0x06002C58 RID: 11352 RVA: 0x000C64B8 File Offset: 0x000C46B8
			// (set) Token: 0x06002C59 RID: 11353 RVA: 0x000130A5 File Offset: 0x000112A5
			public unsafe int parentIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_parentIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_parentIndex)) = value;
				}
			}

			// Token: 0x04002287 RID: 8839
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04002288 RID: 8840
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04002289 RID: 8841
			private static readonly IntPtr NativeFieldInfoPtr_parentIndex;

			// Token: 0x0400228A RID: 8842
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_0;

			// Token: 0x0400228B RID: 8843
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_Int32_0;

			// Token: 0x0400228C RID: 8844
			private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_DatatypeImplementation_SchemaDatatypeMap_0;

			// Token: 0x0400228D RID: 8845
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

			// Token: 0x0400228E RID: 8846
			private static readonly IntPtr NativeMethodInfoPtr_get_ParentIndex_Public_get_Int32_0;

			// Token: 0x0400228F RID: 8847
			private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;
		}
	}
}
