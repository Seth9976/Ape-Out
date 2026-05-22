using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200017E RID: 382
	public sealed class Compiler : BaseProcessor
	{
		// Token: 0x06001E69 RID: 7785 RVA: 0x00090E5C File Offset: 0x0008F05C
		// Note: this type is marked as 'beforefieldinit'.
		static Compiler()
		{
			Il2CppClassPointerStore<Compiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Compiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Compiler>.NativeClassPtr);
			Compiler.NativeFieldInfoPtr_restrictionErrorMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "restrictionErrorMsg");
			Compiler.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "attributes");
			Compiler.NativeFieldInfoPtr_attributeGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "attributeGroups");
			Compiler.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "elements");
			Compiler.NativeFieldInfoPtr_schemaTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "schemaTypes");
			Compiler.NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "groups");
			Compiler.NativeFieldInfoPtr_notations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "notations");
			Compiler.NativeFieldInfoPtr_examplars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "examplars");
			Compiler.NativeFieldInfoPtr_identityConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "identityConstraints");
			Compiler.NativeFieldInfoPtr_complexTypeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "complexTypeStack");
			Compiler.NativeFieldInfoPtr_schemasToCompile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "schemasToCompile");
			Compiler.NativeFieldInfoPtr_importedSchemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "importedSchemas");
			Compiler.NativeFieldInfoPtr_schemaForSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "schemaForSchema");
			Compiler.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_ValidationEventHandler_XmlSchema_XmlSchemaCompilationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667630);
			Compiler.NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchemaSet_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667631);
			Compiler.NativeMethodInfoPtr_Prepare_Internal_Void_XmlSchema_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667632);
			Compiler.NativeMethodInfoPtr_UpdateSForSSimpleTypes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667633);
			Compiler.NativeMethodInfoPtr_Output_Private_Void_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667634);
			Compiler.NativeMethodInfoPtr_ImportAllCompiledSchemas_Internal_Void_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667635);
			Compiler.NativeMethodInfoPtr_Compile_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667636);
			Compiler.NativeMethodInfoPtr_CleanupAttribute_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667637);
			Compiler.NativeMethodInfoPtr_CleanupAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667638);
			Compiler.NativeMethodInfoPtr_CleanupComplexType_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667639);
			Compiler.NativeMethodInfoPtr_CleanupSimpleType_Private_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667640);
			Compiler.NativeMethodInfoPtr_CleanupElement_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667641);
			Compiler.NativeMethodInfoPtr_CleanupAttributes_Private_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667642);
			Compiler.NativeMethodInfoPtr_CleanupGroup_Private_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667643);
			Compiler.NativeMethodInfoPtr_CleanupParticle_Private_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667644);
			Compiler.NativeMethodInfoPtr_ProcessSubstitutionGroups_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667645);
			Compiler.NativeMethodInfoPtr_CompileSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667646);
			Compiler.NativeMethodInfoPtr_RecursivelyCheckRedefinedGroups_Private_Void_XmlSchemaGroup_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667647);
			Compiler.NativeMethodInfoPtr_RecursivelyCheckRedefinedAttributeGroups_Private_Void_XmlSchemaAttributeGroup_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667648);
			Compiler.NativeMethodInfoPtr_CompileGroup_Private_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667649);
			Compiler.NativeMethodInfoPtr_CompileSimpleType_Private_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667650);
			Compiler.NativeMethodInfoPtr_CompileBaseMemberTypes_Private_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667651);
			Compiler.NativeMethodInfoPtr_CheckUnionType_Private_Void_XmlSchemaSimpleType_ArrayList_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667652);
			Compiler.NativeMethodInfoPtr_CompileComplexType_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667653);
			Compiler.NativeMethodInfoPtr_CompileSimpleContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667654);
			Compiler.NativeMethodInfoPtr_CompileSimpleContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentRestriction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667655);
			Compiler.NativeMethodInfoPtr_CompileComplexContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667656);
			Compiler.NativeMethodInfoPtr_CompileComplexContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentRestriction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667657);
			Compiler.NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667658);
			Compiler.NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaParticle_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667659);
			Compiler.NativeMethodInfoPtr_CompileContentTypeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667660);
			Compiler.NativeMethodInfoPtr_CannonicalizeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667661);
			Compiler.NativeMethodInfoPtr_CannonicalizeElement_Private_XmlSchemaParticle_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667662);
			Compiler.NativeMethodInfoPtr_CannonicalizeGroupRef_Private_XmlSchemaParticle_XmlSchemaGroupRef_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667663);
			Compiler.NativeMethodInfoPtr_CannonicalizeAll_Private_XmlSchemaParticle_XmlSchemaAll_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667664);
			Compiler.NativeMethodInfoPtr_CannonicalizeChoice_Private_XmlSchemaParticle_XmlSchemaChoice_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667665);
			Compiler.NativeMethodInfoPtr_CannonicalizeSequence_Private_XmlSchemaParticle_XmlSchemaSequence_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667666);
			Compiler.NativeMethodInfoPtr_CannonicalizePointlessRoot_Private_XmlSchemaParticle_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667667);
			Compiler.NativeMethodInfoPtr_IsValidRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667668);
			Compiler.NativeMethodInfoPtr_IsElementFromElement_Private_Boolean_XmlSchemaElement_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667669);
			Compiler.NativeMethodInfoPtr_IsElementFromAny_Private_Boolean_XmlSchemaElement_XmlSchemaAny_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667670);
			Compiler.NativeMethodInfoPtr_IsAnyFromAny_Private_Boolean_XmlSchemaAny_XmlSchemaAny_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667671);
			Compiler.NativeMethodInfoPtr_IsGroupBaseFromAny_Private_Boolean_XmlSchemaGroupBase_XmlSchemaAny_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667672);
			Compiler.NativeMethodInfoPtr_IsElementFromGroupBase_Private_Boolean_XmlSchemaElement_XmlSchemaGroupBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667673);
			Compiler.NativeMethodInfoPtr_IsChoiceFromChoiceSubstGroup_Private_Boolean_XmlSchemaChoice_XmlSchemaChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667674);
			Compiler.NativeMethodInfoPtr_IsGroupBaseFromGroupBase_Private_Boolean_XmlSchemaGroupBase_XmlSchemaGroupBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667675);
			Compiler.NativeMethodInfoPtr_IsSequenceFromAll_Private_Boolean_XmlSchemaSequence_XmlSchemaAll_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667676);
			Compiler.NativeMethodInfoPtr_IsSequenceFromChoice_Private_Boolean_XmlSchemaSequence_XmlSchemaChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667677);
			Compiler.NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667678);
			Compiler.NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_Decimal_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667679);
			Compiler.NativeMethodInfoPtr_GetMappingParticle_Private_Int32_XmlSchemaParticle_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667680);
			Compiler.NativeMethodInfoPtr_IsParticleEmptiable_Private_Boolean_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667681);
			Compiler.NativeMethodInfoPtr_CalculateEffectiveTotalRange_Private_Void_XmlSchemaParticle_byref_Decimal_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667682);
			Compiler.NativeMethodInfoPtr_PushComplexType_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667683);
			Compiler.NativeMethodInfoPtr_GetSchemaContentType_Private_XmlSchemaContentType_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667684);
			Compiler.NativeMethodInfoPtr_CompileAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667685);
			Compiler.NativeMethodInfoPtr_CompileLocalAttributes_Private_Void_XmlSchemaComplexType_XmlSchemaComplexType_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667686);
			Compiler.NativeMethodInfoPtr_CheckAtrributeGroupRestriction_Private_Void_XmlSchemaAttributeGroup_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667687);
			Compiler.NativeMethodInfoPtr_IsProcessContentsRestricted_Private_Boolean_XmlSchemaComplexType_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667688);
			Compiler.NativeMethodInfoPtr_CompileAnyAttributeUnion_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667689);
			Compiler.NativeMethodInfoPtr_CompileAnyAttributeIntersection_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667690);
			Compiler.NativeMethodInfoPtr_CompileAttribute_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667691);
			Compiler.NativeMethodInfoPtr_SetDefaultFixed_Private_Void_XmlSchemaAttribute_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667692);
			Compiler.NativeMethodInfoPtr_CompileIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667693);
			Compiler.NativeMethodInfoPtr_CompileElement_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667694);
			Compiler.NativeMethodInfoPtr_CompileComplexContent_Private_ContentValidator_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667695);
			Compiler.NativeMethodInfoPtr_BuildParticleContentModel_Private_Boolean_ParticleContentValidator_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667696);
			Compiler.NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaComplexType_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667697);
			Compiler.NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667698);
			Compiler.NativeMethodInfoPtr_CompileComplexTypeElements_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667699);
			Compiler.NativeMethodInfoPtr_GetSimpleType_Private_XmlSchemaSimpleType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667700);
			Compiler.NativeMethodInfoPtr_GetComplexType_Private_XmlSchemaComplexType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667701);
			Compiler.NativeMethodInfoPtr_GetAnySchemaType_Private_XmlSchemaType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667702);
			Compiler.NativeMethodInfoPtr_CopyPosition_Private_Void_XmlSchemaAnnotated_XmlSchemaAnnotated_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667703);
			Compiler.NativeMethodInfoPtr_IsFixedEqual_Private_Boolean_SchemaDeclBase_SchemaDeclBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100667704);
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0009156C File Offset: 0x0008F76C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 421837, RefRangeEnd = 421840, XrefRangeStart = 421800, XrefRangeEnd = 421837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Compiler(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Compiler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaForSchema);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compilationSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_ValidationEventHandler_XmlSchema_XmlSchemaCompilationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x000915F0 File Offset: 0x0008F7F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 421842, RefRangeEnd = 421843, XrefRangeStart = 421840, XrefRangeEnd = 421842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaCompiledInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchemaSet_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00091650 File Offset: 0x0008F850
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 422062, RefRangeEnd = 422068, XrefRangeStart = 421843, XrefRangeEnd = 422062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Prepare(XmlSchema schema, bool cleanup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cleanup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_Prepare_Internal_Void_XmlSchema_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x000916A0 File Offset: 0x0008F8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422068, XrefRangeEnd = 422079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSForSSimpleTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_UpdateSForSSimpleTypes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x000916D4 File Offset: 0x0008F8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 422199, RefRangeEnd = 422200, XrefRangeStart = 422079, XrefRangeEnd = 422199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Output(SchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_Output_Private_Void_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x00091718 File Offset: 0x0008F918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422200, XrefRangeEnd = 422204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportAllCompiledSchemas(XmlSchemaSet schemaSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_ImportAllCompiledSchemas_Internal_Void_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x0009175C File Offset: 0x0008F95C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 422487, RefRangeEnd = 422490, XrefRangeStart = 422204, XrefRangeEnd = 422487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Compile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_Compile_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x00091798 File Offset: 0x0008F998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422490, XrefRangeEnd = 422491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupAttribute(XmlSchemaAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CleanupAttribute_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x000917DC File Offset: 0x0008F9DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 422494, RefRangeEnd = 422495, XrefRangeStart = 422491, XrefRangeEnd = 422494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CleanupAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x00091820 File Offset: 0x0008FA20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 422537, RefRangeEnd = 422541, XrefRangeStart = 422495, XrefRangeEnd = 422537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupComplexType(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CleanupComplexType_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x00091864 File Offset: 0x0008FA64
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 422550, RefRangeEnd = 422557, XrefRangeStart = 422541, XrefRangeEnd = 422550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupSimpleType(XmlSchemaSimpleType simpleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(simpleType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CleanupSimpleType_Private_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x000918A8 File Offset: 0x0008FAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422557, XrefRangeEnd = 422570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupElement(XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CleanupElement_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x000918EC File Offset: 0x0008FAEC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 422575, RefRangeEnd = 422582, XrefRangeStart = 422570, XrefRangeEnd = 422575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupAttributes(XmlSchemaObjectCollection attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CleanupAttributes_Private_Void_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x00091930 File Offset: 0x0008FB30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 422583, RefRangeEnd = 422584, XrefRangeStart = 422582, XrefRangeEnd = 422583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupGroup(XmlSchemaGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CleanupGroup_Private_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00091974 File Offset: 0x0008FB74
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 422601, RefRangeEnd = 422608, XrefRangeStart = 422584, XrefRangeEnd = 422601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupParticle(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CleanupParticle_Private_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x000919B8 File Offset: 0x0008FBB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 422676, RefRangeEnd = 422677, XrefRangeStart = 422608, XrefRangeEnd = 422676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSubstitutionGroups()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_ProcessSubstitutionGroups_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x000919EC File Offset: 0x0008FBEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 422686, RefRangeEnd = 422687, XrefRangeStart = 422677, XrefRangeEnd = 422686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(substitutionGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x00091A30 File Offset: 0x0008FC30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 422701, RefRangeEnd = 422703, XrefRangeStart = 422687, XrefRangeEnd = 422701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(redefinedGroup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseGroup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_RecursivelyCheckRedefinedGroups_Private_Void_XmlSchemaGroup_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x00091A84 File Offset: 0x0008FC84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 422707, RefRangeEnd = 422709, XrefRangeStart = 422703, XrefRangeEnd = 422707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseAttributeGroup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_RecursivelyCheckRedefinedAttributeGroups_Private_Void_XmlSchemaAttributeGroup_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x00091AD8 File Offset: 0x0008FCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422709, XrefRangeEnd = 422713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileGroup(XmlSchemaGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileGroup_Private_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x00091B1C File Offset: 0x0008FD1C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 422790, RefRangeEnd = 422798, XrefRangeStart = 422713, XrefRangeEnd = 422790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileSimpleType(XmlSchemaSimpleType simpleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(simpleType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileSimpleType_Private_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x00091B60 File Offset: 0x0008FD60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 422842, RefRangeEnd = 422843, XrefRangeStart = 422798, XrefRangeEnd = 422842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<XmlSchemaSimpleType> CompileBaseMemberTypes(XmlSchemaSimpleType simpleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(simpleType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileBaseMemberTypes_Private_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaSimpleType>>(intPtr3) : null;
			}
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x00091BB0 File Offset: 0x0008FDB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 422847, RefRangeEnd = 422848, XrefRangeStart = 422843, XrefRangeEnd = 422847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unionMember);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypeDefinitions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CheckUnionType_Private_Void_XmlSchemaSimpleType_ArrayList_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00091C18 File Offset: 0x0008FE18
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 422941, RefRangeEnd = 422949, XrefRangeStart = 422848, XrefRangeEnd = 422941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileComplexType(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileComplexType_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x00091C5C File Offset: 0x0008FE5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 422975, RefRangeEnd = 422976, XrefRangeStart = 422949, XrefRangeEnd = 422975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(simpleExtension);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileSimpleContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x00091CB0 File Offset: 0x0008FEB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 423002, RefRangeEnd = 423003, XrefRangeStart = 422976, XrefRangeEnd = 423002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(simpleRestriction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileSimpleContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentRestriction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x00091D04 File Offset: 0x0008FF04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 423026, RefRangeEnd = 423027, XrefRangeStart = 423003, XrefRangeEnd = 423026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(complexContent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(complexExtension);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileComplexContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x00091D6C File Offset: 0x0008FF6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 423047, RefRangeEnd = 423048, XrefRangeStart = 423027, XrefRangeEnd = 423047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(complexContent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(complexRestriction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileComplexContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentRestriction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00091DD4 File Offset: 0x0008FFD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 423067, RefRangeEnd = 423069, XrefRangeStart = 423048, XrefRangeEnd = 423067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckParticleDerivation(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x00091E18 File Offset: 0x00090018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423069, XrefRangeEnd = 423079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedParticle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseParticle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaParticle_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x00091E6C File Offset: 0x0009006C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 423106, RefRangeEnd = 423108, XrefRangeStart = 423079, XrefRangeEnd = 423106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileContentTypeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
			}
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x00091EBC File Offset: 0x000900BC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 423115, RefRangeEnd = 423126, XrefRangeStart = 423108, XrefRangeEnd = 423115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref root;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CannonicalizeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x00091F1C File Offset: 0x0009011C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423126, XrefRangeEnd = 423131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CannonicalizeElement_Private_XmlSchemaParticle_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
			}
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x00091F6C File Offset: 0x0009016C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423131, XrefRangeEnd = 423150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref root;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CannonicalizeGroupRef_Private_XmlSchemaParticle_XmlSchemaGroupRef_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x00091FCC File Offset: 0x000901CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423150, XrefRangeEnd = 423171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(all);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref root;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CannonicalizeAll_Private_XmlSchemaParticle_XmlSchemaAll_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x0009202C File Offset: 0x0009022C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423171, XrefRangeEnd = 423228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(choice);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref root;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CannonicalizeChoice_Private_XmlSchemaParticle_XmlSchemaChoice_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x0009208C File Offset: 0x0009028C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423228, XrefRangeEnd = 423285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref root;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CannonicalizeSequence_Private_XmlSchemaParticle_XmlSchemaSequence_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x000920EC File Offset: 0x000902EC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 423330, RefRangeEnd = 423338, XrefRangeStart = 423285, XrefRangeEnd = 423330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CannonicalizePointlessRoot_Private_XmlSchemaParticle_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
			}
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x0009213C File Offset: 0x0009033C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 423410, RefRangeEnd = 423418, XrefRangeStart = 423338, XrefRangeEnd = 423410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedParticle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseParticle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsValidRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x0009219C File Offset: 0x0009039C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423418, XrefRangeEnd = 423427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseElement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsElementFromElement_Private_Boolean_XmlSchemaElement_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x000921FC File Offset: 0x000903FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423427, XrefRangeEnd = 423431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseAny);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsElementFromAny_Private_Boolean_XmlSchemaElement_XmlSchemaAny_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x0009225C File Offset: 0x0009045C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423431, XrefRangeEnd = 423436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedAny);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseAny);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsAnyFromAny_Private_Boolean_XmlSchemaAny_XmlSchemaAny_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x000922BC File Offset: 0x000904BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423436, XrefRangeEnd = 423456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedGroupBase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseAny);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsGroupBaseFromAny_Private_Boolean_XmlSchemaGroupBase_XmlSchemaAny_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x0009231C File Offset: 0x0009051C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423456, XrefRangeEnd = 423582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseGroupBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsElementFromGroupBase_Private_Boolean_XmlSchemaElement_XmlSchemaGroupBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x0009237C File Offset: 0x0009057C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423582, XrefRangeEnd = 423590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedChoice);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseChoice);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsChoiceFromChoiceSubstGroup_Private_Boolean_XmlSchemaChoice_XmlSchemaChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x000923DC File Offset: 0x000905DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 423609, RefRangeEnd = 423612, XrefRangeStart = 423590, XrefRangeEnd = 423609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedGroupBase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseGroupBase);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipEmptableOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsGroupBaseFromGroupBase_Private_Boolean_XmlSchemaGroupBase_XmlSchemaGroupBase_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x0009244C File Offset: 0x0009064C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423612, XrefRangeEnd = 423633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedSequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseAll);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsSequenceFromAll_Private_Boolean_XmlSchemaSequence_XmlSchemaAll_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x000924AC File Offset: 0x000906AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423633, XrefRangeEnd = 423665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedSequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseChoice);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsSequenceFromChoice_Private_Boolean_XmlSchemaSequence_XmlSchemaChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x0009250C File Offset: 0x0009070C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423665, XrefRangeEnd = 423666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedParticle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseParticle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x0009256C File Offset: 0x0009076C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 423683, RefRangeEnd = 423693, XrefRangeStart = 423666, XrefRangeEnd = 423683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minOccurs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxOccurs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseMinOccurs;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseMaxOccurs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_Decimal_Decimal_Decimal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x000925E0 File Offset: 0x000907E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 423699, RefRangeEnd = 423702, XrefRangeStart = 423693, XrefRangeEnd = 423699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_GetMappingParticle_Private_Int32_XmlSchemaParticle_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00092640 File Offset: 0x00090840
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 423712, RefRangeEnd = 423714, XrefRangeStart = 423702, XrefRangeEnd = 423712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsParticleEmptiable(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsParticleEmptiable_Private_Boolean_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x00092690 File Offset: 0x00090890
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 423785, RefRangeEnd = 423788, XrefRangeStart = 423714, XrefRangeEnd = 423785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &minOccurs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxOccurs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CalculateEffectiveTotalRange_Private_Void_XmlSchemaParticle_byref_Decimal_byref_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x000926F0 File Offset: 0x000908F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423788, XrefRangeEnd = 423789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushComplexType(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_PushComplexType_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x00092734 File Offset: 0x00090934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(complexContent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_GetSchemaContentType_Private_XmlSchemaContentType_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x000927A8 File Offset: 0x000909A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 423860, RefRangeEnd = 423867, XrefRangeStart = 423789, XrefRangeEnd = 423860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x000927EC File Offset: 0x000909EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 424081, RefRangeEnd = 424086, XrefRangeStart = 423867, XrefRangeEnd = 424081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(derivedType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(anyAttribute);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref derivedBy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileLocalAttributes_Private_Void_XmlSchemaComplexType_XmlSchemaComplexType_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00092874 File Offset: 0x00090A74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 424196, RefRangeEnd = 424198, XrefRangeStart = 424086, XrefRangeEnd = 424196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseAttributeGroup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(derivedAttributeGroup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CheckAtrributeGroupRestriction_Private_Void_XmlSchemaAttributeGroup_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x000928C8 File Offset: 0x00090AC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424202, RefRangeEnd = 424203, XrefRangeStart = 424198, XrefRangeEnd = 424202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(derivedAttributeWildcard);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseAttributeWildcard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsProcessContentsRestricted_Private_Boolean_XmlSchemaComplexType_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x0009293C File Offset: 0x00090B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424203, XrefRangeEnd = 424207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileAnyAttributeUnion_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr3) : null;
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x000929A0 File Offset: 0x00090BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424207, XrefRangeEnd = 424211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileAnyAttributeIntersection_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr3) : null;
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00092A04 File Offset: 0x00090C04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 424265, RefRangeEnd = 424269, XrefRangeStart = 424211, XrefRangeEnd = 424265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileAttribute(XmlSchemaAttribute xa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileAttribute_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00092A48 File Offset: 0x00090C48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 424271, RefRangeEnd = 424273, XrefRangeStart = 424269, XrefRangeEnd = 424271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xa);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decl);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_SetDefaultFixed_Private_Void_XmlSchemaAttribute_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x00092A9C File Offset: 0x00090C9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 424307, RefRangeEnd = 424310, XrefRangeStart = 424273, XrefRangeEnd = 424307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x00092AE0 File Offset: 0x00090CE0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 424406, RefRangeEnd = 424411, XrefRangeStart = 424310, XrefRangeEnd = 424406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileElement(XmlSchemaElement xe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileElement_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x00092B24 File Offset: 0x00090D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424453, RefRangeEnd = 424454, XrefRangeStart = 424411, XrefRangeEnd = 424453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentValidator CompileComplexContent(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileComplexContent_Private_ContentValidator_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr3) : null;
			}
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x00092B74 File Offset: 0x00090D74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424546, RefRangeEnd = 424547, XrefRangeStart = 424454, XrefRangeEnd = 424546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contentValidator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_BuildParticleContentModel_Private_Boolean_ParticleContentValidator_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x00092BD4 File Offset: 0x00090DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424560, RefRangeEnd = 424561, XrefRangeStart = 424547, XrefRangeEnd = 424560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaComplexType_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x00092C28 File Offset: 0x00090E28
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 424573, RefRangeEnd = 424579, XrefRangeStart = 424561, XrefRangeEnd = 424573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileParticleElements(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x00092C6C File Offset: 0x00090E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424589, RefRangeEnd = 424590, XrefRangeStart = 424579, XrefRangeEnd = 424589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileComplexTypeElements(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileComplexTypeElements_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00092CB0 File Offset: 0x00090EB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 424595, RefRangeEnd = 424599, XrefRangeStart = 424590, XrefRangeEnd = 424595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_GetSimpleType_Private_XmlSchemaSimpleType_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00092D00 File Offset: 0x00090F00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 424603, RefRangeEnd = 424605, XrefRangeStart = 424599, XrefRangeEnd = 424603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaComplexType GetComplexType(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_GetComplexType_Private_XmlSchemaComplexType_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr3) : null;
			}
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00092D50 File Offset: 0x00090F50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 424613, RefRangeEnd = 424615, XrefRangeStart = 424605, XrefRangeEnd = 424613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaType GetAnySchemaType(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_GetAnySchemaType_Private_XmlSchemaType_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x00092DA0 File Offset: 0x00090FA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 424615, RefRangeEnd = 424618, XrefRangeStart = 424615, XrefRangeEnd = 424615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(to);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(from);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyParent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CopyPosition_Private_Void_XmlSchemaAnnotated_XmlSchemaAnnotated_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00092E04 File Offset: 0x00091004
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 424621, RefRangeEnd = 424625, XrefRangeStart = 424618, XrefRangeEnd = 424621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseDecl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(derivedDecl);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsFixedEqual_Private_Boolean_SchemaDeclBase_SchemaDeclBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x0000D539 File Offset: 0x0000B739
		public Compiler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x00092E64 File Offset: 0x00091064
		// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x0000D542 File Offset: 0x0000B742
		public unsafe string restrictionErrorMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_restrictionErrorMsg);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_restrictionErrorMsg), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x00092E8C File Offset: 0x0009108C
		// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x0000D561 File Offset: 0x0000B761
		public unsafe XmlSchemaObjectTable attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x00092EBC File Offset: 0x000910BC
		// (set) Token: 0x06001EBB RID: 7867 RVA: 0x0000D580 File Offset: 0x0000B780
		public unsafe XmlSchemaObjectTable attributeGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_attributeGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_attributeGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x00092EEC File Offset: 0x000910EC
		// (set) Token: 0x06001EBD RID: 7869 RVA: 0x0000D59F File Offset: 0x0000B79F
		public unsafe XmlSchemaObjectTable elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x00092F1C File Offset: 0x0009111C
		// (set) Token: 0x06001EBF RID: 7871 RVA: 0x0000D5BE File Offset: 0x0000B7BE
		public unsafe XmlSchemaObjectTable schemaTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_schemaTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_schemaTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x00092F4C File Offset: 0x0009114C
		// (set) Token: 0x06001EC1 RID: 7873 RVA: 0x0000D5DD File Offset: 0x0000B7DD
		public unsafe XmlSchemaObjectTable groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x00092F7C File Offset: 0x0009117C
		// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x0000D5FC File Offset: 0x0000B7FC
		public unsafe XmlSchemaObjectTable notations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_notations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_notations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x00092FAC File Offset: 0x000911AC
		// (set) Token: 0x06001EC5 RID: 7877 RVA: 0x0000D61B File Offset: 0x0000B81B
		public unsafe XmlSchemaObjectTable examplars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_examplars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_examplars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x00092FDC File Offset: 0x000911DC
		// (set) Token: 0x06001EC7 RID: 7879 RVA: 0x0000D63A File Offset: 0x0000B83A
		public unsafe XmlSchemaObjectTable identityConstraints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_identityConstraints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_identityConstraints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x0009300C File Offset: 0x0009120C
		// (set) Token: 0x06001EC9 RID: 7881 RVA: 0x0000D659 File Offset: 0x0000B859
		public unsafe Stack complexTypeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_complexTypeStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_complexTypeStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x0009303C File Offset: 0x0009123C
		// (set) Token: 0x06001ECB RID: 7883 RVA: 0x0000D678 File Offset: 0x0000B878
		public unsafe Hashtable schemasToCompile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_schemasToCompile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_schemasToCompile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x0009306C File Offset: 0x0009126C
		// (set) Token: 0x06001ECD RID: 7885 RVA: 0x0000D697 File Offset: 0x0000B897
		public unsafe Hashtable importedSchemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_importedSchemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_importedSchemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x0009309C File Offset: 0x0009129C
		// (set) Token: 0x06001ECF RID: 7887 RVA: 0x0000D6B6 File Offset: 0x0000B8B6
		public unsafe XmlSchema schemaForSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_schemaForSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_schemaForSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001689 RID: 5769
		private static readonly IntPtr NativeFieldInfoPtr_restrictionErrorMsg;

		// Token: 0x0400168A RID: 5770
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x0400168B RID: 5771
		private static readonly IntPtr NativeFieldInfoPtr_attributeGroups;

		// Token: 0x0400168C RID: 5772
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x0400168D RID: 5773
		private static readonly IntPtr NativeFieldInfoPtr_schemaTypes;

		// Token: 0x0400168E RID: 5774
		private static readonly IntPtr NativeFieldInfoPtr_groups;

		// Token: 0x0400168F RID: 5775
		private static readonly IntPtr NativeFieldInfoPtr_notations;

		// Token: 0x04001690 RID: 5776
		private static readonly IntPtr NativeFieldInfoPtr_examplars;

		// Token: 0x04001691 RID: 5777
		private static readonly IntPtr NativeFieldInfoPtr_identityConstraints;

		// Token: 0x04001692 RID: 5778
		private static readonly IntPtr NativeFieldInfoPtr_complexTypeStack;

		// Token: 0x04001693 RID: 5779
		private static readonly IntPtr NativeFieldInfoPtr_schemasToCompile;

		// Token: 0x04001694 RID: 5780
		private static readonly IntPtr NativeFieldInfoPtr_importedSchemas;

		// Token: 0x04001695 RID: 5781
		private static readonly IntPtr NativeFieldInfoPtr_schemaForSchema;

		// Token: 0x04001696 RID: 5782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_ValidationEventHandler_XmlSchema_XmlSchemaCompilationSettings_0;

		// Token: 0x04001697 RID: 5783
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchemaSet_SchemaInfo_0;

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Internal_Void_XmlSchema_Boolean_0;

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSForSSimpleTypes_Private_Void_0;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeMethodInfoPtr_Output_Private_Void_SchemaInfo_0;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeMethodInfoPtr_ImportAllCompiledSchemas_Internal_Void_XmlSchemaSet_0;

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Internal_Boolean_0;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeMethodInfoPtr_CleanupAttribute_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeMethodInfoPtr_CleanupAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeMethodInfoPtr_CleanupComplexType_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeMethodInfoPtr_CleanupSimpleType_Private_Void_XmlSchemaSimpleType_0;

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeMethodInfoPtr_CleanupElement_Private_Void_XmlSchemaElement_0;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeMethodInfoPtr_CleanupAttributes_Private_Void_XmlSchemaObjectCollection_0;

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeMethodInfoPtr_CleanupGroup_Private_Void_XmlSchemaGroup_0;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeMethodInfoPtr_CleanupParticle_Private_Void_XmlSchemaParticle_0;

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSubstitutionGroups_Private_Void_0;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeMethodInfoPtr_CompileSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_0;

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeMethodInfoPtr_RecursivelyCheckRedefinedGroups_Private_Void_XmlSchemaGroup_XmlSchemaGroup_0;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeMethodInfoPtr_RecursivelyCheckRedefinedAttributeGroups_Private_Void_XmlSchemaAttributeGroup_XmlSchemaAttributeGroup_0;

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeMethodInfoPtr_CompileGroup_Private_Void_XmlSchemaGroup_0;

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeMethodInfoPtr_CompileSimpleType_Private_Void_XmlSchemaSimpleType_0;

		// Token: 0x040016AB RID: 5803
		private static readonly IntPtr NativeMethodInfoPtr_CompileBaseMemberTypes_Private_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaSimpleType_0;

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeMethodInfoPtr_CheckUnionType_Private_Void_XmlSchemaSimpleType_ArrayList_XmlSchemaSimpleType_0;

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeMethodInfoPtr_CompileComplexType_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeMethodInfoPtr_CompileSimpleContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentExtension_0;

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeMethodInfoPtr_CompileSimpleContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentRestriction_0;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeMethodInfoPtr_CompileComplexContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentExtension_0;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeMethodInfoPtr_CompileComplexContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentRestriction_0;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaParticle_XmlSchemaParticle_0;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeMethodInfoPtr_CompileContentTypeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_0;

		// Token: 0x040016B5 RID: 5813
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_0;

		// Token: 0x040016B6 RID: 5814
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeElement_Private_XmlSchemaParticle_XmlSchemaElement_0;

		// Token: 0x040016B7 RID: 5815
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeGroupRef_Private_XmlSchemaParticle_XmlSchemaGroupRef_Boolean_0;

		// Token: 0x040016B8 RID: 5816
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeAll_Private_XmlSchemaParticle_XmlSchemaAll_Boolean_0;

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeChoice_Private_XmlSchemaParticle_XmlSchemaChoice_Boolean_0;

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeSequence_Private_XmlSchemaParticle_XmlSchemaSequence_Boolean_0;

		// Token: 0x040016BB RID: 5819
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizePointlessRoot_Private_XmlSchemaParticle_XmlSchemaParticle_0;

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeMethodInfoPtr_IsValidRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeMethodInfoPtr_IsElementFromElement_Private_Boolean_XmlSchemaElement_XmlSchemaElement_0;

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeMethodInfoPtr_IsElementFromAny_Private_Boolean_XmlSchemaElement_XmlSchemaAny_0;

		// Token: 0x040016BF RID: 5823
		private static readonly IntPtr NativeMethodInfoPtr_IsAnyFromAny_Private_Boolean_XmlSchemaAny_XmlSchemaAny_0;

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeMethodInfoPtr_IsGroupBaseFromAny_Private_Boolean_XmlSchemaGroupBase_XmlSchemaAny_0;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeMethodInfoPtr_IsElementFromGroupBase_Private_Boolean_XmlSchemaElement_XmlSchemaGroupBase_0;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeMethodInfoPtr_IsChoiceFromChoiceSubstGroup_Private_Boolean_XmlSchemaChoice_XmlSchemaChoice_0;

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeMethodInfoPtr_IsGroupBaseFromGroupBase_Private_Boolean_XmlSchemaGroupBase_XmlSchemaGroupBase_Boolean_0;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeMethodInfoPtr_IsSequenceFromAll_Private_Boolean_XmlSchemaSequence_XmlSchemaAll_0;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeMethodInfoPtr_IsSequenceFromChoice_Private_Boolean_XmlSchemaSequence_XmlSchemaChoice_0;

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_Decimal_Decimal_Decimal_Decimal_0;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeMethodInfoPtr_GetMappingParticle_Private_Int32_XmlSchemaParticle_XmlSchemaObjectCollection_0;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr_IsParticleEmptiable_Private_Boolean_XmlSchemaParticle_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr_CalculateEffectiveTotalRange_Private_Void_XmlSchemaParticle_byref_Decimal_byref_Decimal_0;

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr_PushComplexType_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaContentType_Private_XmlSchemaContentType_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaParticle_0;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr_CompileAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeMethodInfoPtr_CompileLocalAttributes_Private_Void_XmlSchemaComplexType_XmlSchemaComplexType_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaDerivationMethod_0;

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeMethodInfoPtr_CheckAtrributeGroupRestriction_Private_Void_XmlSchemaAttributeGroup_XmlSchemaAttributeGroup_0;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeMethodInfoPtr_IsProcessContentsRestricted_Private_Boolean_XmlSchemaComplexType_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeMethodInfoPtr_CompileAnyAttributeUnion_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0;

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeMethodInfoPtr_CompileAnyAttributeIntersection_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0;

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeMethodInfoPtr_CompileAttribute_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x040016D4 RID: 5844
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultFixed_Private_Void_XmlSchemaAttribute_SchemaAttDef_0;

		// Token: 0x040016D5 RID: 5845
		private static readonly IntPtr NativeMethodInfoPtr_CompileIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0;

		// Token: 0x040016D6 RID: 5846
		private static readonly IntPtr NativeMethodInfoPtr_CompileElement_Private_Void_XmlSchemaElement_0;

		// Token: 0x040016D7 RID: 5847
		private static readonly IntPtr NativeMethodInfoPtr_CompileComplexContent_Private_ContentValidator_XmlSchemaComplexType_0;

		// Token: 0x040016D8 RID: 5848
		private static readonly IntPtr NativeMethodInfoPtr_BuildParticleContentModel_Private_Boolean_ParticleContentValidator_XmlSchemaParticle_0;

		// Token: 0x040016D9 RID: 5849
		private static readonly IntPtr NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaComplexType_XmlSchemaParticle_0;

		// Token: 0x040016DA RID: 5850
		private static readonly IntPtr NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaParticle_0;

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeMethodInfoPtr_CompileComplexTypeElements_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleType_Private_XmlSchemaSimpleType_XmlQualifiedName_0;

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeMethodInfoPtr_GetComplexType_Private_XmlSchemaComplexType_XmlQualifiedName_0;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeMethodInfoPtr_GetAnySchemaType_Private_XmlSchemaType_XmlQualifiedName_0;

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeMethodInfoPtr_CopyPosition_Private_Void_XmlSchemaAnnotated_XmlSchemaAnnotated_Boolean_0;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeMethodInfoPtr_IsFixedEqual_Private_Boolean_SchemaDeclBase_SchemaDeclBase_0;
	}
}
