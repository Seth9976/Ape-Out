using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSanford.Collections;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Timers;

namespace Il2CppSanford.Threading
{
	// Token: 0x0200017D RID: 381
	public class DelegateScheduler : Object
	{
		// Token: 0x060010CC RID: 4300 RVA: 0x00052118 File Offset: 0x00050318
		// Note: this type is marked as 'beforefieldinit'.
		static DelegateScheduler()
		{
			Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Threading", "DelegateScheduler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr);
			DelegateScheduler.NativeFieldInfoPtr_Infinite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, "Infinite");
			DelegateScheduler.NativeFieldInfoPtr_DefaultPollingInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, "DefaultPollingInterval");
			DelegateScheduler.NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, "queue");
			DelegateScheduler.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, "timer");
			DelegateScheduler.NativeFieldInfoPtr_tasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, "tasks");
			DelegateScheduler.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, "running");
			DelegateScheduler.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, "disposed");
			DelegateScheduler.NativeFieldInfoPtr_site = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, "site");
			DelegateScheduler.NativeFieldInfoPtr_InvokeCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, "InvokeCompleted");
			DelegateScheduler.NativeFieldInfoPtr_Disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, "Disposed");
			DelegateScheduler.NativeMethodInfoPtr_add_InvokeCompleted_Public_add_Void_EventHandler_1_InvokeCompletedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665753);
			DelegateScheduler.NativeMethodInfoPtr_remove_InvokeCompleted_Public_rem_Void_EventHandler_1_InvokeCompletedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665754);
			DelegateScheduler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665755);
			DelegateScheduler.NativeMethodInfoPtr__ctor_Public_Void_IContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665756);
			DelegateScheduler.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665757);
			DelegateScheduler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665758);
			DelegateScheduler.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665759);
			DelegateScheduler.NativeMethodInfoPtr_Add_Public_Task_Int32_Int32_Delegate_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665760);
			DelegateScheduler.NativeMethodInfoPtr_Remove_Public_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665761);
			DelegateScheduler.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665762);
			DelegateScheduler.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665763);
			DelegateScheduler.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665764);
			DelegateScheduler.NativeMethodInfoPtr_HandleElapsed_Private_Void_Object_ElapsedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665765);
			DelegateScheduler.NativeMethodInfoPtr_OnDisposed_Protected_Virtual_New_Void_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665766);
			DelegateScheduler.NativeMethodInfoPtr_OnInvokeCompleted_Protected_Virtual_New_Void_InvokeCompletedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665767);
			DelegateScheduler.NativeMethodInfoPtr_get_PollingInterval_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665768);
			DelegateScheduler.NativeMethodInfoPtr_set_PollingInterval_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665769);
			DelegateScheduler.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665770);
			DelegateScheduler.NativeMethodInfoPtr_get_SynchronizingObject_Public_get_ISynchronizeInvoke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665771);
			DelegateScheduler.NativeMethodInfoPtr_set_SynchronizingObject_Public_set_Void_ISynchronizeInvoke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665772);
			DelegateScheduler.NativeMethodInfoPtr_add_Disposed_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665773);
			DelegateScheduler.NativeMethodInfoPtr_remove_Disposed_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665774);
			DelegateScheduler.NativeMethodInfoPtr_get_Site_Public_Virtual_Final_New_get_ISite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665775);
			DelegateScheduler.NativeMethodInfoPtr_set_Site_Public_Virtual_Final_New_set_Void_ISite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665776);
			DelegateScheduler.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr, 100665777);
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00052404 File Offset: 0x00050604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13863, XrefRangeEnd = 13866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_InvokeCompleted(EventHandler<InvokeCompletedEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_add_InvokeCompleted_Public_add_Void_EventHandler_1_InvokeCompletedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00052448 File Offset: 0x00050648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13866, XrefRangeEnd = 13869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_InvokeCompleted(EventHandler<InvokeCompletedEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_remove_InvokeCompleted_Public_rem_Void_EventHandler_1_InvokeCompletedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0005248C File Offset: 0x0005068C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13869, XrefRangeEnd = 13884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelegateScheduler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x000524C8 File Offset: 0x000506C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13884, XrefRangeEnd = 13903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelegateScheduler(IContainer container)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateScheduler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr__ctor_Public_Void_IContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00052514 File Offset: 0x00050714
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 13911, RefRangeEnd = 13913, XrefRangeStart = 13903, XrefRangeEnd = 13911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00052548 File Offset: 0x00050748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13913, XrefRangeEnd = 13914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DelegateScheduler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00052584 File Offset: 0x00050784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13914, XrefRangeEnd = 13928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DelegateScheduler.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x000525D0 File Offset: 0x000507D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13928, XrefRangeEnd = 13942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Add(int count, int millisecondsTimeout, Delegate method, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_Add_Public_Task_Int32_Int32_Delegate_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00052660 File Offset: 0x00050860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13942, XrefRangeEnd = 13948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_Remove_Public_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x000526A4 File Offset: 0x000508A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13948, XrefRangeEnd = 13959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x000526D8 File Offset: 0x000508D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13970, RefRangeEnd = 13971, XrefRangeStart = 13959, XrefRangeEnd = 13970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0005270C File Offset: 0x0005090C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13976, RefRangeEnd = 13977, XrefRangeStart = 13971, XrefRangeEnd = 13976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x00052740 File Offset: 0x00050940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13977, XrefRangeEnd = 14002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleElapsed(Object sender, ElapsedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_HandleElapsed_Private_Void_Object_ElapsedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00052794 File Offset: 0x00050994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14002, XrefRangeEnd = 14003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisposed(EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DelegateScheduler.NativeMethodInfoPtr_OnDisposed_Protected_Virtual_New_Void_EventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x000527E4 File Offset: 0x000509E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14003, XrefRangeEnd = 14006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInvokeCompleted(InvokeCompletedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DelegateScheduler.NativeMethodInfoPtr_OnInvokeCompleted_Protected_Virtual_New_Void_InvokeCompletedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x00052834 File Offset: 0x00050A34
		// (set) Token: 0x060010DD RID: 4317 RVA: 0x00052870 File Offset: 0x00050A70
		public unsafe double PollingInterval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_get_PollingInterval_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14006, XrefRangeEnd = 14008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_set_PollingInterval_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x000528B0 File Offset: 0x00050AB0
		public unsafe bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x000528EC File Offset: 0x00050AEC
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x0005292C File Offset: 0x00050B2C
		public unsafe ISynchronizeInvoke SynchronizingObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14008, XrefRangeEnd = 14010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_get_SynchronizingObject_Public_get_ISynchronizeInvoke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISynchronizeInvoke>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_set_SynchronizingObject_Public_set_Void_ISynchronizeInvoke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x00052970 File Offset: 0x00050B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14010, XrefRangeEnd = 14013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_Disposed(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_add_Disposed_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x000529B4 File Offset: 0x00050BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14013, XrefRangeEnd = 14016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_Disposed(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_remove_Disposed_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x000529F8 File Offset: 0x00050BF8
		// (set) Token: 0x060010E4 RID: 4324 RVA: 0x00052A38 File Offset: 0x00050C38
		public unsafe virtual ISite Site
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_get_Site_Public_Virtual_Final_New_get_ISite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_set_Site_Public_Virtual_Final_New_set_Void_ISite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x00052A7C File Offset: 0x00050C7C
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateScheduler.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00006E69 File Offset: 0x00005069
		public Task Add(int count, int millisecondsTimeout, Delegate method, params Object[] args)
		{
			return this.Add(count, millisecondsTimeout, method, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00006E7B File Offset: 0x0000507B
		public DelegateScheduler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x00052AB0 File Offset: 0x00050CB0
		// (set) Token: 0x060010E9 RID: 4329 RVA: 0x00006E84 File Offset: 0x00005084
		public unsafe static int Infinite
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DelegateScheduler.NativeFieldInfoPtr_Infinite, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DelegateScheduler.NativeFieldInfoPtr_Infinite, (void*)(&value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x00052ACC File Offset: 0x00050CCC
		// (set) Token: 0x060010EB RID: 4331 RVA: 0x00006E92 File Offset: 0x00005092
		public unsafe static int DefaultPollingInterval
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DelegateScheduler.NativeFieldInfoPtr_DefaultPollingInterval, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DelegateScheduler.NativeFieldInfoPtr_DefaultPollingInterval, (void*)(&value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x00052AE8 File Offset: 0x00050CE8
		// (set) Token: 0x060010ED RID: 4333 RVA: 0x00006EA0 File Offset: 0x000050A0
		public unsafe PriorityQueue queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateScheduler.NativeFieldInfoPtr_queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PriorityQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateScheduler.NativeFieldInfoPtr_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060010EE RID: 4334 RVA: 0x00052B18 File Offset: 0x00050D18
		// (set) Token: 0x060010EF RID: 4335 RVA: 0x00006EBF File Offset: 0x000050BF
		public unsafe Timer timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateScheduler.NativeFieldInfoPtr_timer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateScheduler.NativeFieldInfoPtr_timer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060010F0 RID: 4336 RVA: 0x00052B48 File Offset: 0x00050D48
		// (set) Token: 0x060010F1 RID: 4337 RVA: 0x00006EDE File Offset: 0x000050DE
		public unsafe List<Task> tasks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateScheduler.NativeFieldInfoPtr_tasks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Task>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateScheduler.NativeFieldInfoPtr_tasks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x00052B78 File Offset: 0x00050D78
		// (set) Token: 0x060010F3 RID: 4339 RVA: 0x00006EFD File Offset: 0x000050FD
		public unsafe bool running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateScheduler.NativeFieldInfoPtr_running);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateScheduler.NativeFieldInfoPtr_running)) = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x00052BA0 File Offset: 0x00050DA0
		// (set) Token: 0x060010F5 RID: 4341 RVA: 0x00006F18 File Offset: 0x00005118
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateScheduler.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateScheduler.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x00052BC8 File Offset: 0x00050DC8
		// (set) Token: 0x060010F7 RID: 4343 RVA: 0x00006F33 File Offset: 0x00005133
		public unsafe ISite site
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateScheduler.NativeFieldInfoPtr_site);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateScheduler.NativeFieldInfoPtr_site), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x00052BF8 File Offset: 0x00050DF8
		// (set) Token: 0x060010F9 RID: 4345 RVA: 0x00006F52 File Offset: 0x00005152
		public unsafe EventHandler<InvokeCompletedEventArgs> InvokeCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateScheduler.NativeFieldInfoPtr_InvokeCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<InvokeCompletedEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateScheduler.NativeFieldInfoPtr_InvokeCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x00052C28 File Offset: 0x00050E28
		// (set) Token: 0x060010FB RID: 4347 RVA: 0x00006F71 File Offset: 0x00005171
		public unsafe EventHandler Disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateScheduler.NativeFieldInfoPtr_Disposed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateScheduler.NativeFieldInfoPtr_Disposed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeFieldInfoPtr_Infinite;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeFieldInfoPtr_DefaultPollingInterval;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeFieldInfoPtr_queue;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeFieldInfoPtr_tasks;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeFieldInfoPtr_running;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeFieldInfoPtr_site;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeFieldInfoPtr_InvokeCompleted;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeFieldInfoPtr_Disposed;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeMethodInfoPtr_add_InvokeCompleted_Public_add_Void_EventHandler_1_InvokeCompletedEventArgs_0;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeMethodInfoPtr_remove_InvokeCompleted_Public_rem_Void_EventHandler_1_InvokeCompletedEventArgs_0;

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IContainer_0;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Task_Int32_Int32_Delegate_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Task_0;

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeMethodInfoPtr_HandleElapsed_Private_Void_Object_ElapsedEventArgs_0;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeMethodInfoPtr_OnDisposed_Protected_Virtual_New_Void_EventArgs_0;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeMethodInfoPtr_OnInvokeCompleted_Protected_Virtual_New_Void_InvokeCompletedEventArgs_0;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeMethodInfoPtr_get_PollingInterval_Public_get_Double_0;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeMethodInfoPtr_set_PollingInterval_Public_set_Void_Double_0;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizingObject_Public_get_ISynchronizeInvoke_0;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeMethodInfoPtr_set_SynchronizingObject_Public_set_Void_ISynchronizeInvoke_0;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeMethodInfoPtr_add_Disposed_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeMethodInfoPtr_remove_Disposed_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeMethodInfoPtr_get_Site_Public_Virtual_Final_New_get_ISite_0;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeMethodInfoPtr_set_Site_Public_Virtual_Final_New_set_Void_ISite_0;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
