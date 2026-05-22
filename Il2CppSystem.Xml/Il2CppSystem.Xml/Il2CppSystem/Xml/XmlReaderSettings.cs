using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000053 RID: 83
	public sealed class XmlReaderSettings : Object
	{
		// Token: 0x0600058E RID: 1422 RVA: 0x0002BBDC File Offset: 0x00029DDC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlReaderSettings()
		{
			Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlReaderSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr);
			XmlReaderSettings.NativeFieldInfoPtr_useAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "useAsync");
			XmlReaderSettings.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "nameTable");
			XmlReaderSettings.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "xmlResolver");
			XmlReaderSettings.NativeFieldInfoPtr_lineNumberOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "lineNumberOffset");
			XmlReaderSettings.NativeFieldInfoPtr_linePositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "linePositionOffset");
			XmlReaderSettings.NativeFieldInfoPtr_conformanceLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "conformanceLevel");
			XmlReaderSettings.NativeFieldInfoPtr_checkCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "checkCharacters");
			XmlReaderSettings.NativeFieldInfoPtr_maxCharactersInDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "maxCharactersInDocument");
			XmlReaderSettings.NativeFieldInfoPtr_maxCharactersFromEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "maxCharactersFromEntities");
			XmlReaderSettings.NativeFieldInfoPtr_ignoreWhitespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "ignoreWhitespace");
			XmlReaderSettings.NativeFieldInfoPtr_ignorePIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "ignorePIs");
			XmlReaderSettings.NativeFieldInfoPtr_ignoreComments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "ignoreComments");
			XmlReaderSettings.NativeFieldInfoPtr_dtdProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "dtdProcessing");
			XmlReaderSettings.NativeFieldInfoPtr_validationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "validationType");
			XmlReaderSettings.NativeFieldInfoPtr_validationFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "validationFlags");
			XmlReaderSettings.NativeFieldInfoPtr_schemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "schemas");
			XmlReaderSettings.NativeFieldInfoPtr_valEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "valEventHandler");
			XmlReaderSettings.NativeFieldInfoPtr_closeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "closeInput");
			XmlReaderSettings.NativeFieldInfoPtr_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "isReadOnly");
			XmlReaderSettings.NativeFieldInfoPtr__IsXmlResolverSet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "<IsXmlResolverSet>k__BackingField");
			XmlReaderSettings.NativeFieldInfoPtr_s_enableLegacyXmlSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "s_enableLegacyXmlSettings");
			XmlReaderSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664119);
			XmlReaderSettings.NativeMethodInfoPtr_get_Async_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664120);
			XmlReaderSettings.NativeMethodInfoPtr_set_Async_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664121);
			XmlReaderSettings.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664122);
			XmlReaderSettings.NativeMethodInfoPtr_set_NameTable_Public_set_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664123);
			XmlReaderSettings.NativeMethodInfoPtr_get_IsXmlResolverSet_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664124);
			XmlReaderSettings.NativeMethodInfoPtr_set_IsXmlResolverSet_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664125);
			XmlReaderSettings.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664126);
			XmlReaderSettings.NativeMethodInfoPtr_GetXmlResolver_Internal_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664127);
			XmlReaderSettings.NativeMethodInfoPtr_GetXmlResolver_CheckConfig_Internal_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664128);
			XmlReaderSettings.NativeMethodInfoPtr_get_LineNumberOffset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664129);
			XmlReaderSettings.NativeMethodInfoPtr_set_LineNumberOffset_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664130);
			XmlReaderSettings.NativeMethodInfoPtr_get_LinePositionOffset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664131);
			XmlReaderSettings.NativeMethodInfoPtr_set_LinePositionOffset_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664132);
			XmlReaderSettings.NativeMethodInfoPtr_get_ConformanceLevel_Public_get_ConformanceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664133);
			XmlReaderSettings.NativeMethodInfoPtr_set_ConformanceLevel_Public_set_Void_ConformanceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664134);
			XmlReaderSettings.NativeMethodInfoPtr_get_CheckCharacters_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664135);
			XmlReaderSettings.NativeMethodInfoPtr_set_CheckCharacters_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664136);
			XmlReaderSettings.NativeMethodInfoPtr_get_MaxCharactersInDocument_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664137);
			XmlReaderSettings.NativeMethodInfoPtr_set_MaxCharactersInDocument_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664138);
			XmlReaderSettings.NativeMethodInfoPtr_get_MaxCharactersFromEntities_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664139);
			XmlReaderSettings.NativeMethodInfoPtr_set_MaxCharactersFromEntities_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664140);
			XmlReaderSettings.NativeMethodInfoPtr_get_IgnoreWhitespace_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664141);
			XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreWhitespace_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664142);
			XmlReaderSettings.NativeMethodInfoPtr_get_IgnoreProcessingInstructions_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664143);
			XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreProcessingInstructions_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664144);
			XmlReaderSettings.NativeMethodInfoPtr_get_IgnoreComments_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664145);
			XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreComments_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664146);
			XmlReaderSettings.NativeMethodInfoPtr_get_DtdProcessing_Public_get_DtdProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664147);
			XmlReaderSettings.NativeMethodInfoPtr_set_DtdProcessing_Public_set_Void_DtdProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664148);
			XmlReaderSettings.NativeMethodInfoPtr_get_CloseInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664149);
			XmlReaderSettings.NativeMethodInfoPtr_set_CloseInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664150);
			XmlReaderSettings.NativeMethodInfoPtr_get_ValidationType_Public_get_ValidationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664151);
			XmlReaderSettings.NativeMethodInfoPtr_set_ValidationType_Public_set_Void_ValidationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664152);
			XmlReaderSettings.NativeMethodInfoPtr_get_ValidationFlags_Public_get_XmlSchemaValidationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664153);
			XmlReaderSettings.NativeMethodInfoPtr_set_ValidationFlags_Public_set_Void_XmlSchemaValidationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664154);
			XmlReaderSettings.NativeMethodInfoPtr_get_Schemas_Public_get_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664155);
			XmlReaderSettings.NativeMethodInfoPtr_set_Schemas_Public_set_Void_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664156);
			XmlReaderSettings.NativeMethodInfoPtr_Clone_Public_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664157);
			XmlReaderSettings.NativeMethodInfoPtr_GetEventHandler_Internal_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664158);
			XmlReaderSettings.NativeMethodInfoPtr_CreateReader_Internal_XmlReader_Stream_Uri_String_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664159);
			XmlReaderSettings.NativeMethodInfoPtr_CreateReader_Internal_XmlReader_TextReader_String_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664160);
			XmlReaderSettings.NativeMethodInfoPtr_set_ReadOnly_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664161);
			XmlReaderSettings.NativeMethodInfoPtr_CheckReadOnly_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664162);
			XmlReaderSettings.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664163);
			XmlReaderSettings.NativeMethodInfoPtr_Initialize_Private_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664164);
			XmlReaderSettings.NativeMethodInfoPtr_CreateDefaultResolver_Private_Static_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664165);
			XmlReaderSettings.NativeMethodInfoPtr_AddValidation_Internal_XmlReader_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664166);
			XmlReaderSettings.NativeMethodInfoPtr_CreateDtdValidatingReader_Private_XmlValidatingReaderImpl_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664167);
			XmlReaderSettings.NativeMethodInfoPtr_EnableLegacyXmlSettings_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664168);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0002C198 File Offset: 0x0002A398
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 391760, RefRangeEnd = 391767, XrefRangeStart = 391757, XrefRangeEnd = 391760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReaderSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0002C1D4 File Offset: 0x0002A3D4
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x0002C210 File Offset: 0x0002A410
		public unsafe bool Async
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_Async_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391767, XrefRangeEnd = 391770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_Async_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0002C250 File Offset: 0x0002A450
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x0002C290 File Offset: 0x0002A490
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 391773, RefRangeEnd = 391775, XrefRangeStart = 391770, XrefRangeEnd = 391773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_NameTable_Public_set_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0002C2D4 File Offset: 0x0002A4D4
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x0002C310 File Offset: 0x0002A510
		public unsafe bool IsXmlResolverSet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_IsXmlResolverSet_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_IsXmlResolverSet_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D5 RID: 469
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x0002C350 File Offset: 0x0002A550
		public unsafe XmlResolver XmlResolver
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 391778, RefRangeEnd = 391785, XrefRangeStart = 391775, XrefRangeEnd = 391778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0002C394 File Offset: 0x0002A594
		[CallerCount(0)]
		public unsafe XmlResolver GetXmlResolver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_GetXmlResolver_Internal_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0002C3D4 File Offset: 0x0002A5D4
		[CallerCount(0)]
		public unsafe XmlResolver GetXmlResolver_CheckConfig()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_GetXmlResolver_CheckConfig_Internal_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0002C414 File Offset: 0x0002A614
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x0002C450 File Offset: 0x0002A650
		public unsafe int LineNumberOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_LineNumberOffset_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391785, XrefRangeEnd = 391788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_LineNumberOffset_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0002C490 File Offset: 0x0002A690
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x0002C4CC File Offset: 0x0002A6CC
		public unsafe int LinePositionOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_LinePositionOffset_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391788, XrefRangeEnd = 391791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_LinePositionOffset_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0002C50C File Offset: 0x0002A70C
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x0002C548 File Offset: 0x0002A748
		public unsafe ConformanceLevel ConformanceLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_ConformanceLevel_Public_get_ConformanceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391791, XrefRangeEnd = 391794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_ConformanceLevel_Public_set_Void_ConformanceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0002C588 File Offset: 0x0002A788
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x0002C5C4 File Offset: 0x0002A7C4
		public unsafe bool CheckCharacters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_CheckCharacters_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391794, XrefRangeEnd = 391797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_CheckCharacters_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0002C604 File Offset: 0x0002A804
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x0002C640 File Offset: 0x0002A840
		public unsafe long MaxCharactersInDocument
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_MaxCharactersInDocument_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391797, XrefRangeEnd = 391800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_MaxCharactersInDocument_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0002C680 File Offset: 0x0002A880
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x0002C6BC File Offset: 0x0002A8BC
		public unsafe long MaxCharactersFromEntities
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_MaxCharactersFromEntities_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391800, XrefRangeEnd = 391803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_MaxCharactersFromEntities_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0002C6FC File Offset: 0x0002A8FC
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x0002C738 File Offset: 0x0002A938
		public unsafe bool IgnoreWhitespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_IgnoreWhitespace_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391803, XrefRangeEnd = 391806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreWhitespace_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0002C778 File Offset: 0x0002A978
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x0002C7B4 File Offset: 0x0002A9B4
		public unsafe bool IgnoreProcessingInstructions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_IgnoreProcessingInstructions_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391806, XrefRangeEnd = 391809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreProcessingInstructions_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0002C7F4 File Offset: 0x0002A9F4
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x0002C830 File Offset: 0x0002AA30
		public unsafe bool IgnoreComments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_IgnoreComments_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391809, XrefRangeEnd = 391812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreComments_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0002C870 File Offset: 0x0002AA70
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x0002C8AC File Offset: 0x0002AAAC
		public unsafe DtdProcessing DtdProcessing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_DtdProcessing_Public_get_DtdProcessing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 391815, RefRangeEnd = 391817, XrefRangeStart = 391812, XrefRangeEnd = 391815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_DtdProcessing_Public_set_Void_DtdProcessing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0002C8EC File Offset: 0x0002AAEC
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x0002C928 File Offset: 0x0002AB28
		public unsafe bool CloseInput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_CloseInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 391820, RefRangeEnd = 391822, XrefRangeStart = 391817, XrefRangeEnd = 391820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_CloseInput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0002C968 File Offset: 0x0002AB68
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x0002C9A4 File Offset: 0x0002ABA4
		public unsafe ValidationType ValidationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_ValidationType_Public_get_ValidationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391822, XrefRangeEnd = 391825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_ValidationType_Public_set_Void_ValidationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0002C9E4 File Offset: 0x0002ABE4
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x0002CA20 File Offset: 0x0002AC20
		public unsafe XmlSchemaValidationFlags ValidationFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_ValidationFlags_Public_get_XmlSchemaValidationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 391828, RefRangeEnd = 391830, XrefRangeStart = 391825, XrefRangeEnd = 391828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_ValidationFlags_Public_set_Void_XmlSchemaValidationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0002CA60 File Offset: 0x0002AC60
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x0002CAA0 File Offset: 0x0002ACA0
		public unsafe XmlSchemaSet Schemas
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 391838, RefRangeEnd = 391840, XrefRangeStart = 391830, XrefRangeEnd = 391838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_Schemas_Public_get_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSet>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391840, XrefRangeEnd = 391843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_Schemas_Public_set_Void_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0002CAE4 File Offset: 0x0002ACE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391843, XrefRangeEnd = 391846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReaderSettings Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_Clone_Public_XmlReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr3) : null;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0002CB24 File Offset: 0x0002AD24
		[CallerCount(0)]
		public unsafe ValidationEventHandler GetEventHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_GetEventHandler_Internal_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr3) : null;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0002CB64 File Offset: 0x0002AD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391846, XrefRangeEnd = 391858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriString);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_CreateReader_Internal_XmlReader_Stream_Uri_String_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr3) : null;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0002CBEC File Offset: 0x0002ADEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391858, XrefRangeEnd = 391866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_CreateReader_Internal_XmlReader_TextReader_String_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr3) : null;
		}

		// Token: 0x170001E4 RID: 484
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x0002CC60 File Offset: 0x0002AE60
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_ReadOnly_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0002CCA0 File Offset: 0x0002AEA0
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 391866, RefRangeEnd = 391900, XrefRangeStart = 391866, XrefRangeEnd = 391866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckReadOnly(string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_CheckReadOnly_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0002CCE4 File Offset: 0x0002AEE4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 391760, RefRangeEnd = 391767, XrefRangeStart = 391760, XrefRangeEnd = 391767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0002CD18 File Offset: 0x0002AF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391900, XrefRangeEnd = 391903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(XmlResolver resolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolver);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_Initialize_Private_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0002CD5C File Offset: 0x0002AF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391903, XrefRangeEnd = 391906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlResolver CreateDefaultResolver()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_CreateDefaultResolver_Private_Static_XmlResolver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0002CD90 File Offset: 0x0002AF90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 391920, RefRangeEnd = 391924, XrefRangeStart = 391906, XrefRangeEnd = 391920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReader AddValidation(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_AddValidation_Internal_XmlReader_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr3) : null;
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0002CDE0 File Offset: 0x0002AFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391924, XrefRangeEnd = 391928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseReader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_CreateDtdValidatingReader_Private_XmlValidatingReaderImpl_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValidatingReaderImpl>(intPtr3) : null;
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0002CE30 File Offset: 0x0002B030
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 391944, RefRangeEnd = 391948, XrefRangeStart = 391928, XrefRangeEnd = 391944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EnableLegacyXmlSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_EnableLegacyXmlSettings_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00003D58 File Offset: 0x00001F58
		public XmlReaderSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0002CE60 File Offset: 0x0002B060
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00003D61 File Offset: 0x00001F61
		public unsafe bool useAsync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_useAsync);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_useAsync)) = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0002CE88 File Offset: 0x0002B088
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x00003D7C File Offset: 0x00001F7C
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x0002CEB8 File Offset: 0x0002B0B8
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x00003D9B File Offset: 0x00001F9B
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x0002CEE8 File Offset: 0x0002B0E8
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x00003DBA File Offset: 0x00001FBA
		public unsafe int lineNumberOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_lineNumberOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_lineNumberOffset)) = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x0002CF10 File Offset: 0x0002B110
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x00003DD5 File Offset: 0x00001FD5
		public unsafe int linePositionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_linePositionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_linePositionOffset)) = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x0002CF38 File Offset: 0x0002B138
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x00003DF0 File Offset: 0x00001FF0
		public unsafe ConformanceLevel conformanceLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_conformanceLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_conformanceLevel)) = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x0002CF60 File Offset: 0x0002B160
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x00003E0B File Offset: 0x0000200B
		public unsafe bool checkCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_checkCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_checkCharacters)) = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0002CF88 File Offset: 0x0002B188
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x00003E26 File Offset: 0x00002026
		public unsafe long maxCharactersInDocument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_maxCharactersInDocument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_maxCharactersInDocument)) = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0002CFB0 File Offset: 0x0002B1B0
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x00003E41 File Offset: 0x00002041
		public unsafe long maxCharactersFromEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_maxCharactersFromEntities);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_maxCharactersFromEntities)) = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0002CFD8 File Offset: 0x0002B1D8
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x00003E5C File Offset: 0x0000205C
		public unsafe bool ignoreWhitespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignoreWhitespace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignoreWhitespace)) = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0002D000 File Offset: 0x0002B200
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x00003E77 File Offset: 0x00002077
		public unsafe bool ignorePIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignorePIs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignorePIs)) = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x0002D028 File Offset: 0x0002B228
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x00003E92 File Offset: 0x00002092
		public unsafe bool ignoreComments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignoreComments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignoreComments)) = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x0002D050 File Offset: 0x0002B250
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x00003EAD File Offset: 0x000020AD
		public unsafe DtdProcessing dtdProcessing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_dtdProcessing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_dtdProcessing)) = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x0002D078 File Offset: 0x0002B278
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x00003EC8 File Offset: 0x000020C8
		public unsafe ValidationType validationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_validationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_validationType)) = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x0002D0A0 File Offset: 0x0002B2A0
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x00003EE3 File Offset: 0x000020E3
		public unsafe XmlSchemaValidationFlags validationFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_validationFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_validationFlags)) = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0002D0C8 File Offset: 0x0002B2C8
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00003EFE File Offset: 0x000020FE
		public unsafe XmlSchemaSet schemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_schemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_schemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0002D0F8 File Offset: 0x0002B2F8
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x00003F1D File Offset: 0x0000211D
		public unsafe ValidationEventHandler valEventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_valEventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_valEventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0002D128 File Offset: 0x0002B328
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x00003F3C File Offset: 0x0000213C
		public unsafe bool closeInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_closeInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_closeInput)) = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x0002D150 File Offset: 0x0002B350
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x00003F57 File Offset: 0x00002157
		public unsafe bool isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_isReadOnly)) = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x0002D178 File Offset: 0x0002B378
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00003F72 File Offset: 0x00002172
		public unsafe bool _IsXmlResolverSet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr__IsXmlResolverSet_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr__IsXmlResolverSet_k__BackingField)) = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0002D1A0 File Offset: 0x0002B3A0
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x00003F8D File Offset: 0x0000218D
		public unsafe static Nullable<bool> s_enableLegacyXmlSettings
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(XmlReaderSettings.NativeFieldInfoPtr_s_enableLegacyXmlSettings, intPtr);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlReaderSettings.NativeFieldInfoPtr_s_enableLegacyXmlSettings, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeFieldInfoPtr_useAsync;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeFieldInfoPtr_lineNumberOffset;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr_linePositionOffset;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr_conformanceLevel;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeFieldInfoPtr_checkCharacters;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeFieldInfoPtr_maxCharactersInDocument;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeFieldInfoPtr_maxCharactersFromEntities;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeFieldInfoPtr_ignoreWhitespace;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeFieldInfoPtr_ignorePIs;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeFieldInfoPtr_ignoreComments;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeFieldInfoPtr_dtdProcessing;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr_validationType;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr_validationFlags;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr_schemas;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeFieldInfoPtr_valEventHandler;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeFieldInfoPtr_closeInput;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeFieldInfoPtr_isReadOnly;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeFieldInfoPtr__IsXmlResolverSet_k__BackingField;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeFieldInfoPtr_s_enableLegacyXmlSettings;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_get_Async_Public_get_Boolean_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_set_Async_Public_set_Void_Boolean_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_set_NameTable_Public_set_Void_XmlNameTable_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_get_IsXmlResolverSet_Internal_get_Boolean_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_set_IsXmlResolverSet_Internal_set_Void_Boolean_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlResolver_Internal_XmlResolver_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlResolver_CheckConfig_Internal_XmlResolver_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumberOffset_Public_get_Int32_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_set_LineNumberOffset_Public_set_Void_Int32_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePositionOffset_Public_get_Int32_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_set_LinePositionOffset_Public_set_Void_Int32_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_get_ConformanceLevel_Public_get_ConformanceLevel_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_set_ConformanceLevel_Public_set_Void_ConformanceLevel_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckCharacters_Public_get_Boolean_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_set_CheckCharacters_Public_set_Void_Boolean_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharactersInDocument_Public_get_Int64_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxCharactersInDocument_Public_set_Void_Int64_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharactersFromEntities_Public_get_Int64_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxCharactersFromEntities_Public_set_Void_Int64_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreWhitespace_Public_get_Boolean_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreWhitespace_Public_set_Void_Boolean_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreProcessingInstructions_Public_get_Boolean_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreProcessingInstructions_Public_set_Void_Boolean_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreComments_Public_get_Boolean_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreComments_Public_set_Void_Boolean_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdProcessing_Public_get_DtdProcessing_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_set_DtdProcessing_Public_set_Void_DtdProcessing_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseInput_Public_get_Boolean_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseInput_Public_set_Void_Boolean_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidationType_Public_get_ValidationType_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_set_ValidationType_Public_set_Void_ValidationType_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidationFlags_Public_get_XmlSchemaValidationFlags_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_set_ValidationFlags_Public_set_Void_XmlSchemaValidationFlags_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_get_Schemas_Public_get_XmlSchemaSet_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_set_Schemas_Public_set_Void_XmlSchemaSet_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_XmlReaderSettings_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_GetEventHandler_Internal_ValidationEventHandler_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_CreateReader_Internal_XmlReader_Stream_Uri_String_XmlParserContext_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_CreateReader_Internal_XmlReader_TextReader_String_XmlParserContext_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadOnly_Internal_set_Void_Boolean_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_CheckReadOnly_Private_Void_String_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_XmlResolver_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultResolver_Private_Static_XmlResolver_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_AddValidation_Internal_XmlReader_XmlReader_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_CreateDtdValidatingReader_Private_XmlValidatingReaderImpl_XmlReader_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_EnableLegacyXmlSettings_Internal_Static_Boolean_0;
	}
}
