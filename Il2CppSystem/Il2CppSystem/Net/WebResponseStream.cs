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
	// Token: 0x02000140 RID: 320
	public class WebResponseStream : WebConnectionStream
	{
		// Token: 0x06001440 RID: 5184 RVA: 0x0005C3D8 File Offset: 0x0005A5D8
		// Note: this type is marked as 'beforefieldinit'.
		static WebResponseStream()
		{
			Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebResponseStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr);
			WebResponseStream.NativeFieldInfoPtr_readBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "readBuffer");
			WebResponseStream.NativeFieldInfoPtr_contentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "contentLength");
			WebResponseStream.NativeFieldInfoPtr_totalRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "totalRead");
			WebResponseStream.NativeFieldInfoPtr_nextReadCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "nextReadCalled");
			WebResponseStream.NativeFieldInfoPtr_stream_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "stream_length");
			WebResponseStream.NativeFieldInfoPtr_pendingRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "pendingRead");
			WebResponseStream.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "locker");
			WebResponseStream.NativeFieldInfoPtr_nestedRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "nestedRead");
			WebResponseStream.NativeFieldInfoPtr_read_eof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "read_eof");
			WebResponseStream.NativeFieldInfoPtr__RequestStream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<RequestStream>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__Headers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<Headers>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__StatusCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<StatusCode>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__StatusDescription_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<StatusDescription>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<Version>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__KeepAlive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<KeepAlive>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__ChunkedRead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<ChunkedRead>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__ChunkStream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<ChunkStream>k__BackingField");
			WebResponseStream.NativeMethodInfoPtr_get_RequestStream_Public_get_WebRequestStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666165);
			WebResponseStream.NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666166);
			WebResponseStream.NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666167);
			WebResponseStream.NativeMethodInfoPtr_get_StatusCode_Public_get_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666168);
			WebResponseStream.NativeMethodInfoPtr_set_StatusCode_Private_set_Void_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666169);
			WebResponseStream.NativeMethodInfoPtr_get_StatusDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666170);
			WebResponseStream.NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666171);
			WebResponseStream.NativeMethodInfoPtr_get_Version_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666172);
			WebResponseStream.NativeMethodInfoPtr_set_Version_Private_set_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666173);
			WebResponseStream.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666174);
			WebResponseStream.NativeMethodInfoPtr_set_KeepAlive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666175);
			WebResponseStream.NativeMethodInfoPtr__ctor_Public_Void_WebRequestStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666176);
			WebResponseStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666177);
			WebResponseStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666178);
			WebResponseStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666179);
			WebResponseStream.NativeMethodInfoPtr_get_ChunkedRead_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666180);
			WebResponseStream.NativeMethodInfoPtr_set_ChunkedRead_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666181);
			WebResponseStream.NativeMethodInfoPtr_get_ChunkStream_Protected_get_MonoChunkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666182);
			WebResponseStream.NativeMethodInfoPtr_set_ChunkStream_Private_set_Void_MonoChunkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666183);
			WebResponseStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666184);
			WebResponseStream.NativeMethodInfoPtr_ProcessRead_Private_Task_1_ValueTuple_2_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666185);
			WebResponseStream.NativeMethodInfoPtr_InnerReadAsync_Internal_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666186);
			WebResponseStream.NativeMethodInfoPtr_EnsureReadAsync_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666187);
			WebResponseStream.NativeMethodInfoPtr_CheckAuthHeader_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666188);
			WebResponseStream.NativeMethodInfoPtr_IsNtlmAuth_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666189);
			WebResponseStream.NativeMethodInfoPtr_get_ExpectContent_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666190);
			WebResponseStream.NativeMethodInfoPtr_Initialize_Private_Task_BufferOffsetSize_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666191);
			WebResponseStream.NativeMethodInfoPtr_ReadAllAsync_Internal_Task_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666192);
			WebResponseStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666193);
			WebResponseStream.NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666194);
			WebResponseStream.NativeMethodInfoPtr_GetReadException_Private_WebException_WebExceptionStatus_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666195);
			WebResponseStream.NativeMethodInfoPtr_InitReadAsync_Internal_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666196);
			WebResponseStream.NativeMethodInfoPtr_GetResponse_Private_Boolean_BufferOffsetSize_byref_Int32_byref_ReadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100666197);
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x0005C7F0 File Offset: 0x0005A9F0
		public unsafe WebRequestStream RequestStream
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_RequestStream_Public_get_WebRequestStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr3) : null;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x0005C830 File Offset: 0x0005AA30
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x0005C870 File Offset: 0x0005AA70
		public unsafe WebHeaderCollection Headers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 386299, RefRangeEnd = 386301, XrefRangeStart = 386299, XrefRangeEnd = 386299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x0005C8B4 File Offset: 0x0005AAB4
		// (set) Token: 0x06001445 RID: 5189 RVA: 0x0005C8F0 File Offset: 0x0005AAF0
		public unsafe HttpStatusCode StatusCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_StatusCode_Public_get_HttpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_StatusCode_Private_set_Void_HttpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0005C930 File Offset: 0x0005AB30
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x0005C968 File Offset: 0x0005AB68
		public unsafe string StatusDescription
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_StatusDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x0005C9AC File Offset: 0x0005ABAC
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x0005C9EC File Offset: 0x0005ABEC
		public unsafe Version Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_Version_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 386301, RefRangeEnd = 386305, XrefRangeStart = 386301, XrefRangeEnd = 386301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_Version_Private_set_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x0005CA30 File Offset: 0x0005AC30
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x0005CA6C File Offset: 0x0005AC6C
		public unsafe bool KeepAlive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_KeepAlive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x0005CAAC File Offset: 0x0005ACAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386305, XrefRangeEnd = 386310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebResponseStream(WebRequestStream request)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr__ctor_Public_Void_WebRequestStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x0005CAF8 File Offset: 0x0005ACF8
		public unsafe override long Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0005CB40 File Offset: 0x0005AD40
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x0005CB88 File Offset: 0x0005AD88
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x0005CBD0 File Offset: 0x0005ADD0
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x0005CC0C File Offset: 0x0005AE0C
		public unsafe bool ChunkedRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_ChunkedRead_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_ChunkedRead_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x0005CC4C File Offset: 0x0005AE4C
		// (set) Token: 0x06001453 RID: 5203 RVA: 0x0005CC8C File Offset: 0x0005AE8C
		public unsafe MonoChunkStream ChunkStream
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_ChunkStream_Protected_get_MonoChunkStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoChunkStream>(intPtr3) : null;
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 386310, RefRangeEnd = 386323, XrefRangeStart = 386310, XrefRangeEnd = 386310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_ChunkStream_Private_set_Void_MonoChunkStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0005CCD0 File Offset: 0x0005AED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386323, XrefRangeEnd = 386333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0005CD60 File Offset: 0x0005AF60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 386343, RefRangeEnd = 386344, XrefRangeStart = 386333, XrefRangeEnd = 386343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<ValueTuple<int, int>> ProcessRead(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_ProcessRead_Private_Task_1_ValueTuple_2_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<ValueTuple<int, int>>>(intPtr3) : null;
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0005CDE4 File Offset: 0x0005AFE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 386354, RefRangeEnd = 386357, XrefRangeStart = 386344, XrefRangeEnd = 386354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> InnerReadAsync(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_InnerReadAsync_Internal_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0005CE68 File Offset: 0x0005B068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 386367, RefRangeEnd = 386368, XrefRangeStart = 386357, XrefRangeEnd = 386367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> EnsureReadAsync(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_EnsureReadAsync_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0005CEEC File Offset: 0x0005B0EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 386369, RefRangeEnd = 386372, XrefRangeStart = 386368, XrefRangeEnd = 386369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckAuthHeader(string headerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(headerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_CheckAuthHeader_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0005CF3C File Offset: 0x0005B13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386372, XrefRangeEnd = 386378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNtlmAuth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_IsNtlmAuth_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x0005CF78 File Offset: 0x0005B178
		public unsafe bool ExpectContent
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 386380, RefRangeEnd = 386382, XrefRangeStart = 386378, XrefRangeEnd = 386380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_ExpectContent_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0005CFB4 File Offset: 0x0005B1B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 386391, RefRangeEnd = 386392, XrefRangeStart = 386382, XrefRangeEnd = 386391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Initialize(BufferOffsetSize buffer, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_Initialize_Private_Task_BufferOffsetSize_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x0005D01C File Offset: 0x0005B21C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 386401, RefRangeEnd = 386402, XrefRangeStart = 386392, XrefRangeEnd = 386401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ReadAllAsync(bool resending, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resending;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_ReadAllAsync_Internal_Task_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x0005D080 File Offset: 0x0005B280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386402, XrefRangeEnd = 386412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x0005D110 File Offset: 0x0005B310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386412, XrefRangeEnd = 386415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close_internal(ref bool disposed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &disposed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x0005D15C File Offset: 0x0005B35C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 386450, RefRangeEnd = 386451, XrefRangeStart = 386415, XrefRangeEnd = 386450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException GetReadException(WebExceptionStatus status, Exception error, string where)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(where);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_GetReadException_Private_WebException_WebExceptionStatus_Exception_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x0005D1CC File Offset: 0x0005B3CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 386460, RefRangeEnd = 386461, XrefRangeStart = 386451, XrefRangeEnd = 386460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task InitReadAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_InitReadAsync_Internal_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x0005D224 File Offset: 0x0005B424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 386537, RefRangeEnd = 386538, XrefRangeStart = 386461, XrefRangeEnd = 386537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_GetResponse_Private_Boolean_BufferOffsetSize_byref_Int32_byref_ReadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x0000A467 File Offset: 0x00008667
		public WebResponseStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x0005D290 File Offset: 0x0005B490
		// (set) Token: 0x06001464 RID: 5220 RVA: 0x0000A470 File Offset: 0x00008670
		public unsafe BufferOffsetSize readBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_readBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_readBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x0005D2C0 File Offset: 0x0005B4C0
		// (set) Token: 0x06001466 RID: 5222 RVA: 0x0000A48F File Offset: 0x0000868F
		public unsafe long contentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_contentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_contentLength)) = value;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x0005D2E8 File Offset: 0x0005B4E8
		// (set) Token: 0x06001468 RID: 5224 RVA: 0x0000A4AA File Offset: 0x000086AA
		public unsafe long totalRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_totalRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_totalRead)) = value;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x0005D310 File Offset: 0x0005B510
		// (set) Token: 0x0600146A RID: 5226 RVA: 0x0000A4C5 File Offset: 0x000086C5
		public unsafe bool nextReadCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_nextReadCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_nextReadCalled)) = value;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x0005D338 File Offset: 0x0005B538
		// (set) Token: 0x0600146C RID: 5228 RVA: 0x0000A4E0 File Offset: 0x000086E0
		public unsafe int stream_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_stream_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_stream_length)) = value;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x0005D360 File Offset: 0x0005B560
		// (set) Token: 0x0600146E RID: 5230 RVA: 0x0000A4FB File Offset: 0x000086FB
		public unsafe WebCompletionSource pendingRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_pendingRead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_pendingRead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x0005D390 File Offset: 0x0005B590
		// (set) Token: 0x06001470 RID: 5232 RVA: 0x0000A51A File Offset: 0x0000871A
		public new unsafe Object locker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_locker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_locker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x0005D3C0 File Offset: 0x0005B5C0
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x0000A539 File Offset: 0x00008739
		public unsafe int nestedRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_nestedRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_nestedRead)) = value;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x0005D3E8 File Offset: 0x0005B5E8
		// (set) Token: 0x06001474 RID: 5236 RVA: 0x0000A554 File Offset: 0x00008754
		public unsafe bool read_eof
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_read_eof);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_read_eof)) = value;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x0005D410 File Offset: 0x0005B610
		// (set) Token: 0x06001476 RID: 5238 RVA: 0x0000A56F File Offset: 0x0000876F
		public unsafe WebRequestStream _RequestStream_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__RequestStream_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__RequestStream_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x0005D440 File Offset: 0x0005B640
		// (set) Token: 0x06001478 RID: 5240 RVA: 0x0000A58E File Offset: 0x0000878E
		public unsafe WebHeaderCollection _Headers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__Headers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__Headers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x0005D470 File Offset: 0x0005B670
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x0000A5AD File Offset: 0x000087AD
		public unsafe HttpStatusCode _StatusCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__StatusCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__StatusCode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x0005D498 File Offset: 0x0005B698
		// (set) Token: 0x0600147C RID: 5244 RVA: 0x0000A5C8 File Offset: 0x000087C8
		public unsafe string _StatusDescription_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__StatusDescription_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__StatusDescription_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x0005D4C0 File Offset: 0x0005B6C0
		// (set) Token: 0x0600147E RID: 5246 RVA: 0x0000A5E7 File Offset: 0x000087E7
		public unsafe Version _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__Version_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__Version_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x0005D4F0 File Offset: 0x0005B6F0
		// (set) Token: 0x06001480 RID: 5248 RVA: 0x0000A606 File Offset: 0x00008806
		public unsafe bool _KeepAlive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__KeepAlive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__KeepAlive_k__BackingField)) = value;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0005D518 File Offset: 0x0005B718
		// (set) Token: 0x06001482 RID: 5250 RVA: 0x0000A621 File Offset: 0x00008821
		public unsafe bool _ChunkedRead_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__ChunkedRead_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__ChunkedRead_k__BackingField)) = value;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0005D540 File Offset: 0x0005B740
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x0000A63C File Offset: 0x0000883C
		public unsafe MonoChunkStream _ChunkStream_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__ChunkStream_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoChunkStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__ChunkStream_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeFieldInfoPtr_readBuffer;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeFieldInfoPtr_contentLength;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeFieldInfoPtr_totalRead;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeFieldInfoPtr_nextReadCalled;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeFieldInfoPtr_stream_length;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeFieldInfoPtr_pendingRead;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeFieldInfoPtr_nestedRead;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeFieldInfoPtr_read_eof;

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeFieldInfoPtr__RequestStream_k__BackingField;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeFieldInfoPtr__Headers_k__BackingField;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeFieldInfoPtr__StatusCode_k__BackingField;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeFieldInfoPtr__StatusDescription_k__BackingField;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeFieldInfoPtr__KeepAlive_k__BackingField;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeFieldInfoPtr__ChunkedRead_k__BackingField;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeFieldInfoPtr__ChunkStream_k__BackingField;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestStream_Public_get_WebRequestStream_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusCode_Public_get_HttpStatusCode_0;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusCode_Private_set_Void_HttpStatusCode_0;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusDescription_Public_get_String_0;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Version_0;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_Version_0;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr_set_KeepAlive_Private_set_Void_Boolean_0;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WebRequestStream_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkedRead_Protected_get_Boolean_0;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeMethodInfoPtr_set_ChunkedRead_Private_set_Void_Boolean_0;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkStream_Protected_get_MonoChunkStream_0;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeMethodInfoPtr_set_ChunkStream_Private_set_Void_MonoChunkStream_0;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRead_Private_Task_1_ValueTuple_2_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr_InnerReadAsync_Internal_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr_EnsureReadAsync_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr_CheckAuthHeader_Private_Boolean_String_0;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeMethodInfoPtr_IsNtlmAuth_Private_Boolean_0;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpectContent_Private_get_Boolean_0;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Task_BufferOffsetSize_CancellationToken_0;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeMethodInfoPtr_ReadAllAsync_Internal_Task_Boolean_CancellationToken_0;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0;

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeMethodInfoPtr_GetReadException_Private_WebException_WebExceptionStatus_Exception_String_0;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeMethodInfoPtr_InitReadAsync_Internal_Task_CancellationToken_0;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Private_Boolean_BufferOffsetSize_byref_Int32_byref_ReadState_0;

		// Token: 0x02000207 RID: 519
		[ObfuscatedName("System.Net.WebResponseStream+<>c__DisplayClass48_0")]
		public sealed class __c__DisplayClass48_0 : Object
		{
			// Token: 0x06001C88 RID: 7304 RVA: 0x00075854 File Offset: 0x00073A54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass48_0()
			{
				Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<>c__DisplayClass48_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr);
				WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr, "<>4__this");
				WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr, "buffer");
				WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr, "offset");
				WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr, "size");
				WebResponseStream.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr, 100666198);
				WebResponseStream.__c__DisplayClass48_0.NativeMethodInfoPtr__ReadAsync_b__0_Internal_Task_1_ValueTuple_2_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr, 100666199);
				WebResponseStream.__c__DisplayClass48_0.NativeMethodInfoPtr__ReadAsync_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr, 100666200);
			}

			// Token: 0x06001C89 RID: 7305 RVA: 0x0007590C File Offset: 0x00073B0C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass48_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C8A RID: 7306 RVA: 0x00075948 File Offset: 0x00073B48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385825, XrefRangeEnd = 385826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<ValueTuple<int, int>> _ReadAsync_b__0(CancellationToken ct)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ct));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.__c__DisplayClass48_0.NativeMethodInfoPtr__ReadAsync_b__0_Internal_Task_1_ValueTuple_2_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<ValueTuple<int, int>>>(intPtr3) : null;
				}
			}

			// Token: 0x06001C8B RID: 7307 RVA: 0x000759A0 File Offset: 0x00073BA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385826, XrefRangeEnd = 385831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReadAsync_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.__c__DisplayClass48_0.NativeMethodInfoPtr__ReadAsync_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C8C RID: 7308 RVA: 0x0000F613 File Offset: 0x0000D813
			public __c__DisplayClass48_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000928 RID: 2344
			// (get) Token: 0x06001C8D RID: 7309 RVA: 0x000759D4 File Offset: 0x00073BD4
			// (set) Token: 0x06001C8E RID: 7310 RVA: 0x0000F61C File Offset: 0x0000D81C
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000929 RID: 2345
			// (get) Token: 0x06001C8F RID: 7311 RVA: 0x00075A04 File Offset: 0x00073C04
			// (set) Token: 0x06001C90 RID: 7312 RVA: 0x0000F63B File Offset: 0x0000D83B
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700092A RID: 2346
			// (get) Token: 0x06001C91 RID: 7313 RVA: 0x00075A34 File Offset: 0x00073C34
			// (set) Token: 0x06001C92 RID: 7314 RVA: 0x0000F65A File Offset: 0x0000D85A
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x1700092B RID: 2347
			// (get) Token: 0x06001C93 RID: 7315 RVA: 0x00075A5C File Offset: 0x00073C5C
			// (set) Token: 0x06001C94 RID: 7316 RVA: 0x0000F675 File Offset: 0x0000D875
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x040015DB RID: 5595
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015DC RID: 5596
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x040015DD RID: 5597
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x040015DE RID: 5598
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x040015DF RID: 5599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015E0 RID: 5600
			private static readonly IntPtr NativeMethodInfoPtr__ReadAsync_b__0_Internal_Task_1_ValueTuple_2_Int32_Int32_CancellationToken_0;

			// Token: 0x040015E1 RID: 5601
			private static readonly IntPtr NativeMethodInfoPtr__ReadAsync_b__1_Internal_Void_0;
		}

		// Token: 0x02000208 RID: 520
		[ObfuscatedName("System.Net.WebResponseStream+<ReadAsync>d__48")]
		public sealed class _ReadAsync_d__48 : ValueType
		{
			// Token: 0x06001C95 RID: 7317 RVA: 0x00075A84 File Offset: 0x00073C84
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadAsync_d__48()
			{
				Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<ReadAsync>d__48");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr);
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<>1__state");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<>t__builder");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<>4__this");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "buffer");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "offset");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "size");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "cancellationToken");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__completion_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<completion>5__1");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<>8__2");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__throwMe_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<throwMe>5__3");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__oldBytes_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<oldBytes>5__4");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__nbytes_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<nbytes>5__5");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<>u__1");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<>u__2");
				WebResponseStream._ReadAsync_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, 100666201);
				WebResponseStream._ReadAsync_d__48.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, 100666202);
			}

			// Token: 0x06001C96 RID: 7318 RVA: 0x00075BF0 File Offset: 0x00073DF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385831, XrefRangeEnd = 385905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ReadAsync_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C97 RID: 7319 RVA: 0x00075C28 File Offset: 0x00073E28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385905, XrefRangeEnd = 385920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ReadAsync_d__48.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C98 RID: 7320 RVA: 0x0000F690 File Offset: 0x0000D890
			public _ReadAsync_d__48(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C99 RID: 7321 RVA: 0x0000F699 File Offset: 0x0000D899
			public _ReadAsync_d__48()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr))
			{
			}

			// Token: 0x1700092C RID: 2348
			// (get) Token: 0x06001C9A RID: 7322 RVA: 0x00075C70 File Offset: 0x00073E70
			// (set) Token: 0x06001C9B RID: 7323 RVA: 0x0000F6AB File Offset: 0x0000D8AB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700092D RID: 2349
			// (get) Token: 0x06001C9C RID: 7324 RVA: 0x00075C98 File Offset: 0x00073E98
			// (set) Token: 0x06001C9D RID: 7325 RVA: 0x0000F6C6 File Offset: 0x0000D8C6
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700092E RID: 2350
			// (get) Token: 0x06001C9E RID: 7326 RVA: 0x00075CC8 File Offset: 0x00073EC8
			// (set) Token: 0x06001C9F RID: 7327 RVA: 0x0000F6F4 File Offset: 0x0000D8F4
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700092F RID: 2351
			// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x00075CF8 File Offset: 0x00073EF8
			// (set) Token: 0x06001CA1 RID: 7329 RVA: 0x0000F713 File Offset: 0x0000D913
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000930 RID: 2352
			// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x00075D28 File Offset: 0x00073F28
			// (set) Token: 0x06001CA3 RID: 7331 RVA: 0x0000F732 File Offset: 0x0000D932
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17000931 RID: 2353
			// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x00075D50 File Offset: 0x00073F50
			// (set) Token: 0x06001CA5 RID: 7333 RVA: 0x0000F74D File Offset: 0x0000D94D
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x17000932 RID: 2354
			// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x00075D78 File Offset: 0x00073F78
			// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x0000F768 File Offset: 0x0000D968
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000933 RID: 2355
			// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x00075DA8 File Offset: 0x00073FA8
			// (set) Token: 0x06001CA9 RID: 7337 RVA: 0x0000F796 File Offset: 0x0000D996
			public unsafe WebCompletionSource _completion_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__completion_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__completion_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000934 RID: 2356
			// (get) Token: 0x06001CAA RID: 7338 RVA: 0x00075DD8 File Offset: 0x00073FD8
			// (set) Token: 0x06001CAB RID: 7339 RVA: 0x0000F7B5 File Offset: 0x0000D9B5
			public unsafe WebResponseStream.__c__DisplayClass48_0 __8__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___8__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream.__c__DisplayClass48_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000935 RID: 2357
			// (get) Token: 0x06001CAC RID: 7340 RVA: 0x00075E08 File Offset: 0x00074008
			// (set) Token: 0x06001CAD RID: 7341 RVA: 0x0000F7D4 File Offset: 0x0000D9D4
			public unsafe Exception _throwMe_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__throwMe_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__throwMe_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000936 RID: 2358
			// (get) Token: 0x06001CAE RID: 7342 RVA: 0x00075E38 File Offset: 0x00074038
			// (set) Token: 0x06001CAF RID: 7343 RVA: 0x0000F7F3 File Offset: 0x0000D9F3
			public unsafe int _oldBytes_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__oldBytes_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__oldBytes_5__4)) = value;
				}
			}

			// Token: 0x17000937 RID: 2359
			// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x00075E60 File Offset: 0x00074060
			// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x0000F80E File Offset: 0x0000DA0E
			public unsafe int _nbytes_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__nbytes_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__nbytes_5__5)) = value;
				}
			}

			// Token: 0x17000938 RID: 2360
			// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x00075E88 File Offset: 0x00074088
			// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x0000F829 File Offset: 0x0000DA29
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000939 RID: 2361
			// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x00075EB8 File Offset: 0x000740B8
			// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x0000F857 File Offset: 0x0000DA57
			public ConfiguredTaskAwaitable<ValueTuple<int, int>>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<ValueTuple<int, int>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<int, int>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<int, int>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040015E2 RID: 5602
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015E3 RID: 5603
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040015E4 RID: 5604
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015E5 RID: 5605
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x040015E6 RID: 5606
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x040015E7 RID: 5607
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x040015E8 RID: 5608
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040015E9 RID: 5609
			private static readonly IntPtr NativeFieldInfoPtr__completion_5__1;

			// Token: 0x040015EA RID: 5610
			private static readonly IntPtr NativeFieldInfoPtr___8__2;

			// Token: 0x040015EB RID: 5611
			private static readonly IntPtr NativeFieldInfoPtr__throwMe_5__3;

			// Token: 0x040015EC RID: 5612
			private static readonly IntPtr NativeFieldInfoPtr__oldBytes_5__4;

			// Token: 0x040015ED RID: 5613
			private static readonly IntPtr NativeFieldInfoPtr__nbytes_5__5;

			// Token: 0x040015EE RID: 5614
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040015EF RID: 5615
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040015F0 RID: 5616
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015F1 RID: 5617
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000209 RID: 521
		[ObfuscatedName("System.Net.WebResponseStream+<ProcessRead>d__49")]
		public sealed class _ProcessRead_d__49 : ValueType
		{
			// Token: 0x06001CB6 RID: 7350 RVA: 0x00075EE8 File Offset: 0x000740E8
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessRead_d__49()
			{
				Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<ProcessRead>d__49");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr);
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "<>1__state");
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "<>t__builder");
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "cancellationToken");
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "<>4__this");
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "size");
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "buffer");
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "offset");
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr__oldBytes_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "<oldBytes>5__1");
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "<>u__1");
				WebResponseStream._ProcessRead_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, 100666203);
				WebResponseStream._ProcessRead_d__49.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, 100666204);
			}

			// Token: 0x06001CB7 RID: 7351 RVA: 0x00075FF0 File Offset: 0x000741F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385920, XrefRangeEnd = 385946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ProcessRead_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CB8 RID: 7352 RVA: 0x00076028 File Offset: 0x00074228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385946, XrefRangeEnd = 385961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ProcessRead_d__49.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001CB9 RID: 7353 RVA: 0x0000F885 File Offset: 0x0000DA85
			public _ProcessRead_d__49(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001CBA RID: 7354 RVA: 0x0000F88E File Offset: 0x0000DA8E
			public _ProcessRead_d__49()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr))
			{
			}

			// Token: 0x1700093A RID: 2362
			// (get) Token: 0x06001CBB RID: 7355 RVA: 0x00076070 File Offset: 0x00074270
			// (set) Token: 0x06001CBC RID: 7356 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700093B RID: 2363
			// (get) Token: 0x06001CBD RID: 7357 RVA: 0x00076098 File Offset: 0x00074298
			// (set) Token: 0x06001CBE RID: 7358 RVA: 0x0000F8BB File Offset: 0x0000DABB
			public AsyncTaskMethodBuilder<ValueTuple<int, int>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<ValueTuple<int, int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<int, int>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<int, int>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700093C RID: 2364
			// (get) Token: 0x06001CBF RID: 7359 RVA: 0x000760C8 File Offset: 0x000742C8
			// (set) Token: 0x06001CC0 RID: 7360 RVA: 0x0000F8E9 File Offset: 0x0000DAE9
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700093D RID: 2365
			// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x000760F8 File Offset: 0x000742F8
			// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x0000F917 File Offset: 0x0000DB17
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700093E RID: 2366
			// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x00076128 File Offset: 0x00074328
			// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x0000F936 File Offset: 0x0000DB36
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x1700093F RID: 2367
			// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x00076150 File Offset: 0x00074350
			// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x0000F951 File Offset: 0x0000DB51
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000940 RID: 2368
			// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x00076180 File Offset: 0x00074380
			// (set) Token: 0x06001CC8 RID: 7368 RVA: 0x0000F970 File Offset: 0x0000DB70
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17000941 RID: 2369
			// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x000761A8 File Offset: 0x000743A8
			// (set) Token: 0x06001CCA RID: 7370 RVA: 0x0000F98B File Offset: 0x0000DB8B
			public unsafe int _oldBytes_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr__oldBytes_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr__oldBytes_5__1)) = value;
				}
			}

			// Token: 0x17000942 RID: 2370
			// (get) Token: 0x06001CCB RID: 7371 RVA: 0x000761D0 File Offset: 0x000743D0
			// (set) Token: 0x06001CCC RID: 7372 RVA: 0x0000F9A6 File Offset: 0x0000DBA6
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040015F2 RID: 5618
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015F3 RID: 5619
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040015F4 RID: 5620
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040015F5 RID: 5621
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015F6 RID: 5622
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x040015F7 RID: 5623
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x040015F8 RID: 5624
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x040015F9 RID: 5625
			private static readonly IntPtr NativeFieldInfoPtr__oldBytes_5__1;

			// Token: 0x040015FA RID: 5626
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040015FB RID: 5627
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015FC RID: 5628
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200020A RID: 522
		[ObfuscatedName("System.Net.WebResponseStream+<InnerReadAsync>d__50")]
		public sealed class _InnerReadAsync_d__50 : ValueType
		{
			// Token: 0x06001CCD RID: 7373 RVA: 0x00076200 File Offset: 0x00074400
			// Note: this type is marked as 'beforefieldinit'.
			static _InnerReadAsync_d__50()
			{
				Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<InnerReadAsync>d__50");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr);
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "<>1__state");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "<>t__builder");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "<>4__this");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "cancellationToken");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "buffer");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "offset");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "size");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr__done_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "<done>5__1");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr__nbytes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "<nbytes>5__2");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "<>u__1");
				WebResponseStream._InnerReadAsync_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, 100666205);
				WebResponseStream._InnerReadAsync_d__50.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, 100666206);
			}

			// Token: 0x06001CCE RID: 7374 RVA: 0x0007631C File Offset: 0x0007451C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385961, XrefRangeEnd = 385997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._InnerReadAsync_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CCF RID: 7375 RVA: 0x00076354 File Offset: 0x00074554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385997, XrefRangeEnd = 386012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._InnerReadAsync_d__50.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001CD0 RID: 7376 RVA: 0x0000F9D4 File Offset: 0x0000DBD4
			public _InnerReadAsync_d__50(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001CD1 RID: 7377 RVA: 0x0000F9DD File Offset: 0x0000DBDD
			public _InnerReadAsync_d__50()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr))
			{
			}

			// Token: 0x17000943 RID: 2371
			// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x0007639C File Offset: 0x0007459C
			// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x0000F9EF File Offset: 0x0000DBEF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000944 RID: 2372
			// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x000763C4 File Offset: 0x000745C4
			// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x0000FA0A File Offset: 0x0000DC0A
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000945 RID: 2373
			// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x000763F4 File Offset: 0x000745F4
			// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x0000FA38 File Offset: 0x0000DC38
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000946 RID: 2374
			// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x00076424 File Offset: 0x00074624
			// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x0000FA57 File Offset: 0x0000DC57
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000947 RID: 2375
			// (get) Token: 0x06001CDA RID: 7386 RVA: 0x00076454 File Offset: 0x00074654
			// (set) Token: 0x06001CDB RID: 7387 RVA: 0x0000FA85 File Offset: 0x0000DC85
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000948 RID: 2376
			// (get) Token: 0x06001CDC RID: 7388 RVA: 0x00076484 File Offset: 0x00074684
			// (set) Token: 0x06001CDD RID: 7389 RVA: 0x0000FAA4 File Offset: 0x0000DCA4
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17000949 RID: 2377
			// (get) Token: 0x06001CDE RID: 7390 RVA: 0x000764AC File Offset: 0x000746AC
			// (set) Token: 0x06001CDF RID: 7391 RVA: 0x0000FABF File Offset: 0x0000DCBF
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x1700094A RID: 2378
			// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x000764D4 File Offset: 0x000746D4
			// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x0000FADA File Offset: 0x0000DCDA
			public unsafe bool _done_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr__done_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr__done_5__1)) = value;
				}
			}

			// Token: 0x1700094B RID: 2379
			// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x000764FC File Offset: 0x000746FC
			// (set) Token: 0x06001CE3 RID: 7395 RVA: 0x0000FAF5 File Offset: 0x0000DCF5
			public unsafe int _nbytes_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr__nbytes_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr__nbytes_5__2)) = value;
				}
			}

			// Token: 0x1700094C RID: 2380
			// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x00076524 File Offset: 0x00074724
			// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x0000FB10 File Offset: 0x0000DD10
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040015FD RID: 5629
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015FE RID: 5630
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040015FF RID: 5631
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001600 RID: 5632
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001601 RID: 5633
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04001602 RID: 5634
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x04001603 RID: 5635
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x04001604 RID: 5636
			private static readonly IntPtr NativeFieldInfoPtr__done_5__1;

			// Token: 0x04001605 RID: 5637
			private static readonly IntPtr NativeFieldInfoPtr__nbytes_5__2;

			// Token: 0x04001606 RID: 5638
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001607 RID: 5639
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001608 RID: 5640
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200020B RID: 523
		[ObfuscatedName("System.Net.WebResponseStream+<EnsureReadAsync>d__51")]
		public sealed class _EnsureReadAsync_d__51 : ValueType
		{
			// Token: 0x06001CE6 RID: 7398 RVA: 0x00076554 File Offset: 0x00074754
			// Note: this type is marked as 'beforefieldinit'.
			static _EnsureReadAsync_d__51()
			{
				Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<EnsureReadAsync>d__51");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr);
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "<>1__state");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "<>t__builder");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "<>4__this");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr__morebytes_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "<morebytes>5__1");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "cancellationToken");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr__nbytes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "<nbytes>5__2");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "buffer");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "offset");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "size");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "<>u__1");
				WebResponseStream._EnsureReadAsync_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, 100666207);
				WebResponseStream._EnsureReadAsync_d__51.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, 100666208);
			}

			// Token: 0x06001CE7 RID: 7399 RVA: 0x00076670 File Offset: 0x00074870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386012, XrefRangeEnd = 386041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._EnsureReadAsync_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CE8 RID: 7400 RVA: 0x000766A8 File Offset: 0x000748A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386041, XrefRangeEnd = 386060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._EnsureReadAsync_d__51.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001CE9 RID: 7401 RVA: 0x0000FB3E File Offset: 0x0000DD3E
			public _EnsureReadAsync_d__51(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001CEA RID: 7402 RVA: 0x0000FB47 File Offset: 0x0000DD47
			public _EnsureReadAsync_d__51()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr))
			{
			}

			// Token: 0x1700094D RID: 2381
			// (get) Token: 0x06001CEB RID: 7403 RVA: 0x000766F0 File Offset: 0x000748F0
			// (set) Token: 0x06001CEC RID: 7404 RVA: 0x0000FB59 File Offset: 0x0000DD59
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700094E RID: 2382
			// (get) Token: 0x06001CED RID: 7405 RVA: 0x00076718 File Offset: 0x00074918
			// (set) Token: 0x06001CEE RID: 7406 RVA: 0x0000FB74 File Offset: 0x0000DD74
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700094F RID: 2383
			// (get) Token: 0x06001CEF RID: 7407 RVA: 0x00076748 File Offset: 0x00074948
			// (set) Token: 0x06001CF0 RID: 7408 RVA: 0x0000FBA2 File Offset: 0x0000DDA2
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000950 RID: 2384
			// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x00076778 File Offset: 0x00074978
			// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x0000FBC1 File Offset: 0x0000DDC1
			public unsafe Il2CppStructArray<byte> _morebytes_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr__morebytes_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr__morebytes_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000951 RID: 2385
			// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x000767A8 File Offset: 0x000749A8
			// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x0000FBE0 File Offset: 0x0000DDE0
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000952 RID: 2386
			// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x000767D8 File Offset: 0x000749D8
			// (set) Token: 0x06001CF6 RID: 7414 RVA: 0x0000FC0E File Offset: 0x0000DE0E
			public unsafe int _nbytes_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr__nbytes_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr__nbytes_5__2)) = value;
				}
			}

			// Token: 0x17000953 RID: 2387
			// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x00076800 File Offset: 0x00074A00
			// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x0000FC29 File Offset: 0x0000DE29
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000954 RID: 2388
			// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x00076830 File Offset: 0x00074A30
			// (set) Token: 0x06001CFA RID: 7418 RVA: 0x0000FC48 File Offset: 0x0000DE48
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17000955 RID: 2389
			// (get) Token: 0x06001CFB RID: 7419 RVA: 0x00076858 File Offset: 0x00074A58
			// (set) Token: 0x06001CFC RID: 7420 RVA: 0x0000FC63 File Offset: 0x0000DE63
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x17000956 RID: 2390
			// (get) Token: 0x06001CFD RID: 7421 RVA: 0x00076880 File Offset: 0x00074A80
			// (set) Token: 0x06001CFE RID: 7422 RVA: 0x0000FC7E File Offset: 0x0000DE7E
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001609 RID: 5641
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400160A RID: 5642
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400160B RID: 5643
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400160C RID: 5644
			private static readonly IntPtr NativeFieldInfoPtr__morebytes_5__1;

			// Token: 0x0400160D RID: 5645
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400160E RID: 5646
			private static readonly IntPtr NativeFieldInfoPtr__nbytes_5__2;

			// Token: 0x0400160F RID: 5647
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04001610 RID: 5648
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x04001611 RID: 5649
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x04001612 RID: 5650
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001613 RID: 5651
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001614 RID: 5652
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200020C RID: 524
		[ObfuscatedName("System.Net.WebResponseStream+<Initialize>d__56")]
		public sealed class _Initialize_d__56 : ValueType
		{
			// Token: 0x06001CFF RID: 7423 RVA: 0x000768B0 File Offset: 0x00074AB0
			// Note: this type is marked as 'beforefieldinit'.
			static _Initialize_d__56()
			{
				Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<Initialize>d__56");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr);
				WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, "<>1__state");
				WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, "<>t__builder");
				WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, "<>4__this");
				WebResponseStream._Initialize_d__56.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, "buffer");
				WebResponseStream._Initialize_d__56.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, "cancellationToken");
				WebResponseStream._Initialize_d__56.NativeFieldInfoPtr__me_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, "<me>5__1");
				WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, "<>u__1");
				WebResponseStream._Initialize_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, 100666209);
				WebResponseStream._Initialize_d__56.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, 100666210);
			}

			// Token: 0x06001D00 RID: 7424 RVA: 0x00076990 File Offset: 0x00074B90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386060, XrefRangeEnd = 386147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._Initialize_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D01 RID: 7425 RVA: 0x000769C8 File Offset: 0x00074BC8
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._Initialize_d__56.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D02 RID: 7426 RVA: 0x0000FCAC File Offset: 0x0000DEAC
			public _Initialize_d__56(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001D03 RID: 7427 RVA: 0x0000FCB5 File Offset: 0x0000DEB5
			public _Initialize_d__56()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr))
			{
			}

			// Token: 0x17000957 RID: 2391
			// (get) Token: 0x06001D04 RID: 7428 RVA: 0x00076A10 File Offset: 0x00074C10
			// (set) Token: 0x06001D05 RID: 7429 RVA: 0x0000FCC7 File Offset: 0x0000DEC7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000958 RID: 2392
			// (get) Token: 0x06001D06 RID: 7430 RVA: 0x00076A38 File Offset: 0x00074C38
			// (set) Token: 0x06001D07 RID: 7431 RVA: 0x0000FCE2 File Offset: 0x0000DEE2
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000959 RID: 2393
			// (get) Token: 0x06001D08 RID: 7432 RVA: 0x00076A68 File Offset: 0x00074C68
			// (set) Token: 0x06001D09 RID: 7433 RVA: 0x0000FD10 File Offset: 0x0000DF10
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095A RID: 2394
			// (get) Token: 0x06001D0A RID: 7434 RVA: 0x00076A98 File Offset: 0x00074C98
			// (set) Token: 0x06001D0B RID: 7435 RVA: 0x0000FD2F File Offset: 0x0000DF2F
			public unsafe BufferOffsetSize buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095B RID: 2395
			// (get) Token: 0x06001D0C RID: 7436 RVA: 0x00076AC8 File Offset: 0x00074CC8
			// (set) Token: 0x06001D0D RID: 7437 RVA: 0x0000FD4E File Offset: 0x0000DF4E
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700095C RID: 2396
			// (get) Token: 0x06001D0E RID: 7438 RVA: 0x00076AF8 File Offset: 0x00074CF8
			// (set) Token: 0x06001D0F RID: 7439 RVA: 0x0000FD7C File Offset: 0x0000DF7C
			public unsafe string _me_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr__me_5__1);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr__me_5__1), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700095D RID: 2397
			// (get) Token: 0x06001D10 RID: 7440 RVA: 0x00076B20 File Offset: 0x00074D20
			// (set) Token: 0x06001D11 RID: 7441 RVA: 0x0000FD9B File Offset: 0x0000DF9B
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001615 RID: 5653
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001616 RID: 5654
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001617 RID: 5655
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001618 RID: 5656
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04001619 RID: 5657
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400161A RID: 5658
			private static readonly IntPtr NativeFieldInfoPtr__me_5__1;

			// Token: 0x0400161B RID: 5659
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400161C RID: 5660
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400161D RID: 5661
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200020D RID: 525
		[ObfuscatedName("System.Net.WebResponseStream+<ReadAllAsync>d__57")]
		public sealed class _ReadAllAsync_d__57 : ValueType
		{
			// Token: 0x06001D12 RID: 7442 RVA: 0x00076B50 File Offset: 0x00074D50
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadAllAsync_d__57()
			{
				Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<ReadAllAsync>d__57");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr);
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<>1__state");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<>t__builder");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<>4__this");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "cancellationToken");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__completion_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<completion>5__1");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__timeoutTask_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<timeoutTask>5__2");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr_resending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "resending");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__ms_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<ms>5__3");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__buffer_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<buffer>5__4");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__read_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<read>5__5");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__b_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<b>5__6");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__remaining_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<remaining>5__7");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__readSize_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<readSize>5__8");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__new_size_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<new_size>5__9");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<>u__1");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<>u__2");
				WebResponseStream._ReadAllAsync_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, 100666211);
				WebResponseStream._ReadAllAsync_d__57.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, 100666212);
			}

			// Token: 0x06001D13 RID: 7443 RVA: 0x00076CE4 File Offset: 0x00074EE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386147, XrefRangeEnd = 386253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ReadAllAsync_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D14 RID: 7444 RVA: 0x00076D1C File Offset: 0x00074F1C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ReadAllAsync_d__57.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D15 RID: 7445 RVA: 0x0000FDC9 File Offset: 0x0000DFC9
			public _ReadAllAsync_d__57(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001D16 RID: 7446 RVA: 0x0000FDD2 File Offset: 0x0000DFD2
			public _ReadAllAsync_d__57()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr))
			{
			}

			// Token: 0x1700095E RID: 2398
			// (get) Token: 0x06001D17 RID: 7447 RVA: 0x00076D64 File Offset: 0x00074F64
			// (set) Token: 0x06001D18 RID: 7448 RVA: 0x0000FDE4 File Offset: 0x0000DFE4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700095F RID: 2399
			// (get) Token: 0x06001D19 RID: 7449 RVA: 0x00076D8C File Offset: 0x00074F8C
			// (set) Token: 0x06001D1A RID: 7450 RVA: 0x0000FDFF File Offset: 0x0000DFFF
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000960 RID: 2400
			// (get) Token: 0x06001D1B RID: 7451 RVA: 0x00076DBC File Offset: 0x00074FBC
			// (set) Token: 0x06001D1C RID: 7452 RVA: 0x0000FE2D File Offset: 0x0000E02D
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000961 RID: 2401
			// (get) Token: 0x06001D1D RID: 7453 RVA: 0x00076DEC File Offset: 0x00074FEC
			// (set) Token: 0x06001D1E RID: 7454 RVA: 0x0000FE4C File Offset: 0x0000E04C
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000962 RID: 2402
			// (get) Token: 0x06001D1F RID: 7455 RVA: 0x00076E1C File Offset: 0x0007501C
			// (set) Token: 0x06001D20 RID: 7456 RVA: 0x0000FE7A File Offset: 0x0000E07A
			public unsafe WebCompletionSource _completion_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__completion_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__completion_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000963 RID: 2403
			// (get) Token: 0x06001D21 RID: 7457 RVA: 0x00076E4C File Offset: 0x0007504C
			// (set) Token: 0x06001D22 RID: 7458 RVA: 0x0000FE99 File Offset: 0x0000E099
			public unsafe Task _timeoutTask_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__timeoutTask_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__timeoutTask_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000964 RID: 2404
			// (get) Token: 0x06001D23 RID: 7459 RVA: 0x00076E7C File Offset: 0x0007507C
			// (set) Token: 0x06001D24 RID: 7460 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
			public unsafe bool resending
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr_resending);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr_resending)) = value;
				}
			}

			// Token: 0x17000965 RID: 2405
			// (get) Token: 0x06001D25 RID: 7461 RVA: 0x00076EA4 File Offset: 0x000750A4
			// (set) Token: 0x06001D26 RID: 7462 RVA: 0x0000FED3 File Offset: 0x0000E0D3
			public unsafe MemoryStream _ms_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__ms_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__ms_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000966 RID: 2406
			// (get) Token: 0x06001D27 RID: 7463 RVA: 0x00076ED4 File Offset: 0x000750D4
			// (set) Token: 0x06001D28 RID: 7464 RVA: 0x0000FEF2 File Offset: 0x0000E0F2
			public unsafe BufferOffsetSize _buffer_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__buffer_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__buffer_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000967 RID: 2407
			// (get) Token: 0x06001D29 RID: 7465 RVA: 0x00076F04 File Offset: 0x00075104
			// (set) Token: 0x06001D2A RID: 7466 RVA: 0x0000FF11 File Offset: 0x0000E111
			public unsafe int _read_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__read_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__read_5__5)) = value;
				}
			}

			// Token: 0x17000968 RID: 2408
			// (get) Token: 0x06001D2B RID: 7467 RVA: 0x00076F2C File Offset: 0x0007512C
			// (set) Token: 0x06001D2C RID: 7468 RVA: 0x0000FF2C File Offset: 0x0000E12C
			public unsafe Il2CppStructArray<byte> _b_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__b_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__b_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000969 RID: 2409
			// (get) Token: 0x06001D2D RID: 7469 RVA: 0x00076F5C File Offset: 0x0007515C
			// (set) Token: 0x06001D2E RID: 7470 RVA: 0x0000FF4B File Offset: 0x0000E14B
			public unsafe int _remaining_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__remaining_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__remaining_5__7)) = value;
				}
			}

			// Token: 0x1700096A RID: 2410
			// (get) Token: 0x06001D2F RID: 7471 RVA: 0x00076F84 File Offset: 0x00075184
			// (set) Token: 0x06001D30 RID: 7472 RVA: 0x0000FF66 File Offset: 0x0000E166
			public unsafe int _readSize_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__readSize_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__readSize_5__8)) = value;
				}
			}

			// Token: 0x1700096B RID: 2411
			// (get) Token: 0x06001D31 RID: 7473 RVA: 0x00076FAC File Offset: 0x000751AC
			// (set) Token: 0x06001D32 RID: 7474 RVA: 0x0000FF81 File Offset: 0x0000E181
			public unsafe int _new_size_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__new_size_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__new_size_5__9)) = value;
				}
			}

			// Token: 0x1700096C RID: 2412
			// (get) Token: 0x06001D33 RID: 7475 RVA: 0x00076FD4 File Offset: 0x000751D4
			// (set) Token: 0x06001D34 RID: 7476 RVA: 0x0000FF9C File Offset: 0x0000E19C
			public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700096D RID: 2413
			// (get) Token: 0x06001D35 RID: 7477 RVA: 0x00077004 File Offset: 0x00075204
			// (set) Token: 0x06001D36 RID: 7478 RVA: 0x0000FFCA File Offset: 0x0000E1CA
			public TaskAwaiter<int> __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400161E RID: 5662
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400161F RID: 5663
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001620 RID: 5664
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001621 RID: 5665
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001622 RID: 5666
			private static readonly IntPtr NativeFieldInfoPtr__completion_5__1;

			// Token: 0x04001623 RID: 5667
			private static readonly IntPtr NativeFieldInfoPtr__timeoutTask_5__2;

			// Token: 0x04001624 RID: 5668
			private static readonly IntPtr NativeFieldInfoPtr_resending;

			// Token: 0x04001625 RID: 5669
			private static readonly IntPtr NativeFieldInfoPtr__ms_5__3;

			// Token: 0x04001626 RID: 5670
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__4;

			// Token: 0x04001627 RID: 5671
			private static readonly IntPtr NativeFieldInfoPtr__read_5__5;

			// Token: 0x04001628 RID: 5672
			private static readonly IntPtr NativeFieldInfoPtr__b_5__6;

			// Token: 0x04001629 RID: 5673
			private static readonly IntPtr NativeFieldInfoPtr__remaining_5__7;

			// Token: 0x0400162A RID: 5674
			private static readonly IntPtr NativeFieldInfoPtr__readSize_5__8;

			// Token: 0x0400162B RID: 5675
			private static readonly IntPtr NativeFieldInfoPtr__new_size_5__9;

			// Token: 0x0400162C RID: 5676
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400162D RID: 5677
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400162E RID: 5678
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400162F RID: 5679
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200020E RID: 526
		[ObfuscatedName("System.Net.WebResponseStream+<InitReadAsync>d__61")]
		public sealed class _InitReadAsync_d__61 : ValueType
		{
			// Token: 0x06001D37 RID: 7479 RVA: 0x00077034 File Offset: 0x00075234
			// Note: this type is marked as 'beforefieldinit'.
			static _InitReadAsync_d__61()
			{
				Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<InitReadAsync>d__61");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr);
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "<>1__state");
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "<>t__builder");
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "<>4__this");
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "cancellationToken");
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__buffer_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "<buffer>5__1");
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__state_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "<state>5__2");
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__position_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "<position>5__3");
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "<>u__1");
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "<>u__2");
				WebResponseStream._InitReadAsync_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, 100666213);
				WebResponseStream._InitReadAsync_d__61.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, 100666214);
			}

			// Token: 0x06001D38 RID: 7480 RVA: 0x0007713C File Offset: 0x0007533C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386253, XrefRangeEnd = 386299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._InitReadAsync_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D39 RID: 7481 RVA: 0x00077174 File Offset: 0x00075374
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._InitReadAsync_d__61.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D3A RID: 7482 RVA: 0x0000FFF8 File Offset: 0x0000E1F8
			public _InitReadAsync_d__61(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001D3B RID: 7483 RVA: 0x00010001 File Offset: 0x0000E201
			public _InitReadAsync_d__61()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr))
			{
			}

			// Token: 0x1700096E RID: 2414
			// (get) Token: 0x06001D3C RID: 7484 RVA: 0x000771BC File Offset: 0x000753BC
			// (set) Token: 0x06001D3D RID: 7485 RVA: 0x00010013 File Offset: 0x0000E213
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700096F RID: 2415
			// (get) Token: 0x06001D3E RID: 7486 RVA: 0x000771E4 File Offset: 0x000753E4
			// (set) Token: 0x06001D3F RID: 7487 RVA: 0x0001002E File Offset: 0x0000E22E
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000970 RID: 2416
			// (get) Token: 0x06001D40 RID: 7488 RVA: 0x00077214 File Offset: 0x00075414
			// (set) Token: 0x06001D41 RID: 7489 RVA: 0x0001005C File Offset: 0x0000E25C
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000971 RID: 2417
			// (get) Token: 0x06001D42 RID: 7490 RVA: 0x00077244 File Offset: 0x00075444
			// (set) Token: 0x06001D43 RID: 7491 RVA: 0x0001007B File Offset: 0x0000E27B
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000972 RID: 2418
			// (get) Token: 0x06001D44 RID: 7492 RVA: 0x00077274 File Offset: 0x00075474
			// (set) Token: 0x06001D45 RID: 7493 RVA: 0x000100A9 File Offset: 0x0000E2A9
			public unsafe BufferOffsetSize _buffer_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__buffer_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__buffer_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000973 RID: 2419
			// (get) Token: 0x06001D46 RID: 7494 RVA: 0x000772A4 File Offset: 0x000754A4
			// (set) Token: 0x06001D47 RID: 7495 RVA: 0x000100C8 File Offset: 0x0000E2C8
			public unsafe ReadState _state_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__state_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__state_5__2)) = value;
				}
			}

			// Token: 0x17000974 RID: 2420
			// (get) Token: 0x06001D48 RID: 7496 RVA: 0x000772CC File Offset: 0x000754CC
			// (set) Token: 0x06001D49 RID: 7497 RVA: 0x000100E3 File Offset: 0x0000E2E3
			public unsafe int _position_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__position_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__position_5__3)) = value;
				}
			}

			// Token: 0x17000975 RID: 2421
			// (get) Token: 0x06001D4A RID: 7498 RVA: 0x000772F4 File Offset: 0x000754F4
			// (set) Token: 0x06001D4B RID: 7499 RVA: 0x000100FE File Offset: 0x0000E2FE
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000976 RID: 2422
			// (get) Token: 0x06001D4C RID: 7500 RVA: 0x00077324 File Offset: 0x00075524
			// (set) Token: 0x06001D4D RID: 7501 RVA: 0x0001012C File Offset: 0x0000E32C
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001630 RID: 5680
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001631 RID: 5681
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001632 RID: 5682
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001633 RID: 5683
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001634 RID: 5684
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__1;

			// Token: 0x04001635 RID: 5685
			private static readonly IntPtr NativeFieldInfoPtr__state_5__2;

			// Token: 0x04001636 RID: 5686
			private static readonly IntPtr NativeFieldInfoPtr__position_5__3;

			// Token: 0x04001637 RID: 5687
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001638 RID: 5688
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001639 RID: 5689
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400163A RID: 5690
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
