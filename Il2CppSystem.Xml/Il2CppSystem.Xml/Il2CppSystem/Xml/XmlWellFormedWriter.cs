using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200005D RID: 93
	public class XmlWellFormedWriter : XmlWriter
	{
		// Token: 0x06000913 RID: 2323 RVA: 0x0003ACE8 File Offset: 0x00038EE8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlWellFormedWriter()
		{
			Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlWellFormedWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr);
			XmlWellFormedWriter.NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "writer");
			XmlWellFormedWriter.NativeFieldInfoPtr_rawWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "rawWriter");
			XmlWellFormedWriter.NativeFieldInfoPtr_predefinedNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "predefinedNamespaces");
			XmlWellFormedWriter.NativeFieldInfoPtr_nsStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "nsStack");
			XmlWellFormedWriter.NativeFieldInfoPtr_nsTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "nsTop");
			XmlWellFormedWriter.NativeFieldInfoPtr_nsHashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "nsHashtable");
			XmlWellFormedWriter.NativeFieldInfoPtr_useNsHashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "useNsHashtable");
			XmlWellFormedWriter.NativeFieldInfoPtr_elemScopeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "elemScopeStack");
			XmlWellFormedWriter.NativeFieldInfoPtr_elemTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "elemTop");
			XmlWellFormedWriter.NativeFieldInfoPtr_attrStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "attrStack");
			XmlWellFormedWriter.NativeFieldInfoPtr_attrCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "attrCount");
			XmlWellFormedWriter.NativeFieldInfoPtr_attrHashTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "attrHashTable");
			XmlWellFormedWriter.NativeFieldInfoPtr_specAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "specAttr");
			XmlWellFormedWriter.NativeFieldInfoPtr_attrValueCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "attrValueCache");
			XmlWellFormedWriter.NativeFieldInfoPtr_curDeclPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "curDeclPrefix");
			XmlWellFormedWriter.NativeFieldInfoPtr_stateTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "stateTable");
			XmlWellFormedWriter.NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "currentState");
			XmlWellFormedWriter.NativeFieldInfoPtr_checkCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "checkCharacters");
			XmlWellFormedWriter.NativeFieldInfoPtr_omitDuplNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "omitDuplNamespaces");
			XmlWellFormedWriter.NativeFieldInfoPtr_writeEndDocumentOnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "writeEndDocumentOnClose");
			XmlWellFormedWriter.NativeFieldInfoPtr_conformanceLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "conformanceLevel");
			XmlWellFormedWriter.NativeFieldInfoPtr_dtdWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "dtdWritten");
			XmlWellFormedWriter.NativeFieldInfoPtr_xmlDeclFollows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "xmlDeclFollows");
			XmlWellFormedWriter.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "xmlCharType");
			XmlWellFormedWriter.NativeFieldInfoPtr_hasher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "hasher");
			XmlWellFormedWriter.NativeFieldInfoPtr_stateName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "stateName");
			XmlWellFormedWriter.NativeFieldInfoPtr_tokenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "tokenName");
			XmlWellFormedWriter.NativeFieldInfoPtr_state2WriteState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "state2WriteState");
			XmlWellFormedWriter.NativeFieldInfoPtr_StateTableDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "StateTableDocument");
			XmlWellFormedWriter.NativeFieldInfoPtr_StateTableAuto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "StateTableAuto");
			XmlWellFormedWriter.NativeMethodInfoPtr__ctor_Internal_Void_XmlWriter_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664742);
			XmlWellFormedWriter.NativeMethodInfoPtr_get_WriteState_Public_Virtual_get_WriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664743);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664744);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664745);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664746);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteEndElement_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664747);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteFullEndElement_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664748);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664749);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664750);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664751);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664752);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664753);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664754);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664755);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664756);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664757);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664758);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664759);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664760);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664761);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteBase64_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664762);
			XmlWellFormedWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664763);
			XmlWellFormedWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664764);
			XmlWellFormedWriter.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664765);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664766);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664767);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664768);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664769);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664770);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664771);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664772);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664773);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664774);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteBinHex_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664775);
			XmlWellFormedWriter.NativeMethodInfoPtr_get_RawWriter_Internal_get_XmlRawWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664776);
			XmlWellFormedWriter.NativeMethodInfoPtr_get_SaveAttrValue_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664777);
			XmlWellFormedWriter.NativeMethodInfoPtr_get_InBase64_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664778);
			XmlWellFormedWriter.NativeMethodInfoPtr_SetSpecialAttribute_Private_Void_SpecialAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664779);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartDocumentImpl_Private_Void_XmlStandalone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664780);
			XmlWellFormedWriter.NativeMethodInfoPtr_StartFragment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664781);
			XmlWellFormedWriter.NativeMethodInfoPtr_PushNamespaceImplicit_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664782);
			XmlWellFormedWriter.NativeMethodInfoPtr_PushNamespaceExplicit_Private_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664783);
			XmlWellFormedWriter.NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_NamespaceKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664784);
			XmlWellFormedWriter.NativeMethodInfoPtr_AddToNamespaceHashtable_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664785);
			XmlWellFormedWriter.NativeMethodInfoPtr_LookupNamespaceIndex_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664786);
			XmlWellFormedWriter.NativeMethodInfoPtr_PopNamespaces_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664787);
			XmlWellFormedWriter.NativeMethodInfoPtr_DupAttrException_Private_Static_XmlException_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664788);
			XmlWellFormedWriter.NativeMethodInfoPtr_AdvanceState_Private_Void_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664789);
			XmlWellFormedWriter.NativeMethodInfoPtr_StartElementContent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664790);
			XmlWellFormedWriter.NativeMethodInfoPtr_GetStateName_Private_Static_String_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664791);
			XmlWellFormedWriter.NativeMethodInfoPtr_LookupNamespace_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664792);
			XmlWellFormedWriter.NativeMethodInfoPtr_LookupLocalNamespace_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664793);
			XmlWellFormedWriter.NativeMethodInfoPtr_GeneratePrefix_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664794);
			XmlWellFormedWriter.NativeMethodInfoPtr_CheckNCName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664795);
			XmlWellFormedWriter.NativeMethodInfoPtr_InvalidCharsException_Private_Static_Exception_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664796);
			XmlWellFormedWriter.NativeMethodInfoPtr_ThrowInvalidStateTransition_Private_Void_Token_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664797);
			XmlWellFormedWriter.NativeMethodInfoPtr_get_IsClosedOrErrorState_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664798);
			XmlWellFormedWriter.NativeMethodInfoPtr_AddAttribute_Private_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664799);
			XmlWellFormedWriter.NativeMethodInfoPtr_AddToAttrHashTable_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664800);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0003B40C File Offset: 0x0003960C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396000, XrefRangeEnd = 396050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlWellFormedWriter(XmlWriter writer, XmlWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr__ctor_Internal_Void_XmlWriter_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x0003B46C File Offset: 0x0003966C
		public unsafe override WriteState WriteState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396050, XrefRangeEnd = 396051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_get_WriteState_Public_Virtual_get_WriteState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0003B4B4 File Offset: 0x000396B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396051, XrefRangeEnd = 396052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartDocument()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0003B4F0 File Offset: 0x000396F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396052, XrefRangeEnd = 396070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pubid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sysid);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0003B574 File Offset: 0x00039774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396070, XrefRangeEnd = 396091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartElement(string prefix, string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0003B5E8 File Offset: 0x000397E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396091, XrefRangeEnd = 396094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteEndElement_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0003B624 File Offset: 0x00039824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396094, XrefRangeEnd = 396097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteFullEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteFullEndElement_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0003B660 File Offset: 0x00039860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396097, XrefRangeEnd = 396151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartAttribute(string prefix, string localName, string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0003B6D4 File Offset: 0x000398D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396151, XrefRangeEnd = 396221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0003B710 File Offset: 0x00039910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396221, XrefRangeEnd = 396224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCData(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0003B760 File Offset: 0x00039960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396224, XrefRangeEnd = 396227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteComment(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0003B7B0 File Offset: 0x000399B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396227, XrefRangeEnd = 396240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteProcessingInstruction(string name, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0003B810 File Offset: 0x00039A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396240, XrefRangeEnd = 396244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEntityRef(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0003B860 File Offset: 0x00039A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396244, XrefRangeEnd = 396256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCharEntity(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0003B8AC File Offset: 0x00039AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396256, XrefRangeEnd = 396269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lowChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0003B904 File Offset: 0x00039B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396269, XrefRangeEnd = 396279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteWhitespace(string ws)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ws);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0003B954 File Offset: 0x00039B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396279, XrefRangeEnd = 396288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteString(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0003B9A4 File Offset: 0x00039BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396288, XrefRangeEnd = 396299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteChars(Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0003BA10 File Offset: 0x00039C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396299, XrefRangeEnd = 396310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteRaw(Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0003BA7C File Offset: 0x00039C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396310, XrefRangeEnd = 396317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteRaw(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0003BACC File Offset: 0x00039CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396317, XrefRangeEnd = 396319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteBase64(Il2CppStructArray<byte> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteBase64_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0003BB38 File Offset: 0x00039D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396319, XrefRangeEnd = 396324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0003BB74 File Offset: 0x00039D74
		[CallerCount(0)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0003BBB0 File Offset: 0x00039DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396324, XrefRangeEnd = 396330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string LookupPrefix(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0003BC04 File Offset: 0x00039E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396330, XrefRangeEnd = 396331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteValue(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0003BC50 File Offset: 0x00039E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396331, XrefRangeEnd = 396332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteValue(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0003BC9C File Offset: 0x00039E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396332, XrefRangeEnd = 396333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteValue(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0003BCE8 File Offset: 0x00039EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396333, XrefRangeEnd = 396334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0003BD34 File Offset: 0x00039F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396334, XrefRangeEnd = 396335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteValue(Decimal value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0003BD80 File Offset: 0x00039F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396335, XrefRangeEnd = 396336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteValue(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0003BDCC File Offset: 0x00039FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396336, XrefRangeEnd = 396337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteValue(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0003BE18 File Offset: 0x0003A018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396337, XrefRangeEnd = 396342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteValue(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0003BE68 File Offset: 0x0003A068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396342, XrefRangeEnd = 396349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0003BEB8 File Offset: 0x0003A0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396349, XrefRangeEnd = 396351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteBinHex(Il2CppStructArray<byte> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteBinHex_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x0003BF24 File Offset: 0x0003A124
		public unsafe XmlRawWriter RawWriter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_get_RawWriter_Internal_get_XmlRawWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlRawWriter>(intPtr3) : null;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x0003BF64 File Offset: 0x0003A164
		public unsafe bool SaveAttrValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_get_SaveAttrValue_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x0003BFA0 File Offset: 0x0003A1A0
		public unsafe bool InBase64
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_get_InBase64_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0003BFDC File Offset: 0x0003A1DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 396362, RefRangeEnd = 396366, XrefRangeStart = 396351, XrefRangeEnd = 396362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute special)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref special;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_SetSpecialAttribute_Private_Void_SpecialAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0003C01C File Offset: 0x0003A21C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 396373, RefRangeEnd = 396374, XrefRangeStart = 396366, XrefRangeEnd = 396373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteStartDocumentImpl(XmlStandalone standalone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref standalone;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartDocumentImpl_Private_Void_XmlStandalone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0003C05C File Offset: 0x0003A25C
		[CallerCount(0)]
		public unsafe void StartFragment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_StartFragment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0003C090 File Offset: 0x0003A290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 396396, RefRangeEnd = 396398, XrefRangeStart = 396374, XrefRangeEnd = 396396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushNamespaceImplicit(string prefix, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_PushNamespaceImplicit_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0003C0E4 File Offset: 0x0003A2E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 396420, RefRangeEnd = 396422, XrefRangeStart = 396398, XrefRangeEnd = 396420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PushNamespaceExplicit(string prefix, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_PushNamespaceExplicit_Private_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0003C144 File Offset: 0x0003A344
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 396433, RefRangeEnd = 396435, XrefRangeStart = 396422, XrefRangeEnd = 396433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNamespace(string prefix, string ns, XmlWellFormedWriter.NamespaceKind kind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_NamespaceKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0003C1A8 File Offset: 0x0003A3A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 396439, RefRangeEnd = 396440, XrefRangeStart = 396435, XrefRangeEnd = 396439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToNamespaceHashtable(int namespaceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namespaceIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_AddToNamespaceHashtable_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0003C1E8 File Offset: 0x0003A3E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 396441, RefRangeEnd = 396443, XrefRangeStart = 396440, XrefRangeEnd = 396441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LookupNamespaceIndex(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_LookupNamespaceIndex_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0003C238 File Offset: 0x0003A438
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 396449, RefRangeEnd = 396451, XrefRangeStart = 396443, XrefRangeEnd = 396449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopNamespaces(int indexFrom, int indexTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref indexFrom;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_PopNamespaces_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0003C284 File Offset: 0x0003A484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396451, XrefRangeEnd = 396467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlException DupAttrException(string prefix, string localName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_DupAttrException_Private_Static_XmlException_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlException>(intPtr3) : null;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0003C2DC File Offset: 0x0003A4DC
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 396471, RefRangeEnd = 396504, XrefRangeStart = 396467, XrefRangeEnd = 396471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdvanceState(XmlWellFormedWriter.Token token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_AdvanceState_Private_Void_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0003C31C File Offset: 0x0003A51C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 396513, RefRangeEnd = 396514, XrefRangeStart = 396504, XrefRangeEnd = 396513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartElementContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_StartElementContent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0003C350 File Offset: 0x0003A550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 396519, RefRangeEnd = 396520, XrefRangeStart = 396514, XrefRangeEnd = 396519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStateName(XmlWellFormedWriter.State state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_GetStateName_Private_Static_String_State_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0003C388 File Offset: 0x0003A588
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 396523, RefRangeEnd = 396529, XrefRangeStart = 396520, XrefRangeEnd = 396523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_LookupNamespace_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0003C3D0 File Offset: 0x0003A5D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 396531, RefRangeEnd = 396532, XrefRangeStart = 396529, XrefRangeEnd = 396531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LookupLocalNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_LookupLocalNamespace_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0003C418 File Offset: 0x0003A618
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 396560, RefRangeEnd = 396562, XrefRangeStart = 396532, XrefRangeEnd = 396560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GeneratePrefix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_GeneratePrefix_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0003C450 File Offset: 0x0003A650
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 396562, RefRangeEnd = 396568, XrefRangeStart = 396562, XrefRangeEnd = 396562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNCName(string ncname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ncname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_CheckNCName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0003C494 File Offset: 0x0003A694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396568, XrefRangeEnd = 396585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidCharsException(string name, int badCharIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref badCharIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_InvalidCharsException_Private_Static_Exception_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0003C4E8 File Offset: 0x0003A6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396585, XrefRangeEnd = 396620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowInvalidStateTransition(XmlWellFormedWriter.Token token, XmlWellFormedWriter.State currentState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_ThrowInvalidStateTransition_Private_Void_Token_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x0003C534 File Offset: 0x0003A734
		public unsafe bool IsClosedOrErrorState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_get_IsClosedOrErrorState_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0003C570 File Offset: 0x0003A770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 396635, RefRangeEnd = 396636, XrefRangeStart = 396620, XrefRangeEnd = 396635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAttribute(string prefix, string localName, string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_AddAttribute_Private_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0003C5D8 File Offset: 0x0003A7D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 396639, RefRangeEnd = 396641, XrefRangeStart = 396636, XrefRangeEnd = 396639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToAttrHashTable(int attributeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attributeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_AddToAttrHashTable_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00005123 File Offset: 0x00003323
		public XmlWellFormedWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x0003C618 File Offset: 0x0003A818
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x0000512C File Offset: 0x0000332C
		public unsafe XmlWriter writer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_writer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_writer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x0003C648 File Offset: 0x0003A848
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x0000514B File Offset: 0x0000334B
		public unsafe XmlRawWriter rawWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_rawWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlRawWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_rawWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x0003C678 File Offset: 0x0003A878
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x0000516A File Offset: 0x0000336A
		public unsafe IXmlNamespaceResolver predefinedNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_predefinedNamespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_predefinedNamespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x0003C6A8 File Offset: 0x0003A8A8
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x00005189 File Offset: 0x00003389
		public unsafe Il2CppReferenceArray<XmlWellFormedWriter.Namespace> nsStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_nsStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlWellFormedWriter.Namespace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_nsStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x0003C6D8 File Offset: 0x0003A8D8
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x000051A8 File Offset: 0x000033A8
		public unsafe int nsTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_nsTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_nsTop)) = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x0003C700 File Offset: 0x0003A900
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x000051C3 File Offset: 0x000033C3
		public unsafe Dictionary<string, int> nsHashtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_nsHashtable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_nsHashtable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x0003C730 File Offset: 0x0003A930
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x000051E2 File Offset: 0x000033E2
		public unsafe bool useNsHashtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_useNsHashtable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_useNsHashtable)) = value;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x0003C758 File Offset: 0x0003A958
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x000051FD File Offset: 0x000033FD
		public unsafe Il2CppReferenceArray<XmlWellFormedWriter.ElementScope> elemScopeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_elemScopeStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlWellFormedWriter.ElementScope>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_elemScopeStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x0003C788 File Offset: 0x0003A988
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x0000521C File Offset: 0x0000341C
		public unsafe int elemTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_elemTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_elemTop)) = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x0003C7B0 File Offset: 0x0003A9B0
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x00005237 File Offset: 0x00003437
		public unsafe Il2CppReferenceArray<XmlWellFormedWriter.AttrName> attrStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_attrStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlWellFormedWriter.AttrName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_attrStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x0003C7E0 File Offset: 0x0003A9E0
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x00005256 File Offset: 0x00003456
		public unsafe int attrCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_attrCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_attrCount)) = value;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x0003C808 File Offset: 0x0003AA08
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x00005271 File Offset: 0x00003471
		public unsafe Dictionary<string, int> attrHashTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_attrHashTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_attrHashTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x0003C838 File Offset: 0x0003AA38
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x00005290 File Offset: 0x00003490
		public unsafe XmlWellFormedWriter.SpecialAttribute specAttr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_specAttr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_specAttr)) = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0003C860 File Offset: 0x0003AA60
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x000052AB File Offset: 0x000034AB
		public unsafe XmlWellFormedWriter.AttributeValueCache attrValueCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_attrValueCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlWellFormedWriter.AttributeValueCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_attrValueCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0003C890 File Offset: 0x0003AA90
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x000052CA File Offset: 0x000034CA
		public unsafe string curDeclPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_curDeclPrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_curDeclPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0003C8B8 File Offset: 0x0003AAB8
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x000052E9 File Offset: 0x000034E9
		public unsafe Il2CppStructArray<XmlWellFormedWriter.State> stateTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_stateTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XmlWellFormedWriter.State>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_stateTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0003C8E8 File Offset: 0x0003AAE8
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x00005308 File Offset: 0x00003508
		public unsafe XmlWellFormedWriter.State currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_currentState)) = value;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0003C910 File Offset: 0x0003AB10
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x00005323 File Offset: 0x00003523
		public unsafe bool checkCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_checkCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_checkCharacters)) = value;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0003C938 File Offset: 0x0003AB38
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x0000533E File Offset: 0x0000353E
		public unsafe bool omitDuplNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_omitDuplNamespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_omitDuplNamespaces)) = value;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x0003C960 File Offset: 0x0003AB60
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x00005359 File Offset: 0x00003559
		public unsafe bool writeEndDocumentOnClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_writeEndDocumentOnClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_writeEndDocumentOnClose)) = value;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x0003C988 File Offset: 0x0003AB88
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x00005374 File Offset: 0x00003574
		public unsafe ConformanceLevel conformanceLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_conformanceLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_conformanceLevel)) = value;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x0003C9B0 File Offset: 0x0003ABB0
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x0000538F File Offset: 0x0000358F
		public unsafe bool dtdWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_dtdWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_dtdWritten)) = value;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x0003C9D8 File Offset: 0x0003ABD8
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x000053AA File Offset: 0x000035AA
		public unsafe bool xmlDeclFollows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_xmlDeclFollows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_xmlDeclFollows)) = value;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x0003CA00 File Offset: 0x0003AC00
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x000053C5 File Offset: 0x000035C5
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x0003CA30 File Offset: 0x0003AC30
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x000053F3 File Offset: 0x000035F3
		public unsafe SecureStringHasher hasher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_hasher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SecureStringHasher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_hasher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x0003CA60 File Offset: 0x0003AC60
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x00005412 File Offset: 0x00003612
		public unsafe static Il2CppStringArray stateName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlWellFormedWriter.NativeFieldInfoPtr_stateName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlWellFormedWriter.NativeFieldInfoPtr_stateName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x0003CA88 File Offset: 0x0003AC88
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x00005424 File Offset: 0x00003624
		public unsafe static Il2CppStringArray tokenName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlWellFormedWriter.NativeFieldInfoPtr_tokenName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlWellFormedWriter.NativeFieldInfoPtr_tokenName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x0003CAB0 File Offset: 0x0003ACB0
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x00005436 File Offset: 0x00003636
		public unsafe static Il2CppStructArray<WriteState> state2WriteState
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlWellFormedWriter.NativeFieldInfoPtr_state2WriteState, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<WriteState>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlWellFormedWriter.NativeFieldInfoPtr_state2WriteState, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x0003CAD8 File Offset: 0x0003ACD8
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x00005448 File Offset: 0x00003648
		public unsafe static Il2CppStructArray<XmlWellFormedWriter.State> StateTableDocument
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlWellFormedWriter.NativeFieldInfoPtr_StateTableDocument, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XmlWellFormedWriter.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlWellFormedWriter.NativeFieldInfoPtr_StateTableDocument, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x0003CB00 File Offset: 0x0003AD00
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x0000545A File Offset: 0x0000365A
		public unsafe static Il2CppStructArray<XmlWellFormedWriter.State> StateTableAuto
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlWellFormedWriter.NativeFieldInfoPtr_StateTableAuto, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XmlWellFormedWriter.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlWellFormedWriter.NativeFieldInfoPtr_StateTableAuto, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeFieldInfoPtr_writer;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeFieldInfoPtr_rawWriter;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeFieldInfoPtr_predefinedNamespaces;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeFieldInfoPtr_nsStack;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeFieldInfoPtr_nsTop;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeFieldInfoPtr_nsHashtable;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeFieldInfoPtr_useNsHashtable;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeFieldInfoPtr_elemScopeStack;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeFieldInfoPtr_elemTop;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeFieldInfoPtr_attrStack;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeFieldInfoPtr_attrCount;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeFieldInfoPtr_attrHashTable;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeFieldInfoPtr_specAttr;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeFieldInfoPtr_attrValueCache;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeFieldInfoPtr_curDeclPrefix;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeFieldInfoPtr_stateTable;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeFieldInfoPtr_currentState;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeFieldInfoPtr_checkCharacters;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeFieldInfoPtr_omitDuplNamespaces;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr_writeEndDocumentOnClose;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr_conformanceLevel;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr_dtdWritten;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeFieldInfoPtr_xmlDeclFollows;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr_hasher;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr_stateName;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr_tokenName;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_state2WriteState;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_StateTableDocument;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_StateTableAuto;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlWriter_XmlWriterSettings_0;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteState_Public_Virtual_get_WriteState_0;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndElement_Public_Virtual_Void_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_WriteFullEndElement_Public_Virtual_Void_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_WriteBase64_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_DateTime_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Double_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Single_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Decimal_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Int32_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Int64_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_String_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Object_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_WriteBinHex_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_get_RawWriter_Internal_get_XmlRawWriter_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveAttrValue_Private_get_Boolean_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_get_InBase64_Private_get_Boolean_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_SetSpecialAttribute_Private_Void_SpecialAttribute_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartDocumentImpl_Private_Void_XmlStandalone_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_StartFragment_Private_Void_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_PushNamespaceImplicit_Private_Void_String_String_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_PushNamespaceExplicit_Private_Boolean_String_String_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_NamespaceKind_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_AddToNamespaceHashtable_Private_Void_Int32_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespaceIndex_Private_Int32_String_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_PopNamespaces_Private_Void_Int32_Int32_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_DupAttrException_Private_Static_XmlException_String_String_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_AdvanceState_Private_Void_Token_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_StartElementContent_Private_Void_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_GetStateName_Private_Static_String_State_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Internal_String_String_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_LookupLocalNamespace_Private_String_String_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePrefix_Private_String_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_CheckNCName_Private_Void_String_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_InvalidCharsException_Private_Static_Exception_String_Int32_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidStateTransition_Private_Void_Token_State_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_get_IsClosedOrErrorState_Private_get_Boolean_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Private_Void_String_String_String_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_AddToAttrHashTable_Private_Void_Int32_0;

		// Token: 0x02000211 RID: 529
		[OriginalName("System.Xml.dll", "", "State")]
		public enum State
		{
			// Token: 0x04002153 RID: 8531
			Start,
			// Token: 0x04002154 RID: 8532
			TopLevel,
			// Token: 0x04002155 RID: 8533
			Document,
			// Token: 0x04002156 RID: 8534
			Element,
			// Token: 0x04002157 RID: 8535
			Content,
			// Token: 0x04002158 RID: 8536
			B64Content,
			// Token: 0x04002159 RID: 8537
			B64Attribute,
			// Token: 0x0400215A RID: 8538
			AfterRootEle,
			// Token: 0x0400215B RID: 8539
			Attribute,
			// Token: 0x0400215C RID: 8540
			SpecialAttr,
			// Token: 0x0400215D RID: 8541
			EndDocument,
			// Token: 0x0400215E RID: 8542
			RootLevelAttr,
			// Token: 0x0400215F RID: 8543
			RootLevelSpecAttr,
			// Token: 0x04002160 RID: 8544
			RootLevelB64Attr,
			// Token: 0x04002161 RID: 8545
			AfterRootLevelAttr,
			// Token: 0x04002162 RID: 8546
			Closed,
			// Token: 0x04002163 RID: 8547
			Error,
			// Token: 0x04002164 RID: 8548
			StartContent = 101,
			// Token: 0x04002165 RID: 8549
			StartContentEle,
			// Token: 0x04002166 RID: 8550
			StartContentB64,
			// Token: 0x04002167 RID: 8551
			StartDoc,
			// Token: 0x04002168 RID: 8552
			StartDocEle = 106,
			// Token: 0x04002169 RID: 8553
			EndAttrSEle,
			// Token: 0x0400216A RID: 8554
			EndAttrEEle,
			// Token: 0x0400216B RID: 8555
			EndAttrSCont,
			// Token: 0x0400216C RID: 8556
			EndAttrSAttr = 111,
			// Token: 0x0400216D RID: 8557
			PostB64Cont,
			// Token: 0x0400216E RID: 8558
			PostB64Attr,
			// Token: 0x0400216F RID: 8559
			PostB64RootAttr,
			// Token: 0x04002170 RID: 8560
			StartFragEle,
			// Token: 0x04002171 RID: 8561
			StartFragCont,
			// Token: 0x04002172 RID: 8562
			StartFragB64,
			// Token: 0x04002173 RID: 8563
			StartRootLevelAttr
		}

		// Token: 0x02000212 RID: 530
		[OriginalName("System.Xml.dll", "", "Token")]
		public enum Token
		{
			// Token: 0x04002175 RID: 8565
			StartDocument,
			// Token: 0x04002176 RID: 8566
			EndDocument,
			// Token: 0x04002177 RID: 8567
			PI,
			// Token: 0x04002178 RID: 8568
			Comment,
			// Token: 0x04002179 RID: 8569
			Dtd,
			// Token: 0x0400217A RID: 8570
			StartElement,
			// Token: 0x0400217B RID: 8571
			EndElement,
			// Token: 0x0400217C RID: 8572
			StartAttribute,
			// Token: 0x0400217D RID: 8573
			EndAttribute,
			// Token: 0x0400217E RID: 8574
			Text,
			// Token: 0x0400217F RID: 8575
			CData,
			// Token: 0x04002180 RID: 8576
			AtomicValue,
			// Token: 0x04002181 RID: 8577
			Base64,
			// Token: 0x04002182 RID: 8578
			RawData,
			// Token: 0x04002183 RID: 8579
			Whitespace
		}

		// Token: 0x02000213 RID: 531
		public class NamespaceResolverProxy : Object
		{
			// Token: 0x06002B49 RID: 11081 RVA: 0x000C3404 File Offset: 0x000C1604
			// Note: this type is marked as 'beforefieldinit'.
			static NamespaceResolverProxy()
			{
				Il2CppClassPointerStore<XmlWellFormedWriter.NamespaceResolverProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "NamespaceResolverProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWellFormedWriter.NamespaceResolverProxy>.NativeClassPtr);
				XmlWellFormedWriter.NamespaceResolverProxy.NativeFieldInfoPtr_wfWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.NamespaceResolverProxy>.NativeClassPtr, "wfWriter");
				XmlWellFormedWriter.NamespaceResolverProxy.NativeMethodInfoPtr__ctor_Internal_Void_XmlWellFormedWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.NamespaceResolverProxy>.NativeClassPtr, 100664802);
				XmlWellFormedWriter.NamespaceResolverProxy.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.NamespaceResolverProxy>.NativeClassPtr, 100664803);
				XmlWellFormedWriter.NamespaceResolverProxy.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.NamespaceResolverProxy>.NativeClassPtr, 100664804);
				XmlWellFormedWriter.NamespaceResolverProxy.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.NamespaceResolverProxy>.NativeClassPtr, 100664805);
			}

			// Token: 0x06002B4A RID: 11082 RVA: 0x000C3494 File Offset: 0x000C1694
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NamespaceResolverProxy(XmlWellFormedWriter wfWriter)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWellFormedWriter.NamespaceResolverProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wfWriter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NamespaceResolverProxy.NativeMethodInfoPtr__ctor_Internal_Void_XmlWellFormedWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B4B RID: 11083 RVA: 0x000C34E0 File Offset: 0x000C16E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395751, XrefRangeEnd = 395756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IDictionary<string, string> System_Xml_IXmlNamespaceResolver_GetNamespacesInScope(XmlNamespaceScope scope)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref scope;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NamespaceResolverProxy.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
				}
			}

			// Token: 0x06002B4C RID: 11084 RVA: 0x000C352C File Offset: 0x000C172C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395756, XrefRangeEnd = 395758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupNamespace(string prefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NamespaceResolverProxy.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002B4D RID: 11085 RVA: 0x000C3574 File Offset: 0x000C1774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395758, XrefRangeEnd = 395759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupPrefix(string namespaceName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NamespaceResolverProxy.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002B4E RID: 11086 RVA: 0x00012677 File Offset: 0x00010877
			public NamespaceResolverProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ECC RID: 3788
			// (get) Token: 0x06002B4F RID: 11087 RVA: 0x000C35BC File Offset: 0x000C17BC
			// (set) Token: 0x06002B50 RID: 11088 RVA: 0x00012680 File Offset: 0x00010880
			public unsafe XmlWellFormedWriter wfWriter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NamespaceResolverProxy.NativeFieldInfoPtr_wfWriter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlWellFormedWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NamespaceResolverProxy.NativeFieldInfoPtr_wfWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002184 RID: 8580
			private static readonly IntPtr NativeFieldInfoPtr_wfWriter;

			// Token: 0x04002185 RID: 8581
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlWellFormedWriter_0;

			// Token: 0x04002186 RID: 8582
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0;

			// Token: 0x04002187 RID: 8583
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0;

			// Token: 0x04002188 RID: 8584
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0;
		}

		// Token: 0x02000214 RID: 532
		public sealed class ElementScope : ValueType
		{
			// Token: 0x06002B51 RID: 11089 RVA: 0x000C35EC File Offset: 0x000C17EC
			// Note: this type is marked as 'beforefieldinit'.
			static ElementScope()
			{
				Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "ElementScope");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr);
				XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_prevNSTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, "prevNSTop");
				XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, "prefix");
				XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, "localName");
				XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_namespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, "namespaceUri");
				XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_xmlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, "xmlSpace");
				XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_xmlLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, "xmlLang");
				XmlWellFormedWriter.ElementScope.NativeMethodInfoPtr_Set_Internal_Void_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, 100664806);
				XmlWellFormedWriter.ElementScope.NativeMethodInfoPtr_WriteEndElement_Internal_Void_XmlRawWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, 100664807);
				XmlWellFormedWriter.ElementScope.NativeMethodInfoPtr_WriteFullEndElement_Internal_Void_XmlRawWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, 100664808);
			}

			// Token: 0x06002B52 RID: 11090 RVA: 0x000C36CC File Offset: 0x000C18CC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 395759, RefRangeEnd = 395761, XrefRangeStart = 395759, XrefRangeEnd = 395759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(string prefix, string localName, string namespaceUri, int prevNSTop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevNSTop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.ElementScope.NativeMethodInfoPtr_Set_Internal_Void_String_String_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B53 RID: 11091 RVA: 0x000C3748 File Offset: 0x000C1948
			[CallerCount(0)]
			public unsafe void WriteEndElement(XmlRawWriter rawWriter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawWriter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.ElementScope.NativeMethodInfoPtr_WriteEndElement_Internal_Void_XmlRawWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B54 RID: 11092 RVA: 0x000C3790 File Offset: 0x000C1990
			[CallerCount(0)]
			public unsafe void WriteFullEndElement(XmlRawWriter rawWriter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawWriter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.ElementScope.NativeMethodInfoPtr_WriteFullEndElement_Internal_Void_XmlRawWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B55 RID: 11093 RVA: 0x0001269F File Offset: 0x0001089F
			public ElementScope(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002B56 RID: 11094 RVA: 0x000126A8 File Offset: 0x000108A8
			public ElementScope()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr))
			{
			}

			// Token: 0x17000ECD RID: 3789
			// (get) Token: 0x06002B57 RID: 11095 RVA: 0x000C37D8 File Offset: 0x000C19D8
			// (set) Token: 0x06002B58 RID: 11096 RVA: 0x000126BA File Offset: 0x000108BA
			public unsafe int prevNSTop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_prevNSTop);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_prevNSTop)) = value;
				}
			}

			// Token: 0x17000ECE RID: 3790
			// (get) Token: 0x06002B59 RID: 11097 RVA: 0x000C3800 File Offset: 0x000C1A00
			// (set) Token: 0x06002B5A RID: 11098 RVA: 0x000126D5 File Offset: 0x000108D5
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000ECF RID: 3791
			// (get) Token: 0x06002B5B RID: 11099 RVA: 0x000C3828 File Offset: 0x000C1A28
			// (set) Token: 0x06002B5C RID: 11100 RVA: 0x000126F4 File Offset: 0x000108F4
			public unsafe string localName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_localName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000ED0 RID: 3792
			// (get) Token: 0x06002B5D RID: 11101 RVA: 0x000C3850 File Offset: 0x000C1A50
			// (set) Token: 0x06002B5E RID: 11102 RVA: 0x00012713 File Offset: 0x00010913
			public unsafe string namespaceUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_namespaceUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_namespaceUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000ED1 RID: 3793
			// (get) Token: 0x06002B5F RID: 11103 RVA: 0x000C3878 File Offset: 0x000C1A78
			// (set) Token: 0x06002B60 RID: 11104 RVA: 0x00012732 File Offset: 0x00010932
			public unsafe XmlSpace xmlSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_xmlSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_xmlSpace)) = value;
				}
			}

			// Token: 0x17000ED2 RID: 3794
			// (get) Token: 0x06002B61 RID: 11105 RVA: 0x000C38A0 File Offset: 0x000C1AA0
			// (set) Token: 0x06002B62 RID: 11106 RVA: 0x0001274D File Offset: 0x0001094D
			public unsafe string xmlLang
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_xmlLang);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_xmlLang), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04002189 RID: 8585
			private static readonly IntPtr NativeFieldInfoPtr_prevNSTop;

			// Token: 0x0400218A RID: 8586
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x0400218B RID: 8587
			private static readonly IntPtr NativeFieldInfoPtr_localName;

			// Token: 0x0400218C RID: 8588
			private static readonly IntPtr NativeFieldInfoPtr_namespaceUri;

			// Token: 0x0400218D RID: 8589
			private static readonly IntPtr NativeFieldInfoPtr_xmlSpace;

			// Token: 0x0400218E RID: 8590
			private static readonly IntPtr NativeFieldInfoPtr_xmlLang;

			// Token: 0x0400218F RID: 8591
			private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_String_String_String_Int32_0;

			// Token: 0x04002190 RID: 8592
			private static readonly IntPtr NativeMethodInfoPtr_WriteEndElement_Internal_Void_XmlRawWriter_0;

			// Token: 0x04002191 RID: 8593
			private static readonly IntPtr NativeMethodInfoPtr_WriteFullEndElement_Internal_Void_XmlRawWriter_0;
		}

		// Token: 0x02000215 RID: 533
		[OriginalName("System.Xml.dll", "", "NamespaceKind")]
		public enum NamespaceKind
		{
			// Token: 0x04002193 RID: 8595
			Written,
			// Token: 0x04002194 RID: 8596
			NeedToWrite,
			// Token: 0x04002195 RID: 8597
			Implied,
			// Token: 0x04002196 RID: 8598
			Special
		}

		// Token: 0x02000216 RID: 534
		public sealed class Namespace : ValueType
		{
			// Token: 0x06002B63 RID: 11107 RVA: 0x000C38C8 File Offset: 0x000C1AC8
			// Note: this type is marked as 'beforefieldinit'.
			static Namespace()
			{
				Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "Namespace");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr);
				XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr, "prefix");
				XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_namespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr, "namespaceUri");
				XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr, "kind");
				XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_prevNsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr, "prevNsIndex");
				XmlWellFormedWriter.Namespace.NativeMethodInfoPtr_Set_Internal_Void_String_String_NamespaceKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr, 100664809);
				XmlWellFormedWriter.Namespace.NativeMethodInfoPtr_WriteDecl_Internal_Void_XmlWriter_XmlRawWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr, 100664810);
			}

			// Token: 0x06002B64 RID: 11108 RVA: 0x000C396C File Offset: 0x000C1B6C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 395761, RefRangeEnd = 395765, XrefRangeStart = 395761, XrefRangeEnd = 395761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(string prefix, string namespaceUri, XmlWellFormedWriter.NamespaceKind kind)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.Namespace.NativeMethodInfoPtr_Set_Internal_Void_String_String_NamespaceKind_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B65 RID: 11109 RVA: 0x000C39D4 File Offset: 0x000C1BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395765, XrefRangeEnd = 395774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rawWriter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.Namespace.NativeMethodInfoPtr_WriteDecl_Internal_Void_XmlWriter_XmlRawWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B66 RID: 11110 RVA: 0x0001276C File Offset: 0x0001096C
			public Namespace(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002B67 RID: 11111 RVA: 0x00012775 File Offset: 0x00010975
			public Namespace()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr))
			{
			}

			// Token: 0x17000ED3 RID: 3795
			// (get) Token: 0x06002B68 RID: 11112 RVA: 0x000C3A30 File Offset: 0x000C1C30
			// (set) Token: 0x06002B69 RID: 11113 RVA: 0x00012787 File Offset: 0x00010987
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000ED4 RID: 3796
			// (get) Token: 0x06002B6A RID: 11114 RVA: 0x000C3A58 File Offset: 0x000C1C58
			// (set) Token: 0x06002B6B RID: 11115 RVA: 0x000127A6 File Offset: 0x000109A6
			public unsafe string namespaceUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_namespaceUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_namespaceUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000ED5 RID: 3797
			// (get) Token: 0x06002B6C RID: 11116 RVA: 0x000C3A80 File Offset: 0x000C1C80
			// (set) Token: 0x06002B6D RID: 11117 RVA: 0x000127C5 File Offset: 0x000109C5
			public unsafe XmlWellFormedWriter.NamespaceKind kind
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_kind);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_kind)) = value;
				}
			}

			// Token: 0x17000ED6 RID: 3798
			// (get) Token: 0x06002B6E RID: 11118 RVA: 0x000C3AA8 File Offset: 0x000C1CA8
			// (set) Token: 0x06002B6F RID: 11119 RVA: 0x000127E0 File Offset: 0x000109E0
			public unsafe int prevNsIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_prevNsIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_prevNsIndex)) = value;
				}
			}

			// Token: 0x04002197 RID: 8599
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x04002198 RID: 8600
			private static readonly IntPtr NativeFieldInfoPtr_namespaceUri;

			// Token: 0x04002199 RID: 8601
			private static readonly IntPtr NativeFieldInfoPtr_kind;

			// Token: 0x0400219A RID: 8602
			private static readonly IntPtr NativeFieldInfoPtr_prevNsIndex;

			// Token: 0x0400219B RID: 8603
			private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_String_String_NamespaceKind_0;

			// Token: 0x0400219C RID: 8604
			private static readonly IntPtr NativeMethodInfoPtr_WriteDecl_Internal_Void_XmlWriter_XmlRawWriter_0;
		}

		// Token: 0x02000217 RID: 535
		public sealed class AttrName : ValueType
		{
			// Token: 0x06002B70 RID: 11120 RVA: 0x000C3AD0 File Offset: 0x000C1CD0
			// Note: this type is marked as 'beforefieldinit'.
			static AttrName()
			{
				Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "AttrName");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr);
				XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr, "prefix");
				XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_namespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr, "namespaceUri");
				XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr, "localName");
				XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr, "prev");
				XmlWellFormedWriter.AttrName.NativeMethodInfoPtr_Set_Internal_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr, 100664811);
				XmlWellFormedWriter.AttrName.NativeMethodInfoPtr_IsDuplicate_Internal_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr, 100664812);
			}

			// Token: 0x06002B71 RID: 11121 RVA: 0x000C3B74 File Offset: 0x000C1D74
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395774, RefRangeEnd = 395775, XrefRangeStart = 395774, XrefRangeEnd = 395774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(string prefix, string localName, string namespaceUri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttrName.NativeMethodInfoPtr_Set_Internal_Void_String_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B72 RID: 11122 RVA: 0x000C3BE0 File Offset: 0x000C1DE0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395775, RefRangeEnd = 395776, XrefRangeStart = 395775, XrefRangeEnd = 395775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsDuplicate(string prefix, string localName, string namespaceUri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttrName.NativeMethodInfoPtr_IsDuplicate_Internal_Boolean_String_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002B73 RID: 11123 RVA: 0x000127FB File Offset: 0x000109FB
			public AttrName(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002B74 RID: 11124 RVA: 0x00012804 File Offset: 0x00010A04
			public AttrName()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr))
			{
			}

			// Token: 0x17000ED7 RID: 3799
			// (get) Token: 0x06002B75 RID: 11125 RVA: 0x000C3C58 File Offset: 0x000C1E58
			// (set) Token: 0x06002B76 RID: 11126 RVA: 0x00012816 File Offset: 0x00010A16
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000ED8 RID: 3800
			// (get) Token: 0x06002B77 RID: 11127 RVA: 0x000C3C80 File Offset: 0x000C1E80
			// (set) Token: 0x06002B78 RID: 11128 RVA: 0x00012835 File Offset: 0x00010A35
			public unsafe string namespaceUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_namespaceUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_namespaceUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000ED9 RID: 3801
			// (get) Token: 0x06002B79 RID: 11129 RVA: 0x000C3CA8 File Offset: 0x000C1EA8
			// (set) Token: 0x06002B7A RID: 11130 RVA: 0x00012854 File Offset: 0x00010A54
			public unsafe string localName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_localName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EDA RID: 3802
			// (get) Token: 0x06002B7B RID: 11131 RVA: 0x000C3CD0 File Offset: 0x000C1ED0
			// (set) Token: 0x06002B7C RID: 11132 RVA: 0x00012873 File Offset: 0x00010A73
			public unsafe int prev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_prev);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_prev)) = value;
				}
			}

			// Token: 0x0400219D RID: 8605
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x0400219E RID: 8606
			private static readonly IntPtr NativeFieldInfoPtr_namespaceUri;

			// Token: 0x0400219F RID: 8607
			private static readonly IntPtr NativeFieldInfoPtr_localName;

			// Token: 0x040021A0 RID: 8608
			private static readonly IntPtr NativeFieldInfoPtr_prev;

			// Token: 0x040021A1 RID: 8609
			private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_String_String_String_0;

			// Token: 0x040021A2 RID: 8610
			private static readonly IntPtr NativeMethodInfoPtr_IsDuplicate_Internal_Boolean_String_String_String_0;
		}

		// Token: 0x02000218 RID: 536
		[OriginalName("System.Xml.dll", "", "SpecialAttribute")]
		public enum SpecialAttribute
		{
			// Token: 0x040021A4 RID: 8612
			No,
			// Token: 0x040021A5 RID: 8613
			DefaultXmlns,
			// Token: 0x040021A6 RID: 8614
			PrefixedXmlns,
			// Token: 0x040021A7 RID: 8615
			XmlSpace,
			// Token: 0x040021A8 RID: 8616
			XmlLang
		}

		// Token: 0x02000219 RID: 537
		public class AttributeValueCache : Object
		{
			// Token: 0x06002B7D RID: 11133 RVA: 0x000C3CF8 File Offset: 0x000C1EF8
			// Note: this type is marked as 'beforefieldinit'.
			static AttributeValueCache()
			{
				Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "AttributeValueCache");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr);
				XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_stringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, "stringValue");
				XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_singleStringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, "singleStringValue");
				XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, "items");
				XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_firstItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, "firstItem");
				XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_lastItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, "lastItem");
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_get_StringValue_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664813);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteEntityRef_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664814);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteCharEntity_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664815);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteSurrogateCharEntity_Internal_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664816);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteWhitespace_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664817);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteString_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664818);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteChars_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664819);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteRaw_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664820);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteRaw_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664821);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteValue_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664822);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_Replay_Internal_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664823);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_Trim_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664824);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664825);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_StartComplexValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664826);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_AddItem_Private_Void_ItemType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664827);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664828);
			}

			// Token: 0x17000EE0 RID: 3808
			// (get) Token: 0x06002B7E RID: 11134 RVA: 0x000C3EC8 File Offset: 0x000C20C8
			public unsafe string StringValue
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 395776, RefRangeEnd = 395779, XrefRangeStart = 395776, XrefRangeEnd = 395776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_get_StringValue_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002B7F RID: 11135 RVA: 0x000C3F00 File Offset: 0x000C2100
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395802, RefRangeEnd = 395803, XrefRangeStart = 395779, XrefRangeEnd = 395802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteEntityRef(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteEntityRef_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B80 RID: 11136 RVA: 0x000C3F44 File Offset: 0x000C2144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395803, XrefRangeEnd = 395811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteCharEntity(char ch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ch;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteCharEntity_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B81 RID: 11137 RVA: 0x000C3F84 File Offset: 0x000C2184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395811, XrefRangeEnd = 395824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteSurrogateCharEntity(char lowChar, char highChar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lowChar;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highChar;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteSurrogateCharEntity_Internal_Void_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B82 RID: 11138 RVA: 0x000C3FD0 File Offset: 0x000C21D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395824, XrefRangeEnd = 395829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteWhitespace(string ws)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(ws);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteWhitespace_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B83 RID: 11139 RVA: 0x000C4014 File Offset: 0x000C2214
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395829, XrefRangeEnd = 395835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteString(string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteString_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B84 RID: 11140 RVA: 0x000C4058 File Offset: 0x000C2258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395835, XrefRangeEnd = 395843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteChars(Il2CppStructArray<char> buffer, int index, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteChars_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B85 RID: 11141 RVA: 0x000C40B8 File Offset: 0x000C22B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395843, XrefRangeEnd = 395851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteRaw(Il2CppStructArray<char> buffer, int index, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteRaw_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B86 RID: 11142 RVA: 0x000C4118 File Offset: 0x000C2318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395851, XrefRangeEnd = 395856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteRaw(string data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteRaw_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B87 RID: 11143 RVA: 0x000C415C File Offset: 0x000C235C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 395861, RefRangeEnd = 395863, XrefRangeStart = 395856, XrefRangeEnd = 395861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteValue(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteValue_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B88 RID: 11144 RVA: 0x000C41A0 File Offset: 0x000C23A0
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 395886, RefRangeEnd = 395892, XrefRangeStart = 395863, XrefRangeEnd = 395886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Replay(XmlWriter writer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_Replay_Internal_Void_XmlWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B89 RID: 11145 RVA: 0x000C41E4 File Offset: 0x000C23E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395941, RefRangeEnd = 395942, XrefRangeStart = 395892, XrefRangeEnd = 395941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Trim()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_Trim_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B8A RID: 11146 RVA: 0x000C4218 File Offset: 0x000C2418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395942, XrefRangeEnd = 395944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B8B RID: 11147 RVA: 0x000C424C File Offset: 0x000C244C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395944, XrefRangeEnd = 395946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void StartComplexValue()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_StartComplexValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B8C RID: 11148 RVA: 0x000C4280 File Offset: 0x000C2480
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 395960, RefRangeEnd = 395993, XrefRangeStart = 395946, XrefRangeEnd = 395960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType type, Object data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_AddItem_Private_Void_ItemType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B8D RID: 11149 RVA: 0x000C42D0 File Offset: 0x000C24D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395993, XrefRangeEnd = 396000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttributeValueCache()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B8E RID: 11150 RVA: 0x0001288E File Offset: 0x00010A8E
			public AttributeValueCache(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EDB RID: 3803
			// (get) Token: 0x06002B8F RID: 11151 RVA: 0x000C430C File Offset: 0x000C250C
			// (set) Token: 0x06002B90 RID: 11152 RVA: 0x00012897 File Offset: 0x00010A97
			public unsafe StringBuilder stringValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_stringValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_stringValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EDC RID: 3804
			// (get) Token: 0x06002B91 RID: 11153 RVA: 0x000C433C File Offset: 0x000C253C
			// (set) Token: 0x06002B92 RID: 11154 RVA: 0x000128B6 File Offset: 0x00010AB6
			public unsafe string singleStringValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_singleStringValue);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_singleStringValue), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EDD RID: 3805
			// (get) Token: 0x06002B93 RID: 11155 RVA: 0x000C4364 File Offset: 0x000C2564
			// (set) Token: 0x06002B94 RID: 11156 RVA: 0x000128D5 File Offset: 0x00010AD5
			public unsafe Il2CppReferenceArray<XmlWellFormedWriter.AttributeValueCache.Item> items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlWellFormedWriter.AttributeValueCache.Item>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EDE RID: 3806
			// (get) Token: 0x06002B95 RID: 11157 RVA: 0x000C4394 File Offset: 0x000C2594
			// (set) Token: 0x06002B96 RID: 11158 RVA: 0x000128F4 File Offset: 0x00010AF4
			public unsafe int firstItem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_firstItem);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_firstItem)) = value;
				}
			}

			// Token: 0x17000EDF RID: 3807
			// (get) Token: 0x06002B97 RID: 11159 RVA: 0x000C43BC File Offset: 0x000C25BC
			// (set) Token: 0x06002B98 RID: 11160 RVA: 0x0001290F File Offset: 0x00010B0F
			public unsafe int lastItem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_lastItem);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_lastItem)) = value;
				}
			}

			// Token: 0x040021A9 RID: 8617
			private static readonly IntPtr NativeFieldInfoPtr_stringValue;

			// Token: 0x040021AA RID: 8618
			private static readonly IntPtr NativeFieldInfoPtr_singleStringValue;

			// Token: 0x040021AB RID: 8619
			private static readonly IntPtr NativeFieldInfoPtr_items;

			// Token: 0x040021AC RID: 8620
			private static readonly IntPtr NativeFieldInfoPtr_firstItem;

			// Token: 0x040021AD RID: 8621
			private static readonly IntPtr NativeFieldInfoPtr_lastItem;

			// Token: 0x040021AE RID: 8622
			private static readonly IntPtr NativeMethodInfoPtr_get_StringValue_Internal_get_String_0;

			// Token: 0x040021AF RID: 8623
			private static readonly IntPtr NativeMethodInfoPtr_WriteEntityRef_Internal_Void_String_0;

			// Token: 0x040021B0 RID: 8624
			private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntity_Internal_Void_Char_0;

			// Token: 0x040021B1 RID: 8625
			private static readonly IntPtr NativeMethodInfoPtr_WriteSurrogateCharEntity_Internal_Void_Char_Char_0;

			// Token: 0x040021B2 RID: 8626
			private static readonly IntPtr NativeMethodInfoPtr_WriteWhitespace_Internal_Void_String_0;

			// Token: 0x040021B3 RID: 8627
			private static readonly IntPtr NativeMethodInfoPtr_WriteString_Internal_Void_String_0;

			// Token: 0x040021B4 RID: 8628
			private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x040021B5 RID: 8629
			private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x040021B6 RID: 8630
			private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Internal_Void_String_0;

			// Token: 0x040021B7 RID: 8631
			private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Internal_Void_String_0;

			// Token: 0x040021B8 RID: 8632
			private static readonly IntPtr NativeMethodInfoPtr_Replay_Internal_Void_XmlWriter_0;

			// Token: 0x040021B9 RID: 8633
			private static readonly IntPtr NativeMethodInfoPtr_Trim_Internal_Void_0;

			// Token: 0x040021BA RID: 8634
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

			// Token: 0x040021BB RID: 8635
			private static readonly IntPtr NativeMethodInfoPtr_StartComplexValue_Private_Void_0;

			// Token: 0x040021BC RID: 8636
			private static readonly IntPtr NativeMethodInfoPtr_AddItem_Private_Void_ItemType_Object_0;

			// Token: 0x040021BD RID: 8637
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200026B RID: 619
			[OriginalName("System.Xml.dll", "", "ItemType")]
			public enum ItemType
			{
				// Token: 0x04002447 RID: 9287
				EntityRef,
				// Token: 0x04002448 RID: 9288
				CharEntity,
				// Token: 0x04002449 RID: 9289
				SurrogateCharEntity,
				// Token: 0x0400244A RID: 9290
				Whitespace,
				// Token: 0x0400244B RID: 9291
				String,
				// Token: 0x0400244C RID: 9292
				StringChars,
				// Token: 0x0400244D RID: 9293
				Raw,
				// Token: 0x0400244E RID: 9294
				RawChars,
				// Token: 0x0400244F RID: 9295
				ValueString
			}

			// Token: 0x0200026C RID: 620
			public class Item : Object
			{
				// Token: 0x06002DFD RID: 11773 RVA: 0x000CAB0C File Offset: 0x000C8D0C
				// Note: this type is marked as 'beforefieldinit'.
				static Item()
				{
					Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.Item>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, "Item");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.Item>.NativeClassPtr);
					XmlWellFormedWriter.AttributeValueCache.Item.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.Item>.NativeClassPtr, "type");
					XmlWellFormedWriter.AttributeValueCache.Item.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.Item>.NativeClassPtr, "data");
					XmlWellFormedWriter.AttributeValueCache.Item.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.Item>.NativeClassPtr, 100664829);
					XmlWellFormedWriter.AttributeValueCache.Item.NativeMethodInfoPtr_Set_Internal_Void_ItemType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.Item>.NativeClassPtr, 100664830);
				}

				// Token: 0x06002DFE RID: 11774 RVA: 0x000CAB88 File Offset: 0x000C8D88
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Item()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.Item>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.Item.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002DFF RID: 11775 RVA: 0x000CABC4 File Offset: 0x000C8DC4
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 106068, RefRangeEnd = 106070, XrefRangeStart = 106068, XrefRangeEnd = 106070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Set(XmlWellFormedWriter.AttributeValueCache.ItemType type, Object data)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref type;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.Item.NativeMethodInfoPtr_Set_Internal_Void_ItemType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002E00 RID: 11776 RVA: 0x0001416D File Offset: 0x0001236D
				public Item(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000F8F RID: 3983
				// (get) Token: 0x06002E01 RID: 11777 RVA: 0x000CAC14 File Offset: 0x000C8E14
				// (set) Token: 0x06002E02 RID: 11778 RVA: 0x00014176 File Offset: 0x00012376
				public unsafe XmlWellFormedWriter.AttributeValueCache.ItemType type
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.Item.NativeFieldInfoPtr_type);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.Item.NativeFieldInfoPtr_type)) = value;
					}
				}

				// Token: 0x17000F90 RID: 3984
				// (get) Token: 0x06002E03 RID: 11779 RVA: 0x000CAC3C File Offset: 0x000C8E3C
				// (set) Token: 0x06002E04 RID: 11780 RVA: 0x00014191 File Offset: 0x00012391
				public unsafe Object data
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.Item.NativeFieldInfoPtr_data);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.Item.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04002450 RID: 9296
				private static readonly IntPtr NativeFieldInfoPtr_type;

				// Token: 0x04002451 RID: 9297
				private static readonly IntPtr NativeFieldInfoPtr_data;

				// Token: 0x04002452 RID: 9298
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

				// Token: 0x04002453 RID: 9299
				private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_ItemType_Object_0;
			}

			// Token: 0x0200026D RID: 621
			public class BufferChunk : Object
			{
				// Token: 0x06002E05 RID: 11781 RVA: 0x000CAC6C File Offset: 0x000C8E6C
				// Note: this type is marked as 'beforefieldinit'.
				static BufferChunk()
				{
					Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.BufferChunk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, "BufferChunk");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.BufferChunk>.NativeClassPtr);
					XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.BufferChunk>.NativeClassPtr, "buffer");
					XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.BufferChunk>.NativeClassPtr, "index");
					XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.BufferChunk>.NativeClassPtr, "count");
					XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.BufferChunk>.NativeClassPtr, 100664831);
				}

				// Token: 0x06002E06 RID: 11782 RVA: 0x000CACE8 File Offset: 0x000C8EE8
				[CallerCount(0)]
				public unsafe BufferChunk(Il2CppStructArray<char> buffer, int index, int count)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.BufferChunk>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002E07 RID: 11783 RVA: 0x000141B0 File Offset: 0x000123B0
				public BufferChunk(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000F91 RID: 3985
				// (get) Token: 0x06002E08 RID: 11784 RVA: 0x000CAD50 File Offset: 0x000C8F50
				// (set) Token: 0x06002E09 RID: 11785 RVA: 0x000141B9 File Offset: 0x000123B9
				public unsafe Il2CppStructArray<char> buffer
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_buffer);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000F92 RID: 3986
				// (get) Token: 0x06002E0A RID: 11786 RVA: 0x000CAD80 File Offset: 0x000C8F80
				// (set) Token: 0x06002E0B RID: 11787 RVA: 0x000141D8 File Offset: 0x000123D8
				public unsafe int index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_index)) = value;
					}
				}

				// Token: 0x17000F93 RID: 3987
				// (get) Token: 0x06002E0C RID: 11788 RVA: 0x000CADA8 File Offset: 0x000C8FA8
				// (set) Token: 0x06002E0D RID: 11789 RVA: 0x000141F3 File Offset: 0x000123F3
				public unsafe int count
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_count);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_count)) = value;
					}
				}

				// Token: 0x04002454 RID: 9300
				private static readonly IntPtr NativeFieldInfoPtr_buffer;

				// Token: 0x04002455 RID: 9301
				private static readonly IntPtr NativeFieldInfoPtr_index;

				// Token: 0x04002456 RID: 9302
				private static readonly IntPtr NativeFieldInfoPtr_count;

				// Token: 0x04002457 RID: 9303
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;
			}
		}
	}
}
