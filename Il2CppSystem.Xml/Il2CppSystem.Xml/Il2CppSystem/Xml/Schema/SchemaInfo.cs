using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200017A RID: 378
	public class SchemaInfo : Object
	{
		// Token: 0x06001CF5 RID: 7413 RVA: 0x0008D350 File Offset: 0x0008B550
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaInfo()
		{
			Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr);
			SchemaInfo.NativeFieldInfoPtr_elementDecls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "elementDecls");
			SchemaInfo.NativeFieldInfoPtr_undeclaredElementDecls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "undeclaredElementDecls");
			SchemaInfo.NativeFieldInfoPtr_generalEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "generalEntities");
			SchemaInfo.NativeFieldInfoPtr_parameterEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "parameterEntities");
			SchemaInfo.NativeFieldInfoPtr_docTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "docTypeName");
			SchemaInfo.NativeFieldInfoPtr_internalDtdSubset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "internalDtdSubset");
			SchemaInfo.NativeFieldInfoPtr_hasNonCDataAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "hasNonCDataAttributes");
			SchemaInfo.NativeFieldInfoPtr_hasDefaultAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "hasDefaultAttributes");
			SchemaInfo.NativeFieldInfoPtr_targetNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "targetNamespaces");
			SchemaInfo.NativeFieldInfoPtr_attributeDecls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "attributeDecls");
			SchemaInfo.NativeFieldInfoPtr_errorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "errorCount");
			SchemaInfo.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "schemaType");
			SchemaInfo.NativeFieldInfoPtr_elementDeclsByType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "elementDeclsByType");
			SchemaInfo.NativeFieldInfoPtr_notations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "notations");
			SchemaInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667584);
			SchemaInfo.NativeMethodInfoPtr_get_DocTypeName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667585);
			SchemaInfo.NativeMethodInfoPtr_set_DocTypeName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667586);
			SchemaInfo.NativeMethodInfoPtr_set_InternalDtdSubset_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667587);
			SchemaInfo.NativeMethodInfoPtr_get_ElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667588);
			SchemaInfo.NativeMethodInfoPtr_get_UndeclaredElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667589);
			SchemaInfo.NativeMethodInfoPtr_get_GeneralEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667590);
			SchemaInfo.NativeMethodInfoPtr_get_ParameterEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667591);
			SchemaInfo.NativeMethodInfoPtr_get_SchemaType_Internal_get_SchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667592);
			SchemaInfo.NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_SchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667593);
			SchemaInfo.NativeMethodInfoPtr_get_TargetNamespaces_Internal_get_Dictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667594);
			SchemaInfo.NativeMethodInfoPtr_get_ElementDeclsByType_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667595);
			SchemaInfo.NativeMethodInfoPtr_get_AttributeDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667596);
			SchemaInfo.NativeMethodInfoPtr_get_Notations_Internal_get_Dictionary_2_String_SchemaNotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667597);
			SchemaInfo.NativeMethodInfoPtr_get_ErrorCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667598);
			SchemaInfo.NativeMethodInfoPtr_set_ErrorCount_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667599);
			SchemaInfo.NativeMethodInfoPtr_GetElementDecl_Internal_SchemaElementDecl_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667600);
			SchemaInfo.NativeMethodInfoPtr_GetTypeDecl_Internal_SchemaElementDecl_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667601);
			SchemaInfo.NativeMethodInfoPtr_GetElement_Internal_XmlSchemaElement_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667602);
			SchemaInfo.NativeMethodInfoPtr_HasSchema_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667603);
			SchemaInfo.NativeMethodInfoPtr_Contains_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667604);
			SchemaInfo.NativeMethodInfoPtr_GetAttributeXdr_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667605);
			SchemaInfo.NativeMethodInfoPtr_GetAttributeXsd_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_XmlSchemaObject_byref_AttributeMatchState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667606);
			SchemaInfo.NativeMethodInfoPtr_GetAttributeXsd_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667607);
			SchemaInfo.NativeMethodInfoPtr_Add_Internal_Void_SchemaInfo_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667608);
			SchemaInfo.NativeMethodInfoPtr_Finish_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667609);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasDefaultAttributes_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667610);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667611);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupAttributeList_Private_Virtual_Final_New_IDtdAttributeListInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667612);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupEntity_Private_Virtual_Final_New_IDtdEntityInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667613);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_Name_Private_Virtual_Final_New_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667614);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_InternalDtdSubset_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100667615);
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x0008D718 File Offset: 0x0008B918
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 420315, RefRangeEnd = 420329, XrefRangeStart = 420288, XrefRangeEnd = 420315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x0008D754 File Offset: 0x0008B954
		// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x0008D794 File Offset: 0x0008B994
		public unsafe XmlQualifiedName DocTypeName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_DocTypeName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_set_DocTypeName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x0008D7D8 File Offset: 0x0008B9D8
		public unsafe string InternalDtdSubset
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_set_InternalDtdSubset_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x0008D81C File Offset: 0x0008BA1C
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_ElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr3) : null;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x0008D85C File Offset: 0x0008BA5C
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_UndeclaredElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr3) : null;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x0008D89C File Offset: 0x0008BA9C
		public unsafe Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 420334, RefRangeEnd = 420342, XrefRangeStart = 420329, XrefRangeEnd = 420334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_GeneralEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x0008D8DC File Offset: 0x0008BADC
		public unsafe Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 420347, RefRangeEnd = 420353, XrefRangeStart = 420342, XrefRangeEnd = 420347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_ParameterEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x0008D91C File Offset: 0x0008BB1C
		// (set) Token: 0x06001CFF RID: 7423 RVA: 0x0008D958 File Offset: 0x0008BB58
		public unsafe SchemaType SchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_SchemaType_Internal_get_SchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_SchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x0008D998 File Offset: 0x0008BB98
		public unsafe Dictionary<string, bool> TargetNamespaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_TargetNamespaces_Internal_get_Dictionary_2_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr3) : null;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x0008D9D8 File Offset: 0x0008BBD8
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDeclsByType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_ElementDeclsByType_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr3) : null;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x0008DA18 File Offset: 0x0008BC18
		public unsafe Dictionary<XmlQualifiedName, SchemaAttDef> AttributeDecls
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_AttributeDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaAttDef>>(intPtr3) : null;
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x0008DA58 File Offset: 0x0008BC58
		public unsafe Dictionary<string, SchemaNotation> Notations
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 420358, RefRangeEnd = 420367, XrefRangeStart = 420353, XrefRangeEnd = 420358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_Notations_Internal_get_Dictionary_2_String_SchemaNotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SchemaNotation>>(intPtr3) : null;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x0008DA98 File Offset: 0x0008BC98
		// (set) Token: 0x06001D05 RID: 7429 RVA: 0x0008DAD4 File Offset: 0x0008BCD4
		public unsafe int ErrorCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_ErrorCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_set_ErrorCount_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x0008DB14 File Offset: 0x0008BD14
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 420369, RefRangeEnd = 420377, XrefRangeStart = 420367, XrefRangeEnd = 420369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl GetElementDecl(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_GetElementDecl_Internal_SchemaElementDecl_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
			}
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x0008DB64 File Offset: 0x0008BD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 420377, XrefRangeEnd = 420379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl GetTypeDecl(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_GetTypeDecl_Internal_SchemaElementDecl_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
			}
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x0008DBB4 File Offset: 0x0008BDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 420379, XrefRangeEnd = 420380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaElement GetElement(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_GetElement_Internal_XmlSchemaElement_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x0008DC04 File Offset: 0x0008BE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 420380, XrefRangeEnd = 420382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSchema(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_HasSchema_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x0008DC54 File Offset: 0x0008BE54
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 420384, RefRangeEnd = 420390, XrefRangeStart = 420382, XrefRangeEnd = 420384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_Contains_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x0008DCA4 File Offset: 0x0008BEA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 420396, RefRangeEnd = 420397, XrefRangeStart = 420390, XrefRangeEnd = 420396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ed);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(qname);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_GetAttributeXdr_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr3) : null;
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x0008DD08 File Offset: 0x0008BF08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 420415, RefRangeEnd = 420418, XrefRangeStart = 420397, XrefRangeEnd = 420415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ed);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(qname);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partialValidationType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &attributeMatchState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_GetAttributeXsd_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_XmlSchemaObject_byref_AttributeMatchState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr3) : null;
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x0008DD8C File Offset: 0x0008BF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 420418, XrefRangeEnd = 420419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ed);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(qname);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &skip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_GetAttributeXsd_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr3) : null;
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x0008DDFC File Offset: 0x0008BFFC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 420461, RefRangeEnd = 420471, XrefRangeStart = 420419, XrefRangeEnd = 420461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sinfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventhandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_Add_Internal_Void_SchemaInfo_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x0008DE50 File Offset: 0x0008C050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 420483, RefRangeEnd = 420484, XrefRangeStart = 420471, XrefRangeEnd = 420483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_Finish_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x0008DE84 File Offset: 0x0008C084
		public unsafe virtual bool System.Xml.IDtdInfo.HasDefaultAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasDefaultAttributes_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x0008DEC0 File Offset: 0x0008C0C0
		public unsafe virtual bool System.Xml.IDtdInfo.HasNonCDataAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x0008DEFC File Offset: 0x0008C0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 420484, XrefRangeEnd = 420492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDtdAttributeListInfo System_Xml_IDtdInfo_LookupAttributeList(string prefix, string localName)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupAttributeList_Private_Virtual_Final_New_IDtdAttributeListInfo_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdAttributeListInfo>(intPtr3) : null;
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0008DF60 File Offset: 0x0008C160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 420492, XrefRangeEnd = 420498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDtdEntityInfo System_Xml_IDtdInfo_LookupEntity(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupEntity_Private_Virtual_Final_New_IDtdEntityInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdEntityInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x0008DFB0 File Offset: 0x0008C1B0
		public unsafe virtual XmlQualifiedName System.Xml.IDtdInfo.Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_Name_Private_Virtual_Final_New_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x0008DFF0 File Offset: 0x0008C1F0
		public unsafe virtual string System.Xml.IDtdInfo.InternalDtdSubset
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_InternalDtdSubset_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x0000C1E4 File Offset: 0x0000A3E4
		public SchemaInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x0008E028 File Offset: 0x0008C228
		// (set) Token: 0x06001D18 RID: 7448 RVA: 0x0000C1ED File Offset: 0x0000A3ED
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_elementDecls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_elementDecls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x0008E058 File Offset: 0x0008C258
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x0000C20C File Offset: 0x0000A40C
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_undeclaredElementDecls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_undeclaredElementDecls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x0008E088 File Offset: 0x0008C288
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x0000C22B File Offset: 0x0000A42B
		public unsafe Dictionary<XmlQualifiedName, SchemaEntity> generalEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_generalEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_generalEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x0008E0B8 File Offset: 0x0008C2B8
		// (set) Token: 0x06001D1E RID: 7454 RVA: 0x0000C24A File Offset: 0x0000A44A
		public unsafe Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_parameterEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_parameterEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x0008E0E8 File Offset: 0x0008C2E8
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x0000C269 File Offset: 0x0000A469
		public unsafe XmlQualifiedName docTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_docTypeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_docTypeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x0008E118 File Offset: 0x0008C318
		// (set) Token: 0x06001D22 RID: 7458 RVA: 0x0000C288 File Offset: 0x0000A488
		public unsafe string internalDtdSubset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_internalDtdSubset);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_internalDtdSubset), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x0008E140 File Offset: 0x0008C340
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x0000C2A7 File Offset: 0x0000A4A7
		public unsafe bool hasNonCDataAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_hasNonCDataAttributes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_hasNonCDataAttributes)) = value;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x0008E168 File Offset: 0x0008C368
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x0000C2C2 File Offset: 0x0000A4C2
		public unsafe bool hasDefaultAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_hasDefaultAttributes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_hasDefaultAttributes)) = value;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x0008E190 File Offset: 0x0008C390
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x0000C2DD File Offset: 0x0000A4DD
		public unsafe Dictionary<string, bool> targetNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_targetNamespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_targetNamespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x0008E1C0 File Offset: 0x0008C3C0
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x0000C2FC File Offset: 0x0000A4FC
		public unsafe Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_attributeDecls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaAttDef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_attributeDecls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x0008E1F0 File Offset: 0x0008C3F0
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x0000C31B File Offset: 0x0000A51B
		public unsafe int errorCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_errorCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_errorCount)) = value;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x0008E218 File Offset: 0x0008C418
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x0000C336 File Offset: 0x0000A536
		public unsafe SchemaType schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_schemaType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_schemaType)) = value;
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x0008E240 File Offset: 0x0008C440
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x0000C351 File Offset: 0x0000A551
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_elementDeclsByType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_elementDeclsByType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x0008E270 File Offset: 0x0008C470
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x0000C370 File Offset: 0x0000A570
		public unsafe Dictionary<string, SchemaNotation> notations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_notations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SchemaNotation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_notations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015BC RID: 5564
		private static readonly IntPtr NativeFieldInfoPtr_elementDecls;

		// Token: 0x040015BD RID: 5565
		private static readonly IntPtr NativeFieldInfoPtr_undeclaredElementDecls;

		// Token: 0x040015BE RID: 5566
		private static readonly IntPtr NativeFieldInfoPtr_generalEntities;

		// Token: 0x040015BF RID: 5567
		private static readonly IntPtr NativeFieldInfoPtr_parameterEntities;

		// Token: 0x040015C0 RID: 5568
		private static readonly IntPtr NativeFieldInfoPtr_docTypeName;

		// Token: 0x040015C1 RID: 5569
		private static readonly IntPtr NativeFieldInfoPtr_internalDtdSubset;

		// Token: 0x040015C2 RID: 5570
		private static readonly IntPtr NativeFieldInfoPtr_hasNonCDataAttributes;

		// Token: 0x040015C3 RID: 5571
		private static readonly IntPtr NativeFieldInfoPtr_hasDefaultAttributes;

		// Token: 0x040015C4 RID: 5572
		private static readonly IntPtr NativeFieldInfoPtr_targetNamespaces;

		// Token: 0x040015C5 RID: 5573
		private static readonly IntPtr NativeFieldInfoPtr_attributeDecls;

		// Token: 0x040015C6 RID: 5574
		private static readonly IntPtr NativeFieldInfoPtr_errorCount;

		// Token: 0x040015C7 RID: 5575
		private static readonly IntPtr NativeFieldInfoPtr_schemaType;

		// Token: 0x040015C8 RID: 5576
		private static readonly IntPtr NativeFieldInfoPtr_elementDeclsByType;

		// Token: 0x040015C9 RID: 5577
		private static readonly IntPtr NativeFieldInfoPtr_notations;

		// Token: 0x040015CA RID: 5578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040015CB RID: 5579
		private static readonly IntPtr NativeMethodInfoPtr_get_DocTypeName_Public_get_XmlQualifiedName_0;

		// Token: 0x040015CC RID: 5580
		private static readonly IntPtr NativeMethodInfoPtr_set_DocTypeName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x040015CD RID: 5581
		private static readonly IntPtr NativeMethodInfoPtr_set_InternalDtdSubset_Internal_set_Void_String_0;

		// Token: 0x040015CE RID: 5582
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0;

		// Token: 0x040015CF RID: 5583
		private static readonly IntPtr NativeMethodInfoPtr_get_UndeclaredElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0;

		// Token: 0x040015D0 RID: 5584
		private static readonly IntPtr NativeMethodInfoPtr_get_GeneralEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0;

		// Token: 0x040015D1 RID: 5585
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0;

		// Token: 0x040015D2 RID: 5586
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Internal_get_SchemaType_0;

		// Token: 0x040015D3 RID: 5587
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_SchemaType_0;

		// Token: 0x040015D4 RID: 5588
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetNamespaces_Internal_get_Dictionary_2_String_Boolean_0;

		// Token: 0x040015D5 RID: 5589
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementDeclsByType_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0;

		// Token: 0x040015D6 RID: 5590
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0;

		// Token: 0x040015D7 RID: 5591
		private static readonly IntPtr NativeMethodInfoPtr_get_Notations_Internal_get_Dictionary_2_String_SchemaNotation_0;

		// Token: 0x040015D8 RID: 5592
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorCount_Internal_get_Int32_0;

		// Token: 0x040015D9 RID: 5593
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorCount_Internal_set_Void_Int32_0;

		// Token: 0x040015DA RID: 5594
		private static readonly IntPtr NativeMethodInfoPtr_GetElementDecl_Internal_SchemaElementDecl_XmlQualifiedName_0;

		// Token: 0x040015DB RID: 5595
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeDecl_Internal_SchemaElementDecl_XmlQualifiedName_0;

		// Token: 0x040015DC RID: 5596
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Internal_XmlSchemaElement_XmlQualifiedName_0;

		// Token: 0x040015DD RID: 5597
		private static readonly IntPtr NativeMethodInfoPtr_HasSchema_Internal_Boolean_String_0;

		// Token: 0x040015DE RID: 5598
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Internal_Boolean_String_0;

		// Token: 0x040015DF RID: 5599
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeXdr_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_0;

		// Token: 0x040015E0 RID: 5600
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeXsd_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_XmlSchemaObject_byref_AttributeMatchState_0;

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeXsd_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_byref_Boolean_0;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_SchemaInfo_ValidationEventHandler_0;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeMethodInfoPtr_Finish_Internal_Void_0;

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasDefaultAttributes_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupAttributeList_Private_Virtual_Final_New_IDtdAttributeListInfo_String_String_0;

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupEntity_Private_Virtual_Final_New_IDtdEntityInfo_String_0;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_get_Name_Private_Virtual_Final_New_get_XmlQualifiedName_0;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_get_InternalDtdSubset_Private_Virtual_Final_New_get_String_0;
	}
}
