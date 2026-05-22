using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x0200016E RID: 366
	[Serializable]
	public class Encoding : Object
	{
		// Token: 0x060018E4 RID: 6372 RVA: 0x00094268 File Offset: 0x00092468
		// Note: this type is marked as 'beforefieldinit'.
		static Encoding()
		{
			Il2CppClassPointerStore<Encoding>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "Encoding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoding>.NativeClassPtr);
			Encoding.NativeFieldInfoPtr_defaultEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "defaultEncoding");
			Encoding.NativeFieldInfoPtr_unicodeEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "unicodeEncoding");
			Encoding.NativeFieldInfoPtr_bigEndianUnicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "bigEndianUnicode");
			Encoding.NativeFieldInfoPtr_utf7Encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "utf7Encoding");
			Encoding.NativeFieldInfoPtr_utf8Encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "utf8Encoding");
			Encoding.NativeFieldInfoPtr_utf32Encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "utf32Encoding");
			Encoding.NativeFieldInfoPtr_asciiEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "asciiEncoding");
			Encoding.NativeFieldInfoPtr_latin1Encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "latin1Encoding");
			Encoding.NativeFieldInfoPtr_encodings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "encodings");
			Encoding.NativeFieldInfoPtr_m_codePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "m_codePage");
			Encoding.NativeFieldInfoPtr_dataItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "dataItem");
			Encoding.NativeFieldInfoPtr_m_deserializedFromEverett = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "m_deserializedFromEverett");
			Encoding.NativeFieldInfoPtr_m_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "m_isReadOnly");
			Encoding.NativeFieldInfoPtr_encoderFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "encoderFallback");
			Encoding.NativeFieldInfoPtr_decoderFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "decoderFallback");
			Encoding.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "s_InternalSyncObject");
			Encoding.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667477);
			Encoding.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667478);
			Encoding.NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667479);
			Encoding.NativeMethodInfoPtr_OnDeserializing_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667480);
			Encoding.NativeMethodInfoPtr_OnDeserialized_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667481);
			Encoding.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667482);
			Encoding.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667483);
			Encoding.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667484);
			Encoding.NativeMethodInfoPtr_DeserializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667485);
			Encoding.NativeMethodInfoPtr_SerializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667486);
			Encoding.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667487);
			Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667488);
			Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667489);
			Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667490);
			Encoding.NativeMethodInfoPtr_GetPreamble_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667491);
			Encoding.NativeMethodInfoPtr_GetDataItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667492);
			Encoding.NativeMethodInfoPtr_get_EncodingName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667493);
			Encoding.NativeMethodInfoPtr_get_HeaderName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667494);
			Encoding.NativeMethodInfoPtr_get_WebName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667495);
			Encoding.NativeMethodInfoPtr_get_EncoderFallback_Public_get_EncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667496);
			Encoding.NativeMethodInfoPtr_set_EncoderFallback_Public_set_Void_EncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667497);
			Encoding.NativeMethodInfoPtr_get_DecoderFallback_Public_get_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667498);
			Encoding.NativeMethodInfoPtr_set_DecoderFallback_Public_set_Void_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667499);
			Encoding.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667500);
			Encoding.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667501);
			Encoding.NativeMethodInfoPtr_get_ASCII_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667502);
			Encoding.NativeMethodInfoPtr_get_Latin1_Private_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667503);
			Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667504);
			Encoding.NativeMethodInfoPtr_GetByteCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667505);
			Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667506);
			Encoding.NativeMethodInfoPtr_GetByteCount_Internal_Virtual_New_Int32_ptr_Char_Int32_EncoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667507);
			Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667508);
			Encoding.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667509);
			Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667510);
			Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667511);
			Encoding.NativeMethodInfoPtr_GetBytes_Internal_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667512);
			Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667513);
			Encoding.NativeMethodInfoPtr_GetCharCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667514);
			Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_New_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667515);
			Encoding.NativeMethodInfoPtr_GetCharCount_Internal_Virtual_New_Int32_ptr_Byte_Int32_DecoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667516);
			Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_New_Il2CppStructArray_1_Char_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667517);
			Encoding.NativeMethodInfoPtr_GetChars_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667518);
			Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667519);
			Encoding.NativeMethodInfoPtr_GetChars_Internal_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667520);
			Encoding.NativeMethodInfoPtr_get_CodePage_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667521);
			Encoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_New_Decoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667522);
			Encoding.NativeMethodInfoPtr_CreateDefaultEncoding_Private_Static_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667523);
			Encoding.NativeMethodInfoPtr_setReadOnly_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667524);
			Encoding.NativeMethodInfoPtr_get_Default_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667525);
			Encoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_New_Encoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667526);
			Encoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Abstract_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667527);
			Encoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Abstract_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667528);
			Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667529);
			Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667530);
			Encoding.NativeMethodInfoPtr_get_Unicode_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667531);
			Encoding.NativeMethodInfoPtr_get_BigEndianUnicode_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667532);
			Encoding.NativeMethodInfoPtr_get_UTF7_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667533);
			Encoding.NativeMethodInfoPtr_get_UTF8_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667534);
			Encoding.NativeMethodInfoPtr_get_UTF32_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667535);
			Encoding.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667536);
			Encoding.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667537);
			Encoding.NativeMethodInfoPtr_GetBestFitUnicodeToBytesData_Internal_Virtual_New_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667538);
			Encoding.NativeMethodInfoPtr_GetBestFitBytesToUnicodeData_Internal_Virtual_New_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667539);
			Encoding.NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667540);
			Encoding.NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_EncoderNLS_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667541);
			Encoding.NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667542);
			Encoding.NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_DecoderNLS_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667543);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00094914 File Offset: 0x00092B14
		[CallerCount(0)]
		public unsafe Encoding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00094950 File Offset: 0x00092B50
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 180135, RefRangeEnd = 180150, XrefRangeStart = 180129, XrefRangeEnd = 180135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Encoding(int codePage)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codePage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00094998 File Offset: 0x00092B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180150, XrefRangeEnd = 180156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetDefaultFallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x000949D4 File Offset: 0x00092BD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 180156, RefRangeEnd = 180158, XrefRangeStart = 180156, XrefRangeEnd = 180156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_OnDeserializing_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00094A08 File Offset: 0x00092C08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 180158, RefRangeEnd = 180160, XrefRangeStart = 180158, XrefRangeEnd = 180158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_OnDeserialized_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00094A3C File Offset: 0x00092C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180160, XrefRangeEnd = 180161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x00094A84 File Offset: 0x00092C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180161, XrefRangeEnd = 180162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00094ACC File Offset: 0x00092CCC
		[CallerCount(0)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x00094B14 File Offset: 0x00092D14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180201, RefRangeEnd = 180202, XrefRangeStart = 180162, XrefRangeEnd = 180201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeEncoding(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_DeserializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x00094B70 File Offset: 0x00092D70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180293, RefRangeEnd = 180294, XrefRangeStart = 180202, XrefRangeEnd = 180293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeEncoding(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_SerializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x00094BCC File Offset: 0x00092DCC
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180294, XrefRangeEnd = 180301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00094C00 File Offset: 0x00092E00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 180333, RefRangeEnd = 180336, XrefRangeStart = 180301, XrefRangeEnd = 180333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncoding(int codepage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00094C40 File Offset: 0x00092E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180336, XrefRangeEnd = 180353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoderFallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decoderFallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00094CA4 File Offset: 0x00092EA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 180383, RefRangeEnd = 180386, XrefRangeStart = 180353, XrefRangeEnd = 180383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncoding(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00094CE8 File Offset: 0x00092EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180386, XrefRangeEnd = 180390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetPreamble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetPreamble_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x00094D34 File Offset: 0x00092F34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 180394, RefRangeEnd = 180396, XrefRangeStart = 180390, XrefRangeEnd = 180394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDataItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_GetDataItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x00094D68 File Offset: 0x00092F68
		public unsafe virtual string EncodingName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180396, XrefRangeEnd = 180405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_get_EncodingName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x00094DAC File Offset: 0x00092FAC
		public unsafe virtual string HeaderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180405, XrefRangeEnd = 180414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_get_HeaderName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x00094DF0 File Offset: 0x00092FF0
		public unsafe virtual string WebName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180414, XrefRangeEnd = 180423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_get_WebName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x00094E34 File Offset: 0x00093034
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x00094E74 File Offset: 0x00093074
		public unsafe EncoderFallback EncoderFallback
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_EncoderFallback_Public_get_EncoderFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 180437, RefRangeEnd = 180438, XrefRangeStart = 180423, XrefRangeEnd = 180437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_set_EncoderFallback_Public_set_Void_EncoderFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x00094EB8 File Offset: 0x000930B8
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x00094EF8 File Offset: 0x000930F8
		public unsafe DecoderFallback DecoderFallback
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_DecoderFallback_Public_get_DecoderFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 180452, RefRangeEnd = 180453, XrefRangeStart = 180438, XrefRangeEnd = 180452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_set_DecoderFallback_Public_set_Void_DecoderFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00094F3C File Offset: 0x0009313C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180453, XrefRangeEnd = 180456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060018FD RID: 6397 RVA: 0x00094F88 File Offset: 0x00093188
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x00094FC4 File Offset: 0x000931C4
		public unsafe static Encoding ASCII
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 180463, RefRangeEnd = 180513, XrefRangeStart = 180456, XrefRangeEnd = 180463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_ASCII_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060018FF RID: 6399 RVA: 0x00094FF8 File Offset: 0x000931F8
		public unsafe static Encoding Latin1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180513, XrefRangeEnd = 180520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_Latin1_Private_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0009502C File Offset: 0x0009322C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180520, XrefRangeEnd = 180521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetByteCount(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00095084 File Offset: 0x00093284
		[CallerCount(0)]
		public unsafe virtual int GetByteCount(Il2CppStructArray<char> chars, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetByteCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x000950F8 File Offset: 0x000932F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180521, XrefRangeEnd = 180524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetByteCount(char* chars, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_ptr_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x0009515C File Offset: 0x0009335C
		[CallerCount(0)]
		public unsafe virtual int GetByteCount(char* chars, int count, EncoderNLS encoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetByteCount_Internal_Virtual_New_Int32_ptr_Char_Int32_EncoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x000951D0 File Offset: 0x000933D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180524, XrefRangeEnd = 180527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetBytes(Il2CppStructArray<char> chars, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00095248 File Offset: 0x00093448
		[CallerCount(0)]
		public unsafe virtual int GetBytes(Il2CppStructArray<char> chars, int charIndex, int charCount, Il2CppStructArray<byte> bytes, int byteIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x000952E0 File Offset: 0x000934E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180527, XrefRangeEnd = 180530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetBytes(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x0009533C File Offset: 0x0009353C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180530, XrefRangeEnd = 180537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetBytes(string s, int charIndex, int charCount, Il2CppStructArray<byte> bytes, int byteIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x000953D4 File Offset: 0x000935D4
		[CallerCount(0)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bytes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Internal_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x00095464 File Offset: 0x00093664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180537, XrefRangeEnd = 180543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bytes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x000954E0 File Offset: 0x000936E0
		[CallerCount(0)]
		public unsafe virtual int GetCharCount(Il2CppStructArray<byte> bytes, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetCharCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00095554 File Offset: 0x00093754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180543, XrefRangeEnd = 180546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetCharCount(byte* bytes, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_New_Int32_ptr_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x000955B8 File Offset: 0x000937B8
		[CallerCount(0)]
		public unsafe virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetCharCount_Internal_Virtual_New_Int32_ptr_Byte_Int32_DecoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x0009562C File Offset: 0x0009382C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180546, XrefRangeEnd = 180549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<char> GetChars(Il2CppStructArray<byte> bytes, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_New_Il2CppStructArray_1_Char_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x000956A4 File Offset: 0x000938A4
		[CallerCount(0)]
		public unsafe virtual int GetChars(Il2CppStructArray<byte> bytes, int byteIndex, int byteCount, Il2CppStructArray<char> chars, int charIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetChars_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x0009573C File Offset: 0x0009393C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180549, XrefRangeEnd = 180555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chars;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x000957B8 File Offset: 0x000939B8
		[CallerCount(0)]
		public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chars;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetChars_Internal_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x00095848 File Offset: 0x00093A48
		public unsafe virtual int CodePage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_get_CodePage_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00095890 File Offset: 0x00093A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180555, XrefRangeEnd = 180558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Decoder GetDecoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_New_Decoder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr3) : null;
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x000958DC File Offset: 0x00093ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180558, XrefRangeEnd = 180562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding CreateDefaultEncoding()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_CreateDefaultEncoding_Private_Static_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00095910 File Offset: 0x00093B10
		[CallerCount(0)]
		public unsafe void setReadOnly(bool value = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_setReadOnly_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x00095950 File Offset: 0x00093B50
		public unsafe static Encoding Default
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 180570, RefRangeEnd = 180575, XrefRangeStart = 180562, XrefRangeEnd = 180570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_Default_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00095984 File Offset: 0x00093B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180575, XrefRangeEnd = 180578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Encoder GetEncoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_New_Encoder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoder>(intPtr3) : null;
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x000959D0 File Offset: 0x00093BD0
		[CallerCount(0)]
		public unsafe virtual int GetMaxByteCount(int charCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Abstract_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00095A24 File Offset: 0x00093C24
		[CallerCount(0)]
		public unsafe virtual int GetMaxCharCount(int byteCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref byteCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Abstract_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00095A78 File Offset: 0x00093C78
		[CallerCount(0)]
		public unsafe virtual string GetString(Il2CppStructArray<byte> bytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00095ACC File Offset: 0x00093CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180578, XrefRangeEnd = 180579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetString(Il2CppStructArray<byte> bytes, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x00095B3C File Offset: 0x00093D3C
		public unsafe static Encoding Unicode
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 180587, RefRangeEnd = 180617, XrefRangeStart = 180579, XrefRangeEnd = 180587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_Unicode_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x00095B70 File Offset: 0x00093D70
		public unsafe static Encoding BigEndianUnicode
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 180625, RefRangeEnd = 180629, XrefRangeStart = 180617, XrefRangeEnd = 180625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_BigEndianUnicode_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x00095BA4 File Offset: 0x00093DA4
		public unsafe static Encoding UTF7
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 180637, RefRangeEnd = 180639, XrefRangeStart = 180629, XrefRangeEnd = 180637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_UTF7_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x00095BD8 File Offset: 0x00093DD8
		public unsafe static Encoding UTF8
		{
			[CallerCount(91)]
			[CachedScanResults(RefRangeStart = 180646, RefRangeEnd = 180737, XrefRangeStart = 180639, XrefRangeEnd = 180646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_UTF8_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x00095C0C File Offset: 0x00093E0C
		public unsafe static Encoding UTF32
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180737, XrefRangeEnd = 180745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_UTF32_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00095C40 File Offset: 0x00093E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180745, XrefRangeEnd = 180747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00095C98 File Offset: 0x00093E98
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00095CE0 File Offset: 0x00093EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180747, XrefRangeEnd = 180751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<char> GetBestFitUnicodeToBytesData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBestFitUnicodeToBytesData_Internal_Virtual_New_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00095D2C File Offset: 0x00093F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180751, XrefRangeEnd = 180755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<char> GetBestFitBytesToUnicodeData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBestFitBytesToUnicodeData_Internal_Virtual_New_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x00095D78 File Offset: 0x00093F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180755, XrefRangeEnd = 180775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowBytesOverflow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00095DAC File Offset: 0x00093FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180775, XrefRangeEnd = 180776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nothingEncoded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_EncoderNLS_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00095DFC File Offset: 0x00093FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180776, XrefRangeEnd = 180796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowCharsOverflow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x00095E30 File Offset: 0x00094030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180796, XrefRangeEnd = 180797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decoder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nothingDecoded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_DecoderNLS_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x000089D5 File Offset: 0x00006BD5
		public Encoding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x00095E80 File Offset: 0x00094080
		// (set) Token: 0x0600192A RID: 6442 RVA: 0x000089DE File Offset: 0x00006BDE
		public unsafe static Encoding defaultEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_defaultEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_defaultEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x00095EA8 File Offset: 0x000940A8
		// (set) Token: 0x0600192C RID: 6444 RVA: 0x000089F0 File Offset: 0x00006BF0
		public unsafe static Encoding unicodeEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_unicodeEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_unicodeEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x00095ED0 File Offset: 0x000940D0
		// (set) Token: 0x0600192E RID: 6446 RVA: 0x00008A02 File Offset: 0x00006C02
		public unsafe static Encoding bigEndianUnicode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_bigEndianUnicode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_bigEndianUnicode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x00095EF8 File Offset: 0x000940F8
		// (set) Token: 0x06001930 RID: 6448 RVA: 0x00008A14 File Offset: 0x00006C14
		public unsafe static Encoding utf7Encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_utf7Encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_utf7Encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x00095F20 File Offset: 0x00094120
		// (set) Token: 0x06001932 RID: 6450 RVA: 0x00008A26 File Offset: 0x00006C26
		public unsafe static Encoding utf8Encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_utf8Encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_utf8Encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x00095F48 File Offset: 0x00094148
		// (set) Token: 0x06001934 RID: 6452 RVA: 0x00008A38 File Offset: 0x00006C38
		public unsafe static Encoding utf32Encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_utf32Encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_utf32Encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x00095F70 File Offset: 0x00094170
		// (set) Token: 0x06001936 RID: 6454 RVA: 0x00008A4A File Offset: 0x00006C4A
		public unsafe static Encoding asciiEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_asciiEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_asciiEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001937 RID: 6455 RVA: 0x00095F98 File Offset: 0x00094198
		// (set) Token: 0x06001938 RID: 6456 RVA: 0x00008A5C File Offset: 0x00006C5C
		public unsafe static Encoding latin1Encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_latin1Encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_latin1Encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x00095FC0 File Offset: 0x000941C0
		// (set) Token: 0x0600193A RID: 6458 RVA: 0x00008A6E File Offset: 0x00006C6E
		public unsafe static Hashtable encodings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_encodings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_encodings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x00095FE8 File Offset: 0x000941E8
		// (set) Token: 0x0600193C RID: 6460 RVA: 0x00008A80 File Offset: 0x00006C80
		public unsafe int m_codePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_codePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_codePage)) = value;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x00096010 File Offset: 0x00094210
		// (set) Token: 0x0600193E RID: 6462 RVA: 0x00008A9B File Offset: 0x00006C9B
		public unsafe CodePageDataItem dataItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_dataItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePageDataItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_dataItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x00096040 File Offset: 0x00094240
		// (set) Token: 0x06001940 RID: 6464 RVA: 0x00008ABA File Offset: 0x00006CBA
		public unsafe bool m_deserializedFromEverett
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_deserializedFromEverett);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_deserializedFromEverett)) = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x00096068 File Offset: 0x00094268
		// (set) Token: 0x06001942 RID: 6466 RVA: 0x00008AD5 File Offset: 0x00006CD5
		public unsafe bool m_isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_isReadOnly)) = value;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x00096090 File Offset: 0x00094290
		// (set) Token: 0x06001944 RID: 6468 RVA: 0x00008AF0 File Offset: 0x00006CF0
		public unsafe EncoderFallback encoderFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_encoderFallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_encoderFallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x000960C0 File Offset: 0x000942C0
		// (set) Token: 0x06001946 RID: 6470 RVA: 0x00008B0F File Offset: 0x00006D0F
		public unsafe DecoderFallback decoderFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_decoderFallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_decoderFallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001947 RID: 6471 RVA: 0x000960F0 File Offset: 0x000942F0
		// (set) Token: 0x06001948 RID: 6472 RVA: 0x00008B2E File Offset: 0x00006D2E
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeFieldInfoPtr_defaultEncoding;

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeFieldInfoPtr_unicodeEncoding;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeFieldInfoPtr_bigEndianUnicode;

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeFieldInfoPtr_utf7Encoding;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeFieldInfoPtr_utf8Encoding;

		// Token: 0x040016E1 RID: 5857
		private static readonly IntPtr NativeFieldInfoPtr_utf32Encoding;

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeFieldInfoPtr_asciiEncoding;

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeFieldInfoPtr_latin1Encoding;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeFieldInfoPtr_encodings;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeFieldInfoPtr_m_codePage;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeFieldInfoPtr_dataItem;

		// Token: 0x040016E7 RID: 5863
		private static readonly IntPtr NativeFieldInfoPtr_m_deserializedFromEverett;

		// Token: 0x040016E8 RID: 5864
		private static readonly IntPtr NativeFieldInfoPtr_m_isReadOnly;

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeFieldInfoPtr_encoderFallback;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeFieldInfoPtr_decoderFallback;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040016ED RID: 5869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_0;

		// Token: 0x040016EE RID: 5870
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_New_Void_0;

		// Token: 0x040016EF RID: 5871
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Internal_Void_0;

		// Token: 0x040016F0 RID: 5872
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Internal_Void_0;

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0;

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040016F5 RID: 5877
		private static readonly IntPtr NativeMethodInfoPtr_SerializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040016F6 RID: 5878
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x040016F7 RID: 5879
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_0;

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_String_0;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeMethodInfoPtr_GetPreamble_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeMethodInfoPtr_GetDataItem_Private_Void_0;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeMethodInfoPtr_get_EncodingName_Public_Virtual_New_get_String_0;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeMethodInfoPtr_get_HeaderName_Public_Virtual_New_get_String_0;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeMethodInfoPtr_get_WebName_Public_Virtual_New_get_String_0;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeMethodInfoPtr_get_EncoderFallback_Public_get_EncoderFallback_0;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeMethodInfoPtr_set_EncoderFallback_Public_set_Void_EncoderFallback_0;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeMethodInfoPtr_get_DecoderFallback_Public_get_DecoderFallback_0;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeMethodInfoPtr_set_DecoderFallback_Public_set_Void_DecoderFallback_0;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeMethodInfoPtr_get_ASCII_Public_Static_get_Encoding_0;

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeMethodInfoPtr_get_Latin1_Private_Static_get_Encoding_0;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_String_0;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_ptr_Char_Int32_0;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Internal_Virtual_New_Int32_ptr_Char_Int32_EncoderNLS_0;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Internal_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0;

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_0;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001712 RID: 5906
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_New_Int32_ptr_Byte_Int32_0;

		// Token: 0x04001713 RID: 5907
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Internal_Virtual_New_Int32_ptr_Byte_Int32_DecoderNLS_0;

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_New_Il2CppStructArray_1_Char_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_0;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Internal_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeMethodInfoPtr_get_CodePage_Public_Virtual_New_get_Int32_0;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeMethodInfoPtr_GetDecoder_Public_Virtual_New_Decoder_0;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultEncoding_Private_Static_Encoding_0;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeMethodInfoPtr_setReadOnly_Internal_Void_Boolean_0;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_Encoding_0;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoder_Public_Virtual_New_Encoder_0;

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxByteCount_Public_Abstract_Virtual_New_Int32_Int32_0;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxCharCount_Public_Abstract_Virtual_New_Int32_Int32_0;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeMethodInfoPtr_get_Unicode_Public_Static_get_Encoding_0;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeMethodInfoPtr_get_BigEndianUnicode_Public_Static_get_Encoding_0;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeMethodInfoPtr_get_UTF7_Public_Static_get_Encoding_0;

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeMethodInfoPtr_get_UTF8_Public_Static_get_Encoding_0;

		// Token: 0x04001726 RID: 5926
		private static readonly IntPtr NativeMethodInfoPtr_get_UTF32_Public_Static_get_Encoding_0;

		// Token: 0x04001727 RID: 5927
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001728 RID: 5928
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeMethodInfoPtr_GetBestFitUnicodeToBytesData_Internal_Virtual_New_Il2CppStructArray_1_Char_0;

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeMethodInfoPtr_GetBestFitBytesToUnicodeData_Internal_Virtual_New_Il2CppStructArray_1_Char_0;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_0;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_EncoderNLS_Boolean_0;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_0;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_DecoderNLS_Boolean_0;

		// Token: 0x020005B4 RID: 1460
		[Serializable]
		public class DefaultEncoder : Encoder
		{
			// Token: 0x060051AC RID: 20908 RVA: 0x00171908 File Offset: 0x0016FB08
			// Note: this type is marked as 'beforefieldinit'.
			static DefaultEncoder()
			{
				Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "DefaultEncoder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr);
				Encoding.DefaultEncoder.NativeFieldInfoPtr_m_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, "m_encoding");
				Encoding.DefaultEncoder.NativeFieldInfoPtr_m_hasInitializedEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, "m_hasInitializedEncoding");
				Encoding.DefaultEncoder.NativeFieldInfoPtr_charLeftOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, "charLeftOver");
				Encoding.DefaultEncoder.NativeMethodInfoPtr__ctor_Public_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100667544);
				Encoding.DefaultEncoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100667545);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100667546);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100667547);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100667548);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100667549);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100667550);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100667551);
			}

			// Token: 0x060051AD RID: 20909 RVA: 0x00171A10 File Offset: 0x0016FC10
			[CallerCount(0)]
			public unsafe DefaultEncoder(Encoding encoding)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultEncoder.NativeMethodInfoPtr__ctor_Public_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051AE RID: 20910 RVA: 0x00171A5C File Offset: 0x0016FC5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180015, XrefRangeEnd = 180046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DefaultEncoder(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultEncoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051AF RID: 20911 RVA: 0x00171AC0 File Offset: 0x0016FCC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180046, XrefRangeEnd = 180049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object GetRealObject(StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultEncoder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060051B0 RID: 20912 RVA: 0x00171B18 File Offset: 0x0016FD18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180049, XrefRangeEnd = 180055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultEncoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051B1 RID: 20913 RVA: 0x00171B74 File Offset: 0x0016FD74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180055, XrefRangeEnd = 180056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetByteCount(Il2CppStructArray<char> chars, int index, int count, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultEncoder.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051B2 RID: 20914 RVA: 0x00171BF8 File Offset: 0x0016FDF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180056, XrefRangeEnd = 180057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetByteCount(char* chars, int count, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = chars;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultEncoder.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051B3 RID: 20915 RVA: 0x00171C68 File Offset: 0x0016FE68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180057, XrefRangeEnd = 180058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetBytes(Il2CppStructArray<char> chars, int charIndex, int charCount, Il2CppStructArray<byte> bytes, int byteIndex, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultEncoder.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051B4 RID: 20916 RVA: 0x00171D0C File Offset: 0x0016FF0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180058, XrefRangeEnd = 180059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = chars;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bytes;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultEncoder.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051B5 RID: 20917 RVA: 0x0001EAFA File Offset: 0x0001CCFA
			public DefaultEncoder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014E8 RID: 5352
			// (get) Token: 0x060051B6 RID: 20918 RVA: 0x00171D98 File Offset: 0x0016FF98
			// (set) Token: 0x060051B7 RID: 20919 RVA: 0x0001EB03 File Offset: 0x0001CD03
			public unsafe Encoding m_encoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_m_encoding);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_m_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014E9 RID: 5353
			// (get) Token: 0x060051B8 RID: 20920 RVA: 0x00171DC8 File Offset: 0x0016FFC8
			// (set) Token: 0x060051B9 RID: 20921 RVA: 0x0001EB22 File Offset: 0x0001CD22
			public unsafe bool m_hasInitializedEncoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_m_hasInitializedEncoding);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_m_hasInitializedEncoding)) = value;
				}
			}

			// Token: 0x170014EA RID: 5354
			// (get) Token: 0x060051BA RID: 20922 RVA: 0x00171DF0 File Offset: 0x0016FFF0
			// (set) Token: 0x060051BB RID: 20923 RVA: 0x0001EB3D File Offset: 0x0001CD3D
			public unsafe char charLeftOver
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_charLeftOver);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_charLeftOver)) = value;
				}
			}

			// Token: 0x0400426D RID: 17005
			private static readonly IntPtr NativeFieldInfoPtr_m_encoding;

			// Token: 0x0400426E RID: 17006
			private static readonly IntPtr NativeFieldInfoPtr_m_hasInitializedEncoding;

			// Token: 0x0400426F RID: 17007
			private static readonly IntPtr NativeFieldInfoPtr_charLeftOver;

			// Token: 0x04004270 RID: 17008
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Encoding_0;

			// Token: 0x04004271 RID: 17009
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004272 RID: 17010
			private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0;

			// Token: 0x04004273 RID: 17011
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004274 RID: 17012
			private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_0;

			// Token: 0x04004275 RID: 17013
			private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_Boolean_0;

			// Token: 0x04004276 RID: 17014
			private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_0;

			// Token: 0x04004277 RID: 17015
			private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_Boolean_0;
		}

		// Token: 0x020005B5 RID: 1461
		[Serializable]
		public class DefaultDecoder : Decoder
		{
			// Token: 0x060051BC RID: 20924 RVA: 0x00171E18 File Offset: 0x00170018
			// Note: this type is marked as 'beforefieldinit'.
			static DefaultDecoder()
			{
				Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "DefaultDecoder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr);
				Encoding.DefaultDecoder.NativeFieldInfoPtr_m_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, "m_encoding");
				Encoding.DefaultDecoder.NativeFieldInfoPtr_m_hasInitializedEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, "m_hasInitializedEncoding");
				Encoding.DefaultDecoder.NativeMethodInfoPtr__ctor_Public_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667552);
				Encoding.DefaultDecoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667553);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667554);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667555);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667556);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667557);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667558);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667559);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667560);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667561);
			}

			// Token: 0x060051BD RID: 20925 RVA: 0x00171F34 File Offset: 0x00170134
			[CallerCount(0)]
			public unsafe DefaultDecoder(Encoding encoding)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultDecoder.NativeMethodInfoPtr__ctor_Public_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051BE RID: 20926 RVA: 0x00171F80 File Offset: 0x00170180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180059, XrefRangeEnd = 180083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DefaultDecoder(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultDecoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051BF RID: 20927 RVA: 0x00171FE4 File Offset: 0x001701E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180083, XrefRangeEnd = 180084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object GetRealObject(StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultDecoder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060051C0 RID: 20928 RVA: 0x0017203C File Offset: 0x0017023C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180084, XrefRangeEnd = 180090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultDecoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051C1 RID: 20929 RVA: 0x00172098 File Offset: 0x00170298
			[CallerCount(0)]
			public unsafe override int GetCharCount(Il2CppStructArray<byte> bytes, int index, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051C2 RID: 20930 RVA: 0x0017210C File Offset: 0x0017030C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180090, XrefRangeEnd = 180091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetCharCount(Il2CppStructArray<byte> bytes, int index, int count, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051C3 RID: 20931 RVA: 0x00172190 File Offset: 0x00170390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180091, XrefRangeEnd = 180092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = bytes;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051C4 RID: 20932 RVA: 0x00172200 File Offset: 0x00170400
			[CallerCount(0)]
			public unsafe override int GetChars(Il2CppStructArray<byte> bytes, int byteIndex, int byteCount, Il2CppStructArray<char> chars, int charIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051C5 RID: 20933 RVA: 0x00172298 File Offset: 0x00170498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180092, XrefRangeEnd = 180093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetChars(Il2CppStructArray<byte> bytes, int byteIndex, int byteCount, Il2CppStructArray<char> chars, int charIndex, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051C6 RID: 20934 RVA: 0x0017233C File Offset: 0x0017053C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180093, XrefRangeEnd = 180094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = bytes;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chars;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051C7 RID: 20935 RVA: 0x0001EB58 File Offset: 0x0001CD58
			public DefaultDecoder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014EB RID: 5355
			// (get) Token: 0x060051C8 RID: 20936 RVA: 0x001723C8 File Offset: 0x001705C8
			// (set) Token: 0x060051C9 RID: 20937 RVA: 0x0001EB61 File Offset: 0x0001CD61
			public unsafe Encoding m_encoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultDecoder.NativeFieldInfoPtr_m_encoding);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultDecoder.NativeFieldInfoPtr_m_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014EC RID: 5356
			// (get) Token: 0x060051CA RID: 20938 RVA: 0x001723F8 File Offset: 0x001705F8
			// (set) Token: 0x060051CB RID: 20939 RVA: 0x0001EB80 File Offset: 0x0001CD80
			public unsafe bool m_hasInitializedEncoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultDecoder.NativeFieldInfoPtr_m_hasInitializedEncoding);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultDecoder.NativeFieldInfoPtr_m_hasInitializedEncoding)) = value;
				}
			}

			// Token: 0x04004278 RID: 17016
			private static readonly IntPtr NativeFieldInfoPtr_m_encoding;

			// Token: 0x04004279 RID: 17017
			private static readonly IntPtr NativeFieldInfoPtr_m_hasInitializedEncoding;

			// Token: 0x0400427A RID: 17018
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Encoding_0;

			// Token: 0x0400427B RID: 17019
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x0400427C RID: 17020
			private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0;

			// Token: 0x0400427D RID: 17021
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x0400427E RID: 17022
			private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x0400427F RID: 17023
			private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0;

			// Token: 0x04004280 RID: 17024
			private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_Boolean_0;

			// Token: 0x04004281 RID: 17025
			private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

			// Token: 0x04004282 RID: 17026
			private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Boolean_0;

			// Token: 0x04004283 RID: 17027
			private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_Boolean_0;
		}

		// Token: 0x020005B6 RID: 1462
		public class EncodingCharBuffer : Object
		{
			// Token: 0x060051CC RID: 20940 RVA: 0x00172420 File Offset: 0x00170620
			// Note: this type is marked as 'beforefieldinit'.
			static EncodingCharBuffer()
			{
				Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "EncodingCharBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr);
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "chars");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "charStart");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "charEnd");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charCountResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "charCountResult");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_enc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "enc");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "decoder");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "byteStart");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "byteEnd");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "bytes");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_fallbackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "fallbackBuffer");
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_DecoderNLS_ptr_Char_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667562);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667563);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667564);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AdjustBytes_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667565);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667566);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_GetNextByte_Internal_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667567);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_BytesUsed_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667568);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_Fallback_Internal_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667569);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_Fallback_Internal_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667570);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667571);
			}

			// Token: 0x060051CD RID: 20941 RVA: 0x001725DC File Offset: 0x001707DC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 180096, RefRangeEnd = 180097, XrefRangeStart = 180094, XrefRangeEnd = 180096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncodingCharBuffer(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(enc);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decoder);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = charStart;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = byteStart;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_DecoderNLS_ptr_Char_Int32_ptr_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051CE RID: 20942 RVA: 0x00172670 File Offset: 0x00170870
			[CallerCount(0)]
			public unsafe bool AddChar(char ch, int numBytes)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ch;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051CF RID: 20943 RVA: 0x001726C8 File Offset: 0x001708C8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 180097, RefRangeEnd = 180099, XrefRangeStart = 180097, XrefRangeEnd = 180097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddChar(char ch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ch;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051D0 RID: 20944 RVA: 0x00172714 File Offset: 0x00170914
			[CallerCount(0)]
			public unsafe void AdjustBytes(int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref count;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AdjustBytes_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170014F7 RID: 5367
			// (get) Token: 0x060051D1 RID: 20945 RVA: 0x00172754 File Offset: 0x00170954
			public unsafe bool MoreData
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051D2 RID: 20946 RVA: 0x00172790 File Offset: 0x00170990
			[CallerCount(0)]
			public unsafe byte GetNextByte()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_GetNextByte_Internal_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170014F8 RID: 5368
			// (get) Token: 0x060051D3 RID: 20947 RVA: 0x001727CC File Offset: 0x001709CC
			public unsafe int BytesUsed
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_BytesUsed_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051D4 RID: 20948 RVA: 0x00172808 File Offset: 0x00170A08
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 180106, RefRangeEnd = 180107, XrefRangeStart = 180099, XrefRangeEnd = 180106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Fallback(byte fallbackByte)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref fallbackByte;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_Fallback_Internal_Boolean_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051D5 RID: 20949 RVA: 0x00172854 File Offset: 0x00170A54
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 180108, RefRangeEnd = 180109, XrefRangeStart = 180107, XrefRangeEnd = 180108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Fallback(Il2CppStructArray<byte> byteBuffer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(byteBuffer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_Fallback_Internal_Boolean_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014F9 RID: 5369
			// (get) Token: 0x060051D6 RID: 20950 RVA: 0x001728A4 File Offset: 0x00170AA4
			public unsafe int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051D7 RID: 20951 RVA: 0x0001EB9B File Offset: 0x0001CD9B
			public EncodingCharBuffer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014ED RID: 5357
			// (get) Token: 0x060051D8 RID: 20952 RVA: 0x001728E0 File Offset: 0x00170AE0
			// (set) Token: 0x060051D9 RID: 20953 RVA: 0x0001EBA4 File Offset: 0x0001CDA4
			public unsafe char* chars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_chars);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_chars)) = value;
				}
			}

			// Token: 0x170014EE RID: 5358
			// (get) Token: 0x060051DA RID: 20954 RVA: 0x00172904 File Offset: 0x00170B04
			// (set) Token: 0x060051DB RID: 20955 RVA: 0x0001EBBF File Offset: 0x0001CDBF
			public unsafe char* charStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charStart)) = value;
				}
			}

			// Token: 0x170014EF RID: 5359
			// (get) Token: 0x060051DC RID: 20956 RVA: 0x00172928 File Offset: 0x00170B28
			// (set) Token: 0x060051DD RID: 20957 RVA: 0x0001EBDA File Offset: 0x0001CDDA
			public unsafe char* charEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charEnd)) = value;
				}
			}

			// Token: 0x170014F0 RID: 5360
			// (get) Token: 0x060051DE RID: 20958 RVA: 0x0017294C File Offset: 0x00170B4C
			// (set) Token: 0x060051DF RID: 20959 RVA: 0x0001EBF5 File Offset: 0x0001CDF5
			public unsafe int charCountResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charCountResult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charCountResult)) = value;
				}
			}

			// Token: 0x170014F1 RID: 5361
			// (get) Token: 0x060051E0 RID: 20960 RVA: 0x00172974 File Offset: 0x00170B74
			// (set) Token: 0x060051E1 RID: 20961 RVA: 0x0001EC10 File Offset: 0x0001CE10
			public unsafe Encoding enc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_enc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_enc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014F2 RID: 5362
			// (get) Token: 0x060051E2 RID: 20962 RVA: 0x001729A4 File Offset: 0x00170BA4
			// (set) Token: 0x060051E3 RID: 20963 RVA: 0x0001EC2F File Offset: 0x0001CE2F
			public unsafe DecoderNLS decoder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_decoder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderNLS>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014F3 RID: 5363
			// (get) Token: 0x060051E4 RID: 20964 RVA: 0x001729D4 File Offset: 0x00170BD4
			// (set) Token: 0x060051E5 RID: 20965 RVA: 0x0001EC4E File Offset: 0x0001CE4E
			public unsafe byte* byteStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteStart)) = value;
				}
			}

			// Token: 0x170014F4 RID: 5364
			// (get) Token: 0x060051E6 RID: 20966 RVA: 0x001729F8 File Offset: 0x00170BF8
			// (set) Token: 0x060051E7 RID: 20967 RVA: 0x0001EC69 File Offset: 0x0001CE69
			public unsafe byte* byteEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteEnd)) = value;
				}
			}

			// Token: 0x170014F5 RID: 5365
			// (get) Token: 0x060051E8 RID: 20968 RVA: 0x00172A1C File Offset: 0x00170C1C
			// (set) Token: 0x060051E9 RID: 20969 RVA: 0x0001EC84 File Offset: 0x0001CE84
			public unsafe byte* bytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_bytes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_bytes)) = value;
				}
			}

			// Token: 0x170014F6 RID: 5366
			// (get) Token: 0x060051EA RID: 20970 RVA: 0x00172A40 File Offset: 0x00170C40
			// (set) Token: 0x060051EB RID: 20971 RVA: 0x0001EC9F File Offset: 0x0001CE9F
			public unsafe DecoderFallbackBuffer fallbackBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_fallbackBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderFallbackBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_fallbackBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004284 RID: 17028
			private static readonly IntPtr NativeFieldInfoPtr_chars;

			// Token: 0x04004285 RID: 17029
			private static readonly IntPtr NativeFieldInfoPtr_charStart;

			// Token: 0x04004286 RID: 17030
			private static readonly IntPtr NativeFieldInfoPtr_charEnd;

			// Token: 0x04004287 RID: 17031
			private static readonly IntPtr NativeFieldInfoPtr_charCountResult;

			// Token: 0x04004288 RID: 17032
			private static readonly IntPtr NativeFieldInfoPtr_enc;

			// Token: 0x04004289 RID: 17033
			private static readonly IntPtr NativeFieldInfoPtr_decoder;

			// Token: 0x0400428A RID: 17034
			private static readonly IntPtr NativeFieldInfoPtr_byteStart;

			// Token: 0x0400428B RID: 17035
			private static readonly IntPtr NativeFieldInfoPtr_byteEnd;

			// Token: 0x0400428C RID: 17036
			private static readonly IntPtr NativeFieldInfoPtr_bytes;

			// Token: 0x0400428D RID: 17037
			private static readonly IntPtr NativeFieldInfoPtr_fallbackBuffer;

			// Token: 0x0400428E RID: 17038
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Encoding_DecoderNLS_ptr_Char_Int32_ptr_Byte_Int32_0;

			// Token: 0x0400428F RID: 17039
			private static readonly IntPtr NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_Int32_0;

			// Token: 0x04004290 RID: 17040
			private static readonly IntPtr NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_0;

			// Token: 0x04004291 RID: 17041
			private static readonly IntPtr NativeMethodInfoPtr_AdjustBytes_Internal_Void_Int32_0;

			// Token: 0x04004292 RID: 17042
			private static readonly IntPtr NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0;

			// Token: 0x04004293 RID: 17043
			private static readonly IntPtr NativeMethodInfoPtr_GetNextByte_Internal_Byte_0;

			// Token: 0x04004294 RID: 17044
			private static readonly IntPtr NativeMethodInfoPtr_get_BytesUsed_Internal_get_Int32_0;

			// Token: 0x04004295 RID: 17045
			private static readonly IntPtr NativeMethodInfoPtr_Fallback_Internal_Boolean_Byte_0;

			// Token: 0x04004296 RID: 17046
			private static readonly IntPtr NativeMethodInfoPtr_Fallback_Internal_Boolean_Il2CppStructArray_1_Byte_0;

			// Token: 0x04004297 RID: 17047
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;
		}

		// Token: 0x020005B7 RID: 1463
		public class EncodingByteBuffer : Object
		{
			// Token: 0x060051EC RID: 20972 RVA: 0x00172A70 File Offset: 0x00170C70
			// Note: this type is marked as 'beforefieldinit'.
			static EncodingByteBuffer()
			{
				Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "EncodingByteBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr);
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "bytes");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "byteStart");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "byteEnd");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "chars");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "charStart");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "charEnd");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteCountResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "byteCountResult");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_enc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "enc");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_encoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "encoder");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_fallbackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "fallbackBuffer");
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_EncoderNLS_ptr_Byte_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667572);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667573);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667574);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667575);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667576);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_MovePrevious_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667577);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667578);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_GetNextChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667579);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_CharsUsed_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667580);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667581);
			}

			// Token: 0x060051ED RID: 20973 RVA: 0x00172C2C File Offset: 0x00170E2C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 180111, RefRangeEnd = 180112, XrefRangeStart = 180109, XrefRangeEnd = 180111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncodingByteBuffer(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(inEncoding);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inEncoder);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = inByteStart;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inByteCount;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = inCharStart;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inCharCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_EncoderNLS_ptr_Byte_Int32_ptr_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051EE RID: 20974 RVA: 0x00172CC0 File Offset: 0x00170EC0
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 180112, RefRangeEnd = 180124, XrefRangeStart = 180112, XrefRangeEnd = 180112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddByte(byte b, int moreBytesExpected)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref b;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moreBytesExpected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051EF RID: 20975 RVA: 0x00172D18 File Offset: 0x00170F18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180124, XrefRangeEnd = 180125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddByte(byte b1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref b1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051F0 RID: 20976 RVA: 0x00172D64 File Offset: 0x00170F64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180125, XrefRangeEnd = 180126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddByte(byte b1, byte b2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref b1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051F1 RID: 20977 RVA: 0x00172DBC File Offset: 0x00170FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180126, XrefRangeEnd = 180127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddByte(byte b1, byte b2, int moreBytesExpected)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref b1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moreBytesExpected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051F2 RID: 20978 RVA: 0x00172E24 File Offset: 0x00171024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180127, XrefRangeEnd = 180128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MovePrevious(bool bThrow)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref bThrow;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_MovePrevious_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001504 RID: 5380
			// (get) Token: 0x060051F3 RID: 20979 RVA: 0x00172E64 File Offset: 0x00171064
			public unsafe bool MoreData
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051F4 RID: 20980 RVA: 0x00172EA0 File Offset: 0x001710A0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 180128, RefRangeEnd = 180129, XrefRangeStart = 180128, XrefRangeEnd = 180128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe char GetNextChar()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_GetNextChar_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001505 RID: 5381
			// (get) Token: 0x060051F5 RID: 20981 RVA: 0x00172EDC File Offset: 0x001710DC
			public unsafe int CharsUsed
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_CharsUsed_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001506 RID: 5382
			// (get) Token: 0x060051F6 RID: 20982 RVA: 0x00172F18 File Offset: 0x00171118
			public unsafe int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051F7 RID: 20983 RVA: 0x0001ECBE File Offset: 0x0001CEBE
			public EncodingByteBuffer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014FA RID: 5370
			// (get) Token: 0x060051F8 RID: 20984 RVA: 0x00172F54 File Offset: 0x00171154
			// (set) Token: 0x060051F9 RID: 20985 RVA: 0x0001ECC7 File Offset: 0x0001CEC7
			public unsafe byte* bytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_bytes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_bytes)) = value;
				}
			}

			// Token: 0x170014FB RID: 5371
			// (get) Token: 0x060051FA RID: 20986 RVA: 0x00172F78 File Offset: 0x00171178
			// (set) Token: 0x060051FB RID: 20987 RVA: 0x0001ECE2 File Offset: 0x0001CEE2
			public unsafe byte* byteStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteStart)) = value;
				}
			}

			// Token: 0x170014FC RID: 5372
			// (get) Token: 0x060051FC RID: 20988 RVA: 0x00172F9C File Offset: 0x0017119C
			// (set) Token: 0x060051FD RID: 20989 RVA: 0x0001ECFD File Offset: 0x0001CEFD
			public unsafe byte* byteEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteEnd)) = value;
				}
			}

			// Token: 0x170014FD RID: 5373
			// (get) Token: 0x060051FE RID: 20990 RVA: 0x00172FC0 File Offset: 0x001711C0
			// (set) Token: 0x060051FF RID: 20991 RVA: 0x0001ED18 File Offset: 0x0001CF18
			public unsafe char* chars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_chars);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_chars)) = value;
				}
			}

			// Token: 0x170014FE RID: 5374
			// (get) Token: 0x06005200 RID: 20992 RVA: 0x00172FE4 File Offset: 0x001711E4
			// (set) Token: 0x06005201 RID: 20993 RVA: 0x0001ED33 File Offset: 0x0001CF33
			public unsafe char* charStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charStart)) = value;
				}
			}

			// Token: 0x170014FF RID: 5375
			// (get) Token: 0x06005202 RID: 20994 RVA: 0x00173008 File Offset: 0x00171208
			// (set) Token: 0x06005203 RID: 20995 RVA: 0x0001ED4E File Offset: 0x0001CF4E
			public unsafe char* charEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charEnd)) = value;
				}
			}

			// Token: 0x17001500 RID: 5376
			// (get) Token: 0x06005204 RID: 20996 RVA: 0x0017302C File Offset: 0x0017122C
			// (set) Token: 0x06005205 RID: 20997 RVA: 0x0001ED69 File Offset: 0x0001CF69
			public unsafe int byteCountResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteCountResult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteCountResult)) = value;
				}
			}

			// Token: 0x17001501 RID: 5377
			// (get) Token: 0x06005206 RID: 20998 RVA: 0x00173054 File Offset: 0x00171254
			// (set) Token: 0x06005207 RID: 20999 RVA: 0x0001ED84 File Offset: 0x0001CF84
			public unsafe Encoding enc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_enc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_enc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001502 RID: 5378
			// (get) Token: 0x06005208 RID: 21000 RVA: 0x00173084 File Offset: 0x00171284
			// (set) Token: 0x06005209 RID: 21001 RVA: 0x0001EDA3 File Offset: 0x0001CFA3
			public unsafe EncoderNLS encoder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_encoder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderNLS>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_encoder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001503 RID: 5379
			// (get) Token: 0x0600520A RID: 21002 RVA: 0x001730B4 File Offset: 0x001712B4
			// (set) Token: 0x0600520B RID: 21003 RVA: 0x0001EDC2 File Offset: 0x0001CFC2
			public unsafe EncoderFallbackBuffer fallbackBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_fallbackBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderFallbackBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_fallbackBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004298 RID: 17048
			private static readonly IntPtr NativeFieldInfoPtr_bytes;

			// Token: 0x04004299 RID: 17049
			private static readonly IntPtr NativeFieldInfoPtr_byteStart;

			// Token: 0x0400429A RID: 17050
			private static readonly IntPtr NativeFieldInfoPtr_byteEnd;

			// Token: 0x0400429B RID: 17051
			private static readonly IntPtr NativeFieldInfoPtr_chars;

			// Token: 0x0400429C RID: 17052
			private static readonly IntPtr NativeFieldInfoPtr_charStart;

			// Token: 0x0400429D RID: 17053
			private static readonly IntPtr NativeFieldInfoPtr_charEnd;

			// Token: 0x0400429E RID: 17054
			private static readonly IntPtr NativeFieldInfoPtr_byteCountResult;

			// Token: 0x0400429F RID: 17055
			private static readonly IntPtr NativeFieldInfoPtr_enc;

			// Token: 0x040042A0 RID: 17056
			private static readonly IntPtr NativeFieldInfoPtr_encoder;

			// Token: 0x040042A1 RID: 17057
			private static readonly IntPtr NativeFieldInfoPtr_fallbackBuffer;

			// Token: 0x040042A2 RID: 17058
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Encoding_EncoderNLS_ptr_Byte_Int32_ptr_Char_Int32_0;

			// Token: 0x040042A3 RID: 17059
			private static readonly IntPtr NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Int32_0;

			// Token: 0x040042A4 RID: 17060
			private static readonly IntPtr NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_0;

			// Token: 0x040042A5 RID: 17061
			private static readonly IntPtr NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_0;

			// Token: 0x040042A6 RID: 17062
			private static readonly IntPtr NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_Int32_0;

			// Token: 0x040042A7 RID: 17063
			private static readonly IntPtr NativeMethodInfoPtr_MovePrevious_Internal_Void_Boolean_0;

			// Token: 0x040042A8 RID: 17064
			private static readonly IntPtr NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0;

			// Token: 0x040042A9 RID: 17065
			private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Internal_Char_0;

			// Token: 0x040042AA RID: 17066
			private static readonly IntPtr NativeMethodInfoPtr_get_CharsUsed_Internal_get_Int32_0;

			// Token: 0x040042AB RID: 17067
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;
		}
	}
}
