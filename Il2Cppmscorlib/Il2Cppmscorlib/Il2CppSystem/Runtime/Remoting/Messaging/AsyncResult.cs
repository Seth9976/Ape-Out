using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E5 RID: 997
	public class AsyncResult : Object
	{
		// Token: 0x0600401D RID: 16413 RVA: 0x0012C570 File Offset: 0x0012A770
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncResult()
		{
			Il2CppClassPointerStore<AsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "AsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr);
			AsyncResult.NativeFieldInfoPtr_async_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "async_state");
			AsyncResult.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "handle");
			AsyncResult.NativeFieldInfoPtr_async_delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "async_delegate");
			AsyncResult.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "data");
			AsyncResult.NativeFieldInfoPtr_object_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "object_data");
			AsyncResult.NativeFieldInfoPtr_sync_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "sync_completed");
			AsyncResult.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "completed");
			AsyncResult.NativeFieldInfoPtr_endinvoke_called = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "endinvoke_called");
			AsyncResult.NativeFieldInfoPtr_async_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "async_callback");
			AsyncResult.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "current");
			AsyncResult.NativeFieldInfoPtr_original = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "original");
			AsyncResult.NativeFieldInfoPtr_add_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "add_time");
			AsyncResult.NativeFieldInfoPtr_call_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "call_message");
			AsyncResult.NativeFieldInfoPtr_message_ctrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "message_ctrl");
			AsyncResult.NativeFieldInfoPtr_reply_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "reply_message");
			AsyncResult.NativeFieldInfoPtr_orig_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "orig_cb");
			AsyncResult.NativeFieldInfoPtr_ccb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "ccb");
			AsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672740);
			AsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_WaitCallback_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672741);
			AsyncResult.NativeMethodInfoPtr_WaitCallback_Context_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672742);
			AsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672743);
			AsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672744);
			AsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672745);
			AsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672746);
			AsyncResult.NativeMethodInfoPtr_get_EndInvokeCalled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672747);
			AsyncResult.NativeMethodInfoPtr_set_EndInvokeCalled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672748);
			AsyncResult.NativeMethodInfoPtr_get_AsyncDelegate_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672749);
			AsyncResult.NativeMethodInfoPtr_get_NextSink_Public_Virtual_Final_New_get_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672750);
			AsyncResult.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672751);
			AsyncResult.NativeMethodInfoPtr_GetReplyMessage_Public_Virtual_New_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672752);
			AsyncResult.NativeMethodInfoPtr_SetMessageCtrl_Public_Virtual_New_Void_IMessageCtrl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672753);
			AsyncResult.NativeMethodInfoPtr_SetCompletedSynchronously_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672754);
			AsyncResult.NativeMethodInfoPtr_EndInvoke_Internal_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672755);
			AsyncResult.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672756);
			AsyncResult.NativeMethodInfoPtr_get_CallMessage_Internal_get_MonoMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672757);
			AsyncResult.NativeMethodInfoPtr_set_CallMessage_Internal_set_Void_MonoMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672758);
			AsyncResult.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672759);
			AsyncResult.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672760);
			AsyncResult.NativeMethodInfoPtr_Invoke_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672761);
			AsyncResult.NativeMethodInfoPtr___ctor_b__17_0_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672763);
		}

		// Token: 0x0600401E RID: 16414 RVA: 0x0012C8C0 File Offset: 0x0012AAC0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncResult()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x0012C8FC File Offset: 0x0012AAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223929, XrefRangeEnd = 223938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncResult(WaitCallback cb, Object state, bool capture_context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capture_context;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_WaitCallback_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x0012C968 File Offset: 0x0012AB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223938, XrefRangeEnd = 223943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WaitCallback_Context(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_WaitCallback_Context_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x06004021 RID: 16417 RVA: 0x0012C9A0 File Offset: 0x0012ABA0
		public unsafe virtual Object AsyncState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x06004022 RID: 16418 RVA: 0x0012C9EC File Offset: 0x0012ABEC
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223943, XrefRangeEnd = 223950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_New_get_WaitHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06004023 RID: 16419 RVA: 0x0012CA38 File Offset: 0x0012AC38
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06004024 RID: 16420 RVA: 0x0012CA80 File Offset: 0x0012AC80
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06004025 RID: 16421 RVA: 0x0012CAC8 File Offset: 0x0012ACC8
		// (set) Token: 0x06004026 RID: 16422 RVA: 0x0012CB04 File Offset: 0x0012AD04
		public unsafe bool EndInvokeCalled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_get_EndInvokeCalled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_set_EndInvokeCalled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06004027 RID: 16423 RVA: 0x0012CB44 File Offset: 0x0012AD44
		public unsafe virtual Object AsyncDelegate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_get_AsyncDelegate_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x06004028 RID: 16424 RVA: 0x0012CB90 File Offset: 0x0012AD90
		public unsafe virtual IMessageSink NextSink
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_get_NextSink_Public_Virtual_Final_New_get_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x0012CBD0 File Offset: 0x0012ADD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223950, XrefRangeEnd = 223955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x0012CC40 File Offset: 0x0012AE40
		[CallerCount(0)]
		public unsafe virtual IMessage GetReplyMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_GetReplyMessage_Public_Virtual_New_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x0012CC8C File Offset: 0x0012AE8C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 14893, RefRangeEnd = 14909, XrefRangeStart = 14893, XrefRangeEnd = 14909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMessageCtrl(IMessageCtrl mc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_SetMessageCtrl_Public_Virtual_New_Void_IMessageCtrl_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x0012CCDC File Offset: 0x0012AEDC
		[CallerCount(0)]
		public unsafe void SetCompletedSynchronously(bool completed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref completed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_SetCompletedSynchronously_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x0012CD1C File Offset: 0x0012AF1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223959, RefRangeEnd = 223960, XrefRangeStart = 223955, XrefRangeEnd = 223959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessage EndInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_EndInvoke_Internal_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x0012CD5C File Offset: 0x0012AF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223960, XrefRangeEnd = 223969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x0600402F RID: 16431 RVA: 0x0012CDB8 File Offset: 0x0012AFB8
		// (set) Token: 0x06004030 RID: 16432 RVA: 0x0012CDF8 File Offset: 0x0012AFF8
		public unsafe MonoMethodMessage CallMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_get_CallMessage_Internal_get_MonoMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoMethodMessage>(intPtr3) : null;
			}
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 214194, RefRangeEnd = 214233, XrefRangeStart = 214194, XrefRangeEnd = 214233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_set_CallMessage_Internal_set_Void_MonoMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x0012CE3C File Offset: 0x0012B03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223969, XrefRangeEnd = 223977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x0012CE70 File Offset: 0x0012B070
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_MarkAborted(ThreadAbortException tae)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x0012CEB4 File Offset: 0x0012B0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_Invoke_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x0012CEF4 File Offset: 0x0012B0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223977, XrefRangeEnd = 223985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__17_0(Object <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr___ctor_b__17_0_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x000180BF File Offset: 0x000162BF
		public AsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06004036 RID: 16438 RVA: 0x0012CF38 File Offset: 0x0012B138
		// (set) Token: 0x06004037 RID: 16439 RVA: 0x000180C8 File Offset: 0x000162C8
		public unsafe Object async_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06004038 RID: 16440 RVA: 0x0012CF68 File Offset: 0x0012B168
		// (set) Token: 0x06004039 RID: 16441 RVA: 0x000180E7 File Offset: 0x000162E7
		public unsafe WaitHandle handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x0600403A RID: 16442 RVA: 0x0012CF98 File Offset: 0x0012B198
		// (set) Token: 0x0600403B RID: 16443 RVA: 0x00018106 File Offset: 0x00016306
		public unsafe Object async_delegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_delegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x0600403C RID: 16444 RVA: 0x0012CFC8 File Offset: 0x0012B1C8
		// (set) Token: 0x0600403D RID: 16445 RVA: 0x00018125 File Offset: 0x00016325
		public unsafe IntPtr data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_data)) = value;
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x0600403E RID: 16446 RVA: 0x0012CFF0 File Offset: 0x0012B1F0
		// (set) Token: 0x0600403F RID: 16447 RVA: 0x00018140 File Offset: 0x00016340
		public unsafe Object object_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_object_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_object_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06004040 RID: 16448 RVA: 0x0012D020 File Offset: 0x0012B220
		// (set) Token: 0x06004041 RID: 16449 RVA: 0x0001815F File Offset: 0x0001635F
		public unsafe bool sync_completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_sync_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_sync_completed)) = value;
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06004042 RID: 16450 RVA: 0x0012D048 File Offset: 0x0012B248
		// (set) Token: 0x06004043 RID: 16451 RVA: 0x0001817A File Offset: 0x0001637A
		public unsafe bool completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_completed)) = value;
			}
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06004044 RID: 16452 RVA: 0x0012D070 File Offset: 0x0012B270
		// (set) Token: 0x06004045 RID: 16453 RVA: 0x00018195 File Offset: 0x00016395
		public unsafe bool endinvoke_called
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_endinvoke_called);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_endinvoke_called)) = value;
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06004046 RID: 16454 RVA: 0x0012D098 File Offset: 0x0012B298
		// (set) Token: 0x06004047 RID: 16455 RVA: 0x000181B0 File Offset: 0x000163B0
		public unsafe Object async_callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x06004048 RID: 16456 RVA: 0x0012D0C8 File Offset: 0x0012B2C8
		// (set) Token: 0x06004049 RID: 16457 RVA: 0x000181CF File Offset: 0x000163CF
		public unsafe ExecutionContext current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x0600404A RID: 16458 RVA: 0x0012D0F8 File Offset: 0x0012B2F8
		// (set) Token: 0x0600404B RID: 16459 RVA: 0x000181EE File Offset: 0x000163EE
		public unsafe ExecutionContext original
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_original);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_original), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x0600404C RID: 16460 RVA: 0x0012D128 File Offset: 0x0012B328
		// (set) Token: 0x0600404D RID: 16461 RVA: 0x0001820D File Offset: 0x0001640D
		public unsafe long add_time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_add_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_add_time)) = value;
			}
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x0600404E RID: 16462 RVA: 0x0012D150 File Offset: 0x0012B350
		// (set) Token: 0x0600404F RID: 16463 RVA: 0x00018228 File Offset: 0x00016428
		public unsafe MonoMethodMessage call_message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_call_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoMethodMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_call_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06004050 RID: 16464 RVA: 0x0012D180 File Offset: 0x0012B380
		// (set) Token: 0x06004051 RID: 16465 RVA: 0x00018247 File Offset: 0x00016447
		public unsafe IMessageCtrl message_ctrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_message_ctrl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_message_ctrl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06004052 RID: 16466 RVA: 0x0012D1B0 File Offset: 0x0012B3B0
		// (set) Token: 0x06004053 RID: 16467 RVA: 0x00018266 File Offset: 0x00016466
		public unsafe IMessage reply_message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_reply_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_reply_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06004054 RID: 16468 RVA: 0x0012D1E0 File Offset: 0x0012B3E0
		// (set) Token: 0x06004055 RID: 16469 RVA: 0x00018285 File Offset: 0x00016485
		public unsafe WaitCallback orig_cb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_orig_cb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_orig_cb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06004056 RID: 16470 RVA: 0x0012D210 File Offset: 0x0012B410
		// (set) Token: 0x06004057 RID: 16471 RVA: 0x000182A4 File Offset: 0x000164A4
		public unsafe static ContextCallback ccb
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncResult.NativeFieldInfoPtr_ccb, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncResult.NativeFieldInfoPtr_ccb, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034A4 RID: 13476
		private static readonly IntPtr NativeFieldInfoPtr_async_state;

		// Token: 0x040034A5 RID: 13477
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x040034A6 RID: 13478
		private static readonly IntPtr NativeFieldInfoPtr_async_delegate;

		// Token: 0x040034A7 RID: 13479
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040034A8 RID: 13480
		private static readonly IntPtr NativeFieldInfoPtr_object_data;

		// Token: 0x040034A9 RID: 13481
		private static readonly IntPtr NativeFieldInfoPtr_sync_completed;

		// Token: 0x040034AA RID: 13482
		private static readonly IntPtr NativeFieldInfoPtr_completed;

		// Token: 0x040034AB RID: 13483
		private static readonly IntPtr NativeFieldInfoPtr_endinvoke_called;

		// Token: 0x040034AC RID: 13484
		private static readonly IntPtr NativeFieldInfoPtr_async_callback;

		// Token: 0x040034AD RID: 13485
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x040034AE RID: 13486
		private static readonly IntPtr NativeFieldInfoPtr_original;

		// Token: 0x040034AF RID: 13487
		private static readonly IntPtr NativeFieldInfoPtr_add_time;

		// Token: 0x040034B0 RID: 13488
		private static readonly IntPtr NativeFieldInfoPtr_call_message;

		// Token: 0x040034B1 RID: 13489
		private static readonly IntPtr NativeFieldInfoPtr_message_ctrl;

		// Token: 0x040034B2 RID: 13490
		private static readonly IntPtr NativeFieldInfoPtr_reply_message;

		// Token: 0x040034B3 RID: 13491
		private static readonly IntPtr NativeFieldInfoPtr_orig_cb;

		// Token: 0x040034B4 RID: 13492
		private static readonly IntPtr NativeFieldInfoPtr_ccb;

		// Token: 0x040034B5 RID: 13493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040034B6 RID: 13494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_WaitCallback_Object_Boolean_0;

		// Token: 0x040034B7 RID: 13495
		private static readonly IntPtr NativeMethodInfoPtr_WaitCallback_Context_Private_Static_Void_Object_0;

		// Token: 0x040034B8 RID: 13496
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_New_get_Object_0;

		// Token: 0x040034B9 RID: 13497
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_New_get_WaitHandle_0;

		// Token: 0x040034BA RID: 13498
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040034BB RID: 13499
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040034BC RID: 13500
		private static readonly IntPtr NativeMethodInfoPtr_get_EndInvokeCalled_Public_get_Boolean_0;

		// Token: 0x040034BD RID: 13501
		private static readonly IntPtr NativeMethodInfoPtr_set_EndInvokeCalled_Public_set_Void_Boolean_0;

		// Token: 0x040034BE RID: 13502
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncDelegate_Public_Virtual_New_get_Object_0;

		// Token: 0x040034BF RID: 13503
		private static readonly IntPtr NativeMethodInfoPtr_get_NextSink_Public_Virtual_Final_New_get_IMessageSink_0;

		// Token: 0x040034C0 RID: 13504
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x040034C1 RID: 13505
		private static readonly IntPtr NativeMethodInfoPtr_GetReplyMessage_Public_Virtual_New_IMessage_0;

		// Token: 0x040034C2 RID: 13506
		private static readonly IntPtr NativeMethodInfoPtr_SetMessageCtrl_Public_Virtual_New_Void_IMessageCtrl_0;

		// Token: 0x040034C3 RID: 13507
		private static readonly IntPtr NativeMethodInfoPtr_SetCompletedSynchronously_Internal_Void_Boolean_0;

		// Token: 0x040034C4 RID: 13508
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Internal_IMessage_0;

		// Token: 0x040034C5 RID: 13509
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0;

		// Token: 0x040034C6 RID: 13510
		private static readonly IntPtr NativeMethodInfoPtr_get_CallMessage_Internal_get_MonoMethodMessage_0;

		// Token: 0x040034C7 RID: 13511
		private static readonly IntPtr NativeMethodInfoPtr_set_CallMessage_Internal_set_Void_MonoMethodMessage_0;

		// Token: 0x040034C8 RID: 13512
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

		// Token: 0x040034C9 RID: 13513
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0;

		// Token: 0x040034CA RID: 13514
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Internal_Object_0;

		// Token: 0x040034CB RID: 13515
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__17_0_Private_Void_Object_0;
	}
}
