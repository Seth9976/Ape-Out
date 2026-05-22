using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSanford.Collections.Generic;
using Il2CppSystem;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Threading;

namespace Il2CppSanford.Threading
{
	// Token: 0x0200017B RID: 379
	public class DelegateQueue : SynchronizationContext
	{
		// Token: 0x0600108F RID: 4239 RVA: 0x000511C8 File Offset: 0x0004F3C8
		// Note: this type is marked as 'beforefieldinit'.
		static DelegateQueue()
		{
			Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Threading", "DelegateQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr);
			DelegateQueue.NativeFieldInfoPtr_delegateThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, "delegateThread");
			DelegateQueue.NativeFieldInfoPtr_delegateDeque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, "delegateDeque");
			DelegateQueue.NativeFieldInfoPtr_lockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, "lockObject");
			DelegateQueue.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, "context");
			DelegateQueue.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, "disposed");
			DelegateQueue.NativeFieldInfoPtr_threadID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, "threadID");
			DelegateQueue.NativeFieldInfoPtr_site = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, "site");
			DelegateQueue.NativeFieldInfoPtr_InvokeCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, "InvokeCompleted");
			DelegateQueue.NativeFieldInfoPtr_PostCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, "PostCompleted");
			DelegateQueue.NativeFieldInfoPtr_Disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, "Disposed");
			DelegateQueue.NativeMethodInfoPtr_add_InvokeCompleted_Public_add_Void_EventHandler_1_InvokeCompletedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665706);
			DelegateQueue.NativeMethodInfoPtr_remove_InvokeCompleted_Public_rem_Void_EventHandler_1_InvokeCompletedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665707);
			DelegateQueue.NativeMethodInfoPtr_add_PostCompleted_Public_add_Void_EventHandler_1_PostCompletedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665708);
			DelegateQueue.NativeMethodInfoPtr_remove_PostCompleted_Public_rem_Void_EventHandler_1_PostCompletedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665709);
			DelegateQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665710);
			DelegateQueue.NativeMethodInfoPtr__ctor_Public_Void_IContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665711);
			DelegateQueue.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665712);
			DelegateQueue.NativeMethodInfoPtr_InitializeDelegateQueue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665713);
			DelegateQueue.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665714);
			DelegateQueue.NativeMethodInfoPtr_BeginInvokePriority_Public_IAsyncResult_Delegate_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665715);
			DelegateQueue.NativeMethodInfoPtr_InvokePriority_Public_Object_Delegate_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665716);
			DelegateQueue.NativeMethodInfoPtr_BeginInvoke_Public_IAsyncResult_AsyncCallback_Object_Delegate_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665717);
			DelegateQueue.NativeMethodInfoPtr_PostPriority_Public_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665718);
			DelegateQueue.NativeMethodInfoPtr_SendPriority_Public_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665719);
			DelegateQueue.NativeMethodInfoPtr_DelegateProcedure_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665720);
			DelegateQueue.NativeMethodInfoPtr_OnInvokeCompleted_Protected_Virtual_New_Void_InvokeCompletedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665721);
			DelegateQueue.NativeMethodInfoPtr_OnPostCompleted_Protected_Virtual_New_Void_PostCompletedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665722);
			DelegateQueue.NativeMethodInfoPtr_OnDisposed_Protected_Virtual_New_Void_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665723);
			DelegateQueue.NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665724);
			DelegateQueue.NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665725);
			DelegateQueue.NativeMethodInfoPtr_add_Disposed_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665726);
			DelegateQueue.NativeMethodInfoPtr_remove_Disposed_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665727);
			DelegateQueue.NativeMethodInfoPtr_get_Site_Public_Virtual_Final_New_get_ISite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665728);
			DelegateQueue.NativeMethodInfoPtr_set_Site_Public_Virtual_Final_New_set_Void_ISite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665729);
			DelegateQueue.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_Final_New_IAsyncResult_Delegate_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665730);
			DelegateQueue.NativeMethodInfoPtr_EndInvoke_Public_Virtual_Final_New_Object_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665731);
			DelegateQueue.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Object_Delegate_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665732);
			DelegateQueue.NativeMethodInfoPtr_get_InvokeRequired_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665733);
			DelegateQueue.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, 100665734);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00051504 File Offset: 0x0004F704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13579, XrefRangeEnd = 13582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_InvokeCompleted(EventHandler<InvokeCompletedEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_add_InvokeCompleted_Public_add_Void_EventHandler_1_InvokeCompletedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00051548 File Offset: 0x0004F748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13582, XrefRangeEnd = 13585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_InvokeCompleted(EventHandler<InvokeCompletedEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_remove_InvokeCompleted_Public_rem_Void_EventHandler_1_InvokeCompletedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0005158C File Offset: 0x0004F78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13585, XrefRangeEnd = 13588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PostCompleted(EventHandler<PostCompletedEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_add_PostCompleted_Public_add_Void_EventHandler_1_PostCompletedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x000515D0 File Offset: 0x0004F7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13588, XrefRangeEnd = 13591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PostCompleted(EventHandler<PostCompletedEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_remove_PostCompleted_Public_rem_Void_EventHandler_1_PostCompletedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00051614 File Offset: 0x0004F814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 13602, RefRangeEnd = 13604, XrefRangeStart = 13591, XrefRangeEnd = 13602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelegateQueue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00051650 File Offset: 0x0004F850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13604, XrefRangeEnd = 13616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelegateQueue(IContainer container)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr__ctor_Public_Void_IContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0005169C File Offset: 0x0004F89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13616, XrefRangeEnd = 13617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DelegateQueue.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x000516D8 File Offset: 0x0004F8D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 13644, RefRangeEnd = 13646, XrefRangeStart = 13617, XrefRangeEnd = 13644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDelegateQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_InitializeDelegateQueue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0005170C File Offset: 0x0004F90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13646, XrefRangeEnd = 13654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DelegateQueue.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00051758 File Offset: 0x0004F958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13654, XrefRangeEnd = 13667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvokePriority(Delegate method, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_BeginInvokePriority_Public_IAsyncResult_Delegate_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x000517C8 File Offset: 0x0004F9C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13669, RefRangeEnd = 13670, XrefRangeStart = 13667, XrefRangeEnd = 13669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InvokePriority(Delegate method, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_InvokePriority_Public_Object_Delegate_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x00051838 File Offset: 0x0004FA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13670, XrefRangeEnd = 13683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object state, Delegate method, [Optional] Il2CppReferenceArray<Object> args)
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
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_BeginInvoke_Public_IAsyncResult_AsyncCallback_Object_Delegate_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x000518D0 File Offset: 0x0004FAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13683, XrefRangeEnd = 13696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostPriority(SendOrPostCallback d, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_PostPriority_Public_Void_SendOrPostCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00051924 File Offset: 0x0004FB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13696, XrefRangeEnd = 13705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPriority(SendOrPostCallback d, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_SendPriority_Public_Void_SendOrPostCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00051978 File Offset: 0x0004FB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13705, XrefRangeEnd = 13730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DelegateProcedure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_DelegateProcedure_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x000519AC File Offset: 0x0004FBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13730, XrefRangeEnd = 13738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInvokeCompleted(InvokeCompletedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DelegateQueue.NativeMethodInfoPtr_OnInvokeCompleted_Protected_Virtual_New_Void_InvokeCompletedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x000519FC File Offset: 0x0004FBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13738, XrefRangeEnd = 13746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPostCompleted(PostCompletedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DelegateQueue.NativeMethodInfoPtr_OnPostCompleted_Protected_Virtual_New_Void_PostCompletedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00051A4C File Offset: 0x0004FC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13746, XrefRangeEnd = 13754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisposed(EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DelegateQueue.NativeMethodInfoPtr_OnDisposed_Protected_Virtual_New_Void_EventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00051A9C File Offset: 0x0004FC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13754, XrefRangeEnd = 13763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Send(SendOrPostCallback d, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DelegateQueue.NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00051AFC File Offset: 0x0004FCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13763, XrefRangeEnd = 13776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Post(SendOrPostCallback d, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DelegateQueue.NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00051B5C File Offset: 0x0004FD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13776, XrefRangeEnd = 13779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_Disposed(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_add_Disposed_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00051BA0 File Offset: 0x0004FDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13779, XrefRangeEnd = 13782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_Disposed(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_remove_Disposed_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x00051BE4 File Offset: 0x0004FDE4
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x00051C24 File Offset: 0x0004FE24
		public unsafe virtual ISite Site
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_get_Site_Public_Virtual_Final_New_get_ISite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_set_Site_Public_Virtual_Final_New_set_Void_ISite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00051C68 File Offset: 0x0004FE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13825, XrefRangeEnd = 13838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAsyncResult BeginInvoke(Delegate method, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_Final_New_IAsyncResult_Delegate_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00051CD8 File Offset: 0x0004FED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13838, XrefRangeEnd = 13843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_EndInvoke_Public_Virtual_Final_New_Object_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x00051D28 File Offset: 0x0004FF28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13845, RefRangeEnd = 13846, XrefRangeStart = 13843, XrefRangeEnd = 13845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Invoke(Delegate method, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Object_Delegate_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x00051D98 File Offset: 0x0004FF98
		public unsafe virtual bool InvokeRequired
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 13849, RefRangeEnd = 13854, XrefRangeStart = 13846, XrefRangeEnd = 13849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_get_InvokeRequired_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00051DD4 File Offset: 0x0004FFD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 13858, RefRangeEnd = 13862, XrefRangeStart = 13854, XrefRangeEnd = 13858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00006CD8 File Offset: 0x00004ED8
		public IAsyncResult BeginInvokePriority(Delegate method, params Object[] args)
		{
			return this.BeginInvokePriority(method, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00006CE7 File Offset: 0x00004EE7
		public Object InvokePriority(Delegate method, params Object[] args)
		{
			return this.InvokePriority(method, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00006CF6 File Offset: 0x00004EF6
		public IAsyncResult BeginInvoke(AsyncCallback callback, Object state, Delegate method, params Object[] args)
		{
			return this.BeginInvoke(callback, state, method, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00006D08 File Offset: 0x00004F08
		public virtual IAsyncResult BeginInvoke(Delegate method, params Object[] args)
		{
			return this.BeginInvoke(method, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00006D17 File Offset: 0x00004F17
		public DelegateQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x00051E08 File Offset: 0x00050008
		// (set) Token: 0x060010B3 RID: 4275 RVA: 0x00006D20 File Offset: 0x00004F20
		public unsafe Thread delegateThread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_delegateThread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_delegateThread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00051E38 File Offset: 0x00050038
		// (set) Token: 0x060010B5 RID: 4277 RVA: 0x00006D3F File Offset: 0x00004F3F
		public unsafe Deque<DelegateQueue.DelegateQueueAsyncResult> delegateDeque
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_delegateDeque);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Deque<DelegateQueue.DelegateQueueAsyncResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_delegateDeque), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x00051E68 File Offset: 0x00050068
		// (set) Token: 0x060010B7 RID: 4279 RVA: 0x00006D5E File Offset: 0x00004F5E
		public unsafe Object lockObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_lockObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_lockObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x00051E98 File Offset: 0x00050098
		// (set) Token: 0x060010B9 RID: 4281 RVA: 0x00006D7D File Offset: 0x00004F7D
		public unsafe SynchronizationContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x00051EC8 File Offset: 0x000500C8
		// (set) Token: 0x060010BB RID: 4283 RVA: 0x00006D9C File Offset: 0x00004F9C
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060010BC RID: 4284 RVA: 0x00051EF0 File Offset: 0x000500F0
		// (set) Token: 0x060010BD RID: 4285 RVA: 0x00006DB7 File Offset: 0x00004FB7
		public unsafe static uint threadID
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(DelegateQueue.NativeFieldInfoPtr_threadID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DelegateQueue.NativeFieldInfoPtr_threadID, (void*)(&value));
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060010BE RID: 4286 RVA: 0x00051F0C File Offset: 0x0005010C
		// (set) Token: 0x060010BF RID: 4287 RVA: 0x00006DC5 File Offset: 0x00004FC5
		public unsafe ISite site
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_site);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_site), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060010C0 RID: 4288 RVA: 0x00051F3C File Offset: 0x0005013C
		// (set) Token: 0x060010C1 RID: 4289 RVA: 0x00006DE4 File Offset: 0x00004FE4
		public unsafe EventHandler<InvokeCompletedEventArgs> InvokeCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_InvokeCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<InvokeCompletedEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_InvokeCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x00051F6C File Offset: 0x0005016C
		// (set) Token: 0x060010C3 RID: 4291 RVA: 0x00006E03 File Offset: 0x00005003
		public unsafe EventHandler<PostCompletedEventArgs> PostCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_PostCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<PostCompletedEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_PostCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x00051F9C File Offset: 0x0005019C
		// (set) Token: 0x060010C5 RID: 4293 RVA: 0x00006E22 File Offset: 0x00005022
		public unsafe EventHandler Disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_Disposed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.NativeFieldInfoPtr_Disposed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeFieldInfoPtr_delegateThread;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeFieldInfoPtr_delegateDeque;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeFieldInfoPtr_lockObject;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeFieldInfoPtr_threadID;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeFieldInfoPtr_site;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeFieldInfoPtr_InvokeCompleted;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeFieldInfoPtr_PostCompleted;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeFieldInfoPtr_Disposed;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeMethodInfoPtr_add_InvokeCompleted_Public_add_Void_EventHandler_1_InvokeCompletedEventArgs_0;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeMethodInfoPtr_remove_InvokeCompleted_Public_rem_Void_EventHandler_1_InvokeCompletedEventArgs_0;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeMethodInfoPtr_add_PostCompleted_Public_add_Void_EventHandler_1_PostCompletedEventArgs_0;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeMethodInfoPtr_remove_PostCompleted_Public_rem_Void_EventHandler_1_PostCompletedEventArgs_0;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IContainer_0;

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDelegateQueue_Private_Void_0;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvokePriority_Public_IAsyncResult_Delegate_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeMethodInfoPtr_InvokePriority_Public_Object_Delegate_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_IAsyncResult_AsyncCallback_Object_Delegate_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeMethodInfoPtr_PostPriority_Public_Void_SendOrPostCallback_Object_0;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeMethodInfoPtr_SendPriority_Public_Void_SendOrPostCallback_Object_0;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeMethodInfoPtr_DelegateProcedure_Private_Void_0;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeMethodInfoPtr_OnInvokeCompleted_Protected_Virtual_New_Void_InvokeCompletedEventArgs_0;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeMethodInfoPtr_OnPostCompleted_Protected_Virtual_New_Void_PostCompletedEventArgs_0;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeMethodInfoPtr_OnDisposed_Protected_Virtual_New_Void_EventArgs_0;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeMethodInfoPtr_add_Disposed_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeMethodInfoPtr_remove_Disposed_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeMethodInfoPtr_get_Site_Public_Virtual_Final_New_get_ISite_0;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeMethodInfoPtr_set_Site_Public_Virtual_Final_New_set_Void_ISite_0;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_Final_New_IAsyncResult_Delegate_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_Final_New_Object_IAsyncResult_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Object_Delegate_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_get_InvokeRequired_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0200023C RID: 572
		[OriginalName("Assembly-CSharp-firstpass.dll", "", "NotificationType")]
		public enum NotificationType
		{
			// Token: 0x04001FE1 RID: 8161
			None,
			// Token: 0x04001FE2 RID: 8162
			BeginInvokeCompleted,
			// Token: 0x04001FE3 RID: 8163
			PostCompleted
		}

		// Token: 0x0200023D RID: 573
		public class DelegateQueueAsyncResult : AsyncResult
		{
			// Token: 0x06001F99 RID: 8089 RVA: 0x0008B87C File Offset: 0x00089A7C
			// Note: this type is marked as 'beforefieldinit'.
			static DelegateQueueAsyncResult()
			{
				Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, "DelegateQueueAsyncResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr);
				DelegateQueue.DelegateQueueAsyncResult.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr, "method");
				DelegateQueue.DelegateQueueAsyncResult.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr, "args");
				DelegateQueue.DelegateQueueAsyncResult.NativeFieldInfoPtr_returnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr, "returnValue");
				DelegateQueue.DelegateQueueAsyncResult.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr, "error");
				DelegateQueue.DelegateQueueAsyncResult.NativeFieldInfoPtr_notificationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr, "notificationType");
				DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_Object_Delegate_Il2CppReferenceArray_1_Object_Boolean_NotificationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr, 100665736);
				DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_Object_AsyncCallback_Object_Delegate_Il2CppReferenceArray_1_Object_Boolean_NotificationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr, 100665737);
				DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr, 100665738);
				DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr_GetArgs_Public_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr, 100665739);
				DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr_get_ReturnValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr, 100665740);
				DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr_get_Error_Public_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr, 100665741);
				DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr_set_Error_Public_set_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr, 100665742);
				DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr_get_Method_Public_get_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr, 100665743);
				DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr_get_NotificationType_Public_get_NotificationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr, 100665744);
			}

			// Token: 0x06001F9A RID: 8090 RVA: 0x0008B9C0 File Offset: 0x00089BC0
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 13523, RefRangeEnd = 13529, XrefRangeStart = 13522, XrefRangeEnd = 13523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DelegateQueueAsyncResult(Object owner, Delegate method, Il2CppReferenceArray<Object> args, bool synchronously, DelegateQueue.NotificationType notificationType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synchronously;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notificationType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_Object_Delegate_Il2CppReferenceArray_1_Object_Boolean_NotificationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F9B RID: 8091 RVA: 0x0008BA4C File Offset: 0x00089C4C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 13530, RefRangeEnd = 13532, XrefRangeStart = 13529, XrefRangeEnd = 13530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DelegateQueueAsyncResult(Object owner, AsyncCallback callback, Object state, Delegate method, Il2CppReferenceArray<Object> args, bool synchronously, DelegateQueue.NotificationType notificationType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateQueue.DelegateQueueAsyncResult>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synchronously;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notificationType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_Object_AsyncCallback_Object_Delegate_Il2CppReferenceArray_1_Object_Boolean_NotificationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F9C RID: 8092 RVA: 0x0008BB00 File Offset: 0x00089D00
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 13539, RefRangeEnd = 13543, XrefRangeStart = 13532, XrefRangeEnd = 13539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F9D RID: 8093 RVA: 0x0008BB34 File Offset: 0x00089D34
			[CallerCount(0)]
			public unsafe Il2CppReferenceArray<Object> GetArgs()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr_GetArgs_Public_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}

			// Token: 0x17000637 RID: 1591
			// (get) Token: 0x06001F9E RID: 8094 RVA: 0x0008BB74 File Offset: 0x00089D74
			public unsafe Object ReturnValue
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr_get_ReturnValue_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17000638 RID: 1592
			// (get) Token: 0x06001F9F RID: 8095 RVA: 0x0008BBB4 File Offset: 0x00089DB4
			// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x0008BBF4 File Offset: 0x00089DF4
			public unsafe Exception Error
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr_get_Error_Public_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
				}
				[CallerCount(26)]
				[CachedScanResults(RefRangeStart = 13543, RefRangeEnd = 13569, XrefRangeStart = 13543, XrefRangeEnd = 13543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr_set_Error_Public_set_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000639 RID: 1593
			// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x0008BC38 File Offset: 0x00089E38
			public unsafe Delegate Method
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr_get_Method_Public_get_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
				}
			}

			// Token: 0x1700063A RID: 1594
			// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x0008BC78 File Offset: 0x00089E78
			public unsafe DelegateQueue.NotificationType NotificationType
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.DelegateQueueAsyncResult.NativeMethodInfoPtr_get_NotificationType_Public_get_NotificationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001FA3 RID: 8099 RVA: 0x0000B7EF File Offset: 0x000099EF
			public DelegateQueueAsyncResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000632 RID: 1586
			// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x0008BCB4 File Offset: 0x00089EB4
			// (set) Token: 0x06001FA5 RID: 8101 RVA: 0x0000B7F8 File Offset: 0x000099F8
			public unsafe Delegate method
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.DelegateQueueAsyncResult.NativeFieldInfoPtr_method);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.DelegateQueueAsyncResult.NativeFieldInfoPtr_method), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000633 RID: 1587
			// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x0008BCE4 File Offset: 0x00089EE4
			// (set) Token: 0x06001FA7 RID: 8103 RVA: 0x0000B817 File Offset: 0x00009A17
			public unsafe Il2CppReferenceArray<Object> args
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.DelegateQueueAsyncResult.NativeFieldInfoPtr_args);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.DelegateQueueAsyncResult.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000634 RID: 1588
			// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x0008BD14 File Offset: 0x00089F14
			// (set) Token: 0x06001FA9 RID: 8105 RVA: 0x0000B836 File Offset: 0x00009A36
			public unsafe Object returnValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.DelegateQueueAsyncResult.NativeFieldInfoPtr_returnValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.DelegateQueueAsyncResult.NativeFieldInfoPtr_returnValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000635 RID: 1589
			// (get) Token: 0x06001FAA RID: 8106 RVA: 0x0008BD44 File Offset: 0x00089F44
			// (set) Token: 0x06001FAB RID: 8107 RVA: 0x0000B855 File Offset: 0x00009A55
			public unsafe Exception error
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.DelegateQueueAsyncResult.NativeFieldInfoPtr_error);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.DelegateQueueAsyncResult.NativeFieldInfoPtr_error), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000636 RID: 1590
			// (get) Token: 0x06001FAC RID: 8108 RVA: 0x0008BD74 File Offset: 0x00089F74
			// (set) Token: 0x06001FAD RID: 8109 RVA: 0x0000B874 File Offset: 0x00009A74
			public unsafe DelegateQueue.NotificationType notificationType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.DelegateQueueAsyncResult.NativeFieldInfoPtr_notificationType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.DelegateQueueAsyncResult.NativeFieldInfoPtr_notificationType)) = value;
				}
			}

			// Token: 0x04001FE4 RID: 8164
			private static readonly IntPtr NativeFieldInfoPtr_method;

			// Token: 0x04001FE5 RID: 8165
			private static readonly IntPtr NativeFieldInfoPtr_args;

			// Token: 0x04001FE6 RID: 8166
			private static readonly IntPtr NativeFieldInfoPtr_returnValue;

			// Token: 0x04001FE7 RID: 8167
			private static readonly IntPtr NativeFieldInfoPtr_error;

			// Token: 0x04001FE8 RID: 8168
			private static readonly IntPtr NativeFieldInfoPtr_notificationType;

			// Token: 0x04001FE9 RID: 8169
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Delegate_Il2CppReferenceArray_1_Object_Boolean_NotificationType_0;

			// Token: 0x04001FEA RID: 8170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_AsyncCallback_Object_Delegate_Il2CppReferenceArray_1_Object_Boolean_NotificationType_0;

			// Token: 0x04001FEB RID: 8171
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;

			// Token: 0x04001FEC RID: 8172
			private static readonly IntPtr NativeMethodInfoPtr_GetArgs_Public_Il2CppReferenceArray_1_Object_0;

			// Token: 0x04001FED RID: 8173
			private static readonly IntPtr NativeMethodInfoPtr_get_ReturnValue_Public_get_Object_0;

			// Token: 0x04001FEE RID: 8174
			private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_Exception_0;

			// Token: 0x04001FEF RID: 8175
			private static readonly IntPtr NativeMethodInfoPtr_set_Error_Public_set_Void_Exception_0;

			// Token: 0x04001FF0 RID: 8176
			private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_get_Delegate_0;

			// Token: 0x04001FF1 RID: 8177
			private static readonly IntPtr NativeMethodInfoPtr_get_NotificationType_Public_get_NotificationType_0;
		}

		// Token: 0x0200023E RID: 574
		[ObfuscatedName("Sanford.Threading.DelegateQueue+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Object
		{
			// Token: 0x06001FAE RID: 8110 RVA: 0x0008BD9C File Offset: 0x00089F9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass26_0>.NativeClassPtr);
				DelegateQueue.__c__DisplayClass26_0.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass26_0>.NativeClassPtr, "handler");
				DelegateQueue.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				DelegateQueue.__c__DisplayClass26_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass26_0>.NativeClassPtr, "e");
				DelegateQueue.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass26_0>.NativeClassPtr, 100665745);
				DelegateQueue.__c__DisplayClass26_0.NativeMethodInfoPtr__OnInvokeCompleted_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass26_0>.NativeClassPtr, 100665746);
			}

			// Token: 0x06001FAF RID: 8111 RVA: 0x0008BE2C File Offset: 0x0008A02C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FB0 RID: 8112 RVA: 0x0008BE68 File Offset: 0x0008A068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13569, XrefRangeEnd = 13573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInvokeCompleted_b__0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.__c__DisplayClass26_0.NativeMethodInfoPtr__OnInvokeCompleted_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FB1 RID: 8113 RVA: 0x0000B88F File Offset: 0x00009A8F
			public __c__DisplayClass26_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700063B RID: 1595
			// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x0008BEAC File Offset: 0x0008A0AC
			// (set) Token: 0x06001FB3 RID: 8115 RVA: 0x0000B898 File Offset: 0x00009A98
			public unsafe EventHandler<InvokeCompletedEventArgs> handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass26_0.NativeFieldInfoPtr_handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<InvokeCompletedEventArgs>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass26_0.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700063C RID: 1596
			// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x0008BEDC File Offset: 0x0008A0DC
			// (set) Token: 0x06001FB5 RID: 8117 RVA: 0x0000B8B7 File Offset: 0x00009AB7
			public unsafe DelegateQueue __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700063D RID: 1597
			// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x0008BF0C File Offset: 0x0008A10C
			// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x0000B8D6 File Offset: 0x00009AD6
			public unsafe InvokeCompletedEventArgs e
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass26_0.NativeFieldInfoPtr_e);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InvokeCompletedEventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass26_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FF2 RID: 8178
			private static readonly IntPtr NativeFieldInfoPtr_handler;

			// Token: 0x04001FF3 RID: 8179
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001FF4 RID: 8180
			private static readonly IntPtr NativeFieldInfoPtr_e;

			// Token: 0x04001FF5 RID: 8181
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001FF6 RID: 8182
			private static readonly IntPtr NativeMethodInfoPtr__OnInvokeCompleted_b__0_Internal_Void_Object_0;
		}

		// Token: 0x0200023F RID: 575
		[ObfuscatedName("Sanford.Threading.DelegateQueue+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Object
		{
			// Token: 0x06001FB8 RID: 8120 RVA: 0x0008BF3C File Offset: 0x0008A13C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass27_0>.NativeClassPtr);
				DelegateQueue.__c__DisplayClass27_0.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass27_0>.NativeClassPtr, "handler");
				DelegateQueue.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				DelegateQueue.__c__DisplayClass27_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass27_0>.NativeClassPtr, "e");
				DelegateQueue.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass27_0>.NativeClassPtr, 100665747);
				DelegateQueue.__c__DisplayClass27_0.NativeMethodInfoPtr__OnPostCompleted_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass27_0>.NativeClassPtr, 100665748);
			}

			// Token: 0x06001FB9 RID: 8121 RVA: 0x0008BFCC File Offset: 0x0008A1CC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FBA RID: 8122 RVA: 0x0008C008 File Offset: 0x0008A208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13573, XrefRangeEnd = 13577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPostCompleted_b__0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.__c__DisplayClass27_0.NativeMethodInfoPtr__OnPostCompleted_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FBB RID: 8123 RVA: 0x0000B8F5 File Offset: 0x00009AF5
			public __c__DisplayClass27_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700063E RID: 1598
			// (get) Token: 0x06001FBC RID: 8124 RVA: 0x0008C04C File Offset: 0x0008A24C
			// (set) Token: 0x06001FBD RID: 8125 RVA: 0x0000B8FE File Offset: 0x00009AFE
			public unsafe EventHandler<PostCompletedEventArgs> handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass27_0.NativeFieldInfoPtr_handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<PostCompletedEventArgs>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass27_0.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700063F RID: 1599
			// (get) Token: 0x06001FBE RID: 8126 RVA: 0x0008C07C File Offset: 0x0008A27C
			// (set) Token: 0x06001FBF RID: 8127 RVA: 0x0000B91D File Offset: 0x00009B1D
			public unsafe DelegateQueue __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000640 RID: 1600
			// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x0008C0AC File Offset: 0x0008A2AC
			// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x0000B93C File Offset: 0x00009B3C
			public unsafe PostCompletedEventArgs e
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass27_0.NativeFieldInfoPtr_e);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostCompletedEventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass27_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FF7 RID: 8183
			private static readonly IntPtr NativeFieldInfoPtr_handler;

			// Token: 0x04001FF8 RID: 8184
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001FF9 RID: 8185
			private static readonly IntPtr NativeFieldInfoPtr_e;

			// Token: 0x04001FFA RID: 8186
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001FFB RID: 8187
			private static readonly IntPtr NativeMethodInfoPtr__OnPostCompleted_b__0_Internal_Void_Object_0;
		}

		// Token: 0x02000240 RID: 576
		[ObfuscatedName("Sanford.Threading.DelegateQueue+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Object
		{
			// Token: 0x06001FC2 RID: 8130 RVA: 0x0008C0DC File Offset: 0x0008A2DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DelegateQueue>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass28_0>.NativeClassPtr);
				DelegateQueue.__c__DisplayClass28_0.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass28_0>.NativeClassPtr, "handler");
				DelegateQueue.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
				DelegateQueue.__c__DisplayClass28_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass28_0>.NativeClassPtr, "e");
				DelegateQueue.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass28_0>.NativeClassPtr, 100665749);
				DelegateQueue.__c__DisplayClass28_0.NativeMethodInfoPtr__OnDisposed_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass28_0>.NativeClassPtr, 100665750);
			}

			// Token: 0x06001FC3 RID: 8131 RVA: 0x0008C16C File Offset: 0x0008A36C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateQueue.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FC4 RID: 8132 RVA: 0x0008C1A8 File Offset: 0x0008A3A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13577, XrefRangeEnd = 13579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnDisposed_b__0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateQueue.__c__DisplayClass28_0.NativeMethodInfoPtr__OnDisposed_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FC5 RID: 8133 RVA: 0x0000B95B File Offset: 0x00009B5B
			public __c__DisplayClass28_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000641 RID: 1601
			// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x0008C1EC File Offset: 0x0008A3EC
			// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x0000B964 File Offset: 0x00009B64
			public unsafe EventHandler handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass28_0.NativeFieldInfoPtr_handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass28_0.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000642 RID: 1602
			// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x0008C21C File Offset: 0x0008A41C
			// (set) Token: 0x06001FC9 RID: 8137 RVA: 0x0000B983 File Offset: 0x00009B83
			public unsafe DelegateQueue __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000643 RID: 1603
			// (get) Token: 0x06001FCA RID: 8138 RVA: 0x0008C24C File Offset: 0x0008A44C
			// (set) Token: 0x06001FCB RID: 8139 RVA: 0x0000B9A2 File Offset: 0x00009BA2
			public unsafe EventArgs e
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass28_0.NativeFieldInfoPtr_e);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateQueue.__c__DisplayClass28_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FFC RID: 8188
			private static readonly IntPtr NativeFieldInfoPtr_handler;

			// Token: 0x04001FFD RID: 8189
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001FFE RID: 8190
			private static readonly IntPtr NativeFieldInfoPtr_e;

			// Token: 0x04001FFF RID: 8191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002000 RID: 8192
			private static readonly IntPtr NativeMethodInfoPtr__OnDisposed_b__0_Internal_Void_Object_0;
		}
	}
}
