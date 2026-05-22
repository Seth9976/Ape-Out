using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x0200020E RID: 526
	[Serializable]
	public class StreamReader : TextReader
	{
		// Token: 0x06002204 RID: 8708 RVA: 0x000BE064 File Offset: 0x000BC264
		// Note: this type is marked as 'beforefieldinit'.
		static StreamReader()
		{
			Il2CppClassPointerStore<StreamReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "StreamReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamReader>.NativeClassPtr);
			StreamReader.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "Null");
			StreamReader.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "stream");
			StreamReader.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "encoding");
			StreamReader.NativeFieldInfoPtr_decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "decoder");
			StreamReader.NativeFieldInfoPtr_byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "byteBuffer");
			StreamReader.NativeFieldInfoPtr_charBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "charBuffer");
			StreamReader.NativeFieldInfoPtr__preamble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_preamble");
			StreamReader.NativeFieldInfoPtr_charPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "charPos");
			StreamReader.NativeFieldInfoPtr_charLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "charLen");
			StreamReader.NativeFieldInfoPtr_byteLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "byteLen");
			StreamReader.NativeFieldInfoPtr_bytePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "bytePos");
			StreamReader.NativeFieldInfoPtr__maxCharsPerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_maxCharsPerBuffer");
			StreamReader.NativeFieldInfoPtr__detectEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_detectEncoding");
			StreamReader.NativeFieldInfoPtr__checkPreamble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_checkPreamble");
			StreamReader.NativeFieldInfoPtr__isBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_isBlocked");
			StreamReader.NativeFieldInfoPtr__closable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_closable");
			StreamReader.NativeFieldInfoPtr__asyncReadTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_asyncReadTask");
			StreamReader.NativeMethodInfoPtr_get_DefaultBufferSize_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669059);
			StreamReader.NativeMethodInfoPtr_CheckAsyncTaskInProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669060);
			StreamReader.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669061);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669062);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669063);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669064);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669065);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669066);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669067);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669068);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669069);
			StreamReader.NativeMethodInfoPtr__ctor_Internal_Void_String_Encoding_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669070);
			StreamReader.NativeMethodInfoPtr_Init_Private_Void_Stream_Encoding_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669071);
			StreamReader.NativeMethodInfoPtr_Init_Internal_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669072);
			StreamReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669073);
			StreamReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669074);
			StreamReader.NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_New_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669075);
			StreamReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669076);
			StreamReader.NativeMethodInfoPtr_get_LeaveOpen_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669077);
			StreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669078);
			StreamReader.NativeMethodInfoPtr_DataAvailable_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669079);
			StreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669080);
			StreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669081);
			StreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669082);
			StreamReader.NativeMethodInfoPtr_CompressBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669083);
			StreamReader.NativeMethodInfoPtr_DetectEncoding_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669084);
			StreamReader.NativeMethodInfoPtr_IsPreamble_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669085);
			StreamReader.NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669086);
			StreamReader.NativeMethodInfoPtr_ReadBuffer_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669087);
			StreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100669088);
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x000BE440 File Offset: 0x000BC640
		public unsafe static int DefaultBufferSize
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_get_DefaultBufferSize_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x000BE470 File Offset: 0x000BC670
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 191242, RefRangeEnd = 191248, XrefRangeStart = 191239, XrefRangeEnd = 191242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAsyncTaskInProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_CheckAsyncTaskInProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x000BE4A4 File Offset: 0x000BC6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191248, XrefRangeEnd = 191251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x000BE4E0 File Offset: 0x000BC6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191251, XrefRangeEnd = 191256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(Stream stream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x000BE52C File Offset: 0x000BC72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191256, XrefRangeEnd = 191261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x000BE588 File Offset: 0x000BC788
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 191265, RefRangeEnd = 191271, XrefRangeStart = 191261, XrefRangeEnd = 191265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(Stream stream, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x000BE5E8 File Offset: 0x000BC7E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 191296, RefRangeEnd = 191300, XrefRangeStart = 191271, XrefRangeEnd = 191296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x000BE670 File Offset: 0x000BC870
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 191305, RefRangeEnd = 191310, XrefRangeStart = 191300, XrefRangeEnd = 191305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(string path)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x000BE6BC File Offset: 0x000BC8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191310, XrefRangeEnd = 191315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(string path, bool detectEncodingFromByteOrderMarks)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x000BE718 File Offset: 0x000BC918
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 191319, RefRangeEnd = 191323, XrefRangeStart = 191315, XrefRangeEnd = 191319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(string path, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x000BE778 File Offset: 0x000BC978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191323, XrefRangeEnd = 191324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x000BE7F4 File Offset: 0x000BC9F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 191357, RefRangeEnd = 191361, XrefRangeStart = 191324, XrefRangeEnd = 191357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool checkHost)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkHost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Internal_Void_String_Encoding_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x000BE87C File Offset: 0x000BCA7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191367, RefRangeEnd = 191369, XrefRangeStart = 191361, XrefRangeEnd = 191367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_Init_Private_Void_Stream_Encoding_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x000BE8FC File Offset: 0x000BCAFC
		[CallerCount(0)]
		public unsafe void Init(Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_Init_Internal_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x000BE940 File Offset: 0x000BCB40
		[CallerCount(0)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x000BE97C File Offset: 0x000BCB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191369, XrefRangeEnd = 191375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x000BE9C8 File Offset: 0x000BCBC8
		public unsafe virtual Encoding CurrentEncoding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_New_get_Encoding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x000BEA14 File Offset: 0x000BCC14
		public unsafe virtual Stream BaseStream
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002217 RID: 8727 RVA: 0x000BEA60 File Offset: 0x000BCC60
		public unsafe bool LeaveOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_get_LeaveOpen_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x000BEA9C File Offset: 0x000BCC9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191376, RefRangeEnd = 191378, XrefRangeStart = 191375, XrefRangeEnd = 191376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x000BEAE4 File Offset: 0x000BCCE4
		[CallerCount(0)]
		public unsafe bool DataAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_DataAvailable_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x000BEB20 File Offset: 0x000BCD20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191379, RefRangeEnd = 191381, XrefRangeStart = 191378, XrefRangeEnd = 191379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x000BEB68 File Offset: 0x000BCD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191381, XrefRangeEnd = 191388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read([In] [Out] Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x000BEBF0 File Offset: 0x000BCDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191388, XrefRangeEnd = 191399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x000BEC34 File Offset: 0x000BCE34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191402, RefRangeEnd = 191404, XrefRangeStart = 191399, XrefRangeEnd = 191402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompressBuffer(int n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_CompressBuffer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x000BEC74 File Offset: 0x000BCE74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191430, RefRangeEnd = 191432, XrefRangeStart = 191404, XrefRangeEnd = 191430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetectEncoding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_DetectEncoding_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x000BECA8 File Offset: 0x000BCEA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191433, RefRangeEnd = 191435, XrefRangeStart = 191432, XrefRangeEnd = 191433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPreamble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_IsPreamble_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x000BECE4 File Offset: 0x000BCEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191435, XrefRangeEnd = 191438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ReadBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x000BED2C File Offset: 0x000BCF2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191442, RefRangeEnd = 191443, XrefRangeStart = 191438, XrefRangeEnd = 191442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadBuffer(Il2CppStructArray<char> userBuffer, int userOffset, int desiredChars, out bool readToUserBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(userBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredChars;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &readToUserBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_ReadBuffer_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x000BEDA4 File Offset: 0x000BCFA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191445, RefRangeEnd = 191446, XrefRangeStart = 191443, XrefRangeEnd = 191445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x0000B554 File Offset: 0x00009754
		public StreamReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x000BEDE8 File Offset: 0x000BCFE8
		// (set) Token: 0x06002225 RID: 8741 RVA: 0x0000B55D File Offset: 0x0000975D
		public new unsafe static StreamReader Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StreamReader.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StreamReader.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x000BEE10 File Offset: 0x000BD010
		// (set) Token: 0x06002227 RID: 8743 RVA: 0x0000B56F File Offset: 0x0000976F
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x000BEE40 File Offset: 0x000BD040
		// (set) Token: 0x06002229 RID: 8745 RVA: 0x0000B58E File Offset: 0x0000978E
		public unsafe Encoding encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x0600222A RID: 8746 RVA: 0x000BEE70 File Offset: 0x000BD070
		// (set) Token: 0x0600222B RID: 8747 RVA: 0x0000B5AD File Offset: 0x000097AD
		public unsafe Decoder decoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_decoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x000BEEA0 File Offset: 0x000BD0A0
		// (set) Token: 0x0600222D RID: 8749 RVA: 0x0000B5CC File Offset: 0x000097CC
		public unsafe Il2CppStructArray<byte> byteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_byteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x000BEED0 File Offset: 0x000BD0D0
		// (set) Token: 0x0600222F RID: 8751 RVA: 0x0000B5EB File Offset: 0x000097EB
		public unsafe Il2CppStructArray<char> charBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_charBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_charBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x000BEF00 File Offset: 0x000BD100
		// (set) Token: 0x06002231 RID: 8753 RVA: 0x0000B60A File Offset: 0x0000980A
		public unsafe Il2CppStructArray<byte> _preamble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__preamble);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__preamble), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x000BEF30 File Offset: 0x000BD130
		// (set) Token: 0x06002233 RID: 8755 RVA: 0x0000B629 File Offset: 0x00009829
		public unsafe int charPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_charPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_charPos)) = value;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x000BEF58 File Offset: 0x000BD158
		// (set) Token: 0x06002235 RID: 8757 RVA: 0x0000B644 File Offset: 0x00009844
		public unsafe int charLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_charLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_charLen)) = value;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x000BEF80 File Offset: 0x000BD180
		// (set) Token: 0x06002237 RID: 8759 RVA: 0x0000B65F File Offset: 0x0000985F
		public unsafe int byteLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_byteLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_byteLen)) = value;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x000BEFA8 File Offset: 0x000BD1A8
		// (set) Token: 0x06002239 RID: 8761 RVA: 0x0000B67A File Offset: 0x0000987A
		public unsafe int bytePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_bytePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_bytePos)) = value;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x000BEFD0 File Offset: 0x000BD1D0
		// (set) Token: 0x0600223B RID: 8763 RVA: 0x0000B695 File Offset: 0x00009895
		public unsafe int _maxCharsPerBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__maxCharsPerBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__maxCharsPerBuffer)) = value;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x000BEFF8 File Offset: 0x000BD1F8
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x0000B6B0 File Offset: 0x000098B0
		public unsafe bool _detectEncoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__detectEncoding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__detectEncoding)) = value;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x000BF020 File Offset: 0x000BD220
		// (set) Token: 0x0600223F RID: 8767 RVA: 0x0000B6CB File Offset: 0x000098CB
		public unsafe bool _checkPreamble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__checkPreamble);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__checkPreamble)) = value;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x000BF048 File Offset: 0x000BD248
		// (set) Token: 0x06002241 RID: 8769 RVA: 0x0000B6E6 File Offset: 0x000098E6
		public unsafe bool _isBlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__isBlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__isBlocked)) = value;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x000BF070 File Offset: 0x000BD270
		// (set) Token: 0x06002243 RID: 8771 RVA: 0x0000B701 File Offset: 0x00009901
		public unsafe bool _closable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__closable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__closable)) = value;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x000BF098 File Offset: 0x000BD298
		// (set) Token: 0x06002245 RID: 8773 RVA: 0x0000B71C File Offset: 0x0000991C
		public unsafe Task _asyncReadTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__asyncReadTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__asyncReadTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E91 RID: 7825
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04001E92 RID: 7826
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x04001E93 RID: 7827
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x04001E94 RID: 7828
		private static readonly IntPtr NativeFieldInfoPtr_decoder;

		// Token: 0x04001E95 RID: 7829
		private static readonly IntPtr NativeFieldInfoPtr_byteBuffer;

		// Token: 0x04001E96 RID: 7830
		private static readonly IntPtr NativeFieldInfoPtr_charBuffer;

		// Token: 0x04001E97 RID: 7831
		private static readonly IntPtr NativeFieldInfoPtr__preamble;

		// Token: 0x04001E98 RID: 7832
		private static readonly IntPtr NativeFieldInfoPtr_charPos;

		// Token: 0x04001E99 RID: 7833
		private static readonly IntPtr NativeFieldInfoPtr_charLen;

		// Token: 0x04001E9A RID: 7834
		private static readonly IntPtr NativeFieldInfoPtr_byteLen;

		// Token: 0x04001E9B RID: 7835
		private static readonly IntPtr NativeFieldInfoPtr_bytePos;

		// Token: 0x04001E9C RID: 7836
		private static readonly IntPtr NativeFieldInfoPtr__maxCharsPerBuffer;

		// Token: 0x04001E9D RID: 7837
		private static readonly IntPtr NativeFieldInfoPtr__detectEncoding;

		// Token: 0x04001E9E RID: 7838
		private static readonly IntPtr NativeFieldInfoPtr__checkPreamble;

		// Token: 0x04001E9F RID: 7839
		private static readonly IntPtr NativeFieldInfoPtr__isBlocked;

		// Token: 0x04001EA0 RID: 7840
		private static readonly IntPtr NativeFieldInfoPtr__closable;

		// Token: 0x04001EA1 RID: 7841
		private static readonly IntPtr NativeFieldInfoPtr__asyncReadTask;

		// Token: 0x04001EA2 RID: 7842
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultBufferSize_Internal_Static_get_Int32_0;

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeMethodInfoPtr_CheckAsyncTaskInProgress_Private_Void_0;

		// Token: 0x04001EA4 RID: 7844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001EA5 RID: 7845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_0;

		// Token: 0x04001EA6 RID: 7846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_0;

		// Token: 0x04001EA7 RID: 7847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x04001EA8 RID: 7848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_Int32_Boolean_0;

		// Token: 0x04001EA9 RID: 7849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001EAA RID: 7850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x04001EAB RID: 7851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_0;

		// Token: 0x04001EAC RID: 7852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_Boolean_Int32_0;

		// Token: 0x04001EAD RID: 7853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Encoding_Boolean_Int32_Boolean_0;

		// Token: 0x04001EAE RID: 7854
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_Stream_Encoding_Boolean_Int32_Boolean_0;

		// Token: 0x04001EAF RID: 7855
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_Stream_0;

		// Token: 0x04001EB0 RID: 7856
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04001EB1 RID: 7857
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04001EB2 RID: 7858
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_New_get_Encoding_0;

		// Token: 0x04001EB3 RID: 7859
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0;

		// Token: 0x04001EB4 RID: 7860
		private static readonly IntPtr NativeMethodInfoPtr_get_LeaveOpen_Internal_get_Boolean_0;

		// Token: 0x04001EB5 RID: 7861
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0;

		// Token: 0x04001EB6 RID: 7862
		private static readonly IntPtr NativeMethodInfoPtr_DataAvailable_Internal_Boolean_0;

		// Token: 0x04001EB7 RID: 7863
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_0;

		// Token: 0x04001EB8 RID: 7864
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001EB9 RID: 7865
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0;

		// Token: 0x04001EBA RID: 7866
		private static readonly IntPtr NativeMethodInfoPtr_CompressBuffer_Private_Void_Int32_0;

		// Token: 0x04001EBB RID: 7867
		private static readonly IntPtr NativeMethodInfoPtr_DetectEncoding_Private_Void_0;

		// Token: 0x04001EBC RID: 7868
		private static readonly IntPtr NativeMethodInfoPtr_IsPreamble_Private_Boolean_0;

		// Token: 0x04001EBD RID: 7869
		private static readonly IntPtr NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_New_Int32_0;

		// Token: 0x04001EBE RID: 7870
		private static readonly IntPtr NativeMethodInfoPtr_ReadBuffer_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Boolean_0;

		// Token: 0x04001EBF RID: 7871
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;

		// Token: 0x020005D7 RID: 1495
		public class NullStreamReader : StreamReader
		{
			// Token: 0x06005367 RID: 21351 RVA: 0x00177C78 File Offset: 0x00175E78
			// Note: this type is marked as 'beforefieldinit'.
			static NullStreamReader()
			{
				Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "NullStreamReader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr);
				StreamReader.NullStreamReader.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100669090);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100669091);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100669092);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100669093);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100669094);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100669095);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100669096);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100669097);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100669098);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100669099);
			}

			// Token: 0x06005368 RID: 21352 RVA: 0x00177D6C File Offset: 0x00175F6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191222, XrefRangeEnd = 191232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NullStreamReader()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NullStreamReader.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001570 RID: 5488
			// (get) Token: 0x06005369 RID: 21353 RVA: 0x00177DA8 File Offset: 0x00175FA8
			public unsafe override Stream BaseStream
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191232, XrefRangeEnd = 191236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_get_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
				}
			}

			// Token: 0x17001571 RID: 5489
			// (get) Token: 0x0600536A RID: 21354 RVA: 0x00177DF4 File Offset: 0x00175FF4
			public unsafe override Encoding CurrentEncoding
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191236, XrefRangeEnd = 191237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_get_Encoding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
				}
			}

			// Token: 0x0600536B RID: 21355 RVA: 0x00177E40 File Offset: 0x00176040
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600536C RID: 21356 RVA: 0x00177E8C File Offset: 0x0017608C
			[CallerCount(0)]
			public unsafe override int Peek()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600536D RID: 21357 RVA: 0x00177ED4 File Offset: 0x001760D4
			[CallerCount(0)]
			public unsafe override int Read()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600536E RID: 21358 RVA: 0x00177F1C File Offset: 0x0017611C
			[CallerCount(0)]
			public unsafe override int Read(Il2CppStructArray<char> buffer, int index, int count)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600536F RID: 21359 RVA: 0x00177F90 File Offset: 0x00176190
			[CallerCount(0)]
			public unsafe override string ReadLine()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06005370 RID: 21360 RVA: 0x00177FD4 File Offset: 0x001761D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191237, XrefRangeEnd = 191239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ReadToEnd()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06005371 RID: 21361 RVA: 0x00178018 File Offset: 0x00176218
			[CallerCount(0)]
			public unsafe override int ReadBuffer()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005372 RID: 21362 RVA: 0x0001F762 File Offset: 0x0001D962
			public NullStreamReader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400437F RID: 17279
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04004380 RID: 17280
			private static readonly IntPtr NativeMethodInfoPtr_get_BaseStream_Public_Virtual_get_Stream_0;

			// Token: 0x04004381 RID: 17281
			private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_get_Encoding_0;

			// Token: 0x04004382 RID: 17282
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

			// Token: 0x04004383 RID: 17283
			private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0;

			// Token: 0x04004384 RID: 17284
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_0;

			// Token: 0x04004385 RID: 17285
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04004386 RID: 17286
			private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;

			// Token: 0x04004387 RID: 17287
			private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0;

			// Token: 0x04004388 RID: 17288
			private static readonly IntPtr NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_Int32_0;
		}
	}
}
