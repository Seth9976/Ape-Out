using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x02000107 RID: 263
	public class LazyAsyncResult : Object
	{
		// Token: 0x06000E58 RID: 3672 RVA: 0x00046A84 File Offset: 0x00044C84
		// Note: this type is marked as 'beforefieldinit'.
		static LazyAsyncResult()
		{
			Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "LazyAsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr);
			LazyAsyncResult.NativeFieldInfoPtr_t_ThreadContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "t_ThreadContext");
			LazyAsyncResult.NativeFieldInfoPtr_m_AsyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_AsyncObject");
			LazyAsyncResult.NativeFieldInfoPtr_m_AsyncState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_AsyncState");
			LazyAsyncResult.NativeFieldInfoPtr_m_AsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_AsyncCallback");
			LazyAsyncResult.NativeFieldInfoPtr_m_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_Result");
			LazyAsyncResult.NativeFieldInfoPtr_m_IntCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_IntCompleted");
			LazyAsyncResult.NativeFieldInfoPtr_m_UserEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_UserEvent");
			LazyAsyncResult.NativeFieldInfoPtr_m_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_Event");
			LazyAsyncResult.NativeMethodInfoPtr_get_CurrentThreadContext_Private_Static_get_ThreadContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665363);
			LazyAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Object_Object_AsyncCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665364);
			LazyAsyncResult.NativeMethodInfoPtr_get_AsyncObject_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665365);
			LazyAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665366);
			LazyAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665367);
			LazyAsyncResult.NativeMethodInfoPtr_LazilyCreateEvent_Private_Boolean_byref_ManualResetEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665368);
			LazyAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665369);
			LazyAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665370);
			LazyAsyncResult.NativeMethodInfoPtr_get_InternalPeekCompleted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665371);
			LazyAsyncResult.NativeMethodInfoPtr_ProtectedInvokeCallback_Protected_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665372);
			LazyAsyncResult.NativeMethodInfoPtr_InvokeCallback_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665373);
			LazyAsyncResult.NativeMethodInfoPtr_Complete_Protected_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665374);
			LazyAsyncResult.NativeMethodInfoPtr_WorkerThreadComplete_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665375);
			LazyAsyncResult.NativeMethodInfoPtr_Cleanup_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665376);
			LazyAsyncResult.NativeMethodInfoPtr_InternalWaitForCompletion_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665377);
			LazyAsyncResult.NativeMethodInfoPtr_WaitForCompletion_Private_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665378);
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00046C94 File Offset: 0x00044E94
		public unsafe static LazyAsyncResult.ThreadContext CurrentThreadContext
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378086, XrefRangeEnd = 378094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_CurrentThreadContext_Private_Static_get_ThreadContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LazyAsyncResult.ThreadContext>(intPtr3) : null;
			}
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00046CC8 File Offset: 0x00044EC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378098, RefRangeEnd = 378099, XrefRangeStart = 378094, XrefRangeEnd = 378098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LazyAsyncResult(Object myObject, Object myState, AsyncCallback myCallBack)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(myObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(myState);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(myCallBack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Object_Object_AsyncCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x00046D38 File Offset: 0x00044F38
		public unsafe Object AsyncObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_AsyncObject_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x00046D78 File Offset: 0x00044F78
		public unsafe virtual Object AsyncState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x00046DB8 File Offset: 0x00044FB8
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378099, XrefRangeEnd = 378102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00046DF8 File Offset: 0x00044FF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 378111, RefRangeEnd = 378113, XrefRangeStart = 378102, XrefRangeEnd = 378111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LazilyCreateEvent(out ManualResetEvent waitHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_LazilyCreateEvent_Private_Boolean_byref_ManualResetEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				waitHandle = ((intPtr4 == 0) ? null : new ManualResetEvent(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x00046E58 File Offset: 0x00045058
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x00046E94 File Offset: 0x00045094
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x00046ED0 File Offset: 0x000450D0
		public unsafe bool InternalPeekCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_InternalPeekCompleted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00046F0C File Offset: 0x0004510C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 378125, RefRangeEnd = 378128, XrefRangeStart = 378113, XrefRangeEnd = 378125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProtectedInvokeCallback(Object result, IntPtr userToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userToken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_ProtectedInvokeCallback_Protected_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00046F5C File Offset: 0x0004515C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 378130, RefRangeEnd = 378132, XrefRangeStart = 378128, XrefRangeEnd = 378130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCallback(Object result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_InvokeCallback_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00046FA0 File Offset: 0x000451A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378132, XrefRangeEnd = 378151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Complete(IntPtr userToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userToken;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LazyAsyncResult.NativeMethodInfoPtr_Complete_Protected_Virtual_New_Void_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00046FEC File Offset: 0x000451EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378151, XrefRangeEnd = 378153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WorkerThreadComplete(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_WorkerThreadComplete_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00047030 File Offset: 0x00045230
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LazyAsyncResult.NativeMethodInfoPtr_Cleanup_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0004706C File Offset: 0x0004526C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378153, XrefRangeEnd = 378154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InternalWaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_InternalWaitForCompletion_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x000470AC File Offset: 0x000452AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 378166, RefRangeEnd = 378168, XrefRangeStart = 378154, XrefRangeEnd = 378166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object WaitForCompletion(bool snap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_WaitForCompletion_Private_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x000079A0 File Offset: 0x00005BA0
		public LazyAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x000470F8 File Offset: 0x000452F8
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x000079A9 File Offset: 0x00005BA9
		public unsafe static LazyAsyncResult.ThreadContext t_ThreadContext
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LazyAsyncResult.NativeFieldInfoPtr_t_ThreadContext, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LazyAsyncResult.ThreadContext>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LazyAsyncResult.NativeFieldInfoPtr_t_ThreadContext, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00047120 File Offset: 0x00045320
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x000079BB File Offset: 0x00005BBB
		public unsafe Object m_AsyncObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x00047150 File Offset: 0x00045350
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x000079DA File Offset: 0x00005BDA
		public unsafe Object m_AsyncState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x00047180 File Offset: 0x00045380
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x000079F9 File Offset: 0x00005BF9
		public unsafe AsyncCallback m_AsyncCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x000471B0 File Offset: 0x000453B0
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x00007A18 File Offset: 0x00005C18
		public unsafe Object m_Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_Result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_Result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x000471E0 File Offset: 0x000453E0
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x00007A37 File Offset: 0x00005C37
		public unsafe int m_IntCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_IntCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_IntCompleted)) = value;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x00047208 File Offset: 0x00045408
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x00007A52 File Offset: 0x00005C52
		public unsafe bool m_UserEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_UserEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_UserEvent)) = value;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x00047230 File Offset: 0x00045430
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x00007A6D File Offset: 0x00005C6D
		public unsafe Object m_Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_Event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeFieldInfoPtr_t_ThreadContext;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncObject;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncState;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncCallback;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeFieldInfoPtr_m_Result;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeFieldInfoPtr_m_IntCompleted;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeFieldInfoPtr_m_UserEvent;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeFieldInfoPtr_m_Event;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentThreadContext_Private_Static_get_ThreadContext_0;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_Object_AsyncCallback_0;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncObject_Internal_get_Object_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_LazilyCreateEvent_Private_Boolean_byref_ManualResetEvent_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalPeekCompleted_Internal_get_Boolean_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr_ProtectedInvokeCallback_Protected_Void_Object_IntPtr_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCallback_Internal_Void_Object_0;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Protected_Virtual_New_Void_IntPtr_0;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr_WorkerThreadComplete_Private_Void_Object_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Protected_Virtual_New_Void_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_InternalWaitForCompletion_Internal_Object_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Private_Object_Boolean_0;

		// Token: 0x020001D3 RID: 467
		public class ThreadContext : Object
		{
			// Token: 0x060019ED RID: 6637 RVA: 0x0006F094 File Offset: 0x0006D294
			// Note: this type is marked as 'beforefieldinit'.
			static ThreadContext()
			{
				Il2CppClassPointerStore<LazyAsyncResult.ThreadContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "ThreadContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LazyAsyncResult.ThreadContext>.NativeClassPtr);
				LazyAsyncResult.ThreadContext.NativeFieldInfoPtr_m_NestedIOCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult.ThreadContext>.NativeClassPtr, "m_NestedIOCount");
				LazyAsyncResult.ThreadContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult.ThreadContext>.NativeClassPtr, 100665379);
			}

			// Token: 0x060019EE RID: 6638 RVA: 0x0006F0E8 File Offset: 0x0006D2E8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ThreadContext()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LazyAsyncResult.ThreadContext>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.ThreadContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019EF RID: 6639 RVA: 0x0000D4E5 File Offset: 0x0000B6E5
			public ThreadContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000845 RID: 2117
			// (get) Token: 0x060019F0 RID: 6640 RVA: 0x0006F124 File Offset: 0x0006D324
			// (set) Token: 0x060019F1 RID: 6641 RVA: 0x0000D4EE File Offset: 0x0000B6EE
			public unsafe int m_NestedIOCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.ThreadContext.NativeFieldInfoPtr_m_NestedIOCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.ThreadContext.NativeFieldInfoPtr_m_NestedIOCount)) = value;
				}
			}

			// Token: 0x0400146F RID: 5231
			private static readonly IntPtr NativeFieldInfoPtr_m_NestedIOCount;

			// Token: 0x04001470 RID: 5232
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
