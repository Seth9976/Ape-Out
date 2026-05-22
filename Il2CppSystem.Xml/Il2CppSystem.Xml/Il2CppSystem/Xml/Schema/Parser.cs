using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200016E RID: 366
	public sealed class Parser : Object
	{
		// Token: 0x06001AE2 RID: 6882 RVA: 0x00084928 File Offset: 0x00082B28
		// Note: this type is marked as 'beforefieldinit'.
		static Parser()
		{
			Il2CppClassPointerStore<Parser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Parser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser>.NativeClassPtr);
			Parser.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "schemaType");
			Parser.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "nameTable");
			Parser.NativeFieldInfoPtr_schemaNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "schemaNames");
			Parser.NativeFieldInfoPtr_eventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "eventHandler");
			Parser.NativeFieldInfoPtr_namespaceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "namespaceManager");
			Parser.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "reader");
			Parser.NativeFieldInfoPtr_positionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "positionInfo");
			Parser.NativeFieldInfoPtr_isProcessNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "isProcessNamespaces");
			Parser.NativeFieldInfoPtr_schemaXmlDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "schemaXmlDepth");
			Parser.NativeFieldInfoPtr_markupDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "markupDepth");
			Parser.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "builder");
			Parser.NativeFieldInfoPtr_schema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "schema");
			Parser.NativeFieldInfoPtr_xdrSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "xdrSchema");
			Parser.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "xmlResolver");
			Parser.NativeFieldInfoPtr_dummyDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "dummyDocument");
			Parser.NativeFieldInfoPtr_processMarkup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "processMarkup");
			Parser.NativeFieldInfoPtr_parentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "parentNode");
			Parser.NativeFieldInfoPtr_annotationNSManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "annotationNSManager");
			Parser.NativeFieldInfoPtr_xmlns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "xmlns");
			Parser.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "xmlCharType");
			Parser.NativeMethodInfoPtr__ctor_Public_Void_SchemaType_XmlNameTable_SchemaNames_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667279);
			Parser.NativeMethodInfoPtr_Parse_Public_SchemaType_XmlReader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667280);
			Parser.NativeMethodInfoPtr_StartParsing_Public_Void_XmlReader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667281);
			Parser.NativeMethodInfoPtr_CheckSchemaRoot_Private_Boolean_SchemaType_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667282);
			Parser.NativeMethodInfoPtr_FinishParsing_Public_SchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667283);
			Parser.NativeMethodInfoPtr_get_XmlSchema_Public_get_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667284);
			Parser.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667285);
			Parser.NativeMethodInfoPtr_get_XdrSchema_Public_get_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667286);
			Parser.NativeMethodInfoPtr_ParseReaderNode_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667287);
			Parser.NativeMethodInfoPtr_ProcessAppInfoDocMarkup_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667288);
			Parser.NativeMethodInfoPtr_LoadElementNode_Private_XmlElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667289);
			Parser.NativeMethodInfoPtr_CreateXmlNsAttribute_Private_XmlAttribute_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667290);
			Parser.NativeMethodInfoPtr_LoadAttributeNode_Private_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667291);
			Parser.NativeMethodInfoPtr_LoadEntityReferenceInAttribute_Private_XmlEntityReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667292);
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00084C00 File Offset: 0x00082E00
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 413556, RefRangeEnd = 413565, XrefRangeStart = 413548, XrefRangeEnd = 413556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Parser(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref schemaType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr__ctor_Public_Void_SchemaType_XmlNameTable_SchemaNames_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00084C80 File Offset: 0x00082E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413565, XrefRangeEnd = 413567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaType Parse(XmlReader reader, string targetNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_Parse_Public_SchemaType_XmlReader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x00084CE0 File Offset: 0x00082EE0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 413588, RefRangeEnd = 413598, XrefRangeStart = 413567, XrefRangeEnd = 413588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartParsing(XmlReader reader, string targetNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_StartParsing_Public_Void_XmlReader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x00084D34 File Offset: 0x00082F34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 413604, RefRangeEnd = 413605, XrefRangeStart = 413598, XrefRangeEnd = 413604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckSchemaRoot(SchemaType rootType, out string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rootType;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_CheckSchemaRoot_Private_Boolean_SchemaType_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			code = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x00084D98 File Offset: 0x00082F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaType FinishParsing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_FinishParsing_Public_SchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x00084DD4 File Offset: 0x00082FD4
		public unsafe XmlSchema XmlSchema
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_get_XmlSchema_Public_get_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (set) Token: 0x06001AE9 RID: 6889 RVA: 0x00084E14 File Offset: 0x00083014
		public unsafe XmlResolver XmlResolver
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 89481, RefRangeEnd = 89490, XrefRangeStart = 89481, XrefRangeEnd = 89490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001AEA RID: 6890 RVA: 0x00084E58 File Offset: 0x00083058
		public unsafe SchemaInfo XdrSchema
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_get_XdrSchema_Public_get_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x00084E98 File Offset: 0x00083098
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 413625, RefRangeEnd = 413637, XrefRangeStart = 413605, XrefRangeEnd = 413625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseReaderNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_ParseReaderNode_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00084ED4 File Offset: 0x000830D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 413638, RefRangeEnd = 413639, XrefRangeStart = 413637, XrefRangeEnd = 413638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessAppInfoDocMarkup(bool root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref root;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_ProcessAppInfoDocMarkup_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00084F14 File Offset: 0x00083114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 413653, RefRangeEnd = 413654, XrefRangeStart = 413639, XrefRangeEnd = 413653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlElement LoadElementNode(bool root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref root;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_LoadElementNode_Private_XmlElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlElement>(intPtr3) : null;
			}
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00084F60 File Offset: 0x00083160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 413659, RefRangeEnd = 413660, XrefRangeStart = 413654, XrefRangeEnd = 413659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute CreateXmlNsAttribute(string prefix, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_CreateXmlNsAttribute_Private_XmlAttribute_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00084FC4 File Offset: 0x000831C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 413663, RefRangeEnd = 413664, XrefRangeStart = 413660, XrefRangeEnd = 413663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute LoadAttributeNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_LoadAttributeNode_Private_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x00085004 File Offset: 0x00083204
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 413669, RefRangeEnd = 413671, XrefRangeStart = 413664, XrefRangeEnd = 413669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlEntityReference LoadEntityReferenceInAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_LoadEntityReferenceInAttribute_Private_XmlEntityReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlEntityReference>(intPtr3) : null;
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x0000B5A2 File Offset: 0x000097A2
		public Parser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x00085044 File Offset: 0x00083244
		// (set) Token: 0x06001AF3 RID: 6899 RVA: 0x0000B5AB File Offset: 0x000097AB
		public unsafe SchemaType schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_schemaType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_schemaType)) = value;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x0008506C File Offset: 0x0008326C
		// (set) Token: 0x06001AF5 RID: 6901 RVA: 0x0000B5C6 File Offset: 0x000097C6
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x0008509C File Offset: 0x0008329C
		// (set) Token: 0x06001AF7 RID: 6903 RVA: 0x0000B5E5 File Offset: 0x000097E5
		public unsafe SchemaNames schemaNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_schemaNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_schemaNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x000850CC File Offset: 0x000832CC
		// (set) Token: 0x06001AF9 RID: 6905 RVA: 0x0000B604 File Offset: 0x00009804
		public unsafe ValidationEventHandler eventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_eventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_eventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001AFA RID: 6906 RVA: 0x000850FC File Offset: 0x000832FC
		// (set) Token: 0x06001AFB RID: 6907 RVA: 0x0000B623 File Offset: 0x00009823
		public unsafe XmlNamespaceManager namespaceManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_namespaceManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_namespaceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001AFC RID: 6908 RVA: 0x0008512C File Offset: 0x0008332C
		// (set) Token: 0x06001AFD RID: 6909 RVA: 0x0000B642 File Offset: 0x00009842
		public unsafe XmlReader reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001AFE RID: 6910 RVA: 0x0008515C File Offset: 0x0008335C
		// (set) Token: 0x06001AFF RID: 6911 RVA: 0x0000B661 File Offset: 0x00009861
		public unsafe PositionInfo positionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_positionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PositionInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_positionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x0008518C File Offset: 0x0008338C
		// (set) Token: 0x06001B01 RID: 6913 RVA: 0x0000B680 File Offset: 0x00009880
		public unsafe bool isProcessNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_isProcessNamespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_isProcessNamespaces)) = value;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x000851B4 File Offset: 0x000833B4
		// (set) Token: 0x06001B03 RID: 6915 RVA: 0x0000B69B File Offset: 0x0000989B
		public unsafe int schemaXmlDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_schemaXmlDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_schemaXmlDepth)) = value;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x000851DC File Offset: 0x000833DC
		// (set) Token: 0x06001B05 RID: 6917 RVA: 0x0000B6B6 File Offset: 0x000098B6
		public unsafe int markupDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_markupDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_markupDepth)) = value;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x00085204 File Offset: 0x00083404
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x0000B6D1 File Offset: 0x000098D1
		public unsafe SchemaBuilder builder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_builder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_builder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x00085234 File Offset: 0x00083434
		// (set) Token: 0x06001B09 RID: 6921 RVA: 0x0000B6F0 File Offset: 0x000098F0
		public unsafe XmlSchema schema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_schema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_schema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x00085264 File Offset: 0x00083464
		// (set) Token: 0x06001B0B RID: 6923 RVA: 0x0000B70F File Offset: 0x0000990F
		public unsafe SchemaInfo xdrSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_xdrSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_xdrSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x00085294 File Offset: 0x00083494
		// (set) Token: 0x06001B0D RID: 6925 RVA: 0x0000B72E File Offset: 0x0000992E
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x000852C4 File Offset: 0x000834C4
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x0000B74D File Offset: 0x0000994D
		public unsafe XmlDocument dummyDocument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_dummyDocument);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_dummyDocument), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x000852F4 File Offset: 0x000834F4
		// (set) Token: 0x06001B11 RID: 6929 RVA: 0x0000B76C File Offset: 0x0000996C
		public unsafe bool processMarkup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_processMarkup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_processMarkup)) = value;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x0008531C File Offset: 0x0008351C
		// (set) Token: 0x06001B13 RID: 6931 RVA: 0x0000B787 File Offset: 0x00009987
		public unsafe XmlNode parentNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_parentNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_parentNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x0008534C File Offset: 0x0008354C
		// (set) Token: 0x06001B15 RID: 6933 RVA: 0x0000B7A6 File Offset: 0x000099A6
		public unsafe XmlNamespaceManager annotationNSManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_annotationNSManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_annotationNSManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x0008537C File Offset: 0x0008357C
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x0000B7C5 File Offset: 0x000099C5
		public unsafe string xmlns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_xmlns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_xmlns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x000853A4 File Offset: 0x000835A4
		// (set) Token: 0x06001B19 RID: 6937 RVA: 0x0000B7E4 File Offset: 0x000099E4
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeFieldInfoPtr_schemaType;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeFieldInfoPtr_schemaNames;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeFieldInfoPtr_eventHandler;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeFieldInfoPtr_namespaceManager;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeFieldInfoPtr_positionInfo;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeFieldInfoPtr_isProcessNamespaces;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeFieldInfoPtr_schemaXmlDepth;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeFieldInfoPtr_markupDepth;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeFieldInfoPtr_builder;

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeFieldInfoPtr_schema;

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeFieldInfoPtr_xdrSchema;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeFieldInfoPtr_dummyDocument;

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeFieldInfoPtr_processMarkup;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeFieldInfoPtr_parentNode;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeFieldInfoPtr_annotationNSManager;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeFieldInfoPtr_xmlns;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SchemaType_XmlNameTable_SchemaNames_ValidationEventHandler_0;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_SchemaType_XmlReader_String_0;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeMethodInfoPtr_StartParsing_Public_Void_XmlReader_String_0;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeMethodInfoPtr_CheckSchemaRoot_Private_Boolean_SchemaType_byref_String_0;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeMethodInfoPtr_FinishParsing_Public_SchemaType_0;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlSchema_Public_get_XmlSchema_0;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeMethodInfoPtr_get_XdrSchema_Public_get_SchemaInfo_0;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeMethodInfoPtr_ParseReaderNode_Public_Boolean_0;

		// Token: 0x04001432 RID: 5170
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAppInfoDocMarkup_Private_Void_Boolean_0;

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeMethodInfoPtr_LoadElementNode_Private_XmlElement_Boolean_0;

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeMethodInfoPtr_CreateXmlNsAttribute_Private_XmlAttribute_String_String_0;

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeMethodInfoPtr_LoadAttributeNode_Private_XmlAttribute_0;

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeMethodInfoPtr_LoadEntityReferenceInAttribute_Private_XmlEntityReference_0;
	}
}
