using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200007A RID: 122
	public class XmlLoader : Object
	{
		// Token: 0x06000CF6 RID: 3318 RVA: 0x0004B400 File Offset: 0x00049600
		// Note: this type is marked as 'beforefieldinit'.
		static XmlLoader()
		{
			Il2CppClassPointerStore<XmlLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr);
			XmlLoader.NativeFieldInfoPtr_doc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, "doc");
			XmlLoader.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, "reader");
			XmlLoader.NativeFieldInfoPtr_preserveWhitespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, "preserveWhitespace");
			XmlLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665330);
			XmlLoader.NativeMethodInfoPtr_Load_Internal_Void_XmlDocument_XmlReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665331);
			XmlLoader.NativeMethodInfoPtr_LoadDocSequence_Private_Void_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665332);
			XmlLoader.NativeMethodInfoPtr_LoadNode_Private_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665333);
			XmlLoader.NativeMethodInfoPtr_LoadAttributeNode_Private_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665334);
			XmlLoader.NativeMethodInfoPtr_LoadDefaultAttribute_Private_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665335);
			XmlLoader.NativeMethodInfoPtr_LoadAttributeValue_Private_Void_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665336);
			XmlLoader.NativeMethodInfoPtr_LoadEntityReferenceNode_Private_XmlEntityReference_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665337);
			XmlLoader.NativeMethodInfoPtr_LoadDeclarationNode_Private_XmlDeclaration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665338);
			XmlLoader.NativeMethodInfoPtr_LoadDocumentTypeNode_Private_XmlDocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665339);
			XmlLoader.NativeMethodInfoPtr_LoadNodeDirect_Private_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665340);
			XmlLoader.NativeMethodInfoPtr_LoadAttributeNodeDirect_Private_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665341);
			XmlLoader.NativeMethodInfoPtr_ParseDocumentType_Internal_Void_XmlDocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665342);
			XmlLoader.NativeMethodInfoPtr_ParseDocumentType_Private_Void_XmlDocumentType_Boolean_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665343);
			XmlLoader.NativeMethodInfoPtr_LoadDocumentType_Private_Void_IDtdInfo_XmlDocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665344);
			XmlLoader.NativeMethodInfoPtr_GetContext_Private_XmlParserContext_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665345);
			XmlLoader.NativeMethodInfoPtr_ParsePartialContent_Internal_XmlNamespaceManager_XmlNode_String_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665346);
			XmlLoader.NativeMethodInfoPtr_LoadInnerXmlElement_Internal_Void_XmlElement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665347);
			XmlLoader.NativeMethodInfoPtr_LoadInnerXmlAttribute_Internal_Void_XmlAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665348);
			XmlLoader.NativeMethodInfoPtr_RemoveDuplicateNamespace_Private_Void_XmlElement_XmlNamespaceManager_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665349);
			XmlLoader.NativeMethodInfoPtr_EntitizeName_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665350);
			XmlLoader.NativeMethodInfoPtr_ExpandEntity_Internal_Void_XmlEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665351);
			XmlLoader.NativeMethodInfoPtr_ExpandEntityReference_Internal_Void_XmlEntityReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665352);
			XmlLoader.NativeMethodInfoPtr_CreateInnerXmlReader_Private_XmlReader_String_XmlNodeType_XmlParserContext_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665353);
			XmlLoader.NativeMethodInfoPtr_ParseXmlDeclarationValue_Internal_Static_Void_String_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665354);
			XmlLoader.NativeMethodInfoPtr_UnexpectedNodeType_Internal_Static_Exception_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665355);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0004B674 File Offset: 0x00049874
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0004B6B0 File Offset: 0x000498B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398203, RefRangeEnd = 398204, XrefRangeStart = 398190, XrefRangeEnd = 398203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveWhitespace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_Load_Internal_Void_XmlDocument_XmlReader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0004B714 File Offset: 0x00049914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398204, XrefRangeEnd = 398205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDocSequence(XmlDocument parentDoc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentDoc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadDocSequence_Private_Void_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0004B758 File Offset: 0x00049958
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 398224, RefRangeEnd = 398228, XrefRangeStart = 398205, XrefRangeEnd = 398224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNode LoadNode(bool skipOverWhitespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipOverWhitespace;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadNode_Private_XmlNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0004B7A4 File Offset: 0x000499A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 398235, RefRangeEnd = 398237, XrefRangeStart = 398228, XrefRangeEnd = 398235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute LoadAttributeNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadAttributeNode_Private_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0004B7E4 File Offset: 0x000499E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398237, XrefRangeEnd = 398243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute LoadDefaultAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadDefaultAttribute_Private_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0004B824 File Offset: 0x00049A24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 398258, RefRangeEnd = 398263, XrefRangeStart = 398243, XrefRangeEnd = 398258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAttributeValue(XmlNode parent, bool direct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadAttributeValue_Private_Void_XmlNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0004B874 File Offset: 0x00049A74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 398274, RefRangeEnd = 398276, XrefRangeStart = 398263, XrefRangeEnd = 398274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlEntityReference LoadEntityReferenceNode(bool direct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direct;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadEntityReferenceNode_Private_XmlEntityReference_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlEntityReference>(intPtr3) : null;
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0004B8C0 File Offset: 0x00049AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398276, XrefRangeEnd = 398286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDeclaration LoadDeclarationNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadDeclarationNode_Private_XmlDeclaration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDeclaration>(intPtr3) : null;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x0004B900 File Offset: 0x00049B00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398296, RefRangeEnd = 398297, XrefRangeStart = 398286, XrefRangeEnd = 398296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDocumentType LoadDocumentTypeNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadDocumentTypeNode_Private_XmlDocumentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocumentType>(intPtr3) : null;
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0004B940 File Offset: 0x00049B40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 398343, RefRangeEnd = 398345, XrefRangeStart = 398297, XrefRangeEnd = 398343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNode LoadNodeDirect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadNodeDirect_Private_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x0004B980 File Offset: 0x00049B80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 398352, RefRangeEnd = 398354, XrefRangeStart = 398345, XrefRangeEnd = 398352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute LoadAttributeNodeDirect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadAttributeNodeDirect_Private_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0004B9C0 File Offset: 0x00049BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398354, XrefRangeEnd = 398355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseDocumentType(XmlDocumentType dtNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ParseDocumentType_Internal_Void_XmlDocumentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0004BA04 File Offset: 0x00049C04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 398384, RefRangeEnd = 398387, XrefRangeStart = 398355, XrefRangeEnd = 398384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bUseResolver;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ParseDocumentType_Private_Void_XmlDocumentType_Boolean_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0004BA68 File Offset: 0x00049C68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 398477, RefRangeEnd = 398479, XrefRangeStart = 398387, XrefRangeEnd = 398477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtdInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadDocumentType_Private_Void_IDtdInfo_XmlDocumentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0004BABC File Offset: 0x00049CBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398523, RefRangeEnd = 398524, XrefRangeStart = 398479, XrefRangeEnd = 398523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlParserContext GetContext(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_GetContext_Private_XmlParserContext_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlParserContext>(intPtr3) : null;
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0004BB0C File Offset: 0x00049D0C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 398531, RefRangeEnd = 398539, XrefRangeStart = 398524, XrefRangeEnd = 398531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(innerxmltext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ParsePartialContent_Internal_XmlNamespaceManager_XmlNode_String_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr3) : null;
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0004BB7C File Offset: 0x00049D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398539, XrefRangeEnd = 398541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadInnerXmlElement(XmlElement node, string innerxmltext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(innerxmltext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadInnerXmlElement_Internal_Void_XmlElement_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0004BBD0 File Offset: 0x00049DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398541, XrefRangeEnd = 398542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(innerxmltext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadInnerXmlAttribute_Internal_Void_XmlAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0004BC24 File Offset: 0x00049E24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 398549, RefRangeEnd = 398552, XrefRangeStart = 398542, XrefRangeEnd = 398549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mgr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fCheckElemAttrs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_RemoveDuplicateNamespace_Private_Void_XmlElement_XmlNamespaceManager_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0004BC88 File Offset: 0x00049E88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398557, RefRangeEnd = 398558, XrefRangeStart = 398552, XrefRangeEnd = 398557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string EntitizeName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_EntitizeName_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0004BCD0 File Offset: 0x00049ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398558, XrefRangeEnd = 398564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandEntity(XmlEntity ent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ExpandEntity_Internal_Void_XmlEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0004BD14 File Offset: 0x00049F14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398602, RefRangeEnd = 398603, XrefRangeStart = 398564, XrefRangeEnd = 398602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandEntityReference(XmlEntityReference eref)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eref);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ExpandEntityReference_Internal_Void_XmlEntityReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x0004BD58 File Offset: 0x00049F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398625, RefRangeEnd = 398626, XrefRangeStart = 398603, XrefRangeEnd = 398625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlFragment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_CreateInnerXmlReader_Private_XmlReader_String_XmlNodeType_XmlParserContext_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr3) : null;
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x0004BDDC File Offset: 0x00049FDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 398651, RefRangeEnd = 398653, XrefRangeStart = 398626, XrefRangeEnd = 398651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strValue);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ParseXmlDeclarationValue_Internal_Static_Void_String_byref_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			version = IL2CPP.Il2CppStringToManaged(intPtr);
			encoding = IL2CPP.Il2CppStringToManaged(intPtr2);
			standalone = IL2CPP.Il2CppStringToManaged(intPtr3);
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0004BE64 File Offset: 0x0004A064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398653, XrefRangeEnd = 398671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UnexpectedNodeType(XmlNodeType nodetype)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodetype;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_UnexpectedNodeType_Internal_Static_Exception_XmlNodeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00006860 File Offset: 0x00004A60
		public XmlLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x0004BEA4 File Offset: 0x0004A0A4
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x00006869 File Offset: 0x00004A69
		public unsafe XmlDocument doc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_doc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_doc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0004BED4 File Offset: 0x0004A0D4
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x00006888 File Offset: 0x00004A88
		public unsafe XmlReader reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0004BF04 File Offset: 0x0004A104
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x000068A7 File Offset: 0x00004AA7
		public unsafe bool preserveWhitespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_preserveWhitespace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_preserveWhitespace)) = value;
			}
		}

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeFieldInfoPtr_doc;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeFieldInfoPtr_preserveWhitespace;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_Load_Internal_Void_XmlDocument_XmlReader_Boolean_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr_LoadDocSequence_Private_Void_XmlDocument_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_LoadNode_Private_XmlNode_Boolean_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_LoadAttributeNode_Private_XmlAttribute_0;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaultAttribute_Private_XmlAttribute_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_LoadAttributeValue_Private_Void_XmlNode_Boolean_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_LoadEntityReferenceNode_Private_XmlEntityReference_Boolean_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_LoadDeclarationNode_Private_XmlDeclaration_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_LoadDocumentTypeNode_Private_XmlDocumentType_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_LoadNodeDirect_Private_XmlNode_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_LoadAttributeNodeDirect_Private_XmlAttribute_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_ParseDocumentType_Internal_Void_XmlDocumentType_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr_ParseDocumentType_Private_Void_XmlDocumentType_Boolean_XmlResolver_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_LoadDocumentType_Private_Void_IDtdInfo_XmlDocumentType_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_GetContext_Private_XmlParserContext_XmlNode_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_ParsePartialContent_Internal_XmlNamespaceManager_XmlNode_String_XmlNodeType_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_LoadInnerXmlElement_Internal_Void_XmlElement_String_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_LoadInnerXmlAttribute_Internal_Void_XmlAttribute_String_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDuplicateNamespace_Private_Void_XmlElement_XmlNamespaceManager_Boolean_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_EntitizeName_Private_String_String_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_ExpandEntity_Internal_Void_XmlEntity_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr_ExpandEntityReference_Internal_Void_XmlEntityReference_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_CreateInnerXmlReader_Private_XmlReader_String_XmlNodeType_XmlParserContext_XmlDocument_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_ParseXmlDeclarationValue_Internal_Static_Void_String_byref_String_byref_String_byref_String_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_UnexpectedNodeType_Internal_Static_Exception_XmlNodeType_0;
	}
}
