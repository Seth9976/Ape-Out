using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200006E RID: 110
	public class BackgroundWorker : Component
	{
		// Token: 0x060007AC RID: 1964 RVA: 0x0002DD8C File Offset: 0x0002BF8C
		// Note: this type is marked as 'beforefieldinit'.
		static BackgroundWorker()
		{
			Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "BackgroundWorker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr);
			BackgroundWorker.NativeFieldInfoPtr_doWorkKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, "doWorkKey");
			BackgroundWorker.NativeFieldInfoPtr_runWorkerCompletedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, "runWorkerCompletedKey");
			BackgroundWorker.NativeFieldInfoPtr_progressChangedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, "progressChangedKey");
			BackgroundWorker.NativeFieldInfoPtr_canCancelWorker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, "canCancelWorker");
			BackgroundWorker.NativeFieldInfoPtr_workerReportsProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, "workerReportsProgress");
			BackgroundWorker.NativeFieldInfoPtr_cancellationPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, "cancellationPending");
			BackgroundWorker.NativeFieldInfoPtr_isRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, "isRunning");
			BackgroundWorker.NativeFieldInfoPtr_asyncOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, "asyncOperation");
			BackgroundWorker.NativeFieldInfoPtr_threadStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, "threadStart");
			BackgroundWorker.NativeFieldInfoPtr_operationCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, "operationCompleted");
			BackgroundWorker.NativeFieldInfoPtr_progressReporter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, "progressReporter");
			BackgroundWorker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664423);
			BackgroundWorker.NativeMethodInfoPtr_AsyncOperationCompleted_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664424);
			BackgroundWorker.NativeMethodInfoPtr_get_CancellationPending_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664425);
			BackgroundWorker.NativeMethodInfoPtr_CancelAsync_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664426);
			BackgroundWorker.NativeMethodInfoPtr_add_DoWork_Public_add_Void_DoWorkEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664427);
			BackgroundWorker.NativeMethodInfoPtr_remove_DoWork_Public_rem_Void_DoWorkEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664428);
			BackgroundWorker.NativeMethodInfoPtr_get_IsBusy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664429);
			BackgroundWorker.NativeMethodInfoPtr_OnDoWork_Protected_Virtual_New_Void_DoWorkEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664430);
			BackgroundWorker.NativeMethodInfoPtr_OnRunWorkerCompleted_Protected_Virtual_New_Void_RunWorkerCompletedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664431);
			BackgroundWorker.NativeMethodInfoPtr_OnProgressChanged_Protected_Virtual_New_Void_ProgressChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664432);
			BackgroundWorker.NativeMethodInfoPtr_add_ProgressChanged_Public_add_Void_ProgressChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664433);
			BackgroundWorker.NativeMethodInfoPtr_remove_ProgressChanged_Public_rem_Void_ProgressChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664434);
			BackgroundWorker.NativeMethodInfoPtr_ProgressReporter_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664435);
			BackgroundWorker.NativeMethodInfoPtr_ReportProgress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664436);
			BackgroundWorker.NativeMethodInfoPtr_ReportProgress_Public_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664437);
			BackgroundWorker.NativeMethodInfoPtr_RunWorkerAsync_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664438);
			BackgroundWorker.NativeMethodInfoPtr_add_RunWorkerCompleted_Public_add_Void_RunWorkerCompletedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664439);
			BackgroundWorker.NativeMethodInfoPtr_remove_RunWorkerCompleted_Public_rem_Void_RunWorkerCompletedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664440);
			BackgroundWorker.NativeMethodInfoPtr_get_WorkerReportsProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664441);
			BackgroundWorker.NativeMethodInfoPtr_set_WorkerReportsProgress_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664442);
			BackgroundWorker.NativeMethodInfoPtr_get_WorkerSupportsCancellation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664443);
			BackgroundWorker.NativeMethodInfoPtr_WorkerThreadStart_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, 100664444);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0002E050 File Offset: 0x0002C250
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 372549, RefRangeEnd = 372557, XrefRangeStart = 372532, XrefRangeEnd = 372549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BackgroundWorker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0002E08C File Offset: 0x0002C28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372557, XrefRangeEnd = 372560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AsyncOperationCompleted(Object arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_AsyncOperationCompleted_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x0002E0D0 File Offset: 0x0002C2D0
		public unsafe bool CancellationPending
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_get_CancellationPending_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0002E10C File Offset: 0x0002C30C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372560, RefRangeEnd = 372562, XrefRangeStart = 372560, XrefRangeEnd = 372560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_CancelAsync_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0002E140 File Offset: 0x0002C340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372569, RefRangeEnd = 372571, XrefRangeStart = 372562, XrefRangeEnd = 372569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_DoWork(DoWorkEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_add_DoWork_Public_add_Void_DoWorkEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0002E184 File Offset: 0x0002C384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372571, XrefRangeEnd = 372578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_DoWork(DoWorkEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_remove_DoWork_Public_rem_Void_DoWorkEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x0002E1C8 File Offset: 0x0002C3C8
		public unsafe bool IsBusy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_get_IsBusy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0002E204 File Offset: 0x0002C404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372578, XrefRangeEnd = 372584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDoWork(DoWorkEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BackgroundWorker.NativeMethodInfoPtr_OnDoWork_Protected_Virtual_New_Void_DoWorkEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0002E254 File Offset: 0x0002C454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372584, XrefRangeEnd = 372590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BackgroundWorker.NativeMethodInfoPtr_OnRunWorkerCompleted_Protected_Virtual_New_Void_RunWorkerCompletedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0002E2A4 File Offset: 0x0002C4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372590, XrefRangeEnd = 372596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnProgressChanged(ProgressChangedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BackgroundWorker.NativeMethodInfoPtr_OnProgressChanged_Protected_Virtual_New_Void_ProgressChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0002E2F4 File Offset: 0x0002C4F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372603, RefRangeEnd = 372605, XrefRangeStart = 372596, XrefRangeEnd = 372603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ProgressChanged(ProgressChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_add_ProgressChanged_Public_add_Void_ProgressChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0002E338 File Offset: 0x0002C538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372605, XrefRangeEnd = 372612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ProgressChanged(ProgressChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_remove_ProgressChanged_Public_rem_Void_ProgressChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0002E37C File Offset: 0x0002C57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372612, XrefRangeEnd = 372615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProgressReporter(Object arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_ProgressReporter_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0002E3C0 File Offset: 0x0002C5C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372631, RefRangeEnd = 372633, XrefRangeStart = 372615, XrefRangeEnd = 372631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReportProgress(int percentProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref percentProgress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_ReportProgress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0002E400 File Offset: 0x0002C600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372633, XrefRangeEnd = 372640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReportProgress(int percentProgress, Object userState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref percentProgress;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userState);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_ReportProgress_Public_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0002E450 File Offset: 0x0002C650
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372650, RefRangeEnd = 372652, XrefRangeStart = 372640, XrefRangeEnd = 372650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunWorkerAsync(Object argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(argument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_RunWorkerAsync_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0002E494 File Offset: 0x0002C694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372659, RefRangeEnd = 372661, XrefRangeStart = 372652, XrefRangeEnd = 372659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_RunWorkerCompleted(RunWorkerCompletedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_add_RunWorkerCompleted_Public_add_Void_RunWorkerCompletedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0002E4D8 File Offset: 0x0002C6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372661, XrefRangeEnd = 372668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_RunWorkerCompleted(RunWorkerCompletedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_remove_RunWorkerCompleted_Public_rem_Void_RunWorkerCompletedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x0002E51C File Offset: 0x0002C71C
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x0002E558 File Offset: 0x0002C758
		public unsafe bool WorkerReportsProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_get_WorkerReportsProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_set_WorkerReportsProgress_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x0002E598 File Offset: 0x0002C798
		public unsafe bool WorkerSupportsCancellation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_get_WorkerSupportsCancellation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0002E5D4 File Offset: 0x0002C7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372668, XrefRangeEnd = 372694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WorkerThreadStart(Object argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(argument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.NativeMethodInfoPtr_WorkerThreadStart_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00005045 File Offset: 0x00003245
		public BackgroundWorker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0002E618 File Offset: 0x0002C818
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x0000504E File Offset: 0x0000324E
		public unsafe static Object doWorkKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BackgroundWorker.NativeFieldInfoPtr_doWorkKey, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BackgroundWorker.NativeFieldInfoPtr_doWorkKey, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0002E640 File Offset: 0x0002C840
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00005060 File Offset: 0x00003260
		public unsafe static Object runWorkerCompletedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BackgroundWorker.NativeFieldInfoPtr_runWorkerCompletedKey, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BackgroundWorker.NativeFieldInfoPtr_runWorkerCompletedKey, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0002E668 File Offset: 0x0002C868
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x00005072 File Offset: 0x00003272
		public unsafe static Object progressChangedKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BackgroundWorker.NativeFieldInfoPtr_progressChangedKey, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BackgroundWorker.NativeFieldInfoPtr_progressChangedKey, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x0002E690 File Offset: 0x0002C890
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x00005084 File Offset: 0x00003284
		public unsafe bool canCancelWorker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundWorker.NativeFieldInfoPtr_canCancelWorker);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundWorker.NativeFieldInfoPtr_canCancelWorker)) = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x0002E6B8 File Offset: 0x0002C8B8
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x0000509F File Offset: 0x0000329F
		public unsafe bool workerReportsProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundWorker.NativeFieldInfoPtr_workerReportsProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundWorker.NativeFieldInfoPtr_workerReportsProgress)) = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x0002E6E0 File Offset: 0x0002C8E0
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x000050BA File Offset: 0x000032BA
		public unsafe bool cancellationPending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundWorker.NativeFieldInfoPtr_cancellationPending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundWorker.NativeFieldInfoPtr_cancellationPending)) = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0002E708 File Offset: 0x0002C908
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x000050D5 File Offset: 0x000032D5
		public unsafe bool isRunning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundWorker.NativeFieldInfoPtr_isRunning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundWorker.NativeFieldInfoPtr_isRunning)) = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x0002E730 File Offset: 0x0002C930
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x000050F0 File Offset: 0x000032F0
		public unsafe AsyncOperation asyncOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundWorker.NativeFieldInfoPtr_asyncOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundWorker.NativeFieldInfoPtr_asyncOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x0002E760 File Offset: 0x0002C960
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x0000510F File Offset: 0x0000330F
		public unsafe BackgroundWorker.WorkerThreadStartDelegate threadStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundWorker.NativeFieldInfoPtr_threadStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BackgroundWorker.WorkerThreadStartDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundWorker.NativeFieldInfoPtr_threadStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0002E790 File Offset: 0x0002C990
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x0000512E File Offset: 0x0000332E
		public unsafe SendOrPostCallback operationCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundWorker.NativeFieldInfoPtr_operationCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundWorker.NativeFieldInfoPtr_operationCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x0002E7C0 File Offset: 0x0002C9C0
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x0000514D File Offset: 0x0000334D
		public unsafe SendOrPostCallback progressReporter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundWorker.NativeFieldInfoPtr_progressReporter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundWorker.NativeFieldInfoPtr_progressReporter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeFieldInfoPtr_doWorkKey;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeFieldInfoPtr_runWorkerCompletedKey;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeFieldInfoPtr_progressChangedKey;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeFieldInfoPtr_canCancelWorker;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeFieldInfoPtr_workerReportsProgress;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeFieldInfoPtr_cancellationPending;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeFieldInfoPtr_isRunning;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeFieldInfoPtr_asyncOperation;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeFieldInfoPtr_threadStart;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeFieldInfoPtr_operationCompleted;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeFieldInfoPtr_progressReporter;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_AsyncOperationCompleted_Private_Void_Object_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_get_CancellationPending_Public_get_Boolean_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_CancelAsync_Public_Void_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_add_DoWork_Public_add_Void_DoWorkEventHandler_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_remove_DoWork_Public_rem_Void_DoWorkEventHandler_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBusy_Public_get_Boolean_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_OnDoWork_Protected_Virtual_New_Void_DoWorkEventArgs_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_OnRunWorkerCompleted_Protected_Virtual_New_Void_RunWorkerCompletedEventArgs_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_OnProgressChanged_Protected_Virtual_New_Void_ProgressChangedEventArgs_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_add_ProgressChanged_Public_add_Void_ProgressChangedEventHandler_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_remove_ProgressChanged_Public_rem_Void_ProgressChangedEventHandler_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_ProgressReporter_Private_Void_Object_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_ReportProgress_Public_Void_Int32_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_ReportProgress_Public_Void_Int32_Object_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_RunWorkerAsync_Public_Void_Object_0;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_add_RunWorkerCompleted_Public_add_Void_RunWorkerCompletedEventHandler_0;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_remove_RunWorkerCompleted_Public_rem_Void_RunWorkerCompletedEventHandler_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_get_WorkerReportsProgress_Public_get_Boolean_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_set_WorkerReportsProgress_Public_set_Void_Boolean_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_get_WorkerSupportsCancellation_Public_get_Boolean_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_WorkerThreadStart_Private_Void_Object_0;

		// Token: 0x020001BA RID: 442
		public sealed class WorkerThreadStartDelegate : MulticastDelegate
		{
			// Token: 0x06001909 RID: 6409 RVA: 0x0006C028 File Offset: 0x0006A228
			// Note: this type is marked as 'beforefieldinit'.
			static WorkerThreadStartDelegate()
			{
				Il2CppClassPointerStore<BackgroundWorker.WorkerThreadStartDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BackgroundWorker>.NativeClassPtr, "WorkerThreadStartDelegate");
				BackgroundWorker.WorkerThreadStartDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker.WorkerThreadStartDelegate>.NativeClassPtr, 100664446);
				BackgroundWorker.WorkerThreadStartDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker.WorkerThreadStartDelegate>.NativeClassPtr, 100664447);
				BackgroundWorker.WorkerThreadStartDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker.WorkerThreadStartDelegate>.NativeClassPtr, 100664448);
				BackgroundWorker.WorkerThreadStartDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundWorker.WorkerThreadStartDelegate>.NativeClassPtr, 100664449);
			}

			// Token: 0x0600190A RID: 6410 RVA: 0x0006C09C File Offset: 0x0006A29C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WorkerThreadStartDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackgroundWorker.WorkerThreadStartDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.WorkerThreadStartDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600190B RID: 6411 RVA: 0x0006C0F8 File Offset: 0x0006A2F8
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 14114, RefRangeEnd = 14213, XrefRangeStart = 14114, XrefRangeEnd = 14213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Object argument)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(argument);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.WorkerThreadStartDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600190C RID: 6412 RVA: 0x0006C13C File Offset: 0x0006A33C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Object argument, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(argument);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.WorkerThreadStartDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600190D RID: 6413 RVA: 0x0006C1B0 File Offset: 0x0006A3B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundWorker.WorkerThreadStartDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600190E RID: 6414 RVA: 0x0000CEB3 File Offset: 0x0000B0B3
			public WorkerThreadStartDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600190F RID: 6415 RVA: 0x0000CEBC File Offset: 0x0000B0BC
			public static implicit operator BackgroundWorker.WorkerThreadStartDelegate(Action<Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<BackgroundWorker.WorkerThreadStartDelegate>(A_0);
			}

			// Token: 0x06001910 RID: 6416 RVA: 0x0000CEC4 File Offset: 0x0000B0C4
			public static BackgroundWorker.WorkerThreadStartDelegate operator +(BackgroundWorker.WorkerThreadStartDelegate A_0, BackgroundWorker.WorkerThreadStartDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<BackgroundWorker.WorkerThreadStartDelegate>();
			}

			// Token: 0x06001911 RID: 6417 RVA: 0x0000CED2 File Offset: 0x0000B0D2
			public static BackgroundWorker.WorkerThreadStartDelegate operator -(BackgroundWorker.WorkerThreadStartDelegate A_0, BackgroundWorker.WorkerThreadStartDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<BackgroundWorker.WorkerThreadStartDelegate>();
				}
				return delegate2;
			}

			// Token: 0x040013E5 RID: 5093
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040013E6 RID: 5094
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0;

			// Token: 0x040013E7 RID: 5095
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_AsyncCallback_Object_0;

			// Token: 0x040013E8 RID: 5096
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
