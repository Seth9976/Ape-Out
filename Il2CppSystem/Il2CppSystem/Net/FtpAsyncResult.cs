using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x02000129 RID: 297
	public class FtpAsyncResult : Object
	{
		// Token: 0x06001094 RID: 4244 RVA: 0x0004EE90 File Offset: 0x0004D090
		// Note: this type is marked as 'beforefieldinit'.
		static FtpAsyncResult()
		{
			Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FtpAsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr);
			FtpAsyncResult.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "response");
			FtpAsyncResult.NativeFieldInfoPtr_waitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "waitHandle");
			FtpAsyncResult.NativeFieldInfoPtr_exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "exception");
			FtpAsyncResult.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "callback");
			FtpAsyncResult.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "stream");
			FtpAsyncResult.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "state");
			FtpAsyncResult.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "completed");
			FtpAsyncResult.NativeFieldInfoPtr_synch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "synch");
			FtpAsyncResult.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "locker");
			FtpAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665663);
			FtpAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665664);
			FtpAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665665);
			FtpAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665666);
			FtpAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665667);
			FtpAsyncResult.NativeMethodInfoPtr_get_GotException_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665668);
			FtpAsyncResult.NativeMethodInfoPtr_get_Exception_Internal_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665669);
			FtpAsyncResult.NativeMethodInfoPtr_get_Response_Internal_get_FtpWebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665670);
			FtpAsyncResult.NativeMethodInfoPtr_set_Stream_Internal_set_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665671);
			FtpAsyncResult.NativeMethodInfoPtr_WaitUntilComplete_Internal_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665672);
			FtpAsyncResult.NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_Exception_FtpWebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665673);
			FtpAsyncResult.NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_FtpWebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665674);
			FtpAsyncResult.NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665675);
			FtpAsyncResult.NativeMethodInfoPtr_DoCallback_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665676);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0004F08C File Offset: 0x0004D28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380779, XrefRangeEnd = 380782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpAsyncResult(AsyncCallback callback, Object state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x0004F0EC File Offset: 0x0004D2EC
		public unsafe virtual Object AsyncState
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x0004F12C File Offset: 0x0004D32C
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 380789, RefRangeEnd = 380791, XrefRangeStart = 380782, XrefRangeEnd = 380789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x0004F16C File Offset: 0x0004D36C
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x0004F1A8 File Offset: 0x0004D3A8
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 380794, RefRangeEnd = 380797, XrefRangeStart = 380791, XrefRangeEnd = 380794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x0004F1E4 File Offset: 0x0004D3E4
		public unsafe bool GotException
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_get_GotException_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x0004F220 File Offset: 0x0004D420
		public unsafe Exception Exception
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_get_Exception_Internal_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x0004F260 File Offset: 0x0004D460
		public unsafe FtpWebResponse Response
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_get_Response_Internal_get_FtpWebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FtpWebResponse>(intPtr3) : null;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (set) Token: 0x0600109D RID: 4253 RVA: 0x0004F2A0 File Offset: 0x0004D4A0
		public unsafe Stream Stream
		{
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_set_Stream_Internal_set_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0004F2E4 File Offset: 0x0004D4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380797, XrefRangeEnd = 380799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WaitUntilComplete(int timeout, bool exitContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_WaitUntilComplete_Internal_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0004F33C File Offset: 0x0004D53C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 380813, RefRangeEnd = 380818, XrefRangeStart = 380799, XrefRangeEnd = 380813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCompleted(bool synch, Exception exc, FtpWebResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref synch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exc);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_Exception_FtpWebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0004F3A0 File Offset: 0x0004D5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380818, XrefRangeEnd = 380819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCompleted(bool synch, FtpWebResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref synch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_FtpWebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0004F3F0 File Offset: 0x0004D5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380819, XrefRangeEnd = 380820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCompleted(bool synch, Exception exc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref synch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0004F440 File Offset: 0x0004D640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380822, RefRangeEnd = 380823, XrefRangeStart = 380820, XrefRangeEnd = 380822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_DoCallback_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00008877 File Offset: 0x00006A77
		public FtpAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x0004F474 File Offset: 0x0004D674
		// (set) Token: 0x060010A5 RID: 4261 RVA: 0x00008880 File Offset: 0x00006A80
		public unsafe FtpWebResponse response
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_response);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FtpWebResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_response), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x0004F4A4 File Offset: 0x0004D6A4
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x0000889F File Offset: 0x00006A9F
		public unsafe ManualResetEvent waitHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_waitHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_waitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x0004F4D4 File Offset: 0x0004D6D4
		// (set) Token: 0x060010A9 RID: 4265 RVA: 0x000088BE File Offset: 0x00006ABE
		public unsafe Exception exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x0004F504 File Offset: 0x0004D704
		// (set) Token: 0x060010AB RID: 4267 RVA: 0x000088DD File Offset: 0x00006ADD
		public unsafe AsyncCallback callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060010AC RID: 4268 RVA: 0x0004F534 File Offset: 0x0004D734
		// (set) Token: 0x060010AD RID: 4269 RVA: 0x000088FC File Offset: 0x00006AFC
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060010AE RID: 4270 RVA: 0x0004F564 File Offset: 0x0004D764
		// (set) Token: 0x060010AF RID: 4271 RVA: 0x0000891B File Offset: 0x00006B1B
		public unsafe Object state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060010B0 RID: 4272 RVA: 0x0004F594 File Offset: 0x0004D794
		// (set) Token: 0x060010B1 RID: 4273 RVA: 0x0000893A File Offset: 0x00006B3A
		public unsafe bool completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_completed)) = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x0004F5BC File Offset: 0x0004D7BC
		// (set) Token: 0x060010B3 RID: 4275 RVA: 0x00008955 File Offset: 0x00006B55
		public unsafe bool synch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_synch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_synch)) = value;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x0004F5E4 File Offset: 0x0004D7E4
		// (set) Token: 0x060010B5 RID: 4277 RVA: 0x00008970 File Offset: 0x00006B70
		public unsafe Object locker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_locker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_locker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeFieldInfoPtr_response;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeFieldInfoPtr_waitHandle;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeFieldInfoPtr_exception;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeFieldInfoPtr_completed;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeFieldInfoPtr_synch;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_get_GotException_Internal_get_Boolean_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Internal_get_Exception_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_get_Response_Internal_get_FtpWebResponse_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_set_Stream_Internal_set_Void_Stream_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_WaitUntilComplete_Internal_Boolean_Int32_Boolean_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_Exception_FtpWebResponse_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_FtpWebResponse_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_Exception_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_DoCallback_Internal_Void_0;
	}
}
