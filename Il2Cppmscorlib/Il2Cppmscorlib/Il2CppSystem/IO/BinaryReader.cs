using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x020001F8 RID: 504
	public class BinaryReader : Object
	{
		// Token: 0x06002070 RID: 8304 RVA: 0x000B6FC8 File Offset: 0x000B51C8
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryReader()
		{
			Il2CppClassPointerStore<BinaryReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "BinaryReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr);
			BinaryReader.NativeFieldInfoPtr_m_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_stream");
			BinaryReader.NativeFieldInfoPtr_m_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_buffer");
			BinaryReader.NativeFieldInfoPtr_m_decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_decoder");
			BinaryReader.NativeFieldInfoPtr_m_charBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_charBytes");
			BinaryReader.NativeFieldInfoPtr_m_singleChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_singleChar");
			BinaryReader.NativeFieldInfoPtr_m_charBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_charBuffer");
			BinaryReader.NativeFieldInfoPtr_m_maxCharsSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_maxCharsSize");
			BinaryReader.NativeFieldInfoPtr_m_2BytesPerChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_2BytesPerChar");
			BinaryReader.NativeFieldInfoPtr_m_isMemoryStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_isMemoryStream");
			BinaryReader.NativeFieldInfoPtr_m_leaveOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_leaveOpen");
			BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668775);
			BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668776);
			BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668777);
			BinaryReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668778);
			BinaryReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668779);
			BinaryReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668780);
			BinaryReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668781);
			BinaryReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668782);
			BinaryReader.NativeMethodInfoPtr_ReadBoolean_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668783);
			BinaryReader.NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668784);
			BinaryReader.NativeMethodInfoPtr_ReadSByte_Public_Virtual_New_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668785);
			BinaryReader.NativeMethodInfoPtr_ReadChar_Public_Virtual_New_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668786);
			BinaryReader.NativeMethodInfoPtr_ReadInt16_Public_Virtual_New_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668787);
			BinaryReader.NativeMethodInfoPtr_ReadUInt16_Public_Virtual_New_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668788);
			BinaryReader.NativeMethodInfoPtr_ReadInt32_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668789);
			BinaryReader.NativeMethodInfoPtr_ReadUInt32_Public_Virtual_New_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668790);
			BinaryReader.NativeMethodInfoPtr_ReadInt64_Public_Virtual_New_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668791);
			BinaryReader.NativeMethodInfoPtr_ReadUInt64_Public_Virtual_New_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668792);
			BinaryReader.NativeMethodInfoPtr_ReadSingle_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668793);
			BinaryReader.NativeMethodInfoPtr_ReadDouble_Public_Virtual_New_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668794);
			BinaryReader.NativeMethodInfoPtr_ReadDecimal_Public_Virtual_New_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668795);
			BinaryReader.NativeMethodInfoPtr_ReadString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668796);
			BinaryReader.NativeMethodInfoPtr_InternalReadChars_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668797);
			BinaryReader.NativeMethodInfoPtr_InternalReadOneChar_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668798);
			BinaryReader.NativeMethodInfoPtr_ReadChars_Public_Virtual_New_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668799);
			BinaryReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668800);
			BinaryReader.NativeMethodInfoPtr_ReadBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668801);
			BinaryReader.NativeMethodInfoPtr_FillBuffer_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668802);
			BinaryReader.NativeMethodInfoPtr_Read7BitEncodedInt_FamOrAssem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668803);
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x000B7304 File Offset: 0x000B5504
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189657, RefRangeEnd = 189659, XrefRangeStart = 189653, XrefRangeEnd = 189657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryReader(Stream input)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x000B7350 File Offset: 0x000B5550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189659, XrefRangeEnd = 189660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryReader(Stream input, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x000B73B0 File Offset: 0x000B55B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 189676, RefRangeEnd = 189680, XrefRangeStart = 189660, XrefRangeEnd = 189676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryReader(Stream input, Encoding encoding, bool leaveOpen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x000B741C File Offset: 0x000B561C
		public unsafe virtual Stream BaseStream
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x000B7468 File Offset: 0x000B5668
		[CallerCount(0)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x000B74A4 File Offset: 0x000B56A4
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x000B74F0 File Offset: 0x000B56F0
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x000B7524 File Offset: 0x000B5724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189680, XrefRangeEnd = 189682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x000B756C File Offset: 0x000B576C
		[CallerCount(0)]
		public unsafe virtual bool ReadBoolean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadBoolean_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x000B75B4 File Offset: 0x000B57B4
		[CallerCount(0)]
		public unsafe virtual byte ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x000B75FC File Offset: 0x000B57FC
		[CallerCount(0)]
		public unsafe virtual sbyte ReadSByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadSByte_Public_Virtual_New_SByte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x000B7644 File Offset: 0x000B5844
		[CallerCount(0)]
		public unsafe virtual char ReadChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadChar_Public_Virtual_New_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x000B768C File Offset: 0x000B588C
		[CallerCount(0)]
		public unsafe virtual short ReadInt16()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadInt16_Public_Virtual_New_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x000B76D4 File Offset: 0x000B58D4
		[CallerCount(0)]
		public unsafe virtual ushort ReadUInt16()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadUInt16_Public_Virtual_New_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x000B771C File Offset: 0x000B591C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189682, XrefRangeEnd = 189683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ReadInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadInt32_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x000B7764 File Offset: 0x000B5964
		[CallerCount(0)]
		public unsafe virtual uint ReadUInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadUInt32_Public_Virtual_New_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x000B77AC File Offset: 0x000B59AC
		[CallerCount(0)]
		public unsafe virtual long ReadInt64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadInt64_Public_Virtual_New_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x000B77F4 File Offset: 0x000B59F4
		[CallerCount(0)]
		public unsafe virtual ulong ReadUInt64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadUInt64_Public_Virtual_New_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x000B783C File Offset: 0x000B5A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189683, XrefRangeEnd = 189684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float ReadSingle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadSingle_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x000B7884 File Offset: 0x000B5A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189684, XrefRangeEnd = 189688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double ReadDouble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadDouble_Public_Virtual_New_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x000B78CC File Offset: 0x000B5ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189688, XrefRangeEnd = 189692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Decimal ReadDecimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadDecimal_Public_Virtual_New_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x000B7914 File Offset: 0x000B5B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189692, XrefRangeEnd = 189705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ReadString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x000B7958 File Offset: 0x000B5B58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189720, RefRangeEnd = 189721, XrefRangeStart = 189705, XrefRangeEnd = 189720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalReadChars(Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr_InternalReadChars_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x000B79C4 File Offset: 0x000B5BC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189729, RefRangeEnd = 189730, XrefRangeStart = 189721, XrefRangeEnd = 189729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalReadOneChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr_InternalReadOneChar_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x000B7A00 File Offset: 0x000B5C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189730, XrefRangeEnd = 189742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<char> ReadChars(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadChars_Public_Virtual_New_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x000B7A58 File Offset: 0x000B5C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189742, XrefRangeEnd = 189775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Read(Il2CppStructArray<byte> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x000B7ACC File Offset: 0x000B5CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189775, XrefRangeEnd = 189786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> ReadBytes(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x000B7B24 File Offset: 0x000B5D24
		[CallerCount(0)]
		public unsafe virtual void FillBuffer(int numBytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numBytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_FillBuffer_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x000B7B70 File Offset: 0x000B5D70
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 189786, RefRangeEnd = 189793, XrefRangeStart = 189786, XrefRangeEnd = 189786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read7BitEncodedInt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr_Read7BitEncodedInt_FamOrAssem_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x0000AD32 File Offset: 0x00008F32
		public BinaryReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x000B7BAC File Offset: 0x000B5DAC
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x0000AD3B File Offset: 0x00008F3B
		public unsafe Stream m_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x000B7BDC File Offset: 0x000B5DDC
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x0000AD5A File Offset: 0x00008F5A
		public unsafe Il2CppStructArray<byte> m_buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x000B7C0C File Offset: 0x000B5E0C
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x0000AD79 File Offset: 0x00008F79
		public unsafe Decoder m_decoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_decoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x000B7C3C File Offset: 0x000B5E3C
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x0000AD98 File Offset: 0x00008F98
		public unsafe Il2CppStructArray<byte> m_charBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_charBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_charBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x000B7C6C File Offset: 0x000B5E6C
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x0000ADB7 File Offset: 0x00008FB7
		public unsafe Il2CppStructArray<char> m_singleChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_singleChar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_singleChar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x000B7C9C File Offset: 0x000B5E9C
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x0000ADD6 File Offset: 0x00008FD6
		public unsafe Il2CppStructArray<char> m_charBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_charBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_charBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x000B7CCC File Offset: 0x000B5ECC
		// (set) Token: 0x0600209C RID: 8348 RVA: 0x0000ADF5 File Offset: 0x00008FF5
		public unsafe int m_maxCharsSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_maxCharsSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_maxCharsSize)) = value;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x000B7CF4 File Offset: 0x000B5EF4
		// (set) Token: 0x0600209E RID: 8350 RVA: 0x0000AE10 File Offset: 0x00009010
		public unsafe bool m_2BytesPerChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_2BytesPerChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_2BytesPerChar)) = value;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x000B7D1C File Offset: 0x000B5F1C
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x0000AE2B File Offset: 0x0000902B
		public unsafe bool m_isMemoryStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_isMemoryStream);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_isMemoryStream)) = value;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x000B7D44 File Offset: 0x000B5F44
		// (set) Token: 0x060020A2 RID: 8354 RVA: 0x0000AE46 File Offset: 0x00009046
		public unsafe bool m_leaveOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_leaveOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_leaveOpen)) = value;
			}
		}

		// Token: 0x04001D69 RID: 7529
		private static readonly IntPtr NativeFieldInfoPtr_m_stream;

		// Token: 0x04001D6A RID: 7530
		private static readonly IntPtr NativeFieldInfoPtr_m_buffer;

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeFieldInfoPtr_m_decoder;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeFieldInfoPtr_m_charBytes;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeFieldInfoPtr_m_singleChar;

		// Token: 0x04001D6E RID: 7534
		private static readonly IntPtr NativeFieldInfoPtr_m_charBuffer;

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCharsSize;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeFieldInfoPtr_m_2BytesPerChar;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeFieldInfoPtr_m_isMemoryStream;

		// Token: 0x04001D72 RID: 7538
		private static readonly IntPtr NativeFieldInfoPtr_m_leaveOpen;

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_0;

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0;

		// Token: 0x04001D76 RID: 7542
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0;

		// Token: 0x04001D77 RID: 7543
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04001D78 RID: 7544
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001D79 RID: 7545
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001D7A RID: 7546
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0;

		// Token: 0x04001D7B RID: 7547
		private static readonly IntPtr NativeMethodInfoPtr_ReadBoolean_Public_Virtual_New_Boolean_0;

		// Token: 0x04001D7C RID: 7548
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Byte_0;

		// Token: 0x04001D7D RID: 7549
		private static readonly IntPtr NativeMethodInfoPtr_ReadSByte_Public_Virtual_New_SByte_0;

		// Token: 0x04001D7E RID: 7550
		private static readonly IntPtr NativeMethodInfoPtr_ReadChar_Public_Virtual_New_Char_0;

		// Token: 0x04001D7F RID: 7551
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt16_Public_Virtual_New_Int16_0;

		// Token: 0x04001D80 RID: 7552
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt16_Public_Virtual_New_UInt16_0;

		// Token: 0x04001D81 RID: 7553
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt32_Public_Virtual_New_Int32_0;

		// Token: 0x04001D82 RID: 7554
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt32_Public_Virtual_New_UInt32_0;

		// Token: 0x04001D83 RID: 7555
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt64_Public_Virtual_New_Int64_0;

		// Token: 0x04001D84 RID: 7556
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt64_Public_Virtual_New_UInt64_0;

		// Token: 0x04001D85 RID: 7557
		private static readonly IntPtr NativeMethodInfoPtr_ReadSingle_Public_Virtual_New_Single_0;

		// Token: 0x04001D86 RID: 7558
		private static readonly IntPtr NativeMethodInfoPtr_ReadDouble_Public_Virtual_New_Double_0;

		// Token: 0x04001D87 RID: 7559
		private static readonly IntPtr NativeMethodInfoPtr_ReadDecimal_Public_Virtual_New_Decimal_0;

		// Token: 0x04001D88 RID: 7560
		private static readonly IntPtr NativeMethodInfoPtr_ReadString_Public_Virtual_New_String_0;

		// Token: 0x04001D89 RID: 7561
		private static readonly IntPtr NativeMethodInfoPtr_InternalReadChars_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001D8A RID: 7562
		private static readonly IntPtr NativeMethodInfoPtr_InternalReadOneChar_Private_Int32_0;

		// Token: 0x04001D8B RID: 7563
		private static readonly IntPtr NativeMethodInfoPtr_ReadChars_Public_Virtual_New_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04001D8C RID: 7564
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001D8D RID: 7565
		private static readonly IntPtr NativeMethodInfoPtr_ReadBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001D8E RID: 7566
		private static readonly IntPtr NativeMethodInfoPtr_FillBuffer_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04001D8F RID: 7567
		private static readonly IntPtr NativeMethodInfoPtr_Read7BitEncodedInt_FamOrAssem_Int32_0;
	}
}
