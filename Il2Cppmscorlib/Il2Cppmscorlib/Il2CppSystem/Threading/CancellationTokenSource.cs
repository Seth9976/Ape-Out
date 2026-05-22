using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200025C RID: 604
	public class CancellationTokenSource : Object
	{
		// Token: 0x06002A20 RID: 10784 RVA: 0x000DD168 File Offset: 0x000DB368
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationTokenSource()
		{
			Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "CancellationTokenSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr);
			CancellationTokenSource.NativeFieldInfoPtr__staticSource_Set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "_staticSource_Set");
			CancellationTokenSource.NativeFieldInfoPtr__staticSource_NotCancelable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "_staticSource_NotCancelable");
			CancellationTokenSource.NativeFieldInfoPtr_s_nLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "s_nLists");
			CancellationTokenSource.NativeFieldInfoPtr_m_kernelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "m_kernelEvent");
			CancellationTokenSource.NativeFieldInfoPtr_m_registeredCallbacksLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "m_registeredCallbacksLists");
			CancellationTokenSource.NativeFieldInfoPtr_CANNOT_BE_CANCELED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "CANNOT_BE_CANCELED");
			CancellationTokenSource.NativeFieldInfoPtr_NOT_CANCELED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "NOT_CANCELED");
			CancellationTokenSource.NativeFieldInfoPtr_NOTIFYING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "NOTIFYING");
			CancellationTokenSource.NativeFieldInfoPtr_NOTIFYINGCOMPLETE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "NOTIFYINGCOMPLETE");
			CancellationTokenSource.NativeFieldInfoPtr_m_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "m_state");
			CancellationTokenSource.NativeFieldInfoPtr_m_threadIDExecutingCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "m_threadIDExecutingCallbacks");
			CancellationTokenSource.NativeFieldInfoPtr_m_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "m_disposed");
			CancellationTokenSource.NativeFieldInfoPtr_m_linkingRegistrations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "m_linkingRegistrations");
			CancellationTokenSource.NativeFieldInfoPtr_s_LinkedTokenCancelDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "s_LinkedTokenCancelDelegate");
			CancellationTokenSource.NativeFieldInfoPtr_m_executingCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "m_executingCallback");
			CancellationTokenSource.NativeFieldInfoPtr_m_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "m_timer");
			CancellationTokenSource.NativeFieldInfoPtr_s_timerCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "s_timerCallback");
			CancellationTokenSource.NativeMethodInfoPtr_LinkedTokenCancelDelegate_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670108);
			CancellationTokenSource.NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670109);
			CancellationTokenSource.NativeMethodInfoPtr_get_IsCancellationCompleted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670110);
			CancellationTokenSource.NativeMethodInfoPtr_get_IsDisposed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670111);
			CancellationTokenSource.NativeMethodInfoPtr_set_ThreadIDExecutingCallbacks_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670112);
			CancellationTokenSource.NativeMethodInfoPtr_get_ThreadIDExecutingCallbacks_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670113);
			CancellationTokenSource.NativeMethodInfoPtr_get_Token_Public_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670114);
			CancellationTokenSource.NativeMethodInfoPtr_get_CanBeCanceled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670115);
			CancellationTokenSource.NativeMethodInfoPtr_get_ExecutingCallback_Internal_get_CancellationCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670116);
			CancellationTokenSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670117);
			CancellationTokenSource.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670118);
			CancellationTokenSource.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670119);
			CancellationTokenSource.NativeMethodInfoPtr_Cancel_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670120);
			CancellationTokenSource.NativeMethodInfoPtr_CancelAfter_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670121);
			CancellationTokenSource.NativeMethodInfoPtr_TimerCallbackLogic_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670122);
			CancellationTokenSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670123);
			CancellationTokenSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670124);
			CancellationTokenSource.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670125);
			CancellationTokenSource.NativeMethodInfoPtr_ThrowObjectDisposedException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670126);
			CancellationTokenSource.NativeMethodInfoPtr_InternalGetStaticSource_Internal_Static_CancellationTokenSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670127);
			CancellationTokenSource.NativeMethodInfoPtr_InternalRegister_Internal_CancellationTokenRegistration_Action_1_Object_Object_SynchronizationContext_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670128);
			CancellationTokenSource.NativeMethodInfoPtr_NotifyCancellation_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670129);
			CancellationTokenSource.NativeMethodInfoPtr_ExecuteCallbackHandlers_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670130);
			CancellationTokenSource.NativeMethodInfoPtr_CancellationCallbackCoreWork_OnSyncContext_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670131);
			CancellationTokenSource.NativeMethodInfoPtr_CancellationCallbackCoreWork_Private_Void_CancellationCallbackCoreWorkArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670132);
			CancellationTokenSource.NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_CancellationToken_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670133);
			CancellationTokenSource.NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_Il2CppReferenceArray_1_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670134);
			CancellationTokenSource.NativeMethodInfoPtr_WaitForCallbackToComplete_Internal_Void_CancellationCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100670135);
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x000DD51C File Offset: 0x000DB71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200240, XrefRangeEnd = 200248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LinkedTokenCancelDelegate(Object source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_LinkedTokenCancelDelegate_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06002A22 RID: 10786 RVA: 0x000DD554 File Offset: 0x000DB754
		public unsafe bool IsCancellationRequested
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06002A23 RID: 10787 RVA: 0x000DD590 File Offset: 0x000DB790
		public unsafe bool IsCancellationCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_IsCancellationCompleted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x000DD5CC File Offset: 0x000DB7CC
		public unsafe bool IsDisposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_IsDisposed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06002A26 RID: 10790 RVA: 0x000DD648 File Offset: 0x000DB848
		// (set) Token: 0x06002A25 RID: 10789 RVA: 0x000DD608 File Offset: 0x000DB808
		public unsafe int ThreadIDExecutingCallbacks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_ThreadIDExecutingCallbacks_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_set_ThreadIDExecutingCallbacks_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06002A27 RID: 10791 RVA: 0x000DD684 File Offset: 0x000DB884
		public unsafe CancellationToken Token
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 200249, RefRangeEnd = 200256, XrefRangeStart = 200248, XrefRangeEnd = 200249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_Token_Public_get_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationToken(intPtr);
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x000DD6BC File Offset: 0x000DB8BC
		public unsafe bool CanBeCanceled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_CanBeCanceled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06002A29 RID: 10793 RVA: 0x000DD6F8 File Offset: 0x000DB8F8
		public unsafe CancellationCallbackInfo ExecutingCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_ExecutingCallback_Internal_get_CancellationCallbackInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CancellationCallbackInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x000DD738 File Offset: 0x000DB938
		[CallerCount(0)]
		public unsafe CancellationTokenSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x000DD774 File Offset: 0x000DB974
		[CallerCount(0)]
		public unsafe CancellationTokenSource(bool set)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref set;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x000DD7BC File Offset: 0x000DB9BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 200261, RefRangeEnd = 200265, XrefRangeStart = 200256, XrefRangeEnd = 200261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x000DD7F0 File Offset: 0x000DB9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200265, XrefRangeEnd = 200270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel(bool throwOnFirstException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwOnFirstException;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_Cancel_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x000DD830 File Offset: 0x000DBA30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200282, RefRangeEnd = 200283, XrefRangeStart = 200270, XrefRangeEnd = 200282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAfter(int millisecondsDelay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsDelay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CancelAfter_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x000DD870 File Offset: 0x000DBA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200283, XrefRangeEnd = 200288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TimerCallbackLogic(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_TimerCallbackLogic_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x000DD8A8 File Offset: 0x000DBAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200288, XrefRangeEnd = 200292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x000DD8DC File Offset: 0x000DBADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200292, XrefRangeEnd = 200296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CancellationTokenSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x000DD928 File Offset: 0x000DBB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200296, XrefRangeEnd = 200297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x000DD95C File Offset: 0x000DBB5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 200304, RefRangeEnd = 200307, XrefRangeStart = 200297, XrefRangeEnd = 200304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowObjectDisposedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_ThrowObjectDisposedException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x000DD984 File Offset: 0x000DBB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200307, XrefRangeEnd = 200311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CancellationTokenSource InternalGetStaticSource(bool set)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref set;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_InternalGetStaticSource_Internal_Static_CancellationTokenSource_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr3) : null;
			}
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x000DD9C4 File Offset: 0x000DBBC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200347, RefRangeEnd = 200348, XrefRangeStart = 200311, XrefRangeEnd = 200347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenRegistration InternalRegister(Action<Object> callback, Object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateForCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetSyncContext);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_InternalRegister_Internal_CancellationTokenRegistration_Action_1_Object_Object_SynchronizationContext_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CancellationTokenRegistration(intPtr);
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x000DDA44 File Offset: 0x000DBC44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 200354, RefRangeEnd = 200358, XrefRangeStart = 200348, XrefRangeEnd = 200354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyCancellation(bool throwOnFirstException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwOnFirstException;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_NotifyCancellation_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x000DDA84 File Offset: 0x000DBC84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200389, RefRangeEnd = 200390, XrefRangeStart = 200358, XrefRangeEnd = 200389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteCallbackHandlers(bool throwOnFirstException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwOnFirstException;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_ExecuteCallbackHandlers_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x000DDAC4 File Offset: 0x000DBCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200390, XrefRangeEnd = 200393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancellationCallbackCoreWork_OnSyncContext(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CancellationCallbackCoreWork_OnSyncContext_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x000DDB08 File Offset: 0x000DBD08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200398, RefRangeEnd = 200400, XrefRangeStart = 200393, XrefRangeEnd = 200398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CancellationCallbackCoreWork_Private_Void_CancellationCallbackCoreWorkArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x000DDB50 File Offset: 0x000DBD50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200418, RefRangeEnd = 200419, XrefRangeStart = 200400, XrefRangeEnd = 200418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token2));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_CancellationToken_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr3) : null;
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x000DDBB0 File Offset: 0x000DBDB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200432, RefRangeEnd = 200433, XrefRangeStart = 200419, XrefRangeEnd = 200432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CancellationTokenSource CreateLinkedTokenSource([Optional] Il2CppReferenceArray<CancellationToken> tokens)
		{
			if (tokens == null)
			{
				tokens = new Il2CppStructArray<CancellationToken>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_Il2CppReferenceArray_1_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr3) : null;
			}
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x000DDC04 File Offset: 0x000DBE04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200461, RefRangeEnd = 200463, XrefRangeStart = 200433, XrefRangeEnd = 200461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callbackInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_WaitForCallbackToComplete_Internal_Void_CancellationCallbackInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x0000E7EB File Offset: 0x0000C9EB
		public static CancellationTokenSource CreateLinkedTokenSource(params CancellationToken[] tokens)
		{
			return CancellationTokenSource.CreateLinkedTokenSource(new Il2CppReferenceArray<CancellationToken>(tokens));
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x0000E7F8 File Offset: 0x0000C9F8
		public CancellationTokenSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06002A3F RID: 10815 RVA: 0x000DDC48 File Offset: 0x000DBE48
		// (set) Token: 0x06002A40 RID: 10816 RVA: 0x0000E801 File Offset: 0x0000CA01
		public unsafe static CancellationTokenSource _staticSource_Set
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr__staticSource_Set, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr__staticSource_Set, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06002A41 RID: 10817 RVA: 0x000DDC70 File Offset: 0x000DBE70
		// (set) Token: 0x06002A42 RID: 10818 RVA: 0x0000E813 File Offset: 0x0000CA13
		public unsafe static CancellationTokenSource _staticSource_NotCancelable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr__staticSource_NotCancelable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr__staticSource_NotCancelable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06002A43 RID: 10819 RVA: 0x000DDC98 File Offset: 0x000DBE98
		// (set) Token: 0x06002A44 RID: 10820 RVA: 0x0000E825 File Offset: 0x0000CA25
		public unsafe static int s_nLists
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_s_nLists, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_s_nLists, (void*)(&value));
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06002A45 RID: 10821 RVA: 0x000DDCB4 File Offset: 0x000DBEB4
		// (set) Token: 0x06002A46 RID: 10822 RVA: 0x0000E833 File Offset: 0x0000CA33
		public unsafe ManualResetEvent m_kernelEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_kernelEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_kernelEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06002A47 RID: 10823 RVA: 0x000DDCE4 File Offset: 0x000DBEE4
		// (set) Token: 0x06002A48 RID: 10824 RVA: 0x0000E852 File Offset: 0x0000CA52
		public unsafe Il2CppReferenceArray<SparselyPopulatedArray<CancellationCallbackInfo>> m_registeredCallbacksLists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_registeredCallbacksLists);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SparselyPopulatedArray<CancellationCallbackInfo>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_registeredCallbacksLists), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x000DDD14 File Offset: 0x000DBF14
		// (set) Token: 0x06002A4A RID: 10826 RVA: 0x0000E871 File Offset: 0x0000CA71
		public unsafe static int CANNOT_BE_CANCELED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_CANNOT_BE_CANCELED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_CANNOT_BE_CANCELED, (void*)(&value));
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06002A4B RID: 10827 RVA: 0x000DDD30 File Offset: 0x000DBF30
		// (set) Token: 0x06002A4C RID: 10828 RVA: 0x0000E87F File Offset: 0x0000CA7F
		public unsafe static int NOT_CANCELED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_NOT_CANCELED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_NOT_CANCELED, (void*)(&value));
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x000DDD4C File Offset: 0x000DBF4C
		// (set) Token: 0x06002A4E RID: 10830 RVA: 0x0000E88D File Offset: 0x0000CA8D
		public unsafe static int NOTIFYING
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_NOTIFYING, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_NOTIFYING, (void*)(&value));
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06002A4F RID: 10831 RVA: 0x000DDD68 File Offset: 0x000DBF68
		// (set) Token: 0x06002A50 RID: 10832 RVA: 0x0000E89B File Offset: 0x0000CA9B
		public unsafe static int NOTIFYINGCOMPLETE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_NOTIFYINGCOMPLETE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_NOTIFYINGCOMPLETE, (void*)(&value));
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x000DDD84 File Offset: 0x000DBF84
		// (set) Token: 0x06002A52 RID: 10834 RVA: 0x0000E8A9 File Offset: 0x0000CAA9
		public unsafe int m_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_state)) = value;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x000DDDAC File Offset: 0x000DBFAC
		// (set) Token: 0x06002A54 RID: 10836 RVA: 0x0000E8C4 File Offset: 0x0000CAC4
		public unsafe int m_threadIDExecutingCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_threadIDExecutingCallbacks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_threadIDExecutingCallbacks)) = value;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06002A55 RID: 10837 RVA: 0x000DDDD4 File Offset: 0x000DBFD4
		// (set) Token: 0x06002A56 RID: 10838 RVA: 0x0000E8DF File Offset: 0x0000CADF
		public unsafe bool m_disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_disposed)) = value;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06002A57 RID: 10839 RVA: 0x000DDDFC File Offset: 0x000DBFFC
		// (set) Token: 0x06002A58 RID: 10840 RVA: 0x0000E8FA File Offset: 0x0000CAFA
		public unsafe Il2CppReferenceArray<CancellationTokenRegistration> m_linkingRegistrations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_linkingRegistrations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CancellationTokenRegistration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_linkingRegistrations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06002A59 RID: 10841 RVA: 0x000DDE2C File Offset: 0x000DC02C
		// (set) Token: 0x06002A5A RID: 10842 RVA: 0x0000E919 File Offset: 0x0000CB19
		public unsafe static Action<Object> s_LinkedTokenCancelDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_s_LinkedTokenCancelDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_s_LinkedTokenCancelDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06002A5B RID: 10843 RVA: 0x000DDE54 File Offset: 0x000DC054
		// (set) Token: 0x06002A5C RID: 10844 RVA: 0x0000E92B File Offset: 0x0000CB2B
		public unsafe CancellationCallbackInfo m_executingCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_executingCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationCallbackInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_executingCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06002A5D RID: 10845 RVA: 0x000DDE84 File Offset: 0x000DC084
		// (set) Token: 0x06002A5E RID: 10846 RVA: 0x0000E94A File Offset: 0x0000CB4A
		public unsafe Timer m_timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_timer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_timer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06002A5F RID: 10847 RVA: 0x000DDEB4 File Offset: 0x000DC0B4
		// (set) Token: 0x06002A60 RID: 10848 RVA: 0x0000E969 File Offset: 0x0000CB69
		public unsafe static TimerCallback s_timerCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_s_timerCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_s_timerCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002525 RID: 9509
		private static readonly IntPtr NativeFieldInfoPtr__staticSource_Set;

		// Token: 0x04002526 RID: 9510
		private static readonly IntPtr NativeFieldInfoPtr__staticSource_NotCancelable;

		// Token: 0x04002527 RID: 9511
		private static readonly IntPtr NativeFieldInfoPtr_s_nLists;

		// Token: 0x04002528 RID: 9512
		private static readonly IntPtr NativeFieldInfoPtr_m_kernelEvent;

		// Token: 0x04002529 RID: 9513
		private static readonly IntPtr NativeFieldInfoPtr_m_registeredCallbacksLists;

		// Token: 0x0400252A RID: 9514
		private static readonly IntPtr NativeFieldInfoPtr_CANNOT_BE_CANCELED;

		// Token: 0x0400252B RID: 9515
		private static readonly IntPtr NativeFieldInfoPtr_NOT_CANCELED;

		// Token: 0x0400252C RID: 9516
		private static readonly IntPtr NativeFieldInfoPtr_NOTIFYING;

		// Token: 0x0400252D RID: 9517
		private static readonly IntPtr NativeFieldInfoPtr_NOTIFYINGCOMPLETE;

		// Token: 0x0400252E RID: 9518
		private static readonly IntPtr NativeFieldInfoPtr_m_state;

		// Token: 0x0400252F RID: 9519
		private static readonly IntPtr NativeFieldInfoPtr_m_threadIDExecutingCallbacks;

		// Token: 0x04002530 RID: 9520
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x04002531 RID: 9521
		private static readonly IntPtr NativeFieldInfoPtr_m_linkingRegistrations;

		// Token: 0x04002532 RID: 9522
		private static readonly IntPtr NativeFieldInfoPtr_s_LinkedTokenCancelDelegate;

		// Token: 0x04002533 RID: 9523
		private static readonly IntPtr NativeFieldInfoPtr_m_executingCallback;

		// Token: 0x04002534 RID: 9524
		private static readonly IntPtr NativeFieldInfoPtr_m_timer;

		// Token: 0x04002535 RID: 9525
		private static readonly IntPtr NativeFieldInfoPtr_s_timerCallback;

		// Token: 0x04002536 RID: 9526
		private static readonly IntPtr NativeMethodInfoPtr_LinkedTokenCancelDelegate_Private_Static_Void_Object_0;

		// Token: 0x04002537 RID: 9527
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0;

		// Token: 0x04002538 RID: 9528
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCancellationCompleted_Internal_get_Boolean_0;

		// Token: 0x04002539 RID: 9529
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDisposed_Internal_get_Boolean_0;

		// Token: 0x0400253A RID: 9530
		private static readonly IntPtr NativeMethodInfoPtr_set_ThreadIDExecutingCallbacks_Internal_set_Void_Int32_0;

		// Token: 0x0400253B RID: 9531
		private static readonly IntPtr NativeMethodInfoPtr_get_ThreadIDExecutingCallbacks_Internal_get_Int32_0;

		// Token: 0x0400253C RID: 9532
		private static readonly IntPtr NativeMethodInfoPtr_get_Token_Public_get_CancellationToken_0;

		// Token: 0x0400253D RID: 9533
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeCanceled_Internal_get_Boolean_0;

		// Token: 0x0400253E RID: 9534
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutingCallback_Internal_get_CancellationCallbackInfo_0;

		// Token: 0x0400253F RID: 9535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002540 RID: 9536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x04002541 RID: 9537
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x04002542 RID: 9538
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_Boolean_0;

		// Token: 0x04002543 RID: 9539
		private static readonly IntPtr NativeMethodInfoPtr_CancelAfter_Public_Void_Int32_0;

		// Token: 0x04002544 RID: 9540
		private static readonly IntPtr NativeMethodInfoPtr_TimerCallbackLogic_Private_Static_Void_Object_0;

		// Token: 0x04002545 RID: 9541
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002546 RID: 9542
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002547 RID: 9543
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0;

		// Token: 0x04002548 RID: 9544
		private static readonly IntPtr NativeMethodInfoPtr_ThrowObjectDisposedException_Private_Static_Void_0;

		// Token: 0x04002549 RID: 9545
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetStaticSource_Internal_Static_CancellationTokenSource_Boolean_0;

		// Token: 0x0400254A RID: 9546
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegister_Internal_CancellationTokenRegistration_Action_1_Object_Object_SynchronizationContext_ExecutionContext_0;

		// Token: 0x0400254B RID: 9547
		private static readonly IntPtr NativeMethodInfoPtr_NotifyCancellation_Private_Void_Boolean_0;

		// Token: 0x0400254C RID: 9548
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCallbackHandlers_Private_Void_Boolean_0;

		// Token: 0x0400254D RID: 9549
		private static readonly IntPtr NativeMethodInfoPtr_CancellationCallbackCoreWork_OnSyncContext_Private_Void_Object_0;

		// Token: 0x0400254E RID: 9550
		private static readonly IntPtr NativeMethodInfoPtr_CancellationCallbackCoreWork_Private_Void_CancellationCallbackCoreWorkArguments_0;

		// Token: 0x0400254F RID: 9551
		private static readonly IntPtr NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_CancellationToken_CancellationToken_0;

		// Token: 0x04002550 RID: 9552
		private static readonly IntPtr NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_Il2CppReferenceArray_1_CancellationToken_0;

		// Token: 0x04002551 RID: 9553
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCallbackToComplete_Internal_Void_CancellationCallbackInfo_0;
	}
}
