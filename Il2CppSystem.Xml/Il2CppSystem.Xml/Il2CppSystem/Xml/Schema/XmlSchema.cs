using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000187 RID: 391
	public class XmlSchema : XmlSchemaObject
	{
		// Token: 0x06001FFC RID: 8188 RVA: 0x00097A58 File Offset: 0x00095C58
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchema()
		{
			Il2CppClassPointerStore<XmlSchema>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchema");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr);
			XmlSchema.NativeFieldInfoPtr_attributeFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "attributeFormDefault");
			XmlSchema.NativeFieldInfoPtr_elementFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "elementFormDefault");
			XmlSchema.NativeFieldInfoPtr_blockDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "blockDefault");
			XmlSchema.NativeFieldInfoPtr_finalDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "finalDefault");
			XmlSchema.NativeFieldInfoPtr_targetNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "targetNs");
			XmlSchema.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "version");
			XmlSchema.NativeFieldInfoPtr_includes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "includes");
			XmlSchema.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "items");
			XmlSchema.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "id");
			XmlSchema.NativeFieldInfoPtr_moreAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "moreAttributes");
			XmlSchema.NativeFieldInfoPtr_isCompiled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "isCompiled");
			XmlSchema.NativeFieldInfoPtr_isCompiledBySet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "isCompiledBySet");
			XmlSchema.NativeFieldInfoPtr_isPreprocessed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "isPreprocessed");
			XmlSchema.NativeFieldInfoPtr_isRedefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "isRedefined");
			XmlSchema.NativeFieldInfoPtr_errorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "errorCount");
			XmlSchema.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "attributes");
			XmlSchema.NativeFieldInfoPtr_attributeGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "attributeGroups");
			XmlSchema.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "elements");
			XmlSchema.NativeFieldInfoPtr_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "types");
			XmlSchema.NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "groups");
			XmlSchema.NativeFieldInfoPtr_notations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "notations");
			XmlSchema.NativeFieldInfoPtr_identityConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "identityConstraints");
			XmlSchema.NativeFieldInfoPtr_globalIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "globalIdCounter");
			XmlSchema.NativeFieldInfoPtr_importedSchemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "importedSchemas");
			XmlSchema.NativeFieldInfoPtr_importedNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "importedNamespaces");
			XmlSchema.NativeFieldInfoPtr_schemaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "schemaId");
			XmlSchema.NativeFieldInfoPtr_baseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "baseUri");
			XmlSchema.NativeFieldInfoPtr_isChameleon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "isChameleon");
			XmlSchema.NativeFieldInfoPtr_ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "ids");
			XmlSchema.NativeFieldInfoPtr_document = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "document");
			XmlSchema.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667879);
			XmlSchema.NativeMethodInfoPtr_CompileSchema_Internal_Boolean_XmlSchemaCollection_XmlResolver_SchemaInfo_String_ValidationEventHandler_XmlNameTable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667880);
			XmlSchema.NativeMethodInfoPtr_CompileSchemaInSet_Internal_Void_XmlNameTable_ValidationEventHandler_XmlSchemaCompilationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667881);
			XmlSchema.NativeMethodInfoPtr_get_AttributeFormDefault_Public_get_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667882);
			XmlSchema.NativeMethodInfoPtr_set_AttributeFormDefault_Public_set_Void_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667883);
			XmlSchema.NativeMethodInfoPtr_get_BlockDefault_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667884);
			XmlSchema.NativeMethodInfoPtr_set_BlockDefault_Public_set_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667885);
			XmlSchema.NativeMethodInfoPtr_get_FinalDefault_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667886);
			XmlSchema.NativeMethodInfoPtr_set_FinalDefault_Public_set_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667887);
			XmlSchema.NativeMethodInfoPtr_get_ElementFormDefault_Public_get_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667888);
			XmlSchema.NativeMethodInfoPtr_set_ElementFormDefault_Public_set_Void_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667889);
			XmlSchema.NativeMethodInfoPtr_get_TargetNamespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667890);
			XmlSchema.NativeMethodInfoPtr_set_TargetNamespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667891);
			XmlSchema.NativeMethodInfoPtr_get_Version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667892);
			XmlSchema.NativeMethodInfoPtr_set_Version_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667893);
			XmlSchema.NativeMethodInfoPtr_get_Includes_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667894);
			XmlSchema.NativeMethodInfoPtr_get_Items_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667895);
			XmlSchema.NativeMethodInfoPtr_get_IsCompiledBySet_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667896);
			XmlSchema.NativeMethodInfoPtr_set_IsCompiledBySet_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667897);
			XmlSchema.NativeMethodInfoPtr_get_IsPreprocessed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667898);
			XmlSchema.NativeMethodInfoPtr_set_IsPreprocessed_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667899);
			XmlSchema.NativeMethodInfoPtr_get_IsRedefined_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667900);
			XmlSchema.NativeMethodInfoPtr_set_IsRedefined_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667901);
			XmlSchema.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667902);
			XmlSchema.NativeMethodInfoPtr_get_AttributeGroups_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667903);
			XmlSchema.NativeMethodInfoPtr_get_SchemaTypes_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667904);
			XmlSchema.NativeMethodInfoPtr_get_Elements_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667905);
			XmlSchema.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667906);
			XmlSchema.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667907);
			XmlSchema.NativeMethodInfoPtr_get_Groups_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667908);
			XmlSchema.NativeMethodInfoPtr_get_Notations_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667909);
			XmlSchema.NativeMethodInfoPtr_get_IdentityConstraints_Internal_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667910);
			XmlSchema.NativeMethodInfoPtr_get_BaseUri_Internal_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667911);
			XmlSchema.NativeMethodInfoPtr_set_BaseUri_Internal_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667912);
			XmlSchema.NativeMethodInfoPtr_get_SchemaId_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667913);
			XmlSchema.NativeMethodInfoPtr_get_IsChameleon_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667914);
			XmlSchema.NativeMethodInfoPtr_set_IsChameleon_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667915);
			XmlSchema.NativeMethodInfoPtr_get_Ids_Internal_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667916);
			XmlSchema.NativeMethodInfoPtr_get_Document_Internal_get_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667917);
			XmlSchema.NativeMethodInfoPtr_get_ErrorCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667918);
			XmlSchema.NativeMethodInfoPtr_set_ErrorCount_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667919);
			XmlSchema.NativeMethodInfoPtr_Clone_Internal_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667920);
			XmlSchema.NativeMethodInfoPtr_DeepClone_Internal_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667921);
			XmlSchema.NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667922);
			XmlSchema.NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667923);
			XmlSchema.NativeMethodInfoPtr_SetIsCompiled_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667924);
			XmlSchema.NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667925);
			XmlSchema.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667926);
			XmlSchema.NativeMethodInfoPtr_get_ImportedSchemas_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667927);
			XmlSchema.NativeMethodInfoPtr_get_ImportedNamespaces_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667928);
			XmlSchema.NativeMethodInfoPtr_GetExternalSchemasList_Internal_Void_IList_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100667929);
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x000980DC File Offset: 0x000962DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 426040, RefRangeEnd = 426043, XrefRangeStart = 426010, XrefRangeEnd = 426040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x00098118 File Offset: 0x00096318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 426068, RefRangeEnd = 426069, XrefRangeStart = 426043, XrefRangeEnd = 426068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xsc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validationEventHandler);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref CompileContentModel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_CompileSchema_Internal_Boolean_XmlSchemaCollection_XmlResolver_SchemaInfo_String_ValidationEventHandler_XmlNameTable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x000981D0 File Offset: 0x000963D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426069, XrefRangeEnd = 426075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compilationSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_CompileSchemaInSet_Internal_Void_XmlNameTable_ValidationEventHandler_XmlSchemaCompilationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x00098238 File Offset: 0x00096438
		// (set) Token: 0x06002001 RID: 8193 RVA: 0x00098274 File Offset: 0x00096474
		public unsafe XmlSchemaForm AttributeFormDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_AttributeFormDefault_Public_get_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_AttributeFormDefault_Public_set_Void_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x000982B4 File Offset: 0x000964B4
		// (set) Token: 0x06002003 RID: 8195 RVA: 0x000982F0 File Offset: 0x000964F0
		public unsafe XmlSchemaDerivationMethod BlockDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_BlockDefault_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_BlockDefault_Public_set_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x00098330 File Offset: 0x00096530
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x0009836C File Offset: 0x0009656C
		public unsafe XmlSchemaDerivationMethod FinalDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_FinalDefault_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_FinalDefault_Public_set_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x000983AC File Offset: 0x000965AC
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x000983E8 File Offset: 0x000965E8
		public unsafe XmlSchemaForm ElementFormDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_ElementFormDefault_Public_get_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_ElementFormDefault_Public_set_Void_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x00098428 File Offset: 0x00096628
		// (set) Token: 0x06002009 RID: 8201 RVA: 0x00098460 File Offset: 0x00096660
		public unsafe string TargetNamespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_TargetNamespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14747, RefRangeEnd = 14763, XrefRangeStart = 14747, XrefRangeEnd = 14763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_TargetNamespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x000984A4 File Offset: 0x000966A4
		// (set) Token: 0x0600200B RID: 8203 RVA: 0x000984DC File Offset: 0x000966DC
		public unsafe string Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 13543, RefRangeEnd = 13569, XrefRangeStart = 13543, XrefRangeEnd = 13569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_Version_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x00098520 File Offset: 0x00096720
		public unsafe XmlSchemaObjectCollection Includes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Includes_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x0600200D RID: 8205 RVA: 0x00098560 File Offset: 0x00096760
		public unsafe XmlSchemaObjectCollection Items
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Items_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x000985A0 File Offset: 0x000967A0
		// (set) Token: 0x0600200F RID: 8207 RVA: 0x000985DC File Offset: 0x000967DC
		public unsafe bool IsCompiledBySet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_IsCompiledBySet_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_IsCompiledBySet_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x0009861C File Offset: 0x0009681C
		// (set) Token: 0x06002011 RID: 8209 RVA: 0x00098658 File Offset: 0x00096858
		public unsafe bool IsPreprocessed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_IsPreprocessed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_IsPreprocessed_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x00098698 File Offset: 0x00096898
		// (set) Token: 0x06002013 RID: 8211 RVA: 0x000986D4 File Offset: 0x000968D4
		public unsafe bool IsRedefined
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_IsRedefined_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_IsRedefined_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x00098714 File Offset: 0x00096914
		public unsafe XmlSchemaObjectTable Attributes
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 426079, RefRangeEnd = 426097, XrefRangeStart = 426075, XrefRangeEnd = 426079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x00098754 File Offset: 0x00096954
		public unsafe XmlSchemaObjectTable AttributeGroups
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 426101, RefRangeEnd = 426120, XrefRangeStart = 426097, XrefRangeEnd = 426101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_AttributeGroups_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06002016 RID: 8214 RVA: 0x00098794 File Offset: 0x00096994
		public unsafe XmlSchemaObjectTable SchemaTypes
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 426124, RefRangeEnd = 426159, XrefRangeStart = 426120, XrefRangeEnd = 426124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_SchemaTypes_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x000987D4 File Offset: 0x000969D4
		public unsafe XmlSchemaObjectTable Elements
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 426163, RefRangeEnd = 426183, XrefRangeStart = 426159, XrefRangeEnd = 426163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Elements_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x00098814 File Offset: 0x00096A14
		// (set) Token: 0x06002019 RID: 8217 RVA: 0x0009884C File Offset: 0x00096A4C
		public unsafe string Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14893, RefRangeEnd = 14909, XrefRangeStart = 14893, XrefRangeEnd = 14909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x00098890 File Offset: 0x00096A90
		public unsafe XmlSchemaObjectTable Groups
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Groups_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x0600201B RID: 8219 RVA: 0x000988D0 File Offset: 0x00096AD0
		public unsafe XmlSchemaObjectTable Notations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Notations_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x00098910 File Offset: 0x00096B10
		public unsafe XmlSchemaObjectTable IdentityConstraints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_IdentityConstraints_Internal_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x0600201D RID: 8221 RVA: 0x00098950 File Offset: 0x00096B50
		// (set) Token: 0x0600201E RID: 8222 RVA: 0x00098990 File Offset: 0x00096B90
		public unsafe Uri BaseUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_BaseUri_Internal_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 386310, RefRangeEnd = 386323, XrefRangeStart = 386310, XrefRangeEnd = 386323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_BaseUri_Internal_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x0600201F RID: 8223 RVA: 0x000989D4 File Offset: 0x00096BD4
		public unsafe int SchemaId
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 426187, RefRangeEnd = 426201, XrefRangeStart = 426183, XrefRangeEnd = 426187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_SchemaId_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x00098A10 File Offset: 0x00096C10
		// (set) Token: 0x06002021 RID: 8225 RVA: 0x00098A4C File Offset: 0x00096C4C
		public unsafe bool IsChameleon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_IsChameleon_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_IsChameleon_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x00098A8C File Offset: 0x00096C8C
		public unsafe Hashtable Ids
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Ids_Internal_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002023 RID: 8227 RVA: 0x00098ACC File Offset: 0x00096CCC
		public unsafe XmlDocument Document
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426201, XrefRangeEnd = 426205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Document_Internal_get_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x00098B0C File Offset: 0x00096D0C
		// (set) Token: 0x06002025 RID: 8229 RVA: 0x00098B48 File Offset: 0x00096D48
		public unsafe int ErrorCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_ErrorCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_ErrorCount_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x00098B88 File Offset: 0x00096D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 426211, RefRangeEnd = 426212, XrefRangeStart = 426205, XrefRangeEnd = 426211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe XmlSchema Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_Clone_Internal_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00098BC8 File Offset: 0x00096DC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 426244, RefRangeEnd = 426245, XrefRangeStart = 426212, XrefRangeEnd = 426244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema DeepClone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_DeepClone_Internal_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x00098C08 File Offset: 0x00096E08
		// (set) Token: 0x06002029 RID: 8233 RVA: 0x00098C4C File Offset: 0x00096E4C
		public unsafe override string IdAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchema.NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14893, RefRangeEnd = 14909, XrefRangeStart = 14893, XrefRangeEnd = 14909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchema.NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x00098C9C File Offset: 0x00096E9C
		[CallerCount(0)]
		public unsafe void SetIsCompiled(bool isCompiled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isCompiled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_SetIsCompiled_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x00098CDC File Offset: 0x00096EDC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 89481, RefRangeEnd = 89490, XrefRangeStart = 89481, XrefRangeEnd = 89490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetUnhandledAttributes(Il2CppReferenceArray<XmlAttribute> moreAttributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(moreAttributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchema.NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00098D2C File Offset: 0x00096F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426245, XrefRangeEnd = 426249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(annotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchema.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x0600202D RID: 8237 RVA: 0x00098D7C File Offset: 0x00096F7C
		public unsafe ArrayList ImportedSchemas
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 426253, RefRangeEnd = 426265, XrefRangeStart = 426249, XrefRangeEnd = 426253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_ImportedSchemas_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x00098DBC File Offset: 0x00096FBC
		public unsafe ArrayList ImportedNamespaces
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 426269, RefRangeEnd = 426278, XrefRangeStart = 426265, XrefRangeEnd = 426269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_ImportedNamespaces_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00098DFC File Offset: 0x00096FFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 426288, RefRangeEnd = 426290, XrefRangeStart = 426278, XrefRangeEnd = 426288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetExternalSchemasList(IList extList, XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_GetExternalSchemasList_Internal_Void_IList_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x0000DED0 File Offset: 0x0000C0D0
		public XmlSchema(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x00098E50 File Offset: 0x00097050
		// (set) Token: 0x06002032 RID: 8242 RVA: 0x0000DED9 File Offset: 0x0000C0D9
		public unsafe XmlSchemaForm attributeFormDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_attributeFormDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_attributeFormDefault)) = value;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x00098E78 File Offset: 0x00097078
		// (set) Token: 0x06002034 RID: 8244 RVA: 0x0000DEF4 File Offset: 0x0000C0F4
		public unsafe XmlSchemaForm elementFormDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_elementFormDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_elementFormDefault)) = value;
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x00098EA0 File Offset: 0x000970A0
		// (set) Token: 0x06002036 RID: 8246 RVA: 0x0000DF0F File Offset: 0x0000C10F
		public unsafe XmlSchemaDerivationMethod blockDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_blockDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_blockDefault)) = value;
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x00098EC8 File Offset: 0x000970C8
		// (set) Token: 0x06002038 RID: 8248 RVA: 0x0000DF2A File Offset: 0x0000C12A
		public unsafe XmlSchemaDerivationMethod finalDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_finalDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_finalDefault)) = value;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x00098EF0 File Offset: 0x000970F0
		// (set) Token: 0x0600203A RID: 8250 RVA: 0x0000DF45 File Offset: 0x0000C145
		public unsafe string targetNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_targetNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_targetNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x00098F18 File Offset: 0x00097118
		// (set) Token: 0x0600203C RID: 8252 RVA: 0x0000DF64 File Offset: 0x0000C164
		public unsafe string version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x0600203D RID: 8253 RVA: 0x00098F40 File Offset: 0x00097140
		// (set) Token: 0x0600203E RID: 8254 RVA: 0x0000DF83 File Offset: 0x0000C183
		public unsafe XmlSchemaObjectCollection includes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_includes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_includes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x0600203F RID: 8255 RVA: 0x00098F70 File Offset: 0x00097170
		// (set) Token: 0x06002040 RID: 8256 RVA: 0x0000DFA2 File Offset: 0x0000C1A2
		public unsafe XmlSchemaObjectCollection items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x00098FA0 File Offset: 0x000971A0
		// (set) Token: 0x06002042 RID: 8258 RVA: 0x0000DFC1 File Offset: 0x0000C1C1
		public unsafe string id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x00098FC8 File Offset: 0x000971C8
		// (set) Token: 0x06002044 RID: 8260 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		public unsafe Il2CppReferenceArray<XmlAttribute> moreAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_moreAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_moreAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x00098FF8 File Offset: 0x000971F8
		// (set) Token: 0x06002046 RID: 8262 RVA: 0x0000DFFF File Offset: 0x0000C1FF
		public unsafe bool isCompiled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isCompiled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isCompiled)) = value;
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x00099020 File Offset: 0x00097220
		// (set) Token: 0x06002048 RID: 8264 RVA: 0x0000E01A File Offset: 0x0000C21A
		public unsafe bool isCompiledBySet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isCompiledBySet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isCompiledBySet)) = value;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x00099048 File Offset: 0x00097248
		// (set) Token: 0x0600204A RID: 8266 RVA: 0x0000E035 File Offset: 0x0000C235
		public unsafe bool isPreprocessed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isPreprocessed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isPreprocessed)) = value;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x00099070 File Offset: 0x00097270
		// (set) Token: 0x0600204C RID: 8268 RVA: 0x0000E050 File Offset: 0x0000C250
		public unsafe bool isRedefined
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isRedefined);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isRedefined)) = value;
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x00099098 File Offset: 0x00097298
		// (set) Token: 0x0600204E RID: 8270 RVA: 0x0000E06B File Offset: 0x0000C26B
		public unsafe int errorCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_errorCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_errorCount)) = value;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x000990C0 File Offset: 0x000972C0
		// (set) Token: 0x06002050 RID: 8272 RVA: 0x0000E086 File Offset: 0x0000C286
		public unsafe XmlSchemaObjectTable attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x000990F0 File Offset: 0x000972F0
		// (set) Token: 0x06002052 RID: 8274 RVA: 0x0000E0A5 File Offset: 0x0000C2A5
		public unsafe XmlSchemaObjectTable attributeGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_attributeGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_attributeGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x00099120 File Offset: 0x00097320
		// (set) Token: 0x06002054 RID: 8276 RVA: 0x0000E0C4 File Offset: 0x0000C2C4
		public unsafe XmlSchemaObjectTable elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x00099150 File Offset: 0x00097350
		// (set) Token: 0x06002056 RID: 8278 RVA: 0x0000E0E3 File Offset: 0x0000C2E3
		public unsafe XmlSchemaObjectTable types
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_types);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_types), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x00099180 File Offset: 0x00097380
		// (set) Token: 0x06002058 RID: 8280 RVA: 0x0000E102 File Offset: 0x0000C302
		public unsafe XmlSchemaObjectTable groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x000991B0 File Offset: 0x000973B0
		// (set) Token: 0x0600205A RID: 8282 RVA: 0x0000E121 File Offset: 0x0000C321
		public unsafe XmlSchemaObjectTable notations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_notations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_notations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x000991E0 File Offset: 0x000973E0
		// (set) Token: 0x0600205C RID: 8284 RVA: 0x0000E140 File Offset: 0x0000C340
		public unsafe XmlSchemaObjectTable identityConstraints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_identityConstraints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_identityConstraints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x00099210 File Offset: 0x00097410
		// (set) Token: 0x0600205E RID: 8286 RVA: 0x0000E15F File Offset: 0x0000C35F
		public unsafe static int globalIdCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XmlSchema.NativeFieldInfoPtr_globalIdCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchema.NativeFieldInfoPtr_globalIdCounter, (void*)(&value));
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x0009922C File Offset: 0x0009742C
		// (set) Token: 0x06002060 RID: 8288 RVA: 0x0000E16D File Offset: 0x0000C36D
		public unsafe ArrayList importedSchemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_importedSchemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_importedSchemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x0009925C File Offset: 0x0009745C
		// (set) Token: 0x06002062 RID: 8290 RVA: 0x0000E18C File Offset: 0x0000C38C
		public unsafe ArrayList importedNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_importedNamespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_importedNamespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x0009928C File Offset: 0x0009748C
		// (set) Token: 0x06002064 RID: 8292 RVA: 0x0000E1AB File Offset: 0x0000C3AB
		public unsafe int schemaId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_schemaId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_schemaId)) = value;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x000992B4 File Offset: 0x000974B4
		// (set) Token: 0x06002066 RID: 8294 RVA: 0x0000E1C6 File Offset: 0x0000C3C6
		public unsafe Uri baseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_baseUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_baseUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x000992E4 File Offset: 0x000974E4
		// (set) Token: 0x06002068 RID: 8296 RVA: 0x0000E1E5 File Offset: 0x0000C3E5
		public unsafe bool isChameleon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isChameleon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isChameleon)) = value;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x0009930C File Offset: 0x0009750C
		// (set) Token: 0x0600206A RID: 8298 RVA: 0x0000E200 File Offset: 0x0000C400
		public unsafe Hashtable ids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_ids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_ids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x0009933C File Offset: 0x0009753C
		// (set) Token: 0x0600206C RID: 8300 RVA: 0x0000E21F File Offset: 0x0000C41F
		public unsafe XmlDocument document
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_document);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_document), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeFieldInfoPtr_attributeFormDefault;

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeFieldInfoPtr_elementFormDefault;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeFieldInfoPtr_blockDefault;

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeFieldInfoPtr_finalDefault;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeFieldInfoPtr_targetNs;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeFieldInfoPtr_includes;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeFieldInfoPtr_moreAttributes;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeFieldInfoPtr_isCompiled;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeFieldInfoPtr_isCompiledBySet;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeFieldInfoPtr_isPreprocessed;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeFieldInfoPtr_isRedefined;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeFieldInfoPtr_errorCount;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeFieldInfoPtr_attributeGroups;

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeFieldInfoPtr_types;

		// Token: 0x040017D6 RID: 6102
		private static readonly IntPtr NativeFieldInfoPtr_groups;

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeFieldInfoPtr_notations;

		// Token: 0x040017D8 RID: 6104
		private static readonly IntPtr NativeFieldInfoPtr_identityConstraints;

		// Token: 0x040017D9 RID: 6105
		private static readonly IntPtr NativeFieldInfoPtr_globalIdCounter;

		// Token: 0x040017DA RID: 6106
		private static readonly IntPtr NativeFieldInfoPtr_importedSchemas;

		// Token: 0x040017DB RID: 6107
		private static readonly IntPtr NativeFieldInfoPtr_importedNamespaces;

		// Token: 0x040017DC RID: 6108
		private static readonly IntPtr NativeFieldInfoPtr_schemaId;

		// Token: 0x040017DD RID: 6109
		private static readonly IntPtr NativeFieldInfoPtr_baseUri;

		// Token: 0x040017DE RID: 6110
		private static readonly IntPtr NativeFieldInfoPtr_isChameleon;

		// Token: 0x040017DF RID: 6111
		private static readonly IntPtr NativeFieldInfoPtr_ids;

		// Token: 0x040017E0 RID: 6112
		private static readonly IntPtr NativeFieldInfoPtr_document;

		// Token: 0x040017E1 RID: 6113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040017E2 RID: 6114
		private static readonly IntPtr NativeMethodInfoPtr_CompileSchema_Internal_Boolean_XmlSchemaCollection_XmlResolver_SchemaInfo_String_ValidationEventHandler_XmlNameTable_Boolean_0;

		// Token: 0x040017E3 RID: 6115
		private static readonly IntPtr NativeMethodInfoPtr_CompileSchemaInSet_Internal_Void_XmlNameTable_ValidationEventHandler_XmlSchemaCompilationSettings_0;

		// Token: 0x040017E4 RID: 6116
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeFormDefault_Public_get_XmlSchemaForm_0;

		// Token: 0x040017E5 RID: 6117
		private static readonly IntPtr NativeMethodInfoPtr_set_AttributeFormDefault_Public_set_Void_XmlSchemaForm_0;

		// Token: 0x040017E6 RID: 6118
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockDefault_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x040017E7 RID: 6119
		private static readonly IntPtr NativeMethodInfoPtr_set_BlockDefault_Public_set_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x040017E8 RID: 6120
		private static readonly IntPtr NativeMethodInfoPtr_get_FinalDefault_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x040017E9 RID: 6121
		private static readonly IntPtr NativeMethodInfoPtr_set_FinalDefault_Public_set_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x040017EA RID: 6122
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementFormDefault_Public_get_XmlSchemaForm_0;

		// Token: 0x040017EB RID: 6123
		private static readonly IntPtr NativeMethodInfoPtr_set_ElementFormDefault_Public_set_Void_XmlSchemaForm_0;

		// Token: 0x040017EC RID: 6124
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetNamespace_Public_get_String_0;

		// Token: 0x040017ED RID: 6125
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetNamespace_Public_set_Void_String_0;

		// Token: 0x040017EE RID: 6126
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_String_0;

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Public_set_Void_String_0;

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeMethodInfoPtr_get_Includes_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompiledBySet_Internal_get_Boolean_0;

		// Token: 0x040017F3 RID: 6131
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCompiledBySet_Internal_set_Void_Boolean_0;

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPreprocessed_Internal_get_Boolean_0;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPreprocessed_Internal_set_Void_Boolean_0;

		// Token: 0x040017F6 RID: 6134
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRedefined_Internal_get_Boolean_0;

		// Token: 0x040017F7 RID: 6135
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRedefined_Internal_set_Void_Boolean_0;

		// Token: 0x040017F8 RID: 6136
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x040017F9 RID: 6137
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeGroups_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x040017FA RID: 6138
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaTypes_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x040017FB RID: 6139
		private static readonly IntPtr NativeMethodInfoPtr_get_Elements_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x040017FC RID: 6140
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

		// Token: 0x040017FD RID: 6141
		private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_String_0;

		// Token: 0x040017FE RID: 6142
		private static readonly IntPtr NativeMethodInfoPtr_get_Groups_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x040017FF RID: 6143
		private static readonly IntPtr NativeMethodInfoPtr_get_Notations_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeMethodInfoPtr_get_IdentityConstraints_Internal_get_XmlSchemaObjectTable_0;

		// Token: 0x04001801 RID: 6145
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUri_Internal_get_Uri_0;

		// Token: 0x04001802 RID: 6146
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseUri_Internal_set_Void_Uri_0;

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaId_Internal_get_Int32_0;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeMethodInfoPtr_get_IsChameleon_Internal_get_Boolean_0;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeMethodInfoPtr_set_IsChameleon_Internal_set_Void_Boolean_0;

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeMethodInfoPtr_get_Ids_Internal_get_Hashtable_0;

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeMethodInfoPtr_get_Document_Internal_get_XmlDocument_0;

		// Token: 0x04001808 RID: 6152
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorCount_Internal_get_Int32_0;

		// Token: 0x04001809 RID: 6153
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorCount_Internal_set_Void_Int32_0;

		// Token: 0x0400180A RID: 6154
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_XmlSchema_0;

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Internal_XmlSchema_0;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_get_String_0;

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_set_Void_String_0;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeMethodInfoPtr_SetIsCompiled_Internal_Void_Boolean_0;

		// Token: 0x0400180F RID: 6159
		private static readonly IntPtr NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlAttribute_0;

		// Token: 0x04001810 RID: 6160
		private static readonly IntPtr NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0;

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeMethodInfoPtr_get_ImportedSchemas_Internal_get_ArrayList_0;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeMethodInfoPtr_get_ImportedNamespaces_Internal_get_ArrayList_0;

		// Token: 0x04001813 RID: 6163
		private static readonly IntPtr NativeMethodInfoPtr_GetExternalSchemasList_Internal_Void_IList_XmlSchema_0;
	}
}
