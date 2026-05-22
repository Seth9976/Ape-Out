using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000171 RID: 369
	public sealed class Preprocessor : BaseProcessor
	{
		// Token: 0x06001B21 RID: 6945 RVA: 0x00085500 File Offset: 0x00083700
		// Note: this type is marked as 'beforefieldinit'.
		static Preprocessor()
		{
			Il2CppClassPointerStore<Preprocessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Preprocessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr);
			Preprocessor.NativeFieldInfoPtr_Xmlns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "Xmlns");
			Preprocessor.NativeFieldInfoPtr_NsXsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "NsXsi");
			Preprocessor.NativeFieldInfoPtr_targetNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "targetNamespace");
			Preprocessor.NativeFieldInfoPtr_rootSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "rootSchema");
			Preprocessor.NativeFieldInfoPtr_currentSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "currentSchema");
			Preprocessor.NativeFieldInfoPtr_elementFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "elementFormDefault");
			Preprocessor.NativeFieldInfoPtr_attributeFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "attributeFormDefault");
			Preprocessor.NativeFieldInfoPtr_blockDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "blockDefault");
			Preprocessor.NativeFieldInfoPtr_finalDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "finalDefault");
			Preprocessor.NativeFieldInfoPtr_schemaLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "schemaLocations");
			Preprocessor.NativeFieldInfoPtr_chameleonSchemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "chameleonSchemas");
			Preprocessor.NativeFieldInfoPtr_referenceNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "referenceNamespaces");
			Preprocessor.NativeFieldInfoPtr_processedExternals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "processedExternals");
			Preprocessor.NativeFieldInfoPtr_lockList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "lockList");
			Preprocessor.NativeFieldInfoPtr_readerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "readerSettings");
			Preprocessor.NativeFieldInfoPtr_rootSchemaForRedefine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "rootSchemaForRedefine");
			Preprocessor.NativeFieldInfoPtr_redefinedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "redefinedList");
			Preprocessor.NativeFieldInfoPtr_builtInSchemaForXmlNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "builtInSchemaForXmlNS");
			Preprocessor.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "xmlResolver");
			Preprocessor.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_XmlSchemaCompilationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667294);
			Preprocessor.NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667295);
			Preprocessor.NativeMethodInfoPtr_Cleanup_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667296);
			Preprocessor.NativeMethodInfoPtr_CleanupRedefine_Private_Void_XmlSchemaExternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667297);
			Preprocessor.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667298);
			Preprocessor.NativeMethodInfoPtr_set_ReaderSettings_Internal_set_Void_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667299);
			Preprocessor.NativeMethodInfoPtr_set_SchemaLocations_Internal_set_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667300);
			Preprocessor.NativeMethodInfoPtr_set_ChameleonSchemas_Internal_set_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667301);
			Preprocessor.NativeMethodInfoPtr_get_RootSchema_Internal_get_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667302);
			Preprocessor.NativeMethodInfoPtr_BuildSchemaList_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667303);
			Preprocessor.NativeMethodInfoPtr_LoadExternals_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667304);
			Preprocessor.NativeMethodInfoPtr_GetBuildInSchema_Internal_Static_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667305);
			Preprocessor.NativeMethodInfoPtr_BuildRefNamespaces_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667306);
			Preprocessor.NativeMethodInfoPtr_ParseUri_Private_Void_String_String_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667307);
			Preprocessor.NativeMethodInfoPtr_Preprocess_Private_Void_XmlSchema_String_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667308);
			Preprocessor.NativeMethodInfoPtr_CopyIncludedComponents_Private_Void_XmlSchema_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667309);
			Preprocessor.NativeMethodInfoPtr_PreprocessRedefine_Private_Void_RedefineEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667310);
			Preprocessor.NativeMethodInfoPtr_GetIncludedSet_Private_Void_XmlSchema_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667311);
			Preprocessor.NativeMethodInfoPtr_GetParentSchema_Internal_Static_XmlSchema_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667312);
			Preprocessor.NativeMethodInfoPtr_SetSchemaDefaults_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667313);
			Preprocessor.NativeMethodInfoPtr_CountGroupSelfReference_Private_Int32_XmlSchemaObjectCollection_XmlQualifiedName_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667314);
			Preprocessor.NativeMethodInfoPtr_CheckRefinedGroup_Private_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667315);
			Preprocessor.NativeMethodInfoPtr_CheckRefinedAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667316);
			Preprocessor.NativeMethodInfoPtr_CheckRefinedSimpleType_Private_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667317);
			Preprocessor.NativeMethodInfoPtr_CheckRefinedComplexType_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667318);
			Preprocessor.NativeMethodInfoPtr_PreprocessAttribute_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667319);
			Preprocessor.NativeMethodInfoPtr_PreprocessLocalAttribute_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667320);
			Preprocessor.NativeMethodInfoPtr_PreprocessAttributeContent_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667321);
			Preprocessor.NativeMethodInfoPtr_PreprocessAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667322);
			Preprocessor.NativeMethodInfoPtr_PreprocessElement_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667323);
			Preprocessor.NativeMethodInfoPtr_PreprocessLocalElement_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667324);
			Preprocessor.NativeMethodInfoPtr_PreprocessElementContent_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667325);
			Preprocessor.NativeMethodInfoPtr_PreprocessIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667326);
			Preprocessor.NativeMethodInfoPtr_PreprocessSimpleType_Private_Void_XmlSchemaSimpleType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667327);
			Preprocessor.NativeMethodInfoPtr_PreprocessComplexType_Private_Void_XmlSchemaComplexType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667328);
			Preprocessor.NativeMethodInfoPtr_PreprocessGroup_Private_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667329);
			Preprocessor.NativeMethodInfoPtr_PreprocessNotation_Private_Void_XmlSchemaNotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667330);
			Preprocessor.NativeMethodInfoPtr_PreprocessParticle_Private_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667331);
			Preprocessor.NativeMethodInfoPtr_PreprocessAttributes_Private_Void_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667332);
			Preprocessor.NativeMethodInfoPtr_ValidateIdAttribute_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667333);
			Preprocessor.NativeMethodInfoPtr_ValidateNameAttribute_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667334);
			Preprocessor.NativeMethodInfoPtr_ValidateQNameAttribute_Private_Void_XmlSchemaObject_String_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667335);
			Preprocessor.NativeMethodInfoPtr_ResolveSchemaLocationUri_Private_Uri_XmlSchema_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667336);
			Preprocessor.NativeMethodInfoPtr_GetSchemaEntity_Private_Object_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667337);
			Preprocessor.NativeMethodInfoPtr_GetChameleonSchema_Private_XmlSchema_String_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667338);
			Preprocessor.NativeMethodInfoPtr_SetParent_Private_Void_XmlSchemaObject_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667339);
			Preprocessor.NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667340);
			Preprocessor.NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaAnnotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667341);
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x00085A6C File Offset: 0x00083C6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 413683, RefRangeEnd = 413684, XrefRangeStart = 413671, XrefRangeEnd = 413683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Preprocessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compilationSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_XmlSchemaCompilationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x00085AF0 File Offset: 0x00083CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 413719, RefRangeEnd = 413720, XrefRangeStart = 413684, XrefRangeEnd = 413719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadExternals;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x00085B60 File Offset: 0x00083D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413720, XrefRangeEnd = 413732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_Cleanup_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x00085BA4 File Offset: 0x00083DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413732, XrefRangeEnd = 413738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupRedefine(XmlSchemaExternal include)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(include);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_CleanupRedefine_Private_Void_XmlSchemaExternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700095A RID: 2394
		// (set) Token: 0x06001B26 RID: 6950 RVA: 0x00085BE8 File Offset: 0x00083DE8
		public unsafe XmlResolver XmlResolver
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700095B RID: 2395
		// (set) Token: 0x06001B27 RID: 6951 RVA: 0x00085C2C File Offset: 0x00083E2C
		public unsafe XmlReaderSettings ReaderSettings
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 413738, RefRangeEnd = 413741, XrefRangeStart = 413738, XrefRangeEnd = 413738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_set_ReaderSettings_Internal_set_Void_XmlReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700095C RID: 2396
		// (set) Token: 0x06001B28 RID: 6952 RVA: 0x00085C70 File Offset: 0x00083E70
		public unsafe Hashtable SchemaLocations
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_set_SchemaLocations_Internal_set_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700095D RID: 2397
		// (set) Token: 0x06001B29 RID: 6953 RVA: 0x00085CB4 File Offset: 0x00083EB4
		public unsafe Hashtable ChameleonSchemas
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 382561, RefRangeEnd = 382571, XrefRangeStart = 382561, XrefRangeEnd = 382571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_set_ChameleonSchemas_Internal_set_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001B2A RID: 6954 RVA: 0x00085CF8 File Offset: 0x00083EF8
		public unsafe XmlSchema RootSchema
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_get_RootSchema_Internal_get_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
			}
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x00085D38 File Offset: 0x00083F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 413753, RefRangeEnd = 413755, XrefRangeStart = 413741, XrefRangeEnd = 413753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildSchemaList(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_BuildSchemaList_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x00085D7C File Offset: 0x00083F7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 413880, RefRangeEnd = 413883, XrefRangeStart = 413755, XrefRangeEnd = 413880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadExternals(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_LoadExternals_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x00085DC0 File Offset: 0x00083FC0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 414044, RefRangeEnd = 414055, XrefRangeStart = 413883, XrefRangeEnd = 414044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchema GetBuildInSchema()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_GetBuildInSchema_Internal_Static_XmlSchema_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x00085DF4 File Offset: 0x00083FF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 414066, RefRangeEnd = 414067, XrefRangeStart = 414055, XrefRangeEnd = 414066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildRefNamespaces(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_BuildRefNamespaces_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x00085E38 File Offset: 0x00084038
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 414077, RefRangeEnd = 414081, XrefRangeStart = 414067, XrefRangeEnd = 414077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceSchemaObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_ParseUri_Private_Void_String_String_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x00085EA0 File Offset: 0x000840A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 414311, RefRangeEnd = 414314, XrefRangeStart = 414081, XrefRangeEnd = 414311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(imports);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_Preprocess_Private_Void_XmlSchema_String_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x00085F08 File Offset: 0x00084108
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 414450, RefRangeEnd = 414451, XrefRangeStart = 414314, XrefRangeEnd = 414450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(includedSchema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_CopyIncludedComponents_Private_Void_XmlSchema_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x00085F5C File Offset: 0x0008415C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 414689, RefRangeEnd = 414690, XrefRangeStart = 414451, XrefRangeEnd = 414689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessRedefine(RedefineEntry redefineEntry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(redefineEntry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessRedefine_Private_Void_RedefineEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x00085FA0 File Offset: 0x000841A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 414695, RefRangeEnd = 414697, XrefRangeStart = 414690, XrefRangeEnd = 414695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIncludedSet(XmlSchema schema, ArrayList includesList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(includesList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_GetIncludedSet_Private_Void_XmlSchema_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x00085FF4 File Offset: 0x000841F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 414699, RefRangeEnd = 414700, XrefRangeStart = 414697, XrefRangeEnd = 414699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentSchemaObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_GetParentSchema_Internal_Static_XmlSchema_XmlSchemaObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
			}
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x00086038 File Offset: 0x00084238
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 414710, RefRangeEnd = 414712, XrefRangeStart = 414700, XrefRangeEnd = 414710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSchemaDefaults(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_SetSchemaDefaults_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x0008607C File Offset: 0x0008427C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 414750, RefRangeEnd = 414753, XrefRangeStart = 414712, XrefRangeEnd = 414750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(redefined);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_CountGroupSelfReference_Private_Int32_XmlSchemaObjectCollection_XmlQualifiedName_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x000860F0 File Offset: 0x000842F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414753, XrefRangeEnd = 414757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRefinedGroup(XmlSchemaGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_CheckRefinedGroup_Private_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x00086134 File Offset: 0x00084334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414757, XrefRangeEnd = 414768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_CheckRefinedAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x00086178 File Offset: 0x00084378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 414777, RefRangeEnd = 414778, XrefRangeStart = 414768, XrefRangeEnd = 414777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRefinedSimpleType(XmlSchemaSimpleType stype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_CheckRefinedSimpleType_Private_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x000861BC File Offset: 0x000843BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 414802, RefRangeEnd = 414803, XrefRangeStart = 414778, XrefRangeEnd = 414802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRefinedComplexType(XmlSchemaComplexType ctype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_CheckRefinedComplexType_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00086200 File Offset: 0x00084400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 414826, RefRangeEnd = 414827, XrefRangeStart = 414803, XrefRangeEnd = 414826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAttribute(XmlSchemaAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessAttribute_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x00086244 File Offset: 0x00084444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414827, XrefRangeEnd = 414850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessLocalAttribute(XmlSchemaAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessLocalAttribute_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00086288 File Offset: 0x00084488
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 414875, RefRangeEnd = 414878, XrefRangeStart = 414850, XrefRangeEnd = 414875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAttributeContent(XmlSchemaAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessAttributeContent_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x000862CC File Offset: 0x000844CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 414893, RefRangeEnd = 414894, XrefRangeStart = 414878, XrefRangeEnd = 414893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00086310 File Offset: 0x00084510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 414931, RefRangeEnd = 414932, XrefRangeStart = 414894, XrefRangeEnd = 414931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessElement(XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessElement_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00086354 File Offset: 0x00084554
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 414986, RefRangeEnd = 414989, XrefRangeStart = 414932, XrefRangeEnd = 414986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessLocalElement(XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessLocalElement_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00086398 File Offset: 0x00084598
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 415151, RefRangeEnd = 415153, XrefRangeStart = 414989, XrefRangeEnd = 415151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessElementContent(XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessElementContent_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x000863DC File Offset: 0x000845DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415153, XrefRangeEnd = 415183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00086420 File Offset: 0x00084620
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 415327, RefRangeEnd = 415335, XrefRangeStart = 415183, XrefRangeEnd = 415327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(simpleType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref local;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessSimpleType_Private_Void_XmlSchemaSimpleType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00086470 File Offset: 0x00084670
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 415456, RefRangeEnd = 415459, XrefRangeStart = 415335, XrefRangeEnd = 415456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessComplexType(XmlSchemaComplexType complexType, bool local)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref local;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessComplexType_Private_Void_XmlSchemaComplexType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x000864C0 File Offset: 0x000846C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 415488, RefRangeEnd = 415490, XrefRangeStart = 415459, XrefRangeEnd = 415488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessGroup(XmlSchemaGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessGroup_Private_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00086504 File Offset: 0x00084704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415524, RefRangeEnd = 415525, XrefRangeStart = 415490, XrefRangeEnd = 415524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessNotation(XmlSchemaNotation notation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessNotation_Private_Void_XmlSchemaNotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00086548 File Offset: 0x00084748
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 415670, RefRangeEnd = 415675, XrefRangeStart = 415525, XrefRangeEnd = 415670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessParticle(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessParticle_Private_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x0008658C File Offset: 0x0008478C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 415778, RefRangeEnd = 415784, XrefRangeStart = 415675, XrefRangeEnd = 415778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(anyAttribute);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessAttributes_Private_Void_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x000865F4 File Offset: 0x000847F4
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 415791, RefRangeEnd = 415821, XrefRangeStart = 415784, XrefRangeEnd = 415791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateIdAttribute(XmlSchemaObject xso)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xso);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_ValidateIdAttribute_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x00086638 File Offset: 0x00084838
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 415834, RefRangeEnd = 415844, XrefRangeStart = 415821, XrefRangeEnd = 415834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateNameAttribute(XmlSchemaObject xso)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xso);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_ValidateNameAttribute_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x0008667C File Offset: 0x0008487C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 415859, RefRangeEnd = 415875, XrefRangeStart = 415844, XrefRangeEnd = 415859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xso);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_ValidateQNameAttribute_Private_Void_XmlSchemaObject_String_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x000866E4 File Offset: 0x000848E4
		[CallerCount(0)]
		public unsafe Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enclosingSchema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(location);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_ResolveSchemaLocationUri_Private_Uri_XmlSchema_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00086748 File Offset: 0x00084948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415875, RefRangeEnd = 415876, XrefRangeStart = 415875, XrefRangeEnd = 415875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetSchemaEntity(Uri ruri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ruri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_GetSchemaEntity_Private_Object_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x00086798 File Offset: 0x00084998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 415884, RefRangeEnd = 415886, XrefRangeStart = 415876, XrefRangeEnd = 415884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_GetChameleonSchema_Private_XmlSchema_String_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x000867FC File Offset: 0x000849FC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 415886, RefRangeEnd = 415892, XrefRangeStart = 415886, XrefRangeEnd = 415886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParent(XmlSchemaObject child, XmlSchemaObject parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_SetParent_Private_Void_XmlSchemaObject_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x00086850 File Offset: 0x00084A50
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 415896, RefRangeEnd = 415908, XrefRangeStart = 415892, XrefRangeEnd = 415896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAnnotation(XmlSchemaObject schemaObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x00086894 File Offset: 0x00084A94
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 415911, RefRangeEnd = 415922, XrefRangeStart = 415908, XrefRangeEnd = 415911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAnnotation(XmlSchemaAnnotation annotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(annotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaAnnotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0000B859 File Offset: 0x00009A59
		public Preprocessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x000868D8 File Offset: 0x00084AD8
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x0000B862 File Offset: 0x00009A62
		public unsafe string Xmlns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_Xmlns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_Xmlns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x00086900 File Offset: 0x00084B00
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x0000B881 File Offset: 0x00009A81
		public unsafe string NsXsi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_NsXsi);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_NsXsi), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x00086928 File Offset: 0x00084B28
		// (set) Token: 0x06001B58 RID: 7000 RVA: 0x0000B8A0 File Offset: 0x00009AA0
		public unsafe string targetNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_targetNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_targetNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x00086950 File Offset: 0x00084B50
		// (set) Token: 0x06001B5A RID: 7002 RVA: 0x0000B8BF File Offset: 0x00009ABF
		public unsafe XmlSchema rootSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_rootSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_rootSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00086980 File Offset: 0x00084B80
		// (set) Token: 0x06001B5C RID: 7004 RVA: 0x0000B8DE File Offset: 0x00009ADE
		public unsafe XmlSchema currentSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_currentSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_currentSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x000869B0 File Offset: 0x00084BB0
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x0000B8FD File Offset: 0x00009AFD
		public unsafe XmlSchemaForm elementFormDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_elementFormDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_elementFormDefault)) = value;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x000869D8 File Offset: 0x00084BD8
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x0000B918 File Offset: 0x00009B18
		public unsafe XmlSchemaForm attributeFormDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_attributeFormDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_attributeFormDefault)) = value;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x00086A00 File Offset: 0x00084C00
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x0000B933 File Offset: 0x00009B33
		public unsafe XmlSchemaDerivationMethod blockDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_blockDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_blockDefault)) = value;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x00086A28 File Offset: 0x00084C28
		// (set) Token: 0x06001B64 RID: 7012 RVA: 0x0000B94E File Offset: 0x00009B4E
		public unsafe XmlSchemaDerivationMethod finalDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_finalDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_finalDefault)) = value;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x00086A50 File Offset: 0x00084C50
		// (set) Token: 0x06001B66 RID: 7014 RVA: 0x0000B969 File Offset: 0x00009B69
		public unsafe Hashtable schemaLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_schemaLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_schemaLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x00086A80 File Offset: 0x00084C80
		// (set) Token: 0x06001B68 RID: 7016 RVA: 0x0000B988 File Offset: 0x00009B88
		public unsafe Hashtable chameleonSchemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_chameleonSchemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_chameleonSchemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x00086AB0 File Offset: 0x00084CB0
		// (set) Token: 0x06001B6A RID: 7018 RVA: 0x0000B9A7 File Offset: 0x00009BA7
		public unsafe Hashtable referenceNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_referenceNamespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_referenceNamespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x00086AE0 File Offset: 0x00084CE0
		// (set) Token: 0x06001B6C RID: 7020 RVA: 0x0000B9C6 File Offset: 0x00009BC6
		public unsafe Hashtable processedExternals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_processedExternals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_processedExternals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x00086B10 File Offset: 0x00084D10
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x0000B9E5 File Offset: 0x00009BE5
		public unsafe SortedList lockList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_lockList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_lockList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x00086B40 File Offset: 0x00084D40
		// (set) Token: 0x06001B70 RID: 7024 RVA: 0x0000BA04 File Offset: 0x00009C04
		public unsafe XmlReaderSettings readerSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_readerSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_readerSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x00086B70 File Offset: 0x00084D70
		// (set) Token: 0x06001B72 RID: 7026 RVA: 0x0000BA23 File Offset: 0x00009C23
		public unsafe XmlSchema rootSchemaForRedefine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_rootSchemaForRedefine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_rootSchemaForRedefine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x00086BA0 File Offset: 0x00084DA0
		// (set) Token: 0x06001B74 RID: 7028 RVA: 0x0000BA42 File Offset: 0x00009C42
		public unsafe ArrayList redefinedList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_redefinedList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_redefinedList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x00086BD0 File Offset: 0x00084DD0
		// (set) Token: 0x06001B76 RID: 7030 RVA: 0x0000BA61 File Offset: 0x00009C61
		public unsafe static XmlSchema builtInSchemaForXmlNS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Preprocessor.NativeFieldInfoPtr_builtInSchemaForXmlNS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Preprocessor.NativeFieldInfoPtr_builtInSchemaForXmlNS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x00086BF8 File Offset: 0x00084DF8
		// (set) Token: 0x06001B78 RID: 7032 RVA: 0x0000BA73 File Offset: 0x00009C73
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeFieldInfoPtr_Xmlns;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeFieldInfoPtr_NsXsi;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeFieldInfoPtr_targetNamespace;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeFieldInfoPtr_rootSchema;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeFieldInfoPtr_currentSchema;

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeFieldInfoPtr_elementFormDefault;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeFieldInfoPtr_attributeFormDefault;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeFieldInfoPtr_blockDefault;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeFieldInfoPtr_finalDefault;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeFieldInfoPtr_schemaLocations;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeFieldInfoPtr_chameleonSchemas;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeFieldInfoPtr_referenceNamespaces;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeFieldInfoPtr_processedExternals;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeFieldInfoPtr_lockList;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeFieldInfoPtr_readerSettings;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeFieldInfoPtr_rootSchemaForRedefine;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeFieldInfoPtr_redefinedList;

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeFieldInfoPtr_builtInSchemaForXmlNS;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_XmlSchemaCompilationSettings_0;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_String_Boolean_0;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_XmlSchema_0;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeMethodInfoPtr_CleanupRedefine_Private_Void_XmlSchemaExternal_0;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeMethodInfoPtr_set_ReaderSettings_Internal_set_Void_XmlReaderSettings_0;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaLocations_Internal_set_Void_Hashtable_0;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeMethodInfoPtr_set_ChameleonSchemas_Internal_set_Void_Hashtable_0;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeMethodInfoPtr_get_RootSchema_Internal_get_XmlSchema_0;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeMethodInfoPtr_BuildSchemaList_Private_Void_XmlSchema_0;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeMethodInfoPtr_LoadExternals_Private_Void_XmlSchema_0;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeMethodInfoPtr_GetBuildInSchema_Internal_Static_XmlSchema_0;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeMethodInfoPtr_BuildRefNamespaces_Private_Void_XmlSchema_0;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeMethodInfoPtr_ParseUri_Private_Void_String_String_XmlSchemaObject_0;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeMethodInfoPtr_Preprocess_Private_Void_XmlSchema_String_ArrayList_0;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeMethodInfoPtr_CopyIncludedComponents_Private_Void_XmlSchema_XmlSchema_0;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessRedefine_Private_Void_RedefineEntry_0;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeMethodInfoPtr_GetIncludedSet_Private_Void_XmlSchema_ArrayList_0;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeMethodInfoPtr_GetParentSchema_Internal_Static_XmlSchema_XmlSchemaObject_0;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeMethodInfoPtr_SetSchemaDefaults_Private_Void_XmlSchema_0;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeMethodInfoPtr_CountGroupSelfReference_Private_Int32_XmlSchemaObjectCollection_XmlQualifiedName_XmlSchemaGroup_0;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeMethodInfoPtr_CheckRefinedGroup_Private_Void_XmlSchemaGroup_0;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeMethodInfoPtr_CheckRefinedAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeMethodInfoPtr_CheckRefinedSimpleType_Private_Void_XmlSchemaSimpleType_0;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeMethodInfoPtr_CheckRefinedComplexType_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAttribute_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessLocalAttribute_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAttributeContent_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessElement_Private_Void_XmlSchemaElement_0;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessLocalElement_Private_Void_XmlSchemaElement_0;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessElementContent_Private_Void_XmlSchemaElement_0;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessSimpleType_Private_Void_XmlSchemaSimpleType_Boolean_0;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessComplexType_Private_Void_XmlSchemaComplexType_Boolean_0;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessGroup_Private_Void_XmlSchemaGroup_0;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessNotation_Private_Void_XmlSchemaNotation_0;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessParticle_Private_Void_XmlSchemaParticle_0;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAttributes_Private_Void_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaObject_0;

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeMethodInfoPtr_ValidateIdAttribute_Private_Void_XmlSchemaObject_0;

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeMethodInfoPtr_ValidateNameAttribute_Private_Void_XmlSchemaObject_0;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeMethodInfoPtr_ValidateQNameAttribute_Private_Void_XmlSchemaObject_String_XmlQualifiedName_0;

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeMethodInfoPtr_ResolveSchemaLocationUri_Private_Uri_XmlSchema_String_0;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaEntity_Private_Object_Uri_0;

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeMethodInfoPtr_GetChameleonSchema_Private_XmlSchema_String_XmlSchema_0;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Private_Void_XmlSchemaObject_XmlSchemaObject_0;

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaObject_0;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaAnnotation_0;
	}
}
