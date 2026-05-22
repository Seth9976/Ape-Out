using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001DD RID: 477
	public class XmlBaseConverter : XmlValueConverter
	{
		// Token: 0x06002626 RID: 9766 RVA: 0x000AFBD4 File Offset: 0x000ADDD4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlBaseConverter()
		{
			Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlBaseConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr);
			XmlBaseConverter.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "schemaType");
			XmlBaseConverter.NativeFieldInfoPtr_typeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "typeCode");
			XmlBaseConverter.NativeFieldInfoPtr_clrTypeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "clrTypeDefault");
			XmlBaseConverter.NativeFieldInfoPtr_ICollectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "ICollectionType");
			XmlBaseConverter.NativeFieldInfoPtr_IEnumerableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "IEnumerableType");
			XmlBaseConverter.NativeFieldInfoPtr_IListType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "IListType");
			XmlBaseConverter.NativeFieldInfoPtr_ObjectArrayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "ObjectArrayType");
			XmlBaseConverter.NativeFieldInfoPtr_StringArrayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "StringArrayType");
			XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueArrayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "XmlAtomicValueArrayType");
			XmlBaseConverter.NativeFieldInfoPtr_DecimalType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "DecimalType");
			XmlBaseConverter.NativeFieldInfoPtr_Int32Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "Int32Type");
			XmlBaseConverter.NativeFieldInfoPtr_Int64Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "Int64Type");
			XmlBaseConverter.NativeFieldInfoPtr_StringType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "StringType");
			XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "XmlAtomicValueType");
			XmlBaseConverter.NativeFieldInfoPtr_ObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "ObjectType");
			XmlBaseConverter.NativeFieldInfoPtr_ByteType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "ByteType");
			XmlBaseConverter.NativeFieldInfoPtr_Int16Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "Int16Type");
			XmlBaseConverter.NativeFieldInfoPtr_SByteType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "SByteType");
			XmlBaseConverter.NativeFieldInfoPtr_UInt16Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "UInt16Type");
			XmlBaseConverter.NativeFieldInfoPtr_UInt32Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "UInt32Type");
			XmlBaseConverter.NativeFieldInfoPtr_UInt64Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "UInt64Type");
			XmlBaseConverter.NativeFieldInfoPtr_XPathItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "XPathItemType");
			XmlBaseConverter.NativeFieldInfoPtr_DoubleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "DoubleType");
			XmlBaseConverter.NativeFieldInfoPtr_SingleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "SingleType");
			XmlBaseConverter.NativeFieldInfoPtr_DateTimeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "DateTimeType");
			XmlBaseConverter.NativeFieldInfoPtr_DateTimeOffsetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "DateTimeOffsetType");
			XmlBaseConverter.NativeFieldInfoPtr_BooleanType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "BooleanType");
			XmlBaseConverter.NativeFieldInfoPtr_ByteArrayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "ByteArrayType");
			XmlBaseConverter.NativeFieldInfoPtr_XmlQualifiedNameType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "XmlQualifiedNameType");
			XmlBaseConverter.NativeFieldInfoPtr_UriType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "UriType");
			XmlBaseConverter.NativeFieldInfoPtr_TimeSpanType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "TimeSpanType");
			XmlBaseConverter.NativeFieldInfoPtr_XPathNavigatorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "XPathNavigatorType");
			XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668734);
			XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668735);
			XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668736);
			XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668737);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668738);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668739);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668740);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668741);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668742);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668743);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668744);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668745);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668746);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668747);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668748);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668749);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668750);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668751);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668752);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668753);
			XmlBaseConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668754);
			XmlBaseConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668755);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668756);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668757);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668758);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668759);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668760);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668761);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668762);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668763);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668764);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668765);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668766);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668767);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668768);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668769);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668770);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668771);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668772);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668773);
			XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668774);
			XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668775);
			XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668776);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668777);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668778);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668779);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668780);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668781);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668782);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668783);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668784);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668785);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668786);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668787);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668788);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668789);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Double_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668790);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668791);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668792);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668793);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668794);
			XmlBaseConverter.NativeMethodInfoPtr_get_SchemaType_Protected_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668795);
			XmlBaseConverter.NativeMethodInfoPtr_get_TypeCode_Protected_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668796);
			XmlBaseConverter.NativeMethodInfoPtr_get_XmlTypeName_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668797);
			XmlBaseConverter.NativeMethodInfoPtr_get_DefaultClrType_Protected_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668798);
			XmlBaseConverter.NativeMethodInfoPtr_IsDerivedFrom_Protected_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668799);
			XmlBaseConverter.NativeMethodInfoPtr_CreateInvalidClrMappingException_Protected_Exception_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668800);
			XmlBaseConverter.NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668801);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeListType_Protected_Virtual_New_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668802);
			XmlBaseConverter.NativeMethodInfoPtr_StringToBase64Binary_Protected_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668803);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDate_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668804);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDateTime_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668805);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDayTimeDuration_Protected_Static_TimeSpan_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668806);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDuration_Protected_Static_TimeSpan_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668807);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGDay_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668808);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGMonth_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668809);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthDay_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668810);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGYear_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668811);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGYearMonth_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668812);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDateOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668813);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDateTimeOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668814);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGDayOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668815);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668816);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthDayOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668817);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGYearOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668818);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGYearMonthOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668819);
			XmlBaseConverter.NativeMethodInfoPtr_StringToHexBinary_Protected_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668820);
			XmlBaseConverter.NativeMethodInfoPtr_StringToQName_Protected_Static_XmlQualifiedName_String_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668821);
			XmlBaseConverter.NativeMethodInfoPtr_StringToTime_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668822);
			XmlBaseConverter.NativeMethodInfoPtr_StringToTimeOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668823);
			XmlBaseConverter.NativeMethodInfoPtr_StringToYearMonthDuration_Protected_Static_TimeSpan_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668824);
			XmlBaseConverter.NativeMethodInfoPtr_AnyUriToString_Protected_Static_String_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668825);
			XmlBaseConverter.NativeMethodInfoPtr_Base64BinaryToString_Protected_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668826);
			XmlBaseConverter.NativeMethodInfoPtr_DateToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668827);
			XmlBaseConverter.NativeMethodInfoPtr_DateTimeToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668828);
			XmlBaseConverter.NativeMethodInfoPtr_DayTimeDurationToString_Protected_Static_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668829);
			XmlBaseConverter.NativeMethodInfoPtr_DurationToString_Protected_Static_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668830);
			XmlBaseConverter.NativeMethodInfoPtr_GDayToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668831);
			XmlBaseConverter.NativeMethodInfoPtr_GMonthToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668832);
			XmlBaseConverter.NativeMethodInfoPtr_GMonthDayToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668833);
			XmlBaseConverter.NativeMethodInfoPtr_GYearToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668834);
			XmlBaseConverter.NativeMethodInfoPtr_GYearMonthToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668835);
			XmlBaseConverter.NativeMethodInfoPtr_DateOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668836);
			XmlBaseConverter.NativeMethodInfoPtr_DateTimeOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668837);
			XmlBaseConverter.NativeMethodInfoPtr_GDayOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668838);
			XmlBaseConverter.NativeMethodInfoPtr_GMonthOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668839);
			XmlBaseConverter.NativeMethodInfoPtr_GMonthDayOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668840);
			XmlBaseConverter.NativeMethodInfoPtr_GYearOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668841);
			XmlBaseConverter.NativeMethodInfoPtr_GYearMonthOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668842);
			XmlBaseConverter.NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668843);
			XmlBaseConverter.NativeMethodInfoPtr_TimeToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668844);
			XmlBaseConverter.NativeMethodInfoPtr_TimeOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668845);
			XmlBaseConverter.NativeMethodInfoPtr_YearMonthDurationToString_Protected_Static_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668846);
			XmlBaseConverter.NativeMethodInfoPtr_DateTimeOffsetToDateTime_Internal_Static_DateTime_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668847);
			XmlBaseConverter.NativeMethodInfoPtr_DecimalToInt32_Internal_Static_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668848);
			XmlBaseConverter.NativeMethodInfoPtr_DecimalToInt64_Protected_Static_Int64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668849);
			XmlBaseConverter.NativeMethodInfoPtr_DecimalToUInt64_Protected_Static_UInt64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668850);
			XmlBaseConverter.NativeMethodInfoPtr_Int32ToByte_Protected_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668851);
			XmlBaseConverter.NativeMethodInfoPtr_Int32ToInt16_Protected_Static_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668852);
			XmlBaseConverter.NativeMethodInfoPtr_Int32ToSByte_Protected_Static_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668853);
			XmlBaseConverter.NativeMethodInfoPtr_Int32ToUInt16_Protected_Static_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668854);
			XmlBaseConverter.NativeMethodInfoPtr_Int64ToInt32_Protected_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668855);
			XmlBaseConverter.NativeMethodInfoPtr_Int64ToUInt32_Protected_Static_UInt32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668856);
			XmlBaseConverter.NativeMethodInfoPtr_UntypedAtomicToDateTime_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668857);
			XmlBaseConverter.NativeMethodInfoPtr_UntypedAtomicToDateTimeOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100668858);
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x000B0848 File Offset: 0x000AEA48
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 431036, RefRangeEnd = 431055, XrefRangeStart = 431020, XrefRangeEnd = 431036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlBaseConverter(XmlSchemaType schemaType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x000B0894 File Offset: 0x000AEA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431055, XrefRangeEnd = 431059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlBaseConverter(XmlTypeCode typeCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x000B08DC File Offset: 0x000AEADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431059, XrefRangeEnd = 431061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlBaseConverter(XmlBaseConverter converterAtomic)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(converterAtomic);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x000B0928 File Offset: 0x000AEB28
		[CallerCount(0)]
		public unsafe XmlBaseConverter(XmlBaseConverter converterAtomic, Type clrTypeDefault)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(converterAtomic);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clrTypeDefault);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x000B0988 File Offset: 0x000AEB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431061, XrefRangeEnd = 431070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x000B09DC File Offset: 0x000AEBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431070, XrefRangeEnd = 431079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x000B0A30 File Offset: 0x000AEC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431079, XrefRangeEnd = 431088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x000B0A84 File Offset: 0x000AEC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431088, XrefRangeEnd = 431097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x000B0AD8 File Offset: 0x000AECD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431097, XrefRangeEnd = 431103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x000B0B30 File Offset: 0x000AED30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431103, XrefRangeEnd = 431109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x000B0B88 File Offset: 0x000AED88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431109, XrefRangeEnd = 431118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x000B0BDC File Offset: 0x000AEDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431118, XrefRangeEnd = 431127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(DateTimeOffset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x000B0C30 File Offset: 0x000AEE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431127, XrefRangeEnd = 431136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x000B0C84 File Offset: 0x000AEE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431136, XrefRangeEnd = 431145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x000B0CD8 File Offset: 0x000AEED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431145, XrefRangeEnd = 431154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x000B0D2C File Offset: 0x000AEF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431154, XrefRangeEnd = 431160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x000B0D84 File Offset: 0x000AEF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431160, XrefRangeEnd = 431166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x000B0DDC File Offset: 0x000AEFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431166, XrefRangeEnd = 431175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTimeOffset ToDateTimeOffset(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x000B0E30 File Offset: 0x000AF030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431175, XrefRangeEnd = 431181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTimeOffset ToDateTimeOffset(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x000B0E88 File Offset: 0x000AF088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431181, XrefRangeEnd = 431187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTimeOffset ToDateTimeOffset(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x000B0EE0 File Offset: 0x000AF0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431187, XrefRangeEnd = 431193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Decimal ToDecimal(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x000B0F38 File Offset: 0x000AF138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431193, XrefRangeEnd = 431199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Decimal ToDecimal(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x000B0F90 File Offset: 0x000AF190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431199, XrefRangeEnd = 431208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x000B0FE4 File Offset: 0x000AF1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431208, XrefRangeEnd = 431217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x000B1038 File Offset: 0x000AF238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431217, XrefRangeEnd = 431226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x000B108C File Offset: 0x000AF28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431226, XrefRangeEnd = 431235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x000B10E0 File Offset: 0x000AF2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431235, XrefRangeEnd = 431241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x000B1138 File Offset: 0x000AF338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431241, XrefRangeEnd = 431247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x000B1190 File Offset: 0x000AF390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431247, XrefRangeEnd = 431256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x000B11E4 File Offset: 0x000AF3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431256, XrefRangeEnd = 431265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x000B1238 File Offset: 0x000AF438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431265, XrefRangeEnd = 431274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x000B128C File Offset: 0x000AF48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431274, XrefRangeEnd = 431283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x000B12E0 File Offset: 0x000AF4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431283, XrefRangeEnd = 431289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x000B1338 File Offset: 0x000AF538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431289, XrefRangeEnd = 431295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x000B1390 File Offset: 0x000AF590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431295, XrefRangeEnd = 431304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x000B13E4 File Offset: 0x000AF5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431304, XrefRangeEnd = 431313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x000B1438 File Offset: 0x000AF638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431313, XrefRangeEnd = 431322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x000B148C File Offset: 0x000AF68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431322, XrefRangeEnd = 431331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x000B14E0 File Offset: 0x000AF6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431331, XrefRangeEnd = 431337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x000B1538 File Offset: 0x000AF738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431337, XrefRangeEnd = 431343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x000B1590 File Offset: 0x000AF790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431343, XrefRangeEnd = 431352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ToSingle(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x000B15E4 File Offset: 0x000AF7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431352, XrefRangeEnd = 431358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ToSingle(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x000B163C File Offset: 0x000AF83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431358, XrefRangeEnd = 431364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ToSingle(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x000B1694 File Offset: 0x000AF894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431364, XrefRangeEnd = 431373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x000B16E4 File Offset: 0x000AF8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431373, XrefRangeEnd = 431382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x000B1734 File Offset: 0x000AF934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431382, XrefRangeEnd = 431391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(DateTimeOffset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x000B1784 File Offset: 0x000AF984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431391, XrefRangeEnd = 431400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(Decimal value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x000B17D4 File Offset: 0x000AF9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431400, XrefRangeEnd = 431409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x000B1824 File Offset: 0x000AFA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431409, XrefRangeEnd = 431418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x000B1874 File Offset: 0x000AFA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431418, XrefRangeEnd = 431427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x000B18C4 File Offset: 0x000AFAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431427, XrefRangeEnd = 431436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x000B1914 File Offset: 0x000AFB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431436, XrefRangeEnd = 431442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(Object value, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x000B197C File Offset: 0x000AFB7C
		[CallerCount(0)]
		public unsafe override string ToString(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x000B19D0 File Offset: 0x000AFBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431442, XrefRangeEnd = 431445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(bool value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x000B1A3C File Offset: 0x000AFC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431445, XrefRangeEnd = 431448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(DateTime value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x000B1AA8 File Offset: 0x000AFCA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431448, XrefRangeEnd = 431451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(Decimal value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x000B1B14 File Offset: 0x000AFD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431451, XrefRangeEnd = 431454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(double value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Double_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x000B1B80 File Offset: 0x000AFD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431454, XrefRangeEnd = 431457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(int value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x000B1BEC File Offset: 0x000AFDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431457, XrefRangeEnd = 431460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(long value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x000B1C58 File Offset: 0x000AFE58
		[CallerCount(0)]
		public unsafe override Object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x000B1CD8 File Offset: 0x000AFED8
		[CallerCount(0)]
		public unsafe override Object ChangeType(Object value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06002664 RID: 9828 RVA: 0x000B1D48 File Offset: 0x000AFF48
		public unsafe XmlSchemaType SchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_get_SchemaType_Protected_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06002665 RID: 9829 RVA: 0x000B1D88 File Offset: 0x000AFF88
		public unsafe XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_get_TypeCode_Protected_get_XmlTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06002666 RID: 9830 RVA: 0x000B1DC4 File Offset: 0x000AFFC4
		public unsafe string XmlTypeName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 431466, RefRangeEnd = 431470, XrefRangeStart = 431460, XrefRangeEnd = 431466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_get_XmlTypeName_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06002667 RID: 9831 RVA: 0x000B1DFC File Offset: 0x000AFFFC
		public unsafe Type DefaultClrType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_get_DefaultClrType_Protected_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x000B1E3C File Offset: 0x000B003C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431470, XrefRangeEnd = 431476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDerivedFrom(Type derivedType, Type baseType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_IsDerivedFrom_Protected_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x000B1E90 File Offset: 0x000B0090
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 431497, RefRangeEnd = 431499, XrefRangeStart = 431476, XrefRangeEnd = 431497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_CreateInvalidClrMappingException_Protected_Exception_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x000B1EF4 File Offset: 0x000B00F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431499, XrefRangeEnd = 431510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string QNameToString(XmlQualifiedName name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x000B1F30 File Offset: 0x000B0130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431510, XrefRangeEnd = 431515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object ChangeListType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeListType_Protected_Virtual_New_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x000B1FB0 File Offset: 0x000B01B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 431539, RefRangeEnd = 431542, XrefRangeStart = 431515, XrefRangeEnd = 431539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> StringToBase64Binary(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToBase64Binary_Protected_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x000B1FF4 File Offset: 0x000B01F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431542, XrefRangeEnd = 431547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToDate(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDate_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x000B2038 File Offset: 0x000B0238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431547, XrefRangeEnd = 431552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToDateTime(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDateTime_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x000B207C File Offset: 0x000B027C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431554, RefRangeEnd = 431555, XrefRangeStart = 431552, XrefRangeEnd = 431554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan StringToDayTimeDuration(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDayTimeDuration_Protected_Static_TimeSpan_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x000B20C0 File Offset: 0x000B02C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 431557, RefRangeEnd = 431560, XrefRangeStart = 431555, XrefRangeEnd = 431557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan StringToDuration(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDuration_Protected_Static_TimeSpan_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x000B2104 File Offset: 0x000B0304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431560, XrefRangeEnd = 431565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToGDay(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGDay_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x000B2148 File Offset: 0x000B0348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431565, XrefRangeEnd = 431570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToGMonth(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGMonth_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x000B218C File Offset: 0x000B038C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431570, XrefRangeEnd = 431575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToGMonthDay(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthDay_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x000B21D0 File Offset: 0x000B03D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431575, XrefRangeEnd = 431580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToGYear(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGYear_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x000B2214 File Offset: 0x000B0414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431580, XrefRangeEnd = 431585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToGYearMonth(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGYearMonth_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x000B2258 File Offset: 0x000B0458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431585, XrefRangeEnd = 431590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToDateOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDateOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x000B229C File Offset: 0x000B049C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431590, XrefRangeEnd = 431595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToDateTimeOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDateTimeOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x000B22E0 File Offset: 0x000B04E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431595, XrefRangeEnd = 431600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToGDayOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGDayOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x000B2324 File Offset: 0x000B0524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431600, XrefRangeEnd = 431605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToGMonthOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x000B2368 File Offset: 0x000B0568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431605, XrefRangeEnd = 431610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToGMonthDayOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthDayOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x000B23AC File Offset: 0x000B05AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431610, XrefRangeEnd = 431615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToGYearOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGYearOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x000B23F0 File Offset: 0x000B05F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431615, XrefRangeEnd = 431620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToGYearMonthOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGYearMonthOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x000B2434 File Offset: 0x000B0634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 431631, RefRangeEnd = 431633, XrefRangeStart = 431620, XrefRangeEnd = 431631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> StringToHexBinary(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToHexBinary_Protected_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x000B2478 File Offset: 0x000B0678
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 431645, RefRangeEnd = 431649, XrefRangeStart = 431633, XrefRangeEnd = 431645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToQName_Protected_Static_XmlQualifiedName_String_IXmlNamespaceResolver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x000B24D0 File Offset: 0x000B06D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431649, XrefRangeEnd = 431654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToTime(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToTime_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x000B2514 File Offset: 0x000B0714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431654, XrefRangeEnd = 431659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToTimeOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToTimeOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x000B2558 File Offset: 0x000B0758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431661, RefRangeEnd = 431662, XrefRangeStart = 431659, XrefRangeEnd = 431661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan StringToYearMonthDuration(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToYearMonthDuration_Protected_Static_TimeSpan_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x000B259C File Offset: 0x000B079C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431662, XrefRangeEnd = 431663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string AnyUriToString(Uri value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_AnyUriToString_Protected_Static_String_Uri_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x000B25D8 File Offset: 0x000B07D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431671, RefRangeEnd = 431672, XrefRangeStart = 431663, XrefRangeEnd = 431671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Base64BinaryToString(Il2CppStructArray<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Base64BinaryToString_Protected_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x000B2614 File Offset: 0x000B0814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431672, XrefRangeEnd = 431674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DateToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DateToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x000B264C File Offset: 0x000B084C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431674, XrefRangeEnd = 431676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DateTimeToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DateTimeToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x000B2684 File Offset: 0x000B0884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431676, XrefRangeEnd = 431678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DayTimeDurationToString(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DayTimeDurationToString_Protected_Static_String_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x000B26BC File Offset: 0x000B08BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431680, RefRangeEnd = 431681, XrefRangeStart = 431678, XrefRangeEnd = 431680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DurationToString(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DurationToString_Protected_Static_String_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x000B26F4 File Offset: 0x000B08F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431681, XrefRangeEnd = 431683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GDayToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GDayToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x000B272C File Offset: 0x000B092C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431683, XrefRangeEnd = 431685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GMonthToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GMonthToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x000B2764 File Offset: 0x000B0964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431685, XrefRangeEnd = 431687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GMonthDayToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GMonthDayToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x000B279C File Offset: 0x000B099C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431687, XrefRangeEnd = 431689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GYearToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GYearToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x000B27D4 File Offset: 0x000B09D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431689, XrefRangeEnd = 431691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GYearMonthToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GYearMonthToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x000B280C File Offset: 0x000B0A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431691, XrefRangeEnd = 431693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DateOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DateOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x000B2844 File Offset: 0x000B0A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431693, XrefRangeEnd = 431695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DateTimeOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DateTimeOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x000B287C File Offset: 0x000B0A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431695, XrefRangeEnd = 431697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GDayOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GDayOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x000B28B4 File Offset: 0x000B0AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431697, XrefRangeEnd = 431699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GMonthOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GMonthOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x000B28EC File Offset: 0x000B0AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431699, XrefRangeEnd = 431701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GMonthDayOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GMonthDayOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x000B2924 File Offset: 0x000B0B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431701, XrefRangeEnd = 431703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GYearOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GYearOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x000B295C File Offset: 0x000B0B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431703, XrefRangeEnd = 431705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GYearMonthOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GYearMonthOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x000B2994 File Offset: 0x000B0B94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431713, RefRangeEnd = 431714, XrefRangeStart = 431705, XrefRangeEnd = 431713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_IXmlNamespaceResolver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x000B29E4 File Offset: 0x000B0BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431714, XrefRangeEnd = 431716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TimeToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_TimeToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x000B2A1C File Offset: 0x000B0C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431716, XrefRangeEnd = 431718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TimeOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_TimeOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x000B2A54 File Offset: 0x000B0C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431718, XrefRangeEnd = 431720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string YearMonthDurationToString(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_YearMonthDurationToString_Protected_Static_String_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x000B2A8C File Offset: 0x000B0C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431720, XrefRangeEnd = 431721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime DateTimeOffsetToDateTime(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DateTimeOffsetToDateTime_Internal_Static_DateTime_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x000B2ACC File Offset: 0x000B0CCC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 431745, RefRangeEnd = 431751, XrefRangeStart = 431721, XrefRangeEnd = 431745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DecimalToInt32(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DecimalToInt32_Internal_Static_Int32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x000B2B0C File Offset: 0x000B0D0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 431775, RefRangeEnd = 431777, XrefRangeStart = 431751, XrefRangeEnd = 431775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long DecimalToInt64(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DecimalToInt64_Protected_Static_Int64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x000B2B4C File Offset: 0x000B0D4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 431801, RefRangeEnd = 431805, XrefRangeStart = 431777, XrefRangeEnd = 431801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong DecimalToUInt64(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DecimalToUInt64_Protected_Static_UInt64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x000B2B8C File Offset: 0x000B0D8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 431805, RefRangeEnd = 431807, XrefRangeStart = 431805, XrefRangeEnd = 431805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte Int32ToByte(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int32ToByte_Protected_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x000B2BCC File Offset: 0x000B0DCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 431807, RefRangeEnd = 431809, XrefRangeStart = 431807, XrefRangeEnd = 431807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short Int32ToInt16(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int32ToInt16_Protected_Static_Int16_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x000B2C0C File Offset: 0x000B0E0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 431809, RefRangeEnd = 431811, XrefRangeStart = 431809, XrefRangeEnd = 431809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte Int32ToSByte(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int32ToSByte_Protected_Static_SByte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x000B2C4C File Offset: 0x000B0E4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 431811, RefRangeEnd = 431813, XrefRangeStart = 431811, XrefRangeEnd = 431811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort Int32ToUInt16(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int32ToUInt16_Protected_Static_UInt16_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x000B2C8C File Offset: 0x000B0E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431813, RefRangeEnd = 431814, XrefRangeStart = 431813, XrefRangeEnd = 431813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Int64ToInt32(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int64ToInt32_Protected_Static_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x000B2CCC File Offset: 0x000B0ECC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 431814, RefRangeEnd = 431818, XrefRangeStart = 431814, XrefRangeEnd = 431814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Int64ToUInt32(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int64ToUInt32_Protected_Static_UInt32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x000B2D0C File Offset: 0x000B0F0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 431823, RefRangeEnd = 431825, XrefRangeStart = 431818, XrefRangeEnd = 431823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime UntypedAtomicToDateTime(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_UntypedAtomicToDateTime_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x000B2D50 File Offset: 0x000B0F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431830, RefRangeEnd = 431831, XrefRangeStart = 431825, XrefRangeEnd = 431830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset UntypedAtomicToDateTimeOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_UntypedAtomicToDateTimeOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x00010795 File Offset: 0x0000E995
		public XmlBaseConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x000B2D94 File Offset: 0x000B0F94
		// (set) Token: 0x060026A6 RID: 9894 RVA: 0x0001079E File Offset: 0x0000E99E
		public unsafe XmlSchemaType schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_schemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_schemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x060026A7 RID: 9895 RVA: 0x000B2DC4 File Offset: 0x000B0FC4
		// (set) Token: 0x060026A8 RID: 9896 RVA: 0x000107BD File Offset: 0x0000E9BD
		public unsafe XmlTypeCode typeCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_typeCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_typeCode)) = value;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x060026A9 RID: 9897 RVA: 0x000B2DEC File Offset: 0x000B0FEC
		// (set) Token: 0x060026AA RID: 9898 RVA: 0x000107D8 File Offset: 0x0000E9D8
		public unsafe Type clrTypeDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_clrTypeDefault);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_clrTypeDefault), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x000B2E1C File Offset: 0x000B101C
		// (set) Token: 0x060026AC RID: 9900 RVA: 0x000107F7 File Offset: 0x0000E9F7
		public unsafe static Type ICollectionType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_ICollectionType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_ICollectionType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x000B2E44 File Offset: 0x000B1044
		// (set) Token: 0x060026AE RID: 9902 RVA: 0x00010809 File Offset: 0x0000EA09
		public unsafe static Type IEnumerableType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_IEnumerableType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_IEnumerableType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x000B2E6C File Offset: 0x000B106C
		// (set) Token: 0x060026B0 RID: 9904 RVA: 0x0001081B File Offset: 0x0000EA1B
		public unsafe static Type IListType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_IListType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_IListType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x000B2E94 File Offset: 0x000B1094
		// (set) Token: 0x060026B2 RID: 9906 RVA: 0x0001082D File Offset: 0x0000EA2D
		public unsafe static Type ObjectArrayType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_ObjectArrayType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_ObjectArrayType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x060026B3 RID: 9907 RVA: 0x000B2EBC File Offset: 0x000B10BC
		// (set) Token: 0x060026B4 RID: 9908 RVA: 0x0001083F File Offset: 0x0000EA3F
		public unsafe static Type StringArrayType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_StringArrayType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_StringArrayType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x060026B5 RID: 9909 RVA: 0x000B2EE4 File Offset: 0x000B10E4
		// (set) Token: 0x060026B6 RID: 9910 RVA: 0x00010851 File Offset: 0x0000EA51
		public unsafe static Type XmlAtomicValueArrayType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueArrayType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueArrayType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x000B2F0C File Offset: 0x000B110C
		// (set) Token: 0x060026B8 RID: 9912 RVA: 0x00010863 File Offset: 0x0000EA63
		public unsafe static Type DecimalType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_DecimalType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_DecimalType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x060026B9 RID: 9913 RVA: 0x000B2F34 File Offset: 0x000B1134
		// (set) Token: 0x060026BA RID: 9914 RVA: 0x00010875 File Offset: 0x0000EA75
		public unsafe static Type Int32Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_Int32Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_Int32Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x000B2F5C File Offset: 0x000B115C
		// (set) Token: 0x060026BC RID: 9916 RVA: 0x00010887 File Offset: 0x0000EA87
		public unsafe static Type Int64Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_Int64Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_Int64Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x060026BD RID: 9917 RVA: 0x000B2F84 File Offset: 0x000B1184
		// (set) Token: 0x060026BE RID: 9918 RVA: 0x00010899 File Offset: 0x0000EA99
		public unsafe static Type StringType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_StringType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_StringType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x060026BF RID: 9919 RVA: 0x000B2FAC File Offset: 0x000B11AC
		// (set) Token: 0x060026C0 RID: 9920 RVA: 0x000108AB File Offset: 0x0000EAAB
		public unsafe static Type XmlAtomicValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x000B2FD4 File Offset: 0x000B11D4
		// (set) Token: 0x060026C2 RID: 9922 RVA: 0x000108BD File Offset: 0x0000EABD
		public unsafe static Type ObjectType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_ObjectType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_ObjectType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x000B2FFC File Offset: 0x000B11FC
		// (set) Token: 0x060026C4 RID: 9924 RVA: 0x000108CF File Offset: 0x0000EACF
		public unsafe static Type ByteType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_ByteType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_ByteType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x000B3024 File Offset: 0x000B1224
		// (set) Token: 0x060026C6 RID: 9926 RVA: 0x000108E1 File Offset: 0x0000EAE1
		public unsafe static Type Int16Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_Int16Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_Int16Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x000B304C File Offset: 0x000B124C
		// (set) Token: 0x060026C8 RID: 9928 RVA: 0x000108F3 File Offset: 0x0000EAF3
		public unsafe static Type SByteType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_SByteType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_SByteType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x000B3074 File Offset: 0x000B1274
		// (set) Token: 0x060026CA RID: 9930 RVA: 0x00010905 File Offset: 0x0000EB05
		public unsafe static Type UInt16Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_UInt16Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_UInt16Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x060026CB RID: 9931 RVA: 0x000B309C File Offset: 0x000B129C
		// (set) Token: 0x060026CC RID: 9932 RVA: 0x00010917 File Offset: 0x0000EB17
		public unsafe static Type UInt32Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_UInt32Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_UInt32Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x060026CD RID: 9933 RVA: 0x000B30C4 File Offset: 0x000B12C4
		// (set) Token: 0x060026CE RID: 9934 RVA: 0x00010929 File Offset: 0x0000EB29
		public unsafe static Type UInt64Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_UInt64Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_UInt64Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x000B30EC File Offset: 0x000B12EC
		// (set) Token: 0x060026D0 RID: 9936 RVA: 0x0001093B File Offset: 0x0000EB3B
		public unsafe static Type XPathItemType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_XPathItemType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_XPathItemType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x000B3114 File Offset: 0x000B1314
		// (set) Token: 0x060026D2 RID: 9938 RVA: 0x0001094D File Offset: 0x0000EB4D
		public unsafe static Type DoubleType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_DoubleType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_DoubleType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x000B313C File Offset: 0x000B133C
		// (set) Token: 0x060026D4 RID: 9940 RVA: 0x0001095F File Offset: 0x0000EB5F
		public unsafe static Type SingleType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_SingleType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_SingleType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x000B3164 File Offset: 0x000B1364
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x00010971 File Offset: 0x0000EB71
		public unsafe static Type DateTimeType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_DateTimeType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_DateTimeType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x000B318C File Offset: 0x000B138C
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x00010983 File Offset: 0x0000EB83
		public unsafe static Type DateTimeOffsetType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_DateTimeOffsetType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_DateTimeOffsetType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x000B31B4 File Offset: 0x000B13B4
		// (set) Token: 0x060026DA RID: 9946 RVA: 0x00010995 File Offset: 0x0000EB95
		public unsafe static Type BooleanType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_BooleanType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_BooleanType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x000B31DC File Offset: 0x000B13DC
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x000109A7 File Offset: 0x0000EBA7
		public unsafe static Type ByteArrayType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_ByteArrayType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_ByteArrayType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x000B3204 File Offset: 0x000B1404
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x000109B9 File Offset: 0x0000EBB9
		public unsafe static Type XmlQualifiedNameType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_XmlQualifiedNameType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_XmlQualifiedNameType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x000B322C File Offset: 0x000B142C
		// (set) Token: 0x060026E0 RID: 9952 RVA: 0x000109CB File Offset: 0x0000EBCB
		public unsafe static Type UriType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_UriType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_UriType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x060026E1 RID: 9953 RVA: 0x000B3254 File Offset: 0x000B1454
		// (set) Token: 0x060026E2 RID: 9954 RVA: 0x000109DD File Offset: 0x0000EBDD
		public unsafe static Type TimeSpanType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_TimeSpanType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_TimeSpanType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x000B327C File Offset: 0x000B147C
		// (set) Token: 0x060026E4 RID: 9956 RVA: 0x000109EF File Offset: 0x0000EBEF
		public unsafe static Type XPathNavigatorType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_XPathNavigatorType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_XPathNavigatorType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CA9 RID: 7337
		private static readonly IntPtr NativeFieldInfoPtr_schemaType;

		// Token: 0x04001CAA RID: 7338
		private static readonly IntPtr NativeFieldInfoPtr_typeCode;

		// Token: 0x04001CAB RID: 7339
		private static readonly IntPtr NativeFieldInfoPtr_clrTypeDefault;

		// Token: 0x04001CAC RID: 7340
		private static readonly IntPtr NativeFieldInfoPtr_ICollectionType;

		// Token: 0x04001CAD RID: 7341
		private static readonly IntPtr NativeFieldInfoPtr_IEnumerableType;

		// Token: 0x04001CAE RID: 7342
		private static readonly IntPtr NativeFieldInfoPtr_IListType;

		// Token: 0x04001CAF RID: 7343
		private static readonly IntPtr NativeFieldInfoPtr_ObjectArrayType;

		// Token: 0x04001CB0 RID: 7344
		private static readonly IntPtr NativeFieldInfoPtr_StringArrayType;

		// Token: 0x04001CB1 RID: 7345
		private static readonly IntPtr NativeFieldInfoPtr_XmlAtomicValueArrayType;

		// Token: 0x04001CB2 RID: 7346
		private static readonly IntPtr NativeFieldInfoPtr_DecimalType;

		// Token: 0x04001CB3 RID: 7347
		private static readonly IntPtr NativeFieldInfoPtr_Int32Type;

		// Token: 0x04001CB4 RID: 7348
		private static readonly IntPtr NativeFieldInfoPtr_Int64Type;

		// Token: 0x04001CB5 RID: 7349
		private static readonly IntPtr NativeFieldInfoPtr_StringType;

		// Token: 0x04001CB6 RID: 7350
		private static readonly IntPtr NativeFieldInfoPtr_XmlAtomicValueType;

		// Token: 0x04001CB7 RID: 7351
		private static readonly IntPtr NativeFieldInfoPtr_ObjectType;

		// Token: 0x04001CB8 RID: 7352
		private static readonly IntPtr NativeFieldInfoPtr_ByteType;

		// Token: 0x04001CB9 RID: 7353
		private static readonly IntPtr NativeFieldInfoPtr_Int16Type;

		// Token: 0x04001CBA RID: 7354
		private static readonly IntPtr NativeFieldInfoPtr_SByteType;

		// Token: 0x04001CBB RID: 7355
		private static readonly IntPtr NativeFieldInfoPtr_UInt16Type;

		// Token: 0x04001CBC RID: 7356
		private static readonly IntPtr NativeFieldInfoPtr_UInt32Type;

		// Token: 0x04001CBD RID: 7357
		private static readonly IntPtr NativeFieldInfoPtr_UInt64Type;

		// Token: 0x04001CBE RID: 7358
		private static readonly IntPtr NativeFieldInfoPtr_XPathItemType;

		// Token: 0x04001CBF RID: 7359
		private static readonly IntPtr NativeFieldInfoPtr_DoubleType;

		// Token: 0x04001CC0 RID: 7360
		private static readonly IntPtr NativeFieldInfoPtr_SingleType;

		// Token: 0x04001CC1 RID: 7361
		private static readonly IntPtr NativeFieldInfoPtr_DateTimeType;

		// Token: 0x04001CC2 RID: 7362
		private static readonly IntPtr NativeFieldInfoPtr_DateTimeOffsetType;

		// Token: 0x04001CC3 RID: 7363
		private static readonly IntPtr NativeFieldInfoPtr_BooleanType;

		// Token: 0x04001CC4 RID: 7364
		private static readonly IntPtr NativeFieldInfoPtr_ByteArrayType;

		// Token: 0x04001CC5 RID: 7365
		private static readonly IntPtr NativeFieldInfoPtr_XmlQualifiedNameType;

		// Token: 0x04001CC6 RID: 7366
		private static readonly IntPtr NativeFieldInfoPtr_UriType;

		// Token: 0x04001CC7 RID: 7367
		private static readonly IntPtr NativeFieldInfoPtr_TimeSpanType;

		// Token: 0x04001CC8 RID: 7368
		private static readonly IntPtr NativeFieldInfoPtr_XPathNavigatorType;

		// Token: 0x04001CC9 RID: 7369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0;

		// Token: 0x04001CCA RID: 7370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlTypeCode_0;

		// Token: 0x04001CCB RID: 7371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0;

		// Token: 0x04001CCC RID: 7372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_Type_0;

		// Token: 0x04001CCD RID: 7373
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_DateTime_0;

		// Token: 0x04001CCE RID: 7374
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Double_0;

		// Token: 0x04001CCF RID: 7375
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int32_0;

		// Token: 0x04001CD0 RID: 7376
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int64_0;

		// Token: 0x04001CD1 RID: 7377
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_String_0;

		// Token: 0x04001CD2 RID: 7378
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001CD3 RID: 7379
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Boolean_0;

		// Token: 0x04001CD4 RID: 7380
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_DateTimeOffset_0;

		// Token: 0x04001CD5 RID: 7381
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Double_0;

		// Token: 0x04001CD6 RID: 7382
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_0;

		// Token: 0x04001CD7 RID: 7383
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int64_0;

		// Token: 0x04001CD8 RID: 7384
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_String_0;

		// Token: 0x04001CD9 RID: 7385
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0;

		// Token: 0x04001CDA RID: 7386
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_DateTime_0;

		// Token: 0x04001CDB RID: 7387
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_String_0;

		// Token: 0x04001CDC RID: 7388
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0;

		// Token: 0x04001CDD RID: 7389
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_String_0;

		// Token: 0x04001CDE RID: 7390
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0;

		// Token: 0x04001CDF RID: 7391
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Boolean_0;

		// Token: 0x04001CE0 RID: 7392
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_DateTime_0;

		// Token: 0x04001CE1 RID: 7393
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int32_0;

		// Token: 0x04001CE2 RID: 7394
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int64_0;

		// Token: 0x04001CE3 RID: 7395
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_String_0;

		// Token: 0x04001CE4 RID: 7396
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Object_0;

		// Token: 0x04001CE5 RID: 7397
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Boolean_0;

		// Token: 0x04001CE6 RID: 7398
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_DateTime_0;

		// Token: 0x04001CE7 RID: 7399
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Double_0;

		// Token: 0x04001CE8 RID: 7400
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Int64_0;

		// Token: 0x04001CE9 RID: 7401
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_String_0;

		// Token: 0x04001CEA RID: 7402
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0;

		// Token: 0x04001CEB RID: 7403
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Boolean_0;

		// Token: 0x04001CEC RID: 7404
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_DateTime_0;

		// Token: 0x04001CED RID: 7405
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Double_0;

		// Token: 0x04001CEE RID: 7406
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Int32_0;

		// Token: 0x04001CEF RID: 7407
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_String_0;

		// Token: 0x04001CF0 RID: 7408
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0;

		// Token: 0x04001CF1 RID: 7409
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Double_0;

		// Token: 0x04001CF2 RID: 7410
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_String_0;

		// Token: 0x04001CF3 RID: 7411
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Object_0;

		// Token: 0x04001CF4 RID: 7412
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0;

		// Token: 0x04001CF5 RID: 7413
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTime_0;

		// Token: 0x04001CF6 RID: 7414
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTimeOffset_0;

		// Token: 0x04001CF7 RID: 7415
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Decimal_0;

		// Token: 0x04001CF8 RID: 7416
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Double_0;

		// Token: 0x04001CF9 RID: 7417
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Int32_0;

		// Token: 0x04001CFA RID: 7418
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Int64_0;

		// Token: 0x04001CFB RID: 7419
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Single_0;

		// Token: 0x04001CFC RID: 7420
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0;

		// Token: 0x04001CFD RID: 7421
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_0;

		// Token: 0x04001CFE RID: 7422
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0;

		// Token: 0x04001CFF RID: 7423
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0;

		// Token: 0x04001D00 RID: 7424
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0;

		// Token: 0x04001D01 RID: 7425
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Double_Type_0;

		// Token: 0x04001D02 RID: 7426
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0;

		// Token: 0x04001D03 RID: 7427
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0;

		// Token: 0x04001D04 RID: 7428
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0;

		// Token: 0x04001D05 RID: 7429
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_0;

		// Token: 0x04001D06 RID: 7430
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Protected_get_XmlSchemaType_0;

		// Token: 0x04001D07 RID: 7431
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Protected_get_XmlTypeCode_0;

		// Token: 0x04001D08 RID: 7432
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlTypeName_Protected_get_String_0;

		// Token: 0x04001D09 RID: 7433
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultClrType_Protected_get_Type_0;

		// Token: 0x04001D0A RID: 7434
		private static readonly IntPtr NativeMethodInfoPtr_IsDerivedFrom_Protected_Static_Boolean_Type_Type_0;

		// Token: 0x04001D0B RID: 7435
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidClrMappingException_Protected_Exception_Type_Type_0;

		// Token: 0x04001D0C RID: 7436
		private static readonly IntPtr NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_0;

		// Token: 0x04001D0D RID: 7437
		private static readonly IntPtr NativeMethodInfoPtr_ChangeListType_Protected_Virtual_New_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04001D0E RID: 7438
		private static readonly IntPtr NativeMethodInfoPtr_StringToBase64Binary_Protected_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04001D0F RID: 7439
		private static readonly IntPtr NativeMethodInfoPtr_StringToDate_Protected_Static_DateTime_String_0;

		// Token: 0x04001D10 RID: 7440
		private static readonly IntPtr NativeMethodInfoPtr_StringToDateTime_Protected_Static_DateTime_String_0;

		// Token: 0x04001D11 RID: 7441
		private static readonly IntPtr NativeMethodInfoPtr_StringToDayTimeDuration_Protected_Static_TimeSpan_String_0;

		// Token: 0x04001D12 RID: 7442
		private static readonly IntPtr NativeMethodInfoPtr_StringToDuration_Protected_Static_TimeSpan_String_0;

		// Token: 0x04001D13 RID: 7443
		private static readonly IntPtr NativeMethodInfoPtr_StringToGDay_Protected_Static_DateTime_String_0;

		// Token: 0x04001D14 RID: 7444
		private static readonly IntPtr NativeMethodInfoPtr_StringToGMonth_Protected_Static_DateTime_String_0;

		// Token: 0x04001D15 RID: 7445
		private static readonly IntPtr NativeMethodInfoPtr_StringToGMonthDay_Protected_Static_DateTime_String_0;

		// Token: 0x04001D16 RID: 7446
		private static readonly IntPtr NativeMethodInfoPtr_StringToGYear_Protected_Static_DateTime_String_0;

		// Token: 0x04001D17 RID: 7447
		private static readonly IntPtr NativeMethodInfoPtr_StringToGYearMonth_Protected_Static_DateTime_String_0;

		// Token: 0x04001D18 RID: 7448
		private static readonly IntPtr NativeMethodInfoPtr_StringToDateOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04001D19 RID: 7449
		private static readonly IntPtr NativeMethodInfoPtr_StringToDateTimeOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04001D1A RID: 7450
		private static readonly IntPtr NativeMethodInfoPtr_StringToGDayOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04001D1B RID: 7451
		private static readonly IntPtr NativeMethodInfoPtr_StringToGMonthOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04001D1C RID: 7452
		private static readonly IntPtr NativeMethodInfoPtr_StringToGMonthDayOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04001D1D RID: 7453
		private static readonly IntPtr NativeMethodInfoPtr_StringToGYearOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04001D1E RID: 7454
		private static readonly IntPtr NativeMethodInfoPtr_StringToGYearMonthOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04001D1F RID: 7455
		private static readonly IntPtr NativeMethodInfoPtr_StringToHexBinary_Protected_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04001D20 RID: 7456
		private static readonly IntPtr NativeMethodInfoPtr_StringToQName_Protected_Static_XmlQualifiedName_String_IXmlNamespaceResolver_0;

		// Token: 0x04001D21 RID: 7457
		private static readonly IntPtr NativeMethodInfoPtr_StringToTime_Protected_Static_DateTime_String_0;

		// Token: 0x04001D22 RID: 7458
		private static readonly IntPtr NativeMethodInfoPtr_StringToTimeOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04001D23 RID: 7459
		private static readonly IntPtr NativeMethodInfoPtr_StringToYearMonthDuration_Protected_Static_TimeSpan_String_0;

		// Token: 0x04001D24 RID: 7460
		private static readonly IntPtr NativeMethodInfoPtr_AnyUriToString_Protected_Static_String_Uri_0;

		// Token: 0x04001D25 RID: 7461
		private static readonly IntPtr NativeMethodInfoPtr_Base64BinaryToString_Protected_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001D26 RID: 7462
		private static readonly IntPtr NativeMethodInfoPtr_DateToString_Protected_Static_String_DateTime_0;

		// Token: 0x04001D27 RID: 7463
		private static readonly IntPtr NativeMethodInfoPtr_DateTimeToString_Protected_Static_String_DateTime_0;

		// Token: 0x04001D28 RID: 7464
		private static readonly IntPtr NativeMethodInfoPtr_DayTimeDurationToString_Protected_Static_String_TimeSpan_0;

		// Token: 0x04001D29 RID: 7465
		private static readonly IntPtr NativeMethodInfoPtr_DurationToString_Protected_Static_String_TimeSpan_0;

		// Token: 0x04001D2A RID: 7466
		private static readonly IntPtr NativeMethodInfoPtr_GDayToString_Protected_Static_String_DateTime_0;

		// Token: 0x04001D2B RID: 7467
		private static readonly IntPtr NativeMethodInfoPtr_GMonthToString_Protected_Static_String_DateTime_0;

		// Token: 0x04001D2C RID: 7468
		private static readonly IntPtr NativeMethodInfoPtr_GMonthDayToString_Protected_Static_String_DateTime_0;

		// Token: 0x04001D2D RID: 7469
		private static readonly IntPtr NativeMethodInfoPtr_GYearToString_Protected_Static_String_DateTime_0;

		// Token: 0x04001D2E RID: 7470
		private static readonly IntPtr NativeMethodInfoPtr_GYearMonthToString_Protected_Static_String_DateTime_0;

		// Token: 0x04001D2F RID: 7471
		private static readonly IntPtr NativeMethodInfoPtr_DateOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04001D30 RID: 7472
		private static readonly IntPtr NativeMethodInfoPtr_DateTimeOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04001D31 RID: 7473
		private static readonly IntPtr NativeMethodInfoPtr_GDayOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04001D32 RID: 7474
		private static readonly IntPtr NativeMethodInfoPtr_GMonthOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04001D33 RID: 7475
		private static readonly IntPtr NativeMethodInfoPtr_GMonthDayOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04001D34 RID: 7476
		private static readonly IntPtr NativeMethodInfoPtr_GYearOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04001D35 RID: 7477
		private static readonly IntPtr NativeMethodInfoPtr_GYearMonthOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_IXmlNamespaceResolver_0;

		// Token: 0x04001D37 RID: 7479
		private static readonly IntPtr NativeMethodInfoPtr_TimeToString_Protected_Static_String_DateTime_0;

		// Token: 0x04001D38 RID: 7480
		private static readonly IntPtr NativeMethodInfoPtr_TimeOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04001D39 RID: 7481
		private static readonly IntPtr NativeMethodInfoPtr_YearMonthDurationToString_Protected_Static_String_TimeSpan_0;

		// Token: 0x04001D3A RID: 7482
		private static readonly IntPtr NativeMethodInfoPtr_DateTimeOffsetToDateTime_Internal_Static_DateTime_DateTimeOffset_0;

		// Token: 0x04001D3B RID: 7483
		private static readonly IntPtr NativeMethodInfoPtr_DecimalToInt32_Internal_Static_Int32_Decimal_0;

		// Token: 0x04001D3C RID: 7484
		private static readonly IntPtr NativeMethodInfoPtr_DecimalToInt64_Protected_Static_Int64_Decimal_0;

		// Token: 0x04001D3D RID: 7485
		private static readonly IntPtr NativeMethodInfoPtr_DecimalToUInt64_Protected_Static_UInt64_Decimal_0;

		// Token: 0x04001D3E RID: 7486
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToByte_Protected_Static_Byte_Int32_0;

		// Token: 0x04001D3F RID: 7487
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToInt16_Protected_Static_Int16_Int32_0;

		// Token: 0x04001D40 RID: 7488
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToSByte_Protected_Static_SByte_Int32_0;

		// Token: 0x04001D41 RID: 7489
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToUInt16_Protected_Static_UInt16_Int32_0;

		// Token: 0x04001D42 RID: 7490
		private static readonly IntPtr NativeMethodInfoPtr_Int64ToInt32_Protected_Static_Int32_Int64_0;

		// Token: 0x04001D43 RID: 7491
		private static readonly IntPtr NativeMethodInfoPtr_Int64ToUInt32_Protected_Static_UInt32_Int64_0;

		// Token: 0x04001D44 RID: 7492
		private static readonly IntPtr NativeMethodInfoPtr_UntypedAtomicToDateTime_Protected_Static_DateTime_String_0;

		// Token: 0x04001D45 RID: 7493
		private static readonly IntPtr NativeMethodInfoPtr_UntypedAtomicToDateTimeOffset_Protected_Static_DateTimeOffset_String_0;
	}
}
