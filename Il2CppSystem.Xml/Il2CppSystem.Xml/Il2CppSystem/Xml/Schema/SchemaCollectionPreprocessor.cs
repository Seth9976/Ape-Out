using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.IO;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000175 RID: 373
	public sealed class SchemaCollectionPreprocessor : BaseProcessor
	{
		// Token: 0x06001C03 RID: 7171 RVA: 0x00089838 File Offset: 0x00087A38
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaCollectionPreprocessor()
		{
			Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaCollectionPreprocessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr);
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_schema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "schema");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_targetNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "targetNamespace");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_buildinIncluded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "buildinIncluded");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_elementFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "elementFormDefault");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_attributeFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "attributeFormDefault");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_blockDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "blockDefault");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_finalDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "finalDefault");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_schemaLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "schemaLocations");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_referenceNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "referenceNamespaces");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_Xmlns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "Xmlns");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "xmlResolver");
			SchemaCollectionPreprocessor.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667449);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_String_Boolean_XmlSchemaCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667450);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_Cleanup_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667451);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667452);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_LoadExternals_Private_Void_XmlSchema_XmlSchemaCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667453);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_BuildRefNamespaces_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667454);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_Preprocess_Private_Void_XmlSchema_String_Compositor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667455);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessRedefine_Private_Void_XmlSchemaRedefine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667456);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_CountGroupSelfReference_Private_Int32_XmlSchemaObjectCollection_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667457);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_CheckRefinedGroup_Private_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667458);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_CheckRefinedAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667459);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_CheckRefinedSimpleType_Private_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667460);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_CheckRefinedComplexType_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667461);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAttribute_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667462);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessLocalAttribute_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667463);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAttributeContent_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667464);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667465);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessElement_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667466);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessLocalElement_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667467);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessElementContent_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667468);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667469);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessSimpleType_Private_Void_XmlSchemaSimpleType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667470);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessComplexType_Private_Void_XmlSchemaComplexType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667471);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessGroup_Private_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667472);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessNotation_Private_Void_XmlSchemaNotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667473);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessParticle_Private_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667474);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAttributes_Private_Void_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667475);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_ValidateIdAttribute_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667476);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_ValidateNameAttribute_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667477);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_ValidateQNameAttribute_Private_Void_XmlSchemaObject_String_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667478);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_SetParent_Private_Void_XmlSchemaObject_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667479);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667480);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_ResolveSchemaLocationUri_Private_Uri_XmlSchema_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667481);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_GetSchemaEntity_Private_Stream_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667482);
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00089BEC File Offset: 0x00087DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 418276, XrefRangeEnd = 418277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaCollectionPreprocessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00089C5C File Offset: 0x00087E5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 418294, RefRangeEnd = 418295, XrefRangeStart = 418277, XrefRangeEnd = 418294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadExternals;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xsc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_String_Boolean_XmlSchemaCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x00089CDC File Offset: 0x00087EDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 418344, RefRangeEnd = 418346, XrefRangeStart = 418295, XrefRangeEnd = 418344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_Cleanup_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700098B RID: 2443
		// (set) Token: 0x06001C07 RID: 7175 RVA: 0x00089D20 File Offset: 0x00087F20
		public unsafe XmlResolver XmlResolver
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x00089D64 File Offset: 0x00087F64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 418446, RefRangeEnd = 418449, XrefRangeStart = 418346, XrefRangeEnd = 418446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xsc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_LoadExternals_Private_Void_XmlSchema_XmlSchemaCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00089DB8 File Offset: 0x00087FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 418461, RefRangeEnd = 418462, XrefRangeStart = 418449, XrefRangeEnd = 418461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildRefNamespaces(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_BuildRefNamespaces_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00089DFC File Offset: 0x00087FFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 418764, RefRangeEnd = 418766, XrefRangeStart = 418462, XrefRangeEnd = 418764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Preprocess(XmlSchema schema, string targetNamespace, SchemaCollectionPreprocessor.Compositor compositor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compositor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_Preprocess_Private_Void_XmlSchema_String_Compositor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x00089E60 File Offset: 0x00088060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 419024, RefRangeEnd = 419025, XrefRangeStart = 418766, XrefRangeEnd = 419024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessRedefine(XmlSchemaRedefine redefine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(redefine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessRedefine_Private_Void_XmlSchemaRedefine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x00089EA4 File Offset: 0x000880A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 419064, RefRangeEnd = 419067, XrefRangeStart = 419025, XrefRangeEnd = 419064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_CountGroupSelfReference_Private_Int32_XmlSchemaObjectCollection_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00089F04 File Offset: 0x00088104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 419067, XrefRangeEnd = 419071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRefinedGroup(XmlSchemaGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_CheckRefinedGroup_Private_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00089F48 File Offset: 0x00088148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 419071, XrefRangeEnd = 419082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_CheckRefinedAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00089F8C File Offset: 0x0008818C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 419091, RefRangeEnd = 419092, XrefRangeStart = 419082, XrefRangeEnd = 419091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRefinedSimpleType(XmlSchemaSimpleType stype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_CheckRefinedSimpleType_Private_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00089FD0 File Offset: 0x000881D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 419116, RefRangeEnd = 419117, XrefRangeStart = 419092, XrefRangeEnd = 419116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRefinedComplexType(XmlSchemaComplexType ctype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_CheckRefinedComplexType_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x0008A014 File Offset: 0x00088214
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 419140, RefRangeEnd = 419141, XrefRangeStart = 419117, XrefRangeEnd = 419140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAttribute(XmlSchemaAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAttribute_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0008A058 File Offset: 0x00088258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 419141, XrefRangeEnd = 419164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessLocalAttribute(XmlSchemaAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessLocalAttribute_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0008A09C File Offset: 0x0008829C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 419191, RefRangeEnd = 419194, XrefRangeStart = 419164, XrefRangeEnd = 419191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAttributeContent(XmlSchemaAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAttributeContent_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0008A0E0 File Offset: 0x000882E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 419209, RefRangeEnd = 419210, XrefRangeStart = 419194, XrefRangeEnd = 419209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0008A124 File Offset: 0x00088324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 419247, RefRangeEnd = 419248, XrefRangeStart = 419210, XrefRangeEnd = 419247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessElement(XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessElement_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x0008A168 File Offset: 0x00088368
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 419302, RefRangeEnd = 419305, XrefRangeStart = 419248, XrefRangeEnd = 419302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessLocalElement(XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessLocalElement_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x0008A1AC File Offset: 0x000883AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 419343, RefRangeEnd = 419345, XrefRangeStart = 419305, XrefRangeEnd = 419343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessElementContent(XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessElementContent_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x0008A1F0 File Offset: 0x000883F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 419375, RefRangeEnd = 419377, XrefRangeStart = 419345, XrefRangeEnd = 419375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x0008A234 File Offset: 0x00088434
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 419523, RefRangeEnd = 419531, XrefRangeStart = 419377, XrefRangeEnd = 419523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessSimpleType_Private_Void_XmlSchemaSimpleType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0008A284 File Offset: 0x00088484
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 419652, RefRangeEnd = 419655, XrefRangeStart = 419531, XrefRangeEnd = 419652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessComplexType_Private_Void_XmlSchemaComplexType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0008A2D4 File Offset: 0x000884D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 419684, RefRangeEnd = 419686, XrefRangeStart = 419655, XrefRangeEnd = 419684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessGroup(XmlSchemaGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessGroup_Private_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0008A318 File Offset: 0x00088518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 419717, RefRangeEnd = 419718, XrefRangeStart = 419686, XrefRangeEnd = 419717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessNotation(XmlSchemaNotation notation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessNotation_Private_Void_XmlSchemaNotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0008A35C File Offset: 0x0008855C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 419859, RefRangeEnd = 419864, XrefRangeStart = 419718, XrefRangeEnd = 419859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessParticle(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessParticle_Private_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0008A3A0 File Offset: 0x000885A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 419970, RefRangeEnd = 419976, XrefRangeStart = 419864, XrefRangeEnd = 419970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAttributes_Private_Void_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0008A408 File Offset: 0x00088608
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 419987, RefRangeEnd = 420012, XrefRangeStart = 419976, XrefRangeEnd = 419987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateIdAttribute(XmlSchemaObject xso)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xso);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_ValidateIdAttribute_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x0008A44C File Offset: 0x0008864C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 420025, RefRangeEnd = 420035, XrefRangeStart = 420012, XrefRangeEnd = 420025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateNameAttribute(XmlSchemaObject xso)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xso);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_ValidateNameAttribute_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x0008A490 File Offset: 0x00088690
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 420043, RefRangeEnd = 420058, XrefRangeStart = 420035, XrefRangeEnd = 420043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_ValidateQNameAttribute_Private_Void_XmlSchemaObject_String_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0008A4F8 File Offset: 0x000886F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 415886, RefRangeEnd = 415892, XrefRangeStart = 415886, XrefRangeEnd = 415892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_SetParent_Private_Void_XmlSchemaObject_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0008A54C File Offset: 0x0008874C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 420063, RefRangeEnd = 420077, XrefRangeStart = 420058, XrefRangeEnd = 420063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAnnotation(XmlSchemaObject schemaObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0008A590 File Offset: 0x00088790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 420078, RefRangeEnd = 420079, XrefRangeStart = 420077, XrefRangeEnd = 420078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_ResolveSchemaLocationUri_Private_Uri_XmlSchema_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x0008A5F4 File Offset: 0x000887F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 420082, RefRangeEnd = 420083, XrefRangeStart = 420079, XrefRangeEnd = 420082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream GetSchemaEntity(Uri ruri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ruri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_GetSchemaEntity_Private_Stream_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x0000BC17 File Offset: 0x00009E17
		public SchemaCollectionPreprocessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x0008A644 File Offset: 0x00088844
		// (set) Token: 0x06001C28 RID: 7208 RVA: 0x0000BC20 File Offset: 0x00009E20
		public unsafe XmlSchema schema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_schema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_schema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x0008A674 File Offset: 0x00088874
		// (set) Token: 0x06001C2A RID: 7210 RVA: 0x0000BC3F File Offset: 0x00009E3F
		public unsafe string targetNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_targetNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_targetNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x0008A69C File Offset: 0x0008889C
		// (set) Token: 0x06001C2C RID: 7212 RVA: 0x0000BC5E File Offset: 0x00009E5E
		public unsafe bool buildinIncluded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_buildinIncluded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_buildinIncluded)) = value;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x0008A6C4 File Offset: 0x000888C4
		// (set) Token: 0x06001C2E RID: 7214 RVA: 0x0000BC79 File Offset: 0x00009E79
		public unsafe XmlSchemaForm elementFormDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_elementFormDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_elementFormDefault)) = value;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x0008A6EC File Offset: 0x000888EC
		// (set) Token: 0x06001C30 RID: 7216 RVA: 0x0000BC94 File Offset: 0x00009E94
		public unsafe XmlSchemaForm attributeFormDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_attributeFormDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_attributeFormDefault)) = value;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x0008A714 File Offset: 0x00088914
		// (set) Token: 0x06001C32 RID: 7218 RVA: 0x0000BCAF File Offset: 0x00009EAF
		public unsafe XmlSchemaDerivationMethod blockDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_blockDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_blockDefault)) = value;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x0008A73C File Offset: 0x0008893C
		// (set) Token: 0x06001C34 RID: 7220 RVA: 0x0000BCCA File Offset: 0x00009ECA
		public unsafe XmlSchemaDerivationMethod finalDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_finalDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_finalDefault)) = value;
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x0008A764 File Offset: 0x00088964
		// (set) Token: 0x06001C36 RID: 7222 RVA: 0x0000BCE5 File Offset: 0x00009EE5
		public unsafe Hashtable schemaLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_schemaLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_schemaLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x0008A794 File Offset: 0x00088994
		// (set) Token: 0x06001C38 RID: 7224 RVA: 0x0000BD04 File Offset: 0x00009F04
		public unsafe Hashtable referenceNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_referenceNamespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_referenceNamespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x0008A7C4 File Offset: 0x000889C4
		// (set) Token: 0x06001C3A RID: 7226 RVA: 0x0000BD23 File Offset: 0x00009F23
		public unsafe string Xmlns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_Xmlns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_Xmlns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x0008A7EC File Offset: 0x000889EC
		// (set) Token: 0x06001C3C RID: 7228 RVA: 0x0000BD42 File Offset: 0x00009F42
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeFieldInfoPtr_schema;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeFieldInfoPtr_targetNamespace;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeFieldInfoPtr_buildinIncluded;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeFieldInfoPtr_elementFormDefault;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeFieldInfoPtr_attributeFormDefault;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeFieldInfoPtr_blockDefault;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeFieldInfoPtr_finalDefault;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeFieldInfoPtr_schemaLocations;

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeFieldInfoPtr_referenceNamespaces;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeFieldInfoPtr_Xmlns;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_0;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_String_Boolean_XmlSchemaCollection_0;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_XmlSchema_0;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeMethodInfoPtr_LoadExternals_Private_Void_XmlSchema_XmlSchemaCollection_0;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeMethodInfoPtr_BuildRefNamespaces_Private_Void_XmlSchema_0;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeMethodInfoPtr_Preprocess_Private_Void_XmlSchema_String_Compositor_0;

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessRedefine_Private_Void_XmlSchemaRedefine_0;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeMethodInfoPtr_CountGroupSelfReference_Private_Int32_XmlSchemaObjectCollection_XmlQualifiedName_0;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeMethodInfoPtr_CheckRefinedGroup_Private_Void_XmlSchemaGroup_0;

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeMethodInfoPtr_CheckRefinedAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeMethodInfoPtr_CheckRefinedSimpleType_Private_Void_XmlSchemaSimpleType_0;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeMethodInfoPtr_CheckRefinedComplexType_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAttribute_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessLocalAttribute_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAttributeContent_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessElement_Private_Void_XmlSchemaElement_0;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessLocalElement_Private_Void_XmlSchemaElement_0;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessElementContent_Private_Void_XmlSchemaElement_0;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessSimpleType_Private_Void_XmlSchemaSimpleType_Boolean_0;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessComplexType_Private_Void_XmlSchemaComplexType_Boolean_0;

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessGroup_Private_Void_XmlSchemaGroup_0;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessNotation_Private_Void_XmlSchemaNotation_0;

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessParticle_Private_Void_XmlSchemaParticle_0;

		// Token: 0x0400151E RID: 5406
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAttributes_Private_Void_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaObject_0;

		// Token: 0x0400151F RID: 5407
		private static readonly IntPtr NativeMethodInfoPtr_ValidateIdAttribute_Private_Void_XmlSchemaObject_0;

		// Token: 0x04001520 RID: 5408
		private static readonly IntPtr NativeMethodInfoPtr_ValidateNameAttribute_Private_Void_XmlSchemaObject_0;

		// Token: 0x04001521 RID: 5409
		private static readonly IntPtr NativeMethodInfoPtr_ValidateQNameAttribute_Private_Void_XmlSchemaObject_String_XmlQualifiedName_0;

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Private_Void_XmlSchemaObject_XmlSchemaObject_0;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaObject_0;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeMethodInfoPtr_ResolveSchemaLocationUri_Private_Uri_XmlSchema_String_0;

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaEntity_Private_Stream_Uri_0;

		// Token: 0x02000235 RID: 565
		[OriginalName("System.Xml.dll", "", "Compositor")]
		public enum Compositor
		{
			// Token: 0x040022BE RID: 8894
			Root,
			// Token: 0x040022BF RID: 8895
			Include,
			// Token: 0x040022C0 RID: 8896
			Import
		}
	}
}
