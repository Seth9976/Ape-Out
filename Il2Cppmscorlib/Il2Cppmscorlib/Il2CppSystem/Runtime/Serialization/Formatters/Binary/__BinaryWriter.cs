using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.IO;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000378 RID: 888
	public sealed class __BinaryWriter : Object
	{
		// Token: 0x06003937 RID: 14647 RVA: 0x00114178 File Offset: 0x00112378
		// Note: this type is marked as 'beforefieldinit'.
		static __BinaryWriter()
		{
			Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "__BinaryWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr);
			__BinaryWriter.NativeFieldInfoPtr_sout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "sout");
			__BinaryWriter.NativeFieldInfoPtr_formatterTypeStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "formatterTypeStyle");
			__BinaryWriter.NativeFieldInfoPtr_objectMapTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "objectMapTable");
			__BinaryWriter.NativeFieldInfoPtr_objectWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "objectWriter");
			__BinaryWriter.NativeFieldInfoPtr_dataWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "dataWriter");
			__BinaryWriter.NativeFieldInfoPtr_m_nestedObjectCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "m_nestedObjectCount");
			__BinaryWriter.NativeFieldInfoPtr_nullCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "nullCount");
			__BinaryWriter.NativeFieldInfoPtr_binaryMethodCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryMethodCall");
			__BinaryWriter.NativeFieldInfoPtr_binaryMethodReturn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryMethodReturn");
			__BinaryWriter.NativeFieldInfoPtr_binaryObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryObject");
			__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryObjectWithMap");
			__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMapTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryObjectWithMapTyped");
			__BinaryWriter.NativeFieldInfoPtr_binaryObjectString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryObjectString");
			__BinaryWriter.NativeFieldInfoPtr_binaryArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryArray");
			__BinaryWriter.NativeFieldInfoPtr_byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "byteBuffer");
			__BinaryWriter.NativeFieldInfoPtr_chunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "chunkSize");
			__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveUnTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "memberPrimitiveUnTyped");
			__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "memberPrimitiveTyped");
			__BinaryWriter.NativeFieldInfoPtr_objectNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "objectNull");
			__BinaryWriter.NativeFieldInfoPtr_memberReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "memberReference");
			__BinaryWriter.NativeFieldInfoPtr_binaryAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryAssembly");
			__BinaryWriter.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectWriter_FormatterTypeStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671997);
			__BinaryWriter.NativeMethodInfoPtr_WriteBegin_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671998);
			__BinaryWriter.NativeMethodInfoPtr_WriteEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671999);
			__BinaryWriter.NativeMethodInfoPtr_WriteBoolean_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672000);
			__BinaryWriter.NativeMethodInfoPtr_WriteByte_Internal_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672001);
			__BinaryWriter.NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672002);
			__BinaryWriter.NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672003);
			__BinaryWriter.NativeMethodInfoPtr_WriteChar_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672004);
			__BinaryWriter.NativeMethodInfoPtr_WriteChars_Internal_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672005);
			__BinaryWriter.NativeMethodInfoPtr_WriteDecimal_Internal_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672006);
			__BinaryWriter.NativeMethodInfoPtr_WriteSingle_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672007);
			__BinaryWriter.NativeMethodInfoPtr_WriteDouble_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672008);
			__BinaryWriter.NativeMethodInfoPtr_WriteInt16_Internal_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672009);
			__BinaryWriter.NativeMethodInfoPtr_WriteInt32_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672010);
			__BinaryWriter.NativeMethodInfoPtr_WriteInt64_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672011);
			__BinaryWriter.NativeMethodInfoPtr_WriteSByte_Internal_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672012);
			__BinaryWriter.NativeMethodInfoPtr_WriteString_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672013);
			__BinaryWriter.NativeMethodInfoPtr_WriteTimeSpan_Internal_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672014);
			__BinaryWriter.NativeMethodInfoPtr_WriteDateTime_Internal_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672015);
			__BinaryWriter.NativeMethodInfoPtr_WriteUInt16_Internal_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672016);
			__BinaryWriter.NativeMethodInfoPtr_WriteUInt32_Internal_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672017);
			__BinaryWriter.NativeMethodInfoPtr_WriteUInt64_Internal_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672018);
			__BinaryWriter.NativeMethodInfoPtr_WriteObjectEnd_Internal_Void_NameInfo_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672019);
			__BinaryWriter.NativeMethodInfoPtr_WriteSerializationHeaderEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672020);
			__BinaryWriter.NativeMethodInfoPtr_WriteSerializationHeader_Internal_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672021);
			__BinaryWriter.NativeMethodInfoPtr_WriteMethodCall_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672022);
			__BinaryWriter.NativeMethodInfoPtr_WriteMethodReturn_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672023);
			__BinaryWriter.NativeMethodInfoPtr_WriteObject_Internal_Void_NameInfo_NameInfo_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672024);
			__BinaryWriter.NativeMethodInfoPtr_WriteObjectString_Internal_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672025);
			__BinaryWriter.NativeMethodInfoPtr_WriteSingleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672026);
			__BinaryWriter.NativeMethodInfoPtr_WriteArrayAsBytes_Private_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672027);
			__BinaryWriter.NativeMethodInfoPtr_WriteJaggedArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672028);
			__BinaryWriter.NativeMethodInfoPtr_WriteRectangleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672029);
			__BinaryWriter.NativeMethodInfoPtr_WriteObjectByteArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672030);
			__BinaryWriter.NativeMethodInfoPtr_WriteMember_Internal_Void_NameInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672031);
			__BinaryWriter.NativeMethodInfoPtr_WriteNullMember_Internal_Void_NameInfo_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672032);
			__BinaryWriter.NativeMethodInfoPtr_WriteMemberObjectRef_Internal_Void_NameInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672033);
			__BinaryWriter.NativeMethodInfoPtr_WriteMemberNested_Internal_Void_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672034);
			__BinaryWriter.NativeMethodInfoPtr_WriteMemberString_Internal_Void_NameInfo_NameInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672035);
			__BinaryWriter.NativeMethodInfoPtr_WriteItem_Internal_Void_NameInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672036);
			__BinaryWriter.NativeMethodInfoPtr_WriteNullItem_Internal_Void_NameInfo_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672037);
			__BinaryWriter.NativeMethodInfoPtr_WriteDelayedNullItem_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672038);
			__BinaryWriter.NativeMethodInfoPtr_WriteItemEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672039);
			__BinaryWriter.NativeMethodInfoPtr_InternalWriteItemNull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672040);
			__BinaryWriter.NativeMethodInfoPtr_WriteItemObjectRef_Internal_Void_NameInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672041);
			__BinaryWriter.NativeMethodInfoPtr_WriteAssembly_Internal_Void_Type_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672042);
			__BinaryWriter.NativeMethodInfoPtr_WriteValue_Internal_Void_InternalPrimitiveTypeE_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100672043);
		}

		// Token: 0x06003938 RID: 14648 RVA: 0x001146F8 File Offset: 0x001128F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216456, XrefRangeEnd = 216461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __BinaryWriter(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectWriter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatterTypeStyle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectWriter_FormatterTypeStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003939 RID: 14649 RVA: 0x00114764 File Offset: 0x00112964
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteBegin_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x00114798 File Offset: 0x00112998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x001147CC File Offset: 0x001129CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216461, XrefRangeEnd = 216462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBoolean(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteBoolean_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x0011480C File Offset: 0x00112A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216462, XrefRangeEnd = 216463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteByte(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteByte_Internal_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x0011484C File Offset: 0x00112A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216463, XrefRangeEnd = 216464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBytes(Il2CppStructArray<byte> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x00114890 File Offset: 0x00112A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216464, XrefRangeEnd = 216465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBytes(Il2CppStructArray<byte> byteA, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(byteA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x001148F0 File Offset: 0x00112AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216465, XrefRangeEnd = 216466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteChar(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteChar_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x00114930 File Offset: 0x00112B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216466, XrefRangeEnd = 216467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteChars(Il2CppStructArray<char> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteChars_Internal_Void_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x00114974 File Offset: 0x00112B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216467, XrefRangeEnd = 216478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDecimal(Decimal value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteDecimal_Internal_Void_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x001149B4 File Offset: 0x00112BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216478, XrefRangeEnd = 216479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSingle(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteSingle_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x001149F4 File Offset: 0x00112BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216479, XrefRangeEnd = 216480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDouble(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteDouble_Internal_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x00114A34 File Offset: 0x00112C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216480, XrefRangeEnd = 216481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInt16(short value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteInt16_Internal_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x00114A74 File Offset: 0x00112C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216481, XrefRangeEnd = 216482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInt32(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteInt32_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x00114AB4 File Offset: 0x00112CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216482, XrefRangeEnd = 216483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInt64(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteInt64_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x00114AF4 File Offset: 0x00112CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSByte(sbyte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteSByte_Internal_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x00114B34 File Offset: 0x00112D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216483, XrefRangeEnd = 216484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteString(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteString_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003949 RID: 14665 RVA: 0x00114B78 File Offset: 0x00112D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteTimeSpan(TimeSpan value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteTimeSpan_Internal_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600394A RID: 14666 RVA: 0x00114BB8 File Offset: 0x00112DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDateTime(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteDateTime_Internal_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x00114BF8 File Offset: 0x00112DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216484, XrefRangeEnd = 216485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteUInt16(ushort value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteUInt16_Internal_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x00114C38 File Offset: 0x00112E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216485, XrefRangeEnd = 216486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteUInt32(uint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteUInt32_Internal_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x00114C78 File Offset: 0x00112E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216486, XrefRangeEnd = 216487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteUInt64(ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteUInt64_Internal_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600394E RID: 14670 RVA: 0x00114CB8 File Offset: 0x00112EB8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteObjectEnd_Internal_Void_NameInfo_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x00114D0C File Offset: 0x00112F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216487, XrefRangeEnd = 216491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSerializationHeaderEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteSerializationHeaderEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x00114D40 File Offset: 0x00112F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216491, XrefRangeEnd = 216495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref topId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minorVersion;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref majorVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteSerializationHeader_Internal_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x00114DA8 File Offset: 0x00112FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216495, XrefRangeEnd = 216500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMethodCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMethodCall_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x00114DDC File Offset: 0x00112FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216500, XrefRangeEnd = 216505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMethodReturn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMethodReturn_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x00114E10 File Offset: 0x00113010
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 216540, RefRangeEnd = 216544, XrefRangeStart = 216505, XrefRangeEnd = 216540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes, Il2CppReferenceArray<WriteObjectInfo> memberObjectInfos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numMembers;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberObjectInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteObject_Internal_Void_NameInfo_NameInfo_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x00114EAC File Offset: 0x001130AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216549, RefRangeEnd = 216550, XrefRangeStart = 216544, XrefRangeEnd = 216549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteObjectString(int objectId, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteObjectString_Internal_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x00114EFC File Offset: 0x001130FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216574, RefRangeEnd = 216576, XrefRangeStart = 216550, XrefRangeEnd = 216574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerBound;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteSingleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x00114FA4 File Offset: 0x001131A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216595, RefRangeEnd = 216596, XrefRangeStart = 216576, XrefRangeEnd = 216595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteArrayAsBytes(Array array, int typeLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteArrayAsBytes_Private_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x00114FF4 File Offset: 0x001131F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216596, XrefRangeEnd = 216610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerBound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteJaggedArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x0011508C File Offset: 0x0011328C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216610, XrefRangeEnd = 216618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, Il2CppStructArray<int> lengthA, Il2CppStructArray<int> lowerBoundA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengthA);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lowerBoundA);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteRectangleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x0011513C File Offset: 0x0011333C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216618, XrefRangeEnd = 216620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Il2CppStructArray<byte> byteA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerBound;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(byteA);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteObjectByteArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x001151E4 File Offset: 0x001133E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216630, RefRangeEnd = 216632, XrefRangeStart = 216620, XrefRangeEnd = 216630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMember_Internal_Void_NameInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600395B RID: 14683 RVA: 0x0011524C File Offset: 0x0011344C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216632, XrefRangeEnd = 216637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteNullMember_Internal_Void_NameInfo_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600395C RID: 14684 RVA: 0x001152A0 File Offset: 0x001134A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216642, RefRangeEnd = 216645, XrefRangeStart = 216637, XrefRangeEnd = 216642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idRef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMemberObjectRef_Internal_Void_NameInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x001152F0 File Offset: 0x001134F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216645, XrefRangeEnd = 216646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMemberNested(NameInfo memberNameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMemberNested_Internal_Void_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600395E RID: 14686 RVA: 0x00115334 File Offset: 0x00113534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216646, XrefRangeEnd = 216649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMemberString_Internal_Void_NameInfo_NameInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x0011539C File Offset: 0x0011359C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216649, XrefRangeEnd = 216651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteItem_Internal_Void_NameInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x00115404 File Offset: 0x00113604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216651, XrefRangeEnd = 216652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteNullItem_Internal_Void_NameInfo_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003961 RID: 14689 RVA: 0x00115458 File Offset: 0x00113658
		[CallerCount(0)]
		public unsafe void WriteDelayedNullItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteDelayedNullItem_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003962 RID: 14690 RVA: 0x0011548C File Offset: 0x0011368C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216652, XrefRangeEnd = 216653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteItemEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteItemEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x001154C0 File Offset: 0x001136C0
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 216658, RefRangeEnd = 216682, XrefRangeStart = 216653, XrefRangeEnd = 216658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteItemNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_InternalWriteItemNull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x001154F4 File Offset: 0x001136F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216682, XrefRangeEnd = 216684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteItemObjectRef(NameInfo nameInfo, int idRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idRef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteItemObjectRef_Internal_Void_NameInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x00115544 File Offset: 0x00113744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216690, RefRangeEnd = 216691, XrefRangeStart = 216684, XrefRangeEnd = 216690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNew;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteAssembly_Internal_Void_Type_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x001155B4 File Offset: 0x001137B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 216806, RefRangeEnd = 216812, XrefRangeStart = 216691, XrefRangeEnd = 216806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteValue(InternalPrimitiveTypeE code, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteValue_Internal_Void_InternalPrimitiveTypeE_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x00014B46 File Offset: 0x00012D46
		public __BinaryWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06003968 RID: 14696 RVA: 0x00115604 File Offset: 0x00113804
		// (set) Token: 0x06003969 RID: 14697 RVA: 0x00014B4F File Offset: 0x00012D4F
		public unsafe Stream sout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_sout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_sout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x0600396A RID: 14698 RVA: 0x00115634 File Offset: 0x00113834
		// (set) Token: 0x0600396B RID: 14699 RVA: 0x00014B6E File Offset: 0x00012D6E
		public unsafe FormatterTypeStyle formatterTypeStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_formatterTypeStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_formatterTypeStyle)) = value;
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x0600396C RID: 14700 RVA: 0x0011565C File Offset: 0x0011385C
		// (set) Token: 0x0600396D RID: 14701 RVA: 0x00014B89 File Offset: 0x00012D89
		public unsafe Hashtable objectMapTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectMapTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectMapTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x0600396E RID: 14702 RVA: 0x0011568C File Offset: 0x0011388C
		// (set) Token: 0x0600396F RID: 14703 RVA: 0x00014BA8 File Offset: 0x00012DA8
		public unsafe ObjectWriter objectWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06003970 RID: 14704 RVA: 0x001156BC File Offset: 0x001138BC
		// (set) Token: 0x06003971 RID: 14705 RVA: 0x00014BC7 File Offset: 0x00012DC7
		public unsafe BinaryWriter dataWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_dataWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_dataWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06003972 RID: 14706 RVA: 0x001156EC File Offset: 0x001138EC
		// (set) Token: 0x06003973 RID: 14707 RVA: 0x00014BE6 File Offset: 0x00012DE6
		public unsafe int m_nestedObjectCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_m_nestedObjectCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_m_nestedObjectCount)) = value;
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06003974 RID: 14708 RVA: 0x00115714 File Offset: 0x00113914
		// (set) Token: 0x06003975 RID: 14709 RVA: 0x00014C01 File Offset: 0x00012E01
		public unsafe int nullCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_nullCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_nullCount)) = value;
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06003976 RID: 14710 RVA: 0x0011573C File Offset: 0x0011393C
		// (set) Token: 0x06003977 RID: 14711 RVA: 0x00014C1C File Offset: 0x00012E1C
		public unsafe BinaryMethodCall binaryMethodCall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryMethodCall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryMethodCall>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryMethodCall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06003978 RID: 14712 RVA: 0x0011576C File Offset: 0x0011396C
		// (set) Token: 0x06003979 RID: 14713 RVA: 0x00014C3B File Offset: 0x00012E3B
		public unsafe BinaryMethodReturn binaryMethodReturn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryMethodReturn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryMethodReturn>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryMethodReturn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x0600397A RID: 14714 RVA: 0x0011579C File Offset: 0x0011399C
		// (set) Token: 0x0600397B RID: 14715 RVA: 0x00014C5A File Offset: 0x00012E5A
		public unsafe BinaryObject binaryObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x0600397C RID: 14716 RVA: 0x001157CC File Offset: 0x001139CC
		// (set) Token: 0x0600397D RID: 14717 RVA: 0x00014C79 File Offset: 0x00012E79
		public unsafe BinaryObjectWithMap binaryObjectWithMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectWithMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x0600397E RID: 14718 RVA: 0x001157FC File Offset: 0x001139FC
		// (set) Token: 0x0600397F RID: 14719 RVA: 0x00014C98 File Offset: 0x00012E98
		public unsafe BinaryObjectWithMapTyped binaryObjectWithMapTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMapTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectWithMapTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMapTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06003980 RID: 14720 RVA: 0x0011582C File Offset: 0x00113A2C
		// (set) Token: 0x06003981 RID: 14721 RVA: 0x00014CB7 File Offset: 0x00012EB7
		public unsafe BinaryObjectString binaryObjectString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectString);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectString), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06003982 RID: 14722 RVA: 0x0011585C File Offset: 0x00113A5C
		// (set) Token: 0x06003983 RID: 14723 RVA: 0x00014CD6 File Offset: 0x00012ED6
		public unsafe BinaryArray binaryArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06003984 RID: 14724 RVA: 0x0011588C File Offset: 0x00113A8C
		// (set) Token: 0x06003985 RID: 14725 RVA: 0x00014CF5 File Offset: 0x00012EF5
		public unsafe Il2CppStructArray<byte> byteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_byteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06003986 RID: 14726 RVA: 0x001158BC File Offset: 0x00113ABC
		// (set) Token: 0x06003987 RID: 14727 RVA: 0x00014D14 File Offset: 0x00012F14
		public unsafe int chunkSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_chunkSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_chunkSize)) = value;
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06003988 RID: 14728 RVA: 0x001158E4 File Offset: 0x00113AE4
		// (set) Token: 0x06003989 RID: 14729 RVA: 0x00014D2F File Offset: 0x00012F2F
		public unsafe MemberPrimitiveUnTyped memberPrimitiveUnTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveUnTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberPrimitiveUnTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveUnTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x0600398A RID: 14730 RVA: 0x00115914 File Offset: 0x00113B14
		// (set) Token: 0x0600398B RID: 14731 RVA: 0x00014D4E File Offset: 0x00012F4E
		public unsafe MemberPrimitiveTyped memberPrimitiveTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberPrimitiveTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x0600398C RID: 14732 RVA: 0x00115944 File Offset: 0x00113B44
		// (set) Token: 0x0600398D RID: 14733 RVA: 0x00014D6D File Offset: 0x00012F6D
		public unsafe ObjectNull objectNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectNull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectNull>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectNull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x0600398E RID: 14734 RVA: 0x00115974 File Offset: 0x00113B74
		// (set) Token: 0x0600398F RID: 14735 RVA: 0x00014D8C File Offset: 0x00012F8C
		public unsafe MemberReference memberReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06003990 RID: 14736 RVA: 0x001159A4 File Offset: 0x00113BA4
		// (set) Token: 0x06003991 RID: 14737 RVA: 0x00014DAB File Offset: 0x00012FAB
		public unsafe BinaryAssembly binaryAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryAssembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400302E RID: 12334
		private static readonly IntPtr NativeFieldInfoPtr_sout;

		// Token: 0x0400302F RID: 12335
		private static readonly IntPtr NativeFieldInfoPtr_formatterTypeStyle;

		// Token: 0x04003030 RID: 12336
		private static readonly IntPtr NativeFieldInfoPtr_objectMapTable;

		// Token: 0x04003031 RID: 12337
		private static readonly IntPtr NativeFieldInfoPtr_objectWriter;

		// Token: 0x04003032 RID: 12338
		private static readonly IntPtr NativeFieldInfoPtr_dataWriter;

		// Token: 0x04003033 RID: 12339
		private static readonly IntPtr NativeFieldInfoPtr_m_nestedObjectCount;

		// Token: 0x04003034 RID: 12340
		private static readonly IntPtr NativeFieldInfoPtr_nullCount;

		// Token: 0x04003035 RID: 12341
		private static readonly IntPtr NativeFieldInfoPtr_binaryMethodCall;

		// Token: 0x04003036 RID: 12342
		private static readonly IntPtr NativeFieldInfoPtr_binaryMethodReturn;

		// Token: 0x04003037 RID: 12343
		private static readonly IntPtr NativeFieldInfoPtr_binaryObject;

		// Token: 0x04003038 RID: 12344
		private static readonly IntPtr NativeFieldInfoPtr_binaryObjectWithMap;

		// Token: 0x04003039 RID: 12345
		private static readonly IntPtr NativeFieldInfoPtr_binaryObjectWithMapTyped;

		// Token: 0x0400303A RID: 12346
		private static readonly IntPtr NativeFieldInfoPtr_binaryObjectString;

		// Token: 0x0400303B RID: 12347
		private static readonly IntPtr NativeFieldInfoPtr_binaryArray;

		// Token: 0x0400303C RID: 12348
		private static readonly IntPtr NativeFieldInfoPtr_byteBuffer;

		// Token: 0x0400303D RID: 12349
		private static readonly IntPtr NativeFieldInfoPtr_chunkSize;

		// Token: 0x0400303E RID: 12350
		private static readonly IntPtr NativeFieldInfoPtr_memberPrimitiveUnTyped;

		// Token: 0x0400303F RID: 12351
		private static readonly IntPtr NativeFieldInfoPtr_memberPrimitiveTyped;

		// Token: 0x04003040 RID: 12352
		private static readonly IntPtr NativeFieldInfoPtr_objectNull;

		// Token: 0x04003041 RID: 12353
		private static readonly IntPtr NativeFieldInfoPtr_memberReference;

		// Token: 0x04003042 RID: 12354
		private static readonly IntPtr NativeFieldInfoPtr_binaryAssembly;

		// Token: 0x04003043 RID: 12355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectWriter_FormatterTypeStyle_0;

		// Token: 0x04003044 RID: 12356
		private static readonly IntPtr NativeMethodInfoPtr_WriteBegin_Internal_Void_0;

		// Token: 0x04003045 RID: 12357
		private static readonly IntPtr NativeMethodInfoPtr_WriteEnd_Internal_Void_0;

		// Token: 0x04003046 RID: 12358
		private static readonly IntPtr NativeMethodInfoPtr_WriteBoolean_Internal_Void_Boolean_0;

		// Token: 0x04003047 RID: 12359
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Internal_Void_Byte_0;

		// Token: 0x04003048 RID: 12360
		private static readonly IntPtr NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003049 RID: 12361
		private static readonly IntPtr NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400304A RID: 12362
		private static readonly IntPtr NativeMethodInfoPtr_WriteChar_Internal_Void_Char_0;

		// Token: 0x0400304B RID: 12363
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Internal_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x0400304C RID: 12364
		private static readonly IntPtr NativeMethodInfoPtr_WriteDecimal_Internal_Void_Decimal_0;

		// Token: 0x0400304D RID: 12365
		private static readonly IntPtr NativeMethodInfoPtr_WriteSingle_Internal_Void_Single_0;

		// Token: 0x0400304E RID: 12366
		private static readonly IntPtr NativeMethodInfoPtr_WriteDouble_Internal_Void_Double_0;

		// Token: 0x0400304F RID: 12367
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt16_Internal_Void_Int16_0;

		// Token: 0x04003050 RID: 12368
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt32_Internal_Void_Int32_0;

		// Token: 0x04003051 RID: 12369
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt64_Internal_Void_Int64_0;

		// Token: 0x04003052 RID: 12370
		private static readonly IntPtr NativeMethodInfoPtr_WriteSByte_Internal_Void_SByte_0;

		// Token: 0x04003053 RID: 12371
		private static readonly IntPtr NativeMethodInfoPtr_WriteString_Internal_Void_String_0;

		// Token: 0x04003054 RID: 12372
		private static readonly IntPtr NativeMethodInfoPtr_WriteTimeSpan_Internal_Void_TimeSpan_0;

		// Token: 0x04003055 RID: 12373
		private static readonly IntPtr NativeMethodInfoPtr_WriteDateTime_Internal_Void_DateTime_0;

		// Token: 0x04003056 RID: 12374
		private static readonly IntPtr NativeMethodInfoPtr_WriteUInt16_Internal_Void_UInt16_0;

		// Token: 0x04003057 RID: 12375
		private static readonly IntPtr NativeMethodInfoPtr_WriteUInt32_Internal_Void_UInt32_0;

		// Token: 0x04003058 RID: 12376
		private static readonly IntPtr NativeMethodInfoPtr_WriteUInt64_Internal_Void_UInt64_0;

		// Token: 0x04003059 RID: 12377
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectEnd_Internal_Void_NameInfo_NameInfo_0;

		// Token: 0x0400305A RID: 12378
		private static readonly IntPtr NativeMethodInfoPtr_WriteSerializationHeaderEnd_Internal_Void_0;

		// Token: 0x0400305B RID: 12379
		private static readonly IntPtr NativeMethodInfoPtr_WriteSerializationHeader_Internal_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400305C RID: 12380
		private static readonly IntPtr NativeMethodInfoPtr_WriteMethodCall_Internal_Void_0;

		// Token: 0x0400305D RID: 12381
		private static readonly IntPtr NativeMethodInfoPtr_WriteMethodReturn_Internal_Void_0;

		// Token: 0x0400305E RID: 12382
		private static readonly IntPtr NativeMethodInfoPtr_WriteObject_Internal_Void_NameInfo_NameInfo_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_WriteObjectInfo_0;

		// Token: 0x0400305F RID: 12383
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectString_Internal_Void_Int32_String_0;

		// Token: 0x04003060 RID: 12384
		private static readonly IntPtr NativeMethodInfoPtr_WriteSingleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Array_0;

		// Token: 0x04003061 RID: 12385
		private static readonly IntPtr NativeMethodInfoPtr_WriteArrayAsBytes_Private_Void_Array_Int32_0;

		// Token: 0x04003062 RID: 12386
		private static readonly IntPtr NativeMethodInfoPtr_WriteJaggedArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_0;

		// Token: 0x04003063 RID: 12387
		private static readonly IntPtr NativeMethodInfoPtr_WriteRectangleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003064 RID: 12388
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectByteArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003065 RID: 12389
		private static readonly IntPtr NativeMethodInfoPtr_WriteMember_Internal_Void_NameInfo_NameInfo_Object_0;

		// Token: 0x04003066 RID: 12390
		private static readonly IntPtr NativeMethodInfoPtr_WriteNullMember_Internal_Void_NameInfo_NameInfo_0;

		// Token: 0x04003067 RID: 12391
		private static readonly IntPtr NativeMethodInfoPtr_WriteMemberObjectRef_Internal_Void_NameInfo_Int32_0;

		// Token: 0x04003068 RID: 12392
		private static readonly IntPtr NativeMethodInfoPtr_WriteMemberNested_Internal_Void_NameInfo_0;

		// Token: 0x04003069 RID: 12393
		private static readonly IntPtr NativeMethodInfoPtr_WriteMemberString_Internal_Void_NameInfo_NameInfo_String_0;

		// Token: 0x0400306A RID: 12394
		private static readonly IntPtr NativeMethodInfoPtr_WriteItem_Internal_Void_NameInfo_NameInfo_Object_0;

		// Token: 0x0400306B RID: 12395
		private static readonly IntPtr NativeMethodInfoPtr_WriteNullItem_Internal_Void_NameInfo_NameInfo_0;

		// Token: 0x0400306C RID: 12396
		private static readonly IntPtr NativeMethodInfoPtr_WriteDelayedNullItem_Internal_Void_0;

		// Token: 0x0400306D RID: 12397
		private static readonly IntPtr NativeMethodInfoPtr_WriteItemEnd_Internal_Void_0;

		// Token: 0x0400306E RID: 12398
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteItemNull_Private_Void_0;

		// Token: 0x0400306F RID: 12399
		private static readonly IntPtr NativeMethodInfoPtr_WriteItemObjectRef_Internal_Void_NameInfo_Int32_0;

		// Token: 0x04003070 RID: 12400
		private static readonly IntPtr NativeMethodInfoPtr_WriteAssembly_Internal_Void_Type_String_Int32_Boolean_0;

		// Token: 0x04003071 RID: 12401
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Internal_Void_InternalPrimitiveTypeE_Object_0;
	}
}
