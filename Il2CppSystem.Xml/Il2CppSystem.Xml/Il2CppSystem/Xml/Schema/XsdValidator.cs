using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001ED RID: 493
	public sealed class XsdValidator : BaseValidator
	{
		// Token: 0x06002969 RID: 10601 RVA: 0x000BDA24 File Offset: 0x000BBC24
		// Note: this type is marked as 'beforefieldinit'.
		static XsdValidator()
		{
			Il2CppClassPointerStore<XsdValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr);
			XsdValidator.NativeFieldInfoPtr_startIDConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "startIDConstraint");
			XsdValidator.NativeFieldInfoPtr_validationStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "validationStack");
			XsdValidator.NativeFieldInfoPtr_attPresence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "attPresence");
			XsdValidator.NativeFieldInfoPtr_nsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "nsManager");
			XsdValidator.NativeFieldInfoPtr_bManageNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "bManageNamespaces");
			XsdValidator.NativeFieldInfoPtr_IDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "IDs");
			XsdValidator.NativeFieldInfoPtr_idRefListHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "idRefListHead");
			XsdValidator.NativeFieldInfoPtr_inlineSchemaParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "inlineSchemaParser");
			XsdValidator.NativeFieldInfoPtr_processContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "processContents");
			XsdValidator.NativeFieldInfoPtr_dtCDATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "dtCDATA");
			XsdValidator.NativeFieldInfoPtr_dtQName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "dtQName");
			XsdValidator.NativeFieldInfoPtr_dtStringArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "dtStringArray");
			XsdValidator.NativeFieldInfoPtr_NsXmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "NsXmlNs");
			XsdValidator.NativeFieldInfoPtr_NsXs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "NsXs");
			XsdValidator.NativeFieldInfoPtr_NsXsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "NsXsi");
			XsdValidator.NativeFieldInfoPtr_XsiType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "XsiType");
			XsdValidator.NativeFieldInfoPtr_XsiNil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "XsiNil");
			XsdValidator.NativeFieldInfoPtr_XsiSchemaLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "XsiSchemaLocation");
			XsdValidator.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "XsiNoNamespaceSchemaLocation");
			XsdValidator.NativeFieldInfoPtr_XsdSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "XsdSchema");
			XsdValidator.NativeMethodInfoPtr__ctor_Internal_Void_BaseValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669218);
			XsdValidator.NativeMethodInfoPtr__ctor_Internal_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669219);
			XsdValidator.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669220);
			XsdValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669221);
			XsdValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669222);
			XsdValidator.NativeMethodInfoPtr_get_IsInlineSchemaStarted_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669223);
			XsdValidator.NativeMethodInfoPtr_ProcessInlineSchema_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669224);
			XsdValidator.NativeMethodInfoPtr_ValidateElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669225);
			XsdValidator.NativeMethodInfoPtr_ValidateChildElement_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669226);
			XsdValidator.NativeMethodInfoPtr_ProcessElement_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669227);
			XsdValidator.NativeMethodInfoPtr_ProcessXsiAttributes_Private_Void_byref_XmlQualifiedName_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669228);
			XsdValidator.NativeMethodInfoPtr_ValidateEndElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669229);
			XsdValidator.NativeMethodInfoPtr_FastGetElementDecl_Private_SchemaElementDecl_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669230);
			XsdValidator.NativeMethodInfoPtr_ThoroughGetElementDecl_Private_SchemaElementDecl_SchemaElementDecl_XmlQualifiedName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669231);
			XsdValidator.NativeMethodInfoPtr_ValidateStartElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669232);
			XsdValidator.NativeMethodInfoPtr_ValidateEndStartElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669233);
			XsdValidator.NativeMethodInfoPtr_LoadSchemaFromLocation_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669234);
			XsdValidator.NativeMethodInfoPtr_LoadSchema_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669235);
			XsdValidator.NativeMethodInfoPtr_get_HasSchema_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669236);
			XsdValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669237);
			XsdValidator.NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669238);
			XsdValidator.NativeMethodInfoPtr_CheckValue_Private_Void_String_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669239);
			XsdValidator.NativeMethodInfoPtr_AddID_Internal_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669240);
			XsdValidator.NativeMethodInfoPtr_FindId_Public_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669241);
			XsdValidator.NativeMethodInfoPtr_IsXSDRoot_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669242);
			XsdValidator.NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669243);
			XsdValidator.NativeMethodInfoPtr_Pop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669244);
			XsdValidator.NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669245);
			XsdValidator.NativeMethodInfoPtr_ValidateStartElementIdentityConstraints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669246);
			XsdValidator.NativeMethodInfoPtr_get_HasIdentityConstraints_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669247);
			XsdValidator.NativeMethodInfoPtr_AddIdentityConstraints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669248);
			XsdValidator.NativeMethodInfoPtr_ElementIdentityConstraints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669249);
			XsdValidator.NativeMethodInfoPtr_AttributeIdentityConstraints_Private_Void_String_String_Object_String_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669250);
			XsdValidator.NativeMethodInfoPtr_UnWrapUnion_Private_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669251);
			XsdValidator.NativeMethodInfoPtr_EndElementIdentityConstraints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669252);
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x000BDEA0 File Offset: 0x000BC0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438668, XrefRangeEnd = 438670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdValidator(BaseValidator validator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr__ctor_Internal_Void_BaseValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x000BDEEC File Offset: 0x000BC0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438670, XrefRangeEnd = 438672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaCollection);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandling);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr__ctor_Internal_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x000BDF5C File Offset: 0x000BC15C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 438716, RefRangeEnd = 438720, XrefRangeStart = 438672, XrefRangeEnd = 438716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x000BDF90 File Offset: 0x000BC190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438720, XrefRangeEnd = 438726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x000BDFC4 File Offset: 0x000BC1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438726, XrefRangeEnd = 438734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CompleteValidation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x0600296F RID: 10607 RVA: 0x000BDFF8 File Offset: 0x000BC1F8
		public unsafe bool IsInlineSchemaStarted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_get_IsInlineSchemaStarted_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x000BE034 File Offset: 0x000BC234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 438756, RefRangeEnd = 438758, XrefRangeStart = 438734, XrefRangeEnd = 438756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessInlineSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ProcessInlineSchema_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x000BE068 File Offset: 0x000BC268
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438771, RefRangeEnd = 438772, XrefRangeStart = 438758, XrefRangeEnd = 438771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ValidateElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x000BE09C File Offset: 0x000BC29C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438781, RefRangeEnd = 438782, XrefRangeStart = 438772, XrefRangeEnd = 438781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ValidateChildElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ValidateChildElement_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x000BE0DC File Offset: 0x000BC2DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438860, RefRangeEnd = 438861, XrefRangeStart = 438782, XrefRangeEnd = 438860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessElement(Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ProcessElement_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x000BE120 File Offset: 0x000BC320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438912, RefRangeEnd = 438913, XrefRangeStart = 438861, XrefRangeEnd = 438912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ProcessXsiAttributes_Private_Void_byref_XmlQualifiedName_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			xsiType = ((intPtr5 == 0) ? null : new XmlQualifiedName(intPtr5));
			xsiNil = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x000BE18C File Offset: 0x000BC38C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 438923, RefRangeEnd = 438925, XrefRangeStart = 438913, XrefRangeEnd = 438923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ValidateEndElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x000BE1C0 File Offset: 0x000BC3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438925, XrefRangeEnd = 438928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl FastGetElementDecl(Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_FastGetElementDecl_Private_SchemaElementDecl_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
			}
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x000BE210 File Offset: 0x000BC410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438928, XrefRangeEnd = 438986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementDecl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xsiType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xsiNil);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ThoroughGetElementDecl_Private_SchemaElementDecl_SchemaElementDecl_XmlQualifiedName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x000BE284 File Offset: 0x000BC484
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 439024, RefRangeEnd = 439025, XrefRangeStart = 438986, XrefRangeEnd = 439024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateStartElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ValidateStartElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x000BE2B8 File Offset: 0x000BC4B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 439053, RefRangeEnd = 439054, XrefRangeStart = 439025, XrefRangeEnd = 439053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEndStartElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ValidateEndStartElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x000BE2EC File Offset: 0x000BC4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439054, XrefRangeEnd = 439096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSchemaFromLocation(string uri, string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_LoadSchemaFromLocation_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x000BE340 File Offset: 0x000BC540
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 439101, RefRangeEnd = 439106, XrefRangeStart = 439096, XrefRangeEnd = 439101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSchema(string uri, string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_LoadSchema_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x0600297C RID: 10620 RVA: 0x000BE394 File Offset: 0x000BC594
		public unsafe bool HasSchema
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_get_HasSchema_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x0600297D RID: 10621 RVA: 0x000BE3D0 File Offset: 0x000BC5D0
		public unsafe override bool PreserveWhitespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x000BE40C File Offset: 0x000BC60C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 439123, RefRangeEnd = 439125, XrefRangeStart = 439106, XrefRangeEnd = 439123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTokenizedType(XmlTokenizedType ttype, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ttype;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x000BE45C File Offset: 0x000BC65C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 439163, RefRangeEnd = 439165, XrefRangeStart = 439125, XrefRangeEnd = 439163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckValue(string value, SchemaAttDef attdef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attdef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_CheckValue_Private_Void_String_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x000BE4B0 File Offset: 0x000BC6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439165, XrefRangeEnd = 439170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddID(string name, Object node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_AddID_Internal_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x000BE504 File Offset: 0x000BC704
		[CallerCount(0)]
		public unsafe override Object FindId(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_FindId_Public_Virtual_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x000BE554 File Offset: 0x000BC754
		[CallerCount(0)]
		public unsafe bool IsXSDRoot(string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_IsXSDRoot_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x000BE5B4 File Offset: 0x000BC7B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 439178, RefRangeEnd = 439180, XrefRangeStart = 439170, XrefRangeEnd = 439178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(XmlQualifiedName elementName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x000BE5F8 File Offset: 0x000BC7F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 439183, RefRangeEnd = 439184, XrefRangeStart = 439180, XrefRangeEnd = 439183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_Pop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x000BE62C File Offset: 0x000BC82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForwardRefs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x000BE660 File Offset: 0x000BC860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439184, XrefRangeEnd = 439186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateStartElementIdentityConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ValidateStartElementIdentityConstraints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06002987 RID: 10631 RVA: 0x000BE694 File Offset: 0x000BC894
		public unsafe bool HasIdentityConstraints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_get_HasIdentityConstraints_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x000BE6D0 File Offset: 0x000BC8D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 439223, RefRangeEnd = 439225, XrefRangeStart = 439186, XrefRangeEnd = 439223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddIdentityConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_AddIdentityConstraints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x000BE704 File Offset: 0x000BC904
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 439243, RefRangeEnd = 439245, XrefRangeStart = 439225, XrefRangeEnd = 439243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ElementIdentityConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ElementIdentityConstraints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x000BE738 File Offset: 0x000BC938
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 439266, RefRangeEnd = 439268, XrefRangeStart = 439245, XrefRangeEnd = 439266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttributeIdentityConstraints(string name, string ns, Object obj, string sobj, SchemaAttDef attdef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sobj);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attdef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_AttributeIdentityConstraints_Private_Void_String_String_Object_String_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x000BE7C4 File Offset: 0x000BC9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439268, XrefRangeEnd = 439270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object UnWrapUnion(Object typedValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typedValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_UnWrapUnion_Private_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x000BE814 File Offset: 0x000BCA14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 439356, RefRangeEnd = 439357, XrefRangeStart = 439270, XrefRangeEnd = 439356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndElementIdentityConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_EndElementIdentityConstraints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x00011722 File Offset: 0x0000F922
		public XsdValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x0600298E RID: 10638 RVA: 0x000BE848 File Offset: 0x000BCA48
		// (set) Token: 0x0600298F RID: 10639 RVA: 0x0001172B File Offset: 0x0000F92B
		public unsafe int startIDConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_startIDConstraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_startIDConstraint)) = value;
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06002990 RID: 10640 RVA: 0x000BE870 File Offset: 0x000BCA70
		// (set) Token: 0x06002991 RID: 10641 RVA: 0x00011746 File Offset: 0x0000F946
		public unsafe HWStack validationStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_validationStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HWStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_validationStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x000BE8A0 File Offset: 0x000BCAA0
		// (set) Token: 0x06002993 RID: 10643 RVA: 0x00011765 File Offset: 0x0000F965
		public unsafe Hashtable attPresence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_attPresence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_attPresence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x000BE8D0 File Offset: 0x000BCAD0
		// (set) Token: 0x06002995 RID: 10645 RVA: 0x00011784 File Offset: 0x0000F984
		public unsafe XmlNamespaceManager nsManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_nsManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_nsManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x000BE900 File Offset: 0x000BCB00
		// (set) Token: 0x06002997 RID: 10647 RVA: 0x000117A3 File Offset: 0x0000F9A3
		public unsafe bool bManageNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_bManageNamespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_bManageNamespaces)) = value;
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06002998 RID: 10648 RVA: 0x000BE928 File Offset: 0x000BCB28
		// (set) Token: 0x06002999 RID: 10649 RVA: 0x000117BE File Offset: 0x0000F9BE
		public unsafe Hashtable IDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_IDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_IDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x0600299A RID: 10650 RVA: 0x000BE958 File Offset: 0x000BCB58
		// (set) Token: 0x0600299B RID: 10651 RVA: 0x000117DD File Offset: 0x0000F9DD
		public unsafe IdRefNode idRefListHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_idRefListHead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IdRefNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_idRefListHead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x0600299C RID: 10652 RVA: 0x000BE988 File Offset: 0x000BCB88
		// (set) Token: 0x0600299D RID: 10653 RVA: 0x000117FC File Offset: 0x0000F9FC
		public unsafe Parser inlineSchemaParser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_inlineSchemaParser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Parser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_inlineSchemaParser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x0600299E RID: 10654 RVA: 0x000BE9B8 File Offset: 0x000BCBB8
		// (set) Token: 0x0600299F RID: 10655 RVA: 0x0001181B File Offset: 0x0000FA1B
		public unsafe XmlSchemaContentProcessing processContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_processContents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_processContents)) = value;
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x000BE9E0 File Offset: 0x000BCBE0
		// (set) Token: 0x060029A1 RID: 10657 RVA: 0x00011836 File Offset: 0x0000FA36
		public unsafe static XmlSchemaDatatype dtCDATA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdValidator.NativeFieldInfoPtr_dtCDATA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdValidator.NativeFieldInfoPtr_dtCDATA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x060029A2 RID: 10658 RVA: 0x000BEA08 File Offset: 0x000BCC08
		// (set) Token: 0x060029A3 RID: 10659 RVA: 0x00011848 File Offset: 0x0000FA48
		public unsafe static XmlSchemaDatatype dtQName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdValidator.NativeFieldInfoPtr_dtQName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdValidator.NativeFieldInfoPtr_dtQName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x000BEA30 File Offset: 0x000BCC30
		// (set) Token: 0x060029A5 RID: 10661 RVA: 0x0001185A File Offset: 0x0000FA5A
		public unsafe static XmlSchemaDatatype dtStringArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdValidator.NativeFieldInfoPtr_dtStringArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdValidator.NativeFieldInfoPtr_dtStringArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x060029A6 RID: 10662 RVA: 0x000BEA58 File Offset: 0x000BCC58
		// (set) Token: 0x060029A7 RID: 10663 RVA: 0x0001186C File Offset: 0x0000FA6C
		public unsafe string NsXmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_NsXmlNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_NsXmlNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x000BEA80 File Offset: 0x000BCC80
		// (set) Token: 0x060029A9 RID: 10665 RVA: 0x0001188B File Offset: 0x0000FA8B
		public unsafe string NsXs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_NsXs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_NsXs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x000BEAA8 File Offset: 0x000BCCA8
		// (set) Token: 0x060029AB RID: 10667 RVA: 0x000118AA File Offset: 0x0000FAAA
		public unsafe string NsXsi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_NsXsi);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_NsXsi), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x000BEAD0 File Offset: 0x000BCCD0
		// (set) Token: 0x060029AD RID: 10669 RVA: 0x000118C9 File Offset: 0x0000FAC9
		public unsafe string XsiType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsiType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsiType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x060029AE RID: 10670 RVA: 0x000BEAF8 File Offset: 0x000BCCF8
		// (set) Token: 0x060029AF RID: 10671 RVA: 0x000118E8 File Offset: 0x0000FAE8
		public unsafe string XsiNil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsiNil);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsiNil), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x060029B0 RID: 10672 RVA: 0x000BEB20 File Offset: 0x000BCD20
		// (set) Token: 0x060029B1 RID: 10673 RVA: 0x00011907 File Offset: 0x0000FB07
		public unsafe string XsiSchemaLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsiSchemaLocation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsiSchemaLocation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x060029B2 RID: 10674 RVA: 0x000BEB48 File Offset: 0x000BCD48
		// (set) Token: 0x060029B3 RID: 10675 RVA: 0x00011926 File Offset: 0x0000FB26
		public unsafe string XsiNoNamespaceSchemaLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x000BEB70 File Offset: 0x000BCD70
		// (set) Token: 0x060029B5 RID: 10677 RVA: 0x00011945 File Offset: 0x0000FB45
		public unsafe string XsdSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsdSchema);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsdSchema), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001F3C RID: 7996
		private static readonly IntPtr NativeFieldInfoPtr_startIDConstraint;

		// Token: 0x04001F3D RID: 7997
		private static readonly IntPtr NativeFieldInfoPtr_validationStack;

		// Token: 0x04001F3E RID: 7998
		private static readonly IntPtr NativeFieldInfoPtr_attPresence;

		// Token: 0x04001F3F RID: 7999
		private static readonly IntPtr NativeFieldInfoPtr_nsManager;

		// Token: 0x04001F40 RID: 8000
		private static readonly IntPtr NativeFieldInfoPtr_bManageNamespaces;

		// Token: 0x04001F41 RID: 8001
		private static readonly IntPtr NativeFieldInfoPtr_IDs;

		// Token: 0x04001F42 RID: 8002
		private static readonly IntPtr NativeFieldInfoPtr_idRefListHead;

		// Token: 0x04001F43 RID: 8003
		private static readonly IntPtr NativeFieldInfoPtr_inlineSchemaParser;

		// Token: 0x04001F44 RID: 8004
		private static readonly IntPtr NativeFieldInfoPtr_processContents;

		// Token: 0x04001F45 RID: 8005
		private static readonly IntPtr NativeFieldInfoPtr_dtCDATA;

		// Token: 0x04001F46 RID: 8006
		private static readonly IntPtr NativeFieldInfoPtr_dtQName;

		// Token: 0x04001F47 RID: 8007
		private static readonly IntPtr NativeFieldInfoPtr_dtStringArray;

		// Token: 0x04001F48 RID: 8008
		private static readonly IntPtr NativeFieldInfoPtr_NsXmlNs;

		// Token: 0x04001F49 RID: 8009
		private static readonly IntPtr NativeFieldInfoPtr_NsXs;

		// Token: 0x04001F4A RID: 8010
		private static readonly IntPtr NativeFieldInfoPtr_NsXsi;

		// Token: 0x04001F4B RID: 8011
		private static readonly IntPtr NativeFieldInfoPtr_XsiType;

		// Token: 0x04001F4C RID: 8012
		private static readonly IntPtr NativeFieldInfoPtr_XsiNil;

		// Token: 0x04001F4D RID: 8013
		private static readonly IntPtr NativeFieldInfoPtr_XsiSchemaLocation;

		// Token: 0x04001F4E RID: 8014
		private static readonly IntPtr NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation;

		// Token: 0x04001F4F RID: 8015
		private static readonly IntPtr NativeFieldInfoPtr_XsdSchema;

		// Token: 0x04001F50 RID: 8016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BaseValidator_0;

		// Token: 0x04001F51 RID: 8017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0;

		// Token: 0x04001F52 RID: 8018
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04001F53 RID: 8019
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Virtual_Void_0;

		// Token: 0x04001F54 RID: 8020
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Void_0;

		// Token: 0x04001F55 RID: 8021
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInlineSchemaStarted_Private_get_Boolean_0;

		// Token: 0x04001F56 RID: 8022
		private static readonly IntPtr NativeMethodInfoPtr_ProcessInlineSchema_Private_Void_0;

		// Token: 0x04001F57 RID: 8023
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Private_Void_0;

		// Token: 0x04001F58 RID: 8024
		private static readonly IntPtr NativeMethodInfoPtr_ValidateChildElement_Private_Object_0;

		// Token: 0x04001F59 RID: 8025
		private static readonly IntPtr NativeMethodInfoPtr_ProcessElement_Private_Void_Object_0;

		// Token: 0x04001F5A RID: 8026
		private static readonly IntPtr NativeMethodInfoPtr_ProcessXsiAttributes_Private_Void_byref_XmlQualifiedName_byref_String_0;

		// Token: 0x04001F5B RID: 8027
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndElement_Private_Void_0;

		// Token: 0x04001F5C RID: 8028
		private static readonly IntPtr NativeMethodInfoPtr_FastGetElementDecl_Private_SchemaElementDecl_Object_0;

		// Token: 0x04001F5D RID: 8029
		private static readonly IntPtr NativeMethodInfoPtr_ThoroughGetElementDecl_Private_SchemaElementDecl_SchemaElementDecl_XmlQualifiedName_String_0;

		// Token: 0x04001F5E RID: 8030
		private static readonly IntPtr NativeMethodInfoPtr_ValidateStartElement_Private_Void_0;

		// Token: 0x04001F5F RID: 8031
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndStartElement_Private_Void_0;

		// Token: 0x04001F60 RID: 8032
		private static readonly IntPtr NativeMethodInfoPtr_LoadSchemaFromLocation_Private_Void_String_String_0;

		// Token: 0x04001F61 RID: 8033
		private static readonly IntPtr NativeMethodInfoPtr_LoadSchema_Private_Void_String_String_0;

		// Token: 0x04001F62 RID: 8034
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSchema_Private_get_Boolean_0;

		// Token: 0x04001F63 RID: 8035
		private static readonly IntPtr NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_get_Boolean_0;

		// Token: 0x04001F64 RID: 8036
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_0;

		// Token: 0x04001F65 RID: 8037
		private static readonly IntPtr NativeMethodInfoPtr_CheckValue_Private_Void_String_SchemaAttDef_0;

		// Token: 0x04001F66 RID: 8038
		private static readonly IntPtr NativeMethodInfoPtr_AddID_Internal_Void_String_Object_0;

		// Token: 0x04001F67 RID: 8039
		private static readonly IntPtr NativeMethodInfoPtr_FindId_Public_Virtual_Object_String_0;

		// Token: 0x04001F68 RID: 8040
		private static readonly IntPtr NativeMethodInfoPtr_IsXSDRoot_Public_Boolean_String_String_0;

		// Token: 0x04001F69 RID: 8041
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0;

		// Token: 0x04001F6A RID: 8042
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_Void_0;

		// Token: 0x04001F6B RID: 8043
		private static readonly IntPtr NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0;

		// Token: 0x04001F6C RID: 8044
		private static readonly IntPtr NativeMethodInfoPtr_ValidateStartElementIdentityConstraints_Private_Void_0;

		// Token: 0x04001F6D RID: 8045
		private static readonly IntPtr NativeMethodInfoPtr_get_HasIdentityConstraints_Private_get_Boolean_0;

		// Token: 0x04001F6E RID: 8046
		private static readonly IntPtr NativeMethodInfoPtr_AddIdentityConstraints_Private_Void_0;

		// Token: 0x04001F6F RID: 8047
		private static readonly IntPtr NativeMethodInfoPtr_ElementIdentityConstraints_Private_Void_0;

		// Token: 0x04001F70 RID: 8048
		private static readonly IntPtr NativeMethodInfoPtr_AttributeIdentityConstraints_Private_Void_String_String_Object_String_SchemaAttDef_0;

		// Token: 0x04001F71 RID: 8049
		private static readonly IntPtr NativeMethodInfoPtr_UnWrapUnion_Private_Object_Object_0;

		// Token: 0x04001F72 RID: 8050
		private static readonly IntPtr NativeMethodInfoPtr_EndElementIdentityConstraints_Private_Void_0;
	}
}
