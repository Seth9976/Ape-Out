using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000199 RID: 409
	public class XmlSchemaComplexType : XmlSchemaType
	{
		// Token: 0x060021A3 RID: 8611 RVA: 0x0009DB7C File Offset: 0x0009BD7C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaComplexType()
		{
			Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaComplexType");
			XmlSchemaComplexType.NativeFieldInfoPtr_block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "block");
			XmlSchemaComplexType.NativeFieldInfoPtr_contentModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "contentModel");
			XmlSchemaComplexType.NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "particle");
			XmlSchemaComplexType.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "attributes");
			XmlSchemaComplexType.NativeFieldInfoPtr_anyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "anyAttribute");
			XmlSchemaComplexType.NativeFieldInfoPtr_contentTypeParticle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "contentTypeParticle");
			XmlSchemaComplexType.NativeFieldInfoPtr_blockResolved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "blockResolved");
			XmlSchemaComplexType.NativeFieldInfoPtr_localElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "localElements");
			XmlSchemaComplexType.NativeFieldInfoPtr_attributeUses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "attributeUses");
			XmlSchemaComplexType.NativeFieldInfoPtr_attributeWildcard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "attributeWildcard");
			XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeLax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "anyTypeLax");
			XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "anyTypeSkip");
			XmlSchemaComplexType.NativeFieldInfoPtr_untypedAnyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "untypedAnyType");
			XmlSchemaComplexType.NativeFieldInfoPtr_pvFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "pvFlags");
			XmlSchemaComplexType.NativeMethodInfoPtr_CreateAnyType_Private_Static_XmlSchemaComplexType_XmlSchemaContentProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668088);
			XmlSchemaComplexType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668089);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_AnyType_Internal_Static_get_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668090);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_UntypedAnyType_Internal_Static_get_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668091);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_AnyTypeContentValidator_Internal_Static_get_ContentValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668092);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_IsAbstract_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668093);
			XmlSchemaComplexType.NativeMethodInfoPtr_set_IsAbstract_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668094);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_Block_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668095);
			XmlSchemaComplexType.NativeMethodInfoPtr_set_Block_Public_set_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668096);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_IsMixed_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668097);
			XmlSchemaComplexType.NativeMethodInfoPtr_set_IsMixed_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668098);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_ContentModel_Public_get_XmlSchemaContentModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668099);
			XmlSchemaComplexType.NativeMethodInfoPtr_set_ContentModel_Public_set_Void_XmlSchemaContentModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668100);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_Particle_Public_get_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668101);
			XmlSchemaComplexType.NativeMethodInfoPtr_set_Particle_Public_set_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668102);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668103);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668104);
			XmlSchemaComplexType.NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668105);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668106);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_ContentTypeParticle_Public_get_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668107);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_BlockResolved_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668108);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_AttributeUses_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668109);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_AttributeWildcard_Public_get_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668110);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_LocalElements_Internal_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668111);
			XmlSchemaComplexType.NativeMethodInfoPtr_SetContentTypeParticle_Internal_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668112);
			XmlSchemaComplexType.NativeMethodInfoPtr_SetBlockResolved_Internal_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668113);
			XmlSchemaComplexType.NativeMethodInfoPtr_SetAttributeWildcard_Internal_Void_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668114);
			XmlSchemaComplexType.NativeMethodInfoPtr_set_HasWildCard_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668115);
			XmlSchemaComplexType.NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668116);
			XmlSchemaComplexType.NativeMethodInfoPtr_ContainsIdAttribute_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668117);
			XmlSchemaComplexType.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668118);
			XmlSchemaComplexType.NativeMethodInfoPtr_Clone_Internal_XmlSchemaObject_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668119);
			XmlSchemaComplexType.NativeMethodInfoPtr_ClearCompiledState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668120);
			XmlSchemaComplexType.NativeMethodInfoPtr_CloneAttributes_Internal_Static_XmlSchemaObjectCollection_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668121);
			XmlSchemaComplexType.NativeMethodInfoPtr_CloneGroupBaseParticles_Private_Static_XmlSchemaObjectCollection_XmlSchemaObjectCollection_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668122);
			XmlSchemaComplexType.NativeMethodInfoPtr_CloneParticle_Internal_Static_XmlSchemaParticle_XmlSchemaParticle_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668123);
			XmlSchemaComplexType.NativeMethodInfoPtr_GetResolvedElementForm_Private_Static_XmlSchemaForm_XmlSchema_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668124);
			XmlSchemaComplexType.NativeMethodInfoPtr_HasParticleRef_Internal_Static_Boolean_XmlSchemaParticle_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668125);
			XmlSchemaComplexType.NativeMethodInfoPtr_HasAttributeQNameRef_Internal_Static_Boolean_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668126);
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x0009DFC8 File Offset: 0x0009C1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426585, XrefRangeEnd = 426636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref processContents;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_CreateAnyType_Private_Static_XmlSchemaComplexType_XmlSchemaContentProcessing_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr3) : null;
			}
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x0009E008 File Offset: 0x0009C208
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 426641, RefRangeEnd = 426643, XrefRangeStart = 426636, XrefRangeEnd = 426641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaComplexType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x0009E044 File Offset: 0x0009C244
		public unsafe static XmlSchemaComplexType AnyType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426643, XrefRangeEnd = 426647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_AnyType_Internal_Static_get_XmlSchemaComplexType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr3) : null;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x0009E078 File Offset: 0x0009C278
		public unsafe static XmlSchemaComplexType UntypedAnyType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426647, XrefRangeEnd = 426651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_UntypedAnyType_Internal_Static_get_XmlSchemaComplexType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr3) : null;
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x0009E0AC File Offset: 0x0009C2AC
		public unsafe static ContentValidator AnyTypeContentValidator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426651, XrefRangeEnd = 426655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_AnyTypeContentValidator_Internal_Static_get_ContentValidator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr3) : null;
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x0009E0E0 File Offset: 0x0009C2E0
		// (set) Token: 0x060021AA RID: 8618 RVA: 0x0009E11C File Offset: 0x0009C31C
		public unsafe bool IsAbstract
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_IsAbstract_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_set_IsAbstract_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x0009E15C File Offset: 0x0009C35C
		// (set) Token: 0x060021AC RID: 8620 RVA: 0x0009E198 File Offset: 0x0009C398
		public unsafe XmlSchemaDerivationMethod Block
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 381016, RefRangeEnd = 381017, XrefRangeStart = 381016, XrefRangeEnd = 381017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_Block_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_set_Block_Public_set_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x0009E1D8 File Offset: 0x0009C3D8
		// (set) Token: 0x060021AE RID: 8622 RVA: 0x0009E220 File Offset: 0x0009C420
		public unsafe override bool IsMixed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaComplexType.NativeMethodInfoPtr_get_IsMixed_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaComplexType.NativeMethodInfoPtr_set_IsMixed_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x0009E26C File Offset: 0x0009C46C
		// (set) Token: 0x060021B0 RID: 8624 RVA: 0x0009E2AC File Offset: 0x0009C4AC
		public unsafe XmlSchemaContentModel ContentModel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_ContentModel_Public_get_XmlSchemaContentModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaContentModel>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 413738, RefRangeEnd = 413741, XrefRangeStart = 413738, XrefRangeEnd = 413741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_set_ContentModel_Public_set_Void_XmlSchemaContentModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x0009E2F0 File Offset: 0x0009C4F0
		// (set) Token: 0x060021B2 RID: 8626 RVA: 0x0009E330 File Offset: 0x0009C530
		public unsafe XmlSchemaParticle Particle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_Particle_Public_get_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 386299, RefRangeEnd = 386301, XrefRangeStart = 386299, XrefRangeEnd = 386301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_set_Particle_Public_set_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x0009E374 File Offset: 0x0009C574
		public unsafe XmlSchemaObjectCollection Attributes
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 426659, RefRangeEnd = 426672, XrefRangeStart = 426655, XrefRangeEnd = 426659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x0009E3B4 File Offset: 0x0009C5B4
		// (set) Token: 0x060021B5 RID: 8629 RVA: 0x0009E3F4 File Offset: 0x0009C5F4
		public unsafe XmlSchemaAnyAttribute AnyAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x0009E438 File Offset: 0x0009C638
		public unsafe XmlSchemaContentType ContentType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x0009E474 File Offset: 0x0009C674
		public unsafe XmlSchemaParticle ContentTypeParticle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_ContentTypeParticle_Public_get_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x0009E4B4 File Offset: 0x0009C6B4
		public unsafe XmlSchemaDerivationMethod BlockResolved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_BlockResolved_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x0009E4F0 File Offset: 0x0009C6F0
		public unsafe XmlSchemaObjectTable AttributeUses
		{
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 426676, RefRangeEnd = 426707, XrefRangeStart = 426672, XrefRangeEnd = 426676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_AttributeUses_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x0009E530 File Offset: 0x0009C730
		public unsafe XmlSchemaAnyAttribute AttributeWildcard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_AttributeWildcard_Public_get_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x0009E570 File Offset: 0x0009C770
		public unsafe XmlSchemaObjectTable LocalElements
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 426711, RefRangeEnd = 426718, XrefRangeStart = 426707, XrefRangeEnd = 426711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_LocalElements_Internal_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x0009E5B0 File Offset: 0x0009C7B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 386301, RefRangeEnd = 386305, XrefRangeStart = 386301, XrefRangeEnd = 386305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContentTypeParticle(XmlSchemaParticle value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_SetContentTypeParticle_Internal_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0009E5F4 File Offset: 0x0009C7F4
		[CallerCount(0)]
		public unsafe void SetBlockResolved(XmlSchemaDerivationMethod value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_SetBlockResolved_Internal_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0009E634 File Offset: 0x0009C834
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 426718, RefRangeEnd = 426723, XrefRangeStart = 426718, XrefRangeEnd = 426718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAttributeWildcard(XmlSchemaAnyAttribute value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_SetAttributeWildcard_Internal_Void_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (set) Token: 0x060021BF RID: 8639 RVA: 0x0009E678 File Offset: 0x0009C878
		public unsafe bool HasWildCard
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_set_HasWildCard_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x0009E6B8 File Offset: 0x0009C8B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 426723, RefRangeEnd = 426724, XrefRangeStart = 426723, XrefRangeEnd = 426723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAttributes(XmlSchemaObjectCollection newAttributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newAttributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x0009E6FC File Offset: 0x0009C8FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 426743, RefRangeEnd = 426745, XrefRangeStart = 426724, XrefRangeEnd = 426743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsIdAttribute(bool findAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref findAll;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_ContainsIdAttribute_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0009E748 File Offset: 0x0009C948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426745, XrefRangeEnd = 426746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlSchemaObject Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaComplexType.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x0009E794 File Offset: 0x0009C994
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 426832, RefRangeEnd = 426835, XrefRangeStart = 426746, XrefRangeEnd = 426832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaObject Clone(XmlSchema parentSchema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_Clone_Internal_XmlSchemaObject_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
			}
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x0009E7E4 File Offset: 0x0009C9E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 426839, RefRangeEnd = 426840, XrefRangeStart = 426835, XrefRangeEnd = 426839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCompiledState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_ClearCompiledState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x0009E818 File Offset: 0x0009CA18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 426846, RefRangeEnd = 426852, XrefRangeStart = 426840, XrefRangeEnd = 426846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_CloneAttributes_Internal_Static_XmlSchemaObjectCollection_XmlSchemaObjectCollection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x0009E85C File Offset: 0x0009CA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426852, XrefRangeEnd = 426862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupBaseParticles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_CloneGroupBaseParticles_Private_Static_XmlSchemaObjectCollection_XmlSchemaObjectCollection_XmlSchema_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x0009E8B4 File Offset: 0x0009CAB4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 426893, RefRangeEnd = 426899, XrefRangeStart = 426862, XrefRangeEnd = 426893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_CloneParticle_Internal_Static_XmlSchemaParticle_XmlSchemaParticle_XmlSchema_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x0009E90C File Offset: 0x0009CB0C
		[CallerCount(0)]
		public unsafe static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(element);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_GetResolvedElementForm_Private_Static_XmlSchemaForm_XmlSchema_XmlSchemaElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x0009E960 File Offset: 0x0009CB60
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 426918, RefRangeEnd = 426923, XrefRangeStart = 426899, XrefRangeEnd = 426918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_HasParticleRef_Internal_Static_Boolean_XmlSchemaParticle_XmlSchema_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x0009E9B4 File Offset: 0x0009CBB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 426929, RefRangeEnd = 426931, XrefRangeStart = 426923, XrefRangeEnd = 426929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_HasAttributeQNameRef_Internal_Static_Boolean_XmlSchemaObjectCollection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x0000E9F3 File Offset: 0x0000CBF3
		public XmlSchemaComplexType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x0009E9F8 File Offset: 0x0009CBF8
		// (set) Token: 0x060021CD RID: 8653 RVA: 0x0000E9FC File Offset: 0x0000CBFC
		public unsafe XmlSchemaDerivationMethod block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_block);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_block)) = value;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x0009EA20 File Offset: 0x0009CC20
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x0000EA17 File Offset: 0x0000CC17
		public unsafe XmlSchemaContentModel contentModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_contentModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaContentModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_contentModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x0009EA50 File Offset: 0x0009CC50
		// (set) Token: 0x060021D1 RID: 8657 RVA: 0x0000EA36 File Offset: 0x0000CC36
		public unsafe XmlSchemaParticle particle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_particle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_particle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x060021D2 RID: 8658 RVA: 0x0009EA80 File Offset: 0x0009CC80
		// (set) Token: 0x060021D3 RID: 8659 RVA: 0x0000EA55 File Offset: 0x0000CC55
		public unsafe XmlSchemaObjectCollection attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x0009EAB0 File Offset: 0x0009CCB0
		// (set) Token: 0x060021D5 RID: 8661 RVA: 0x0000EA74 File Offset: 0x0000CC74
		public unsafe XmlSchemaAnyAttribute anyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_anyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_anyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x0009EAE0 File Offset: 0x0009CCE0
		// (set) Token: 0x060021D7 RID: 8663 RVA: 0x0000EA93 File Offset: 0x0000CC93
		public unsafe XmlSchemaParticle contentTypeParticle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_contentTypeParticle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_contentTypeParticle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x0009EB10 File Offset: 0x0009CD10
		// (set) Token: 0x060021D9 RID: 8665 RVA: 0x0000EAB2 File Offset: 0x0000CCB2
		public unsafe XmlSchemaDerivationMethod blockResolved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_blockResolved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_blockResolved)) = value;
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x0009EB38 File Offset: 0x0009CD38
		// (set) Token: 0x060021DB RID: 8667 RVA: 0x0000EACD File Offset: 0x0000CCCD
		public unsafe XmlSchemaObjectTable localElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_localElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_localElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x0009EB68 File Offset: 0x0009CD68
		// (set) Token: 0x060021DD RID: 8669 RVA: 0x0000EAEC File Offset: 0x0000CCEC
		public unsafe XmlSchemaObjectTable attributeUses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_attributeUses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_attributeUses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x060021DE RID: 8670 RVA: 0x0009EB98 File Offset: 0x0009CD98
		// (set) Token: 0x060021DF RID: 8671 RVA: 0x0000EB0B File Offset: 0x0000CD0B
		public unsafe XmlSchemaAnyAttribute attributeWildcard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_attributeWildcard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_attributeWildcard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x060021E0 RID: 8672 RVA: 0x0009EBC8 File Offset: 0x0009CDC8
		// (set) Token: 0x060021E1 RID: 8673 RVA: 0x0000EB2A File Offset: 0x0000CD2A
		public unsafe static XmlSchemaComplexType anyTypeLax
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeLax, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeLax, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x0009EBF0 File Offset: 0x0009CDF0
		// (set) Token: 0x060021E3 RID: 8675 RVA: 0x0000EB3C File Offset: 0x0000CD3C
		public unsafe static XmlSchemaComplexType anyTypeSkip
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeSkip, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeSkip, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x0009EC18 File Offset: 0x0009CE18
		// (set) Token: 0x060021E5 RID: 8677 RVA: 0x0000EB4E File Offset: 0x0000CD4E
		public unsafe static XmlSchemaComplexType untypedAnyType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaComplexType.NativeFieldInfoPtr_untypedAnyType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaComplexType.NativeFieldInfoPtr_untypedAnyType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x0009EC40 File Offset: 0x0009CE40
		// (set) Token: 0x060021E7 RID: 8679 RVA: 0x0000EB60 File Offset: 0x0000CD60
		public unsafe byte pvFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_pvFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_pvFlags)) = value;
			}
		}

		// Token: 0x040018EC RID: 6380
		private static readonly IntPtr NativeFieldInfoPtr_block;

		// Token: 0x040018ED RID: 6381
		private static readonly IntPtr NativeFieldInfoPtr_contentModel;

		// Token: 0x040018EE RID: 6382
		private static readonly IntPtr NativeFieldInfoPtr_particle;

		// Token: 0x040018EF RID: 6383
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x040018F0 RID: 6384
		private static readonly IntPtr NativeFieldInfoPtr_anyAttribute;

		// Token: 0x040018F1 RID: 6385
		private static readonly IntPtr NativeFieldInfoPtr_contentTypeParticle;

		// Token: 0x040018F2 RID: 6386
		private static readonly IntPtr NativeFieldInfoPtr_blockResolved;

		// Token: 0x040018F3 RID: 6387
		private static readonly IntPtr NativeFieldInfoPtr_localElements;

		// Token: 0x040018F4 RID: 6388
		private static readonly IntPtr NativeFieldInfoPtr_attributeUses;

		// Token: 0x040018F5 RID: 6389
		private static readonly IntPtr NativeFieldInfoPtr_attributeWildcard;

		// Token: 0x040018F6 RID: 6390
		private static readonly IntPtr NativeFieldInfoPtr_anyTypeLax;

		// Token: 0x040018F7 RID: 6391
		private static readonly IntPtr NativeFieldInfoPtr_anyTypeSkip;

		// Token: 0x040018F8 RID: 6392
		private static readonly IntPtr NativeFieldInfoPtr_untypedAnyType;

		// Token: 0x040018F9 RID: 6393
		private static readonly IntPtr NativeFieldInfoPtr_pvFlags;

		// Token: 0x040018FA RID: 6394
		private static readonly IntPtr NativeMethodInfoPtr_CreateAnyType_Private_Static_XmlSchemaComplexType_XmlSchemaContentProcessing_0;

		// Token: 0x040018FB RID: 6395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018FC RID: 6396
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyType_Internal_Static_get_XmlSchemaComplexType_0;

		// Token: 0x040018FD RID: 6397
		private static readonly IntPtr NativeMethodInfoPtr_get_UntypedAnyType_Internal_Static_get_XmlSchemaComplexType_0;

		// Token: 0x040018FE RID: 6398
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyTypeContentValidator_Internal_Static_get_ContentValidator_0;

		// Token: 0x040018FF RID: 6399
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAbstract_Public_get_Boolean_0;

		// Token: 0x04001900 RID: 6400
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAbstract_Public_set_Void_Boolean_0;

		// Token: 0x04001901 RID: 6401
		private static readonly IntPtr NativeMethodInfoPtr_get_Block_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeMethodInfoPtr_set_Block_Public_set_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMixed_Public_Virtual_get_Boolean_0;

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMixed_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentModel_Public_get_XmlSchemaContentModel_0;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentModel_Public_set_Void_XmlSchemaContentModel_0;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeMethodInfoPtr_get_Particle_Public_get_XmlSchemaParticle_0;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeMethodInfoPtr_set_Particle_Public_set_Void_XmlSchemaParticle_0;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentTypeParticle_Public_get_XmlSchemaParticle_0;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockResolved_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeUses_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeWildcard_Public_get_XmlSchemaAnyAttribute_0;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalElements_Internal_get_XmlSchemaObjectTable_0;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeMethodInfoPtr_SetContentTypeParticle_Internal_Void_XmlSchemaParticle_0;

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeMethodInfoPtr_SetBlockResolved_Internal_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributeWildcard_Internal_Void_XmlSchemaAnyAttribute_0;

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeMethodInfoPtr_set_HasWildCard_Internal_set_Void_Boolean_0;

		// Token: 0x04001916 RID: 6422
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0;

		// Token: 0x04001917 RID: 6423
		private static readonly IntPtr NativeMethodInfoPtr_ContainsIdAttribute_Internal_Boolean_Boolean_0;

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0;

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_XmlSchemaObject_XmlSchema_0;

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeMethodInfoPtr_ClearCompiledState_Private_Void_0;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeMethodInfoPtr_CloneAttributes_Internal_Static_XmlSchemaObjectCollection_XmlSchemaObjectCollection_0;

		// Token: 0x0400191C RID: 6428
		private static readonly IntPtr NativeMethodInfoPtr_CloneGroupBaseParticles_Private_Static_XmlSchemaObjectCollection_XmlSchemaObjectCollection_XmlSchema_0;

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeMethodInfoPtr_CloneParticle_Internal_Static_XmlSchemaParticle_XmlSchemaParticle_XmlSchema_0;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeMethodInfoPtr_GetResolvedElementForm_Private_Static_XmlSchemaForm_XmlSchema_XmlSchemaElement_0;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeMethodInfoPtr_HasParticleRef_Internal_Static_Boolean_XmlSchemaParticle_XmlSchema_0;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeMethodInfoPtr_HasAttributeQNameRef_Internal_Static_Boolean_XmlSchemaObjectCollection_0;
	}
}
