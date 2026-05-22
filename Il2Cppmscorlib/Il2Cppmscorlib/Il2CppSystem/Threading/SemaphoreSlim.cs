using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000264 RID: 612
	public class SemaphoreSlim : Object
	{
		// Token: 0x06002AD5 RID: 10965 RVA: 0x000DF6F4 File Offset: 0x000DD8F4
		// Note: this type is marked as 'beforefieldinit'.
		static SemaphoreSlim()
		{
			Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SemaphoreSlim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr);
			SemaphoreSlim.NativeFieldInfoPtr_m_currentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_currentCount");
			SemaphoreSlim.NativeFieldInfoPtr_m_maxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_maxCount");
			SemaphoreSlim.NativeFieldInfoPtr_m_waitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_waitCount");
			SemaphoreSlim.NativeFieldInfoPtr_m_lockObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_lockObj");
			SemaphoreSlim.NativeFieldInfoPtr_m_waitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_waitHandle");
			SemaphoreSlim.NativeFieldInfoPtr_m_asyncHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_asyncHead");
			SemaphoreSlim.NativeFieldInfoPtr_m_asyncTail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_asyncTail");
			SemaphoreSlim.NativeFieldInfoPtr_s_trueTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "s_trueTask");
			SemaphoreSlim.NativeFieldInfoPtr_NO_MAXIMUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "NO_MAXIMUM");
			SemaphoreSlim.NativeFieldInfoPtr_s_cancellationTokenCanceledEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "s_cancellationTokenCanceledEventHandler");
			SemaphoreSlim.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670178);
			SemaphoreSlim.NativeMethodInfoPtr_Wait_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670179);
			SemaphoreSlim.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670180);
			SemaphoreSlim.NativeMethodInfoPtr_WaitUntilCountOrTimeout_Private_Boolean_Int32_UInt32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670181);
			SemaphoreSlim.NativeMethodInfoPtr_WaitAsync_Public_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670182);
			SemaphoreSlim.NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670183);
			SemaphoreSlim.NativeMethodInfoPtr_CreateAndAddAsyncWaiter_Private_TaskNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670184);
			SemaphoreSlim.NativeMethodInfoPtr_RemoveAsyncWaiter_Private_Boolean_TaskNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670185);
			SemaphoreSlim.NativeMethodInfoPtr_WaitUntilCountOrTimeoutAsync_Private_Task_1_Boolean_TaskNode_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670186);
			SemaphoreSlim.NativeMethodInfoPtr_Release_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670187);
			SemaphoreSlim.NativeMethodInfoPtr_Release_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670188);
			SemaphoreSlim.NativeMethodInfoPtr_QueueWaiterTask_Private_Static_Void_TaskNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670189);
			SemaphoreSlim.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670190);
			SemaphoreSlim.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670191);
			SemaphoreSlim.NativeMethodInfoPtr_CancellationTokenCanceledEventHandler_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670192);
			SemaphoreSlim.NativeMethodInfoPtr_CheckDispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670193);
			SemaphoreSlim.NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670194);
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x000DF940 File Offset: 0x000DDB40
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 200754, RefRangeEnd = 200759, XrefRangeStart = 200750, XrefRangeEnd = 200754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SemaphoreSlim(int initialCount, int maxCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x000DF998 File Offset: 0x000DDB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200759, XrefRangeEnd = 200760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Wait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_Wait_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x000DF9CC File Offset: 0x000DDBCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 200793, RefRangeEnd = 200796, XrefRangeStart = 200760, XrefRangeEnd = 200793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x000DFA2C File Offset: 0x000DDC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200796, XrefRangeEnd = 200799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_WaitUntilCountOrTimeout_Private_Boolean_Int32_UInt32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x000DFA9C File Offset: 0x000DDC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200799, XrefRangeEnd = 200800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WaitAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_WaitAsync_Public_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x000DFADC File Offset: 0x000DDCDC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 200809, RefRangeEnd = 200816, XrefRangeStart = 200800, XrefRangeEnd = 200809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x000DFB40 File Offset: 0x000DDD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200816, XrefRangeEnd = 200826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_CreateAndAddAsyncWaiter_Private_TaskNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr3) : null;
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000DFB80 File Offset: 0x000DDD80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200827, RefRangeEnd = 200829, XrefRangeStart = 200826, XrefRangeEnd = 200827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_RemoveAsyncWaiter_Private_Boolean_TaskNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x000DFBD0 File Offset: 0x000DDDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200829, XrefRangeEnd = 200839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncWaiter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_WaitUntilCountOrTimeoutAsync_Private_Task_1_Boolean_TaskNode_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x000DFC48 File Offset: 0x000DDE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200839, XrefRangeEnd = 200840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_Release_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000DFC84 File Offset: 0x000DDE84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 200854, RefRangeEnd = 200858, XrefRangeStart = 200840, XrefRangeEnd = 200854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Release(int releaseCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref releaseCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_Release_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x000DFCD0 File Offset: 0x000DDED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200858, XrefRangeEnd = 200859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waiterTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_QueueWaiterTask_Private_Static_Void_TaskNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x000DFD08 File Offset: 0x000DDF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200859, XrefRangeEnd = 200863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x000DFD3C File Offset: 0x000DDF3C
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SemaphoreSlim.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x000DFD88 File Offset: 0x000DDF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200863, XrefRangeEnd = 200869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancellationTokenCanceledEventHandler(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_CancellationTokenCanceledEventHandler_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x000DFDC0 File Offset: 0x000DDFC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 200869, RefRangeEnd = 200872, XrefRangeStart = 200869, XrefRangeEnd = 200869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_CheckDispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x000DFDF4 File Offset: 0x000DDFF4
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceString(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x0000EC9B File Offset: 0x0000CE9B
		public SemaphoreSlim(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06002AE8 RID: 10984 RVA: 0x000DFE30 File Offset: 0x000DE030
		// (set) Token: 0x06002AE9 RID: 10985 RVA: 0x0000ECA4 File Offset: 0x0000CEA4
		public unsafe int m_currentCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_currentCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_currentCount)) = value;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06002AEA RID: 10986 RVA: 0x000DFE58 File Offset: 0x000DE058
		// (set) Token: 0x06002AEB RID: 10987 RVA: 0x0000ECBF File Offset: 0x0000CEBF
		public unsafe int m_maxCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_maxCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_maxCount)) = value;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x000DFE80 File Offset: 0x000DE080
		// (set) Token: 0x06002AED RID: 10989 RVA: 0x0000ECDA File Offset: 0x0000CEDA
		public unsafe int m_waitCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_waitCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_waitCount)) = value;
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06002AEE RID: 10990 RVA: 0x000DFEA8 File Offset: 0x000DE0A8
		// (set) Token: 0x06002AEF RID: 10991 RVA: 0x0000ECF5 File Offset: 0x0000CEF5
		public unsafe Object m_lockObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_lockObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_lockObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x000DFED8 File Offset: 0x000DE0D8
		// (set) Token: 0x06002AF1 RID: 10993 RVA: 0x0000ED14 File Offset: 0x0000CF14
		public unsafe ManualResetEvent m_waitHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_waitHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_waitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06002AF2 RID: 10994 RVA: 0x000DFF08 File Offset: 0x000DE108
		// (set) Token: 0x06002AF3 RID: 10995 RVA: 0x0000ED33 File Offset: 0x0000CF33
		public unsafe SemaphoreSlim.TaskNode m_asyncHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_asyncHead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_asyncHead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x000DFF38 File Offset: 0x000DE138
		// (set) Token: 0x06002AF5 RID: 10997 RVA: 0x0000ED52 File Offset: 0x0000CF52
		public unsafe SemaphoreSlim.TaskNode m_asyncTail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_asyncTail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_asyncTail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002AF6 RID: 10998 RVA: 0x000DFF68 File Offset: 0x000DE168
		// (set) Token: 0x06002AF7 RID: 10999 RVA: 0x0000ED71 File Offset: 0x0000CF71
		public unsafe static Task<bool> s_trueTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SemaphoreSlim.NativeFieldInfoPtr_s_trueTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SemaphoreSlim.NativeFieldInfoPtr_s_trueTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x000DFF90 File Offset: 0x000DE190
		// (set) Token: 0x06002AF9 RID: 11001 RVA: 0x0000ED83 File Offset: 0x0000CF83
		public unsafe static int NO_MAXIMUM
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SemaphoreSlim.NativeFieldInfoPtr_NO_MAXIMUM, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SemaphoreSlim.NativeFieldInfoPtr_NO_MAXIMUM, (void*)(&value));
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06002AFA RID: 11002 RVA: 0x000DFFAC File Offset: 0x000DE1AC
		// (set) Token: 0x06002AFB RID: 11003 RVA: 0x0000ED91 File Offset: 0x0000CF91
		public unsafe static Action<Object> s_cancellationTokenCanceledEventHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SemaphoreSlim.NativeFieldInfoPtr_s_cancellationTokenCanceledEventHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SemaphoreSlim.NativeFieldInfoPtr_s_cancellationTokenCanceledEventHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002598 RID: 9624
		private static readonly IntPtr NativeFieldInfoPtr_m_currentCount;

		// Token: 0x04002599 RID: 9625
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCount;

		// Token: 0x0400259A RID: 9626
		private static readonly IntPtr NativeFieldInfoPtr_m_waitCount;

		// Token: 0x0400259B RID: 9627
		private static readonly IntPtr NativeFieldInfoPtr_m_lockObj;

		// Token: 0x0400259C RID: 9628
		private static readonly IntPtr NativeFieldInfoPtr_m_waitHandle;

		// Token: 0x0400259D RID: 9629
		private static readonly IntPtr NativeFieldInfoPtr_m_asyncHead;

		// Token: 0x0400259E RID: 9630
		private static readonly IntPtr NativeFieldInfoPtr_m_asyncTail;

		// Token: 0x0400259F RID: 9631
		private static readonly IntPtr NativeFieldInfoPtr_s_trueTask;

		// Token: 0x040025A0 RID: 9632
		private static readonly IntPtr NativeFieldInfoPtr_NO_MAXIMUM;

		// Token: 0x040025A1 RID: 9633
		private static readonly IntPtr NativeFieldInfoPtr_s_cancellationTokenCanceledEventHandler;

		// Token: 0x040025A2 RID: 9634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x040025A3 RID: 9635
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Void_0;

		// Token: 0x040025A4 RID: 9636
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0;

		// Token: 0x040025A5 RID: 9637
		private static readonly IntPtr NativeMethodInfoPtr_WaitUntilCountOrTimeout_Private_Boolean_Int32_UInt32_CancellationToken_0;

		// Token: 0x040025A6 RID: 9638
		private static readonly IntPtr NativeMethodInfoPtr_WaitAsync_Public_Task_0;

		// Token: 0x040025A7 RID: 9639
		private static readonly IntPtr NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_CancellationToken_0;

		// Token: 0x040025A8 RID: 9640
		private static readonly IntPtr NativeMethodInfoPtr_CreateAndAddAsyncWaiter_Private_TaskNode_0;

		// Token: 0x040025A9 RID: 9641
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAsyncWaiter_Private_Boolean_TaskNode_0;

		// Token: 0x040025AA RID: 9642
		private static readonly IntPtr NativeMethodInfoPtr_WaitUntilCountOrTimeoutAsync_Private_Task_1_Boolean_TaskNode_Int32_CancellationToken_0;

		// Token: 0x040025AB RID: 9643
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Int32_0;

		// Token: 0x040025AC RID: 9644
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Int32_Int32_0;

		// Token: 0x040025AD RID: 9645
		private static readonly IntPtr NativeMethodInfoPtr_QueueWaiterTask_Private_Static_Void_TaskNode_0;

		// Token: 0x040025AE RID: 9646
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040025AF RID: 9647
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040025B0 RID: 9648
		private static readonly IntPtr NativeMethodInfoPtr_CancellationTokenCanceledEventHandler_Private_Static_Void_Object_0;

		// Token: 0x040025B1 RID: 9649
		private static readonly IntPtr NativeMethodInfoPtr_CheckDispose_Private_Void_0;

		// Token: 0x040025B2 RID: 9650
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0;

		// Token: 0x020005EB RID: 1515
		public sealed class TaskNode : Task<bool>
		{
			// Token: 0x060053F1 RID: 21489 RVA: 0x00179E7C File Offset: 0x0017807C
			// Note: this type is marked as 'beforefieldinit'.
			static TaskNode()
			{
				Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "TaskNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr);
				SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr, "Prev");
				SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr, "Next");
				SemaphoreSlim.TaskNode.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr, 100670196);
				SemaphoreSlim.TaskNode.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr, 100670197);
				SemaphoreSlim.TaskNode.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr, 100670198);
			}

			// Token: 0x060053F2 RID: 21490 RVA: 0x00179F0C File Offset: 0x0017810C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200652, XrefRangeEnd = 200659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TaskNode()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.TaskNode.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053F3 RID: 21491 RVA: 0x00179F48 File Offset: 0x00178148
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200659, XrefRangeEnd = 200666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.TaskNode.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053F4 RID: 21492 RVA: 0x00179F7C File Offset: 0x0017817C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void System_Threading_IThreadPoolWorkItem_MarkAborted(ThreadAbortException tae)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.TaskNode.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053F5 RID: 21493 RVA: 0x0001F9E3 File Offset: 0x0001DBE3
			public TaskNode(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001588 RID: 5512
			// (get) Token: 0x060053F6 RID: 21494 RVA: 0x00179FC0 File Offset: 0x001781C0
			// (set) Token: 0x060053F7 RID: 21495 RVA: 0x0001F9EC File Offset: 0x0001DBEC
			public unsafe SemaphoreSlim.TaskNode Prev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Prev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Prev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001589 RID: 5513
			// (get) Token: 0x060053F8 RID: 21496 RVA: 0x00179FF0 File Offset: 0x001781F0
			// (set) Token: 0x060053F9 RID: 21497 RVA: 0x0001FA0B File Offset: 0x0001DC0B
			public unsafe SemaphoreSlim.TaskNode Next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004413 RID: 17427
			private static readonly IntPtr NativeFieldInfoPtr_Prev;

			// Token: 0x04004414 RID: 17428
			private static readonly IntPtr NativeFieldInfoPtr_Next;

			// Token: 0x04004415 RID: 17429
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04004416 RID: 17430
			private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004417 RID: 17431
			private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0;
		}

		// Token: 0x020005EC RID: 1516
		[ObfuscatedName("System.Threading.SemaphoreSlim+<WaitUntilCountOrTimeoutAsync>d__31")]
		public sealed class _WaitUntilCountOrTimeoutAsync_d__31 : ValueType
		{
			// Token: 0x060053FA RID: 21498 RVA: 0x0017A020 File Offset: 0x00178220
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitUntilCountOrTimeoutAsync_d__31()
			{
				Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "<WaitUntilCountOrTimeoutAsync>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr);
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "<>1__state");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "<>t__builder");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "cancellationToken");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_asyncWaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "asyncWaiter");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_millisecondsTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "millisecondsTimeout");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr__cts_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "<cts>5__1");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "<>4__this");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "<>7__wrap1");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "<>u__1");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "<>u__2");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, 100670199);
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, 100670200);
			}

			// Token: 0x060053FB RID: 21499 RVA: 0x0017A13C File Offset: 0x0017833C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200666, XrefRangeEnd = 200735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053FC RID: 21500 RVA: 0x0017A174 File Offset: 0x00178374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200735, XrefRangeEnd = 200750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053FD RID: 21501 RVA: 0x0001FA2A File Offset: 0x0001DC2A
			public _WaitUntilCountOrTimeoutAsync_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060053FE RID: 21502 RVA: 0x0001FA33 File Offset: 0x0001DC33
			public _WaitUntilCountOrTimeoutAsync_d__31()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr))
			{
			}

			// Token: 0x1700158A RID: 5514
			// (get) Token: 0x060053FF RID: 21503 RVA: 0x0017A1BC File Offset: 0x001783BC
			// (set) Token: 0x06005400 RID: 21504 RVA: 0x0001FA45 File Offset: 0x0001DC45
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700158B RID: 5515
			// (get) Token: 0x06005401 RID: 21505 RVA: 0x0017A1E4 File Offset: 0x001783E4
			// (set) Token: 0x06005402 RID: 21506 RVA: 0x0001FA60 File Offset: 0x0001DC60
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700158C RID: 5516
			// (get) Token: 0x06005403 RID: 21507 RVA: 0x0017A214 File Offset: 0x00178414
			// (set) Token: 0x06005404 RID: 21508 RVA: 0x0001FA8E File Offset: 0x0001DC8E
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700158D RID: 5517
			// (get) Token: 0x06005405 RID: 21509 RVA: 0x0017A244 File Offset: 0x00178444
			// (set) Token: 0x06005406 RID: 21510 RVA: 0x0001FABC File Offset: 0x0001DCBC
			public unsafe SemaphoreSlim.TaskNode asyncWaiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_asyncWaiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_asyncWaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700158E RID: 5518
			// (get) Token: 0x06005407 RID: 21511 RVA: 0x0017A274 File Offset: 0x00178474
			// (set) Token: 0x06005408 RID: 21512 RVA: 0x0001FADB File Offset: 0x0001DCDB
			public unsafe int millisecondsTimeout
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_millisecondsTimeout);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_millisecondsTimeout)) = value;
				}
			}

			// Token: 0x1700158F RID: 5519
			// (get) Token: 0x06005409 RID: 21513 RVA: 0x0017A29C File Offset: 0x0017849C
			// (set) Token: 0x0600540A RID: 21514 RVA: 0x0001FAF6 File Offset: 0x0001DCF6
			public unsafe CancellationTokenSource _cts_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr__cts_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr__cts_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001590 RID: 5520
			// (get) Token: 0x0600540B RID: 21515 RVA: 0x0017A2CC File Offset: 0x001784CC
			// (set) Token: 0x0600540C RID: 21516 RVA: 0x0001FB15 File Offset: 0x0001DD15
			public unsafe SemaphoreSlim __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001591 RID: 5521
			// (get) Token: 0x0600540D RID: 21517 RVA: 0x0017A2FC File Offset: 0x001784FC
			// (set) Token: 0x0600540E RID: 21518 RVA: 0x0001FB34 File Offset: 0x0001DD34
			public unsafe Object __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001592 RID: 5522
			// (get) Token: 0x0600540F RID: 21519 RVA: 0x0017A32C File Offset: 0x0017852C
			// (set) Token: 0x06005410 RID: 21520 RVA: 0x0001FB53 File Offset: 0x0001DD53
			public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001593 RID: 5523
			// (get) Token: 0x06005411 RID: 21521 RVA: 0x0017A35C File Offset: 0x0017855C
			// (set) Token: 0x06005412 RID: 21522 RVA: 0x0001FB81 File Offset: 0x0001DD81
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004418 RID: 17432
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004419 RID: 17433
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400441A RID: 17434
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400441B RID: 17435
			private static readonly IntPtr NativeFieldInfoPtr_asyncWaiter;

			// Token: 0x0400441C RID: 17436
			private static readonly IntPtr NativeFieldInfoPtr_millisecondsTimeout;

			// Token: 0x0400441D RID: 17437
			private static readonly IntPtr NativeFieldInfoPtr__cts_5__1;

			// Token: 0x0400441E RID: 17438
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400441F RID: 17439
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04004420 RID: 17440
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004421 RID: 17441
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04004422 RID: 17442
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004423 RID: 17443
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
