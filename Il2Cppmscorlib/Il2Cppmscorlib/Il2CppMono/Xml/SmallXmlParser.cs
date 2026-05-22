using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppMono.Xml
{
	// Token: 0x02000012 RID: 18
	public class SmallXmlParser : Object
	{
		// Token: 0x0600006C RID: 108 RVA: 0x000246C0 File Offset: 0x000228C0
		// Note: this type is marked as 'beforefieldinit'.
		static SmallXmlParser()
		{
			Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Xml", "SmallXmlParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr);
			SmallXmlParser.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "handler");
			SmallXmlParser.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "reader");
			SmallXmlParser.NativeFieldInfoPtr_elementNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "elementNames");
			SmallXmlParser.NativeFieldInfoPtr_xmlSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "xmlSpaces");
			SmallXmlParser.NativeFieldInfoPtr_xmlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "xmlSpace");
			SmallXmlParser.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "buffer");
			SmallXmlParser.NativeFieldInfoPtr_nameBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "nameBuffer");
			SmallXmlParser.NativeFieldInfoPtr_isWhitespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "isWhitespace");
			SmallXmlParser.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "attributes");
			SmallXmlParser.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "line");
			SmallXmlParser.NativeFieldInfoPtr_column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "column");
			SmallXmlParser.NativeFieldInfoPtr_resetColumn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "resetColumn");
			SmallXmlParser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663364);
			SmallXmlParser.NativeMethodInfoPtr_Error_Private_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663365);
			SmallXmlParser.NativeMethodInfoPtr_UnexpectedEndError_Private_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663366);
			SmallXmlParser.NativeMethodInfoPtr_IsNameChar_Private_Boolean_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663367);
			SmallXmlParser.NativeMethodInfoPtr_IsWhitespace_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663368);
			SmallXmlParser.NativeMethodInfoPtr_SkipWhitespaces_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663369);
			SmallXmlParser.NativeMethodInfoPtr_HandleWhitespaces_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663370);
			SmallXmlParser.NativeMethodInfoPtr_SkipWhitespaces_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663371);
			SmallXmlParser.NativeMethodInfoPtr_Peek_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663372);
			SmallXmlParser.NativeMethodInfoPtr_Read_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663373);
			SmallXmlParser.NativeMethodInfoPtr_Expect_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663374);
			SmallXmlParser.NativeMethodInfoPtr_ReadUntil_Private_String_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663375);
			SmallXmlParser.NativeMethodInfoPtr_ReadName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663376);
			SmallXmlParser.NativeMethodInfoPtr_Parse_Public_Void_TextReader_IContentHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663377);
			SmallXmlParser.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663378);
			SmallXmlParser.NativeMethodInfoPtr_ReadContent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663379);
			SmallXmlParser.NativeMethodInfoPtr_HandleBufferedContent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663380);
			SmallXmlParser.NativeMethodInfoPtr_ReadCharacters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663381);
			SmallXmlParser.NativeMethodInfoPtr_ReadReference_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663382);
			SmallXmlParser.NativeMethodInfoPtr_ReadCharacterReference_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663383);
			SmallXmlParser.NativeMethodInfoPtr_ReadAttribute_Private_Void_AttrListImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663384);
			SmallXmlParser.NativeMethodInfoPtr_ReadCDATASection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663385);
			SmallXmlParser.NativeMethodInfoPtr_ReadComment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663386);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000249AC File Offset: 0x00022BAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131302, RefRangeEnd = 131304, XrefRangeStart = 131272, XrefRangeEnd = 131302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmallXmlParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000249E8 File Offset: 0x00022BE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131316, RefRangeEnd = 131319, XrefRangeStart = 131304, XrefRangeEnd = 131316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception Error(string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Error_Private_Exception_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00024A38 File Offset: 0x00022C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131319, XrefRangeEnd = 131336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception UnexpectedEndError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_UnexpectedEndError_Private_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00024A78 File Offset: 0x00022C78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131337, RefRangeEnd = 131339, XrefRangeStart = 131336, XrefRangeEnd = 131337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNameChar(char c, bool start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_IsNameChar_Private_Boolean_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00024AD0 File Offset: 0x00022CD0
		[CallerCount(0)]
		public unsafe bool IsWhitespace(int c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_IsWhitespace_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00024B1C File Offset: 0x00022D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131339, XrefRangeEnd = 131340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipWhitespaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_SkipWhitespaces_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00024B50 File Offset: 0x00022D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131340, XrefRangeEnd = 131343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleWhitespaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_HandleWhitespaces_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00024B84 File Offset: 0x00022D84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 131345, RefRangeEnd = 131349, XrefRangeStart = 131343, XrefRangeEnd = 131345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipWhitespaces(bool expected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_SkipWhitespaces_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00024BC4 File Offset: 0x00022DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131349, XrefRangeEnd = 131350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Peek_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00024C00 File Offset: 0x00022E00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 131350, RefRangeEnd = 131354, XrefRangeStart = 131350, XrefRangeEnd = 131350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Read_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00024C3C File Offset: 0x00022E3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 131355, RefRangeEnd = 131359, XrefRangeStart = 131354, XrefRangeEnd = 131355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Expect(int c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Expect_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00024C7C File Offset: 0x00022E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131365, RefRangeEnd = 131366, XrefRangeStart = 131359, XrefRangeEnd = 131365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadUntil(char until, bool handleReferences)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref until;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleReferences;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadUntil_Private_String_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00024CD0 File Offset: 0x00022ED0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131375, RefRangeEnd = 131378, XrefRangeStart = 131366, XrefRangeEnd = 131375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00024D08 File Offset: 0x00022F08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131394, RefRangeEnd = 131396, XrefRangeStart = 131378, XrefRangeEnd = 131394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Parse(TextReader input, SmallXmlParser.IContentHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Parse_Public_Void_TextReader_IContentHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00024D5C File Offset: 0x00022F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131398, RefRangeEnd = 131399, XrefRangeStart = 131396, XrefRangeEnd = 131398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00024D90 File Offset: 0x00022F90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131419, RefRangeEnd = 131420, XrefRangeStart = 131399, XrefRangeEnd = 131419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadContent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00024DC4 File Offset: 0x00022FC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131425, RefRangeEnd = 131426, XrefRangeStart = 131420, XrefRangeEnd = 131425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleBufferedContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_HandleBufferedContent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00024DF8 File Offset: 0x00022FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131426, XrefRangeEnd = 131433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadCharacters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadCharacters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00024E2C File Offset: 0x0002302C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 131457, RefRangeEnd = 131462, XrefRangeStart = 131433, XrefRangeEnd = 131457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadReference_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00024E60 File Offset: 0x00023060
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131463, RefRangeEnd = 131465, XrefRangeStart = 131462, XrefRangeEnd = 131463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadCharacterReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadCharacterReference_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00024E9C File Offset: 0x0002309C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131465, XrefRangeEnd = 131481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadAttribute(SmallXmlParser.AttrListImpl a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadAttribute_Private_Void_AttrListImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00024EE0 File Offset: 0x000230E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131481, XrefRangeEnd = 131487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadCDATASection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadCDATASection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00024F14 File Offset: 0x00023114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131492, RefRangeEnd = 131493, XrefRangeStart = 131487, XrefRangeEnd = 131492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadComment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadComment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002204 File Offset: 0x00000404
		public SmallXmlParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00024F48 File Offset: 0x00023148
		// (set) Token: 0x06000086 RID: 134 RVA: 0x0000220D File Offset: 0x0000040D
		public unsafe SmallXmlParser.IContentHandler handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmallXmlParser.IContentHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00024F78 File Offset: 0x00023178
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0000222C File Offset: 0x0000042C
		public unsafe TextReader reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00024FA8 File Offset: 0x000231A8
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000224B File Offset: 0x0000044B
		public unsafe Stack elementNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_elementNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_elementNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00024FD8 File Offset: 0x000231D8
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0000226A File Offset: 0x0000046A
		public unsafe Stack xmlSpaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_xmlSpaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_xmlSpaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00025008 File Offset: 0x00023208
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002289 File Offset: 0x00000489
		public unsafe string xmlSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_xmlSpace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_xmlSpace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00025030 File Offset: 0x00023230
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000022A8 File Offset: 0x000004A8
		public unsafe StringBuilder buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00025060 File Offset: 0x00023260
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000022C7 File Offset: 0x000004C7
		public unsafe Il2CppStructArray<char> nameBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_nameBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_nameBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00025090 File Offset: 0x00023290
		// (set) Token: 0x06000094 RID: 148 RVA: 0x000022E6 File Offset: 0x000004E6
		public unsafe bool isWhitespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_isWhitespace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_isWhitespace)) = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000250B8 File Offset: 0x000232B8
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002301 File Offset: 0x00000501
		public unsafe SmallXmlParser.AttrListImpl attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmallXmlParser.AttrListImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000250E8 File Offset: 0x000232E8
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002320 File Offset: 0x00000520
		public unsafe int line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_line);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_line)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00025110 File Offset: 0x00023310
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000233B File Offset: 0x0000053B
		public unsafe int column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_column);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_column)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00025138 File Offset: 0x00023338
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002356 File Offset: 0x00000556
		public unsafe bool resetColumn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_resetColumn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_resetColumn)) = value;
			}
		}

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_elementNames;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_xmlSpaces;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_xmlSpace;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_nameBuffer;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_isWhitespace;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_line;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_column;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_resetColumn;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_Error_Private_Exception_String_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_UnexpectedEndError_Private_Exception_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_IsNameChar_Private_Boolean_Char_Boolean_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_IsWhitespace_Private_Boolean_Int32_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhitespaces_Public_Void_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_HandleWhitespaces_Private_Void_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhitespaces_Public_Void_Boolean_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Private_Int32_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_Read_Private_Int32_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_Expect_Public_Void_Int32_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_ReadUntil_Private_String_Char_Boolean_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_ReadName_Public_String_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Void_TextReader_IContentHandler_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_ReadContent_Public_Void_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_HandleBufferedContent_Private_Void_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_ReadCharacters_Private_Void_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_ReadReference_Private_Void_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_ReadCharacterReference_Private_Int32_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttribute_Private_Void_AttrListImpl_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_ReadCDATASection_Private_Void_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_ReadComment_Private_Void_0;

		// Token: 0x02000538 RID: 1336
		public class IContentHandler : Il2CppObjectBase
		{
			// Token: 0x06004EF6 RID: 20214 RVA: 0x001677CC File Offset: 0x001659CC
			// Note: this type is marked as 'beforefieldinit'.
			static IContentHandler()
			{
				Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "IContentHandler");
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnStartParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663387);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnEndParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663388);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnStartElement_Public_Abstract_Virtual_New_Void_String_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663389);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnEndElement_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663390);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnProcessingInstruction_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663391);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnChars_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663392);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663393);
			}

			// Token: 0x06004EF7 RID: 20215 RVA: 0x0016787C File Offset: 0x00165A7C
			[CallerCount(0)]
			public unsafe virtual void OnStartParsing(SmallXmlParser parser)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnStartParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004EF8 RID: 20216 RVA: 0x001678CC File Offset: 0x00165ACC
			[CallerCount(0)]
			public unsafe virtual void OnEndParsing(SmallXmlParser parser)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnEndParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004EF9 RID: 20217 RVA: 0x0016791C File Offset: 0x00165B1C
			[CallerCount(0)]
			public unsafe virtual void OnStartElement(string name, SmallXmlParser.IAttrList attrs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnStartElement_Public_Abstract_Virtual_New_Void_String_IAttrList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EFA RID: 20218 RVA: 0x0016797C File Offset: 0x00165B7C
			[CallerCount(0)]
			public unsafe virtual void OnEndElement(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnEndElement_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004EFB RID: 20219 RVA: 0x001679CC File Offset: 0x00165BCC
			[CallerCount(0)]
			public unsafe virtual void OnProcessingInstruction(string name, string text)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnProcessingInstruction_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EFC RID: 20220 RVA: 0x00167A2C File Offset: 0x00165C2C
			[CallerCount(0)]
			public unsafe virtual void OnChars(string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnChars_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004EFD RID: 20221 RVA: 0x00167A7C File Offset: 0x00165C7C
			[CallerCount(0)]
			public unsafe virtual void OnIgnorableWhitespace(string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004EFE RID: 20222 RVA: 0x0001D987 File Offset: 0x0001BB87
			public IContentHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003FBD RID: 16317
			private static readonly IntPtr NativeMethodInfoPtr_OnStartParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0;

			// Token: 0x04003FBE RID: 16318
			private static readonly IntPtr NativeMethodInfoPtr_OnEndParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0;

			// Token: 0x04003FBF RID: 16319
			private static readonly IntPtr NativeMethodInfoPtr_OnStartElement_Public_Abstract_Virtual_New_Void_String_IAttrList_0;

			// Token: 0x04003FC0 RID: 16320
			private static readonly IntPtr NativeMethodInfoPtr_OnEndElement_Public_Abstract_Virtual_New_Void_String_0;

			// Token: 0x04003FC1 RID: 16321
			private static readonly IntPtr NativeMethodInfoPtr_OnProcessingInstruction_Public_Abstract_Virtual_New_Void_String_String_0;

			// Token: 0x04003FC2 RID: 16322
			private static readonly IntPtr NativeMethodInfoPtr_OnChars_Public_Abstract_Virtual_New_Void_String_0;

			// Token: 0x04003FC3 RID: 16323
			private static readonly IntPtr NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Abstract_Virtual_New_Void_String_0;
		}

		// Token: 0x02000539 RID: 1337
		public class IAttrList : Il2CppObjectBase
		{
			// Token: 0x06004EFF RID: 20223 RVA: 0x00167ACC File Offset: 0x00165CCC
			// Note: this type is marked as 'beforefieldinit'.
			static IAttrList()
			{
				Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "IAttrList");
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663394);
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663395);
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663396);
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663397);
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Names_Public_Abstract_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663398);
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Values_Public_Abstract_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663399);
			}

			// Token: 0x17001433 RID: 5171
			// (get) Token: 0x06004F00 RID: 20224 RVA: 0x00167B68 File Offset: 0x00165D68
			public unsafe virtual int Length
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F01 RID: 20225 RVA: 0x00167BB0 File Offset: 0x00165DB0
			[CallerCount(0)]
			public unsafe virtual string GetName(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06004F02 RID: 20226 RVA: 0x00167C00 File Offset: 0x00165E00
			[CallerCount(0)]
			public unsafe virtual string GetValue(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06004F03 RID: 20227 RVA: 0x00167C50 File Offset: 0x00165E50
			[CallerCount(0)]
			public unsafe virtual string GetValue(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001434 RID: 5172
			// (get) Token: 0x06004F04 RID: 20228 RVA: 0x00167CA4 File Offset: 0x00165EA4
			public unsafe virtual Il2CppStringArray Names
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Names_Public_Abstract_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x17001435 RID: 5173
			// (get) Token: 0x06004F05 RID: 20229 RVA: 0x00167CF0 File Offset: 0x00165EF0
			public unsafe virtual Il2CppStringArray Values
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Values_Public_Abstract_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x06004F06 RID: 20230 RVA: 0x0001D990 File Offset: 0x0001BB90
			public IAttrList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003FC4 RID: 16324
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int32_0;

			// Token: 0x04003FC5 RID: 16325
			private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_Int32_0;

			// Token: 0x04003FC6 RID: 16326
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_Int32_0;

			// Token: 0x04003FC7 RID: 16327
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_String_0;

			// Token: 0x04003FC8 RID: 16328
			private static readonly IntPtr NativeMethodInfoPtr_get_Names_Public_Abstract_Virtual_New_get_Il2CppStringArray_0;

			// Token: 0x04003FC9 RID: 16329
			private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Abstract_Virtual_New_get_Il2CppStringArray_0;
		}

		// Token: 0x0200053A RID: 1338
		public class AttrListImpl : Object
		{
			// Token: 0x06004F07 RID: 20231 RVA: 0x00167D3C File Offset: 0x00165F3C
			// Note: this type is marked as 'beforefieldinit'.
			static AttrListImpl()
			{
				Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "AttrListImpl");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr);
				SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, "attrNames");
				SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, "attrValues");
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Length_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663400);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663401);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663402);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663403);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Names_Public_Virtual_Final_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663404);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663405);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663406);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_Add_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663407);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663408);
			}

			// Token: 0x17001438 RID: 5176
			// (get) Token: 0x06004F08 RID: 20232 RVA: 0x00167E44 File Offset: 0x00166044
			public unsafe virtual int Length
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131237, XrefRangeEnd = 131238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Length_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F09 RID: 20233 RVA: 0x00167E80 File Offset: 0x00166080
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131238, XrefRangeEnd = 131239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string GetName(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06004F0A RID: 20234 RVA: 0x00167EC4 File Offset: 0x001660C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131239, XrefRangeEnd = 131240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string GetValue(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06004F0B RID: 20235 RVA: 0x00167F08 File Offset: 0x00166108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131240, XrefRangeEnd = 131244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string GetValue(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001439 RID: 5177
			// (get) Token: 0x06004F0C RID: 20236 RVA: 0x00167F50 File Offset: 0x00166150
			public unsafe virtual Il2CppStringArray Names
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131244, XrefRangeEnd = 131248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Names_Public_Virtual_Final_New_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x1700143A RID: 5178
			// (get) Token: 0x06004F0D RID: 20237 RVA: 0x00167F90 File Offset: 0x00166190
			public unsafe virtual Il2CppStringArray Values
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131248, XrefRangeEnd = 131252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x06004F0E RID: 20238 RVA: 0x00167FD0 File Offset: 0x001661D0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 131255, RefRangeEnd = 131256, XrefRangeStart = 131252, XrefRangeEnd = 131255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F0F RID: 20239 RVA: 0x00168004 File Offset: 0x00166204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131256, XrefRangeEnd = 131262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(string name, string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_Add_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F10 RID: 20240 RVA: 0x00168058 File Offset: 0x00166258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131262, XrefRangeEnd = 131272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttrListImpl()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F11 RID: 20241 RVA: 0x0001D999 File Offset: 0x0001BB99
			public AttrListImpl(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001436 RID: 5174
			// (get) Token: 0x06004F12 RID: 20242 RVA: 0x00168094 File Offset: 0x00166294
			// (set) Token: 0x06004F13 RID: 20243 RVA: 0x0001D9A2 File Offset: 0x0001BBA2
			public unsafe List<string> attrNames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrNames);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrNames), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001437 RID: 5175
			// (get) Token: 0x06004F14 RID: 20244 RVA: 0x001680C4 File Offset: 0x001662C4
			// (set) Token: 0x06004F15 RID: 20245 RVA: 0x0001D9C1 File Offset: 0x0001BBC1
			public unsafe List<string> attrValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FCA RID: 16330
			private static readonly IntPtr NativeFieldInfoPtr_attrNames;

			// Token: 0x04003FCB RID: 16331
			private static readonly IntPtr NativeFieldInfoPtr_attrValues;

			// Token: 0x04003FCC RID: 16332
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04003FCD RID: 16333
			private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_Int32_0;

			// Token: 0x04003FCE RID: 16334
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_Int32_0;

			// Token: 0x04003FCF RID: 16335
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_String_0;

			// Token: 0x04003FD0 RID: 16336
			private static readonly IntPtr NativeMethodInfoPtr_get_Names_Public_Virtual_Final_New_get_Il2CppStringArray_0;

			// Token: 0x04003FD1 RID: 16337
			private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_Il2CppStringArray_0;

			// Token: 0x04003FD2 RID: 16338
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

			// Token: 0x04003FD3 RID: 16339
			private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_String_String_0;

			// Token: 0x04003FD4 RID: 16340
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
