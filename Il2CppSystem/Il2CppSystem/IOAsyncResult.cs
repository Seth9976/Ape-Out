using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x02000041 RID: 65
	public class IOAsyncResult : Object
	{
		// Token: 0x060003BE RID: 958 RVA: 0x0001FAE0 File Offset: 0x0001DCE0
		// Note: this type is marked as 'beforefieldinit'.
		static IOAsyncResult()
		{
			Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IOAsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr);
			IOAsyncResult.NativeFieldInfoPtr_async_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, "async_callback");
			IOAsyncResult.NativeFieldInfoPtr_async_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, "async_state");
			IOAsyncResult.NativeFieldInfoPtr_wait_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, "wait_handle");
			IOAsyncResult.NativeFieldInfoPtr_completed_synchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, "completed_synchronously");
			IOAsyncResult.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, "completed");
			IOAsyncResult.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100663967);
			IOAsyncResult.NativeMethodInfoPtr_Init_Protected_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100663968);
			IOAsyncResult.NativeMethodInfoPtr__ctor_Protected_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100663969);
			IOAsyncResult.NativeMethodInfoPtr_get_AsyncCallback_Public_get_AsyncCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100663970);
			IOAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100663971);
			IOAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100663972);
			IOAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100663973);
			IOAsyncResult.NativeMethodInfoPtr_set_CompletedSynchronously_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100663974);
			IOAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100663975);
			IOAsyncResult.NativeMethodInfoPtr_set_IsCompleted_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100663976);
			IOAsyncResult.NativeMethodInfoPtr_CompleteDisposed_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100663977);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0001FC50 File Offset: 0x0001DE50
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOAsyncResult()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0001FC8C File Offset: 0x0001DE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369180, XrefRangeEnd = 369181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(AsyncCallback async_callback, Object async_state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(async_callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(async_state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr_Init_Protected_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0001FCE0 File Offset: 0x0001DEE0
		[CallerCount(76)]
		[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOAsyncResult(AsyncCallback async_callback, Object async_state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(async_callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(async_state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr__ctor_Protected_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x0001FD40 File Offset: 0x0001DF40
		public unsafe AsyncCallback AsyncCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr_get_AsyncCallback_Public_get_AsyncCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr3) : null;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0001FD80 File Offset: 0x0001DF80
		public unsafe virtual Object AsyncState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x0001FDC0 File Offset: 0x0001DFC0
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 369188, RefRangeEnd = 369202, XrefRangeStart = 369181, XrefRangeEnd = 369188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0001FE00 File Offset: 0x0001E000
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x0001FE3C File Offset: 0x0001E03C
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr_set_CompletedSynchronously_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0001FE7C File Offset: 0x0001E07C
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x0001FEB8 File Offset: 0x0001E0B8
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 369206, RefRangeEnd = 369207, XrefRangeStart = 369202, XrefRangeEnd = 369206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr_set_IsCompleted_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0001FEF8 File Offset: 0x0001E0F8
		[CallerCount(0)]
		public unsafe virtual void CompleteDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOAsyncResult.NativeMethodInfoPtr_CompleteDisposed_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000345F File Offset: 0x0000165F
		public IOAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0001FF34 File Offset: 0x0001E134
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00003468 File Offset: 0x00001668
		public unsafe AsyncCallback async_callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_async_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_async_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0001FF64 File Offset: 0x0001E164
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00003487 File Offset: 0x00001687
		public unsafe Object async_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_async_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_async_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0001FF94 File Offset: 0x0001E194
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x000034A6 File Offset: 0x000016A6
		public unsafe ManualResetEvent wait_handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_wait_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_wait_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0001FFC4 File Offset: 0x0001E1C4
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x000034C5 File Offset: 0x000016C5
		public unsafe bool completed_synchronously
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_completed_synchronously);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_completed_synchronously)) = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0001FFEC File Offset: 0x0001E1EC
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x000034E0 File Offset: 0x000016E0
		public unsafe bool completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_completed)) = value;
			}
		}

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeFieldInfoPtr_async_callback;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeFieldInfoPtr_async_state;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeFieldInfoPtr_wait_handle;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeFieldInfoPtr_completed_synchronously;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeFieldInfoPtr_completed;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Void_AsyncCallback_Object_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_AsyncCallback_Object_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncCallback_Public_get_AsyncCallback_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_set_CompletedSynchronously_Protected_set_Void_Boolean_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCompleted_Protected_set_Void_Boolean_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_CompleteDisposed_Internal_Abstract_Virtual_New_Void_0;
	}
}
