using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x0200013F RID: 319
	public class WebRequestStream : WebConnectionStream
	{
		// Token: 0x06001412 RID: 5138 RVA: 0x0005B85C File Offset: 0x00059A5C
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequestStream()
		{
			Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebRequestStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr);
			WebRequestStream.NativeFieldInfoPtr_crlf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "crlf");
			WebRequestStream.NativeFieldInfoPtr_writeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "writeBuffer");
			WebRequestStream.NativeFieldInfoPtr_requestWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "requestWritten");
			WebRequestStream.NativeFieldInfoPtr_allowBuffering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "allowBuffering");
			WebRequestStream.NativeFieldInfoPtr_sendChunked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "sendChunked");
			WebRequestStream.NativeFieldInfoPtr_pendingWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "pendingWrite");
			WebRequestStream.NativeFieldInfoPtr_totalWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "totalWritten");
			WebRequestStream.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "headers");
			WebRequestStream.NativeFieldInfoPtr_headersSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "headersSent");
			WebRequestStream.NativeFieldInfoPtr_completeRequestWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "completeRequestWritten");
			WebRequestStream.NativeFieldInfoPtr_chunkTrailerWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "chunkTrailerWritten");
			WebRequestStream.NativeFieldInfoPtr__KeepAlive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<KeepAlive>k__BackingField");
			WebRequestStream.NativeMethodInfoPtr__ctor_Public_Void_WebConnection_WebOperation_Stream_WebConnectionTunnel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666128);
			WebRequestStream.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666129);
			WebRequestStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666130);
			WebRequestStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666131);
			WebRequestStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666132);
			WebRequestStream.NativeMethodInfoPtr_get_HasWriteBuffer_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666133);
			WebRequestStream.NativeMethodInfoPtr_get_WriteBufferLength_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666134);
			WebRequestStream.NativeMethodInfoPtr_GetWriteBuffer_Internal_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666135);
			WebRequestStream.NativeMethodInfoPtr_FinishWriting_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666136);
			WebRequestStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666137);
			WebRequestStream.NativeMethodInfoPtr_ProcessWrite_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666138);
			WebRequestStream.NativeMethodInfoPtr_CheckWriteOverflow_Private_Void_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666139);
			WebRequestStream.NativeMethodInfoPtr_Initialize_Internal_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666140);
			WebRequestStream.NativeMethodInfoPtr_SetHeadersAsync_Private_Task_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666141);
			WebRequestStream.NativeMethodInfoPtr_WriteRequestAsync_Internal_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666142);
			WebRequestStream.NativeMethodInfoPtr_WriteChunkTrailer_inner_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666143);
			WebRequestStream.NativeMethodInfoPtr_WriteChunkTrailer_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666144);
			WebRequestStream.NativeMethodInfoPtr_KillBuffer_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666145);
			WebRequestStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666146);
			WebRequestStream.NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100666147);
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0005BB0C File Offset: 0x00059D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385712, RefRangeEnd = 385713, XrefRangeStart = 385683, XrefRangeEnd = 385712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequestStream(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tunnel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr__ctor_Public_Void_WebConnection_WebOperation_Stream_WebConnectionTunnel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x0005BB90 File Offset: 0x00059D90
		public unsafe bool KeepAlive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x0005BBCC File Offset: 0x00059DCC
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385713, XrefRangeEnd = 385718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0005BC14 File Offset: 0x00059E14
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x0005BC5C File Offset: 0x00059E5C
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x0005BCA4 File Offset: 0x00059EA4
		public unsafe bool HasWriteBuffer
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 385718, RefRangeEnd = 385720, XrefRangeStart = 385718, XrefRangeEnd = 385718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_get_HasWriteBuffer_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x0005BCE0 File Offset: 0x00059EE0
		public unsafe int WriteBufferLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 385720, RefRangeEnd = 385721, XrefRangeStart = 385720, XrefRangeEnd = 385720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_get_WriteBufferLength_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0005BD1C File Offset: 0x00059F1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385725, RefRangeEnd = 385726, XrefRangeStart = 385721, XrefRangeEnd = 385725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BufferOffsetSize GetWriteBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_GetWriteBuffer_Internal_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr3) : null;
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0005BD5C File Offset: 0x00059F5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 385735, RefRangeEnd = 385737, XrefRangeStart = 385726, XrefRangeEnd = 385735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task FinishWriting(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_FinishWriting_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x0005BDB4 File Offset: 0x00059FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385737, XrefRangeEnd = 385746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x0005BE44 File Offset: 0x0005A044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385755, RefRangeEnd = 385756, XrefRangeStart = 385746, XrefRangeEnd = 385755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ProcessWrite(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_ProcessWrite_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0005BEC8 File Offset: 0x0005A0C8
		[CallerCount(0)]
		public unsafe void CheckWriteOverflow(long contentLength, long totalWritten, long size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalWritten;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_CheckWriteOverflow_Private_Void_Int64_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x0005BF24 File Offset: 0x0005A124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385765, RefRangeEnd = 385766, XrefRangeStart = 385756, XrefRangeEnd = 385765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Initialize(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_Initialize_Internal_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0005BF7C File Offset: 0x0005A17C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 385775, RefRangeEnd = 385777, XrefRangeStart = 385766, XrefRangeEnd = 385775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref setInternalLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_SetHeadersAsync_Private_Task_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0005BFE0 File Offset: 0x0005A1E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 385786, RefRangeEnd = 385788, XrefRangeStart = 385777, XrefRangeEnd = 385786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteRequestAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_WriteRequestAsync_Internal_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0005C038 File Offset: 0x0005A238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385797, RefRangeEnd = 385798, XrefRangeStart = 385788, XrefRangeEnd = 385797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteChunkTrailer_inner(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_WriteChunkTrailer_inner_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0005C090 File Offset: 0x0005A290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385798, XrefRangeEnd = 385807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteChunkTrailer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_WriteChunkTrailer_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0005C0D0 File Offset: 0x0005A2D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385807, RefRangeEnd = 385808, XrefRangeStart = 385807, XrefRangeEnd = 385807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KillBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_KillBuffer_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0005C104 File Offset: 0x0005A304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385808, XrefRangeEnd = 385821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0005C194 File Offset: 0x0005A394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385821, XrefRangeEnd = 385825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close_internal(ref bool disposed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &disposed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x0000A317 File Offset: 0x00008517
		public WebRequestStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x0005C1E0 File Offset: 0x0005A3E0
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x0000A320 File Offset: 0x00008520
		public unsafe static Il2CppStructArray<byte> crlf
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequestStream.NativeFieldInfoPtr_crlf, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequestStream.NativeFieldInfoPtr_crlf, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x0005C208 File Offset: 0x0005A408
		// (set) Token: 0x0600142B RID: 5163 RVA: 0x0000A332 File Offset: 0x00008532
		public unsafe MemoryStream writeBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_writeBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_writeBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x0005C238 File Offset: 0x0005A438
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x0000A351 File Offset: 0x00008551
		public unsafe bool requestWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_requestWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_requestWritten)) = value;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x0005C260 File Offset: 0x0005A460
		// (set) Token: 0x0600142F RID: 5167 RVA: 0x0000A36C File Offset: 0x0000856C
		public unsafe bool allowBuffering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_allowBuffering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_allowBuffering)) = value;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x0005C288 File Offset: 0x0005A488
		// (set) Token: 0x06001431 RID: 5169 RVA: 0x0000A387 File Offset: 0x00008587
		public unsafe bool sendChunked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_sendChunked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_sendChunked)) = value;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x0005C2B0 File Offset: 0x0005A4B0
		// (set) Token: 0x06001433 RID: 5171 RVA: 0x0000A3A2 File Offset: 0x000085A2
		public unsafe WebCompletionSource pendingWrite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_pendingWrite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_pendingWrite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x0005C2E0 File Offset: 0x0005A4E0
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x0000A3C1 File Offset: 0x000085C1
		public unsafe long totalWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_totalWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_totalWritten)) = value;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x0005C308 File Offset: 0x0005A508
		// (set) Token: 0x06001437 RID: 5175 RVA: 0x0000A3DC File Offset: 0x000085DC
		public unsafe Il2CppStructArray<byte> headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x0005C338 File Offset: 0x0005A538
		// (set) Token: 0x06001439 RID: 5177 RVA: 0x0000A3FB File Offset: 0x000085FB
		public unsafe bool headersSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_headersSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_headersSent)) = value;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x0005C360 File Offset: 0x0005A560
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x0000A416 File Offset: 0x00008616
		public unsafe int completeRequestWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_completeRequestWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_completeRequestWritten)) = value;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x0005C388 File Offset: 0x0005A588
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x0000A431 File Offset: 0x00008631
		public unsafe int chunkTrailerWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_chunkTrailerWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_chunkTrailerWritten)) = value;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x0005C3B0 File Offset: 0x0005A5B0
		// (set) Token: 0x0600143F RID: 5183 RVA: 0x0000A44C File Offset: 0x0000864C
		public unsafe bool _KeepAlive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr__KeepAlive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr__KeepAlive_k__BackingField)) = value;
			}
		}

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeFieldInfoPtr_crlf;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeFieldInfoPtr_writeBuffer;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeFieldInfoPtr_requestWritten;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeFieldInfoPtr_allowBuffering;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeFieldInfoPtr_sendChunked;

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeFieldInfoPtr_pendingWrite;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeFieldInfoPtr_totalWritten;

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeFieldInfoPtr_headersSent;

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeFieldInfoPtr_completeRequestWritten;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeFieldInfoPtr_chunkTrailerWritten;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeFieldInfoPtr__KeepAlive_k__BackingField;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WebConnection_WebOperation_Stream_WebConnectionTunnel_0;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeMethodInfoPtr_get_HasWriteBuffer_Internal_get_Boolean_0;

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteBufferLength_Internal_get_Int32_0;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeMethodInfoPtr_GetWriteBuffer_Internal_BufferOffsetSize_0;

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeMethodInfoPtr_FinishWriting_Private_Task_CancellationToken_0;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeMethodInfoPtr_ProcessWrite_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeMethodInfoPtr_CheckWriteOverflow_Private_Void_Int64_Int64_Int64_0;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Task_CancellationToken_0;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeMethodInfoPtr_SetHeadersAsync_Private_Task_Boolean_CancellationToken_0;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeMethodInfoPtr_WriteRequestAsync_Internal_Task_CancellationToken_0;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeMethodInfoPtr_WriteChunkTrailer_inner_Private_Task_CancellationToken_0;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeMethodInfoPtr_WriteChunkTrailer_Private_Task_0;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr_KillBuffer_Internal_Void_0;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0;

		// Token: 0x020001FF RID: 511
		[ObfuscatedName("System.Net.WebRequestStream+<FinishWriting>d__30")]
		public sealed class _FinishWriting_d__30 : ValueType
		{
			// Token: 0x06001BF4 RID: 7156 RVA: 0x000743C4 File Offset: 0x000725C4
			// Note: this type is marked as 'beforefieldinit'.
			static _FinishWriting_d__30()
			{
				Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<FinishWriting>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr);
				WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr, "<>1__state");
				WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr, "<>t__builder");
				WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr, "<>4__this");
				WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr, "cancellationToken");
				WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr, "<>u__1");
				WebRequestStream._FinishWriting_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr, 100666149);
				WebRequestStream._FinishWriting_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr, 100666150);
			}

			// Token: 0x06001BF5 RID: 7157 RVA: 0x0007447C File Offset: 0x0007267C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385435, XrefRangeEnd = 385453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._FinishWriting_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BF6 RID: 7158 RVA: 0x000744B4 File Offset: 0x000726B4
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._FinishWriting_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BF7 RID: 7159 RVA: 0x0000ED50 File Offset: 0x0000CF50
			public _FinishWriting_d__30(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001BF8 RID: 7160 RVA: 0x0000ED59 File Offset: 0x0000CF59
			public _FinishWriting_d__30()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr))
			{
			}

			// Token: 0x170008F2 RID: 2290
			// (get) Token: 0x06001BF9 RID: 7161 RVA: 0x000744FC File Offset: 0x000726FC
			// (set) Token: 0x06001BFA RID: 7162 RVA: 0x0000ED6B File Offset: 0x0000CF6B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008F3 RID: 2291
			// (get) Token: 0x06001BFB RID: 7163 RVA: 0x00074524 File Offset: 0x00072724
			// (set) Token: 0x06001BFC RID: 7164 RVA: 0x0000ED86 File Offset: 0x0000CF86
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008F4 RID: 2292
			// (get) Token: 0x06001BFD RID: 7165 RVA: 0x00074554 File Offset: 0x00072754
			// (set) Token: 0x06001BFE RID: 7166 RVA: 0x0000EDB4 File Offset: 0x0000CFB4
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F5 RID: 2293
			// (get) Token: 0x06001BFF RID: 7167 RVA: 0x00074584 File Offset: 0x00072784
			// (set) Token: 0x06001C00 RID: 7168 RVA: 0x0000EDD3 File Offset: 0x0000CFD3
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008F6 RID: 2294
			// (get) Token: 0x06001C01 RID: 7169 RVA: 0x000745B4 File Offset: 0x000727B4
			// (set) Token: 0x06001C02 RID: 7170 RVA: 0x0000EE01 File Offset: 0x0000D001
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001595 RID: 5525
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001596 RID: 5526
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001597 RID: 5527
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001598 RID: 5528
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001599 RID: 5529
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400159A RID: 5530
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400159B RID: 5531
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000200 RID: 512
		[ObfuscatedName("System.Net.WebRequestStream+<WriteAsync>d__31")]
		public sealed class _WriteAsync_d__31 : ValueType
		{
			// Token: 0x06001C03 RID: 7171 RVA: 0x000745E4 File Offset: 0x000727E4
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteAsync_d__31()
			{
				Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<WriteAsync>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr);
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "<>1__state");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "<>t__builder");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "<>4__this");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "cancellationToken");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "buffer");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "offset");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "size");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr__completion_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "<completion>5__1");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "<>u__1");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "<>u__2");
				WebRequestStream._WriteAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, 100666151);
				WebRequestStream._WriteAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, 100666152);
			}

			// Token: 0x06001C04 RID: 7172 RVA: 0x00074700 File Offset: 0x00072900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385453, XrefRangeEnd = 385483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C05 RID: 7173 RVA: 0x00074738 File Offset: 0x00072938
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C06 RID: 7174 RVA: 0x0000EE2F File Offset: 0x0000D02F
			public _WriteAsync_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C07 RID: 7175 RVA: 0x0000EE38 File Offset: 0x0000D038
			public _WriteAsync_d__31()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr))
			{
			}

			// Token: 0x170008F7 RID: 2295
			// (get) Token: 0x06001C08 RID: 7176 RVA: 0x00074780 File Offset: 0x00072980
			// (set) Token: 0x06001C09 RID: 7177 RVA: 0x0000EE4A File Offset: 0x0000D04A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008F8 RID: 2296
			// (get) Token: 0x06001C0A RID: 7178 RVA: 0x000747A8 File Offset: 0x000729A8
			// (set) Token: 0x06001C0B RID: 7179 RVA: 0x0000EE65 File Offset: 0x0000D065
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008F9 RID: 2297
			// (get) Token: 0x06001C0C RID: 7180 RVA: 0x000747D8 File Offset: 0x000729D8
			// (set) Token: 0x06001C0D RID: 7181 RVA: 0x0000EE93 File Offset: 0x0000D093
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008FA RID: 2298
			// (get) Token: 0x06001C0E RID: 7182 RVA: 0x00074808 File Offset: 0x00072A08
			// (set) Token: 0x06001C0F RID: 7183 RVA: 0x0000EEB2 File Offset: 0x0000D0B2
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008FB RID: 2299
			// (get) Token: 0x06001C10 RID: 7184 RVA: 0x00074838 File Offset: 0x00072A38
			// (set) Token: 0x06001C11 RID: 7185 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008FC RID: 2300
			// (get) Token: 0x06001C12 RID: 7186 RVA: 0x00074868 File Offset: 0x00072A68
			// (set) Token: 0x06001C13 RID: 7187 RVA: 0x0000EEFF File Offset: 0x0000D0FF
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x170008FD RID: 2301
			// (get) Token: 0x06001C14 RID: 7188 RVA: 0x00074890 File Offset: 0x00072A90
			// (set) Token: 0x06001C15 RID: 7189 RVA: 0x0000EF1A File Offset: 0x0000D11A
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x170008FE RID: 2302
			// (get) Token: 0x06001C16 RID: 7190 RVA: 0x000748B8 File Offset: 0x00072AB8
			// (set) Token: 0x06001C17 RID: 7191 RVA: 0x0000EF35 File Offset: 0x0000D135
			public unsafe WebCompletionSource _completion_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr__completion_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr__completion_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008FF RID: 2303
			// (get) Token: 0x06001C18 RID: 7192 RVA: 0x000748E8 File Offset: 0x00072AE8
			// (set) Token: 0x06001C19 RID: 7193 RVA: 0x0000EF54 File Offset: 0x0000D154
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000900 RID: 2304
			// (get) Token: 0x06001C1A RID: 7194 RVA: 0x00074918 File Offset: 0x00072B18
			// (set) Token: 0x06001C1B RID: 7195 RVA: 0x0000EF82 File Offset: 0x0000D182
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400159C RID: 5532
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400159D RID: 5533
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400159E RID: 5534
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400159F RID: 5535
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040015A0 RID: 5536
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x040015A1 RID: 5537
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x040015A2 RID: 5538
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x040015A3 RID: 5539
			private static readonly IntPtr NativeFieldInfoPtr__completion_5__1;

			// Token: 0x040015A4 RID: 5540
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040015A5 RID: 5541
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040015A6 RID: 5542
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015A7 RID: 5543
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000201 RID: 513
		[ObfuscatedName("System.Net.WebRequestStream+<ProcessWrite>d__32")]
		public sealed class _ProcessWrite_d__32 : ValueType
		{
			// Token: 0x06001C1C RID: 7196 RVA: 0x00074948 File Offset: 0x00072B48
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessWrite_d__32()
			{
				Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<ProcessWrite>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr);
				WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, "<>1__state");
				WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, "<>t__builder");
				WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, "<>4__this");
				WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, "cancellationToken");
				WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, "size");
				WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, "buffer");
				WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, "offset");
				WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, "<>u__1");
				WebRequestStream._ProcessWrite_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, 100666153);
				WebRequestStream._ProcessWrite_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, 100666154);
			}

			// Token: 0x06001C1D RID: 7197 RVA: 0x00074A3C File Offset: 0x00072C3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385483, XrefRangeEnd = 385529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._ProcessWrite_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C1E RID: 7198 RVA: 0x00074A74 File Offset: 0x00072C74
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._ProcessWrite_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C1F RID: 7199 RVA: 0x0000EFB0 File Offset: 0x0000D1B0
			public _ProcessWrite_d__32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C20 RID: 7200 RVA: 0x0000EFB9 File Offset: 0x0000D1B9
			public _ProcessWrite_d__32()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr))
			{
			}

			// Token: 0x17000901 RID: 2305
			// (get) Token: 0x06001C21 RID: 7201 RVA: 0x00074ABC File Offset: 0x00072CBC
			// (set) Token: 0x06001C22 RID: 7202 RVA: 0x0000EFCB File Offset: 0x0000D1CB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000902 RID: 2306
			// (get) Token: 0x06001C23 RID: 7203 RVA: 0x00074AE4 File Offset: 0x00072CE4
			// (set) Token: 0x06001C24 RID: 7204 RVA: 0x0000EFE6 File Offset: 0x0000D1E6
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000903 RID: 2307
			// (get) Token: 0x06001C25 RID: 7205 RVA: 0x00074B14 File Offset: 0x00072D14
			// (set) Token: 0x06001C26 RID: 7206 RVA: 0x0000F014 File Offset: 0x0000D214
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000904 RID: 2308
			// (get) Token: 0x06001C27 RID: 7207 RVA: 0x00074B44 File Offset: 0x00072D44
			// (set) Token: 0x06001C28 RID: 7208 RVA: 0x0000F033 File Offset: 0x0000D233
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000905 RID: 2309
			// (get) Token: 0x06001C29 RID: 7209 RVA: 0x00074B74 File Offset: 0x00072D74
			// (set) Token: 0x06001C2A RID: 7210 RVA: 0x0000F061 File Offset: 0x0000D261
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x17000906 RID: 2310
			// (get) Token: 0x06001C2B RID: 7211 RVA: 0x00074B9C File Offset: 0x00072D9C
			// (set) Token: 0x06001C2C RID: 7212 RVA: 0x0000F07C File Offset: 0x0000D27C
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000907 RID: 2311
			// (get) Token: 0x06001C2D RID: 7213 RVA: 0x00074BCC File Offset: 0x00072DCC
			// (set) Token: 0x06001C2E RID: 7214 RVA: 0x0000F09B File Offset: 0x0000D29B
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17000908 RID: 2312
			// (get) Token: 0x06001C2F RID: 7215 RVA: 0x00074BF4 File Offset: 0x00072DF4
			// (set) Token: 0x06001C30 RID: 7216 RVA: 0x0000F0B6 File Offset: 0x0000D2B6
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040015A8 RID: 5544
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015A9 RID: 5545
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040015AA RID: 5546
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015AB RID: 5547
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040015AC RID: 5548
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x040015AD RID: 5549
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x040015AE RID: 5550
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x040015AF RID: 5551
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040015B0 RID: 5552
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015B1 RID: 5553
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000202 RID: 514
		[ObfuscatedName("System.Net.WebRequestStream+<Initialize>d__34")]
		public sealed class _Initialize_d__34 : ValueType
		{
			// Token: 0x06001C31 RID: 7217 RVA: 0x00074C24 File Offset: 0x00072E24
			// Note: this type is marked as 'beforefieldinit'.
			static _Initialize_d__34()
			{
				Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<Initialize>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr);
				WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr, "<>1__state");
				WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr, "<>t__builder");
				WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr, "<>4__this");
				WebRequestStream._Initialize_d__34.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr, "cancellationToken");
				WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr, "<>u__1");
				WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr, "<>u__2");
				WebRequestStream._Initialize_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr, 100666155);
				WebRequestStream._Initialize_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr, 100666156);
			}

			// Token: 0x06001C32 RID: 7218 RVA: 0x00074CF0 File Offset: 0x00072EF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385529, XrefRangeEnd = 385548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._Initialize_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C33 RID: 7219 RVA: 0x00074D28 File Offset: 0x00072F28
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._Initialize_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C34 RID: 7220 RVA: 0x0000F0E4 File Offset: 0x0000D2E4
			public _Initialize_d__34(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C35 RID: 7221 RVA: 0x0000F0ED File Offset: 0x0000D2ED
			public _Initialize_d__34()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr))
			{
			}

			// Token: 0x17000909 RID: 2313
			// (get) Token: 0x06001C36 RID: 7222 RVA: 0x00074D70 File Offset: 0x00072F70
			// (set) Token: 0x06001C37 RID: 7223 RVA: 0x0000F0FF File Offset: 0x0000D2FF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700090A RID: 2314
			// (get) Token: 0x06001C38 RID: 7224 RVA: 0x00074D98 File Offset: 0x00072F98
			// (set) Token: 0x06001C39 RID: 7225 RVA: 0x0000F11A File Offset: 0x0000D31A
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700090B RID: 2315
			// (get) Token: 0x06001C3A RID: 7226 RVA: 0x00074DC8 File Offset: 0x00072FC8
			// (set) Token: 0x06001C3B RID: 7227 RVA: 0x0000F148 File Offset: 0x0000D348
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700090C RID: 2316
			// (get) Token: 0x06001C3C RID: 7228 RVA: 0x00074DF8 File Offset: 0x00072FF8
			// (set) Token: 0x06001C3D RID: 7229 RVA: 0x0000F167 File Offset: 0x0000D367
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700090D RID: 2317
			// (get) Token: 0x06001C3E RID: 7230 RVA: 0x00074E28 File Offset: 0x00073028
			// (set) Token: 0x06001C3F RID: 7231 RVA: 0x0000F195 File Offset: 0x0000D395
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700090E RID: 2318
			// (get) Token: 0x06001C40 RID: 7232 RVA: 0x00074E58 File Offset: 0x00073058
			// (set) Token: 0x06001C41 RID: 7233 RVA: 0x0000F1C3 File Offset: 0x0000D3C3
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040015B2 RID: 5554
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015B3 RID: 5555
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040015B4 RID: 5556
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015B5 RID: 5557
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040015B6 RID: 5558
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040015B7 RID: 5559
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040015B8 RID: 5560
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015B9 RID: 5561
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000203 RID: 515
		[ObfuscatedName("System.Net.WebRequestStream+<SetHeadersAsync>d__35")]
		public sealed class _SetHeadersAsync_d__35 : ValueType
		{
			// Token: 0x06001C42 RID: 7234 RVA: 0x00074E88 File Offset: 0x00073088
			// Note: this type is marked as 'beforefieldinit'.
			static _SetHeadersAsync_d__35()
			{
				Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<SetHeadersAsync>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr);
				WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr, "<>1__state");
				WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr, "<>t__builder");
				WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr, "<>4__this");
				WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr, "cancellationToken");
				WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr_setInternalLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr, "setInternalLength");
				WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr, "<>u__1");
				WebRequestStream._SetHeadersAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr, 100666157);
				WebRequestStream._SetHeadersAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr, 100666158);
			}

			// Token: 0x06001C43 RID: 7235 RVA: 0x00074F54 File Offset: 0x00073154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385548, XrefRangeEnd = 385594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._SetHeadersAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C44 RID: 7236 RVA: 0x00074F8C File Offset: 0x0007318C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._SetHeadersAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C45 RID: 7237 RVA: 0x0000F1F1 File Offset: 0x0000D3F1
			public _SetHeadersAsync_d__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C46 RID: 7238 RVA: 0x0000F1FA File Offset: 0x0000D3FA
			public _SetHeadersAsync_d__35()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr))
			{
			}

			// Token: 0x1700090F RID: 2319
			// (get) Token: 0x06001C47 RID: 7239 RVA: 0x00074FD4 File Offset: 0x000731D4
			// (set) Token: 0x06001C48 RID: 7240 RVA: 0x0000F20C File Offset: 0x0000D40C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000910 RID: 2320
			// (get) Token: 0x06001C49 RID: 7241 RVA: 0x00074FFC File Offset: 0x000731FC
			// (set) Token: 0x06001C4A RID: 7242 RVA: 0x0000F227 File Offset: 0x0000D427
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000911 RID: 2321
			// (get) Token: 0x06001C4B RID: 7243 RVA: 0x0007502C File Offset: 0x0007322C
			// (set) Token: 0x06001C4C RID: 7244 RVA: 0x0000F255 File Offset: 0x0000D455
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000912 RID: 2322
			// (get) Token: 0x06001C4D RID: 7245 RVA: 0x0007505C File Offset: 0x0007325C
			// (set) Token: 0x06001C4E RID: 7246 RVA: 0x0000F274 File Offset: 0x0000D474
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000913 RID: 2323
			// (get) Token: 0x06001C4F RID: 7247 RVA: 0x0007508C File Offset: 0x0007328C
			// (set) Token: 0x06001C50 RID: 7248 RVA: 0x0000F2A2 File Offset: 0x0000D4A2
			public unsafe bool setInternalLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr_setInternalLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr_setInternalLength)) = value;
				}
			}

			// Token: 0x17000914 RID: 2324
			// (get) Token: 0x06001C51 RID: 7249 RVA: 0x000750B4 File Offset: 0x000732B4
			// (set) Token: 0x06001C52 RID: 7250 RVA: 0x0000F2BD File Offset: 0x0000D4BD
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040015BA RID: 5562
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015BB RID: 5563
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040015BC RID: 5564
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015BD RID: 5565
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040015BE RID: 5566
			private static readonly IntPtr NativeFieldInfoPtr_setInternalLength;

			// Token: 0x040015BF RID: 5567
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040015C0 RID: 5568
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015C1 RID: 5569
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000204 RID: 516
		[ObfuscatedName("System.Net.WebRequestStream+<WriteRequestAsync>d__36")]
		public sealed class _WriteRequestAsync_d__36 : ValueType
		{
			// Token: 0x06001C53 RID: 7251 RVA: 0x000750E4 File Offset: 0x000732E4
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteRequestAsync_d__36()
			{
				Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<WriteRequestAsync>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr);
				WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, "<>1__state");
				WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, "<>t__builder");
				WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, "<>4__this");
				WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, "cancellationToken");
				WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr__buffer_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, "<buffer>5__1");
				WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, "<>u__1");
				WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, "<>u__2");
				WebRequestStream._WriteRequestAsync_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, 100666159);
				WebRequestStream._WriteRequestAsync_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, 100666160);
			}

			// Token: 0x06001C54 RID: 7252 RVA: 0x000751C4 File Offset: 0x000733C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385594, XrefRangeEnd = 385624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteRequestAsync_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C55 RID: 7253 RVA: 0x000751FC File Offset: 0x000733FC
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteRequestAsync_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C56 RID: 7254 RVA: 0x0000F2EB File Offset: 0x0000D4EB
			public _WriteRequestAsync_d__36(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C57 RID: 7255 RVA: 0x0000F2F4 File Offset: 0x0000D4F4
			public _WriteRequestAsync_d__36()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr))
			{
			}

			// Token: 0x17000915 RID: 2325
			// (get) Token: 0x06001C58 RID: 7256 RVA: 0x00075244 File Offset: 0x00073444
			// (set) Token: 0x06001C59 RID: 7257 RVA: 0x0000F306 File Offset: 0x0000D506
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000916 RID: 2326
			// (get) Token: 0x06001C5A RID: 7258 RVA: 0x0007526C File Offset: 0x0007346C
			// (set) Token: 0x06001C5B RID: 7259 RVA: 0x0000F321 File Offset: 0x0000D521
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000917 RID: 2327
			// (get) Token: 0x06001C5C RID: 7260 RVA: 0x0007529C File Offset: 0x0007349C
			// (set) Token: 0x06001C5D RID: 7261 RVA: 0x0000F34F File Offset: 0x0000D54F
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000918 RID: 2328
			// (get) Token: 0x06001C5E RID: 7262 RVA: 0x000752CC File Offset: 0x000734CC
			// (set) Token: 0x06001C5F RID: 7263 RVA: 0x0000F36E File Offset: 0x0000D56E
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000919 RID: 2329
			// (get) Token: 0x06001C60 RID: 7264 RVA: 0x000752FC File Offset: 0x000734FC
			// (set) Token: 0x06001C61 RID: 7265 RVA: 0x0000F39C File Offset: 0x0000D59C
			public unsafe BufferOffsetSize _buffer_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr__buffer_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr__buffer_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700091A RID: 2330
			// (get) Token: 0x06001C62 RID: 7266 RVA: 0x0007532C File Offset: 0x0007352C
			// (set) Token: 0x06001C63 RID: 7267 RVA: 0x0000F3BB File Offset: 0x0000D5BB
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700091B RID: 2331
			// (get) Token: 0x06001C64 RID: 7268 RVA: 0x0007535C File Offset: 0x0007355C
			// (set) Token: 0x06001C65 RID: 7269 RVA: 0x0000F3E9 File Offset: 0x0000D5E9
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040015C2 RID: 5570
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015C3 RID: 5571
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040015C4 RID: 5572
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015C5 RID: 5573
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040015C6 RID: 5574
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__1;

			// Token: 0x040015C7 RID: 5575
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040015C8 RID: 5576
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040015C9 RID: 5577
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015CA RID: 5578
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000205 RID: 517
		[ObfuscatedName("System.Net.WebRequestStream+<WriteChunkTrailer_inner>d__37")]
		public sealed class _WriteChunkTrailer_inner_d__37 : ValueType
		{
			// Token: 0x06001C66 RID: 7270 RVA: 0x0007538C File Offset: 0x0007358C
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteChunkTrailer_inner_d__37()
			{
				Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<WriteChunkTrailer_inner>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr);
				WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr, "<>1__state");
				WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr, "<>t__builder");
				WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr, "<>4__this");
				WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr, "cancellationToken");
				WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr, "<>u__1");
				WebRequestStream._WriteChunkTrailer_inner_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr, 100666161);
				WebRequestStream._WriteChunkTrailer_inner_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr, 100666162);
			}

			// Token: 0x06001C67 RID: 7271 RVA: 0x00075444 File Offset: 0x00073644
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385624, XrefRangeEnd = 385640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C68 RID: 7272 RVA: 0x0007547C File Offset: 0x0007367C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C69 RID: 7273 RVA: 0x0000F417 File Offset: 0x0000D617
			public _WriteChunkTrailer_inner_d__37(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C6A RID: 7274 RVA: 0x0000F420 File Offset: 0x0000D620
			public _WriteChunkTrailer_inner_d__37()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr))
			{
			}

			// Token: 0x1700091C RID: 2332
			// (get) Token: 0x06001C6B RID: 7275 RVA: 0x000754C4 File Offset: 0x000736C4
			// (set) Token: 0x06001C6C RID: 7276 RVA: 0x0000F432 File Offset: 0x0000D632
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700091D RID: 2333
			// (get) Token: 0x06001C6D RID: 7277 RVA: 0x000754EC File Offset: 0x000736EC
			// (set) Token: 0x06001C6E RID: 7278 RVA: 0x0000F44D File Offset: 0x0000D64D
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700091E RID: 2334
			// (get) Token: 0x06001C6F RID: 7279 RVA: 0x0007551C File Offset: 0x0007371C
			// (set) Token: 0x06001C70 RID: 7280 RVA: 0x0000F47B File Offset: 0x0000D67B
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700091F RID: 2335
			// (get) Token: 0x06001C71 RID: 7281 RVA: 0x0007554C File Offset: 0x0007374C
			// (set) Token: 0x06001C72 RID: 7282 RVA: 0x0000F49A File Offset: 0x0000D69A
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000920 RID: 2336
			// (get) Token: 0x06001C73 RID: 7283 RVA: 0x0007557C File Offset: 0x0007377C
			// (set) Token: 0x06001C74 RID: 7284 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040015CB RID: 5579
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015CC RID: 5580
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040015CD RID: 5581
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015CE RID: 5582
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040015CF RID: 5583
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040015D0 RID: 5584
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015D1 RID: 5585
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000206 RID: 518
		[ObfuscatedName("System.Net.WebRequestStream+<WriteChunkTrailer>d__38")]
		public sealed class _WriteChunkTrailer_d__38 : ValueType
		{
			// Token: 0x06001C75 RID: 7285 RVA: 0x000755AC File Offset: 0x000737AC
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteChunkTrailer_d__38()
			{
				Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<WriteChunkTrailer>d__38");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr);
				WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, "<>1__state");
				WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, "<>t__builder");
				WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, "<>4__this");
				WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr__timeoutTask_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, "<timeoutTask>5__1");
				WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr__cts_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, "<cts>5__2");
				WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, "<>u__1");
				WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, "<>u__2");
				WebRequestStream._WriteChunkTrailer_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, 100666163);
				WebRequestStream._WriteChunkTrailer_d__38.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, 100666164);
			}

			// Token: 0x06001C76 RID: 7286 RVA: 0x0007568C File Offset: 0x0007388C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385640, XrefRangeEnd = 385683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteChunkTrailer_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C77 RID: 7287 RVA: 0x000756C4 File Offset: 0x000738C4
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteChunkTrailer_d__38.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C78 RID: 7288 RVA: 0x0000F4F6 File Offset: 0x0000D6F6
			public _WriteChunkTrailer_d__38(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C79 RID: 7289 RVA: 0x0000F4FF File Offset: 0x0000D6FF
			public _WriteChunkTrailer_d__38()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr))
			{
			}

			// Token: 0x17000921 RID: 2337
			// (get) Token: 0x06001C7A RID: 7290 RVA: 0x0007570C File Offset: 0x0007390C
			// (set) Token: 0x06001C7B RID: 7291 RVA: 0x0000F511 File Offset: 0x0000D711
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000922 RID: 2338
			// (get) Token: 0x06001C7C RID: 7292 RVA: 0x00075734 File Offset: 0x00073934
			// (set) Token: 0x06001C7D RID: 7293 RVA: 0x0000F52C File Offset: 0x0000D72C
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000923 RID: 2339
			// (get) Token: 0x06001C7E RID: 7294 RVA: 0x00075764 File Offset: 0x00073964
			// (set) Token: 0x06001C7F RID: 7295 RVA: 0x0000F55A File Offset: 0x0000D75A
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000924 RID: 2340
			// (get) Token: 0x06001C80 RID: 7296 RVA: 0x00075794 File Offset: 0x00073994
			// (set) Token: 0x06001C81 RID: 7297 RVA: 0x0000F579 File Offset: 0x0000D779
			public unsafe Task _timeoutTask_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr__timeoutTask_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr__timeoutTask_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000925 RID: 2341
			// (get) Token: 0x06001C82 RID: 7298 RVA: 0x000757C4 File Offset: 0x000739C4
			// (set) Token: 0x06001C83 RID: 7299 RVA: 0x0000F598 File Offset: 0x0000D798
			public unsafe CancellationTokenSource _cts_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr__cts_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr__cts_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000926 RID: 2342
			// (get) Token: 0x06001C84 RID: 7300 RVA: 0x000757F4 File Offset: 0x000739F4
			// (set) Token: 0x06001C85 RID: 7301 RVA: 0x0000F5B7 File Offset: 0x0000D7B7
			public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000927 RID: 2343
			// (get) Token: 0x06001C86 RID: 7302 RVA: 0x00075824 File Offset: 0x00073A24
			// (set) Token: 0x06001C87 RID: 7303 RVA: 0x0000F5E5 File Offset: 0x0000D7E5
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040015D2 RID: 5586
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015D3 RID: 5587
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040015D4 RID: 5588
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015D5 RID: 5589
			private static readonly IntPtr NativeFieldInfoPtr__timeoutTask_5__1;

			// Token: 0x040015D6 RID: 5590
			private static readonly IntPtr NativeFieldInfoPtr__cts_5__2;

			// Token: 0x040015D7 RID: 5591
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040015D8 RID: 5592
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040015D9 RID: 5593
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015DA RID: 5594
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
