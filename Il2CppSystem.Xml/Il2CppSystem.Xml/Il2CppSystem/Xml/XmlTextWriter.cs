using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000059 RID: 89
	public class XmlTextWriter : XmlWriter
	{
		// Token: 0x060007CD RID: 1997 RVA: 0x000358BC File Offset: 0x00033ABC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTextWriter()
		{
			Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlTextWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr);
			XmlTextWriter.NativeFieldInfoPtr_textWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "textWriter");
			XmlTextWriter.NativeFieldInfoPtr_xmlEncoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "xmlEncoder");
			XmlTextWriter.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "encoding");
			XmlTextWriter.NativeFieldInfoPtr_formatting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "formatting");
			XmlTextWriter.NativeFieldInfoPtr_indented = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "indented");
			XmlTextWriter.NativeFieldInfoPtr_indentation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "indentation");
			XmlTextWriter.NativeFieldInfoPtr_indentChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "indentChar");
			XmlTextWriter.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "stack");
			XmlTextWriter.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "top");
			XmlTextWriter.NativeFieldInfoPtr_stateTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "stateTable");
			XmlTextWriter.NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "currentState");
			XmlTextWriter.NativeFieldInfoPtr_lastToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "lastToken");
			XmlTextWriter.NativeFieldInfoPtr_base64Encoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "base64Encoder");
			XmlTextWriter.NativeFieldInfoPtr_quoteChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "quoteChar");
			XmlTextWriter.NativeFieldInfoPtr_curQuoteChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "curQuoteChar");
			XmlTextWriter.NativeFieldInfoPtr_namespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "namespaces");
			XmlTextWriter.NativeFieldInfoPtr_specialAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "specialAttr");
			XmlTextWriter.NativeFieldInfoPtr_prefixForXmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "prefixForXmlNs");
			XmlTextWriter.NativeFieldInfoPtr_flush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "flush");
			XmlTextWriter.NativeFieldInfoPtr_nsStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "nsStack");
			XmlTextWriter.NativeFieldInfoPtr_nsTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "nsTop");
			XmlTextWriter.NativeFieldInfoPtr_nsHashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "nsHashtable");
			XmlTextWriter.NativeFieldInfoPtr_useNsHashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "useNsHashtable");
			XmlTextWriter.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "xmlCharType");
			XmlTextWriter.NativeFieldInfoPtr_stateName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "stateName");
			XmlTextWriter.NativeFieldInfoPtr_tokenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "tokenName");
			XmlTextWriter.NativeFieldInfoPtr_stateTableDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "stateTableDefault");
			XmlTextWriter.NativeFieldInfoPtr_stateTableDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "stateTableDocument");
			XmlTextWriter.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664557);
			XmlTextWriter.NativeMethodInfoPtr__ctor_Public_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664558);
			XmlTextWriter.NativeMethodInfoPtr_set_Formatting_Public_set_Void_Formatting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664559);
			XmlTextWriter.NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664560);
			XmlTextWriter.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664561);
			XmlTextWriter.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664562);
			XmlTextWriter.NativeMethodInfoPtr_WriteEndElement_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664563);
			XmlTextWriter.NativeMethodInfoPtr_WriteFullEndElement_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664564);
			XmlTextWriter.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664565);
			XmlTextWriter.NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664566);
			XmlTextWriter.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664567);
			XmlTextWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664568);
			XmlTextWriter.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664569);
			XmlTextWriter.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664570);
			XmlTextWriter.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664571);
			XmlTextWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664572);
			XmlTextWriter.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664573);
			XmlTextWriter.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664574);
			XmlTextWriter.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664575);
			XmlTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664576);
			XmlTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664577);
			XmlTextWriter.NativeMethodInfoPtr_WriteBase64_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664578);
			XmlTextWriter.NativeMethodInfoPtr_WriteBinHex_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664579);
			XmlTextWriter.NativeMethodInfoPtr_get_WriteState_Public_Virtual_get_WriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664580);
			XmlTextWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664581);
			XmlTextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664582);
			XmlTextWriter.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664583);
			XmlTextWriter.NativeMethodInfoPtr_StartDocument_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664584);
			XmlTextWriter.NativeMethodInfoPtr_AutoComplete_Private_Void_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664585);
			XmlTextWriter.NativeMethodInfoPtr_AutoCompleteAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664586);
			XmlTextWriter.NativeMethodInfoPtr_InternalWriteEndElement_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664587);
			XmlTextWriter.NativeMethodInfoPtr_WriteEndStartTag_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664588);
			XmlTextWriter.NativeMethodInfoPtr_WriteEndAttributeQuote_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664589);
			XmlTextWriter.NativeMethodInfoPtr_Indent_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664590);
			XmlTextWriter.NativeMethodInfoPtr_PushNamespace_Private_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664591);
			XmlTextWriter.NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664592);
			XmlTextWriter.NativeMethodInfoPtr_AddToNamespaceHashtable_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664593);
			XmlTextWriter.NativeMethodInfoPtr_PopNamespaces_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664594);
			XmlTextWriter.NativeMethodInfoPtr_GeneratePrefix_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664595);
			XmlTextWriter.NativeMethodInfoPtr_InternalWriteProcessingInstruction_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664596);
			XmlTextWriter.NativeMethodInfoPtr_LookupNamespace_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664597);
			XmlTextWriter.NativeMethodInfoPtr_LookupNamespaceInCurrentScope_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664598);
			XmlTextWriter.NativeMethodInfoPtr_FindPrefix_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664599);
			XmlTextWriter.NativeMethodInfoPtr_ValidateName_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664600);
			XmlTextWriter.NativeMethodInfoPtr_HandleSpecialAttribute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664601);
			XmlTextWriter.NativeMethodInfoPtr_VerifyPrefixXml_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664602);
			XmlTextWriter.NativeMethodInfoPtr_PushStack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664603);
			XmlTextWriter.NativeMethodInfoPtr_FlushEncoders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664604);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00035EDC File Offset: 0x000340DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 394679, RefRangeEnd = 394680, XrefRangeStart = 394667, XrefRangeEnd = 394679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00035F18 File Offset: 0x00034118
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 394685, RefRangeEnd = 394687, XrefRangeStart = 394680, XrefRangeEnd = 394685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextWriter(TextWriter w)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(w);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr__ctor_Public_Void_TextWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002A5 RID: 677
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x00035F64 File Offset: 0x00034164
		public unsafe Formatting Formatting
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_set_Formatting_Public_set_Void_Formatting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00035FA4 File Offset: 0x000341A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394687, XrefRangeEnd = 394688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartDocument()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00035FE0 File Offset: 0x000341E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394688, XrefRangeEnd = 394719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00036064 File Offset: 0x00034264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394719, XrefRangeEnd = 394734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x000360D8 File Offset: 0x000342D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394734, XrefRangeEnd = 394735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteEndElement_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00036114 File Offset: 0x00034314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394735, XrefRangeEnd = 394736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteFullEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteFullEndElement_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00036150 File Offset: 0x00034350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394736, XrefRangeEnd = 394785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000361C4 File Offset: 0x000343C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394785, XrefRangeEnd = 394786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00036200 File Offset: 0x00034400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394786, XrefRangeEnd = 394798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCData(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00036250 File Offset: 0x00034450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394798, XrefRangeEnd = 394812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteComment(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000362A0 File Offset: 0x000344A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394812, XrefRangeEnd = 394832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00036300 File Offset: 0x00034500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394832, XrefRangeEnd = 394838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEntityRef(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00036350 File Offset: 0x00034550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394838, XrefRangeEnd = 394850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCharEntity(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0003639C File Offset: 0x0003459C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394850, XrefRangeEnd = 394855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteWhitespace(string ws)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ws);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000363EC File Offset: 0x000345EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394855, XrefRangeEnd = 394857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteString(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0003643C File Offset: 0x0003463C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394857, XrefRangeEnd = 394859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00036494 File Offset: 0x00034694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394859, XrefRangeEnd = 394861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00036500 File Offset: 0x00034700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394861, XrefRangeEnd = 394863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0003656C File Offset: 0x0003476C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394863, XrefRangeEnd = 394865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteRaw(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x000365BC File Offset: 0x000347BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394865, XrefRangeEnd = 394871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteBase64_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00036628 File Offset: 0x00034828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394871, XrefRangeEnd = 394873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteBinHex_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x00036694 File Offset: 0x00034894
		public unsafe override WriteState WriteState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_get_WriteState_Public_Virtual_get_WriteState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000366DC File Offset: 0x000348DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394873, XrefRangeEnd = 394877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00036718 File Offset: 0x00034918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00036754 File Offset: 0x00034954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394877, XrefRangeEnd = 394880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string LookupPrefix(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000367A8 File Offset: 0x000349A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 394924, RefRangeEnd = 394925, XrefRangeStart = 394880, XrefRangeEnd = 394924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDocument(int standalone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref standalone;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_StartDocument_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000367E8 File Offset: 0x000349E8
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 394950, RefRangeEnd = 394968, XrefRangeStart = 394925, XrefRangeEnd = 394950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutoComplete(XmlTextWriter.Token token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_AutoComplete_Private_Void_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00036828 File Offset: 0x00034A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394968, XrefRangeEnd = 394969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutoCompleteAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_AutoCompleteAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0003685C File Offset: 0x00034A5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 394978, RefRangeEnd = 394980, XrefRangeStart = 394969, XrefRangeEnd = 394978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteEndElement(bool longFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref longFormat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_InternalWriteEndElement_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0003689C File Offset: 0x00034A9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 395009, RefRangeEnd = 395012, XrefRangeStart = 394980, XrefRangeEnd = 395009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEndStartTag(bool empty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref empty;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_WriteEndStartTag_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x000368DC File Offset: 0x00034ADC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 395015, RefRangeEnd = 395019, XrefRangeStart = 395012, XrefRangeEnd = 395015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEndAttributeQuote()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_WriteEndAttributeQuote_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00036910 File Offset: 0x00034B10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 395019, RefRangeEnd = 395021, XrefRangeStart = 395019, XrefRangeEnd = 395019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Indent(bool beforeEndElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref beforeEndElement;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_Indent_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00036950 File Offset: 0x00034B50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 395024, RefRangeEnd = 395028, XrefRangeStart = 395021, XrefRangeEnd = 395024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushNamespace(string prefix, string ns, bool declared)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref declared;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_PushNamespace_Private_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000369B4 File Offset: 0x00034BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395028, XrefRangeEnd = 395042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNamespace(string prefix, string ns, bool declared)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref declared;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00036A18 File Offset: 0x00034C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 395046, RefRangeEnd = 395047, XrefRangeStart = 395042, XrefRangeEnd = 395046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToNamespaceHashtable(int namespaceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namespaceIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_AddToNamespaceHashtable_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00036A58 File Offset: 0x00034C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395047, XrefRangeEnd = 395053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_PopNamespaces_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00036AA4 File Offset: 0x00034CA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 395076, RefRangeEnd = 395077, XrefRangeStart = 395053, XrefRangeEnd = 395076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GeneratePrefix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_GeneratePrefix_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00036ADC File Offset: 0x00034CDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 395084, RefRangeEnd = 395086, XrefRangeStart = 395077, XrefRangeEnd = 395084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteProcessingInstruction(string name, string text)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_InternalWriteProcessingInstruction_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00036B30 File Offset: 0x00034D30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 395087, RefRangeEnd = 395091, XrefRangeStart = 395086, XrefRangeEnd = 395087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_LookupNamespace_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00036B80 File Offset: 0x00034D80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 395094, RefRangeEnd = 395095, XrefRangeStart = 395091, XrefRangeEnd = 395094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LookupNamespaceInCurrentScope(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_LookupNamespaceInCurrentScope_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00036BD0 File Offset: 0x00034DD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 395096, RefRangeEnd = 395099, XrefRangeStart = 395095, XrefRangeEnd = 395096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FindPrefix(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_FindPrefix_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00036C18 File Offset: 0x00034E18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 395113, RefRangeEnd = 395116, XrefRangeStart = 395099, XrefRangeEnd = 395113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateName(string name, bool isNCName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNCName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_ValidateName_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00036C68 File Offset: 0x00034E68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 395124, RefRangeEnd = 395125, XrefRangeStart = 395116, XrefRangeEnd = 395124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleSpecialAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_HandleSpecialAttribute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00036C9C File Offset: 0x00034E9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 395127, RefRangeEnd = 395130, XrefRangeStart = 395125, XrefRangeEnd = 395127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VerifyPrefixXml(string prefix, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_VerifyPrefixXml_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00036CF0 File Offset: 0x00034EF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 395156, RefRangeEnd = 395157, XrefRangeStart = 395130, XrefRangeEnd = 395156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_PushStack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00036D24 File Offset: 0x00034F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395157, XrefRangeEnd = 395158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushEncoders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_FlushEncoders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00004944 File Offset: 0x00002B44
		public XmlTextWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x00036D58 File Offset: 0x00034F58
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x0000494D File Offset: 0x00002B4D
		public unsafe TextWriter textWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_textWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_textWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00036D88 File Offset: 0x00034F88
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x0000496C File Offset: 0x00002B6C
		public unsafe XmlTextEncoder xmlEncoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_xmlEncoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextEncoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_xmlEncoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00036DB8 File Offset: 0x00034FB8
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x0000498B File Offset: 0x00002B8B
		public unsafe Encoding encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00036DE8 File Offset: 0x00034FE8
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x000049AA File Offset: 0x00002BAA
		public unsafe Formatting formatting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_formatting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_formatting)) = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x00036E10 File Offset: 0x00035010
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x000049C5 File Offset: 0x00002BC5
		public unsafe bool indented
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_indented);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_indented)) = value;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00036E38 File Offset: 0x00035038
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x000049E0 File Offset: 0x00002BE0
		public unsafe int indentation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_indentation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_indentation)) = value;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x00036E60 File Offset: 0x00035060
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x000049FB File Offset: 0x00002BFB
		public unsafe char indentChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_indentChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_indentChar)) = value;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00036E88 File Offset: 0x00035088
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x00004A16 File Offset: 0x00002C16
		public unsafe Il2CppReferenceArray<XmlTextWriter.TagInfo> stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlTextWriter.TagInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00036EB8 File Offset: 0x000350B8
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00004A35 File Offset: 0x00002C35
		public unsafe int top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_top);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_top)) = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x00036EE0 File Offset: 0x000350E0
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x00004A50 File Offset: 0x00002C50
		public unsafe Il2CppStructArray<XmlTextWriter.State> stateTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_stateTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XmlTextWriter.State>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_stateTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00036F10 File Offset: 0x00035110
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00004A6F File Offset: 0x00002C6F
		public unsafe XmlTextWriter.State currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_currentState)) = value;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00036F38 File Offset: 0x00035138
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00004A8A File Offset: 0x00002C8A
		public unsafe XmlTextWriter.Token lastToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_lastToken);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_lastToken)) = value;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00036F60 File Offset: 0x00035160
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00004AA5 File Offset: 0x00002CA5
		public unsafe XmlTextWriterBase64Encoder base64Encoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_base64Encoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextWriterBase64Encoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_base64Encoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x00036F90 File Offset: 0x00035190
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x00004AC4 File Offset: 0x00002CC4
		public unsafe char quoteChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_quoteChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_quoteChar)) = value;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00036FB8 File Offset: 0x000351B8
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x00004ADF File Offset: 0x00002CDF
		public unsafe char curQuoteChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_curQuoteChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_curQuoteChar)) = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x00036FE0 File Offset: 0x000351E0
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x00004AFA File Offset: 0x00002CFA
		public unsafe bool namespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_namespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_namespaces)) = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00037008 File Offset: 0x00035208
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x00004B15 File Offset: 0x00002D15
		public unsafe XmlTextWriter.SpecialAttr specialAttr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_specialAttr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_specialAttr)) = value;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00037030 File Offset: 0x00035230
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00004B30 File Offset: 0x00002D30
		public unsafe string prefixForXmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_prefixForXmlNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_prefixForXmlNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00037058 File Offset: 0x00035258
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x00004B4F File Offset: 0x00002D4F
		public unsafe bool flush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_flush);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_flush)) = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00037080 File Offset: 0x00035280
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x00004B6A File Offset: 0x00002D6A
		public unsafe Il2CppReferenceArray<XmlTextWriter.Namespace> nsStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_nsStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlTextWriter.Namespace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_nsStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x000370B0 File Offset: 0x000352B0
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x00004B89 File Offset: 0x00002D89
		public unsafe int nsTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_nsTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_nsTop)) = value;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x000370D8 File Offset: 0x000352D8
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x00004BA4 File Offset: 0x00002DA4
		public unsafe Dictionary<string, int> nsHashtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_nsHashtable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_nsHashtable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00037108 File Offset: 0x00035308
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00004BC3 File Offset: 0x00002DC3
		public unsafe bool useNsHashtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_useNsHashtable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_useNsHashtable)) = value;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00037130 File Offset: 0x00035330
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x00004BDE File Offset: 0x00002DDE
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00037160 File Offset: 0x00035360
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x00004C0C File Offset: 0x00002E0C
		public unsafe static Il2CppStringArray stateName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlTextWriter.NativeFieldInfoPtr_stateName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlTextWriter.NativeFieldInfoPtr_stateName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x00037188 File Offset: 0x00035388
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x00004C1E File Offset: 0x00002E1E
		public unsafe static Il2CppStringArray tokenName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlTextWriter.NativeFieldInfoPtr_tokenName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlTextWriter.NativeFieldInfoPtr_tokenName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x000371B0 File Offset: 0x000353B0
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x00004C30 File Offset: 0x00002E30
		public unsafe static Il2CppStructArray<XmlTextWriter.State> stateTableDefault
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlTextWriter.NativeFieldInfoPtr_stateTableDefault, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XmlTextWriter.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlTextWriter.NativeFieldInfoPtr_stateTableDefault, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x000371D8 File Offset: 0x000353D8
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x00004C42 File Offset: 0x00002E42
		public unsafe static Il2CppStructArray<XmlTextWriter.State> stateTableDocument
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlTextWriter.NativeFieldInfoPtr_stateTableDocument, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XmlTextWriter.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlTextWriter.NativeFieldInfoPtr_stateTableDocument, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeFieldInfoPtr_textWriter;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeFieldInfoPtr_xmlEncoder;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeFieldInfoPtr_formatting;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeFieldInfoPtr_indented;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeFieldInfoPtr_indentation;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeFieldInfoPtr_indentChar;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeFieldInfoPtr_stateTable;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeFieldInfoPtr_currentState;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeFieldInfoPtr_lastToken;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeFieldInfoPtr_base64Encoder;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeFieldInfoPtr_quoteChar;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeFieldInfoPtr_curQuoteChar;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeFieldInfoPtr_namespaces;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeFieldInfoPtr_specialAttr;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeFieldInfoPtr_prefixForXmlNs;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeFieldInfoPtr_flush;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeFieldInfoPtr_nsStack;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeFieldInfoPtr_nsTop;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeFieldInfoPtr_nsHashtable;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeFieldInfoPtr_useNsHashtable;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeFieldInfoPtr_stateName;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeFieldInfoPtr_tokenName;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeFieldInfoPtr_stateTableDefault;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeFieldInfoPtr_stateTableDocument;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextWriter_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_set_Formatting_Public_set_Void_Formatting_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndElement_Public_Virtual_Void_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_WriteFullEndElement_Public_Virtual_Void_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_WriteBase64_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_WriteBinHex_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteState_Public_Virtual_get_WriteState_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_StartDocument_Private_Void_Int32_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_AutoComplete_Private_Void_Token_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_AutoCompleteAll_Private_Void_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteEndElement_Private_Void_Boolean_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndStartTag_Private_Void_Boolean_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndAttributeQuote_Private_Void_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_Indent_Private_Void_Boolean_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_PushNamespace_Private_Void_String_String_Boolean_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_Boolean_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_AddToNamespaceHashtable_Private_Void_Int32_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_PopNamespaces_Private_Void_Int32_Int32_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePrefix_Private_String_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteProcessingInstruction_Private_Void_String_String_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Private_Int32_String_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespaceInCurrentScope_Private_Int32_String_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_FindPrefix_Private_String_String_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_ValidateName_Private_Void_String_Boolean_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_HandleSpecialAttribute_Private_Void_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_VerifyPrefixXml_Private_Void_String_String_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_PushStack_Private_Void_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_FlushEncoders_Private_Void_0;

		// Token: 0x02000209 RID: 521
		[OriginalName("System.Xml.dll", "", "NamespaceState")]
		public enum NamespaceState
		{
			// Token: 0x04002111 RID: 8465
			Uninitialized,
			// Token: 0x04002112 RID: 8466
			NotDeclaredButInScope,
			// Token: 0x04002113 RID: 8467
			DeclaredButNotWrittenOut,
			// Token: 0x04002114 RID: 8468
			DeclaredAndWrittenOut
		}

		// Token: 0x0200020A RID: 522
		public sealed class TagInfo : ValueType
		{
			// Token: 0x06002B1D RID: 11037 RVA: 0x000C2DA8 File Offset: 0x000C0FA8
			// Note: this type is marked as 'beforefieldinit'.
			static TagInfo()
			{
				Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "TagInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr);
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "name");
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "prefix");
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_defaultNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "defaultNs");
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_defaultNsState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "defaultNsState");
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_xmlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "xmlSpace");
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_xmlLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "xmlLang");
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_prevNsTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "prevNsTop");
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_prefixCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "prefixCount");
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_mixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "mixed");
				XmlTextWriter.TagInfo.NativeMethodInfoPtr_Init_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, 100664606);
			}

			// Token: 0x06002B1E RID: 11038 RVA: 0x000C2E9C File Offset: 0x000C109C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 394664, RefRangeEnd = 394666, XrefRangeStart = 394662, XrefRangeEnd = 394664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(int nsTop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref nsTop;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.TagInfo.NativeMethodInfoPtr_Init_Internal_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B1F RID: 11039 RVA: 0x00012483 File Offset: 0x00010683
			public TagInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002B20 RID: 11040 RVA: 0x0001248C File Offset: 0x0001068C
			public TagInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr))
			{
			}

			// Token: 0x17000EBC RID: 3772
			// (get) Token: 0x06002B21 RID: 11041 RVA: 0x000C2EE0 File Offset: 0x000C10E0
			// (set) Token: 0x06002B22 RID: 11042 RVA: 0x0001249E File Offset: 0x0001069E
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EBD RID: 3773
			// (get) Token: 0x06002B23 RID: 11043 RVA: 0x000C2F08 File Offset: 0x000C1108
			// (set) Token: 0x06002B24 RID: 11044 RVA: 0x000124BD File Offset: 0x000106BD
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EBE RID: 3774
			// (get) Token: 0x06002B25 RID: 11045 RVA: 0x000C2F30 File Offset: 0x000C1130
			// (set) Token: 0x06002B26 RID: 11046 RVA: 0x000124DC File Offset: 0x000106DC
			public unsafe string defaultNs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_defaultNs);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_defaultNs), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EBF RID: 3775
			// (get) Token: 0x06002B27 RID: 11047 RVA: 0x000C2F58 File Offset: 0x000C1158
			// (set) Token: 0x06002B28 RID: 11048 RVA: 0x000124FB File Offset: 0x000106FB
			public unsafe XmlTextWriter.NamespaceState defaultNsState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_defaultNsState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_defaultNsState)) = value;
				}
			}

			// Token: 0x17000EC0 RID: 3776
			// (get) Token: 0x06002B29 RID: 11049 RVA: 0x000C2F80 File Offset: 0x000C1180
			// (set) Token: 0x06002B2A RID: 11050 RVA: 0x00012516 File Offset: 0x00010716
			public unsafe XmlSpace xmlSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_xmlSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_xmlSpace)) = value;
				}
			}

			// Token: 0x17000EC1 RID: 3777
			// (get) Token: 0x06002B2B RID: 11051 RVA: 0x000C2FA8 File Offset: 0x000C11A8
			// (set) Token: 0x06002B2C RID: 11052 RVA: 0x00012531 File Offset: 0x00010731
			public unsafe string xmlLang
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_xmlLang);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_xmlLang), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EC2 RID: 3778
			// (get) Token: 0x06002B2D RID: 11053 RVA: 0x000C2FD0 File Offset: 0x000C11D0
			// (set) Token: 0x06002B2E RID: 11054 RVA: 0x00012550 File Offset: 0x00010750
			public unsafe int prevNsTop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_prevNsTop);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_prevNsTop)) = value;
				}
			}

			// Token: 0x17000EC3 RID: 3779
			// (get) Token: 0x06002B2F RID: 11055 RVA: 0x000C2FF8 File Offset: 0x000C11F8
			// (set) Token: 0x06002B30 RID: 11056 RVA: 0x0001256B File Offset: 0x0001076B
			public unsafe int prefixCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_prefixCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_prefixCount)) = value;
				}
			}

			// Token: 0x17000EC4 RID: 3780
			// (get) Token: 0x06002B31 RID: 11057 RVA: 0x000C3020 File Offset: 0x000C1220
			// (set) Token: 0x06002B32 RID: 11058 RVA: 0x00012586 File Offset: 0x00010786
			public unsafe bool mixed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_mixed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_mixed)) = value;
				}
			}

			// Token: 0x04002115 RID: 8469
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04002116 RID: 8470
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x04002117 RID: 8471
			private static readonly IntPtr NativeFieldInfoPtr_defaultNs;

			// Token: 0x04002118 RID: 8472
			private static readonly IntPtr NativeFieldInfoPtr_defaultNsState;

			// Token: 0x04002119 RID: 8473
			private static readonly IntPtr NativeFieldInfoPtr_xmlSpace;

			// Token: 0x0400211A RID: 8474
			private static readonly IntPtr NativeFieldInfoPtr_xmlLang;

			// Token: 0x0400211B RID: 8475
			private static readonly IntPtr NativeFieldInfoPtr_prevNsTop;

			// Token: 0x0400211C RID: 8476
			private static readonly IntPtr NativeFieldInfoPtr_prefixCount;

			// Token: 0x0400211D RID: 8477
			private static readonly IntPtr NativeFieldInfoPtr_mixed;

			// Token: 0x0400211E RID: 8478
			private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_Int32_0;
		}

		// Token: 0x0200020B RID: 523
		public sealed class Namespace : ValueType
		{
			// Token: 0x06002B33 RID: 11059 RVA: 0x000C3048 File Offset: 0x000C1248
			// Note: this type is marked as 'beforefieldinit'.
			static Namespace()
			{
				Il2CppClassPointerStore<XmlTextWriter.Namespace>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "Namespace");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextWriter.Namespace>.NativeClassPtr);
				XmlTextWriter.Namespace.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.Namespace>.NativeClassPtr, "prefix");
				XmlTextWriter.Namespace.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.Namespace>.NativeClassPtr, "ns");
				XmlTextWriter.Namespace.NativeFieldInfoPtr_declared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.Namespace>.NativeClassPtr, "declared");
				XmlTextWriter.Namespace.NativeFieldInfoPtr_prevNsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.Namespace>.NativeClassPtr, "prevNsIndex");
				XmlTextWriter.Namespace.NativeMethodInfoPtr_Set_Internal_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter.Namespace>.NativeClassPtr, 100664607);
			}

			// Token: 0x06002B34 RID: 11060 RVA: 0x000C30D8 File Offset: 0x000C12D8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 394666, RefRangeEnd = 394667, XrefRangeStart = 394666, XrefRangeEnd = 394666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(string prefix, string ns, bool declared)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref declared;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.Namespace.NativeMethodInfoPtr_Set_Internal_Void_String_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B35 RID: 11061 RVA: 0x000125A1 File Offset: 0x000107A1
			public Namespace(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002B36 RID: 11062 RVA: 0x000125AA File Offset: 0x000107AA
			public Namespace()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextWriter.Namespace>.NativeClassPtr))
			{
			}

			// Token: 0x17000EC5 RID: 3781
			// (get) Token: 0x06002B37 RID: 11063 RVA: 0x000C3140 File Offset: 0x000C1340
			// (set) Token: 0x06002B38 RID: 11064 RVA: 0x000125BC File Offset: 0x000107BC
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.Namespace.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.Namespace.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EC6 RID: 3782
			// (get) Token: 0x06002B39 RID: 11065 RVA: 0x000C3168 File Offset: 0x000C1368
			// (set) Token: 0x06002B3A RID: 11066 RVA: 0x000125DB File Offset: 0x000107DB
			public unsafe string ns
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.Namespace.NativeFieldInfoPtr_ns);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.Namespace.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EC7 RID: 3783
			// (get) Token: 0x06002B3B RID: 11067 RVA: 0x000C3190 File Offset: 0x000C1390
			// (set) Token: 0x06002B3C RID: 11068 RVA: 0x000125FA File Offset: 0x000107FA
			public unsafe bool declared
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.Namespace.NativeFieldInfoPtr_declared);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.Namespace.NativeFieldInfoPtr_declared)) = value;
				}
			}

			// Token: 0x17000EC8 RID: 3784
			// (get) Token: 0x06002B3D RID: 11069 RVA: 0x000C31B8 File Offset: 0x000C13B8
			// (set) Token: 0x06002B3E RID: 11070 RVA: 0x00012615 File Offset: 0x00010815
			public unsafe int prevNsIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.Namespace.NativeFieldInfoPtr_prevNsIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.Namespace.NativeFieldInfoPtr_prevNsIndex)) = value;
				}
			}

			// Token: 0x0400211F RID: 8479
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x04002120 RID: 8480
			private static readonly IntPtr NativeFieldInfoPtr_ns;

			// Token: 0x04002121 RID: 8481
			private static readonly IntPtr NativeFieldInfoPtr_declared;

			// Token: 0x04002122 RID: 8482
			private static readonly IntPtr NativeFieldInfoPtr_prevNsIndex;

			// Token: 0x04002123 RID: 8483
			private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_String_String_Boolean_0;
		}

		// Token: 0x0200020C RID: 524
		[OriginalName("System.Xml.dll", "", "SpecialAttr")]
		public enum SpecialAttr
		{
			// Token: 0x04002125 RID: 8485
			None,
			// Token: 0x04002126 RID: 8486
			XmlSpace,
			// Token: 0x04002127 RID: 8487
			XmlLang,
			// Token: 0x04002128 RID: 8488
			XmlNs
		}

		// Token: 0x0200020D RID: 525
		[OriginalName("System.Xml.dll", "", "State")]
		public enum State
		{
			// Token: 0x0400212A RID: 8490
			Start,
			// Token: 0x0400212B RID: 8491
			Prolog,
			// Token: 0x0400212C RID: 8492
			PostDTD,
			// Token: 0x0400212D RID: 8493
			Element,
			// Token: 0x0400212E RID: 8494
			Attribute,
			// Token: 0x0400212F RID: 8495
			Content,
			// Token: 0x04002130 RID: 8496
			AttrOnly,
			// Token: 0x04002131 RID: 8497
			Epilog,
			// Token: 0x04002132 RID: 8498
			Error,
			// Token: 0x04002133 RID: 8499
			Closed
		}

		// Token: 0x0200020E RID: 526
		[OriginalName("System.Xml.dll", "", "Token")]
		public enum Token
		{
			// Token: 0x04002135 RID: 8501
			PI,
			// Token: 0x04002136 RID: 8502
			Doctype,
			// Token: 0x04002137 RID: 8503
			Comment,
			// Token: 0x04002138 RID: 8504
			CData,
			// Token: 0x04002139 RID: 8505
			StartElement,
			// Token: 0x0400213A RID: 8506
			EndElement,
			// Token: 0x0400213B RID: 8507
			LongEndElement,
			// Token: 0x0400213C RID: 8508
			StartAttribute,
			// Token: 0x0400213D RID: 8509
			EndAttribute,
			// Token: 0x0400213E RID: 8510
			Content,
			// Token: 0x0400213F RID: 8511
			Base64,
			// Token: 0x04002140 RID: 8512
			RawData,
			// Token: 0x04002141 RID: 8513
			Whitespace,
			// Token: 0x04002142 RID: 8514
			Empty
		}
	}
}
