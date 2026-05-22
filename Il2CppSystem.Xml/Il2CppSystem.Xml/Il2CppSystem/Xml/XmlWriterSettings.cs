using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000063 RID: 99
	public sealed class XmlWriterSettings : Object
	{
		// Token: 0x060009BB RID: 2491 RVA: 0x0003DD7C File Offset: 0x0003BF7C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlWriterSettings()
		{
			Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlWriterSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr);
			XmlWriterSettings.NativeFieldInfoPtr_useAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "useAsync");
			XmlWriterSettings.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "encoding");
			XmlWriterSettings.NativeFieldInfoPtr_omitXmlDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "omitXmlDecl");
			XmlWriterSettings.NativeFieldInfoPtr_newLineHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "newLineHandling");
			XmlWriterSettings.NativeFieldInfoPtr_newLineChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "newLineChars");
			XmlWriterSettings.NativeFieldInfoPtr_indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "indent");
			XmlWriterSettings.NativeFieldInfoPtr_indentChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "indentChars");
			XmlWriterSettings.NativeFieldInfoPtr_newLineOnAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "newLineOnAttributes");
			XmlWriterSettings.NativeFieldInfoPtr_closeOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "closeOutput");
			XmlWriterSettings.NativeFieldInfoPtr_namespaceHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "namespaceHandling");
			XmlWriterSettings.NativeFieldInfoPtr_conformanceLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "conformanceLevel");
			XmlWriterSettings.NativeFieldInfoPtr_checkCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "checkCharacters");
			XmlWriterSettings.NativeFieldInfoPtr_writeEndDocumentOnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "writeEndDocumentOnClose");
			XmlWriterSettings.NativeFieldInfoPtr_outputMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "outputMethod");
			XmlWriterSettings.NativeFieldInfoPtr_cdataSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "cdataSections");
			XmlWriterSettings.NativeFieldInfoPtr_doNotEscapeUriAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "doNotEscapeUriAttributes");
			XmlWriterSettings.NativeFieldInfoPtr_mergeCDataSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "mergeCDataSections");
			XmlWriterSettings.NativeFieldInfoPtr_mediaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "mediaType");
			XmlWriterSettings.NativeFieldInfoPtr_docTypeSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "docTypeSystem");
			XmlWriterSettings.NativeFieldInfoPtr_docTypePublic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "docTypePublic");
			XmlWriterSettings.NativeFieldInfoPtr_standalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "standalone");
			XmlWriterSettings.NativeFieldInfoPtr_autoXmlDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "autoXmlDecl");
			XmlWriterSettings.NativeFieldInfoPtr_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "isReadOnly");
			XmlWriterSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664877);
			XmlWriterSettings.NativeMethodInfoPtr_get_Async_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664878);
			XmlWriterSettings.NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664879);
			XmlWriterSettings.NativeMethodInfoPtr_get_OmitXmlDeclaration_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664880);
			XmlWriterSettings.NativeMethodInfoPtr_get_NewLineHandling_Public_get_NewLineHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664881);
			XmlWriterSettings.NativeMethodInfoPtr_get_NewLineChars_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664882);
			XmlWriterSettings.NativeMethodInfoPtr_get_Indent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664883);
			XmlWriterSettings.NativeMethodInfoPtr_set_Indent_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664884);
			XmlWriterSettings.NativeMethodInfoPtr_get_IndentChars_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664885);
			XmlWriterSettings.NativeMethodInfoPtr_get_NewLineOnAttributes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664886);
			XmlWriterSettings.NativeMethodInfoPtr_get_CloseOutput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664887);
			XmlWriterSettings.NativeMethodInfoPtr_get_ConformanceLevel_Public_get_ConformanceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664888);
			XmlWriterSettings.NativeMethodInfoPtr_get_CheckCharacters_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664889);
			XmlWriterSettings.NativeMethodInfoPtr_get_NamespaceHandling_Public_get_NamespaceHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664890);
			XmlWriterSettings.NativeMethodInfoPtr_get_WriteEndDocumentOnClose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664891);
			XmlWriterSettings.NativeMethodInfoPtr_get_OutputMethod_Public_get_XmlOutputMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664892);
			XmlWriterSettings.NativeMethodInfoPtr_set_OutputMethod_Internal_set_Void_XmlOutputMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664893);
			XmlWriterSettings.NativeMethodInfoPtr_Clone_Public_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664894);
			XmlWriterSettings.NativeMethodInfoPtr_get_CDataSectionElements_Internal_get_List_1_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664895);
			XmlWriterSettings.NativeMethodInfoPtr_get_DoNotEscapeUriAttributes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664896);
			XmlWriterSettings.NativeMethodInfoPtr_get_MergeCDataSections_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664897);
			XmlWriterSettings.NativeMethodInfoPtr_get_MediaType_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664898);
			XmlWriterSettings.NativeMethodInfoPtr_get_DocTypeSystem_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664899);
			XmlWriterSettings.NativeMethodInfoPtr_get_DocTypePublic_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664900);
			XmlWriterSettings.NativeMethodInfoPtr_get_Standalone_Internal_get_XmlStandalone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664901);
			XmlWriterSettings.NativeMethodInfoPtr_get_AutoXmlDeclaration_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664902);
			XmlWriterSettings.NativeMethodInfoPtr_get_IndentInternal_Internal_get_TriState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664903);
			XmlWriterSettings.NativeMethodInfoPtr_get_IsQuerySpecific_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664904);
			XmlWriterSettings.NativeMethodInfoPtr_CreateWriter_Internal_XmlWriter_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664905);
			XmlWriterSettings.NativeMethodInfoPtr_CreateWriter_Internal_XmlWriter_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664906);
			XmlWriterSettings.NativeMethodInfoPtr_set_ReadOnly_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664907);
			XmlWriterSettings.NativeMethodInfoPtr_CheckReadOnly_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664908);
			XmlWriterSettings.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664909);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0003E20C File Offset: 0x0003C40C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 396724, RefRangeEnd = 396730, XrefRangeStart = 396717, XrefRangeEnd = 396724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlWriterSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x0003E248 File Offset: 0x0003C448
		public unsafe bool Async
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_Async_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x0003E284 File Offset: 0x0003C484
		public unsafe Encoding Encoding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x0003E2C4 File Offset: 0x0003C4C4
		public unsafe bool OmitXmlDeclaration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_OmitXmlDeclaration_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0003E300 File Offset: 0x0003C500
		public unsafe NewLineHandling NewLineHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_NewLineHandling_Public_get_NewLineHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0003E33C File Offset: 0x0003C53C
		public unsafe string NewLineChars
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_NewLineChars_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0003E374 File Offset: 0x0003C574
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x0003E3B0 File Offset: 0x0003C5B0
		public unsafe bool Indent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_Indent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396730, XrefRangeEnd = 396732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_set_Indent_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x0003E3F0 File Offset: 0x0003C5F0
		public unsafe string IndentChars
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_IndentChars_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x0003E428 File Offset: 0x0003C628
		public unsafe bool NewLineOnAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_NewLineOnAttributes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0003E464 File Offset: 0x0003C664
		public unsafe bool CloseOutput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_CloseOutput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x0003E4A0 File Offset: 0x0003C6A0
		public unsafe ConformanceLevel ConformanceLevel
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 93966, RefRangeEnd = 93969, XrefRangeStart = 93966, XrefRangeEnd = 93969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_ConformanceLevel_Public_get_ConformanceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0003E4DC File Offset: 0x0003C6DC
		public unsafe bool CheckCharacters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_CheckCharacters_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x0003E518 File Offset: 0x0003C718
		public unsafe NamespaceHandling NamespaceHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_NamespaceHandling_Public_get_NamespaceHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x0003E554 File Offset: 0x0003C754
		public unsafe bool WriteEndDocumentOnClose
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_WriteEndDocumentOnClose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x0003E590 File Offset: 0x0003C790
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x0003E5CC File Offset: 0x0003C7CC
		public unsafe XmlOutputMethod OutputMethod
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_OutputMethod_Public_get_XmlOutputMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_set_OutputMethod_Internal_set_Void_XmlOutputMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0003E60C File Offset: 0x0003C80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396732, XrefRangeEnd = 396741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlWriterSettings Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_Clone_Public_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlWriterSettings>(intPtr3) : null;
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0003E64C File Offset: 0x0003C84C
		public unsafe List<XmlQualifiedName> CDataSectionElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_CDataSectionElements_Internal_get_List_1_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<XmlQualifiedName>>(intPtr3) : null;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x0003E68C File Offset: 0x0003C88C
		public unsafe bool DoNotEscapeUriAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_DoNotEscapeUriAttributes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0003E6C8 File Offset: 0x0003C8C8
		public unsafe bool MergeCDataSections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_MergeCDataSections_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0003E704 File Offset: 0x0003C904
		public unsafe string MediaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_MediaType_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0003E73C File Offset: 0x0003C93C
		public unsafe string DocTypeSystem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_DocTypeSystem_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x0003E774 File Offset: 0x0003C974
		public unsafe string DocTypePublic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_DocTypePublic_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x0003E7AC File Offset: 0x0003C9AC
		public unsafe XmlStandalone Standalone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_Standalone_Internal_get_XmlStandalone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x0003E7E8 File Offset: 0x0003C9E8
		public unsafe bool AutoXmlDeclaration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_AutoXmlDeclaration_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0003E824 File Offset: 0x0003CA24
		public unsafe TriState IndentInternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_IndentInternal_Internal_get_TriState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0003E860 File Offset: 0x0003CA60
		public unsafe bool IsQuerySpecific
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396741, XrefRangeEnd = 396742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_IsQuerySpecific_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0003E89C File Offset: 0x0003CA9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 396787, RefRangeEnd = 396789, XrefRangeStart = 396742, XrefRangeEnd = 396787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlWriter CreateWriter(Stream output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_CreateWriter_Internal_XmlWriter_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlWriter>(intPtr3) : null;
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0003E8EC File Offset: 0x0003CAEC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 396799, RefRangeEnd = 396803, XrefRangeStart = 396789, XrefRangeEnd = 396799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlWriter CreateWriter(TextWriter output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_CreateWriter_Internal_XmlWriter_TextWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlWriter>(intPtr3) : null;
			}
		}

		// Token: 0x17000340 RID: 832
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x0003E93C File Offset: 0x0003CB3C
		public unsafe bool ReadOnly
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_set_ReadOnly_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0003E97C File Offset: 0x0003CB7C
		[CallerCount(0)]
		public unsafe void CheckReadOnly(string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_CheckReadOnly_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0003E9C0 File Offset: 0x0003CBC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 396809, RefRangeEnd = 396810, XrefRangeStart = 396803, XrefRangeEnd = 396809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00005475 File Offset: 0x00003675
		public XmlWriterSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0003E9F4 File Offset: 0x0003CBF4
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x0000547E File Offset: 0x0000367E
		public unsafe bool useAsync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_useAsync);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_useAsync)) = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0003EA1C File Offset: 0x0003CC1C
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x00005499 File Offset: 0x00003699
		public unsafe Encoding encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x0003EA4C File Offset: 0x0003CC4C
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x000054B8 File Offset: 0x000036B8
		public unsafe bool omitXmlDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_omitXmlDecl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_omitXmlDecl)) = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0003EA74 File Offset: 0x0003CC74
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x000054D3 File Offset: 0x000036D3
		public unsafe NewLineHandling newLineHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_newLineHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_newLineHandling)) = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0003EA9C File Offset: 0x0003CC9C
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x000054EE File Offset: 0x000036EE
		public unsafe string newLineChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_newLineChars);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_newLineChars), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0003EAC4 File Offset: 0x0003CCC4
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x0000550D File Offset: 0x0000370D
		public unsafe TriState indent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_indent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_indent)) = value;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x0003EAEC File Offset: 0x0003CCEC
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x00005528 File Offset: 0x00003728
		public unsafe string indentChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_indentChars);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_indentChars), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x0003EB14 File Offset: 0x0003CD14
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x00005547 File Offset: 0x00003747
		public unsafe bool newLineOnAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_newLineOnAttributes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_newLineOnAttributes)) = value;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0003EB3C File Offset: 0x0003CD3C
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x00005562 File Offset: 0x00003762
		public unsafe bool closeOutput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_closeOutput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_closeOutput)) = value;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0003EB64 File Offset: 0x0003CD64
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x0000557D File Offset: 0x0000377D
		public unsafe NamespaceHandling namespaceHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_namespaceHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_namespaceHandling)) = value;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0003EB8C File Offset: 0x0003CD8C
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x00005598 File Offset: 0x00003798
		public unsafe ConformanceLevel conformanceLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_conformanceLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_conformanceLevel)) = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0003EBB4 File Offset: 0x0003CDB4
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x000055B3 File Offset: 0x000037B3
		public unsafe bool checkCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_checkCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_checkCharacters)) = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x0003EBDC File Offset: 0x0003CDDC
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x000055CE File Offset: 0x000037CE
		public unsafe bool writeEndDocumentOnClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_writeEndDocumentOnClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_writeEndDocumentOnClose)) = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x0003EC04 File Offset: 0x0003CE04
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x000055E9 File Offset: 0x000037E9
		public unsafe XmlOutputMethod outputMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_outputMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_outputMethod)) = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x0003EC2C File Offset: 0x0003CE2C
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x00005604 File Offset: 0x00003804
		public unsafe List<XmlQualifiedName> cdataSections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_cdataSections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<XmlQualifiedName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_cdataSections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0003EC5C File Offset: 0x0003CE5C
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x00005623 File Offset: 0x00003823
		public unsafe bool doNotEscapeUriAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_doNotEscapeUriAttributes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_doNotEscapeUriAttributes)) = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0003EC84 File Offset: 0x0003CE84
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x0000563E File Offset: 0x0000383E
		public unsafe bool mergeCDataSections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_mergeCDataSections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_mergeCDataSections)) = value;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x0003ECAC File Offset: 0x0003CEAC
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x00005659 File Offset: 0x00003859
		public unsafe string mediaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_mediaType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_mediaType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x0003ECD4 File Offset: 0x0003CED4
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00005678 File Offset: 0x00003878
		public unsafe string docTypeSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_docTypeSystem);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_docTypeSystem), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0003ECFC File Offset: 0x0003CEFC
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00005697 File Offset: 0x00003897
		public unsafe string docTypePublic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_docTypePublic);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_docTypePublic), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x0003ED24 File Offset: 0x0003CF24
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x000056B6 File Offset: 0x000038B6
		public unsafe XmlStandalone standalone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_standalone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_standalone)) = value;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0003ED4C File Offset: 0x0003CF4C
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x000056D1 File Offset: 0x000038D1
		public unsafe bool autoXmlDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_autoXmlDecl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_autoXmlDecl)) = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0003ED74 File Offset: 0x0003CF74
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x000056EC File Offset: 0x000038EC
		public unsafe bool isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_isReadOnly)) = value;
			}
		}

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeFieldInfoPtr_useAsync;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeFieldInfoPtr_omitXmlDecl;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeFieldInfoPtr_newLineHandling;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeFieldInfoPtr_newLineChars;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeFieldInfoPtr_indent;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeFieldInfoPtr_indentChars;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeFieldInfoPtr_newLineOnAttributes;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeFieldInfoPtr_closeOutput;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeFieldInfoPtr_namespaceHandling;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeFieldInfoPtr_conformanceLevel;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeFieldInfoPtr_checkCharacters;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeFieldInfoPtr_writeEndDocumentOnClose;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeFieldInfoPtr_outputMethod;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeFieldInfoPtr_cdataSections;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeFieldInfoPtr_doNotEscapeUriAttributes;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeFieldInfoPtr_mergeCDataSections;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeFieldInfoPtr_mediaType;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeFieldInfoPtr_docTypeSystem;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeFieldInfoPtr_docTypePublic;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeFieldInfoPtr_standalone;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeFieldInfoPtr_autoXmlDecl;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeFieldInfoPtr_isReadOnly;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_get_Async_Public_get_Boolean_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_get_OmitXmlDeclaration_Public_get_Boolean_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_get_NewLineHandling_Public_get_NewLineHandling_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_get_NewLineChars_Public_get_String_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_get_Indent_Public_get_Boolean_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_set_Indent_Public_set_Void_Boolean_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr_get_IndentChars_Public_get_String_0;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr_get_NewLineOnAttributes_Public_get_Boolean_0;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseOutput_Public_get_Boolean_0;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_get_ConformanceLevel_Public_get_ConformanceLevel_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckCharacters_Public_get_Boolean_0;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceHandling_Public_get_NamespaceHandling_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteEndDocumentOnClose_Public_get_Boolean_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputMethod_Public_get_XmlOutputMethod_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputMethod_Internal_set_Void_XmlOutputMethod_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_XmlWriterSettings_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_get_CDataSectionElements_Internal_get_List_1_XmlQualifiedName_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_get_DoNotEscapeUriAttributes_Public_get_Boolean_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_get_MergeCDataSections_Internal_get_Boolean_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_get_MediaType_Internal_get_String_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_get_DocTypeSystem_Internal_get_String_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_get_DocTypePublic_Internal_get_String_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_get_Standalone_Internal_get_XmlStandalone_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoXmlDeclaration_Internal_get_Boolean_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_get_IndentInternal_Internal_get_TriState_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_get_IsQuerySpecific_Internal_get_Boolean_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_CreateWriter_Internal_XmlWriter_Stream_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_CreateWriter_Internal_XmlWriter_TextWriter_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadOnly_Internal_set_Void_Boolean_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_CheckReadOnly_Private_Void_String_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;
	}
}
