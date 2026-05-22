using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000055 RID: 85
	public class XmlTextEncoder : Object
	{
		// Token: 0x060005EC RID: 1516 RVA: 0x0002D1DC File Offset: 0x0002B3DC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTextEncoder()
		{
			Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlTextEncoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr);
			XmlTextEncoder.NativeFieldInfoPtr_textWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, "textWriter");
			XmlTextEncoder.NativeFieldInfoPtr_inAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, "inAttribute");
			XmlTextEncoder.NativeFieldInfoPtr_quoteChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, "quoteChar");
			XmlTextEncoder.NativeFieldInfoPtr_attrValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, "attrValue");
			XmlTextEncoder.NativeFieldInfoPtr_cacheAttrValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, "cacheAttrValue");
			XmlTextEncoder.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, "xmlCharType");
			XmlTextEncoder.NativeMethodInfoPtr__ctor_Internal_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664169);
			XmlTextEncoder.NativeMethodInfoPtr_set_QuoteChar_Internal_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664170);
			XmlTextEncoder.NativeMethodInfoPtr_StartAttribute_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664171);
			XmlTextEncoder.NativeMethodInfoPtr_EndAttribute_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664172);
			XmlTextEncoder.NativeMethodInfoPtr_get_AttributeValue_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664173);
			XmlTextEncoder.NativeMethodInfoPtr_WriteSurrogateChar_Internal_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664174);
			XmlTextEncoder.NativeMethodInfoPtr_Write_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664175);
			XmlTextEncoder.NativeMethodInfoPtr_WriteSurrogateCharEntity_Internal_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664176);
			XmlTextEncoder.NativeMethodInfoPtr_Write_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664177);
			XmlTextEncoder.NativeMethodInfoPtr_WriteRawWithSurrogateChecking_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664178);
			XmlTextEncoder.NativeMethodInfoPtr_WriteRaw_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664179);
			XmlTextEncoder.NativeMethodInfoPtr_WriteCharEntity_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664180);
			XmlTextEncoder.NativeMethodInfoPtr_WriteEntityRef_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664181);
			XmlTextEncoder.NativeMethodInfoPtr_WriteStringFragment_Private_Void_String_Int32_Int32_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664182);
			XmlTextEncoder.NativeMethodInfoPtr_WriteCharEntityImpl_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664183);
			XmlTextEncoder.NativeMethodInfoPtr_WriteCharEntityImpl_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664184);
			XmlTextEncoder.NativeMethodInfoPtr_WriteEntityRefImpl_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664185);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0002D3D8 File Offset: 0x0002B5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391948, XrefRangeEnd = 391949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextEncoder(TextWriter textWriter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textWriter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr__ctor_Internal_Void_TextWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001EB RID: 491
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x0002D424 File Offset: 0x0002B624
		public unsafe char QuoteChar
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_set_QuoteChar_Internal_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0002D464 File Offset: 0x0002B664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 391951, RefRangeEnd = 391952, XrefRangeStart = 391949, XrefRangeEnd = 391951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAttribute(bool cacheAttrValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cacheAttrValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_StartAttribute_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0002D4A4 File Offset: 0x0002B6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391952, XrefRangeEnd = 391953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_EndAttribute_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0002D4D8 File Offset: 0x0002B6D8
		public unsafe string AttributeValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391953, XrefRangeEnd = 391955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_get_AttributeValue_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0002D510 File Offset: 0x0002B710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 391963, RefRangeEnd = 391965, XrefRangeStart = 391955, XrefRangeEnd = 391963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSurrogateChar(char lowChar, char highChar)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteSurrogateChar_Internal_Void_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0002D55C File Offset: 0x0002B75C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 391999, RefRangeEnd = 392000, XrefRangeStart = 391965, XrefRangeEnd = 391999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(Il2CppStructArray<char> array, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_Write_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0002D5BC File Offset: 0x0002B7BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392017, RefRangeEnd = 392018, XrefRangeStart = 392000, XrefRangeEnd = 392017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteSurrogateCharEntity_Internal_Void_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0002D608 File Offset: 0x0002B808
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 392055, RefRangeEnd = 392059, XrefRangeStart = 392018, XrefRangeEnd = 392055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_Write_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0002D64C File Offset: 0x0002B84C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 392063, RefRangeEnd = 392067, XrefRangeStart = 392059, XrefRangeEnd = 392063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteRawWithSurrogateChecking(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteRawWithSurrogateChecking_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0002D690 File Offset: 0x0002B890
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 392094, RefRangeEnd = 392096, XrefRangeStart = 392067, XrefRangeEnd = 392094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteRaw(Il2CppStructArray<char> array, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteRaw_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0002D6F0 File Offset: 0x0002B8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392096, XrefRangeEnd = 392115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteCharEntity(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteCharEntity_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0002D730 File Offset: 0x0002B930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392115, XrefRangeEnd = 392120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEntityRef(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteEntityRef_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0002D774 File Offset: 0x0002B974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392120, XrefRangeEnd = 392122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteStringFragment(string str, int offset, int count, Il2CppStructArray<char> helperBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helperBuffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteStringFragment_Private_Void_String_Int32_Int32_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0002D7E8 File Offset: 0x0002B9E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392128, RefRangeEnd = 392129, XrefRangeStart = 392122, XrefRangeEnd = 392128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteCharEntityImpl(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteCharEntityImpl_Private_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0002D828 File Offset: 0x0002BA28
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 392132, RefRangeEnd = 392137, XrefRangeStart = 392129, XrefRangeEnd = 392132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteCharEntityImpl(string strVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strVal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteCharEntityImpl_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0002D86C File Offset: 0x0002BA6C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 392142, RefRangeEnd = 392149, XrefRangeStart = 392137, XrefRangeEnd = 392142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEntityRefImpl(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteEntityRefImpl_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00003FA4 File Offset: 0x000021A4
		public XmlTextEncoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x0002D8B0 File Offset: 0x0002BAB0
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00003FAD File Offset: 0x000021AD
		public unsafe TextWriter textWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_textWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_textWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x0002D8E0 File Offset: 0x0002BAE0
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x00003FCC File Offset: 0x000021CC
		public unsafe bool inAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_inAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_inAttribute)) = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0002D908 File Offset: 0x0002BB08
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00003FE7 File Offset: 0x000021E7
		public unsafe char quoteChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_quoteChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_quoteChar)) = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x0002D930 File Offset: 0x0002BB30
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x00004002 File Offset: 0x00002202
		public unsafe StringBuilder attrValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_attrValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_attrValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0002D960 File Offset: 0x0002BB60
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x00004021 File Offset: 0x00002221
		public unsafe bool cacheAttrValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_cacheAttrValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_cacheAttrValue)) = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x0002D988 File Offset: 0x0002BB88
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x0000403C File Offset: 0x0000223C
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeFieldInfoPtr_textWriter;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeFieldInfoPtr_inAttribute;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeFieldInfoPtr_quoteChar;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeFieldInfoPtr_attrValue;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeFieldInfoPtr_cacheAttrValue;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TextWriter_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_set_QuoteChar_Internal_set_Void_Char_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_StartAttribute_Internal_Void_Boolean_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_EndAttribute_Internal_Void_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeValue_Internal_get_String_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_WriteSurrogateChar_Internal_Void_Char_Char_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_Write_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_WriteSurrogateCharEntity_Internal_Void_Char_Char_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_Write_Internal_Void_String_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_WriteRawWithSurrogateChecking_Internal_Void_String_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntity_Internal_Void_Char_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_WriteEntityRef_Internal_Void_String_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringFragment_Private_Void_String_Int32_Int32_Il2CppStructArray_1_Char_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntityImpl_Private_Void_Char_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntityImpl_Private_Void_String_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_WriteEntityRefImpl_Private_Void_String_0;
	}
}
