using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200004D RID: 77
	public class XmlEncodedRawTextWriter : XmlRawWriter
	{
		// Token: 0x06000439 RID: 1081 RVA: 0x00025A68 File Offset: 0x00023C68
		// Note: this type is marked as 'beforefieldinit'.
		static XmlEncodedRawTextWriter()
		{
			Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlEncodedRawTextWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr);
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_useAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "useAsync");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "bufBytes");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "stream");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "encoding");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "xmlCharType");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "bufPos");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_textPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "textPos");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_contentPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "contentPos");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_cdataPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "cdataPos");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_attrEndPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "attrEndPos");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "bufLen");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_writeToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "writeToNull");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_hadDoubleBracket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "hadDoubleBracket");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_inAttributeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "inAttributeValue");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufBytesUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "bufBytesUsed");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "bufChars");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_encoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "encoder");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "writer");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_trackTextContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "trackTextContent");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_inTextContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "inTextContent");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_lastMarkPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "lastMarkPos");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_textContentMarks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "textContentMarks");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_charEntityFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "charEntityFallback");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_newLineHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "newLineHandling");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_closeOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "closeOutput");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_omitXmlDeclaration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "omitXmlDeclaration");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_newLineChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "newLineChars");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_checkCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "checkCharacters");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_standalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "standalone");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_outputMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "outputMethod");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_autoXmlDeclaration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "autoXmlDeclaration");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_mergeCDataSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "mergeCDataSections");
			XmlEncodedRawTextWriter.NativeMethodInfoPtr__ctor_Protected_Void_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663896);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr__ctor_Public_Void_TextWriter_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663897);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663898);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_XmlStandalone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663899);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663900);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663901);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663902);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663903);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663904);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteFullEndElement_Internal_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663905);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663906);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663907);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteNamespaceDeclaration_Internal_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663908);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_get_SupportsNamespaceDeclarationInChunks_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663909);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteStartNamespaceDeclaration_Internal_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663910);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteEndNamespaceDeclaration_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663911);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663912);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663913);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663914);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663915);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663916);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663917);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663918);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663919);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663920);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663921);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663922);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663923);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663924);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_FlushBuffer_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663925);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_EncodeChars_Private_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663926);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_FlushEncoder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663927);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteAttributeTextBlock_Protected_Void_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663928);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteElementTextBlock_Protected_Void_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663929);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_RawText_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663930);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_RawText_Protected_Void_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663931);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteRawWithCharChecking_Protected_Void_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663932);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteCommentOrPi_Protected_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663933);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteCDataSection_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663934);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_EncodeSurrogate_Private_Static_ptr_Char_ptr_Char_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663935);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_InvalidXmlChar_Private_ptr_Char_Int32_ptr_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663936);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_EncodeChar_Internal_Void_byref_ptr_Char_ptr_Char_byref_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663937);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_ChangeTextContentMark_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663938);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_GrowTextContentMarks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663939);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteNewLine_Protected_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663940);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_LtEntity_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663941);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_GtEntity_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663942);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_AmpEntity_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663943);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_QuoteEntity_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663944);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_TabEntity_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663945);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_LineFeedEntity_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663946);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_CarriageReturnEntity_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663947);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_CharEntity_Private_Static_ptr_Char_ptr_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663948);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_RawStartCData_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663949);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_RawEndCData_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663950);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_ValidateContentChars_Protected_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663951);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00026178 File Offset: 0x00024378
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 390754, RefRangeEnd = 390756, XrefRangeStart = 390750, XrefRangeEnd = 390754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlEncodedRawTextWriter(XmlWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr__ctor_Protected_Void_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000261C4 File Offset: 0x000243C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 390761, RefRangeEnd = 390765, XrefRangeStart = 390756, XrefRangeEnd = 390761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr__ctor_Public_Void_TextWriter_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00026224 File Offset: 0x00024424
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 390782, RefRangeEnd = 390791, XrefRangeStart = 390765, XrefRangeEnd = 390782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlEncodedRawTextWriter(Stream stream, XmlWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00026284 File Offset: 0x00024484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390791, XrefRangeEnd = 390813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref standalone;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_XmlStandalone_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000262D0 File Offset: 0x000244D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390813, XrefRangeEnd = 390815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteXmlDeclaration(string xmldecl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmldecl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00026320 File Offset: 0x00024520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390835, RefRangeEnd = 390836, XrefRangeStart = 390815, XrefRangeEnd = 390835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000263A4 File Offset: 0x000245A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390839, RefRangeEnd = 390840, XrefRangeStart = 390836, XrefRangeEnd = 390839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00026418 File Offset: 0x00024618
		[CallerCount(0)]
		public unsafe override void StartElementContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00026454 File Offset: 0x00024654
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 390844, RefRangeEnd = 390846, XrefRangeStart = 390840, XrefRangeEnd = 390844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndElement(string prefix, string localName, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000264C8 File Offset: 0x000246C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 390849, RefRangeEnd = 390851, XrefRangeStart = 390846, XrefRangeEnd = 390849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteFullEndElement(string prefix, string localName, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteFullEndElement_Internal_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0002653C File Offset: 0x0002473C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 390854, RefRangeEnd = 390856, XrefRangeStart = 390851, XrefRangeEnd = 390854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartAttribute(string prefix, string localName, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000265B0 File Offset: 0x000247B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390856, XrefRangeEnd = 390857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000265EC File Offset: 0x000247EC
		[CallerCount(0)]
		public unsafe override void WriteNamespaceDeclaration(string prefix, string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteNamespaceDeclaration_Internal_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0002664C File Offset: 0x0002484C
		public unsafe override bool SupportsNamespaceDeclarationInChunks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_get_SupportsNamespaceDeclarationInChunks_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00026694 File Offset: 0x00024894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390857, XrefRangeEnd = 390867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartNamespaceDeclaration(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteStartNamespaceDeclaration_Internal_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000266E4 File Offset: 0x000248E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390867, XrefRangeEnd = 390868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndNamespaceDeclaration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteEndNamespaceDeclaration_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00026720 File Offset: 0x00024920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390871, RefRangeEnd = 390872, XrefRangeStart = 390868, XrefRangeEnd = 390871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCData(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00026770 File Offset: 0x00024970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390874, RefRangeEnd = 390875, XrefRangeStart = 390872, XrefRangeEnd = 390874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteComment(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000267C0 File Offset: 0x000249C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390878, RefRangeEnd = 390879, XrefRangeStart = 390875, XrefRangeEnd = 390878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00026820 File Offset: 0x00024A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390879, XrefRangeEnd = 390881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEntityRef(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00026870 File Offset: 0x00024A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390888, RefRangeEnd = 390889, XrefRangeStart = 390881, XrefRangeEnd = 390888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCharEntity(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000268BC File Offset: 0x00024ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390889, XrefRangeEnd = 390893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteWhitespace(string ws)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ws);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0002690C File Offset: 0x00024B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390893, XrefRangeEnd = 390897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteString(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0002695C File Offset: 0x00024B5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390904, RefRangeEnd = 390905, XrefRangeStart = 390897, XrefRangeEnd = 390904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000269B4 File Offset: 0x00024BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00026A20 File Offset: 0x00024C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390905, XrefRangeEnd = 390907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00026A8C File Offset: 0x00024C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteRaw(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00026ADC File Offset: 0x00024CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390907, XrefRangeEnd = 390911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00026B18 File Offset: 0x00024D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390911, XrefRangeEnd = 390912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00026B54 File Offset: 0x00024D54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390917, RefRangeEnd = 390918, XrefRangeStart = 390912, XrefRangeEnd = 390917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FlushBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_FlushBuffer_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00026B90 File Offset: 0x00024D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390918, XrefRangeEnd = 390919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EncodeChars(int startOffset, int endOffset, bool writeAllToStream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeAllToStream;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_EncodeChars_Private_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00026BEC File Offset: 0x00024DEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 390919, RefRangeEnd = 390921, XrefRangeStart = 390919, XrefRangeEnd = 390919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushEncoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_FlushEncoder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00026C20 File Offset: 0x00024E20
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 390937, RefRangeEnd = 390942, XrefRangeStart = 390921, XrefRangeEnd = 390937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pSrc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pSrcEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteAttributeTextBlock_Protected_Void_ptr_Char_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00026C6C File Offset: 0x00024E6C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 390956, RefRangeEnd = 390964, XrefRangeStart = 390942, XrefRangeEnd = 390956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteElementTextBlock(char* pSrc, char* pSrcEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pSrc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pSrcEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteElementTextBlock_Protected_Void_ptr_Char_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00026CB8 File Offset: 0x00024EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390964, XrefRangeEnd = 390966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RawText(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_RawText_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00026CFC File Offset: 0x00024EFC
		[CallerCount(67)]
		[CachedScanResults(RefRangeStart = 390971, RefRangeEnd = 391038, XrefRangeStart = 390966, XrefRangeEnd = 390971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RawText(char* pSrcBegin, char* pSrcEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pSrcBegin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pSrcEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_RawText_Protected_Void_ptr_Char_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00026D48 File Offset: 0x00024F48
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 391049, RefRangeEnd = 391059, XrefRangeStart = 391038, XrefRangeEnd = 391049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pSrcBegin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pSrcEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteRawWithCharChecking_Protected_Void_ptr_Char_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00026D94 File Offset: 0x00024F94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 391072, RefRangeEnd = 391075, XrefRangeStart = 391059, XrefRangeEnd = 391072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteCommentOrPi(string text, int stopChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteCommentOrPi_Protected_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00026DE4 File Offset: 0x00024FE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 391087, RefRangeEnd = 391088, XrefRangeStart = 391075, XrefRangeEnd = 391087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteCDataSection(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteCDataSection_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00026E28 File Offset: 0x00025028
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 391090, RefRangeEnd = 391097, XrefRangeStart = 391088, XrefRangeEnd = 391090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pSrc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pSrcEnd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pDst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_EncodeSurrogate_Private_Static_ptr_Char_ptr_Char_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00026E74 File Offset: 0x00025074
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 391097, RefRangeEnd = 391099, XrefRangeStart = 391097, XrefRangeEnd = 391097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char* InvalidXmlChar(int ch, char* pDst, bool entitize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pDst;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entitize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_InvalidXmlChar_Private_ptr_Char_Int32_ptr_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00026ED0 File Offset: 0x000250D0
		[CallerCount(0)]
		public unsafe void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(pSrc);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pSrcEnd;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(pDst);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_EncodeChar_Internal_Void_byref_ptr_Char_ptr_Char_byref_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			pSrc = ((intPtr5 == 0) ? null : new char*(intPtr5));
			IntPtr intPtr6 = intPtr2;
			pDst = ((intPtr6 == 0) ? null : new char*(intPtr6));
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00026F60 File Offset: 0x00025160
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 391100, RefRangeEnd = 391143, XrefRangeStart = 391099, XrefRangeEnd = 391100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeTextContentMark(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_ChangeTextContentMark_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00026FA0 File Offset: 0x000251A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 391149, RefRangeEnd = 391151, XrefRangeStart = 391143, XrefRangeEnd = 391149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrowTextContentMarks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_GrowTextContentMarks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00026FD4 File Offset: 0x000251D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391151, XrefRangeEnd = 391153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char* WriteNewLine(char* pDst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteNewLine_Protected_ptr_Char_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00027014 File Offset: 0x00025214
		[CallerCount(0)]
		public unsafe static char* LtEntity(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_LtEntity_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00027048 File Offset: 0x00025248
		[CallerCount(0)]
		public unsafe static char* GtEntity(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_GtEntity_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0002707C File Offset: 0x0002527C
		[CallerCount(0)]
		public unsafe static char* AmpEntity(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_AmpEntity_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x000270B0 File Offset: 0x000252B0
		[CallerCount(0)]
		public unsafe static char* QuoteEntity(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_QuoteEntity_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000270E4 File Offset: 0x000252E4
		[CallerCount(0)]
		public unsafe static char* TabEntity(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_TabEntity_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00027118 File Offset: 0x00025318
		[CallerCount(0)]
		public unsafe static char* LineFeedEntity(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_LineFeedEntity_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0002714C File Offset: 0x0002534C
		[CallerCount(0)]
		public unsafe static char* CarriageReturnEntity(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_CarriageReturnEntity_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00027180 File Offset: 0x00025380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391153, XrefRangeEnd = 391158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char* CharEntity(char* pDst, char ch)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_CharEntity_Private_Static_ptr_Char_ptr_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000271C0 File Offset: 0x000253C0
		[CallerCount(0)]
		public unsafe static char* RawStartCData(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_RawStartCData_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000271F4 File Offset: 0x000253F4
		[CallerCount(0)]
		public unsafe static char* RawEndCData(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_RawEndCData_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00027228 File Offset: 0x00025428
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 391183, RefRangeEnd = 391187, XrefRangeStart = 391158, XrefRangeEnd = 391183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowOnlyWhitespace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_ValidateContentChars_Protected_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00003686 File Offset: 0x00001886
		public XmlEncodedRawTextWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0002728C File Offset: 0x0002548C
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x0000368F File Offset: 0x0000188F
		public unsafe bool useAsync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_useAsync);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_useAsync)) = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x000272B4 File Offset: 0x000254B4
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x000036AA File Offset: 0x000018AA
		public unsafe Il2CppStructArray<byte> bufBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x000272E4 File Offset: 0x000254E4
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x000036C9 File Offset: 0x000018C9
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00027314 File Offset: 0x00025514
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x000036E8 File Offset: 0x000018E8
		public unsafe Encoding encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00027344 File Offset: 0x00025544
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00003707 File Offset: 0x00001907
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00027374 File Offset: 0x00025574
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00003735 File Offset: 0x00001935
		public unsafe int bufPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufPos)) = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x0002739C File Offset: 0x0002559C
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00003750 File Offset: 0x00001950
		public unsafe int textPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_textPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_textPos)) = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x000273C4 File Offset: 0x000255C4
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x0000376B File Offset: 0x0000196B
		public unsafe int contentPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_contentPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_contentPos)) = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x000273EC File Offset: 0x000255EC
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x00003786 File Offset: 0x00001986
		public unsafe int cdataPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_cdataPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_cdataPos)) = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00027414 File Offset: 0x00025614
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x000037A1 File Offset: 0x000019A1
		public unsafe int attrEndPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_attrEndPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_attrEndPos)) = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0002743C File Offset: 0x0002563C
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x000037BC File Offset: 0x000019BC
		public unsafe int bufLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufLen)) = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00027464 File Offset: 0x00025664
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x000037D7 File Offset: 0x000019D7
		public unsafe bool writeToNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_writeToNull);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_writeToNull)) = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x0002748C File Offset: 0x0002568C
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x000037F2 File Offset: 0x000019F2
		public unsafe bool hadDoubleBracket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_hadDoubleBracket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_hadDoubleBracket)) = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x000274B4 File Offset: 0x000256B4
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x0000380D File Offset: 0x00001A0D
		public unsafe bool inAttributeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_inAttributeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_inAttributeValue)) = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x000274DC File Offset: 0x000256DC
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00003828 File Offset: 0x00001A28
		public unsafe int bufBytesUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufBytesUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufBytesUsed)) = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00027504 File Offset: 0x00025704
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00003843 File Offset: 0x00001A43
		public unsafe Il2CppStructArray<char> bufChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufChars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufChars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00027534 File Offset: 0x00025734
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00003862 File Offset: 0x00001A62
		public unsafe Encoder encoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_encoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_encoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00027564 File Offset: 0x00025764
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00003881 File Offset: 0x00001A81
		public unsafe TextWriter writer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_writer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_writer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00027594 File Offset: 0x00025794
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x000038A0 File Offset: 0x00001AA0
		public unsafe bool trackTextContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_trackTextContent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_trackTextContent)) = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x000275BC File Offset: 0x000257BC
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x000038BB File Offset: 0x00001ABB
		public unsafe bool inTextContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_inTextContent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_inTextContent)) = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x000275E4 File Offset: 0x000257E4
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x000038D6 File Offset: 0x00001AD6
		public unsafe int lastMarkPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_lastMarkPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_lastMarkPos)) = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0002760C File Offset: 0x0002580C
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x000038F1 File Offset: 0x00001AF1
		public unsafe Il2CppStructArray<int> textContentMarks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_textContentMarks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_textContentMarks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0002763C File Offset: 0x0002583C
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00003910 File Offset: 0x00001B10
		public unsafe CharEntityEncoderFallback charEntityFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_charEntityFallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharEntityEncoderFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_charEntityFallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0002766C File Offset: 0x0002586C
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x0000392F File Offset: 0x00001B2F
		public unsafe NewLineHandling newLineHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_newLineHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_newLineHandling)) = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00027694 File Offset: 0x00025894
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x0000394A File Offset: 0x00001B4A
		public unsafe bool closeOutput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_closeOutput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_closeOutput)) = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x000276BC File Offset: 0x000258BC
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00003965 File Offset: 0x00001B65
		public unsafe bool omitXmlDeclaration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_omitXmlDeclaration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_omitXmlDeclaration)) = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x000276E4 File Offset: 0x000258E4
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00003980 File Offset: 0x00001B80
		public unsafe string newLineChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_newLineChars);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_newLineChars), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0002770C File Offset: 0x0002590C
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x0000399F File Offset: 0x00001B9F
		public unsafe bool checkCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_checkCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_checkCharacters)) = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00027734 File Offset: 0x00025934
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x000039BA File Offset: 0x00001BBA
		public unsafe XmlStandalone standalone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_standalone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_standalone)) = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0002775C File Offset: 0x0002595C
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x000039D5 File Offset: 0x00001BD5
		public unsafe XmlOutputMethod outputMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_outputMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_outputMethod)) = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00027784 File Offset: 0x00025984
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x000039F0 File Offset: 0x00001BF0
		public unsafe bool autoXmlDeclaration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_autoXmlDeclaration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_autoXmlDeclaration)) = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x000277AC File Offset: 0x000259AC
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00003A0B File Offset: 0x00001C0B
		public unsafe bool mergeCDataSections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_mergeCDataSections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_mergeCDataSections)) = value;
			}
		}

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeFieldInfoPtr_useAsync;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeFieldInfoPtr_bufBytes;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeFieldInfoPtr_bufPos;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeFieldInfoPtr_textPos;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeFieldInfoPtr_contentPos;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeFieldInfoPtr_cdataPos;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeFieldInfoPtr_attrEndPos;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeFieldInfoPtr_bufLen;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeFieldInfoPtr_writeToNull;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeFieldInfoPtr_hadDoubleBracket;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeFieldInfoPtr_inAttributeValue;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeFieldInfoPtr_bufBytesUsed;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeFieldInfoPtr_bufChars;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeFieldInfoPtr_encoder;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeFieldInfoPtr_writer;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeFieldInfoPtr_trackTextContent;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeFieldInfoPtr_inTextContent;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeFieldInfoPtr_lastMarkPos;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeFieldInfoPtr_textContentMarks;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeFieldInfoPtr_charEntityFallback;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeFieldInfoPtr_newLineHandling;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeFieldInfoPtr_closeOutput;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeFieldInfoPtr_omitXmlDeclaration;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeFieldInfoPtr_newLineChars;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeFieldInfoPtr_checkCharacters;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeFieldInfoPtr_standalone;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeFieldInfoPtr_outputMethod;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeFieldInfoPtr_autoXmlDeclaration;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeFieldInfoPtr_mergeCDataSections;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlWriterSettings_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextWriter_XmlWriterSettings_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_XmlStandalone_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_String_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_WriteFullEndElement_Internal_Virtual_Void_String_String_String_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_WriteNamespaceDeclaration_Internal_Virtual_Void_String_String_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsNamespaceDeclarationInChunks_Internal_Virtual_get_Boolean_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartNamespaceDeclaration_Internal_Virtual_Void_String_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndNamespaceDeclaration_Internal_Virtual_Void_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_FlushBuffer_Protected_Virtual_New_Void_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_EncodeChars_Private_Void_Int32_Int32_Boolean_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_FlushEncoder_Private_Void_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_WriteAttributeTextBlock_Protected_Void_ptr_Char_ptr_Char_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_WriteElementTextBlock_Protected_Void_ptr_Char_ptr_Char_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_RawText_Protected_Void_String_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_RawText_Protected_Void_ptr_Char_ptr_Char_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_WriteRawWithCharChecking_Protected_Void_ptr_Char_ptr_Char_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_WriteCommentOrPi_Protected_Void_String_Int32_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_WriteCDataSection_Protected_Void_String_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_EncodeSurrogate_Private_Static_ptr_Char_ptr_Char_ptr_Char_ptr_Char_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_InvalidXmlChar_Private_ptr_Char_Int32_ptr_Char_Boolean_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_EncodeChar_Internal_Void_byref_ptr_Char_ptr_Char_byref_ptr_Char_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTextContentMark_Protected_Void_Boolean_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_GrowTextContentMarks_Private_Void_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_WriteNewLine_Protected_ptr_Char_ptr_Char_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_LtEntity_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_GtEntity_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_AmpEntity_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_QuoteEntity_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_TabEntity_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_LineFeedEntity_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_CarriageReturnEntity_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_CharEntity_Private_Static_ptr_Char_ptr_Char_Char_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_RawStartCData_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_RawEndCData_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_ValidateContentChars_Protected_Void_String_String_Boolean_0;
	}
}
