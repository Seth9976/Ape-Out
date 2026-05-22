using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001C6 RID: 454
	public class XmlSchemaSet : Object
	{
		// Token: 0x06002411 RID: 9233 RVA: 0x000A6EC8 File Offset: 0x000A50C8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSet()
		{
			Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr);
			XmlSchemaSet.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "nameTable");
			XmlSchemaSet.NativeFieldInfoPtr_schemaNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "schemaNames");
			XmlSchemaSet.NativeFieldInfoPtr_schemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "schemas");
			XmlSchemaSet.NativeFieldInfoPtr_internalEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "internalEventHandler");
			XmlSchemaSet.NativeFieldInfoPtr_eventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "eventHandler");
			XmlSchemaSet.NativeFieldInfoPtr_isCompiled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "isCompiled");
			XmlSchemaSet.NativeFieldInfoPtr_schemaLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "schemaLocations");
			XmlSchemaSet.NativeFieldInfoPtr_chameleonSchemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "chameleonSchemas");
			XmlSchemaSet.NativeFieldInfoPtr_targetNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "targetNamespaces");
			XmlSchemaSet.NativeFieldInfoPtr_compileAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "compileAll");
			XmlSchemaSet.NativeFieldInfoPtr_cachedCompiledInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "cachedCompiledInfo");
			XmlSchemaSet.NativeFieldInfoPtr_readerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "readerSettings");
			XmlSchemaSet.NativeFieldInfoPtr_schemaForSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "schemaForSchema");
			XmlSchemaSet.NativeFieldInfoPtr_compilationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "compilationSettings");
			XmlSchemaSet.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "elements");
			XmlSchemaSet.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "attributes");
			XmlSchemaSet.NativeFieldInfoPtr_schemaTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "schemaTypes");
			XmlSchemaSet.NativeFieldInfoPtr_substitutionGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "substitutionGroups");
			XmlSchemaSet.NativeFieldInfoPtr_typeExtensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "typeExtensions");
			XmlSchemaSet.NativeFieldInfoPtr_internalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "internalSyncObject");
			XmlSchemaSet.NativeMethodInfoPtr_get_InternalSyncObject_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668441);
			XmlSchemaSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668442);
			XmlSchemaSet.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668443);
			XmlSchemaSet.NativeMethodInfoPtr_add_ValidationEventHandler_Public_add_Void_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668444);
			XmlSchemaSet.NativeMethodInfoPtr_remove_ValidationEventHandler_Public_rem_Void_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668445);
			XmlSchemaSet.NativeMethodInfoPtr_get_IsCompiled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668446);
			XmlSchemaSet.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668447);
			XmlSchemaSet.NativeMethodInfoPtr_get_CompilationSettings_Public_get_XmlSchemaCompilationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668448);
			XmlSchemaSet.NativeMethodInfoPtr_set_CompilationSettings_Public_set_Void_XmlSchemaCompilationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668449);
			XmlSchemaSet.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668450);
			XmlSchemaSet.NativeMethodInfoPtr_get_GlobalElements_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668451);
			XmlSchemaSet.NativeMethodInfoPtr_get_GlobalAttributes_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668452);
			XmlSchemaSet.NativeMethodInfoPtr_get_GlobalTypes_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668453);
			XmlSchemaSet.NativeMethodInfoPtr_get_SubstitutionGroups_Internal_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668454);
			XmlSchemaSet.NativeMethodInfoPtr_get_SchemaLocations_Internal_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668455);
			XmlSchemaSet.NativeMethodInfoPtr_get_TypeExtensions_Internal_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668456);
			XmlSchemaSet.NativeMethodInfoPtr_Add_Public_Void_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668457);
			XmlSchemaSet.NativeMethodInfoPtr_Add_Public_XmlSchema_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668458);
			XmlSchemaSet.NativeMethodInfoPtr_RemoveRecursive_Public_Boolean_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668459);
			XmlSchemaSet.NativeMethodInfoPtr_Compile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668460);
			XmlSchemaSet.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppReferenceArray_1_XmlSchema_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668461);
			XmlSchemaSet.NativeMethodInfoPtr_Schemas_Public_ICollection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668462);
			XmlSchemaSet.NativeMethodInfoPtr_Add_Private_XmlSchema_String_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668463);
			XmlSchemaSet.NativeMethodInfoPtr_Add_Internal_Void_String_XmlReader_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668464);
			XmlSchemaSet.NativeMethodInfoPtr_FindSchemaByNSAndUrl_Internal_XmlSchema_Uri_String_Il2CppReferenceArray_1_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668465);
			XmlSchemaSet.NativeMethodInfoPtr_AddSchemaToSet_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668466);
			XmlSchemaSet.NativeMethodInfoPtr_ProcessNewSubstitutionGroups_Private_Void_XmlSchemaObjectTable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668467);
			XmlSchemaSet.NativeMethodInfoPtr_ResolveSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668468);
			XmlSchemaSet.NativeMethodInfoPtr_Remove_Internal_XmlSchema_XmlSchema_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668469);
			XmlSchemaSet.NativeMethodInfoPtr_ClearTables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668470);
			XmlSchemaSet.NativeMethodInfoPtr_PreprocessSchema_Internal_Boolean_byref_XmlSchema_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668471);
			XmlSchemaSet.NativeMethodInfoPtr_ParseSchema_Internal_XmlSchema_String_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668472);
			XmlSchemaSet.NativeMethodInfoPtr_CopyFromCompiledSet_Internal_Void_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668473);
			XmlSchemaSet.NativeMethodInfoPtr_get_CompiledInfo_Internal_get_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668474);
			XmlSchemaSet.NativeMethodInfoPtr_get_ReaderSettings_Internal_get_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668475);
			XmlSchemaSet.NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668476);
			XmlSchemaSet.NativeMethodInfoPtr_GetEventHandler_Internal_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668477);
			XmlSchemaSet.NativeMethodInfoPtr_GetSchemaNames_Internal_SchemaNames_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668478);
			XmlSchemaSet.NativeMethodInfoPtr_IsSchemaLoaded_Internal_Boolean_Uri_String_byref_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668479);
			XmlSchemaSet.NativeMethodInfoPtr_GetSchemaByUri_Internal_Boolean_Uri_byref_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668480);
			XmlSchemaSet.NativeMethodInfoPtr_GetTargetNamespace_Internal_String_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668481);
			XmlSchemaSet.NativeMethodInfoPtr_get_SortedSchemas_Internal_get_SortedList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668482);
			XmlSchemaSet.NativeMethodInfoPtr_RemoveSchemaFromCaches_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668483);
			XmlSchemaSet.NativeMethodInfoPtr_RemoveSchemaFromGlobalTables_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668484);
			XmlSchemaSet.NativeMethodInfoPtr_AddToTable_Private_Boolean_XmlSchemaObjectTable_XmlQualifiedName_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668485);
			XmlSchemaSet.NativeMethodInfoPtr_VerifyTables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668486);
			XmlSchemaSet.NativeMethodInfoPtr_InternalValidationCallback_Private_Void_Object_ValidationEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668487);
			XmlSchemaSet.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668488);
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06002412 RID: 9234 RVA: 0x000A7448 File Offset: 0x000A5648
		public unsafe Object InternalSyncObject
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 428280, RefRangeEnd = 428289, XrefRangeStart = 428277, XrefRangeEnd = 428280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_InternalSyncObject_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x000A7488 File Offset: 0x000A5688
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428294, RefRangeEnd = 428295, XrefRangeStart = 428289, XrefRangeEnd = 428294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x000A74C4 File Offset: 0x000A56C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 428333, RefRangeEnd = 428338, XrefRangeStart = 428295, XrefRangeEnd = 428333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSet(XmlNameTable nameTable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x000A7510 File Offset: 0x000A5710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428343, RefRangeEnd = 428344, XrefRangeStart = 428338, XrefRangeEnd = 428343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ValidationEventHandler(ValidationEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_add_ValidationEventHandler_Public_add_Void_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x000A7554 File Offset: 0x000A5754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428344, XrefRangeEnd = 428347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ValidationEventHandler(ValidationEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_remove_ValidationEventHandler_Public_rem_Void_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x000A7598 File Offset: 0x000A5798
		public unsafe bool IsCompiled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_IsCompiled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (set) Token: 0x06002418 RID: 9240 RVA: 0x000A75D4 File Offset: 0x000A57D4
		public unsafe XmlResolver XmlResolver
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428347, XrefRangeEnd = 428349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x000A7618 File Offset: 0x000A5818
		// (set) Token: 0x0600241A RID: 9242 RVA: 0x000A7658 File Offset: 0x000A5858
		public unsafe XmlSchemaCompilationSettings CompilationSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_CompilationSettings_Public_get_XmlSchemaCompilationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaCompilationSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_set_CompilationSettings_Public_set_Void_XmlSchemaCompilationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x0600241B RID: 9243 RVA: 0x000A769C File Offset: 0x000A589C
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428349, XrefRangeEnd = 428350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x000A76D8 File Offset: 0x000A58D8
		public unsafe XmlSchemaObjectTable GlobalElements
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 428354, RefRangeEnd = 428357, XrefRangeStart = 428350, XrefRangeEnd = 428354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_GlobalElements_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x000A7718 File Offset: 0x000A5918
		public unsafe XmlSchemaObjectTable GlobalAttributes
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 428361, RefRangeEnd = 428364, XrefRangeStart = 428357, XrefRangeEnd = 428361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_GlobalAttributes_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x0600241E RID: 9246 RVA: 0x000A7758 File Offset: 0x000A5958
		public unsafe XmlSchemaObjectTable GlobalTypes
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 428368, RefRangeEnd = 428371, XrefRangeStart = 428364, XrefRangeEnd = 428368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_GlobalTypes_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x000A7798 File Offset: 0x000A5998
		public unsafe XmlSchemaObjectTable SubstitutionGroups
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 428375, RefRangeEnd = 428379, XrefRangeStart = 428371, XrefRangeEnd = 428375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_SubstitutionGroups_Internal_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06002420 RID: 9248 RVA: 0x000A77D8 File Offset: 0x000A59D8
		public unsafe Hashtable SchemaLocations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_SchemaLocations_Internal_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06002421 RID: 9249 RVA: 0x000A7818 File Offset: 0x000A5A18
		public unsafe XmlSchemaObjectTable TypeExtensions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428379, XrefRangeEnd = 428383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_TypeExtensions_Internal_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x000A7858 File Offset: 0x000A5A58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 428439, RefRangeEnd = 428442, XrefRangeStart = 428383, XrefRangeEnd = 428439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(XmlSchemaSet schemas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Add_Public_Void_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x000A789C File Offset: 0x000A5A9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 428454, RefRangeEnd = 428457, XrefRangeStart = 428442, XrefRangeEnd = 428454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema Add(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Add_Public_XmlSchema_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
			}
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x000A78EC File Offset: 0x000A5AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428525, RefRangeEnd = 428526, XrefRangeStart = 428457, XrefRangeEnd = 428525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveRecursive(XmlSchema schemaToRemove)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaToRemove);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_RemoveRecursive_Public_Boolean_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x000A793C File Offset: 0x000A5B3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 428590, RefRangeEnd = 428593, XrefRangeStart = 428526, XrefRangeEnd = 428590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Compile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Compile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x000A7970 File Offset: 0x000A5B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428593, XrefRangeEnd = 428595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppReferenceArray<XmlSchema> schemas, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemas);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppReferenceArray_1_XmlSchema_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x000A79C0 File Offset: 0x000A5BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428607, RefRangeEnd = 428608, XrefRangeStart = 428595, XrefRangeEnd = 428607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ICollection Schemas(string targetNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Schemas_Public_ICollection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x000A7A10 File Offset: 0x000A5C10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428610, RefRangeEnd = 428611, XrefRangeStart = 428608, XrefRangeEnd = 428610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema Add(string targetNamespace, XmlSchema schema)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Add_Private_XmlSchema_String_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x000A7A74 File Offset: 0x000A5C74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428636, RefRangeEnd = 428637, XrefRangeStart = 428611, XrefRangeEnd = 428636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validatedNamespaces);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Add_Internal_Void_String_XmlReader_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x000A7ADC File Offset: 0x000A5CDC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 428655, RefRangeEnd = 428660, XrefRangeStart = 428637, XrefRangeEnd = 428655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, Il2CppReferenceArray<DictionaryEntry> locationsTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locationsTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_FindSchemaByNSAndUrl_Internal_XmlSchema_Uri_String_Il2CppReferenceArray_1_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x000A7B50 File Offset: 0x000A5D50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 428695, RefRangeEnd = 428698, XrefRangeStart = 428660, XrefRangeEnd = 428695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSchemaToSet(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_AddSchemaToSet_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x000A7B94 File Offset: 0x000A5D94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428748, RefRangeEnd = 428749, XrefRangeStart = 428698, XrefRangeEnd = 428748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(substitutionGroupsTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolve;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_ProcessNewSubstitutionGroups_Private_Void_XmlSchemaObjectTable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x000A7BE4 File Offset: 0x000A5DE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 428774, RefRangeEnd = 428776, XrefRangeStart = 428749, XrefRangeEnd = 428774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(substitutionGroup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(substTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_ResolveSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x000A7C38 File Offset: 0x000A5E38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 428799, RefRangeEnd = 428801, XrefRangeStart = 428776, XrefRangeEnd = 428799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema Remove(XmlSchema schema, bool forceCompile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceCompile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Remove_Internal_XmlSchema_XmlSchema_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x000A7C98 File Offset: 0x000A5E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428801, XrefRangeEnd = 428815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_ClearTables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x000A7CCC File Offset: 0x000A5ECC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 428821, RefRangeEnd = 428824, XrefRangeStart = 428815, XrefRangeEnd = 428821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PreprocessSchema(ref XmlSchema schema, string targetNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_PreprocessSchema_Internal_Boolean_byref_XmlSchema_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			schema = ((intPtr4 == 0) ? null : new XmlSchema(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x000A7D44 File Offset: 0x000A5F44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428831, RefRangeEnd = 428832, XrefRangeStart = 428824, XrefRangeEnd = 428831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema ParseSchema(string targetNamespace, XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_ParseSchema_Internal_XmlSchema_String_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x000A7DA8 File Offset: 0x000A5FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428992, RefRangeEnd = 428993, XrefRangeStart = 428832, XrefRangeEnd = 428992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFromCompiledSet(XmlSchemaSet otherSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_CopyFromCompiledSet_Internal_Void_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x000A7DEC File Offset: 0x000A5FEC
		public unsafe SchemaInfo CompiledInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_CompiledInfo_Internal_get_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06002434 RID: 9268 RVA: 0x000A7E2C File Offset: 0x000A602C
		public unsafe XmlReaderSettings ReaderSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_ReaderSettings_Internal_get_XmlReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x000A7E6C File Offset: 0x000A606C
		[CallerCount(0)]
		public unsafe XmlResolver GetResolver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x000A7EAC File Offset: 0x000A60AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationEventHandler GetEventHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_GetEventHandler_Internal_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr3) : null;
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x000A7EEC File Offset: 0x000A60EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 429001, RefRangeEnd = 429004, XrefRangeStart = 428993, XrefRangeEnd = 429001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaNames GetSchemaNames(XmlNameTable nt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_GetSchemaNames_Internal_SchemaNames_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr3) : null;
			}
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x000A7F3C File Offset: 0x000A613C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429011, RefRangeEnd = 429012, XrefRangeStart = 429004, XrefRangeEnd = 429011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_IsSchemaLoaded_Internal_Boolean_Uri_String_byref_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			schema = ((intPtr4 == 0) ? null : new XmlSchema(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x000A7FC0 File Offset: 0x000A61C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429021, RefRangeEnd = 429022, XrefRangeStart = 429012, XrefRangeEnd = 429021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaUri);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_GetSchemaByUri_Internal_Boolean_Uri_byref_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			schema = ((intPtr4 == 0) ? null : new XmlSchema(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x000A8030 File Offset: 0x000A6230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429022, XrefRangeEnd = 429024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTargetNamespace(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_GetTargetNamespace_Internal_String_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x0600243B RID: 9275 RVA: 0x000A8078 File Offset: 0x000A6278
		public unsafe SortedList SortedSchemas
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_SortedSchemas_Internal_get_SortedList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr3) : null;
			}
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x000A80B8 File Offset: 0x000A62B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429060, RefRangeEnd = 429061, XrefRangeStart = 429024, XrefRangeEnd = 429060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSchemaFromCaches(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_RemoveSchemaFromCaches_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x000A80FC File Offset: 0x000A62FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429137, RefRangeEnd = 429138, XrefRangeStart = 429061, XrefRangeEnd = 429137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSchemaFromGlobalTables(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_RemoveSchemaFromGlobalTables_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x000A8140 File Offset: 0x000A6340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 429151, RefRangeEnd = 429153, XrefRangeStart = 429138, XrefRangeEnd = 429151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(qname);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_AddToTable_Private_Boolean_XmlSchemaObjectTable_XmlQualifiedName_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x000A81B4 File Offset: 0x000A63B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 429166, RefRangeEnd = 429168, XrefRangeStart = 429153, XrefRangeEnd = 429166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VerifyTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_VerifyTables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x000A81E8 File Offset: 0x000A63E8
		[CallerCount(0)]
		public unsafe void InternalValidationCallback(Object sender, ValidationEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_InternalValidationCallback_Private_Void_Object_ValidationEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x000A823C File Offset: 0x000A643C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 429175, RefRangeEnd = 429179, XrefRangeStart = 429168, XrefRangeEnd = 429175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x0000FACE File Offset: 0x0000DCCE
		public XmlSchemaSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x000A828C File Offset: 0x000A648C
		// (set) Token: 0x06002444 RID: 9284 RVA: 0x0000FAD7 File Offset: 0x0000DCD7
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x000A82BC File Offset: 0x000A64BC
		// (set) Token: 0x06002446 RID: 9286 RVA: 0x0000FAF6 File Offset: 0x0000DCF6
		public unsafe SchemaNames schemaNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x000A82EC File Offset: 0x000A64EC
		// (set) Token: 0x06002448 RID: 9288 RVA: 0x0000FB15 File Offset: 0x0000DD15
		public unsafe SortedList schemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x000A831C File Offset: 0x000A651C
		// (set) Token: 0x0600244A RID: 9290 RVA: 0x0000FB34 File Offset: 0x0000DD34
		public unsafe ValidationEventHandler internalEventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_internalEventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_internalEventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x000A834C File Offset: 0x000A654C
		// (set) Token: 0x0600244C RID: 9292 RVA: 0x0000FB53 File Offset: 0x0000DD53
		public unsafe ValidationEventHandler eventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_eventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_eventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x000A837C File Offset: 0x000A657C
		// (set) Token: 0x0600244E RID: 9294 RVA: 0x0000FB72 File Offset: 0x0000DD72
		public unsafe bool isCompiled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_isCompiled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_isCompiled)) = value;
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x000A83A4 File Offset: 0x000A65A4
		// (set) Token: 0x06002450 RID: 9296 RVA: 0x0000FB8D File Offset: 0x0000DD8D
		public unsafe Hashtable schemaLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x000A83D4 File Offset: 0x000A65D4
		// (set) Token: 0x06002452 RID: 9298 RVA: 0x0000FBAC File Offset: 0x0000DDAC
		public unsafe Hashtable chameleonSchemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_chameleonSchemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_chameleonSchemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x000A8404 File Offset: 0x000A6604
		// (set) Token: 0x06002454 RID: 9300 RVA: 0x0000FBCB File Offset: 0x0000DDCB
		public unsafe Hashtable targetNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_targetNamespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_targetNamespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x000A8434 File Offset: 0x000A6634
		// (set) Token: 0x06002456 RID: 9302 RVA: 0x0000FBEA File Offset: 0x0000DDEA
		public unsafe bool compileAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_compileAll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_compileAll)) = value;
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x000A845C File Offset: 0x000A665C
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x0000FC05 File Offset: 0x0000DE05
		public unsafe SchemaInfo cachedCompiledInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_cachedCompiledInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_cachedCompiledInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x000A848C File Offset: 0x000A668C
		// (set) Token: 0x0600245A RID: 9306 RVA: 0x0000FC24 File Offset: 0x0000DE24
		public unsafe XmlReaderSettings readerSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_readerSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_readerSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x000A84BC File Offset: 0x000A66BC
		// (set) Token: 0x0600245C RID: 9308 RVA: 0x0000FC43 File Offset: 0x0000DE43
		public unsafe XmlSchema schemaForSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaForSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaForSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x000A84EC File Offset: 0x000A66EC
		// (set) Token: 0x0600245E RID: 9310 RVA: 0x0000FC62 File Offset: 0x0000DE62
		public unsafe XmlSchemaCompilationSettings compilationSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_compilationSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaCompilationSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_compilationSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x0600245F RID: 9311 RVA: 0x000A851C File Offset: 0x000A671C
		// (set) Token: 0x06002460 RID: 9312 RVA: 0x0000FC81 File Offset: 0x0000DE81
		public unsafe XmlSchemaObjectTable elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002461 RID: 9313 RVA: 0x000A854C File Offset: 0x000A674C
		// (set) Token: 0x06002462 RID: 9314 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public unsafe XmlSchemaObjectTable attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x000A857C File Offset: 0x000A677C
		// (set) Token: 0x06002464 RID: 9316 RVA: 0x0000FCBF File Offset: 0x0000DEBF
		public unsafe XmlSchemaObjectTable schemaTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06002465 RID: 9317 RVA: 0x000A85AC File Offset: 0x000A67AC
		// (set) Token: 0x06002466 RID: 9318 RVA: 0x0000FCDE File Offset: 0x0000DEDE
		public unsafe XmlSchemaObjectTable substitutionGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_substitutionGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_substitutionGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06002467 RID: 9319 RVA: 0x000A85DC File Offset: 0x000A67DC
		// (set) Token: 0x06002468 RID: 9320 RVA: 0x0000FCFD File Offset: 0x0000DEFD
		public unsafe XmlSchemaObjectTable typeExtensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_typeExtensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_typeExtensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06002469 RID: 9321 RVA: 0x000A860C File Offset: 0x000A680C
		// (set) Token: 0x0600246A RID: 9322 RVA: 0x0000FD1C File Offset: 0x0000DF1C
		public unsafe Object internalSyncObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_internalSyncObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_internalSyncObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AC7 RID: 6855
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04001AC8 RID: 6856
		private static readonly IntPtr NativeFieldInfoPtr_schemaNames;

		// Token: 0x04001AC9 RID: 6857
		private static readonly IntPtr NativeFieldInfoPtr_schemas;

		// Token: 0x04001ACA RID: 6858
		private static readonly IntPtr NativeFieldInfoPtr_internalEventHandler;

		// Token: 0x04001ACB RID: 6859
		private static readonly IntPtr NativeFieldInfoPtr_eventHandler;

		// Token: 0x04001ACC RID: 6860
		private static readonly IntPtr NativeFieldInfoPtr_isCompiled;

		// Token: 0x04001ACD RID: 6861
		private static readonly IntPtr NativeFieldInfoPtr_schemaLocations;

		// Token: 0x04001ACE RID: 6862
		private static readonly IntPtr NativeFieldInfoPtr_chameleonSchemas;

		// Token: 0x04001ACF RID: 6863
		private static readonly IntPtr NativeFieldInfoPtr_targetNamespaces;

		// Token: 0x04001AD0 RID: 6864
		private static readonly IntPtr NativeFieldInfoPtr_compileAll;

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeFieldInfoPtr_cachedCompiledInfo;

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeFieldInfoPtr_readerSettings;

		// Token: 0x04001AD3 RID: 6867
		private static readonly IntPtr NativeFieldInfoPtr_schemaForSchema;

		// Token: 0x04001AD4 RID: 6868
		private static readonly IntPtr NativeFieldInfoPtr_compilationSettings;

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x04001AD6 RID: 6870
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04001AD7 RID: 6871
		private static readonly IntPtr NativeFieldInfoPtr_schemaTypes;

		// Token: 0x04001AD8 RID: 6872
		private static readonly IntPtr NativeFieldInfoPtr_substitutionGroups;

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeFieldInfoPtr_typeExtensions;

		// Token: 0x04001ADA RID: 6874
		private static readonly IntPtr NativeFieldInfoPtr_internalSyncObject;

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Internal_get_Object_0;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001ADD RID: 6877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0;

		// Token: 0x04001ADE RID: 6878
		private static readonly IntPtr NativeMethodInfoPtr_add_ValidationEventHandler_Public_add_Void_ValidationEventHandler_0;

		// Token: 0x04001ADF RID: 6879
		private static readonly IntPtr NativeMethodInfoPtr_remove_ValidationEventHandler_Public_rem_Void_ValidationEventHandler_0;

		// Token: 0x04001AE0 RID: 6880
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompiled_Public_get_Boolean_0;

		// Token: 0x04001AE1 RID: 6881
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0;

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeMethodInfoPtr_get_CompilationSettings_Public_get_XmlSchemaCompilationSettings_0;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeMethodInfoPtr_set_CompilationSettings_Public_set_Void_XmlSchemaCompilationSettings_0;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalElements_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalAttributes_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001AE7 RID: 6887
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalTypes_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001AE8 RID: 6888
		private static readonly IntPtr NativeMethodInfoPtr_get_SubstitutionGroups_Internal_get_XmlSchemaObjectTable_0;

		// Token: 0x04001AE9 RID: 6889
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaLocations_Internal_get_Hashtable_0;

		// Token: 0x04001AEA RID: 6890
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeExtensions_Internal_get_XmlSchemaObjectTable_0;

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_XmlSchemaSet_0;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_XmlSchema_XmlSchema_0;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRecursive_Public_Boolean_XmlSchema_0;

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Void_0;

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppReferenceArray_1_XmlSchema_Int32_0;

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeMethodInfoPtr_Schemas_Public_ICollection_String_0;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeMethodInfoPtr_Add_Private_XmlSchema_String_XmlSchema_0;

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_String_XmlReader_Hashtable_0;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeMethodInfoPtr_FindSchemaByNSAndUrl_Internal_XmlSchema_Uri_String_Il2CppReferenceArray_1_DictionaryEntry_0;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeMethodInfoPtr_AddSchemaToSet_Private_Void_XmlSchema_0;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeMethodInfoPtr_ProcessNewSubstitutionGroups_Private_Void_XmlSchemaObjectTable_Boolean_0;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeMethodInfoPtr_ResolveSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_XmlSchemaObjectTable_0;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Internal_XmlSchema_XmlSchema_Boolean_0;

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeMethodInfoPtr_ClearTables_Private_Void_0;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessSchema_Internal_Boolean_byref_XmlSchema_String_0;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeMethodInfoPtr_ParseSchema_Internal_XmlSchema_String_XmlReader_0;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeMethodInfoPtr_CopyFromCompiledSet_Internal_Void_XmlSchemaSet_0;

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeMethodInfoPtr_get_CompiledInfo_Internal_get_SchemaInfo_0;

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeMethodInfoPtr_get_ReaderSettings_Internal_get_XmlReaderSettings_0;

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0;

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeMethodInfoPtr_GetEventHandler_Internal_ValidationEventHandler_0;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaNames_Internal_SchemaNames_XmlNameTable_0;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeMethodInfoPtr_IsSchemaLoaded_Internal_Boolean_Uri_String_byref_XmlSchema_0;

		// Token: 0x04001B02 RID: 6914
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaByUri_Internal_Boolean_Uri_byref_XmlSchema_0;

		// Token: 0x04001B03 RID: 6915
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetNamespace_Internal_String_XmlSchema_0;

		// Token: 0x04001B04 RID: 6916
		private static readonly IntPtr NativeMethodInfoPtr_get_SortedSchemas_Internal_get_SortedList_0;

		// Token: 0x04001B05 RID: 6917
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSchemaFromCaches_Private_Void_XmlSchema_0;

		// Token: 0x04001B06 RID: 6918
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSchemaFromGlobalTables_Private_Void_XmlSchema_0;

		// Token: 0x04001B07 RID: 6919
		private static readonly IntPtr NativeMethodInfoPtr_AddToTable_Private_Boolean_XmlSchemaObjectTable_XmlQualifiedName_XmlSchemaObject_0;

		// Token: 0x04001B08 RID: 6920
		private static readonly IntPtr NativeMethodInfoPtr_VerifyTables_Private_Void_0;

		// Token: 0x04001B09 RID: 6921
		private static readonly IntPtr NativeMethodInfoPtr_InternalValidationCallback_Private_Void_Object_ValidationEventArgs_0;

		// Token: 0x04001B0A RID: 6922
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0;
	}
}
