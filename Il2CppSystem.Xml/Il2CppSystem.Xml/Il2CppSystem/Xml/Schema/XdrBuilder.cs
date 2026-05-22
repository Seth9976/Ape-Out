using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000184 RID: 388
	public sealed class XdrBuilder : SchemaBuilder
	{
		// Token: 0x06001F0C RID: 7948 RVA: 0x00093A4C File Offset: 0x00091C4C
		// Note: this type is marked as 'beforefieldinit'.
		static XdrBuilder()
		{
			Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XdrBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr);
			XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_Element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Root_Element");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_SubElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Root_SubElements");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementType_SubElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_ElementType_SubElements");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeType_SubElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_AttributeType_SubElements");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_Group_SubElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Group_SubElements");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Root_Attributes");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementType_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_ElementType_Attributes");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeType_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_AttributeType_Attributes");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_Element_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Element_Attributes");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_Attribute_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Attribute_Attributes");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_Group_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Group_Attributes");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementDataType_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_ElementDataType_Attributes");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeDataType_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_AttributeDataType_Attributes");
			XdrBuilder.NativeFieldInfoPtr_S_SchemaEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_SchemaEntries");
			XdrBuilder.NativeFieldInfoPtr__SchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_SchemaInfo");
			XdrBuilder.NativeFieldInfoPtr__TargetNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_TargetNamespace");
			XdrBuilder.NativeFieldInfoPtr__reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_reader");
			XdrBuilder.NativeFieldInfoPtr_positionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "positionInfo");
			XdrBuilder.NativeFieldInfoPtr__contentValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_contentValidator");
			XdrBuilder.NativeFieldInfoPtr__CurState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_CurState");
			XdrBuilder.NativeFieldInfoPtr__NextState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_NextState");
			XdrBuilder.NativeFieldInfoPtr__StateHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_StateHistory");
			XdrBuilder.NativeFieldInfoPtr__GroupStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_GroupStack");
			XdrBuilder.NativeFieldInfoPtr__XdrName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_XdrName");
			XdrBuilder.NativeFieldInfoPtr__XdrPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_XdrPrefix");
			XdrBuilder.NativeFieldInfoPtr__ElementDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_ElementDef");
			XdrBuilder.NativeFieldInfoPtr__GroupDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_GroupDef");
			XdrBuilder.NativeFieldInfoPtr__AttributeDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_AttributeDef");
			XdrBuilder.NativeFieldInfoPtr__UndefinedAttributeTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_UndefinedAttributeTypes");
			XdrBuilder.NativeFieldInfoPtr__BaseDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_BaseDecl");
			XdrBuilder.NativeFieldInfoPtr__NameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_NameTable");
			XdrBuilder.NativeFieldInfoPtr__SchemaNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_SchemaNames");
			XdrBuilder.NativeFieldInfoPtr__CurNsMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_CurNsMgr");
			XdrBuilder.NativeFieldInfoPtr__Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_Text");
			XdrBuilder.NativeFieldInfoPtr_validationEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "validationEventHandler");
			XdrBuilder.NativeFieldInfoPtr__UndeclaredElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_UndeclaredElements");
			XdrBuilder.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "xmlResolver");
			XdrBuilder.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_SchemaInfo_String_XmlNameTable_SchemaNames_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667714);
			XdrBuilder.NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667715);
			XdrBuilder.NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667716);
			XdrBuilder.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667717);
			XdrBuilder.NativeMethodInfoPtr_LoadSchema_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667718);
			XdrBuilder.NativeMethodInfoPtr_IsXdrSchema_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667719);
			XdrBuilder.NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667720);
			XdrBuilder.NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667721);
			XdrBuilder.NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667722);
			XdrBuilder.NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667723);
			XdrBuilder.NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667724);
			XdrBuilder.NativeMethodInfoPtr_Push_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667725);
			XdrBuilder.NativeMethodInfoPtr_Pop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667726);
			XdrBuilder.NativeMethodInfoPtr_PushGroupInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667727);
			XdrBuilder.NativeMethodInfoPtr_PopGroupInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667728);
			XdrBuilder.NativeMethodInfoPtr_XDR_InitRoot_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667729);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildRoot_Name_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667730);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildRoot_ID_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667731);
			XdrBuilder.NativeMethodInfoPtr_XDR_BeginRoot_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667732);
			XdrBuilder.NativeMethodInfoPtr_XDR_EndRoot_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667733);
			XdrBuilder.NativeMethodInfoPtr_XDR_InitElementType_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667734);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_Name_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667735);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_Content_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667736);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_Model_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667737);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_Order_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667738);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_DtType_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667739);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667740);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667741);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667742);
			XdrBuilder.NativeMethodInfoPtr_XDR_BeginElementType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667743);
			XdrBuilder.NativeMethodInfoPtr_XDR_EndElementType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667744);
			XdrBuilder.NativeMethodInfoPtr_XDR_InitAttributeType_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667745);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_Name_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667746);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_Required_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667747);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_Default_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667748);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_DtType_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667749);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667750);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667751);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667752);
			XdrBuilder.NativeMethodInfoPtr_XDR_BeginAttributeType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667753);
			XdrBuilder.NativeMethodInfoPtr_XDR_EndAttributeType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667754);
			XdrBuilder.NativeMethodInfoPtr_XDR_InitElement_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667755);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElement_Type_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667756);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElement_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667757);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElement_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667758);
			XdrBuilder.NativeMethodInfoPtr_XDR_EndElement_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667759);
			XdrBuilder.NativeMethodInfoPtr_XDR_InitAttribute_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667760);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttribute_Type_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667761);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttribute_Required_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667762);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttribute_Default_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667763);
			XdrBuilder.NativeMethodInfoPtr_XDR_BeginAttribute_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667764);
			XdrBuilder.NativeMethodInfoPtr_XDR_EndAttribute_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667765);
			XdrBuilder.NativeMethodInfoPtr_XDR_InitGroup_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667766);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildGroup_Order_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667767);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildGroup_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667768);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildGroup_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667769);
			XdrBuilder.NativeMethodInfoPtr_XDR_EndGroup_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667770);
			XdrBuilder.NativeMethodInfoPtr_XDR_InitElementDtType_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667771);
			XdrBuilder.NativeMethodInfoPtr_XDR_EndElementDtType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667772);
			XdrBuilder.NativeMethodInfoPtr_XDR_InitAttributeDtType_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667773);
			XdrBuilder.NativeMethodInfoPtr_XDR_EndAttributeDtType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667774);
			XdrBuilder.NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667775);
			XdrBuilder.NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667776);
			XdrBuilder.NativeMethodInfoPtr_IsSkipableAttribute_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667777);
			XdrBuilder.NativeMethodInfoPtr_GetOrder_Private_Int32_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667778);
			XdrBuilder.NativeMethodInfoPtr_AddOrder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667779);
			XdrBuilder.NativeMethodInfoPtr_IsYes_Private_Static_Boolean_Object_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667780);
			XdrBuilder.NativeMethodInfoPtr_ParseMinOccurs_Private_Static_UInt32_Object_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667781);
			XdrBuilder.NativeMethodInfoPtr_ParseMaxOccurs_Private_Static_UInt32_Object_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667782);
			XdrBuilder.NativeMethodInfoPtr_HandleMinMax_Private_Static_Void_ParticleContentValidator_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667783);
			XdrBuilder.NativeMethodInfoPtr_ParseDtMaxLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667784);
			XdrBuilder.NativeMethodInfoPtr_ParseDtMinLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667785);
			XdrBuilder.NativeMethodInfoPtr_CompareMinMaxLength_Private_Static_Void_UInt32_UInt32_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667786);
			XdrBuilder.NativeMethodInfoPtr_ParseInteger_Private_Static_Boolean_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667787);
			XdrBuilder.NativeMethodInfoPtr_XDR_CheckAttributeDefault_Private_Void_DeclBaseInfo_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667788);
			XdrBuilder.NativeMethodInfoPtr_SetAttributePresence_Private_Void_SchemaAttDef_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667789);
			XdrBuilder.NativeMethodInfoPtr_GetContent_Private_Int32_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667790);
			XdrBuilder.NativeMethodInfoPtr_GetModel_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667791);
			XdrBuilder.NativeMethodInfoPtr_CheckDatatype_Private_XmlSchemaDatatype_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667792);
			XdrBuilder.NativeMethodInfoPtr_CheckDefaultAttValue_Private_Void_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667793);
			XdrBuilder.NativeMethodInfoPtr_IsGlobal_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667794);
			XdrBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667795);
			XdrBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667796);
			XdrBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667797);
			XdrBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667798);
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x00094404 File Offset: 0x00092604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424754, RefRangeEnd = 424755, XrefRangeStart = 424726, XrefRangeEnd = 424754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XdrBuilder(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(curmgr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sinfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamspace);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaNames);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventhandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_SchemaInfo_String_XmlNameTable_SchemaNames_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x000944C0 File Offset: 0x000926C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424755, XrefRangeEnd = 424769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00094534 File Offset: 0x00092734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424769, XrefRangeEnd = 424780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AE0 RID: 2784
		// (set) Token: 0x06001F10 RID: 7952 RVA: 0x000945B0 File Offset: 0x000927B0
		public unsafe XmlResolver XmlResolver
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x000945F4 File Offset: 0x000927F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424780, XrefRangeEnd = 424814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LoadSchema(string uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_LoadSchema_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00094644 File Offset: 0x00092844
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424821, RefRangeEnd = 424822, XrefRangeStart = 424814, XrefRangeEnd = 424821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsXdrSchema(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_IsXdrSchema_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00094688 File Offset: 0x00092888
		[CallerCount(0)]
		public unsafe override bool IsContentParsed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x000946C4 File Offset: 0x000928C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424822, XrefRangeEnd = 424829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessMarkup(Il2CppReferenceArray<XmlNode> markup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(markup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00094708 File Offset: 0x00092908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424829, XrefRangeEnd = 424832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessCData(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x0009474C File Offset: 0x0009294C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424832, XrefRangeEnd = 424833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00094780 File Offset: 0x00092980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424833, XrefRangeEnd = 424837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x000947B4 File Offset: 0x000929B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424837, XrefRangeEnd = 424839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_Push_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x000947E8 File Offset: 0x000929E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424839, XrefRangeEnd = 424842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_Pop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x0009481C File Offset: 0x00092A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424842, XrefRangeEnd = 424848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushGroupInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_PushGroupInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x00094850 File Offset: 0x00092A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424848, XrefRangeEnd = 424851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopGroupInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_PopGroupInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00094884 File Offset: 0x00092A84
		[CallerCount(0)]
		public unsafe static void XDR_InitRoot(XdrBuilder builder, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_InitRoot_Private_Static_Void_XdrBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x000948CC File Offset: 0x00092ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424851, XrefRangeEnd = 424853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildRoot_Name(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildRoot_Name_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x00094928 File Offset: 0x00092B28
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildRoot_ID(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildRoot_ID_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00094984 File Offset: 0x00092B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424853, XrefRangeEnd = 424862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BeginRoot(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BeginRoot_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x000949BC File Offset: 0x00092BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424862, XrefRangeEnd = 424908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_EndRoot(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_EndRoot_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x000949F4 File Offset: 0x00092BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424908, XrefRangeEnd = 424922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_InitElementType(XdrBuilder builder, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_InitElementType_Private_Static_Void_XdrBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00094A3C File Offset: 0x00092C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424922, XrefRangeEnd = 424936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElementType_Name(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_Name_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00094A98 File Offset: 0x00092C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424936, XrefRangeEnd = 424939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElementType_Content(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_Content_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x00094AF4 File Offset: 0x00092CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424939, XrefRangeEnd = 424945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElementType_Model(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_Model_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x00094B50 File Offset: 0x00092D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424945, XrefRangeEnd = 424948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElementType_Order(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_Order_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x00094BAC File Offset: 0x00092DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424948, XrefRangeEnd = 424956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElementType_DtType(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_DtType_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x00094C08 File Offset: 0x00092E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424956, XrefRangeEnd = 424966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElementType_DtValues(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00094C64 File Offset: 0x00092E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424966, XrefRangeEnd = 424971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x00094CC0 File Offset: 0x00092EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424971, XrefRangeEnd = 424976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x00094D1C File Offset: 0x00092F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424976, XrefRangeEnd = 425005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BeginElementType(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BeginElementType_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00094D54 File Offset: 0x00092F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425005, XrefRangeEnd = 425056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_EndElementType(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_EndElementType_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x00094D8C File Offset: 0x00092F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425056, XrefRangeEnd = 425064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_InitAttributeType(XdrBuilder builder, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_InitAttributeType_Private_Static_Void_XdrBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00094DD4 File Offset: 0x00092FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425064, XrefRangeEnd = 425075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttributeType_Name(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_Name_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x00094E30 File Offset: 0x00093030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425075, XrefRangeEnd = 425079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttributeType_Required(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_Required_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00094E8C File Offset: 0x0009308C
		[CallerCount(0)]
		public unsafe static void XDR_BuildAttributeType_Default(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_Default_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x00094EE8 File Offset: 0x000930E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425079, XrefRangeEnd = 425082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttributeType_DtType(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_DtType_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00094F44 File Offset: 0x00093144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425082, XrefRangeEnd = 425092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00094FA0 File Offset: 0x000931A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425092, XrefRangeEnd = 425097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x00094FFC File Offset: 0x000931FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425097, XrefRangeEnd = 425102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00095058 File Offset: 0x00093258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425102, XrefRangeEnd = 425107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BeginAttributeType(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BeginAttributeType_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x00095090 File Offset: 0x00093290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425107, XrefRangeEnd = 425123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_EndAttributeType(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_EndAttributeType_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x000950C8 File Offset: 0x000932C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425123, XrefRangeEnd = 425128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_InitElement(XdrBuilder builder, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_InitElement_Private_Static_Void_XdrBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x00095110 File Offset: 0x00093310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425128, XrefRangeEnd = 425144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElement_Type(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElement_Type_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x0009516C File Offset: 0x0009336C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425144, XrefRangeEnd = 425148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElement_MinOccurs(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElement_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x000951C8 File Offset: 0x000933C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425148, XrefRangeEnd = 425152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElement_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00095224 File Offset: 0x00093424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425152, XrefRangeEnd = 425161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_EndElement(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_EndElement_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x0009525C File Offset: 0x0009345C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425161, XrefRangeEnd = 425165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_InitAttribute(XdrBuilder builder, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_InitAttribute_Private_Static_Void_XdrBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x000952A4 File Offset: 0x000934A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425165, XrefRangeEnd = 425167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttribute_Type(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttribute_Type_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x00095300 File Offset: 0x00093500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425167, XrefRangeEnd = 425171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttribute_Required(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttribute_Required_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x0009535C File Offset: 0x0009355C
		[CallerCount(0)]
		public unsafe static void XDR_BuildAttribute_Default(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttribute_Default_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x000953B8 File Offset: 0x000935B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425171, XrefRangeEnd = 425211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BeginAttribute(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BeginAttribute_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x000953F0 File Offset: 0x000935F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425211, XrefRangeEnd = 425213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_EndAttribute(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_EndAttribute_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x00095428 File Offset: 0x00093628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425213, XrefRangeEnd = 425225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_InitGroup(XdrBuilder builder, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_InitGroup_Private_Static_Void_XdrBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00095470 File Offset: 0x00093670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425225, XrefRangeEnd = 425231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildGroup_Order(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildGroup_Order_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x000954CC File Offset: 0x000936CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425231, XrefRangeEnd = 425235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildGroup_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x00095528 File Offset: 0x00093728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425235, XrefRangeEnd = 425239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildGroup_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x00095584 File Offset: 0x00093784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425239, XrefRangeEnd = 425263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_EndGroup(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_EndGroup_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x000955BC File Offset: 0x000937BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425263, XrefRangeEnd = 425273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_InitElementDtType(XdrBuilder builder, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_InitElementDtType_Private_Static_Void_XdrBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x00095604 File Offset: 0x00093804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425273, XrefRangeEnd = 425282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_EndElementDtType(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_EndElementDtType_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x0009563C File Offset: 0x0009383C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425282, XrefRangeEnd = 425287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_InitAttributeDtType(XdrBuilder builder, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_InitAttributeDtType_Private_Static_Void_XdrBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00095684 File Offset: 0x00093884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425287, XrefRangeEnd = 425298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_EndAttributeDtType(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_EndAttributeDtType_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x000956BC File Offset: 0x000938BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 425306, RefRangeEnd = 425307, XrefRangeStart = 425298, XrefRangeEnd = 425306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNextState(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x0009570C File Offset: 0x0009390C
		[CallerCount(0)]
		public unsafe bool IsSkipableElement(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x0009575C File Offset: 0x0009395C
		[CallerCount(0)]
		public unsafe bool IsSkipableAttribute(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_IsSkipableAttribute_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x000957AC File Offset: 0x000939AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425310, RefRangeEnd = 425312, XrefRangeStart = 425307, XrefRangeEnd = 425310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetOrder(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_GetOrder_Private_Int32_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x000957FC File Offset: 0x000939FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425323, RefRangeEnd = 425325, XrefRangeStart = 425312, XrefRangeEnd = 425323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_AddOrder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00095830 File Offset: 0x00093A30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425334, RefRangeEnd = 425336, XrefRangeStart = 425325, XrefRangeEnd = 425334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsYes(Object obj, XdrBuilder builder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_IsYes_Private_Static_Boolean_Object_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x00095884 File Offset: 0x00093A84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425349, RefRangeEnd = 425351, XrefRangeStart = 425336, XrefRangeEnd = 425349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ParseMinOccurs(Object obj, XdrBuilder builder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ParseMinOccurs_Private_Static_UInt32_Object_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x000958D8 File Offset: 0x00093AD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425366, RefRangeEnd = 425368, XrefRangeStart = 425351, XrefRangeEnd = 425366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ParseMaxOccurs(Object obj, XdrBuilder builder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ParseMaxOccurs_Private_Static_UInt32_Object_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x0009592C File Offset: 0x00093B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425368, XrefRangeEnd = 425371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pContent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_HandleMinMax_Private_Static_Void_ParticleContentValidator_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x00095980 File Offset: 0x00093B80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425387, RefRangeEnd = 425389, XrefRangeStart = 425371, XrefRangeEnd = 425387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseDtMaxLength(ref uint cVal, Object obj, XdrBuilder builder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &cVal;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ParseDtMaxLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x000959D8 File Offset: 0x00093BD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425405, RefRangeEnd = 425407, XrefRangeStart = 425389, XrefRangeEnd = 425405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseDtMinLength(ref uint cVal, Object obj, XdrBuilder builder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &cVal;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ParseDtMinLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00095A30 File Offset: 0x00093C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425407, XrefRangeEnd = 425410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cMin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMax;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_CompareMinMaxLength_Private_Static_Void_UInt32_UInt32_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00095A84 File Offset: 0x00093C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425410, XrefRangeEnd = 425413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseInteger(string str, ref uint n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ParseInteger_Private_Static_Boolean_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x00095AD4 File Offset: 0x00093CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 425419, RefRangeEnd = 425420, XrefRangeStart = 425413, XrefRangeEnd = 425419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void XDR_CheckAttributeDefault(XdrBuilder.DeclBaseInfo decl, SchemaAttDef pAttdef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pAttdef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_CheckAttributeDefault_Private_Void_DeclBaseInfo_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x00095B28 File Offset: 0x00093D28
		[CallerCount(0)]
		public unsafe void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pAttdef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_SetAttributePresence_Private_Void_SchemaAttDef_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x00095B78 File Offset: 0x00093D78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 425423, RefRangeEnd = 425424, XrefRangeStart = 425420, XrefRangeEnd = 425423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetContent(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_GetContent_Private_Int32_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x00095BC8 File Offset: 0x00093DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425424, XrefRangeEnd = 425427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetModel(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_GetModel_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00095C18 File Offset: 0x00093E18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 425439, RefRangeEnd = 425440, XrefRangeStart = 425427, XrefRangeEnd = 425439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaDatatype CheckDatatype(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_CheckDatatype_Private_XmlSchemaDatatype_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x00095C68 File Offset: 0x00093E68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425444, RefRangeEnd = 425446, XrefRangeStart = 425440, XrefRangeEnd = 425444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDefaultAttValue(SchemaAttDef attDef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attDef);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_CheckDefaultAttValue_Private_Void_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00095CAC File Offset: 0x00093EAC
		[CallerCount(0)]
		public unsafe bool IsGlobal(int flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_IsGlobal_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x00095CF8 File Offset: 0x00093EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 425452, RefRangeEnd = 425453, XrefRangeStart = 425446, XrefRangeEnd = 425452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x00095D5C File Offset: 0x00093F5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 425456, RefRangeEnd = 425460, XrefRangeStart = 425453, XrefRangeEnd = 425456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x00095DA0 File Offset: 0x00093FA0
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 425466, RefRangeEnd = 425500, XrefRangeStart = 425460, XrefRangeEnd = 425466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x00095DF4 File Offset: 0x00093FF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425506, RefRangeEnd = 425508, XrefRangeStart = 425500, XrefRangeEnd = 425506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x0000D969 File Offset: 0x0000BB69
		public XdrBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06001F63 RID: 8035 RVA: 0x00095E44 File Offset: 0x00094044
		// (set) Token: 0x06001F64 RID: 8036 RVA: 0x0000D972 File Offset: 0x0000BB72
		public unsafe static Il2CppStructArray<int> S_XDR_Root_Element
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_Element, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_Element, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06001F65 RID: 8037 RVA: 0x00095E6C File Offset: 0x0009406C
		// (set) Token: 0x06001F66 RID: 8038 RVA: 0x0000D984 File Offset: 0x0000BB84
		public unsafe static Il2CppStructArray<int> S_XDR_Root_SubElements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_SubElements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_SubElements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06001F67 RID: 8039 RVA: 0x00095E94 File Offset: 0x00094094
		// (set) Token: 0x06001F68 RID: 8040 RVA: 0x0000D996 File Offset: 0x0000BB96
		public unsafe static Il2CppStructArray<int> S_XDR_ElementType_SubElements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementType_SubElements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementType_SubElements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06001F69 RID: 8041 RVA: 0x00095EBC File Offset: 0x000940BC
		// (set) Token: 0x06001F6A RID: 8042 RVA: 0x0000D9A8 File Offset: 0x0000BBA8
		public unsafe static Il2CppStructArray<int> S_XDR_AttributeType_SubElements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeType_SubElements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeType_SubElements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x00095EE4 File Offset: 0x000940E4
		// (set) Token: 0x06001F6C RID: 8044 RVA: 0x0000D9BA File Offset: 0x0000BBBA
		public unsafe static Il2CppStructArray<int> S_XDR_Group_SubElements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Group_SubElements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Group_SubElements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x00095F0C File Offset: 0x0009410C
		// (set) Token: 0x06001F6E RID: 8046 RVA: 0x0000D9CC File Offset: 0x0000BBCC
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> S_XDR_Root_Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x00095F34 File Offset: 0x00094134
		// (set) Token: 0x06001F70 RID: 8048 RVA: 0x0000D9DE File Offset: 0x0000BBDE
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> S_XDR_ElementType_Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementType_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementType_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x00095F5C File Offset: 0x0009415C
		// (set) Token: 0x06001F72 RID: 8050 RVA: 0x0000D9F0 File Offset: 0x0000BBF0
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> S_XDR_AttributeType_Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeType_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeType_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x00095F84 File Offset: 0x00094184
		// (set) Token: 0x06001F74 RID: 8052 RVA: 0x0000DA02 File Offset: 0x0000BC02
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> S_XDR_Element_Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Element_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Element_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06001F75 RID: 8053 RVA: 0x00095FAC File Offset: 0x000941AC
		// (set) Token: 0x06001F76 RID: 8054 RVA: 0x0000DA14 File Offset: 0x0000BC14
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> S_XDR_Attribute_Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Attribute_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Attribute_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x00095FD4 File Offset: 0x000941D4
		// (set) Token: 0x06001F78 RID: 8056 RVA: 0x0000DA26 File Offset: 0x0000BC26
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> S_XDR_Group_Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Group_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Group_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x00095FFC File Offset: 0x000941FC
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x0000DA38 File Offset: 0x0000BC38
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> S_XDR_ElementDataType_Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementDataType_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementDataType_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x00096024 File Offset: 0x00094224
		// (set) Token: 0x06001F7C RID: 8060 RVA: 0x0000DA4A File Offset: 0x0000BC4A
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> S_XDR_AttributeDataType_Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeDataType_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeDataType_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x0009604C File Offset: 0x0009424C
		// (set) Token: 0x06001F7E RID: 8062 RVA: 0x0000DA5C File Offset: 0x0000BC5C
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrEntry> S_SchemaEntries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_SchemaEntries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_SchemaEntries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x00096074 File Offset: 0x00094274
		// (set) Token: 0x06001F80 RID: 8064 RVA: 0x0000DA6E File Offset: 0x0000BC6E
		public unsafe SchemaInfo _SchemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__SchemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__SchemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x000960A4 File Offset: 0x000942A4
		// (set) Token: 0x06001F82 RID: 8066 RVA: 0x0000DA8D File Offset: 0x0000BC8D
		public unsafe string _TargetNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__TargetNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__TargetNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x000960CC File Offset: 0x000942CC
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x0000DAAC File Offset: 0x0000BCAC
		public unsafe XmlReader _reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x000960FC File Offset: 0x000942FC
		// (set) Token: 0x06001F86 RID: 8070 RVA: 0x0000DACB File Offset: 0x0000BCCB
		public unsafe PositionInfo positionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr_positionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PositionInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr_positionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x0009612C File Offset: 0x0009432C
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x0000DAEA File Offset: 0x0000BCEA
		public unsafe ParticleContentValidator _contentValidator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__contentValidator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleContentValidator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__contentValidator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x0009615C File Offset: 0x0009435C
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x0000DB09 File Offset: 0x0000BD09
		public unsafe XdrBuilder.XdrEntry _CurState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__CurState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.XdrEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__CurState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x0009618C File Offset: 0x0009438C
		// (set) Token: 0x06001F8C RID: 8076 RVA: 0x0000DB28 File Offset: 0x0000BD28
		public unsafe XdrBuilder.XdrEntry _NextState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__NextState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.XdrEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__NextState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x000961BC File Offset: 0x000943BC
		// (set) Token: 0x06001F8E RID: 8078 RVA: 0x0000DB47 File Offset: 0x0000BD47
		public unsafe HWStack _StateHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__StateHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HWStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__StateHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x000961EC File Offset: 0x000943EC
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x0000DB66 File Offset: 0x0000BD66
		public unsafe HWStack _GroupStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__GroupStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HWStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__GroupStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x0009621C File Offset: 0x0009441C
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x0000DB85 File Offset: 0x0000BD85
		public unsafe string _XdrName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__XdrName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__XdrName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x00096244 File Offset: 0x00094444
		// (set) Token: 0x06001F94 RID: 8084 RVA: 0x0000DBA4 File Offset: 0x0000BDA4
		public unsafe string _XdrPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__XdrPrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__XdrPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x0009626C File Offset: 0x0009446C
		// (set) Token: 0x06001F96 RID: 8086 RVA: 0x0000DBC3 File Offset: 0x0000BDC3
		public unsafe XdrBuilder.ElementContent _ElementDef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__ElementDef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.ElementContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__ElementDef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x0009629C File Offset: 0x0009449C
		// (set) Token: 0x06001F98 RID: 8088 RVA: 0x0000DBE2 File Offset: 0x0000BDE2
		public unsafe XdrBuilder.GroupContent _GroupDef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__GroupDef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.GroupContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__GroupDef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x000962CC File Offset: 0x000944CC
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x0000DC01 File Offset: 0x0000BE01
		public unsafe XdrBuilder.AttributeContent _AttributeDef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__AttributeDef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.AttributeContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__AttributeDef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x000962FC File Offset: 0x000944FC
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x0000DC20 File Offset: 0x0000BE20
		public unsafe XdrBuilder.DeclBaseInfo _UndefinedAttributeTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__UndefinedAttributeTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.DeclBaseInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__UndefinedAttributeTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x0009632C File Offset: 0x0009452C
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x0000DC3F File Offset: 0x0000BE3F
		public unsafe XdrBuilder.DeclBaseInfo _BaseDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__BaseDecl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.DeclBaseInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__BaseDecl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x0009635C File Offset: 0x0009455C
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x0000DC5E File Offset: 0x0000BE5E
		public unsafe XmlNameTable _NameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__NameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__NameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x0009638C File Offset: 0x0009458C
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x0000DC7D File Offset: 0x0000BE7D
		public unsafe SchemaNames _SchemaNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__SchemaNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__SchemaNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x000963BC File Offset: 0x000945BC
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x0000DC9C File Offset: 0x0000BE9C
		public unsafe XmlNamespaceManager _CurNsMgr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__CurNsMgr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__CurNsMgr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x000963EC File Offset: 0x000945EC
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x0000DCBB File Offset: 0x0000BEBB
		public unsafe string _Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x00096414 File Offset: 0x00094614
		// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x0000DCDA File Offset: 0x0000BEDA
		public unsafe ValidationEventHandler validationEventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr_validationEventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr_validationEventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x00096444 File Offset: 0x00094644
		// (set) Token: 0x06001FAA RID: 8106 RVA: 0x0000DCF9 File Offset: 0x0000BEF9
		public unsafe Hashtable _UndeclaredElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__UndeclaredElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__UndeclaredElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x00096474 File Offset: 0x00094674
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x0000DD18 File Offset: 0x0000BF18
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_Root_Element;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_Root_SubElements;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_ElementType_SubElements;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_AttributeType_SubElements;

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_Group_SubElements;

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_Root_Attributes;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_ElementType_Attributes;

		// Token: 0x04001712 RID: 5906
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_AttributeType_Attributes;

		// Token: 0x04001713 RID: 5907
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_Element_Attributes;

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_Attribute_Attributes;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_Group_Attributes;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_ElementDataType_Attributes;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_AttributeDataType_Attributes;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeFieldInfoPtr_S_SchemaEntries;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeFieldInfoPtr__SchemaInfo;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeFieldInfoPtr__TargetNamespace;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeFieldInfoPtr__reader;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeFieldInfoPtr_positionInfo;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeFieldInfoPtr__contentValidator;

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeFieldInfoPtr__CurState;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeFieldInfoPtr__NextState;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeFieldInfoPtr__StateHistory;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeFieldInfoPtr__GroupStack;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeFieldInfoPtr__XdrName;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeFieldInfoPtr__XdrPrefix;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeFieldInfoPtr__ElementDef;

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeFieldInfoPtr__GroupDef;

		// Token: 0x04001726 RID: 5926
		private static readonly IntPtr NativeFieldInfoPtr__AttributeDef;

		// Token: 0x04001727 RID: 5927
		private static readonly IntPtr NativeFieldInfoPtr__UndefinedAttributeTypes;

		// Token: 0x04001728 RID: 5928
		private static readonly IntPtr NativeFieldInfoPtr__BaseDecl;

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeFieldInfoPtr__NameTable;

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeFieldInfoPtr__SchemaNames;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeFieldInfoPtr__CurNsMgr;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeFieldInfoPtr__Text;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeFieldInfoPtr_validationEventHandler;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeFieldInfoPtr__UndeclaredElements;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_SchemaInfo_String_XmlNameTable_SchemaNames_ValidationEventHandler_0;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0;

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeMethodInfoPtr_LoadSchema_Private_Boolean_String_0;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeMethodInfoPtr_IsXdrSchema_Internal_Static_Boolean_String_0;

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0;

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0;

		// Token: 0x04001738 RID: 5944
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0;

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_0;

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_Void_0;

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeMethodInfoPtr_PushGroupInfo_Private_Void_0;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeMethodInfoPtr_PopGroupInfo_Private_Void_0;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeMethodInfoPtr_XDR_InitRoot_Private_Static_Void_XdrBuilder_Object_0;

		// Token: 0x04001740 RID: 5952
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildRoot_Name_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001741 RID: 5953
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildRoot_ID_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001742 RID: 5954
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BeginRoot_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001743 RID: 5955
		private static readonly IntPtr NativeMethodInfoPtr_XDR_EndRoot_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001744 RID: 5956
		private static readonly IntPtr NativeMethodInfoPtr_XDR_InitElementType_Private_Static_Void_XdrBuilder_Object_0;

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElementType_Name_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElementType_Content_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElementType_Model_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElementType_Order_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElementType_DtType_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElementType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElementType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElementType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x0400174D RID: 5965
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BeginElementType_Private_Static_Void_XdrBuilder_0;

		// Token: 0x0400174E RID: 5966
		private static readonly IntPtr NativeMethodInfoPtr_XDR_EndElementType_Private_Static_Void_XdrBuilder_0;

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeMethodInfoPtr_XDR_InitAttributeType_Private_Static_Void_XdrBuilder_Object_0;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_Name_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_Required_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_Default_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_DtType_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001754 RID: 5972
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001755 RID: 5973
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BeginAttributeType_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeMethodInfoPtr_XDR_EndAttributeType_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeMethodInfoPtr_XDR_InitElement_Private_Static_Void_XdrBuilder_Object_0;

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElement_Type_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElement_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x0400175C RID: 5980
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElement_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x0400175D RID: 5981
		private static readonly IntPtr NativeMethodInfoPtr_XDR_EndElement_Private_Static_Void_XdrBuilder_0;

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeMethodInfoPtr_XDR_InitAttribute_Private_Static_Void_XdrBuilder_Object_0;

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttribute_Type_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttribute_Required_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttribute_Default_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BeginAttribute_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001763 RID: 5987
		private static readonly IntPtr NativeMethodInfoPtr_XDR_EndAttribute_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeMethodInfoPtr_XDR_InitGroup_Private_Static_Void_XdrBuilder_Object_0;

		// Token: 0x04001765 RID: 5989
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildGroup_Order_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildGroup_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildGroup_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeMethodInfoPtr_XDR_EndGroup_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeMethodInfoPtr_XDR_InitElementDtType_Private_Static_Void_XdrBuilder_Object_0;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeMethodInfoPtr_XDR_EndElementDtType_Private_Static_Void_XdrBuilder_0;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeMethodInfoPtr_XDR_InitAttributeDtType_Private_Static_Void_XdrBuilder_Object_0;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeMethodInfoPtr_XDR_EndAttributeDtType_Private_Static_Void_XdrBuilder_0;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0;

		// Token: 0x0400176E RID: 5998
		private static readonly IntPtr NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0;

		// Token: 0x0400176F RID: 5999
		private static readonly IntPtr NativeMethodInfoPtr_IsSkipableAttribute_Private_Boolean_XmlQualifiedName_0;

		// Token: 0x04001770 RID: 6000
		private static readonly IntPtr NativeMethodInfoPtr_GetOrder_Private_Int32_XmlQualifiedName_0;

		// Token: 0x04001771 RID: 6001
		private static readonly IntPtr NativeMethodInfoPtr_AddOrder_Private_Void_0;

		// Token: 0x04001772 RID: 6002
		private static readonly IntPtr NativeMethodInfoPtr_IsYes_Private_Static_Boolean_Object_XdrBuilder_0;

		// Token: 0x04001773 RID: 6003
		private static readonly IntPtr NativeMethodInfoPtr_ParseMinOccurs_Private_Static_UInt32_Object_XdrBuilder_0;

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeMethodInfoPtr_ParseMaxOccurs_Private_Static_UInt32_Object_XdrBuilder_0;

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeMethodInfoPtr_HandleMinMax_Private_Static_Void_ParticleContentValidator_UInt32_UInt32_0;

		// Token: 0x04001776 RID: 6006
		private static readonly IntPtr NativeMethodInfoPtr_ParseDtMaxLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0;

		// Token: 0x04001777 RID: 6007
		private static readonly IntPtr NativeMethodInfoPtr_ParseDtMinLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0;

		// Token: 0x04001778 RID: 6008
		private static readonly IntPtr NativeMethodInfoPtr_CompareMinMaxLength_Private_Static_Void_UInt32_UInt32_XdrBuilder_0;

		// Token: 0x04001779 RID: 6009
		private static readonly IntPtr NativeMethodInfoPtr_ParseInteger_Private_Static_Boolean_String_byref_UInt32_0;

		// Token: 0x0400177A RID: 6010
		private static readonly IntPtr NativeMethodInfoPtr_XDR_CheckAttributeDefault_Private_Void_DeclBaseInfo_SchemaAttDef_0;

		// Token: 0x0400177B RID: 6011
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributePresence_Private_Void_SchemaAttDef_Boolean_0;

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeMethodInfoPtr_GetContent_Private_Int32_XmlQualifiedName_0;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeMethodInfoPtr_GetModel_Private_Boolean_XmlQualifiedName_0;

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeMethodInfoPtr_CheckDatatype_Private_XmlSchemaDatatype_String_0;

		// Token: 0x0400177F RID: 6015
		private static readonly IntPtr NativeMethodInfoPtr_CheckDefaultAttValue_Private_Void_SchemaAttDef_0;

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeMethodInfoPtr_IsGlobal_Private_Boolean_Int32_0;

		// Token: 0x04001781 RID: 6017
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0;

		// Token: 0x04001782 RID: 6018
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_0;

		// Token: 0x04001783 RID: 6019
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0;

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0;

		// Token: 0x02000238 RID: 568
		public sealed class DeclBaseInfo : Object
		{
			// Token: 0x06002C90 RID: 11408 RVA: 0x000C71F0 File Offset: 0x000C53F0
			// Note: this type is marked as 'beforefieldinit'.
			static DeclBaseInfo()
			{
				Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "DeclBaseInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr);
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_Name");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_Prefix");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__TypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_TypeName");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__TypePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_TypePrefix");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_Default");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Revises = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_Revises");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__MaxOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_MaxOccurs");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__MinOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_MinOccurs");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Checking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_Checking");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__ElementDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_ElementDecl");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Attdef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_Attdef");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_Next");
				XdrBuilder.DeclBaseInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, 100667800);
				XdrBuilder.DeclBaseInfo.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, 100667801);
			}

			// Token: 0x06002C91 RID: 11409 RVA: 0x000C7334 File Offset: 0x000C5534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424709, XrefRangeEnd = 424710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeclBaseInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.DeclBaseInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C92 RID: 11410 RVA: 0x000C7370 File Offset: 0x000C5570
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 424715, RefRangeEnd = 424719, XrefRangeStart = 424710, XrefRangeEnd = 424715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.DeclBaseInfo.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C93 RID: 11411 RVA: 0x00013237 File Offset: 0x00011437
			public DeclBaseInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F2C RID: 3884
			// (get) Token: 0x06002C94 RID: 11412 RVA: 0x000C73A4 File Offset: 0x000C55A4
			// (set) Token: 0x06002C95 RID: 11413 RVA: 0x00013240 File Offset: 0x00011440
			public unsafe XmlQualifiedName _Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Name);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Name), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F2D RID: 3885
			// (get) Token: 0x06002C96 RID: 11414 RVA: 0x000C73D4 File Offset: 0x000C55D4
			// (set) Token: 0x06002C97 RID: 11415 RVA: 0x0001325F File Offset: 0x0001145F
			public unsafe string _Prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000F2E RID: 3886
			// (get) Token: 0x06002C98 RID: 11416 RVA: 0x000C73FC File Offset: 0x000C55FC
			// (set) Token: 0x06002C99 RID: 11417 RVA: 0x0001327E File Offset: 0x0001147E
			public unsafe XmlQualifiedName _TypeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__TypeName);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__TypeName), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F2F RID: 3887
			// (get) Token: 0x06002C9A RID: 11418 RVA: 0x000C742C File Offset: 0x000C562C
			// (set) Token: 0x06002C9B RID: 11419 RVA: 0x0001329D File Offset: 0x0001149D
			public unsafe string _TypePrefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__TypePrefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__TypePrefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000F30 RID: 3888
			// (get) Token: 0x06002C9C RID: 11420 RVA: 0x000C7454 File Offset: 0x000C5654
			// (set) Token: 0x06002C9D RID: 11421 RVA: 0x000132BC File Offset: 0x000114BC
			public unsafe Object _Default
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Default);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Default), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F31 RID: 3889
			// (get) Token: 0x06002C9E RID: 11422 RVA: 0x000C7484 File Offset: 0x000C5684
			// (set) Token: 0x06002C9F RID: 11423 RVA: 0x000132DB File Offset: 0x000114DB
			public unsafe Object _Revises
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Revises);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Revises), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F32 RID: 3890
			// (get) Token: 0x06002CA0 RID: 11424 RVA: 0x000C74B4 File Offset: 0x000C56B4
			// (set) Token: 0x06002CA1 RID: 11425 RVA: 0x000132FA File Offset: 0x000114FA
			public unsafe uint _MaxOccurs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__MaxOccurs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__MaxOccurs)) = value;
				}
			}

			// Token: 0x17000F33 RID: 3891
			// (get) Token: 0x06002CA2 RID: 11426 RVA: 0x000C74DC File Offset: 0x000C56DC
			// (set) Token: 0x06002CA3 RID: 11427 RVA: 0x00013315 File Offset: 0x00011515
			public unsafe uint _MinOccurs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__MinOccurs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__MinOccurs)) = value;
				}
			}

			// Token: 0x17000F34 RID: 3892
			// (get) Token: 0x06002CA4 RID: 11428 RVA: 0x000C7504 File Offset: 0x000C5704
			// (set) Token: 0x06002CA5 RID: 11429 RVA: 0x00013330 File Offset: 0x00011530
			public unsafe bool _Checking
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Checking);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Checking)) = value;
				}
			}

			// Token: 0x17000F35 RID: 3893
			// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x000C752C File Offset: 0x000C572C
			// (set) Token: 0x06002CA7 RID: 11431 RVA: 0x0001334B File Offset: 0x0001154B
			public unsafe SchemaElementDecl _ElementDecl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__ElementDecl);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__ElementDecl), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F36 RID: 3894
			// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x000C755C File Offset: 0x000C575C
			// (set) Token: 0x06002CA9 RID: 11433 RVA: 0x0001336A File Offset: 0x0001156A
			public unsafe SchemaAttDef _Attdef
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Attdef);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Attdef), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F37 RID: 3895
			// (get) Token: 0x06002CAA RID: 11434 RVA: 0x000C758C File Offset: 0x000C578C
			// (set) Token: 0x06002CAB RID: 11435 RVA: 0x00013389 File Offset: 0x00011589
			public unsafe XdrBuilder.DeclBaseInfo _Next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.DeclBaseInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002343 RID: 9027
			private static readonly IntPtr NativeFieldInfoPtr__Name;

			// Token: 0x04002344 RID: 9028
			private static readonly IntPtr NativeFieldInfoPtr__Prefix;

			// Token: 0x04002345 RID: 9029
			private static readonly IntPtr NativeFieldInfoPtr__TypeName;

			// Token: 0x04002346 RID: 9030
			private static readonly IntPtr NativeFieldInfoPtr__TypePrefix;

			// Token: 0x04002347 RID: 9031
			private static readonly IntPtr NativeFieldInfoPtr__Default;

			// Token: 0x04002348 RID: 9032
			private static readonly IntPtr NativeFieldInfoPtr__Revises;

			// Token: 0x04002349 RID: 9033
			private static readonly IntPtr NativeFieldInfoPtr__MaxOccurs;

			// Token: 0x0400234A RID: 9034
			private static readonly IntPtr NativeFieldInfoPtr__MinOccurs;

			// Token: 0x0400234B RID: 9035
			private static readonly IntPtr NativeFieldInfoPtr__Checking;

			// Token: 0x0400234C RID: 9036
			private static readonly IntPtr NativeFieldInfoPtr__ElementDecl;

			// Token: 0x0400234D RID: 9037
			private static readonly IntPtr NativeFieldInfoPtr__Attdef;

			// Token: 0x0400234E RID: 9038
			private static readonly IntPtr NativeFieldInfoPtr__Next;

			// Token: 0x0400234F RID: 9039
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04002350 RID: 9040
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;
		}

		// Token: 0x02000239 RID: 569
		public sealed class GroupContent : Object
		{
			// Token: 0x06002CAC RID: 11436 RVA: 0x000C75BC File Offset: 0x000C57BC
			// Note: this type is marked as 'beforefieldinit'.
			static GroupContent()
			{
				Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "GroupContent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr);
				XdrBuilder.GroupContent.NativeFieldInfoPtr__MinVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr, "_MinVal");
				XdrBuilder.GroupContent.NativeFieldInfoPtr__MaxVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr, "_MaxVal");
				XdrBuilder.GroupContent.NativeFieldInfoPtr__HasMaxAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr, "_HasMaxAttr");
				XdrBuilder.GroupContent.NativeFieldInfoPtr__HasMinAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr, "_HasMinAttr");
				XdrBuilder.GroupContent.NativeFieldInfoPtr__Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr, "_Order");
				XdrBuilder.GroupContent.NativeMethodInfoPtr_Copy_Internal_Static_Void_GroupContent_GroupContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr, 100667802);
				XdrBuilder.GroupContent.NativeMethodInfoPtr_Copy_Internal_Static_GroupContent_GroupContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr, 100667803);
				XdrBuilder.GroupContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr, 100667804);
			}

			// Token: 0x06002CAD RID: 11437 RVA: 0x000C7688 File Offset: 0x000C5888
			[CallerCount(0)]
			public unsafe static void Copy(XdrBuilder.GroupContent from, XdrBuilder.GroupContent to)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.GroupContent.NativeMethodInfoPtr_Copy_Internal_Static_Void_GroupContent_GroupContent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CAE RID: 11438 RVA: 0x000C76D0 File Offset: 0x000C58D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424719, XrefRangeEnd = 424722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static XdrBuilder.GroupContent Copy(XdrBuilder.GroupContent other)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.GroupContent.NativeMethodInfoPtr_Copy_Internal_Static_GroupContent_GroupContent_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XdrBuilder.GroupContent>(intPtr3) : null;
				}
			}

			// Token: 0x06002CAF RID: 11439 RVA: 0x000C7714 File Offset: 0x000C5914
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GroupContent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.GroupContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CB0 RID: 11440 RVA: 0x000133A8 File Offset: 0x000115A8
			public GroupContent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F38 RID: 3896
			// (get) Token: 0x06002CB1 RID: 11441 RVA: 0x000C7750 File Offset: 0x000C5950
			// (set) Token: 0x06002CB2 RID: 11442 RVA: 0x000133B1 File Offset: 0x000115B1
			public unsafe uint _MinVal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__MinVal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__MinVal)) = value;
				}
			}

			// Token: 0x17000F39 RID: 3897
			// (get) Token: 0x06002CB3 RID: 11443 RVA: 0x000C7778 File Offset: 0x000C5978
			// (set) Token: 0x06002CB4 RID: 11444 RVA: 0x000133CC File Offset: 0x000115CC
			public unsafe uint _MaxVal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__MaxVal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__MaxVal)) = value;
				}
			}

			// Token: 0x17000F3A RID: 3898
			// (get) Token: 0x06002CB5 RID: 11445 RVA: 0x000C77A0 File Offset: 0x000C59A0
			// (set) Token: 0x06002CB6 RID: 11446 RVA: 0x000133E7 File Offset: 0x000115E7
			public unsafe bool _HasMaxAttr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__HasMaxAttr);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__HasMaxAttr)) = value;
				}
			}

			// Token: 0x17000F3B RID: 3899
			// (get) Token: 0x06002CB7 RID: 11447 RVA: 0x000C77C8 File Offset: 0x000C59C8
			// (set) Token: 0x06002CB8 RID: 11448 RVA: 0x00013402 File Offset: 0x00011602
			public unsafe bool _HasMinAttr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__HasMinAttr);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__HasMinAttr)) = value;
				}
			}

			// Token: 0x17000F3C RID: 3900
			// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x000C77F0 File Offset: 0x000C59F0
			// (set) Token: 0x06002CBA RID: 11450 RVA: 0x0001341D File Offset: 0x0001161D
			public unsafe int _Order
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__Order);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__Order)) = value;
				}
			}

			// Token: 0x04002351 RID: 9041
			private static readonly IntPtr NativeFieldInfoPtr__MinVal;

			// Token: 0x04002352 RID: 9042
			private static readonly IntPtr NativeFieldInfoPtr__MaxVal;

			// Token: 0x04002353 RID: 9043
			private static readonly IntPtr NativeFieldInfoPtr__HasMaxAttr;

			// Token: 0x04002354 RID: 9044
			private static readonly IntPtr NativeFieldInfoPtr__HasMinAttr;

			// Token: 0x04002355 RID: 9045
			private static readonly IntPtr NativeFieldInfoPtr__Order;

			// Token: 0x04002356 RID: 9046
			private static readonly IntPtr NativeMethodInfoPtr_Copy_Internal_Static_Void_GroupContent_GroupContent_0;

			// Token: 0x04002357 RID: 9047
			private static readonly IntPtr NativeMethodInfoPtr_Copy_Internal_Static_GroupContent_GroupContent_0;

			// Token: 0x04002358 RID: 9048
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200023A RID: 570
		public sealed class ElementContent : Object
		{
			// Token: 0x06002CBB RID: 11451 RVA: 0x000C7818 File Offset: 0x000C5A18
			// Note: this type is marked as 'beforefieldinit'.
			static ElementContent()
			{
				Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "ElementContent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr);
				XdrBuilder.ElementContent.NativeFieldInfoPtr__ElementDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_ElementDecl");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__ContentAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_ContentAttr");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__OrderAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_OrderAttr");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__MasterGroupRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_MasterGroupRequired");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__ExistTerminal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_ExistTerminal");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__AllowDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_AllowDataType");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__HasDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_HasDataType");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__HasType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_HasType");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__EnumerationRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_EnumerationRequired");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__MinVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_MinVal");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__MaxVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_MaxVal");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__MaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_MaxLength");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__MinLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_MinLength");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__AttDefList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_AttDefList");
				XdrBuilder.ElementContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, 100667805);
			}

			// Token: 0x06002CBC RID: 11452 RVA: 0x000C7970 File Offset: 0x000C5B70
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ElementContent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.ElementContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CBD RID: 11453 RVA: 0x00013438 File Offset: 0x00011638
			public ElementContent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F3D RID: 3901
			// (get) Token: 0x06002CBE RID: 11454 RVA: 0x000C79AC File Offset: 0x000C5BAC
			// (set) Token: 0x06002CBF RID: 11455 RVA: 0x00013441 File Offset: 0x00011641
			public unsafe SchemaElementDecl _ElementDecl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__ElementDecl);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__ElementDecl), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F3E RID: 3902
			// (get) Token: 0x06002CC0 RID: 11456 RVA: 0x000C79DC File Offset: 0x000C5BDC
			// (set) Token: 0x06002CC1 RID: 11457 RVA: 0x00013460 File Offset: 0x00011660
			public unsafe int _ContentAttr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__ContentAttr);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__ContentAttr)) = value;
				}
			}

			// Token: 0x17000F3F RID: 3903
			// (get) Token: 0x06002CC2 RID: 11458 RVA: 0x000C7A04 File Offset: 0x000C5C04
			// (set) Token: 0x06002CC3 RID: 11459 RVA: 0x0001347B File Offset: 0x0001167B
			public unsafe int _OrderAttr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__OrderAttr);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__OrderAttr)) = value;
				}
			}

			// Token: 0x17000F40 RID: 3904
			// (get) Token: 0x06002CC4 RID: 11460 RVA: 0x000C7A2C File Offset: 0x000C5C2C
			// (set) Token: 0x06002CC5 RID: 11461 RVA: 0x00013496 File Offset: 0x00011696
			public unsafe bool _MasterGroupRequired
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MasterGroupRequired);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MasterGroupRequired)) = value;
				}
			}

			// Token: 0x17000F41 RID: 3905
			// (get) Token: 0x06002CC6 RID: 11462 RVA: 0x000C7A54 File Offset: 0x000C5C54
			// (set) Token: 0x06002CC7 RID: 11463 RVA: 0x000134B1 File Offset: 0x000116B1
			public unsafe bool _ExistTerminal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__ExistTerminal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__ExistTerminal)) = value;
				}
			}

			// Token: 0x17000F42 RID: 3906
			// (get) Token: 0x06002CC8 RID: 11464 RVA: 0x000C7A7C File Offset: 0x000C5C7C
			// (set) Token: 0x06002CC9 RID: 11465 RVA: 0x000134CC File Offset: 0x000116CC
			public unsafe bool _AllowDataType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__AllowDataType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__AllowDataType)) = value;
				}
			}

			// Token: 0x17000F43 RID: 3907
			// (get) Token: 0x06002CCA RID: 11466 RVA: 0x000C7AA4 File Offset: 0x000C5CA4
			// (set) Token: 0x06002CCB RID: 11467 RVA: 0x000134E7 File Offset: 0x000116E7
			public unsafe bool _HasDataType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__HasDataType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__HasDataType)) = value;
				}
			}

			// Token: 0x17000F44 RID: 3908
			// (get) Token: 0x06002CCC RID: 11468 RVA: 0x000C7ACC File Offset: 0x000C5CCC
			// (set) Token: 0x06002CCD RID: 11469 RVA: 0x00013502 File Offset: 0x00011702
			public unsafe bool _HasType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__HasType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__HasType)) = value;
				}
			}

			// Token: 0x17000F45 RID: 3909
			// (get) Token: 0x06002CCE RID: 11470 RVA: 0x000C7AF4 File Offset: 0x000C5CF4
			// (set) Token: 0x06002CCF RID: 11471 RVA: 0x0001351D File Offset: 0x0001171D
			public unsafe bool _EnumerationRequired
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__EnumerationRequired);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__EnumerationRequired)) = value;
				}
			}

			// Token: 0x17000F46 RID: 3910
			// (get) Token: 0x06002CD0 RID: 11472 RVA: 0x000C7B1C File Offset: 0x000C5D1C
			// (set) Token: 0x06002CD1 RID: 11473 RVA: 0x00013538 File Offset: 0x00011738
			public unsafe uint _MinVal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MinVal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MinVal)) = value;
				}
			}

			// Token: 0x17000F47 RID: 3911
			// (get) Token: 0x06002CD2 RID: 11474 RVA: 0x000C7B44 File Offset: 0x000C5D44
			// (set) Token: 0x06002CD3 RID: 11475 RVA: 0x00013553 File Offset: 0x00011753
			public unsafe uint _MaxVal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MaxVal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MaxVal)) = value;
				}
			}

			// Token: 0x17000F48 RID: 3912
			// (get) Token: 0x06002CD4 RID: 11476 RVA: 0x000C7B6C File Offset: 0x000C5D6C
			// (set) Token: 0x06002CD5 RID: 11477 RVA: 0x0001356E File Offset: 0x0001176E
			public unsafe uint _MaxLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MaxLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MaxLength)) = value;
				}
			}

			// Token: 0x17000F49 RID: 3913
			// (get) Token: 0x06002CD6 RID: 11478 RVA: 0x000C7B94 File Offset: 0x000C5D94
			// (set) Token: 0x06002CD7 RID: 11479 RVA: 0x00013589 File Offset: 0x00011789
			public unsafe uint _MinLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MinLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MinLength)) = value;
				}
			}

			// Token: 0x17000F4A RID: 3914
			// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x000C7BBC File Offset: 0x000C5DBC
			// (set) Token: 0x06002CD9 RID: 11481 RVA: 0x000135A4 File Offset: 0x000117A4
			public unsafe Hashtable _AttDefList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__AttDefList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__AttDefList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002359 RID: 9049
			private static readonly IntPtr NativeFieldInfoPtr__ElementDecl;

			// Token: 0x0400235A RID: 9050
			private static readonly IntPtr NativeFieldInfoPtr__ContentAttr;

			// Token: 0x0400235B RID: 9051
			private static readonly IntPtr NativeFieldInfoPtr__OrderAttr;

			// Token: 0x0400235C RID: 9052
			private static readonly IntPtr NativeFieldInfoPtr__MasterGroupRequired;

			// Token: 0x0400235D RID: 9053
			private static readonly IntPtr NativeFieldInfoPtr__ExistTerminal;

			// Token: 0x0400235E RID: 9054
			private static readonly IntPtr NativeFieldInfoPtr__AllowDataType;

			// Token: 0x0400235F RID: 9055
			private static readonly IntPtr NativeFieldInfoPtr__HasDataType;

			// Token: 0x04002360 RID: 9056
			private static readonly IntPtr NativeFieldInfoPtr__HasType;

			// Token: 0x04002361 RID: 9057
			private static readonly IntPtr NativeFieldInfoPtr__EnumerationRequired;

			// Token: 0x04002362 RID: 9058
			private static readonly IntPtr NativeFieldInfoPtr__MinVal;

			// Token: 0x04002363 RID: 9059
			private static readonly IntPtr NativeFieldInfoPtr__MaxVal;

			// Token: 0x04002364 RID: 9060
			private static readonly IntPtr NativeFieldInfoPtr__MaxLength;

			// Token: 0x04002365 RID: 9061
			private static readonly IntPtr NativeFieldInfoPtr__MinLength;

			// Token: 0x04002366 RID: 9062
			private static readonly IntPtr NativeFieldInfoPtr__AttDefList;

			// Token: 0x04002367 RID: 9063
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200023B RID: 571
		public sealed class AttributeContent : Object
		{
			// Token: 0x06002CDA RID: 11482 RVA: 0x000C7BEC File Offset: 0x000C5DEC
			// Note: this type is marked as 'beforefieldinit'.
			static AttributeContent()
			{
				Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "AttributeContent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr);
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__AttDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_AttDef");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_Name");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__Prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_Prefix");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__Required = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_Required");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__MinVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_MinVal");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__MaxVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_MaxVal");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__MaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_MaxLength");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__MinLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_MinLength");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__EnumerationRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_EnumerationRequired");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__HasDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_HasDataType");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__Global = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_Global");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_Default");
				XdrBuilder.AttributeContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, 100667806);
			}

			// Token: 0x06002CDB RID: 11483 RVA: 0x000C7D1C File Offset: 0x000C5F1C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttributeContent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.AttributeContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CDC RID: 11484 RVA: 0x000135C3 File Offset: 0x000117C3
			public AttributeContent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F4B RID: 3915
			// (get) Token: 0x06002CDD RID: 11485 RVA: 0x000C7D58 File Offset: 0x000C5F58
			// (set) Token: 0x06002CDE RID: 11486 RVA: 0x000135CC File Offset: 0x000117CC
			public unsafe SchemaAttDef _AttDef
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__AttDef);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__AttDef), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F4C RID: 3916
			// (get) Token: 0x06002CDF RID: 11487 RVA: 0x000C7D88 File Offset: 0x000C5F88
			// (set) Token: 0x06002CE0 RID: 11488 RVA: 0x000135EB File Offset: 0x000117EB
			public unsafe XmlQualifiedName _Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Name);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Name), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F4D RID: 3917
			// (get) Token: 0x06002CE1 RID: 11489 RVA: 0x000C7DB8 File Offset: 0x000C5FB8
			// (set) Token: 0x06002CE2 RID: 11490 RVA: 0x0001360A File Offset: 0x0001180A
			public unsafe string _Prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000F4E RID: 3918
			// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x000C7DE0 File Offset: 0x000C5FE0
			// (set) Token: 0x06002CE4 RID: 11492 RVA: 0x00013629 File Offset: 0x00011829
			public unsafe bool _Required
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Required);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Required)) = value;
				}
			}

			// Token: 0x17000F4F RID: 3919
			// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x000C7E08 File Offset: 0x000C6008
			// (set) Token: 0x06002CE6 RID: 11494 RVA: 0x00013644 File Offset: 0x00011844
			public unsafe uint _MinVal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__MinVal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__MinVal)) = value;
				}
			}

			// Token: 0x17000F50 RID: 3920
			// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x000C7E30 File Offset: 0x000C6030
			// (set) Token: 0x06002CE8 RID: 11496 RVA: 0x0001365F File Offset: 0x0001185F
			public unsafe uint _MaxVal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__MaxVal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__MaxVal)) = value;
				}
			}

			// Token: 0x17000F51 RID: 3921
			// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x000C7E58 File Offset: 0x000C6058
			// (set) Token: 0x06002CEA RID: 11498 RVA: 0x0001367A File Offset: 0x0001187A
			public unsafe uint _MaxLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__MaxLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__MaxLength)) = value;
				}
			}

			// Token: 0x17000F52 RID: 3922
			// (get) Token: 0x06002CEB RID: 11499 RVA: 0x000C7E80 File Offset: 0x000C6080
			// (set) Token: 0x06002CEC RID: 11500 RVA: 0x00013695 File Offset: 0x00011895
			public unsafe uint _MinLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__MinLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__MinLength)) = value;
				}
			}

			// Token: 0x17000F53 RID: 3923
			// (get) Token: 0x06002CED RID: 11501 RVA: 0x000C7EA8 File Offset: 0x000C60A8
			// (set) Token: 0x06002CEE RID: 11502 RVA: 0x000136B0 File Offset: 0x000118B0
			public unsafe bool _EnumerationRequired
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__EnumerationRequired);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__EnumerationRequired)) = value;
				}
			}

			// Token: 0x17000F54 RID: 3924
			// (get) Token: 0x06002CEF RID: 11503 RVA: 0x000C7ED0 File Offset: 0x000C60D0
			// (set) Token: 0x06002CF0 RID: 11504 RVA: 0x000136CB File Offset: 0x000118CB
			public unsafe bool _HasDataType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__HasDataType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__HasDataType)) = value;
				}
			}

			// Token: 0x17000F55 RID: 3925
			// (get) Token: 0x06002CF1 RID: 11505 RVA: 0x000C7EF8 File Offset: 0x000C60F8
			// (set) Token: 0x06002CF2 RID: 11506 RVA: 0x000136E6 File Offset: 0x000118E6
			public unsafe bool _Global
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Global);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Global)) = value;
				}
			}

			// Token: 0x17000F56 RID: 3926
			// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x000C7F20 File Offset: 0x000C6120
			// (set) Token: 0x06002CF4 RID: 11508 RVA: 0x00013701 File Offset: 0x00011901
			public unsafe Object _Default
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Default);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Default), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002368 RID: 9064
			private static readonly IntPtr NativeFieldInfoPtr__AttDef;

			// Token: 0x04002369 RID: 9065
			private static readonly IntPtr NativeFieldInfoPtr__Name;

			// Token: 0x0400236A RID: 9066
			private static readonly IntPtr NativeFieldInfoPtr__Prefix;

			// Token: 0x0400236B RID: 9067
			private static readonly IntPtr NativeFieldInfoPtr__Required;

			// Token: 0x0400236C RID: 9068
			private static readonly IntPtr NativeFieldInfoPtr__MinVal;

			// Token: 0x0400236D RID: 9069
			private static readonly IntPtr NativeFieldInfoPtr__MaxVal;

			// Token: 0x0400236E RID: 9070
			private static readonly IntPtr NativeFieldInfoPtr__MaxLength;

			// Token: 0x0400236F RID: 9071
			private static readonly IntPtr NativeFieldInfoPtr__MinLength;

			// Token: 0x04002370 RID: 9072
			private static readonly IntPtr NativeFieldInfoPtr__EnumerationRequired;

			// Token: 0x04002371 RID: 9073
			private static readonly IntPtr NativeFieldInfoPtr__HasDataType;

			// Token: 0x04002372 RID: 9074
			private static readonly IntPtr NativeFieldInfoPtr__Global;

			// Token: 0x04002373 RID: 9075
			private static readonly IntPtr NativeFieldInfoPtr__Default;

			// Token: 0x04002374 RID: 9076
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200023C RID: 572
		public sealed class XdrBuildFunction : MulticastDelegate
		{
			// Token: 0x06002CF5 RID: 11509 RVA: 0x000C7F50 File Offset: 0x000C6150
			// Note: this type is marked as 'beforefieldinit'.
			static XdrBuildFunction()
			{
				Il2CppClassPointerStore<XdrBuilder.XdrBuildFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrBuildFunction");
				XdrBuilder.XdrBuildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrBuildFunction>.NativeClassPtr, 100667807);
				XdrBuilder.XdrBuildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrBuildFunction>.NativeClassPtr, 100667808);
				XdrBuilder.XdrBuildFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XdrBuilder_Object_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrBuildFunction>.NativeClassPtr, 100667809);
				XdrBuilder.XdrBuildFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrBuildFunction>.NativeClassPtr, 100667810);
			}

			// Token: 0x06002CF6 RID: 11510 RVA: 0x000C7FC4 File Offset: 0x000C61C4
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XdrBuildFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.XdrBuildFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrBuildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CF7 RID: 11511 RVA: 0x000C8020 File Offset: 0x000C6220
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 424722, RefRangeEnd = 424723, XrefRangeStart = 424722, XrefRangeEnd = 424722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(XdrBuilder builder, Object obj, string prefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrBuildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CF8 RID: 11512 RVA: 0x000C8088 File Offset: 0x000C6288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424723, XrefRangeEnd = 424724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(XdrBuilder builder, Object obj, string prefix, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrBuildFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XdrBuilder_Object_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002CF9 RID: 11513 RVA: 0x000C8124 File Offset: 0x000C6324
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrBuildFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002CFA RID: 11514 RVA: 0x00013720 File Offset: 0x00011920
			public XdrBuildFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002CFB RID: 11515 RVA: 0x00013729 File Offset: 0x00011929
			public static implicit operator XdrBuilder.XdrBuildFunction(Action<XdrBuilder, Object, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<XdrBuilder.XdrBuildFunction>(A_0);
			}

			// Token: 0x06002CFC RID: 11516 RVA: 0x00013731 File Offset: 0x00011931
			public static XdrBuilder.XdrBuildFunction operator +(XdrBuilder.XdrBuildFunction A_0, XdrBuilder.XdrBuildFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XdrBuilder.XdrBuildFunction>();
			}

			// Token: 0x06002CFD RID: 11517 RVA: 0x0001373F File Offset: 0x0001193F
			public static XdrBuilder.XdrBuildFunction operator -(XdrBuilder.XdrBuildFunction A_0, XdrBuilder.XdrBuildFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XdrBuilder.XdrBuildFunction>();
				}
				return delegate2;
			}

			// Token: 0x04002375 RID: 9077
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002376 RID: 9078
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_String_0;

			// Token: 0x04002377 RID: 9079
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XdrBuilder_Object_String_AsyncCallback_Object_0;

			// Token: 0x04002378 RID: 9080
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200023D RID: 573
		public sealed class XdrInitFunction : MulticastDelegate
		{
			// Token: 0x06002CFE RID: 11518 RVA: 0x000C8168 File Offset: 0x000C6368
			// Note: this type is marked as 'beforefieldinit'.
			static XdrInitFunction()
			{
				Il2CppClassPointerStore<XdrBuilder.XdrInitFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrInitFunction");
				XdrBuilder.XdrInitFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrInitFunction>.NativeClassPtr, 100667811);
				XdrBuilder.XdrInitFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrInitFunction>.NativeClassPtr, 100667812);
				XdrBuilder.XdrInitFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XdrBuilder_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrInitFunction>.NativeClassPtr, 100667813);
				XdrBuilder.XdrInitFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrInitFunction>.NativeClassPtr, 100667814);
			}

			// Token: 0x06002CFF RID: 11519 RVA: 0x000C81DC File Offset: 0x000C63DC
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XdrInitFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.XdrInitFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrInitFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D00 RID: 11520 RVA: 0x000C8238 File Offset: 0x000C6438
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 107679, RefRangeEnd = 107686, XrefRangeStart = 107679, XrefRangeEnd = 107686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(XdrBuilder builder, Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrInitFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D01 RID: 11521 RVA: 0x000C828C File Offset: 0x000C648C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(XdrBuilder builder, Object obj, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrInitFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XdrBuilder_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002D02 RID: 11522 RVA: 0x000C8314 File Offset: 0x000C6514
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrInitFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D03 RID: 11523 RVA: 0x00013750 File Offset: 0x00011950
			public XdrInitFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002D04 RID: 11524 RVA: 0x00013759 File Offset: 0x00011959
			public static implicit operator XdrBuilder.XdrInitFunction(Action<XdrBuilder, Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<XdrBuilder.XdrInitFunction>(A_0);
			}

			// Token: 0x06002D05 RID: 11525 RVA: 0x00013761 File Offset: 0x00011961
			public static XdrBuilder.XdrInitFunction operator +(XdrBuilder.XdrInitFunction A_0, XdrBuilder.XdrInitFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XdrBuilder.XdrInitFunction>();
			}

			// Token: 0x06002D06 RID: 11526 RVA: 0x0001376F File Offset: 0x0001196F
			public static XdrBuilder.XdrInitFunction operator -(XdrBuilder.XdrInitFunction A_0, XdrBuilder.XdrInitFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XdrBuilder.XdrInitFunction>();
				}
				return delegate2;
			}

			// Token: 0x04002379 RID: 9081
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400237A RID: 9082
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_0;

			// Token: 0x0400237B RID: 9083
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XdrBuilder_Object_AsyncCallback_Object_0;

			// Token: 0x0400237C RID: 9084
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200023E RID: 574
		public sealed class XdrBeginChildFunction : MulticastDelegate
		{
			// Token: 0x06002D07 RID: 11527 RVA: 0x000C8358 File Offset: 0x000C6558
			// Note: this type is marked as 'beforefieldinit'.
			static XdrBeginChildFunction()
			{
				Il2CppClassPointerStore<XdrBuilder.XdrBeginChildFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrBeginChildFunction");
				XdrBuilder.XdrBeginChildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrBeginChildFunction>.NativeClassPtr, 100667815);
				XdrBuilder.XdrBeginChildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrBeginChildFunction>.NativeClassPtr, 100667816);
				XdrBuilder.XdrBeginChildFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XdrBuilder_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrBeginChildFunction>.NativeClassPtr, 100667817);
				XdrBuilder.XdrBeginChildFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrBeginChildFunction>.NativeClassPtr, 100667818);
			}

			// Token: 0x06002D08 RID: 11528 RVA: 0x000C83CC File Offset: 0x000C65CC
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XdrBeginChildFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.XdrBeginChildFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrBeginChildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D09 RID: 11529 RVA: 0x000C8428 File Offset: 0x000C6628
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 14114, RefRangeEnd = 14213, XrefRangeStart = 14114, XrefRangeEnd = 14213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(XdrBuilder builder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrBeginChildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D0A RID: 11530 RVA: 0x000C846C File Offset: 0x000C666C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(XdrBuilder builder, AsyncCallback callback, Object @object)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrBeginChildFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XdrBuilder_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002D0B RID: 11531 RVA: 0x000C84E0 File Offset: 0x000C66E0
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrBeginChildFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D0C RID: 11532 RVA: 0x00013780 File Offset: 0x00011980
			public XdrBeginChildFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002D0D RID: 11533 RVA: 0x00013789 File Offset: 0x00011989
			public static implicit operator XdrBuilder.XdrBeginChildFunction(Action<XdrBuilder> A_0)
			{
				return DelegateSupport.ConvertDelegate<XdrBuilder.XdrBeginChildFunction>(A_0);
			}

			// Token: 0x06002D0E RID: 11534 RVA: 0x00013791 File Offset: 0x00011991
			public static XdrBuilder.XdrBeginChildFunction operator +(XdrBuilder.XdrBeginChildFunction A_0, XdrBuilder.XdrBeginChildFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XdrBuilder.XdrBeginChildFunction>();
			}

			// Token: 0x06002D0F RID: 11535 RVA: 0x0001379F File Offset: 0x0001199F
			public static XdrBuilder.XdrBeginChildFunction operator -(XdrBuilder.XdrBeginChildFunction A_0, XdrBuilder.XdrBeginChildFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XdrBuilder.XdrBeginChildFunction>();
				}
				return delegate2;
			}

			// Token: 0x0400237D RID: 9085
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400237E RID: 9086
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0;

			// Token: 0x0400237F RID: 9087
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XdrBuilder_AsyncCallback_Object_0;

			// Token: 0x04002380 RID: 9088
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200023F RID: 575
		public sealed class XdrEndChildFunction : MulticastDelegate
		{
			// Token: 0x06002D10 RID: 11536 RVA: 0x000C8524 File Offset: 0x000C6724
			// Note: this type is marked as 'beforefieldinit'.
			static XdrEndChildFunction()
			{
				Il2CppClassPointerStore<XdrBuilder.XdrEndChildFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrEndChildFunction");
				XdrBuilder.XdrEndChildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrEndChildFunction>.NativeClassPtr, 100667819);
				XdrBuilder.XdrEndChildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrEndChildFunction>.NativeClassPtr, 100667820);
				XdrBuilder.XdrEndChildFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XdrBuilder_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrEndChildFunction>.NativeClassPtr, 100667821);
				XdrBuilder.XdrEndChildFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrEndChildFunction>.NativeClassPtr, 100667822);
			}

			// Token: 0x06002D11 RID: 11537 RVA: 0x000C8598 File Offset: 0x000C6798
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XdrEndChildFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.XdrEndChildFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrEndChildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D12 RID: 11538 RVA: 0x000C85F4 File Offset: 0x000C67F4
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 14114, RefRangeEnd = 14213, XrefRangeStart = 14114, XrefRangeEnd = 14213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(XdrBuilder builder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrEndChildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D13 RID: 11539 RVA: 0x000C8638 File Offset: 0x000C6838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(XdrBuilder builder, AsyncCallback callback, Object @object)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrEndChildFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XdrBuilder_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002D14 RID: 11540 RVA: 0x000C86AC File Offset: 0x000C68AC
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrEndChildFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D15 RID: 11541 RVA: 0x000137B0 File Offset: 0x000119B0
			public XdrEndChildFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002D16 RID: 11542 RVA: 0x000137B9 File Offset: 0x000119B9
			public static implicit operator XdrBuilder.XdrEndChildFunction(Action<XdrBuilder> A_0)
			{
				return DelegateSupport.ConvertDelegate<XdrBuilder.XdrEndChildFunction>(A_0);
			}

			// Token: 0x06002D17 RID: 11543 RVA: 0x000137C1 File Offset: 0x000119C1
			public static XdrBuilder.XdrEndChildFunction operator +(XdrBuilder.XdrEndChildFunction A_0, XdrBuilder.XdrEndChildFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XdrBuilder.XdrEndChildFunction>();
			}

			// Token: 0x06002D18 RID: 11544 RVA: 0x000137CF File Offset: 0x000119CF
			public static XdrBuilder.XdrEndChildFunction operator -(XdrBuilder.XdrEndChildFunction A_0, XdrBuilder.XdrEndChildFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XdrBuilder.XdrEndChildFunction>();
				}
				return delegate2;
			}

			// Token: 0x04002381 RID: 9089
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002382 RID: 9090
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0;

			// Token: 0x04002383 RID: 9091
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XdrBuilder_AsyncCallback_Object_0;

			// Token: 0x04002384 RID: 9092
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000240 RID: 576
		public sealed class XdrAttributeEntry : Object
		{
			// Token: 0x06002D19 RID: 11545 RVA: 0x000C86F0 File Offset: 0x000C68F0
			// Note: this type is marked as 'beforefieldinit'.
			static XdrAttributeEntry()
			{
				Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrAttributeEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr);
				XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr, "_Attribute");
				XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__SchemaFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr, "_SchemaFlags");
				XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__Datatype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr, "_Datatype");
				XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__BuildFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr, "_BuildFunc");
				XdrBuilder.XdrAttributeEntry.NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_XdrBuildFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr, 100667823);
				XdrBuilder.XdrAttributeEntry.NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_Int32_XdrBuildFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr, 100667824);
			}

			// Token: 0x06002D1A RID: 11546 RVA: 0x000C8794 File Offset: 0x000C6994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424724, XrefRangeEnd = 424725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XdrAttributeEntry(SchemaNames.Token a, XmlTokenizedType ttype, XdrBuilder.XdrBuildFunction build)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ttype;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(build);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrAttributeEntry.NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_XdrBuildFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D1B RID: 11547 RVA: 0x000C87FC File Offset: 0x000C69FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424725, XrefRangeEnd = 424726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XdrAttributeEntry(SchemaNames.Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuilder.XdrBuildFunction build)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ttype;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref schemaFlags;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(build);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrAttributeEntry.NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_Int32_XdrBuildFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D1C RID: 11548 RVA: 0x000137E0 File Offset: 0x000119E0
			public XdrAttributeEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F57 RID: 3927
			// (get) Token: 0x06002D1D RID: 11549 RVA: 0x000C8874 File Offset: 0x000C6A74
			// (set) Token: 0x06002D1E RID: 11550 RVA: 0x000137E9 File Offset: 0x000119E9
			public unsafe SchemaNames.Token _Attribute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__Attribute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__Attribute)) = value;
				}
			}

			// Token: 0x17000F58 RID: 3928
			// (get) Token: 0x06002D1F RID: 11551 RVA: 0x000C889C File Offset: 0x000C6A9C
			// (set) Token: 0x06002D20 RID: 11552 RVA: 0x00013804 File Offset: 0x00011A04
			public unsafe int _SchemaFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__SchemaFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__SchemaFlags)) = value;
				}
			}

			// Token: 0x17000F59 RID: 3929
			// (get) Token: 0x06002D21 RID: 11553 RVA: 0x000C88C4 File Offset: 0x000C6AC4
			// (set) Token: 0x06002D22 RID: 11554 RVA: 0x0001381F File Offset: 0x00011A1F
			public unsafe XmlSchemaDatatype _Datatype
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__Datatype);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__Datatype), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F5A RID: 3930
			// (get) Token: 0x06002D23 RID: 11555 RVA: 0x000C88F4 File Offset: 0x000C6AF4
			// (set) Token: 0x06002D24 RID: 11556 RVA: 0x0001383E File Offset: 0x00011A3E
			public unsafe XdrBuilder.XdrBuildFunction _BuildFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__BuildFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.XdrBuildFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__BuildFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002385 RID: 9093
			private static readonly IntPtr NativeFieldInfoPtr__Attribute;

			// Token: 0x04002386 RID: 9094
			private static readonly IntPtr NativeFieldInfoPtr__SchemaFlags;

			// Token: 0x04002387 RID: 9095
			private static readonly IntPtr NativeFieldInfoPtr__Datatype;

			// Token: 0x04002388 RID: 9096
			private static readonly IntPtr NativeFieldInfoPtr__BuildFunc;

			// Token: 0x04002389 RID: 9097
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_XdrBuildFunction_0;

			// Token: 0x0400238A RID: 9098
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_Int32_XdrBuildFunction_0;
		}

		// Token: 0x02000241 RID: 577
		public sealed class XdrEntry : Object
		{
			// Token: 0x06002D25 RID: 11557 RVA: 0x000C8924 File Offset: 0x000C6B24
			// Note: this type is marked as 'beforefieldinit'.
			static XdrEntry()
			{
				Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr);
				XdrBuilder.XdrEntry.NativeFieldInfoPtr__Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr, "_Name");
				XdrBuilder.XdrEntry.NativeFieldInfoPtr__NextStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr, "_NextStates");
				XdrBuilder.XdrEntry.NativeFieldInfoPtr__Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr, "_Attributes");
				XdrBuilder.XdrEntry.NativeFieldInfoPtr__InitFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr, "_InitFunc");
				XdrBuilder.XdrEntry.NativeFieldInfoPtr__BeginChildFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr, "_BeginChildFunc");
				XdrBuilder.XdrEntry.NativeFieldInfoPtr__EndChildFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr, "_EndChildFunc");
				XdrBuilder.XdrEntry.NativeFieldInfoPtr__AllowText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr, "_AllowText");
				XdrBuilder.XdrEntry.NativeMethodInfoPtr__ctor_Internal_Void_Token_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_XdrAttributeEntry_XdrInitFunction_XdrBeginChildFunction_XdrEndChildFunction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr, 100667825);
			}

			// Token: 0x06002D26 RID: 11558 RVA: 0x000C89F0 File Offset: 0x000C6BF0
			[CallerCount(0)]
			public unsafe XdrEntry(SchemaNames.Token n, Il2CppStructArray<int> states, Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> attributes, XdrBuilder.XdrInitFunction init, XdrBuilder.XdrBeginChildFunction begin, XdrBuilder.XdrEndChildFunction end, bool fText)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(states);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(init);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(begin);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(end);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fText;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrEntry.NativeMethodInfoPtr__ctor_Internal_Void_Token_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_XdrAttributeEntry_XdrInitFunction_XdrBeginChildFunction_XdrEndChildFunction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D27 RID: 11559 RVA: 0x0001385D File Offset: 0x00011A5D
			public XdrEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F5B RID: 3931
			// (get) Token: 0x06002D28 RID: 11560 RVA: 0x000C8AA4 File Offset: 0x000C6CA4
			// (set) Token: 0x06002D29 RID: 11561 RVA: 0x00013866 File Offset: 0x00011A66
			public unsafe SchemaNames.Token _Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__Name);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__Name)) = value;
				}
			}

			// Token: 0x17000F5C RID: 3932
			// (get) Token: 0x06002D2A RID: 11562 RVA: 0x000C8ACC File Offset: 0x000C6CCC
			// (set) Token: 0x06002D2B RID: 11563 RVA: 0x00013881 File Offset: 0x00011A81
			public unsafe Il2CppStructArray<int> _NextStates
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__NextStates);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__NextStates), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F5D RID: 3933
			// (get) Token: 0x06002D2C RID: 11564 RVA: 0x000C8AFC File Offset: 0x000C6CFC
			// (set) Token: 0x06002D2D RID: 11565 RVA: 0x000138A0 File Offset: 0x00011AA0
			public unsafe Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> _Attributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__Attributes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F5E RID: 3934
			// (get) Token: 0x06002D2E RID: 11566 RVA: 0x000C8B2C File Offset: 0x000C6D2C
			// (set) Token: 0x06002D2F RID: 11567 RVA: 0x000138BF File Offset: 0x00011ABF
			public unsafe XdrBuilder.XdrInitFunction _InitFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__InitFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.XdrInitFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__InitFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F5F RID: 3935
			// (get) Token: 0x06002D30 RID: 11568 RVA: 0x000C8B5C File Offset: 0x000C6D5C
			// (set) Token: 0x06002D31 RID: 11569 RVA: 0x000138DE File Offset: 0x00011ADE
			public unsafe XdrBuilder.XdrBeginChildFunction _BeginChildFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__BeginChildFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.XdrBeginChildFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__BeginChildFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F60 RID: 3936
			// (get) Token: 0x06002D32 RID: 11570 RVA: 0x000C8B8C File Offset: 0x000C6D8C
			// (set) Token: 0x06002D33 RID: 11571 RVA: 0x000138FD File Offset: 0x00011AFD
			public unsafe XdrBuilder.XdrEndChildFunction _EndChildFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__EndChildFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.XdrEndChildFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__EndChildFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F61 RID: 3937
			// (get) Token: 0x06002D34 RID: 11572 RVA: 0x000C8BBC File Offset: 0x000C6DBC
			// (set) Token: 0x06002D35 RID: 11573 RVA: 0x0001391C File Offset: 0x00011B1C
			public unsafe bool _AllowText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__AllowText);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__AllowText)) = value;
				}
			}

			// Token: 0x0400238B RID: 9099
			private static readonly IntPtr NativeFieldInfoPtr__Name;

			// Token: 0x0400238C RID: 9100
			private static readonly IntPtr NativeFieldInfoPtr__NextStates;

			// Token: 0x0400238D RID: 9101
			private static readonly IntPtr NativeFieldInfoPtr__Attributes;

			// Token: 0x0400238E RID: 9102
			private static readonly IntPtr NativeFieldInfoPtr__InitFunc;

			// Token: 0x0400238F RID: 9103
			private static readonly IntPtr NativeFieldInfoPtr__BeginChildFunc;

			// Token: 0x04002390 RID: 9104
			private static readonly IntPtr NativeFieldInfoPtr__EndChildFunc;

			// Token: 0x04002391 RID: 9105
			private static readonly IntPtr NativeFieldInfoPtr__AllowText;

			// Token: 0x04002392 RID: 9106
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Token_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_XdrAttributeEntry_XdrInitFunction_XdrBeginChildFunction_XdrEndChildFunction_Boolean_0;
		}
	}
}
