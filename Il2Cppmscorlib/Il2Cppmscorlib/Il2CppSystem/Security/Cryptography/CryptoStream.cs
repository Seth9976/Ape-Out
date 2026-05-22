using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002E1 RID: 737
	public class CryptoStream : Stream
	{
		// Token: 0x06003171 RID: 12657 RVA: 0x000F8818 File Offset: 0x000F6A18
		// Note: this type is marked as 'beforefieldinit'.
		static CryptoStream()
		{
			Il2CppClassPointerStore<CryptoStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CryptoStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr);
			CryptoStream.NativeFieldInfoPtr__stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_stream");
			CryptoStream.NativeFieldInfoPtr__Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_Transform");
			CryptoStream.NativeFieldInfoPtr__InputBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_InputBuffer");
			CryptoStream.NativeFieldInfoPtr__InputBufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_InputBufferIndex");
			CryptoStream.NativeFieldInfoPtr__InputBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_InputBlockSize");
			CryptoStream.NativeFieldInfoPtr__OutputBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_OutputBuffer");
			CryptoStream.NativeFieldInfoPtr__OutputBufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_OutputBufferIndex");
			CryptoStream.NativeFieldInfoPtr__OutputBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_OutputBlockSize");
			CryptoStream.NativeFieldInfoPtr__transformMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_transformMode");
			CryptoStream.NativeFieldInfoPtr__canRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_canRead");
			CryptoStream.NativeFieldInfoPtr__canWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_canWrite");
			CryptoStream.NativeFieldInfoPtr__finalBlockTransformed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_finalBlockTransformed");
			CryptoStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_ICryptoTransform_CryptoStreamMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671126);
			CryptoStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671127);
			CryptoStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671128);
			CryptoStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671129);
			CryptoStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671130);
			CryptoStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671131);
			CryptoStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671132);
			CryptoStream.NativeMethodInfoPtr_get_HasFlushedFinalBlock_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671133);
			CryptoStream.NativeMethodInfoPtr_FlushFinalBlock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671134);
			CryptoStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671135);
			CryptoStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671136);
			CryptoStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671137);
			CryptoStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671138);
			CryptoStream.NativeMethodInfoPtr_ReadAsyncInternal_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671139);
			CryptoStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671140);
			CryptoStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671141);
			CryptoStream.NativeMethodInfoPtr_WriteAsyncInternal_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671142);
			CryptoStream.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671143);
			CryptoStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671144);
			CryptoStream.NativeMethodInfoPtr_InitializeBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100671145);
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x000F8AC8 File Offset: 0x000F6CC8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 209450, RefRangeEnd = 209455, XrefRangeStart = 209432, XrefRangeEnd = 209450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_ICryptoTransform_CryptoStreamMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06003173 RID: 12659 RVA: 0x000F8B34 File Offset: 0x000F6D34
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06003174 RID: 12660 RVA: 0x000F8B7C File Offset: 0x000F6D7C
		public unsafe override bool CanSeek
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06003175 RID: 12661 RVA: 0x000F8BC4 File Offset: 0x000F6DC4
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06003176 RID: 12662 RVA: 0x000F8C0C File Offset: 0x000F6E0C
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209455, XrefRangeEnd = 209462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06003177 RID: 12663 RVA: 0x000F8C54 File Offset: 0x000F6E54
		// (set) Token: 0x06003178 RID: 12664 RVA: 0x000F8C9C File Offset: 0x000F6E9C
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209462, XrefRangeEnd = 209469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209469, XrefRangeEnd = 209476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06003179 RID: 12665 RVA: 0x000F8CE8 File Offset: 0x000F6EE8
		public unsafe bool HasFlushedFinalBlock
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_get_HasFlushedFinalBlock_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x000F8D24 File Offset: 0x000F6F24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209484, RefRangeEnd = 209487, XrefRangeStart = 209476, XrefRangeEnd = 209484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushFinalBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_FlushFinalBlock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x000F8D58 File Offset: 0x000F6F58
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x000F8D94 File Offset: 0x000F6F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209487, XrefRangeEnd = 209494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long Seek(long offset, SeekOrigin origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x000F8DF8 File Offset: 0x000F6FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209494, XrefRangeEnd = 209504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read([In] [Out] Il2CppStructArray<byte> buffer, int offset, int count)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x000F8E80 File Offset: 0x000F7080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209504, XrefRangeEnd = 209516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x000F8F10 File Offset: 0x000F7110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209516, XrefRangeEnd = 209526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> ReadAsyncInternal(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_ReadAsyncInternal_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x000F8F94 File Offset: 0x000F7194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209526, XrefRangeEnd = 209549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x000F9000 File Offset: 0x000F7200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209549, XrefRangeEnd = 209560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x000F9090 File Offset: 0x000F7290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209560, XrefRangeEnd = 209569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteAsyncInternal(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_WriteAsyncInternal_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x000F9114 File Offset: 0x000F7314
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x000F9148 File Offset: 0x000F7348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209569, XrefRangeEnd = 209574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x000F9194 File Offset: 0x000F7394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209574, XrefRangeEnd = 209584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_InitializeBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x00011480 File Offset: 0x0000F680
		public CryptoStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x000F91C8 File Offset: 0x000F73C8
		// (set) Token: 0x06003188 RID: 12680 RVA: 0x00011489 File Offset: 0x0000F689
		public unsafe Stream _stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06003189 RID: 12681 RVA: 0x000F91F8 File Offset: 0x000F73F8
		// (set) Token: 0x0600318A RID: 12682 RVA: 0x000114A8 File Offset: 0x0000F6A8
		public unsafe ICryptoTransform _Transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__Transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__Transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x0600318B RID: 12683 RVA: 0x000F9228 File Offset: 0x000F7428
		// (set) Token: 0x0600318C RID: 12684 RVA: 0x000114C7 File Offset: 0x0000F6C7
		public unsafe Il2CppStructArray<byte> _InputBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__InputBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__InputBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x0600318D RID: 12685 RVA: 0x000F9258 File Offset: 0x000F7458
		// (set) Token: 0x0600318E RID: 12686 RVA: 0x000114E6 File Offset: 0x0000F6E6
		public unsafe int _InputBufferIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__InputBufferIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__InputBufferIndex)) = value;
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x0600318F RID: 12687 RVA: 0x000F9280 File Offset: 0x000F7480
		// (set) Token: 0x06003190 RID: 12688 RVA: 0x00011501 File Offset: 0x0000F701
		public unsafe int _InputBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__InputBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__InputBlockSize)) = value;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x000F92A8 File Offset: 0x000F74A8
		// (set) Token: 0x06003192 RID: 12690 RVA: 0x0001151C File Offset: 0x0000F71C
		public unsafe Il2CppStructArray<byte> _OutputBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__OutputBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__OutputBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06003193 RID: 12691 RVA: 0x000F92D8 File Offset: 0x000F74D8
		// (set) Token: 0x06003194 RID: 12692 RVA: 0x0001153B File Offset: 0x0000F73B
		public unsafe int _OutputBufferIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__OutputBufferIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__OutputBufferIndex)) = value;
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06003195 RID: 12693 RVA: 0x000F9300 File Offset: 0x000F7500
		// (set) Token: 0x06003196 RID: 12694 RVA: 0x00011556 File Offset: 0x0000F756
		public unsafe int _OutputBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__OutputBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__OutputBlockSize)) = value;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06003197 RID: 12695 RVA: 0x000F9328 File Offset: 0x000F7528
		// (set) Token: 0x06003198 RID: 12696 RVA: 0x00011571 File Offset: 0x0000F771
		public unsafe CryptoStreamMode _transformMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__transformMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__transformMode)) = value;
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06003199 RID: 12697 RVA: 0x000F9350 File Offset: 0x000F7550
		// (set) Token: 0x0600319A RID: 12698 RVA: 0x0001158C File Offset: 0x0000F78C
		public unsafe bool _canRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__canRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__canRead)) = value;
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x0600319B RID: 12699 RVA: 0x000F9378 File Offset: 0x000F7578
		// (set) Token: 0x0600319C RID: 12700 RVA: 0x000115A7 File Offset: 0x0000F7A7
		public unsafe bool _canWrite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__canWrite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__canWrite)) = value;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x0600319D RID: 12701 RVA: 0x000F93A0 File Offset: 0x000F75A0
		// (set) Token: 0x0600319E RID: 12702 RVA: 0x000115C2 File Offset: 0x0000F7C2
		public unsafe bool _finalBlockTransformed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__finalBlockTransformed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__finalBlockTransformed)) = value;
			}
		}

		// Token: 0x04002A88 RID: 10888
		private static readonly IntPtr NativeFieldInfoPtr__stream;

		// Token: 0x04002A89 RID: 10889
		private static readonly IntPtr NativeFieldInfoPtr__Transform;

		// Token: 0x04002A8A RID: 10890
		private static readonly IntPtr NativeFieldInfoPtr__InputBuffer;

		// Token: 0x04002A8B RID: 10891
		private static readonly IntPtr NativeFieldInfoPtr__InputBufferIndex;

		// Token: 0x04002A8C RID: 10892
		private static readonly IntPtr NativeFieldInfoPtr__InputBlockSize;

		// Token: 0x04002A8D RID: 10893
		private static readonly IntPtr NativeFieldInfoPtr__OutputBuffer;

		// Token: 0x04002A8E RID: 10894
		private static readonly IntPtr NativeFieldInfoPtr__OutputBufferIndex;

		// Token: 0x04002A8F RID: 10895
		private static readonly IntPtr NativeFieldInfoPtr__OutputBlockSize;

		// Token: 0x04002A90 RID: 10896
		private static readonly IntPtr NativeFieldInfoPtr__transformMode;

		// Token: 0x04002A91 RID: 10897
		private static readonly IntPtr NativeFieldInfoPtr__canRead;

		// Token: 0x04002A92 RID: 10898
		private static readonly IntPtr NativeFieldInfoPtr__canWrite;

		// Token: 0x04002A93 RID: 10899
		private static readonly IntPtr NativeFieldInfoPtr__finalBlockTransformed;

		// Token: 0x04002A94 RID: 10900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_ICryptoTransform_CryptoStreamMode_0;

		// Token: 0x04002A95 RID: 10901
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04002A96 RID: 10902
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x04002A97 RID: 10903
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04002A98 RID: 10904
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04002A99 RID: 10905
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x04002A9A RID: 10906
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

		// Token: 0x04002A9B RID: 10907
		private static readonly IntPtr NativeMethodInfoPtr_get_HasFlushedFinalBlock_Public_get_Boolean_0;

		// Token: 0x04002A9C RID: 10908
		private static readonly IntPtr NativeMethodInfoPtr_FlushFinalBlock_Public_Void_0;

		// Token: 0x04002A9D RID: 10909
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04002A9E RID: 10910
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x04002A9F RID: 10911
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002AA0 RID: 10912
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04002AA1 RID: 10913
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsyncInternal_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04002AA2 RID: 10914
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002AA3 RID: 10915
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04002AA4 RID: 10916
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsyncInternal_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04002AA5 RID: 10917
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002AA6 RID: 10918
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04002AA7 RID: 10919
		private static readonly IntPtr NativeMethodInfoPtr_InitializeBuffer_Private_Void_0;

		// Token: 0x02000627 RID: 1575
		[StructLayout(2)]
		public struct HopToThreadPoolAwaitable : INotifyCompletion
		{
			// Token: 0x0600558F RID: 21903 RVA: 0x0017F17C File Offset: 0x0017D37C
			// Note: this type is marked as 'beforefieldinit'.
			static HopToThreadPoolAwaitable()
			{
				Il2CppClassPointerStore<CryptoStream.HopToThreadPoolAwaitable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "HopToThreadPoolAwaitable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoStream.HopToThreadPoolAwaitable>.NativeClassPtr);
				CryptoStream.HopToThreadPoolAwaitable.NativeMethodInfoPtr_GetAwaiter_Public_HopToThreadPoolAwaitable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream.HopToThreadPoolAwaitable>.NativeClassPtr, 100671146);
				CryptoStream.HopToThreadPoolAwaitable.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream.HopToThreadPoolAwaitable>.NativeClassPtr, 100671147);
				CryptoStream.HopToThreadPoolAwaitable.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream.HopToThreadPoolAwaitable>.NativeClassPtr, 100671148);
				CryptoStream.HopToThreadPoolAwaitable.NativeMethodInfoPtr_GetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream.HopToThreadPoolAwaitable>.NativeClassPtr, 100671149);
			}

			// Token: 0x06005590 RID: 21904 RVA: 0x0017F1F8 File Offset: 0x0017D3F8
			[CallerCount(0)]
			public unsafe CryptoStream.HopToThreadPoolAwaitable GetAwaiter()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.HopToThreadPoolAwaitable.NativeMethodInfoPtr_GetAwaiter_Public_HopToThreadPoolAwaitable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170015F9 RID: 5625
			// (get) Token: 0x06005591 RID: 21905 RVA: 0x0017F228 File Offset: 0x0017D428
			public unsafe bool IsCompleted
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.HopToThreadPoolAwaitable.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005592 RID: 21906 RVA: 0x0017F258 File Offset: 0x0017D458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209240, XrefRangeEnd = 209244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnCompleted(Action continuation)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.HopToThreadPoolAwaitable.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005593 RID: 21907 RVA: 0x0017F290 File Offset: 0x0017D490
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetResult()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.HopToThreadPoolAwaitable.NativeMethodInfoPtr_GetResult_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005594 RID: 21908 RVA: 0x000206F1 File Offset: 0x0001E8F1
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CryptoStream.HopToThreadPoolAwaitable>.NativeClassPtr, ref this));
			}

			// Token: 0x06005595 RID: 21909 RVA: 0x00020703 File Offset: 0x0001E903
			public void OnCompleted(Action continuation)
			{
				this.OnCompleted(continuation);
			}

			// Token: 0x04004511 RID: 17681
			private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_HopToThreadPoolAwaitable_0;

			// Token: 0x04004512 RID: 17682
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

			// Token: 0x04004513 RID: 17683
			private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

			// Token: 0x04004514 RID: 17684
			private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Void_0;
		}

		// Token: 0x02000628 RID: 1576
		[ObfuscatedName("System.Security.Cryptography.CryptoStream+<ReadAsyncInternal>d__34")]
		public sealed class _ReadAsyncInternal_d__34 : ValueType
		{
			// Token: 0x06005596 RID: 21910 RVA: 0x0017F2B8 File Offset: 0x0017D4B8
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadAsyncInternal_d__34()
			{
				Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "<ReadAsyncInternal>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr);
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<>1__state");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<>t__builder");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<>4__this");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "count");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "offset");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "buffer");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "cancellationToken");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__tempInputBuffer_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<tempInputBuffer>5__1");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__currentOutputIndex_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<currentOutputIndex>5__2");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__bytesToDeliver_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<bytesToDeliver>5__3");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__sem_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<sem>5__4");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<>u__1");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<>u__2");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<>7__wrap1");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<>u__3");
				CryptoStream._ReadAsyncInternal_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, 100671150);
				CryptoStream._ReadAsyncInternal_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, 100671151);
			}

			// Token: 0x06005597 RID: 21911 RVA: 0x0017F438 File Offset: 0x0017D638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209244, XrefRangeEnd = 209350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream._ReadAsyncInternal_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005598 RID: 21912 RVA: 0x0017F470 File Offset: 0x0017D670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209350, XrefRangeEnd = 209365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream._ReadAsyncInternal_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005599 RID: 21913 RVA: 0x00020711 File Offset: 0x0001E911
			public _ReadAsyncInternal_d__34(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600559A RID: 21914 RVA: 0x0002071A File Offset: 0x0001E91A
			public _ReadAsyncInternal_d__34()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr))
			{
			}

			// Token: 0x170015FA RID: 5626
			// (get) Token: 0x0600559B RID: 21915 RVA: 0x0017F4B8 File Offset: 0x0017D6B8
			// (set) Token: 0x0600559C RID: 21916 RVA: 0x0002072C File Offset: 0x0001E92C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170015FB RID: 5627
			// (get) Token: 0x0600559D RID: 21917 RVA: 0x0017F4E0 File Offset: 0x0017D6E0
			// (set) Token: 0x0600559E RID: 21918 RVA: 0x00020747 File Offset: 0x0001E947
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170015FC RID: 5628
			// (get) Token: 0x0600559F RID: 21919 RVA: 0x0017F510 File Offset: 0x0017D710
			// (set) Token: 0x060055A0 RID: 21920 RVA: 0x00020775 File Offset: 0x0001E975
			public unsafe CryptoStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CryptoStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015FD RID: 5629
			// (get) Token: 0x060055A1 RID: 21921 RVA: 0x0017F540 File Offset: 0x0017D740
			// (set) Token: 0x060055A2 RID: 21922 RVA: 0x00020794 File Offset: 0x0001E994
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x170015FE RID: 5630
			// (get) Token: 0x060055A3 RID: 21923 RVA: 0x0017F568 File Offset: 0x0017D768
			// (set) Token: 0x060055A4 RID: 21924 RVA: 0x000207AF File Offset: 0x0001E9AF
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x170015FF RID: 5631
			// (get) Token: 0x060055A5 RID: 21925 RVA: 0x0017F590 File Offset: 0x0017D790
			// (set) Token: 0x060055A6 RID: 21926 RVA: 0x000207CA File Offset: 0x0001E9CA
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001600 RID: 5632
			// (get) Token: 0x060055A7 RID: 21927 RVA: 0x0017F5C0 File Offset: 0x0017D7C0
			// (set) Token: 0x060055A8 RID: 21928 RVA: 0x000207E9 File Offset: 0x0001E9E9
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001601 RID: 5633
			// (get) Token: 0x060055A9 RID: 21929 RVA: 0x0017F5F0 File Offset: 0x0017D7F0
			// (set) Token: 0x060055AA RID: 21930 RVA: 0x00020817 File Offset: 0x0001EA17
			public unsafe Il2CppStructArray<byte> _tempInputBuffer_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__tempInputBuffer_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__tempInputBuffer_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001602 RID: 5634
			// (get) Token: 0x060055AB RID: 21931 RVA: 0x0017F620 File Offset: 0x0017D820
			// (set) Token: 0x060055AC RID: 21932 RVA: 0x00020836 File Offset: 0x0001EA36
			public unsafe int _currentOutputIndex_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__currentOutputIndex_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__currentOutputIndex_5__2)) = value;
				}
			}

			// Token: 0x17001603 RID: 5635
			// (get) Token: 0x060055AD RID: 21933 RVA: 0x0017F648 File Offset: 0x0017D848
			// (set) Token: 0x060055AE RID: 21934 RVA: 0x00020851 File Offset: 0x0001EA51
			public unsafe int _bytesToDeliver_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__bytesToDeliver_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__bytesToDeliver_5__3)) = value;
				}
			}

			// Token: 0x17001604 RID: 5636
			// (get) Token: 0x060055AF RID: 21935 RVA: 0x0017F670 File Offset: 0x0017D870
			// (set) Token: 0x060055B0 RID: 21936 RVA: 0x0002086C File Offset: 0x0001EA6C
			public unsafe SemaphoreSlim _sem_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__sem_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__sem_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001605 RID: 5637
			// (get) Token: 0x060055B1 RID: 21937 RVA: 0x0017F6A0 File Offset: 0x0017D8A0
			// (set) Token: 0x060055B2 RID: 21938 RVA: 0x0002088B File Offset: 0x0001EA8B
			public unsafe CryptoStream.HopToThreadPoolAwaitable __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__1)) = value;
				}
			}

			// Token: 0x17001606 RID: 5638
			// (get) Token: 0x060055B3 RID: 21939 RVA: 0x0017F6C8 File Offset: 0x0017D8C8
			// (set) Token: 0x060055B4 RID: 21940 RVA: 0x000208A6 File Offset: 0x0001EAA6
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001607 RID: 5639
			// (get) Token: 0x060055B5 RID: 21941 RVA: 0x0017F6F8 File Offset: 0x0017D8F8
			// (set) Token: 0x060055B6 RID: 21942 RVA: 0x000208D4 File Offset: 0x0001EAD4
			public unsafe int __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___7__wrap1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___7__wrap1)) = value;
				}
			}

			// Token: 0x17001608 RID: 5640
			// (get) Token: 0x060055B7 RID: 21943 RVA: 0x0017F720 File Offset: 0x0017D920
			// (set) Token: 0x060055B8 RID: 21944 RVA: 0x000208EF File Offset: 0x0001EAEF
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004515 RID: 17685
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004516 RID: 17686
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004517 RID: 17687
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004518 RID: 17688
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04004519 RID: 17689
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x0400451A RID: 17690
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x0400451B RID: 17691
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400451C RID: 17692
			private static readonly IntPtr NativeFieldInfoPtr__tempInputBuffer_5__1;

			// Token: 0x0400451D RID: 17693
			private static readonly IntPtr NativeFieldInfoPtr__currentOutputIndex_5__2;

			// Token: 0x0400451E RID: 17694
			private static readonly IntPtr NativeFieldInfoPtr__bytesToDeliver_5__3;

			// Token: 0x0400451F RID: 17695
			private static readonly IntPtr NativeFieldInfoPtr__sem_5__4;

			// Token: 0x04004520 RID: 17696
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004521 RID: 17697
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04004522 RID: 17698
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04004523 RID: 17699
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x04004524 RID: 17700
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004525 RID: 17701
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000629 RID: 1577
		[ObfuscatedName("System.Security.Cryptography.CryptoStream+<WriteAsyncInternal>d__37")]
		public sealed class _WriteAsyncInternal_d__37 : ValueType
		{
			// Token: 0x060055B9 RID: 21945 RVA: 0x0017F750 File Offset: 0x0017D950
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteAsyncInternal_d__37()
			{
				Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "<WriteAsyncInternal>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr);
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<>1__state");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<>t__builder");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<>4__this");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "count");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "offset");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "buffer");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "cancellationToken");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__bytesToWrite_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<bytesToWrite>5__1");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__currentInputIndex_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<currentInputIndex>5__2");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__numWholeBlocksInBytes_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<numWholeBlocksInBytes>5__3");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__sem_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<sem>5__4");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<>u__1");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<>u__2");
				CryptoStream._WriteAsyncInternal_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, 100671152);
				CryptoStream._WriteAsyncInternal_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, 100671153);
			}

			// Token: 0x060055BA RID: 21946 RVA: 0x0017F8A8 File Offset: 0x0017DAA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209365, XrefRangeEnd = 209432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream._WriteAsyncInternal_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055BB RID: 21947 RVA: 0x0017F8E0 File Offset: 0x0017DAE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream._WriteAsyncInternal_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060055BC RID: 21948 RVA: 0x0002091D File Offset: 0x0001EB1D
			public _WriteAsyncInternal_d__37(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060055BD RID: 21949 RVA: 0x00020926 File Offset: 0x0001EB26
			public _WriteAsyncInternal_d__37()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr))
			{
			}

			// Token: 0x17001609 RID: 5641
			// (get) Token: 0x060055BE RID: 21950 RVA: 0x0017F928 File Offset: 0x0017DB28
			// (set) Token: 0x060055BF RID: 21951 RVA: 0x00020938 File Offset: 0x0001EB38
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700160A RID: 5642
			// (get) Token: 0x060055C0 RID: 21952 RVA: 0x0017F950 File Offset: 0x0017DB50
			// (set) Token: 0x060055C1 RID: 21953 RVA: 0x00020953 File Offset: 0x0001EB53
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700160B RID: 5643
			// (get) Token: 0x060055C2 RID: 21954 RVA: 0x0017F980 File Offset: 0x0017DB80
			// (set) Token: 0x060055C3 RID: 21955 RVA: 0x00020981 File Offset: 0x0001EB81
			public unsafe CryptoStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CryptoStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700160C RID: 5644
			// (get) Token: 0x060055C4 RID: 21956 RVA: 0x0017F9B0 File Offset: 0x0017DBB0
			// (set) Token: 0x060055C5 RID: 21957 RVA: 0x000209A0 File Offset: 0x0001EBA0
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x1700160D RID: 5645
			// (get) Token: 0x060055C6 RID: 21958 RVA: 0x0017F9D8 File Offset: 0x0017DBD8
			// (set) Token: 0x060055C7 RID: 21959 RVA: 0x000209BB File Offset: 0x0001EBBB
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x1700160E RID: 5646
			// (get) Token: 0x060055C8 RID: 21960 RVA: 0x0017FA00 File Offset: 0x0017DC00
			// (set) Token: 0x060055C9 RID: 21961 RVA: 0x000209D6 File Offset: 0x0001EBD6
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700160F RID: 5647
			// (get) Token: 0x060055CA RID: 21962 RVA: 0x0017FA30 File Offset: 0x0017DC30
			// (set) Token: 0x060055CB RID: 21963 RVA: 0x000209F5 File Offset: 0x0001EBF5
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001610 RID: 5648
			// (get) Token: 0x060055CC RID: 21964 RVA: 0x0017FA60 File Offset: 0x0017DC60
			// (set) Token: 0x060055CD RID: 21965 RVA: 0x00020A23 File Offset: 0x0001EC23
			public unsafe int _bytesToWrite_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__bytesToWrite_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__bytesToWrite_5__1)) = value;
				}
			}

			// Token: 0x17001611 RID: 5649
			// (get) Token: 0x060055CE RID: 21966 RVA: 0x0017FA88 File Offset: 0x0017DC88
			// (set) Token: 0x060055CF RID: 21967 RVA: 0x00020A3E File Offset: 0x0001EC3E
			public unsafe int _currentInputIndex_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__currentInputIndex_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__currentInputIndex_5__2)) = value;
				}
			}

			// Token: 0x17001612 RID: 5650
			// (get) Token: 0x060055D0 RID: 21968 RVA: 0x0017FAB0 File Offset: 0x0017DCB0
			// (set) Token: 0x060055D1 RID: 21969 RVA: 0x00020A59 File Offset: 0x0001EC59
			public unsafe int _numWholeBlocksInBytes_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__numWholeBlocksInBytes_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__numWholeBlocksInBytes_5__3)) = value;
				}
			}

			// Token: 0x17001613 RID: 5651
			// (get) Token: 0x060055D2 RID: 21970 RVA: 0x0017FAD8 File Offset: 0x0017DCD8
			// (set) Token: 0x060055D3 RID: 21971 RVA: 0x00020A74 File Offset: 0x0001EC74
			public unsafe SemaphoreSlim _sem_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__sem_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__sem_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001614 RID: 5652
			// (get) Token: 0x060055D4 RID: 21972 RVA: 0x0017FB08 File Offset: 0x0017DD08
			// (set) Token: 0x060055D5 RID: 21973 RVA: 0x00020A93 File Offset: 0x0001EC93
			public unsafe CryptoStream.HopToThreadPoolAwaitable __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___u__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___u__1)) = value;
				}
			}

			// Token: 0x17001615 RID: 5653
			// (get) Token: 0x060055D6 RID: 21974 RVA: 0x0017FB30 File Offset: 0x0017DD30
			// (set) Token: 0x060055D7 RID: 21975 RVA: 0x00020AAE File Offset: 0x0001ECAE
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004526 RID: 17702
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004527 RID: 17703
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004528 RID: 17704
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004529 RID: 17705
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x0400452A RID: 17706
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x0400452B RID: 17707
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x0400452C RID: 17708
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400452D RID: 17709
			private static readonly IntPtr NativeFieldInfoPtr__bytesToWrite_5__1;

			// Token: 0x0400452E RID: 17710
			private static readonly IntPtr NativeFieldInfoPtr__currentInputIndex_5__2;

			// Token: 0x0400452F RID: 17711
			private static readonly IntPtr NativeFieldInfoPtr__numWholeBlocksInBytes_5__3;

			// Token: 0x04004530 RID: 17712
			private static readonly IntPtr NativeFieldInfoPtr__sem_5__4;

			// Token: 0x04004531 RID: 17713
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004532 RID: 17714
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04004533 RID: 17715
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004534 RID: 17716
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
