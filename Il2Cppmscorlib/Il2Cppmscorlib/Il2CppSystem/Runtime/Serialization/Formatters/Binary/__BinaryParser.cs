using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000381 RID: 897
	public sealed class __BinaryParser : Object
	{
		// Token: 0x06003AD2 RID: 15058 RVA: 0x0011A5CC File Offset: 0x001187CC
		// Note: this type is marked as 'beforefieldinit'.
		static __BinaryParser()
		{
			Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "__BinaryParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr);
			__BinaryParser.NativeFieldInfoPtr_objectReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "objectReader");
			__BinaryParser.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "input");
			__BinaryParser.NativeFieldInfoPtr_topId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "topId");
			__BinaryParser.NativeFieldInfoPtr_headerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "headerId");
			__BinaryParser.NativeFieldInfoPtr_objectMapIdTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "objectMapIdTable");
			__BinaryParser.NativeFieldInfoPtr_assemIdToAssemblyTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "assemIdToAssemblyTable");
			__BinaryParser.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "stack");
			__BinaryParser.NativeFieldInfoPtr_expectedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "expectedType");
			__BinaryParser.NativeFieldInfoPtr_expectedTypeInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "expectedTypeInformation");
			__BinaryParser.NativeFieldInfoPtr_PRS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "PRS");
			__BinaryParser.NativeFieldInfoPtr_systemAssemblyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "systemAssemblyInfo");
			__BinaryParser.NativeFieldInfoPtr_dataReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "dataReader");
			__BinaryParser.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "encoding");
			__BinaryParser.NativeFieldInfoPtr_opPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "opPool");
			__BinaryParser.NativeFieldInfoPtr_binaryObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "binaryObject");
			__BinaryParser.NativeFieldInfoPtr_bowm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "bowm");
			__BinaryParser.NativeFieldInfoPtr_bowmt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "bowmt");
			__BinaryParser.NativeFieldInfoPtr_objectString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "objectString");
			__BinaryParser.NativeFieldInfoPtr_crossAppDomainString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "crossAppDomainString");
			__BinaryParser.NativeFieldInfoPtr_memberPrimitiveTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "memberPrimitiveTyped");
			__BinaryParser.NativeFieldInfoPtr_byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "byteBuffer");
			__BinaryParser.NativeFieldInfoPtr_memberPrimitiveUnTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "memberPrimitiveUnTyped");
			__BinaryParser.NativeFieldInfoPtr_memberReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "memberReference");
			__BinaryParser.NativeFieldInfoPtr_objectNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "objectNull");
			__BinaryParser.NativeFieldInfoPtr_messageEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "messageEnd");
			__BinaryParser.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672159);
			__BinaryParser.NativeMethodInfoPtr_get_SystemAssemblyInfo_Internal_get_BinaryAssemblyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672160);
			__BinaryParser.NativeMethodInfoPtr_get_ObjectMapIdTable_Internal_get_SizedArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672161);
			__BinaryParser.NativeMethodInfoPtr_get_AssemIdToAssemblyTable_Internal_get_SizedArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672162);
			__BinaryParser.NativeMethodInfoPtr_get_prs_Internal_get_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672163);
			__BinaryParser.NativeMethodInfoPtr_Run_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672164);
			__BinaryParser.NativeMethodInfoPtr_ReadBegin_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672165);
			__BinaryParser.NativeMethodInfoPtr_ReadEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672166);
			__BinaryParser.NativeMethodInfoPtr_ReadBoolean_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672167);
			__BinaryParser.NativeMethodInfoPtr_ReadByte_Internal_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672168);
			__BinaryParser.NativeMethodInfoPtr_ReadBytes_Internal_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672169);
			__BinaryParser.NativeMethodInfoPtr_ReadBytes_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672170);
			__BinaryParser.NativeMethodInfoPtr_ReadChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672171);
			__BinaryParser.NativeMethodInfoPtr_ReadChars_Internal_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672172);
			__BinaryParser.NativeMethodInfoPtr_ReadDecimal_Internal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672173);
			__BinaryParser.NativeMethodInfoPtr_ReadSingle_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672174);
			__BinaryParser.NativeMethodInfoPtr_ReadDouble_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672175);
			__BinaryParser.NativeMethodInfoPtr_ReadInt16_Internal_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672176);
			__BinaryParser.NativeMethodInfoPtr_ReadInt32_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672177);
			__BinaryParser.NativeMethodInfoPtr_ReadInt64_Internal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672178);
			__BinaryParser.NativeMethodInfoPtr_ReadSByte_Internal_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672179);
			__BinaryParser.NativeMethodInfoPtr_ReadString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672180);
			__BinaryParser.NativeMethodInfoPtr_ReadTimeSpan_Internal_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672181);
			__BinaryParser.NativeMethodInfoPtr_ReadDateTime_Internal_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672182);
			__BinaryParser.NativeMethodInfoPtr_ReadUInt16_Internal_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672183);
			__BinaryParser.NativeMethodInfoPtr_ReadUInt32_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672184);
			__BinaryParser.NativeMethodInfoPtr_ReadUInt64_Internal_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672185);
			__BinaryParser.NativeMethodInfoPtr_ReadSerializationHeaderRecord_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672186);
			__BinaryParser.NativeMethodInfoPtr_ReadAssembly_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672187);
			__BinaryParser.NativeMethodInfoPtr_ReadObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672188);
			__BinaryParser.NativeMethodInfoPtr_ReadCrossAppDomainMap_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672189);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMap_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672190);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMap_Private_Void_BinaryObjectWithMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672191);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMapTyped_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672192);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMapTyped_Private_Void_BinaryObjectWithMapTyped_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672193);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectString_Private_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672194);
			__BinaryParser.NativeMethodInfoPtr_ReadMemberPrimitiveTyped_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672195);
			__BinaryParser.NativeMethodInfoPtr_ReadArray_Private_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672196);
			__BinaryParser.NativeMethodInfoPtr_ReadArrayAsBytes_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672197);
			__BinaryParser.NativeMethodInfoPtr_ReadMemberPrimitiveUnTyped_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672198);
			__BinaryParser.NativeMethodInfoPtr_ReadMemberReference_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672199);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectNull_Private_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672200);
			__BinaryParser.NativeMethodInfoPtr_ReadMessageEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672201);
			__BinaryParser.NativeMethodInfoPtr_ReadValue_Internal_Object_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672202);
			__BinaryParser.NativeMethodInfoPtr_GetOp_Private_ObjectProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672203);
			__BinaryParser.NativeMethodInfoPtr_PutOp_Private_Void_ObjectProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672204);
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x0011AB88 File Offset: 0x00118D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217901, RefRangeEnd = 217902, XrefRangeStart = 217887, XrefRangeEnd = 217901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __BinaryParser(Stream stream, ObjectReader objectReader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectReader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06003AD4 RID: 15060 RVA: 0x0011ABE8 File Offset: 0x00118DE8
		public unsafe BinaryAssemblyInfo SystemAssemblyInfo
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 217909, RefRangeEnd = 217912, XrefRangeStart = 217902, XrefRangeEnd = 217909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_get_SystemAssemblyInfo_Internal_get_BinaryAssemblyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BinaryAssemblyInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06003AD5 RID: 15061 RVA: 0x0011AC28 File Offset: 0x00118E28
		public unsafe SizedArray ObjectMapIdTable
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 217920, RefRangeEnd = 217923, XrefRangeStart = 217912, XrefRangeEnd = 217920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_get_ObjectMapIdTable_Internal_get_SizedArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SizedArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06003AD6 RID: 15062 RVA: 0x0011AC68 File Offset: 0x00118E68
		public unsafe SizedArray AssemIdToAssemblyTable
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 217931, RefRangeEnd = 217936, XrefRangeStart = 217923, XrefRangeEnd = 217931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_get_AssemIdToAssemblyTable_Internal_get_SizedArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SizedArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06003AD7 RID: 15063 RVA: 0x0011ACA8 File Offset: 0x00118EA8
		public unsafe ParseRecord prs
		{
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 217939, RefRangeEnd = 218008, XrefRangeStart = 217936, XrefRangeEnd = 217939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_get_prs_Internal_get_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParseRecord>(intPtr3) : null;
			}
		}

		// Token: 0x06003AD8 RID: 15064 RVA: 0x0011ACE8 File Offset: 0x00118EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218060, RefRangeEnd = 218061, XrefRangeStart = 218008, XrefRangeEnd = 218060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_Run_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AD9 RID: 15065 RVA: 0x0011AD1C File Offset: 0x00118F1C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadBegin_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x0011AD50 File Offset: 0x00118F50
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x0011AD84 File Offset: 0x00118F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218061, XrefRangeEnd = 218062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadBoolean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadBoolean_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x0011ADC0 File Offset: 0x00118FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218062, XrefRangeEnd = 218063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadByte_Internal_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x0011ADFC File Offset: 0x00118FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218063, XrefRangeEnd = 218064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ReadBytes(int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadBytes_Internal_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x0011AE48 File Offset: 0x00119048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218064, RefRangeEnd = 218065, XrefRangeStart = 218064, XrefRangeEnd = 218064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadBytes(Il2CppStructArray<byte> byteA, int offset, int size)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadBytes_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x0011AEA8 File Offset: 0x001190A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218065, XrefRangeEnd = 218066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ReadChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadChar_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x0011AEE4 File Offset: 0x001190E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218066, XrefRangeEnd = 218067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<char> ReadChars(int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadChars_Internal_Il2CppStructArray_1_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x06003AE1 RID: 15073 RVA: 0x0011AF30 File Offset: 0x00119130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218067, XrefRangeEnd = 218080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal ReadDecimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadDecimal_Internal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AE2 RID: 15074 RVA: 0x0011AF6C File Offset: 0x0011916C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218080, XrefRangeEnd = 218081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ReadSingle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadSingle_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AE3 RID: 15075 RVA: 0x0011AFA8 File Offset: 0x001191A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218081, XrefRangeEnd = 218082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double ReadDouble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadDouble_Internal_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AE4 RID: 15076 RVA: 0x0011AFE4 File Offset: 0x001191E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218082, XrefRangeEnd = 218083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short ReadInt16()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadInt16_Internal_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x0011B020 File Offset: 0x00119220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218083, XrefRangeEnd = 218084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadInt32_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x0011B05C File Offset: 0x0011925C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218084, XrefRangeEnd = 218085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long ReadInt64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadInt64_Internal_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x0011B098 File Offset: 0x00119298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte ReadSByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadSByte_Internal_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x0011B0D4 File Offset: 0x001192D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218085, XrefRangeEnd = 218086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x0011B10C File Offset: 0x0011930C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan ReadTimeSpan()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadTimeSpan_Internal_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AEA RID: 15082 RVA: 0x0011B148 File Offset: 0x00119348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218086, XrefRangeEnd = 218091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ReadDateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadDateTime_Internal_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AEB RID: 15083 RVA: 0x0011B184 File Offset: 0x00119384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218091, XrefRangeEnd = 218092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort ReadUInt16()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadUInt16_Internal_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x0011B1C0 File Offset: 0x001193C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218092, XrefRangeEnd = 218093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint ReadUInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadUInt32_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AED RID: 15085 RVA: 0x0011B1FC File Offset: 0x001193FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218093, XrefRangeEnd = 218094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong ReadUInt64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadUInt64_Internal_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AEE RID: 15086 RVA: 0x0011B238 File Offset: 0x00119438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218094, XrefRangeEnd = 218100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadSerializationHeaderRecord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadSerializationHeaderRecord_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AEF RID: 15087 RVA: 0x0011B26C File Offset: 0x0011946C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218138, RefRangeEnd = 218139, XrefRangeStart = 218100, XrefRangeEnd = 218138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadAssembly_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AF0 RID: 15088 RVA: 0x0011B2AC File Offset: 0x001194AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218198, RefRangeEnd = 218199, XrefRangeStart = 218139, XrefRangeEnd = 218198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AF1 RID: 15089 RVA: 0x0011B2E0 File Offset: 0x001194E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218226, RefRangeEnd = 218227, XrefRangeStart = 218199, XrefRangeEnd = 218226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadCrossAppDomainMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadCrossAppDomainMap_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AF2 RID: 15090 RVA: 0x0011B314 File Offset: 0x00119514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218234, RefRangeEnd = 218235, XrefRangeStart = 218227, XrefRangeEnd = 218234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMap_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AF3 RID: 15091 RVA: 0x0011B354 File Offset: 0x00119554
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218316, RefRangeEnd = 218318, XrefRangeStart = 218235, XrefRangeEnd = 218316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectWithMap(BinaryObjectWithMap record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMap_Private_Void_BinaryObjectWithMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x0011B398 File Offset: 0x00119598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218325, RefRangeEnd = 218326, XrefRangeStart = 218318, XrefRangeEnd = 218325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMapTyped_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x0011B3D8 File Offset: 0x001195D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218407, RefRangeEnd = 218409, XrefRangeStart = 218326, XrefRangeEnd = 218407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMapTyped_Private_Void_BinaryObjectWithMapTyped_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x0011B41C File Offset: 0x0011961C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218499, RefRangeEnd = 218500, XrefRangeStart = 218409, XrefRangeEnd = 218499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectString_Private_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x0011B45C File Offset: 0x0011965C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218554, RefRangeEnd = 218555, XrefRangeStart = 218500, XrefRangeEnd = 218554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadMemberPrimitiveTyped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadMemberPrimitiveTyped_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x0011B490 File Offset: 0x00119690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218591, RefRangeEnd = 218592, XrefRangeStart = 218555, XrefRangeEnd = 218591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadArray(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadArray_Private_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x0011B4D0 File Offset: 0x001196D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218620, RefRangeEnd = 218621, XrefRangeStart = 218592, XrefRangeEnd = 218620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadArrayAsBytes(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadArrayAsBytes_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x0011B514 File Offset: 0x00119714
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218655, RefRangeEnd = 218656, XrefRangeStart = 218621, XrefRangeEnd = 218655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadMemberPrimitiveUnTyped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadMemberPrimitiveUnTyped_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x0011B548 File Offset: 0x00119748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218679, RefRangeEnd = 218680, XrefRangeStart = 218656, XrefRangeEnd = 218679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadMemberReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadMemberReference_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x0011B57C File Offset: 0x0011977C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218704, RefRangeEnd = 218705, XrefRangeStart = 218680, XrefRangeEnd = 218704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectNull_Private_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x0011B5BC File Offset: 0x001197BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218719, RefRangeEnd = 218720, XrefRangeStart = 218705, XrefRangeEnd = 218719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadMessageEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadMessageEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x0011B5F0 File Offset: 0x001197F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 218782, RefRangeEnd = 218786, XrefRangeStart = 218720, XrefRangeEnd = 218782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadValue(InternalPrimitiveTypeE code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadValue_Internal_Object_InternalPrimitiveTypeE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x0011B63C File Offset: 0x0011983C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 218790, RefRangeEnd = 218794, XrefRangeStart = 218786, XrefRangeEnd = 218790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectProgress GetOp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_GetOp_Private_ObjectProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectProgress>(intPtr3) : null;
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x0011B67C File Offset: 0x0011987C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218807, RefRangeEnd = 218809, XrefRangeStart = 218794, XrefRangeEnd = 218807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PutOp(ObjectProgress op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_PutOp_Private_Void_ObjectProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x00015971 File Offset: 0x00013B71
		public __BinaryParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06003B02 RID: 15106 RVA: 0x0011B6C0 File Offset: 0x001198C0
		// (set) Token: 0x06003B03 RID: 15107 RVA: 0x0001597A File Offset: 0x00013B7A
		public unsafe ObjectReader objectReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06003B04 RID: 15108 RVA: 0x0011B6F0 File Offset: 0x001198F0
		// (set) Token: 0x06003B05 RID: 15109 RVA: 0x00015999 File Offset: 0x00013B99
		public unsafe Stream input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06003B06 RID: 15110 RVA: 0x0011B720 File Offset: 0x00119920
		// (set) Token: 0x06003B07 RID: 15111 RVA: 0x000159B8 File Offset: 0x00013BB8
		public unsafe long topId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_topId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_topId)) = value;
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06003B08 RID: 15112 RVA: 0x0011B748 File Offset: 0x00119948
		// (set) Token: 0x06003B09 RID: 15113 RVA: 0x000159D3 File Offset: 0x00013BD3
		public unsafe long headerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_headerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_headerId)) = value;
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06003B0A RID: 15114 RVA: 0x0011B770 File Offset: 0x00119970
		// (set) Token: 0x06003B0B RID: 15115 RVA: 0x000159EE File Offset: 0x00013BEE
		public unsafe SizedArray objectMapIdTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectMapIdTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SizedArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectMapIdTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06003B0C RID: 15116 RVA: 0x0011B7A0 File Offset: 0x001199A0
		// (set) Token: 0x06003B0D RID: 15117 RVA: 0x00015A0D File Offset: 0x00013C0D
		public unsafe SizedArray assemIdToAssemblyTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_assemIdToAssemblyTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SizedArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_assemIdToAssemblyTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06003B0E RID: 15118 RVA: 0x0011B7D0 File Offset: 0x001199D0
		// (set) Token: 0x06003B0F RID: 15119 RVA: 0x00015A2C File Offset: 0x00013C2C
		public unsafe SerStack stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06003B10 RID: 15120 RVA: 0x0011B800 File Offset: 0x00119A00
		// (set) Token: 0x06003B11 RID: 15121 RVA: 0x00015A4B File Offset: 0x00013C4B
		public unsafe BinaryTypeEnum expectedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_expectedType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_expectedType)) = value;
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06003B12 RID: 15122 RVA: 0x0011B828 File Offset: 0x00119A28
		// (set) Token: 0x06003B13 RID: 15123 RVA: 0x00015A66 File Offset: 0x00013C66
		public unsafe Object expectedTypeInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_expectedTypeInformation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_expectedTypeInformation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06003B14 RID: 15124 RVA: 0x0011B858 File Offset: 0x00119A58
		// (set) Token: 0x06003B15 RID: 15125 RVA: 0x00015A85 File Offset: 0x00013C85
		public unsafe ParseRecord PRS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_PRS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParseRecord>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_PRS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06003B16 RID: 15126 RVA: 0x0011B888 File Offset: 0x00119A88
		// (set) Token: 0x06003B17 RID: 15127 RVA: 0x00015AA4 File Offset: 0x00013CA4
		public unsafe BinaryAssemblyInfo systemAssemblyInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_systemAssemblyInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryAssemblyInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_systemAssemblyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06003B18 RID: 15128 RVA: 0x0011B8B8 File Offset: 0x00119AB8
		// (set) Token: 0x06003B19 RID: 15129 RVA: 0x00015AC3 File Offset: 0x00013CC3
		public unsafe BinaryReader dataReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_dataReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_dataReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06003B1A RID: 15130 RVA: 0x0011B8E8 File Offset: 0x00119AE8
		// (set) Token: 0x06003B1B RID: 15131 RVA: 0x00015AE2 File Offset: 0x00013CE2
		public unsafe static Encoding encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(__BinaryParser.NativeFieldInfoPtr_encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(__BinaryParser.NativeFieldInfoPtr_encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06003B1C RID: 15132 RVA: 0x0011B910 File Offset: 0x00119B10
		// (set) Token: 0x06003B1D RID: 15133 RVA: 0x00015AF4 File Offset: 0x00013CF4
		public unsafe SerStack opPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_opPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_opPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06003B1E RID: 15134 RVA: 0x0011B940 File Offset: 0x00119B40
		// (set) Token: 0x06003B1F RID: 15135 RVA: 0x00015B13 File Offset: 0x00013D13
		public unsafe BinaryObject binaryObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_binaryObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_binaryObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06003B20 RID: 15136 RVA: 0x0011B970 File Offset: 0x00119B70
		// (set) Token: 0x06003B21 RID: 15137 RVA: 0x00015B32 File Offset: 0x00013D32
		public unsafe BinaryObjectWithMap bowm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_bowm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectWithMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_bowm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06003B22 RID: 15138 RVA: 0x0011B9A0 File Offset: 0x00119BA0
		// (set) Token: 0x06003B23 RID: 15139 RVA: 0x00015B51 File Offset: 0x00013D51
		public unsafe BinaryObjectWithMapTyped bowmt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_bowmt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectWithMapTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_bowmt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06003B24 RID: 15140 RVA: 0x0011B9D0 File Offset: 0x00119BD0
		// (set) Token: 0x06003B25 RID: 15141 RVA: 0x00015B70 File Offset: 0x00013D70
		public unsafe BinaryObjectString objectString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectString);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectString), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06003B26 RID: 15142 RVA: 0x0011BA00 File Offset: 0x00119C00
		// (set) Token: 0x06003B27 RID: 15143 RVA: 0x00015B8F File Offset: 0x00013D8F
		public unsafe BinaryCrossAppDomainString crossAppDomainString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_crossAppDomainString);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryCrossAppDomainString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_crossAppDomainString), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06003B28 RID: 15144 RVA: 0x0011BA30 File Offset: 0x00119C30
		// (set) Token: 0x06003B29 RID: 15145 RVA: 0x00015BAE File Offset: 0x00013DAE
		public unsafe MemberPrimitiveTyped memberPrimitiveTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberPrimitiveTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberPrimitiveTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberPrimitiveTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06003B2A RID: 15146 RVA: 0x0011BA60 File Offset: 0x00119C60
		// (set) Token: 0x06003B2B RID: 15147 RVA: 0x00015BCD File Offset: 0x00013DCD
		public unsafe Il2CppStructArray<byte> byteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_byteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06003B2C RID: 15148 RVA: 0x0011BA90 File Offset: 0x00119C90
		// (set) Token: 0x06003B2D RID: 15149 RVA: 0x00015BEC File Offset: 0x00013DEC
		public unsafe MemberPrimitiveUnTyped memberPrimitiveUnTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberPrimitiveUnTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberPrimitiveUnTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberPrimitiveUnTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06003B2E RID: 15150 RVA: 0x0011BAC0 File Offset: 0x00119CC0
		// (set) Token: 0x06003B2F RID: 15151 RVA: 0x00015C0B File Offset: 0x00013E0B
		public unsafe MemberReference memberReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06003B30 RID: 15152 RVA: 0x0011BAF0 File Offset: 0x00119CF0
		// (set) Token: 0x06003B31 RID: 15153 RVA: 0x00015C2A File Offset: 0x00013E2A
		public unsafe ObjectNull objectNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectNull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectNull>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectNull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06003B32 RID: 15154 RVA: 0x0011BB20 File Offset: 0x00119D20
		// (set) Token: 0x06003B33 RID: 15155 RVA: 0x00015C49 File Offset: 0x00013E49
		public unsafe static MessageEnd messageEnd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(__BinaryParser.NativeFieldInfoPtr_messageEnd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageEnd>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(__BinaryParser.NativeFieldInfoPtr_messageEnd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003142 RID: 12610
		private static readonly IntPtr NativeFieldInfoPtr_objectReader;

		// Token: 0x04003143 RID: 12611
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x04003144 RID: 12612
		private static readonly IntPtr NativeFieldInfoPtr_topId;

		// Token: 0x04003145 RID: 12613
		private static readonly IntPtr NativeFieldInfoPtr_headerId;

		// Token: 0x04003146 RID: 12614
		private static readonly IntPtr NativeFieldInfoPtr_objectMapIdTable;

		// Token: 0x04003147 RID: 12615
		private static readonly IntPtr NativeFieldInfoPtr_assemIdToAssemblyTable;

		// Token: 0x04003148 RID: 12616
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x04003149 RID: 12617
		private static readonly IntPtr NativeFieldInfoPtr_expectedType;

		// Token: 0x0400314A RID: 12618
		private static readonly IntPtr NativeFieldInfoPtr_expectedTypeInformation;

		// Token: 0x0400314B RID: 12619
		private static readonly IntPtr NativeFieldInfoPtr_PRS;

		// Token: 0x0400314C RID: 12620
		private static readonly IntPtr NativeFieldInfoPtr_systemAssemblyInfo;

		// Token: 0x0400314D RID: 12621
		private static readonly IntPtr NativeFieldInfoPtr_dataReader;

		// Token: 0x0400314E RID: 12622
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x0400314F RID: 12623
		private static readonly IntPtr NativeFieldInfoPtr_opPool;

		// Token: 0x04003150 RID: 12624
		private static readonly IntPtr NativeFieldInfoPtr_binaryObject;

		// Token: 0x04003151 RID: 12625
		private static readonly IntPtr NativeFieldInfoPtr_bowm;

		// Token: 0x04003152 RID: 12626
		private static readonly IntPtr NativeFieldInfoPtr_bowmt;

		// Token: 0x04003153 RID: 12627
		private static readonly IntPtr NativeFieldInfoPtr_objectString;

		// Token: 0x04003154 RID: 12628
		private static readonly IntPtr NativeFieldInfoPtr_crossAppDomainString;

		// Token: 0x04003155 RID: 12629
		private static readonly IntPtr NativeFieldInfoPtr_memberPrimitiveTyped;

		// Token: 0x04003156 RID: 12630
		private static readonly IntPtr NativeFieldInfoPtr_byteBuffer;

		// Token: 0x04003157 RID: 12631
		private static readonly IntPtr NativeFieldInfoPtr_memberPrimitiveUnTyped;

		// Token: 0x04003158 RID: 12632
		private static readonly IntPtr NativeFieldInfoPtr_memberReference;

		// Token: 0x04003159 RID: 12633
		private static readonly IntPtr NativeFieldInfoPtr_objectNull;

		// Token: 0x0400315A RID: 12634
		private static readonly IntPtr NativeFieldInfoPtr_messageEnd;

		// Token: 0x0400315B RID: 12635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectReader_0;

		// Token: 0x0400315C RID: 12636
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemAssemblyInfo_Internal_get_BinaryAssemblyInfo_0;

		// Token: 0x0400315D RID: 12637
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectMapIdTable_Internal_get_SizedArray_0;

		// Token: 0x0400315E RID: 12638
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemIdToAssemblyTable_Internal_get_SizedArray_0;

		// Token: 0x0400315F RID: 12639
		private static readonly IntPtr NativeMethodInfoPtr_get_prs_Internal_get_ParseRecord_0;

		// Token: 0x04003160 RID: 12640
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Void_0;

		// Token: 0x04003161 RID: 12641
		private static readonly IntPtr NativeMethodInfoPtr_ReadBegin_Internal_Void_0;

		// Token: 0x04003162 RID: 12642
		private static readonly IntPtr NativeMethodInfoPtr_ReadEnd_Internal_Void_0;

		// Token: 0x04003163 RID: 12643
		private static readonly IntPtr NativeMethodInfoPtr_ReadBoolean_Internal_Boolean_0;

		// Token: 0x04003164 RID: 12644
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Internal_Byte_0;

		// Token: 0x04003165 RID: 12645
		private static readonly IntPtr NativeMethodInfoPtr_ReadBytes_Internal_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04003166 RID: 12646
		private static readonly IntPtr NativeMethodInfoPtr_ReadBytes_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04003167 RID: 12647
		private static readonly IntPtr NativeMethodInfoPtr_ReadChar_Internal_Char_0;

		// Token: 0x04003168 RID: 12648
		private static readonly IntPtr NativeMethodInfoPtr_ReadChars_Internal_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04003169 RID: 12649
		private static readonly IntPtr NativeMethodInfoPtr_ReadDecimal_Internal_Decimal_0;

		// Token: 0x0400316A RID: 12650
		private static readonly IntPtr NativeMethodInfoPtr_ReadSingle_Internal_Single_0;

		// Token: 0x0400316B RID: 12651
		private static readonly IntPtr NativeMethodInfoPtr_ReadDouble_Internal_Double_0;

		// Token: 0x0400316C RID: 12652
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt16_Internal_Int16_0;

		// Token: 0x0400316D RID: 12653
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt32_Internal_Int32_0;

		// Token: 0x0400316E RID: 12654
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt64_Internal_Int64_0;

		// Token: 0x0400316F RID: 12655
		private static readonly IntPtr NativeMethodInfoPtr_ReadSByte_Internal_SByte_0;

		// Token: 0x04003170 RID: 12656
		private static readonly IntPtr NativeMethodInfoPtr_ReadString_Internal_String_0;

		// Token: 0x04003171 RID: 12657
		private static readonly IntPtr NativeMethodInfoPtr_ReadTimeSpan_Internal_TimeSpan_0;

		// Token: 0x04003172 RID: 12658
		private static readonly IntPtr NativeMethodInfoPtr_ReadDateTime_Internal_DateTime_0;

		// Token: 0x04003173 RID: 12659
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt16_Internal_UInt16_0;

		// Token: 0x04003174 RID: 12660
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt32_Internal_UInt32_0;

		// Token: 0x04003175 RID: 12661
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt64_Internal_UInt64_0;

		// Token: 0x04003176 RID: 12662
		private static readonly IntPtr NativeMethodInfoPtr_ReadSerializationHeaderRecord_Internal_Void_0;

		// Token: 0x04003177 RID: 12663
		private static readonly IntPtr NativeMethodInfoPtr_ReadAssembly_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x04003178 RID: 12664
		private static readonly IntPtr NativeMethodInfoPtr_ReadObject_Private_Void_0;

		// Token: 0x04003179 RID: 12665
		private static readonly IntPtr NativeMethodInfoPtr_ReadCrossAppDomainMap_Internal_Void_0;

		// Token: 0x0400317A RID: 12666
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectWithMap_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x0400317B RID: 12667
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectWithMap_Private_Void_BinaryObjectWithMap_0;

		// Token: 0x0400317C RID: 12668
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectWithMapTyped_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x0400317D RID: 12669
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectWithMapTyped_Private_Void_BinaryObjectWithMapTyped_0;

		// Token: 0x0400317E RID: 12670
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectString_Private_Void_BinaryHeaderEnum_0;

		// Token: 0x0400317F RID: 12671
		private static readonly IntPtr NativeMethodInfoPtr_ReadMemberPrimitiveTyped_Private_Void_0;

		// Token: 0x04003180 RID: 12672
		private static readonly IntPtr NativeMethodInfoPtr_ReadArray_Private_Void_BinaryHeaderEnum_0;

		// Token: 0x04003181 RID: 12673
		private static readonly IntPtr NativeMethodInfoPtr_ReadArrayAsBytes_Private_Void_ParseRecord_0;

		// Token: 0x04003182 RID: 12674
		private static readonly IntPtr NativeMethodInfoPtr_ReadMemberPrimitiveUnTyped_Private_Void_0;

		// Token: 0x04003183 RID: 12675
		private static readonly IntPtr NativeMethodInfoPtr_ReadMemberReference_Private_Void_0;

		// Token: 0x04003184 RID: 12676
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectNull_Private_Void_BinaryHeaderEnum_0;

		// Token: 0x04003185 RID: 12677
		private static readonly IntPtr NativeMethodInfoPtr_ReadMessageEnd_Private_Void_0;

		// Token: 0x04003186 RID: 12678
		private static readonly IntPtr NativeMethodInfoPtr_ReadValue_Internal_Object_InternalPrimitiveTypeE_0;

		// Token: 0x04003187 RID: 12679
		private static readonly IntPtr NativeMethodInfoPtr_GetOp_Private_ObjectProgress_0;

		// Token: 0x04003188 RID: 12680
		private static readonly IntPtr NativeMethodInfoPtr_PutOp_Private_Void_ObjectProgress_0;
	}
}
