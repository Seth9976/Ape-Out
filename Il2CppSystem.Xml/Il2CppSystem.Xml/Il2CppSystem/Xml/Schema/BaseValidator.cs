using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000FC RID: 252
	public class BaseValidator : Object
	{
		// Token: 0x060014F7 RID: 5367 RVA: 0x0006D018 File Offset: 0x0006B218
		// Note: this type is marked as 'beforefieldinit'.
		static BaseValidator()
		{
			Il2CppClassPointerStore<BaseValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "BaseValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr);
			BaseValidator.NativeFieldInfoPtr_schemaCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "schemaCollection");
			BaseValidator.NativeFieldInfoPtr_eventHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "eventHandling");
			BaseValidator.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "nameTable");
			BaseValidator.NativeFieldInfoPtr_schemaNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "schemaNames");
			BaseValidator.NativeFieldInfoPtr_positionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "positionInfo");
			BaseValidator.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "xmlResolver");
			BaseValidator.NativeFieldInfoPtr_baseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "baseUri");
			BaseValidator.NativeFieldInfoPtr_schemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "schemaInfo");
			BaseValidator.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "reader");
			BaseValidator.NativeFieldInfoPtr_elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "elementName");
			BaseValidator.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "context");
			BaseValidator.NativeFieldInfoPtr_textValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "textValue");
			BaseValidator.NativeFieldInfoPtr_textString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "textString");
			BaseValidator.NativeFieldInfoPtr_hasSibling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "hasSibling");
			BaseValidator.NativeFieldInfoPtr_checkDatatype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "checkDatatype");
			BaseValidator.NativeMethodInfoPtr__ctor_Public_Void_BaseValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666500);
			BaseValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666501);
			BaseValidator.NativeMethodInfoPtr_get_Reader_Public_get_XmlValidatingReaderImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666502);
			BaseValidator.NativeMethodInfoPtr_get_SchemaCollection_Public_get_XmlSchemaCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666503);
			BaseValidator.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666504);
			BaseValidator.NativeMethodInfoPtr_get_SchemaNames_Public_get_SchemaNames_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666505);
			BaseValidator.NativeMethodInfoPtr_get_PositionInfo_Public_get_PositionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666506);
			BaseValidator.NativeMethodInfoPtr_get_XmlResolver_Public_get_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666507);
			BaseValidator.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666508);
			BaseValidator.NativeMethodInfoPtr_get_BaseUri_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666509);
			BaseValidator.NativeMethodInfoPtr_set_BaseUri_Public_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666510);
			BaseValidator.NativeMethodInfoPtr_get_EventHandler_Public_get_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666511);
			BaseValidator.NativeMethodInfoPtr_get_SchemaInfo_Public_get_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666512);
			BaseValidator.NativeMethodInfoPtr_set_DtdInfo_Public_set_Void_IDtdInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666513);
			BaseValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666514);
			BaseValidator.NativeMethodInfoPtr_Validate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666515);
			BaseValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666516);
			BaseValidator.NativeMethodInfoPtr_FindId_Public_Virtual_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666517);
			BaseValidator.NativeMethodInfoPtr_ValidateText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666518);
			BaseValidator.NativeMethodInfoPtr_ValidateWhitespace_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666519);
			BaseValidator.NativeMethodInfoPtr_SaveTextValue_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666520);
			BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666521);
			BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666522);
			BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666523);
			BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666524);
			BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666525);
			BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_Il2CppStringArray_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666526);
			BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666527);
			BaseValidator.NativeMethodInfoPtr_ProcessEntity_Protected_Static_Void_SchemaInfo_String_Object_ValidationEventHandler_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666528);
			BaseValidator.NativeMethodInfoPtr_ProcessEntity_Protected_Static_Void_SchemaInfo_String_IValidationEventHandling_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666529);
			BaseValidator.NativeMethodInfoPtr_CreateInstance_Public_Static_BaseValidator_ValidationType_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100666530);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0006D3E0 File Offset: 0x0006B5E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 408554, RefRangeEnd = 408557, XrefRangeStart = 408554, XrefRangeEnd = 408554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseValidator(BaseValidator other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr__ctor_Public_Void_BaseValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0006D42C File Offset: 0x0006B62C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 408562, RefRangeEnd = 408571, XrefRangeStart = 408557, XrefRangeEnd = 408562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x0006D49C File Offset: 0x0006B69C
		public unsafe XmlValidatingReaderImpl Reader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_Reader_Public_get_XmlValidatingReaderImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValidatingReaderImpl>(intPtr3) : null;
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x0006D4DC File Offset: 0x0006B6DC
		public unsafe XmlSchemaCollection SchemaCollection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_SchemaCollection_Public_get_XmlSchemaCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x0006D51C File Offset: 0x0006B71C
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x0006D55C File Offset: 0x0006B75C
		public unsafe SchemaNames SchemaNames
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 408585, RefRangeEnd = 408602, XrefRangeStart = 408571, XrefRangeEnd = 408585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_SchemaNames_Public_get_SchemaNames_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr3) : null;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x0006D59C File Offset: 0x0006B79C
		public unsafe PositionInfo PositionInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_PositionInfo_Public_get_PositionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PositionInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x0006D5DC File Offset: 0x0006B7DC
		// (set) Token: 0x06001500 RID: 5376 RVA: 0x0006D61C File Offset: 0x0006B81C
		public unsafe XmlResolver XmlResolver
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_XmlResolver_Public_get_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x0006D660 File Offset: 0x0006B860
		// (set) Token: 0x06001502 RID: 5378 RVA: 0x0006D6A0 File Offset: 0x0006B8A0
		public unsafe Uri BaseUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_BaseUri_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_set_BaseUri_Public_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x0006D6E4 File Offset: 0x0006B8E4
		public unsafe ValidationEventHandler EventHandler
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 408607, RefRangeEnd = 408629, XrefRangeStart = 408602, XrefRangeEnd = 408607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_EventHandler_Public_get_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr3) : null;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x0006D724 File Offset: 0x0006B924
		public unsafe SchemaInfo SchemaInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_SchemaInfo_Public_get_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x0006D764 File Offset: 0x0006B964
		public unsafe IDtdInfo DtdInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408629, XrefRangeEnd = 408631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_set_DtdInfo_Public_set_Void_IDtdInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x0006D7A8 File Offset: 0x0006B9A8
		public unsafe virtual bool PreserveWhitespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x0006D7F0 File Offset: 0x0006B9F0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseValidator.NativeMethodInfoPtr_Validate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x0006D82C File Offset: 0x0006BA2C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CompleteValidation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x0006D868 File Offset: 0x0006BA68
		[CallerCount(0)]
		public unsafe virtual Object FindId(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseValidator.NativeMethodInfoPtr_FindId_Public_Virtual_New_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0006D8C4 File Offset: 0x0006BAC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 408660, RefRangeEnd = 408662, XrefRangeStart = 408631, XrefRangeEnd = 408660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_ValidateText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0006D8F8 File Offset: 0x0006BAF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 408677, RefRangeEnd = 408679, XrefRangeStart = 408662, XrefRangeEnd = 408677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateWhitespace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_ValidateWhitespace_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0006D92C File Offset: 0x0006BB2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 408681, RefRangeEnd = 408683, XrefRangeStart = 408679, XrefRangeEnd = 408681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveTextValue(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_SaveTextValue_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0006D970 File Offset: 0x0006BB70
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 408686, RefRangeEnd = 408693, XrefRangeStart = 408683, XrefRangeEnd = 408686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0006D9B4 File Offset: 0x0006BBB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 408699, RefRangeEnd = 408702, XrefRangeStart = 408693, XrefRangeEnd = 408699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, Il2CppStringArray args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0006DA08 File Offset: 0x0006BC08
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 408708, RefRangeEnd = 408742, XrefRangeStart = 408702, XrefRangeEnd = 408708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x0006DA5C File Offset: 0x0006BC5C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 408745, RefRangeEnd = 408760, XrefRangeStart = 408742, XrefRangeEnd = 408745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSchemaException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0006DAA0 File Offset: 0x0006BCA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 408766, RefRangeEnd = 408768, XrefRangeStart = 408760, XrefRangeEnd = 408766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string msg, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x0006DB04 File Offset: 0x0006BD04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 408774, RefRangeEnd = 408779, XrefRangeStart = 408768, XrefRangeEnd = 408774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, Il2CppStringArray args, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_Il2CppStringArray_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x0006DB68 File Offset: 0x0006BD68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 408783, RefRangeEnd = 408785, XrefRangeStart = 408779, XrefRangeEnd = 408783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0006DBB8 File Offset: 0x0006BDB8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 408808, RefRangeEnd = 408813, XrefRangeStart = 408785, XrefRangeEnd = 408808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessEntity(SchemaInfo sinfo, string name, Object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sinfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventhandler);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_ProcessEntity_Protected_Static_Void_SchemaInfo_String_Object_ValidationEventHandler_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x0006DC54 File Offset: 0x0006BE54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 408832, RefRangeEnd = 408834, XrefRangeStart = 408813, XrefRangeEnd = 408832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sinfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandling);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_ProcessEntity_Protected_Static_Void_SchemaInfo_String_IValidationEventHandling_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0006DCDC File Offset: 0x0006BEDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 408874, RefRangeEnd = 408875, XrefRangeStart = 408834, XrefRangeEnd = 408874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaCollection);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandling);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref processIdentityConstraints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_CreateInstance_Public_Static_BaseValidator_ValidationType_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseValidator>(intPtr3) : null;
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00009580 File Offset: 0x00007780
		public BaseValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x0006DD60 File Offset: 0x0006BF60
		// (set) Token: 0x06001519 RID: 5401 RVA: 0x00009589 File Offset: 0x00007789
		public unsafe XmlSchemaCollection schemaCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_schemaCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_schemaCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x0006DD90 File Offset: 0x0006BF90
		// (set) Token: 0x0600151B RID: 5403 RVA: 0x000095A8 File Offset: 0x000077A8
		public unsafe IValidationEventHandling eventHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_eventHandling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IValidationEventHandling>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_eventHandling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x0006DDC0 File Offset: 0x0006BFC0
		// (set) Token: 0x0600151D RID: 5405 RVA: 0x000095C7 File Offset: 0x000077C7
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x0006DDF0 File Offset: 0x0006BFF0
		// (set) Token: 0x0600151F RID: 5407 RVA: 0x000095E6 File Offset: 0x000077E6
		public unsafe SchemaNames schemaNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_schemaNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_schemaNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x0006DE20 File Offset: 0x0006C020
		// (set) Token: 0x06001521 RID: 5409 RVA: 0x00009605 File Offset: 0x00007805
		public unsafe PositionInfo positionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_positionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PositionInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_positionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x0006DE50 File Offset: 0x0006C050
		// (set) Token: 0x06001523 RID: 5411 RVA: 0x00009624 File Offset: 0x00007824
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x0006DE80 File Offset: 0x0006C080
		// (set) Token: 0x06001525 RID: 5413 RVA: 0x00009643 File Offset: 0x00007843
		public unsafe Uri baseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_baseUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_baseUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x0006DEB0 File Offset: 0x0006C0B0
		// (set) Token: 0x06001527 RID: 5415 RVA: 0x00009662 File Offset: 0x00007862
		public unsafe SchemaInfo schemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_schemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_schemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x0006DEE0 File Offset: 0x0006C0E0
		// (set) Token: 0x06001529 RID: 5417 RVA: 0x00009681 File Offset: 0x00007881
		public unsafe XmlValidatingReaderImpl reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValidatingReaderImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x0006DF10 File Offset: 0x0006C110
		// (set) Token: 0x0600152B RID: 5419 RVA: 0x000096A0 File Offset: 0x000078A0
		public unsafe XmlQualifiedName elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_elementName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_elementName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x0006DF40 File Offset: 0x0006C140
		// (set) Token: 0x0600152D RID: 5421 RVA: 0x000096BF File Offset: 0x000078BF
		public unsafe ValidationState context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x0006DF70 File Offset: 0x0006C170
		// (set) Token: 0x0600152F RID: 5423 RVA: 0x000096DE File Offset: 0x000078DE
		public unsafe StringBuilder textValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_textValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_textValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x0006DFA0 File Offset: 0x0006C1A0
		// (set) Token: 0x06001531 RID: 5425 RVA: 0x000096FD File Offset: 0x000078FD
		public unsafe string textString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_textString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_textString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x0006DFC8 File Offset: 0x0006C1C8
		// (set) Token: 0x06001533 RID: 5427 RVA: 0x0000971C File Offset: 0x0000791C
		public unsafe bool hasSibling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_hasSibling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_hasSibling)) = value;
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x0006DFF0 File Offset: 0x0006C1F0
		// (set) Token: 0x06001535 RID: 5429 RVA: 0x00009737 File Offset: 0x00007937
		public unsafe bool checkDatatype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_checkDatatype);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_checkDatatype)) = value;
			}
		}

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeFieldInfoPtr_schemaCollection;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeFieldInfoPtr_eventHandling;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeFieldInfoPtr_schemaNames;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeFieldInfoPtr_positionInfo;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeFieldInfoPtr_baseUri;

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeFieldInfoPtr_schemaInfo;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeFieldInfoPtr_elementName;

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeFieldInfoPtr_textValue;

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeFieldInfoPtr_textString;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeFieldInfoPtr_hasSibling;

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeFieldInfoPtr_checkDatatype;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BaseValidator_0;

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeMethodInfoPtr_get_Reader_Public_get_XmlValidatingReaderImpl_0;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaCollection_Public_get_XmlSchemaCollection_0;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaNames_Public_get_SchemaNames_0;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeMethodInfoPtr_get_PositionInfo_Public_get_PositionInfo_0;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlResolver_Public_get_XmlResolver_0;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUri_Public_get_Uri_0;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseUri_Public_set_Void_Uri_0;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeMethodInfoPtr_get_EventHandler_Public_get_ValidationEventHandler_0;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaInfo_Public_get_SchemaInfo_0;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeMethodInfoPtr_set_DtdInfo_Public_set_Void_IDtdInfo_0;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Virtual_New_Void_0;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidation_Public_Virtual_New_Void_0;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeMethodInfoPtr_FindId_Public_Virtual_New_Object_String_0;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeMethodInfoPtr_ValidateText_Public_Void_0;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeMethodInfoPtr_ValidateWhitespace_Public_Void_0;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeMethodInfoPtr_SaveTextValue_Private_Void_String_0;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_0;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_Il2CppStringArray_0;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_0;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_0;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_XmlSeverityType_0;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_Il2CppStringArray_XmlSeverityType_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_XmlSeverityType_0;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEntity_Protected_Static_Void_SchemaInfo_String_Object_ValidationEventHandler_String_Int32_Int32_0;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEntity_Protected_Static_Void_SchemaInfo_String_IValidationEventHandling_String_Int32_Int32_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_BaseValidator_ValidationType_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_Boolean_0;
	}
}
