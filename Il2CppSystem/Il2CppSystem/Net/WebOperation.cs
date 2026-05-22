using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x0200013E RID: 318
	public class WebOperation : Object
	{
		// Token: 0x060013CD RID: 5069 RVA: 0x0005A8DC File Offset: 0x00058ADC
		// Note: this type is marked as 'beforefieldinit'.
		static WebOperation()
		{
			Il2CppClassPointerStore<WebOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebOperation>.NativeClassPtr);
			WebOperation.NativeFieldInfoPtr__Request_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<Request>k__BackingField");
			WebOperation.NativeFieldInfoPtr__Connection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<Connection>k__BackingField");
			WebOperation.NativeFieldInfoPtr__ServicePoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<ServicePoint>k__BackingField");
			WebOperation.NativeFieldInfoPtr__WriteBuffer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<WriteBuffer>k__BackingField");
			WebOperation.NativeFieldInfoPtr__IsNtlmChallenge_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<IsNtlmChallenge>k__BackingField");
			WebOperation.NativeFieldInfoPtr_cts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "cts");
			WebOperation.NativeFieldInfoPtr_requestTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "requestTask");
			WebOperation.NativeFieldInfoPtr_requestWrittenTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "requestWrittenTask");
			WebOperation.NativeFieldInfoPtr_responseTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "responseTask");
			WebOperation.NativeFieldInfoPtr_completeResponseReadTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "completeResponseReadTask");
			WebOperation.NativeFieldInfoPtr_finishedTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "finishedTask");
			WebOperation.NativeFieldInfoPtr_writeStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "writeStream");
			WebOperation.NativeFieldInfoPtr_responseStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "responseStream");
			WebOperation.NativeFieldInfoPtr_disposedInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "disposedInfo");
			WebOperation.NativeFieldInfoPtr_closedInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "closedInfo");
			WebOperation.NativeFieldInfoPtr_priorityRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "priorityRequest");
			WebOperation.NativeFieldInfoPtr_finishedReading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "finishedReading");
			WebOperation.NativeFieldInfoPtr_requestSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "requestSent");
			WebOperation.NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666091);
			WebOperation.NativeMethodInfoPtr_get_Connection_Public_get_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666092);
			WebOperation.NativeMethodInfoPtr_set_Connection_Private_set_Void_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666093);
			WebOperation.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666094);
			WebOperation.NativeMethodInfoPtr_set_ServicePoint_Private_set_Void_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666095);
			WebOperation.NativeMethodInfoPtr_get_WriteBuffer_Public_get_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666096);
			WebOperation.NativeMethodInfoPtr_get_IsNtlmChallenge_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666097);
			WebOperation.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_BufferOffsetSize_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666098);
			WebOperation.NativeMethodInfoPtr_get_Aborted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666099);
			WebOperation.NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666100);
			WebOperation.NativeMethodInfoPtr_Abort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666101);
			WebOperation.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666102);
			WebOperation.NativeMethodInfoPtr_SetCanceled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666103);
			WebOperation.NativeMethodInfoPtr_SetError_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666104);
			WebOperation.NativeMethodInfoPtr_SetDisposed_Private_ValueTuple_2_ExceptionDispatchInfo_Boolean_byref_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666105);
			WebOperation.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666106);
			WebOperation.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666107);
			WebOperation.NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666108);
			WebOperation.NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666109);
			WebOperation.NativeMethodInfoPtr_ThrowDisposed_Private_Void_byref_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666110);
			WebOperation.NativeMethodInfoPtr_RegisterRequest_Internal_Void_ServicePoint_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666111);
			WebOperation.NativeMethodInfoPtr_SetPriorityRequest_Public_Void_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666112);
			WebOperation.NativeMethodInfoPtr_GetRequestStream_Public_Task_1_WebRequestStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666113);
			WebOperation.NativeMethodInfoPtr_get_WriteStream_Public_get_WebRequestStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666114);
			WebOperation.NativeMethodInfoPtr_GetResponseStream_Public_Task_1_WebResponseStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666115);
			WebOperation.NativeMethodInfoPtr_WaitForCompletion_Internal_Task_1_ValueTuple_2_Boolean_WebOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666116);
			WebOperation.NativeMethodInfoPtr_Run_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666117);
			WebOperation.NativeMethodInfoPtr_FinishReading_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666118);
			WebOperation.NativeMethodInfoPtr_CompleteRequestWritten_Internal_Void_WebRequestStream_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666119);
			WebOperation.NativeMethodInfoPtr_CompleteResponseRead_Internal_Void_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666120);
			WebOperation.NativeMethodInfoPtr__RegisterRequest_b__46_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100666121);
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x0005ACE0 File Offset: 0x00058EE0
		public unsafe HttpWebRequest Request
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x0005AD20 File Offset: 0x00058F20
		// (set) Token: 0x060013D0 RID: 5072 RVA: 0x0005AD60 File Offset: 0x00058F60
		public unsafe WebConnection Connection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_Connection_Public_get_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_set_Connection_Private_set_Void_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x0005ADA4 File Offset: 0x00058FA4
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x0005ADE4 File Offset: 0x00058FE4
		public unsafe ServicePoint ServicePoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_set_ServicePoint_Private_set_Void_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x0005AE28 File Offset: 0x00059028
		public unsafe BufferOffsetSize WriteBuffer
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_WriteBuffer_Public_get_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr3) : null;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x0005AE68 File Offset: 0x00059068
		public unsafe bool IsNtlmChallenge
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_IsNtlmChallenge_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0005AEA4 File Offset: 0x000590A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 385277, RefRangeEnd = 385279, XrefRangeStart = 385242, XrefRangeEnd = 385277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebOperation(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebOperation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writeBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNtlmChallenge;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_BufferOffsetSize_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x0005AF28 File Offset: 0x00059128
		public unsafe bool Aborted
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 385279, RefRangeEnd = 385282, XrefRangeStart = 385279, XrefRangeEnd = 385279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_Aborted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0005AF64 File Offset: 0x00059164
		public unsafe bool Closed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0005AFA0 File Offset: 0x000591A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385286, RefRangeEnd = 385287, XrefRangeStart = 385282, XrefRangeEnd = 385286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_Abort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0005AFD4 File Offset: 0x000591D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 385290, RefRangeEnd = 385292, XrefRangeStart = 385287, XrefRangeEnd = 385290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0005B008 File Offset: 0x00059208
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 385300, RefRangeEnd = 385303, XrefRangeStart = 385292, XrefRangeEnd = 385300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanceled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_SetCanceled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0005B03C File Offset: 0x0005923C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 385318, RefRangeEnd = 385321, XrefRangeStart = 385303, XrefRangeEnd = 385318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetError(Exception error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_SetError_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0005B080 File Offset: 0x00059280
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 385332, RefRangeEnd = 385337, XrefRangeStart = 385321, XrefRangeEnd = 385332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<ExceptionDispatchInfo, bool> SetDisposed(ref ExceptionDispatchInfo field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(field);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_SetDisposed_Private_ValueTuple_2_ExceptionDispatchInfo_Boolean_byref_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				field = ((intPtr4 == 0) ? null : new ExceptionDispatchInfo(intPtr4));
				return new ValueTuple<ExceptionDispatchInfo, bool>(intPtr2);
			}
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0005B0E0 File Offset: 0x000592E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385337, XrefRangeEnd = 385341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0005B114 File Offset: 0x00059314
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 385341, RefRangeEnd = 385347, XrefRangeStart = 385341, XrefRangeEnd = 385341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfDisposed(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0005B15C File Offset: 0x0005935C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385351, RefRangeEnd = 385352, XrefRangeStart = 385347, XrefRangeEnd = 385351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfClosedOrDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0005B190 File Offset: 0x00059390
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 385352, RefRangeEnd = 385369, XrefRangeStart = 385352, XrefRangeEnd = 385352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfClosedOrDisposed(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0005B1D8 File Offset: 0x000593D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385369, XrefRangeEnd = 385377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowDisposed(ref ExceptionDispatchInfo field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(field);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_ThrowDisposed_Private_Void_byref_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				field = ((intPtr4 == 0) ? null : new ExceptionDispatchInfo(intPtr4));
			}
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0005B230 File Offset: 0x00059430
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 385391, RefRangeEnd = 385393, XrefRangeStart = 385377, XrefRangeEnd = 385391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterRequest(ServicePoint servicePoint, WebConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(servicePoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_RegisterRequest_Internal_Void_ServicePoint_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0005B284 File Offset: 0x00059484
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385397, RefRangeEnd = 385398, XrefRangeStart = 385393, XrefRangeEnd = 385397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPriorityRequest(WebOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_SetPriorityRequest_Public_Void_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x0005B2C8 File Offset: 0x000594C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385398, XrefRangeEnd = 385399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<WebRequestStream> GetRequestStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_GetRequestStream_Public_Task_1_WebRequestStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebRequestStream>>(intPtr3) : null;
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x0005B308 File Offset: 0x00059508
		public unsafe WebRequestStream WriteStream
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385399, XrefRangeEnd = 385403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_WriteStream_Public_get_WebRequestStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr3) : null;
			}
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x0005B348 File Offset: 0x00059548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385403, XrefRangeEnd = 385404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<WebResponseStream> GetResponseStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_GetResponseStream_Public_Task_1_WebResponseStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebResponseStream>>(intPtr3) : null;
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0005B388 File Offset: 0x00059588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385404, XrefRangeEnd = 385414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<ValueTuple<bool, WebOperation>> WaitForCompletion(bool ignoreErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ignoreErrors;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_WaitForCompletion_Internal_Task_1_ValueTuple_2_Boolean_WebOperation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<ValueTuple<bool, WebOperation>>>(intPtr3) : null;
			}
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x0005B3D4 File Offset: 0x000595D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385414, XrefRangeEnd = 385418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_Run_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0005B408 File Offset: 0x00059608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385422, RefRangeEnd = 385423, XrefRangeStart = 385418, XrefRangeEnd = 385422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishReading()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_FinishReading_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0005B43C File Offset: 0x0005963C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385423, XrefRangeEnd = 385428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteRequestWritten(WebRequestStream stream, Exception error = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_CompleteRequestWritten_Internal_Void_WebRequestStream_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0005B490 File Offset: 0x00059690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385433, RefRangeEnd = 385434, XrefRangeStart = 385428, XrefRangeEnd = 385433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteResponseRead(bool ok, Exception error = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ok;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_CompleteResponseRead_Internal_Void_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0005B4E0 File Offset: 0x000596E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385434, XrefRangeEnd = 385435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RegisterRequest_b__46_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr__RegisterRequest_b__46_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0000A0EC File Offset: 0x000082EC
		public WebOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x0005B514 File Offset: 0x00059714
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x0000A0F5 File Offset: 0x000082F5
		public unsafe HttpWebRequest _Request_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__Request_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__Request_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0005B544 File Offset: 0x00059744
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x0000A114 File Offset: 0x00008314
		public unsafe WebConnection _Connection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__Connection_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__Connection_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x0005B574 File Offset: 0x00059774
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x0000A133 File Offset: 0x00008333
		public unsafe ServicePoint _ServicePoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__ServicePoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__ServicePoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x0005B5A4 File Offset: 0x000597A4
		// (set) Token: 0x060013F5 RID: 5109 RVA: 0x0000A152 File Offset: 0x00008352
		public unsafe BufferOffsetSize _WriteBuffer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__WriteBuffer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__WriteBuffer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0005B5D4 File Offset: 0x000597D4
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x0000A171 File Offset: 0x00008371
		public unsafe bool _IsNtlmChallenge_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__IsNtlmChallenge_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__IsNtlmChallenge_k__BackingField)) = value;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x0005B5FC File Offset: 0x000597FC
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x0000A18C File Offset: 0x0000838C
		public unsafe CancellationTokenSource cts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_cts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_cts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x0005B62C File Offset: 0x0005982C
		// (set) Token: 0x060013FB RID: 5115 RVA: 0x0000A1AB File Offset: 0x000083AB
		public unsafe TaskCompletionSource<WebRequestStream> requestTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<WebRequestStream>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x0005B65C File Offset: 0x0005985C
		// (set) Token: 0x060013FD RID: 5117 RVA: 0x0000A1CA File Offset: 0x000083CA
		public unsafe TaskCompletionSource<WebRequestStream> requestWrittenTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestWrittenTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<WebRequestStream>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestWrittenTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0005B68C File Offset: 0x0005988C
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x0000A1E9 File Offset: 0x000083E9
		public unsafe TaskCompletionSource<WebResponseStream> responseTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_responseTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<WebResponseStream>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_responseTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x0005B6BC File Offset: 0x000598BC
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x0000A208 File Offset: 0x00008408
		public unsafe TaskCompletionSource<bool> completeResponseReadTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_completeResponseReadTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_completeResponseReadTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x0005B6EC File Offset: 0x000598EC
		// (set) Token: 0x06001403 RID: 5123 RVA: 0x0000A227 File Offset: 0x00008427
		public unsafe TaskCompletionSource<ValueTuple<bool, WebOperation>> finishedTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_finishedTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<ValueTuple<bool, WebOperation>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_finishedTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x0005B71C File Offset: 0x0005991C
		// (set) Token: 0x06001405 RID: 5125 RVA: 0x0000A246 File Offset: 0x00008446
		public unsafe WebRequestStream writeStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_writeStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_writeStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x0005B74C File Offset: 0x0005994C
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x0000A265 File Offset: 0x00008465
		public unsafe WebResponseStream responseStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_responseStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_responseStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x0005B77C File Offset: 0x0005997C
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x0000A284 File Offset: 0x00008484
		public unsafe ExceptionDispatchInfo disposedInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_disposedInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_disposedInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x0005B7AC File Offset: 0x000599AC
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x0000A2A3 File Offset: 0x000084A3
		public unsafe ExceptionDispatchInfo closedInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_closedInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_closedInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x0005B7DC File Offset: 0x000599DC
		// (set) Token: 0x0600140D RID: 5133 RVA: 0x0000A2C2 File Offset: 0x000084C2
		public unsafe WebOperation priorityRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_priorityRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_priorityRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x0005B80C File Offset: 0x00059A0C
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x0000A2E1 File Offset: 0x000084E1
		public unsafe bool finishedReading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_finishedReading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_finishedReading)) = value;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0005B834 File Offset: 0x00059A34
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x0000A2FC File Offset: 0x000084FC
		public unsafe int requestSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestSent)) = value;
			}
		}

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeFieldInfoPtr__Request_k__BackingField;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeFieldInfoPtr__Connection_k__BackingField;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeFieldInfoPtr__ServicePoint_k__BackingField;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeFieldInfoPtr__WriteBuffer_k__BackingField;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeFieldInfoPtr__IsNtlmChallenge_k__BackingField;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeFieldInfoPtr_cts;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeFieldInfoPtr_requestTask;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeFieldInfoPtr_requestWrittenTask;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeFieldInfoPtr_responseTask;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeFieldInfoPtr_completeResponseReadTask;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeFieldInfoPtr_finishedTask;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeFieldInfoPtr_writeStream;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeFieldInfoPtr_responseStream;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeFieldInfoPtr_disposedInfo;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeFieldInfoPtr_closedInfo;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeFieldInfoPtr_priorityRequest;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeFieldInfoPtr_finishedReading;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeFieldInfoPtr_requestSent;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeMethodInfoPtr_get_Connection_Public_get_WebConnection_0;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeMethodInfoPtr_set_Connection_Private_set_Void_WebConnection_0;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeMethodInfoPtr_set_ServicePoint_Private_set_Void_ServicePoint_0;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteBuffer_Public_get_BufferOffsetSize_0;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNtlmChallenge_Public_get_Boolean_0;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_BufferOffsetSize_Boolean_CancellationToken_0;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeMethodInfoPtr_get_Aborted_Public_get_Boolean_0;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Void_0;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeMethodInfoPtr_SetCanceled_Private_Void_0;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeMethodInfoPtr_SetError_Private_Void_Exception_0;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeMethodInfoPtr_SetDisposed_Private_ValueTuple_2_ExceptionDispatchInfo_Boolean_byref_ExceptionDispatchInfo_0;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_CancellationToken_0;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_0;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_CancellationToken_0;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeMethodInfoPtr_ThrowDisposed_Private_Void_byref_ExceptionDispatchInfo_0;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeMethodInfoPtr_RegisterRequest_Internal_Void_ServicePoint_WebConnection_0;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeMethodInfoPtr_SetPriorityRequest_Public_Void_WebOperation_0;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestStream_Public_Task_1_WebRequestStream_0;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteStream_Public_get_WebRequestStream_0;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseStream_Public_Task_1_WebResponseStream_0;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Internal_Task_1_ValueTuple_2_Boolean_WebOperation_Boolean_0;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Void_0;

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeMethodInfoPtr_FinishReading_Private_Void_0;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeMethodInfoPtr_CompleteRequestWritten_Internal_Void_WebRequestStream_Exception_0;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeMethodInfoPtr_CompleteResponseRead_Internal_Void_Boolean_Exception_0;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeMethodInfoPtr__RegisterRequest_b__46_0_Private_Void_0;

		// Token: 0x020001FC RID: 508
		[ObfuscatedName("System.Net.WebOperation+<WaitForCompletion>d__53")]
		public sealed class _WaitForCompletion_d__53 : ValueType
		{
			// Token: 0x06001BC1 RID: 7105 RVA: 0x00073CA8 File Offset: 0x00071EA8
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForCompletion_d__53()
			{
				Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<WaitForCompletion>d__53");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr);
				WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr, "<>1__state");
				WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr, "<>t__builder");
				WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr, "<>4__this");
				WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr_ignoreErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr, "ignoreErrors");
				WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr, "<>u__1");
				WebOperation._WaitForCompletion_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr, 100666122);
				WebOperation._WaitForCompletion_d__53.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr, 100666123);
			}

			// Token: 0x06001BC2 RID: 7106 RVA: 0x00073D60 File Offset: 0x00071F60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385094, XrefRangeEnd = 385118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation._WaitForCompletion_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BC3 RID: 7107 RVA: 0x00073D98 File Offset: 0x00071F98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385118, XrefRangeEnd = 385133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation._WaitForCompletion_d__53.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BC4 RID: 7108 RVA: 0x0000EA7C File Offset: 0x0000CC7C
			public _WaitForCompletion_d__53(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001BC5 RID: 7109 RVA: 0x0000EA85 File Offset: 0x0000CC85
			public _WaitForCompletion_d__53()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr))
			{
			}

			// Token: 0x170008E0 RID: 2272
			// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x00073DE0 File Offset: 0x00071FE0
			// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x0000EA97 File Offset: 0x0000CC97
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008E1 RID: 2273
			// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x00073E08 File Offset: 0x00072008
			// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x0000EAB2 File Offset: 0x0000CCB2
			public AsyncTaskMethodBuilder<ValueTuple<bool, WebOperation>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<ValueTuple<bool, WebOperation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<bool, WebOperation>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<bool, WebOperation>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008E2 RID: 2274
			// (get) Token: 0x06001BCA RID: 7114 RVA: 0x00073E38 File Offset: 0x00072038
			// (set) Token: 0x06001BCB RID: 7115 RVA: 0x0000EAE0 File Offset: 0x0000CCE0
			public unsafe WebOperation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E3 RID: 2275
			// (get) Token: 0x06001BCC RID: 7116 RVA: 0x00073E68 File Offset: 0x00072068
			// (set) Token: 0x06001BCD RID: 7117 RVA: 0x0000EAFF File Offset: 0x0000CCFF
			public unsafe bool ignoreErrors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr_ignoreErrors);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr_ignoreErrors)) = value;
				}
			}

			// Token: 0x170008E4 RID: 2276
			// (get) Token: 0x06001BCE RID: 7118 RVA: 0x00073E90 File Offset: 0x00072090
			// (set) Token: 0x06001BCF RID: 7119 RVA: 0x0000EB1A File Offset: 0x0000CD1A
			public ConfiguredTaskAwaitable<ValueTuple<bool, WebOperation>>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<ValueTuple<bool, WebOperation>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<bool, WebOperation>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<bool, WebOperation>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400157D RID: 5501
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400157E RID: 5502
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400157F RID: 5503
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001580 RID: 5504
			private static readonly IntPtr NativeFieldInfoPtr_ignoreErrors;

			// Token: 0x04001581 RID: 5505
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001582 RID: 5506
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001583 RID: 5507
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001FD RID: 509
		[ObfuscatedName("System.Net.WebOperation+<Run>d__54")]
		public sealed class _Run_d__54 : ValueType
		{
			// Token: 0x06001BD0 RID: 7120 RVA: 0x00073EC0 File Offset: 0x000720C0
			// Note: this type is marked as 'beforefieldinit'.
			static _Run_d__54()
			{
				Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<Run>d__54");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr);
				WebOperation._Run_d__54.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, "<>1__state");
				WebOperation._Run_d__54.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, "<>t__builder");
				WebOperation._Run_d__54.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, "<>4__this");
				WebOperation._Run_d__54.NativeFieldInfoPtr__requestStream_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, "<requestStream>5__1");
				WebOperation._Run_d__54.NativeFieldInfoPtr__stream_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, "<stream>5__2");
				WebOperation._Run_d__54.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, "<>u__1");
				WebOperation._Run_d__54.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, "<>u__2");
				WebOperation._Run_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, 100666124);
				WebOperation._Run_d__54.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, 100666125);
			}

			// Token: 0x06001BD1 RID: 7121 RVA: 0x00073FA0 File Offset: 0x000721A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385133, XrefRangeEnd = 385202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation._Run_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BD2 RID: 7122 RVA: 0x00073FD8 File Offset: 0x000721D8
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation._Run_d__54.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BD3 RID: 7123 RVA: 0x0000EB48 File Offset: 0x0000CD48
			public _Run_d__54(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001BD4 RID: 7124 RVA: 0x0000EB51 File Offset: 0x0000CD51
			public _Run_d__54()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr))
			{
			}

			// Token: 0x170008E5 RID: 2277
			// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x00074020 File Offset: 0x00072220
			// (set) Token: 0x06001BD6 RID: 7126 RVA: 0x0000EB63 File Offset: 0x0000CD63
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008E6 RID: 2278
			// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x00074048 File Offset: 0x00072248
			// (set) Token: 0x06001BD8 RID: 7128 RVA: 0x0000EB7E File Offset: 0x0000CD7E
			public AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___t__builder);
					return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008E7 RID: 2279
			// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x00074078 File Offset: 0x00072278
			// (set) Token: 0x06001BDA RID: 7130 RVA: 0x0000EBAC File Offset: 0x0000CDAC
			public unsafe WebOperation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E8 RID: 2280
			// (get) Token: 0x06001BDB RID: 7131 RVA: 0x000740A8 File Offset: 0x000722A8
			// (set) Token: 0x06001BDC RID: 7132 RVA: 0x0000EBCB File Offset: 0x0000CDCB
			public unsafe WebRequestStream _requestStream_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr__requestStream_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr__requestStream_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E9 RID: 2281
			// (get) Token: 0x06001BDD RID: 7133 RVA: 0x000740D8 File Offset: 0x000722D8
			// (set) Token: 0x06001BDE RID: 7134 RVA: 0x0000EBEA File Offset: 0x0000CDEA
			public unsafe WebResponseStream _stream_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr__stream_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr__stream_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008EA RID: 2282
			// (get) Token: 0x06001BDF RID: 7135 RVA: 0x00074108 File Offset: 0x00072308
			// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x0000EC09 File Offset: 0x0000CE09
			public ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008EB RID: 2283
			// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x00074138 File Offset: 0x00072338
			// (set) Token: 0x06001BE2 RID: 7138 RVA: 0x0000EC37 File Offset: 0x0000CE37
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001584 RID: 5508
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001585 RID: 5509
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001586 RID: 5510
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001587 RID: 5511
			private static readonly IntPtr NativeFieldInfoPtr__requestStream_5__1;

			// Token: 0x04001588 RID: 5512
			private static readonly IntPtr NativeFieldInfoPtr__stream_5__2;

			// Token: 0x04001589 RID: 5513
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400158A RID: 5514
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400158B RID: 5515
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400158C RID: 5516
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001FE RID: 510
		[ObfuscatedName("System.Net.WebOperation+<FinishReading>d__55")]
		public sealed class _FinishReading_d__55 : ValueType
		{
			// Token: 0x06001BE3 RID: 7139 RVA: 0x00074168 File Offset: 0x00072368
			// Note: this type is marked as 'beforefieldinit'.
			static _FinishReading_d__55()
			{
				Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<FinishReading>d__55");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr);
				WebOperation._FinishReading_d__55.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr, "<>1__state");
				WebOperation._FinishReading_d__55.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr, "<>t__builder");
				WebOperation._FinishReading_d__55.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr, "<>4__this");
				WebOperation._FinishReading_d__55.NativeFieldInfoPtr__error_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr, "<error>5__1");
				WebOperation._FinishReading_d__55.NativeFieldInfoPtr__ok_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr, "<ok>5__2");
				WebOperation._FinishReading_d__55.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr, "<>u__1");
				WebOperation._FinishReading_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr, 100666126);
				WebOperation._FinishReading_d__55.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr, 100666127);
			}

			// Token: 0x06001BE4 RID: 7140 RVA: 0x00074234 File Offset: 0x00072434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385202, XrefRangeEnd = 385242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation._FinishReading_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BE5 RID: 7141 RVA: 0x0007426C File Offset: 0x0007246C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation._FinishReading_d__55.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BE6 RID: 7142 RVA: 0x0000EC65 File Offset: 0x0000CE65
			public _FinishReading_d__55(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001BE7 RID: 7143 RVA: 0x0000EC6E File Offset: 0x0000CE6E
			public _FinishReading_d__55()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr))
			{
			}

			// Token: 0x170008EC RID: 2284
			// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x000742B4 File Offset: 0x000724B4
			// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x0000EC80 File Offset: 0x0000CE80
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008ED RID: 2285
			// (get) Token: 0x06001BEA RID: 7146 RVA: 0x000742DC File Offset: 0x000724DC
			// (set) Token: 0x06001BEB RID: 7147 RVA: 0x0000EC9B File Offset: 0x0000CE9B
			public AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr___t__builder);
					return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008EE RID: 2286
			// (get) Token: 0x06001BEC RID: 7148 RVA: 0x0007430C File Offset: 0x0007250C
			// (set) Token: 0x06001BED RID: 7149 RVA: 0x0000ECC9 File Offset: 0x0000CEC9
			public unsafe WebOperation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008EF RID: 2287
			// (get) Token: 0x06001BEE RID: 7150 RVA: 0x0007433C File Offset: 0x0007253C
			// (set) Token: 0x06001BEF RID: 7151 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
			public unsafe Exception _error_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr__error_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr__error_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F0 RID: 2288
			// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x0007436C File Offset: 0x0007256C
			// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x0000ED07 File Offset: 0x0000CF07
			public unsafe bool _ok_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr__ok_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr__ok_5__2)) = value;
				}
			}

			// Token: 0x170008F1 RID: 2289
			// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x00074394 File Offset: 0x00072594
			// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x0000ED22 File Offset: 0x0000CF22
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400158D RID: 5517
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400158E RID: 5518
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400158F RID: 5519
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001590 RID: 5520
			private static readonly IntPtr NativeFieldInfoPtr__error_5__1;

			// Token: 0x04001591 RID: 5521
			private static readonly IntPtr NativeFieldInfoPtr__ok_5__2;

			// Token: 0x04001592 RID: 5522
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001593 RID: 5523
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001594 RID: 5524
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
